// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class RegistrationInstructions : Message
        {
            public const string MsgType = "o";

            public RegistrationInstructions() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("o"));
            }

            public RegistrationInstructions(
                    QuickFix.Fields.RegistID aRegistID,
                    QuickFix.Fields.RegistTransType aRegistTransType,
                    QuickFix.Fields.RegistRefID aRegistRefID
                ) : this()
            {
                this.registID = aRegistID;
                this.registTransType = aRegistTransType;
                this.registRefID = aRegistRefID;
            }

            public QuickFix.Fields.RegistID registID
            { 
                get 
                {
                    QuickFix.Fields.RegistID val = new QuickFix.Fields.RegistID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RegistID val) 
            { 
                this.registID = val;
            }
            
            public QuickFix.Fields.RegistID get(QuickFix.Fields.RegistID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RegistID val) 
            { 
                return isSetRegistID();
            }
            
            public bool isSetRegistID() 
            { 
                return isSetField(Tags.RegistID);
            }
            public QuickFix.Fields.RegistTransType registTransType
            { 
                get 
                {
                    QuickFix.Fields.RegistTransType val = new QuickFix.Fields.RegistTransType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RegistTransType val) 
            { 
                this.registTransType = val;
            }
            
            public QuickFix.Fields.RegistTransType get(QuickFix.Fields.RegistTransType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RegistTransType val) 
            { 
                return isSetRegistTransType();
            }
            
            public bool isSetRegistTransType() 
            { 
                return isSetField(Tags.RegistTransType);
            }
            public QuickFix.Fields.RegistRefID registRefID
            { 
                get 
                {
                    QuickFix.Fields.RegistRefID val = new QuickFix.Fields.RegistRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RegistRefID val) 
            { 
                this.registRefID = val;
            }
            
            public QuickFix.Fields.RegistRefID get(QuickFix.Fields.RegistRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RegistRefID val) 
            { 
                return isSetRegistRefID();
            }
            
            public bool isSetRegistRefID() 
            { 
                return isSetField(Tags.RegistRefID);
            }
            public QuickFix.Fields.ClOrdID clOrdID
            { 
                get 
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ClOrdID val) 
            { 
                this.clOrdID = val;
            }
            
            public QuickFix.Fields.ClOrdID get(QuickFix.Fields.ClOrdID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ClOrdID val) 
            { 
                return isSetClOrdID();
            }
            
            public bool isSetClOrdID() 
            { 
                return isSetField(Tags.ClOrdID);
            }
            public QuickFix.Fields.NoPartyIDs noPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoPartyIDs val) 
            { 
                this.noPartyIDs = val;
            }
            
            public QuickFix.Fields.NoPartyIDs get(QuickFix.Fields.NoPartyIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoPartyIDs val) 
            { 
                return isSetNoPartyIDs();
            }
            
            public bool isSetNoPartyIDs() 
            { 
                return isSetField(Tags.NoPartyIDs);
            }
            public QuickFix.Fields.Account account
            { 
                get 
                {
                    QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Account val) 
            { 
                this.account = val;
            }
            
            public QuickFix.Fields.Account get(QuickFix.Fields.Account val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Account val) 
            { 
                return isSetAccount();
            }
            
            public bool isSetAccount() 
            { 
                return isSetField(Tags.Account);
            }
            public QuickFix.Fields.AcctIDSource acctIDSource
            { 
                get 
                {
                    QuickFix.Fields.AcctIDSource val = new QuickFix.Fields.AcctIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AcctIDSource val) 
            { 
                this.acctIDSource = val;
            }
            
            public QuickFix.Fields.AcctIDSource get(QuickFix.Fields.AcctIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AcctIDSource val) 
            { 
                return isSetAcctIDSource();
            }
            
            public bool isSetAcctIDSource() 
            { 
                return isSetField(Tags.AcctIDSource);
            }
            public QuickFix.Fields.RegistAcctType registAcctType
            { 
                get 
                {
                    QuickFix.Fields.RegistAcctType val = new QuickFix.Fields.RegistAcctType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RegistAcctType val) 
            { 
                this.registAcctType = val;
            }
            
            public QuickFix.Fields.RegistAcctType get(QuickFix.Fields.RegistAcctType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RegistAcctType val) 
            { 
                return isSetRegistAcctType();
            }
            
            public bool isSetRegistAcctType() 
            { 
                return isSetField(Tags.RegistAcctType);
            }
            public QuickFix.Fields.TaxAdvantageType taxAdvantageType
            { 
                get 
                {
                    QuickFix.Fields.TaxAdvantageType val = new QuickFix.Fields.TaxAdvantageType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TaxAdvantageType val) 
            { 
                this.taxAdvantageType = val;
            }
            
            public QuickFix.Fields.TaxAdvantageType get(QuickFix.Fields.TaxAdvantageType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TaxAdvantageType val) 
            { 
                return isSetTaxAdvantageType();
            }
            
            public bool isSetTaxAdvantageType() 
            { 
                return isSetField(Tags.TaxAdvantageType);
            }
            public QuickFix.Fields.OwnershipType ownershipType
            { 
                get 
                {
                    QuickFix.Fields.OwnershipType val = new QuickFix.Fields.OwnershipType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OwnershipType val) 
            { 
                this.ownershipType = val;
            }
            
            public QuickFix.Fields.OwnershipType get(QuickFix.Fields.OwnershipType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OwnershipType val) 
            { 
                return isSetOwnershipType();
            }
            
            public bool isSetOwnershipType() 
            { 
                return isSetField(Tags.OwnershipType);
            }
            public QuickFix.Fields.NoRegistDtls noRegistDtls
            { 
                get 
                {
                    QuickFix.Fields.NoRegistDtls val = new QuickFix.Fields.NoRegistDtls();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRegistDtls val) 
            { 
                this.noRegistDtls = val;
            }
            
            public QuickFix.Fields.NoRegistDtls get(QuickFix.Fields.NoRegistDtls val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRegistDtls val) 
            { 
                return isSetNoRegistDtls();
            }
            
            public bool isSetNoRegistDtls() 
            { 
                return isSetField(Tags.NoRegistDtls);
            }
            public QuickFix.Fields.NoDistribInsts noDistribInsts
            { 
                get 
                {
                    QuickFix.Fields.NoDistribInsts val = new QuickFix.Fields.NoDistribInsts();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoDistribInsts val) 
            { 
                this.noDistribInsts = val;
            }
            
            public QuickFix.Fields.NoDistribInsts get(QuickFix.Fields.NoDistribInsts val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoDistribInsts val) 
            { 
                return isSetNoDistribInsts();
            }
            
            public bool isSetNoDistribInsts() 
            { 
                return isSetField(Tags.NoDistribInsts);
            }
            public class NoPartyIDs : Group
            {
                public NoPartyIDs() 
                  :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
                            public QuickFix.Fields.PartyID partyID
                { 
                    get 
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyID val) 
                { 
                    this.partyID = val;
                }
                
                public QuickFix.Fields.PartyID get(QuickFix.Fields.PartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyID val) 
                { 
                    return isSetPartyID();
                }
                
                public bool isSetPartyID() 
                { 
                    return isSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource partyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyIDSource val) 
                { 
                    this.partyIDSource = val;
                }
                
                public QuickFix.Fields.PartyIDSource get(QuickFix.Fields.PartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyIDSource val) 
                { 
                    return isSetPartyIDSource();
                }
                
                public bool isSetPartyIDSource() 
                { 
                    return isSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole partyRole
                { 
                    get 
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PartyRole val) 
                { 
                    this.partyRole = val;
                }
                
                public QuickFix.Fields.PartyRole get(QuickFix.Fields.PartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PartyRole val) 
                { 
                    return isSetPartyRole();
                }
                
                public bool isSetPartyRole() 
                { 
                    return isSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.NoPartySubIDs noPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    this.noPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoPartySubIDs get(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoPartySubIDs val) 
                { 
                    return isSetNoPartySubIDs();
                }
                
                public bool isSetNoPartySubIDs() 
                { 
                    return isSetField(Tags.NoPartySubIDs);
                }
                            public class NoPartySubIDs : Group
                {
                    public NoPartySubIDs() 
                      :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                                    public QuickFix.Fields.PartySubID partySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartySubID val) 
                    { 
                        this.partySubID = val;
                    }
                    
                    public QuickFix.Fields.PartySubID get(QuickFix.Fields.PartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartySubID val) 
                    { 
                        return isSetPartySubID();
                    }
                    
                    public bool isSetPartySubID() 
                    { 
                        return isSetField(Tags.PartySubID);
                    }
                    public QuickFix.Fields.PartySubIDType partySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartySubIDType val) 
                    { 
                        this.partySubIDType = val;
                    }
                    
                    public QuickFix.Fields.PartySubIDType get(QuickFix.Fields.PartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartySubIDType val) 
                    { 
                        return isSetPartySubIDType();
                    }
                    
                    public bool isSetPartySubIDType() 
                    { 
                        return isSetField(Tags.PartySubIDType);
                    }
                
                }
            }
            public class NoRegistDtls : Group
            {
                public NoRegistDtls() 
                  :base( Tags.NoRegistDtls, Tags.RegistDtls, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RegistDtls, Tags.RegistEmail, Tags.MailingDtls, Tags.MailingInst, Tags.NoNestedPartyIDs, Tags.OwnerType, Tags.DateOfBirth, Tags.InvestorCountryOfResidence, 0};
                            public QuickFix.Fields.RegistDtls registDtls
                { 
                    get 
                    {
                        QuickFix.Fields.RegistDtls val = new QuickFix.Fields.RegistDtls();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RegistDtls val) 
                { 
                    this.registDtls = val;
                }
                
                public QuickFix.Fields.RegistDtls get(QuickFix.Fields.RegistDtls val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RegistDtls val) 
                { 
                    return isSetRegistDtls();
                }
                
                public bool isSetRegistDtls() 
                { 
                    return isSetField(Tags.RegistDtls);
                }
                public QuickFix.Fields.RegistEmail registEmail
                { 
                    get 
                    {
                        QuickFix.Fields.RegistEmail val = new QuickFix.Fields.RegistEmail();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RegistEmail val) 
                { 
                    this.registEmail = val;
                }
                
                public QuickFix.Fields.RegistEmail get(QuickFix.Fields.RegistEmail val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RegistEmail val) 
                { 
                    return isSetRegistEmail();
                }
                
                public bool isSetRegistEmail() 
                { 
                    return isSetField(Tags.RegistEmail);
                }
                public QuickFix.Fields.MailingDtls mailingDtls
                { 
                    get 
                    {
                        QuickFix.Fields.MailingDtls val = new QuickFix.Fields.MailingDtls();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MailingDtls val) 
                { 
                    this.mailingDtls = val;
                }
                
                public QuickFix.Fields.MailingDtls get(QuickFix.Fields.MailingDtls val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MailingDtls val) 
                { 
                    return isSetMailingDtls();
                }
                
                public bool isSetMailingDtls() 
                { 
                    return isSetField(Tags.MailingDtls);
                }
                public QuickFix.Fields.MailingInst mailingInst
                { 
                    get 
                    {
                        QuickFix.Fields.MailingInst val = new QuickFix.Fields.MailingInst();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MailingInst val) 
                { 
                    this.mailingInst = val;
                }
                
                public QuickFix.Fields.MailingInst get(QuickFix.Fields.MailingInst val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MailingInst val) 
                { 
                    return isSetMailingInst();
                }
                
                public bool isSetMailingInst() 
                { 
                    return isSetField(Tags.MailingInst);
                }
                public QuickFix.Fields.NoNestedPartyIDs noNestedPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoNestedPartyIDs val = new QuickFix.Fields.NoNestedPartyIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    this.noNestedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoNestedPartyIDs get(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoNestedPartyIDs val) 
                { 
                    return isSetNoNestedPartyIDs();
                }
                
                public bool isSetNoNestedPartyIDs() 
                { 
                    return isSetField(Tags.NoNestedPartyIDs);
                }
                public QuickFix.Fields.OwnerType ownerType
                { 
                    get 
                    {
                        QuickFix.Fields.OwnerType val = new QuickFix.Fields.OwnerType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OwnerType val) 
                { 
                    this.ownerType = val;
                }
                
                public QuickFix.Fields.OwnerType get(QuickFix.Fields.OwnerType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OwnerType val) 
                { 
                    return isSetOwnerType();
                }
                
                public bool isSetOwnerType() 
                { 
                    return isSetField(Tags.OwnerType);
                }
                public QuickFix.Fields.DateOfBirth dateOfBirth
                { 
                    get 
                    {
                        QuickFix.Fields.DateOfBirth val = new QuickFix.Fields.DateOfBirth();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DateOfBirth val) 
                { 
                    this.dateOfBirth = val;
                }
                
                public QuickFix.Fields.DateOfBirth get(QuickFix.Fields.DateOfBirth val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DateOfBirth val) 
                { 
                    return isSetDateOfBirth();
                }
                
                public bool isSetDateOfBirth() 
                { 
                    return isSetField(Tags.DateOfBirth);
                }
                public QuickFix.Fields.InvestorCountryOfResidence investorCountryOfResidence
                { 
                    get 
                    {
                        QuickFix.Fields.InvestorCountryOfResidence val = new QuickFix.Fields.InvestorCountryOfResidence();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InvestorCountryOfResidence val) 
                { 
                    this.investorCountryOfResidence = val;
                }
                
                public QuickFix.Fields.InvestorCountryOfResidence get(QuickFix.Fields.InvestorCountryOfResidence val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InvestorCountryOfResidence val) 
                { 
                    return isSetInvestorCountryOfResidence();
                }
                
                public bool isSetInvestorCountryOfResidence() 
                { 
                    return isSetField(Tags.InvestorCountryOfResidence);
                }
                            public class NoNestedPartyIDs : Group
                {
                    public NoNestedPartyIDs() 
                      :base( Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};
                                    public QuickFix.Fields.NestedPartyID nestedPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyID val = new QuickFix.Fields.NestedPartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NestedPartyID val) 
                    { 
                        this.nestedPartyID = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyID get(QuickFix.Fields.NestedPartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NestedPartyID val) 
                    { 
                        return isSetNestedPartyID();
                    }
                    
                    public bool isSetNestedPartyID() 
                    { 
                        return isSetField(Tags.NestedPartyID);
                    }
                    public QuickFix.Fields.NestedPartyIDSource nestedPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyIDSource val = new QuickFix.Fields.NestedPartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        this.nestedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyIDSource get(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NestedPartyIDSource val) 
                    { 
                        return isSetNestedPartyIDSource();
                    }
                    
                    public bool isSetNestedPartyIDSource() 
                    { 
                        return isSetField(Tags.NestedPartyIDSource);
                    }
                    public QuickFix.Fields.NestedPartyRole nestedPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedPartyRole val = new QuickFix.Fields.NestedPartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        this.nestedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.NestedPartyRole get(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NestedPartyRole val) 
                    { 
                        return isSetNestedPartyRole();
                    }
                    
                    public bool isSetNestedPartyRole() 
                    { 
                        return isSetField(Tags.NestedPartyRole);
                    }
                    public QuickFix.Fields.NoNestedPartySubIDs noNestedPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNestedPartySubIDs val = new QuickFix.Fields.NoNestedPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        this.noNestedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartySubIDs get(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                    { 
                        return isSetNoNestedPartySubIDs();
                    }
                    
                    public bool isSetNoNestedPartySubIDs() 
                    { 
                        return isSetField(Tags.NoNestedPartySubIDs);
                    }
                                    public class NoNestedPartySubIDs : Group
                    {
                        public NoNestedPartySubIDs() 
                          :base( Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};
                                            public QuickFix.Fields.NestedPartySubID nestedPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartySubID val = new QuickFix.Fields.NestedPartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            this.nestedPartySubID = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubID get(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NestedPartySubID val) 
                        { 
                            return isSetNestedPartySubID();
                        }
                        
                        public bool isSetNestedPartySubID() 
                        { 
                            return isSetField(Tags.NestedPartySubID);
                        }
                        public QuickFix.Fields.NestedPartySubIDType nestedPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartySubIDType val = new QuickFix.Fields.NestedPartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            this.nestedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.NestedPartySubIDType get(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NestedPartySubIDType val) 
                        { 
                            return isSetNestedPartySubIDType();
                        }
                        
                        public bool isSetNestedPartySubIDType() 
                        { 
                            return isSetField(Tags.NestedPartySubIDType);
                        }
                    
                    }
                }
            }
            public class NoDistribInsts : Group
            {
                public NoDistribInsts() 
                  :base( Tags.NoDistribInsts, Tags.DistribPaymentMethod, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.DistribPaymentMethod, Tags.DistribPercentage, Tags.CashDistribCurr, Tags.CashDistribAgentName, Tags.CashDistribAgentCode, Tags.CashDistribAgentAcctNumber, Tags.CashDistribPayRef, Tags.CashDistribAgentAcctName, 0};
                            public QuickFix.Fields.DistribPaymentMethod distribPaymentMethod
                { 
                    get 
                    {
                        QuickFix.Fields.DistribPaymentMethod val = new QuickFix.Fields.DistribPaymentMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DistribPaymentMethod val) 
                { 
                    this.distribPaymentMethod = val;
                }
                
                public QuickFix.Fields.DistribPaymentMethod get(QuickFix.Fields.DistribPaymentMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DistribPaymentMethod val) 
                { 
                    return isSetDistribPaymentMethod();
                }
                
                public bool isSetDistribPaymentMethod() 
                { 
                    return isSetField(Tags.DistribPaymentMethod);
                }
                public QuickFix.Fields.DistribPercentage distribPercentage
                { 
                    get 
                    {
                        QuickFix.Fields.DistribPercentage val = new QuickFix.Fields.DistribPercentage();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DistribPercentage val) 
                { 
                    this.distribPercentage = val;
                }
                
                public QuickFix.Fields.DistribPercentage get(QuickFix.Fields.DistribPercentage val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DistribPercentage val) 
                { 
                    return isSetDistribPercentage();
                }
                
                public bool isSetDistribPercentage() 
                { 
                    return isSetField(Tags.DistribPercentage);
                }
                public QuickFix.Fields.CashDistribCurr cashDistribCurr
                { 
                    get 
                    {
                        QuickFix.Fields.CashDistribCurr val = new QuickFix.Fields.CashDistribCurr();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CashDistribCurr val) 
                { 
                    this.cashDistribCurr = val;
                }
                
                public QuickFix.Fields.CashDistribCurr get(QuickFix.Fields.CashDistribCurr val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CashDistribCurr val) 
                { 
                    return isSetCashDistribCurr();
                }
                
                public bool isSetCashDistribCurr() 
                { 
                    return isSetField(Tags.CashDistribCurr);
                }
                public QuickFix.Fields.CashDistribAgentName cashDistribAgentName
                { 
                    get 
                    {
                        QuickFix.Fields.CashDistribAgentName val = new QuickFix.Fields.CashDistribAgentName();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CashDistribAgentName val) 
                { 
                    this.cashDistribAgentName = val;
                }
                
                public QuickFix.Fields.CashDistribAgentName get(QuickFix.Fields.CashDistribAgentName val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CashDistribAgentName val) 
                { 
                    return isSetCashDistribAgentName();
                }
                
                public bool isSetCashDistribAgentName() 
                { 
                    return isSetField(Tags.CashDistribAgentName);
                }
                public QuickFix.Fields.CashDistribAgentCode cashDistribAgentCode
                { 
                    get 
                    {
                        QuickFix.Fields.CashDistribAgentCode val = new QuickFix.Fields.CashDistribAgentCode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CashDistribAgentCode val) 
                { 
                    this.cashDistribAgentCode = val;
                }
                
                public QuickFix.Fields.CashDistribAgentCode get(QuickFix.Fields.CashDistribAgentCode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CashDistribAgentCode val) 
                { 
                    return isSetCashDistribAgentCode();
                }
                
                public bool isSetCashDistribAgentCode() 
                { 
                    return isSetField(Tags.CashDistribAgentCode);
                }
                public QuickFix.Fields.CashDistribAgentAcctNumber cashDistribAgentAcctNumber
                { 
                    get 
                    {
                        QuickFix.Fields.CashDistribAgentAcctNumber val = new QuickFix.Fields.CashDistribAgentAcctNumber();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CashDistribAgentAcctNumber val) 
                { 
                    this.cashDistribAgentAcctNumber = val;
                }
                
                public QuickFix.Fields.CashDistribAgentAcctNumber get(QuickFix.Fields.CashDistribAgentAcctNumber val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CashDistribAgentAcctNumber val) 
                { 
                    return isSetCashDistribAgentAcctNumber();
                }
                
                public bool isSetCashDistribAgentAcctNumber() 
                { 
                    return isSetField(Tags.CashDistribAgentAcctNumber);
                }
                public QuickFix.Fields.CashDistribPayRef cashDistribPayRef
                { 
                    get 
                    {
                        QuickFix.Fields.CashDistribPayRef val = new QuickFix.Fields.CashDistribPayRef();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CashDistribPayRef val) 
                { 
                    this.cashDistribPayRef = val;
                }
                
                public QuickFix.Fields.CashDistribPayRef get(QuickFix.Fields.CashDistribPayRef val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CashDistribPayRef val) 
                { 
                    return isSetCashDistribPayRef();
                }
                
                public bool isSetCashDistribPayRef() 
                { 
                    return isSetField(Tags.CashDistribPayRef);
                }
                public QuickFix.Fields.CashDistribAgentAcctName cashDistribAgentAcctName
                { 
                    get 
                    {
                        QuickFix.Fields.CashDistribAgentAcctName val = new QuickFix.Fields.CashDistribAgentAcctName();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CashDistribAgentAcctName val) 
                { 
                    this.cashDistribAgentAcctName = val;
                }
                
                public QuickFix.Fields.CashDistribAgentAcctName get(QuickFix.Fields.CashDistribAgentAcctName val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CashDistribAgentAcctName val) 
                { 
                    return isSetCashDistribAgentAcctName();
                }
                
                public bool isSetCashDistribAgentAcctName() 
                { 
                    return isSetField(Tags.CashDistribAgentAcctName);
                }
            
            }
        }
    }
}
