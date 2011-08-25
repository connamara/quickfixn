// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class ConfirmationAck : Message
        {
            public ConfirmationAck() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("AU"));
            }

            public ConfirmationAck(
                    QuickFix.Fields.ConfirmID aConfirmID,
                    QuickFix.Fields.TradeDate aTradeDate,
                    QuickFix.Fields.TransactTime aTransactTime,
                    QuickFix.Fields.AffirmStatus aAffirmStatus
                ) : this()
            {
                this.confirmID = aConfirmID;
                this.tradeDate = aTradeDate;
                this.transactTime = aTransactTime;
                this.affirmStatus = aAffirmStatus;
            }

            public QuickFix.Fields.ConfirmID confirmID
            { 
                get 
                {
                    QuickFix.Fields.ConfirmID val = new QuickFix.Fields.ConfirmID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ConfirmID val) 
            { 
                this.confirmID = val;
            }
            
            public QuickFix.Fields.ConfirmID get(QuickFix.Fields.ConfirmID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ConfirmID val) 
            { 
                return isSetConfirmID();
            }
            
            public bool isSetConfirmID() 
            { 
                return isSetField(Tags.ConfirmID);
            }
            public QuickFix.Fields.TradeDate tradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradeDate val) 
            { 
                this.tradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate get(QuickFix.Fields.TradeDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradeDate val) 
            { 
                return isSetTradeDate();
            }
            
            public bool isSetTradeDate() 
            { 
                return isSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.TransactTime transactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TransactTime val) 
            { 
                this.transactTime = val;
            }
            
            public QuickFix.Fields.TransactTime get(QuickFix.Fields.TransactTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TransactTime val) 
            { 
                return isSetTransactTime();
            }
            
            public bool isSetTransactTime() 
            { 
                return isSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.AffirmStatus affirmStatus
            { 
                get 
                {
                    QuickFix.Fields.AffirmStatus val = new QuickFix.Fields.AffirmStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AffirmStatus val) 
            { 
                this.affirmStatus = val;
            }
            
            public QuickFix.Fields.AffirmStatus get(QuickFix.Fields.AffirmStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AffirmStatus val) 
            { 
                return isSetAffirmStatus();
            }
            
            public bool isSetAffirmStatus() 
            { 
                return isSetField(Tags.AffirmStatus);
            }
            public QuickFix.Fields.ConfirmRejReason confirmRejReason
            { 
                get 
                {
                    QuickFix.Fields.ConfirmRejReason val = new QuickFix.Fields.ConfirmRejReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ConfirmRejReason val) 
            { 
                this.confirmRejReason = val;
            }
            
            public QuickFix.Fields.ConfirmRejReason get(QuickFix.Fields.ConfirmRejReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ConfirmRejReason val) 
            { 
                return isSetConfirmRejReason();
            }
            
            public bool isSetConfirmRejReason() 
            { 
                return isSetField(Tags.ConfirmRejReason);
            }
            public QuickFix.Fields.MatchStatus matchStatus
            { 
                get 
                {
                    QuickFix.Fields.MatchStatus val = new QuickFix.Fields.MatchStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.MatchStatus val) 
            { 
                this.matchStatus = val;
            }
            
            public QuickFix.Fields.MatchStatus get(QuickFix.Fields.MatchStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.MatchStatus val) 
            { 
                return isSetMatchStatus();
            }
            
            public bool isSetMatchStatus() 
            { 
                return isSetField(Tags.MatchStatus);
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

        }
    }
}
