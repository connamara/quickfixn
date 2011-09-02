// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class ApplicationMessageReport : Message
        {
            public const string MsgType = "BY";

            public ApplicationMessageReport() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BY"));
            }

            public ApplicationMessageReport(
                    QuickFix.Fields.ApplReportID aApplReportID,
                    QuickFix.Fields.ApplReportType aApplReportType
                ) : this()
            {
                this.applReportID = aApplReportID;
                this.applReportType = aApplReportType;
            }

            public QuickFix.Fields.ApplReportID applReportID
            { 
                get 
                {
                    QuickFix.Fields.ApplReportID val = new QuickFix.Fields.ApplReportID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplReportID val) 
            { 
                this.applReportID = val;
            }
            
            public QuickFix.Fields.ApplReportID get(QuickFix.Fields.ApplReportID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplReportID val) 
            { 
                return isSetApplReportID();
            }
            
            public bool isSetApplReportID() 
            { 
                return isSetField(Tags.ApplReportID);
            }
            public QuickFix.Fields.ApplReportType applReportType
            { 
                get 
                {
                    QuickFix.Fields.ApplReportType val = new QuickFix.Fields.ApplReportType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplReportType val) 
            { 
                this.applReportType = val;
            }
            
            public QuickFix.Fields.ApplReportType get(QuickFix.Fields.ApplReportType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplReportType val) 
            { 
                return isSetApplReportType();
            }
            
            public bool isSetApplReportType() 
            { 
                return isSetField(Tags.ApplReportType);
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
            public class NoApplIDs : Group
            {
                public NoApplIDs() 
                  :base( Tags.NoApplIDs, Tags.RefApplID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RefApplID, Tags.ApplNewSeqNum, Tags.RefApplLastSeqNum, 0};
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
                public QuickFix.Fields.ApplNewSeqNum applNewSeqNum
                { 
                    get 
                    {
                        QuickFix.Fields.ApplNewSeqNum val = new QuickFix.Fields.ApplNewSeqNum();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ApplNewSeqNum val) 
                { 
                    this.applNewSeqNum = val;
                }
                
                public QuickFix.Fields.ApplNewSeqNum get(QuickFix.Fields.ApplNewSeqNum val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ApplNewSeqNum val) 
                { 
                    return isSetApplNewSeqNum();
                }
                
                public bool isSetApplNewSeqNum() 
                { 
                    return isSetField(Tags.ApplNewSeqNum);
                }
                public QuickFix.Fields.RefApplLastSeqNum refApplLastSeqNum
                { 
                    get 
                    {
                        QuickFix.Fields.RefApplLastSeqNum val = new QuickFix.Fields.RefApplLastSeqNum();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RefApplLastSeqNum val) 
                { 
                    this.refApplLastSeqNum = val;
                }
                
                public QuickFix.Fields.RefApplLastSeqNum get(QuickFix.Fields.RefApplLastSeqNum val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RefApplLastSeqNum val) 
                { 
                    return isSetRefApplLastSeqNum();
                }
                
                public bool isSetRefApplLastSeqNum() 
                { 
                    return isSetField(Tags.RefApplLastSeqNum);
                }
            
            }
        }
    }
}
