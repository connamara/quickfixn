// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class SecurityList : Message
        {
            public const string MsgType = "y";

            public SecurityList() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("y"));
            }


            public QuickFix.Fields.SecurityReqID SecurityReqID
            {
                get
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityReqID val)
            {
                this.SecurityReqID = val;
            }

            public QuickFix.Fields.SecurityReqID Get(QuickFix.Fields.SecurityReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityReqID val)
            {
                return IsSetSecurityReqID();
            }

            public bool IsSetSecurityReqID()
            {
                return IsSetField(Tags.SecurityReqID);
            }

            public QuickFix.Fields.SecurityResponseID SecurityResponseID
            {
                get
                {
                    QuickFix.Fields.SecurityResponseID val = new QuickFix.Fields.SecurityResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityResponseID val)
            {
                this.SecurityResponseID = val;
            }

            public QuickFix.Fields.SecurityResponseID Get(QuickFix.Fields.SecurityResponseID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityResponseID val)
            {
                return IsSetSecurityResponseID();
            }

            public bool IsSetSecurityResponseID()
            {
                return IsSetField(Tags.SecurityResponseID);
            }

            public QuickFix.Fields.TotNoRelatedSym TotNoRelatedSym
            {
                get
                {
                    QuickFix.Fields.TotNoRelatedSym val = new QuickFix.Fields.TotNoRelatedSym();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TotNoRelatedSym val)
            {
                this.TotNoRelatedSym = val;
            }

            public QuickFix.Fields.TotNoRelatedSym Get(QuickFix.Fields.TotNoRelatedSym val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TotNoRelatedSym val)
            {
                return IsSetTotNoRelatedSym();
            }

            public bool IsSetTotNoRelatedSym()
            {
                return IsSetField(Tags.TotNoRelatedSym);
            }

            public QuickFix.Fields.LastFragment LastFragment
            {
                get
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.LastFragment val)
            {
                this.LastFragment = val;
            }

            public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.LastFragment val)
            {
                return IsSetLastFragment();
            }

            public bool IsSetLastFragment()
            {
                return IsSetField(Tags.LastFragment);
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

            public QuickFix.Fields.SecurityRequestResult SecurityRequestResult
            {
                get
                {
                    QuickFix.Fields.SecurityRequestResult val = new QuickFix.Fields.SecurityRequestResult();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityRequestResult val)
            {
                this.SecurityRequestResult = val;
            }

            public QuickFix.Fields.SecurityRequestResult Get(QuickFix.Fields.SecurityRequestResult val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityRequestResult val)
            {
                return IsSetSecurityRequestResult();
            }

            public bool IsSetSecurityRequestResult()
            {
                return IsSetField(Tags.SecurityRequestResult);
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
        }
    }
}
