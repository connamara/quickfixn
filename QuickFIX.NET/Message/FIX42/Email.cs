// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Email : Message
        {
            public const string MsgType = "C";

            public Email() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("C"));
            }

            public Email(
                    QuickFix.Fields.EmailThreadID aEmailThreadID,
                    QuickFix.Fields.EmailType aEmailType,
                    QuickFix.Fields.Subject aSubject
                ) : this()
            {
                this.EmailThreadID = aEmailThreadID;
                this.EmailType = aEmailType;
                this.Subject = aSubject;
            }

            public QuickFix.Fields.EmailThreadID EmailThreadID
            { 
                get 
                {
                    QuickFix.Fields.EmailThreadID val = new QuickFix.Fields.EmailThreadID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EmailThreadID val) 
            { 
                this.EmailThreadID = val;
            }
            
            public QuickFix.Fields.EmailThreadID Get(QuickFix.Fields.EmailThreadID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EmailThreadID val) 
            { 
                return IsSetEmailThreadID();
            }
            
            public bool IsSetEmailThreadID() 
            { 
                return IsSetField(Tags.EmailThreadID);
            }
            public QuickFix.Fields.EmailType EmailType
            { 
                get 
                {
                    QuickFix.Fields.EmailType val = new QuickFix.Fields.EmailType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EmailType val) 
            { 
                this.EmailType = val;
            }
            
            public QuickFix.Fields.EmailType Get(QuickFix.Fields.EmailType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EmailType val) 
            { 
                return IsSetEmailType();
            }
            
            public bool IsSetEmailType() 
            { 
                return IsSetField(Tags.EmailType);
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
            public QuickFix.Fields.Subject Subject
            { 
                get 
                {
                    QuickFix.Fields.Subject val = new QuickFix.Fields.Subject();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.Subject val) 
            { 
                this.Subject = val;
            }
            
            public QuickFix.Fields.Subject Get(QuickFix.Fields.Subject val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.Subject val) 
            { 
                return IsSetSubject();
            }
            
            public bool IsSetSubject() 
            { 
                return IsSetField(Tags.Subject);
            }
            public QuickFix.Fields.EncodedSubjectLen EncodedSubjectLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSubjectLen val = new QuickFix.Fields.EncodedSubjectLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSubjectLen val) 
            { 
                this.EncodedSubjectLen = val;
            }
            
            public QuickFix.Fields.EncodedSubjectLen Get(QuickFix.Fields.EncodedSubjectLen val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSubjectLen val) 
            { 
                return IsSetEncodedSubjectLen();
            }
            
            public bool IsSetEncodedSubjectLen() 
            { 
                return IsSetField(Tags.EncodedSubjectLen);
            }
            public QuickFix.Fields.EncodedSubject EncodedSubject
            { 
                get 
                {
                    QuickFix.Fields.EncodedSubject val = new QuickFix.Fields.EncodedSubject();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.EncodedSubject val) 
            { 
                this.EncodedSubject = val;
            }
            
            public QuickFix.Fields.EncodedSubject Get(QuickFix.Fields.EncodedSubject val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.EncodedSubject val) 
            { 
                return IsSetEncodedSubject();
            }
            
            public bool IsSetEncodedSubject() 
            { 
                return IsSetField(Tags.EncodedSubject);
            }
            public QuickFix.Fields.NoRoutingIDs NoRoutingIDs
            { 
                get 
                {
                    QuickFix.Fields.NoRoutingIDs val = new QuickFix.Fields.NoRoutingIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRoutingIDs val) 
            { 
                this.NoRoutingIDs = val;
            }
            
            public QuickFix.Fields.NoRoutingIDs Get(QuickFix.Fields.NoRoutingIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRoutingIDs val) 
            { 
                return IsSetNoRoutingIDs();
            }
            
            public bool IsSetNoRoutingIDs() 
            { 
                return IsSetField(Tags.NoRoutingIDs);
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
            public QuickFix.Fields.OrderID OrderID
            { 
                get 
                {
                    QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderID val) 
            { 
                this.OrderID = val;
            }
            
            public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderID val) 
            { 
                return IsSetOrderID();
            }
            
            public bool IsSetOrderID() 
            { 
                return IsSetField(Tags.OrderID);
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
            public QuickFix.Fields.LinesOfText LinesOfText
            { 
                get 
                {
                    QuickFix.Fields.LinesOfText val = new QuickFix.Fields.LinesOfText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LinesOfText val) 
            { 
                this.LinesOfText = val;
            }
            
            public QuickFix.Fields.LinesOfText Get(QuickFix.Fields.LinesOfText val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LinesOfText val) 
            { 
                return IsSetLinesOfText();
            }
            
            public bool IsSetLinesOfText() 
            { 
                return IsSetField(Tags.LinesOfText);
            }
            public QuickFix.Fields.RawDataLength RawDataLength
            { 
                get 
                {
                    QuickFix.Fields.RawDataLength val = new QuickFix.Fields.RawDataLength();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawDataLength val) 
            { 
                this.RawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength Get(QuickFix.Fields.RawDataLength val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawDataLength val) 
            { 
                return IsSetRawDataLength();
            }
            
            public bool IsSetRawDataLength() 
            { 
                return IsSetField(Tags.RawDataLength);
            }
            public QuickFix.Fields.RawData RawData
            { 
                get 
                {
                    QuickFix.Fields.RawData val = new QuickFix.Fields.RawData();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RawData val) 
            { 
                this.RawData = val;
            }
            
            public QuickFix.Fields.RawData Get(QuickFix.Fields.RawData val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RawData val) 
            { 
                return IsSetRawData();
            }
            
            public bool IsSetRawData() 
            { 
                return IsSetField(Tags.RawData);
            }
            public class NoRoutingIDsGroup : Group
            {
                public static int[] fieldOrder = {Tags.RoutingType, Tags.RoutingID, 0};
            
                public NoRoutingIDsGroup() 
                  :base( Tags.NoRoutingIDs, Tags.RoutingType, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRoutingIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RoutingType RoutingType
                { 
                    get 
                    {
                        QuickFix.Fields.RoutingType val = new QuickFix.Fields.RoutingType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoutingType val) 
                { 
                    this.RoutingType = val;
                }
                
                public QuickFix.Fields.RoutingType Get(QuickFix.Fields.RoutingType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoutingType val) 
                { 
                    return IsSetRoutingType();
                }
                
                public bool IsSetRoutingType() 
                { 
                    return IsSetField(Tags.RoutingType);
                }
                public QuickFix.Fields.RoutingID RoutingID
                { 
                    get 
                    {
                        QuickFix.Fields.RoutingID val = new QuickFix.Fields.RoutingID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoutingID val) 
                { 
                    this.RoutingID = val;
                }
                
                public QuickFix.Fields.RoutingID Get(QuickFix.Fields.RoutingID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoutingID val) 
                { 
                    return IsSetRoutingID();
                }
                
                public bool IsSetRoutingID() 
                { 
                    return IsSetField(Tags.RoutingID);
                }
            
            }
            public class NoRelatedSymGroup : Group
            {
                public static int[] fieldOrder = {Tags.RelatdSym, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, 0};
            
                public NoRelatedSymGroup() 
                  :base( Tags.NoRelatedSym, Tags.RelatdSym, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoRelatedSymGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.RelatdSym RelatdSym
                { 
                    get 
                    {
                        QuickFix.Fields.RelatdSym val = new QuickFix.Fields.RelatdSym();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RelatdSym val) 
                { 
                    this.RelatdSym = val;
                }
                
                public QuickFix.Fields.RelatdSym Get(QuickFix.Fields.RelatdSym val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RelatdSym val) 
                { 
                    return IsSetRelatdSym();
                }
                
                public bool IsSetRelatdSym() 
                { 
                    return IsSetField(Tags.RelatdSym);
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
                public QuickFix.Fields.IDSource IDSource
                { 
                    get 
                    {
                        QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IDSource val) 
                { 
                    this.IDSource = val;
                }
                
                public QuickFix.Fields.IDSource Get(QuickFix.Fields.IDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IDSource val) 
                { 
                    return IsSetIDSource();
                }
                
                public bool IsSetIDSource() 
                { 
                    return IsSetField(Tags.IDSource);
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
                public QuickFix.Fields.MaturityDay MaturityDay
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaturityDay val) 
                { 
                    this.MaturityDay = val;
                }
                
                public QuickFix.Fields.MaturityDay Get(QuickFix.Fields.MaturityDay val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaturityDay val) 
                { 
                    return IsSetMaturityDay();
                }
                
                public bool IsSetMaturityDay() 
                { 
                    return IsSetField(Tags.MaturityDay);
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
            
            }
            public class LinesOfTextGroup : Group
            {
                public static int[] fieldOrder = {Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};
            
                public LinesOfTextGroup() 
                  :base( Tags.LinesOfText, Tags.Text, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new LinesOfTextGroup();
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
                public QuickFix.Fields.EncodedTextLen EncodedTextLen
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
                    this.EncodedTextLen = val;
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
                public QuickFix.Fields.EncodedText EncodedText
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
                    this.EncodedText = val;
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
            
            }
        }
    }
}
