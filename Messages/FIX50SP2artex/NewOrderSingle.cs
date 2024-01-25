// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class NewOrderSingle : Message
        {
            public const string MsgType = "D";

            public NewOrderSingle() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("D"));
            }

            public NewOrderSingle(
                    QuickFix.Fields.ClOrdID aClOrdID,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.TransactTime aTransactTime,
                    QuickFix.Fields.OrdType aOrdType
                ) : this()
            {
                this.ClOrdID = aClOrdID;
                this.Side = aSide;
                this.TransactTime = aTransactTime;
                this.OrdType = aOrdType;
            }

            public QuickFix.Fields.ClOrdID ClOrdID
            {
                get
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ClOrdID val)
            {
                this.ClOrdID = val;
            }

            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ClOrdID val)
            {
                return IsSetClOrdID();
            }

            public bool IsSetClOrdID()
            {
                return IsSetField(Tags.ClOrdID);
            }

            public QuickFix.Fields.NoPartyIDs NoPartyIDs
            {
                get
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPartyIDs val)
            {
                this.NoPartyIDs = val;
            }

            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPartyIDs val)
            {
                return IsSetNoPartyIDs();
            }

            public bool IsSetNoPartyIDs()
            {
                return IsSetField(Tags.NoPartyIDs);
            }

            public QuickFix.Fields.Account Account
            {
                get
                {
                    QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Account val)
            {
                this.Account = val;
            }

            public QuickFix.Fields.Account Get(QuickFix.Fields.Account val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Account val)
            {
                return IsSetAccount();
            }

            public bool IsSetAccount()
            {
                return IsSetField(Tags.Account);
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

            public QuickFix.Fields.Side Side
            {
                get
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Side val)
            {
                this.Side = val;
            }

            public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Side val)
            {
                return IsSetSide();
            }

            public bool IsSetSide()
            {
                return IsSetField(Tags.Side);
            }

            public QuickFix.Fields.TransactTime TransactTime
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
                this.TransactTime = val;
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

            public QuickFix.Fields.OrderQty OrderQty
            {
                get
                {
                    QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrderQty val)
            {
                this.OrderQty = val;
            }

            public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrderQty val)
            {
                return IsSetOrderQty();
            }

            public bool IsSetOrderQty()
            {
                return IsSetField(Tags.OrderQty);
            }

            public QuickFix.Fields.OrdType OrdType
            {
                get
                {
                    QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrdType val)
            {
                this.OrdType = val;
            }

            public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrdType val)
            {
                return IsSetOrdType();
            }

            public bool IsSetOrdType()
            {
                return IsSetField(Tags.OrdType);
            }

            public QuickFix.Fields.Price Price
            {
                get
                {
                    QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Price val)
            {
                this.Price = val;
            }

            public QuickFix.Fields.Price Get(QuickFix.Fields.Price val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Price val)
            {
                return IsSetPrice();
            }

            public bool IsSetPrice()
            {
                return IsSetField(Tags.Price);
            }

            public QuickFix.Fields.QuoteID QuoteID
            {
                get
                {
                    QuickFix.Fields.QuoteID val = new QuickFix.Fields.QuoteID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteID val)
            {
                this.QuoteID = val;
            }

            public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteID val)
            {
                return IsSetQuoteID();
            }

            public bool IsSetQuoteID()
            {
                return IsSetField(Tags.QuoteID);
            }

            public QuickFix.Fields.TimeInForce TimeInForce
            {
                get
                {
                    QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TimeInForce val)
            {
                this.TimeInForce = val;
            }

            public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TimeInForce val)
            {
                return IsSetTimeInForce();
            }

            public bool IsSetTimeInForce()
            {
                return IsSetField(Tags.TimeInForce);
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

            public QuickFix.Fields.OrderOrigination OrderOrigination
            {
                get
                {
                    QuickFix.Fields.OrderOrigination val = new QuickFix.Fields.OrderOrigination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrderOrigination val)
            {
                this.OrderOrigination = val;
            }

            public QuickFix.Fields.OrderOrigination Get(QuickFix.Fields.OrderOrigination val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrderOrigination val)
            {
                return IsSetOrderOrigination();
            }

            public bool IsSetOrderOrigination()
            {
                return IsSetField(Tags.OrderOrigination);
            }

            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, Tags.PartyRoleQualifier, 0};

                public NoPartyIDsGroup()
                  : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.PartyID PartyID
                {
                    get
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyID val)
                {
                    this.PartyID = val;
                }

                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyID val)
                {
                    return IsSetPartyID();
                }

                public bool IsSetPartyID()
                {
                    return IsSetField(Tags.PartyID);
                }

                public QuickFix.Fields.PartyIDSource PartyIDSource
                {
                    get
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyIDSource val)
                {
                    this.PartyIDSource = val;
                }

                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyIDSource val)
                {
                    return IsSetPartyIDSource();
                }

                public bool IsSetPartyIDSource()
                {
                    return IsSetField(Tags.PartyIDSource);
                }

                public QuickFix.Fields.PartyRole PartyRole
                {
                    get
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyRole val)
                {
                    this.PartyRole = val;
                }

                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyRole val)
                {
                    return IsSetPartyRole();
                }

                public bool IsSetPartyRole()
                {
                    return IsSetField(Tags.PartyRole);
                }

                public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoPartySubIDs val)
                {
                    this.NoPartySubIDs = val;
                }

                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoPartySubIDs val)
                {
                    return IsSetNoPartySubIDs();
                }

                public bool IsSetNoPartySubIDs()
                {
                    return IsSetField(Tags.NoPartySubIDs);
                }

                public QuickFix.Fields.PartyRoleQualifier PartyRoleQualifier
                {
                    get
                    {
                        QuickFix.Fields.PartyRoleQualifier val = new QuickFix.Fields.PartyRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyRoleQualifier val)
                {
                    this.PartyRoleQualifier = val;
                }

                public QuickFix.Fields.PartyRoleQualifier Get(QuickFix.Fields.PartyRoleQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyRoleQualifier val)
                {
                    return IsSetPartyRoleQualifier();
                }

                public bool IsSetPartyRoleQualifier()
                {
                    return IsSetField(Tags.PartyRoleQualifier);
                }

                public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

                    public NoPartySubIDsGroup()
                      : base(Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.PartySubID PartySubID
                    {
                        get
                        {
                            QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartySubID val)
                    {
                        this.PartySubID = val;
                    }

                    public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartySubID val)
                    {
                        return IsSetPartySubID();
                    }

                    public bool IsSetPartySubID()
                    {
                        return IsSetField(Tags.PartySubID);
                    }

                    public QuickFix.Fields.PartySubIDType PartySubIDType
                    {
                        get
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartySubIDType val)
                    {
                        this.PartySubIDType = val;
                    }

                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartySubIDType val)
                    {
                        return IsSetPartySubIDType();
                    }

                    public bool IsSetPartySubIDType()
                    {
                        return IsSetField(Tags.PartySubIDType);
                    }


                }
            }
        }
    }
}
