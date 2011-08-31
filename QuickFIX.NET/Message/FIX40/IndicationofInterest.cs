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
                this.Header.setField(new QuickFix.Fields.MsgType("6"));
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
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IOIid val) 
            { 
                this.iOIid = val;
            }
            
            public QuickFix.Fields.IOIid get(QuickFix.Fields.IOIid val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IOIid val) 
            { 
                return isSetIOIid();
            }
            
            public bool isSetIOIid() 
            { 
                return isSetField(Tags.IOIid);
            }
            public QuickFix.Fields.IOITransType iOITransType
            { 
                get 
                {
                    QuickFix.Fields.IOITransType val = new QuickFix.Fields.IOITransType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IOITransType val) 
            { 
                this.iOITransType = val;
            }
            
            public QuickFix.Fields.IOITransType get(QuickFix.Fields.IOITransType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IOITransType val) 
            { 
                return isSetIOITransType();
            }
            
            public bool isSetIOITransType() 
            { 
                return isSetField(Tags.IOITransType);
            }
            public QuickFix.Fields.IOIRefID iOIRefID
            { 
                get 
                {
                    QuickFix.Fields.IOIRefID val = new QuickFix.Fields.IOIRefID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IOIRefID val) 
            { 
                this.iOIRefID = val;
            }
            
            public QuickFix.Fields.IOIRefID get(QuickFix.Fields.IOIRefID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IOIRefID val) 
            { 
                return isSetIOIRefID();
            }
            
            public bool isSetIOIRefID() 
            { 
                return isSetField(Tags.IOIRefID);
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
            public QuickFix.Fields.IOIShares iOIShares
            { 
                get 
                {
                    QuickFix.Fields.IOIShares val = new QuickFix.Fields.IOIShares();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IOIShares val) 
            { 
                this.iOIShares = val;
            }
            
            public QuickFix.Fields.IOIShares get(QuickFix.Fields.IOIShares val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IOIShares val) 
            { 
                return isSetIOIShares();
            }
            
            public bool isSetIOIShares() 
            { 
                return isSetField(Tags.IOIShares);
            }
            public QuickFix.Fields.Price price
            { 
                get 
                {
                    QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Price val) 
            { 
                this.price = val;
            }
            
            public QuickFix.Fields.Price get(QuickFix.Fields.Price val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Price val) 
            { 
                return isSetPrice();
            }
            
            public bool isSetPrice() 
            { 
                return isSetField(Tags.Price);
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
            public QuickFix.Fields.ValidUntilTime validUntilTime
            { 
                get 
                {
                    QuickFix.Fields.ValidUntilTime val = new QuickFix.Fields.ValidUntilTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ValidUntilTime val) 
            { 
                this.validUntilTime = val;
            }
            
            public QuickFix.Fields.ValidUntilTime get(QuickFix.Fields.ValidUntilTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ValidUntilTime val) 
            { 
                return isSetValidUntilTime();
            }
            
            public bool isSetValidUntilTime() 
            { 
                return isSetField(Tags.ValidUntilTime);
            }
            public QuickFix.Fields.IOIQltyInd iOIQltyInd
            { 
                get 
                {
                    QuickFix.Fields.IOIQltyInd val = new QuickFix.Fields.IOIQltyInd();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IOIQltyInd val) 
            { 
                this.iOIQltyInd = val;
            }
            
            public QuickFix.Fields.IOIQltyInd get(QuickFix.Fields.IOIQltyInd val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IOIQltyInd val) 
            { 
                return isSetIOIQltyInd();
            }
            
            public bool isSetIOIQltyInd() 
            { 
                return isSetField(Tags.IOIQltyInd);
            }
            public QuickFix.Fields.IOIOthSvc iOIOthSvc
            { 
                get 
                {
                    QuickFix.Fields.IOIOthSvc val = new QuickFix.Fields.IOIOthSvc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IOIOthSvc val) 
            { 
                this.iOIOthSvc = val;
            }
            
            public QuickFix.Fields.IOIOthSvc get(QuickFix.Fields.IOIOthSvc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IOIOthSvc val) 
            { 
                return isSetIOIOthSvc();
            }
            
            public bool isSetIOIOthSvc() 
            { 
                return isSetField(Tags.IOIOthSvc);
            }
            public QuickFix.Fields.IOINaturalFlag iOINaturalFlag
            { 
                get 
                {
                    QuickFix.Fields.IOINaturalFlag val = new QuickFix.Fields.IOINaturalFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IOINaturalFlag val) 
            { 
                this.iOINaturalFlag = val;
            }
            
            public QuickFix.Fields.IOINaturalFlag get(QuickFix.Fields.IOINaturalFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IOINaturalFlag val) 
            { 
                return isSetIOINaturalFlag();
            }
            
            public bool isSetIOINaturalFlag() 
            { 
                return isSetField(Tags.IOINaturalFlag);
            }
            public QuickFix.Fields.IOIQualifier iOIQualifier
            { 
                get 
                {
                    QuickFix.Fields.IOIQualifier val = new QuickFix.Fields.IOIQualifier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.IOIQualifier val) 
            { 
                this.iOIQualifier = val;
            }
            
            public QuickFix.Fields.IOIQualifier get(QuickFix.Fields.IOIQualifier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.IOIQualifier val) 
            { 
                return isSetIOIQualifier();
            }
            
            public bool isSetIOIQualifier() 
            { 
                return isSetField(Tags.IOIQualifier);
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

        }
    }
}
