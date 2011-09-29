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
                this.Header.SetField(new QuickFix.Fields.MsgType("CG"));
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
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplID val) 
            { 
                return IsSetApplID();
            }
            
            public bool IsSetApplID() 
            { 
                return IsSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return IsSetApplSeqNum();
            }
            
            public bool IsSetApplSeqNum() 
            { 
                return IsSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return IsSetApplLastSeqNum();
            }
            
            public bool IsSetApplLastSeqNum() 
            { 
                return IsSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return IsSetApplResendFlag();
            }
            
            public bool IsSetApplResendFlag() 
            { 
                return IsSetField(Tags.ApplResendFlag);
            }
            public QuickFix.Fields.PartyDetailsListReportID partyDetailsListReportID
            { 
                get 
                {
                    QuickFix.Fields.PartyDetailsListReportID val = new QuickFix.Fields.PartyDetailsListReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                this.partyDetailsListReportID = val;
            }
            
            public QuickFix.Fields.PartyDetailsListReportID Get(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PartyDetailsListReportID val) 
            { 
                return IsSetPartyDetailsListReportID();
            }
            
            public bool IsSetPartyDetailsListReportID() 
            { 
                return IsSetField(Tags.PartyDetailsListReportID);
            }
            public QuickFix.Fields.PartyDetailsListRequestID partyDetailsListRequestID
            { 
                get 
                {
                    QuickFix.Fields.PartyDetailsListRequestID val = new QuickFix.Fields.PartyDetailsListRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                this.partyDetailsListRequestID = val;
            }
            
            public QuickFix.Fields.PartyDetailsListRequestID Get(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PartyDetailsListRequestID val) 
            { 
                return IsSetPartyDetailsListRequestID();
            }
            
            public bool IsSetPartyDetailsListRequestID() 
            { 
                return IsSetField(Tags.PartyDetailsListRequestID);
            }
            public QuickFix.Fields.PartyDetailsRequestResult partyDetailsRequestResult
            { 
                get 
                {
                    QuickFix.Fields.PartyDetailsRequestResult val = new QuickFix.Fields.PartyDetailsRequestResult();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                this.partyDetailsRequestResult = val;
            }
            
            public QuickFix.Fields.PartyDetailsRequestResult Get(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PartyDetailsRequestResult val) 
            { 
                return IsSetPartyDetailsRequestResult();
            }
            
            public bool IsSetPartyDetailsRequestResult() 
            { 
                return IsSetField(Tags.PartyDetailsRequestResult);
            }
            public QuickFix.Fields.TotNoPartyList totNoPartyList
            { 
                get 
                {
                    QuickFix.Fields.TotNoPartyList val = new QuickFix.Fields.TotNoPartyList();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.TotNoPartyList val) 
            { 
                this.totNoPartyList = val;
            }
            
            public QuickFix.Fields.TotNoPartyList Get(QuickFix.Fields.TotNoPartyList val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.TotNoPartyList val) 
            { 
                return IsSetTotNoPartyList();
            }
            
            public bool IsSetTotNoPartyList() 
            { 
                return IsSetField(Tags.TotNoPartyList);
            }
            public QuickFix.Fields.LastFragment lastFragment
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
                this.lastFragment = val;
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
            public QuickFix.Fields.NoPartyList noPartyList
            { 
                get 
                {
                    QuickFix.Fields.NoPartyList val = new QuickFix.Fields.NoPartyList();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoPartyList val) 
            { 
                this.noPartyList = val;
            }
            
            public QuickFix.Fields.NoPartyList Get(QuickFix.Fields.NoPartyList val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoPartyList val) 
            { 
                return IsSetNoPartyList();
            }
            
            public bool IsSetNoPartyList() 
            { 
                return IsSetField(Tags.NoPartyList);
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
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PartyID val) 
                { 
                    this.partyID = val;
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
                public QuickFix.Fields.PartyIDSource partyIDSource
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
                    this.partyIDSource = val;
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
                public QuickFix.Fields.PartyRole partyRole
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
                    this.partyRole = val;
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
                public QuickFix.Fields.NoPartySubIDs noPartySubIDs
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
                    this.noPartySubIDs = val;
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
                public QuickFix.Fields.NoPartyAltIDs noPartyAltIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoPartyAltIDs val = new QuickFix.Fields.NoPartyAltIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    this.noPartyAltIDs = val;
                }
                
                public QuickFix.Fields.NoPartyAltIDs Get(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoPartyAltIDs val) 
                { 
                    return IsSetNoPartyAltIDs();
                }
                
                public bool IsSetNoPartyAltIDs() 
                { 
                    return IsSetField(Tags.NoPartyAltIDs);
                }
                public QuickFix.Fields.NoContextPartyIDs noContextPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoContextPartyIDs val = new QuickFix.Fields.NoContextPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    this.noContextPartyIDs = val;
                }
                
                public QuickFix.Fields.NoContextPartyIDs Get(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoContextPartyIDs val) 
                { 
                    return IsSetNoContextPartyIDs();
                }
                
                public bool IsSetNoContextPartyIDs() 
                { 
                    return IsSetField(Tags.NoContextPartyIDs);
                }
                public QuickFix.Fields.NoRiskLimits noRiskLimits
                { 
                    get 
                    {
                        QuickFix.Fields.NoRiskLimits val = new QuickFix.Fields.NoRiskLimits();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoRiskLimits val) 
                { 
                    this.noRiskLimits = val;
                }
                
                public QuickFix.Fields.NoRiskLimits Get(QuickFix.Fields.NoRiskLimits val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoRiskLimits val) 
                { 
                    return IsSetNoRiskLimits();
                }
                
                public bool IsSetNoRiskLimits() 
                { 
                    return IsSetField(Tags.NoRiskLimits);
                }
                public QuickFix.Fields.NoRelatedPartyIDs noRelatedPartyIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoRelatedPartyIDs val = new QuickFix.Fields.NoRelatedPartyIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    this.noRelatedPartyIDs = val;
                }
                
                public QuickFix.Fields.NoRelatedPartyIDs Get(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoRelatedPartyIDs val) 
                { 
                    return IsSetNoRelatedPartyIDs();
                }
                
                public bool IsSetNoRelatedPartyIDs() 
                { 
                    return IsSetField(Tags.NoRelatedPartyIDs);
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
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartySubID val) 
                    { 
                        this.partySubID = val;
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
                    public QuickFix.Fields.PartySubIDType partySubIDType
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
                        this.partySubIDType = val;
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
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyAltID val) 
                    { 
                        this.partyAltID = val;
                    }
                    
                    public QuickFix.Fields.PartyAltID Get(QuickFix.Fields.PartyAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyAltID val) 
                    { 
                        return IsSetPartyAltID();
                    }
                    
                    public bool IsSetPartyAltID() 
                    { 
                        return IsSetField(Tags.PartyAltID);
                    }
                    public QuickFix.Fields.PartyAltIDSource partyAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.PartyAltIDSource val = new QuickFix.Fields.PartyAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        this.partyAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.PartyAltIDSource Get(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.PartyAltIDSource val) 
                    { 
                        return IsSetPartyAltIDSource();
                    }
                    
                    public bool IsSetPartyAltIDSource() 
                    { 
                        return IsSetField(Tags.PartyAltIDSource);
                    }
                    public QuickFix.Fields.NoPartyAltSubIDs noPartyAltSubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartyAltSubIDs val = new QuickFix.Fields.NoPartyAltSubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        this.noPartyAltSubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoPartyAltSubIDs Get(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoPartyAltSubIDs val) 
                    { 
                        return IsSetNoPartyAltSubIDs();
                    }
                    
                    public bool IsSetNoPartyAltSubIDs() 
                    { 
                        return IsSetField(Tags.NoPartyAltSubIDs);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            this.partyAltSubID = val;
                        }
                        
                        public QuickFix.Fields.PartyAltSubID Get(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartyAltSubID val) 
                        { 
                            return IsSetPartyAltSubID();
                        }
                        
                        public bool IsSetPartyAltSubID() 
                        { 
                            return IsSetField(Tags.PartyAltSubID);
                        }
                        public QuickFix.Fields.PartyAltSubIDType partyAltSubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.PartyAltSubIDType val = new QuickFix.Fields.PartyAltSubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            this.partyAltSubIDType = val;
                        }
                        
                        public QuickFix.Fields.PartyAltSubIDType Get(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartyAltSubIDType val) 
                        { 
                            return IsSetPartyAltSubIDType();
                        }
                        
                        public bool IsSetPartyAltSubIDType() 
                        { 
                            return IsSetField(Tags.PartyAltSubIDType);
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
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContextPartyID val) 
                    { 
                        this.contextPartyID = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyID Get(QuickFix.Fields.ContextPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContextPartyID val) 
                    { 
                        return IsSetContextPartyID();
                    }
                    
                    public bool IsSetContextPartyID() 
                    { 
                        return IsSetField(Tags.ContextPartyID);
                    }
                    public QuickFix.Fields.ContextPartyIDSource contextPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.ContextPartyIDSource val = new QuickFix.Fields.ContextPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        this.contextPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyIDSource Get(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContextPartyIDSource val) 
                    { 
                        return IsSetContextPartyIDSource();
                    }
                    
                    public bool IsSetContextPartyIDSource() 
                    { 
                        return IsSetField(Tags.ContextPartyIDSource);
                    }
                    public QuickFix.Fields.ContextPartyRole contextPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.ContextPartyRole val = new QuickFix.Fields.ContextPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        this.contextPartyRole = val;
                    }
                    
                    public QuickFix.Fields.ContextPartyRole Get(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ContextPartyRole val) 
                    { 
                        return IsSetContextPartyRole();
                    }
                    
                    public bool IsSetContextPartyRole() 
                    { 
                        return IsSetField(Tags.ContextPartyRole);
                    }
                    public QuickFix.Fields.NoContextPartySubIDs noContextPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoContextPartySubIDs val = new QuickFix.Fields.NoContextPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        this.noContextPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoContextPartySubIDs Get(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoContextPartySubIDs val) 
                    { 
                        return IsSetNoContextPartySubIDs();
                    }
                    
                    public bool IsSetNoContextPartySubIDs() 
                    { 
                        return IsSetField(Tags.NoContextPartySubIDs);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            this.contextPartySubID = val;
                        }
                        
                        public QuickFix.Fields.ContextPartySubID Get(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ContextPartySubID val) 
                        { 
                            return IsSetContextPartySubID();
                        }
                        
                        public bool IsSetContextPartySubID() 
                        { 
                            return IsSetField(Tags.ContextPartySubID);
                        }
                        public QuickFix.Fields.ContextPartySubIDType contextPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.ContextPartySubIDType val = new QuickFix.Fields.ContextPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            this.contextPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.ContextPartySubIDType Get(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.ContextPartySubIDType val) 
                        { 
                            return IsSetContextPartySubIDType();
                        }
                        
                        public bool IsSetContextPartySubIDType() 
                        { 
                            return IsSetField(Tags.ContextPartySubIDType);
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
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RiskLimitType val) 
                    { 
                        this.riskLimitType = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitType Get(QuickFix.Fields.RiskLimitType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RiskLimitType val) 
                    { 
                        return IsSetRiskLimitType();
                    }
                    
                    public bool IsSetRiskLimitType() 
                    { 
                        return IsSetField(Tags.RiskLimitType);
                    }
                    public QuickFix.Fields.RiskLimitAmount riskLimitAmount
                    { 
                        get 
                        {
                            QuickFix.Fields.RiskLimitAmount val = new QuickFix.Fields.RiskLimitAmount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        this.riskLimitAmount = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitAmount Get(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RiskLimitAmount val) 
                    { 
                        return IsSetRiskLimitAmount();
                    }
                    
                    public bool IsSetRiskLimitAmount() 
                    { 
                        return IsSetField(Tags.RiskLimitAmount);
                    }
                    public QuickFix.Fields.RiskLimitCurrency riskLimitCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.RiskLimitCurrency val = new QuickFix.Fields.RiskLimitCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        this.riskLimitCurrency = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitCurrency Get(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RiskLimitCurrency val) 
                    { 
                        return IsSetRiskLimitCurrency();
                    }
                    
                    public bool IsSetRiskLimitCurrency() 
                    { 
                        return IsSetField(Tags.RiskLimitCurrency);
                    }
                    public QuickFix.Fields.RiskLimitPlatform riskLimitPlatform
                    { 
                        get 
                        {
                            QuickFix.Fields.RiskLimitPlatform val = new QuickFix.Fields.RiskLimitPlatform();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        this.riskLimitPlatform = val;
                    }
                    
                    public QuickFix.Fields.RiskLimitPlatform Get(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RiskLimitPlatform val) 
                    { 
                        return IsSetRiskLimitPlatform();
                    }
                    
                    public bool IsSetRiskLimitPlatform() 
                    { 
                        return IsSetField(Tags.RiskLimitPlatform);
                    }
                    public QuickFix.Fields.NoRiskInstruments noRiskInstruments
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRiskInstruments val = new QuickFix.Fields.NoRiskInstruments();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        this.noRiskInstruments = val;
                    }
                    
                    public QuickFix.Fields.NoRiskInstruments Get(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRiskInstruments val) 
                    { 
                        return IsSetNoRiskInstruments();
                    }
                    
                    public bool IsSetNoRiskInstruments() 
                    { 
                        return IsSetField(Tags.NoRiskInstruments);
                    }
                    public QuickFix.Fields.NoRiskWarningLevels noRiskWarningLevels
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRiskWarningLevels val = new QuickFix.Fields.NoRiskWarningLevels();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        this.noRiskWarningLevels = val;
                    }
                    
                    public QuickFix.Fields.NoRiskWarningLevels Get(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRiskWarningLevels val) 
                    { 
                        return IsSetNoRiskWarningLevels();
                    }
                    
                    public bool IsSetNoRiskWarningLevels() 
                    { 
                        return IsSetField(Tags.NoRiskWarningLevels);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            this.riskInstrumentOperator = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentOperator Get(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskInstrumentOperator val) 
                        { 
                            return IsSetRiskInstrumentOperator();
                        }
                        
                        public bool IsSetRiskInstrumentOperator() 
                        { 
                            return IsSetField(Tags.RiskInstrumentOperator);
                        }
                        public QuickFix.Fields.RiskSymbol riskSymbol
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSymbol val = new QuickFix.Fields.RiskSymbol();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSymbol val) 
                        { 
                            this.riskSymbol = val;
                        }
                        
                        public QuickFix.Fields.RiskSymbol Get(QuickFix.Fields.RiskSymbol val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSymbol val) 
                        { 
                            return IsSetRiskSymbol();
                        }
                        
                        public bool IsSetRiskSymbol() 
                        { 
                            return IsSetField(Tags.RiskSymbol);
                        }
                        public QuickFix.Fields.RiskSymbolSfx riskSymbolSfx
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSymbolSfx val = new QuickFix.Fields.RiskSymbolSfx();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            this.riskSymbolSfx = val;
                        }
                        
                        public QuickFix.Fields.RiskSymbolSfx Get(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSymbolSfx val) 
                        { 
                            return IsSetRiskSymbolSfx();
                        }
                        
                        public bool IsSetRiskSymbolSfx() 
                        { 
                            return IsSetField(Tags.RiskSymbolSfx);
                        }
                        public QuickFix.Fields.RiskSecurityID riskSecurityID
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityID val = new QuickFix.Fields.RiskSecurityID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            this.riskSecurityID = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityID Get(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityID val) 
                        { 
                            return IsSetRiskSecurityID();
                        }
                        
                        public bool IsSetRiskSecurityID() 
                        { 
                            return IsSetField(Tags.RiskSecurityID);
                        }
                        public QuickFix.Fields.RiskSecurityIDSource riskSecurityIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityIDSource val = new QuickFix.Fields.RiskSecurityIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            this.riskSecurityIDSource = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityIDSource Get(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityIDSource val) 
                        { 
                            return IsSetRiskSecurityIDSource();
                        }
                        
                        public bool IsSetRiskSecurityIDSource() 
                        { 
                            return IsSetField(Tags.RiskSecurityIDSource);
                        }
                        public QuickFix.Fields.NoRiskSecurityAltID noRiskSecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRiskSecurityAltID val = new QuickFix.Fields.NoRiskSecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            this.noRiskSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.NoRiskSecurityAltID Get(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRiskSecurityAltID val) 
                        { 
                            return IsSetNoRiskSecurityAltID();
                        }
                        
                        public bool IsSetNoRiskSecurityAltID() 
                        { 
                            return IsSetField(Tags.NoRiskSecurityAltID);
                        }
                        public QuickFix.Fields.RiskProduct riskProduct
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskProduct val = new QuickFix.Fields.RiskProduct();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskProduct val) 
                        { 
                            this.riskProduct = val;
                        }
                        
                        public QuickFix.Fields.RiskProduct Get(QuickFix.Fields.RiskProduct val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskProduct val) 
                        { 
                            return IsSetRiskProduct();
                        }
                        
                        public bool IsSetRiskProduct() 
                        { 
                            return IsSetField(Tags.RiskProduct);
                        }
                        public QuickFix.Fields.RiskProductComplex riskProductComplex
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskProductComplex val = new QuickFix.Fields.RiskProductComplex();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            this.riskProductComplex = val;
                        }
                        
                        public QuickFix.Fields.RiskProductComplex Get(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskProductComplex val) 
                        { 
                            return IsSetRiskProductComplex();
                        }
                        
                        public bool IsSetRiskProductComplex() 
                        { 
                            return IsSetField(Tags.RiskProductComplex);
                        }
                        public QuickFix.Fields.RiskSecurityGroup riskSecurityGroup
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityGroup val = new QuickFix.Fields.RiskSecurityGroup();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            this.riskSecurityGroup = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityGroup Get(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityGroup val) 
                        { 
                            return IsSetRiskSecurityGroup();
                        }
                        
                        public bool IsSetRiskSecurityGroup() 
                        { 
                            return IsSetField(Tags.RiskSecurityGroup);
                        }
                        public QuickFix.Fields.RiskCFICode riskCFICode
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskCFICode val = new QuickFix.Fields.RiskCFICode();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskCFICode val) 
                        { 
                            this.riskCFICode = val;
                        }
                        
                        public QuickFix.Fields.RiskCFICode Get(QuickFix.Fields.RiskCFICode val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskCFICode val) 
                        { 
                            return IsSetRiskCFICode();
                        }
                        
                        public bool IsSetRiskCFICode() 
                        { 
                            return IsSetField(Tags.RiskCFICode);
                        }
                        public QuickFix.Fields.RiskSecurityType riskSecurityType
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityType val = new QuickFix.Fields.RiskSecurityType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            this.riskSecurityType = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityType Get(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityType val) 
                        { 
                            return IsSetRiskSecurityType();
                        }
                        
                        public bool IsSetRiskSecurityType() 
                        { 
                            return IsSetField(Tags.RiskSecurityType);
                        }
                        public QuickFix.Fields.RiskSecuritySubType riskSecuritySubType
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecuritySubType val = new QuickFix.Fields.RiskSecuritySubType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            this.riskSecuritySubType = val;
                        }
                        
                        public QuickFix.Fields.RiskSecuritySubType Get(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecuritySubType val) 
                        { 
                            return IsSetRiskSecuritySubType();
                        }
                        
                        public bool IsSetRiskSecuritySubType() 
                        { 
                            return IsSetField(Tags.RiskSecuritySubType);
                        }
                        public QuickFix.Fields.RiskMaturityMonthYear riskMaturityMonthYear
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskMaturityMonthYear val = new QuickFix.Fields.RiskMaturityMonthYear();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            this.riskMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.RiskMaturityMonthYear Get(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskMaturityMonthYear val) 
                        { 
                            return IsSetRiskMaturityMonthYear();
                        }
                        
                        public bool IsSetRiskMaturityMonthYear() 
                        { 
                            return IsSetField(Tags.RiskMaturityMonthYear);
                        }
                        public QuickFix.Fields.RiskMaturityTime riskMaturityTime
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskMaturityTime val = new QuickFix.Fields.RiskMaturityTime();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            this.riskMaturityTime = val;
                        }
                        
                        public QuickFix.Fields.RiskMaturityTime Get(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskMaturityTime val) 
                        { 
                            return IsSetRiskMaturityTime();
                        }
                        
                        public bool IsSetRiskMaturityTime() 
                        { 
                            return IsSetField(Tags.RiskMaturityTime);
                        }
                        public QuickFix.Fields.RiskRestructuringType riskRestructuringType
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskRestructuringType val = new QuickFix.Fields.RiskRestructuringType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            this.riskRestructuringType = val;
                        }
                        
                        public QuickFix.Fields.RiskRestructuringType Get(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskRestructuringType val) 
                        { 
                            return IsSetRiskRestructuringType();
                        }
                        
                        public bool IsSetRiskRestructuringType() 
                        { 
                            return IsSetField(Tags.RiskRestructuringType);
                        }
                        public QuickFix.Fields.RiskSeniority riskSeniority
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSeniority val = new QuickFix.Fields.RiskSeniority();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSeniority val) 
                        { 
                            this.riskSeniority = val;
                        }
                        
                        public QuickFix.Fields.RiskSeniority Get(QuickFix.Fields.RiskSeniority val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSeniority val) 
                        { 
                            return IsSetRiskSeniority();
                        }
                        
                        public bool IsSetRiskSeniority() 
                        { 
                            return IsSetField(Tags.RiskSeniority);
                        }
                        public QuickFix.Fields.RiskPutOrCall riskPutOrCall
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskPutOrCall val = new QuickFix.Fields.RiskPutOrCall();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            this.riskPutOrCall = val;
                        }
                        
                        public QuickFix.Fields.RiskPutOrCall Get(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskPutOrCall val) 
                        { 
                            return IsSetRiskPutOrCall();
                        }
                        
                        public bool IsSetRiskPutOrCall() 
                        { 
                            return IsSetField(Tags.RiskPutOrCall);
                        }
                        public QuickFix.Fields.RiskFlexibleIndicator riskFlexibleIndicator
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskFlexibleIndicator val = new QuickFix.Fields.RiskFlexibleIndicator();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            this.riskFlexibleIndicator = val;
                        }
                        
                        public QuickFix.Fields.RiskFlexibleIndicator Get(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskFlexibleIndicator val) 
                        { 
                            return IsSetRiskFlexibleIndicator();
                        }
                        
                        public bool IsSetRiskFlexibleIndicator() 
                        { 
                            return IsSetField(Tags.RiskFlexibleIndicator);
                        }
                        public QuickFix.Fields.RiskCouponRate riskCouponRate
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskCouponRate val = new QuickFix.Fields.RiskCouponRate();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            this.riskCouponRate = val;
                        }
                        
                        public QuickFix.Fields.RiskCouponRate Get(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskCouponRate val) 
                        { 
                            return IsSetRiskCouponRate();
                        }
                        
                        public bool IsSetRiskCouponRate() 
                        { 
                            return IsSetField(Tags.RiskCouponRate);
                        }
                        public QuickFix.Fields.RiskSecurityExchange riskSecurityExchange
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityExchange val = new QuickFix.Fields.RiskSecurityExchange();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            this.riskSecurityExchange = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityExchange Get(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityExchange val) 
                        { 
                            return IsSetRiskSecurityExchange();
                        }
                        
                        public bool IsSetRiskSecurityExchange() 
                        { 
                            return IsSetField(Tags.RiskSecurityExchange);
                        }
                        public QuickFix.Fields.RiskSecurityDesc riskSecurityDesc
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskSecurityDesc val = new QuickFix.Fields.RiskSecurityDesc();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            this.riskSecurityDesc = val;
                        }
                        
                        public QuickFix.Fields.RiskSecurityDesc Get(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskSecurityDesc val) 
                        { 
                            return IsSetRiskSecurityDesc();
                        }
                        
                        public bool IsSetRiskSecurityDesc() 
                        { 
                            return IsSetField(Tags.RiskSecurityDesc);
                        }
                        public QuickFix.Fields.RiskEncodedSecurityDescLen riskEncodedSecurityDescLen
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskEncodedSecurityDescLen val = new QuickFix.Fields.RiskEncodedSecurityDescLen();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            this.riskEncodedSecurityDescLen = val;
                        }
                        
                        public QuickFix.Fields.RiskEncodedSecurityDescLen Get(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskEncodedSecurityDescLen val) 
                        { 
                            return IsSetRiskEncodedSecurityDescLen();
                        }
                        
                        public bool IsSetRiskEncodedSecurityDescLen() 
                        { 
                            return IsSetField(Tags.RiskEncodedSecurityDescLen);
                        }
                        public QuickFix.Fields.RiskEncodedSecurityDesc riskEncodedSecurityDesc
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskEncodedSecurityDesc val = new QuickFix.Fields.RiskEncodedSecurityDesc();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            this.riskEncodedSecurityDesc = val;
                        }
                        
                        public QuickFix.Fields.RiskEncodedSecurityDesc Get(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskEncodedSecurityDesc val) 
                        { 
                            return IsSetRiskEncodedSecurityDesc();
                        }
                        
                        public bool IsSetRiskEncodedSecurityDesc() 
                        { 
                            return IsSetField(Tags.RiskEncodedSecurityDesc);
                        }
                        public QuickFix.Fields.RiskInstrumentSettlType riskInstrumentSettlType
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskInstrumentSettlType val = new QuickFix.Fields.RiskInstrumentSettlType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            this.riskInstrumentSettlType = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentSettlType Get(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskInstrumentSettlType val) 
                        { 
                            return IsSetRiskInstrumentSettlType();
                        }
                        
                        public bool IsSetRiskInstrumentSettlType() 
                        { 
                            return IsSetField(Tags.RiskInstrumentSettlType);
                        }
                        public QuickFix.Fields.RiskInstrumentMultiplier riskInstrumentMultiplier
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskInstrumentMultiplier val = new QuickFix.Fields.RiskInstrumentMultiplier();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            this.riskInstrumentMultiplier = val;
                        }
                        
                        public QuickFix.Fields.RiskInstrumentMultiplier Get(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskInstrumentMultiplier val) 
                        { 
                            return IsSetRiskInstrumentMultiplier();
                        }
                        
                        public bool IsSetRiskInstrumentMultiplier() 
                        { 
                            return IsSetField(Tags.RiskInstrumentMultiplier);
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
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                this.riskSecurityAltID = val;
                            }
                            
                            public QuickFix.Fields.RiskSecurityAltID Get(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RiskSecurityAltID val) 
                            { 
                                return IsSetRiskSecurityAltID();
                            }
                            
                            public bool IsSetRiskSecurityAltID() 
                            { 
                                return IsSetField(Tags.RiskSecurityAltID);
                            }
                            public QuickFix.Fields.RiskSecurityAltIDSource riskSecurityAltIDSource
                            { 
                                get 
                                {
                                    QuickFix.Fields.RiskSecurityAltIDSource val = new QuickFix.Fields.RiskSecurityAltIDSource();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                this.riskSecurityAltIDSource = val;
                            }
                            
                            public QuickFix.Fields.RiskSecurityAltIDSource Get(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RiskSecurityAltIDSource val) 
                            { 
                                return IsSetRiskSecurityAltIDSource();
                            }
                            
                            public bool IsSetRiskSecurityAltIDSource() 
                            { 
                                return IsSetField(Tags.RiskSecurityAltIDSource);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            this.riskWarningLevelPercent = val;
                        }
                        
                        public QuickFix.Fields.RiskWarningLevelPercent Get(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskWarningLevelPercent val) 
                        { 
                            return IsSetRiskWarningLevelPercent();
                        }
                        
                        public bool IsSetRiskWarningLevelPercent() 
                        { 
                            return IsSetField(Tags.RiskWarningLevelPercent);
                        }
                        public QuickFix.Fields.RiskWarningLevelName riskWarningLevelName
                        { 
                            get 
                            {
                                QuickFix.Fields.RiskWarningLevelName val = new QuickFix.Fields.RiskWarningLevelName();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            this.riskWarningLevelName = val;
                        }
                        
                        public QuickFix.Fields.RiskWarningLevelName Get(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RiskWarningLevelName val) 
                        { 
                            return IsSetRiskWarningLevelName();
                        }
                        
                        public bool IsSetRiskWarningLevelName() 
                        { 
                            return IsSetField(Tags.RiskWarningLevelName);
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
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        this.relatedPartyID = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyID Get(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RelatedPartyID val) 
                    { 
                        return IsSetRelatedPartyID();
                    }
                    
                    public bool IsSetRelatedPartyID() 
                    { 
                        return IsSetField(Tags.RelatedPartyID);
                    }
                    public QuickFix.Fields.RelatedPartyIDSource relatedPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.RelatedPartyIDSource val = new QuickFix.Fields.RelatedPartyIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        this.relatedPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyIDSource Get(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RelatedPartyIDSource val) 
                    { 
                        return IsSetRelatedPartyIDSource();
                    }
                    
                    public bool IsSetRelatedPartyIDSource() 
                    { 
                        return IsSetField(Tags.RelatedPartyIDSource);
                    }
                    public QuickFix.Fields.RelatedPartyRole relatedPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.RelatedPartyRole val = new QuickFix.Fields.RelatedPartyRole();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        this.relatedPartyRole = val;
                    }
                    
                    public QuickFix.Fields.RelatedPartyRole Get(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RelatedPartyRole val) 
                    { 
                        return IsSetRelatedPartyRole();
                    }
                    
                    public bool IsSetRelatedPartyRole() 
                    { 
                        return IsSetField(Tags.RelatedPartyRole);
                    }
                    public QuickFix.Fields.NoRelatedPartySubIDs noRelatedPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRelatedPartySubIDs val = new QuickFix.Fields.NoRelatedPartySubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        this.noRelatedPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedPartySubIDs Get(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRelatedPartySubIDs val) 
                    { 
                        return IsSetNoRelatedPartySubIDs();
                    }
                    
                    public bool IsSetNoRelatedPartySubIDs() 
                    { 
                        return IsSetField(Tags.NoRelatedPartySubIDs);
                    }
                    public QuickFix.Fields.NoRelatedPartyAltIDs noRelatedPartyAltIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRelatedPartyAltIDs val = new QuickFix.Fields.NoRelatedPartyAltIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        this.noRelatedPartyAltIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedPartyAltIDs Get(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRelatedPartyAltIDs val) 
                    { 
                        return IsSetNoRelatedPartyAltIDs();
                    }
                    
                    public bool IsSetNoRelatedPartyAltIDs() 
                    { 
                        return IsSetField(Tags.NoRelatedPartyAltIDs);
                    }
                    public QuickFix.Fields.NoRelatedContextPartyIDs noRelatedContextPartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRelatedContextPartyIDs val = new QuickFix.Fields.NoRelatedContextPartyIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        this.noRelatedContextPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoRelatedContextPartyIDs Get(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRelatedContextPartyIDs val) 
                    { 
                        return IsSetNoRelatedContextPartyIDs();
                    }
                    
                    public bool IsSetNoRelatedContextPartyIDs() 
                    { 
                        return IsSetField(Tags.NoRelatedContextPartyIDs);
                    }
                    public QuickFix.Fields.NoRelationshipRiskLimits noRelationshipRiskLimits
                    { 
                        get 
                        {
                            QuickFix.Fields.NoRelationshipRiskLimits val = new QuickFix.Fields.NoRelationshipRiskLimits();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        this.noRelationshipRiskLimits = val;
                    }
                    
                    public QuickFix.Fields.NoRelationshipRiskLimits Get(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoRelationshipRiskLimits val) 
                    { 
                        return IsSetNoRelationshipRiskLimits();
                    }
                    
                    public bool IsSetNoRelationshipRiskLimits() 
                    { 
                        return IsSetField(Tags.NoRelationshipRiskLimits);
                    }
                    public QuickFix.Fields.NoPartyRelationships noPartyRelationships
                    { 
                        get 
                        {
                            QuickFix.Fields.NoPartyRelationships val = new QuickFix.Fields.NoPartyRelationships();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        this.noPartyRelationships = val;
                    }
                    
                    public QuickFix.Fields.NoPartyRelationships Get(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoPartyRelationships val) 
                    { 
                        return IsSetNoPartyRelationships();
                    }
                    
                    public bool IsSetNoPartyRelationships() 
                    { 
                        return IsSetField(Tags.NoPartyRelationships);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            this.relatedPartySubID = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartySubID Get(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedPartySubID val) 
                        { 
                            return IsSetRelatedPartySubID();
                        }
                        
                        public bool IsSetRelatedPartySubID() 
                        { 
                            return IsSetField(Tags.RelatedPartySubID);
                        }
                        public QuickFix.Fields.RelatedPartySubIDType relatedPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedPartySubIDType val = new QuickFix.Fields.RelatedPartySubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            this.relatedPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartySubIDType Get(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedPartySubIDType val) 
                        { 
                            return IsSetRelatedPartySubIDType();
                        }
                        
                        public bool IsSetRelatedPartySubIDType() 
                        { 
                            return IsSetField(Tags.RelatedPartySubIDType);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            this.relatedPartyAltID = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartyAltID Get(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedPartyAltID val) 
                        { 
                            return IsSetRelatedPartyAltID();
                        }
                        
                        public bool IsSetRelatedPartyAltID() 
                        { 
                            return IsSetField(Tags.RelatedPartyAltID);
                        }
                        public QuickFix.Fields.RelatedPartyAltIDSource relatedPartyAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedPartyAltIDSource val = new QuickFix.Fields.RelatedPartyAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            this.relatedPartyAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.RelatedPartyAltIDSource Get(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedPartyAltIDSource val) 
                        { 
                            return IsSetRelatedPartyAltIDSource();
                        }
                        
                        public bool IsSetRelatedPartyAltIDSource() 
                        { 
                            return IsSetField(Tags.RelatedPartyAltIDSource);
                        }
                        public QuickFix.Fields.NoRelatedPartyAltSubIDs noRelatedPartyAltSubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRelatedPartyAltSubIDs val = new QuickFix.Fields.NoRelatedPartyAltSubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            this.noRelatedPartyAltSubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoRelatedPartyAltSubIDs Get(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRelatedPartyAltSubIDs val) 
                        { 
                            return IsSetNoRelatedPartyAltSubIDs();
                        }
                        
                        public bool IsSetNoRelatedPartyAltSubIDs() 
                        { 
                            return IsSetField(Tags.NoRelatedPartyAltSubIDs);
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
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                this.relatedPartyAltSubID = val;
                            }
                            
                            public QuickFix.Fields.RelatedPartyAltSubID Get(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelatedPartyAltSubID val) 
                            { 
                                return IsSetRelatedPartyAltSubID();
                            }
                            
                            public bool IsSetRelatedPartyAltSubID() 
                            { 
                                return IsSetField(Tags.RelatedPartyAltSubID);
                            }
                            public QuickFix.Fields.RelatedPartyAltSubIDType relatedPartyAltSubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelatedPartyAltSubIDType val = new QuickFix.Fields.RelatedPartyAltSubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                this.relatedPartyAltSubIDType = val;
                            }
                            
                            public QuickFix.Fields.RelatedPartyAltSubIDType Get(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelatedPartyAltSubIDType val) 
                            { 
                                return IsSetRelatedPartyAltSubIDType();
                            }
                            
                            public bool IsSetRelatedPartyAltSubIDType() 
                            { 
                                return IsSetField(Tags.RelatedPartyAltSubIDType);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            this.relatedContextPartyID = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyID Get(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedContextPartyID val) 
                        { 
                            return IsSetRelatedContextPartyID();
                        }
                        
                        public bool IsSetRelatedContextPartyID() 
                        { 
                            return IsSetField(Tags.RelatedContextPartyID);
                        }
                        public QuickFix.Fields.RelatedContextPartyIDSource relatedContextPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedContextPartyIDSource val = new QuickFix.Fields.RelatedContextPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            this.relatedContextPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyIDSource Get(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedContextPartyIDSource val) 
                        { 
                            return IsSetRelatedContextPartyIDSource();
                        }
                        
                        public bool IsSetRelatedContextPartyIDSource() 
                        { 
                            return IsSetField(Tags.RelatedContextPartyIDSource);
                        }
                        public QuickFix.Fields.RelatedContextPartyRole relatedContextPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.RelatedContextPartyRole val = new QuickFix.Fields.RelatedContextPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            this.relatedContextPartyRole = val;
                        }
                        
                        public QuickFix.Fields.RelatedContextPartyRole Get(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelatedContextPartyRole val) 
                        { 
                            return IsSetRelatedContextPartyRole();
                        }
                        
                        public bool IsSetRelatedContextPartyRole() 
                        { 
                            return IsSetField(Tags.RelatedContextPartyRole);
                        }
                        public QuickFix.Fields.NoRelatedContextPartySubIDs noRelatedContextPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRelatedContextPartySubIDs val = new QuickFix.Fields.NoRelatedContextPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            this.noRelatedContextPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoRelatedContextPartySubIDs Get(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRelatedContextPartySubIDs val) 
                        { 
                            return IsSetNoRelatedContextPartySubIDs();
                        }
                        
                        public bool IsSetNoRelatedContextPartySubIDs() 
                        { 
                            return IsSetField(Tags.NoRelatedContextPartySubIDs);
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
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                this.relatedContextPartySubID = val;
                            }
                            
                            public QuickFix.Fields.RelatedContextPartySubID Get(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelatedContextPartySubID val) 
                            { 
                                return IsSetRelatedContextPartySubID();
                            }
                            
                            public bool IsSetRelatedContextPartySubID() 
                            { 
                                return IsSetField(Tags.RelatedContextPartySubID);
                            }
                            public QuickFix.Fields.RelatedContextPartySubIDType relatedContextPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelatedContextPartySubIDType val = new QuickFix.Fields.RelatedContextPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                this.relatedContextPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.RelatedContextPartySubIDType Get(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelatedContextPartySubIDType val) 
                            { 
                                return IsSetRelatedContextPartySubIDType();
                            }
                            
                            public bool IsSetRelatedContextPartySubIDType() 
                            { 
                                return IsSetField(Tags.RelatedContextPartySubIDType);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            this.relationshipRiskLimitType = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitType Get(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitType val) 
                        { 
                            return IsSetRelationshipRiskLimitType();
                        }
                        
                        public bool IsSetRelationshipRiskLimitType() 
                        { 
                            return IsSetField(Tags.RelationshipRiskLimitType);
                        }
                        public QuickFix.Fields.RelationshipRiskLimitAmount relationshipRiskLimitAmount
                        { 
                            get 
                            {
                                QuickFix.Fields.RelationshipRiskLimitAmount val = new QuickFix.Fields.RelationshipRiskLimitAmount();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            this.relationshipRiskLimitAmount = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitAmount Get(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitAmount val) 
                        { 
                            return IsSetRelationshipRiskLimitAmount();
                        }
                        
                        public bool IsSetRelationshipRiskLimitAmount() 
                        { 
                            return IsSetField(Tags.RelationshipRiskLimitAmount);
                        }
                        public QuickFix.Fields.RelationshipRiskLimitCurrency relationshipRiskLimitCurrency
                        { 
                            get 
                            {
                                QuickFix.Fields.RelationshipRiskLimitCurrency val = new QuickFix.Fields.RelationshipRiskLimitCurrency();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            this.relationshipRiskLimitCurrency = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitCurrency Get(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitCurrency val) 
                        { 
                            return IsSetRelationshipRiskLimitCurrency();
                        }
                        
                        public bool IsSetRelationshipRiskLimitCurrency() 
                        { 
                            return IsSetField(Tags.RelationshipRiskLimitCurrency);
                        }
                        public QuickFix.Fields.RelationshipRiskLimitPlatform relationshipRiskLimitPlatform
                        { 
                            get 
                            {
                                QuickFix.Fields.RelationshipRiskLimitPlatform val = new QuickFix.Fields.RelationshipRiskLimitPlatform();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            this.relationshipRiskLimitPlatform = val;
                        }
                        
                        public QuickFix.Fields.RelationshipRiskLimitPlatform Get(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.RelationshipRiskLimitPlatform val) 
                        { 
                            return IsSetRelationshipRiskLimitPlatform();
                        }
                        
                        public bool IsSetRelationshipRiskLimitPlatform() 
                        { 
                            return IsSetField(Tags.RelationshipRiskLimitPlatform);
                        }
                        public QuickFix.Fields.NoRelationshipRiskInstruments noRelationshipRiskInstruments
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRelationshipRiskInstruments val = new QuickFix.Fields.NoRelationshipRiskInstruments();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            this.noRelationshipRiskInstruments = val;
                        }
                        
                        public QuickFix.Fields.NoRelationshipRiskInstruments Get(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRelationshipRiskInstruments val) 
                        { 
                            return IsSetNoRelationshipRiskInstruments();
                        }
                        
                        public bool IsSetNoRelationshipRiskInstruments() 
                        { 
                            return IsSetField(Tags.NoRelationshipRiskInstruments);
                        }
                        public QuickFix.Fields.NoRelationshipRiskWarningLevels noRelationshipRiskWarningLevels
                        { 
                            get 
                            {
                                QuickFix.Fields.NoRelationshipRiskWarningLevels val = new QuickFix.Fields.NoRelationshipRiskWarningLevels();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            this.noRelationshipRiskWarningLevels = val;
                        }
                        
                        public QuickFix.Fields.NoRelationshipRiskWarningLevels Get(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoRelationshipRiskWarningLevels val) 
                        { 
                            return IsSetNoRelationshipRiskWarningLevels();
                        }
                        
                        public bool IsSetNoRelationshipRiskWarningLevels() 
                        { 
                            return IsSetField(Tags.NoRelationshipRiskWarningLevels);
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
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                this.relationshipRiskInstrumentOperator = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentOperator Get(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentOperator val) 
                            { 
                                return IsSetRelationshipRiskInstrumentOperator();
                            }
                            
                            public bool IsSetRelationshipRiskInstrumentOperator() 
                            { 
                                return IsSetField(Tags.RelationshipRiskInstrumentOperator);
                            }
                            public QuickFix.Fields.RelationshipRiskSymbol relationshipRiskSymbol
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSymbol val = new QuickFix.Fields.RelationshipRiskSymbol();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                this.relationshipRiskSymbol = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSymbol Get(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSymbol val) 
                            { 
                                return IsSetRelationshipRiskSymbol();
                            }
                            
                            public bool IsSetRelationshipRiskSymbol() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSymbol);
                            }
                            public QuickFix.Fields.RelationshipRiskSymbolSfx relationshipRiskSymbolSfx
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSymbolSfx val = new QuickFix.Fields.RelationshipRiskSymbolSfx();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                this.relationshipRiskSymbolSfx = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSymbolSfx Get(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSymbolSfx val) 
                            { 
                                return IsSetRelationshipRiskSymbolSfx();
                            }
                            
                            public bool IsSetRelationshipRiskSymbolSfx() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSymbolSfx);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityID relationshipRiskSecurityID
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityID val = new QuickFix.Fields.RelationshipRiskSecurityID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                this.relationshipRiskSecurityID = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityID Get(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityID val) 
                            { 
                                return IsSetRelationshipRiskSecurityID();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityID() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSecurityID);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityIDSource relationshipRiskSecurityIDSource
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityIDSource val = new QuickFix.Fields.RelationshipRiskSecurityIDSource();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                this.relationshipRiskSecurityIDSource = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityIDSource Get(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityIDSource val) 
                            { 
                                return IsSetRelationshipRiskSecurityIDSource();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityIDSource() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSecurityIDSource);
                            }
                            public QuickFix.Fields.NoRelationshipRiskSecurityAltID noRelationshipRiskSecurityAltID
                            { 
                                get 
                                {
                                    QuickFix.Fields.NoRelationshipRiskSecurityAltID val = new QuickFix.Fields.NoRelationshipRiskSecurityAltID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                this.noRelationshipRiskSecurityAltID = val;
                            }
                            
                            public QuickFix.Fields.NoRelationshipRiskSecurityAltID Get(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.NoRelationshipRiskSecurityAltID val) 
                            { 
                                return IsSetNoRelationshipRiskSecurityAltID();
                            }
                            
                            public bool IsSetNoRelationshipRiskSecurityAltID() 
                            { 
                                return IsSetField(Tags.NoRelationshipRiskSecurityAltID);
                            }
                            public QuickFix.Fields.RelationshipRiskProduct relationshipRiskProduct
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskProduct val = new QuickFix.Fields.RelationshipRiskProduct();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                this.relationshipRiskProduct = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskProduct Get(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskProduct val) 
                            { 
                                return IsSetRelationshipRiskProduct();
                            }
                            
                            public bool IsSetRelationshipRiskProduct() 
                            { 
                                return IsSetField(Tags.RelationshipRiskProduct);
                            }
                            public QuickFix.Fields.RelationshipRiskProductComplex relationshipRiskProductComplex
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskProductComplex val = new QuickFix.Fields.RelationshipRiskProductComplex();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                this.relationshipRiskProductComplex = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskProductComplex Get(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskProductComplex val) 
                            { 
                                return IsSetRelationshipRiskProductComplex();
                            }
                            
                            public bool IsSetRelationshipRiskProductComplex() 
                            { 
                                return IsSetField(Tags.RelationshipRiskProductComplex);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityGroup relationshipRiskSecurityGroup
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityGroup val = new QuickFix.Fields.RelationshipRiskSecurityGroup();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                this.relationshipRiskSecurityGroup = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityGroup Get(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityGroup val) 
                            { 
                                return IsSetRelationshipRiskSecurityGroup();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityGroup() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSecurityGroup);
                            }
                            public QuickFix.Fields.RelationshipRiskCFICode relationshipRiskCFICode
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskCFICode val = new QuickFix.Fields.RelationshipRiskCFICode();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                this.relationshipRiskCFICode = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskCFICode Get(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskCFICode val) 
                            { 
                                return IsSetRelationshipRiskCFICode();
                            }
                            
                            public bool IsSetRelationshipRiskCFICode() 
                            { 
                                return IsSetField(Tags.RelationshipRiskCFICode);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityType relationshipRiskSecurityType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityType val = new QuickFix.Fields.RelationshipRiskSecurityType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                this.relationshipRiskSecurityType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityType Get(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityType val) 
                            { 
                                return IsSetRelationshipRiskSecurityType();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityType() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSecurityType);
                            }
                            public QuickFix.Fields.RelationshipRiskSecuritySubType relationshipRiskSecuritySubType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecuritySubType val = new QuickFix.Fields.RelationshipRiskSecuritySubType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                this.relationshipRiskSecuritySubType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecuritySubType Get(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecuritySubType val) 
                            { 
                                return IsSetRelationshipRiskSecuritySubType();
                            }
                            
                            public bool IsSetRelationshipRiskSecuritySubType() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSecuritySubType);
                            }
                            public QuickFix.Fields.RelationshipRiskMaturityMonthYear relationshipRiskMaturityMonthYear
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskMaturityMonthYear val = new QuickFix.Fields.RelationshipRiskMaturityMonthYear();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                this.relationshipRiskMaturityMonthYear = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskMaturityMonthYear Get(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskMaturityMonthYear val) 
                            { 
                                return IsSetRelationshipRiskMaturityMonthYear();
                            }
                            
                            public bool IsSetRelationshipRiskMaturityMonthYear() 
                            { 
                                return IsSetField(Tags.RelationshipRiskMaturityMonthYear);
                            }
                            public QuickFix.Fields.RelationshipRiskMaturityTime relationshipRiskMaturityTime
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskMaturityTime val = new QuickFix.Fields.RelationshipRiskMaturityTime();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                this.relationshipRiskMaturityTime = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskMaturityTime Get(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskMaturityTime val) 
                            { 
                                return IsSetRelationshipRiskMaturityTime();
                            }
                            
                            public bool IsSetRelationshipRiskMaturityTime() 
                            { 
                                return IsSetField(Tags.RelationshipRiskMaturityTime);
                            }
                            public QuickFix.Fields.RelationshipRiskRestructuringType relationshipRiskRestructuringType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskRestructuringType val = new QuickFix.Fields.RelationshipRiskRestructuringType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                this.relationshipRiskRestructuringType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskRestructuringType Get(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskRestructuringType val) 
                            { 
                                return IsSetRelationshipRiskRestructuringType();
                            }
                            
                            public bool IsSetRelationshipRiskRestructuringType() 
                            { 
                                return IsSetField(Tags.RelationshipRiskRestructuringType);
                            }
                            public QuickFix.Fields.RelationshipRiskSeniority relationshipRiskSeniority
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSeniority val = new QuickFix.Fields.RelationshipRiskSeniority();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                this.relationshipRiskSeniority = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSeniority Get(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSeniority val) 
                            { 
                                return IsSetRelationshipRiskSeniority();
                            }
                            
                            public bool IsSetRelationshipRiskSeniority() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSeniority);
                            }
                            public QuickFix.Fields.RelationshipRiskPutOrCall relationshipRiskPutOrCall
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskPutOrCall val = new QuickFix.Fields.RelationshipRiskPutOrCall();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                this.relationshipRiskPutOrCall = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskPutOrCall Get(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskPutOrCall val) 
                            { 
                                return IsSetRelationshipRiskPutOrCall();
                            }
                            
                            public bool IsSetRelationshipRiskPutOrCall() 
                            { 
                                return IsSetField(Tags.RelationshipRiskPutOrCall);
                            }
                            public QuickFix.Fields.RelationshipRiskFlexibleIndicator relationshipRiskFlexibleIndicator
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskFlexibleIndicator val = new QuickFix.Fields.RelationshipRiskFlexibleIndicator();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                this.relationshipRiskFlexibleIndicator = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskFlexibleIndicator Get(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskFlexibleIndicator val) 
                            { 
                                return IsSetRelationshipRiskFlexibleIndicator();
                            }
                            
                            public bool IsSetRelationshipRiskFlexibleIndicator() 
                            { 
                                return IsSetField(Tags.RelationshipRiskFlexibleIndicator);
                            }
                            public QuickFix.Fields.RelationshipRiskCouponRate relationshipRiskCouponRate
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskCouponRate val = new QuickFix.Fields.RelationshipRiskCouponRate();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                this.relationshipRiskCouponRate = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskCouponRate Get(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskCouponRate val) 
                            { 
                                return IsSetRelationshipRiskCouponRate();
                            }
                            
                            public bool IsSetRelationshipRiskCouponRate() 
                            { 
                                return IsSetField(Tags.RelationshipRiskCouponRate);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityExchange relationshipRiskSecurityExchange
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityExchange val = new QuickFix.Fields.RelationshipRiskSecurityExchange();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                this.relationshipRiskSecurityExchange = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityExchange Get(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityExchange val) 
                            { 
                                return IsSetRelationshipRiskSecurityExchange();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityExchange() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSecurityExchange);
                            }
                            public QuickFix.Fields.RelationshipRiskSecurityDesc relationshipRiskSecurityDesc
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskSecurityDesc val = new QuickFix.Fields.RelationshipRiskSecurityDesc();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                this.relationshipRiskSecurityDesc = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskSecurityDesc Get(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityDesc val) 
                            { 
                                return IsSetRelationshipRiskSecurityDesc();
                            }
                            
                            public bool IsSetRelationshipRiskSecurityDesc() 
                            { 
                                return IsSetField(Tags.RelationshipRiskSecurityDesc);
                            }
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen relationshipRiskEncodedSecurityDescLen
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val = new QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                this.relationshipRiskEncodedSecurityDescLen = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen Get(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskEncodedSecurityDescLen val) 
                            { 
                                return IsSetRelationshipRiskEncodedSecurityDescLen();
                            }
                            
                            public bool IsSetRelationshipRiskEncodedSecurityDescLen() 
                            { 
                                return IsSetField(Tags.RelationshipRiskEncodedSecurityDescLen);
                            }
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDesc relationshipRiskEncodedSecurityDesc
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val = new QuickFix.Fields.RelationshipRiskEncodedSecurityDesc();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                this.relationshipRiskEncodedSecurityDesc = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskEncodedSecurityDesc Get(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskEncodedSecurityDesc val) 
                            { 
                                return IsSetRelationshipRiskEncodedSecurityDesc();
                            }
                            
                            public bool IsSetRelationshipRiskEncodedSecurityDesc() 
                            { 
                                return IsSetField(Tags.RelationshipRiskEncodedSecurityDesc);
                            }
                            public QuickFix.Fields.RelationshipRiskInstrumentSettlType relationshipRiskInstrumentSettlType
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskInstrumentSettlType val = new QuickFix.Fields.RelationshipRiskInstrumentSettlType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                this.relationshipRiskInstrumentSettlType = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentSettlType Get(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentSettlType val) 
                            { 
                                return IsSetRelationshipRiskInstrumentSettlType();
                            }
                            
                            public bool IsSetRelationshipRiskInstrumentSettlType() 
                            { 
                                return IsSetField(Tags.RelationshipRiskInstrumentSettlType);
                            }
                            public QuickFix.Fields.RelationshipRiskInstrumentMultiplier relationshipRiskInstrumentMultiplier
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskInstrumentMultiplier val = new QuickFix.Fields.RelationshipRiskInstrumentMultiplier();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                this.relationshipRiskInstrumentMultiplier = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskInstrumentMultiplier Get(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskInstrumentMultiplier val) 
                            { 
                                return IsSetRelationshipRiskInstrumentMultiplier();
                            }
                            
                            public bool IsSetRelationshipRiskInstrumentMultiplier() 
                            { 
                                return IsSetField(Tags.RelationshipRiskInstrumentMultiplier);
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
                                        GetField(val);
                                        return val;
                                    }
                                    set { SetField(value); }
                                }
                                
                                public void Set(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    this.relationshipRiskSecurityAltID = val;
                                }
                                
                                public QuickFix.Fields.RelationshipRiskSecurityAltID Get(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    GetField(val);
                                    return val;
                                }
                                
                                public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityAltID val) 
                                { 
                                    return IsSetRelationshipRiskSecurityAltID();
                                }
                                
                                public bool IsSetRelationshipRiskSecurityAltID() 
                                { 
                                    return IsSetField(Tags.RelationshipRiskSecurityAltID);
                                }
                                public QuickFix.Fields.RelationshipRiskSecurityAltIDSource relationshipRiskSecurityAltIDSource
                                { 
                                    get 
                                    {
                                        QuickFix.Fields.RelationshipRiskSecurityAltIDSource val = new QuickFix.Fields.RelationshipRiskSecurityAltIDSource();
                                        GetField(val);
                                        return val;
                                    }
                                    set { SetField(value); }
                                }
                                
                                public void Set(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    this.relationshipRiskSecurityAltIDSource = val;
                                }
                                
                                public QuickFix.Fields.RelationshipRiskSecurityAltIDSource Get(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    GetField(val);
                                    return val;
                                }
                                
                                public bool IsSet(QuickFix.Fields.RelationshipRiskSecurityAltIDSource val) 
                                { 
                                    return IsSetRelationshipRiskSecurityAltIDSource();
                                }
                                
                                public bool IsSetRelationshipRiskSecurityAltIDSource() 
                                { 
                                    return IsSetField(Tags.RelationshipRiskSecurityAltIDSource);
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
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                this.relationshipRiskWarningLevelPercent = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskWarningLevelPercent Get(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskWarningLevelPercent val) 
                            { 
                                return IsSetRelationshipRiskWarningLevelPercent();
                            }
                            
                            public bool IsSetRelationshipRiskWarningLevelPercent() 
                            { 
                                return IsSetField(Tags.RelationshipRiskWarningLevelPercent);
                            }
                            public QuickFix.Fields.RelationshipRiskWarningLevelName relationshipRiskWarningLevelName
                            { 
                                get 
                                {
                                    QuickFix.Fields.RelationshipRiskWarningLevelName val = new QuickFix.Fields.RelationshipRiskWarningLevelName();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                this.relationshipRiskWarningLevelName = val;
                            }
                            
                            public QuickFix.Fields.RelationshipRiskWarningLevelName Get(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.RelationshipRiskWarningLevelName val) 
                            { 
                                return IsSetRelationshipRiskWarningLevelName();
                            }
                            
                            public bool IsSetRelationshipRiskWarningLevelName() 
                            { 
                                return IsSetField(Tags.RelationshipRiskWarningLevelName);
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.PartyRelationship val) 
                        { 
                            this.partyRelationship = val;
                        }
                        
                        public QuickFix.Fields.PartyRelationship Get(QuickFix.Fields.PartyRelationship val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.PartyRelationship val) 
                        { 
                            return IsSetPartyRelationship();
                        }
                        
                        public bool IsSetPartyRelationship() 
                        { 
                            return IsSetField(Tags.PartyRelationship);
                        }
                    
                    }
                }
            }
        }
    }
}
