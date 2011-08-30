// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX44 
    {
        public class SettlementInstructionRequest : Message
        {
            public const string MsgType = "AV";

            public SettlementInstructionRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("AV"));
            }

            public SettlementInstructionRequest(
                    QuickFix.Fields.SettlInstReqID aSettlInstReqID,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.settlInstReqID = aSettlInstReqID;
                this.transactTime = aTransactTime;
            }

            public QuickFix.Fields.SettlInstReqID settlInstReqID
            { 
                get 
                {
                    QuickFix.Fields.SettlInstReqID val = new QuickFix.Fields.SettlInstReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SettlInstReqID val) 
            { 
                this.settlInstReqID = val;
            }
            
            public QuickFix.Fields.SettlInstReqID get(QuickFix.Fields.SettlInstReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SettlInstReqID val) 
            { 
                return isSetSettlInstReqID();
            }
            
            public bool isSetSettlInstReqID() 
            { 
                return isSetField(Tags.SettlInstReqID);
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
            public QuickFix.Fields.AllocAccount allocAccount
            { 
                get 
                {
                    QuickFix.Fields.AllocAccount val = new QuickFix.Fields.AllocAccount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocAccount val) 
            { 
                this.allocAccount = val;
            }
            
            public QuickFix.Fields.AllocAccount get(QuickFix.Fields.AllocAccount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocAccount val) 
            { 
                return isSetAllocAccount();
            }
            
            public bool isSetAllocAccount() 
            { 
                return isSetField(Tags.AllocAccount);
            }
            public QuickFix.Fields.AllocAcctIDSource allocAcctIDSource
            { 
                get 
                {
                    QuickFix.Fields.AllocAcctIDSource val = new QuickFix.Fields.AllocAcctIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                this.allocAcctIDSource = val;
            }
            
            public QuickFix.Fields.AllocAcctIDSource get(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.AllocAcctIDSource val) 
            { 
                return isSetAllocAcctIDSource();
            }
            
            public bool isSetAllocAcctIDSource() 
            { 
                return isSetField(Tags.AllocAcctIDSource);
            }
            public QuickFix.Fields.Side side
            { 
                get 
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Side val) 
            { 
                this.side = val;
            }
            
            public QuickFix.Fields.Side get(QuickFix.Fields.Side val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Side val) 
            { 
                return isSetSide();
            }
            
            public bool isSetSide() 
            { 
                return isSetField(Tags.Side);
            }
            public QuickFix.Fields.Product product
            { 
                get 
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Product val) 
            { 
                this.product = val;
            }
            
            public QuickFix.Fields.Product get(QuickFix.Fields.Product val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Product val) 
            { 
                return isSetProduct();
            }
            
            public bool isSetProduct() 
            { 
                return isSetField(Tags.Product);
            }
            public QuickFix.Fields.SecurityType securityType
            { 
                get 
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityType val) 
            { 
                this.securityType = val;
            }
            
            public QuickFix.Fields.SecurityType get(QuickFix.Fields.SecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityType val) 
            { 
                return isSetSecurityType();
            }
            
            public bool isSetSecurityType() 
            { 
                return isSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.CFICode cFICode
            { 
                get 
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CFICode val) 
            { 
                this.cFICode = val;
            }
            
            public QuickFix.Fields.CFICode get(QuickFix.Fields.CFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CFICode val) 
            { 
                return isSetCFICode();
            }
            
            public bool isSetCFICode() 
            { 
                return isSetField(Tags.CFICode);
            }
            public QuickFix.Fields.EffectiveTime effectiveTime
            { 
                get 
                {
                    QuickFix.Fields.EffectiveTime val = new QuickFix.Fields.EffectiveTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EffectiveTime val) 
            { 
                this.effectiveTime = val;
            }
            
            public QuickFix.Fields.EffectiveTime get(QuickFix.Fields.EffectiveTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EffectiveTime val) 
            { 
                return isSetEffectiveTime();
            }
            
            public bool isSetEffectiveTime() 
            { 
                return isSetField(Tags.EffectiveTime);
            }
            public QuickFix.Fields.ExpireTime expireTime
            { 
                get 
                {
                    QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ExpireTime val) 
            { 
                this.expireTime = val;
            }
            
            public QuickFix.Fields.ExpireTime get(QuickFix.Fields.ExpireTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ExpireTime val) 
            { 
                return isSetExpireTime();
            }
            
            public bool isSetExpireTime() 
            { 
                return isSetField(Tags.ExpireTime);
            }
            public QuickFix.Fields.LastUpdateTime lastUpdateTime
            { 
                get 
                {
                    QuickFix.Fields.LastUpdateTime val = new QuickFix.Fields.LastUpdateTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastUpdateTime val) 
            { 
                this.lastUpdateTime = val;
            }
            
            public QuickFix.Fields.LastUpdateTime get(QuickFix.Fields.LastUpdateTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastUpdateTime val) 
            { 
                return isSetLastUpdateTime();
            }
            
            public bool isSetLastUpdateTime() 
            { 
                return isSetField(Tags.LastUpdateTime);
            }
            public QuickFix.Fields.StandInstDbType standInstDbType
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbType val = new QuickFix.Fields.StandInstDbType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StandInstDbType val) 
            { 
                this.standInstDbType = val;
            }
            
            public QuickFix.Fields.StandInstDbType get(QuickFix.Fields.StandInstDbType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StandInstDbType val) 
            { 
                return isSetStandInstDbType();
            }
            
            public bool isSetStandInstDbType() 
            { 
                return isSetField(Tags.StandInstDbType);
            }
            public QuickFix.Fields.StandInstDbName standInstDbName
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbName val = new QuickFix.Fields.StandInstDbName();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StandInstDbName val) 
            { 
                this.standInstDbName = val;
            }
            
            public QuickFix.Fields.StandInstDbName get(QuickFix.Fields.StandInstDbName val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StandInstDbName val) 
            { 
                return isSetStandInstDbName();
            }
            
            public bool isSetStandInstDbName() 
            { 
                return isSetField(Tags.StandInstDbName);
            }
            public QuickFix.Fields.StandInstDbID standInstDbID
            { 
                get 
                {
                    QuickFix.Fields.StandInstDbID val = new QuickFix.Fields.StandInstDbID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.StandInstDbID val) 
            { 
                this.standInstDbID = val;
            }
            
            public QuickFix.Fields.StandInstDbID get(QuickFix.Fields.StandInstDbID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.StandInstDbID val) 
            { 
                return isSetStandInstDbID();
            }
            
            public bool isSetStandInstDbID() 
            { 
                return isSetField(Tags.StandInstDbID);
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
        }
    }
}
