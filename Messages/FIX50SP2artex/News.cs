// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class News : Message
        {
            public const string MsgType = "B";

            public News() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("B"));
            }

            public News(
                    QuickFix.Fields.Headline aHeadline
                ) : this()
            {
                this.Headline = aHeadline;
            }

            public QuickFix.Fields.OrigTime OrigTime
            {
                get
                {
                    QuickFix.Fields.OrigTime val = new QuickFix.Fields.OrigTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrigTime val)
            {
                this.OrigTime = val;
            }

            public QuickFix.Fields.OrigTime Get(QuickFix.Fields.OrigTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrigTime val)
            {
                return IsSetOrigTime();
            }

            public bool IsSetOrigTime()
            {
                return IsSetField(Tags.OrigTime);
            }

            public QuickFix.Fields.Urgency Urgency
            {
                get
                {
                    QuickFix.Fields.Urgency val = new QuickFix.Fields.Urgency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Urgency val)
            {
                this.Urgency = val;
            }

            public QuickFix.Fields.Urgency Get(QuickFix.Fields.Urgency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Urgency val)
            {
                return IsSetUrgency();
            }

            public bool IsSetUrgency()
            {
                return IsSetField(Tags.Urgency);
            }

            public QuickFix.Fields.Headline Headline
            {
                get
                {
                    QuickFix.Fields.Headline val = new QuickFix.Fields.Headline();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Headline val)
            {
                this.Headline = val;
            }

            public QuickFix.Fields.Headline Get(QuickFix.Fields.Headline val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Headline val)
            {
                return IsSetHeadline();
            }

            public bool IsSetHeadline()
            {
                return IsSetField(Tags.Headline);
            }

            public QuickFix.Fields.NoRelatedSym NoRelatedSym
            {
                get
                {
                    QuickFix.Fields.NoRelatedSym val = new QuickFix.Fields.NoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoRelatedSym val)
            {
                this.NoRelatedSym = val;
            }

            public QuickFix.Fields.NoRelatedSym Get(QuickFix.Fields.NoRelatedSym val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoRelatedSym val)
            {
                return IsSetNoRelatedSym();
            }

            public bool IsSetNoRelatedSym()
            {
                return IsSetField(Tags.NoRelatedSym);
            }

            public QuickFix.Fields.NoLinesOfText NoLinesOfText
            {
                get
                {
                    QuickFix.Fields.NoLinesOfText val = new QuickFix.Fields.NoLinesOfText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoLinesOfText val)
            {
                this.NoLinesOfText = val;
            }

            public QuickFix.Fields.NoLinesOfText Get(QuickFix.Fields.NoLinesOfText val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoLinesOfText val)
            {
                return IsSetNoLinesOfText();
            }

            public bool IsSetNoLinesOfText()
            {
                return IsSetField(Tags.NoLinesOfText);
            }

            public QuickFix.Fields.URLLink URLLink
            {
                get
                {
                    QuickFix.Fields.URLLink val = new QuickFix.Fields.URLLink();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.URLLink val)
            {
                this.URLLink = val;
            }

            public QuickFix.Fields.URLLink Get(QuickFix.Fields.URLLink val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.URLLink val)
            {
                return IsSetURLLink();
            }

            public bool IsSetURLLink()
            {
                return IsSetField(Tags.URLLink);
            }

            public QuickFix.Fields.MarketID MarketID
            {
                get
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketID val)
            {
                this.MarketID = val;
            }

            public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketID val)
            {
                return IsSetMarketID();
            }

            public bool IsSetMarketID()
            {
                return IsSetField(Tags.MarketID);
            }

            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {Tags.Symbol, Tags.SecurityID, Tags.SecurityIDSource, Tags.Currency, 0};

                public NoRelatedSymGroup()
                  : base(Tags.NoRelatedSym, Tags.Symbol, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRelatedSymGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.Symbol Symbol
                {
                    get
                    {
                        QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Symbol val)
                {
                    this.Symbol = val;
                }

                public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Symbol val)
                {
                    return IsSetSymbol();
                }

                public bool IsSetSymbol()
                {
                    return IsSetField(Tags.Symbol);
                }

                public QuickFix.Fields.SecurityID SecurityID
                {
                    get
                    {
                        QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityID val)
                {
                    this.SecurityID = val;
                }

                public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityID val)
                {
                    return IsSetSecurityID();
                }

                public bool IsSetSecurityID()
                {
                    return IsSetField(Tags.SecurityID);
                }

                public QuickFix.Fields.SecurityIDSource SecurityIDSource
                {
                    get
                    {
                        QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityIDSource val)
                {
                    this.SecurityIDSource = val;
                }

                public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityIDSource val)
                {
                    return IsSetSecurityIDSource();
                }

                public bool IsSetSecurityIDSource()
                {
                    return IsSetField(Tags.SecurityIDSource);
                }

                public QuickFix.Fields.Currency Currency
                {
                    get
                    {
                        QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Currency val)
                {
                    this.Currency = val;
                }

                public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Currency val)
                {
                    return IsSetCurrency();
                }

                public bool IsSetCurrency()
                {
                    return IsSetField(Tags.Currency);
                }


            }
            public class NoLinesOfTextGroup : Group
            {
                public static int[] fieldOrder = {Tags.Text, 0};

                public NoLinesOfTextGroup()
                  : base(Tags.NoLinesOfText, Tags.Text, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoLinesOfTextGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
}
