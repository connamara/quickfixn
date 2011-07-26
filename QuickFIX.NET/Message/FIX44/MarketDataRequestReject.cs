using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class MarketDataRequestReject : Message
        {
            public MarketDataRequestReject() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("Y"));
            }

            public MarketDataRequestReject(
                    QuickFix.Fields.MDReqID aMDReqID
                ) : this()
            {
                this.mDReqID = aMDReqID;
            }

            public QuickFix.Fields.MDReqID mDReqID
            { 
                get 
                {
                    QuickFix.Fields.MDReqID val = new QuickFix.Fields.MDReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MDReqID val) 
            { 
                this.mDReqID = val;
            }
            
            public QuickFix.Fields.MDReqID get(QuickFix.Fields.MDReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MDReqID val) 
            { 
                return isSetMDReqID();
            }
            
            public bool isSetMDReqID() 
            { 
                return isSetField(Tags.MDReqID);
            }
            public QuickFix.Fields.MDReqRejReason mDReqRejReason
            { 
                get 
                {
                    QuickFix.Fields.MDReqRejReason val = new QuickFix.Fields.MDReqRejReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MDReqRejReason val) 
            { 
                this.mDReqRejReason = val;
            }
            
            public QuickFix.Fields.MDReqRejReason get(QuickFix.Fields.MDReqRejReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MDReqRejReason val) 
            { 
                return isSetMDReqRejReason();
            }
            
            public bool isSetMDReqRejReason() 
            { 
                return isSetField(Tags.MDReqRejReason);
            }
            public QuickFix.Fields.NoAltMDSource noAltMDSource
            { 
                get 
                {
                    QuickFix.Fields.NoAltMDSource val = new QuickFix.Fields.NoAltMDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoAltMDSource val) 
            { 
                this.noAltMDSource = val;
            }
            
            public QuickFix.Fields.NoAltMDSource get(QuickFix.Fields.NoAltMDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoAltMDSource val) 
            { 
                return isSetNoAltMDSource();
            }
            
            public bool isSetNoAltMDSource() 
            { 
                return isSetField(Tags.NoAltMDSource);
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
            public class NoAltMDSource : Group
            {
                public NoAltMDSource() 
                  :base( Tags.NoAltMDSource, Tags.AltMDSourceID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.AltMDSourceID, 0};
                            public QuickFix.Fields.AltMDSourceID altMDSourceID
                { 
                    get 
                    {
                        QuickFix.Fields.AltMDSourceID val = new QuickFix.Fields.AltMDSourceID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.AltMDSourceID val) 
                { 
                    this.altMDSourceID = val;
                }
                
                public QuickFix.Fields.AltMDSourceID get(QuickFix.Fields.AltMDSourceID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.AltMDSourceID val) 
                { 
                    return isSetAltMDSourceID();
                }
                
                public bool isSetAltMDSourceID() 
                { 
                    return isSetField(Tags.AltMDSourceID);
                }
            
            }
        }
    }
}
