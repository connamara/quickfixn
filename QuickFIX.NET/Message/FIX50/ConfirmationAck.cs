// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class ConfirmationAck : Message
        {
            public const string MsgType = "AU";

            public ConfirmationAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("AU"));
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
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ConfirmID val) 
            { 
                this.confirmID = val;
            }
            
            public QuickFix.Fields.ConfirmID Get(QuickFix.Fields.ConfirmID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ConfirmID val) 
            { 
                return IsSetConfirmID();
            }
            
            public bool IsSetConfirmID() 
            { 
                return IsSetField(Tags.ConfirmID);
            }
            public QuickFix.Fields.TradeDate tradeDate
            { 
                get 
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TradeDate val) 
            { 
                this.tradeDate = val;
            }
            
            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TradeDate val) 
            { 
                return IsSetTradeDate();
            }
            
            public bool IsSetTradeDate() 
            { 
                return IsSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.TransactTime transactTime
            { 
                get 
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TransactTime val) 
            { 
                this.transactTime = val;
            }
            
            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TransactTime val) 
            { 
                return IsSetTransactTime();
            }
            
            public bool IsSetTransactTime() 
            { 
                return IsSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.AffirmStatus affirmStatus
            { 
                get 
                {
                    QuickFix.Fields.AffirmStatus val = new QuickFix.Fields.AffirmStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.AffirmStatus val) 
            { 
                this.affirmStatus = val;
            }
            
            public QuickFix.Fields.AffirmStatus Get(QuickFix.Fields.AffirmStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.AffirmStatus val) 
            { 
                return IsSetAffirmStatus();
            }
            
            public bool IsSetAffirmStatus() 
            { 
                return IsSetField(Tags.AffirmStatus);
            }
            public QuickFix.Fields.ConfirmRejReason confirmRejReason
            { 
                get 
                {
                    QuickFix.Fields.ConfirmRejReason val = new QuickFix.Fields.ConfirmRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ConfirmRejReason val) 
            { 
                this.confirmRejReason = val;
            }
            
            public QuickFix.Fields.ConfirmRejReason Get(QuickFix.Fields.ConfirmRejReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ConfirmRejReason val) 
            { 
                return IsSetConfirmRejReason();
            }
            
            public bool IsSetConfirmRejReason() 
            { 
                return IsSetField(Tags.ConfirmRejReason);
            }
            public QuickFix.Fields.MatchStatus matchStatus
            { 
                get 
                {
                    QuickFix.Fields.MatchStatus val = new QuickFix.Fields.MatchStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MatchStatus val) 
            { 
                this.matchStatus = val;
            }
            
            public QuickFix.Fields.MatchStatus Get(QuickFix.Fields.MatchStatus val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MatchStatus val) 
            { 
                return IsSetMatchStatus();
            }
            
            public bool IsSetMatchStatus() 
            { 
                return IsSetField(Tags.MatchStatus);
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

        }
    }
}
