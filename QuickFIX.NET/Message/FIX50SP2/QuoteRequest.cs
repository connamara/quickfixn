// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2 
    {
        public class QuoteRequest : Message
        {
            public const string MsgType = "R";

            public QuoteRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("R"));
            }

            public QuoteRequest(
                    QuickFix.Fields.QuoteReqID aQuoteReqID
                ) : this()
            {
                this.quoteReqID = aQuoteReqID;
            }

            public QuickFix.Fields.QuoteReqID quoteReqID
            { 
                get 
                {
                    QuickFix.Fields.QuoteReqID val = new QuickFix.Fields.QuoteReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.QuoteReqID val) 
            { 
                this.quoteReqID = val;
            }
            
            public QuickFix.Fields.QuoteReqID Get(QuickFix.Fields.QuoteReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.QuoteReqID val) 
            { 
                return IsSetQuoteReqID();
            }
            
            public bool IsSetQuoteReqID() 
            { 
                return IsSetField(Tags.QuoteReqID);
            }
            public QuickFix.Fields.RFQReqID rFQReqID
            { 
                get 
                {
                    QuickFix.Fields.RFQReqID val = new QuickFix.Fields.RFQReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RFQReqID val) 
            { 
                this.rFQReqID = val;
            }
            
            public QuickFix.Fields.RFQReqID Get(QuickFix.Fields.RFQReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RFQReqID val) 
            { 
                return IsSetRFQReqID();
            }
            
            public bool IsSetRFQReqID() 
            { 
                return IsSetField(Tags.RFQReqID);
            }
            public QuickFix.Fields.ClOrdID clOrdID
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
                this.clOrdID = val;
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
            public QuickFix.Fields.OrderCapacity orderCapacity
            { 
                get 
                {
                    QuickFix.Fields.OrderCapacity val = new QuickFix.Fields.OrderCapacity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderCapacity val) 
            { 
                this.orderCapacity = val;
            }
            
            public QuickFix.Fields.OrderCapacity Get(QuickFix.Fields.OrderCapacity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderCapacity val) 
            { 
                return IsSetOrderCapacity();
            }
            
            public bool IsSetOrderCapacity() 
            { 
                return IsSetField(Tags.OrderCapacity);
            }
            public QuickFix.Fields.NoRelatedSym noRelatedSym
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
                this.noRelatedSym = val;
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
            public QuickFix.Fields.NoRootPartyIDs noRootPartyIDs
            { 
                get 
                {
                    QuickFix.Fields.NoRootPartyIDs val = new QuickFix.Fields.NoRootPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                this.noRootPartyIDs = val;
            }
            
            public QuickFix.Fields.NoRootPartyIDs Get(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoRootPartyIDs val) 
            { 
                return IsSetNoRootPartyIDs();
            }
            
            public bool IsSetNoRootPartyIDs() 
            { 
                return IsSetField(Tags.NoRootPartyIDs);
            }
            public QuickFix.Fields.PrivateQuote privateQuote
            { 
                get 
                {
                    QuickFix.Fields.PrivateQuote val = new QuickFix.Fields.PrivateQuote();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PrivateQuote val) 
            { 
                this.privateQuote = val;
            }
            
            public QuickFix.Fields.PrivateQuote Get(QuickFix.Fields.PrivateQuote val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PrivateQuote val) 
            { 
                return IsSetPrivateQuote();
            }
            
            public bool IsSetPrivateQuote() 
            { 
                return IsSetField(Tags.PrivateQuote);
            }
            public QuickFix.Fields.RespondentType respondentType
            { 
                get 
                {
                    QuickFix.Fields.RespondentType val = new QuickFix.Fields.RespondentType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.RespondentType val) 
            { 
                this.respondentType = val;
            }
            
            public QuickFix.Fields.RespondentType Get(QuickFix.Fields.RespondentType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.RespondentType val) 
            { 
                return IsSetRespondentType();
            }
            
            public bool IsSetRespondentType() 
            { 
                return IsSetField(Tags.RespondentType);
            }
            public QuickFix.Fields.PreTradeAnonymity preTradeAnonymity
            { 
                get 
                {
                    QuickFix.Fields.PreTradeAnonymity val = new QuickFix.Fields.PreTradeAnonymity();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.PreTradeAnonymity val) 
            { 
                this.preTradeAnonymity = val;
            }
            
            public QuickFix.Fields.PreTradeAnonymity Get(QuickFix.Fields.PreTradeAnonymity val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.PreTradeAnonymity val) 
            { 
                return IsSetPreTradeAnonymity();
            }
            
            public bool IsSetPreTradeAnonymity() 
            { 
                return IsSetField(Tags.PreTradeAnonymity);
            }
            public QuickFix.Fields.BookingType bookingType
            { 
                get 
                {
                    QuickFix.Fields.BookingType val = new QuickFix.Fields.BookingType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.BookingType val) 
            { 
                this.bookingType = val;
            }
            
            public QuickFix.Fields.BookingType Get(QuickFix.Fields.BookingType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.BookingType val) 
            { 
                return IsSetBookingType();
            }
            
            public bool IsSetBookingType() 
            { 
                return IsSetField(Tags.BookingType);
            }
            public QuickFix.Fields.OrderRestrictions orderRestrictions
            { 
                get 
                {
                    QuickFix.Fields.OrderRestrictions val = new QuickFix.Fields.OrderRestrictions();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.OrderRestrictions val) 
            { 
                this.orderRestrictions = val;
            }
            
            public QuickFix.Fields.OrderRestrictions Get(QuickFix.Fields.OrderRestrictions val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.OrderRestrictions val) 
            { 
                return IsSetOrderRestrictions();
            }
            
            public bool IsSetOrderRestrictions() 
            { 
                return IsSetField(Tags.OrderRestrictions);
            }
            public class NoRelatedSym : Group
            {
                public NoRelatedSym() 
                  :base( Tags.NoRelatedSym, Tags.Symbol, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayoutAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.ValuationMethod, Tags.ContractMultiplierUnit, Tags.FlowScheduleType, Tags.RestructuringType, Tags.Seniority, Tags.NotionalPercentageOutstanding, Tags.OriginalNotionalPercentageOutstanding, Tags.AttachmentPoint, Tags.DetachmentPoint, Tags.StrikePriceDeterminationMethod, Tags.StrikePriceBoundaryMethod, Tags.StrikePriceBoundaryPrecision, Tags.UnderlyingPriceDeterminationMethod, Tags.OptPayoutType, Tags.NoComplexEvents, Tags.AgreementDesc, Tags.AgreementID, Tags.AgreementDate, Tags.AgreementCurrency, Tags.TerminationType, Tags.StartDate, Tags.EndDate, Tags.DeliveryType, Tags.MarginRatio, Tags.NoUnderlyings, Tags.PrevClosePx, Tags.QuoteRequestType, Tags.QuoteType, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.TradeOriginationDate, Tags.Side, Tags.QtyType, Tags.OrderQty, Tags.CashOrderQty, Tags.OrderPercent, Tags.RoundingDirection, Tags.RoundingModulus, Tags.SettlType, Tags.SettlDate, Tags.SettlDate2, Tags.OrderQty2, Tags.Currency, Tags.NoStipulations, Tags.Account, Tags.AcctIDSource, Tags.AccountType, Tags.NoLegs, Tags.NoQuoteQualifiers, Tags.QuotePriceType, Tags.OrdType, Tags.ValidUntilTime, Tags.ExpireTime, Tags.TransactTime, Tags.Spread, Tags.BenchmarkCurveCurrency, Tags.BenchmarkCurveName, Tags.BenchmarkCurvePoint, Tags.BenchmarkPrice, Tags.BenchmarkPriceType, Tags.BenchmarkSecurityID, Tags.BenchmarkSecurityIDSource, Tags.PriceType, Tags.Price, Tags.Price2, Tags.YieldType, Tags.Yield, Tags.YieldCalcDate, Tags.YieldRedemptionDate, Tags.YieldRedemptionPrice, Tags.YieldRedemptionPriceType, Tags.NoPartyIDs, Tags.MinQty, Tags.SettlCurrency, Tags.NoRateSources, 0};
                            public QuickFix.Fields.Symbol symbol
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
                    this.symbol = val;
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
                public QuickFix.Fields.SymbolSfx symbolSfx
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
                    this.symbolSfx = val;
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
                public QuickFix.Fields.SecurityID securityID
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
                    this.securityID = val;
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
                public QuickFix.Fields.SecurityIDSource securityIDSource
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
                    this.securityIDSource = val;
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
                public QuickFix.Fields.NoSecurityAltID noSecurityAltID
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
                    this.noSecurityAltID = val;
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
                public QuickFix.Fields.Product product
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
                    this.product = val;
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
                public QuickFix.Fields.CFICode cFICode
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
                    this.cFICode = val;
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
                public QuickFix.Fields.SecurityType securityType
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
                    this.securityType = val;
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
                public QuickFix.Fields.SecuritySubType securitySubType
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
                    this.securitySubType = val;
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
                public QuickFix.Fields.MaturityMonthYear maturityMonthYear
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
                    this.maturityMonthYear = val;
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
                public QuickFix.Fields.MaturityDate maturityDate
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
                    this.maturityDate = val;
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
                public QuickFix.Fields.CouponPaymentDate couponPaymentDate
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
                    this.couponPaymentDate = val;
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
                public QuickFix.Fields.IssueDate issueDate
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
                    this.issueDate = val;
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
                public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
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
                    this.repoCollateralSecurityType = val;
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
                public QuickFix.Fields.RepurchaseTerm repurchaseTerm
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
                    this.repurchaseTerm = val;
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
                public QuickFix.Fields.RepurchaseRate repurchaseRate
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
                    this.repurchaseRate = val;
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
                public QuickFix.Fields.Factor factor
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
                    this.factor = val;
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
                public QuickFix.Fields.CreditRating creditRating
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
                    this.creditRating = val;
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
                public QuickFix.Fields.InstrRegistry instrRegistry
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
                    this.instrRegistry = val;
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
                public QuickFix.Fields.CountryOfIssue countryOfIssue
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
                    this.countryOfIssue = val;
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
                public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
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
                    this.stateOrProvinceOfIssue = val;
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
                public QuickFix.Fields.LocaleOfIssue localeOfIssue
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
                    this.localeOfIssue = val;
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
                public QuickFix.Fields.RedemptionDate redemptionDate
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
                    this.redemptionDate = val;
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
                public QuickFix.Fields.StrikePrice strikePrice
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
                    this.strikePrice = val;
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
                public QuickFix.Fields.StrikeCurrency strikeCurrency
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
                    this.strikeCurrency = val;
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
                public QuickFix.Fields.OptAttribute optAttribute
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
                    this.optAttribute = val;
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
                public QuickFix.Fields.ContractMultiplier contractMultiplier
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
                    this.contractMultiplier = val;
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
                public QuickFix.Fields.CouponRate couponRate
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
                    this.couponRate = val;
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
                public QuickFix.Fields.SecurityExchange securityExchange
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
                    this.securityExchange = val;
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
                public QuickFix.Fields.Issuer issuer
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
                    this.issuer = val;
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
                public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
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
                    this.encodedIssuerLen = val;
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
                public QuickFix.Fields.EncodedIssuer encodedIssuer
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
                    this.encodedIssuer = val;
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
                public QuickFix.Fields.SecurityDesc securityDesc
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
                    this.securityDesc = val;
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
                public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
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
                    this.encodedSecurityDescLen = val;
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
                public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
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
                    this.encodedSecurityDesc = val;
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
                public QuickFix.Fields.Pool pool
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
                    this.pool = val;
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
                public QuickFix.Fields.ContractSettlMonth contractSettlMonth
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
                    this.contractSettlMonth = val;
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
                public QuickFix.Fields.CPProgram cPProgram
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
                    this.cPProgram = val;
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
                public QuickFix.Fields.CPRegType cPRegType
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
                    this.cPRegType = val;
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
                public QuickFix.Fields.NoEvents noEvents
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
                    this.noEvents = val;
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
                public QuickFix.Fields.DatedDate datedDate
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
                    this.datedDate = val;
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
                public QuickFix.Fields.InterestAccrualDate interestAccrualDate
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
                    this.interestAccrualDate = val;
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
                public QuickFix.Fields.SecurityStatus securityStatus
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
                    this.securityStatus = val;
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
                public QuickFix.Fields.SettleOnOpenFlag settleOnOpenFlag
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
                    this.settleOnOpenFlag = val;
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
                public QuickFix.Fields.InstrmtAssignmentMethod instrmtAssignmentMethod
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
                    this.instrmtAssignmentMethod = val;
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
                public QuickFix.Fields.StrikeMultiplier strikeMultiplier
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
                    this.strikeMultiplier = val;
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
                public QuickFix.Fields.StrikeValue strikeValue
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
                    this.strikeValue = val;
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
                public QuickFix.Fields.MinPriceIncrement minPriceIncrement
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
                    this.minPriceIncrement = val;
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
                public QuickFix.Fields.PositionLimit positionLimit
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
                    this.positionLimit = val;
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
                public QuickFix.Fields.NTPositionLimit nTPositionLimit
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
                    this.nTPositionLimit = val;
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
                public QuickFix.Fields.NoInstrumentParties noInstrumentParties
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
                    this.noInstrumentParties = val;
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
                public QuickFix.Fields.UnitOfMeasure unitOfMeasure
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
                    this.unitOfMeasure = val;
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
                public QuickFix.Fields.TimeUnit timeUnit
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
                    this.timeUnit = val;
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
                public QuickFix.Fields.MaturityTime maturityTime
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
                    this.maturityTime = val;
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
                public QuickFix.Fields.SecurityGroup securityGroup
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
                    this.securityGroup = val;
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
                public QuickFix.Fields.MinPriceIncrementAmount minPriceIncrementAmount
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
                    this.minPriceIncrementAmount = val;
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
                public QuickFix.Fields.UnitOfMeasureQty unitOfMeasureQty
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
                    this.unitOfMeasureQty = val;
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
                public QuickFix.Fields.SecurityXMLLen securityXMLLen
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
                    this.securityXMLLen = val;
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
                public QuickFix.Fields.SecurityXML securityXML
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
                    this.securityXML = val;
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
                public QuickFix.Fields.SecurityXMLSchema securityXMLSchema
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
                    this.securityXMLSchema = val;
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
                public QuickFix.Fields.ProductComplex productComplex
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
                    this.productComplex = val;
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
                public QuickFix.Fields.PriceUnitOfMeasure priceUnitOfMeasure
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
                    this.priceUnitOfMeasure = val;
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
                public QuickFix.Fields.PriceUnitOfMeasureQty priceUnitOfMeasureQty
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
                    this.priceUnitOfMeasureQty = val;
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
                public QuickFix.Fields.SettlMethod settlMethod
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
                    this.settlMethod = val;
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
                public QuickFix.Fields.ExerciseStyle exerciseStyle
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
                    this.exerciseStyle = val;
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
                public QuickFix.Fields.OptPayoutAmount optPayoutAmount
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
                    this.optPayoutAmount = val;
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
                public QuickFix.Fields.PriceQuoteMethod priceQuoteMethod
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
                    this.priceQuoteMethod = val;
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
                public QuickFix.Fields.ListMethod listMethod
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
                    this.listMethod = val;
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
                public QuickFix.Fields.CapPrice capPrice
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
                    this.capPrice = val;
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
                public QuickFix.Fields.FloorPrice floorPrice
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
                    this.floorPrice = val;
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
                public QuickFix.Fields.PutOrCall putOrCall
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
                    this.putOrCall = val;
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
                public QuickFix.Fields.FlexibleIndicator flexibleIndicator
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
                    this.flexibleIndicator = val;
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
                public QuickFix.Fields.FlexProductEligibilityIndicator flexProductEligibilityIndicator
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
                    this.flexProductEligibilityIndicator = val;
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
                public QuickFix.Fields.ValuationMethod valuationMethod
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
                    this.valuationMethod = val;
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
                public QuickFix.Fields.ContractMultiplierUnit contractMultiplierUnit
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
                    this.contractMultiplierUnit = val;
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
                public QuickFix.Fields.FlowScheduleType flowScheduleType
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
                    this.flowScheduleType = val;
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
                public QuickFix.Fields.RestructuringType restructuringType
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
                    this.restructuringType = val;
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
                public QuickFix.Fields.Seniority seniority
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
                    this.seniority = val;
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
                public QuickFix.Fields.NotionalPercentageOutstanding notionalPercentageOutstanding
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
                    this.notionalPercentageOutstanding = val;
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
                public QuickFix.Fields.OriginalNotionalPercentageOutstanding originalNotionalPercentageOutstanding
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
                    this.originalNotionalPercentageOutstanding = val;
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
                public QuickFix.Fields.AttachmentPoint attachmentPoint
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
                    this.attachmentPoint = val;
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
                public QuickFix.Fields.DetachmentPoint detachmentPoint
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
                    this.detachmentPoint = val;
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
                public QuickFix.Fields.StrikePriceDeterminationMethod strikePriceDeterminationMethod
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
                    this.strikePriceDeterminationMethod = val;
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
                public QuickFix.Fields.StrikePriceBoundaryMethod strikePriceBoundaryMethod
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
                    this.strikePriceBoundaryMethod = val;
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
                public QuickFix.Fields.StrikePriceBoundaryPrecision strikePriceBoundaryPrecision
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
                    this.strikePriceBoundaryPrecision = val;
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
                public QuickFix.Fields.UnderlyingPriceDeterminationMethod underlyingPriceDeterminationMethod
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
                    this.underlyingPriceDeterminationMethod = val;
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
                public QuickFix.Fields.OptPayoutType optPayoutType
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
                    this.optPayoutType = val;
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
                public QuickFix.Fields.NoComplexEvents noComplexEvents
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
                    this.noComplexEvents = val;
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
                public QuickFix.Fields.AgreementDesc agreementDesc
                { 
                    get 
                    {
                        QuickFix.Fields.AgreementDesc val = new QuickFix.Fields.AgreementDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AgreementDesc val) 
                { 
                    this.agreementDesc = val;
                }
                
                public QuickFix.Fields.AgreementDesc Get(QuickFix.Fields.AgreementDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AgreementDesc val) 
                { 
                    return IsSetAgreementDesc();
                }
                
                public bool IsSetAgreementDesc() 
                { 
                    return IsSetField(Tags.AgreementDesc);
                }
                public QuickFix.Fields.AgreementID agreementID
                { 
                    get 
                    {
                        QuickFix.Fields.AgreementID val = new QuickFix.Fields.AgreementID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AgreementID val) 
                { 
                    this.agreementID = val;
                }
                
                public QuickFix.Fields.AgreementID Get(QuickFix.Fields.AgreementID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AgreementID val) 
                { 
                    return IsSetAgreementID();
                }
                
                public bool IsSetAgreementID() 
                { 
                    return IsSetField(Tags.AgreementID);
                }
                public QuickFix.Fields.AgreementDate agreementDate
                { 
                    get 
                    {
                        QuickFix.Fields.AgreementDate val = new QuickFix.Fields.AgreementDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AgreementDate val) 
                { 
                    this.agreementDate = val;
                }
                
                public QuickFix.Fields.AgreementDate Get(QuickFix.Fields.AgreementDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AgreementDate val) 
                { 
                    return IsSetAgreementDate();
                }
                
                public bool IsSetAgreementDate() 
                { 
                    return IsSetField(Tags.AgreementDate);
                }
                public QuickFix.Fields.AgreementCurrency agreementCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.AgreementCurrency val = new QuickFix.Fields.AgreementCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AgreementCurrency val) 
                { 
                    this.agreementCurrency = val;
                }
                
                public QuickFix.Fields.AgreementCurrency Get(QuickFix.Fields.AgreementCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AgreementCurrency val) 
                { 
                    return IsSetAgreementCurrency();
                }
                
                public bool IsSetAgreementCurrency() 
                { 
                    return IsSetField(Tags.AgreementCurrency);
                }
                public QuickFix.Fields.TerminationType terminationType
                { 
                    get 
                    {
                        QuickFix.Fields.TerminationType val = new QuickFix.Fields.TerminationType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TerminationType val) 
                { 
                    this.terminationType = val;
                }
                
                public QuickFix.Fields.TerminationType Get(QuickFix.Fields.TerminationType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TerminationType val) 
                { 
                    return IsSetTerminationType();
                }
                
                public bool IsSetTerminationType() 
                { 
                    return IsSetField(Tags.TerminationType);
                }
                public QuickFix.Fields.StartDate startDate
                { 
                    get 
                    {
                        QuickFix.Fields.StartDate val = new QuickFix.Fields.StartDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StartDate val) 
                { 
                    this.startDate = val;
                }
                
                public QuickFix.Fields.StartDate Get(QuickFix.Fields.StartDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StartDate val) 
                { 
                    return IsSetStartDate();
                }
                
                public bool IsSetStartDate() 
                { 
                    return IsSetField(Tags.StartDate);
                }
                public QuickFix.Fields.EndDate endDate
                { 
                    get 
                    {
                        QuickFix.Fields.EndDate val = new QuickFix.Fields.EndDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EndDate val) 
                { 
                    this.endDate = val;
                }
                
                public QuickFix.Fields.EndDate Get(QuickFix.Fields.EndDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EndDate val) 
                { 
                    return IsSetEndDate();
                }
                
                public bool IsSetEndDate() 
                { 
                    return IsSetField(Tags.EndDate);
                }
                public QuickFix.Fields.DeliveryType deliveryType
                { 
                    get 
                    {
                        QuickFix.Fields.DeliveryType val = new QuickFix.Fields.DeliveryType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeliveryType val) 
                { 
                    this.deliveryType = val;
                }
                
                public QuickFix.Fields.DeliveryType Get(QuickFix.Fields.DeliveryType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeliveryType val) 
                { 
                    return IsSetDeliveryType();
                }
                
                public bool IsSetDeliveryType() 
                { 
                    return IsSetField(Tags.DeliveryType);
                }
                public QuickFix.Fields.MarginRatio marginRatio
                { 
                    get 
                    {
                        QuickFix.Fields.MarginRatio val = new QuickFix.Fields.MarginRatio();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MarginRatio val) 
                { 
                    this.marginRatio = val;
                }
                
                public QuickFix.Fields.MarginRatio Get(QuickFix.Fields.MarginRatio val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MarginRatio val) 
                { 
                    return IsSetMarginRatio();
                }
                
                public bool IsSetMarginRatio() 
                { 
                    return IsSetField(Tags.MarginRatio);
                }
                public QuickFix.Fields.NoUnderlyings noUnderlyings
                { 
                    get 
                    {
                        QuickFix.Fields.NoUnderlyings val = new QuickFix.Fields.NoUnderlyings();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoUnderlyings val) 
                { 
                    this.noUnderlyings = val;
                }
                
                public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoUnderlyings val) 
                { 
                    return IsSetNoUnderlyings();
                }
                
                public bool IsSetNoUnderlyings() 
                { 
                    return IsSetField(Tags.NoUnderlyings);
                }
                public QuickFix.Fields.PrevClosePx prevClosePx
                { 
                    get 
                    {
                        QuickFix.Fields.PrevClosePx val = new QuickFix.Fields.PrevClosePx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PrevClosePx val) 
                { 
                    this.prevClosePx = val;
                }
                
                public QuickFix.Fields.PrevClosePx Get(QuickFix.Fields.PrevClosePx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PrevClosePx val) 
                { 
                    return IsSetPrevClosePx();
                }
                
                public bool IsSetPrevClosePx() 
                { 
                    return IsSetField(Tags.PrevClosePx);
                }
                public QuickFix.Fields.QuoteRequestType quoteRequestType
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteRequestType val = new QuickFix.Fields.QuoteRequestType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteRequestType val) 
                { 
                    this.quoteRequestType = val;
                }
                
                public QuickFix.Fields.QuoteRequestType Get(QuickFix.Fields.QuoteRequestType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteRequestType val) 
                { 
                    return IsSetQuoteRequestType();
                }
                
                public bool IsSetQuoteRequestType() 
                { 
                    return IsSetField(Tags.QuoteRequestType);
                }
                public QuickFix.Fields.QuoteType quoteType
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteType val = new QuickFix.Fields.QuoteType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteType val) 
                { 
                    this.quoteType = val;
                }
                
                public QuickFix.Fields.QuoteType Get(QuickFix.Fields.QuoteType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteType val) 
                { 
                    return IsSetQuoteType();
                }
                
                public bool IsSetQuoteType() 
                { 
                    return IsSetField(Tags.QuoteType);
                }
                public QuickFix.Fields.TradingSessionID tradingSessionID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionID val) 
                { 
                    this.tradingSessionID = val;
                }
                
                public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionID val) 
                { 
                    return IsSetTradingSessionID();
                }
                
                public bool IsSetTradingSessionID() 
                { 
                    return IsSetField(Tags.TradingSessionID);
                }
                public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    this.tradingSessionSubID = val;
                }
                
                public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionSubID val) 
                { 
                    return IsSetTradingSessionSubID();
                }
                
                public bool IsSetTradingSessionSubID() 
                { 
                    return IsSetField(Tags.TradingSessionSubID);
                }
                public QuickFix.Fields.TradeOriginationDate tradeOriginationDate
                { 
                    get 
                    {
                        QuickFix.Fields.TradeOriginationDate val = new QuickFix.Fields.TradeOriginationDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    this.tradeOriginationDate = val;
                }
                
                public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradeOriginationDate val) 
                { 
                    return IsSetTradeOriginationDate();
                }
                
                public bool IsSetTradeOriginationDate() 
                { 
                    return IsSetField(Tags.TradeOriginationDate);
                }
                public QuickFix.Fields.Side side
                { 
                    get 
                    {
                        QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Side val) 
                { 
                    this.side = val;
                }
                
                public QuickFix.Fields.Side Get(QuickFix.Fields.Side val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Side val) 
                { 
                    return IsSetSide();
                }
                
                public bool IsSetSide() 
                { 
                    return IsSetField(Tags.Side);
                }
                public QuickFix.Fields.QtyType qtyType
                { 
                    get 
                    {
                        QuickFix.Fields.QtyType val = new QuickFix.Fields.QtyType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QtyType val) 
                { 
                    this.qtyType = val;
                }
                
                public QuickFix.Fields.QtyType Get(QuickFix.Fields.QtyType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QtyType val) 
                { 
                    return IsSetQtyType();
                }
                
                public bool IsSetQtyType() 
                { 
                    return IsSetField(Tags.QtyType);
                }
                public QuickFix.Fields.OrderQty orderQty
                { 
                    get 
                    {
                        QuickFix.Fields.OrderQty val = new QuickFix.Fields.OrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderQty val) 
                { 
                    this.orderQty = val;
                }
                
                public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderQty val) 
                { 
                    return IsSetOrderQty();
                }
                
                public bool IsSetOrderQty() 
                { 
                    return IsSetField(Tags.OrderQty);
                }
                public QuickFix.Fields.CashOrderQty cashOrderQty
                { 
                    get 
                    {
                        QuickFix.Fields.CashOrderQty val = new QuickFix.Fields.CashOrderQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CashOrderQty val) 
                { 
                    this.cashOrderQty = val;
                }
                
                public QuickFix.Fields.CashOrderQty Get(QuickFix.Fields.CashOrderQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CashOrderQty val) 
                { 
                    return IsSetCashOrderQty();
                }
                
                public bool IsSetCashOrderQty() 
                { 
                    return IsSetField(Tags.CashOrderQty);
                }
                public QuickFix.Fields.OrderPercent orderPercent
                { 
                    get 
                    {
                        QuickFix.Fields.OrderPercent val = new QuickFix.Fields.OrderPercent();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderPercent val) 
                { 
                    this.orderPercent = val;
                }
                
                public QuickFix.Fields.OrderPercent Get(QuickFix.Fields.OrderPercent val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderPercent val) 
                { 
                    return IsSetOrderPercent();
                }
                
                public bool IsSetOrderPercent() 
                { 
                    return IsSetField(Tags.OrderPercent);
                }
                public QuickFix.Fields.RoundingDirection roundingDirection
                { 
                    get 
                    {
                        QuickFix.Fields.RoundingDirection val = new QuickFix.Fields.RoundingDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoundingDirection val) 
                { 
                    this.roundingDirection = val;
                }
                
                public QuickFix.Fields.RoundingDirection Get(QuickFix.Fields.RoundingDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoundingDirection val) 
                { 
                    return IsSetRoundingDirection();
                }
                
                public bool IsSetRoundingDirection() 
                { 
                    return IsSetField(Tags.RoundingDirection);
                }
                public QuickFix.Fields.RoundingModulus roundingModulus
                { 
                    get 
                    {
                        QuickFix.Fields.RoundingModulus val = new QuickFix.Fields.RoundingModulus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RoundingModulus val) 
                { 
                    this.roundingModulus = val;
                }
                
                public QuickFix.Fields.RoundingModulus Get(QuickFix.Fields.RoundingModulus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RoundingModulus val) 
                { 
                    return IsSetRoundingModulus();
                }
                
                public bool IsSetRoundingModulus() 
                { 
                    return IsSetField(Tags.RoundingModulus);
                }
                public QuickFix.Fields.SettlType settlType
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
                    this.settlType = val;
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
                public QuickFix.Fields.SettlDate settlDate
                { 
                    get 
                    {
                        QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlDate val) 
                { 
                    this.settlDate = val;
                }
                
                public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlDate val) 
                { 
                    return IsSetSettlDate();
                }
                
                public bool IsSetSettlDate() 
                { 
                    return IsSetField(Tags.SettlDate);
                }
                public QuickFix.Fields.SettlDate2 settlDate2
                { 
                    get 
                    {
                        QuickFix.Fields.SettlDate2 val = new QuickFix.Fields.SettlDate2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlDate2 val) 
                { 
                    this.settlDate2 = val;
                }
                
                public QuickFix.Fields.SettlDate2 Get(QuickFix.Fields.SettlDate2 val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlDate2 val) 
                { 
                    return IsSetSettlDate2();
                }
                
                public bool IsSetSettlDate2() 
                { 
                    return IsSetField(Tags.SettlDate2);
                }
                public QuickFix.Fields.OrderQty2 orderQty2
                { 
                    get 
                    {
                        QuickFix.Fields.OrderQty2 val = new QuickFix.Fields.OrderQty2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderQty2 val) 
                { 
                    this.orderQty2 = val;
                }
                
                public QuickFix.Fields.OrderQty2 Get(QuickFix.Fields.OrderQty2 val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderQty2 val) 
                { 
                    return IsSetOrderQty2();
                }
                
                public bool IsSetOrderQty2() 
                { 
                    return IsSetField(Tags.OrderQty2);
                }
                public QuickFix.Fields.Currency currency
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
                    this.currency = val;
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
                public QuickFix.Fields.NoStipulations noStipulations
                { 
                    get 
                    {
                        QuickFix.Fields.NoStipulations val = new QuickFix.Fields.NoStipulations();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoStipulations val) 
                { 
                    this.noStipulations = val;
                }
                
                public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoStipulations val) 
                { 
                    return IsSetNoStipulations();
                }
                
                public bool IsSetNoStipulations() 
                { 
                    return IsSetField(Tags.NoStipulations);
                }
                public QuickFix.Fields.Account account
                { 
                    get 
                    {
                        QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Account val) 
                { 
                    this.account = val;
                }
                
                public QuickFix.Fields.Account Get(QuickFix.Fields.Account val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Account val) 
                { 
                    return IsSetAccount();
                }
                
                public bool IsSetAccount() 
                { 
                    return IsSetField(Tags.Account);
                }
                public QuickFix.Fields.AcctIDSource acctIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.AcctIDSource val = new QuickFix.Fields.AcctIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AcctIDSource val) 
                { 
                    this.acctIDSource = val;
                }
                
                public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AcctIDSource val) 
                { 
                    return IsSetAcctIDSource();
                }
                
                public bool IsSetAcctIDSource() 
                { 
                    return IsSetField(Tags.AcctIDSource);
                }
                public QuickFix.Fields.AccountType accountType
                { 
                    get 
                    {
                        QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.AccountType val) 
                { 
                    this.accountType = val;
                }
                
                public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.AccountType val) 
                { 
                    return IsSetAccountType();
                }
                
                public bool IsSetAccountType() 
                { 
                    return IsSetField(Tags.AccountType);
                }
                public QuickFix.Fields.NoLegs noLegs
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoLegs val) 
                { 
                    this.noLegs = val;
                }
                
                public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoLegs val) 
                { 
                    return IsSetNoLegs();
                }
                
                public bool IsSetNoLegs() 
                { 
                    return IsSetField(Tags.NoLegs);
                }
                public QuickFix.Fields.NoQuoteQualifiers noQuoteQualifiers
                { 
                    get 
                    {
                        QuickFix.Fields.NoQuoteQualifiers val = new QuickFix.Fields.NoQuoteQualifiers();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoQuoteQualifiers val) 
                { 
                    this.noQuoteQualifiers = val;
                }
                
                public QuickFix.Fields.NoQuoteQualifiers Get(QuickFix.Fields.NoQuoteQualifiers val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoQuoteQualifiers val) 
                { 
                    return IsSetNoQuoteQualifiers();
                }
                
                public bool IsSetNoQuoteQualifiers() 
                { 
                    return IsSetField(Tags.NoQuoteQualifiers);
                }
                public QuickFix.Fields.QuotePriceType quotePriceType
                { 
                    get 
                    {
                        QuickFix.Fields.QuotePriceType val = new QuickFix.Fields.QuotePriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuotePriceType val) 
                { 
                    this.quotePriceType = val;
                }
                
                public QuickFix.Fields.QuotePriceType Get(QuickFix.Fields.QuotePriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuotePriceType val) 
                { 
                    return IsSetQuotePriceType();
                }
                
                public bool IsSetQuotePriceType() 
                { 
                    return IsSetField(Tags.QuotePriceType);
                }
                public QuickFix.Fields.OrdType ordType
                { 
                    get 
                    {
                        QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrdType val) 
                { 
                    this.ordType = val;
                }
                
                public QuickFix.Fields.OrdType Get(QuickFix.Fields.OrdType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrdType val) 
                { 
                    return IsSetOrdType();
                }
                
                public bool IsSetOrdType() 
                { 
                    return IsSetField(Tags.OrdType);
                }
                public QuickFix.Fields.ValidUntilTime validUntilTime
                { 
                    get 
                    {
                        QuickFix.Fields.ValidUntilTime val = new QuickFix.Fields.ValidUntilTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ValidUntilTime val) 
                { 
                    this.validUntilTime = val;
                }
                
                public QuickFix.Fields.ValidUntilTime Get(QuickFix.Fields.ValidUntilTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ValidUntilTime val) 
                { 
                    return IsSetValidUntilTime();
                }
                
                public bool IsSetValidUntilTime() 
                { 
                    return IsSetField(Tags.ValidUntilTime);
                }
                public QuickFix.Fields.ExpireTime expireTime
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpireTime val) 
                { 
                    this.expireTime = val;
                }
                
                public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExpireTime val) 
                { 
                    return IsSetExpireTime();
                }
                
                public bool IsSetExpireTime() 
                { 
                    return IsSetField(Tags.ExpireTime);
                }
                public QuickFix.Fields.TransactTime transactTime
                { 
                    get 
                    {
                        QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TransactTime val) 
                { 
                    this.transactTime = val;
                }
                
                public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TransactTime val) 
                { 
                    return IsSetTransactTime();
                }
                
                public bool IsSetTransactTime() 
                { 
                    return IsSetField(Tags.TransactTime);
                }
                public QuickFix.Fields.Spread spread
                { 
                    get 
                    {
                        QuickFix.Fields.Spread val = new QuickFix.Fields.Spread();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Spread val) 
                { 
                    this.spread = val;
                }
                
                public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Spread val) 
                { 
                    return IsSetSpread();
                }
                
                public bool IsSetSpread() 
                { 
                    return IsSetField(Tags.Spread);
                }
                public QuickFix.Fields.BenchmarkCurveCurrency benchmarkCurveCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurveCurrency val = new QuickFix.Fields.BenchmarkCurveCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    this.benchmarkCurveCurrency = val;
                }
                
                public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val) 
                { 
                    return IsSetBenchmarkCurveCurrency();
                }
                
                public bool IsSetBenchmarkCurveCurrency() 
                { 
                    return IsSetField(Tags.BenchmarkCurveCurrency);
                }
                public QuickFix.Fields.BenchmarkCurveName benchmarkCurveName
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurveName val = new QuickFix.Fields.BenchmarkCurveName();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    this.benchmarkCurveName = val;
                }
                
                public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurveName val) 
                { 
                    return IsSetBenchmarkCurveName();
                }
                
                public bool IsSetBenchmarkCurveName() 
                { 
                    return IsSetField(Tags.BenchmarkCurveName);
                }
                public QuickFix.Fields.BenchmarkCurvePoint benchmarkCurvePoint
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkCurvePoint val = new QuickFix.Fields.BenchmarkCurvePoint();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    this.benchmarkCurvePoint = val;
                }
                
                public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val) 
                { 
                    return IsSetBenchmarkCurvePoint();
                }
                
                public bool IsSetBenchmarkCurvePoint() 
                { 
                    return IsSetField(Tags.BenchmarkCurvePoint);
                }
                public QuickFix.Fields.BenchmarkPrice benchmarkPrice
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkPrice val = new QuickFix.Fields.BenchmarkPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    this.benchmarkPrice = val;
                }
                
                public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkPrice val) 
                { 
                    return IsSetBenchmarkPrice();
                }
                
                public bool IsSetBenchmarkPrice() 
                { 
                    return IsSetField(Tags.BenchmarkPrice);
                }
                public QuickFix.Fields.BenchmarkPriceType benchmarkPriceType
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkPriceType val = new QuickFix.Fields.BenchmarkPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    this.benchmarkPriceType = val;
                }
                
                public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkPriceType val) 
                { 
                    return IsSetBenchmarkPriceType();
                }
                
                public bool IsSetBenchmarkPriceType() 
                { 
                    return IsSetField(Tags.BenchmarkPriceType);
                }
                public QuickFix.Fields.BenchmarkSecurityID benchmarkSecurityID
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkSecurityID val = new QuickFix.Fields.BenchmarkSecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    this.benchmarkSecurityID = val;
                }
                
                public QuickFix.Fields.BenchmarkSecurityID Get(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkSecurityID val) 
                { 
                    return IsSetBenchmarkSecurityID();
                }
                
                public bool IsSetBenchmarkSecurityID() 
                { 
                    return IsSetField(Tags.BenchmarkSecurityID);
                }
                public QuickFix.Fields.BenchmarkSecurityIDSource benchmarkSecurityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.BenchmarkSecurityIDSource val = new QuickFix.Fields.BenchmarkSecurityIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    this.benchmarkSecurityIDSource = val;
                }
                
                public QuickFix.Fields.BenchmarkSecurityIDSource Get(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.BenchmarkSecurityIDSource val) 
                { 
                    return IsSetBenchmarkSecurityIDSource();
                }
                
                public bool IsSetBenchmarkSecurityIDSource() 
                { 
                    return IsSetField(Tags.BenchmarkSecurityIDSource);
                }
                public QuickFix.Fields.PriceType priceType
                { 
                    get 
                    {
                        QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PriceType val) 
                { 
                    this.priceType = val;
                }
                
                public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PriceType val) 
                { 
                    return IsSetPriceType();
                }
                
                public bool IsSetPriceType() 
                { 
                    return IsSetField(Tags.PriceType);
                }
                public QuickFix.Fields.Price price
                { 
                    get 
                    {
                        QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Price val) 
                { 
                    this.price = val;
                }
                
                public QuickFix.Fields.Price Get(QuickFix.Fields.Price val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Price val) 
                { 
                    return IsSetPrice();
                }
                
                public bool IsSetPrice() 
                { 
                    return IsSetField(Tags.Price);
                }
                public QuickFix.Fields.Price2 price2
                { 
                    get 
                    {
                        QuickFix.Fields.Price2 val = new QuickFix.Fields.Price2();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Price2 val) 
                { 
                    this.price2 = val;
                }
                
                public QuickFix.Fields.Price2 Get(QuickFix.Fields.Price2 val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Price2 val) 
                { 
                    return IsSetPrice2();
                }
                
                public bool IsSetPrice2() 
                { 
                    return IsSetField(Tags.Price2);
                }
                public QuickFix.Fields.YieldType yieldType
                { 
                    get 
                    {
                        QuickFix.Fields.YieldType val = new QuickFix.Fields.YieldType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldType val) 
                { 
                    this.yieldType = val;
                }
                
                public QuickFix.Fields.YieldType Get(QuickFix.Fields.YieldType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldType val) 
                { 
                    return IsSetYieldType();
                }
                
                public bool IsSetYieldType() 
                { 
                    return IsSetField(Tags.YieldType);
                }
                public QuickFix.Fields.Yield yield
                { 
                    get 
                    {
                        QuickFix.Fields.Yield val = new QuickFix.Fields.Yield();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Yield val) 
                { 
                    this.yield = val;
                }
                
                public QuickFix.Fields.Yield Get(QuickFix.Fields.Yield val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Yield val) 
                { 
                    return IsSetYield();
                }
                
                public bool IsSetYield() 
                { 
                    return IsSetField(Tags.Yield);
                }
                public QuickFix.Fields.YieldCalcDate yieldCalcDate
                { 
                    get 
                    {
                        QuickFix.Fields.YieldCalcDate val = new QuickFix.Fields.YieldCalcDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldCalcDate val) 
                { 
                    this.yieldCalcDate = val;
                }
                
                public QuickFix.Fields.YieldCalcDate Get(QuickFix.Fields.YieldCalcDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldCalcDate val) 
                { 
                    return IsSetYieldCalcDate();
                }
                
                public bool IsSetYieldCalcDate() 
                { 
                    return IsSetField(Tags.YieldCalcDate);
                }
                public QuickFix.Fields.YieldRedemptionDate yieldRedemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionDate val = new QuickFix.Fields.YieldRedemptionDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    this.yieldRedemptionDate = val;
                }
                
                public QuickFix.Fields.YieldRedemptionDate Get(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionDate val) 
                { 
                    return IsSetYieldRedemptionDate();
                }
                
                public bool IsSetYieldRedemptionDate() 
                { 
                    return IsSetField(Tags.YieldRedemptionDate);
                }
                public QuickFix.Fields.YieldRedemptionPrice yieldRedemptionPrice
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionPrice val = new QuickFix.Fields.YieldRedemptionPrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    this.yieldRedemptionPrice = val;
                }
                
                public QuickFix.Fields.YieldRedemptionPrice Get(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionPrice val) 
                { 
                    return IsSetYieldRedemptionPrice();
                }
                
                public bool IsSetYieldRedemptionPrice() 
                { 
                    return IsSetField(Tags.YieldRedemptionPrice);
                }
                public QuickFix.Fields.YieldRedemptionPriceType yieldRedemptionPriceType
                { 
                    get 
                    {
                        QuickFix.Fields.YieldRedemptionPriceType val = new QuickFix.Fields.YieldRedemptionPriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    this.yieldRedemptionPriceType = val;
                }
                
                public QuickFix.Fields.YieldRedemptionPriceType Get(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.YieldRedemptionPriceType val) 
                { 
                    return IsSetYieldRedemptionPriceType();
                }
                
                public bool IsSetYieldRedemptionPriceType() 
                { 
                    return IsSetField(Tags.YieldRedemptionPriceType);
                }
                public QuickFix.Fields.NoPartyIDs noPartyIDs
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
                    this.noPartyIDs = val;
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
                public QuickFix.Fields.MinQty minQty
                { 
                    get 
                    {
                        QuickFix.Fields.MinQty val = new QuickFix.Fields.MinQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinQty val) 
                { 
                    this.minQty = val;
                }
                
                public QuickFix.Fields.MinQty Get(QuickFix.Fields.MinQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinQty val) 
                { 
                    return IsSetMinQty();
                }
                
                public bool IsSetMinQty() 
                { 
                    return IsSetField(Tags.MinQty);
                }
                public QuickFix.Fields.SettlCurrency settlCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrency val = new QuickFix.Fields.SettlCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrency val) 
                { 
                    this.settlCurrency = val;
                }
                
                public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrency val) 
                { 
                    return IsSetSettlCurrency();
                }
                
                public bool IsSetSettlCurrency() 
                { 
                    return IsSetField(Tags.SettlCurrency);
                }
                public QuickFix.Fields.NoRateSources noRateSources
                { 
                    get 
                    {
                        QuickFix.Fields.NoRateSources val = new QuickFix.Fields.NoRateSources();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoRateSources val) 
                { 
                    this.noRateSources = val;
                }
                
                public QuickFix.Fields.NoRateSources Get(QuickFix.Fields.NoRateSources val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoRateSources val) 
                { 
                    return IsSetNoRateSources();
                }
                
                public bool IsSetNoRateSources() 
                { 
                    return IsSetField(Tags.NoRateSources);
                }
                            public class NoSecurityAltID : Group
                {
                    public NoSecurityAltID() 
                      :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                                    public QuickFix.Fields.SecurityAltID securityAltID
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
                        this.securityAltID = val;
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
                    public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
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
                        this.securityAltIDSource = val;
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
                public class NoEvents : Group
                {
                    public NoEvents() 
                      :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                                    public QuickFix.Fields.EventType eventType
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
                        this.eventType = val;
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
                    public QuickFix.Fields.EventDate eventDate
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
                        this.eventDate = val;
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
                    public QuickFix.Fields.EventPx eventPx
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
                        this.eventPx = val;
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
                    public QuickFix.Fields.EventText eventText
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
                        this.eventText = val;
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
                    public QuickFix.Fields.EventTime eventTime
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
                        this.eventTime = val;
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
                public class NoInstrumentParties : Group
                {
                    public NoInstrumentParties() 
                      :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                                    public QuickFix.Fields.InstrumentPartyID instrumentPartyID
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
                        this.instrumentPartyID = val;
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
                    public QuickFix.Fields.InstrumentPartyIDSource instrumentPartyIDSource
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
                        this.instrumentPartyIDSource = val;
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
                    public QuickFix.Fields.InstrumentPartyRole instrumentPartyRole
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
                        this.instrumentPartyRole = val;
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
                    public QuickFix.Fields.NoInstrumentPartySubIDs noInstrumentPartySubIDs
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
                        this.noInstrumentPartySubIDs = val;
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
                                    public class NoInstrumentPartySubIDs : Group
                    {
                        public NoInstrumentPartySubIDs() 
                          :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                                            public QuickFix.Fields.InstrumentPartySubID instrumentPartySubID
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
                            this.instrumentPartySubID = val;
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
                        public QuickFix.Fields.InstrumentPartySubIDType instrumentPartySubIDType
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
                            this.instrumentPartySubIDType = val;
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
                public class NoComplexEvents : Group
                {
                    public NoComplexEvents() 
                      :base( Tags.NoComplexEvents, Tags.ComplexEventType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.ComplexEventType, Tags.ComplexOptPayoutAmount, Tags.ComplexEventPrice, Tags.ComplexEventPriceBoundaryMethod, Tags.ComplexEventPriceBoundaryPrecision, Tags.ComplexEventPriceTimeType, Tags.ComplexEventCondition, Tags.NoComplexEventDates, 0};
                                    public QuickFix.Fields.ComplexEventType complexEventType
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
                        this.complexEventType = val;
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
                    public QuickFix.Fields.ComplexOptPayoutAmount complexOptPayoutAmount
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
                        this.complexOptPayoutAmount = val;
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
                    public QuickFix.Fields.ComplexEventPrice complexEventPrice
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
                        this.complexEventPrice = val;
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
                    public QuickFix.Fields.ComplexEventPriceBoundaryMethod complexEventPriceBoundaryMethod
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
                        this.complexEventPriceBoundaryMethod = val;
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
                    public QuickFix.Fields.ComplexEventPriceBoundaryPrecision complexEventPriceBoundaryPrecision
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
                        this.complexEventPriceBoundaryPrecision = val;
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
                    public QuickFix.Fields.ComplexEventPriceTimeType complexEventPriceTimeType
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
                        this.complexEventPriceTimeType = val;
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
                    public QuickFix.Fields.ComplexEventCondition complexEventCondition
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
                        this.complexEventCondition = val;
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
                    public QuickFix.Fields.NoComplexEventDates noComplexEventDates
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
                        this.noComplexEventDates = val;
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
                                    public class NoComplexEventDates : Group
                    {
                        public NoComplexEventDates() 
                          :base( Tags.NoComplexEventDates, Tags.ComplexEventStartDate, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.ComplexEventStartDate, Tags.ComplexEventEndDate, Tags.NoComplexEventTimes, 0};
                                            public QuickFix.Fields.ComplexEventStartDate complexEventStartDate
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
                            this.complexEventStartDate = val;
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
                        public QuickFix.Fields.ComplexEventEndDate complexEventEndDate
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
                            this.complexEventEndDate = val;
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
                        public QuickFix.Fields.NoComplexEventTimes noComplexEventTimes
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
                            this.noComplexEventTimes = val;
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
                                            public class NoComplexEventTimes : Group
                        {
                            public NoComplexEventTimes() 
                              :base( Tags.NoComplexEventTimes, Tags.ComplexEventStartTime, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.ComplexEventStartTime, Tags.ComplexEventEndTime, 0};
                                                    public QuickFix.Fields.ComplexEventStartTime complexEventStartTime
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
                                this.complexEventStartTime = val;
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
                            public QuickFix.Fields.ComplexEventEndTime complexEventEndTime
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
                                this.complexEventEndTime = val;
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
                public class NoUnderlyings : Group
                {
                    public NoUnderlyings() 
                      :base( Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, Tags.UnderlyingAllocationPercent, Tags.UnderlyingSettlementType, Tags.UnderlyingCashAmount, Tags.UnderlyingCashType, Tags.UnderlyingUnitOfMeasure, Tags.UnderlyingTimeUnit, Tags.UnderlyingCapValue, Tags.NoUndlyInstrumentParties, Tags.UnderlyingSettlMethod, Tags.UnderlyingAdjustedQuantity, Tags.UnderlyingFXRate, Tags.UnderlyingFXRateCalc, Tags.UnderlyingMaturityTime, Tags.UnderlyingPutOrCall, Tags.UnderlyingExerciseStyle, Tags.UnderlyingUnitOfMeasureQty, Tags.UnderlyingPriceUnitOfMeasure, Tags.UnderlyingPriceUnitOfMeasureQty, Tags.UnderlyingContractMultiplierUnit, Tags.UnderlyingFlowScheduleType, Tags.UnderlyingRestructuringType, Tags.UnderlyingSeniority, Tags.UnderlyingNotionalPercentageOutstanding, Tags.UnderlyingOriginalNotionalPercentageOutstanding, Tags.UnderlyingAttachmentPoint, Tags.UnderlyingDetachmentPoint, 0};
                                    public QuickFix.Fields.UnderlyingSymbol underlyingSymbol
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSymbol val) 
                    { 
                        this.underlyingSymbol = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) 
                    { 
                        return IsSetUnderlyingSymbol();
                    }
                    
                    public bool IsSetUnderlyingSymbol() 
                    { 
                        return IsSetField(Tags.UnderlyingSymbol);
                    }
                    public QuickFix.Fields.UnderlyingSymbolSfx underlyingSymbolSfx
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) 
                    { 
                        this.underlyingSymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
                    { 
                        return IsSetUnderlyingSymbolSfx();
                    }
                    
                    public bool IsSetUnderlyingSymbolSfx() 
                    { 
                        return IsSetField(Tags.UnderlyingSymbolSfx);
                    }
                    public QuickFix.Fields.UnderlyingSecurityID underlyingSecurityID
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityID val) 
                    { 
                        this.underlyingSecurityID = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) 
                    { 
                        return IsSetUnderlyingSecurityID();
                    }
                    
                    public bool IsSetUnderlyingSecurityID() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityID);
                    }
                    public QuickFix.Fields.UnderlyingSecurityIDSource underlyingSecurityIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        this.underlyingSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
                    { 
                        return IsSetUnderlyingSecurityIDSource();
                    }
                    
                    public bool IsSetUnderlyingSecurityIDSource() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityIDSource);
                    }
                    public QuickFix.Fields.NoUnderlyingSecurityAltID noUnderlyingSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        this.noUnderlyingSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
                    { 
                        return IsSetNoUnderlyingSecurityAltID();
                    }
                    
                    public bool IsSetNoUnderlyingSecurityAltID() 
                    { 
                        return IsSetField(Tags.NoUnderlyingSecurityAltID);
                    }
                    public QuickFix.Fields.UnderlyingProduct underlyingProduct
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        this.underlyingProduct = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingProduct val) 
                    { 
                        return IsSetUnderlyingProduct();
                    }
                    
                    public bool IsSetUnderlyingProduct() 
                    { 
                        return IsSetField(Tags.UnderlyingProduct);
                    }
                    public QuickFix.Fields.UnderlyingCFICode underlyingCFICode
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        this.underlyingCFICode = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) 
                    { 
                        return IsSetUnderlyingCFICode();
                    }
                    
                    public bool IsSetUnderlyingCFICode() 
                    { 
                        return IsSetField(Tags.UnderlyingCFICode);
                    }
                    public QuickFix.Fields.UnderlyingSecurityType underlyingSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityType val) 
                    { 
                        this.underlyingSecurityType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) 
                    { 
                        return IsSetUnderlyingSecurityType();
                    }
                    
                    public bool IsSetUnderlyingSecurityType() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityType);
                    }
                    public QuickFix.Fields.UnderlyingSecuritySubType underlyingSecuritySubType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        this.underlyingSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
                    { 
                        return IsSetUnderlyingSecuritySubType();
                    }
                    
                    public bool IsSetUnderlyingSecuritySubType() 
                    { 
                        return IsSetField(Tags.UnderlyingSecuritySubType);
                    }
                    public QuickFix.Fields.UnderlyingMaturityMonthYear underlyingMaturityMonthYear
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                    { 
                        this.underlyingMaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
                    { 
                        return IsSetUnderlyingMaturityMonthYear();
                    }
                    
                    public bool IsSetUnderlyingMaturityMonthYear() 
                    { 
                        return IsSetField(Tags.UnderlyingMaturityMonthYear);
                    }
                    public QuickFix.Fields.UnderlyingMaturityDate underlyingMaturityDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        this.underlyingMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) 
                    { 
                        return IsSetUnderlyingMaturityDate();
                    }
                    
                    public bool IsSetUnderlyingMaturityDate() 
                    { 
                        return IsSetField(Tags.UnderlyingMaturityDate);
                    }
                    public QuickFix.Fields.UnderlyingCouponPaymentDate underlyingCouponPaymentDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        this.underlyingCouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
                    { 
                        return IsSetUnderlyingCouponPaymentDate();
                    }
                    
                    public bool IsSetUnderlyingCouponPaymentDate() 
                    { 
                        return IsSetField(Tags.UnderlyingCouponPaymentDate);
                    }
                    public QuickFix.Fields.UnderlyingIssueDate underlyingIssueDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        this.underlyingIssueDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) 
                    { 
                        return IsSetUnderlyingIssueDate();
                    }
                    
                    public bool IsSetUnderlyingIssueDate() 
                    { 
                        return IsSetField(Tags.UnderlyingIssueDate);
                    }
                    public QuickFix.Fields.UnderlyingRepoCollateralSecurityType underlyingRepoCollateralSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        this.underlyingRepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
                    { 
                        return IsSetUnderlyingRepoCollateralSecurityType();
                    }
                    
                    public bool IsSetUnderlyingRepoCollateralSecurityType() 
                    { 
                        return IsSetField(Tags.UnderlyingRepoCollateralSecurityType);
                    }
                    public QuickFix.Fields.UnderlyingRepurchaseTerm underlyingRepurchaseTerm
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        this.underlyingRepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
                    { 
                        return IsSetUnderlyingRepurchaseTerm();
                    }
                    
                    public bool IsSetUnderlyingRepurchaseTerm() 
                    { 
                        return IsSetField(Tags.UnderlyingRepurchaseTerm);
                    }
                    public QuickFix.Fields.UnderlyingRepurchaseRate underlyingRepurchaseRate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        this.underlyingRepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
                    { 
                        return IsSetUnderlyingRepurchaseRate();
                    }
                    
                    public bool IsSetUnderlyingRepurchaseRate() 
                    { 
                        return IsSetField(Tags.UnderlyingRepurchaseRate);
                    }
                    public QuickFix.Fields.UnderlyingFactor underlyingFactor
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        this.underlyingFactor = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingFactor val) 
                    { 
                        return IsSetUnderlyingFactor();
                    }
                    
                    public bool IsSetUnderlyingFactor() 
                    { 
                        return IsSetField(Tags.UnderlyingFactor);
                    }
                    public QuickFix.Fields.UnderlyingCreditRating underlyingCreditRating
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        this.underlyingCreditRating = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) 
                    { 
                        return IsSetUnderlyingCreditRating();
                    }
                    
                    public bool IsSetUnderlyingCreditRating() 
                    { 
                        return IsSetField(Tags.UnderlyingCreditRating);
                    }
                    public QuickFix.Fields.UnderlyingInstrRegistry underlyingInstrRegistry
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        this.underlyingInstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
                    { 
                        return IsSetUnderlyingInstrRegistry();
                    }
                    
                    public bool IsSetUnderlyingInstrRegistry() 
                    { 
                        return IsSetField(Tags.UnderlyingInstrRegistry);
                    }
                    public QuickFix.Fields.UnderlyingCountryOfIssue underlyingCountryOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        this.underlyingCountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
                    { 
                        return IsSetUnderlyingCountryOfIssue();
                    }
                    
                    public bool IsSetUnderlyingCountryOfIssue() 
                    { 
                        return IsSetField(Tags.UnderlyingCountryOfIssue);
                    }
                    public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue underlyingStateOrProvinceOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        this.underlyingStateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
                    { 
                        return IsSetUnderlyingStateOrProvinceOfIssue();
                    }
                    
                    public bool IsSetUnderlyingStateOrProvinceOfIssue() 
                    { 
                        return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue);
                    }
                    public QuickFix.Fields.UnderlyingLocaleOfIssue underlyingLocaleOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        this.underlyingLocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
                    { 
                        return IsSetUnderlyingLocaleOfIssue();
                    }
                    
                    public bool IsSetUnderlyingLocaleOfIssue() 
                    { 
                        return IsSetField(Tags.UnderlyingLocaleOfIssue);
                    }
                    public QuickFix.Fields.UnderlyingRedemptionDate underlyingRedemptionDate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        this.underlyingRedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
                    { 
                        return IsSetUnderlyingRedemptionDate();
                    }
                    
                    public bool IsSetUnderlyingRedemptionDate() 
                    { 
                        return IsSetField(Tags.UnderlyingRedemptionDate);
                    }
                    public QuickFix.Fields.UnderlyingStrikePrice underlyingStrikePrice
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStrikePrice val) 
                    { 
                        this.underlyingStrikePrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) 
                    { 
                        return IsSetUnderlyingStrikePrice();
                    }
                    
                    public bool IsSetUnderlyingStrikePrice() 
                    { 
                        return IsSetField(Tags.UnderlyingStrikePrice);
                    }
                    public QuickFix.Fields.UnderlyingStrikeCurrency underlyingStrikeCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        this.underlyingStrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
                    { 
                        return IsSetUnderlyingStrikeCurrency();
                    }
                    
                    public bool IsSetUnderlyingStrikeCurrency() 
                    { 
                        return IsSetField(Tags.UnderlyingStrikeCurrency);
                    }
                    public QuickFix.Fields.UnderlyingOptAttribute underlyingOptAttribute
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingOptAttribute val) 
                    { 
                        this.underlyingOptAttribute = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) 
                    { 
                        return IsSetUnderlyingOptAttribute();
                    }
                    
                    public bool IsSetUnderlyingOptAttribute() 
                    { 
                        return IsSetField(Tags.UnderlyingOptAttribute);
                    }
                    public QuickFix.Fields.UnderlyingContractMultiplier underlyingContractMultiplier
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) 
                    { 
                        this.underlyingContractMultiplier = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
                    { 
                        return IsSetUnderlyingContractMultiplier();
                    }
                    
                    public bool IsSetUnderlyingContractMultiplier() 
                    { 
                        return IsSetField(Tags.UnderlyingContractMultiplier);
                    }
                    public QuickFix.Fields.UnderlyingCouponRate underlyingCouponRate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCouponRate val) 
                    { 
                        this.underlyingCouponRate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) 
                    { 
                        return IsSetUnderlyingCouponRate();
                    }
                    
                    public bool IsSetUnderlyingCouponRate() 
                    { 
                        return IsSetField(Tags.UnderlyingCouponRate);
                    }
                    public QuickFix.Fields.UnderlyingSecurityExchange underlyingSecurityExchange
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) 
                    { 
                        this.underlyingSecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
                    { 
                        return IsSetUnderlyingSecurityExchange();
                    }
                    
                    public bool IsSetUnderlyingSecurityExchange() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityExchange);
                    }
                    public QuickFix.Fields.UnderlyingIssuer underlyingIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingIssuer val) 
                    { 
                        this.underlyingIssuer = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) 
                    { 
                        return IsSetUnderlyingIssuer();
                    }
                    
                    public bool IsSetUnderlyingIssuer() 
                    { 
                        return IsSetField(Tags.UnderlyingIssuer);
                    }
                    public QuickFix.Fields.EncodedUnderlyingIssuerLen encodedUnderlyingIssuerLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                    { 
                        this.encodedUnderlyingIssuerLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
                    { 
                        return IsSetEncodedUnderlyingIssuerLen();
                    }
                    
                    public bool IsSetEncodedUnderlyingIssuerLen() 
                    { 
                        return IsSetField(Tags.EncodedUnderlyingIssuerLen);
                    }
                    public QuickFix.Fields.EncodedUnderlyingIssuer encodedUnderlyingIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                    { 
                        this.encodedUnderlyingIssuer = val;
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
                    { 
                        return IsSetEncodedUnderlyingIssuer();
                    }
                    
                    public bool IsSetEncodedUnderlyingIssuer() 
                    { 
                        return IsSetField(Tags.EncodedUnderlyingIssuer);
                    }
                    public QuickFix.Fields.UnderlyingSecurityDesc underlyingSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) 
                    { 
                        this.underlyingSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
                    { 
                        return IsSetUnderlyingSecurityDesc();
                    }
                    
                    public bool IsSetUnderlyingSecurityDesc() 
                    { 
                        return IsSetField(Tags.UnderlyingSecurityDesc);
                    }
                    public QuickFix.Fields.EncodedUnderlyingSecurityDescLen encodedUnderlyingSecurityDescLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                    { 
                        this.encodedUnderlyingSecurityDescLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
                    { 
                        return IsSetEncodedUnderlyingSecurityDescLen();
                    }
                    
                    public bool IsSetEncodedUnderlyingSecurityDescLen() 
                    { 
                        return IsSetField(Tags.EncodedUnderlyingSecurityDescLen);
                    }
                    public QuickFix.Fields.EncodedUnderlyingSecurityDesc encodedUnderlyingSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                    { 
                        this.encodedUnderlyingSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
                    { 
                        return IsSetEncodedUnderlyingSecurityDesc();
                    }
                    
                    public bool IsSetEncodedUnderlyingSecurityDesc() 
                    { 
                        return IsSetField(Tags.EncodedUnderlyingSecurityDesc);
                    }
                    public QuickFix.Fields.UnderlyingCPProgram underlyingCPProgram
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        this.underlyingCPProgram = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) 
                    { 
                        return IsSetUnderlyingCPProgram();
                    }
                    
                    public bool IsSetUnderlyingCPProgram() 
                    { 
                        return IsSetField(Tags.UnderlyingCPProgram);
                    }
                    public QuickFix.Fields.UnderlyingCPRegType underlyingCPRegType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        this.underlyingCPRegType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) 
                    { 
                        return IsSetUnderlyingCPRegType();
                    }
                    
                    public bool IsSetUnderlyingCPRegType() 
                    { 
                        return IsSetField(Tags.UnderlyingCPRegType);
                    }
                    public QuickFix.Fields.UnderlyingCurrency underlyingCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        this.underlyingCurrency = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) 
                    { 
                        return IsSetUnderlyingCurrency();
                    }
                    
                    public bool IsSetUnderlyingCurrency() 
                    { 
                        return IsSetField(Tags.UnderlyingCurrency);
                    }
                    public QuickFix.Fields.UnderlyingQty underlyingQty
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        this.underlyingQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingQty val) 
                    { 
                        return IsSetUnderlyingQty();
                    }
                    
                    public bool IsSetUnderlyingQty() 
                    { 
                        return IsSetField(Tags.UnderlyingQty);
                    }
                    public QuickFix.Fields.UnderlyingPx underlyingPx
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        this.underlyingPx = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPx val) 
                    { 
                        return IsSetUnderlyingPx();
                    }
                    
                    public bool IsSetUnderlyingPx() 
                    { 
                        return IsSetField(Tags.UnderlyingPx);
                    }
                    public QuickFix.Fields.UnderlyingDirtyPrice underlyingDirtyPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        this.underlyingDirtyPrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
                    { 
                        return IsSetUnderlyingDirtyPrice();
                    }
                    
                    public bool IsSetUnderlyingDirtyPrice() 
                    { 
                        return IsSetField(Tags.UnderlyingDirtyPrice);
                    }
                    public QuickFix.Fields.UnderlyingEndPrice underlyingEndPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        this.underlyingEndPrice = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) 
                    { 
                        return IsSetUnderlyingEndPrice();
                    }
                    
                    public bool IsSetUnderlyingEndPrice() 
                    { 
                        return IsSetField(Tags.UnderlyingEndPrice);
                    }
                    public QuickFix.Fields.UnderlyingStartValue underlyingStartValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        this.underlyingStartValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) 
                    { 
                        return IsSetUnderlyingStartValue();
                    }
                    
                    public bool IsSetUnderlyingStartValue() 
                    { 
                        return IsSetField(Tags.UnderlyingStartValue);
                    }
                    public QuickFix.Fields.UnderlyingCurrentValue underlyingCurrentValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        this.underlyingCurrentValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) 
                    { 
                        return IsSetUnderlyingCurrentValue();
                    }
                    
                    public bool IsSetUnderlyingCurrentValue() 
                    { 
                        return IsSetField(Tags.UnderlyingCurrentValue);
                    }
                    public QuickFix.Fields.UnderlyingEndValue underlyingEndValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        this.underlyingEndValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) 
                    { 
                        return IsSetUnderlyingEndValue();
                    }
                    
                    public bool IsSetUnderlyingEndValue() 
                    { 
                        return IsSetField(Tags.UnderlyingEndValue);
                    }
                    public QuickFix.Fields.NoUnderlyingStips noUnderlyingStips
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        this.noUnderlyingStips = val;
                    }
                    
                    public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) 
                    { 
                        return IsSetNoUnderlyingStips();
                    }
                    
                    public bool IsSetNoUnderlyingStips() 
                    { 
                        return IsSetField(Tags.NoUnderlyingStips);
                    }
                    public QuickFix.Fields.UnderlyingAllocationPercent underlyingAllocationPercent
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingAllocationPercent val = new QuickFix.Fields.UnderlyingAllocationPercent();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        this.underlyingAllocationPercent = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAllocationPercent Get(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
                    { 
                        return IsSetUnderlyingAllocationPercent();
                    }
                    
                    public bool IsSetUnderlyingAllocationPercent() 
                    { 
                        return IsSetField(Tags.UnderlyingAllocationPercent);
                    }
                    public QuickFix.Fields.UnderlyingSettlementType underlyingSettlementType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSettlementType val = new QuickFix.Fields.UnderlyingSettlementType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        this.underlyingSettlementType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSettlementType Get(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSettlementType val) 
                    { 
                        return IsSetUnderlyingSettlementType();
                    }
                    
                    public bool IsSetUnderlyingSettlementType() 
                    { 
                        return IsSetField(Tags.UnderlyingSettlementType);
                    }
                    public QuickFix.Fields.UnderlyingCashAmount underlyingCashAmount
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCashAmount val = new QuickFix.Fields.UnderlyingCashAmount();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        this.underlyingCashAmount = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCashAmount Get(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCashAmount val) 
                    { 
                        return IsSetUnderlyingCashAmount();
                    }
                    
                    public bool IsSetUnderlyingCashAmount() 
                    { 
                        return IsSetField(Tags.UnderlyingCashAmount);
                    }
                    public QuickFix.Fields.UnderlyingCashType underlyingCashType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCashType val = new QuickFix.Fields.UnderlyingCashType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        this.underlyingCashType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCashType Get(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCashType val) 
                    { 
                        return IsSetUnderlyingCashType();
                    }
                    
                    public bool IsSetUnderlyingCashType() 
                    { 
                        return IsSetField(Tags.UnderlyingCashType);
                    }
                    public QuickFix.Fields.UnderlyingUnitOfMeasure underlyingUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        this.underlyingUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingUnitOfMeasure Get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
                    { 
                        return IsSetUnderlyingUnitOfMeasure();
                    }
                    
                    public bool IsSetUnderlyingUnitOfMeasure() 
                    { 
                        return IsSetField(Tags.UnderlyingUnitOfMeasure);
                    }
                    public QuickFix.Fields.UnderlyingTimeUnit underlyingTimeUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingTimeUnit val = new QuickFix.Fields.UnderlyingTimeUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        this.underlyingTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingTimeUnit Get(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingTimeUnit val) 
                    { 
                        return IsSetUnderlyingTimeUnit();
                    }
                    
                    public bool IsSetUnderlyingTimeUnit() 
                    { 
                        return IsSetField(Tags.UnderlyingTimeUnit);
                    }
                    public QuickFix.Fields.UnderlyingCapValue underlyingCapValue
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingCapValue val = new QuickFix.Fields.UnderlyingCapValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        this.underlyingCapValue = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingCapValue Get(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingCapValue val) 
                    { 
                        return IsSetUnderlyingCapValue();
                    }
                    
                    public bool IsSetUnderlyingCapValue() 
                    { 
                        return IsSetField(Tags.UnderlyingCapValue);
                    }
                    public QuickFix.Fields.NoUndlyInstrumentParties noUndlyInstrumentParties
                    { 
                        get 
                        {
                            QuickFix.Fields.NoUndlyInstrumentParties val = new QuickFix.Fields.NoUndlyInstrumentParties();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        this.noUndlyInstrumentParties = val;
                    }
                    
                    public QuickFix.Fields.NoUndlyInstrumentParties Get(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
                    { 
                        return IsSetNoUndlyInstrumentParties();
                    }
                    
                    public bool IsSetNoUndlyInstrumentParties() 
                    { 
                        return IsSetField(Tags.NoUndlyInstrumentParties);
                    }
                    public QuickFix.Fields.UnderlyingSettlMethod underlyingSettlMethod
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        this.underlyingSettlMethod = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSettlMethod Get(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSettlMethod val) 
                    { 
                        return IsSetUnderlyingSettlMethod();
                    }
                    
                    public bool IsSetUnderlyingSettlMethod() 
                    { 
                        return IsSetField(Tags.UnderlyingSettlMethod);
                    }
                    public QuickFix.Fields.UnderlyingAdjustedQuantity underlyingAdjustedQuantity
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingAdjustedQuantity val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        this.underlyingAdjustedQuantity = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAdjustedQuantity Get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
                    { 
                        return IsSetUnderlyingAdjustedQuantity();
                    }
                    
                    public bool IsSetUnderlyingAdjustedQuantity() 
                    { 
                        return IsSetField(Tags.UnderlyingAdjustedQuantity);
                    }
                    public QuickFix.Fields.UnderlyingFXRate underlyingFXRate
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingFXRate val = new QuickFix.Fields.UnderlyingFXRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        this.underlyingFXRate = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFXRate Get(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingFXRate val) 
                    { 
                        return IsSetUnderlyingFXRate();
                    }
                    
                    public bool IsSetUnderlyingFXRate() 
                    { 
                        return IsSetField(Tags.UnderlyingFXRate);
                    }
                    public QuickFix.Fields.UnderlyingFXRateCalc underlyingFXRateCalc
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingFXRateCalc val = new QuickFix.Fields.UnderlyingFXRateCalc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        this.underlyingFXRateCalc = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFXRateCalc Get(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
                    { 
                        return IsSetUnderlyingFXRateCalc();
                    }
                    
                    public bool IsSetUnderlyingFXRateCalc() 
                    { 
                        return IsSetField(Tags.UnderlyingFXRateCalc);
                    }
                    public QuickFix.Fields.UnderlyingMaturityTime underlyingMaturityTime
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingMaturityTime val = new QuickFix.Fields.UnderlyingMaturityTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        this.underlyingMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingMaturityTime Get(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingMaturityTime val) 
                    { 
                        return IsSetUnderlyingMaturityTime();
                    }
                    
                    public bool IsSetUnderlyingMaturityTime() 
                    { 
                        return IsSetField(Tags.UnderlyingMaturityTime);
                    }
                    public QuickFix.Fields.UnderlyingPutOrCall underlyingPutOrCall
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPutOrCall val) 
                    { 
                        this.underlyingPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) 
                    { 
                        return IsSetUnderlyingPutOrCall();
                    }
                    
                    public bool IsSetUnderlyingPutOrCall() 
                    { 
                        return IsSetField(Tags.UnderlyingPutOrCall);
                    }
                    public QuickFix.Fields.UnderlyingExerciseStyle underlyingExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingExerciseStyle val = new QuickFix.Fields.UnderlyingExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        this.underlyingExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingExerciseStyle Get(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
                    { 
                        return IsSetUnderlyingExerciseStyle();
                    }
                    
                    public bool IsSetUnderlyingExerciseStyle() 
                    { 
                        return IsSetField(Tags.UnderlyingExerciseStyle);
                    }
                    public QuickFix.Fields.UnderlyingUnitOfMeasureQty underlyingUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        this.underlyingUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
                    { 
                        return IsSetUnderlyingUnitOfMeasureQty();
                    }
                    
                    public bool IsSetUnderlyingUnitOfMeasureQty() 
                    { 
                        return IsSetField(Tags.UnderlyingUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasure underlyingPriceUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingPriceUnitOfMeasure val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        this.underlyingPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasure Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
                    { 
                        return IsSetUnderlyingPriceUnitOfMeasure();
                    }
                    
                    public bool IsSetUnderlyingPriceUnitOfMeasure() 
                    { 
                        return IsSetField(Tags.UnderlyingPriceUnitOfMeasure);
                    }
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty underlyingPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        this.underlyingPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty Get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
                    { 
                        return IsSetUnderlyingPriceUnitOfMeasureQty();
                    }
                    
                    public bool IsSetUnderlyingPriceUnitOfMeasureQty() 
                    { 
                        return IsSetField(Tags.UnderlyingPriceUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.UnderlyingContractMultiplierUnit underlyingContractMultiplierUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingContractMultiplierUnit val = new QuickFix.Fields.UnderlyingContractMultiplierUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        this.underlyingContractMultiplierUnit = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingContractMultiplierUnit Get(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplierUnit val) 
                    { 
                        return IsSetUnderlyingContractMultiplierUnit();
                    }
                    
                    public bool IsSetUnderlyingContractMultiplierUnit() 
                    { 
                        return IsSetField(Tags.UnderlyingContractMultiplierUnit);
                    }
                    public QuickFix.Fields.UnderlyingFlowScheduleType underlyingFlowScheduleType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingFlowScheduleType val = new QuickFix.Fields.UnderlyingFlowScheduleType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        this.underlyingFlowScheduleType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingFlowScheduleType Get(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingFlowScheduleType val) 
                    { 
                        return IsSetUnderlyingFlowScheduleType();
                    }
                    
                    public bool IsSetUnderlyingFlowScheduleType() 
                    { 
                        return IsSetField(Tags.UnderlyingFlowScheduleType);
                    }
                    public QuickFix.Fields.UnderlyingRestructuringType underlyingRestructuringType
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingRestructuringType val = new QuickFix.Fields.UnderlyingRestructuringType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        this.underlyingRestructuringType = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingRestructuringType Get(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingRestructuringType val) 
                    { 
                        return IsSetUnderlyingRestructuringType();
                    }
                    
                    public bool IsSetUnderlyingRestructuringType() 
                    { 
                        return IsSetField(Tags.UnderlyingRestructuringType);
                    }
                    public QuickFix.Fields.UnderlyingSeniority underlyingSeniority
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingSeniority val = new QuickFix.Fields.UnderlyingSeniority();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        this.underlyingSeniority = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingSeniority Get(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingSeniority val) 
                    { 
                        return IsSetUnderlyingSeniority();
                    }
                    
                    public bool IsSetUnderlyingSeniority() 
                    { 
                        return IsSetField(Tags.UnderlyingSeniority);
                    }
                    public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding underlyingNotionalPercentageOutstanding
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val = new QuickFix.Fields.UnderlyingNotionalPercentageOutstanding();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        this.underlyingNotionalPercentageOutstanding = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingNotionalPercentageOutstanding Get(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingNotionalPercentageOutstanding val) 
                    { 
                        return IsSetUnderlyingNotionalPercentageOutstanding();
                    }
                    
                    public bool IsSetUnderlyingNotionalPercentageOutstanding() 
                    { 
                        return IsSetField(Tags.UnderlyingNotionalPercentageOutstanding);
                    }
                    public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding underlyingOriginalNotionalPercentageOutstanding
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val = new QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        this.underlyingOriginalNotionalPercentageOutstanding = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding Get(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingOriginalNotionalPercentageOutstanding val) 
                    { 
                        return IsSetUnderlyingOriginalNotionalPercentageOutstanding();
                    }
                    
                    public bool IsSetUnderlyingOriginalNotionalPercentageOutstanding() 
                    { 
                        return IsSetField(Tags.UnderlyingOriginalNotionalPercentageOutstanding);
                    }
                    public QuickFix.Fields.UnderlyingAttachmentPoint underlyingAttachmentPoint
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingAttachmentPoint val = new QuickFix.Fields.UnderlyingAttachmentPoint();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        this.underlyingAttachmentPoint = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingAttachmentPoint Get(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingAttachmentPoint val) 
                    { 
                        return IsSetUnderlyingAttachmentPoint();
                    }
                    
                    public bool IsSetUnderlyingAttachmentPoint() 
                    { 
                        return IsSetField(Tags.UnderlyingAttachmentPoint);
                    }
                    public QuickFix.Fields.UnderlyingDetachmentPoint underlyingDetachmentPoint
                    { 
                        get 
                        {
                            QuickFix.Fields.UnderlyingDetachmentPoint val = new QuickFix.Fields.UnderlyingDetachmentPoint();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        this.underlyingDetachmentPoint = val;
                    }
                    
                    public QuickFix.Fields.UnderlyingDetachmentPoint Get(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.UnderlyingDetachmentPoint val) 
                    { 
                        return IsSetUnderlyingDetachmentPoint();
                    }
                    
                    public bool IsSetUnderlyingDetachmentPoint() 
                    { 
                        return IsSetField(Tags.UnderlyingDetachmentPoint);
                    }
                                    public class NoUnderlyingSecurityAltID : Group
                    {
                        public NoUnderlyingSecurityAltID() 
                          :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
                                            public QuickFix.Fields.UnderlyingSecurityAltID underlyingSecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            this.underlyingSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                        { 
                            return IsSetUnderlyingSecurityAltID();
                        }
                        
                        public bool IsSetUnderlyingSecurityAltID() 
                        { 
                            return IsSetField(Tags.UnderlyingSecurityAltID);
                        }
                        public QuickFix.Fields.UnderlyingSecurityAltIDSource underlyingSecurityAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            this.underlyingSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                        { 
                            return IsSetUnderlyingSecurityAltIDSource();
                        }
                        
                        public bool IsSetUnderlyingSecurityAltIDSource() 
                        { 
                            return IsSetField(Tags.UnderlyingSecurityAltIDSource);
                        }
                    
                    }
                    public class NoUnderlyingStips : Group
                    {
                        public NoUnderlyingStips() 
                          :base( Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};
                                            public QuickFix.Fields.UnderlyingStipType underlyingStipType
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            this.underlyingStipType = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingStipType val) 
                        { 
                            return IsSetUnderlyingStipType();
                        }
                        
                        public bool IsSetUnderlyingStipType() 
                        { 
                            return IsSetField(Tags.UnderlyingStipType);
                        }
                        public QuickFix.Fields.UnderlyingStipValue underlyingStipValue
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            this.underlyingStipValue = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) 
                        { 
                            return IsSetUnderlyingStipValue();
                        }
                        
                        public bool IsSetUnderlyingStipValue() 
                        { 
                            return IsSetField(Tags.UnderlyingStipValue);
                        }
                    
                    }
                    public class NoUndlyInstrumentParties : Group
                    {
                        public NoUndlyInstrumentParties() 
                          :base( Tags.NoUndlyInstrumentParties, Tags.UnderlyingInstrumentPartyID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
                                            public QuickFix.Fields.UnderlyingInstrumentPartyID underlyingInstrumentPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingInstrumentPartyID val = new QuickFix.Fields.UnderlyingInstrumentPartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            this.underlyingInstrumentPartyID = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyID Get(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyID val) 
                        { 
                            return IsSetUnderlyingInstrumentPartyID();
                        }
                        
                        public bool IsSetUnderlyingInstrumentPartyID() 
                        { 
                            return IsSetField(Tags.UnderlyingInstrumentPartyID);
                        }
                        public QuickFix.Fields.UnderlyingInstrumentPartyIDSource underlyingInstrumentPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingInstrumentPartyIDSource val = new QuickFix.Fields.UnderlyingInstrumentPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            this.underlyingInstrumentPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyIDSource Get(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyIDSource val) 
                        { 
                            return IsSetUnderlyingInstrumentPartyIDSource();
                        }
                        
                        public bool IsSetUnderlyingInstrumentPartyIDSource() 
                        { 
                            return IsSetField(Tags.UnderlyingInstrumentPartyIDSource);
                        }
                        public QuickFix.Fields.UnderlyingInstrumentPartyRole underlyingInstrumentPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.UnderlyingInstrumentPartyRole val = new QuickFix.Fields.UnderlyingInstrumentPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            this.underlyingInstrumentPartyRole = val;
                        }
                        
                        public QuickFix.Fields.UnderlyingInstrumentPartyRole Get(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartyRole val) 
                        { 
                            return IsSetUnderlyingInstrumentPartyRole();
                        }
                        
                        public bool IsSetUnderlyingInstrumentPartyRole() 
                        { 
                            return IsSetField(Tags.UnderlyingInstrumentPartyRole);
                        }
                        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs noUndlyInstrumentPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoUndlyInstrumentPartySubIDs val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            this.noUndlyInstrumentPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoUndlyInstrumentPartySubIDs Get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                        { 
                            return IsSetNoUndlyInstrumentPartySubIDs();
                        }
                        
                        public bool IsSetNoUndlyInstrumentPartySubIDs() 
                        { 
                            return IsSetField(Tags.NoUndlyInstrumentPartySubIDs);
                        }
                                            public class NoUndlyInstrumentPartySubIDs : Group
                        {
                            public NoUndlyInstrumentPartySubIDs() 
                              :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UnderlyingInstrumentPartySubID, fieldOrder)
                            {
                            }
                            public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0};
                                                    public QuickFix.Fields.UnderlyingInstrumentPartySubID underlyingInstrumentPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.UnderlyingInstrumentPartySubID val = new QuickFix.Fields.UnderlyingInstrumentPartySubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                this.underlyingInstrumentPartySubID = val;
                            }
                            
                            public QuickFix.Fields.UnderlyingInstrumentPartySubID Get(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartySubID val) 
                            { 
                                return IsSetUnderlyingInstrumentPartySubID();
                            }
                            
                            public bool IsSetUnderlyingInstrumentPartySubID() 
                            { 
                                return IsSetField(Tags.UnderlyingInstrumentPartySubID);
                            }
                            public QuickFix.Fields.UnderlyingInstrumentPartySubIDType underlyingInstrumentPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.UnderlyingInstrumentPartySubIDType val = new QuickFix.Fields.UnderlyingInstrumentPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                this.underlyingInstrumentPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.UnderlyingInstrumentPartySubIDType Get(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.UnderlyingInstrumentPartySubIDType val) 
                            { 
                                return IsSetUnderlyingInstrumentPartySubIDType();
                            }
                            
                            public bool IsSetUnderlyingInstrumentPartySubIDType() 
                            { 
                                return IsSetField(Tags.UnderlyingInstrumentPartySubIDType);
                            }
                        
                        }
                    }
                }
                public class NoStipulations : Group
                {
                    public NoStipulations() 
                      :base( Tags.NoStipulations, Tags.StipulationType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};
                                    public QuickFix.Fields.StipulationType stipulationType
                    { 
                        get 
                        {
                            QuickFix.Fields.StipulationType val = new QuickFix.Fields.StipulationType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StipulationType val) 
                    { 
                        this.stipulationType = val;
                    }
                    
                    public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StipulationType val) 
                    { 
                        return IsSetStipulationType();
                    }
                    
                    public bool IsSetStipulationType() 
                    { 
                        return IsSetField(Tags.StipulationType);
                    }
                    public QuickFix.Fields.StipulationValue stipulationValue
                    { 
                        get 
                        {
                            QuickFix.Fields.StipulationValue val = new QuickFix.Fields.StipulationValue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.StipulationValue val) 
                    { 
                        this.stipulationValue = val;
                    }
                    
                    public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.StipulationValue val) 
                    { 
                        return IsSetStipulationValue();
                    }
                    
                    public bool IsSetStipulationValue() 
                    { 
                        return IsSetField(Tags.StipulationValue);
                    }
                
                }
                public class NoLegs : Group
                {
                    public NoLegs() 
                      :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, Tags.LegContractMultiplierUnit, Tags.LegFlowScheduleType, Tags.LegQty, Tags.LegSwapType, Tags.LegSettlType, Tags.LegSettlDate, Tags.NoLegStipulations, Tags.NoNestedPartyIDs, Tags.LegBenchmarkCurveCurrency, Tags.LegBenchmarkCurveName, Tags.LegBenchmarkCurvePoint, Tags.LegBenchmarkPrice, Tags.LegBenchmarkPriceType, Tags.LegOrderQty, Tags.LegRefID, 0};
                                    public QuickFix.Fields.LegSymbol legSymbol
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSymbol val) 
                    { 
                        this.legSymbol = val;
                    }
                    
                    public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSymbol val) 
                    { 
                        return IsSetLegSymbol();
                    }
                    
                    public bool IsSetLegSymbol() 
                    { 
                        return IsSetField(Tags.LegSymbol);
                    }
                    public QuickFix.Fields.LegSymbolSfx legSymbolSfx
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        this.legSymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        return IsSetLegSymbolSfx();
                    }
                    
                    public bool IsSetLegSymbolSfx() 
                    { 
                        return IsSetField(Tags.LegSymbolSfx);
                    }
                    public QuickFix.Fields.LegSecurityID legSecurityID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityID val) 
                    { 
                        this.legSecurityID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityID val) 
                    { 
                        return IsSetLegSecurityID();
                    }
                    
                    public bool IsSetLegSecurityID() 
                    { 
                        return IsSetField(Tags.LegSecurityID);
                    }
                    public QuickFix.Fields.LegSecurityIDSource legSecurityIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        this.legSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        return IsSetLegSecurityIDSource();
                    }
                    
                    public bool IsSetLegSecurityIDSource() 
                    { 
                        return IsSetField(Tags.LegSecurityIDSource);
                    }
                    public QuickFix.Fields.NoLegSecurityAltID noLegSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        this.noLegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        return IsSetNoLegSecurityAltID();
                    }
                    
                    public bool IsSetNoLegSecurityAltID() 
                    { 
                        return IsSetField(Tags.NoLegSecurityAltID);
                    }
                    public QuickFix.Fields.LegProduct legProduct
                    { 
                        get 
                        {
                            QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegProduct val) 
                    { 
                        this.legProduct = val;
                    }
                    
                    public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegProduct val) 
                    { 
                        return IsSetLegProduct();
                    }
                    
                    public bool IsSetLegProduct() 
                    { 
                        return IsSetField(Tags.LegProduct);
                    }
                    public QuickFix.Fields.LegCFICode legCFICode
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCFICode val) 
                    { 
                        this.legCFICode = val;
                    }
                    
                    public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCFICode val) 
                    { 
                        return IsSetLegCFICode();
                    }
                    
                    public bool IsSetLegCFICode() 
                    { 
                        return IsSetField(Tags.LegCFICode);
                    }
                    public QuickFix.Fields.LegSecurityType legSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityType val) 
                    { 
                        this.legSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityType val) 
                    { 
                        return IsSetLegSecurityType();
                    }
                    
                    public bool IsSetLegSecurityType() 
                    { 
                        return IsSetField(Tags.LegSecurityType);
                    }
                    public QuickFix.Fields.LegSecuritySubType legSecuritySubType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        this.legSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        return IsSetLegSecuritySubType();
                    }
                    
                    public bool IsSetLegSecuritySubType() 
                    { 
                        return IsSetField(Tags.LegSecuritySubType);
                    }
                    public QuickFix.Fields.LegMaturityMonthYear legMaturityMonthYear
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        this.legMaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        return IsSetLegMaturityMonthYear();
                    }
                    
                    public bool IsSetLegMaturityMonthYear() 
                    { 
                        return IsSetField(Tags.LegMaturityMonthYear);
                    }
                    public QuickFix.Fields.LegMaturityDate legMaturityDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        this.legMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        return IsSetLegMaturityDate();
                    }
                    
                    public bool IsSetLegMaturityDate() 
                    { 
                        return IsSetField(Tags.LegMaturityDate);
                    }
                    public QuickFix.Fields.LegCouponPaymentDate legCouponPaymentDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        this.legCouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        return IsSetLegCouponPaymentDate();
                    }
                    
                    public bool IsSetLegCouponPaymentDate() 
                    { 
                        return IsSetField(Tags.LegCouponPaymentDate);
                    }
                    public QuickFix.Fields.LegIssueDate legIssueDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegIssueDate val) 
                    { 
                        this.legIssueDate = val;
                    }
                    
                    public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegIssueDate val) 
                    { 
                        return IsSetLegIssueDate();
                    }
                    
                    public bool IsSetLegIssueDate() 
                    { 
                        return IsSetField(Tags.LegIssueDate);
                    }
                    public QuickFix.Fields.LegRepoCollateralSecurityType legRepoCollateralSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        this.legRepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        return IsSetLegRepoCollateralSecurityType();
                    }
                    
                    public bool IsSetLegRepoCollateralSecurityType() 
                    { 
                        return IsSetField(Tags.LegRepoCollateralSecurityType);
                    }
                    public QuickFix.Fields.LegRepurchaseTerm legRepurchaseTerm
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        this.legRepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        return IsSetLegRepurchaseTerm();
                    }
                    
                    public bool IsSetLegRepurchaseTerm() 
                    { 
                        return IsSetField(Tags.LegRepurchaseTerm);
                    }
                    public QuickFix.Fields.LegRepurchaseRate legRepurchaseRate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        this.legRepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        return IsSetLegRepurchaseRate();
                    }
                    
                    public bool IsSetLegRepurchaseRate() 
                    { 
                        return IsSetField(Tags.LegRepurchaseRate);
                    }
                    public QuickFix.Fields.LegFactor legFactor
                    { 
                        get 
                        {
                            QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegFactor val) 
                    { 
                        this.legFactor = val;
                    }
                    
                    public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegFactor val) 
                    { 
                        return IsSetLegFactor();
                    }
                    
                    public bool IsSetLegFactor() 
                    { 
                        return IsSetField(Tags.LegFactor);
                    }
                    public QuickFix.Fields.LegCreditRating legCreditRating
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCreditRating val) 
                    { 
                        this.legCreditRating = val;
                    }
                    
                    public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCreditRating val) 
                    { 
                        return IsSetLegCreditRating();
                    }
                    
                    public bool IsSetLegCreditRating() 
                    { 
                        return IsSetField(Tags.LegCreditRating);
                    }
                    public QuickFix.Fields.LegInstrRegistry legInstrRegistry
                    { 
                        get 
                        {
                            QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        this.legInstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        return IsSetLegInstrRegistry();
                    }
                    
                    public bool IsSetLegInstrRegistry() 
                    { 
                        return IsSetField(Tags.LegInstrRegistry);
                    }
                    public QuickFix.Fields.LegCountryOfIssue legCountryOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        this.legCountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        return IsSetLegCountryOfIssue();
                    }
                    
                    public bool IsSetLegCountryOfIssue() 
                    { 
                        return IsSetField(Tags.LegCountryOfIssue);
                    }
                    public QuickFix.Fields.LegStateOrProvinceOfIssue legStateOrProvinceOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        this.legStateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        return IsSetLegStateOrProvinceOfIssue();
                    }
                    
                    public bool IsSetLegStateOrProvinceOfIssue() 
                    { 
                        return IsSetField(Tags.LegStateOrProvinceOfIssue);
                    }
                    public QuickFix.Fields.LegLocaleOfIssue legLocaleOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        this.legLocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        return IsSetLegLocaleOfIssue();
                    }
                    
                    public bool IsSetLegLocaleOfIssue() 
                    { 
                        return IsSetField(Tags.LegLocaleOfIssue);
                    }
                    public QuickFix.Fields.LegRedemptionDate legRedemptionDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        this.legRedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        return IsSetLegRedemptionDate();
                    }
                    
                    public bool IsSetLegRedemptionDate() 
                    { 
                        return IsSetField(Tags.LegRedemptionDate);
                    }
                    public QuickFix.Fields.LegStrikePrice legStrikePrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        this.legStrikePrice = val;
                    }
                    
                    public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        return IsSetLegStrikePrice();
                    }
                    
                    public bool IsSetLegStrikePrice() 
                    { 
                        return IsSetField(Tags.LegStrikePrice);
                    }
                    public QuickFix.Fields.LegStrikeCurrency legStrikeCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStrikeCurrency val = new QuickFix.Fields.LegStrikeCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        this.legStrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        return IsSetLegStrikeCurrency();
                    }
                    
                    public bool IsSetLegStrikeCurrency() 
                    { 
                        return IsSetField(Tags.LegStrikeCurrency);
                    }
                    public QuickFix.Fields.LegOptAttribute legOptAttribute
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        this.legOptAttribute = val;
                    }
                    
                    public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        return IsSetLegOptAttribute();
                    }
                    
                    public bool IsSetLegOptAttribute() 
                    { 
                        return IsSetField(Tags.LegOptAttribute);
                    }
                    public QuickFix.Fields.LegContractMultiplier legContractMultiplier
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        this.legContractMultiplier = val;
                    }
                    
                    public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        return IsSetLegContractMultiplier();
                    }
                    
                    public bool IsSetLegContractMultiplier() 
                    { 
                        return IsSetField(Tags.LegContractMultiplier);
                    }
                    public QuickFix.Fields.LegCouponRate legCouponRate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCouponRate val) 
                    { 
                        this.legCouponRate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCouponRate val) 
                    { 
                        return IsSetLegCouponRate();
                    }
                    
                    public bool IsSetLegCouponRate() 
                    { 
                        return IsSetField(Tags.LegCouponRate);
                    }
                    public QuickFix.Fields.LegSecurityExchange legSecurityExchange
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        this.legSecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        return IsSetLegSecurityExchange();
                    }
                    
                    public bool IsSetLegSecurityExchange() 
                    { 
                        return IsSetField(Tags.LegSecurityExchange);
                    }
                    public QuickFix.Fields.LegIssuer legIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegIssuer val) 
                    { 
                        this.legIssuer = val;
                    }
                    
                    public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegIssuer val) 
                    { 
                        return IsSetLegIssuer();
                    }
                    
                    public bool IsSetLegIssuer() 
                    { 
                        return IsSetField(Tags.LegIssuer);
                    }
                    public QuickFix.Fields.EncodedLegIssuerLen encodedLegIssuerLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        this.encodedLegIssuerLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        return IsSetEncodedLegIssuerLen();
                    }
                    
                    public bool IsSetEncodedLegIssuerLen() 
                    { 
                        return IsSetField(Tags.EncodedLegIssuerLen);
                    }
                    public QuickFix.Fields.EncodedLegIssuer encodedLegIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        this.encodedLegIssuer = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        return IsSetEncodedLegIssuer();
                    }
                    
                    public bool IsSetEncodedLegIssuer() 
                    { 
                        return IsSetField(Tags.EncodedLegIssuer);
                    }
                    public QuickFix.Fields.LegSecurityDesc legSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        this.legSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        return IsSetLegSecurityDesc();
                    }
                    
                    public bool IsSetLegSecurityDesc() 
                    { 
                        return IsSetField(Tags.LegSecurityDesc);
                    }
                    public QuickFix.Fields.EncodedLegSecurityDescLen encodedLegSecurityDescLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        this.encodedLegSecurityDescLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        return IsSetEncodedLegSecurityDescLen();
                    }
                    
                    public bool IsSetEncodedLegSecurityDescLen() 
                    { 
                        return IsSetField(Tags.EncodedLegSecurityDescLen);
                    }
                    public QuickFix.Fields.EncodedLegSecurityDesc encodedLegSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        this.encodedLegSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        return IsSetEncodedLegSecurityDesc();
                    }
                    
                    public bool IsSetEncodedLegSecurityDesc() 
                    { 
                        return IsSetField(Tags.EncodedLegSecurityDesc);
                    }
                    public QuickFix.Fields.LegRatioQty legRatioQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRatioQty val) 
                    { 
                        this.legRatioQty = val;
                    }
                    
                    public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRatioQty val) 
                    { 
                        return IsSetLegRatioQty();
                    }
                    
                    public bool IsSetLegRatioQty() 
                    { 
                        return IsSetField(Tags.LegRatioQty);
                    }
                    public QuickFix.Fields.LegSide legSide
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSide val) 
                    { 
                        this.legSide = val;
                    }
                    
                    public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSide val) 
                    { 
                        return IsSetLegSide();
                    }
                    
                    public bool IsSetLegSide() 
                    { 
                        return IsSetField(Tags.LegSide);
                    }
                    public QuickFix.Fields.LegCurrency legCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCurrency val = new QuickFix.Fields.LegCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegCurrency val) 
                    { 
                        this.legCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegCurrency val) 
                    { 
                        return IsSetLegCurrency();
                    }
                    
                    public bool IsSetLegCurrency() 
                    { 
                        return IsSetField(Tags.LegCurrency);
                    }
                    public QuickFix.Fields.LegPool legPool
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPool val = new QuickFix.Fields.LegPool();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPool val) 
                    { 
                        this.legPool = val;
                    }
                    
                    public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPool val) 
                    { 
                        return IsSetLegPool();
                    }
                    
                    public bool IsSetLegPool() 
                    { 
                        return IsSetField(Tags.LegPool);
                    }
                    public QuickFix.Fields.LegDatedDate legDatedDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegDatedDate val = new QuickFix.Fields.LegDatedDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegDatedDate val) 
                    { 
                        this.legDatedDate = val;
                    }
                    
                    public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegDatedDate val) 
                    { 
                        return IsSetLegDatedDate();
                    }
                    
                    public bool IsSetLegDatedDate() 
                    { 
                        return IsSetField(Tags.LegDatedDate);
                    }
                    public QuickFix.Fields.LegContractSettlMonth legContractSettlMonth
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractSettlMonth val = new QuickFix.Fields.LegContractSettlMonth();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        this.legContractSettlMonth = val;
                    }
                    
                    public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        return IsSetLegContractSettlMonth();
                    }
                    
                    public bool IsSetLegContractSettlMonth() 
                    { 
                        return IsSetField(Tags.LegContractSettlMonth);
                    }
                    public QuickFix.Fields.LegInterestAccrualDate legInterestAccrualDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegInterestAccrualDate val = new QuickFix.Fields.LegInterestAccrualDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        this.legInterestAccrualDate = val;
                    }
                    
                    public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        return IsSetLegInterestAccrualDate();
                    }
                    
                    public bool IsSetLegInterestAccrualDate() 
                    { 
                        return IsSetField(Tags.LegInterestAccrualDate);
                    }
                    public QuickFix.Fields.LegUnitOfMeasure legUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.LegUnitOfMeasure val = new QuickFix.Fields.LegUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        this.legUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasure Get(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        return IsSetLegUnitOfMeasure();
                    }
                    
                    public bool IsSetLegUnitOfMeasure() 
                    { 
                        return IsSetField(Tags.LegUnitOfMeasure);
                    }
                    public QuickFix.Fields.LegTimeUnit legTimeUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.LegTimeUnit val = new QuickFix.Fields.LegTimeUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        this.legTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.LegTimeUnit Get(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        return IsSetLegTimeUnit();
                    }
                    
                    public bool IsSetLegTimeUnit() 
                    { 
                        return IsSetField(Tags.LegTimeUnit);
                    }
                    public QuickFix.Fields.LegOptionRatio legOptionRatio
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOptionRatio val = new QuickFix.Fields.LegOptionRatio();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        this.legOptionRatio = val;
                    }
                    
                    public QuickFix.Fields.LegOptionRatio Get(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        return IsSetLegOptionRatio();
                    }
                    
                    public bool IsSetLegOptionRatio() 
                    { 
                        return IsSetField(Tags.LegOptionRatio);
                    }
                    public QuickFix.Fields.LegPrice legPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPrice val = new QuickFix.Fields.LegPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPrice val) 
                    { 
                        this.legPrice = val;
                    }
                    
                    public QuickFix.Fields.LegPrice Get(QuickFix.Fields.LegPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPrice val) 
                    { 
                        return IsSetLegPrice();
                    }
                    
                    public bool IsSetLegPrice() 
                    { 
                        return IsSetField(Tags.LegPrice);
                    }
                    public QuickFix.Fields.LegMaturityTime legMaturityTime
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityTime val = new QuickFix.Fields.LegMaturityTime();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        this.legMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityTime Get(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        return IsSetLegMaturityTime();
                    }
                    
                    public bool IsSetLegMaturityTime() 
                    { 
                        return IsSetField(Tags.LegMaturityTime);
                    }
                    public QuickFix.Fields.LegPutOrCall legPutOrCall
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPutOrCall val = new QuickFix.Fields.LegPutOrCall();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        this.legPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.LegPutOrCall Get(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        return IsSetLegPutOrCall();
                    }
                    
                    public bool IsSetLegPutOrCall() 
                    { 
                        return IsSetField(Tags.LegPutOrCall);
                    }
                    public QuickFix.Fields.LegExerciseStyle legExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.LegExerciseStyle val = new QuickFix.Fields.LegExerciseStyle();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        this.legExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.LegExerciseStyle Get(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        return IsSetLegExerciseStyle();
                    }
                    
                    public bool IsSetLegExerciseStyle() 
                    { 
                        return IsSetField(Tags.LegExerciseStyle);
                    }
                    public QuickFix.Fields.LegUnitOfMeasureQty legUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegUnitOfMeasureQty val = new QuickFix.Fields.LegUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        this.legUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasureQty Get(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        return IsSetLegUnitOfMeasureQty();
                    }
                    
                    public bool IsSetLegUnitOfMeasureQty() 
                    { 
                        return IsSetField(Tags.LegUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.LegPriceUnitOfMeasure legPriceUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPriceUnitOfMeasure val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        this.legPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasure Get(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        return IsSetLegPriceUnitOfMeasure();
                    }
                    
                    public bool IsSetLegPriceUnitOfMeasure() 
                    { 
                        return IsSetField(Tags.LegPriceUnitOfMeasure);
                    }
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty legPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPriceUnitOfMeasureQty val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        this.legPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty Get(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        return IsSetLegPriceUnitOfMeasureQty();
                    }
                    
                    public bool IsSetLegPriceUnitOfMeasureQty() 
                    { 
                        return IsSetField(Tags.LegPriceUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.LegContractMultiplierUnit legContractMultiplierUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractMultiplierUnit val = new QuickFix.Fields.LegContractMultiplierUnit();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegContractMultiplierUnit val) 
                    { 
                        this.legContractMultiplierUnit = val;
                    }
                    
                    public QuickFix.Fields.LegContractMultiplierUnit Get(QuickFix.Fields.LegContractMultiplierUnit val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegContractMultiplierUnit val) 
                    { 
                        return IsSetLegContractMultiplierUnit();
                    }
                    
                    public bool IsSetLegContractMultiplierUnit() 
                    { 
                        return IsSetField(Tags.LegContractMultiplierUnit);
                    }
                    public QuickFix.Fields.LegFlowScheduleType legFlowScheduleType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegFlowScheduleType val = new QuickFix.Fields.LegFlowScheduleType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegFlowScheduleType val) 
                    { 
                        this.legFlowScheduleType = val;
                    }
                    
                    public QuickFix.Fields.LegFlowScheduleType Get(QuickFix.Fields.LegFlowScheduleType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegFlowScheduleType val) 
                    { 
                        return IsSetLegFlowScheduleType();
                    }
                    
                    public bool IsSetLegFlowScheduleType() 
                    { 
                        return IsSetField(Tags.LegFlowScheduleType);
                    }
                    public QuickFix.Fields.LegQty legQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegQty val = new QuickFix.Fields.LegQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegQty val) 
                    { 
                        this.legQty = val;
                    }
                    
                    public QuickFix.Fields.LegQty Get(QuickFix.Fields.LegQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegQty val) 
                    { 
                        return IsSetLegQty();
                    }
                    
                    public bool IsSetLegQty() 
                    { 
                        return IsSetField(Tags.LegQty);
                    }
                    public QuickFix.Fields.LegSwapType legSwapType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSwapType val = new QuickFix.Fields.LegSwapType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSwapType val) 
                    { 
                        this.legSwapType = val;
                    }
                    
                    public QuickFix.Fields.LegSwapType Get(QuickFix.Fields.LegSwapType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSwapType val) 
                    { 
                        return IsSetLegSwapType();
                    }
                    
                    public bool IsSetLegSwapType() 
                    { 
                        return IsSetField(Tags.LegSwapType);
                    }
                    public QuickFix.Fields.LegSettlType legSettlType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSettlType val = new QuickFix.Fields.LegSettlType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSettlType val) 
                    { 
                        this.legSettlType = val;
                    }
                    
                    public QuickFix.Fields.LegSettlType Get(QuickFix.Fields.LegSettlType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSettlType val) 
                    { 
                        return IsSetLegSettlType();
                    }
                    
                    public bool IsSetLegSettlType() 
                    { 
                        return IsSetField(Tags.LegSettlType);
                    }
                    public QuickFix.Fields.LegSettlDate legSettlDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSettlDate val = new QuickFix.Fields.LegSettlDate();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegSettlDate val) 
                    { 
                        this.legSettlDate = val;
                    }
                    
                    public QuickFix.Fields.LegSettlDate Get(QuickFix.Fields.LegSettlDate val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegSettlDate val) 
                    { 
                        return IsSetLegSettlDate();
                    }
                    
                    public bool IsSetLegSettlDate() 
                    { 
                        return IsSetField(Tags.LegSettlDate);
                    }
                    public QuickFix.Fields.NoLegStipulations noLegStipulations
                    { 
                        get 
                        {
                            QuickFix.Fields.NoLegStipulations val = new QuickFix.Fields.NoLegStipulations();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoLegStipulations val) 
                    { 
                        this.noLegStipulations = val;
                    }
                    
                    public QuickFix.Fields.NoLegStipulations Get(QuickFix.Fields.NoLegStipulations val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoLegStipulations val) 
                    { 
                        return IsSetNoLegStipulations();
                    }
                    
                    public bool IsSetNoLegStipulations() 
                    { 
                        return IsSetField(Tags.NoLegStipulations);
                    }
                    public QuickFix.Fields.NoNestedPartyIDs noNestedPartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoNestedPartyIDs val = new QuickFix.Fields.NoNestedPartyIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        this.noNestedPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) 
                    { 
                        return IsSetNoNestedPartyIDs();
                    }
                    
                    public bool IsSetNoNestedPartyIDs() 
                    { 
                        return IsSetField(Tags.NoNestedPartyIDs);
                    }
                    public QuickFix.Fields.LegBenchmarkCurveCurrency legBenchmarkCurveCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegBenchmarkCurveCurrency val = new QuickFix.Fields.LegBenchmarkCurveCurrency();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkCurveCurrency val) 
                    { 
                        this.legBenchmarkCurveCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurveCurrency Get(QuickFix.Fields.LegBenchmarkCurveCurrency val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkCurveCurrency val) 
                    { 
                        return IsSetLegBenchmarkCurveCurrency();
                    }
                    
                    public bool IsSetLegBenchmarkCurveCurrency() 
                    { 
                        return IsSetField(Tags.LegBenchmarkCurveCurrency);
                    }
                    public QuickFix.Fields.LegBenchmarkCurveName legBenchmarkCurveName
                    { 
                        get 
                        {
                            QuickFix.Fields.LegBenchmarkCurveName val = new QuickFix.Fields.LegBenchmarkCurveName();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkCurveName val) 
                    { 
                        this.legBenchmarkCurveName = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurveName Get(QuickFix.Fields.LegBenchmarkCurveName val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkCurveName val) 
                    { 
                        return IsSetLegBenchmarkCurveName();
                    }
                    
                    public bool IsSetLegBenchmarkCurveName() 
                    { 
                        return IsSetField(Tags.LegBenchmarkCurveName);
                    }
                    public QuickFix.Fields.LegBenchmarkCurvePoint legBenchmarkCurvePoint
                    { 
                        get 
                        {
                            QuickFix.Fields.LegBenchmarkCurvePoint val = new QuickFix.Fields.LegBenchmarkCurvePoint();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkCurvePoint val) 
                    { 
                        this.legBenchmarkCurvePoint = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkCurvePoint Get(QuickFix.Fields.LegBenchmarkCurvePoint val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkCurvePoint val) 
                    { 
                        return IsSetLegBenchmarkCurvePoint();
                    }
                    
                    public bool IsSetLegBenchmarkCurvePoint() 
                    { 
                        return IsSetField(Tags.LegBenchmarkCurvePoint);
                    }
                    public QuickFix.Fields.LegBenchmarkPrice legBenchmarkPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegBenchmarkPrice val = new QuickFix.Fields.LegBenchmarkPrice();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkPrice val) 
                    { 
                        this.legBenchmarkPrice = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkPrice Get(QuickFix.Fields.LegBenchmarkPrice val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkPrice val) 
                    { 
                        return IsSetLegBenchmarkPrice();
                    }
                    
                    public bool IsSetLegBenchmarkPrice() 
                    { 
                        return IsSetField(Tags.LegBenchmarkPrice);
                    }
                    public QuickFix.Fields.LegBenchmarkPriceType legBenchmarkPriceType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegBenchmarkPriceType val = new QuickFix.Fields.LegBenchmarkPriceType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegBenchmarkPriceType val) 
                    { 
                        this.legBenchmarkPriceType = val;
                    }
                    
                    public QuickFix.Fields.LegBenchmarkPriceType Get(QuickFix.Fields.LegBenchmarkPriceType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegBenchmarkPriceType val) 
                    { 
                        return IsSetLegBenchmarkPriceType();
                    }
                    
                    public bool IsSetLegBenchmarkPriceType() 
                    { 
                        return IsSetField(Tags.LegBenchmarkPriceType);
                    }
                    public QuickFix.Fields.LegOrderQty legOrderQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOrderQty val = new QuickFix.Fields.LegOrderQty();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegOrderQty val) 
                    { 
                        this.legOrderQty = val;
                    }
                    
                    public QuickFix.Fields.LegOrderQty Get(QuickFix.Fields.LegOrderQty val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegOrderQty val) 
                    { 
                        return IsSetLegOrderQty();
                    }
                    
                    public bool IsSetLegOrderQty() 
                    { 
                        return IsSetField(Tags.LegOrderQty);
                    }
                    public QuickFix.Fields.LegRefID legRefID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRefID val = new QuickFix.Fields.LegRefID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.LegRefID val) 
                    { 
                        this.legRefID = val;
                    }
                    
                    public QuickFix.Fields.LegRefID Get(QuickFix.Fields.LegRefID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.LegRefID val) 
                    { 
                        return IsSetLegRefID();
                    }
                    
                    public bool IsSetLegRefID() 
                    { 
                        return IsSetField(Tags.LegRefID);
                    }
                                    public class NoLegSecurityAltID : Group
                    {
                        public NoLegSecurityAltID() 
                          :base( Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};
                                            public QuickFix.Fields.LegSecurityAltID legSecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            this.legSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            return IsSetLegSecurityAltID();
                        }
                        
                        public bool IsSetLegSecurityAltID() 
                        { 
                            return IsSetField(Tags.LegSecurityAltID);
                        }
                        public QuickFix.Fields.LegSecurityAltIDSource legSecurityAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            this.legSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            return IsSetLegSecurityAltIDSource();
                        }
                        
                        public bool IsSetLegSecurityAltIDSource() 
                        { 
                            return IsSetField(Tags.LegSecurityAltIDSource);
                        }
                    
                    }
                    public class NoLegStipulations : Group
                    {
                        public NoLegStipulations() 
                          :base( Tags.NoLegStipulations, Tags.LegStipulationType, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.LegStipulationType, Tags.LegStipulationValue, 0};
                                            public QuickFix.Fields.LegStipulationType legStipulationType
                        { 
                            get 
                            {
                                QuickFix.Fields.LegStipulationType val = new QuickFix.Fields.LegStipulationType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegStipulationType val) 
                        { 
                            this.legStipulationType = val;
                        }
                        
                        public QuickFix.Fields.LegStipulationType Get(QuickFix.Fields.LegStipulationType val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegStipulationType val) 
                        { 
                            return IsSetLegStipulationType();
                        }
                        
                        public bool IsSetLegStipulationType() 
                        { 
                            return IsSetField(Tags.LegStipulationType);
                        }
                        public QuickFix.Fields.LegStipulationValue legStipulationValue
                        { 
                            get 
                            {
                                QuickFix.Fields.LegStipulationValue val = new QuickFix.Fields.LegStipulationValue();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.LegStipulationValue val) 
                        { 
                            this.legStipulationValue = val;
                        }
                        
                        public QuickFix.Fields.LegStipulationValue Get(QuickFix.Fields.LegStipulationValue val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.LegStipulationValue val) 
                        { 
                            return IsSetLegStipulationValue();
                        }
                        
                        public bool IsSetLegStipulationValue() 
                        { 
                            return IsSetField(Tags.LegStipulationValue);
                        }
                    
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
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartyID val) 
                        { 
                            this.nestedPartyID = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartyID val) 
                        { 
                            return IsSetNestedPartyID();
                        }
                        
                        public bool IsSetNestedPartyID() 
                        { 
                            return IsSetField(Tags.NestedPartyID);
                        }
                        public QuickFix.Fields.NestedPartyIDSource nestedPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartyIDSource val = new QuickFix.Fields.NestedPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            this.nestedPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) 
                        { 
                            return IsSetNestedPartyIDSource();
                        }
                        
                        public bool IsSetNestedPartyIDSource() 
                        { 
                            return IsSetField(Tags.NestedPartyIDSource);
                        }
                        public QuickFix.Fields.NestedPartyRole nestedPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.NestedPartyRole val = new QuickFix.Fields.NestedPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            this.nestedPartyRole = val;
                        }
                        
                        public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NestedPartyRole val) 
                        { 
                            return IsSetNestedPartyRole();
                        }
                        
                        public bool IsSetNestedPartyRole() 
                        { 
                            return IsSetField(Tags.NestedPartyRole);
                        }
                        public QuickFix.Fields.NoNestedPartySubIDs noNestedPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoNestedPartySubIDs val = new QuickFix.Fields.NoNestedPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            this.noNestedPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) 
                        { 
                            return IsSetNoNestedPartySubIDs();
                        }
                        
                        public bool IsSetNoNestedPartySubIDs() 
                        { 
                            return IsSetField(Tags.NoNestedPartySubIDs);
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
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                this.nestedPartySubID = val;
                            }
                            
                            public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.NestedPartySubID val) 
                            { 
                                return IsSetNestedPartySubID();
                            }
                            
                            public bool IsSetNestedPartySubID() 
                            { 
                                return IsSetField(Tags.NestedPartySubID);
                            }
                            public QuickFix.Fields.NestedPartySubIDType nestedPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.NestedPartySubIDType val = new QuickFix.Fields.NestedPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                this.nestedPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) 
                            { 
                                return IsSetNestedPartySubIDType();
                            }
                            
                            public bool IsSetNestedPartySubIDType() 
                            { 
                                return IsSetField(Tags.NestedPartySubIDType);
                            }
                        
                        }
                    }
                }
                public class NoQuoteQualifiers : Group
                {
                    public NoQuoteQualifiers() 
                      :base( Tags.NoQuoteQualifiers, Tags.QuoteQualifier, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.QuoteQualifier, 0};
                                    public QuickFix.Fields.QuoteQualifier quoteQualifier
                    { 
                        get 
                        {
                            QuickFix.Fields.QuoteQualifier val = new QuickFix.Fields.QuoteQualifier();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.QuoteQualifier val) 
                    { 
                        this.quoteQualifier = val;
                    }
                    
                    public QuickFix.Fields.QuoteQualifier Get(QuickFix.Fields.QuoteQualifier val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.QuoteQualifier val) 
                    { 
                        return IsSetQuoteQualifier();
                    }
                    
                    public bool IsSetQuoteQualifier() 
                    { 
                        return IsSetField(Tags.QuoteQualifier);
                    }
                
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
                }
                public class NoRateSources : Group
                {
                    public NoRateSources() 
                      :base( Tags.NoRateSources, Tags.RateSource, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.RateSource, Tags.RateSourceType, Tags.ReferencePage, 0};
                                    public QuickFix.Fields.RateSource rateSource
                    { 
                        get 
                        {
                            QuickFix.Fields.RateSource val = new QuickFix.Fields.RateSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RateSource val) 
                    { 
                        this.rateSource = val;
                    }
                    
                    public QuickFix.Fields.RateSource Get(QuickFix.Fields.RateSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RateSource val) 
                    { 
                        return IsSetRateSource();
                    }
                    
                    public bool IsSetRateSource() 
                    { 
                        return IsSetField(Tags.RateSource);
                    }
                    public QuickFix.Fields.RateSourceType rateSourceType
                    { 
                        get 
                        {
                            QuickFix.Fields.RateSourceType val = new QuickFix.Fields.RateSourceType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RateSourceType val) 
                    { 
                        this.rateSourceType = val;
                    }
                    
                    public QuickFix.Fields.RateSourceType Get(QuickFix.Fields.RateSourceType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RateSourceType val) 
                    { 
                        return IsSetRateSourceType();
                    }
                    
                    public bool IsSetRateSourceType() 
                    { 
                        return IsSetField(Tags.RateSourceType);
                    }
                    public QuickFix.Fields.ReferencePage referencePage
                    { 
                        get 
                        {
                            QuickFix.Fields.ReferencePage val = new QuickFix.Fields.ReferencePage();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.ReferencePage val) 
                    { 
                        this.referencePage = val;
                    }
                    
                    public QuickFix.Fields.ReferencePage Get(QuickFix.Fields.ReferencePage val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.ReferencePage val) 
                    { 
                        return IsSetReferencePage();
                    }
                    
                    public bool IsSetReferencePage() 
                    { 
                        return IsSetField(Tags.ReferencePage);
                    }
                
                }
            }
            public class NoRootPartyIDs : Group
            {
                public NoRootPartyIDs() 
                  :base( Tags.NoRootPartyIDs, Tags.RootPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RootPartyID, Tags.RootPartyIDSource, Tags.RootPartyRole, Tags.NoRootPartySubIDs, 0};
                            public QuickFix.Fields.RootPartyID rootPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyID val = new QuickFix.Fields.RootPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RootPartyID val) 
                { 
                    this.rootPartyID = val;
                }
                
                public QuickFix.Fields.RootPartyID Get(QuickFix.Fields.RootPartyID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RootPartyID val) 
                { 
                    return IsSetRootPartyID();
                }
                
                public bool IsSetRootPartyID() 
                { 
                    return IsSetField(Tags.RootPartyID);
                }
                public QuickFix.Fields.RootPartyIDSource rootPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyIDSource val = new QuickFix.Fields.RootPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    this.rootPartyIDSource = val;
                }
                
                public QuickFix.Fields.RootPartyIDSource Get(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RootPartyIDSource val) 
                { 
                    return IsSetRootPartyIDSource();
                }
                
                public bool IsSetRootPartyIDSource() 
                { 
                    return IsSetField(Tags.RootPartyIDSource);
                }
                public QuickFix.Fields.RootPartyRole rootPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.RootPartyRole val = new QuickFix.Fields.RootPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RootPartyRole val) 
                { 
                    this.rootPartyRole = val;
                }
                
                public QuickFix.Fields.RootPartyRole Get(QuickFix.Fields.RootPartyRole val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RootPartyRole val) 
                { 
                    return IsSetRootPartyRole();
                }
                
                public bool IsSetRootPartyRole() 
                { 
                    return IsSetField(Tags.RootPartyRole);
                }
                public QuickFix.Fields.NoRootPartySubIDs noRootPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoRootPartySubIDs val = new QuickFix.Fields.NoRootPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    this.noRootPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoRootPartySubIDs Get(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoRootPartySubIDs val) 
                { 
                    return IsSetNoRootPartySubIDs();
                }
                
                public bool IsSetNoRootPartySubIDs() 
                { 
                    return IsSetField(Tags.NoRootPartySubIDs);
                }
                            public class NoRootPartySubIDs : Group
                {
                    public NoRootPartySubIDs() 
                      :base( Tags.NoRootPartySubIDs, Tags.RootPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.RootPartySubID, Tags.RootPartySubIDType, 0};
                                    public QuickFix.Fields.RootPartySubID rootPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.RootPartySubID val = new QuickFix.Fields.RootPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RootPartySubID val) 
                    { 
                        this.rootPartySubID = val;
                    }
                    
                    public QuickFix.Fields.RootPartySubID Get(QuickFix.Fields.RootPartySubID val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RootPartySubID val) 
                    { 
                        return IsSetRootPartySubID();
                    }
                    
                    public bool IsSetRootPartySubID() 
                    { 
                        return IsSetField(Tags.RootPartySubID);
                    }
                    public QuickFix.Fields.RootPartySubIDType rootPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.RootPartySubIDType val = new QuickFix.Fields.RootPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        this.rootPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.RootPartySubIDType Get(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.RootPartySubIDType val) 
                    { 
                        return IsSetRootPartySubIDType();
                    }
                    
                    public bool IsSetRootPartySubIDType() 
                    { 
                        return IsSetField(Tags.RootPartySubIDType);
                    }
                
                }
            }
        }
    }
}
