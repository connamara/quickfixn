// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX40 
    {
        public class News : Message
        {
            public const string MsgType = "B";

            public News() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("B"));
            }


            public QuickFix.Fields.OrigTime origTime
            { 
                get 
                {
                    QuickFix.Fields.OrigTime val = new QuickFix.Fields.OrigTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigTime val) 
            { 
                this.origTime = val;
            }
            
            public QuickFix.Fields.OrigTime get(QuickFix.Fields.OrigTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigTime val) 
            { 
                return isSetOrigTime();
            }
            
            public bool isSetOrigTime() 
            { 
                return isSetField(Tags.OrigTime);
            }
            public QuickFix.Fields.Urgency urgency
            { 
                get 
                {
                    QuickFix.Fields.Urgency val = new QuickFix.Fields.Urgency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Urgency val) 
            { 
                this.urgency = val;
            }
            
            public QuickFix.Fields.Urgency get(QuickFix.Fields.Urgency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Urgency val) 
            { 
                return isSetUrgency();
            }
            
            public bool isSetUrgency() 
            { 
                return isSetField(Tags.Urgency);
            }
            public QuickFix.Fields.RelatdSym relatdSym
            { 
                get 
                {
                    QuickFix.Fields.RelatdSym val = new QuickFix.Fields.RelatdSym();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RelatdSym val) 
            { 
                this.relatdSym = val;
            }
            
            public QuickFix.Fields.RelatdSym get(QuickFix.Fields.RelatdSym val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RelatdSym val) 
            { 
                return isSetRelatdSym();
            }
            
            public bool isSetRelatdSym() 
            { 
                return isSetField(Tags.RelatdSym);
            }
            public QuickFix.Fields.LinesOfText linesOfText
            { 
                get 
                {
                    QuickFix.Fields.LinesOfText val = new QuickFix.Fields.LinesOfText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LinesOfText val) 
            { 
                this.linesOfText = val;
            }
            
            public QuickFix.Fields.LinesOfText get(QuickFix.Fields.LinesOfText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LinesOfText val) 
            { 
                return isSetLinesOfText();
            }
            
            public bool isSetLinesOfText() 
            { 
                return isSetField(Tags.LinesOfText);
            }
            public QuickFix.Fields.RawDataLength rawDataLength
            { 
                get 
                {
                    QuickFix.Fields.RawDataLength val = new QuickFix.Fields.RawDataLength();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RawDataLength val) 
            { 
                this.rawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength get(QuickFix.Fields.RawDataLength val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RawDataLength val) 
            { 
                return isSetRawDataLength();
            }
            
            public bool isSetRawDataLength() 
            { 
                return isSetField(Tags.RawDataLength);
            }
            public QuickFix.Fields.RawData rawData
            { 
                get 
                {
                    QuickFix.Fields.RawData val = new QuickFix.Fields.RawData();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RawData val) 
            { 
                this.rawData = val;
            }
            
            public QuickFix.Fields.RawData get(QuickFix.Fields.RawData val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RawData val) 
            { 
                return isSetRawData();
            }
            
            public bool isSetRawData() 
            { 
                return isSetField(Tags.RawData);
            }
            public class LinesOfText : Group
            {
                public LinesOfText() 
                  :base( Tags.LinesOfText, Tags.Text, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Text, 0};
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
            
            }
        }
    }
}
