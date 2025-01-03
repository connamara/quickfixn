// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class RegistrationInstructions : Message
{
    public const string MsgType = "o";

    public RegistrationInstructions() : base()
    {
        Header.SetField(new MsgType("o"));
    }

    public RegistrationInstructions(
            RegistID aRegistID,
            RegistTransType aRegistTransType,
            RegistRefID aRegistRefID
        ) : this()
    {
        RegistID = aRegistID;
        RegistTransType = aRegistTransType;
        RegistRefID = aRegistRefID;
    }

    public RegistID RegistID
    {
        get
        {
            RegistID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistID val) { RegistID = val; }
    public RegistID Get(RegistID val) { GetField(val); return val; }
    public bool IsSet(RegistID val) { return IsSetRegistID(); }
    public bool IsSetRegistID() { return IsSetField(Tags.RegistID); }

    public RegistTransType RegistTransType
    {
        get
        {
            RegistTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistTransType val) { RegistTransType = val; }
    public RegistTransType Get(RegistTransType val) { GetField(val); return val; }
    public bool IsSet(RegistTransType val) { return IsSetRegistTransType(); }
    public bool IsSetRegistTransType() { return IsSetField(Tags.RegistTransType); }

    public RegistRefID RegistRefID
    {
        get
        {
            RegistRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistRefID val) { RegistRefID = val; }
    public RegistRefID Get(RegistRefID val) { GetField(val); return val; }
    public bool IsSet(RegistRefID val) { return IsSetRegistRefID(); }
    public bool IsSetRegistRefID() { return IsSetField(Tags.RegistRefID); }

    public ClOrdID ClOrdID
    {
        get
        {
            ClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdID val) { ClOrdID = val; }
    public ClOrdID Get(ClOrdID val) { GetField(val); return val; }
    public bool IsSet(ClOrdID val) { return IsSetClOrdID(); }
    public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

    public NoPartyIDs NoPartyIDs
    {
        get
        {
            NoPartyIDs val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoPartyIDs val) { NoPartyIDs = val; }
    public NoPartyIDs Get(NoPartyIDs val) { GetField(val); return val; }
    public bool IsSet(NoPartyIDs val) { return IsSetNoPartyIDs(); }
    public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }

    public Account Account
    {
        get
        {
            Account val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Account val) { Account = val; }
    public Account Get(Account val) { GetField(val); return val; }
    public bool IsSet(Account val) { return IsSetAccount(); }
    public bool IsSetAccount() { return IsSetField(Tags.Account); }

    public AcctIDSource AcctIDSource
    {
        get
        {
            AcctIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AcctIDSource val) { AcctIDSource = val; }
    public AcctIDSource Get(AcctIDSource val) { GetField(val); return val; }
    public bool IsSet(AcctIDSource val) { return IsSetAcctIDSource(); }
    public bool IsSetAcctIDSource() { return IsSetField(Tags.AcctIDSource); }

    public RegistAcctType RegistAcctType
    {
        get
        {
            RegistAcctType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(RegistAcctType val) { RegistAcctType = val; }
    public RegistAcctType Get(RegistAcctType val) { GetField(val); return val; }
    public bool IsSet(RegistAcctType val) { return IsSetRegistAcctType(); }
    public bool IsSetRegistAcctType() { return IsSetField(Tags.RegistAcctType); }

    public TaxAdvantageType TaxAdvantageType
    {
        get
        {
            TaxAdvantageType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TaxAdvantageType val) { TaxAdvantageType = val; }
    public TaxAdvantageType Get(TaxAdvantageType val) { GetField(val); return val; }
    public bool IsSet(TaxAdvantageType val) { return IsSetTaxAdvantageType(); }
    public bool IsSetTaxAdvantageType() { return IsSetField(Tags.TaxAdvantageType); }

    public OwnershipType OwnershipType
    {
        get
        {
            OwnershipType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OwnershipType val) { OwnershipType = val; }
    public OwnershipType Get(OwnershipType val) { GetField(val); return val; }
    public bool IsSet(OwnershipType val) { return IsSetOwnershipType(); }
    public bool IsSetOwnershipType() { return IsSetField(Tags.OwnershipType); }

    public NoRegistDtls NoRegistDtls
    {
        get
        {
            NoRegistDtls val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRegistDtls val) { NoRegistDtls = val; }
    public NoRegistDtls Get(NoRegistDtls val) { GetField(val); return val; }
    public bool IsSet(NoRegistDtls val) { return IsSetNoRegistDtls(); }
    public bool IsSetNoRegistDtls() { return IsSetField(Tags.NoRegistDtls); }

    public NoDistribInsts NoDistribInsts
    {
        get
        {
            NoDistribInsts val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoDistribInsts val) { NoDistribInsts = val; }
    public NoDistribInsts Get(NoDistribInsts val) { GetField(val); return val; }
    public bool IsSet(NoDistribInsts val) { return IsSetNoDistribInsts(); }
    public bool IsSetNoDistribInsts() { return IsSetField(Tags.NoDistribInsts); }

    public class NoPartyIDsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

        public NoPartyIDsGroup()
          : base(Tags.NoPartyIDs, Tags.PartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoPartyIDsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public PartyID PartyID
        {
            get
            {
                PartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyID val) { PartyID = val; }
        public PartyID Get(PartyID val) { GetField(val); return val; }
        public bool IsSet(PartyID val) { return IsSetPartyID(); }
        public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }

        public PartyIDSource PartyIDSource
        {
            get
            {
                PartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyIDSource val) { PartyIDSource = val; }
        public PartyIDSource Get(PartyIDSource val) { GetField(val); return val; }
        public bool IsSet(PartyIDSource val) { return IsSetPartyIDSource(); }
        public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }

        public PartyRole PartyRole
        {
            get
            {
                PartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PartyRole val) { PartyRole = val; }
        public PartyRole Get(PartyRole val) { GetField(val); return val; }
        public bool IsSet(PartyRole val) { return IsSetPartyRole(); }
        public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }

        public NoPartySubIDs NoPartySubIDs
        {
            get
            {
                NoPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoPartySubIDs val) { NoPartySubIDs = val; }
        public NoPartySubIDs Get(NoPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoPartySubIDs val) { return IsSetNoPartySubIDs(); }
        public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }

        public class NoPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.PartySubID, Tags.PartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

            public NoPartySubIDsGroup()
              : base(Tags.NoPartySubIDs, Tags.PartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public PartySubID PartySubID
            {
                get
                {
                    PartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubID val) { PartySubID = val; }
            public PartySubID Get(PartySubID val) { GetField(val); return val; }
            public bool IsSet(PartySubID val) { return IsSetPartySubID(); }
            public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }

            public PartySubIDType PartySubIDType
            {
                get
                {
                    PartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(PartySubIDType val) { PartySubIDType = val; }
            public PartySubIDType Get(PartySubIDType val) { GetField(val); return val; }
            public bool IsSet(PartySubIDType val) { return IsSetPartySubIDType(); }
            public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }
        }
    }

    public class NoRegistDtlsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.RegistDtls, Tags.RegistEmail, Tags.MailingDtls, Tags.MailingInst, Tags.NoNestedPartyIDs, Tags.OwnerType, Tags.DateOfBirth, Tags.InvestorCountryOfResidence, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.RegistDtls, Tags.RegistEmail, Tags.MailingDtls, Tags.MailingInst, Tags.NoNestedPartyIDs, Tags.OwnerType, Tags.DateOfBirth, Tags.InvestorCountryOfResidence, 0};

        public NoRegistDtlsGroup()
          : base(Tags.NoRegistDtls, Tags.RegistDtls, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRegistDtlsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public RegistDtls RegistDtls
        {
            get
            {
                RegistDtls val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RegistDtls val) { RegistDtls = val; }
        public RegistDtls Get(RegistDtls val) { GetField(val); return val; }
        public bool IsSet(RegistDtls val) { return IsSetRegistDtls(); }
        public bool IsSetRegistDtls() { return IsSetField(Tags.RegistDtls); }

        public RegistEmail RegistEmail
        {
            get
            {
                RegistEmail val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RegistEmail val) { RegistEmail = val; }
        public RegistEmail Get(RegistEmail val) { GetField(val); return val; }
        public bool IsSet(RegistEmail val) { return IsSetRegistEmail(); }
        public bool IsSetRegistEmail() { return IsSetField(Tags.RegistEmail); }

        public MailingDtls MailingDtls
        {
            get
            {
                MailingDtls val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MailingDtls val) { MailingDtls = val; }
        public MailingDtls Get(MailingDtls val) { GetField(val); return val; }
        public bool IsSet(MailingDtls val) { return IsSetMailingDtls(); }
        public bool IsSetMailingDtls() { return IsSetField(Tags.MailingDtls); }

        public MailingInst MailingInst
        {
            get
            {
                MailingInst val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MailingInst val) { MailingInst = val; }
        public MailingInst Get(MailingInst val) { GetField(val); return val; }
        public bool IsSet(MailingInst val) { return IsSetMailingInst(); }
        public bool IsSetMailingInst() { return IsSetField(Tags.MailingInst); }

        public NoNestedPartyIDs NoNestedPartyIDs
        {
            get
            {
                NoNestedPartyIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNestedPartyIDs val) { NoNestedPartyIDs = val; }
        public NoNestedPartyIDs Get(NoNestedPartyIDs val) { GetField(val); return val; }
        public bool IsSet(NoNestedPartyIDs val) { return IsSetNoNestedPartyIDs(); }
        public bool IsSetNoNestedPartyIDs() { return IsSetField(Tags.NoNestedPartyIDs); }

        public OwnerType OwnerType
        {
            get
            {
                OwnerType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OwnerType val) { OwnerType = val; }
        public OwnerType Get(OwnerType val) { GetField(val); return val; }
        public bool IsSet(OwnerType val) { return IsSetOwnerType(); }
        public bool IsSetOwnerType() { return IsSetField(Tags.OwnerType); }

        public DateOfBirth DateOfBirth
        {
            get
            {
                DateOfBirth val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DateOfBirth val) { DateOfBirth = val; }
        public DateOfBirth Get(DateOfBirth val) { GetField(val); return val; }
        public bool IsSet(DateOfBirth val) { return IsSetDateOfBirth(); }
        public bool IsSetDateOfBirth() { return IsSetField(Tags.DateOfBirth); }

        public InvestorCountryOfResidence InvestorCountryOfResidence
        {
            get
            {
                InvestorCountryOfResidence val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InvestorCountryOfResidence val) { InvestorCountryOfResidence = val; }
        public InvestorCountryOfResidence Get(InvestorCountryOfResidence val) { GetField(val); return val; }
        public bool IsSet(InvestorCountryOfResidence val) { return IsSetInvestorCountryOfResidence(); }
        public bool IsSetInvestorCountryOfResidence() { return IsSetField(Tags.InvestorCountryOfResidence); }

        public class NoNestedPartyIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};

            public NoNestedPartyIDsGroup()
              : base(Tags.NoNestedPartyIDs, Tags.NestedPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedPartyIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public NestedPartyID NestedPartyID
            {
                get
                {
                    NestedPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyID val) { NestedPartyID = val; }
            public NestedPartyID Get(NestedPartyID val) { GetField(val); return val; }
            public bool IsSet(NestedPartyID val) { return IsSetNestedPartyID(); }
            public bool IsSetNestedPartyID() { return IsSetField(Tags.NestedPartyID); }

            public NestedPartyIDSource NestedPartyIDSource
            {
                get
                {
                    NestedPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyIDSource val) { NestedPartyIDSource = val; }
            public NestedPartyIDSource Get(NestedPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(NestedPartyIDSource val) { return IsSetNestedPartyIDSource(); }
            public bool IsSetNestedPartyIDSource() { return IsSetField(Tags.NestedPartyIDSource); }

            public NestedPartyRole NestedPartyRole
            {
                get
                {
                    NestedPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedPartyRole val) { NestedPartyRole = val; }
            public NestedPartyRole Get(NestedPartyRole val) { GetField(val); return val; }
            public bool IsSet(NestedPartyRole val) { return IsSetNestedPartyRole(); }
            public bool IsSetNestedPartyRole() { return IsSetField(Tags.NestedPartyRole); }

            public NoNestedPartySubIDs NoNestedPartySubIDs
            {
                get
                {
                    NoNestedPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoNestedPartySubIDs val) { NoNestedPartySubIDs = val; }
            public NoNestedPartySubIDs Get(NoNestedPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoNestedPartySubIDs val) { return IsSetNoNestedPartySubIDs(); }
            public bool IsSetNoNestedPartySubIDs() { return IsSetField(Tags.NoNestedPartySubIDs); }

            public class NoNestedPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};

                public NoNestedPartySubIDsGroup()
                  : base(Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoNestedPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public NestedPartySubID NestedPartySubID
                {
                    get
                    {
                        NestedPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubID val) { NestedPartySubID = val; }
                public NestedPartySubID Get(NestedPartySubID val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubID val) { return IsSetNestedPartySubID(); }
                public bool IsSetNestedPartySubID() { return IsSetField(Tags.NestedPartySubID); }

                public NestedPartySubIDType NestedPartySubIDType
                {
                    get
                    {
                        NestedPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(NestedPartySubIDType val) { NestedPartySubIDType = val; }
                public NestedPartySubIDType Get(NestedPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(NestedPartySubIDType val) { return IsSetNestedPartySubIDType(); }
                public bool IsSetNestedPartySubIDType() { return IsSetField(Tags.NestedPartySubIDType); }
            }
        }
    }

    public class NoDistribInstsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.DistribPaymentMethod, Tags.DistribPercentage, Tags.CashDistribCurr, Tags.CashDistribAgentName, Tags.CashDistribAgentCode, Tags.CashDistribAgentAcctNumber, Tags.CashDistribPayRef, Tags.CashDistribAgentAcctName, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.DistribPaymentMethod, Tags.DistribPercentage, Tags.CashDistribCurr, Tags.CashDistribAgentName, Tags.CashDistribAgentCode, Tags.CashDistribAgentAcctNumber, Tags.CashDistribPayRef, Tags.CashDistribAgentAcctName, 0};

        public NoDistribInstsGroup()
          : base(Tags.NoDistribInsts, Tags.DistribPaymentMethod, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoDistribInstsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public DistribPaymentMethod DistribPaymentMethod
        {
            get
            {
                DistribPaymentMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DistribPaymentMethod val) { DistribPaymentMethod = val; }
        public DistribPaymentMethod Get(DistribPaymentMethod val) { GetField(val); return val; }
        public bool IsSet(DistribPaymentMethod val) { return IsSetDistribPaymentMethod(); }
        public bool IsSetDistribPaymentMethod() { return IsSetField(Tags.DistribPaymentMethod); }

        public DistribPercentage DistribPercentage
        {
            get
            {
                DistribPercentage val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DistribPercentage val) { DistribPercentage = val; }
        public DistribPercentage Get(DistribPercentage val) { GetField(val); return val; }
        public bool IsSet(DistribPercentage val) { return IsSetDistribPercentage(); }
        public bool IsSetDistribPercentage() { return IsSetField(Tags.DistribPercentage); }

        public CashDistribCurr CashDistribCurr
        {
            get
            {
                CashDistribCurr val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CashDistribCurr val) { CashDistribCurr = val; }
        public CashDistribCurr Get(CashDistribCurr val) { GetField(val); return val; }
        public bool IsSet(CashDistribCurr val) { return IsSetCashDistribCurr(); }
        public bool IsSetCashDistribCurr() { return IsSetField(Tags.CashDistribCurr); }

        public CashDistribAgentName CashDistribAgentName
        {
            get
            {
                CashDistribAgentName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CashDistribAgentName val) { CashDistribAgentName = val; }
        public CashDistribAgentName Get(CashDistribAgentName val) { GetField(val); return val; }
        public bool IsSet(CashDistribAgentName val) { return IsSetCashDistribAgentName(); }
        public bool IsSetCashDistribAgentName() { return IsSetField(Tags.CashDistribAgentName); }

        public CashDistribAgentCode CashDistribAgentCode
        {
            get
            {
                CashDistribAgentCode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CashDistribAgentCode val) { CashDistribAgentCode = val; }
        public CashDistribAgentCode Get(CashDistribAgentCode val) { GetField(val); return val; }
        public bool IsSet(CashDistribAgentCode val) { return IsSetCashDistribAgentCode(); }
        public bool IsSetCashDistribAgentCode() { return IsSetField(Tags.CashDistribAgentCode); }

        public CashDistribAgentAcctNumber CashDistribAgentAcctNumber
        {
            get
            {
                CashDistribAgentAcctNumber val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CashDistribAgentAcctNumber val) { CashDistribAgentAcctNumber = val; }
        public CashDistribAgentAcctNumber Get(CashDistribAgentAcctNumber val) { GetField(val); return val; }
        public bool IsSet(CashDistribAgentAcctNumber val) { return IsSetCashDistribAgentAcctNumber(); }
        public bool IsSetCashDistribAgentAcctNumber() { return IsSetField(Tags.CashDistribAgentAcctNumber); }

        public CashDistribPayRef CashDistribPayRef
        {
            get
            {
                CashDistribPayRef val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CashDistribPayRef val) { CashDistribPayRef = val; }
        public CashDistribPayRef Get(CashDistribPayRef val) { GetField(val); return val; }
        public bool IsSet(CashDistribPayRef val) { return IsSetCashDistribPayRef(); }
        public bool IsSetCashDistribPayRef() { return IsSetField(Tags.CashDistribPayRef); }

        public CashDistribAgentAcctName CashDistribAgentAcctName
        {
            get
            {
                CashDistribAgentAcctName val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CashDistribAgentAcctName val) { CashDistribAgentAcctName = val; }
        public CashDistribAgentAcctName Get(CashDistribAgentAcctName val) { GetField(val); return val; }
        public bool IsSet(CashDistribAgentAcctName val) { return IsSetCashDistribAgentAcctName(); }
        public bool IsSetCashDistribAgentAcctName() { return IsSetField(Tags.CashDistribAgentAcctName); }
    }
}
