// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class MarketDataRequest : Message
        {
            public const string MsgType = "V";

            public MarketDataRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("V"));
            }

            public MarketDataRequest(
                    QuickFix.Fields.MDReqID aMDReqID,
                    QuickFix.Fields.SubscriptionRequestType aSubscriptionRequestType,
                    QuickFix.Fields.MarketDepth aMarketDepth
                ) : this()
            {
                this.MDReqID = aMDReqID;
                this.SubscriptionRequestType = aSubscriptionRequestType;
                this.MarketDepth = aMarketDepth;
            }

            public QuickFix.Fields.MDReqID MDReqID
            {
                get
                {
                    QuickFix.Fields.MDReqID val = new QuickFix.Fields.MDReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MDReqID val)
            {
                this.MDReqID = val;
            }

            public QuickFix.Fields.MDReqID Get(QuickFix.Fields.MDReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MDReqID val)
            {
                return IsSetMDReqID();
            }

            public bool IsSetMDReqID()
            {
                return IsSetField(Tags.MDReqID);
            }

            public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
            {
                get
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SubscriptionRequestType val)
            {
                this.SubscriptionRequestType = val;
            }

            public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SubscriptionRequestType val)
            {
                return IsSetSubscriptionRequestType();
            }

            public bool IsSetSubscriptionRequestType()
            {
                return IsSetField(Tags.SubscriptionRequestType);
            }

            public QuickFix.Fields.MarketDepth MarketDepth
            {
                get
                {
                    QuickFix.Fields.MarketDepth val = new QuickFix.Fields.MarketDepth();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketDepth val)
            {
                this.MarketDepth = val;
            }

            public QuickFix.Fields.MarketDepth Get(QuickFix.Fields.MarketDepth val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketDepth val)
            {
                return IsSetMarketDepth();
            }

            public bool IsSetMarketDepth()
            {
                return IsSetField(Tags.MarketDepth);
            }

            public QuickFix.Fields.MDUpdateType MDUpdateType
            {
                get
                {
                    QuickFix.Fields.MDUpdateType val = new QuickFix.Fields.MDUpdateType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MDUpdateType val)
            {
                this.MDUpdateType = val;
            }

            public QuickFix.Fields.MDUpdateType Get(QuickFix.Fields.MDUpdateType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MDUpdateType val)
            {
                return IsSetMDUpdateType();
            }

            public bool IsSetMDUpdateType()
            {
                return IsSetField(Tags.MDUpdateType);
            }

            public QuickFix.Fields.NoMDEntryTypes NoMDEntryTypes
            {
                get
                {
                    QuickFix.Fields.NoMDEntryTypes val = new QuickFix.Fields.NoMDEntryTypes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoMDEntryTypes val)
            {
                this.NoMDEntryTypes = val;
            }

            public QuickFix.Fields.NoMDEntryTypes Get(QuickFix.Fields.NoMDEntryTypes val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoMDEntryTypes val)
            {
                return IsSetNoMDEntryTypes();
            }

            public bool IsSetNoMDEntryTypes()
            {
                return IsSetField(Tags.NoMDEntryTypes);
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

            public class NoMDEntryTypesGroup : Group
            {
                public static int[] fieldOrder = {Tags.MDEntryType, 0};

                public NoMDEntryTypesGroup()
                  : base(Tags.NoMDEntryTypes, Tags.MDEntryType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMDEntryTypesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.MDEntryType MDEntryType
                {
                    get
                    {
                        QuickFix.Fields.MDEntryType val = new QuickFix.Fields.MDEntryType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.MDEntryType val)
                {
                    this.MDEntryType = val;
                }

                public QuickFix.Fields.MDEntryType Get(QuickFix.Fields.MDEntryType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.MDEntryType val)
                {
                    return IsSetMDEntryType();
                }

                public bool IsSetMDEntryType()
                {
                    return IsSetField(Tags.MDEntryType);
                }


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
