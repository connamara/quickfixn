// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX40;

public class Advertisement : Message
{
    public const string MsgType = "7";

    public Advertisement() : base()
    {
        Header.SetField(new MsgType("7"));
    }

    public Advertisement(
            AdvId aAdvId,
            AdvTransType aAdvTransType,
            Symbol aSymbol,
            AdvSide aAdvSide,
            Shares aShares
        ) : this()
    {
        AdvId = aAdvId;
        AdvTransType = aAdvTransType;
        Symbol = aSymbol;
        AdvSide = aAdvSide;
        Shares = aShares;
    }

    public AdvId AdvId
    {
        get
        {
            AdvId val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AdvId val) { AdvId = val; }
    public AdvId Get(AdvId val) { GetField(val); return val; }
    public bool IsSet(AdvId val) { return IsSetAdvId(); }
    public bool IsSetAdvId() { return IsSetField(Tags.AdvId); }

    public AdvTransType AdvTransType
    {
        get
        {
            AdvTransType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AdvTransType val) { AdvTransType = val; }
    public AdvTransType Get(AdvTransType val) { GetField(val); return val; }
    public bool IsSet(AdvTransType val) { return IsSetAdvTransType(); }
    public bool IsSetAdvTransType() { return IsSetField(Tags.AdvTransType); }

    public AdvRefID AdvRefID
    {
        get
        {
            AdvRefID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AdvRefID val) { AdvRefID = val; }
    public AdvRefID Get(AdvRefID val) { GetField(val); return val; }
    public bool IsSet(AdvRefID val) { return IsSetAdvRefID(); }
    public bool IsSetAdvRefID() { return IsSetField(Tags.AdvRefID); }

    public Symbol Symbol
    {
        get
        {
            Symbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Symbol val) { Symbol = val; }
    public Symbol Get(Symbol val) { GetField(val); return val; }
    public bool IsSet(Symbol val) { return IsSetSymbol(); }
    public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

    public SymbolSfx SymbolSfx
    {
        get
        {
            SymbolSfx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SymbolSfx val) { SymbolSfx = val; }
    public SymbolSfx Get(SymbolSfx val) { GetField(val); return val; }
    public bool IsSet(SymbolSfx val) { return IsSetSymbolSfx(); }
    public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }

    public SecurityID SecurityID
    {
        get
        {
            SecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityID val) { SecurityID = val; }
    public SecurityID Get(SecurityID val) { GetField(val); return val; }
    public bool IsSet(SecurityID val) { return IsSetSecurityID(); }
    public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

    public IDSource IDSource
    {
        get
        {
            IDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(IDSource val) { IDSource = val; }
    public IDSource Get(IDSource val) { GetField(val); return val; }
    public bool IsSet(IDSource val) { return IsSetIDSource(); }
    public bool IsSetIDSource() { return IsSetField(Tags.IDSource); }

    public Issuer Issuer
    {
        get
        {
            Issuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Issuer val) { Issuer = val; }
    public Issuer Get(Issuer val) { GetField(val); return val; }
    public bool IsSet(Issuer val) { return IsSetIssuer(); }
    public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }

    public SecurityDesc SecurityDesc
    {
        get
        {
            SecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityDesc val) { SecurityDesc = val; }
    public SecurityDesc Get(SecurityDesc val) { GetField(val); return val; }
    public bool IsSet(SecurityDesc val) { return IsSetSecurityDesc(); }
    public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }

    public AdvSide AdvSide
    {
        get
        {
            AdvSide val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AdvSide val) { AdvSide = val; }
    public AdvSide Get(AdvSide val) { GetField(val); return val; }
    public bool IsSet(AdvSide val) { return IsSetAdvSide(); }
    public bool IsSetAdvSide() { return IsSetField(Tags.AdvSide); }

    public Shares Shares
    {
        get
        {
            Shares val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Shares val) { Shares = val; }
    public Shares Get(Shares val) { GetField(val); return val; }
    public bool IsSet(Shares val) { return IsSetShares(); }
    public bool IsSetShares() { return IsSetField(Tags.Shares); }

    public Price Price
    {
        get
        {
            Price val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Price val) { Price = val; }
    public Price Get(Price val) { GetField(val); return val; }
    public bool IsSet(Price val) { return IsSetPrice(); }
    public bool IsSetPrice() { return IsSetField(Tags.Price); }

    public Currency Currency
    {
        get
        {
            Currency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Currency val) { Currency = val; }
    public Currency Get(Currency val) { GetField(val); return val; }
    public bool IsSet(Currency val) { return IsSetCurrency(); }
    public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }
}
