// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class SettlementObligationReport : Message
        {
            public const string MsgType = "BQ";

            public SettlementObligationReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BQ"));
            }

            public SettlementObligationReport(
                    QuickFix.Fields.SettlObligMsgID aSettlObligMsgID,
                    QuickFix.Fields.SettlObligMode aSettlObligMode
                ) : this()
            {
                this.SettlObligMsgID = aSettlObligMsgID;
                this.SettlObligMode = aSettlObligMode;
            }

            public QuickFix.Fields.ClearingBusinessDate ClearingBusinessDate
            { 
                get 
                {
                    QuickFix.Fields.ClearingBusinessDate val = new QuickFix.Fields.ClearingBusinessDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                this.ClearingBusinessDate = val;
            }
            
            public QuickFix.Fields.ClearingBusinessDate Get(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClearingBusinessDate val) 
            { 
                return IsSetClearingBusinessDate();
            }
            
            public bool IsSetClearingBusinessDate() 
            { 
                return IsSetField(Tags.ClearingBusinessDate);
            }
            public QuickFix.Fields.SettlementCycleNo SettlementCycleNo
            { 
                get 
                {
                    QuickFix.Fields.SettlementCycleNo val = new QuickFix.Fields.SettlementCycleNo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlementCycleNo val) 
            { 
                this.SettlementCycleNo = val;
            }
            
            public QuickFix.Fields.SettlementCycleNo Get(QuickFix.Fields.SettlementCycleNo val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlementCycleNo val) 
            { 
                return IsSetSettlementCycleNo();
            }
            
            public bool IsSetSettlementCycleNo() 
            { 
                return IsSetField(Tags.SettlementCycleNo);
            }
            public QuickFix.Fields.SettlObligMsgID SettlObligMsgID
            { 
                get 
                {
                    QuickFix.Fields.SettlObligMsgID val = new QuickFix.Fields.SettlObligMsgID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlObligMsgID val) 
            { 
                this.SettlObligMsgID = val;
            }
            
            public QuickFix.Fields.SettlObligMsgID Get(QuickFix.Fields.SettlObligMsgID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlObligMsgID val) 
            { 
                return IsSetSettlObligMsgID();
            }
            
            public bool IsSetSettlObligMsgID() 
            { 
                return IsSetField(Tags.SettlObligMsgID);
            }
            public QuickFix.Fields.SettlObligMode SettlObligMode
            { 
                get 
                {
                    QuickFix.Fields.SettlObligMode val = new QuickFix.Fields.SettlObligMode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.SettlObligMode val) 
            { 
                this.SettlObligMode = val;
            }
            
            public QuickFix.Fields.SettlObligMode Get(QuickFix.Fields.SettlObligMode val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.SettlObligMode val) 
            { 
                return IsSetSettlObligMode();
            }
            
            public bool IsSetSettlObligMode() 
            { 
                return IsSetField(Tags.SettlObligMode);
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
            public QuickFix.Fields.TransactTime TransactTime
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
                this.TransactTime = val;
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
            public QuickFix.Fields.NoSettlOblig NoSettlOblig
            { 
                get 
                {
                    QuickFix.Fields.NoSettlOblig val = new QuickFix.Fields.NoSettlOblig();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoSettlOblig val) 
            { 
                this.NoSettlOblig = val;
            }
            
            public QuickFix.Fields.NoSettlOblig Get(QuickFix.Fields.NoSettlOblig val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoSettlOblig val) 
            { 
                return IsSetNoSettlOblig();
            }
            
            public bool IsSetNoSettlOblig() 
            { 
                return IsSetField(Tags.NoSettlOblig);
            }
            public QuickFix.Fields.ApplID ApplID
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
                this.ApplID = val;
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
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
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
                this.ApplSeqNum = val;
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
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
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
                this.ApplLastSeqNum = val;
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
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
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
                this.ApplResendFlag = val;
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
            public class NoSettlObligGroup : Group
            {
                public static int[] fieldOrder = {Tags.NetGrossInd, Tags.SettlObligID, Tags.SettlObligTransType, Tags.SettlObligRefID, Tags.CcyAmt, Tags.SettlCurrAmt, Tags.Currency, Tags.SettlCurrency, Tags.SettlCurrFxRate, Tags.SettlDate, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.NoPartyIDs, Tags.EffectiveTime, Tags.ExpireTime, Tags.LastUpdateTime, Tags.NoSettlDetails, 0};
            
                public NoSettlObligGroup() 
                  :base( Tags.NoSettlOblig, Tags.NetGrossInd, fieldOrder)
                {
                }
            
                public override Group Clone()
                {
                    var clone = new NoSettlObligGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }
            
                            public QuickFix.Fields.NetGrossInd NetGrossInd
                { 
                    get 
                    {
                        QuickFix.Fields.NetGrossInd val = new QuickFix.Fields.NetGrossInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NetGrossInd val) 
                { 
                    this.NetGrossInd = val;
                }
                
                public QuickFix.Fields.NetGrossInd Get(QuickFix.Fields.NetGrossInd val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NetGrossInd val) 
                { 
                    return IsSetNetGrossInd();
                }
                
                public bool IsSetNetGrossInd() 
                { 
                    return IsSetField(Tags.NetGrossInd);
                }
                public QuickFix.Fields.SettlObligID SettlObligID
                { 
                    get 
                    {
                        QuickFix.Fields.SettlObligID val = new QuickFix.Fields.SettlObligID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlObligID val) 
                { 
                    this.SettlObligID = val;
                }
                
                public QuickFix.Fields.SettlObligID Get(QuickFix.Fields.SettlObligID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlObligID val) 
                { 
                    return IsSetSettlObligID();
                }
                
                public bool IsSetSettlObligID() 
                { 
                    return IsSetField(Tags.SettlObligID);
                }
                public QuickFix.Fields.SettlObligTransType SettlObligTransType
                { 
                    get 
                    {
                        QuickFix.Fields.SettlObligTransType val = new QuickFix.Fields.SettlObligTransType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlObligTransType val) 
                { 
                    this.SettlObligTransType = val;
                }
                
                public QuickFix.Fields.SettlObligTransType Get(QuickFix.Fields.SettlObligTransType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlObligTransType val) 
                { 
                    return IsSetSettlObligTransType();
                }
                
                public bool IsSetSettlObligTransType() 
                { 
                    return IsSetField(Tags.SettlObligTransType);
                }
                public QuickFix.Fields.SettlObligRefID SettlObligRefID
                { 
                    get 
                    {
                        QuickFix.Fields.SettlObligRefID val = new QuickFix.Fields.SettlObligRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlObligRefID val) 
                { 
                    this.SettlObligRefID = val;
                }
                
                public QuickFix.Fields.SettlObligRefID Get(QuickFix.Fields.SettlObligRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlObligRefID val) 
                { 
                    return IsSetSettlObligRefID();
                }
                
                public bool IsSetSettlObligRefID() 
                { 
                    return IsSetField(Tags.SettlObligRefID);
                }
                public QuickFix.Fields.CcyAmt CcyAmt
                { 
                    get 
                    {
                        QuickFix.Fields.CcyAmt val = new QuickFix.Fields.CcyAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CcyAmt val) 
                { 
                    this.CcyAmt = val;
                }
                
                public QuickFix.Fields.CcyAmt Get(QuickFix.Fields.CcyAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CcyAmt val) 
                { 
                    return IsSetCcyAmt();
                }
                
                public bool IsSetCcyAmt() 
                { 
                    return IsSetField(Tags.CcyAmt);
                }
                public QuickFix.Fields.SettlCurrAmt SettlCurrAmt
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrAmt val = new QuickFix.Fields.SettlCurrAmt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    this.SettlCurrAmt = val;
                }
                
                public QuickFix.Fields.SettlCurrAmt Get(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrAmt val) 
                { 
                    return IsSetSettlCurrAmt();
                }
                
                public bool IsSetSettlCurrAmt() 
                { 
                    return IsSetField(Tags.SettlCurrAmt);
                }
                public QuickFix.Fields.Currency Currency
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
                    this.Currency = val;
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
                public QuickFix.Fields.SettlCurrency SettlCurrency
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
                    this.SettlCurrency = val;
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
                public QuickFix.Fields.SettlCurrFxRate SettlCurrFxRate
                { 
                    get 
                    {
                        QuickFix.Fields.SettlCurrFxRate val = new QuickFix.Fields.SettlCurrFxRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    this.SettlCurrFxRate = val;
                }
                
                public QuickFix.Fields.SettlCurrFxRate Get(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SettlCurrFxRate val) 
                { 
                    return IsSetSettlCurrFxRate();
                }
                
                public bool IsSetSettlCurrFxRate() 
                { 
                    return IsSetField(Tags.SettlCurrFxRate);
                }
                public QuickFix.Fields.SettlDate SettlDate
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
                    this.SettlDate = val;
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
                public QuickFix.Fields.OptPayAmount OptPayAmount
                { 
                    get 
                    {
                        QuickFix.Fields.OptPayAmount val = new QuickFix.Fields.OptPayAmount();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OptPayAmount val) 
                { 
                    this.OptPayAmount = val;
                }
                
                public QuickFix.Fields.OptPayAmount Get(QuickFix.Fields.OptPayAmount val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OptPayAmount val) 
                { 
                    return IsSetOptPayAmount();
                }
                
                public bool IsSetOptPayAmount() 
                { 
                    return IsSetField(Tags.OptPayAmount);
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
                public QuickFix.Fields.FuturesValuationMethod FuturesValuationMethod
                { 
                    get 
                    {
                        QuickFix.Fields.FuturesValuationMethod val = new QuickFix.Fields.FuturesValuationMethod();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    this.FuturesValuationMethod = val;
                }
                
                public QuickFix.Fields.FuturesValuationMethod Get(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    return IsSetFuturesValuationMethod();
                }
                
                public bool IsSetFuturesValuationMethod() 
                { 
                    return IsSetField(Tags.FuturesValuationMethod);
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
                public QuickFix.Fields.EffectiveTime EffectiveTime
                { 
                    get 
                    {
                        QuickFix.Fields.EffectiveTime val = new QuickFix.Fields.EffectiveTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EffectiveTime val) 
                { 
                    this.EffectiveTime = val;
                }
                
                public QuickFix.Fields.EffectiveTime Get(QuickFix.Fields.EffectiveTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EffectiveTime val) 
                { 
                    return IsSetEffectiveTime();
                }
                
                public bool IsSetEffectiveTime() 
                { 
                    return IsSetField(Tags.EffectiveTime);
                }
                public QuickFix.Fields.ExpireTime ExpireTime
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
                    this.ExpireTime = val;
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
                public QuickFix.Fields.LastUpdateTime LastUpdateTime
                { 
                    get 
                    {
                        QuickFix.Fields.LastUpdateTime val = new QuickFix.Fields.LastUpdateTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LastUpdateTime val) 
                { 
                    this.LastUpdateTime = val;
                }
                
                public QuickFix.Fields.LastUpdateTime Get(QuickFix.Fields.LastUpdateTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LastUpdateTime val) 
                { 
                    return IsSetLastUpdateTime();
                }
                
                public bool IsSetLastUpdateTime() 
                { 
                    return IsSetField(Tags.LastUpdateTime);
                }
                public QuickFix.Fields.NoSettlDetails NoSettlDetails
                { 
                    get 
                    {
                        QuickFix.Fields.NoSettlDetails val = new QuickFix.Fields.NoSettlDetails();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NoSettlDetails val) 
                { 
                    this.NoSettlDetails = val;
                }
                
                public QuickFix.Fields.NoSettlDetails Get(QuickFix.Fields.NoSettlDetails val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NoSettlDetails val) 
                { 
                    return IsSetNoSettlDetails();
                }
                
                public bool IsSetNoSettlDetails() 
                { 
                    return IsSetField(Tags.NoSettlDetails);
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
                public class NoSettlDetailsGroup : Group
                {
                    public static int[] fieldOrder = {Tags.SettlObligSource, Tags.NoSettlPartyIDs, 0};
                
                    public NoSettlDetailsGroup() 
                      :base( Tags.NoSettlDetails, Tags.SettlObligSource, fieldOrder)
                    {
                    }
                
                    public override Group Clone()
                    {
                        var clone = new NoSettlDetailsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }
                
                                    public QuickFix.Fields.SettlObligSource SettlObligSource
                    { 
                        get 
                        {
                            QuickFix.Fields.SettlObligSource val = new QuickFix.Fields.SettlObligSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.SettlObligSource val) 
                    { 
                        this.SettlObligSource = val;
                    }
                    
                    public QuickFix.Fields.SettlObligSource Get(QuickFix.Fields.SettlObligSource val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.SettlObligSource val) 
                    { 
                        return IsSetSettlObligSource();
                    }
                    
                    public bool IsSetSettlObligSource() 
                    { 
                        return IsSetField(Tags.SettlObligSource);
                    }
                    public QuickFix.Fields.NoSettlPartyIDs NoSettlPartyIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoSettlPartyIDs val = new QuickFix.Fields.NoSettlPartyIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }
                    
                    public void Set(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        this.NoSettlPartyIDs = val;
                    }
                    
                    public QuickFix.Fields.NoSettlPartyIDs Get(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        GetField(val);
                        return val;
                    }
                    
                    public bool IsSet(QuickFix.Fields.NoSettlPartyIDs val) 
                    { 
                        return IsSetNoSettlPartyIDs();
                    }
                    
                    public bool IsSetNoSettlPartyIDs() 
                    { 
                        return IsSetField(Tags.NoSettlPartyIDs);
                    }
                                    public class NoSettlPartyIDsGroup : Group
                    {
                        public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};
                    
                        public NoSettlPartyIDsGroup() 
                          :base( Tags.NoSettlPartyIDs, Tags.SettlPartyID, fieldOrder)
                        {
                        }
                    
                        public override Group Clone()
                        {
                            var clone = new NoSettlPartyIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }
                    
                                            public QuickFix.Fields.SettlPartyID SettlPartyID
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyID val = new QuickFix.Fields.SettlPartyID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.SettlPartyID val) 
                        { 
                            this.SettlPartyID = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyID Get(QuickFix.Fields.SettlPartyID val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.SettlPartyID val) 
                        { 
                            return IsSetSettlPartyID();
                        }
                        
                        public bool IsSetSettlPartyID() 
                        { 
                            return IsSetField(Tags.SettlPartyID);
                        }
                        public QuickFix.Fields.SettlPartyIDSource SettlPartyIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyIDSource val = new QuickFix.Fields.SettlPartyIDSource();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            this.SettlPartyIDSource = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyIDSource Get(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.SettlPartyIDSource val) 
                        { 
                            return IsSetSettlPartyIDSource();
                        }
                        
                        public bool IsSetSettlPartyIDSource() 
                        { 
                            return IsSetField(Tags.SettlPartyIDSource);
                        }
                        public QuickFix.Fields.SettlPartyRole SettlPartyRole
                        { 
                            get 
                            {
                                QuickFix.Fields.SettlPartyRole val = new QuickFix.Fields.SettlPartyRole();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            this.SettlPartyRole = val;
                        }
                        
                        public QuickFix.Fields.SettlPartyRole Get(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.SettlPartyRole val) 
                        { 
                            return IsSetSettlPartyRole();
                        }
                        
                        public bool IsSetSettlPartyRole() 
                        { 
                            return IsSetField(Tags.SettlPartyRole);
                        }
                        public QuickFix.Fields.NoSettlPartySubIDs NoSettlPartySubIDs
                        { 
                            get 
                            {
                                QuickFix.Fields.NoSettlPartySubIDs val = new QuickFix.Fields.NoSettlPartySubIDs();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }
                        
                        public void Set(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            this.NoSettlPartySubIDs = val;
                        }
                        
                        public QuickFix.Fields.NoSettlPartySubIDs Get(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            GetField(val);
                            return val;
                        }
                        
                        public bool IsSet(QuickFix.Fields.NoSettlPartySubIDs val) 
                        { 
                            return IsSetNoSettlPartySubIDs();
                        }
                        
                        public bool IsSetNoSettlPartySubIDs() 
                        { 
                            return IsSetField(Tags.NoSettlPartySubIDs);
                        }
                                            public class NoSettlPartySubIDsGroup : Group
                        {
                            public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};
                        
                            public NoSettlPartySubIDsGroup() 
                              :base( Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, fieldOrder)
                            {
                            }
                        
                            public override Group Clone()
                            {
                                var clone = new NoSettlPartySubIDsGroup();
                                clone.CopyStateFrom(this);
                                return clone;
                            }
                        
                                                    public QuickFix.Fields.SettlPartySubID SettlPartySubID
                            { 
                                get 
                                {
                                    QuickFix.Fields.SettlPartySubID val = new QuickFix.Fields.SettlPartySubID();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                this.SettlPartySubID = val;
                            }
                            
                            public QuickFix.Fields.SettlPartySubID Get(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.SettlPartySubID val) 
                            { 
                                return IsSetSettlPartySubID();
                            }
                            
                            public bool IsSetSettlPartySubID() 
                            { 
                                return IsSetField(Tags.SettlPartySubID);
                            }
                            public QuickFix.Fields.SettlPartySubIDType SettlPartySubIDType
                            { 
                                get 
                                {
                                    QuickFix.Fields.SettlPartySubIDType val = new QuickFix.Fields.SettlPartySubIDType();
                                    GetField(val);
                                    return val;
                                }
                                set { SetField(value); }
                            }
                            
                            public void Set(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                this.SettlPartySubIDType = val;
                            }
                            
                            public QuickFix.Fields.SettlPartySubIDType Get(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                GetField(val);
                                return val;
                            }
                            
                            public bool IsSet(QuickFix.Fields.SettlPartySubIDType val) 
                            { 
                                return IsSetSettlPartySubIDType();
                            }
                            
                            public bool IsSetSettlPartySubIDType() 
                            { 
                                return IsSetField(Tags.SettlPartySubIDType);
                            }
                        
                        }
                    }
                }
            }
        }
    }
}
