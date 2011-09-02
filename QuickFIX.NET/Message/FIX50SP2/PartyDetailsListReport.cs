// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class PartyDetailsListReport : Message
        {
            public const string MsgType = "CG";

            public PartyDetailsListReport() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("CG"));
            }

            public PartyDetailsListReport(
                    QuickFix.Fields.PartyDetailsListReportID aPartyDetailsListReportID
                ) : this()
            {
                this.partyDetailsListReportID = aPartyDetailsListReportID;
            }

            public QuickFix.Fields.ApplID applID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID get(QuickFix.Fields.ApplID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplID val) 
            { 
                return isSetApplID();
            }
            
            public bool isSetApplID() 
            { 
                return isSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum get(QuickFix.Fields.ApplSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return isSetApplSeqNum();
            }
            
            public bool isSetApplSeqNum() 
            { 
                return isSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return isSetApplLastSeqNum();
            }
            
            public bool isSetApplLastSeqNum() 
            { 
                return isSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag get(QuickFix.Fields.ApplResendFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return isSetApplResendFlag();
            }
            
            public bool isSetApplResendFlag() 
            { 
                return isSetField(Tags.ApplResendFlag);
            }
            public QuickFix.Fields.PartyDetailsListReportID partyDetailsListReportID
            { 
                get 
                {
                    QuickFix.Fields.PartyDetailsListReportID val = new QuickFix.Fields.PartyDetailsListReportID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                this.partyDetailsListReportID = val;
            }
            
            public QuickFix.Fields.PartyDetailsListReportID get(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                return isSetPartyDetailsListReportID();
            }
            
            public bool isSetPartyDetailsListReportID() 
            { 
                return isSetField(Tags.PartyDetailsListReportID);
            }
            public QuickFix.Fields.PartyDetailsListRequestID partyDetailsListRequestID
            { 
                get 
                {
                    QuickFix.Fields.PartyDetailsListRequestID val = new QuickFix.Fields.PartyDetailsListRequestID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                this.partyDetailsListRequestID = val;
            }
            
            public QuickFix.Fields.PartyDetailsListRequestID get(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                return isSetPartyDetailsListRequestID();
            }
            
            public bool isSetPartyDetailsListRequestID() 
            { 
                return isSetField(Tags.PartyDetailsListRequestID);
            }
            public QuickFix.Fields.PartyDetailsRequestResult partyDetailsRequestResult
            { 
                get 
                {
                    QuickFix.Fields.PartyDetailsRequestResult val = new QuickFix.Fields.PartyDetailsRequestResult();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                this.partyDetailsRequestResult = val;
            }
            
            public QuickFix.Fields.PartyDetailsRequestResult get(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                return isSetPartyDetailsRequestResult();
            }
            
            public bool isSetPartyDetailsRequestResult() 
            { 
                return isSetField(Tags.PartyDetailsRequestResult);
            }
            public QuickFix.Fields.TotNoPartyList totNoPartyList
            { 
                get 
                {
                    QuickFix.Fields.TotNoPartyList val = new QuickFix.Fields.TotNoPartyList();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotNoPartyList val) 
            { 
                this.totNoPartyList = val;
            }
            
            public QuickFix.Fields.TotNoPartyList get(QuickFix.Fields.TotNoPartyList val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotNoPartyList val) 
            { 
                return isSetTotNoPartyList();
            }
            
            public bool isSetTotNoPartyList() 
            { 
                return isSetField(Tags.TotNoPartyList);
            }
            public QuickFix.Fields.LastFragment lastFragment
            { 
                get 
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastFragment val) 
            { 
                this.lastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment get(QuickFix.Fields.LastFragment val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastFragment val) 
            { 
                return isSetLastFragment();
            }
            
            public bool isSetLastFragment() 
            { 
                return isSetField(Tags.LastFragment);
            }
            public QuickFix.Fields.NoPartyList noPartyList
            { 
                get 
                {
                    QuickFix.Fields.NoPartyList val = new QuickFix.Fields.NoPartyList();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoPartyList val) 
            { 
                this.noPartyList = val;
            }
            
            public QuickFix.Fields.NoPartyList get(QuickFix.Fields.NoPartyList val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoPartyList val) 
            { 
                return isSetNoPartyList();
            }
            
            public bool isSetNoPartyList() 
            { 
                return isSetField(Tags.NoPartyList);
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
            public class NoPartyList : Group
            {
                public NoPartyList() 
                  :base( Tags.NoPartyList, Tags.PartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, Tags.NoPartyAltIDs, Tags.NoContextPartyIDs, Tags.NoRiskLimits, Tags.NoRelatedPartyIDs, 0};
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
                public QuickFix.Fields.NoPartyAltIDs noPartyAltIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartyAltIDs val = new QuickFix.Fields.NoPartyAltIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    this.noPartyAltIDs = val;
                }
                
                public QuickFix.Fields.NoPartyAltIDs get(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    return isSetNoPartyAltIDs();
                }
                
                public bool isSetNoPartyAltIDs() 
                { 
                    return isSetField(Tags.NoPartyAltIDs);
                }
                public QuickFix.Fields.NoContextPartyIDs noContextPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoContextPartyIDs val = new QuickFix.Fields.NoContextPartyIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    this.noContextPartyIDs = val;
                }
                
                public QuickFix.Fields.NoContextPartyIDs get(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    return isSetNoContextPartyIDs();
                }
                
                public bool isSetNoContextPartyIDs() 
                { 
                    return isSetField(Tags.NoContextPartyIDs);
                }
                public QuickFix.Fields.NoRiskLimits noRiskLimits
                { 
                    get 
                    {
                        QuickFix.Fields.NoRiskLimits val = new QuickFix.Fields.NoRiskLimits();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoRiskLimits val) 
                { 
                    this.noRiskLimits = val;
                }
                
                public QuickFix.Fields.NoRiskLimits get(QuickFix.Fields.NoRiskLimits val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoRiskLimits val) 
                { 
                    return isSetNoRiskLimits();
                }
                
                public bool isSetNoRiskLimits() 
                { 
                    return isSetField(Tags.NoRiskLimits);
                }
                public QuickFix.Fields.NoRelatedPartyIDs noRelatedPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoRelatedPartyIDs val = new QuickFix.Fields.NoRelatedPartyIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    this.noRelatedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoRelatedPartyIDs get(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    return isSetNoRelatedPartyIDs();
                }
                
                public bool isSetNoRelatedPartyIDs() 
                { 
                    return isSetField(Tags.NoRelatedPartyIDs);
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
                public class NoPartyAltIDs : Group
                {
                    public NoPartyAltIDs() 
                      :base( Tags.NoPartyAltIDs, Tags.PartyAltID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.PartyAltID, Tags.PartyAltIDSource, Tags.NoPartyAltSubIDs, 0};
                                    public QuickFix.Fields.PartyAltID partyAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyAltID val = new QuickFix.Fields.PartyAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartyAltID val) 
                    { 
                        this.partyAltID = val;
                    }
                    
                    public QuickFix.Fields.PartyAltID get(QuickFix.Fields.PartyAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartyAltID val) 
                    { 
                        return isSetPartyAltID();
                    }
                    
                    public bool isSetPartyAltID() 
                    { 
                        return isSetField(Tags.PartyAltID);
                    }
                    public QuickFix.Fields.PartyAltIDSource partyAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyAltIDSource val = new QuickFix.Fields.PartyAltIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        this.partyAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.PartyAltIDSource get(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        return isSetPartyAltIDSource();
                    }
                    
                    public bool isSetPartyAltIDSource() 
                    { 
                        return isSetField(Tags.PartyAltIDSource);
                    }
                    public QuickFix.Fields.NoPartyAltSubIDs noPartyAltSubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartyAltSubIDs val = new QuickFix.Fields.NoPartyAltSubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        this.noPartyAltSubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoPartyAltSubIDs get(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        return isSetNoPartyAltSubIDs();
                    }
                    
                    public bool isSetNoPartyAltSubIDs() 
                    { 
                        return isSetField(Tags.NoPartyAltSubIDs);
                    }
                                    public class NoPartyAltSubIDs : Group
                    {
                        public NoPartyAltSubIDs() 
                          :base( Tags.NoPartyAltSubIDs, Tags.PartyAltSubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.PartyAltSubID, Tags.PartyAltSubIDType, 0};
                                            public QuickFix.Fields.PartyAltSubID partyAltSubID
                        { 
                            get 
                            {
                                QuickFix.Fields.PartyAltSubID val = new QuickFix.Fields.PartyAltSubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            this.partyAltSubID = val;
                        }
                        
                        public QuickFix.Fields.PartyAltSubID get(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            return isSetPartyAltSubID();
                        }
                        
                        public bool isSetPartyAltSubID() 
                        { 
                            return isSetField(Tags.PartyAltSubID);
                        }
                        public QuickFix.Fields.PartyAltSubIDType partyAltSubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.PartyAltSubIDType val = new QuickFix.Fields.PartyAltSubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            this.partyAltSubIDType = val;
                        }
                        
                        public QuickFix.Fields.PartyAltSubIDType get(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            return isSetPartyAltSubIDType();
                        }
                        
                        public bool isSetPartyAltSubIDType() 
                        { 
                            return isSetField(Tags.PartyAltSubIDType);
                        }
                    
                    }
                }
                public class NoContextPartyIDs : Group
                {
                    public NoContextPartyIDs() 
                      :base( Tags.NoContextPartyIDs, Tags.ContextPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.ContextPartyID, Tags.ContextPartyIDSource, Tags.ContextPartyRole, Tags.NoContextPartySubIDs, 0};
                                    public QuickFix.Fields.ContextPartyID contextPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.ContextPartyID val = new QuickFix.Fields.ContextPartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ContextPartyID val) 
                    { 
                        this.contextPartyID = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyID get(QuickFix.Fields.ContextPartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ContextPartyID val) 
                    { 
                        return isSetContextPartyID();
                    }
                    
                    public bool isSetContextPartyID() 
                    { 
                        return isSetField(Tags.ContextPartyID);
                    }
                    public QuickFix.Fields.ContextPartyIDSource contextPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.ContextPartyIDSource val = new QuickFix.Fields.ContextPartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        this.contextPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyIDSource get(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        return isSetContextPartyIDSource();
                    }
                    
                    public bool isSetContextPartyIDSource() 
                    { 
                        return isSetField(Tags.ContextPartyIDSource);
                    }
                    public QuickFix.Fields.ContextPartyRole contextPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.ContextPartyRole val = new QuickFix.Fields.ContextPartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        this.contextPartyRole = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyRole get(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        return isSetContextPartyRole();
                    }
                    
                    public bool isSetContextPartyRole() 
                    { 
                        return isSetField(Tags.ContextPartyRole);
                    }
                    public QuickFix.Fields.NoContextPartySubIDs noContextPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoContextPartySubIDs val = new QuickFix.Fields.NoContextPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        this.noContextPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoContextPartySubIDs get(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        return isSetNoContextPartySubIDs();
                    }
                    
                    public bool isSetNoContextPartySubIDs() 
                    { 
                        return isSetField(Tags.NoContextPartySubIDs);
                    }
                                    public class NoContextPartySubIDs : Group
                    {
                        public NoContextPartySubIDs() 
                          :base( Tags.NoContextPartySubIDs, Tags.ContextPartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.ContextPartySubID, Tags.ContextPartySubIDType, 0};
                                            public QuickFix.Fields.ContextPartySubID contextPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.ContextPartySubID val = new QuickFix.Fields.ContextPartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            this.contextPartySubID = val;
                        }
                        
                        public QuickFix.Fields.ContextPartySubID get(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            return isSetContextPartySubID();
                        }
                        
                        public bool isSetContextPartySubID() 
                        { 
                            return isSetField(Tags.ContextPartySubID);
                        }
                        public QuickFix.Fields.ContextPartySubIDType contextPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.ContextPartySubIDType val = new QuickFix.Fields.ContextPartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            this.contextPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.ContextPartySubIDType get(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            return isSetContextPartySubIDType();
                        }
                        
                        public bool isSetContextPartySubIDType() 
                        { 
                            return isSetField(Tags.ContextPartySubIDType);
                        }
                    
                    }
                }
                public class NoRiskLimits : Group
                {
                    public NoRiskLimits() 
                      :base( Tags.NoRiskLimits, Tags.RiskLimitType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.RiskLimitType, Tags.RiskLimitAmount, Tags.RiskLimitCurrency, Tags.RiskLimitPlatform, Tags.NoRiskInstruments, Tags.NoRiskWarningLevels, 0};
                                    public QuickFix.Fields.RiskLimitType riskLimitType
                    { 
                        get 
                        {
                            QuickFix.Fields.RiskLimitType val = new QuickFix.Fields.RiskLimitType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RiskLimitType val) 
                    { 
                        this.riskLimitType = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitType get(QuickFix.Fields.RiskLimitType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RiskLimitType val) 
                    { 
                        return isSetRiskLimitType();
                    }
                    
                    public bool isSetRiskLimitType() 
                    { 
                        return isSetField(Tags.RiskLimitType);
                    }
                    public QuickFix.Fields.RiskLimitAmount riskLimitAmount
                    { 
                        get 
                        {
                            QuickFix.Fields.RiskLimitAmount val = new QuickFix.Fields.RiskLimitAmount();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        this.riskLimitAmount = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitAmount get(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        return isSetRiskLimitAmount();
                    }
                    
                    public bool isSetRiskLimitAmount() 
                    { 
                        return isSetField(Tags.RiskLimitAmount);
                    }
                    public QuickFix.Fields.RiskLimitCurrency riskLimitCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.RiskLimitCurrency val = new QuickFix.Fields.RiskLimitCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        this.riskLimitCurrency = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitCurrency get(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        return isSetRiskLimitCurrency();
                    }
                    
                    public bool isSetRiskLimitCurrency() 
                    { 
                        return isSetField(Tags.RiskLimitCurrency);
                    }
                    public QuickFix.Fields.RiskLimitPlatform riskLimitPlatform
                    { 
                        get 
                        {
                            QuickFix.Fields.RiskLimitPlatform val = new QuickFix.Fields.RiskLimitPlatform();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        this.riskLimitPlatform = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitPlatform get(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        return isSetRiskLimitPlatform();
                    }
                    
                    public bool isSetRiskLimitPlatform() 
                    { 
                        return isSetField(Tags.RiskLimitPlatform);
                    }
                    public QuickFix.Fields.NoRiskInstruments noRiskInstruments
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRiskInstruments val = new QuickFix.Fields.NoRiskInstruments();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        this.noRiskInstruments = val;
                    }
                    
                    public QuickFix.Fields.NoRiskInstruments get(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        return isSetNoRiskInstruments();
                    }
                    
                    public bool isSetNoRiskInstruments() 
                    { 
                        return isSetField(Tags.NoRiskInstruments);
                    }
                    public QuickFix.Fields.NoRiskWarningLevels noRiskWarningLevels
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRiskWarningLevels val = new QuickFix.Fields.NoRiskWarningLevels();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        this.noRiskWarningLevels = val;
                    }
                    
                    public QuickFix.Fields.NoRiskWarningLevels get(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        return isSetNoRiskWarningLevels();
                    }
                    
                    public bool isSetNoRiskWarningLevels() 
                    { 
                        return isSetField(Tags.NoRiskWarningLevels);
                    }
                                    public class NoRiskInstruments : Group
                    {
                        public NoRiskInstruments() 
                          :base( Tags.NoRiskInstruments, Tags.RiskInstrumentOperator, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.RiskInstrumentOperator, Tags.RiskSymbol, Tags.RiskSymbolSfx, Tags.RiskSecurityID, Tags.RiskSecurityIDSource, Tags.NoRiskSecurityAltID, Tags.RiskProduct, Tags.RiskProductComplex, Tags.RiskSecurityGroup, Tags.RiskCFICode, Tags.RiskSecurityType, Tags.RiskSecuritySubType, Tags.RiskMaturityMonthYear, Tags.RiskMaturityTime, Tags.RiskRestructuringType, Tags.RiskSeniority, Tags.RiskPutOrCall, Tags.RiskFlexibleIndicator, Tags.RiskCouponRate, Tags.RiskSecurityExchange, Tags.RiskSecurityDesc, Tags.RiskEncodedSecurityDescLen, Tags.RiskEncodedSecurityDesc, Tags.RiskInstrumentSettlType, Tags.RiskInstrumentMultiplier, 0};
                                            public QuickFix.Fields.RiskInstrumentOperator riskInstrumentOperator
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskInstrumentOperator val = new QuickFix.Fields.RiskInstrumentOperator();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            this.riskInstrumentOperator = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentOperator get(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            return isSetRiskInstrumentOperator();
                        }
                        
                        public bool isSetRiskInstrumentOperator() 
                        { 
                            return isSetField(Tags.RiskInstrumentOperator);
                        }
                        public QuickFix.Fields.RiskSymbol riskSymbol
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSymbol val = new QuickFix.Fields.RiskSymbol();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSymbol val) 
                        { 
                            this.riskSymbol = val;
                        }
                        
                        public QuickFix.Fields.RiskSymbol get(QuickFix.Fields.RiskSymbol val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSymbol val) 
                        { 
                            return isSetRiskSymbol();
                        }
                        
                        public bool isSetRiskSymbol() 
                        { 
                            return isSetField(Tags.RiskSymbol);
                        }
                        public QuickFix.Fields.RiskSymbolSfx riskSymbolSfx
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSymbolSfx val = new QuickFix.Fields.RiskSymbolSfx();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            this.riskSymbolSfx = val;
                        }
                        
                        public QuickFix.Fields.RiskSymbolSfx get(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            return isSetRiskSymbolSfx();
                        }
                        
                        public bool isSetRiskSymbolSfx() 
                        { 
                            return isSetField(Tags.RiskSymbolSfx);
                        }
                        public QuickFix.Fields.RiskSecurityID riskSecurityID
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityID val = new QuickFix.Fields.RiskSecurityID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            this.riskSecurityID = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityID get(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            return isSetRiskSecurityID();
                        }
                        
                        public bool isSetRiskSecurityID() 
                        { 
                            return isSetField(Tags.RiskSecurityID);
                        }
                        public QuickFix.Fields.RiskSecurityIDSource riskSecurityIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityIDSource val = new QuickFix.Fields.RiskSecurityIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            this.riskSecurityIDSource = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityIDSource get(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            return isSetRiskSecurityIDSource();
                        }
                        
                        public bool isSetRiskSecurityIDSource() 
                        { 
                            return isSetField(Tags.RiskSecurityIDSource);
                        }
                        public QuickFix.Fields.NoRiskSecurityAltID noRiskSecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRiskSecurityAltID val = new QuickFix.Fields.NoRiskSecurityAltID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            this.noRiskSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.NoRiskSecurityAltID get(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            return isSetNoRiskSecurityAltID();
                        }
                        
                        public bool isSetNoRiskSecurityAltID() 
                        { 
                            return isSetField(Tags.NoRiskSecurityAltID);
                        }
                        public QuickFix.Fields.RiskProduct riskProduct
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskProduct val = new QuickFix.Fields.RiskProduct();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskProduct val) 
                        { 
                            this.riskProduct = val;
                        }
                        
                        public QuickFix.Fields.RiskProduct get(QuickFix.Fields.RiskProduct val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskProduct val) 
                        { 
                            return isSetRiskProduct();
                        }
                        
                        public bool isSetRiskProduct() 
                        { 
                            return isSetField(Tags.RiskProduct);
                        }
                        public QuickFix.Fields.RiskProductComplex riskProductComplex
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskProductComplex val = new QuickFix.Fields.RiskProductComplex();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            this.riskProductComplex = val;
                        }
                        
                        public QuickFix.Fields.RiskProductComplex get(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            return isSetRiskProductComplex();
                        }
                        
                        public bool isSetRiskProductComplex() 
                        { 
                            return isSetField(Tags.RiskProductComplex);
                        }
                        public QuickFix.Fields.RiskSecurityGroup riskSecurityGroup
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityGroup val = new QuickFix.Fields.RiskSecurityGroup();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            this.riskSecurityGroup = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityGroup get(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            return isSetRiskSecurityGroup();
                        }
                        
                        public bool isSetRiskSecurityGroup() 
                        { 
                            return isSetField(Tags.RiskSecurityGroup);
                        }
                        public QuickFix.Fields.RiskCFICode riskCFICode
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskCFICode val = new QuickFix.Fields.RiskCFICode();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskCFICode val) 
                        { 
                            this.riskCFICode = val;
                        }
                        
                        public QuickFix.Fields.RiskCFICode get(QuickFix.Fields.RiskCFICode val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskCFICode val) 
                        { 
                            return isSetRiskCFICode();
                        }
                        
                        public bool isSetRiskCFICode() 
                        { 
                            return isSetField(Tags.RiskCFICode);
                        }
                        public QuickFix.Fields.RiskSecurityType riskSecurityType
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityType val = new QuickFix.Fields.RiskSecurityType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            this.riskSecurityType = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityType get(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            return isSetRiskSecurityType();
                        }
                        
                        public bool isSetRiskSecurityType() 
                        { 
                            return isSetField(Tags.RiskSecurityType);
                        }
                        public QuickFix.Fields.RiskSecuritySubType riskSecuritySubType
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecuritySubType val = new QuickFix.Fields.RiskSecuritySubType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            this.riskSecuritySubType = val;
                        }
                        
                        public QuickFix.Fields.RiskSecuritySubType get(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            return isSetRiskSecuritySubType();
                        }
                        
                        public bool isSetRiskSecuritySubType() 
                        { 
                            return isSetField(Tags.RiskSecuritySubType);
                        }
                        public QuickFix.Fields.RiskMaturityMonthYear riskMaturityMonthYear
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskMaturityMonthYear val = new QuickFix.Fields.RiskMaturityMonthYear();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            this.riskMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.RiskMaturityMonthYear get(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            return isSetRiskMaturityMonthYear();
                        }
                        
                        public bool isSetRiskMaturityMonthYear() 
                        { 
                            return isSetField(Tags.RiskMaturityMonthYear);
                        }
                        public QuickFix.Fields.RiskMaturityTime riskMaturityTime
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskMaturityTime val = new QuickFix.Fields.RiskMaturityTime();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            this.riskMaturityTime = val;
                        }
                        
                        public QuickFix.Fields.RiskMaturityTime get(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            return isSetRiskMaturityTime();
                        }
                        
                        public bool isSetRiskMaturityTime() 
                        { 
                            return isSetField(Tags.RiskMaturityTime);
                        }
                        public QuickFix.Fields.RiskRestructuringType riskRestructuringType
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskRestructuringType val = new QuickFix.Fields.RiskRestructuringType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            this.riskRestructuringType = val;
                        }
                        
                        public QuickFix.Fields.RiskRestructuringType get(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            return isSetRiskRestructuringType();
                        }
                        
                        public bool isSetRiskRestructuringType() 
                        { 
                            return isSetField(Tags.RiskRestructuringType);
                        }
                        public QuickFix.Fields.RiskSeniority riskSeniority
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSeniority val = new QuickFix.Fields.RiskSeniority();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSeniority val) 
                        { 
                            this.riskSeniority = val;
                        }
                        
                        public QuickFix.Fields.RiskSeniority get(QuickFix.Fields.RiskSeniority val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSeniority val) 
                        { 
                            return isSetRiskSeniority();
                        }
                        
                        public bool isSetRiskSeniority() 
                        { 
                            return isSetField(Tags.RiskSeniority);
                        }
                        public QuickFix.Fields.RiskPutOrCall riskPutOrCall
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskPutOrCall val = new QuickFix.Fields.RiskPutOrCall();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            this.riskPutOrCall = val;
                        }
                        
                        public QuickFix.Fields.RiskPutOrCall get(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            return isSetRiskPutOrCall();
                        }
                        
                        public bool isSetRiskPutOrCall() 
                        { 
                            return isSetField(Tags.RiskPutOrCall);
                        }
                        public QuickFix.Fields.RiskFlexibleIndicator riskFlexibleIndicator
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskFlexibleIndicator val = new QuickFix.Fields.RiskFlexibleIndicator();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            this.riskFlexibleIndicator = val;
                        }
                        
                        public QuickFix.Fields.RiskFlexibleIndicator get(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            return isSetRiskFlexibleIndicator();
                        }
                        
                        public bool isSetRiskFlexibleIndicator() 
                        { 
                            return isSetField(Tags.RiskFlexibleIndicator);
                        }
                        public QuickFix.Fields.RiskCouponRate riskCouponRate
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskCouponRate val = new QuickFix.Fields.RiskCouponRate();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            this.riskCouponRate = val;
                        }
                        
                        public QuickFix.Fields.RiskCouponRate get(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            return isSetRiskCouponRate();
                        }
                        
                        public bool isSetRiskCouponRate() 
                        { 
                            return isSetField(Tags.RiskCouponRate);
                        }
                        public QuickFix.Fields.RiskSecurityExchange riskSecurityExchange
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityExchange val = new QuickFix.Fields.RiskSecurityExchange();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            this.riskSecurityExchange = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityExchange get(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            return isSetRiskSecurityExchange();
                        }
                        
                        public bool isSetRiskSecurityExchange() 
                        { 
                            return isSetField(Tags.RiskSecurityExchange);
                        }
                        public QuickFix.Fields.RiskSecurityDesc riskSecurityDesc
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityDesc val = new QuickFix.Fields.RiskSecurityDesc();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            this.riskSecurityDesc = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityDesc get(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            return isSetRiskSecurityDesc();
                        }
                        
                        public bool isSetRiskSecurityDesc() 
                        { 
                            return isSetField(Tags.RiskSecurityDesc);
                        }
                        public QuickFix.Fields.RiskEncodedSecurityDescLen riskEncodedSecurityDescLen
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskEncodedSecurityDescLen val = new QuickFix.Fields.RiskEncodedSecurityDescLen();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            this.riskEncodedSecurityDescLen = val;
                        }
                        
                        public QuickFix.Fields.RiskEncodedSecurityDescLen get(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            return isSetRiskEncodedSecurityDescLen();
                        }
                        
                        public bool isSetRiskEncodedSecurityDescLen() 
                        { 
                            return isSetField(Tags.RiskEncodedSecurityDescLen);
                        }
                        public QuickFix.Fields.RiskEncodedSecurityDesc riskEncodedSecurityDesc
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskEncodedSecurityDesc val = new QuickFix.Fields.RiskEncodedSecurityDesc();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            this.riskEncodedSecurityDesc = val;
                        }
                        
                        public QuickFix.Fields.RiskEncodedSecurityDesc get(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            return isSetRiskEncodedSecurityDesc();
                        }
                        
                        public bool isSetRiskEncodedSecurityDesc() 
                        { 
                            return isSetField(Tags.RiskEncodedSecurityDesc);
                        }
                        public QuickFix.Fields.RiskInstrumentSettlType riskInstrumentSettlType
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskInstrumentSettlType val = new QuickFix.Fields.RiskInstrumentSettlType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            this.riskInstrumentSettlType = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentSettlType get(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            return isSetRiskInstrumentSettlType();
                        }
                        
                        public bool isSetRiskInstrumentSettlType() 
                        { 
                            return isSetField(Tags.RiskInstrumentSettlType);
                        }
                        public QuickFix.Fields.RiskInstrumentMultiplier riskInstrumentMultiplier
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskInstrumentMultiplier val = new QuickFix.Fields.RiskInstrumentMultiplier();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            this.riskInstrumentMultiplier = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentMultiplier get(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            return isSetRiskInstrumentMultiplier();
                        }
                        
                        public bool isSetRiskInstrumentMultiplier() 
                        { 
                            return isSetField(Tags.RiskInstrumentMultiplier);
                        }
                                            public class NoRiskSecurityAltID : Group
                        {
                            public NoRiskSecurityAltID() 
                              :base( Tags.NoRiskSecurityAltID, Tags.RiskSecurityAltID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.RiskSecurityAltID, Tags.RiskSecurityAltIDSource, 0};
                                                    public QuickFix.Fields.RiskSecurityAltID riskSecurityAltID
                            { 
                                get 
                                {
                                    QuickFix.Fields.RiskSecurityAltID val = new QuickFix.Fields.RiskSecurityAltID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                this.riskSecurityAltID = val;
                            }
                            
                            public QuickFix.Fields.RiskSecurityAltID get(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                return isSetRiskSecurityAltID();
                            }
                            
                            public bool isSetRiskSecurityAltID() 
                            { 
                                return isSetField(Tags.RiskSecurityAltID);
                            }
                            public QuickFix.Fields.RiskSecurityAltIDSource riskSecurityAltIDSource
                            { 
                                get 
                                {
                                    QuickFix.Fields.RiskSecurityAltIDSource val = new QuickFix.Fields.RiskSecurityAltIDSource();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                this.riskSecurityAltIDSource = val;
                            }
                            
                            public QuickFix.Fields.RiskSecurityAltIDSource get(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                return isSetRiskSecurityAltIDSource();
                            }
                            
                            public bool isSetRiskSecurityAltIDSource() 
                            { 
                                return isSetField(Tags.RiskSecurityAltIDSource);
                            }
                        
                        }
                    }
                    public class NoRiskWarningLevels : Group
                    {
                        public NoRiskWarningLevels() 
                          :base( Tags.NoRiskWarningLevels, Tags.RiskWarningLevelPercent, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.RiskWarningLevelPercent, Tags.RiskWarningLevelName, 0};
                                            public QuickFix.Fields.RiskWarningLevelPercent riskWarningLevelPercent
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskWarningLevelPercent val = new QuickFix.Fields.RiskWarningLevelPercent();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            this.riskWarningLevelPercent = val;
                        }
                        
                        public QuickFix.Fields.RiskWarningLevelPercent get(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            return isSetRiskWarningLevelPercent();
                        }
                        
                        public bool isSetRiskWarningLevelPercent() 
                        { 
                            return isSetField(Tags.RiskWarningLevelPercent);
                        }
                        public QuickFix.Fields.RiskWarningLevelName riskWarningLevelName
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskWarningLevelName val = new QuickFix.Fields.RiskWarningLevelName();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            this.riskWarningLevelName = val;
                        }
                        
                        public QuickFix.Fields.RiskWarningLevelName get(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            return isSetRiskWarningLevelName();
                        }
                        
                        public bool isSetRiskWarningLevelName() 
                        { 
                            return isSetField(Tags.RiskWarningLevelName);
                        }
                    
                    }
                }
                public class NoRelatedPartyIDs : Group
                {
                    public NoRelatedPartyIDs() 
                      :base( Tags.NoRelatedPartyIDs, Tags.RelatedPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.RelatedPartyID, Tags.RelatedPartyIDSource, Tags.RelatedPartyRole, Tags.NoRelatedPartySubIDs, Tags.NoRelatedPartyAltIDs, Tags.NoRelatedContextPartyIDs, Tags.NoRelationshipRiskLimits, Tags.NoPartyRelationships, 0};
                                    public QuickFix.Fields.RelatedPartyID relatedPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.RelatedPartyID val = new QuickFix.Fields.RelatedPartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        this.relatedPartyID = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyID get(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        return isSetRelatedPartyID();
                    }
                    
                    public bool isSetRelatedPartyID() 
                    { 
                        return isSetField(Tags.RelatedPartyID);
                    }
                    public QuickFix.Fields.RelatedPartyIDSource relatedPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.RelatedPartyIDSource val = new QuickFix.Fields.RelatedPartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        this.relatedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyIDSource get(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        return isSetRelatedPartyIDSource();
                    }
                    
                    public bool isSetRelatedPartyIDSource() 
                    { 
                        return isSetField(Tags.RelatedPartyIDSource);
                    }
                    public QuickFix.Fields.RelatedPartyRole relatedPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.RelatedPartyRole val = new QuickFix.Fields.RelatedPartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        this.relatedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyRole get(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        return isSetRelatedPartyRole();
                    }
                    
                    public bool isSetRelatedPartyRole() 
                    { 
                        return isSetField(Tags.RelatedPartyRole);
                    }
                    public QuickFix.Fields.NoRelatedPartySubIDs noRelatedPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRelatedPartySubIDs val = new QuickFix.Fields.NoRelatedPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        this.noRelatedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedPartySubIDs get(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        return isSetNoRelatedPartySubIDs();
                    }
                    
                    public bool isSetNoRelatedPartySubIDs() 
                    { 
                        return isSetField(Tags.NoRelatedPartySubIDs);
                    }
                    public QuickFix.Fields.NoRelatedPartyAltIDs noRelatedPartyAltIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRelatedPartyAltIDs val = new QuickFix.Fields.NoRelatedPartyAltIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        this.noRelatedPartyAltIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedPartyAltIDs get(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        return isSetNoRelatedPartyAltIDs();
                    }
                    
                    public bool isSetNoRelatedPartyAltIDs() 
                    { 
                        return isSetField(Tags.NoRelatedPartyAltIDs);
                    }
                    public QuickFix.Fields.NoRelatedContextPartyIDs noRelatedContextPartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRelatedContextPartyIDs val = new QuickFix.Fields.NoRelatedContextPartyIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        this.noRelatedContextPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedContextPartyIDs get(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        return isSetNoRelatedContextPartyIDs();
                    }
                    
                    public bool isSetNoRelatedContextPartyIDs() 
                    { 
                        return isSetField(Tags.NoRelatedContextPartyIDs);
                    }
                    public QuickFix.Fields.NoRelationshipRiskLimits noRelationshipRiskLimits
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRelationshipRiskLimits val = new QuickFix.Fields.NoRelationshipRiskLimits();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        this.noRelationshipRiskLimits = val;
                    }
                    
                    public QuickFix.Fields.NoRelationshipRiskLimits get(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        return isSetNoRelationshipRiskLimits();
                    }
                    
                    public bool isSetNoRelationshipRiskLimits() 
                    { 
                        return isSetField(Tags.NoRelationshipRiskLimits);
                    }
                    public QuickFix.Fields.NoPartyRelationships noPartyRelationships
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartyRelationships val = new QuickFix.Fields.NoPartyRelationships();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        this.noPartyRelationships = val;
                    }
                    
                    public QuickFix.Fields.NoPartyRelationships get(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        return isSetNoPartyRelationships();
                    }
                    
                    public bool isSetNoPartyRelationships() 
                    { 
                        return isSetField(Tags.NoPartyRelationships);
                    }
                                    public class NoRelatedPartySubIDs : Group
                    {
                        public NoRelatedPartySubIDs() 
                          :base( Tags.NoRelatedPartySubIDs, Tags.RelatedPartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.RelatedPartySubID, Tags.RelatedPartySubIDType, 0};
                                            public QuickFix.Fields.RelatedPartySubID relatedPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedPartySubID val = new QuickFix.Fields.RelatedPartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            this.relatedPartySubID = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartySubID get(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            return isSetRelatedPartySubID();
                        }
                        
                        public bool isSetRelatedPartySubID() 
                        { 
                            return isSetField(Tags.RelatedPartySubID);
                        }
                        public QuickFix.Fields.RelatedPartySubIDType relatedPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedPartySubIDType val = new QuickFix.Fields.RelatedPartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            this.relatedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartySubIDType get(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            return isSetRelatedPartySubIDType();
                        }
                        
                        public bool isSetRelatedPartySubIDType() 
                        { 
                            return isSetField(Tags.RelatedPartySubIDType);
                        }
                    
                    }
                    public class NoRelatedPartyAltIDs : Group
                    {
                        public NoRelatedPartyAltIDs() 
                          :base( Tags.NoRelatedPartyAltIDs, Tags.RelatedPartyAltID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.RelatedPartyAltID, Tags.RelatedPartyAltIDSource, Tags.NoRelatedPartyAltSubIDs, 0};
                                            public QuickFix.Fields.RelatedPartyAltID relatedPartyAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedPartyAltID val = new QuickFix.Fields.RelatedPartyAltID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            this.relatedPartyAltID = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartyAltID get(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            return isSetRelatedPartyAltID();
                        }
                        
                        public bool isSetRelatedPartyAltID() 
                        { 
                            return isSetField(Tags.RelatedPartyAltID);
                        }
                        public QuickFix.Fields.RelatedPartyAltIDSource relatedPartyAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedPartyAltIDSource val = new QuickFix.Fields.RelatedPartyAltIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            this.relatedPartyAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartyAltIDSource get(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            return isSetRelatedPartyAltIDSource();
                        }
                        
                        public bool isSetRelatedPartyAltIDSource() 
                        { 
                            return isSetField(Tags.RelatedPartyAltIDSource);
                        }
                        public QuickFix.Fields.NoRelatedPartyAltSubIDs noRelatedPartyAltSubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRelatedPartyAltSubIDs val = new QuickFix.Fields.NoRelatedPartyAltSubIDs();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            this.noRelatedPartyAltSubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoRelatedPartyAltSubIDs get(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            return isSetNoRelatedPartyAltSubIDs();
                        }
                        
                        public bool isSetNoRelatedPartyAltSubIDs() 
                        { 
                            return isSetField(Tags.NoRelatedPartyAltSubIDs);
                        }
                                            public class NoRelatedPartyAltSubIDs : Group
                        {
                            public NoRelatedPartyAltSubIDs() 
                              :base( Tags.NoRelatedPartyAltSubIDs, Tags.RelatedPartyAltSubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.RelatedPartyAltSubID, Tags.RelatedPartyAltSubIDType, 0};
                                                    public QuickFix.Fields.RelatedPartyAltSubID relatedPartyAltSubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelatedPartyAltSubID val = new QuickFix.Fields.RelatedPartyAltSubID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                this.relatedPartyAltSubID = val;
                            }
                            
                            public QuickFix.Fields.RelatedPartyAltSubID get(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                return isSetRelatedPartyAltSubID();
                            }
                            
                            public bool isSetRelatedPartyAltSubID() 
                            { 
                                return isSetField(Tags.RelatedPartyAltSubID);
                            }
                            public QuickFix.Fields.RelatedPartyAltSubIDType relatedPartyAltSubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelatedPartyAltSubIDType val = new QuickFix.Fields.RelatedPartyAltSubIDType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                this.relatedPartyAltSubIDType = val;
                            }
                            
                            public QuickFix.Fields.RelatedPartyAltSubIDType get(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                return isSetRelatedPartyAltSubIDType();
                            }
                            
                            public bool isSetRelatedPartyAltSubIDType() 
                            { 
                                return isSetField(Tags.RelatedPartyAltSubIDType);
                            }
                        
                        }
                    }
                    public class NoRelatedContextPartyIDs : Group
                    {
                        public NoRelatedContextPartyIDs() 
                          :base( Tags.NoRelatedContextPartyIDs, Tags.RelatedContextPartyID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.RelatedContextPartyID, Tags.RelatedContextPartyIDSource, Tags.RelatedContextPartyRole, Tags.NoRelatedContextPartySubIDs, 0};
                                            public QuickFix.Fields.RelatedContextPartyID relatedContextPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedContextPartyID val = new QuickFix.Fields.RelatedContextPartyID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            this.relatedContextPartyID = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyID get(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            return isSetRelatedContextPartyID();
                        }
                        
                        public bool isSetRelatedContextPartyID() 
                        { 
                            return isSetField(Tags.RelatedContextPartyID);
                        }
                        public QuickFix.Fields.RelatedContextPartyIDSource relatedContextPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedContextPartyIDSource val = new QuickFix.Fields.RelatedContextPartyIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            this.relatedContextPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyIDSource get(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            return isSetRelatedContextPartyIDSource();
                        }
                        
                        public bool isSetRelatedContextPartyIDSource() 
                        { 
                            return isSetField(Tags.RelatedContextPartyIDSource);
                        }
                        public QuickFix.Fields.RelatedContextPartyRole relatedContextPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedContextPartyRole val = new QuickFix.Fields.RelatedContextPartyRole();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            this.relatedContextPartyRole = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyRole get(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            return isSetRelatedContextPartyRole();
                        }
                        
                        public bool isSetRelatedContextPartyRole() 
                        { 
                            return isSetField(Tags.RelatedContextPartyRole);
                        }
                        public QuickFix.Fields.NoRelatedContextPartySubIDs noRelatedContextPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRelatedContextPartySubIDs val = new QuickFix.Fields.NoRelatedContextPartySubIDs();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            this.noRelatedContextPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoRelatedContextPartySubIDs get(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            return isSetNoRelatedContextPartySubIDs();
                        }
                        
                        public bool isSetNoRelatedContextPartySubIDs() 
                        { 
                            return isSetField(Tags.NoRelatedContextPartySubIDs);
                        }
                                            public class NoRelatedContextPartySubIDs : Group
                        {
                            public NoRelatedContextPartySubIDs() 
                              :base( Tags.NoRelatedContextPartySubIDs, Tags.RelatedContextPartySubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.RelatedContextPartySubID, Tags.RelatedContextPartySubIDType, 0};
                                                    public QuickFix.Fields.RelatedContextPartySubID relatedContextPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelatedContextPartySubID val = new QuickFix.Fields.RelatedContextPartySubID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                this.relatedContextPartySubID = val;
                            }
                            
                            public QuickFix.Fields.RelatedContextPartySubID get(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                return isSetRelatedContextPartySubID();
                            }
                            
                            public bool isSetRelatedContextPartySubID() 
                            { 
                                return isSetField(Tags.RelatedContextPartySubID);
                            }
                            public QuickFix.Fields.RelatedContextPartySubIDType relatedContextPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelatedContextPartySubIDType val = new QuickFix.Fields.RelatedContextPartySubIDType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                this.relatedContextPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.RelatedContextPartySubIDType get(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                return isSetRelatedContextPartySubIDType();
                            }
                            
                            public bool isSetRelatedContextPartySubIDType() 
                            { 
                                return isSetField(Tags.RelatedContextPartySubIDType);
                            }
                        
                        }
                    }
                    public class NoRelationshipRiskLimits : Group
                    {
                        public NoRelationshipRiskLimits() 
                          :base( Tags.NoRelationshipRiskLimits, Tags.RelationshipRiskLimitType, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.RelationshipRiskLimitType, Tags.RelationshipRiskLimitAmount, Tags.RelationshipRiskLimitCurrency, Tags.RelationshipRiskLimitPlatform, Tags.NoRelationshipRiskInstruments, Tags.NoRelationshipRiskWarningLevels, 0};
                                            public QuickFix.Fields.RelationshipRiskLimitType relationshipRiskLimitType
                        { 
                            get 
                            {
                                QuickFix.Fields.RelationshipRiskLimitType val = new QuickFix.Fields.RelationshipRiskLimitType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            this.relationshipRiskLimitType = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitType get(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            return isSetRelationshipRiskLimitType();
                        }
                        
                        public bool isSetRelationshipRiskLimitType() 
                        { 
                            return isSetField(Tags.RelationshipRiskLimitType);
                        }
                        public QuickFix.Fields.RelationshipRiskLimitAmount relationshipRiskLimitAmount
                        { 
                            get 
                            {
                                QuickFix.Fields.RelationshipRiskLimitAmount val = new QuickFix.Fields.RelationshipRiskLimitAmount();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            this.relationshipRiskLimitAmount = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitAmount get(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            return isSetRelationshipRiskLimitAmount();
                        }
                        
                        public bool isSetRelationshipRiskLimitAmount() 
                        { 
                            return isSetField(Tags.RelationshipRiskLimitAmount);
                        }
                        public QuickFix.Fields.RelationshipRiskLimitCurrency relationshipRiskLimitCurrency
                        { 
                            get 
                            {
                                QuickFix.Fields.RelationshipRiskLimitCurrency val = new QuickFix.Fields.RelationshipRiskLimitCurrency();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            this.relationshipRiskLimitCurrency = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitCurrency get(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            return isSetRelationshipRiskLimitCurrency();
                        }
                        
                        public bool isSetRelationshipRiskLimitCurrency() 
                        { 
                            return isSetField(Tags.RelationshipRiskLimitCurrency);
                        }
                        public QuickFix.Fields.RelationshipRiskLimitPlatform relationshipRiskLimitPlatform
                        { 
                            get 
                            {
                                QuickFix.Fields.RelationshipRiskLimitPlatform val = new QuickFix.Fields.RelationshipRiskLimitPlatform();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            this.relationshipRiskLimitPlatform = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitPlatform get(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            return isSetRelationshipRiskLimitPlatform();
                        }
                        
                        public bool isSetRelationshipRiskLimitPlatform() 
                        { 
                            return isSetField(Tags.RelationshipRiskLimitPlatform);
                        }
                        public QuickFix.Fields.NoRelationshipRiskInstruments noRelationshipRiskInstruments
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRelationshipRiskInstruments val = new QuickFix.Fields.NoRelationshipRiskInstruments();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            this.noRelationshipRiskInstruments = val;
                        }
                        
                        public QuickFix.Fields.NoRelationshipRiskInstruments get(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            return isSetNoRelationshipRiskInstruments();
                        }
                        
                        public bool isSetNoRelationshipRiskInstruments() 
                        { 
                            return isSetField(Tags.NoRelationshipRiskInstruments);
                        }
                        public QuickFix.Fields.NoRelationshipRiskWarningLevels noRelationshipRiskWarningLevels
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRelationshipRiskWarningLevels val = new QuickFix.Fields.NoRelationshipRiskWarningLevels();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            this.noRelationshipRiskWarningLevels = val;
                        }
                        
                        public QuickFix.Fields.NoRelationshipRiskWarningLevels get(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            return isSetNoRelationshipRiskWarningLevels();
                        }
                        
                        public bool isSetNoRelationshipRiskWarningLevels() 
                        { 
                            return isSetField(Tags.NoRelationshipRiskWarningLevels);
                        }
                                            public class NoRelationshipRiskInstruments : Group
                        {
                            public NoRelationshipRiskInstruments() 
                              :base( Tags.NoRelationshipRiskInstruments, Tags.RelationshipRiskInstrumentOperator, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.RelationshipRiskInstrumentOperator, Tags.RelationshipRiskSymbol, Tags.RelationshipRiskSymbolSfx, Tags.RelationshipRiskSecurityID, Tags.RelationshipRiskSecurityIDSource, Tags.NoRelationshipRiskSecurityAltID, Tags.RelationshipRiskProduct, Tags.RelationshipRiskProductComplex, Tags.RelationshipRiskSecurityGroup, Tags.RelationshipRiskCFICode, Tags.RelationshipRiskSecurityType, Tags.RelationshipRiskSecuritySubType, Tags.RelationshipRiskMaturityMonthYear, Tags.RelationshipRiskMaturityTime, Tags.RelationshipRiskRestructuringType, Tags.RelationshipRiskSeniority, Tags.RelationshipRiskPutOrCall, Tags.RelationshipRiskFlexibleIndicator, Tags.RelationshipRiskCouponRate, Tags.RelationshipRiskSecurityExchange, Tags.RelationshipRiskSecurityDesc, Tags.RelationshipRiskEncodedSecurityDescLen, Tags.RelationshipRiskEncodedSecurityDesc, Tags.RelationshipRiskInstrumentSettlType, Tags.RelationshipRiskInstrumentMultiplier, 0};
                                                    public QuickFix.Fields.RelationshipRiskInstrumentOperator relationshipRiskInstrumentOperator
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskInstrumentOperator val = new QuickFix.Fields.RelationshipRiskInstrumentOperator();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                this.relationshipRiskInstrumentOperator = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentOperator get(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                return isSetRelationshipRiskInstrumentOperator();
                            }
                            
                            public bool isSetRelationshipRiskInstrumentOperator() 
                            { 
                                return isSetField(Tags.RelationshipRiskInstrumentOperator);
                            }
                            public QuickFix.Fields.RelationshipRiskSymbol relationshipRiskSymbol
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSymbol val = new QuickFix.Fields.RelationshipRiskSymbol();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                this.relationshipRiskSymbol = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSymbol get(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                return isSetRelationshipRiskSymbol();
                            }
                            
                            public bool isSetRelationshipRiskSymbol() 
                            { 
                                return isSetField(Tags.RelationshipRiskSymbol);
                            }
                            public QuickFix.Fields.RelationshipRiskSymbolSfx relationshipRiskSymbolSfx
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSymbolSfx val = new QuickFix.Fields.RelationshipRiskSymbolSfx();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                this.relationshipRiskSymbolSfx = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSymbolSfx get(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                return isSetRelationshipRiskSymbolSfx();
                            }
                            
                            public bool isSetRelationshipRiskSymbolSfx() 
                            { 
                                return isSetField(Tags.RelationshipRiskSymbolSfx);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityID relationshipRiskSecurityID
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityID val = new QuickFix.Fields.RelationshipRiskSecurityID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                this.relationshipRiskSecurityID = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityID get(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                return isSetRelationshipRiskSecurityID();
                            }
                            
                            public bool isSetRelationshipRiskSecurityID() 
                            { 
                                return isSetField(Tags.RelationshipRiskSecurityID);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityIDSource relationshipRiskSecurityIDSource
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityIDSource val = new QuickFix.Fields.RelationshipRiskSecurityIDSource();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                this.relationshipRiskSecurityIDSource = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityIDSource get(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                return isSetRelationshipRiskSecurityIDSource();
                            }
                            
                            public bool isSetRelationshipRiskSecurityIDSource() 
                            { 
                                return isSetField(Tags.RelationshipRiskSecurityIDSource);
                            }
                            public QuickFix.Fields.NoRelationshipRiskSecurityAltID noRelationshipRiskSecurityAltID
                            { 
                                get 
                                {
                                    QuickFix.Fields.NoRelationshipRiskSecurityAltID val = new QuickFix.Fields.NoRelationshipRiskSecurityAltID();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                this.noRelationshipRiskSecurityAltID = val;
                            }
                            
                            public QuickFix.Fields.NoRelationshipRiskSecurityAltID get(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                return isSetNoRelationshipRiskSecurityAltID();
                            }
                            
                            public bool isSetNoRelationshipRiskSecurityAltID() 
                            { 
                                return isSetField(Tags.NoRelationshipRiskSecurityAltID);
                            }
                            public QuickFix.Fields.RelationshipRiskProduct relationshipRiskProduct
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskProduct val = new QuickFix.Fields.RelationshipRiskProduct();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                this.relationshipRiskProduct = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskProduct get(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                return isSetRelationshipRiskProduct();
                            }
                            
                            public bool isSetRelationshipRiskProduct() 
                            { 
                                return isSetField(Tags.RelationshipRiskProduct);
                            }
                            public QuickFix.Fields.RelationshipRiskProductComplex relationshipRiskProductComplex
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskProductComplex val = new QuickFix.Fields.RelationshipRiskProductComplex();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                this.relationshipRiskProductComplex = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskProductComplex get(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                return isSetRelationshipRiskProductComplex();
                            }
                            
                            public bool isSetRelationshipRiskProductComplex() 
                            { 
                                return isSetField(Tags.RelationshipRiskProductComplex);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityGroup relationshipRiskSecurityGroup
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityGroup val = new QuickFix.Fields.RelationshipRiskSecurityGroup();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                this.relationshipRiskSecurityGroup = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityGroup get(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                return isSetRelationshipRiskSecurityGroup();
                            }
                            
                            public bool isSetRelationshipRiskSecurityGroup() 
                            { 
                                return isSetField(Tags.RelationshipRiskSecurityGroup);
                            }
                            public QuickFix.Fields.RelationshipRiskCFICode relationshipRiskCFICode
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskCFICode val = new QuickFix.Fields.RelationshipRiskCFICode();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                this.relationshipRiskCFICode = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskCFICode get(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                return isSetRelationshipRiskCFICode();
                            }
                            
                            public bool isSetRelationshipRiskCFICode() 
                            { 
                                return isSetField(Tags.RelationshipRiskCFICode);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityType relationshipRiskSecurityType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityType val = new QuickFix.Fields.RelationshipRiskSecurityType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                this.relationshipRiskSecurityType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityType get(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                return isSetRelationshipRiskSecurityType();
                            }
                            
                            public bool isSetRelationshipRiskSecurityType() 
                            { 
                                return isSetField(Tags.RelationshipRiskSecurityType);
                            }
                            public QuickFix.Fields.RelationshipRiskSecuritySubType relationshipRiskSecuritySubType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecuritySubType val = new QuickFix.Fields.RelationshipRiskSecuritySubType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                this.relationshipRiskSecuritySubType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecuritySubType get(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                return isSetRelationshipRiskSecuritySubType();
                            }
                            
                            public bool isSetRelationshipRiskSecuritySubType() 
                            { 
                                return isSetField(Tags.RelationshipRiskSecuritySubType);
                            }
                            public QuickFix.Fields.RelationshipRiskMaturityMonthYear relationshipRiskMaturityMonthYear
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskMaturityMonthYear val = new QuickFix.Fields.RelationshipRiskMaturityMonthYear();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                this.relationshipRiskMaturityMonthYear = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskMaturityMonthYear get(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                return isSetRelationshipRiskMaturityMonthYear();
                            }
                            
                            public bool isSetRelationshipRiskMaturityMonthYear() 
                            { 
                                return isSetField(Tags.RelationshipRiskMaturityMonthYear);
                            }
                            public QuickFix.Fields.RelationshipRiskMaturityTime relationshipRiskMaturityTime
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskMaturityTime val = new QuickFix.Fields.RelationshipRiskMaturityTime();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                this.relationshipRiskMaturityTime = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskMaturityTime get(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                return isSetRelationshipRiskMaturityTime();
                            }
                            
                            public bool isSetRelationshipRiskMaturityTime() 
                            { 
                                return isSetField(Tags.RelationshipRiskMaturityTime);
                            }
                            public QuickFix.Fields.RelationshipRiskRestructuringType relationshipRiskRestructuringType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskRestructuringType val = new QuickFix.Fields.RelationshipRiskRestructuringType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                this.relationshipRiskRestructuringType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskRestructuringType get(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                return isSetRelationshipRiskRestructuringType();
                            }
                            
                            public bool isSetRelationshipRiskRestructuringType() 
                            { 
                                return isSetField(Tags.RelationshipRiskRestructuringType);
                            }
                            public QuickFix.Fields.RelationshipRiskSeniority relationshipRiskSeniority
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSeniority val = new QuickFix.Fields.RelationshipRiskSeniority();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                this.relationshipRiskSeniority = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSeniority get(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                return isSetRelationshipRiskSeniority();
                            }
                            
                            public bool isSetRelationshipRiskSeniority() 
                            { 
                                return isSetField(Tags.RelationshipRiskSeniority);
                            }
                            public QuickFix.Fields.RelationshipRiskPutOrCall relationshipRiskPutOrCall
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskPutOrCall val = new QuickFix.Fields.RelationshipRiskPutOrCall();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                this.relationshipRiskPutOrCall = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskPutOrCall get(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                return isSetRelationshipRiskPutOrCall();
                            }
                            
                            public bool isSetRelationshipRiskPutOrCall() 
                            { 
                                return isSetField(Tags.RelationshipRiskPutOrCall);
                            }
                            public QuickFix.Fields.RelationshipRiskFlexibleIndicator relationshipRiskFlexibleIndicator
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskFlexibleIndicator val = new QuickFix.Fields.RelationshipRiskFlexibleIndicator();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                this.relationshipRiskFlexibleIndicator = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskFlexibleIndicator get(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                return isSetRelationshipRiskFlexibleIndicator();
                            }
                            
                            public bool isSetRelationshipRiskFlexibleIndicator() 
                            { 
                                return isSetField(Tags.RelationshipRiskFlexibleIndicator);
                            }
                            public QuickFix.Fields.RelationshipRiskCouponRate relationshipRiskCouponRate
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskCouponRate val = new QuickFix.Fields.RelationshipRiskCouponRate();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                this.relationshipRiskCouponRate = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskCouponRate get(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                return isSetRelationshipRiskCouponRate();
                            }
                            
                            public bool isSetRelationshipRiskCouponRate() 
                            { 
                                return isSetField(Tags.RelationshipRiskCouponRate);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityExchange relationshipRiskSecurityExchange
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityExchange val = new QuickFix.Fields.RelationshipRiskSecurityExchange();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                this.relationshipRiskSecurityExchange = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityExchange get(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                return isSetRelationshipRiskSecurityExchange();
                            }
                            
                            public bool isSetRelationshipRiskSecurityExchange() 
                            { 
                                return isSetField(Tags.RelationshipRiskSecurityExchange);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityDesc relationshipRiskSecurityDesc
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityDesc val = new QuickFix.Fields.RelationshipRiskSecurityDesc();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                this.relationshipRiskSecurityDesc = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityDesc get(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                return isSetRelationshipRiskSecurityDesc();
                            }
                            
                            public bool isSetRelationshipRiskSecurityDesc() 
                            { 
                                return isSetField(Tags.RelationshipRiskSecurityDesc);
                            }
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen relationshipRiskEncodedSecurityDescLen
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val = new QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                this.relationshipRiskEncodedSecurityDescLen = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen get(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                return isSetRelationshipRiskEncodedSecurityDescLen();
                            }
                            
                            public bool isSetRelationshipRiskEncodedSecurityDescLen() 
                            { 
                                return isSetField(Tags.RelationshipRiskEncodedSecurityDescLen);
                            }
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDesc relationshipRiskEncodedSecurityDesc
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val = new QuickFix.Fields.RelationshipRiskEncodedSecurityDesc();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                this.relationshipRiskEncodedSecurityDesc = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDesc get(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                return isSetRelationshipRiskEncodedSecurityDesc();
                            }
                            
                            public bool isSetRelationshipRiskEncodedSecurityDesc() 
                            { 
                                return isSetField(Tags.RelationshipRiskEncodedSecurityDesc);
                            }
                            public QuickFix.Fields.RelationshipRiskInstrumentSettlType relationshipRiskInstrumentSettlType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskInstrumentSettlType val = new QuickFix.Fields.RelationshipRiskInstrumentSettlType();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                this.relationshipRiskInstrumentSettlType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentSettlType get(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                return isSetRelationshipRiskInstrumentSettlType();
                            }
                            
                            public bool isSetRelationshipRiskInstrumentSettlType() 
                            { 
                                return isSetField(Tags.RelationshipRiskInstrumentSettlType);
                            }
                            public QuickFix.Fields.RelationshipRiskInstrumentMultiplier relationshipRiskInstrumentMultiplier
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskInstrumentMultiplier val = new QuickFix.Fields.RelationshipRiskInstrumentMultiplier();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                this.relationshipRiskInstrumentMultiplier = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentMultiplier get(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                return isSetRelationshipRiskInstrumentMultiplier();
                            }
                            
                            public bool isSetRelationshipRiskInstrumentMultiplier() 
                            { 
                                return isSetField(Tags.RelationshipRiskInstrumentMultiplier);
                            }
                                                    public class NoRelationshipRiskSecurityAltID : Group
                            {
                                public NoRelationshipRiskSecurityAltID() 
                                  :base( Tags.NoRelationshipRiskSecurityAltID, Tags.RelationshipRiskSecurityAltID, fieldOrder)
                                {
                                }
                                public static int[] fieldOrder = {Tags.RelationshipRiskSecurityAltID, Tags.RelationshipRiskSecurityAltIDSource, 0};
                                                            public QuickFix.Fields.RelationshipRiskSecurityAltID relationshipRiskSecurityAltID
                                { 
                                    get 
                                    {
                                        QuickFix.Fields.RelationshipRiskSecurityAltID val = new QuickFix.Fields.RelationshipRiskSecurityAltID();
                                        getField(val);
                                        return val;
                                    }
                                    set { setField(value); }
                                }
                                
                                public void set(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    this.relationshipRiskSecurityAltID = val;
                                }
                                
                                public QuickFix.Fields.RelationshipRiskSecurityAltID get(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    getField(val);
                                    return val;
                                }
                                
                                public bool isSet(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    return isSetRelationshipRiskSecurityAltID();
                                }
                                
                                public bool isSetRelationshipRiskSecurityAltID() 
                                { 
                                    return isSetField(Tags.RelationshipRiskSecurityAltID);
                                }
                                public QuickFix.Fields.RelationshipRiskSecurityAltIDSource relationshipRiskSecurityAltIDSource
                                { 
                                    get 
                                    {
                                        QuickFix.Fields.RelationshipRiskSecurityAltIDSource val = new QuickFix.Fields.RelationshipRiskSecurityAltIDSource();
                                        getField(val);
                                        return val;
                                    }
                                    set { setField(value); }
                                }
                                
                                public void set(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    this.relationshipRiskSecurityAltIDSource = val;
                                }
                                
                                public QuickFix.Fields.RelationshipRiskSecurityAltIDSource get(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    getField(val);
                                    return val;
                                }
                                
                                public bool isSet(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    return isSetRelationshipRiskSecurityAltIDSource();
                                }
                                
                                public bool isSetRelationshipRiskSecurityAltIDSource() 
                                { 
                                    return isSetField(Tags.RelationshipRiskSecurityAltIDSource);
                                }
                            
                            }
                        }
                        public class NoRelationshipRiskWarningLevels : Group
                        {
                            public NoRelationshipRiskWarningLevels() 
                              :base( Tags.NoRelationshipRiskWarningLevels, Tags.RelationshipRiskWarningLevelPercent, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.RelationshipRiskWarningLevelPercent, Tags.RelationshipRiskWarningLevelName, 0};
                                                    public QuickFix.Fields.RelationshipRiskWarningLevelPercent relationshipRiskWarningLevelPercent
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskWarningLevelPercent val = new QuickFix.Fields.RelationshipRiskWarningLevelPercent();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                this.relationshipRiskWarningLevelPercent = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskWarningLevelPercent get(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                return isSetRelationshipRiskWarningLevelPercent();
                            }
                            
                            public bool isSetRelationshipRiskWarningLevelPercent() 
                            { 
                                return isSetField(Tags.RelationshipRiskWarningLevelPercent);
                            }
                            public QuickFix.Fields.RelationshipRiskWarningLevelName relationshipRiskWarningLevelName
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskWarningLevelName val = new QuickFix.Fields.RelationshipRiskWarningLevelName();
                                    getField(val);
                                    return val;
                                }
                                set { setField(value); }
                            }
                            
                            public void set(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                this.relationshipRiskWarningLevelName = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskWarningLevelName get(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                getField(val);
                                return val;
                            }
                            
                            public bool isSet(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                return isSetRelationshipRiskWarningLevelName();
                            }
                            
                            public bool isSetRelationshipRiskWarningLevelName() 
                            { 
                                return isSetField(Tags.RelationshipRiskWarningLevelName);
                            }
                        
                        }
                    }
                    public class NoPartyRelationships : Group
                    {
                        public NoPartyRelationships() 
                          :base( Tags.NoPartyRelationships, Tags.PartyRelationship, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.PartyRelationship, 0};
                                            public QuickFix.Fields.PartyRelationship partyRelationship
                        { 
                            get 
                            {
                                QuickFix.Fields.PartyRelationship val = new QuickFix.Fields.PartyRelationship();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.PartyRelationship val) 
                        { 
                            this.partyRelationship = val;
                        }
                        
                        public QuickFix.Fields.PartyRelationship get(QuickFix.Fields.PartyRelationship val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.PartyRelationship val) 
                        { 
                            return isSetPartyRelationship();
                        }
                        
                        public bool isSetPartyRelationship() 
                        { 
                            return isSetField(Tags.PartyRelationship);
                        }
                    
                    }
                }
            }
        }
    }
}
