// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class DerivativeSecurityListRequest : Message
{
    public const string MsgType = "z";

    public DerivativeSecurityListRequest() : base()
    {
        Header.SetField(new MsgType("z"));
    }

    public DerivativeSecurityListRequest(
            SecurityReqID aSecurityReqID,
            SecurityListRequestType aSecurityListRequestType
        ) : this()
    {
        SecurityReqID = aSecurityReqID;
        SecurityListRequestType = aSecurityListRequestType;
    }

    public SecurityReqID SecurityReqID
    {
        get
        {
            SecurityReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityReqID val) { SecurityReqID = val; }
    public SecurityReqID Get(SecurityReqID val) { GetField(val); return val; }
    public bool IsSet(SecurityReqID val) { return IsSetSecurityReqID(); }
    public bool IsSetSecurityReqID() { return IsSetField(Tags.SecurityReqID); }

    public SecurityListRequestType SecurityListRequestType
    {
        get
        {
            SecurityListRequestType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityListRequestType val) { SecurityListRequestType = val; }
    public SecurityListRequestType Get(SecurityListRequestType val) { GetField(val); return val; }
    public bool IsSet(SecurityListRequestType val) { return IsSetSecurityListRequestType(); }
    public bool IsSetSecurityListRequestType() { return IsSetField(Tags.SecurityListRequestType); }

    public UnderlyingSymbol UnderlyingSymbol
    {
        get
        {
            UnderlyingSymbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSymbol val) { UnderlyingSymbol = val; }
    public UnderlyingSymbol Get(UnderlyingSymbol val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSymbol val) { return IsSetUnderlyingSymbol(); }
    public bool IsSetUnderlyingSymbol() { return IsSetField(Tags.UnderlyingSymbol); }

    public UnderlyingSymbolSfx UnderlyingSymbolSfx
    {
        get
        {
            UnderlyingSymbolSfx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSymbolSfx val) { UnderlyingSymbolSfx = val; }
    public UnderlyingSymbolSfx Get(UnderlyingSymbolSfx val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSymbolSfx val) { return IsSetUnderlyingSymbolSfx(); }
    public bool IsSetUnderlyingSymbolSfx() { return IsSetField(Tags.UnderlyingSymbolSfx); }

    public UnderlyingSecurityID UnderlyingSecurityID
    {
        get
        {
            UnderlyingSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityID val) { UnderlyingSecurityID = val; }
    public UnderlyingSecurityID Get(UnderlyingSecurityID val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityID val) { return IsSetUnderlyingSecurityID(); }
    public bool IsSetUnderlyingSecurityID() { return IsSetField(Tags.UnderlyingSecurityID); }

    public UnderlyingSecurityIDSource UnderlyingSecurityIDSource
    {
        get
        {
            UnderlyingSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityIDSource val) { UnderlyingSecurityIDSource = val; }
    public UnderlyingSecurityIDSource Get(UnderlyingSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityIDSource val) { return IsSetUnderlyingSecurityIDSource(); }
    public bool IsSetUnderlyingSecurityIDSource() { return IsSetField(Tags.UnderlyingSecurityIDSource); }

    public NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
    {
        get
        {
            NoUnderlyingSecurityAltID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUnderlyingSecurityAltID val) { NoUnderlyingSecurityAltID = val; }
    public NoUnderlyingSecurityAltID Get(NoUnderlyingSecurityAltID val) { GetField(val); return val; }
    public bool IsSet(NoUnderlyingSecurityAltID val) { return IsSetNoUnderlyingSecurityAltID(); }
    public bool IsSetNoUnderlyingSecurityAltID() { return IsSetField(Tags.NoUnderlyingSecurityAltID); }

    public UnderlyingProduct UnderlyingProduct
    {
        get
        {
            UnderlyingProduct val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingProduct val) { UnderlyingProduct = val; }
    public UnderlyingProduct Get(UnderlyingProduct val) { GetField(val); return val; }
    public bool IsSet(UnderlyingProduct val) { return IsSetUnderlyingProduct(); }
    public bool IsSetUnderlyingProduct() { return IsSetField(Tags.UnderlyingProduct); }

    public UnderlyingCFICode UnderlyingCFICode
    {
        get
        {
            UnderlyingCFICode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCFICode val) { UnderlyingCFICode = val; }
    public UnderlyingCFICode Get(UnderlyingCFICode val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCFICode val) { return IsSetUnderlyingCFICode(); }
    public bool IsSetUnderlyingCFICode() { return IsSetField(Tags.UnderlyingCFICode); }

    public UnderlyingSecurityType UnderlyingSecurityType
    {
        get
        {
            UnderlyingSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityType val) { UnderlyingSecurityType = val; }
    public UnderlyingSecurityType Get(UnderlyingSecurityType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityType val) { return IsSetUnderlyingSecurityType(); }
    public bool IsSetUnderlyingSecurityType() { return IsSetField(Tags.UnderlyingSecurityType); }

    public UnderlyingSecuritySubType UnderlyingSecuritySubType
    {
        get
        {
            UnderlyingSecuritySubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecuritySubType val) { UnderlyingSecuritySubType = val; }
    public UnderlyingSecuritySubType Get(UnderlyingSecuritySubType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecuritySubType val) { return IsSetUnderlyingSecuritySubType(); }
    public bool IsSetUnderlyingSecuritySubType() { return IsSetField(Tags.UnderlyingSecuritySubType); }

    public UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
    {
        get
        {
            UnderlyingMaturityMonthYear val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingMaturityMonthYear val) { UnderlyingMaturityMonthYear = val; }
    public UnderlyingMaturityMonthYear Get(UnderlyingMaturityMonthYear val) { GetField(val); return val; }
    public bool IsSet(UnderlyingMaturityMonthYear val) { return IsSetUnderlyingMaturityMonthYear(); }
    public bool IsSetUnderlyingMaturityMonthYear() { return IsSetField(Tags.UnderlyingMaturityMonthYear); }

    public UnderlyingMaturityDate UnderlyingMaturityDate
    {
        get
        {
            UnderlyingMaturityDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingMaturityDate val) { UnderlyingMaturityDate = val; }
    public UnderlyingMaturityDate Get(UnderlyingMaturityDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingMaturityDate val) { return IsSetUnderlyingMaturityDate(); }
    public bool IsSetUnderlyingMaturityDate() { return IsSetField(Tags.UnderlyingMaturityDate); }

    public UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
    {
        get
        {
            UnderlyingCouponPaymentDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCouponPaymentDate val) { UnderlyingCouponPaymentDate = val; }
    public UnderlyingCouponPaymentDate Get(UnderlyingCouponPaymentDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCouponPaymentDate val) { return IsSetUnderlyingCouponPaymentDate(); }
    public bool IsSetUnderlyingCouponPaymentDate() { return IsSetField(Tags.UnderlyingCouponPaymentDate); }

    public UnderlyingIssueDate UnderlyingIssueDate
    {
        get
        {
            UnderlyingIssueDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingIssueDate val) { UnderlyingIssueDate = val; }
    public UnderlyingIssueDate Get(UnderlyingIssueDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingIssueDate val) { return IsSetUnderlyingIssueDate(); }
    public bool IsSetUnderlyingIssueDate() { return IsSetField(Tags.UnderlyingIssueDate); }

    public UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
    {
        get
        {
            UnderlyingRepoCollateralSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRepoCollateralSecurityType val) { UnderlyingRepoCollateralSecurityType = val; }
    public UnderlyingRepoCollateralSecurityType Get(UnderlyingRepoCollateralSecurityType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRepoCollateralSecurityType val) { return IsSetUnderlyingRepoCollateralSecurityType(); }
    public bool IsSetUnderlyingRepoCollateralSecurityType() { return IsSetField(Tags.UnderlyingRepoCollateralSecurityType); }

    public UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
    {
        get
        {
            UnderlyingRepurchaseTerm val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRepurchaseTerm val) { UnderlyingRepurchaseTerm = val; }
    public UnderlyingRepurchaseTerm Get(UnderlyingRepurchaseTerm val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRepurchaseTerm val) { return IsSetUnderlyingRepurchaseTerm(); }
    public bool IsSetUnderlyingRepurchaseTerm() { return IsSetField(Tags.UnderlyingRepurchaseTerm); }

    public UnderlyingRepurchaseRate UnderlyingRepurchaseRate
    {
        get
        {
            UnderlyingRepurchaseRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRepurchaseRate val) { UnderlyingRepurchaseRate = val; }
    public UnderlyingRepurchaseRate Get(UnderlyingRepurchaseRate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRepurchaseRate val) { return IsSetUnderlyingRepurchaseRate(); }
    public bool IsSetUnderlyingRepurchaseRate() { return IsSetField(Tags.UnderlyingRepurchaseRate); }

    public UnderlyingFactor UnderlyingFactor
    {
        get
        {
            UnderlyingFactor val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingFactor val) { UnderlyingFactor = val; }
    public UnderlyingFactor Get(UnderlyingFactor val) { GetField(val); return val; }
    public bool IsSet(UnderlyingFactor val) { return IsSetUnderlyingFactor(); }
    public bool IsSetUnderlyingFactor() { return IsSetField(Tags.UnderlyingFactor); }

    public UnderlyingCreditRating UnderlyingCreditRating
    {
        get
        {
            UnderlyingCreditRating val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCreditRating val) { UnderlyingCreditRating = val; }
    public UnderlyingCreditRating Get(UnderlyingCreditRating val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCreditRating val) { return IsSetUnderlyingCreditRating(); }
    public bool IsSetUnderlyingCreditRating() { return IsSetField(Tags.UnderlyingCreditRating); }

    public UnderlyingInstrRegistry UnderlyingInstrRegistry
    {
        get
        {
            UnderlyingInstrRegistry val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingInstrRegistry val) { UnderlyingInstrRegistry = val; }
    public UnderlyingInstrRegistry Get(UnderlyingInstrRegistry val) { GetField(val); return val; }
    public bool IsSet(UnderlyingInstrRegistry val) { return IsSetUnderlyingInstrRegistry(); }
    public bool IsSetUnderlyingInstrRegistry() { return IsSetField(Tags.UnderlyingInstrRegistry); }

    public UnderlyingCountryOfIssue UnderlyingCountryOfIssue
    {
        get
        {
            UnderlyingCountryOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCountryOfIssue val) { UnderlyingCountryOfIssue = val; }
    public UnderlyingCountryOfIssue Get(UnderlyingCountryOfIssue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCountryOfIssue val) { return IsSetUnderlyingCountryOfIssue(); }
    public bool IsSetUnderlyingCountryOfIssue() { return IsSetField(Tags.UnderlyingCountryOfIssue); }

    public UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
    {
        get
        {
            UnderlyingStateOrProvinceOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingStateOrProvinceOfIssue val) { UnderlyingStateOrProvinceOfIssue = val; }
    public UnderlyingStateOrProvinceOfIssue Get(UnderlyingStateOrProvinceOfIssue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingStateOrProvinceOfIssue val) { return IsSetUnderlyingStateOrProvinceOfIssue(); }
    public bool IsSetUnderlyingStateOrProvinceOfIssue() { return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue); }

    public UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
    {
        get
        {
            UnderlyingLocaleOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingLocaleOfIssue val) { UnderlyingLocaleOfIssue = val; }
    public UnderlyingLocaleOfIssue Get(UnderlyingLocaleOfIssue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingLocaleOfIssue val) { return IsSetUnderlyingLocaleOfIssue(); }
    public bool IsSetUnderlyingLocaleOfIssue() { return IsSetField(Tags.UnderlyingLocaleOfIssue); }

    public UnderlyingRedemptionDate UnderlyingRedemptionDate
    {
        get
        {
            UnderlyingRedemptionDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRedemptionDate val) { UnderlyingRedemptionDate = val; }
    public UnderlyingRedemptionDate Get(UnderlyingRedemptionDate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRedemptionDate val) { return IsSetUnderlyingRedemptionDate(); }
    public bool IsSetUnderlyingRedemptionDate() { return IsSetField(Tags.UnderlyingRedemptionDate); }

    public UnderlyingStrikePrice UnderlyingStrikePrice
    {
        get
        {
            UnderlyingStrikePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingStrikePrice val) { UnderlyingStrikePrice = val; }
    public UnderlyingStrikePrice Get(UnderlyingStrikePrice val) { GetField(val); return val; }
    public bool IsSet(UnderlyingStrikePrice val) { return IsSetUnderlyingStrikePrice(); }
    public bool IsSetUnderlyingStrikePrice() { return IsSetField(Tags.UnderlyingStrikePrice); }

    public UnderlyingStrikeCurrency UnderlyingStrikeCurrency
    {
        get
        {
            UnderlyingStrikeCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingStrikeCurrency val) { UnderlyingStrikeCurrency = val; }
    public UnderlyingStrikeCurrency Get(UnderlyingStrikeCurrency val) { GetField(val); return val; }
    public bool IsSet(UnderlyingStrikeCurrency val) { return IsSetUnderlyingStrikeCurrency(); }
    public bool IsSetUnderlyingStrikeCurrency() { return IsSetField(Tags.UnderlyingStrikeCurrency); }

    public UnderlyingOptAttribute UnderlyingOptAttribute
    {
        get
        {
            UnderlyingOptAttribute val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingOptAttribute val) { UnderlyingOptAttribute = val; }
    public UnderlyingOptAttribute Get(UnderlyingOptAttribute val) { GetField(val); return val; }
    public bool IsSet(UnderlyingOptAttribute val) { return IsSetUnderlyingOptAttribute(); }
    public bool IsSetUnderlyingOptAttribute() { return IsSetField(Tags.UnderlyingOptAttribute); }

    public UnderlyingContractMultiplier UnderlyingContractMultiplier
    {
        get
        {
            UnderlyingContractMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingContractMultiplier val) { UnderlyingContractMultiplier = val; }
    public UnderlyingContractMultiplier Get(UnderlyingContractMultiplier val) { GetField(val); return val; }
    public bool IsSet(UnderlyingContractMultiplier val) { return IsSetUnderlyingContractMultiplier(); }
    public bool IsSetUnderlyingContractMultiplier() { return IsSetField(Tags.UnderlyingContractMultiplier); }

    public UnderlyingCouponRate UnderlyingCouponRate
    {
        get
        {
            UnderlyingCouponRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCouponRate val) { UnderlyingCouponRate = val; }
    public UnderlyingCouponRate Get(UnderlyingCouponRate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCouponRate val) { return IsSetUnderlyingCouponRate(); }
    public bool IsSetUnderlyingCouponRate() { return IsSetField(Tags.UnderlyingCouponRate); }

    public UnderlyingSecurityExchange UnderlyingSecurityExchange
    {
        get
        {
            UnderlyingSecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityExchange val) { UnderlyingSecurityExchange = val; }
    public UnderlyingSecurityExchange Get(UnderlyingSecurityExchange val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityExchange val) { return IsSetUnderlyingSecurityExchange(); }
    public bool IsSetUnderlyingSecurityExchange() { return IsSetField(Tags.UnderlyingSecurityExchange); }

    public UnderlyingIssuer UnderlyingIssuer
    {
        get
        {
            UnderlyingIssuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingIssuer val) { UnderlyingIssuer = val; }
    public UnderlyingIssuer Get(UnderlyingIssuer val) { GetField(val); return val; }
    public bool IsSet(UnderlyingIssuer val) { return IsSetUnderlyingIssuer(); }
    public bool IsSetUnderlyingIssuer() { return IsSetField(Tags.UnderlyingIssuer); }

    public EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
    {
        get
        {
            EncodedUnderlyingIssuerLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedUnderlyingIssuerLen val) { EncodedUnderlyingIssuerLen = val; }
    public EncodedUnderlyingIssuerLen Get(EncodedUnderlyingIssuerLen val) { GetField(val); return val; }
    public bool IsSet(EncodedUnderlyingIssuerLen val) { return IsSetEncodedUnderlyingIssuerLen(); }
    public bool IsSetEncodedUnderlyingIssuerLen() { return IsSetField(Tags.EncodedUnderlyingIssuerLen); }

    public EncodedUnderlyingIssuer EncodedUnderlyingIssuer
    {
        get
        {
            EncodedUnderlyingIssuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedUnderlyingIssuer val) { EncodedUnderlyingIssuer = val; }
    public EncodedUnderlyingIssuer Get(EncodedUnderlyingIssuer val) { GetField(val); return val; }
    public bool IsSet(EncodedUnderlyingIssuer val) { return IsSetEncodedUnderlyingIssuer(); }
    public bool IsSetEncodedUnderlyingIssuer() { return IsSetField(Tags.EncodedUnderlyingIssuer); }

    public UnderlyingSecurityDesc UnderlyingSecurityDesc
    {
        get
        {
            UnderlyingSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSecurityDesc val) { UnderlyingSecurityDesc = val; }
    public UnderlyingSecurityDesc Get(UnderlyingSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSecurityDesc val) { return IsSetUnderlyingSecurityDesc(); }
    public bool IsSetUnderlyingSecurityDesc() { return IsSetField(Tags.UnderlyingSecurityDesc); }

    public EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
    {
        get
        {
            EncodedUnderlyingSecurityDescLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedUnderlyingSecurityDescLen val) { EncodedUnderlyingSecurityDescLen = val; }
    public EncodedUnderlyingSecurityDescLen Get(EncodedUnderlyingSecurityDescLen val) { GetField(val); return val; }
    public bool IsSet(EncodedUnderlyingSecurityDescLen val) { return IsSetEncodedUnderlyingSecurityDescLen(); }
    public bool IsSetEncodedUnderlyingSecurityDescLen() { return IsSetField(Tags.EncodedUnderlyingSecurityDescLen); }

    public EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
    {
        get
        {
            EncodedUnderlyingSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedUnderlyingSecurityDesc val) { EncodedUnderlyingSecurityDesc = val; }
    public EncodedUnderlyingSecurityDesc Get(EncodedUnderlyingSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(EncodedUnderlyingSecurityDesc val) { return IsSetEncodedUnderlyingSecurityDesc(); }
    public bool IsSetEncodedUnderlyingSecurityDesc() { return IsSetField(Tags.EncodedUnderlyingSecurityDesc); }

    public UnderlyingCPProgram UnderlyingCPProgram
    {
        get
        {
            UnderlyingCPProgram val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCPProgram val) { UnderlyingCPProgram = val; }
    public UnderlyingCPProgram Get(UnderlyingCPProgram val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCPProgram val) { return IsSetUnderlyingCPProgram(); }
    public bool IsSetUnderlyingCPProgram() { return IsSetField(Tags.UnderlyingCPProgram); }

    public UnderlyingCPRegType UnderlyingCPRegType
    {
        get
        {
            UnderlyingCPRegType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCPRegType val) { UnderlyingCPRegType = val; }
    public UnderlyingCPRegType Get(UnderlyingCPRegType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCPRegType val) { return IsSetUnderlyingCPRegType(); }
    public bool IsSetUnderlyingCPRegType() { return IsSetField(Tags.UnderlyingCPRegType); }

    public UnderlyingCurrency UnderlyingCurrency
    {
        get
        {
            UnderlyingCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCurrency val) { UnderlyingCurrency = val; }
    public UnderlyingCurrency Get(UnderlyingCurrency val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCurrency val) { return IsSetUnderlyingCurrency(); }
    public bool IsSetUnderlyingCurrency() { return IsSetField(Tags.UnderlyingCurrency); }

    public UnderlyingQty UnderlyingQty
    {
        get
        {
            UnderlyingQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingQty val) { UnderlyingQty = val; }
    public UnderlyingQty Get(UnderlyingQty val) { GetField(val); return val; }
    public bool IsSet(UnderlyingQty val) { return IsSetUnderlyingQty(); }
    public bool IsSetUnderlyingQty() { return IsSetField(Tags.UnderlyingQty); }

    public UnderlyingPx UnderlyingPx
    {
        get
        {
            UnderlyingPx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPx val) { UnderlyingPx = val; }
    public UnderlyingPx Get(UnderlyingPx val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPx val) { return IsSetUnderlyingPx(); }
    public bool IsSetUnderlyingPx() { return IsSetField(Tags.UnderlyingPx); }

    public UnderlyingDirtyPrice UnderlyingDirtyPrice
    {
        get
        {
            UnderlyingDirtyPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingDirtyPrice val) { UnderlyingDirtyPrice = val; }
    public UnderlyingDirtyPrice Get(UnderlyingDirtyPrice val) { GetField(val); return val; }
    public bool IsSet(UnderlyingDirtyPrice val) { return IsSetUnderlyingDirtyPrice(); }
    public bool IsSetUnderlyingDirtyPrice() { return IsSetField(Tags.UnderlyingDirtyPrice); }

    public UnderlyingEndPrice UnderlyingEndPrice
    {
        get
        {
            UnderlyingEndPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingEndPrice val) { UnderlyingEndPrice = val; }
    public UnderlyingEndPrice Get(UnderlyingEndPrice val) { GetField(val); return val; }
    public bool IsSet(UnderlyingEndPrice val) { return IsSetUnderlyingEndPrice(); }
    public bool IsSetUnderlyingEndPrice() { return IsSetField(Tags.UnderlyingEndPrice); }

    public UnderlyingStartValue UnderlyingStartValue
    {
        get
        {
            UnderlyingStartValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingStartValue val) { UnderlyingStartValue = val; }
    public UnderlyingStartValue Get(UnderlyingStartValue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingStartValue val) { return IsSetUnderlyingStartValue(); }
    public bool IsSetUnderlyingStartValue() { return IsSetField(Tags.UnderlyingStartValue); }

    public UnderlyingCurrentValue UnderlyingCurrentValue
    {
        get
        {
            UnderlyingCurrentValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCurrentValue val) { UnderlyingCurrentValue = val; }
    public UnderlyingCurrentValue Get(UnderlyingCurrentValue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCurrentValue val) { return IsSetUnderlyingCurrentValue(); }
    public bool IsSetUnderlyingCurrentValue() { return IsSetField(Tags.UnderlyingCurrentValue); }

    public UnderlyingEndValue UnderlyingEndValue
    {
        get
        {
            UnderlyingEndValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingEndValue val) { UnderlyingEndValue = val; }
    public UnderlyingEndValue Get(UnderlyingEndValue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingEndValue val) { return IsSetUnderlyingEndValue(); }
    public bool IsSetUnderlyingEndValue() { return IsSetField(Tags.UnderlyingEndValue); }

    public NoUnderlyingStips NoUnderlyingStips
    {
        get
        {
            NoUnderlyingStips val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUnderlyingStips val) { NoUnderlyingStips = val; }
    public NoUnderlyingStips Get(NoUnderlyingStips val) { GetField(val); return val; }
    public bool IsSet(NoUnderlyingStips val) { return IsSetNoUnderlyingStips(); }
    public bool IsSetNoUnderlyingStips() { return IsSetField(Tags.NoUnderlyingStips); }

    public UnderlyingAllocationPercent UnderlyingAllocationPercent
    {
        get
        {
            UnderlyingAllocationPercent val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingAllocationPercent val) { UnderlyingAllocationPercent = val; }
    public UnderlyingAllocationPercent Get(UnderlyingAllocationPercent val) { GetField(val); return val; }
    public bool IsSet(UnderlyingAllocationPercent val) { return IsSetUnderlyingAllocationPercent(); }
    public bool IsSetUnderlyingAllocationPercent() { return IsSetField(Tags.UnderlyingAllocationPercent); }

    public UnderlyingSettlementType UnderlyingSettlementType
    {
        get
        {
            UnderlyingSettlementType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSettlementType val) { UnderlyingSettlementType = val; }
    public UnderlyingSettlementType Get(UnderlyingSettlementType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSettlementType val) { return IsSetUnderlyingSettlementType(); }
    public bool IsSetUnderlyingSettlementType() { return IsSetField(Tags.UnderlyingSettlementType); }

    public UnderlyingCashAmount UnderlyingCashAmount
    {
        get
        {
            UnderlyingCashAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCashAmount val) { UnderlyingCashAmount = val; }
    public UnderlyingCashAmount Get(UnderlyingCashAmount val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCashAmount val) { return IsSetUnderlyingCashAmount(); }
    public bool IsSetUnderlyingCashAmount() { return IsSetField(Tags.UnderlyingCashAmount); }

    public UnderlyingCashType UnderlyingCashType
    {
        get
        {
            UnderlyingCashType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCashType val) { UnderlyingCashType = val; }
    public UnderlyingCashType Get(UnderlyingCashType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCashType val) { return IsSetUnderlyingCashType(); }
    public bool IsSetUnderlyingCashType() { return IsSetField(Tags.UnderlyingCashType); }

    public UnderlyingUnitOfMeasure UnderlyingUnitOfMeasure
    {
        get
        {
            UnderlyingUnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingUnitOfMeasure val) { UnderlyingUnitOfMeasure = val; }
    public UnderlyingUnitOfMeasure Get(UnderlyingUnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(UnderlyingUnitOfMeasure val) { return IsSetUnderlyingUnitOfMeasure(); }
    public bool IsSetUnderlyingUnitOfMeasure() { return IsSetField(Tags.UnderlyingUnitOfMeasure); }

    public UnderlyingTimeUnit UnderlyingTimeUnit
    {
        get
        {
            UnderlyingTimeUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingTimeUnit val) { UnderlyingTimeUnit = val; }
    public UnderlyingTimeUnit Get(UnderlyingTimeUnit val) { GetField(val); return val; }
    public bool IsSet(UnderlyingTimeUnit val) { return IsSetUnderlyingTimeUnit(); }
    public bool IsSetUnderlyingTimeUnit() { return IsSetField(Tags.UnderlyingTimeUnit); }

    public UnderlyingCapValue UnderlyingCapValue
    {
        get
        {
            UnderlyingCapValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingCapValue val) { UnderlyingCapValue = val; }
    public UnderlyingCapValue Get(UnderlyingCapValue val) { GetField(val); return val; }
    public bool IsSet(UnderlyingCapValue val) { return IsSetUnderlyingCapValue(); }
    public bool IsSetUnderlyingCapValue() { return IsSetField(Tags.UnderlyingCapValue); }

    public NoUndlyInstrumentParties NoUndlyInstrumentParties
    {
        get
        {
            NoUndlyInstrumentParties val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoUndlyInstrumentParties val) { NoUndlyInstrumentParties = val; }
    public NoUndlyInstrumentParties Get(NoUndlyInstrumentParties val) { GetField(val); return val; }
    public bool IsSet(NoUndlyInstrumentParties val) { return IsSetNoUndlyInstrumentParties(); }
    public bool IsSetNoUndlyInstrumentParties() { return IsSetField(Tags.NoUndlyInstrumentParties); }

    public UnderlyingSettlMethod UnderlyingSettlMethod
    {
        get
        {
            UnderlyingSettlMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSettlMethod val) { UnderlyingSettlMethod = val; }
    public UnderlyingSettlMethod Get(UnderlyingSettlMethod val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSettlMethod val) { return IsSetUnderlyingSettlMethod(); }
    public bool IsSetUnderlyingSettlMethod() { return IsSetField(Tags.UnderlyingSettlMethod); }

    public UnderlyingAdjustedQuantity UnderlyingAdjustedQuantity
    {
        get
        {
            UnderlyingAdjustedQuantity val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingAdjustedQuantity val) { UnderlyingAdjustedQuantity = val; }
    public UnderlyingAdjustedQuantity Get(UnderlyingAdjustedQuantity val) { GetField(val); return val; }
    public bool IsSet(UnderlyingAdjustedQuantity val) { return IsSetUnderlyingAdjustedQuantity(); }
    public bool IsSetUnderlyingAdjustedQuantity() { return IsSetField(Tags.UnderlyingAdjustedQuantity); }

    public UnderlyingFXRate UnderlyingFXRate
    {
        get
        {
            UnderlyingFXRate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingFXRate val) { UnderlyingFXRate = val; }
    public UnderlyingFXRate Get(UnderlyingFXRate val) { GetField(val); return val; }
    public bool IsSet(UnderlyingFXRate val) { return IsSetUnderlyingFXRate(); }
    public bool IsSetUnderlyingFXRate() { return IsSetField(Tags.UnderlyingFXRate); }

    public UnderlyingFXRateCalc UnderlyingFXRateCalc
    {
        get
        {
            UnderlyingFXRateCalc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingFXRateCalc val) { UnderlyingFXRateCalc = val; }
    public UnderlyingFXRateCalc Get(UnderlyingFXRateCalc val) { GetField(val); return val; }
    public bool IsSet(UnderlyingFXRateCalc val) { return IsSetUnderlyingFXRateCalc(); }
    public bool IsSetUnderlyingFXRateCalc() { return IsSetField(Tags.UnderlyingFXRateCalc); }

    public UnderlyingMaturityTime UnderlyingMaturityTime
    {
        get
        {
            UnderlyingMaturityTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingMaturityTime val) { UnderlyingMaturityTime = val; }
    public UnderlyingMaturityTime Get(UnderlyingMaturityTime val) { GetField(val); return val; }
    public bool IsSet(UnderlyingMaturityTime val) { return IsSetUnderlyingMaturityTime(); }
    public bool IsSetUnderlyingMaturityTime() { return IsSetField(Tags.UnderlyingMaturityTime); }

    public UnderlyingPutOrCall UnderlyingPutOrCall
    {
        get
        {
            UnderlyingPutOrCall val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPutOrCall val) { UnderlyingPutOrCall = val; }
    public UnderlyingPutOrCall Get(UnderlyingPutOrCall val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPutOrCall val) { return IsSetUnderlyingPutOrCall(); }
    public bool IsSetUnderlyingPutOrCall() { return IsSetField(Tags.UnderlyingPutOrCall); }

    public UnderlyingExerciseStyle UnderlyingExerciseStyle
    {
        get
        {
            UnderlyingExerciseStyle val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingExerciseStyle val) { UnderlyingExerciseStyle = val; }
    public UnderlyingExerciseStyle Get(UnderlyingExerciseStyle val) { GetField(val); return val; }
    public bool IsSet(UnderlyingExerciseStyle val) { return IsSetUnderlyingExerciseStyle(); }
    public bool IsSetUnderlyingExerciseStyle() { return IsSetField(Tags.UnderlyingExerciseStyle); }

    public UnderlyingUnitOfMeasureQty UnderlyingUnitOfMeasureQty
    {
        get
        {
            UnderlyingUnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingUnitOfMeasureQty val) { UnderlyingUnitOfMeasureQty = val; }
    public UnderlyingUnitOfMeasureQty Get(UnderlyingUnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(UnderlyingUnitOfMeasureQty val) { return IsSetUnderlyingUnitOfMeasureQty(); }
    public bool IsSetUnderlyingUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingUnitOfMeasureQty); }

    public UnderlyingPriceUnitOfMeasure UnderlyingPriceUnitOfMeasure
    {
        get
        {
            UnderlyingPriceUnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPriceUnitOfMeasure val) { UnderlyingPriceUnitOfMeasure = val; }
    public UnderlyingPriceUnitOfMeasure Get(UnderlyingPriceUnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPriceUnitOfMeasure val) { return IsSetUnderlyingPriceUnitOfMeasure(); }
    public bool IsSetUnderlyingPriceUnitOfMeasure() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasure); }

    public UnderlyingPriceUnitOfMeasureQty UnderlyingPriceUnitOfMeasureQty
    {
        get
        {
            UnderlyingPriceUnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingPriceUnitOfMeasureQty val) { UnderlyingPriceUnitOfMeasureQty = val; }
    public UnderlyingPriceUnitOfMeasureQty Get(UnderlyingPriceUnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(UnderlyingPriceUnitOfMeasureQty val) { return IsSetUnderlyingPriceUnitOfMeasureQty(); }
    public bool IsSetUnderlyingPriceUnitOfMeasureQty() { return IsSetField(Tags.UnderlyingPriceUnitOfMeasureQty); }

    public UnderlyingContractMultiplierUnit UnderlyingContractMultiplierUnit
    {
        get
        {
            UnderlyingContractMultiplierUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingContractMultiplierUnit val) { UnderlyingContractMultiplierUnit = val; }
    public UnderlyingContractMultiplierUnit Get(UnderlyingContractMultiplierUnit val) { GetField(val); return val; }
    public bool IsSet(UnderlyingContractMultiplierUnit val) { return IsSetUnderlyingContractMultiplierUnit(); }
    public bool IsSetUnderlyingContractMultiplierUnit() { return IsSetField(Tags.UnderlyingContractMultiplierUnit); }

    public UnderlyingFlowScheduleType UnderlyingFlowScheduleType
    {
        get
        {
            UnderlyingFlowScheduleType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingFlowScheduleType val) { UnderlyingFlowScheduleType = val; }
    public UnderlyingFlowScheduleType Get(UnderlyingFlowScheduleType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingFlowScheduleType val) { return IsSetUnderlyingFlowScheduleType(); }
    public bool IsSetUnderlyingFlowScheduleType() { return IsSetField(Tags.UnderlyingFlowScheduleType); }

    public UnderlyingRestructuringType UnderlyingRestructuringType
    {
        get
        {
            UnderlyingRestructuringType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingRestructuringType val) { UnderlyingRestructuringType = val; }
    public UnderlyingRestructuringType Get(UnderlyingRestructuringType val) { GetField(val); return val; }
    public bool IsSet(UnderlyingRestructuringType val) { return IsSetUnderlyingRestructuringType(); }
    public bool IsSetUnderlyingRestructuringType() { return IsSetField(Tags.UnderlyingRestructuringType); }

    public UnderlyingSeniority UnderlyingSeniority
    {
        get
        {
            UnderlyingSeniority val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingSeniority val) { UnderlyingSeniority = val; }
    public UnderlyingSeniority Get(UnderlyingSeniority val) { GetField(val); return val; }
    public bool IsSet(UnderlyingSeniority val) { return IsSetUnderlyingSeniority(); }
    public bool IsSetUnderlyingSeniority() { return IsSetField(Tags.UnderlyingSeniority); }

    public UnderlyingNotionalPercentageOutstanding UnderlyingNotionalPercentageOutstanding
    {
        get
        {
            UnderlyingNotionalPercentageOutstanding val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingNotionalPercentageOutstanding val) { UnderlyingNotionalPercentageOutstanding = val; }
    public UnderlyingNotionalPercentageOutstanding Get(UnderlyingNotionalPercentageOutstanding val) { GetField(val); return val; }
    public bool IsSet(UnderlyingNotionalPercentageOutstanding val) { return IsSetUnderlyingNotionalPercentageOutstanding(); }
    public bool IsSetUnderlyingNotionalPercentageOutstanding() { return IsSetField(Tags.UnderlyingNotionalPercentageOutstanding); }

    public UnderlyingOriginalNotionalPercentageOutstanding UnderlyingOriginalNotionalPercentageOutstanding
    {
        get
        {
            UnderlyingOriginalNotionalPercentageOutstanding val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingOriginalNotionalPercentageOutstanding val) { UnderlyingOriginalNotionalPercentageOutstanding = val; }
    public UnderlyingOriginalNotionalPercentageOutstanding Get(UnderlyingOriginalNotionalPercentageOutstanding val) { GetField(val); return val; }
    public bool IsSet(UnderlyingOriginalNotionalPercentageOutstanding val) { return IsSetUnderlyingOriginalNotionalPercentageOutstanding(); }
    public bool IsSetUnderlyingOriginalNotionalPercentageOutstanding() { return IsSetField(Tags.UnderlyingOriginalNotionalPercentageOutstanding); }

    public UnderlyingAttachmentPoint UnderlyingAttachmentPoint
    {
        get
        {
            UnderlyingAttachmentPoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingAttachmentPoint val) { UnderlyingAttachmentPoint = val; }
    public UnderlyingAttachmentPoint Get(UnderlyingAttachmentPoint val) { GetField(val); return val; }
    public bool IsSet(UnderlyingAttachmentPoint val) { return IsSetUnderlyingAttachmentPoint(); }
    public bool IsSetUnderlyingAttachmentPoint() { return IsSetField(Tags.UnderlyingAttachmentPoint); }

    public UnderlyingDetachmentPoint UnderlyingDetachmentPoint
    {
        get
        {
            UnderlyingDetachmentPoint val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(UnderlyingDetachmentPoint val) { UnderlyingDetachmentPoint = val; }
    public UnderlyingDetachmentPoint Get(UnderlyingDetachmentPoint val) { GetField(val); return val; }
    public bool IsSet(UnderlyingDetachmentPoint val) { return IsSetUnderlyingDetachmentPoint(); }
    public bool IsSetUnderlyingDetachmentPoint() { return IsSetField(Tags.UnderlyingDetachmentPoint); }

    public SecuritySubType SecuritySubType
    {
        get
        {
            SecuritySubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecuritySubType val) { SecuritySubType = val; }
    public SecuritySubType Get(SecuritySubType val) { GetField(val); return val; }
    public bool IsSet(SecuritySubType val) { return IsSetSecuritySubType(); }
    public bool IsSetSecuritySubType() { return IsSetField(Tags.SecuritySubType); }

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

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

    public TradingSessionID TradingSessionID
    {
        get
        {
            TradingSessionID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSessionID val) { TradingSessionID = val; }
    public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
    public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
    public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

    public TradingSessionSubID TradingSessionSubID
    {
        get
        {
            TradingSessionSubID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradingSessionSubID val) { TradingSessionSubID = val; }
    public TradingSessionSubID Get(TradingSessionSubID val) { GetField(val); return val; }
    public bool IsSet(TradingSessionSubID val) { return IsSetTradingSessionSubID(); }
    public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }

    public SubscriptionRequestType SubscriptionRequestType
    {
        get
        {
            SubscriptionRequestType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SubscriptionRequestType val) { SubscriptionRequestType = val; }
    public SubscriptionRequestType Get(SubscriptionRequestType val) { GetField(val); return val; }
    public bool IsSet(SubscriptionRequestType val) { return IsSetSubscriptionRequestType(); }
    public bool IsSetSubscriptionRequestType() { return IsSetField(Tags.SubscriptionRequestType); }

    public MarketID MarketID
    {
        get
        {
            MarketID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketID val) { MarketID = val; }
    public MarketID Get(MarketID val) { GetField(val); return val; }
    public bool IsSet(MarketID val) { return IsSetMarketID(); }
    public bool IsSetMarketID() { return IsSetField(Tags.MarketID); }

    public MarketSegmentID MarketSegmentID
    {
        get
        {
            MarketSegmentID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketSegmentID val) { MarketSegmentID = val; }
    public MarketSegmentID Get(MarketSegmentID val) { GetField(val); return val; }
    public bool IsSet(MarketSegmentID val) { return IsSetMarketSegmentID(); }
    public bool IsSetMarketSegmentID() { return IsSetField(Tags.MarketSegmentID); }

    public DerivativeSymbol DerivativeSymbol
    {
        get
        {
            DerivativeSymbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSymbol val) { DerivativeSymbol = val; }
    public DerivativeSymbol Get(DerivativeSymbol val) { GetField(val); return val; }
    public bool IsSet(DerivativeSymbol val) { return IsSetDerivativeSymbol(); }
    public bool IsSetDerivativeSymbol() { return IsSetField(Tags.DerivativeSymbol); }

    public DerivativeSymbolSfx DerivativeSymbolSfx
    {
        get
        {
            DerivativeSymbolSfx val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSymbolSfx val) { DerivativeSymbolSfx = val; }
    public DerivativeSymbolSfx Get(DerivativeSymbolSfx val) { GetField(val); return val; }
    public bool IsSet(DerivativeSymbolSfx val) { return IsSetDerivativeSymbolSfx(); }
    public bool IsSetDerivativeSymbolSfx() { return IsSetField(Tags.DerivativeSymbolSfx); }

    public DerivativeSecurityID DerivativeSecurityID
    {
        get
        {
            DerivativeSecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityID val) { DerivativeSecurityID = val; }
    public DerivativeSecurityID Get(DerivativeSecurityID val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityID val) { return IsSetDerivativeSecurityID(); }
    public bool IsSetDerivativeSecurityID() { return IsSetField(Tags.DerivativeSecurityID); }

    public DerivativeSecurityIDSource DerivativeSecurityIDSource
    {
        get
        {
            DerivativeSecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityIDSource val) { DerivativeSecurityIDSource = val; }
    public DerivativeSecurityIDSource Get(DerivativeSecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityIDSource val) { return IsSetDerivativeSecurityIDSource(); }
    public bool IsSetDerivativeSecurityIDSource() { return IsSetField(Tags.DerivativeSecurityIDSource); }

    public NoDerivativeSecurityAltID NoDerivativeSecurityAltID
    {
        get
        {
            NoDerivativeSecurityAltID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoDerivativeSecurityAltID val) { NoDerivativeSecurityAltID = val; }
    public NoDerivativeSecurityAltID Get(NoDerivativeSecurityAltID val) { GetField(val); return val; }
    public bool IsSet(NoDerivativeSecurityAltID val) { return IsSetNoDerivativeSecurityAltID(); }
    public bool IsSetNoDerivativeSecurityAltID() { return IsSetField(Tags.NoDerivativeSecurityAltID); }

    public DerivativeProduct DerivativeProduct
    {
        get
        {
            DerivativeProduct val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeProduct val) { DerivativeProduct = val; }
    public DerivativeProduct Get(DerivativeProduct val) { GetField(val); return val; }
    public bool IsSet(DerivativeProduct val) { return IsSetDerivativeProduct(); }
    public bool IsSetDerivativeProduct() { return IsSetField(Tags.DerivativeProduct); }

    public DerivativeProductComplex DerivativeProductComplex
    {
        get
        {
            DerivativeProductComplex val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeProductComplex val) { DerivativeProductComplex = val; }
    public DerivativeProductComplex Get(DerivativeProductComplex val) { GetField(val); return val; }
    public bool IsSet(DerivativeProductComplex val) { return IsSetDerivativeProductComplex(); }
    public bool IsSetDerivativeProductComplex() { return IsSetField(Tags.DerivativeProductComplex); }

    public DerivFlexProductEligibilityIndicator DerivFlexProductEligibilityIndicator
    {
        get
        {
            DerivFlexProductEligibilityIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivFlexProductEligibilityIndicator val) { DerivFlexProductEligibilityIndicator = val; }
    public DerivFlexProductEligibilityIndicator Get(DerivFlexProductEligibilityIndicator val) { GetField(val); return val; }
    public bool IsSet(DerivFlexProductEligibilityIndicator val) { return IsSetDerivFlexProductEligibilityIndicator(); }
    public bool IsSetDerivFlexProductEligibilityIndicator() { return IsSetField(Tags.DerivFlexProductEligibilityIndicator); }

    public DerivativeSecurityGroup DerivativeSecurityGroup
    {
        get
        {
            DerivativeSecurityGroup val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityGroup val) { DerivativeSecurityGroup = val; }
    public DerivativeSecurityGroup Get(DerivativeSecurityGroup val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityGroup val) { return IsSetDerivativeSecurityGroup(); }
    public bool IsSetDerivativeSecurityGroup() { return IsSetField(Tags.DerivativeSecurityGroup); }

    public DerivativeCFICode DerivativeCFICode
    {
        get
        {
            DerivativeCFICode val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeCFICode val) { DerivativeCFICode = val; }
    public DerivativeCFICode Get(DerivativeCFICode val) { GetField(val); return val; }
    public bool IsSet(DerivativeCFICode val) { return IsSetDerivativeCFICode(); }
    public bool IsSetDerivativeCFICode() { return IsSetField(Tags.DerivativeCFICode); }

    public DerivativeSecurityType DerivativeSecurityType
    {
        get
        {
            DerivativeSecurityType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityType val) { DerivativeSecurityType = val; }
    public DerivativeSecurityType Get(DerivativeSecurityType val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityType val) { return IsSetDerivativeSecurityType(); }
    public bool IsSetDerivativeSecurityType() { return IsSetField(Tags.DerivativeSecurityType); }

    public DerivativeSecuritySubType DerivativeSecuritySubType
    {
        get
        {
            DerivativeSecuritySubType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecuritySubType val) { DerivativeSecuritySubType = val; }
    public DerivativeSecuritySubType Get(DerivativeSecuritySubType val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecuritySubType val) { return IsSetDerivativeSecuritySubType(); }
    public bool IsSetDerivativeSecuritySubType() { return IsSetField(Tags.DerivativeSecuritySubType); }

    public DerivativeMaturityMonthYear DerivativeMaturityMonthYear
    {
        get
        {
            DerivativeMaturityMonthYear val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeMaturityMonthYear val) { DerivativeMaturityMonthYear = val; }
    public DerivativeMaturityMonthYear Get(DerivativeMaturityMonthYear val) { GetField(val); return val; }
    public bool IsSet(DerivativeMaturityMonthYear val) { return IsSetDerivativeMaturityMonthYear(); }
    public bool IsSetDerivativeMaturityMonthYear() { return IsSetField(Tags.DerivativeMaturityMonthYear); }

    public DerivativeMaturityDate DerivativeMaturityDate
    {
        get
        {
            DerivativeMaturityDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeMaturityDate val) { DerivativeMaturityDate = val; }
    public DerivativeMaturityDate Get(DerivativeMaturityDate val) { GetField(val); return val; }
    public bool IsSet(DerivativeMaturityDate val) { return IsSetDerivativeMaturityDate(); }
    public bool IsSetDerivativeMaturityDate() { return IsSetField(Tags.DerivativeMaturityDate); }

    public DerivativeMaturityTime DerivativeMaturityTime
    {
        get
        {
            DerivativeMaturityTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeMaturityTime val) { DerivativeMaturityTime = val; }
    public DerivativeMaturityTime Get(DerivativeMaturityTime val) { GetField(val); return val; }
    public bool IsSet(DerivativeMaturityTime val) { return IsSetDerivativeMaturityTime(); }
    public bool IsSetDerivativeMaturityTime() { return IsSetField(Tags.DerivativeMaturityTime); }

    public DerivativeSettleOnOpenFlag DerivativeSettleOnOpenFlag
    {
        get
        {
            DerivativeSettleOnOpenFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSettleOnOpenFlag val) { DerivativeSettleOnOpenFlag = val; }
    public DerivativeSettleOnOpenFlag Get(DerivativeSettleOnOpenFlag val) { GetField(val); return val; }
    public bool IsSet(DerivativeSettleOnOpenFlag val) { return IsSetDerivativeSettleOnOpenFlag(); }
    public bool IsSetDerivativeSettleOnOpenFlag() { return IsSetField(Tags.DerivativeSettleOnOpenFlag); }

    public DerivativeInstrmtAssignmentMethod DerivativeInstrmtAssignmentMethod
    {
        get
        {
            DerivativeInstrmtAssignmentMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeInstrmtAssignmentMethod val) { DerivativeInstrmtAssignmentMethod = val; }
    public DerivativeInstrmtAssignmentMethod Get(DerivativeInstrmtAssignmentMethod val) { GetField(val); return val; }
    public bool IsSet(DerivativeInstrmtAssignmentMethod val) { return IsSetDerivativeInstrmtAssignmentMethod(); }
    public bool IsSetDerivativeInstrmtAssignmentMethod() { return IsSetField(Tags.DerivativeInstrmtAssignmentMethod); }

    public DerivativeSecurityStatus DerivativeSecurityStatus
    {
        get
        {
            DerivativeSecurityStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityStatus val) { DerivativeSecurityStatus = val; }
    public DerivativeSecurityStatus Get(DerivativeSecurityStatus val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityStatus val) { return IsSetDerivativeSecurityStatus(); }
    public bool IsSetDerivativeSecurityStatus() { return IsSetField(Tags.DerivativeSecurityStatus); }

    public DerivativeIssueDate DerivativeIssueDate
    {
        get
        {
            DerivativeIssueDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeIssueDate val) { DerivativeIssueDate = val; }
    public DerivativeIssueDate Get(DerivativeIssueDate val) { GetField(val); return val; }
    public bool IsSet(DerivativeIssueDate val) { return IsSetDerivativeIssueDate(); }
    public bool IsSetDerivativeIssueDate() { return IsSetField(Tags.DerivativeIssueDate); }

    public DerivativeInstrRegistry DerivativeInstrRegistry
    {
        get
        {
            DerivativeInstrRegistry val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeInstrRegistry val) { DerivativeInstrRegistry = val; }
    public DerivativeInstrRegistry Get(DerivativeInstrRegistry val) { GetField(val); return val; }
    public bool IsSet(DerivativeInstrRegistry val) { return IsSetDerivativeInstrRegistry(); }
    public bool IsSetDerivativeInstrRegistry() { return IsSetField(Tags.DerivativeInstrRegistry); }

    public DerivativeCountryOfIssue DerivativeCountryOfIssue
    {
        get
        {
            DerivativeCountryOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeCountryOfIssue val) { DerivativeCountryOfIssue = val; }
    public DerivativeCountryOfIssue Get(DerivativeCountryOfIssue val) { GetField(val); return val; }
    public bool IsSet(DerivativeCountryOfIssue val) { return IsSetDerivativeCountryOfIssue(); }
    public bool IsSetDerivativeCountryOfIssue() { return IsSetField(Tags.DerivativeCountryOfIssue); }

    public DerivativeStateOrProvinceOfIssue DerivativeStateOrProvinceOfIssue
    {
        get
        {
            DerivativeStateOrProvinceOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeStateOrProvinceOfIssue val) { DerivativeStateOrProvinceOfIssue = val; }
    public DerivativeStateOrProvinceOfIssue Get(DerivativeStateOrProvinceOfIssue val) { GetField(val); return val; }
    public bool IsSet(DerivativeStateOrProvinceOfIssue val) { return IsSetDerivativeStateOrProvinceOfIssue(); }
    public bool IsSetDerivativeStateOrProvinceOfIssue() { return IsSetField(Tags.DerivativeStateOrProvinceOfIssue); }

    public DerivativeStrikePrice DerivativeStrikePrice
    {
        get
        {
            DerivativeStrikePrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeStrikePrice val) { DerivativeStrikePrice = val; }
    public DerivativeStrikePrice Get(DerivativeStrikePrice val) { GetField(val); return val; }
    public bool IsSet(DerivativeStrikePrice val) { return IsSetDerivativeStrikePrice(); }
    public bool IsSetDerivativeStrikePrice() { return IsSetField(Tags.DerivativeStrikePrice); }

    public DerivativeLocaleOfIssue DerivativeLocaleOfIssue
    {
        get
        {
            DerivativeLocaleOfIssue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeLocaleOfIssue val) { DerivativeLocaleOfIssue = val; }
    public DerivativeLocaleOfIssue Get(DerivativeLocaleOfIssue val) { GetField(val); return val; }
    public bool IsSet(DerivativeLocaleOfIssue val) { return IsSetDerivativeLocaleOfIssue(); }
    public bool IsSetDerivativeLocaleOfIssue() { return IsSetField(Tags.DerivativeLocaleOfIssue); }

    public DerivativeStrikeCurrency DerivativeStrikeCurrency
    {
        get
        {
            DerivativeStrikeCurrency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeStrikeCurrency val) { DerivativeStrikeCurrency = val; }
    public DerivativeStrikeCurrency Get(DerivativeStrikeCurrency val) { GetField(val); return val; }
    public bool IsSet(DerivativeStrikeCurrency val) { return IsSetDerivativeStrikeCurrency(); }
    public bool IsSetDerivativeStrikeCurrency() { return IsSetField(Tags.DerivativeStrikeCurrency); }

    public DerivativeStrikeMultiplier DerivativeStrikeMultiplier
    {
        get
        {
            DerivativeStrikeMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeStrikeMultiplier val) { DerivativeStrikeMultiplier = val; }
    public DerivativeStrikeMultiplier Get(DerivativeStrikeMultiplier val) { GetField(val); return val; }
    public bool IsSet(DerivativeStrikeMultiplier val) { return IsSetDerivativeStrikeMultiplier(); }
    public bool IsSetDerivativeStrikeMultiplier() { return IsSetField(Tags.DerivativeStrikeMultiplier); }

    public DerivativeStrikeValue DerivativeStrikeValue
    {
        get
        {
            DerivativeStrikeValue val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeStrikeValue val) { DerivativeStrikeValue = val; }
    public DerivativeStrikeValue Get(DerivativeStrikeValue val) { GetField(val); return val; }
    public bool IsSet(DerivativeStrikeValue val) { return IsSetDerivativeStrikeValue(); }
    public bool IsSetDerivativeStrikeValue() { return IsSetField(Tags.DerivativeStrikeValue); }

    public DerivativeOptAttribute DerivativeOptAttribute
    {
        get
        {
            DerivativeOptAttribute val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeOptAttribute val) { DerivativeOptAttribute = val; }
    public DerivativeOptAttribute Get(DerivativeOptAttribute val) { GetField(val); return val; }
    public bool IsSet(DerivativeOptAttribute val) { return IsSetDerivativeOptAttribute(); }
    public bool IsSetDerivativeOptAttribute() { return IsSetField(Tags.DerivativeOptAttribute); }

    public DerivativeContractMultiplier DerivativeContractMultiplier
    {
        get
        {
            DerivativeContractMultiplier val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeContractMultiplier val) { DerivativeContractMultiplier = val; }
    public DerivativeContractMultiplier Get(DerivativeContractMultiplier val) { GetField(val); return val; }
    public bool IsSet(DerivativeContractMultiplier val) { return IsSetDerivativeContractMultiplier(); }
    public bool IsSetDerivativeContractMultiplier() { return IsSetField(Tags.DerivativeContractMultiplier); }

    public DerivativeMinPriceIncrement DerivativeMinPriceIncrement
    {
        get
        {
            DerivativeMinPriceIncrement val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeMinPriceIncrement val) { DerivativeMinPriceIncrement = val; }
    public DerivativeMinPriceIncrement Get(DerivativeMinPriceIncrement val) { GetField(val); return val; }
    public bool IsSet(DerivativeMinPriceIncrement val) { return IsSetDerivativeMinPriceIncrement(); }
    public bool IsSetDerivativeMinPriceIncrement() { return IsSetField(Tags.DerivativeMinPriceIncrement); }

    public DerivativeMinPriceIncrementAmount DerivativeMinPriceIncrementAmount
    {
        get
        {
            DerivativeMinPriceIncrementAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeMinPriceIncrementAmount val) { DerivativeMinPriceIncrementAmount = val; }
    public DerivativeMinPriceIncrementAmount Get(DerivativeMinPriceIncrementAmount val) { GetField(val); return val; }
    public bool IsSet(DerivativeMinPriceIncrementAmount val) { return IsSetDerivativeMinPriceIncrementAmount(); }
    public bool IsSetDerivativeMinPriceIncrementAmount() { return IsSetField(Tags.DerivativeMinPriceIncrementAmount); }

    public DerivativeUnitOfMeasure DerivativeUnitOfMeasure
    {
        get
        {
            DerivativeUnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeUnitOfMeasure val) { DerivativeUnitOfMeasure = val; }
    public DerivativeUnitOfMeasure Get(DerivativeUnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(DerivativeUnitOfMeasure val) { return IsSetDerivativeUnitOfMeasure(); }
    public bool IsSetDerivativeUnitOfMeasure() { return IsSetField(Tags.DerivativeUnitOfMeasure); }

    public DerivativeUnitOfMeasureQty DerivativeUnitOfMeasureQty
    {
        get
        {
            DerivativeUnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeUnitOfMeasureQty val) { DerivativeUnitOfMeasureQty = val; }
    public DerivativeUnitOfMeasureQty Get(DerivativeUnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(DerivativeUnitOfMeasureQty val) { return IsSetDerivativeUnitOfMeasureQty(); }
    public bool IsSetDerivativeUnitOfMeasureQty() { return IsSetField(Tags.DerivativeUnitOfMeasureQty); }

    public DerivativePriceUnitOfMeasure DerivativePriceUnitOfMeasure
    {
        get
        {
            DerivativePriceUnitOfMeasure val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativePriceUnitOfMeasure val) { DerivativePriceUnitOfMeasure = val; }
    public DerivativePriceUnitOfMeasure Get(DerivativePriceUnitOfMeasure val) { GetField(val); return val; }
    public bool IsSet(DerivativePriceUnitOfMeasure val) { return IsSetDerivativePriceUnitOfMeasure(); }
    public bool IsSetDerivativePriceUnitOfMeasure() { return IsSetField(Tags.DerivativePriceUnitOfMeasure); }

    public DerivativePriceUnitOfMeasureQty DerivativePriceUnitOfMeasureQty
    {
        get
        {
            DerivativePriceUnitOfMeasureQty val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativePriceUnitOfMeasureQty val) { DerivativePriceUnitOfMeasureQty = val; }
    public DerivativePriceUnitOfMeasureQty Get(DerivativePriceUnitOfMeasureQty val) { GetField(val); return val; }
    public bool IsSet(DerivativePriceUnitOfMeasureQty val) { return IsSetDerivativePriceUnitOfMeasureQty(); }
    public bool IsSetDerivativePriceUnitOfMeasureQty() { return IsSetField(Tags.DerivativePriceUnitOfMeasureQty); }

    public DerivativeExerciseStyle DerivativeExerciseStyle
    {
        get
        {
            DerivativeExerciseStyle val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeExerciseStyle val) { DerivativeExerciseStyle = val; }
    public DerivativeExerciseStyle Get(DerivativeExerciseStyle val) { GetField(val); return val; }
    public bool IsSet(DerivativeExerciseStyle val) { return IsSetDerivativeExerciseStyle(); }
    public bool IsSetDerivativeExerciseStyle() { return IsSetField(Tags.DerivativeExerciseStyle); }

    public DerivativeOptPayAmount DerivativeOptPayAmount
    {
        get
        {
            DerivativeOptPayAmount val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeOptPayAmount val) { DerivativeOptPayAmount = val; }
    public DerivativeOptPayAmount Get(DerivativeOptPayAmount val) { GetField(val); return val; }
    public bool IsSet(DerivativeOptPayAmount val) { return IsSetDerivativeOptPayAmount(); }
    public bool IsSetDerivativeOptPayAmount() { return IsSetField(Tags.DerivativeOptPayAmount); }

    public DerivativeTimeUnit DerivativeTimeUnit
    {
        get
        {
            DerivativeTimeUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeTimeUnit val) { DerivativeTimeUnit = val; }
    public DerivativeTimeUnit Get(DerivativeTimeUnit val) { GetField(val); return val; }
    public bool IsSet(DerivativeTimeUnit val) { return IsSetDerivativeTimeUnit(); }
    public bool IsSetDerivativeTimeUnit() { return IsSetField(Tags.DerivativeTimeUnit); }

    public DerivativeSecurityExchange DerivativeSecurityExchange
    {
        get
        {
            DerivativeSecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityExchange val) { DerivativeSecurityExchange = val; }
    public DerivativeSecurityExchange Get(DerivativeSecurityExchange val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityExchange val) { return IsSetDerivativeSecurityExchange(); }
    public bool IsSetDerivativeSecurityExchange() { return IsSetField(Tags.DerivativeSecurityExchange); }

    public DerivativePositionLimit DerivativePositionLimit
    {
        get
        {
            DerivativePositionLimit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativePositionLimit val) { DerivativePositionLimit = val; }
    public DerivativePositionLimit Get(DerivativePositionLimit val) { GetField(val); return val; }
    public bool IsSet(DerivativePositionLimit val) { return IsSetDerivativePositionLimit(); }
    public bool IsSetDerivativePositionLimit() { return IsSetField(Tags.DerivativePositionLimit); }

    public DerivativeNTPositionLimit DerivativeNTPositionLimit
    {
        get
        {
            DerivativeNTPositionLimit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeNTPositionLimit val) { DerivativeNTPositionLimit = val; }
    public DerivativeNTPositionLimit Get(DerivativeNTPositionLimit val) { GetField(val); return val; }
    public bool IsSet(DerivativeNTPositionLimit val) { return IsSetDerivativeNTPositionLimit(); }
    public bool IsSetDerivativeNTPositionLimit() { return IsSetField(Tags.DerivativeNTPositionLimit); }

    public DerivativeIssuer DerivativeIssuer
    {
        get
        {
            DerivativeIssuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeIssuer val) { DerivativeIssuer = val; }
    public DerivativeIssuer Get(DerivativeIssuer val) { GetField(val); return val; }
    public bool IsSet(DerivativeIssuer val) { return IsSetDerivativeIssuer(); }
    public bool IsSetDerivativeIssuer() { return IsSetField(Tags.DerivativeIssuer); }

    public DerivativeEncodedIssuerLen DerivativeEncodedIssuerLen
    {
        get
        {
            DerivativeEncodedIssuerLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeEncodedIssuerLen val) { DerivativeEncodedIssuerLen = val; }
    public DerivativeEncodedIssuerLen Get(DerivativeEncodedIssuerLen val) { GetField(val); return val; }
    public bool IsSet(DerivativeEncodedIssuerLen val) { return IsSetDerivativeEncodedIssuerLen(); }
    public bool IsSetDerivativeEncodedIssuerLen() { return IsSetField(Tags.DerivativeEncodedIssuerLen); }

    public DerivativeEncodedIssuer DerivativeEncodedIssuer
    {
        get
        {
            DerivativeEncodedIssuer val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeEncodedIssuer val) { DerivativeEncodedIssuer = val; }
    public DerivativeEncodedIssuer Get(DerivativeEncodedIssuer val) { GetField(val); return val; }
    public bool IsSet(DerivativeEncodedIssuer val) { return IsSetDerivativeEncodedIssuer(); }
    public bool IsSetDerivativeEncodedIssuer() { return IsSetField(Tags.DerivativeEncodedIssuer); }

    public DerivativeSecurityDesc DerivativeSecurityDesc
    {
        get
        {
            DerivativeSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityDesc val) { DerivativeSecurityDesc = val; }
    public DerivativeSecurityDesc Get(DerivativeSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityDesc val) { return IsSetDerivativeSecurityDesc(); }
    public bool IsSetDerivativeSecurityDesc() { return IsSetField(Tags.DerivativeSecurityDesc); }

    public DerivativeEncodedSecurityDescLen DerivativeEncodedSecurityDescLen
    {
        get
        {
            DerivativeEncodedSecurityDescLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeEncodedSecurityDescLen val) { DerivativeEncodedSecurityDescLen = val; }
    public DerivativeEncodedSecurityDescLen Get(DerivativeEncodedSecurityDescLen val) { GetField(val); return val; }
    public bool IsSet(DerivativeEncodedSecurityDescLen val) { return IsSetDerivativeEncodedSecurityDescLen(); }
    public bool IsSetDerivativeEncodedSecurityDescLen() { return IsSetField(Tags.DerivativeEncodedSecurityDescLen); }

    public DerivativeEncodedSecurityDesc DerivativeEncodedSecurityDesc
    {
        get
        {
            DerivativeEncodedSecurityDesc val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeEncodedSecurityDesc val) { DerivativeEncodedSecurityDesc = val; }
    public DerivativeEncodedSecurityDesc Get(DerivativeEncodedSecurityDesc val) { GetField(val); return val; }
    public bool IsSet(DerivativeEncodedSecurityDesc val) { return IsSetDerivativeEncodedSecurityDesc(); }
    public bool IsSetDerivativeEncodedSecurityDesc() { return IsSetField(Tags.DerivativeEncodedSecurityDesc); }

    public DerivativeContractSettlMonth DerivativeContractSettlMonth
    {
        get
        {
            DerivativeContractSettlMonth val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeContractSettlMonth val) { DerivativeContractSettlMonth = val; }
    public DerivativeContractSettlMonth Get(DerivativeContractSettlMonth val) { GetField(val); return val; }
    public bool IsSet(DerivativeContractSettlMonth val) { return IsSetDerivativeContractSettlMonth(); }
    public bool IsSetDerivativeContractSettlMonth() { return IsSetField(Tags.DerivativeContractSettlMonth); }

    public NoDerivativeEvents NoDerivativeEvents
    {
        get
        {
            NoDerivativeEvents val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoDerivativeEvents val) { NoDerivativeEvents = val; }
    public NoDerivativeEvents Get(NoDerivativeEvents val) { GetField(val); return val; }
    public bool IsSet(NoDerivativeEvents val) { return IsSetNoDerivativeEvents(); }
    public bool IsSetNoDerivativeEvents() { return IsSetField(Tags.NoDerivativeEvents); }

    public NoDerivativeInstrumentParties NoDerivativeInstrumentParties
    {
        get
        {
            NoDerivativeInstrumentParties val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoDerivativeInstrumentParties val) { NoDerivativeInstrumentParties = val; }
    public NoDerivativeInstrumentParties Get(NoDerivativeInstrumentParties val) { GetField(val); return val; }
    public bool IsSet(NoDerivativeInstrumentParties val) { return IsSetNoDerivativeInstrumentParties(); }
    public bool IsSetNoDerivativeInstrumentParties() { return IsSetField(Tags.NoDerivativeInstrumentParties); }

    public DerivativeSettlMethod DerivativeSettlMethod
    {
        get
        {
            DerivativeSettlMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSettlMethod val) { DerivativeSettlMethod = val; }
    public DerivativeSettlMethod Get(DerivativeSettlMethod val) { GetField(val); return val; }
    public bool IsSet(DerivativeSettlMethod val) { return IsSetDerivativeSettlMethod(); }
    public bool IsSetDerivativeSettlMethod() { return IsSetField(Tags.DerivativeSettlMethod); }

    public DerivativePriceQuoteMethod DerivativePriceQuoteMethod
    {
        get
        {
            DerivativePriceQuoteMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativePriceQuoteMethod val) { DerivativePriceQuoteMethod = val; }
    public DerivativePriceQuoteMethod Get(DerivativePriceQuoteMethod val) { GetField(val); return val; }
    public bool IsSet(DerivativePriceQuoteMethod val) { return IsSetDerivativePriceQuoteMethod(); }
    public bool IsSetDerivativePriceQuoteMethod() { return IsSetField(Tags.DerivativePriceQuoteMethod); }

    public DerivativeValuationMethod DerivativeValuationMethod
    {
        get
        {
            DerivativeValuationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeValuationMethod val) { DerivativeValuationMethod = val; }
    public DerivativeValuationMethod Get(DerivativeValuationMethod val) { GetField(val); return val; }
    public bool IsSet(DerivativeValuationMethod val) { return IsSetDerivativeValuationMethod(); }
    public bool IsSetDerivativeValuationMethod() { return IsSetField(Tags.DerivativeValuationMethod); }

    public DerivativeListMethod DerivativeListMethod
    {
        get
        {
            DerivativeListMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeListMethod val) { DerivativeListMethod = val; }
    public DerivativeListMethod Get(DerivativeListMethod val) { GetField(val); return val; }
    public bool IsSet(DerivativeListMethod val) { return IsSetDerivativeListMethod(); }
    public bool IsSetDerivativeListMethod() { return IsSetField(Tags.DerivativeListMethod); }

    public DerivativeCapPrice DerivativeCapPrice
    {
        get
        {
            DerivativeCapPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeCapPrice val) { DerivativeCapPrice = val; }
    public DerivativeCapPrice Get(DerivativeCapPrice val) { GetField(val); return val; }
    public bool IsSet(DerivativeCapPrice val) { return IsSetDerivativeCapPrice(); }
    public bool IsSetDerivativeCapPrice() { return IsSetField(Tags.DerivativeCapPrice); }

    public DerivativeFloorPrice DerivativeFloorPrice
    {
        get
        {
            DerivativeFloorPrice val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeFloorPrice val) { DerivativeFloorPrice = val; }
    public DerivativeFloorPrice Get(DerivativeFloorPrice val) { GetField(val); return val; }
    public bool IsSet(DerivativeFloorPrice val) { return IsSetDerivativeFloorPrice(); }
    public bool IsSetDerivativeFloorPrice() { return IsSetField(Tags.DerivativeFloorPrice); }

    public DerivativePutOrCall DerivativePutOrCall
    {
        get
        {
            DerivativePutOrCall val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativePutOrCall val) { DerivativePutOrCall = val; }
    public DerivativePutOrCall Get(DerivativePutOrCall val) { GetField(val); return val; }
    public bool IsSet(DerivativePutOrCall val) { return IsSetDerivativePutOrCall(); }
    public bool IsSetDerivativePutOrCall() { return IsSetField(Tags.DerivativePutOrCall); }

    public DerivativeSecurityXMLLen DerivativeSecurityXMLLen
    {
        get
        {
            DerivativeSecurityXMLLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityXMLLen val) { DerivativeSecurityXMLLen = val; }
    public DerivativeSecurityXMLLen Get(DerivativeSecurityXMLLen val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityXMLLen val) { return IsSetDerivativeSecurityXMLLen(); }
    public bool IsSetDerivativeSecurityXMLLen() { return IsSetField(Tags.DerivativeSecurityXMLLen); }

    public DerivativeSecurityXML DerivativeSecurityXML
    {
        get
        {
            DerivativeSecurityXML val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityXML val) { DerivativeSecurityXML = val; }
    public DerivativeSecurityXML Get(DerivativeSecurityXML val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityXML val) { return IsSetDerivativeSecurityXML(); }
    public bool IsSetDerivativeSecurityXML() { return IsSetField(Tags.DerivativeSecurityXML); }

    public DerivativeSecurityXMLSchema DerivativeSecurityXMLSchema
    {
        get
        {
            DerivativeSecurityXMLSchema val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeSecurityXMLSchema val) { DerivativeSecurityXMLSchema = val; }
    public DerivativeSecurityXMLSchema Get(DerivativeSecurityXMLSchema val) { GetField(val); return val; }
    public bool IsSet(DerivativeSecurityXMLSchema val) { return IsSetDerivativeSecurityXMLSchema(); }
    public bool IsSetDerivativeSecurityXMLSchema() { return IsSetField(Tags.DerivativeSecurityXMLSchema); }

    public DerivativeContractMultiplierUnit DerivativeContractMultiplierUnit
    {
        get
        {
            DerivativeContractMultiplierUnit val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeContractMultiplierUnit val) { DerivativeContractMultiplierUnit = val; }
    public DerivativeContractMultiplierUnit Get(DerivativeContractMultiplierUnit val) { GetField(val); return val; }
    public bool IsSet(DerivativeContractMultiplierUnit val) { return IsSetDerivativeContractMultiplierUnit(); }
    public bool IsSetDerivativeContractMultiplierUnit() { return IsSetField(Tags.DerivativeContractMultiplierUnit); }

    public DerivativeFlowScheduleType DerivativeFlowScheduleType
    {
        get
        {
            DerivativeFlowScheduleType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeFlowScheduleType val) { DerivativeFlowScheduleType = val; }
    public DerivativeFlowScheduleType Get(DerivativeFlowScheduleType val) { GetField(val); return val; }
    public bool IsSet(DerivativeFlowScheduleType val) { return IsSetDerivativeFlowScheduleType(); }
    public bool IsSetDerivativeFlowScheduleType() { return IsSetField(Tags.DerivativeFlowScheduleType); }

    public class NoUnderlyingSecurityAltIDGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};

        public NoUnderlyingSecurityAltIDGroup()
          : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUnderlyingSecurityAltIDGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public UnderlyingSecurityAltID UnderlyingSecurityAltID
        {
            get
            {
                UnderlyingSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityAltID val) { UnderlyingSecurityAltID = val; }
        public UnderlyingSecurityAltID Get(UnderlyingSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityAltID val) { return IsSetUnderlyingSecurityAltID(); }
        public bool IsSetUnderlyingSecurityAltID() { return IsSetField(Tags.UnderlyingSecurityAltID); }

        public UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
        {
            get
            {
                UnderlyingSecurityAltIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingSecurityAltIDSource val) { UnderlyingSecurityAltIDSource = val; }
        public UnderlyingSecurityAltIDSource Get(UnderlyingSecurityAltIDSource val) { GetField(val); return val; }
        public bool IsSet(UnderlyingSecurityAltIDSource val) { return IsSetUnderlyingSecurityAltIDSource(); }
        public bool IsSetUnderlyingSecurityAltIDSource() { return IsSetField(Tags.UnderlyingSecurityAltIDSource); }
    }

    public class NoUnderlyingStipsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};

        public NoUnderlyingStipsGroup()
          : base(Tags.NoUnderlyingStips, Tags.UnderlyingStipType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUnderlyingStipsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public UnderlyingStipType UnderlyingStipType
        {
            get
            {
                UnderlyingStipType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStipType val) { UnderlyingStipType = val; }
        public UnderlyingStipType Get(UnderlyingStipType val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStipType val) { return IsSetUnderlyingStipType(); }
        public bool IsSetUnderlyingStipType() { return IsSetField(Tags.UnderlyingStipType); }

        public UnderlyingStipValue UnderlyingStipValue
        {
            get
            {
                UnderlyingStipValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingStipValue val) { UnderlyingStipValue = val; }
        public UnderlyingStipValue Get(UnderlyingStipValue val) { GetField(val); return val; }
        public bool IsSet(UnderlyingStipValue val) { return IsSetUnderlyingStipValue(); }
        public bool IsSetUnderlyingStipValue() { return IsSetField(Tags.UnderlyingStipValue); }
    }

    public class NoUndlyInstrumentPartiesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartyID, Tags.UnderlyingInstrumentPartyIDSource, Tags.UnderlyingInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

        public NoUndlyInstrumentPartiesGroup()
          : base(Tags.NoUndlyInstrumentParties, Tags.UnderlyingInstrumentPartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUndlyInstrumentPartiesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public UnderlyingInstrumentPartyID UnderlyingInstrumentPartyID
        {
            get
            {
                UnderlyingInstrumentPartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingInstrumentPartyID val) { UnderlyingInstrumentPartyID = val; }
        public UnderlyingInstrumentPartyID Get(UnderlyingInstrumentPartyID val) { GetField(val); return val; }
        public bool IsSet(UnderlyingInstrumentPartyID val) { return IsSetUnderlyingInstrumentPartyID(); }
        public bool IsSetUnderlyingInstrumentPartyID() { return IsSetField(Tags.UnderlyingInstrumentPartyID); }

        public UnderlyingInstrumentPartyIDSource UnderlyingInstrumentPartyIDSource
        {
            get
            {
                UnderlyingInstrumentPartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingInstrumentPartyIDSource val) { UnderlyingInstrumentPartyIDSource = val; }
        public UnderlyingInstrumentPartyIDSource Get(UnderlyingInstrumentPartyIDSource val) { GetField(val); return val; }
        public bool IsSet(UnderlyingInstrumentPartyIDSource val) { return IsSetUnderlyingInstrumentPartyIDSource(); }
        public bool IsSetUnderlyingInstrumentPartyIDSource() { return IsSetField(Tags.UnderlyingInstrumentPartyIDSource); }

        public UnderlyingInstrumentPartyRole UnderlyingInstrumentPartyRole
        {
            get
            {
                UnderlyingInstrumentPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnderlyingInstrumentPartyRole val) { UnderlyingInstrumentPartyRole = val; }
        public UnderlyingInstrumentPartyRole Get(UnderlyingInstrumentPartyRole val) { GetField(val); return val; }
        public bool IsSet(UnderlyingInstrumentPartyRole val) { return IsSetUnderlyingInstrumentPartyRole(); }
        public bool IsSetUnderlyingInstrumentPartyRole() { return IsSetField(Tags.UnderlyingInstrumentPartyRole); }

        public NoUndlyInstrumentPartySubIDs NoUndlyInstrumentPartySubIDs
        {
            get
            {
                NoUndlyInstrumentPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoUndlyInstrumentPartySubIDs val) { NoUndlyInstrumentPartySubIDs = val; }
        public NoUndlyInstrumentPartySubIDs Get(NoUndlyInstrumentPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoUndlyInstrumentPartySubIDs val) { return IsSetNoUndlyInstrumentPartySubIDs(); }
        public bool IsSetNoUndlyInstrumentPartySubIDs() { return IsSetField(Tags.NoUndlyInstrumentPartySubIDs); }

        public class NoUndlyInstrumentPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.UnderlyingInstrumentPartySubID, Tags.UnderlyingInstrumentPartySubIDType, 0};

            public NoUndlyInstrumentPartySubIDsGroup()
              : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UnderlyingInstrumentPartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UnderlyingInstrumentPartySubID UnderlyingInstrumentPartySubID
            {
                get
                {
                    UnderlyingInstrumentPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingInstrumentPartySubID val) { UnderlyingInstrumentPartySubID = val; }
            public UnderlyingInstrumentPartySubID Get(UnderlyingInstrumentPartySubID val) { GetField(val); return val; }
            public bool IsSet(UnderlyingInstrumentPartySubID val) { return IsSetUnderlyingInstrumentPartySubID(); }
            public bool IsSetUnderlyingInstrumentPartySubID() { return IsSetField(Tags.UnderlyingInstrumentPartySubID); }

            public UnderlyingInstrumentPartySubIDType UnderlyingInstrumentPartySubIDType
            {
                get
                {
                    UnderlyingInstrumentPartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UnderlyingInstrumentPartySubIDType val) { UnderlyingInstrumentPartySubIDType = val; }
            public UnderlyingInstrumentPartySubIDType Get(UnderlyingInstrumentPartySubIDType val) { GetField(val); return val; }
            public bool IsSet(UnderlyingInstrumentPartySubIDType val) { return IsSetUnderlyingInstrumentPartySubIDType(); }
            public bool IsSetUnderlyingInstrumentPartySubIDType() { return IsSetField(Tags.UnderlyingInstrumentPartySubIDType); }
        }
    }

    public class NoDerivativeSecurityAltIDGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.DerivativeSecurityAltID, Tags.DerivativeSecurityAltIDSource, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.DerivativeSecurityAltID, Tags.DerivativeSecurityAltIDSource, 0};

        public NoDerivativeSecurityAltIDGroup()
          : base(Tags.NoDerivativeSecurityAltID, Tags.DerivativeSecurityAltID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoDerivativeSecurityAltIDGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public DerivativeSecurityAltID DerivativeSecurityAltID
        {
            get
            {
                DerivativeSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeSecurityAltID val) { DerivativeSecurityAltID = val; }
        public DerivativeSecurityAltID Get(DerivativeSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(DerivativeSecurityAltID val) { return IsSetDerivativeSecurityAltID(); }
        public bool IsSetDerivativeSecurityAltID() { return IsSetField(Tags.DerivativeSecurityAltID); }

        public DerivativeSecurityAltIDSource DerivativeSecurityAltIDSource
        {
            get
            {
                DerivativeSecurityAltIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeSecurityAltIDSource val) { DerivativeSecurityAltIDSource = val; }
        public DerivativeSecurityAltIDSource Get(DerivativeSecurityAltIDSource val) { GetField(val); return val; }
        public bool IsSet(DerivativeSecurityAltIDSource val) { return IsSetDerivativeSecurityAltIDSource(); }
        public bool IsSetDerivativeSecurityAltIDSource() { return IsSetField(Tags.DerivativeSecurityAltIDSource); }
    }

    public class NoDerivativeEventsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.DerivativeEventType, Tags.DerivativeEventDate, Tags.DerivativeEventTime, Tags.DerivativeEventPx, Tags.DerivativeEventText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.DerivativeEventType, Tags.DerivativeEventDate, Tags.DerivativeEventTime, Tags.DerivativeEventPx, Tags.DerivativeEventText, 0};

        public NoDerivativeEventsGroup()
          : base(Tags.NoDerivativeEvents, Tags.DerivativeEventType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoDerivativeEventsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public DerivativeEventType DerivativeEventType
        {
            get
            {
                DerivativeEventType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeEventType val) { DerivativeEventType = val; }
        public DerivativeEventType Get(DerivativeEventType val) { GetField(val); return val; }
        public bool IsSet(DerivativeEventType val) { return IsSetDerivativeEventType(); }
        public bool IsSetDerivativeEventType() { return IsSetField(Tags.DerivativeEventType); }

        public DerivativeEventDate DerivativeEventDate
        {
            get
            {
                DerivativeEventDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeEventDate val) { DerivativeEventDate = val; }
        public DerivativeEventDate Get(DerivativeEventDate val) { GetField(val); return val; }
        public bool IsSet(DerivativeEventDate val) { return IsSetDerivativeEventDate(); }
        public bool IsSetDerivativeEventDate() { return IsSetField(Tags.DerivativeEventDate); }

        public DerivativeEventTime DerivativeEventTime
        {
            get
            {
                DerivativeEventTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeEventTime val) { DerivativeEventTime = val; }
        public DerivativeEventTime Get(DerivativeEventTime val) { GetField(val); return val; }
        public bool IsSet(DerivativeEventTime val) { return IsSetDerivativeEventTime(); }
        public bool IsSetDerivativeEventTime() { return IsSetField(Tags.DerivativeEventTime); }

        public DerivativeEventPx DerivativeEventPx
        {
            get
            {
                DerivativeEventPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeEventPx val) { DerivativeEventPx = val; }
        public DerivativeEventPx Get(DerivativeEventPx val) { GetField(val); return val; }
        public bool IsSet(DerivativeEventPx val) { return IsSetDerivativeEventPx(); }
        public bool IsSetDerivativeEventPx() { return IsSetField(Tags.DerivativeEventPx); }

        public DerivativeEventText DerivativeEventText
        {
            get
            {
                DerivativeEventText val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeEventText val) { DerivativeEventText = val; }
        public DerivativeEventText Get(DerivativeEventText val) { GetField(val); return val; }
        public bool IsSet(DerivativeEventText val) { return IsSetDerivativeEventText(); }
        public bool IsSetDerivativeEventText() { return IsSetField(Tags.DerivativeEventText); }
    }

    public class NoDerivativeInstrumentPartiesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.DerivativeInstrumentPartyID, Tags.DerivativeInstrumentPartyIDSource, Tags.DerivativeInstrumentPartyRole, Tags.NoDerivativeInstrumentPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.DerivativeInstrumentPartyID, Tags.DerivativeInstrumentPartyIDSource, Tags.DerivativeInstrumentPartyRole, Tags.NoDerivativeInstrumentPartySubIDs, 0};

        public NoDerivativeInstrumentPartiesGroup()
          : base(Tags.NoDerivativeInstrumentParties, Tags.DerivativeInstrumentPartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoDerivativeInstrumentPartiesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public DerivativeInstrumentPartyID DerivativeInstrumentPartyID
        {
            get
            {
                DerivativeInstrumentPartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeInstrumentPartyID val) { DerivativeInstrumentPartyID = val; }
        public DerivativeInstrumentPartyID Get(DerivativeInstrumentPartyID val) { GetField(val); return val; }
        public bool IsSet(DerivativeInstrumentPartyID val) { return IsSetDerivativeInstrumentPartyID(); }
        public bool IsSetDerivativeInstrumentPartyID() { return IsSetField(Tags.DerivativeInstrumentPartyID); }

        public DerivativeInstrumentPartyIDSource DerivativeInstrumentPartyIDSource
        {
            get
            {
                DerivativeInstrumentPartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeInstrumentPartyIDSource val) { DerivativeInstrumentPartyIDSource = val; }
        public DerivativeInstrumentPartyIDSource Get(DerivativeInstrumentPartyIDSource val) { GetField(val); return val; }
        public bool IsSet(DerivativeInstrumentPartyIDSource val) { return IsSetDerivativeInstrumentPartyIDSource(); }
        public bool IsSetDerivativeInstrumentPartyIDSource() { return IsSetField(Tags.DerivativeInstrumentPartyIDSource); }

        public DerivativeInstrumentPartyRole DerivativeInstrumentPartyRole
        {
            get
            {
                DerivativeInstrumentPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeInstrumentPartyRole val) { DerivativeInstrumentPartyRole = val; }
        public DerivativeInstrumentPartyRole Get(DerivativeInstrumentPartyRole val) { GetField(val); return val; }
        public bool IsSet(DerivativeInstrumentPartyRole val) { return IsSetDerivativeInstrumentPartyRole(); }
        public bool IsSetDerivativeInstrumentPartyRole() { return IsSetField(Tags.DerivativeInstrumentPartyRole); }

        public NoDerivativeInstrumentPartySubIDs NoDerivativeInstrumentPartySubIDs
        {
            get
            {
                NoDerivativeInstrumentPartySubIDs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoDerivativeInstrumentPartySubIDs val) { NoDerivativeInstrumentPartySubIDs = val; }
        public NoDerivativeInstrumentPartySubIDs Get(NoDerivativeInstrumentPartySubIDs val) { GetField(val); return val; }
        public bool IsSet(NoDerivativeInstrumentPartySubIDs val) { return IsSetNoDerivativeInstrumentPartySubIDs(); }
        public bool IsSetNoDerivativeInstrumentPartySubIDs() { return IsSetField(Tags.NoDerivativeInstrumentPartySubIDs); }

        public class NoDerivativeInstrumentPartySubIDsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.DerivativeInstrumentPartySubID, Tags.DerivativeInstrumentPartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.DerivativeInstrumentPartySubID, Tags.DerivativeInstrumentPartySubIDType, 0};

            public NoDerivativeInstrumentPartySubIDsGroup()
              : base(Tags.NoDerivativeInstrumentPartySubIDs, Tags.DerivativeInstrumentPartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoDerivativeInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public DerivativeInstrumentPartySubID DerivativeInstrumentPartySubID
            {
                get
                {
                    DerivativeInstrumentPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(DerivativeInstrumentPartySubID val) { DerivativeInstrumentPartySubID = val; }
            public DerivativeInstrumentPartySubID Get(DerivativeInstrumentPartySubID val) { GetField(val); return val; }
            public bool IsSet(DerivativeInstrumentPartySubID val) { return IsSetDerivativeInstrumentPartySubID(); }
            public bool IsSetDerivativeInstrumentPartySubID() { return IsSetField(Tags.DerivativeInstrumentPartySubID); }

            public DerivativeInstrumentPartySubIDType DerivativeInstrumentPartySubIDType
            {
                get
                {
                    DerivativeInstrumentPartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(DerivativeInstrumentPartySubIDType val) { DerivativeInstrumentPartySubIDType = val; }
            public DerivativeInstrumentPartySubIDType Get(DerivativeInstrumentPartySubIDType val) { GetField(val); return val; }
            public bool IsSet(DerivativeInstrumentPartySubIDType val) { return IsSetDerivativeInstrumentPartySubIDType(); }
            public bool IsSetDerivativeInstrumentPartySubIDType() { return IsSetField(Tags.DerivativeInstrumentPartySubIDType); }
        }
    }
}
