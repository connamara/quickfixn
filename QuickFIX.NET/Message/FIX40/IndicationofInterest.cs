// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX40 
    {
        public class IndicationofInterest : Message
        {
            public const string MsgType = "6";

            public IndicationofInterest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("6"));
            }

            public IndicationofInterest(
                    QuickFix.Fields.IOIid aIOIid,
                    QuickFix.Fields.IOITransType aIOITransType,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.Side aSide,
                    QuickFix.Fields.IOIShares aIOIShares
                ) : this()
            {
                this.iOIid = aIOIid;
                this.iOITransType = aIOITransType;
                this.symbol = aSymbol;
                this.side = aSide;
                this.iOIShares = aIOIShares;
            }

            public QuickFix.Fields.IOIid iOIid
            { 
                get 
                {
                    QuickFix.Fields.IOIid val = new QuickFix.Fields.IOIid();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIid val) 
            { 
                this.iOIid = val;
            }
            
            public QuickFix.Fields.IOIid Get(QuickFix.Fields.IOIid val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIid val) 
            { 
                return IsSetIOIid();
            }
            
            public bool IsSetIOIid() 
            { 
                return IsSetField(Tags.IOIid);
            }
            public QuickFix.Fields.IOITransType iOITransType
            { 
                get 
                {
                    QuickFix.Fields.IOITransType val = new QuickFix.Fields.IOITransType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOITransType val) 
            { 
                this.iOITransType = val;
            }
            
            public QuickFix.Fields.IOITransType Get(QuickFix.Fields.IOITransType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOITransType val) 
            { 
                return IsSetIOITransType();
            }
            
            public bool IsSetIOITransType() 
            { 
                return IsSetField(Tags.IOITransType);
            }
            public QuickFix.Fields.IOIRefID iOIRefID
            { 
                get 
                {
                    QuickFix.Fields.IOIRefID val = new QuickFix.Fields.IOIRefID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIRefID val) 
            { 
                this.iOIRefID = val;
            }
            
            public QuickFix.Fields.IOIRefID Get(QuickFix.Fields.IOIRefID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIRefID val) 
            { 
                return IsSetIOIRefID();
            }
            
            public bool IsSetIOIRefID() 
            { 
                return IsSetField(Tags.IOIRefID);
            }
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
            public QuickFix.Fields.IDSource iDSource
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
                this.iDSource = val;
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
            public QuickFix.Fields.IOIShares iOIShares
            { 
                get 
                {
                    QuickFix.Fields.IOIShares val = new QuickFix.Fields.IOIShares();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIShares val) 
            { 
                this.iOIShares = val;
            }
            
            public QuickFix.Fields.IOIShares Get(QuickFix.Fields.IOIShares val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIShares val) 
            { 
                return IsSetIOIShares();
            }
            
            public bool IsSetIOIShares() 
            { 
                return IsSetField(Tags.IOIShares);
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
            public QuickFix.Fields.IOIQltyInd iOIQltyInd
            { 
                get 
                {
                    QuickFix.Fields.IOIQltyInd val = new QuickFix.Fields.IOIQltyInd();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIQltyInd val) 
            { 
                this.iOIQltyInd = val;
            }
            
            public QuickFix.Fields.IOIQltyInd Get(QuickFix.Fields.IOIQltyInd val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIQltyInd val) 
            { 
                return IsSetIOIQltyInd();
            }
            
            public bool IsSetIOIQltyInd() 
            { 
                return IsSetField(Tags.IOIQltyInd);
            }
            public QuickFix.Fields.IOIOthSvc iOIOthSvc
            { 
                get 
                {
                    QuickFix.Fields.IOIOthSvc val = new QuickFix.Fields.IOIOthSvc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIOthSvc val) 
            { 
                this.iOIOthSvc = val;
            }
            
            public QuickFix.Fields.IOIOthSvc Get(QuickFix.Fields.IOIOthSvc val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIOthSvc val) 
            { 
                return IsSetIOIOthSvc();
            }
            
            public bool IsSetIOIOthSvc() 
            { 
                return IsSetField(Tags.IOIOthSvc);
            }
            public QuickFix.Fields.IOINaturalFlag iOINaturalFlag
            { 
                get 
                {
                    QuickFix.Fields.IOINaturalFlag val = new QuickFix.Fields.IOINaturalFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOINaturalFlag val) 
            { 
                this.iOINaturalFlag = val;
            }
            
            public QuickFix.Fields.IOINaturalFlag Get(QuickFix.Fields.IOINaturalFlag val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOINaturalFlag val) 
            { 
                return IsSetIOINaturalFlag();
            }
            
            public bool IsSetIOINaturalFlag() 
            { 
                return IsSetField(Tags.IOINaturalFlag);
            }
            public QuickFix.Fields.IOIQualifier iOIQualifier
            { 
                get 
                {
                    QuickFix.Fields.IOIQualifier val = new QuickFix.Fields.IOIQualifier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.IOIQualifier val) 
            { 
                this.iOIQualifier = val;
            }
            
            public QuickFix.Fields.IOIQualifier Get(QuickFix.Fields.IOIQualifier val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.IOIQualifier val) 
            { 
                return IsSetIOIQualifier();
            }
            
            public bool IsSetIOIQualifier() 
            { 
                return IsSetField(Tags.IOIQualifier);
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

        }
    }
}
