// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

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
}
