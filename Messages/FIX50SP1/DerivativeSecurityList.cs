// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP1;

public class DerivativeSecurityList : Message
{
    public const string MsgType = "AA";

    public DerivativeSecurityList() : base()
    {
        Header.SetField(new MsgType("AA"));
    }

    public DerivativeSecurityList(
            SecurityResponseID aSecurityResponseID
        ) : this()
    {
        SecurityResponseID = aSecurityResponseID;
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

    public SecurityResponseID SecurityResponseID
    {
        get
        {
            SecurityResponseID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityResponseID val) { SecurityResponseID = val; }
    public SecurityResponseID Get(SecurityResponseID val) { GetField(val); return val; }
    public bool IsSet(SecurityResponseID val) { return IsSetSecurityResponseID(); }
    public bool IsSetSecurityResponseID() { return IsSetField(Tags.SecurityResponseID); }

    public SecurityRequestResult SecurityRequestResult
    {
        get
        {
            SecurityRequestResult val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityRequestResult val) { SecurityRequestResult = val; }
    public SecurityRequestResult Get(SecurityRequestResult val) { GetField(val); return val; }
    public bool IsSet(SecurityRequestResult val) { return IsSetSecurityRequestResult(); }
    public bool IsSetSecurityRequestResult() { return IsSetField(Tags.SecurityRequestResult); }

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

    public TotNoRelatedSym TotNoRelatedSym
    {
        get
        {
            TotNoRelatedSym val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TotNoRelatedSym val) { TotNoRelatedSym = val; }
    public TotNoRelatedSym Get(TotNoRelatedSym val) { GetField(val); return val; }
    public bool IsSet(TotNoRelatedSym val) { return IsSetTotNoRelatedSym(); }
    public bool IsSetTotNoRelatedSym() { return IsSetField(Tags.TotNoRelatedSym); }

    public LastFragment LastFragment
    {
        get
        {
            LastFragment val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastFragment val) { LastFragment = val; }
    public LastFragment Get(LastFragment val) { GetField(val); return val; }
    public bool IsSet(LastFragment val) { return IsSetLastFragment(); }
    public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }

    public NoRelatedSym NoRelatedSym
    {
        get
        {
            NoRelatedSym val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoRelatedSym val) { NoRelatedSym = val; }
    public NoRelatedSym Get(NoRelatedSym val) { GetField(val); return val; }
    public bool IsSet(NoRelatedSym val) { return IsSetNoRelatedSym(); }
    public bool IsSetNoRelatedSym() { return IsSetField(Tags.NoRelatedSym); }

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

    public DerivativeFuturesValuationMethod DerivativeFuturesValuationMethod
    {
        get
        {
            DerivativeFuturesValuationMethod val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(DerivativeFuturesValuationMethod val) { DerivativeFuturesValuationMethod = val; }
    public DerivativeFuturesValuationMethod Get(DerivativeFuturesValuationMethod val) { GetField(val); return val; }
    public bool IsSet(DerivativeFuturesValuationMethod val) { return IsSetDerivativeFuturesValuationMethod(); }
    public bool IsSetDerivativeFuturesValuationMethod() { return IsSetField(Tags.DerivativeFuturesValuationMethod); }

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

    public NoDerivativeInstrAttrib NoDerivativeInstrAttrib
    {
        get
        {
            NoDerivativeInstrAttrib val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoDerivativeInstrAttrib val) { NoDerivativeInstrAttrib = val; }
    public NoDerivativeInstrAttrib Get(NoDerivativeInstrAttrib val) { GetField(val); return val; }
    public bool IsSet(NoDerivativeInstrAttrib val) { return IsSetNoDerivativeInstrAttrib(); }
    public bool IsSetNoDerivativeInstrAttrib() { return IsSetField(Tags.NoDerivativeInstrAttrib); }

    public NoMarketSegments NoMarketSegments
    {
        get
        {
            NoMarketSegments val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoMarketSegments val) { NoMarketSegments = val; }
    public NoMarketSegments Get(NoMarketSegments val) { GetField(val); return val; }
    public bool IsSet(NoMarketSegments val) { return IsSetNoMarketSegments(); }
    public bool IsSetNoMarketSegments() { return IsSetField(Tags.NoMarketSegments); }

    public ApplID ApplID
    {
        get
        {
            ApplID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplID val) { ApplID = val; }
    public ApplID Get(ApplID val) { GetField(val); return val; }
    public bool IsSet(ApplID val) { return IsSetApplID(); }
    public bool IsSetApplID() { return IsSetField(Tags.ApplID); }

    public ApplSeqNum ApplSeqNum
    {
        get
        {
            ApplSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplSeqNum val) { ApplSeqNum = val; }
    public ApplSeqNum Get(ApplSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplSeqNum val) { return IsSetApplSeqNum(); }
    public bool IsSetApplSeqNum() { return IsSetField(Tags.ApplSeqNum); }

    public ApplLastSeqNum ApplLastSeqNum
    {
        get
        {
            ApplLastSeqNum val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplLastSeqNum val) { ApplLastSeqNum = val; }
    public ApplLastSeqNum Get(ApplLastSeqNum val) { GetField(val); return val; }
    public bool IsSet(ApplLastSeqNum val) { return IsSetApplLastSeqNum(); }
    public bool IsSetApplLastSeqNum() { return IsSetField(Tags.ApplLastSeqNum); }

    public ApplResendFlag ApplResendFlag
    {
        get
        {
            ApplResendFlag val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ApplResendFlag val) { ApplResendFlag = val; }
    public ApplResendFlag Get(ApplResendFlag val) { GetField(val); return val; }
    public bool IsSet(ApplResendFlag val) { return IsSetApplResendFlag(); }
    public bool IsSetApplResendFlag() { return IsSetField(Tags.ApplResendFlag); }

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
        public static int[] DefaultFieldOrder = [Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};

        public NoUndlyInstrumentPartiesGroup()
          : base(Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoUndlyInstrumentPartiesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public UndlyInstrumentPartyID UndlyInstrumentPartyID
        {
            get
            {
                UndlyInstrumentPartyID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UndlyInstrumentPartyID val) { UndlyInstrumentPartyID = val; }
        public UndlyInstrumentPartyID Get(UndlyInstrumentPartyID val) { GetField(val); return val; }
        public bool IsSet(UndlyInstrumentPartyID val) { return IsSetUndlyInstrumentPartyID(); }
        public bool IsSetUndlyInstrumentPartyID() { return IsSetField(Tags.UndlyInstrumentPartyID); }

        public UndlyInstrumentPartyIDSource UndlyInstrumentPartyIDSource
        {
            get
            {
                UndlyInstrumentPartyIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UndlyInstrumentPartyIDSource val) { UndlyInstrumentPartyIDSource = val; }
        public UndlyInstrumentPartyIDSource Get(UndlyInstrumentPartyIDSource val) { GetField(val); return val; }
        public bool IsSet(UndlyInstrumentPartyIDSource val) { return IsSetUndlyInstrumentPartyIDSource(); }
        public bool IsSetUndlyInstrumentPartyIDSource() { return IsSetField(Tags.UndlyInstrumentPartyIDSource); }

        public UndlyInstrumentPartyRole UndlyInstrumentPartyRole
        {
            get
            {
                UndlyInstrumentPartyRole val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UndlyInstrumentPartyRole val) { UndlyInstrumentPartyRole = val; }
        public UndlyInstrumentPartyRole Get(UndlyInstrumentPartyRole val) { GetField(val); return val; }
        public bool IsSet(UndlyInstrumentPartyRole val) { return IsSetUndlyInstrumentPartyRole(); }
        public bool IsSetUndlyInstrumentPartyRole() { return IsSetField(Tags.UndlyInstrumentPartyRole); }

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
            public static int[] DefaultFieldOrder = [Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};

            public NoUndlyInstrumentPartySubIDsGroup()
              : base(Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoUndlyInstrumentPartySubIDsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public UndlyInstrumentPartySubID UndlyInstrumentPartySubID
            {
                get
                {
                    UndlyInstrumentPartySubID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UndlyInstrumentPartySubID val) { UndlyInstrumentPartySubID = val; }
            public UndlyInstrumentPartySubID Get(UndlyInstrumentPartySubID val) { GetField(val); return val; }
            public bool IsSet(UndlyInstrumentPartySubID val) { return IsSetUndlyInstrumentPartySubID(); }
            public bool IsSetUndlyInstrumentPartySubID() { return IsSetField(Tags.UndlyInstrumentPartySubID); }

            public UndlyInstrumentPartySubIDType UndlyInstrumentPartySubIDType
            {
                get
                {
                    UndlyInstrumentPartySubIDType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(UndlyInstrumentPartySubIDType val) { UndlyInstrumentPartySubIDType = val; }
            public UndlyInstrumentPartySubIDType Get(UndlyInstrumentPartySubIDType val) { GetField(val); return val; }
            public bool IsSet(UndlyInstrumentPartySubIDType val) { return IsSetUndlyInstrumentPartySubIDType(); }
            public bool IsSetUndlyInstrumentPartySubIDType() { return IsSetField(Tags.UndlyInstrumentPartySubIDType); }
        }
    }

    public class NoRelatedSymGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.Currency, Tags.DeliveryForm, Tags.PctAtRisk, Tags.NoInstrAttrib, Tags.NoLegs, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SecondaryPriceLimitType, Tags.SecondaryLowLimitPrice, Tags.SecondaryHighLimitPrice, Tags.SecondaryTradingReferencePrice, Tags.CorporateAction, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.Currency, Tags.DeliveryForm, Tags.PctAtRisk, Tags.NoInstrAttrib, Tags.NoLegs, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.SecondaryPriceLimitType, Tags.SecondaryLowLimitPrice, Tags.SecondaryHighLimitPrice, Tags.SecondaryTradingReferencePrice, Tags.CorporateAction, 0};

        public NoRelatedSymGroup()
          : base(Tags.NoRelatedSym, Tags.Symbol, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoRelatedSymGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public SecurityIDSource SecurityIDSource
        {
            get
            {
                SecurityIDSource val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityIDSource val) { SecurityIDSource = val; }
        public SecurityIDSource Get(SecurityIDSource val) { GetField(val); return val; }
        public bool IsSet(SecurityIDSource val) { return IsSetSecurityIDSource(); }
        public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }

        public NoSecurityAltID NoSecurityAltID
        {
            get
            {
                NoSecurityAltID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoSecurityAltID val) { NoSecurityAltID = val; }
        public NoSecurityAltID Get(NoSecurityAltID val) { GetField(val); return val; }
        public bool IsSet(NoSecurityAltID val) { return IsSetNoSecurityAltID(); }
        public bool IsSetNoSecurityAltID() { return IsSetField(Tags.NoSecurityAltID); }

        public Product Product
        {
            get
            {
                Product val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Product val) { Product = val; }
        public Product Get(Product val) { GetField(val); return val; }
        public bool IsSet(Product val) { return IsSetProduct(); }
        public bool IsSetProduct() { return IsSetField(Tags.Product); }

        public CFICode CFICode
        {
            get
            {
                CFICode val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CFICode val) { CFICode = val; }
        public CFICode Get(CFICode val) { GetField(val); return val; }
        public bool IsSet(CFICode val) { return IsSetCFICode(); }
        public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }

        public SecurityType SecurityType
        {
            get
            {
                SecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityType val) { SecurityType = val; }
        public SecurityType Get(SecurityType val) { GetField(val); return val; }
        public bool IsSet(SecurityType val) { return IsSetSecurityType(); }
        public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }

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

        public MaturityMonthYear MaturityMonthYear
        {
            get
            {
                MaturityMonthYear val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaturityMonthYear val) { MaturityMonthYear = val; }
        public MaturityMonthYear Get(MaturityMonthYear val) { GetField(val); return val; }
        public bool IsSet(MaturityMonthYear val) { return IsSetMaturityMonthYear(); }
        public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }

        public MaturityDate MaturityDate
        {
            get
            {
                MaturityDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaturityDate val) { MaturityDate = val; }
        public MaturityDate Get(MaturityDate val) { GetField(val); return val; }
        public bool IsSet(MaturityDate val) { return IsSetMaturityDate(); }
        public bool IsSetMaturityDate() { return IsSetField(Tags.MaturityDate); }

        public CouponPaymentDate CouponPaymentDate
        {
            get
            {
                CouponPaymentDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CouponPaymentDate val) { CouponPaymentDate = val; }
        public CouponPaymentDate Get(CouponPaymentDate val) { GetField(val); return val; }
        public bool IsSet(CouponPaymentDate val) { return IsSetCouponPaymentDate(); }
        public bool IsSetCouponPaymentDate() { return IsSetField(Tags.CouponPaymentDate); }

        public IssueDate IssueDate
        {
            get
            {
                IssueDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(IssueDate val) { IssueDate = val; }
        public IssueDate Get(IssueDate val) { GetField(val); return val; }
        public bool IsSet(IssueDate val) { return IsSetIssueDate(); }
        public bool IsSetIssueDate() { return IsSetField(Tags.IssueDate); }

        public RepoCollateralSecurityType RepoCollateralSecurityType
        {
            get
            {
                RepoCollateralSecurityType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RepoCollateralSecurityType val) { RepoCollateralSecurityType = val; }
        public RepoCollateralSecurityType Get(RepoCollateralSecurityType val) { GetField(val); return val; }
        public bool IsSet(RepoCollateralSecurityType val) { return IsSetRepoCollateralSecurityType(); }
        public bool IsSetRepoCollateralSecurityType() { return IsSetField(Tags.RepoCollateralSecurityType); }

        public RepurchaseTerm RepurchaseTerm
        {
            get
            {
                RepurchaseTerm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RepurchaseTerm val) { RepurchaseTerm = val; }
        public RepurchaseTerm Get(RepurchaseTerm val) { GetField(val); return val; }
        public bool IsSet(RepurchaseTerm val) { return IsSetRepurchaseTerm(); }
        public bool IsSetRepurchaseTerm() { return IsSetField(Tags.RepurchaseTerm); }

        public RepurchaseRate RepurchaseRate
        {
            get
            {
                RepurchaseRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RepurchaseRate val) { RepurchaseRate = val; }
        public RepurchaseRate Get(RepurchaseRate val) { GetField(val); return val; }
        public bool IsSet(RepurchaseRate val) { return IsSetRepurchaseRate(); }
        public bool IsSetRepurchaseRate() { return IsSetField(Tags.RepurchaseRate); }

        public Factor Factor
        {
            get
            {
                Factor val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Factor val) { Factor = val; }
        public Factor Get(Factor val) { GetField(val); return val; }
        public bool IsSet(Factor val) { return IsSetFactor(); }
        public bool IsSetFactor() { return IsSetField(Tags.Factor); }

        public CreditRating CreditRating
        {
            get
            {
                CreditRating val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CreditRating val) { CreditRating = val; }
        public CreditRating Get(CreditRating val) { GetField(val); return val; }
        public bool IsSet(CreditRating val) { return IsSetCreditRating(); }
        public bool IsSetCreditRating() { return IsSetField(Tags.CreditRating); }

        public InstrRegistry InstrRegistry
        {
            get
            {
                InstrRegistry val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrRegistry val) { InstrRegistry = val; }
        public InstrRegistry Get(InstrRegistry val) { GetField(val); return val; }
        public bool IsSet(InstrRegistry val) { return IsSetInstrRegistry(); }
        public bool IsSetInstrRegistry() { return IsSetField(Tags.InstrRegistry); }

        public CountryOfIssue CountryOfIssue
        {
            get
            {
                CountryOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CountryOfIssue val) { CountryOfIssue = val; }
        public CountryOfIssue Get(CountryOfIssue val) { GetField(val); return val; }
        public bool IsSet(CountryOfIssue val) { return IsSetCountryOfIssue(); }
        public bool IsSetCountryOfIssue() { return IsSetField(Tags.CountryOfIssue); }

        public StateOrProvinceOfIssue StateOrProvinceOfIssue
        {
            get
            {
                StateOrProvinceOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StateOrProvinceOfIssue val) { StateOrProvinceOfIssue = val; }
        public StateOrProvinceOfIssue Get(StateOrProvinceOfIssue val) { GetField(val); return val; }
        public bool IsSet(StateOrProvinceOfIssue val) { return IsSetStateOrProvinceOfIssue(); }
        public bool IsSetStateOrProvinceOfIssue() { return IsSetField(Tags.StateOrProvinceOfIssue); }

        public LocaleOfIssue LocaleOfIssue
        {
            get
            {
                LocaleOfIssue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LocaleOfIssue val) { LocaleOfIssue = val; }
        public LocaleOfIssue Get(LocaleOfIssue val) { GetField(val); return val; }
        public bool IsSet(LocaleOfIssue val) { return IsSetLocaleOfIssue(); }
        public bool IsSetLocaleOfIssue() { return IsSetField(Tags.LocaleOfIssue); }

        public RedemptionDate RedemptionDate
        {
            get
            {
                RedemptionDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RedemptionDate val) { RedemptionDate = val; }
        public RedemptionDate Get(RedemptionDate val) { GetField(val); return val; }
        public bool IsSet(RedemptionDate val) { return IsSetRedemptionDate(); }
        public bool IsSetRedemptionDate() { return IsSetField(Tags.RedemptionDate); }

        public StrikePrice StrikePrice
        {
            get
            {
                StrikePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikePrice val) { StrikePrice = val; }
        public StrikePrice Get(StrikePrice val) { GetField(val); return val; }
        public bool IsSet(StrikePrice val) { return IsSetStrikePrice(); }
        public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }

        public StrikeCurrency StrikeCurrency
        {
            get
            {
                StrikeCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikeCurrency val) { StrikeCurrency = val; }
        public StrikeCurrency Get(StrikeCurrency val) { GetField(val); return val; }
        public bool IsSet(StrikeCurrency val) { return IsSetStrikeCurrency(); }
        public bool IsSetStrikeCurrency() { return IsSetField(Tags.StrikeCurrency); }

        public OptAttribute OptAttribute
        {
            get
            {
                OptAttribute val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptAttribute val) { OptAttribute = val; }
        public OptAttribute Get(OptAttribute val) { GetField(val); return val; }
        public bool IsSet(OptAttribute val) { return IsSetOptAttribute(); }
        public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }

        public ContractMultiplier ContractMultiplier
        {
            get
            {
                ContractMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractMultiplier val) { ContractMultiplier = val; }
        public ContractMultiplier Get(ContractMultiplier val) { GetField(val); return val; }
        public bool IsSet(ContractMultiplier val) { return IsSetContractMultiplier(); }
        public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }

        public CouponRate CouponRate
        {
            get
            {
                CouponRate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CouponRate val) { CouponRate = val; }
        public CouponRate Get(CouponRate val) { GetField(val); return val; }
        public bool IsSet(CouponRate val) { return IsSetCouponRate(); }
        public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }

        public SecurityExchange SecurityExchange
        {
            get
            {
                SecurityExchange val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityExchange val) { SecurityExchange = val; }
        public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
        public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
        public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

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

        public EncodedIssuerLen EncodedIssuerLen
        {
            get
            {
                EncodedIssuerLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedIssuerLen val) { EncodedIssuerLen = val; }
        public EncodedIssuerLen Get(EncodedIssuerLen val) { GetField(val); return val; }
        public bool IsSet(EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }
        public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }

        public EncodedIssuer EncodedIssuer
        {
            get
            {
                EncodedIssuer val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedIssuer val) { EncodedIssuer = val; }
        public EncodedIssuer Get(EncodedIssuer val) { GetField(val); return val; }
        public bool IsSet(EncodedIssuer val) { return IsSetEncodedIssuer(); }
        public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }

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

        public EncodedSecurityDescLen EncodedSecurityDescLen
        {
            get
            {
                EncodedSecurityDescLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedSecurityDescLen val) { EncodedSecurityDescLen = val; }
        public EncodedSecurityDescLen Get(EncodedSecurityDescLen val) { GetField(val); return val; }
        public bool IsSet(EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }
        public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }

        public EncodedSecurityDesc EncodedSecurityDesc
        {
            get
            {
                EncodedSecurityDesc val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(EncodedSecurityDesc val) { EncodedSecurityDesc = val; }
        public EncodedSecurityDesc Get(EncodedSecurityDesc val) { GetField(val); return val; }
        public bool IsSet(EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }
        public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }

        public Pool Pool
        {
            get
            {
                Pool val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Pool val) { Pool = val; }
        public Pool Get(Pool val) { GetField(val); return val; }
        public bool IsSet(Pool val) { return IsSetPool(); }
        public bool IsSetPool() { return IsSetField(Tags.Pool); }

        public ContractSettlMonth ContractSettlMonth
        {
            get
            {
                ContractSettlMonth val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ContractSettlMonth val) { ContractSettlMonth = val; }
        public ContractSettlMonth Get(ContractSettlMonth val) { GetField(val); return val; }
        public bool IsSet(ContractSettlMonth val) { return IsSetContractSettlMonth(); }
        public bool IsSetContractSettlMonth() { return IsSetField(Tags.ContractSettlMonth); }

        public CPProgram CPProgram
        {
            get
            {
                CPProgram val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CPProgram val) { CPProgram = val; }
        public CPProgram Get(CPProgram val) { GetField(val); return val; }
        public bool IsSet(CPProgram val) { return IsSetCPProgram(); }
        public bool IsSetCPProgram() { return IsSetField(Tags.CPProgram); }

        public CPRegType CPRegType
        {
            get
            {
                CPRegType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CPRegType val) { CPRegType = val; }
        public CPRegType Get(CPRegType val) { GetField(val); return val; }
        public bool IsSet(CPRegType val) { return IsSetCPRegType(); }
        public bool IsSetCPRegType() { return IsSetField(Tags.CPRegType); }

        public NoEvents NoEvents
        {
            get
            {
                NoEvents val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoEvents val) { NoEvents = val; }
        public NoEvents Get(NoEvents val) { GetField(val); return val; }
        public bool IsSet(NoEvents val) { return IsSetNoEvents(); }
        public bool IsSetNoEvents() { return IsSetField(Tags.NoEvents); }

        public DatedDate DatedDate
        {
            get
            {
                DatedDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DatedDate val) { DatedDate = val; }
        public DatedDate Get(DatedDate val) { GetField(val); return val; }
        public bool IsSet(DatedDate val) { return IsSetDatedDate(); }
        public bool IsSetDatedDate() { return IsSetField(Tags.DatedDate); }

        public InterestAccrualDate InterestAccrualDate
        {
            get
            {
                InterestAccrualDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InterestAccrualDate val) { InterestAccrualDate = val; }
        public InterestAccrualDate Get(InterestAccrualDate val) { GetField(val); return val; }
        public bool IsSet(InterestAccrualDate val) { return IsSetInterestAccrualDate(); }
        public bool IsSetInterestAccrualDate() { return IsSetField(Tags.InterestAccrualDate); }

        public Fields.SecurityStatus SecurityStatus
        {
            get
            {
                Fields.SecurityStatus val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Fields.SecurityStatus val) { SecurityStatus = val; }
        public Fields.SecurityStatus Get(Fields.SecurityStatus val) { GetField(val); return val; }
        public bool IsSet(Fields.SecurityStatus val) { return IsSetSecurityStatus(); }
        public bool IsSetSecurityStatus() { return IsSetField(Tags.SecurityStatus); }

        public SettleOnOpenFlag SettleOnOpenFlag
        {
            get
            {
                SettleOnOpenFlag val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettleOnOpenFlag val) { SettleOnOpenFlag = val; }
        public SettleOnOpenFlag Get(SettleOnOpenFlag val) { GetField(val); return val; }
        public bool IsSet(SettleOnOpenFlag val) { return IsSetSettleOnOpenFlag(); }
        public bool IsSetSettleOnOpenFlag() { return IsSetField(Tags.SettleOnOpenFlag); }

        public InstrmtAssignmentMethod InstrmtAssignmentMethod
        {
            get
            {
                InstrmtAssignmentMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(InstrmtAssignmentMethod val) { InstrmtAssignmentMethod = val; }
        public InstrmtAssignmentMethod Get(InstrmtAssignmentMethod val) { GetField(val); return val; }
        public bool IsSet(InstrmtAssignmentMethod val) { return IsSetInstrmtAssignmentMethod(); }
        public bool IsSetInstrmtAssignmentMethod() { return IsSetField(Tags.InstrmtAssignmentMethod); }

        public StrikeMultiplier StrikeMultiplier
        {
            get
            {
                StrikeMultiplier val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikeMultiplier val) { StrikeMultiplier = val; }
        public StrikeMultiplier Get(StrikeMultiplier val) { GetField(val); return val; }
        public bool IsSet(StrikeMultiplier val) { return IsSetStrikeMultiplier(); }
        public bool IsSetStrikeMultiplier() { return IsSetField(Tags.StrikeMultiplier); }

        public StrikeValue StrikeValue
        {
            get
            {
                StrikeValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(StrikeValue val) { StrikeValue = val; }
        public StrikeValue Get(StrikeValue val) { GetField(val); return val; }
        public bool IsSet(StrikeValue val) { return IsSetStrikeValue(); }
        public bool IsSetStrikeValue() { return IsSetField(Tags.StrikeValue); }

        public MinPriceIncrement MinPriceIncrement
        {
            get
            {
                MinPriceIncrement val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MinPriceIncrement val) { MinPriceIncrement = val; }
        public MinPriceIncrement Get(MinPriceIncrement val) { GetField(val); return val; }
        public bool IsSet(MinPriceIncrement val) { return IsSetMinPriceIncrement(); }
        public bool IsSetMinPriceIncrement() { return IsSetField(Tags.MinPriceIncrement); }

        public PositionLimit PositionLimit
        {
            get
            {
                PositionLimit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PositionLimit val) { PositionLimit = val; }
        public PositionLimit Get(PositionLimit val) { GetField(val); return val; }
        public bool IsSet(PositionLimit val) { return IsSetPositionLimit(); }
        public bool IsSetPositionLimit() { return IsSetField(Tags.PositionLimit); }

        public NTPositionLimit NTPositionLimit
        {
            get
            {
                NTPositionLimit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NTPositionLimit val) { NTPositionLimit = val; }
        public NTPositionLimit Get(NTPositionLimit val) { GetField(val); return val; }
        public bool IsSet(NTPositionLimit val) { return IsSetNTPositionLimit(); }
        public bool IsSetNTPositionLimit() { return IsSetField(Tags.NTPositionLimit); }

        public NoInstrumentParties NoInstrumentParties
        {
            get
            {
                NoInstrumentParties val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoInstrumentParties val) { NoInstrumentParties = val; }
        public NoInstrumentParties Get(NoInstrumentParties val) { GetField(val); return val; }
        public bool IsSet(NoInstrumentParties val) { return IsSetNoInstrumentParties(); }
        public bool IsSetNoInstrumentParties() { return IsSetField(Tags.NoInstrumentParties); }

        public UnitOfMeasure UnitOfMeasure
        {
            get
            {
                UnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnitOfMeasure val) { UnitOfMeasure = val; }
        public UnitOfMeasure Get(UnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(UnitOfMeasure val) { return IsSetUnitOfMeasure(); }
        public bool IsSetUnitOfMeasure() { return IsSetField(Tags.UnitOfMeasure); }

        public TimeUnit TimeUnit
        {
            get
            {
                TimeUnit val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TimeUnit val) { TimeUnit = val; }
        public TimeUnit Get(TimeUnit val) { GetField(val); return val; }
        public bool IsSet(TimeUnit val) { return IsSetTimeUnit(); }
        public bool IsSetTimeUnit() { return IsSetField(Tags.TimeUnit); }

        public MaturityTime MaturityTime
        {
            get
            {
                MaturityTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaturityTime val) { MaturityTime = val; }
        public MaturityTime Get(MaturityTime val) { GetField(val); return val; }
        public bool IsSet(MaturityTime val) { return IsSetMaturityTime(); }
        public bool IsSetMaturityTime() { return IsSetField(Tags.MaturityTime); }

        public SecurityGroup SecurityGroup
        {
            get
            {
                SecurityGroup val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityGroup val) { SecurityGroup = val; }
        public SecurityGroup Get(SecurityGroup val) { GetField(val); return val; }
        public bool IsSet(SecurityGroup val) { return IsSetSecurityGroup(); }
        public bool IsSetSecurityGroup() { return IsSetField(Tags.SecurityGroup); }

        public MinPriceIncrementAmount MinPriceIncrementAmount
        {
            get
            {
                MinPriceIncrementAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MinPriceIncrementAmount val) { MinPriceIncrementAmount = val; }
        public MinPriceIncrementAmount Get(MinPriceIncrementAmount val) { GetField(val); return val; }
        public bool IsSet(MinPriceIncrementAmount val) { return IsSetMinPriceIncrementAmount(); }
        public bool IsSetMinPriceIncrementAmount() { return IsSetField(Tags.MinPriceIncrementAmount); }

        public UnitOfMeasureQty UnitOfMeasureQty
        {
            get
            {
                UnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(UnitOfMeasureQty val) { UnitOfMeasureQty = val; }
        public UnitOfMeasureQty Get(UnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(UnitOfMeasureQty val) { return IsSetUnitOfMeasureQty(); }
        public bool IsSetUnitOfMeasureQty() { return IsSetField(Tags.UnitOfMeasureQty); }

        public SecurityXMLLen SecurityXMLLen
        {
            get
            {
                SecurityXMLLen val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityXMLLen val) { SecurityXMLLen = val; }
        public SecurityXMLLen Get(SecurityXMLLen val) { GetField(val); return val; }
        public bool IsSet(SecurityXMLLen val) { return IsSetSecurityXMLLen(); }
        public bool IsSetSecurityXMLLen() { return IsSetField(Tags.SecurityXMLLen); }

        public SecurityXML SecurityXML
        {
            get
            {
                SecurityXML val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityXML val) { SecurityXML = val; }
        public SecurityXML Get(SecurityXML val) { GetField(val); return val; }
        public bool IsSet(SecurityXML val) { return IsSetSecurityXML(); }
        public bool IsSetSecurityXML() { return IsSetField(Tags.SecurityXML); }

        public SecurityXMLSchema SecurityXMLSchema
        {
            get
            {
                SecurityXMLSchema val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecurityXMLSchema val) { SecurityXMLSchema = val; }
        public SecurityXMLSchema Get(SecurityXMLSchema val) { GetField(val); return val; }
        public bool IsSet(SecurityXMLSchema val) { return IsSetSecurityXMLSchema(); }
        public bool IsSetSecurityXMLSchema() { return IsSetField(Tags.SecurityXMLSchema); }

        public ProductComplex ProductComplex
        {
            get
            {
                ProductComplex val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ProductComplex val) { ProductComplex = val; }
        public ProductComplex Get(ProductComplex val) { GetField(val); return val; }
        public bool IsSet(ProductComplex val) { return IsSetProductComplex(); }
        public bool IsSetProductComplex() { return IsSetField(Tags.ProductComplex); }

        public PriceUnitOfMeasure PriceUnitOfMeasure
        {
            get
            {
                PriceUnitOfMeasure val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceUnitOfMeasure val) { PriceUnitOfMeasure = val; }
        public PriceUnitOfMeasure Get(PriceUnitOfMeasure val) { GetField(val); return val; }
        public bool IsSet(PriceUnitOfMeasure val) { return IsSetPriceUnitOfMeasure(); }
        public bool IsSetPriceUnitOfMeasure() { return IsSetField(Tags.PriceUnitOfMeasure); }

        public PriceUnitOfMeasureQty PriceUnitOfMeasureQty
        {
            get
            {
                PriceUnitOfMeasureQty val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceUnitOfMeasureQty val) { PriceUnitOfMeasureQty = val; }
        public PriceUnitOfMeasureQty Get(PriceUnitOfMeasureQty val) { GetField(val); return val; }
        public bool IsSet(PriceUnitOfMeasureQty val) { return IsSetPriceUnitOfMeasureQty(); }
        public bool IsSetPriceUnitOfMeasureQty() { return IsSetField(Tags.PriceUnitOfMeasureQty); }

        public SettlMethod SettlMethod
        {
            get
            {
                SettlMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlMethod val) { SettlMethod = val; }
        public SettlMethod Get(SettlMethod val) { GetField(val); return val; }
        public bool IsSet(SettlMethod val) { return IsSetSettlMethod(); }
        public bool IsSetSettlMethod() { return IsSetField(Tags.SettlMethod); }

        public ExerciseStyle ExerciseStyle
        {
            get
            {
                ExerciseStyle val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExerciseStyle val) { ExerciseStyle = val; }
        public ExerciseStyle Get(ExerciseStyle val) { GetField(val); return val; }
        public bool IsSet(ExerciseStyle val) { return IsSetExerciseStyle(); }
        public bool IsSetExerciseStyle() { return IsSetField(Tags.ExerciseStyle); }

        public OptPayAmount OptPayAmount
        {
            get
            {
                OptPayAmount val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OptPayAmount val) { OptPayAmount = val; }
        public OptPayAmount Get(OptPayAmount val) { GetField(val); return val; }
        public bool IsSet(OptPayAmount val) { return IsSetOptPayAmount(); }
        public bool IsSetOptPayAmount() { return IsSetField(Tags.OptPayAmount); }

        public PriceQuoteMethod PriceQuoteMethod
        {
            get
            {
                PriceQuoteMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceQuoteMethod val) { PriceQuoteMethod = val; }
        public PriceQuoteMethod Get(PriceQuoteMethod val) { GetField(val); return val; }
        public bool IsSet(PriceQuoteMethod val) { return IsSetPriceQuoteMethod(); }
        public bool IsSetPriceQuoteMethod() { return IsSetField(Tags.PriceQuoteMethod); }

        public ListMethod ListMethod
        {
            get
            {
                ListMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ListMethod val) { ListMethod = val; }
        public ListMethod Get(ListMethod val) { GetField(val); return val; }
        public bool IsSet(ListMethod val) { return IsSetListMethod(); }
        public bool IsSetListMethod() { return IsSetField(Tags.ListMethod); }

        public CapPrice CapPrice
        {
            get
            {
                CapPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CapPrice val) { CapPrice = val; }
        public CapPrice Get(CapPrice val) { GetField(val); return val; }
        public bool IsSet(CapPrice val) { return IsSetCapPrice(); }
        public bool IsSetCapPrice() { return IsSetField(Tags.CapPrice); }

        public FloorPrice FloorPrice
        {
            get
            {
                FloorPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FloorPrice val) { FloorPrice = val; }
        public FloorPrice Get(FloorPrice val) { GetField(val); return val; }
        public bool IsSet(FloorPrice val) { return IsSetFloorPrice(); }
        public bool IsSetFloorPrice() { return IsSetField(Tags.FloorPrice); }

        public PutOrCall PutOrCall
        {
            get
            {
                PutOrCall val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PutOrCall val) { PutOrCall = val; }
        public PutOrCall Get(PutOrCall val) { GetField(val); return val; }
        public bool IsSet(PutOrCall val) { return IsSetPutOrCall(); }
        public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }

        public FlexibleIndicator FlexibleIndicator
        {
            get
            {
                FlexibleIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FlexibleIndicator val) { FlexibleIndicator = val; }
        public FlexibleIndicator Get(FlexibleIndicator val) { GetField(val); return val; }
        public bool IsSet(FlexibleIndicator val) { return IsSetFlexibleIndicator(); }
        public bool IsSetFlexibleIndicator() { return IsSetField(Tags.FlexibleIndicator); }

        public FlexProductEligibilityIndicator FlexProductEligibilityIndicator
        {
            get
            {
                FlexProductEligibilityIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FlexProductEligibilityIndicator val) { FlexProductEligibilityIndicator = val; }
        public FlexProductEligibilityIndicator Get(FlexProductEligibilityIndicator val) { GetField(val); return val; }
        public bool IsSet(FlexProductEligibilityIndicator val) { return IsSetFlexProductEligibilityIndicator(); }
        public bool IsSetFlexProductEligibilityIndicator() { return IsSetField(Tags.FlexProductEligibilityIndicator); }

        public FuturesValuationMethod FuturesValuationMethod
        {
            get
            {
                FuturesValuationMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FuturesValuationMethod val) { FuturesValuationMethod = val; }
        public FuturesValuationMethod Get(FuturesValuationMethod val) { GetField(val); return val; }
        public bool IsSet(FuturesValuationMethod val) { return IsSetFuturesValuationMethod(); }
        public bool IsSetFuturesValuationMethod() { return IsSetField(Tags.FuturesValuationMethod); }

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

        public DeliveryForm DeliveryForm
        {
            get
            {
                DeliveryForm val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DeliveryForm val) { DeliveryForm = val; }
        public DeliveryForm Get(DeliveryForm val) { GetField(val); return val; }
        public bool IsSet(DeliveryForm val) { return IsSetDeliveryForm(); }
        public bool IsSetDeliveryForm() { return IsSetField(Tags.DeliveryForm); }

        public PctAtRisk PctAtRisk
        {
            get
            {
                PctAtRisk val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PctAtRisk val) { PctAtRisk = val; }
        public PctAtRisk Get(PctAtRisk val) { GetField(val); return val; }
        public bool IsSet(PctAtRisk val) { return IsSetPctAtRisk(); }
        public bool IsSetPctAtRisk() { return IsSetField(Tags.PctAtRisk); }

        public NoInstrAttrib NoInstrAttrib
        {
            get
            {
                NoInstrAttrib val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoInstrAttrib val) { NoInstrAttrib = val; }
        public NoInstrAttrib Get(NoInstrAttrib val) { GetField(val); return val; }
        public bool IsSet(NoInstrAttrib val) { return IsSetNoInstrAttrib(); }
        public bool IsSetNoInstrAttrib() { return IsSetField(Tags.NoInstrAttrib); }

        public NoLegs NoLegs
        {
            get
            {
                NoLegs val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLegs val) { NoLegs = val; }
        public NoLegs Get(NoLegs val) { GetField(val); return val; }
        public bool IsSet(NoLegs val) { return IsSetNoLegs(); }
        public bool IsSetNoLegs() { return IsSetField(Tags.NoLegs); }

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

        public SecondaryPriceLimitType SecondaryPriceLimitType
        {
            get
            {
                SecondaryPriceLimitType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryPriceLimitType val) { SecondaryPriceLimitType = val; }
        public SecondaryPriceLimitType Get(SecondaryPriceLimitType val) { GetField(val); return val; }
        public bool IsSet(SecondaryPriceLimitType val) { return IsSetSecondaryPriceLimitType(); }
        public bool IsSetSecondaryPriceLimitType() { return IsSetField(Tags.SecondaryPriceLimitType); }

        public SecondaryLowLimitPrice SecondaryLowLimitPrice
        {
            get
            {
                SecondaryLowLimitPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryLowLimitPrice val) { SecondaryLowLimitPrice = val; }
        public SecondaryLowLimitPrice Get(SecondaryLowLimitPrice val) { GetField(val); return val; }
        public bool IsSet(SecondaryLowLimitPrice val) { return IsSetSecondaryLowLimitPrice(); }
        public bool IsSetSecondaryLowLimitPrice() { return IsSetField(Tags.SecondaryLowLimitPrice); }

        public SecondaryHighLimitPrice SecondaryHighLimitPrice
        {
            get
            {
                SecondaryHighLimitPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryHighLimitPrice val) { SecondaryHighLimitPrice = val; }
        public SecondaryHighLimitPrice Get(SecondaryHighLimitPrice val) { GetField(val); return val; }
        public bool IsSet(SecondaryHighLimitPrice val) { return IsSetSecondaryHighLimitPrice(); }
        public bool IsSetSecondaryHighLimitPrice() { return IsSetField(Tags.SecondaryHighLimitPrice); }

        public SecondaryTradingReferencePrice SecondaryTradingReferencePrice
        {
            get
            {
                SecondaryTradingReferencePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SecondaryTradingReferencePrice val) { SecondaryTradingReferencePrice = val; }
        public SecondaryTradingReferencePrice Get(SecondaryTradingReferencePrice val) { GetField(val); return val; }
        public bool IsSet(SecondaryTradingReferencePrice val) { return IsSetSecondaryTradingReferencePrice(); }
        public bool IsSetSecondaryTradingReferencePrice() { return IsSetField(Tags.SecondaryTradingReferencePrice); }

        public CorporateAction CorporateAction
        {
            get
            {
                CorporateAction val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CorporateAction val) { CorporateAction = val; }
        public CorporateAction Get(CorporateAction val) { GetField(val); return val; }
        public bool IsSet(CorporateAction val) { return IsSetCorporateAction(); }
        public bool IsSetCorporateAction() { return IsSetField(Tags.CorporateAction); }

        public class NoSecurityAltIDGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.SecurityAltID, Tags.SecurityAltIDSource, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

            public NoSecurityAltIDGroup()
              : base(Tags.NoSecurityAltID, Tags.SecurityAltID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoSecurityAltIDGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public SecurityAltID SecurityAltID
            {
                get
                {
                    SecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SecurityAltID val) { SecurityAltID = val; }
            public SecurityAltID Get(SecurityAltID val) { GetField(val); return val; }
            public bool IsSet(SecurityAltID val) { return IsSetSecurityAltID(); }
            public bool IsSetSecurityAltID() { return IsSetField(Tags.SecurityAltID); }

            public SecurityAltIDSource SecurityAltIDSource
            {
                get
                {
                    SecurityAltIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(SecurityAltIDSource val) { SecurityAltIDSource = val; }
            public SecurityAltIDSource Get(SecurityAltIDSource val) { GetField(val); return val; }
            public bool IsSet(SecurityAltIDSource val) { return IsSetSecurityAltIDSource(); }
            public bool IsSetSecurityAltIDSource() { return IsSetField(Tags.SecurityAltIDSource); }
        }

        public class NoEventsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};

            public NoEventsGroup()
              : base(Tags.NoEvents, Tags.EventType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoEventsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public EventType EventType
            {
                get
                {
                    EventType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EventType val) { EventType = val; }
            public EventType Get(EventType val) { GetField(val); return val; }
            public bool IsSet(EventType val) { return IsSetEventType(); }
            public bool IsSetEventType() { return IsSetField(Tags.EventType); }

            public EventDate EventDate
            {
                get
                {
                    EventDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EventDate val) { EventDate = val; }
            public EventDate Get(EventDate val) { GetField(val); return val; }
            public bool IsSet(EventDate val) { return IsSetEventDate(); }
            public bool IsSetEventDate() { return IsSetField(Tags.EventDate); }

            public EventPx EventPx
            {
                get
                {
                    EventPx val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EventPx val) { EventPx = val; }
            public EventPx Get(EventPx val) { GetField(val); return val; }
            public bool IsSet(EventPx val) { return IsSetEventPx(); }
            public bool IsSetEventPx() { return IsSetField(Tags.EventPx); }

            public EventText EventText
            {
                get
                {
                    EventText val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EventText val) { EventText = val; }
            public EventText Get(EventText val) { GetField(val); return val; }
            public bool IsSet(EventText val) { return IsSetEventText(); }
            public bool IsSetEventText() { return IsSetField(Tags.EventText); }

            public EventTime EventTime
            {
                get
                {
                    EventTime val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EventTime val) { EventTime = val; }
            public EventTime Get(EventTime val) { GetField(val); return val; }
            public bool IsSet(EventTime val) { return IsSetEventTime(); }
            public bool IsSetEventTime() { return IsSetField(Tags.EventTime); }
        }

        public class NoInstrumentPartiesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};

            public NoInstrumentPartiesGroup()
              : base(Tags.NoInstrumentParties, Tags.InstrumentPartyID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoInstrumentPartiesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public InstrumentPartyID InstrumentPartyID
            {
                get
                {
                    InstrumentPartyID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartyID val) { InstrumentPartyID = val; }
            public InstrumentPartyID Get(InstrumentPartyID val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartyID val) { return IsSetInstrumentPartyID(); }
            public bool IsSetInstrumentPartyID() { return IsSetField(Tags.InstrumentPartyID); }

            public InstrumentPartyIDSource InstrumentPartyIDSource
            {
                get
                {
                    InstrumentPartyIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartyIDSource val) { InstrumentPartyIDSource = val; }
            public InstrumentPartyIDSource Get(InstrumentPartyIDSource val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartyIDSource val) { return IsSetInstrumentPartyIDSource(); }
            public bool IsSetInstrumentPartyIDSource() { return IsSetField(Tags.InstrumentPartyIDSource); }

            public InstrumentPartyRole InstrumentPartyRole
            {
                get
                {
                    InstrumentPartyRole val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrumentPartyRole val) { InstrumentPartyRole = val; }
            public InstrumentPartyRole Get(InstrumentPartyRole val) { GetField(val); return val; }
            public bool IsSet(InstrumentPartyRole val) { return IsSetInstrumentPartyRole(); }
            public bool IsSetInstrumentPartyRole() { return IsSetField(Tags.InstrumentPartyRole); }

            public NoInstrumentPartySubIDs NoInstrumentPartySubIDs
            {
                get
                {
                    NoInstrumentPartySubIDs val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoInstrumentPartySubIDs val) { NoInstrumentPartySubIDs = val; }
            public NoInstrumentPartySubIDs Get(NoInstrumentPartySubIDs val) { GetField(val); return val; }
            public bool IsSet(NoInstrumentPartySubIDs val) { return IsSetNoInstrumentPartySubIDs(); }
            public bool IsSetNoInstrumentPartySubIDs() { return IsSetField(Tags.NoInstrumentPartySubIDs); }

            public class NoInstrumentPartySubIDsGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};

                public NoInstrumentPartySubIDsGroup()
                  : base(Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoInstrumentPartySubIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public InstrumentPartySubID InstrumentPartySubID
                {
                    get
                    {
                        InstrumentPartySubID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(InstrumentPartySubID val) { InstrumentPartySubID = val; }
                public InstrumentPartySubID Get(InstrumentPartySubID val) { GetField(val); return val; }
                public bool IsSet(InstrumentPartySubID val) { return IsSetInstrumentPartySubID(); }
                public bool IsSetInstrumentPartySubID() { return IsSetField(Tags.InstrumentPartySubID); }

                public InstrumentPartySubIDType InstrumentPartySubIDType
                {
                    get
                    {
                        InstrumentPartySubIDType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(InstrumentPartySubIDType val) { InstrumentPartySubIDType = val; }
                public InstrumentPartySubIDType Get(InstrumentPartySubIDType val) { GetField(val); return val; }
                public bool IsSet(InstrumentPartySubIDType val) { return IsSetInstrumentPartySubIDType(); }
                public bool IsSetInstrumentPartySubIDType() { return IsSetField(Tags.InstrumentPartySubIDType); }
            }
        }

        public class NoInstrAttribGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.InstrAttribType, Tags.InstrAttribValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.InstrAttribType, Tags.InstrAttribValue, 0};

            public NoInstrAttribGroup()
              : base(Tags.NoInstrAttrib, Tags.InstrAttribType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoInstrAttribGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public InstrAttribType InstrAttribType
            {
                get
                {
                    InstrAttribType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrAttribType val) { InstrAttribType = val; }
            public InstrAttribType Get(InstrAttribType val) { GetField(val); return val; }
            public bool IsSet(InstrAttribType val) { return IsSetInstrAttribType(); }
            public bool IsSetInstrAttribType() { return IsSetField(Tags.InstrAttribType); }

            public InstrAttribValue InstrAttribValue
            {
                get
                {
                    InstrAttribValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(InstrAttribValue val) { InstrAttribValue = val; }
            public InstrAttribValue Get(InstrAttribValue val) { GetField(val); return val; }
            public bool IsSet(InstrAttribValue val) { return IsSetInstrAttribValue(); }
            public bool IsSetInstrAttribValue() { return IsSetField(Tags.InstrAttribValue); }
        }

        public class NoLegsGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, 0};

            public NoLegsGroup()
              : base(Tags.NoLegs, Tags.LegSymbol, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLegsGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LegSymbol LegSymbol
            {
                get
                {
                    LegSymbol val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSymbol val) { LegSymbol = val; }
            public LegSymbol Get(LegSymbol val) { GetField(val); return val; }
            public bool IsSet(LegSymbol val) { return IsSetLegSymbol(); }
            public bool IsSetLegSymbol() { return IsSetField(Tags.LegSymbol); }

            public LegSymbolSfx LegSymbolSfx
            {
                get
                {
                    LegSymbolSfx val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSymbolSfx val) { LegSymbolSfx = val; }
            public LegSymbolSfx Get(LegSymbolSfx val) { GetField(val); return val; }
            public bool IsSet(LegSymbolSfx val) { return IsSetLegSymbolSfx(); }
            public bool IsSetLegSymbolSfx() { return IsSetField(Tags.LegSymbolSfx); }

            public LegSecurityID LegSecurityID
            {
                get
                {
                    LegSecurityID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityID val) { LegSecurityID = val; }
            public LegSecurityID Get(LegSecurityID val) { GetField(val); return val; }
            public bool IsSet(LegSecurityID val) { return IsSetLegSecurityID(); }
            public bool IsSetLegSecurityID() { return IsSetField(Tags.LegSecurityID); }

            public LegSecurityIDSource LegSecurityIDSource
            {
                get
                {
                    LegSecurityIDSource val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityIDSource val) { LegSecurityIDSource = val; }
            public LegSecurityIDSource Get(LegSecurityIDSource val) { GetField(val); return val; }
            public bool IsSet(LegSecurityIDSource val) { return IsSetLegSecurityIDSource(); }
            public bool IsSetLegSecurityIDSource() { return IsSetField(Tags.LegSecurityIDSource); }

            public NoLegSecurityAltID NoLegSecurityAltID
            {
                get
                {
                    NoLegSecurityAltID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoLegSecurityAltID val) { NoLegSecurityAltID = val; }
            public NoLegSecurityAltID Get(NoLegSecurityAltID val) { GetField(val); return val; }
            public bool IsSet(NoLegSecurityAltID val) { return IsSetNoLegSecurityAltID(); }
            public bool IsSetNoLegSecurityAltID() { return IsSetField(Tags.NoLegSecurityAltID); }

            public LegProduct LegProduct
            {
                get
                {
                    LegProduct val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegProduct val) { LegProduct = val; }
            public LegProduct Get(LegProduct val) { GetField(val); return val; }
            public bool IsSet(LegProduct val) { return IsSetLegProduct(); }
            public bool IsSetLegProduct() { return IsSetField(Tags.LegProduct); }

            public LegCFICode LegCFICode
            {
                get
                {
                    LegCFICode val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegCFICode val) { LegCFICode = val; }
            public LegCFICode Get(LegCFICode val) { GetField(val); return val; }
            public bool IsSet(LegCFICode val) { return IsSetLegCFICode(); }
            public bool IsSetLegCFICode() { return IsSetField(Tags.LegCFICode); }

            public LegSecurityType LegSecurityType
            {
                get
                {
                    LegSecurityType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityType val) { LegSecurityType = val; }
            public LegSecurityType Get(LegSecurityType val) { GetField(val); return val; }
            public bool IsSet(LegSecurityType val) { return IsSetLegSecurityType(); }
            public bool IsSetLegSecurityType() { return IsSetField(Tags.LegSecurityType); }

            public LegSecuritySubType LegSecuritySubType
            {
                get
                {
                    LegSecuritySubType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecuritySubType val) { LegSecuritySubType = val; }
            public LegSecuritySubType Get(LegSecuritySubType val) { GetField(val); return val; }
            public bool IsSet(LegSecuritySubType val) { return IsSetLegSecuritySubType(); }
            public bool IsSetLegSecuritySubType() { return IsSetField(Tags.LegSecuritySubType); }

            public LegMaturityMonthYear LegMaturityMonthYear
            {
                get
                {
                    LegMaturityMonthYear val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegMaturityMonthYear val) { LegMaturityMonthYear = val; }
            public LegMaturityMonthYear Get(LegMaturityMonthYear val) { GetField(val); return val; }
            public bool IsSet(LegMaturityMonthYear val) { return IsSetLegMaturityMonthYear(); }
            public bool IsSetLegMaturityMonthYear() { return IsSetField(Tags.LegMaturityMonthYear); }

            public LegMaturityDate LegMaturityDate
            {
                get
                {
                    LegMaturityDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegMaturityDate val) { LegMaturityDate = val; }
            public LegMaturityDate Get(LegMaturityDate val) { GetField(val); return val; }
            public bool IsSet(LegMaturityDate val) { return IsSetLegMaturityDate(); }
            public bool IsSetLegMaturityDate() { return IsSetField(Tags.LegMaturityDate); }

            public LegCouponPaymentDate LegCouponPaymentDate
            {
                get
                {
                    LegCouponPaymentDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegCouponPaymentDate val) { LegCouponPaymentDate = val; }
            public LegCouponPaymentDate Get(LegCouponPaymentDate val) { GetField(val); return val; }
            public bool IsSet(LegCouponPaymentDate val) { return IsSetLegCouponPaymentDate(); }
            public bool IsSetLegCouponPaymentDate() { return IsSetField(Tags.LegCouponPaymentDate); }

            public LegIssueDate LegIssueDate
            {
                get
                {
                    LegIssueDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegIssueDate val) { LegIssueDate = val; }
            public LegIssueDate Get(LegIssueDate val) { GetField(val); return val; }
            public bool IsSet(LegIssueDate val) { return IsSetLegIssueDate(); }
            public bool IsSetLegIssueDate() { return IsSetField(Tags.LegIssueDate); }

            public LegRepoCollateralSecurityType LegRepoCollateralSecurityType
            {
                get
                {
                    LegRepoCollateralSecurityType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegRepoCollateralSecurityType val) { LegRepoCollateralSecurityType = val; }
            public LegRepoCollateralSecurityType Get(LegRepoCollateralSecurityType val) { GetField(val); return val; }
            public bool IsSet(LegRepoCollateralSecurityType val) { return IsSetLegRepoCollateralSecurityType(); }
            public bool IsSetLegRepoCollateralSecurityType() { return IsSetField(Tags.LegRepoCollateralSecurityType); }

            public LegRepurchaseTerm LegRepurchaseTerm
            {
                get
                {
                    LegRepurchaseTerm val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegRepurchaseTerm val) { LegRepurchaseTerm = val; }
            public LegRepurchaseTerm Get(LegRepurchaseTerm val) { GetField(val); return val; }
            public bool IsSet(LegRepurchaseTerm val) { return IsSetLegRepurchaseTerm(); }
            public bool IsSetLegRepurchaseTerm() { return IsSetField(Tags.LegRepurchaseTerm); }

            public LegRepurchaseRate LegRepurchaseRate
            {
                get
                {
                    LegRepurchaseRate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegRepurchaseRate val) { LegRepurchaseRate = val; }
            public LegRepurchaseRate Get(LegRepurchaseRate val) { GetField(val); return val; }
            public bool IsSet(LegRepurchaseRate val) { return IsSetLegRepurchaseRate(); }
            public bool IsSetLegRepurchaseRate() { return IsSetField(Tags.LegRepurchaseRate); }

            public LegFactor LegFactor
            {
                get
                {
                    LegFactor val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegFactor val) { LegFactor = val; }
            public LegFactor Get(LegFactor val) { GetField(val); return val; }
            public bool IsSet(LegFactor val) { return IsSetLegFactor(); }
            public bool IsSetLegFactor() { return IsSetField(Tags.LegFactor); }

            public LegCreditRating LegCreditRating
            {
                get
                {
                    LegCreditRating val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegCreditRating val) { LegCreditRating = val; }
            public LegCreditRating Get(LegCreditRating val) { GetField(val); return val; }
            public bool IsSet(LegCreditRating val) { return IsSetLegCreditRating(); }
            public bool IsSetLegCreditRating() { return IsSetField(Tags.LegCreditRating); }

            public LegInstrRegistry LegInstrRegistry
            {
                get
                {
                    LegInstrRegistry val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegInstrRegistry val) { LegInstrRegistry = val; }
            public LegInstrRegistry Get(LegInstrRegistry val) { GetField(val); return val; }
            public bool IsSet(LegInstrRegistry val) { return IsSetLegInstrRegistry(); }
            public bool IsSetLegInstrRegistry() { return IsSetField(Tags.LegInstrRegistry); }

            public LegCountryOfIssue LegCountryOfIssue
            {
                get
                {
                    LegCountryOfIssue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegCountryOfIssue val) { LegCountryOfIssue = val; }
            public LegCountryOfIssue Get(LegCountryOfIssue val) { GetField(val); return val; }
            public bool IsSet(LegCountryOfIssue val) { return IsSetLegCountryOfIssue(); }
            public bool IsSetLegCountryOfIssue() { return IsSetField(Tags.LegCountryOfIssue); }

            public LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
            {
                get
                {
                    LegStateOrProvinceOfIssue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStateOrProvinceOfIssue val) { LegStateOrProvinceOfIssue = val; }
            public LegStateOrProvinceOfIssue Get(LegStateOrProvinceOfIssue val) { GetField(val); return val; }
            public bool IsSet(LegStateOrProvinceOfIssue val) { return IsSetLegStateOrProvinceOfIssue(); }
            public bool IsSetLegStateOrProvinceOfIssue() { return IsSetField(Tags.LegStateOrProvinceOfIssue); }

            public LegLocaleOfIssue LegLocaleOfIssue
            {
                get
                {
                    LegLocaleOfIssue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegLocaleOfIssue val) { LegLocaleOfIssue = val; }
            public LegLocaleOfIssue Get(LegLocaleOfIssue val) { GetField(val); return val; }
            public bool IsSet(LegLocaleOfIssue val) { return IsSetLegLocaleOfIssue(); }
            public bool IsSetLegLocaleOfIssue() { return IsSetField(Tags.LegLocaleOfIssue); }

            public LegRedemptionDate LegRedemptionDate
            {
                get
                {
                    LegRedemptionDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegRedemptionDate val) { LegRedemptionDate = val; }
            public LegRedemptionDate Get(LegRedemptionDate val) { GetField(val); return val; }
            public bool IsSet(LegRedemptionDate val) { return IsSetLegRedemptionDate(); }
            public bool IsSetLegRedemptionDate() { return IsSetField(Tags.LegRedemptionDate); }

            public LegStrikePrice LegStrikePrice
            {
                get
                {
                    LegStrikePrice val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStrikePrice val) { LegStrikePrice = val; }
            public LegStrikePrice Get(LegStrikePrice val) { GetField(val); return val; }
            public bool IsSet(LegStrikePrice val) { return IsSetLegStrikePrice(); }
            public bool IsSetLegStrikePrice() { return IsSetField(Tags.LegStrikePrice); }

            public LegStrikeCurrency LegStrikeCurrency
            {
                get
                {
                    LegStrikeCurrency val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegStrikeCurrency val) { LegStrikeCurrency = val; }
            public LegStrikeCurrency Get(LegStrikeCurrency val) { GetField(val); return val; }
            public bool IsSet(LegStrikeCurrency val) { return IsSetLegStrikeCurrency(); }
            public bool IsSetLegStrikeCurrency() { return IsSetField(Tags.LegStrikeCurrency); }

            public LegOptAttribute LegOptAttribute
            {
                get
                {
                    LegOptAttribute val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegOptAttribute val) { LegOptAttribute = val; }
            public LegOptAttribute Get(LegOptAttribute val) { GetField(val); return val; }
            public bool IsSet(LegOptAttribute val) { return IsSetLegOptAttribute(); }
            public bool IsSetLegOptAttribute() { return IsSetField(Tags.LegOptAttribute); }

            public LegContractMultiplier LegContractMultiplier
            {
                get
                {
                    LegContractMultiplier val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegContractMultiplier val) { LegContractMultiplier = val; }
            public LegContractMultiplier Get(LegContractMultiplier val) { GetField(val); return val; }
            public bool IsSet(LegContractMultiplier val) { return IsSetLegContractMultiplier(); }
            public bool IsSetLegContractMultiplier() { return IsSetField(Tags.LegContractMultiplier); }

            public LegCouponRate LegCouponRate
            {
                get
                {
                    LegCouponRate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegCouponRate val) { LegCouponRate = val; }
            public LegCouponRate Get(LegCouponRate val) { GetField(val); return val; }
            public bool IsSet(LegCouponRate val) { return IsSetLegCouponRate(); }
            public bool IsSetLegCouponRate() { return IsSetField(Tags.LegCouponRate); }

            public LegSecurityExchange LegSecurityExchange
            {
                get
                {
                    LegSecurityExchange val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityExchange val) { LegSecurityExchange = val; }
            public LegSecurityExchange Get(LegSecurityExchange val) { GetField(val); return val; }
            public bool IsSet(LegSecurityExchange val) { return IsSetLegSecurityExchange(); }
            public bool IsSetLegSecurityExchange() { return IsSetField(Tags.LegSecurityExchange); }

            public LegIssuer LegIssuer
            {
                get
                {
                    LegIssuer val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegIssuer val) { LegIssuer = val; }
            public LegIssuer Get(LegIssuer val) { GetField(val); return val; }
            public bool IsSet(LegIssuer val) { return IsSetLegIssuer(); }
            public bool IsSetLegIssuer() { return IsSetField(Tags.LegIssuer); }

            public EncodedLegIssuerLen EncodedLegIssuerLen
            {
                get
                {
                    EncodedLegIssuerLen val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EncodedLegIssuerLen val) { EncodedLegIssuerLen = val; }
            public EncodedLegIssuerLen Get(EncodedLegIssuerLen val) { GetField(val); return val; }
            public bool IsSet(EncodedLegIssuerLen val) { return IsSetEncodedLegIssuerLen(); }
            public bool IsSetEncodedLegIssuerLen() { return IsSetField(Tags.EncodedLegIssuerLen); }

            public EncodedLegIssuer EncodedLegIssuer
            {
                get
                {
                    EncodedLegIssuer val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EncodedLegIssuer val) { EncodedLegIssuer = val; }
            public EncodedLegIssuer Get(EncodedLegIssuer val) { GetField(val); return val; }
            public bool IsSet(EncodedLegIssuer val) { return IsSetEncodedLegIssuer(); }
            public bool IsSetEncodedLegIssuer() { return IsSetField(Tags.EncodedLegIssuer); }

            public LegSecurityDesc LegSecurityDesc
            {
                get
                {
                    LegSecurityDesc val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSecurityDesc val) { LegSecurityDesc = val; }
            public LegSecurityDesc Get(LegSecurityDesc val) { GetField(val); return val; }
            public bool IsSet(LegSecurityDesc val) { return IsSetLegSecurityDesc(); }
            public bool IsSetLegSecurityDesc() { return IsSetField(Tags.LegSecurityDesc); }

            public EncodedLegSecurityDescLen EncodedLegSecurityDescLen
            {
                get
                {
                    EncodedLegSecurityDescLen val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EncodedLegSecurityDescLen val) { EncodedLegSecurityDescLen = val; }
            public EncodedLegSecurityDescLen Get(EncodedLegSecurityDescLen val) { GetField(val); return val; }
            public bool IsSet(EncodedLegSecurityDescLen val) { return IsSetEncodedLegSecurityDescLen(); }
            public bool IsSetEncodedLegSecurityDescLen() { return IsSetField(Tags.EncodedLegSecurityDescLen); }

            public EncodedLegSecurityDesc EncodedLegSecurityDesc
            {
                get
                {
                    EncodedLegSecurityDesc val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EncodedLegSecurityDesc val) { EncodedLegSecurityDesc = val; }
            public EncodedLegSecurityDesc Get(EncodedLegSecurityDesc val) { GetField(val); return val; }
            public bool IsSet(EncodedLegSecurityDesc val) { return IsSetEncodedLegSecurityDesc(); }
            public bool IsSetEncodedLegSecurityDesc() { return IsSetField(Tags.EncodedLegSecurityDesc); }

            public LegRatioQty LegRatioQty
            {
                get
                {
                    LegRatioQty val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegRatioQty val) { LegRatioQty = val; }
            public LegRatioQty Get(LegRatioQty val) { GetField(val); return val; }
            public bool IsSet(LegRatioQty val) { return IsSetLegRatioQty(); }
            public bool IsSetLegRatioQty() { return IsSetField(Tags.LegRatioQty); }

            public LegSide LegSide
            {
                get
                {
                    LegSide val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegSide val) { LegSide = val; }
            public LegSide Get(LegSide val) { GetField(val); return val; }
            public bool IsSet(LegSide val) { return IsSetLegSide(); }
            public bool IsSetLegSide() { return IsSetField(Tags.LegSide); }

            public LegCurrency LegCurrency
            {
                get
                {
                    LegCurrency val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegCurrency val) { LegCurrency = val; }
            public LegCurrency Get(LegCurrency val) { GetField(val); return val; }
            public bool IsSet(LegCurrency val) { return IsSetLegCurrency(); }
            public bool IsSetLegCurrency() { return IsSetField(Tags.LegCurrency); }

            public LegPool LegPool
            {
                get
                {
                    LegPool val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPool val) { LegPool = val; }
            public LegPool Get(LegPool val) { GetField(val); return val; }
            public bool IsSet(LegPool val) { return IsSetLegPool(); }
            public bool IsSetLegPool() { return IsSetField(Tags.LegPool); }

            public LegDatedDate LegDatedDate
            {
                get
                {
                    LegDatedDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegDatedDate val) { LegDatedDate = val; }
            public LegDatedDate Get(LegDatedDate val) { GetField(val); return val; }
            public bool IsSet(LegDatedDate val) { return IsSetLegDatedDate(); }
            public bool IsSetLegDatedDate() { return IsSetField(Tags.LegDatedDate); }

            public LegContractSettlMonth LegContractSettlMonth
            {
                get
                {
                    LegContractSettlMonth val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegContractSettlMonth val) { LegContractSettlMonth = val; }
            public LegContractSettlMonth Get(LegContractSettlMonth val) { GetField(val); return val; }
            public bool IsSet(LegContractSettlMonth val) { return IsSetLegContractSettlMonth(); }
            public bool IsSetLegContractSettlMonth() { return IsSetField(Tags.LegContractSettlMonth); }

            public LegInterestAccrualDate LegInterestAccrualDate
            {
                get
                {
                    LegInterestAccrualDate val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegInterestAccrualDate val) { LegInterestAccrualDate = val; }
            public LegInterestAccrualDate Get(LegInterestAccrualDate val) { GetField(val); return val; }
            public bool IsSet(LegInterestAccrualDate val) { return IsSetLegInterestAccrualDate(); }
            public bool IsSetLegInterestAccrualDate() { return IsSetField(Tags.LegInterestAccrualDate); }

            public LegUnitOfMeasure LegUnitOfMeasure
            {
                get
                {
                    LegUnitOfMeasure val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegUnitOfMeasure val) { LegUnitOfMeasure = val; }
            public LegUnitOfMeasure Get(LegUnitOfMeasure val) { GetField(val); return val; }
            public bool IsSet(LegUnitOfMeasure val) { return IsSetLegUnitOfMeasure(); }
            public bool IsSetLegUnitOfMeasure() { return IsSetField(Tags.LegUnitOfMeasure); }

            public LegTimeUnit LegTimeUnit
            {
                get
                {
                    LegTimeUnit val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegTimeUnit val) { LegTimeUnit = val; }
            public LegTimeUnit Get(LegTimeUnit val) { GetField(val); return val; }
            public bool IsSet(LegTimeUnit val) { return IsSetLegTimeUnit(); }
            public bool IsSetLegTimeUnit() { return IsSetField(Tags.LegTimeUnit); }

            public LegOptionRatio LegOptionRatio
            {
                get
                {
                    LegOptionRatio val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegOptionRatio val) { LegOptionRatio = val; }
            public LegOptionRatio Get(LegOptionRatio val) { GetField(val); return val; }
            public bool IsSet(LegOptionRatio val) { return IsSetLegOptionRatio(); }
            public bool IsSetLegOptionRatio() { return IsSetField(Tags.LegOptionRatio); }

            public LegPrice LegPrice
            {
                get
                {
                    LegPrice val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPrice val) { LegPrice = val; }
            public LegPrice Get(LegPrice val) { GetField(val); return val; }
            public bool IsSet(LegPrice val) { return IsSetLegPrice(); }
            public bool IsSetLegPrice() { return IsSetField(Tags.LegPrice); }

            public LegMaturityTime LegMaturityTime
            {
                get
                {
                    LegMaturityTime val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegMaturityTime val) { LegMaturityTime = val; }
            public LegMaturityTime Get(LegMaturityTime val) { GetField(val); return val; }
            public bool IsSet(LegMaturityTime val) { return IsSetLegMaturityTime(); }
            public bool IsSetLegMaturityTime() { return IsSetField(Tags.LegMaturityTime); }

            public LegPutOrCall LegPutOrCall
            {
                get
                {
                    LegPutOrCall val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPutOrCall val) { LegPutOrCall = val; }
            public LegPutOrCall Get(LegPutOrCall val) { GetField(val); return val; }
            public bool IsSet(LegPutOrCall val) { return IsSetLegPutOrCall(); }
            public bool IsSetLegPutOrCall() { return IsSetField(Tags.LegPutOrCall); }

            public LegExerciseStyle LegExerciseStyle
            {
                get
                {
                    LegExerciseStyle val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegExerciseStyle val) { LegExerciseStyle = val; }
            public LegExerciseStyle Get(LegExerciseStyle val) { GetField(val); return val; }
            public bool IsSet(LegExerciseStyle val) { return IsSetLegExerciseStyle(); }
            public bool IsSetLegExerciseStyle() { return IsSetField(Tags.LegExerciseStyle); }

            public LegUnitOfMeasureQty LegUnitOfMeasureQty
            {
                get
                {
                    LegUnitOfMeasureQty val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegUnitOfMeasureQty val) { LegUnitOfMeasureQty = val; }
            public LegUnitOfMeasureQty Get(LegUnitOfMeasureQty val) { GetField(val); return val; }
            public bool IsSet(LegUnitOfMeasureQty val) { return IsSetLegUnitOfMeasureQty(); }
            public bool IsSetLegUnitOfMeasureQty() { return IsSetField(Tags.LegUnitOfMeasureQty); }

            public LegPriceUnitOfMeasure LegPriceUnitOfMeasure
            {
                get
                {
                    LegPriceUnitOfMeasure val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPriceUnitOfMeasure val) { LegPriceUnitOfMeasure = val; }
            public LegPriceUnitOfMeasure Get(LegPriceUnitOfMeasure val) { GetField(val); return val; }
            public bool IsSet(LegPriceUnitOfMeasure val) { return IsSetLegPriceUnitOfMeasure(); }
            public bool IsSetLegPriceUnitOfMeasure() { return IsSetField(Tags.LegPriceUnitOfMeasure); }

            public LegPriceUnitOfMeasureQty LegPriceUnitOfMeasureQty
            {
                get
                {
                    LegPriceUnitOfMeasureQty val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LegPriceUnitOfMeasureQty val) { LegPriceUnitOfMeasureQty = val; }
            public LegPriceUnitOfMeasureQty Get(LegPriceUnitOfMeasureQty val) { GetField(val); return val; }
            public bool IsSet(LegPriceUnitOfMeasureQty val) { return IsSetLegPriceUnitOfMeasureQty(); }
            public bool IsSetLegPriceUnitOfMeasureQty() { return IsSetField(Tags.LegPriceUnitOfMeasureQty); }

            public class NoLegSecurityAltIDGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};

                public NoLegSecurityAltIDGroup()
                  : base(Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoLegSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public LegSecurityAltID LegSecurityAltID
                {
                    get
                    {
                        LegSecurityAltID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(LegSecurityAltID val) { LegSecurityAltID = val; }
                public LegSecurityAltID Get(LegSecurityAltID val) { GetField(val); return val; }
                public bool IsSet(LegSecurityAltID val) { return IsSetLegSecurityAltID(); }
                public bool IsSetLegSecurityAltID() { return IsSetField(Tags.LegSecurityAltID); }

                public LegSecurityAltIDSource LegSecurityAltIDSource
                {
                    get
                    {
                        LegSecurityAltIDSource val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(LegSecurityAltIDSource val) { LegSecurityAltIDSource = val; }
                public LegSecurityAltIDSource Get(LegSecurityAltIDSource val) { GetField(val); return val; }
                public bool IsSet(LegSecurityAltIDSource val) { return IsSetLegSecurityAltIDSource(); }
                public bool IsSetLegSecurityAltIDSource() { return IsSetField(Tags.LegSecurityAltIDSource); }
            }
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

    public class NoDerivativeInstrAttribGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.DerivativeInstrAttribType, Tags.DerivativeInstrAttribValue, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.DerivativeInstrAttribType, Tags.DerivativeInstrAttribValue, 0};

        public NoDerivativeInstrAttribGroup()
          : base(Tags.NoDerivativeInstrAttrib, Tags.DerivativeInstrAttribType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoDerivativeInstrAttribGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public DerivativeInstrAttribType DerivativeInstrAttribType
        {
            get
            {
                DerivativeInstrAttribType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeInstrAttribType val) { DerivativeInstrAttribType = val; }
        public DerivativeInstrAttribType Get(DerivativeInstrAttribType val) { GetField(val); return val; }
        public bool IsSet(DerivativeInstrAttribType val) { return IsSetDerivativeInstrAttribType(); }
        public bool IsSetDerivativeInstrAttribType() { return IsSetField(Tags.DerivativeInstrAttribType); }

        public DerivativeInstrAttribValue DerivativeInstrAttribValue
        {
            get
            {
                DerivativeInstrAttribValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(DerivativeInstrAttribValue val) { DerivativeInstrAttribValue = val; }
        public DerivativeInstrAttribValue Get(DerivativeInstrAttribValue val) { GetField(val); return val; }
        public bool IsSet(DerivativeInstrAttribValue val) { return IsSetDerivativeInstrAttribValue(); }
        public bool IsSetDerivativeInstrAttribValue() { return IsSetField(Tags.DerivativeInstrAttribValue); }
    }

    public class NoMarketSegmentsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.MarketID, Tags.MarketSegmentID, Tags.NoTickRules, Tags.NoLotTypeRules, Tags.PriceLimitType, Tags.LowLimitPrice, Tags.HighLimitPrice, Tags.TradingReferencePrice, Tags.ExpirationCycle, Tags.MinTradeVol, Tags.MaxTradeVol, Tags.MaxPriceVariation, Tags.ImpliedMarketIndicator, Tags.TradingCurrency, Tags.RoundLot, Tags.MultilegModel, Tags.MultilegPriceMethod, Tags.PriceType, Tags.NoTradingSessionRules, Tags.NoNestedInstrAttrib, Tags.NoStrikeRules, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.MarketID, Tags.MarketSegmentID, Tags.NoTickRules, Tags.NoLotTypeRules, Tags.PriceLimitType, Tags.LowLimitPrice, Tags.HighLimitPrice, Tags.TradingReferencePrice, Tags.ExpirationCycle, Tags.MinTradeVol, Tags.MaxTradeVol, Tags.MaxPriceVariation, Tags.ImpliedMarketIndicator, Tags.TradingCurrency, Tags.RoundLot, Tags.MultilegModel, Tags.MultilegPriceMethod, Tags.PriceType, Tags.NoTradingSessionRules, Tags.NoNestedInstrAttrib, Tags.NoStrikeRules, 0};

        public NoMarketSegmentsGroup()
          : base(Tags.NoMarketSegments, Tags.MarketID, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoMarketSegmentsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

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

        public NoTickRules NoTickRules
        {
            get
            {
                NoTickRules val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoTickRules val) { NoTickRules = val; }
        public NoTickRules Get(NoTickRules val) { GetField(val); return val; }
        public bool IsSet(NoTickRules val) { return IsSetNoTickRules(); }
        public bool IsSetNoTickRules() { return IsSetField(Tags.NoTickRules); }

        public NoLotTypeRules NoLotTypeRules
        {
            get
            {
                NoLotTypeRules val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoLotTypeRules val) { NoLotTypeRules = val; }
        public NoLotTypeRules Get(NoLotTypeRules val) { GetField(val); return val; }
        public bool IsSet(NoLotTypeRules val) { return IsSetNoLotTypeRules(); }
        public bool IsSetNoLotTypeRules() { return IsSetField(Tags.NoLotTypeRules); }

        public PriceLimitType PriceLimitType
        {
            get
            {
                PriceLimitType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceLimitType val) { PriceLimitType = val; }
        public PriceLimitType Get(PriceLimitType val) { GetField(val); return val; }
        public bool IsSet(PriceLimitType val) { return IsSetPriceLimitType(); }
        public bool IsSetPriceLimitType() { return IsSetField(Tags.PriceLimitType); }

        public LowLimitPrice LowLimitPrice
        {
            get
            {
                LowLimitPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(LowLimitPrice val) { LowLimitPrice = val; }
        public LowLimitPrice Get(LowLimitPrice val) { GetField(val); return val; }
        public bool IsSet(LowLimitPrice val) { return IsSetLowLimitPrice(); }
        public bool IsSetLowLimitPrice() { return IsSetField(Tags.LowLimitPrice); }

        public HighLimitPrice HighLimitPrice
        {
            get
            {
                HighLimitPrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(HighLimitPrice val) { HighLimitPrice = val; }
        public HighLimitPrice Get(HighLimitPrice val) { GetField(val); return val; }
        public bool IsSet(HighLimitPrice val) { return IsSetHighLimitPrice(); }
        public bool IsSetHighLimitPrice() { return IsSetField(Tags.HighLimitPrice); }

        public TradingReferencePrice TradingReferencePrice
        {
            get
            {
                TradingReferencePrice val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingReferencePrice val) { TradingReferencePrice = val; }
        public TradingReferencePrice Get(TradingReferencePrice val) { GetField(val); return val; }
        public bool IsSet(TradingReferencePrice val) { return IsSetTradingReferencePrice(); }
        public bool IsSetTradingReferencePrice() { return IsSetField(Tags.TradingReferencePrice); }

        public ExpirationCycle ExpirationCycle
        {
            get
            {
                ExpirationCycle val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ExpirationCycle val) { ExpirationCycle = val; }
        public ExpirationCycle Get(ExpirationCycle val) { GetField(val); return val; }
        public bool IsSet(ExpirationCycle val) { return IsSetExpirationCycle(); }
        public bool IsSetExpirationCycle() { return IsSetField(Tags.ExpirationCycle); }

        public MinTradeVol MinTradeVol
        {
            get
            {
                MinTradeVol val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MinTradeVol val) { MinTradeVol = val; }
        public MinTradeVol Get(MinTradeVol val) { GetField(val); return val; }
        public bool IsSet(MinTradeVol val) { return IsSetMinTradeVol(); }
        public bool IsSetMinTradeVol() { return IsSetField(Tags.MinTradeVol); }

        public MaxTradeVol MaxTradeVol
        {
            get
            {
                MaxTradeVol val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaxTradeVol val) { MaxTradeVol = val; }
        public MaxTradeVol Get(MaxTradeVol val) { GetField(val); return val; }
        public bool IsSet(MaxTradeVol val) { return IsSetMaxTradeVol(); }
        public bool IsSetMaxTradeVol() { return IsSetField(Tags.MaxTradeVol); }

        public MaxPriceVariation MaxPriceVariation
        {
            get
            {
                MaxPriceVariation val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MaxPriceVariation val) { MaxPriceVariation = val; }
        public MaxPriceVariation Get(MaxPriceVariation val) { GetField(val); return val; }
        public bool IsSet(MaxPriceVariation val) { return IsSetMaxPriceVariation(); }
        public bool IsSetMaxPriceVariation() { return IsSetField(Tags.MaxPriceVariation); }

        public ImpliedMarketIndicator ImpliedMarketIndicator
        {
            get
            {
                ImpliedMarketIndicator val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(ImpliedMarketIndicator val) { ImpliedMarketIndicator = val; }
        public ImpliedMarketIndicator Get(ImpliedMarketIndicator val) { GetField(val); return val; }
        public bool IsSet(ImpliedMarketIndicator val) { return IsSetImpliedMarketIndicator(); }
        public bool IsSetImpliedMarketIndicator() { return IsSetField(Tags.ImpliedMarketIndicator); }

        public TradingCurrency TradingCurrency
        {
            get
            {
                TradingCurrency val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingCurrency val) { TradingCurrency = val; }
        public TradingCurrency Get(TradingCurrency val) { GetField(val); return val; }
        public bool IsSet(TradingCurrency val) { return IsSetTradingCurrency(); }
        public bool IsSetTradingCurrency() { return IsSetField(Tags.TradingCurrency); }

        public RoundLot RoundLot
        {
            get
            {
                RoundLot val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(RoundLot val) { RoundLot = val; }
        public RoundLot Get(RoundLot val) { GetField(val); return val; }
        public bool IsSet(RoundLot val) { return IsSetRoundLot(); }
        public bool IsSetRoundLot() { return IsSetField(Tags.RoundLot); }

        public MultilegModel MultilegModel
        {
            get
            {
                MultilegModel val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MultilegModel val) { MultilegModel = val; }
        public MultilegModel Get(MultilegModel val) { GetField(val); return val; }
        public bool IsSet(MultilegModel val) { return IsSetMultilegModel(); }
        public bool IsSetMultilegModel() { return IsSetField(Tags.MultilegModel); }

        public MultilegPriceMethod MultilegPriceMethod
        {
            get
            {
                MultilegPriceMethod val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MultilegPriceMethod val) { MultilegPriceMethod = val; }
        public MultilegPriceMethod Get(MultilegPriceMethod val) { GetField(val); return val; }
        public bool IsSet(MultilegPriceMethod val) { return IsSetMultilegPriceMethod(); }
        public bool IsSetMultilegPriceMethod() { return IsSetField(Tags.MultilegPriceMethod); }

        public PriceType PriceType
        {
            get
            {
                PriceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceType val) { PriceType = val; }
        public PriceType Get(PriceType val) { GetField(val); return val; }
        public bool IsSet(PriceType val) { return IsSetPriceType(); }
        public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

        public NoTradingSessionRules NoTradingSessionRules
        {
            get
            {
                NoTradingSessionRules val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoTradingSessionRules val) { NoTradingSessionRules = val; }
        public NoTradingSessionRules Get(NoTradingSessionRules val) { GetField(val); return val; }
        public bool IsSet(NoTradingSessionRules val) { return IsSetNoTradingSessionRules(); }
        public bool IsSetNoTradingSessionRules() { return IsSetField(Tags.NoTradingSessionRules); }

        public NoNestedInstrAttrib NoNestedInstrAttrib
        {
            get
            {
                NoNestedInstrAttrib val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoNestedInstrAttrib val) { NoNestedInstrAttrib = val; }
        public NoNestedInstrAttrib Get(NoNestedInstrAttrib val) { GetField(val); return val; }
        public bool IsSet(NoNestedInstrAttrib val) { return IsSetNoNestedInstrAttrib(); }
        public bool IsSetNoNestedInstrAttrib() { return IsSetField(Tags.NoNestedInstrAttrib); }

        public NoStrikeRules NoStrikeRules
        {
            get
            {
                NoStrikeRules val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NoStrikeRules val) { NoStrikeRules = val; }
        public NoStrikeRules Get(NoStrikeRules val) { GetField(val); return val; }
        public bool IsSet(NoStrikeRules val) { return IsSetNoStrikeRules(); }
        public bool IsSetNoStrikeRules() { return IsSetField(Tags.NoStrikeRules); }

        public class NoTickRulesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, 0};

            public NoTickRulesGroup()
              : base(Tags.NoTickRules, Tags.StartTickPriceRange, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoTickRulesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public StartTickPriceRange StartTickPriceRange
            {
                get
                {
                    StartTickPriceRange val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(StartTickPriceRange val) { StartTickPriceRange = val; }
            public StartTickPriceRange Get(StartTickPriceRange val) { GetField(val); return val; }
            public bool IsSet(StartTickPriceRange val) { return IsSetStartTickPriceRange(); }
            public bool IsSetStartTickPriceRange() { return IsSetField(Tags.StartTickPriceRange); }

            public EndTickPriceRange EndTickPriceRange
            {
                get
                {
                    EndTickPriceRange val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EndTickPriceRange val) { EndTickPriceRange = val; }
            public EndTickPriceRange Get(EndTickPriceRange val) { GetField(val); return val; }
            public bool IsSet(EndTickPriceRange val) { return IsSetEndTickPriceRange(); }
            public bool IsSetEndTickPriceRange() { return IsSetField(Tags.EndTickPriceRange); }

            public TickIncrement TickIncrement
            {
                get
                {
                    TickIncrement val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(TickIncrement val) { TickIncrement = val; }
            public TickIncrement Get(TickIncrement val) { GetField(val); return val; }
            public bool IsSet(TickIncrement val) { return IsSetTickIncrement(); }
            public bool IsSetTickIncrement() { return IsSetField(Tags.TickIncrement); }

            public TickRuleType TickRuleType
            {
                get
                {
                    TickRuleType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(TickRuleType val) { TickRuleType = val; }
            public TickRuleType Get(TickRuleType val) { GetField(val); return val; }
            public bool IsSet(TickRuleType val) { return IsSetTickRuleType(); }
            public bool IsSetTickRuleType() { return IsSetField(Tags.TickRuleType); }
        }

        public class NoLotTypeRulesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.LotType, Tags.MinLotSize, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.LotType, Tags.MinLotSize, 0};

            public NoLotTypeRulesGroup()
              : base(Tags.NoLotTypeRules, Tags.LotType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoLotTypeRulesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public LotType LotType
            {
                get
                {
                    LotType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(LotType val) { LotType = val; }
            public LotType Get(LotType val) { GetField(val); return val; }
            public bool IsSet(LotType val) { return IsSetLotType(); }
            public bool IsSetLotType() { return IsSetField(Tags.LotType); }

            public MinLotSize MinLotSize
            {
                get
                {
                    MinLotSize val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(MinLotSize val) { MinLotSize = val; }
            public MinLotSize Get(MinLotSize val) { GetField(val); return val; }
            public bool IsSet(MinLotSize val) { return IsSetMinLotSize(); }
            public bool IsSetMinLotSize() { return IsSetField(Tags.MinLotSize); }
        }

        public class NoTradingSessionRulesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.NoOrdTypeRules, Tags.NoTimeInForceRules, Tags.NoExecInstRules, Tags.NoMatchRules, Tags.NoMDFeedTypes, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.NoOrdTypeRules, Tags.NoTimeInForceRules, Tags.NoExecInstRules, Tags.NoMatchRules, Tags.NoMDFeedTypes, 0};

            public NoTradingSessionRulesGroup()
              : base(Tags.NoTradingSessionRules, Tags.TradingSessionID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoTradingSessionRulesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

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

            public NoOrdTypeRules NoOrdTypeRules
            {
                get
                {
                    NoOrdTypeRules val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoOrdTypeRules val) { NoOrdTypeRules = val; }
            public NoOrdTypeRules Get(NoOrdTypeRules val) { GetField(val); return val; }
            public bool IsSet(NoOrdTypeRules val) { return IsSetNoOrdTypeRules(); }
            public bool IsSetNoOrdTypeRules() { return IsSetField(Tags.NoOrdTypeRules); }

            public NoTimeInForceRules NoTimeInForceRules
            {
                get
                {
                    NoTimeInForceRules val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoTimeInForceRules val) { NoTimeInForceRules = val; }
            public NoTimeInForceRules Get(NoTimeInForceRules val) { GetField(val); return val; }
            public bool IsSet(NoTimeInForceRules val) { return IsSetNoTimeInForceRules(); }
            public bool IsSetNoTimeInForceRules() { return IsSetField(Tags.NoTimeInForceRules); }

            public NoExecInstRules NoExecInstRules
            {
                get
                {
                    NoExecInstRules val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoExecInstRules val) { NoExecInstRules = val; }
            public NoExecInstRules Get(NoExecInstRules val) { GetField(val); return val; }
            public bool IsSet(NoExecInstRules val) { return IsSetNoExecInstRules(); }
            public bool IsSetNoExecInstRules() { return IsSetField(Tags.NoExecInstRules); }

            public NoMatchRules NoMatchRules
            {
                get
                {
                    NoMatchRules val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoMatchRules val) { NoMatchRules = val; }
            public NoMatchRules Get(NoMatchRules val) { GetField(val); return val; }
            public bool IsSet(NoMatchRules val) { return IsSetNoMatchRules(); }
            public bool IsSetNoMatchRules() { return IsSetField(Tags.NoMatchRules); }

            public NoMDFeedTypes NoMDFeedTypes
            {
                get
                {
                    NoMDFeedTypes val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoMDFeedTypes val) { NoMDFeedTypes = val; }
            public NoMDFeedTypes Get(NoMDFeedTypes val) { GetField(val); return val; }
            public bool IsSet(NoMDFeedTypes val) { return IsSetNoMDFeedTypes(); }
            public bool IsSetNoMDFeedTypes() { return IsSetField(Tags.NoMDFeedTypes); }

            public class NoOrdTypeRulesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.OrdType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.OrdType, 0};

                public NoOrdTypeRulesGroup()
                  : base(Tags.NoOrdTypeRules, Tags.OrdType, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoOrdTypeRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public OrdType OrdType
                {
                    get
                    {
                        OrdType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(OrdType val) { OrdType = val; }
                public OrdType Get(OrdType val) { GetField(val); return val; }
                public bool IsSet(OrdType val) { return IsSetOrdType(); }
                public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }
            }

            public class NoTimeInForceRulesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.TimeInForce, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.TimeInForce, 0};

                public NoTimeInForceRulesGroup()
                  : base(Tags.NoTimeInForceRules, Tags.TimeInForce, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoTimeInForceRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public TimeInForce TimeInForce
                {
                    get
                    {
                        TimeInForce val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(TimeInForce val) { TimeInForce = val; }
                public TimeInForce Get(TimeInForce val) { GetField(val); return val; }
                public bool IsSet(TimeInForce val) { return IsSetTimeInForce(); }
                public bool IsSetTimeInForce() { return IsSetField(Tags.TimeInForce); }
            }

            public class NoExecInstRulesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.ExecInstValue, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.ExecInstValue, 0};

                public NoExecInstRulesGroup()
                  : base(Tags.NoExecInstRules, Tags.ExecInstValue, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoExecInstRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public ExecInstValue ExecInstValue
                {
                    get
                    {
                        ExecInstValue val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(ExecInstValue val) { ExecInstValue = val; }
                public ExecInstValue Get(ExecInstValue val) { GetField(val); return val; }
                public bool IsSet(ExecInstValue val) { return IsSetExecInstValue(); }
                public bool IsSetExecInstValue() { return IsSetField(Tags.ExecInstValue); }
            }

            public class NoMatchRulesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.MatchAlgorithm, Tags.MatchType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.MatchAlgorithm, Tags.MatchType, 0};

                public NoMatchRulesGroup()
                  : base(Tags.NoMatchRules, Tags.MatchAlgorithm, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMatchRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public MatchAlgorithm MatchAlgorithm
                {
                    get
                    {
                        MatchAlgorithm val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MatchAlgorithm val) { MatchAlgorithm = val; }
                public MatchAlgorithm Get(MatchAlgorithm val) { GetField(val); return val; }
                public bool IsSet(MatchAlgorithm val) { return IsSetMatchAlgorithm(); }
                public bool IsSetMatchAlgorithm() { return IsSetField(Tags.MatchAlgorithm); }

                public MatchType MatchType
                {
                    get
                    {
                        MatchType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MatchType val) { MatchType = val; }
                public MatchType Get(MatchType val) { GetField(val); return val; }
                public bool IsSet(MatchType val) { return IsSetMatchType(); }
                public bool IsSetMatchType() { return IsSetField(Tags.MatchType); }
            }

            public class NoMDFeedTypesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.MDFeedType, Tags.MarketDepth, Tags.MDBookType, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.MDFeedType, Tags.MarketDepth, Tags.MDBookType, 0};

                public NoMDFeedTypesGroup()
                  : base(Tags.NoMDFeedTypes, Tags.MDFeedType, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMDFeedTypesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public MDFeedType MDFeedType
                {
                    get
                    {
                        MDFeedType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MDFeedType val) { MDFeedType = val; }
                public MDFeedType Get(MDFeedType val) { GetField(val); return val; }
                public bool IsSet(MDFeedType val) { return IsSetMDFeedType(); }
                public bool IsSetMDFeedType() { return IsSetField(Tags.MDFeedType); }

                public MarketDepth MarketDepth
                {
                    get
                    {
                        MarketDepth val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MarketDepth val) { MarketDepth = val; }
                public MarketDepth Get(MarketDepth val) { GetField(val); return val; }
                public bool IsSet(MarketDepth val) { return IsSetMarketDepth(); }
                public bool IsSetMarketDepth() { return IsSetField(Tags.MarketDepth); }

                public MDBookType MDBookType
                {
                    get
                    {
                        MDBookType val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MDBookType val) { MDBookType = val; }
                public MDBookType Get(MDBookType val) { GetField(val); return val; }
                public bool IsSet(MDBookType val) { return IsSetMDBookType(); }
                public bool IsSetMDBookType() { return IsSetField(Tags.MDBookType); }
            }
        }

        public class NoNestedInstrAttribGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.NestedInstrAttribType, Tags.NestedInstrAttribValue, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.NestedInstrAttribType, Tags.NestedInstrAttribValue, 0};

            public NoNestedInstrAttribGroup()
              : base(Tags.NoNestedInstrAttrib, Tags.NestedInstrAttribType, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoNestedInstrAttribGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public NestedInstrAttribType NestedInstrAttribType
            {
                get
                {
                    NestedInstrAttribType val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedInstrAttribType val) { NestedInstrAttribType = val; }
            public NestedInstrAttribType Get(NestedInstrAttribType val) { GetField(val); return val; }
            public bool IsSet(NestedInstrAttribType val) { return IsSetNestedInstrAttribType(); }
            public bool IsSetNestedInstrAttribType() { return IsSetField(Tags.NestedInstrAttribType); }

            public NestedInstrAttribValue NestedInstrAttribValue
            {
                get
                {
                    NestedInstrAttribValue val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NestedInstrAttribValue val) { NestedInstrAttribValue = val; }
            public NestedInstrAttribValue Get(NestedInstrAttribValue val) { GetField(val); return val; }
            public bool IsSet(NestedInstrAttribValue val) { return IsSetNestedInstrAttribValue(); }
            public bool IsSetNestedInstrAttribValue() { return IsSetField(Tags.NestedInstrAttribValue); }
        }

        public class NoStrikeRulesGroup : Group
        {
            public static int[] DefaultFieldOrder = [Tags.StrikeRuleID, Tags.StartStrikePxRange, Tags.EndStrikePxRange, Tags.StrikeIncrement, Tags.StrikeExerciseStyle, Tags.NoMaturityRules, 0];

            [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
            public static int[] fieldOrder = {Tags.StrikeRuleID, Tags.StartStrikePxRange, Tags.EndStrikePxRange, Tags.StrikeIncrement, Tags.StrikeExerciseStyle, Tags.NoMaturityRules, 0};

            public NoStrikeRulesGroup()
              : base(Tags.NoStrikeRules, Tags.StrikeRuleID, DefaultFieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new NoStrikeRulesGroup();
                clone.CopyStateFrom(this);
                return clone;
            }

            public StrikeRuleID StrikeRuleID
            {
                get
                {
                    StrikeRuleID val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(StrikeRuleID val) { StrikeRuleID = val; }
            public StrikeRuleID Get(StrikeRuleID val) { GetField(val); return val; }
            public bool IsSet(StrikeRuleID val) { return IsSetStrikeRuleID(); }
            public bool IsSetStrikeRuleID() { return IsSetField(Tags.StrikeRuleID); }

            public StartStrikePxRange StartStrikePxRange
            {
                get
                {
                    StartStrikePxRange val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(StartStrikePxRange val) { StartStrikePxRange = val; }
            public StartStrikePxRange Get(StartStrikePxRange val) { GetField(val); return val; }
            public bool IsSet(StartStrikePxRange val) { return IsSetStartStrikePxRange(); }
            public bool IsSetStartStrikePxRange() { return IsSetField(Tags.StartStrikePxRange); }

            public EndStrikePxRange EndStrikePxRange
            {
                get
                {
                    EndStrikePxRange val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(EndStrikePxRange val) { EndStrikePxRange = val; }
            public EndStrikePxRange Get(EndStrikePxRange val) { GetField(val); return val; }
            public bool IsSet(EndStrikePxRange val) { return IsSetEndStrikePxRange(); }
            public bool IsSetEndStrikePxRange() { return IsSetField(Tags.EndStrikePxRange); }

            public StrikeIncrement StrikeIncrement
            {
                get
                {
                    StrikeIncrement val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(StrikeIncrement val) { StrikeIncrement = val; }
            public StrikeIncrement Get(StrikeIncrement val) { GetField(val); return val; }
            public bool IsSet(StrikeIncrement val) { return IsSetStrikeIncrement(); }
            public bool IsSetStrikeIncrement() { return IsSetField(Tags.StrikeIncrement); }

            public StrikeExerciseStyle StrikeExerciseStyle
            {
                get
                {
                    StrikeExerciseStyle val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(StrikeExerciseStyle val) { StrikeExerciseStyle = val; }
            public StrikeExerciseStyle Get(StrikeExerciseStyle val) { GetField(val); return val; }
            public bool IsSet(StrikeExerciseStyle val) { return IsSetStrikeExerciseStyle(); }
            public bool IsSetStrikeExerciseStyle() { return IsSetField(Tags.StrikeExerciseStyle); }

            public NoMaturityRules NoMaturityRules
            {
                get
                {
                    NoMaturityRules val = new();
                    GetField(val);
                    return val;
                }
                set  => SetField(value);
            }

            public void Set(NoMaturityRules val) { NoMaturityRules = val; }
            public NoMaturityRules Get(NoMaturityRules val) { GetField(val); return val; }
            public bool IsSet(NoMaturityRules val) { return IsSetNoMaturityRules(); }
            public bool IsSetNoMaturityRules() { return IsSetField(Tags.NoMaturityRules); }

            public class NoMaturityRulesGroup : Group
            {
                public static int[] DefaultFieldOrder = [Tags.MaturityRuleID, Tags.MaturityMonthYearFormat, Tags.MaturityMonthYearIncrementUnits, Tags.StartMaturityMonthYear, Tags.EndMaturityMonthYear, Tags.MaturityMonthYearIncrement, 0];

                [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
                public static int[] fieldOrder = {Tags.MaturityRuleID, Tags.MaturityMonthYearFormat, Tags.MaturityMonthYearIncrementUnits, Tags.StartMaturityMonthYear, Tags.EndMaturityMonthYear, Tags.MaturityMonthYearIncrement, 0};

                public NoMaturityRulesGroup()
                  : base(Tags.NoMaturityRules, Tags.MaturityRuleID, DefaultFieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoMaturityRulesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public MaturityRuleID MaturityRuleID
                {
                    get
                    {
                        MaturityRuleID val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MaturityRuleID val) { MaturityRuleID = val; }
                public MaturityRuleID Get(MaturityRuleID val) { GetField(val); return val; }
                public bool IsSet(MaturityRuleID val) { return IsSetMaturityRuleID(); }
                public bool IsSetMaturityRuleID() { return IsSetField(Tags.MaturityRuleID); }

                public MaturityMonthYearFormat MaturityMonthYearFormat
                {
                    get
                    {
                        MaturityMonthYearFormat val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MaturityMonthYearFormat val) { MaturityMonthYearFormat = val; }
                public MaturityMonthYearFormat Get(MaturityMonthYearFormat val) { GetField(val); return val; }
                public bool IsSet(MaturityMonthYearFormat val) { return IsSetMaturityMonthYearFormat(); }
                public bool IsSetMaturityMonthYearFormat() { return IsSetField(Tags.MaturityMonthYearFormat); }

                public MaturityMonthYearIncrementUnits MaturityMonthYearIncrementUnits
                {
                    get
                    {
                        MaturityMonthYearIncrementUnits val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MaturityMonthYearIncrementUnits val) { MaturityMonthYearIncrementUnits = val; }
                public MaturityMonthYearIncrementUnits Get(MaturityMonthYearIncrementUnits val) { GetField(val); return val; }
                public bool IsSet(MaturityMonthYearIncrementUnits val) { return IsSetMaturityMonthYearIncrementUnits(); }
                public bool IsSetMaturityMonthYearIncrementUnits() { return IsSetField(Tags.MaturityMonthYearIncrementUnits); }

                public StartMaturityMonthYear StartMaturityMonthYear
                {
                    get
                    {
                        StartMaturityMonthYear val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(StartMaturityMonthYear val) { StartMaturityMonthYear = val; }
                public StartMaturityMonthYear Get(StartMaturityMonthYear val) { GetField(val); return val; }
                public bool IsSet(StartMaturityMonthYear val) { return IsSetStartMaturityMonthYear(); }
                public bool IsSetStartMaturityMonthYear() { return IsSetField(Tags.StartMaturityMonthYear); }

                public EndMaturityMonthYear EndMaturityMonthYear
                {
                    get
                    {
                        EndMaturityMonthYear val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(EndMaturityMonthYear val) { EndMaturityMonthYear = val; }
                public EndMaturityMonthYear Get(EndMaturityMonthYear val) { GetField(val); return val; }
                public bool IsSet(EndMaturityMonthYear val) { return IsSetEndMaturityMonthYear(); }
                public bool IsSetEndMaturityMonthYear() { return IsSetField(Tags.EndMaturityMonthYear); }

                public MaturityMonthYearIncrement MaturityMonthYearIncrement
                {
                    get
                    {
                        MaturityMonthYearIncrement val = new();
                        GetField(val);
                        return val;
                    }
                    set  => SetField(value);
                }

                public void Set(MaturityMonthYearIncrement val) { MaturityMonthYearIncrement = val; }
                public MaturityMonthYearIncrement Get(MaturityMonthYearIncrement val) { GetField(val); return val; }
                public bool IsSet(MaturityMonthYearIncrement val) { return IsSetMaturityMonthYearIncrement(); }
                public bool IsSetMaturityMonthYearIncrement() { return IsSetField(Tags.MaturityMonthYearIncrement); }
            }
        }
    }
}
