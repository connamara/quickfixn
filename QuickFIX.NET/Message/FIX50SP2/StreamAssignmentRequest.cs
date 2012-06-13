// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class StreamAssignmentRequest : Message
        {
            public const string MsgType = "CC";

            public StreamAssignmentRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CC"));
            }

            public StreamAssignmentRequest(
                    QuickFix.Fields.StreamAsgnReqID aStreamAsgnReqID,
                    QuickFix.Fields.StreamAsgnReqType aStreamAsgnReqType
                ) : this()
            {
                this.StreamAsgnReqID = aStreamAsgnReqID;
                this.StreamAsgnReqType = aStreamAsgnReqType;
            }

            public QuickFix.Fields.StreamAsgnReqID StreamAsgnReqID
            { 
                get 
                {
                    QuickFix.Fields.StreamAsgnReqID val = new QuickFix.Fields.StreamAsgnReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StreamAsgnReqID val) 
            { 
                this.StreamAsgnReqID = val;
            }
            
            public QuickFix.Fields.StreamAsgnReqID Get(QuickFix.Fields.StreamAsgnReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StreamAsgnReqID val) 
            { 
                return IsSetStreamAsgnReqID();
            }
            
            public bool IsSetStreamAsgnReqID() 
            { 
                return IsSetField(Tags.StreamAsgnReqID);
            }
            public QuickFix.Fields.StreamAsgnReqType StreamAsgnReqType
            { 
                get 
                {
                    QuickFix.Fields.StreamAsgnReqType val = new QuickFix.Fields.StreamAsgnReqType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.StreamAsgnReqType val) 
            { 
                this.StreamAsgnReqType = val;
            }
            
            public QuickFix.Fields.StreamAsgnReqType Get(QuickFix.Fields.StreamAsgnReqType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.StreamAsgnReqType val) 
            { 
                return IsSetStreamAsgnReqType();
            }
            
            public bool IsSetStreamAsgnReqType() 
            { 
                return IsSetField(Tags.StreamAsgnReqType);
            }
            public QuickFix.Fields.NoAsgnReqs NoAsgnReqs
            { 
                get 
                {
                    QuickFix.Fields.NoAsgnReqs val = new QuickFix.Fields.NoAsgnReqs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoAsgnReqs val) 
            { 
                this.NoAsgnReqs = val;
            }
            
            public QuickFix.Fields.NoAsgnReqs Get(QuickFix.Fields.NoAsgnReqs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoAsgnReqs val) 
            { 
                return IsSetNoAsgnReqs();
            }
            
            public bool IsSetNoAsgnReqs() 
            { 
                return IsSetField(Tags.NoAsgnReqs);
            }
            public class NoAsgnReqsGroup : Group
            {
                public static int[] fieldOrder = {Tags.NoPartyIDs, Tags.NoRelatedSym, 0};
            
                public NoAsgnReqsGroup() 
                  :base( Tags.NoAsgnReqs, Tags.NoPartyIDs, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoAsgnReqsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
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
                            public class NoPartyIDsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};
                
                    public NoPartyIDsGroup() 
                      :base( Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
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
                                    public class NoPartySubIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};
                    
                        public NoPartySubIDsGroup() 
                          :base( Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
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
                public class NoRelatedSymGroup : Group
                {
                    public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayoutAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.ValuationMethod, Tags.ContractMultiplierUnit, Tags.FlowScheduleType, Tags.RestructuringType, Tags.Seniority, Tags.NotionalPercentageOutstanding, Tags.OriginalNotionalPercentageOutstanding, Tags.AttachmentPoint, Tags.DetachmentPoint, Tags.StrikePriceDeterminationMethod, Tags.StrikePriceBoundaryMethod, Tags.StrikePriceBoundaryPrecision, Tags.UnderlyingPriceDeterminationMethod, Tags.OptPayoutType, Tags.NoComplexEvents, Tags.SettlType, Tags.MDEntrySize, Tags.MDStreamID, 0};
                
                    public NoRelatedSymGroup() 
                      :base( Tags.NoRelatedSym, Tags.Symbol, fieldOrder)
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
                    public QuickFix.Fields.SymbolSfx SymbolSfx
                    { 
                        get 
                        {
                            QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SymbolSfx val) 
                    { 
                        this.SymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SymbolSfx val) 
                    { 
                        return IsSetSymbolSfx();
                    }
                    
                    public bool IsSetSymbolSfx() 
                    { 
                        return IsSetField(Tags.SymbolSfx);
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
                    public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoSecurityAltID val) 
                    { 
                        this.NoSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoSecurityAltID val) 
                    { 
                        return IsSetNoSecurityAltID();
                    }
                    
                    public bool IsSetNoSecurityAltID() 
                    { 
                        return IsSetField(Tags.NoSecurityAltID);
                    }
                    public QuickFix.Fields.Product Product
                    { 
                        get 
                        {
                            QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Product val) 
                    { 
                        this.Product = val;
                    }
                    
                    public QuickFix.Fields.Product Get(QuickFix.Fields.Product val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Product val) 
                    { 
                        return IsSetProduct();
                    }
                    
                    public bool IsSetProduct() 
                    { 
                        return IsSetField(Tags.Product);
                    }
                    public QuickFix.Fields.CFICode CFICode
                    { 
                        get 
                        {
                            QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.CFICode val) 
                    { 
                        this.CFICode = val;
                    }
                    
                    public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.CFICode val) 
                    { 
                        return IsSetCFICode();
                    }
                    
                    public bool IsSetCFICode() 
                    { 
                        return IsSetField(Tags.CFICode);
                    }
                    public QuickFix.Fields.SecurityType SecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityType val) 
                    { 
                        this.SecurityType = val;
                    }
                    
                    public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecurityType val) 
                    { 
                        return IsSetSecurityType();
                    }
                    
                    public bool IsSetSecurityType() 
                    { 
                        return IsSetField(Tags.SecurityType);
                    }
                    public QuickFix.Fields.SecuritySubType SecuritySubType
                    { 
                        get 
                        {
                            QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecuritySubType val) 
                    { 
                        this.SecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecuritySubType val) 
                    { 
                        return IsSetSecuritySubType();
                    }
                    
                    public bool IsSetSecuritySubType() 
                    { 
                        return IsSetField(Tags.SecuritySubType);
                    }
                    public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
                    { 
                        get 
                        {
                            QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MaturityMonthYear val) 
                    { 
                        this.MaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MaturityMonthYear val) 
                    { 
                        return IsSetMaturityMonthYear();
                    }
                    
                    public bool IsSetMaturityMonthYear() 
                    { 
                        return IsSetField(Tags.MaturityMonthYear);
                    }
                    public QuickFix.Fields.MaturityDate MaturityDate
                    { 
                        get 
                        {
                            QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MaturityDate val) 
                    { 
                        this.MaturityDate = val;
                    }
                    
                    public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MaturityDate val) 
                    { 
                        return IsSetMaturityDate();
                    }
                    
                    public bool IsSetMaturityDate() 
                    { 
                        return IsSetField(Tags.MaturityDate);
                    }
                    public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
                    { 
                        get 
                        {
                            QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.CouponPaymentDate val) 
                    { 
                        this.CouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.CouponPaymentDate val) 
                    { 
                        return IsSetCouponPaymentDate();
                    }
                    
                    public bool IsSetCouponPaymentDate() 
                    { 
                        return IsSetField(Tags.CouponPaymentDate);
                    }
                    public QuickFix.Fields.IssueDate IssueDate
                    { 
                        get 
                        {
                            QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.IssueDate val) 
                    { 
                        this.IssueDate = val;
                    }
                    
                    public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.IssueDate val) 
                    { 
                        return IsSetIssueDate();
                    }
                    
                    public bool IsSetIssueDate() 
                    { 
                        return IsSetField(Tags.IssueDate);
                    }
                    public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RepoCollateralSecurityType val) 
                    { 
                        this.RepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) 
                    { 
                        return IsSetRepoCollateralSecurityType();
                    }
                    
                    public bool IsSetRepoCollateralSecurityType() 
                    { 
                        return IsSetField(Tags.RepoCollateralSecurityType);
                    }
                    public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
                    { 
                        get 
                        {
                            QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RepurchaseTerm val) 
                    { 
                        this.RepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RepurchaseTerm val) 
                    { 
                        return IsSetRepurchaseTerm();
                    }
                    
                    public bool IsSetRepurchaseTerm() 
                    { 
                        return IsSetField(Tags.RepurchaseTerm);
                    }
                    public QuickFix.Fields.RepurchaseRate RepurchaseRate
                    { 
                        get 
                        {
                            QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RepurchaseRate val) 
                    { 
                        this.RepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RepurchaseRate val) 
                    { 
                        return IsSetRepurchaseRate();
                    }
                    
                    public bool IsSetRepurchaseRate() 
                    { 
                        return IsSetField(Tags.RepurchaseRate);
                    }
                    public QuickFix.Fields.Factor Factor
                    { 
                        get 
                        {
                            QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Factor val) 
                    { 
                        this.Factor = val;
                    }
                    
                    public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Factor val) 
                    { 
                        return IsSetFactor();
                    }
                    
                    public bool IsSetFactor() 
                    { 
                        return IsSetField(Tags.Factor);
                    }
                    public QuickFix.Fields.CreditRating CreditRating
                    { 
                        get 
                        {
                            QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.CreditRating val) 
                    { 
                        this.CreditRating = val;
                    }
                    
                    public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.CreditRating val) 
                    { 
                        return IsSetCreditRating();
                    }
                    
                    public bool IsSetCreditRating() 
                    { 
                        return IsSetField(Tags.CreditRating);
                    }
                    public QuickFix.Fields.InstrRegistry InstrRegistry
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrRegistry val) 
                    { 
                        this.InstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrRegistry val) 
                    { 
                        return IsSetInstrRegistry();
                    }
                    
                    public bool IsSetInstrRegistry() 
                    { 
                        return IsSetField(Tags.InstrRegistry);
                    }
                    public QuickFix.Fields.CountryOfIssue CountryOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.CountryOfIssue val) 
                    { 
                        this.CountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.CountryOfIssue val) 
                    { 
                        return IsSetCountryOfIssue();
                    }
                    
                    public bool IsSetCountryOfIssue() 
                    { 
                        return IsSetField(Tags.CountryOfIssue);
                    }
                    public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) 
                    { 
                        this.StateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
                    { 
                        return IsSetStateOrProvinceOfIssue();
                    }
                    
                    public bool IsSetStateOrProvinceOfIssue() 
                    { 
                        return IsSetField(Tags.StateOrProvinceOfIssue);
                    }
                    public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LocaleOfIssue val) 
                    { 
                        this.LocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LocaleOfIssue val) 
                    { 
                        return IsSetLocaleOfIssue();
                    }
                    
                    public bool IsSetLocaleOfIssue() 
                    { 
                        return IsSetField(Tags.LocaleOfIssue);
                    }
                    public QuickFix.Fields.RedemptionDate RedemptionDate
                    { 
                        get 
                        {
                            QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RedemptionDate val) 
                    { 
                        this.RedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RedemptionDate val) 
                    { 
                        return IsSetRedemptionDate();
                    }
                    
                    public bool IsSetRedemptionDate() 
                    { 
                        return IsSetField(Tags.RedemptionDate);
                    }
                    public QuickFix.Fields.StrikePrice StrikePrice
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikePrice val) 
                    { 
                        this.StrikePrice = val;
                    }
                    
                    public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikePrice val) 
                    { 
                        return IsSetStrikePrice();
                    }
                    
                    public bool IsSetStrikePrice() 
                    { 
                        return IsSetField(Tags.StrikePrice);
                    }
                    public QuickFix.Fields.StrikeCurrency StrikeCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeCurrency val) 
                    { 
                        this.StrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeCurrency val) 
                    { 
                        return IsSetStrikeCurrency();
                    }
                    
                    public bool IsSetStrikeCurrency() 
                    { 
                        return IsSetField(Tags.StrikeCurrency);
                    }
                    public QuickFix.Fields.OptAttribute OptAttribute
                    { 
                        get 
                        {
                            QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OptAttribute val) 
                    { 
                        this.OptAttribute = val;
                    }
                    
                    public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OptAttribute val) 
                    { 
                        return IsSetOptAttribute();
                    }
                    
                    public bool IsSetOptAttribute() 
                    { 
                        return IsSetField(Tags.OptAttribute);
                    }
                    public QuickFix.Fields.ContractMultiplier ContractMultiplier
                    { 
                        get 
                        {
                            QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContractMultiplier val) 
                    { 
                        this.ContractMultiplier = val;
                    }
                    
                    public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContractMultiplier val) 
                    { 
                        return IsSetContractMultiplier();
                    }
                    
                    public bool IsSetContractMultiplier() 
                    { 
                        return IsSetField(Tags.ContractMultiplier);
                    }
                    public QuickFix.Fields.CouponRate CouponRate
                    { 
                        get 
                        {
                            QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.CouponRate val) 
                    { 
                        this.CouponRate = val;
                    }
                    
                    public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.CouponRate val) 
                    { 
                        return IsSetCouponRate();
                    }
                    
                    public bool IsSetCouponRate() 
                    { 
                        return IsSetField(Tags.CouponRate);
                    }
                    public QuickFix.Fields.SecurityExchange SecurityExchange
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityExchange val) 
                    { 
                        this.SecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecurityExchange val) 
                    { 
                        return IsSetSecurityExchange();
                    }
                    
                    public bool IsSetSecurityExchange() 
                    { 
                        return IsSetField(Tags.SecurityExchange);
                    }
                    public QuickFix.Fields.Issuer Issuer
                    { 
                        get 
                        {
                            QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Issuer val) 
                    { 
                        this.Issuer = val;
                    }
                    
                    public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Issuer val) 
                    { 
                        return IsSetIssuer();
                    }
                    
                    public bool IsSetIssuer() 
                    { 
                        return IsSetField(Tags.Issuer);
                    }
                    public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedIssuerLen val) 
                    { 
                        this.EncodedIssuerLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) 
                    { 
                        return IsSetEncodedIssuerLen();
                    }
                    
                    public bool IsSetEncodedIssuerLen() 
                    { 
                        return IsSetField(Tags.EncodedIssuerLen);
                    }
                    public QuickFix.Fields.EncodedIssuer EncodedIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedIssuer val) 
                    { 
                        this.EncodedIssuer = val;
                    }
                    
                    public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedIssuer val) 
                    { 
                        return IsSetEncodedIssuer();
                    }
                    
                    public bool IsSetEncodedIssuer() 
                    { 
                        return IsSetField(Tags.EncodedIssuer);
                    }
                    public QuickFix.Fields.SecurityDesc SecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityDesc val) 
                    { 
                        this.SecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecurityDesc val) 
                    { 
                        return IsSetSecurityDesc();
                    }
                    
                    public bool IsSetSecurityDesc() 
                    { 
                        return IsSetField(Tags.SecurityDesc);
                    }
                    public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedSecurityDescLen val) 
                    { 
                        this.EncodedSecurityDescLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) 
                    { 
                        return IsSetEncodedSecurityDescLen();
                    }
                    
                    public bool IsSetEncodedSecurityDescLen() 
                    { 
                        return IsSetField(Tags.EncodedSecurityDescLen);
                    }
                    public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedSecurityDesc val) 
                    { 
                        this.EncodedSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) 
                    { 
                        return IsSetEncodedSecurityDesc();
                    }
                    
                    public bool IsSetEncodedSecurityDesc() 
                    { 
                        return IsSetField(Tags.EncodedSecurityDesc);
                    }
                    public QuickFix.Fields.Pool Pool
                    { 
                        get 
                        {
                            QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Pool val) 
                    { 
                        this.Pool = val;
                    }
                    
                    public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Pool val) 
                    { 
                        return IsSetPool();
                    }
                    
                    public bool IsSetPool() 
                    { 
                        return IsSetField(Tags.Pool);
                    }
                    public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
                    { 
                        get 
                        {
                            QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContractSettlMonth val) 
                    { 
                        this.ContractSettlMonth = val;
                    }
                    
                    public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContractSettlMonth val) 
                    { 
                        return IsSetContractSettlMonth();
                    }
                    
                    public bool IsSetContractSettlMonth() 
                    { 
                        return IsSetField(Tags.ContractSettlMonth);
                    }
                    public QuickFix.Fields.CPProgram CPProgram
                    { 
                        get 
                        {
                            QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.CPProgram val) 
                    { 
                        this.CPProgram = val;
                    }
                    
                    public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.CPProgram val) 
                    { 
                        return IsSetCPProgram();
                    }
                    
                    public bool IsSetCPProgram() 
                    { 
                        return IsSetField(Tags.CPProgram);
                    }
                    public QuickFix.Fields.CPRegType CPRegType
                    { 
                        get 
                        {
                            QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.CPRegType val) 
                    { 
                        this.CPRegType = val;
                    }
                    
                    public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.CPRegType val) 
                    { 
                        return IsSetCPRegType();
                    }
                    
                    public bool IsSetCPRegType() 
                    { 
                        return IsSetField(Tags.CPRegType);
                    }
                    public QuickFix.Fields.NoEvents NoEvents
                    { 
                        get 
                        {
                            QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoEvents val) 
                    { 
                        this.NoEvents = val;
                    }
                    
                    public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoEvents val) 
                    { 
                        return IsSetNoEvents();
                    }
                    
                    public bool IsSetNoEvents() 
                    { 
                        return IsSetField(Tags.NoEvents);
                    }
                    public QuickFix.Fields.DatedDate DatedDate
                    { 
                        get 
                        {
                            QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.DatedDate val) 
                    { 
                        this.DatedDate = val;
                    }
                    
                    public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.DatedDate val) 
                    { 
                        return IsSetDatedDate();
                    }
                    
                    public bool IsSetDatedDate() 
                    { 
                        return IsSetField(Tags.DatedDate);
                    }
                    public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
                    { 
                        get 
                        {
                            QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InterestAccrualDate val) 
                    { 
                        this.InterestAccrualDate = val;
                    }
                    
                    public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InterestAccrualDate val) 
                    { 
                        return IsSetInterestAccrualDate();
                    }
                    
                    public bool IsSetInterestAccrualDate() 
                    { 
                        return IsSetField(Tags.InterestAccrualDate);
                    }
                    public QuickFix.Fields.SecurityStatus SecurityStatus
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityStatus val) 
                    { 
                        this.SecurityStatus = val;
                    }
                    
                    public QuickFix.Fields.SecurityStatus Get(QuickFix.Fields.SecurityStatus val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecurityStatus val) 
                    { 
                        return IsSetSecurityStatus();
                    }
                    
                    public bool IsSetSecurityStatus() 
                    { 
                        return IsSetField(Tags.SecurityStatus);
                    }
                    public QuickFix.Fields.SettleOnOpenFlag SettleOnOpenFlag
                    { 
                        get 
                        {
                            QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SettleOnOpenFlag val) 
                    { 
                        this.SettleOnOpenFlag = val;
                    }
                    
                    public QuickFix.Fields.SettleOnOpenFlag Get(QuickFix.Fields.SettleOnOpenFlag val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SettleOnOpenFlag val) 
                    { 
                        return IsSetSettleOnOpenFlag();
                    }
                    
                    public bool IsSetSettleOnOpenFlag() 
                    { 
                        return IsSetField(Tags.SettleOnOpenFlag);
                    }
                    public QuickFix.Fields.InstrmtAssignmentMethod InstrmtAssignmentMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.InstrmtAssignmentMethod val) 
                    { 
                        this.InstrmtAssignmentMethod = val;
                    }
                    
                    public QuickFix.Fields.InstrmtAssignmentMethod Get(QuickFix.Fields.InstrmtAssignmentMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
                    { 
                        return IsSetInstrmtAssignmentMethod();
                    }
                    
                    public bool IsSetInstrmtAssignmentMethod() 
                    { 
                        return IsSetField(Tags.InstrmtAssignmentMethod);
                    }
                    public QuickFix.Fields.StrikeMultiplier StrikeMultiplier
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeMultiplier val) 
                    { 
                        this.StrikeMultiplier = val;
                    }
                    
                    public QuickFix.Fields.StrikeMultiplier Get(QuickFix.Fields.StrikeMultiplier val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeMultiplier val) 
                    { 
                        return IsSetStrikeMultiplier();
                    }
                    
                    public bool IsSetStrikeMultiplier() 
                    { 
                        return IsSetField(Tags.StrikeMultiplier);
                    }
                    public QuickFix.Fields.StrikeValue StrikeValue
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikeValue val) 
                    { 
                        this.StrikeValue = val;
                    }
                    
                    public QuickFix.Fields.StrikeValue Get(QuickFix.Fields.StrikeValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikeValue val) 
                    { 
                        return IsSetStrikeValue();
                    }
                    
                    public bool IsSetStrikeValue() 
                    { 
                        return IsSetField(Tags.StrikeValue);
                    }
                    public QuickFix.Fields.MinPriceIncrement MinPriceIncrement
                    { 
                        get 
                        {
                            QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MinPriceIncrement val) 
                    { 
                        this.MinPriceIncrement = val;
                    }
                    
                    public QuickFix.Fields.MinPriceIncrement Get(QuickFix.Fields.MinPriceIncrement val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MinPriceIncrement val) 
                    { 
                        return IsSetMinPriceIncrement();
                    }
                    
                    public bool IsSetMinPriceIncrement() 
                    { 
                        return IsSetField(Tags.MinPriceIncrement);
                    }
                    public QuickFix.Fields.PositionLimit PositionLimit
                    { 
                        get 
                        {
                            QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PositionLimit val) 
                    { 
                        this.PositionLimit = val;
                    }
                    
                    public QuickFix.Fields.PositionLimit Get(QuickFix.Fields.PositionLimit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PositionLimit val) 
                    { 
                        return IsSetPositionLimit();
                    }
                    
                    public bool IsSetPositionLimit() 
                    { 
                        return IsSetField(Tags.PositionLimit);
                    }
                    public QuickFix.Fields.NTPositionLimit NTPositionLimit
                    { 
                        get 
                        {
                            QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NTPositionLimit val) 
                    { 
                        this.NTPositionLimit = val;
                    }
                    
                    public QuickFix.Fields.NTPositionLimit Get(QuickFix.Fields.NTPositionLimit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NTPositionLimit val) 
                    { 
                        return IsSetNTPositionLimit();
                    }
                    
                    public bool IsSetNTPositionLimit() 
                    { 
                        return IsSetField(Tags.NTPositionLimit);
                    }
                    public QuickFix.Fields.NoInstrumentParties NoInstrumentParties
                    { 
                        get 
                        {
                            QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoInstrumentParties val) 
                    { 
                        this.NoInstrumentParties = val;
                    }
                    
                    public QuickFix.Fields.NoInstrumentParties Get(QuickFix.Fields.NoInstrumentParties val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoInstrumentParties val) 
                    { 
                        return IsSetNoInstrumentParties();
                    }
                    
                    public bool IsSetNoInstrumentParties() 
                    { 
                        return IsSetField(Tags.NoInstrumentParties);
                    }
                    public QuickFix.Fields.UnitOfMeasure UnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnitOfMeasure val) 
                    { 
                        this.UnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.UnitOfMeasure Get(QuickFix.Fields.UnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnitOfMeasure val) 
                    { 
                        return IsSetUnitOfMeasure();
                    }
                    
                    public bool IsSetUnitOfMeasure() 
                    { 
                        return IsSetField(Tags.UnitOfMeasure);
                    }
                    public QuickFix.Fields.TimeUnit TimeUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.TimeUnit val) 
                    { 
                        this.TimeUnit = val;
                    }
                    
                    public QuickFix.Fields.TimeUnit Get(QuickFix.Fields.TimeUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.TimeUnit val) 
                    { 
                        return IsSetTimeUnit();
                    }
                    
                    public bool IsSetTimeUnit() 
                    { 
                        return IsSetField(Tags.TimeUnit);
                    }
                    public QuickFix.Fields.MaturityTime MaturityTime
                    { 
                        get 
                        {
                            QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MaturityTime val) 
                    { 
                        this.MaturityTime = val;
                    }
                    
                    public QuickFix.Fields.MaturityTime Get(QuickFix.Fields.MaturityTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MaturityTime val) 
                    { 
                        return IsSetMaturityTime();
                    }
                    
                    public bool IsSetMaturityTime() 
                    { 
                        return IsSetField(Tags.MaturityTime);
                    }
                    public QuickFix.Fields.SecurityGroup SecurityGroup
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityGroup val) 
                    { 
                        this.SecurityGroup = val;
                    }
                    
                    public QuickFix.Fields.SecurityGroup Get(QuickFix.Fields.SecurityGroup val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecurityGroup val) 
                    { 
                        return IsSetSecurityGroup();
                    }
                    
                    public bool IsSetSecurityGroup() 
                    { 
                        return IsSetField(Tags.SecurityGroup);
                    }
                    public QuickFix.Fields.MinPriceIncrementAmount MinPriceIncrementAmount
                    { 
                        get 
                        {
                            QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MinPriceIncrementAmount val) 
                    { 
                        this.MinPriceIncrementAmount = val;
                    }
                    
                    public QuickFix.Fields.MinPriceIncrementAmount Get(QuickFix.Fields.MinPriceIncrementAmount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MinPriceIncrementAmount val) 
                    { 
                        return IsSetMinPriceIncrementAmount();
                    }
                    
                    public bool IsSetMinPriceIncrementAmount() 
                    { 
                        return IsSetField(Tags.MinPriceIncrementAmount);
                    }
                    public QuickFix.Fields.UnitOfMeasureQty UnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnitOfMeasureQty val) 
                    { 
                        this.UnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.UnitOfMeasureQty Get(QuickFix.Fields.UnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnitOfMeasureQty val) 
                    { 
                        return IsSetUnitOfMeasureQty();
                    }
                    
                    public bool IsSetUnitOfMeasureQty() 
                    { 
                        return IsSetField(Tags.UnitOfMeasureQty);
                    }
                    public QuickFix.Fields.SecurityXMLLen SecurityXMLLen
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityXMLLen val) 
                    { 
                        this.SecurityXMLLen = val;
                    }
                    
                    public QuickFix.Fields.SecurityXMLLen Get(QuickFix.Fields.SecurityXMLLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecurityXMLLen val) 
                    { 
                        return IsSetSecurityXMLLen();
                    }
                    
                    public bool IsSetSecurityXMLLen() 
                    { 
                        return IsSetField(Tags.SecurityXMLLen);
                    }
                    public QuickFix.Fields.SecurityXML SecurityXML
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityXML val) 
                    { 
                        this.SecurityXML = val;
                    }
                    
                    public QuickFix.Fields.SecurityXML Get(QuickFix.Fields.SecurityXML val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecurityXML val) 
                    { 
                        return IsSetSecurityXML();
                    }
                    
                    public bool IsSetSecurityXML() 
                    { 
                        return IsSetField(Tags.SecurityXML);
                    }
                    public QuickFix.Fields.SecurityXMLSchema SecurityXMLSchema
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SecurityXMLSchema val) 
                    { 
                        this.SecurityXMLSchema = val;
                    }
                    
                    public QuickFix.Fields.SecurityXMLSchema Get(QuickFix.Fields.SecurityXMLSchema val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SecurityXMLSchema val) 
                    { 
                        return IsSetSecurityXMLSchema();
                    }
                    
                    public bool IsSetSecurityXMLSchema() 
                    { 
                        return IsSetField(Tags.SecurityXMLSchema);
                    }
                    public QuickFix.Fields.ProductComplex ProductComplex
                    { 
                        get 
                        {
                            QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ProductComplex val) 
                    { 
                        this.ProductComplex = val;
                    }
                    
                    public QuickFix.Fields.ProductComplex Get(QuickFix.Fields.ProductComplex val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ProductComplex val) 
                    { 
                        return IsSetProductComplex();
                    }
                    
                    public bool IsSetProductComplex() 
                    { 
                        return IsSetField(Tags.ProductComplex);
                    }
                    public QuickFix.Fields.PriceUnitOfMeasure PriceUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PriceUnitOfMeasure val) 
                    { 
                        this.PriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.PriceUnitOfMeasure Get(QuickFix.Fields.PriceUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PriceUnitOfMeasure val) 
                    { 
                        return IsSetPriceUnitOfMeasure();
                    }
                    
                    public bool IsSetPriceUnitOfMeasure() 
                    { 
                        return IsSetField(Tags.PriceUnitOfMeasure);
                    }
                    public QuickFix.Fields.PriceUnitOfMeasureQty PriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                    { 
                        this.PriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.PriceUnitOfMeasureQty Get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                    { 
                        return IsSetPriceUnitOfMeasureQty();
                    }
                    
                    public bool IsSetPriceUnitOfMeasureQty() 
                    { 
                        return IsSetField(Tags.PriceUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.SettlMethod SettlMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SettlMethod val) 
                    { 
                        this.SettlMethod = val;
                    }
                    
                    public QuickFix.Fields.SettlMethod Get(QuickFix.Fields.SettlMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SettlMethod val) 
                    { 
                        return IsSetSettlMethod();
                    }
                    
                    public bool IsSetSettlMethod() 
                    { 
                        return IsSetField(Tags.SettlMethod);
                    }
                    public QuickFix.Fields.ExerciseStyle ExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ExerciseStyle val) 
                    { 
                        this.ExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.ExerciseStyle Get(QuickFix.Fields.ExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ExerciseStyle val) 
                    { 
                        return IsSetExerciseStyle();
                    }
                    
                    public bool IsSetExerciseStyle() 
                    { 
                        return IsSetField(Tags.ExerciseStyle);
                    }
                    public QuickFix.Fields.OptPayoutAmount OptPayoutAmount
                    { 
                        get 
                        {
                            QuickFix.Fields.OptPayoutAmount val = new QuickFix.Fields.OptPayoutAmount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OptPayoutAmount val) 
                    { 
                        this.OptPayoutAmount = val;
                    }
                    
                    public QuickFix.Fields.OptPayoutAmount Get(QuickFix.Fields.OptPayoutAmount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OptPayoutAmount val) 
                    { 
                        return IsSetOptPayoutAmount();
                    }
                    
                    public bool IsSetOptPayoutAmount() 
                    { 
                        return IsSetField(Tags.OptPayoutAmount);
                    }
                    public QuickFix.Fields.PriceQuoteMethod PriceQuoteMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PriceQuoteMethod val) 
                    { 
                        this.PriceQuoteMethod = val;
                    }
                    
                    public QuickFix.Fields.PriceQuoteMethod Get(QuickFix.Fields.PriceQuoteMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PriceQuoteMethod val) 
                    { 
                        return IsSetPriceQuoteMethod();
                    }
                    
                    public bool IsSetPriceQuoteMethod() 
                    { 
                        return IsSetField(Tags.PriceQuoteMethod);
                    }
                    public QuickFix.Fields.ListMethod ListMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ListMethod val) 
                    { 
                        this.ListMethod = val;
                    }
                    
                    public QuickFix.Fields.ListMethod Get(QuickFix.Fields.ListMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ListMethod val) 
                    { 
                        return IsSetListMethod();
                    }
                    
                    public bool IsSetListMethod() 
                    { 
                        return IsSetField(Tags.ListMethod);
                    }
                    public QuickFix.Fields.CapPrice CapPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.CapPrice val) 
                    { 
                        this.CapPrice = val;
                    }
                    
                    public QuickFix.Fields.CapPrice Get(QuickFix.Fields.CapPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.CapPrice val) 
                    { 
                        return IsSetCapPrice();
                    }
                    
                    public bool IsSetCapPrice() 
                    { 
                        return IsSetField(Tags.CapPrice);
                    }
                    public QuickFix.Fields.FloorPrice FloorPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.FloorPrice val) 
                    { 
                        this.FloorPrice = val;
                    }
                    
                    public QuickFix.Fields.FloorPrice Get(QuickFix.Fields.FloorPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.FloorPrice val) 
                    { 
                        return IsSetFloorPrice();
                    }
                    
                    public bool IsSetFloorPrice() 
                    { 
                        return IsSetField(Tags.FloorPrice);
                    }
                    public QuickFix.Fields.PutOrCall PutOrCall
                    { 
                        get 
                        {
                            QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PutOrCall val) 
                    { 
                        this.PutOrCall = val;
                    }
                    
                    public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PutOrCall val) 
                    { 
                        return IsSetPutOrCall();
                    }
                    
                    public bool IsSetPutOrCall() 
                    { 
                        return IsSetField(Tags.PutOrCall);
                    }
                    public QuickFix.Fields.FlexibleIndicator FlexibleIndicator
                    { 
                        get 
                        {
                            QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.FlexibleIndicator val) 
                    { 
                        this.FlexibleIndicator = val;
                    }
                    
                    public QuickFix.Fields.FlexibleIndicator Get(QuickFix.Fields.FlexibleIndicator val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.FlexibleIndicator val) 
                    { 
                        return IsSetFlexibleIndicator();
                    }
                    
                    public bool IsSetFlexibleIndicator() 
                    { 
                        return IsSetField(Tags.FlexibleIndicator);
                    }
                    public QuickFix.Fields.FlexProductEligibilityIndicator FlexProductEligibilityIndicator
                    { 
                        get 
                        {
                            QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                    { 
                        this.FlexProductEligibilityIndicator = val;
                    }
                    
                    public QuickFix.Fields.FlexProductEligibilityIndicator Get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                    { 
                        return IsSetFlexProductEligibilityIndicator();
                    }
                    
                    public bool IsSetFlexProductEligibilityIndicator() 
                    { 
                        return IsSetField(Tags.FlexProductEligibilityIndicator);
                    }
                    public QuickFix.Fields.ValuationMethod ValuationMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.ValuationMethod val = new QuickFix.Fields.ValuationMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ValuationMethod val) 
                    { 
                        this.ValuationMethod = val;
                    }
                    
                    public QuickFix.Fields.ValuationMethod Get(QuickFix.Fields.ValuationMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ValuationMethod val) 
                    { 
                        return IsSetValuationMethod();
                    }
                    
                    public bool IsSetValuationMethod() 
                    { 
                        return IsSetField(Tags.ValuationMethod);
                    }
                    public QuickFix.Fields.ContractMultiplierUnit ContractMultiplierUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.ContractMultiplierUnit val = new QuickFix.Fields.ContractMultiplierUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContractMultiplierUnit val) 
                    { 
                        this.ContractMultiplierUnit = val;
                    }
                    
                    public QuickFix.Fields.ContractMultiplierUnit Get(QuickFix.Fields.ContractMultiplierUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContractMultiplierUnit val) 
                    { 
                        return IsSetContractMultiplierUnit();
                    }
                    
                    public bool IsSetContractMultiplierUnit() 
                    { 
                        return IsSetField(Tags.ContractMultiplierUnit);
                    }
                    public QuickFix.Fields.FlowScheduleType FlowScheduleType
                    { 
                        get 
                        {
                            QuickFix.Fields.FlowScheduleType val = new QuickFix.Fields.FlowScheduleType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.FlowScheduleType val) 
                    { 
                        this.FlowScheduleType = val;
                    }
                    
                    public QuickFix.Fields.FlowScheduleType Get(QuickFix.Fields.FlowScheduleType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.FlowScheduleType val) 
                    { 
                        return IsSetFlowScheduleType();
                    }
                    
                    public bool IsSetFlowScheduleType() 
                    { 
                        return IsSetField(Tags.FlowScheduleType);
                    }
                    public QuickFix.Fields.RestructuringType RestructuringType
                    { 
                        get 
                        {
                            QuickFix.Fields.RestructuringType val = new QuickFix.Fields.RestructuringType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RestructuringType val) 
                    { 
                        this.RestructuringType = val;
                    }
                    
                    public QuickFix.Fields.RestructuringType Get(QuickFix.Fields.RestructuringType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RestructuringType val) 
                    { 
                        return IsSetRestructuringType();
                    }
                    
                    public bool IsSetRestructuringType() 
                    { 
                        return IsSetField(Tags.RestructuringType);
                    }
                    public QuickFix.Fields.Seniority Seniority
                    { 
                        get 
                        {
                            QuickFix.Fields.Seniority val = new QuickFix.Fields.Seniority();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.Seniority val) 
                    { 
                        this.Seniority = val;
                    }
                    
                    public QuickFix.Fields.Seniority Get(QuickFix.Fields.Seniority val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.Seniority val) 
                    { 
                        return IsSetSeniority();
                    }
                    
                    public bool IsSetSeniority() 
                    { 
                        return IsSetField(Tags.Seniority);
                    }
                    public QuickFix.Fields.NotionalPercentageOutstanding NotionalPercentageOutstanding
                    { 
                        get 
                        {
                            QuickFix.Fields.NotionalPercentageOutstanding val = new QuickFix.Fields.NotionalPercentageOutstanding();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NotionalPercentageOutstanding val) 
                    { 
                        this.NotionalPercentageOutstanding = val;
                    }
                    
                    public QuickFix.Fields.NotionalPercentageOutstanding Get(QuickFix.Fields.NotionalPercentageOutstanding val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NotionalPercentageOutstanding val) 
                    { 
                        return IsSetNotionalPercentageOutstanding();
                    }
                    
                    public bool IsSetNotionalPercentageOutstanding() 
                    { 
                        return IsSetField(Tags.NotionalPercentageOutstanding);
                    }
                    public QuickFix.Fields.OriginalNotionalPercentageOutstanding OriginalNotionalPercentageOutstanding
                    { 
                        get 
                        {
                            QuickFix.Fields.OriginalNotionalPercentageOutstanding val = new QuickFix.Fields.OriginalNotionalPercentageOutstanding();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                    { 
                        this.OriginalNotionalPercentageOutstanding = val;
                    }
                    
                    public QuickFix.Fields.OriginalNotionalPercentageOutstanding Get(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OriginalNotionalPercentageOutstanding val) 
                    { 
                        return IsSetOriginalNotionalPercentageOutstanding();
                    }
                    
                    public bool IsSetOriginalNotionalPercentageOutstanding() 
                    { 
                        return IsSetField(Tags.OriginalNotionalPercentageOutstanding);
                    }
                    public QuickFix.Fields.AttachmentPoint AttachmentPoint
                    { 
                        get 
                        {
                            QuickFix.Fields.AttachmentPoint val = new QuickFix.Fields.AttachmentPoint();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.AttachmentPoint val) 
                    { 
                        this.AttachmentPoint = val;
                    }
                    
                    public QuickFix.Fields.AttachmentPoint Get(QuickFix.Fields.AttachmentPoint val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.AttachmentPoint val) 
                    { 
                        return IsSetAttachmentPoint();
                    }
                    
                    public bool IsSetAttachmentPoint() 
                    { 
                        return IsSetField(Tags.AttachmentPoint);
                    }
                    public QuickFix.Fields.DetachmentPoint DetachmentPoint
                    { 
                        get 
                        {
                            QuickFix.Fields.DetachmentPoint val = new QuickFix.Fields.DetachmentPoint();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.DetachmentPoint val) 
                    { 
                        this.DetachmentPoint = val;
                    }
                    
                    public QuickFix.Fields.DetachmentPoint Get(QuickFix.Fields.DetachmentPoint val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.DetachmentPoint val) 
                    { 
                        return IsSetDetachmentPoint();
                    }
                    
                    public bool IsSetDetachmentPoint() 
                    { 
                        return IsSetField(Tags.DetachmentPoint);
                    }
                    public QuickFix.Fields.StrikePriceDeterminationMethod StrikePriceDeterminationMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikePriceDeterminationMethod val = new QuickFix.Fields.StrikePriceDeterminationMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                    { 
                        this.StrikePriceDeterminationMethod = val;
                    }
                    
                    public QuickFix.Fields.StrikePriceDeterminationMethod Get(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikePriceDeterminationMethod val) 
                    { 
                        return IsSetStrikePriceDeterminationMethod();
                    }
                    
                    public bool IsSetStrikePriceDeterminationMethod() 
                    { 
                        return IsSetField(Tags.StrikePriceDeterminationMethod);
                    }
                    public QuickFix.Fields.StrikePriceBoundaryMethod StrikePriceBoundaryMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikePriceBoundaryMethod val = new QuickFix.Fields.StrikePriceBoundaryMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                    { 
                        this.StrikePriceBoundaryMethod = val;
                    }
                    
                    public QuickFix.Fields.StrikePriceBoundaryMethod Get(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikePriceBoundaryMethod val) 
                    { 
                        return IsSetStrikePriceBoundaryMethod();
                    }
                    
                    public bool IsSetStrikePriceBoundaryMethod() 
                    { 
                        return IsSetField(Tags.StrikePriceBoundaryMethod);
                    }
                    public QuickFix.Fields.StrikePriceBoundaryPrecision StrikePriceBoundaryPrecision
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikePriceBoundaryPrecision val = new QuickFix.Fields.StrikePriceBoundaryPrecision();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                    { 
                        this.StrikePriceBoundaryPrecision = val;
                    }
                    
                    public QuickFix.Fields.StrikePriceBoundaryPrecision Get(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StrikePriceBoundaryPrecision val) 
                    { 
                        return IsSetStrikePriceBoundaryPrecision();
                    }
                    
                    public bool IsSetStrikePriceBoundaryPrecision() 
                    { 
                        return IsSetField(Tags.StrikePriceBoundaryPrecision);
                    }
                    public QuickFix.Fields.UnderlyingPriceDeterminationMethod UnderlyingPriceDeterminationMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingPriceDeterminationMethod val = new QuickFix.Fields.UnderlyingPriceDeterminationMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                    { 
                        this.UnderlyingPriceDeterminationMethod = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceDeterminationMethod Get(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPriceDeterminationMethod val) 
                    { 
                        return IsSetUnderlyingPriceDeterminationMethod();
                    }
                    
                    public bool IsSetUnderlyingPriceDeterminationMethod() 
                    { 
                        return IsSetField(Tags.UnderlyingPriceDeterminationMethod);
                    }
                    public QuickFix.Fields.OptPayoutType OptPayoutType
                    { 
                        get 
                        {
                            QuickFix.Fields.OptPayoutType val = new QuickFix.Fields.OptPayoutType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.OptPayoutType val) 
                    { 
                        this.OptPayoutType = val;
                    }
                    
                    public QuickFix.Fields.OptPayoutType Get(QuickFix.Fields.OptPayoutType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.OptPayoutType val) 
                    { 
                        return IsSetOptPayoutType();
                    }
                    
                    public bool IsSetOptPayoutType() 
                    { 
                        return IsSetField(Tags.OptPayoutType);
                    }
                    public QuickFix.Fields.NoComplexEvents NoComplexEvents
                    { 
                        get 
                        {
                            QuickFix.Fields.NoComplexEvents val = new QuickFix.Fields.NoComplexEvents();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoComplexEvents val) 
                    { 
                        this.NoComplexEvents = val;
                    }
                    
                    public QuickFix.Fields.NoComplexEvents Get(QuickFix.Fields.NoComplexEvents val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoComplexEvents val) 
                    { 
                        return IsSetNoComplexEvents();
                    }
                    
                    public bool IsSetNoComplexEvents() 
                    { 
                        return IsSetField(Tags.NoComplexEvents);
                    }
                    public QuickFix.Fields.SettlType SettlType
                    { 
                        get 
                        {
                            QuickFix.Fields.SettlType val = new QuickFix.Fields.SettlType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SettlType val) 
                    { 
                        this.SettlType = val;
                    }
                    
                    public QuickFix.Fields.SettlType Get(QuickFix.Fields.SettlType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SettlType val) 
                    { 
                        return IsSetSettlType();
                    }
                    
                    public bool IsSetSettlType() 
                    { 
                        return IsSetField(Tags.SettlType);
                    }
                    public QuickFix.Fields.MDEntrySize MDEntrySize
                    { 
                        get 
                        {
                            QuickFix.Fields.MDEntrySize val = new QuickFix.Fields.MDEntrySize();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MDEntrySize val) 
                    { 
                        this.MDEntrySize = val;
                    }
                    
                    public QuickFix.Fields.MDEntrySize Get(QuickFix.Fields.MDEntrySize val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MDEntrySize val) 
                    { 
                        return IsSetMDEntrySize();
                    }
                    
                    public bool IsSetMDEntrySize() 
                    { 
                        return IsSetField(Tags.MDEntrySize);
                    }
                    public QuickFix.Fields.MDStreamID MDStreamID
                    { 
                        get 
                        {
                            QuickFix.Fields.MDStreamID val = new QuickFix.Fields.MDStreamID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.MDStreamID val) 
                    { 
                        this.MDStreamID = val;
                    }
                    
                    public QuickFix.Fields.MDStreamID Get(QuickFix.Fields.MDStreamID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.MDStreamID val) 
                    { 
                        return IsSetMDStreamID();
                    }
                    
                    public bool IsSetMDStreamID() 
                    { 
                        return IsSetField(Tags.MDStreamID);
                    }
                                    public class NoSecurityAltIDGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                    
                        public NoSecurityAltIDGroup() 
                          :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoSecurityAltIDGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.SecurityAltID SecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.SecurityAltID val) 
                        { 
                            this.SecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.SecurityAltID val) 
                        { 
                            return IsSetSecurityAltID();
                        }
                        
                        public bool IsSetSecurityAltID() 
                        { 
                            return IsSetField(Tags.SecurityAltID);
                        }
                        public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.SecurityAltIDSource val) 
                        { 
                            this.SecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) 
                        { 
                            return IsSetSecurityAltIDSource();
                        }
                        
                        public bool IsSetSecurityAltIDSource() 
                        { 
                            return IsSetField(Tags.SecurityAltIDSource);
                        }
                    
                    }
                    public class NoEventsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                    
                        public NoEventsGroup() 
                          :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoEventsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.EventType EventType
                        { 
                            get 
                            {
                                QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.EventType val) 
                        { 
                            this.EventType = val;
                        }
                        
                        public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.EventType val) 
                        { 
                            return IsSetEventType();
                        }
                        
                        public bool IsSetEventType() 
                        { 
                            return IsSetField(Tags.EventType);
                        }
                        public QuickFix.Fields.EventDate EventDate
                        { 
                            get 
                            {
                                QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.EventDate val) 
                        { 
                            this.EventDate = val;
                        }
                        
                        public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.EventDate val) 
                        { 
                            return IsSetEventDate();
                        }
                        
                        public bool IsSetEventDate() 
                        { 
                            return IsSetField(Tags.EventDate);
                        }
                        public QuickFix.Fields.EventPx EventPx
                        { 
                            get 
                            {
                                QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.EventPx val) 
                        { 
                            this.EventPx = val;
                        }
                        
                        public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.EventPx val) 
                        { 
                            return IsSetEventPx();
                        }
                        
                        public bool IsSetEventPx() 
                        { 
                            return IsSetField(Tags.EventPx);
                        }
                        public QuickFix.Fields.EventText EventText
                        { 
                            get 
                            {
                                QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.EventText val) 
                        { 
                            this.EventText = val;
                        }
                        
                        public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.EventText val) 
                        { 
                            return IsSetEventText();
                        }
                        
                        public bool IsSetEventText() 
                        { 
                            return IsSetField(Tags.EventText);
                        }
                        public QuickFix.Fields.EventTime EventTime
                        { 
                            get 
                            {
                                QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.EventTime val) 
                        { 
                            this.EventTime = val;
                        }
                        
                        public QuickFix.Fields.EventTime Get(QuickFix.Fields.EventTime val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.EventTime val) 
                        { 
                            return IsSetEventTime();
                        }
                        
                        public bool IsSetEventTime() 
                        { 
                            return IsSetField(Tags.EventTime);
                        }
                    
                    }
                    public class NoInstrumentPartiesGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                    
                        public NoInstrumentPartiesGroup() 
                          :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoInstrumentPartiesGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.InstrumentPartyID InstrumentPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.InstrumentPartyID val) 
                        { 
                            this.InstrumentPartyID = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartyID Get(QuickFix.Fields.InstrumentPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.InstrumentPartyID val) 
                        { 
                            return IsSetInstrumentPartyID();
                        }
                        
                        public bool IsSetInstrumentPartyID() 
                        { 
                            return IsSetField(Tags.InstrumentPartyID);
                        }
                        public QuickFix.Fields.InstrumentPartyIDSource InstrumentPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.InstrumentPartyIDSource val) 
                        { 
                            this.InstrumentPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartyIDSource Get(QuickFix.Fields.InstrumentPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                        { 
                            return IsSetInstrumentPartyIDSource();
                        }
                        
                        public bool IsSetInstrumentPartyIDSource() 
                        { 
                            return IsSetField(Tags.InstrumentPartyIDSource);
                        }
                        public QuickFix.Fields.InstrumentPartyRole InstrumentPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.InstrumentPartyRole val) 
                        { 
                            this.InstrumentPartyRole = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartyRole Get(QuickFix.Fields.InstrumentPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.InstrumentPartyRole val) 
                        { 
                            return IsSetInstrumentPartyRole();
                        }
                        
                        public bool IsSetInstrumentPartyRole() 
                        { 
                            return IsSetField(Tags.InstrumentPartyRole);
                        }
                        public QuickFix.Fields.NoInstrumentPartySubIDs NoInstrumentPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                        { 
                            this.NoInstrumentPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoInstrumentPartySubIDs Get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                        { 
                            return IsSetNoInstrumentPartySubIDs();
                        }
                        
                        public bool IsSetNoInstrumentPartySubIDs() 
                        { 
                            return IsSetField(Tags.NoInstrumentPartySubIDs);
                        }
                                            public class NoInstrumentPartySubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                        
                            public NoInstrumentPartySubIDsGroup() 
                              :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoInstrumentPartySubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.InstrumentPartySubID InstrumentPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.InstrumentPartySubID val) 
                            { 
                                this.InstrumentPartySubID = val;
                            }
                            
                            public QuickFix.Fields.InstrumentPartySubID Get(QuickFix.Fields.InstrumentPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.InstrumentPartySubID val) 
                            { 
                                return IsSetInstrumentPartySubID();
                            }
                            
                            public bool IsSetInstrumentPartySubID() 
                            { 
                                return IsSetField(Tags.InstrumentPartySubID);
                            }
                            public QuickFix.Fields.InstrumentPartySubIDType InstrumentPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.InstrumentPartySubIDType val) 
                            { 
                                this.InstrumentPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.InstrumentPartySubIDType Get(QuickFix.Fields.InstrumentPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                            { 
                                return IsSetInstrumentPartySubIDType();
                            }
                            
                            public bool IsSetInstrumentPartySubIDType() 
                            { 
                                return IsSetField(Tags.InstrumentPartySubIDType);
                            }
                        
                        }
                    }
                    public class NoComplexEventsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};
                    
                        public NoComplexEventsGroup() 
                          :base( Tags.NoComplexEvents, Tags.ComplexEventType, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoComplexEventsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.ComplexEventType ComplexEventType
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventType val = new QuickFix.Fields.ComplexEventType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventType val) 
                        { 
                            this.ComplexEventType = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventType Get(QuickFix.Fields.ComplexEventType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventType val) 
                        { 
                            return IsSetComplexEventType();
                        }
                        
                        public bool IsSetComplexEventType() 
                        { 
                            return IsSetField(Tags.ComplexEventType);
                        }
                        public QuickFix.Fields.ComplexOptPayoutAmount ComplexOptPayoutAmount
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexOptPayoutAmount val = new QuickFix.Fields.ComplexOptPayoutAmount();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexOptPayoutAmount val) 
                        { 
                            this.ComplexOptPayoutAmount = val;
                        }
                        
                        public QuickFix.Fields.ComplexOptPayoutAmount Get(QuickFix.Fields.ComplexOptPayoutAmount val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexOptPayoutAmount val) 
                        { 
                            return IsSetComplexOptPayoutAmount();
                        }
                        
                        public bool IsSetComplexOptPayoutAmount() 
                        { 
                            return IsSetField(Tags.ComplexOptPayoutAmount);
                        }
                        public QuickFix.Fields.ComplexEventPrice ComplexEventPrice
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventPrice val = new QuickFix.Fields.ComplexEventPrice();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventPrice val) 
                        { 
                            this.ComplexEventPrice = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventPrice Get(QuickFix.Fields.ComplexEventPrice val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventPrice val) 
                        { 
                            return IsSetComplexEventPrice();
                        }
                        
                        public bool IsSetComplexEventPrice() 
                        { 
                            return IsSetField(Tags.ComplexEventPrice);
                        }
                        public QuickFix.Fields.ComplexEventPriceBoundaryMethod ComplexEventPriceBoundaryMethod
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventPriceBoundaryMethod val = new QuickFix.Fields.ComplexEventPriceBoundaryMethod();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                        { 
                            this.ComplexEventPriceBoundaryMethod = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventPriceBoundaryMethod Get(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryMethod val) 
                        { 
                            return IsSetComplexEventPriceBoundaryMethod();
                        }
                        
                        public bool IsSetComplexEventPriceBoundaryMethod() 
                        { 
                            return IsSetField(Tags.ComplexEventPriceBoundaryMethod);
                        }
                        public QuickFix.Fields.ComplexEventPriceBoundaryPrecision ComplexEventPriceBoundaryPrecision
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventPriceBoundaryPrecision val = new QuickFix.Fields.ComplexEventPriceBoundaryPrecision();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                        { 
                            this.ComplexEventPriceBoundaryPrecision = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventPriceBoundaryPrecision Get(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventPriceBoundaryPrecision val) 
                        { 
                            return IsSetComplexEventPriceBoundaryPrecision();
                        }
                        
                        public bool IsSetComplexEventPriceBoundaryPrecision() 
                        { 
                            return IsSetField(Tags.ComplexEventPriceBoundaryPrecision);
                        }
                        public QuickFix.Fields.ComplexEventPriceTimeType ComplexEventPriceTimeType
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventPriceTimeType val = new QuickFix.Fields.ComplexEventPriceTimeType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventPriceTimeType val) 
                        { 
                            this.ComplexEventPriceTimeType = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventPriceTimeType Get(QuickFix.Fields.ComplexEventPriceTimeType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventPriceTimeType val) 
                        { 
                            return IsSetComplexEventPriceTimeType();
                        }
                        
                        public bool IsSetComplexEventPriceTimeType() 
                        { 
                            return IsSetField(Tags.ComplexEventPriceTimeType);
                        }
                        public QuickFix.Fields.ComplexEventCondition ComplexEventCondition
                        { 
                            get 
                            {
                                QuickFix.Fields.ComplexEventCondition val = new QuickFix.Fields.ComplexEventCondition();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ComplexEventCondition val) 
                        { 
                            this.ComplexEventCondition = val;
                        }
                        
                        public QuickFix.Fields.ComplexEventCondition Get(QuickFix.Fields.ComplexEventCondition val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ComplexEventCondition val) 
                        { 
                            return IsSetComplexEventCondition();
                        }
                        
                        public bool IsSetComplexEventCondition() 
                        { 
                            return IsSetField(Tags.ComplexEventCondition);
                        }
                        public QuickFix.Fields.NoComplexEventDates NoComplexEventDates
                        { 
                            get 
                            {
                                QuickFix.Fields.NoComplexEventDates val = new QuickFix.Fields.NoComplexEventDates();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoComplexEventDates val) 
                        { 
                            this.NoComplexEventDates = val;
                        }
                        
                        public QuickFix.Fields.NoComplexEventDates Get(QuickFix.Fields.NoComplexEventDates val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoComplexEventDates val) 
                        { 
                            return IsSetNoComplexEventDates();
                        }
                        
                        public bool IsSetNoComplexEventDates() 
                        { 
                            return IsSetField(Tags.NoComplexEventDates);
                        }
                                            public class NoComplexEventDatesGroup : Group
                        {
                            public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};
                        
                            public NoComplexEventDatesGroup() 
                              :base( Tags.NoComplexEventDates, Tags.ComplexEventStartDate, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoComplexEventDatesGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.ComplexEventStartDate ComplexEventStartDate
                            { 
                                get 
                                {
                                    QuickFix.Fields.ComplexEventStartDate val = new QuickFix.Fields.ComplexEventStartDate();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.ComplexEventStartDate val) 
                            { 
                                this.ComplexEventStartDate = val;
                            }
                            
                            public QuickFix.Fields.ComplexEventStartDate Get(QuickFix.Fields.ComplexEventStartDate val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.ComplexEventStartDate val) 
                            { 
                                return IsSetComplexEventStartDate();
                            }
                            
                            public bool IsSetComplexEventStartDate() 
                            { 
                                return IsSetField(Tags.ComplexEventStartDate);
                            }
                            public QuickFix.Fields.ComplexEventEndDate ComplexEventEndDate
                            { 
                                get 
                                {
                                    QuickFix.Fields.ComplexEventEndDate val = new QuickFix.Fields.ComplexEventEndDate();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.ComplexEventEndDate val) 
                            { 
                                this.ComplexEventEndDate = val;
                            }
                            
                            public QuickFix.Fields.ComplexEventEndDate Get(QuickFix.Fields.ComplexEventEndDate val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.ComplexEventEndDate val) 
                            { 
                                return IsSetComplexEventEndDate();
                            }
                            
                            public bool IsSetComplexEventEndDate() 
                            { 
                                return IsSetField(Tags.ComplexEventEndDate);
                            }
                            public QuickFix.Fields.NoComplexEventTimes NoComplexEventTimes
                            { 
                                get 
                                {
                                    QuickFix.Fields.NoComplexEventTimes val = new QuickFix.Fields.NoComplexEventTimes();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.NoComplexEventTimes val) 
                            { 
                                this.NoComplexEventTimes = val;
                            }
                            
                            public QuickFix.Fields.NoComplexEventTimes Get(QuickFix.Fields.NoComplexEventTimes val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.NoComplexEventTimes val) 
                            { 
                                return IsSetNoComplexEventTimes();
                            }
                            
                            public bool IsSetNoComplexEventTimes() 
                            { 
                                return IsSetField(Tags.NoComplexEventTimes);
                            }
                                                    public class NoComplexEventTimesGroup : Group
                            {
                                public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};
                            
                                public NoComplexEventTimesGroup() 
                                  :base( Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, fieldOrder)
                                {
                                }
                            
                                public override Group Clone()
                                {
                                    var clone = new NoComplexEventTimesGroup();
                                    clone.CopyStateFrom(this);
                                    return clone;
                                }
                            
                                                            public QuickFix.Fields.ComplexEventStartTime ComplexEventStartTime
                                { 
                                    get 
                                    {
                                        QuickFix.Fields.ComplexEventStartTime val = new QuickFix.Fields.ComplexEventStartTime();
                                        GetField(val);
                                        return val;
                                    }
                                    set { SetField(value); }
                                }
                                
                                public void Set(QuickFix.Fields.ComplexEventStartTime val) 
                                { 
                                    this.ComplexEventStartTime = val;
                                }
                                
                                public QuickFix.Fields.ComplexEventStartTime Get(QuickFix.Fields.ComplexEventStartTime val) 
                                { 
                                    GetField(val);
                                    return val;
                                }
                                
                                public bool IsSet(QuickFix.Fields.ComplexEventStartTime val) 
                                { 
                                    return IsSetComplexEventStartTime();
                                }
                                
                                public bool IsSetComplexEventStartTime() 
                                { 
                                    return IsSetField(Tags.ComplexEventStartTime);
                                }
                                public QuickFix.Fields.ComplexEventEndTime ComplexEventEndTime
                                { 
                                    get 
                                    {
                                        QuickFix.Fields.ComplexEventEndTime val = new QuickFix.Fields.ComplexEventEndTime();
                                        GetField(val);
                                        return val;
                                    }
                                    set { SetField(value); }
                                }
                                
                                public void Set(QuickFix.Fields.ComplexEventEndTime val) 
                                { 
                                    this.ComplexEventEndTime = val;
                                }
                                
                                public QuickFix.Fields.ComplexEventEndTime Get(QuickFix.Fields.ComplexEventEndTime val) 
                                { 
                                    GetField(val);
                                    return val;
                                }
                                
                                public bool IsSet(QuickFix.Fields.ComplexEventEndTime val) 
                                { 
                                    return IsSetComplexEventEndTime();
                                }
                                
                                public bool IsSetComplexEventEndTime() 
                                { 
                                    return IsSetField(Tags.ComplexEventEndTime);
                                }
                            
                            }
                        }
                    }
                }
            }
        }
    }
}
