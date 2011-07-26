using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class Email : Message
        {
            public Email() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("C"));
            }

            public Email(
                    QuickFix.Fields.EmailThreadID aEmailThreadID,
                    QuickFix.Fields.EmailType aEmailType,
                    QuickFix.Fields.Subject aSubject
                ) : this()
            {
                this.emailThreadID = aEmailThreadID;
                this.emailType = aEmailType;
                this.subject = aSubject;
            }

            public QuickFix.Fields.EmailThreadID emailThreadID
            { 
                get 
                {
                    QuickFix.Fields.EmailThreadID val = new QuickFix.Fields.EmailThreadID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EmailThreadID val) 
            { 
                this.emailThreadID = val;
            }
            
            public QuickFix.Fields.EmailThreadID get(QuickFix.Fields.EmailThreadID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EmailThreadID val) 
            { 
                return isSetEmailThreadID();
            }
            
            public bool isSetEmailThreadID() 
            { 
                return isSetField(Tags.EmailThreadID);
            }
            public QuickFix.Fields.EmailType emailType
            { 
                get 
                {
                    QuickFix.Fields.EmailType val = new QuickFix.Fields.EmailType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EmailType val) 
            { 
                this.emailType = val;
            }
            
            public QuickFix.Fields.EmailType get(QuickFix.Fields.EmailType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EmailType val) 
            { 
                return isSetEmailType();
            }
            
            public bool isSetEmailType() 
            { 
                return isSetField(Tags.EmailType);
            }
            public QuickFix.Fields.OrigTime origTime
            { 
                get 
                {
                    QuickFix.Fields.OrigTime val = new QuickFix.Fields.OrigTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrigTime val) 
            { 
                this.origTime = val;
            }
            
            public QuickFix.Fields.OrigTime get(QuickFix.Fields.OrigTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrigTime val) 
            { 
                return isSetOrigTime();
            }
            
            public bool isSetOrigTime() 
            { 
                return isSetField(Tags.OrigTime);
            }
            public QuickFix.Fields.Subject subject
            { 
                get 
                {
                    QuickFix.Fields.Subject val = new QuickFix.Fields.Subject();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Subject val) 
            { 
                this.subject = val;
            }
            
            public QuickFix.Fields.Subject get(QuickFix.Fields.Subject val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Subject val) 
            { 
                return isSetSubject();
            }
            
            public bool isSetSubject() 
            { 
                return isSetField(Tags.Subject);
            }
            public QuickFix.Fields.EncodedSubjectLen encodedSubjectLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedSubjectLen val = new QuickFix.Fields.EncodedSubjectLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedSubjectLen val) 
            { 
                this.encodedSubjectLen = val;
            }
            
            public QuickFix.Fields.EncodedSubjectLen get(QuickFix.Fields.EncodedSubjectLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedSubjectLen val) 
            { 
                return isSetEncodedSubjectLen();
            }
            
            public bool isSetEncodedSubjectLen() 
            { 
                return isSetField(Tags.EncodedSubjectLen);
            }
            public QuickFix.Fields.EncodedSubject encodedSubject
            { 
                get 
                {
                    QuickFix.Fields.EncodedSubject val = new QuickFix.Fields.EncodedSubject();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedSubject val) 
            { 
                this.encodedSubject = val;
            }
            
            public QuickFix.Fields.EncodedSubject get(QuickFix.Fields.EncodedSubject val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedSubject val) 
            { 
                return isSetEncodedSubject();
            }
            
            public bool isSetEncodedSubject() 
            { 
                return isSetField(Tags.EncodedSubject);
            }
            public QuickFix.Fields.NoRoutingIDs noRoutingIDs
            { 
                get 
                {
                    QuickFix.Fields.NoRoutingIDs val = new QuickFix.Fields.NoRoutingIDs();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRoutingIDs val) 
            { 
                this.noRoutingIDs = val;
            }
            
            public QuickFix.Fields.NoRoutingIDs get(QuickFix.Fields.NoRoutingIDs val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRoutingIDs val) 
            { 
                return isSetNoRoutingIDs();
            }
            
            public bool isSetNoRoutingIDs() 
            { 
                return isSetField(Tags.NoRoutingIDs);
            }
            public QuickFix.Fields.NoRelatedSym noRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.NoRelatedSym val = new QuickFix.Fields.NoRelatedSym();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRelatedSym val) 
            { 
                this.noRelatedSym = val;
            }
            
            public QuickFix.Fields.NoRelatedSym get(QuickFix.Fields.NoRelatedSym val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRelatedSym val) 
            { 
                return isSetNoRelatedSym();
            }
            
            public bool isSetNoRelatedSym() 
            { 
                return isSetField(Tags.NoRelatedSym);
            }
            public QuickFix.Fields.OrderID orderID
            { 
                get 
                {
                    QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.OrderID val) 
            { 
                this.orderID = val;
            }
            
            public QuickFix.Fields.OrderID get(QuickFix.Fields.OrderID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.OrderID val) 
            { 
                return isSetOrderID();
            }
            
            public bool isSetOrderID() 
            { 
                return isSetField(Tags.OrderID);
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
            public QuickFix.Fields.LinesOfText linesOfText
            { 
                get 
                {
                    QuickFix.Fields.LinesOfText val = new QuickFix.Fields.LinesOfText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LinesOfText val) 
            { 
                this.linesOfText = val;
            }
            
            public QuickFix.Fields.LinesOfText get(QuickFix.Fields.LinesOfText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LinesOfText val) 
            { 
                return isSetLinesOfText();
            }
            
            public bool isSetLinesOfText() 
            { 
                return isSetField(Tags.LinesOfText);
            }
            public QuickFix.Fields.RawDataLength rawDataLength
            { 
                get 
                {
                    QuickFix.Fields.RawDataLength val = new QuickFix.Fields.RawDataLength();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RawDataLength val) 
            { 
                this.rawDataLength = val;
            }
            
            public QuickFix.Fields.RawDataLength get(QuickFix.Fields.RawDataLength val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RawDataLength val) 
            { 
                return isSetRawDataLength();
            }
            
            public bool isSetRawDataLength() 
            { 
                return isSetField(Tags.RawDataLength);
            }
            public QuickFix.Fields.RawData rawData
            { 
                get 
                {
                    QuickFix.Fields.RawData val = new QuickFix.Fields.RawData();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.RawData val) 
            { 
                this.rawData = val;
            }
            
            public QuickFix.Fields.RawData get(QuickFix.Fields.RawData val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.RawData val) 
            { 
                return isSetRawData();
            }
            
            public bool isSetRawData() 
            { 
                return isSetField(Tags.RawData);
            }
            public class NoRoutingIDs : Group
            {
                public NoRoutingIDs() 
                  :base( Tags.NoRoutingIDs, Tags.RoutingType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RoutingType, Tags.RoutingID, 0};
                            public QuickFix.Fields.RoutingType routingType
                { 
                    get 
                    {
                        QuickFix.Fields.RoutingType val = new QuickFix.Fields.RoutingType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RoutingType val) 
                { 
                    this.routingType = val;
                }
                
                public QuickFix.Fields.RoutingType get(QuickFix.Fields.RoutingType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RoutingType val) 
                { 
                    return isSetRoutingType();
                }
                
                public bool isSetRoutingType() 
                { 
                    return isSetField(Tags.RoutingType);
                }
                public QuickFix.Fields.RoutingID routingID
                { 
                    get 
                    {
                        QuickFix.Fields.RoutingID val = new QuickFix.Fields.RoutingID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RoutingID val) 
                { 
                    this.routingID = val;
                }
                
                public QuickFix.Fields.RoutingID get(QuickFix.Fields.RoutingID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RoutingID val) 
                { 
                    return isSetRoutingID();
                }
                
                public bool isSetRoutingID() 
                { 
                    return isSetField(Tags.RoutingID);
                }
            
            }
            public class NoRelatedSym : Group
            {
                public NoRelatedSym() 
                  :base( Tags.NoRelatedSym, Tags.RelatdSym, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RelatdSym, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, 0};
                            public QuickFix.Fields.RelatdSym relatdSym
                { 
                    get 
                    {
                        QuickFix.Fields.RelatdSym val = new QuickFix.Fields.RelatdSym();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RelatdSym val) 
                { 
                    this.relatdSym = val;
                }
                
                public QuickFix.Fields.RelatdSym get(QuickFix.Fields.RelatdSym val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RelatdSym val) 
                { 
                    return isSetRelatdSym();
                }
                
                public bool isSetRelatdSym() 
                { 
                    return isSetField(Tags.RelatdSym);
                }
                public QuickFix.Fields.SymbolSfx symbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SymbolSfx val) 
                { 
                    this.symbolSfx = val;
                }
                
                public QuickFix.Fields.SymbolSfx get(QuickFix.Fields.SymbolSfx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SymbolSfx val) 
                { 
                    return isSetSymbolSfx();
                }
                
                public bool isSetSymbolSfx() 
                { 
                    return isSetField(Tags.SymbolSfx);
                }
                public QuickFix.Fields.SecurityID securityID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityID val) 
                { 
                    this.securityID = val;
                }
                
                public QuickFix.Fields.SecurityID get(QuickFix.Fields.SecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityID val) 
                { 
                    return isSetSecurityID();
                }
                
                public bool isSetSecurityID() 
                { 
                    return isSetField(Tags.SecurityID);
                }
                public QuickFix.Fields.IDSource iDSource
                { 
                    get 
                    {
                        QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.IDSource val) 
                { 
                    this.iDSource = val;
                }
                
                public QuickFix.Fields.IDSource get(QuickFix.Fields.IDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.IDSource val) 
                { 
                    return isSetIDSource();
                }
                
                public bool isSetIDSource() 
                { 
                    return isSetField(Tags.IDSource);
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
                public QuickFix.Fields.MaturityMonthYear maturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    this.maturityMonthYear = val;
                }
                
                public QuickFix.Fields.MaturityMonthYear get(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    return isSetMaturityMonthYear();
                }
                
                public bool isSetMaturityMonthYear() 
                { 
                    return isSetField(Tags.MaturityMonthYear);
                }
                public QuickFix.Fields.MaturityDay maturityDay
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityDay val) 
                { 
                    this.maturityDay = val;
                }
                
                public QuickFix.Fields.MaturityDay get(QuickFix.Fields.MaturityDay val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityDay val) 
                { 
                    return isSetMaturityDay();
                }
                
                public bool isSetMaturityDay() 
                { 
                    return isSetField(Tags.MaturityDay);
                }
                public QuickFix.Fields.PutOrCall putOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PutOrCall val) 
                { 
                    this.putOrCall = val;
                }
                
                public QuickFix.Fields.PutOrCall get(QuickFix.Fields.PutOrCall val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PutOrCall val) 
                { 
                    return isSetPutOrCall();
                }
                
                public bool isSetPutOrCall() 
                { 
                    return isSetField(Tags.PutOrCall);
                }
                public QuickFix.Fields.StrikePrice strikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikePrice val) 
                { 
                    this.strikePrice = val;
                }
                
                public QuickFix.Fields.StrikePrice get(QuickFix.Fields.StrikePrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikePrice val) 
                { 
                    return isSetStrikePrice();
                }
                
                public bool isSetStrikePrice() 
                { 
                    return isSetField(Tags.StrikePrice);
                }
                public QuickFix.Fields.OptAttribute optAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OptAttribute val) 
                { 
                    this.optAttribute = val;
                }
                
                public QuickFix.Fields.OptAttribute get(QuickFix.Fields.OptAttribute val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OptAttribute val) 
                { 
                    return isSetOptAttribute();
                }
                
                public bool isSetOptAttribute() 
                { 
                    return isSetField(Tags.OptAttribute);
                }
                public QuickFix.Fields.ContractMultiplier contractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContractMultiplier val) 
                { 
                    this.contractMultiplier = val;
                }
                
                public QuickFix.Fields.ContractMultiplier get(QuickFix.Fields.ContractMultiplier val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContractMultiplier val) 
                { 
                    return isSetContractMultiplier();
                }
                
                public bool isSetContractMultiplier() 
                { 
                    return isSetField(Tags.ContractMultiplier);
                }
                public QuickFix.Fields.CouponRate couponRate
                { 
                    get 
                    {
                        QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CouponRate val) 
                { 
                    this.couponRate = val;
                }
                
                public QuickFix.Fields.CouponRate get(QuickFix.Fields.CouponRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CouponRate val) 
                { 
                    return isSetCouponRate();
                }
                
                public bool isSetCouponRate() 
                { 
                    return isSetField(Tags.CouponRate);
                }
                public QuickFix.Fields.SecurityExchange securityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityExchange val) 
                { 
                    this.securityExchange = val;
                }
                
                public QuickFix.Fields.SecurityExchange get(QuickFix.Fields.SecurityExchange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityExchange val) 
                { 
                    return isSetSecurityExchange();
                }
                
                public bool isSetSecurityExchange() 
                { 
                    return isSetField(Tags.SecurityExchange);
                }
                public QuickFix.Fields.Issuer issuer
                { 
                    get 
                    {
                        QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Issuer val) 
                { 
                    this.issuer = val;
                }
                
                public QuickFix.Fields.Issuer get(QuickFix.Fields.Issuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Issuer val) 
                { 
                    return isSetIssuer();
                }
                
                public bool isSetIssuer() 
                { 
                    return isSetField(Tags.Issuer);
                }
                public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    this.encodedIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedIssuerLen get(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    return isSetEncodedIssuerLen();
                }
                
                public bool isSetEncodedIssuerLen() 
                { 
                    return isSetField(Tags.EncodedIssuerLen);
                }
                public QuickFix.Fields.EncodedIssuer encodedIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedIssuer val) 
                { 
                    this.encodedIssuer = val;
                }
                
                public QuickFix.Fields.EncodedIssuer get(QuickFix.Fields.EncodedIssuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedIssuer val) 
                { 
                    return isSetEncodedIssuer();
                }
                
                public bool isSetEncodedIssuer() 
                { 
                    return isSetField(Tags.EncodedIssuer);
                }
                public QuickFix.Fields.SecurityDesc securityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityDesc val) 
                { 
                    this.securityDesc = val;
                }
                
                public QuickFix.Fields.SecurityDesc get(QuickFix.Fields.SecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityDesc val) 
                { 
                    return isSetSecurityDesc();
                }
                
                public bool isSetSecurityDesc() 
                { 
                    return isSetField(Tags.SecurityDesc);
                }
                public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    this.encodedSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedSecurityDescLen get(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    return isSetEncodedSecurityDescLen();
                }
                
                public bool isSetEncodedSecurityDescLen() 
                { 
                    return isSetField(Tags.EncodedSecurityDescLen);
                }
                public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    this.encodedSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedSecurityDesc get(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    return isSetEncodedSecurityDesc();
                }
                
                public bool isSetEncodedSecurityDesc() 
                { 
                    return isSetField(Tags.EncodedSecurityDesc);
                }
            
            }
            public class LinesOfText : Group
            {
                public LinesOfText() 
                  :base( Tags.LinesOfText, Tags.Text, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};
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
            
            }
        }
    }
}
