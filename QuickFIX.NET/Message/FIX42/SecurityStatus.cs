using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class SecurityStatus : Message
        {
            public SecurityStatus() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("f"));
            }

            public SecurityStatus(
                    QuickFix.Fields.Symbol aSymbol
                ) : this()
            {
                this.symbol = aSymbol;
            }

            public QuickFix.Fields.SecurityStatusReqID securityStatusReqID
            { 
                get 
                {
                    QuickFix.Fields.SecurityStatusReqID val = new QuickFix.Fields.SecurityStatusReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityStatusReqID val) 
            { 
                this.securityStatusReqID = val;
            }
            
            public QuickFix.Fields.SecurityStatusReqID get(QuickFix.Fields.SecurityStatusReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityStatusReqID val) 
            { 
                return isSetSecurityStatusReqID();
            }
            
            public bool isSetSecurityStatusReqID() 
            { 
                return isSetField(Tags.SecurityStatusReqID);
            }
            public QuickFix.Fields.Symbol symbol
            { 
                get 
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Symbol val) 
            { 
                this.symbol = val;
            }
            
            public QuickFix.Fields.Symbol get(QuickFix.Fields.Symbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Symbol val) 
            { 
                return isSetSymbol();
            }
            
            public bool isSetSymbol() 
            { 
                return isSetField(Tags.Symbol);
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
            public QuickFix.Fields.Currency currency
            { 
                get 
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Currency val) 
            { 
                this.currency = val;
            }
            
            public QuickFix.Fields.Currency get(QuickFix.Fields.Currency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Currency val) 
            { 
                return isSetCurrency();
            }
            
            public bool isSetCurrency() 
            { 
                return isSetField(Tags.Currency);
            }
            public QuickFix.Fields.TradingSessionID tradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionID val) 
            { 
                this.tradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID get(QuickFix.Fields.TradingSessionID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return isSetTradingSessionID();
            }
            
            public bool isSetTradingSessionID() 
            { 
                return isSetField(Tags.TradingSessionID);
            }
            public QuickFix.Fields.UnsolicitedIndicator unsolicitedIndicator
            { 
                get 
                {
                    QuickFix.Fields.UnsolicitedIndicator val = new QuickFix.Fields.UnsolicitedIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                this.unsolicitedIndicator = val;
            }
            
            public QuickFix.Fields.UnsolicitedIndicator get(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnsolicitedIndicator val) 
            { 
                return isSetUnsolicitedIndicator();
            }
            
            public bool isSetUnsolicitedIndicator() 
            { 
                return isSetField(Tags.UnsolicitedIndicator);
            }
            public QuickFix.Fields.SecurityTradingStatus securityTradingStatus
            { 
                get 
                {
                    QuickFix.Fields.SecurityTradingStatus val = new QuickFix.Fields.SecurityTradingStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityTradingStatus val) 
            { 
                this.securityTradingStatus = val;
            }
            
            public QuickFix.Fields.SecurityTradingStatus get(QuickFix.Fields.SecurityTradingStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityTradingStatus val) 
            { 
                return isSetSecurityTradingStatus();
            }
            
            public bool isSetSecurityTradingStatus() 
            { 
                return isSetField(Tags.SecurityTradingStatus);
            }
            public QuickFix.Fields.FinancialStatus financialStatus
            { 
                get 
                {
                    QuickFix.Fields.FinancialStatus val = new QuickFix.Fields.FinancialStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.FinancialStatus val) 
            { 
                this.financialStatus = val;
            }
            
            public QuickFix.Fields.FinancialStatus get(QuickFix.Fields.FinancialStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.FinancialStatus val) 
            { 
                return isSetFinancialStatus();
            }
            
            public bool isSetFinancialStatus() 
            { 
                return isSetField(Tags.FinancialStatus);
            }
            public QuickFix.Fields.CorporateAction corporateAction
            { 
                get 
                {
                    QuickFix.Fields.CorporateAction val = new QuickFix.Fields.CorporateAction();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.CorporateAction val) 
            { 
                this.corporateAction = val;
            }
            
            public QuickFix.Fields.CorporateAction get(QuickFix.Fields.CorporateAction val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.CorporateAction val) 
            { 
                return isSetCorporateAction();
            }
            
            public bool isSetCorporateAction() 
            { 
                return isSetField(Tags.CorporateAction);
            }
            public QuickFix.Fields.HaltReason haltReason
            { 
                get 
                {
                    QuickFix.Fields.HaltReason val = new QuickFix.Fields.HaltReason();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.HaltReason val) 
            { 
                this.haltReason = val;
            }
            
            public QuickFix.Fields.HaltReason get(QuickFix.Fields.HaltReason val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.HaltReason val) 
            { 
                return isSetHaltReason();
            }
            
            public bool isSetHaltReason() 
            { 
                return isSetField(Tags.HaltReason);
            }
            public QuickFix.Fields.InViewOfCommon inViewOfCommon
            { 
                get 
                {
                    QuickFix.Fields.InViewOfCommon val = new QuickFix.Fields.InViewOfCommon();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.InViewOfCommon val) 
            { 
                this.inViewOfCommon = val;
            }
            
            public QuickFix.Fields.InViewOfCommon get(QuickFix.Fields.InViewOfCommon val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.InViewOfCommon val) 
            { 
                return isSetInViewOfCommon();
            }
            
            public bool isSetInViewOfCommon() 
            { 
                return isSetField(Tags.InViewOfCommon);
            }
            public QuickFix.Fields.DueToRelated dueToRelated
            { 
                get 
                {
                    QuickFix.Fields.DueToRelated val = new QuickFix.Fields.DueToRelated();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DueToRelated val) 
            { 
                this.dueToRelated = val;
            }
            
            public QuickFix.Fields.DueToRelated get(QuickFix.Fields.DueToRelated val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DueToRelated val) 
            { 
                return isSetDueToRelated();
            }
            
            public bool isSetDueToRelated() 
            { 
                return isSetField(Tags.DueToRelated);
            }
            public QuickFix.Fields.BuyVolume buyVolume
            { 
                get 
                {
                    QuickFix.Fields.BuyVolume val = new QuickFix.Fields.BuyVolume();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.BuyVolume val) 
            { 
                this.buyVolume = val;
            }
            
            public QuickFix.Fields.BuyVolume get(QuickFix.Fields.BuyVolume val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.BuyVolume val) 
            { 
                return isSetBuyVolume();
            }
            
            public bool isSetBuyVolume() 
            { 
                return isSetField(Tags.BuyVolume);
            }
            public QuickFix.Fields.SellVolume sellVolume
            { 
                get 
                {
                    QuickFix.Fields.SellVolume val = new QuickFix.Fields.SellVolume();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SellVolume val) 
            { 
                this.sellVolume = val;
            }
            
            public QuickFix.Fields.SellVolume get(QuickFix.Fields.SellVolume val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SellVolume val) 
            { 
                return isSetSellVolume();
            }
            
            public bool isSetSellVolume() 
            { 
                return isSetField(Tags.SellVolume);
            }
            public QuickFix.Fields.HighPx highPx
            { 
                get 
                {
                    QuickFix.Fields.HighPx val = new QuickFix.Fields.HighPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.HighPx val) 
            { 
                this.highPx = val;
            }
            
            public QuickFix.Fields.HighPx get(QuickFix.Fields.HighPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.HighPx val) 
            { 
                return isSetHighPx();
            }
            
            public bool isSetHighPx() 
            { 
                return isSetField(Tags.HighPx);
            }
            public QuickFix.Fields.LowPx lowPx
            { 
                get 
                {
                    QuickFix.Fields.LowPx val = new QuickFix.Fields.LowPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LowPx val) 
            { 
                this.lowPx = val;
            }
            
            public QuickFix.Fields.LowPx get(QuickFix.Fields.LowPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LowPx val) 
            { 
                return isSetLowPx();
            }
            
            public bool isSetLowPx() 
            { 
                return isSetField(Tags.LowPx);
            }
            public QuickFix.Fields.LastPx lastPx
            { 
                get 
                {
                    QuickFix.Fields.LastPx val = new QuickFix.Fields.LastPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastPx val) 
            { 
                this.lastPx = val;
            }
            
            public QuickFix.Fields.LastPx get(QuickFix.Fields.LastPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastPx val) 
            { 
                return isSetLastPx();
            }
            
            public bool isSetLastPx() 
            { 
                return isSetField(Tags.LastPx);
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
            public QuickFix.Fields.Adjustment adjustment
            { 
                get 
                {
                    QuickFix.Fields.Adjustment val = new QuickFix.Fields.Adjustment();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Adjustment val) 
            { 
                this.adjustment = val;
            }
            
            public QuickFix.Fields.Adjustment get(QuickFix.Fields.Adjustment val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Adjustment val) 
            { 
                return isSetAdjustment();
            }
            
            public bool isSetAdjustment() 
            { 
                return isSetField(Tags.Adjustment);
            }

        }
    }
}
