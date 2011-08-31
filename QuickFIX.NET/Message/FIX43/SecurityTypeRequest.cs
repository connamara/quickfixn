// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class SecurityTypeRequest : Message
        {
            public const string MsgType = "v";

            public SecurityTypeRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("v"));
            }

            public SecurityTypeRequest(
                    QuickFix.Fields.SecurityReqID aSecurityReqID
                ) : this()
            {
                this.securityReqID = aSecurityReqID;
            }

            public QuickFix.Fields.SecurityReqID securityReqID
            { 
                get 
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityReqID val) 
            { 
                this.securityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID get(QuickFix.Fields.SecurityReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return isSetSecurityReqID();
            }
            
            public bool isSetSecurityReqID() 
            { 
                return isSetField(Tags.SecurityReqID);
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
            public QuickFix.Fields.TradingSessionID tradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionID val) 
            { 
                this.tradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID get(QuickFix.Fields.TradingSessionID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return isSetTradingSessionID();
            }
            
            public bool isSetTradingSessionID() 
            { 
                return isSetField(Tags.TradingSessionID);
            }
            public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionSubID val) 
            { 
                this.tradingSessionSubID = val;
            }
            
            public QuickFix.Fields.TradingSessionSubID get(QuickFix.Fields.TradingSessionSubID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionSubID val) 
            { 
                return isSetTradingSessionSubID();
            }
            
            public bool isSetTradingSessionSubID() 
            { 
                return isSetField(Tags.TradingSessionSubID);
            }

        }
    }
}
