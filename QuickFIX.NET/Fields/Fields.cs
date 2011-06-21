using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// Account Field
    /// </summary>/
    public sealed class Account : StringField
    {
        public Account()
            :base(Tags.Account) {}
        public Account(string val)
            :base(Tags.Account, val) {}
    }


    /// <summary>
    /// AccountType Field
    /// </summary>/
    public sealed class AccountType : IntField
    {
        public AccountType()
            :base(Tags.AccountType) {}
        public AccountType(int val)
            :base(Tags.AccountType, val) {}
    }


    /// <summary>
    /// AccruedInterestAmt Field
    /// </summary>/
    public sealed class AccruedInterestAmt : DecimalField
    {
        public AccruedInterestAmt()
            :base(Tags.AccruedInterestAmt) {}
        public AccruedInterestAmt(Decimal val)
            :base(Tags.AccruedInterestAmt, val) {}
    }


    /// <summary>
    /// AccruedInterestRate Field
    /// </summary>/
    public sealed class AccruedInterestRate : DecimalField
    {
        public AccruedInterestRate()
            :base(Tags.AccruedInterestRate) {}
        public AccruedInterestRate(Decimal val)
            :base(Tags.AccruedInterestRate, val) {}
    }


    /// <summary>
    /// AcctIDSource Field
    /// </summary>/
    public sealed class AcctIDSource : IntField
    {
        public AcctIDSource()
            :base(Tags.AcctIDSource) {}
        public AcctIDSource(int val)
            :base(Tags.AcctIDSource, val) {}
    }


    /// <summary>
    /// Adjustment Field
    /// </summary>/
    public sealed class Adjustment : IntField
    {
        public Adjustment()
            :base(Tags.Adjustment) {}
        public Adjustment(int val)
            :base(Tags.Adjustment, val) {}
    }


    /// <summary>
    /// AdjustmentType Field
    /// </summary>/
    public sealed class AdjustmentType : IntField
    {
        public AdjustmentType()
            :base(Tags.AdjustmentType) {}
        public AdjustmentType(int val)
            :base(Tags.AdjustmentType, val) {}
    }


    /// <summary>
    /// AdvId Field
    /// </summary>/
    public sealed class AdvId : StringField
    {
        public AdvId()
            :base(Tags.AdvId) {}
        public AdvId(string val)
            :base(Tags.AdvId, val) {}
    }


    /// <summary>
    /// AdvRefID Field
    /// </summary>/
    public sealed class AdvRefID : StringField
    {
        public AdvRefID()
            :base(Tags.AdvRefID) {}
        public AdvRefID(string val)
            :base(Tags.AdvRefID, val) {}
    }


    /// <summary>
    /// AdvSide Field
    /// </summary>/
    public sealed class AdvSide : CharField
    {
        public AdvSide()
            :base(Tags.AdvSide) {}
        public AdvSide(char val)
            :base(Tags.AdvSide, val) {}
    }


    /// <summary>
    /// AdvTransType Field
    /// </summary>/
    public sealed class AdvTransType : StringField
    {
        public AdvTransType()
            :base(Tags.AdvTransType) {}
        public AdvTransType(string val)
            :base(Tags.AdvTransType, val) {}
    }


    /// <summary>
    /// AffectedOrderID Field
    /// </summary>/
    public sealed class AffectedOrderID : StringField
    {
        public AffectedOrderID()
            :base(Tags.AffectedOrderID) {}
        public AffectedOrderID(string val)
            :base(Tags.AffectedOrderID, val) {}
    }


    /// <summary>
    /// AffectedSecondaryOrderID Field
    /// </summary>/
    public sealed class AffectedSecondaryOrderID : StringField
    {
        public AffectedSecondaryOrderID()
            :base(Tags.AffectedSecondaryOrderID) {}
        public AffectedSecondaryOrderID(string val)
            :base(Tags.AffectedSecondaryOrderID, val) {}
    }


    /// <summary>
    /// AffirmStatus Field
    /// </summary>/
    public sealed class AffirmStatus : IntField
    {
        public AffirmStatus()
            :base(Tags.AffirmStatus) {}
        public AffirmStatus(int val)
            :base(Tags.AffirmStatus, val) {}
    }


    /// <summary>
    /// AggregatedBook Field
    /// </summary>/
    public sealed class AggregatedBook : BooleanField
    {
        public AggregatedBook()
            :base(Tags.AggregatedBook) {}
        public AggregatedBook(Boolean val)
            :base(Tags.AggregatedBook, val) {}
    }


    /// <summary>
    /// AgreementCurrency Field
    /// </summary>/
    public sealed class AgreementCurrency : DecimalField
    {
        public AgreementCurrency()
            :base(Tags.AgreementCurrency) {}
        public AgreementCurrency(Decimal val)
            :base(Tags.AgreementCurrency, val) {}
    }


    /// <summary>
    /// AgreementDate Field
    /// </summary>/
    public sealed class AgreementDate : DateTimeField
    {
        public AgreementDate()
            :base(Tags.AgreementDate) {}
        public AgreementDate(DateTime val)
            :base(Tags.AgreementDate, val) {}
    }


    /// <summary>
    /// AgreementDesc Field
    /// </summary>/
    public sealed class AgreementDesc : StringField
    {
        public AgreementDesc()
            :base(Tags.AgreementDesc) {}
        public AgreementDesc(string val)
            :base(Tags.AgreementDesc, val) {}
    }


    /// <summary>
    /// AgreementID Field
    /// </summary>/
    public sealed class AgreementID : StringField
    {
        public AgreementID()
            :base(Tags.AgreementID) {}
        public AgreementID(string val)
            :base(Tags.AgreementID, val) {}
    }


    /// <summary>
    /// AllocAccount Field
    /// </summary>/
    public sealed class AllocAccount : StringField
    {
        public AllocAccount()
            :base(Tags.AllocAccount) {}
        public AllocAccount(string val)
            :base(Tags.AllocAccount, val) {}
    }


    /// <summary>
    /// AllocAccountType Field
    /// </summary>/
    public sealed class AllocAccountType : IntField
    {
        public AllocAccountType()
            :base(Tags.AllocAccountType) {}
        public AllocAccountType(int val)
            :base(Tags.AllocAccountType, val) {}
    }


    /// <summary>
    /// AllocAccruedInterestAmt Field
    /// </summary>/
    public sealed class AllocAccruedInterestAmt : DecimalField
    {
        public AllocAccruedInterestAmt()
            :base(Tags.AllocAccruedInterestAmt) {}
        public AllocAccruedInterestAmt(Decimal val)
            :base(Tags.AllocAccruedInterestAmt, val) {}
    }


    /// <summary>
    /// AllocAcctIDSource Field
    /// </summary>/
    public sealed class AllocAcctIDSource : IntField
    {
        public AllocAcctIDSource()
            :base(Tags.AllocAcctIDSource) {}
        public AllocAcctIDSource(int val)
            :base(Tags.AllocAcctIDSource, val) {}
    }


    /// <summary>
    /// AllocAvgPx Field
    /// </summary>/
    public sealed class AllocAvgPx : DecimalField
    {
        public AllocAvgPx()
            :base(Tags.AllocAvgPx) {}
        public AllocAvgPx(Decimal val)
            :base(Tags.AllocAvgPx, val) {}
    }


    /// <summary>
    /// AllocCancReplaceReason Field
    /// </summary>/
    public sealed class AllocCancReplaceReason : IntField
    {
        public AllocCancReplaceReason()
            :base(Tags.AllocCancReplaceReason) {}
        public AllocCancReplaceReason(int val)
            :base(Tags.AllocCancReplaceReason, val) {}
    }


    /// <summary>
    /// AllocHandlInst Field
    /// </summary>/
    public sealed class AllocHandlInst : IntField
    {
        public AllocHandlInst()
            :base(Tags.AllocHandlInst) {}
        public AllocHandlInst(int val)
            :base(Tags.AllocHandlInst, val) {}
    }


    /// <summary>
    /// AllocID Field
    /// </summary>/
    public sealed class AllocID : StringField
    {
        public AllocID()
            :base(Tags.AllocID) {}
        public AllocID(string val)
            :base(Tags.AllocID, val) {}
    }


    /// <summary>
    /// AllocInterestAtMaturity Field
    /// </summary>/
    public sealed class AllocInterestAtMaturity : DecimalField
    {
        public AllocInterestAtMaturity()
            :base(Tags.AllocInterestAtMaturity) {}
        public AllocInterestAtMaturity(Decimal val)
            :base(Tags.AllocInterestAtMaturity, val) {}
    }


    /// <summary>
    /// AllocIntermedReqType Field
    /// </summary>/
    public sealed class AllocIntermedReqType : IntField
    {
        public AllocIntermedReqType()
            :base(Tags.AllocIntermedReqType) {}
        public AllocIntermedReqType(int val)
            :base(Tags.AllocIntermedReqType, val) {}
    }


    /// <summary>
    /// AllocLinkID Field
    /// </summary>/
    public sealed class AllocLinkID : StringField
    {
        public AllocLinkID()
            :base(Tags.AllocLinkID) {}
        public AllocLinkID(string val)
            :base(Tags.AllocLinkID, val) {}
    }


    /// <summary>
    /// AllocLinkType Field
    /// </summary>/
    public sealed class AllocLinkType : IntField
    {
        public AllocLinkType()
            :base(Tags.AllocLinkType) {}
        public AllocLinkType(int val)
            :base(Tags.AllocLinkType, val) {}
    }


    /// <summary>
    /// AllocNetMoney Field
    /// </summary>/
    public sealed class AllocNetMoney : DecimalField
    {
        public AllocNetMoney()
            :base(Tags.AllocNetMoney) {}
        public AllocNetMoney(Decimal val)
            :base(Tags.AllocNetMoney, val) {}
    }


    /// <summary>
    /// AllocNoOrdersType Field
    /// </summary>/
    public sealed class AllocNoOrdersType : IntField
    {
        public AllocNoOrdersType()
            :base(Tags.AllocNoOrdersType) {}
        public AllocNoOrdersType(int val)
            :base(Tags.AllocNoOrdersType, val) {}
    }


    /// <summary>
    /// AllocPrice Field
    /// </summary>/
    public sealed class AllocPrice : DecimalField
    {
        public AllocPrice()
            :base(Tags.AllocPrice) {}
        public AllocPrice(Decimal val)
            :base(Tags.AllocPrice, val) {}
    }


    /// <summary>
    /// AllocQty Field
    /// </summary>/
    public sealed class AllocQty : DecimalField
    {
        public AllocQty()
            :base(Tags.AllocQty) {}
        public AllocQty(Decimal val)
            :base(Tags.AllocQty, val) {}
    }


    /// <summary>
    /// AllocRejCode Field
    /// </summary>/
    public sealed class AllocRejCode : IntField
    {
        public AllocRejCode()
            :base(Tags.AllocRejCode) {}
        public AllocRejCode(int val)
            :base(Tags.AllocRejCode, val) {}
    }


    /// <summary>
    /// AllocReportID Field
    /// </summary>/
    public sealed class AllocReportID : StringField
    {
        public AllocReportID()
            :base(Tags.AllocReportID) {}
        public AllocReportID(string val)
            :base(Tags.AllocReportID, val) {}
    }


    /// <summary>
    /// AllocReportRefID Field
    /// </summary>/
    public sealed class AllocReportRefID : StringField
    {
        public AllocReportRefID()
            :base(Tags.AllocReportRefID) {}
        public AllocReportRefID(string val)
            :base(Tags.AllocReportRefID, val) {}
    }


    /// <summary>
    /// AllocReportType Field
    /// </summary>/
    public sealed class AllocReportType : IntField
    {
        public AllocReportType()
            :base(Tags.AllocReportType) {}
        public AllocReportType(int val)
            :base(Tags.AllocReportType, val) {}
    }


    /// <summary>
    /// AllocSettlCurrAmt Field
    /// </summary>/
    public sealed class AllocSettlCurrAmt : DecimalField
    {
        public AllocSettlCurrAmt()
            :base(Tags.AllocSettlCurrAmt) {}
        public AllocSettlCurrAmt(Decimal val)
            :base(Tags.AllocSettlCurrAmt, val) {}
    }


    /// <summary>
    /// AllocSettlCurrency Field
    /// </summary>/
    public sealed class AllocSettlCurrency : DecimalField
    {
        public AllocSettlCurrency()
            :base(Tags.AllocSettlCurrency) {}
        public AllocSettlCurrency(Decimal val)
            :base(Tags.AllocSettlCurrency, val) {}
    }


    /// <summary>
    /// AllocSettlInstType Field
    /// </summary>/
    public sealed class AllocSettlInstType : IntField
    {
        public AllocSettlInstType()
            :base(Tags.AllocSettlInstType) {}
        public AllocSettlInstType(int val)
            :base(Tags.AllocSettlInstType, val) {}
    }


    /// <summary>
    /// AllocStatus Field
    /// </summary>/
    public sealed class AllocStatus : IntField
    {
        public AllocStatus()
            :base(Tags.AllocStatus) {}
        public AllocStatus(int val)
            :base(Tags.AllocStatus, val) {}
    }


    /// <summary>
    /// AllocText Field
    /// </summary>/
    public sealed class AllocText : StringField
    {
        public AllocText()
            :base(Tags.AllocText) {}
        public AllocText(string val)
            :base(Tags.AllocText, val) {}
    }


    /// <summary>
    /// AllocTransType Field
    /// </summary>/
    public sealed class AllocTransType : CharField
    {
        public AllocTransType()
            :base(Tags.AllocTransType) {}
        public AllocTransType(char val)
            :base(Tags.AllocTransType, val) {}
    }


    /// <summary>
    /// AllocType Field
    /// </summary>/
    public sealed class AllocType : IntField
    {
        public AllocType()
            :base(Tags.AllocType) {}
        public AllocType(int val)
            :base(Tags.AllocType, val) {}
    }


    /// <summary>
    /// AllowableOneSidednessCurr Field
    /// </summary>/
    public sealed class AllowableOneSidednessCurr : DecimalField
    {
        public AllowableOneSidednessCurr()
            :base(Tags.AllowableOneSidednessCurr) {}
        public AllowableOneSidednessCurr(Decimal val)
            :base(Tags.AllowableOneSidednessCurr, val) {}
    }


    /// <summary>
    /// AllowableOneSidednessPct Field
    /// </summary>/
    public sealed class AllowableOneSidednessPct : DecimalField
    {
        public AllowableOneSidednessPct()
            :base(Tags.AllowableOneSidednessPct) {}
        public AllowableOneSidednessPct(Decimal val)
            :base(Tags.AllowableOneSidednessPct, val) {}
    }


    /// <summary>
    /// AllowableOneSidednessValue Field
    /// </summary>/
    public sealed class AllowableOneSidednessValue : DecimalField
    {
        public AllowableOneSidednessValue()
            :base(Tags.AllowableOneSidednessValue) {}
        public AllowableOneSidednessValue(Decimal val)
            :base(Tags.AllowableOneSidednessValue, val) {}
    }


    /// <summary>
    /// AltMDSourceID Field
    /// </summary>/
    public sealed class AltMDSourceID : StringField
    {
        public AltMDSourceID()
            :base(Tags.AltMDSourceID) {}
        public AltMDSourceID(string val)
            :base(Tags.AltMDSourceID, val) {}
    }


    /// <summary>
    /// ApplQueueAction Field
    /// </summary>/
    public sealed class ApplQueueAction : IntField
    {
        public ApplQueueAction()
            :base(Tags.ApplQueueAction) {}
        public ApplQueueAction(int val)
            :base(Tags.ApplQueueAction, val) {}
    }


    /// <summary>
    /// ApplQueueDepth Field
    /// </summary>/
    public sealed class ApplQueueDepth : IntField
    {
        public ApplQueueDepth()
            :base(Tags.ApplQueueDepth) {}
        public ApplQueueDepth(int val)
            :base(Tags.ApplQueueDepth, val) {}
    }


    /// <summary>
    /// ApplQueueMax Field
    /// </summary>/
    public sealed class ApplQueueMax : IntField
    {
        public ApplQueueMax()
            :base(Tags.ApplQueueMax) {}
        public ApplQueueMax(int val)
            :base(Tags.ApplQueueMax, val) {}
    }


    /// <summary>
    /// ApplQueueResolution Field
    /// </summary>/
    public sealed class ApplQueueResolution : IntField
    {
        public ApplQueueResolution()
            :base(Tags.ApplQueueResolution) {}
        public ApplQueueResolution(int val)
            :base(Tags.ApplQueueResolution, val) {}
    }


    /// <summary>
    /// AsgnReqID Field
    /// </summary>/
    public sealed class AsgnReqID : StringField
    {
        public AsgnReqID()
            :base(Tags.AsgnReqID) {}
        public AsgnReqID(string val)
            :base(Tags.AsgnReqID, val) {}
    }


    /// <summary>
    /// AsgnRptID Field
    /// </summary>/
    public sealed class AsgnRptID : StringField
    {
        public AsgnRptID()
            :base(Tags.AsgnRptID) {}
        public AsgnRptID(string val)
            :base(Tags.AsgnRptID, val) {}
    }


    /// <summary>
    /// AssignmentMethod Field
    /// </summary>/
    public sealed class AssignmentMethod : CharField
    {
        public AssignmentMethod()
            :base(Tags.AssignmentMethod) {}
        public AssignmentMethod(char val)
            :base(Tags.AssignmentMethod, val) {}
    }


    /// <summary>
    /// AssignmentUnit Field
    /// </summary>/
    public sealed class AssignmentUnit : DecimalField
    {
        public AssignmentUnit()
            :base(Tags.AssignmentUnit) {}
        public AssignmentUnit(Decimal val)
            :base(Tags.AssignmentUnit, val) {}
    }


    /// <summary>
    /// AutoAcceptIndicator Field
    /// </summary>/
    public sealed class AutoAcceptIndicator : BooleanField
    {
        public AutoAcceptIndicator()
            :base(Tags.AutoAcceptIndicator) {}
        public AutoAcceptIndicator(Boolean val)
            :base(Tags.AutoAcceptIndicator, val) {}
    }


    /// <summary>
    /// AvgParPx Field
    /// </summary>/
    public sealed class AvgParPx : DecimalField
    {
        public AvgParPx()
            :base(Tags.AvgParPx) {}
        public AvgParPx(Decimal val)
            :base(Tags.AvgParPx, val) {}
    }


    /// <summary>
    /// AvgPx Field
    /// </summary>/
    public sealed class AvgPx : DecimalField
    {
        public AvgPx()
            :base(Tags.AvgPx) {}
        public AvgPx(Decimal val)
            :base(Tags.AvgPx, val) {}
    }


    /// <summary>
    /// AvgPxIndicator Field
    /// </summary>/
    public sealed class AvgPxIndicator : IntField
    {
        public AvgPxIndicator()
            :base(Tags.AvgPxIndicator) {}
        public AvgPxIndicator(int val)
            :base(Tags.AvgPxIndicator, val) {}
    }


    /// <summary>
    /// AvgPxPrecision Field
    /// </summary>/
    public sealed class AvgPxPrecision : IntField
    {
        public AvgPxPrecision()
            :base(Tags.AvgPxPrecision) {}
        public AvgPxPrecision(int val)
            :base(Tags.AvgPxPrecision, val) {}
    }


    /// <summary>
    /// BasisFeatureDate Field
    /// </summary>/
    public sealed class BasisFeatureDate : DateTimeField
    {
        public BasisFeatureDate()
            :base(Tags.BasisFeatureDate) {}
        public BasisFeatureDate(DateTime val)
            :base(Tags.BasisFeatureDate, val) {}
    }


    /// <summary>
    /// BasisFeaturePrice Field
    /// </summary>/
    public sealed class BasisFeaturePrice : DecimalField
    {
        public BasisFeaturePrice()
            :base(Tags.BasisFeaturePrice) {}
        public BasisFeaturePrice(Decimal val)
            :base(Tags.BasisFeaturePrice, val) {}
    }


    /// <summary>
    /// BasisPxType Field
    /// </summary>/
    public sealed class BasisPxType : CharField
    {
        public BasisPxType()
            :base(Tags.BasisPxType) {}
        public BasisPxType(char val)
            :base(Tags.BasisPxType, val) {}
    }


    /// <summary>
    /// BeginSeqNo Field
    /// </summary>/
    public sealed class BeginSeqNo : IntField
    {
        public BeginSeqNo()
            :base(Tags.BeginSeqNo) {}
        public BeginSeqNo(int val)
            :base(Tags.BeginSeqNo, val) {}
    }


    /// <summary>
    /// BeginString Field
    /// </summary>/
    public sealed class BeginString : StringField
    {
        public BeginString()
            :base(Tags.BeginString) {}
        public BeginString(string val)
            :base(Tags.BeginString, val) {}
    }


    /// <summary>
    /// BenchmarkCurveCurrency Field
    /// </summary>/
    public sealed class BenchmarkCurveCurrency : DecimalField
    {
        public BenchmarkCurveCurrency()
            :base(Tags.BenchmarkCurveCurrency) {}
        public BenchmarkCurveCurrency(Decimal val)
            :base(Tags.BenchmarkCurveCurrency, val) {}
    }


    /// <summary>
    /// BenchmarkCurveName Field
    /// </summary>/
    public sealed class BenchmarkCurveName : StringField
    {
        public BenchmarkCurveName()
            :base(Tags.BenchmarkCurveName) {}
        public BenchmarkCurveName(string val)
            :base(Tags.BenchmarkCurveName, val) {}
    }


    /// <summary>
    /// BenchmarkCurvePoint Field
    /// </summary>/
    public sealed class BenchmarkCurvePoint : StringField
    {
        public BenchmarkCurvePoint()
            :base(Tags.BenchmarkCurvePoint) {}
        public BenchmarkCurvePoint(string val)
            :base(Tags.BenchmarkCurvePoint, val) {}
    }


    /// <summary>
    /// BenchmarkPrice Field
    /// </summary>/
    public sealed class BenchmarkPrice : DecimalField
    {
        public BenchmarkPrice()
            :base(Tags.BenchmarkPrice) {}
        public BenchmarkPrice(Decimal val)
            :base(Tags.BenchmarkPrice, val) {}
    }


    /// <summary>
    /// BenchmarkPriceType Field
    /// </summary>/
    public sealed class BenchmarkPriceType : IntField
    {
        public BenchmarkPriceType()
            :base(Tags.BenchmarkPriceType) {}
        public BenchmarkPriceType(int val)
            :base(Tags.BenchmarkPriceType, val) {}
    }


    /// <summary>
    /// BenchmarkSecurityID Field
    /// </summary>/
    public sealed class BenchmarkSecurityID : StringField
    {
        public BenchmarkSecurityID()
            :base(Tags.BenchmarkSecurityID) {}
        public BenchmarkSecurityID(string val)
            :base(Tags.BenchmarkSecurityID, val) {}
    }


    /// <summary>
    /// BenchmarkSecurityIDSource Field
    /// </summary>/
    public sealed class BenchmarkSecurityIDSource : StringField
    {
        public BenchmarkSecurityIDSource()
            :base(Tags.BenchmarkSecurityIDSource) {}
        public BenchmarkSecurityIDSource(string val)
            :base(Tags.BenchmarkSecurityIDSource, val) {}
    }


    /// <summary>
    /// BidDescriptor Field
    /// </summary>/
    public sealed class BidDescriptor : StringField
    {
        public BidDescriptor()
            :base(Tags.BidDescriptor) {}
        public BidDescriptor(string val)
            :base(Tags.BidDescriptor, val) {}
    }


    /// <summary>
    /// BidDescriptorType Field
    /// </summary>/
    public sealed class BidDescriptorType : IntField
    {
        public BidDescriptorType()
            :base(Tags.BidDescriptorType) {}
        public BidDescriptorType(int val)
            :base(Tags.BidDescriptorType, val) {}
    }


    /// <summary>
    /// BidForwardPoints Field
    /// </summary>/
    public sealed class BidForwardPoints : DecimalField
    {
        public BidForwardPoints()
            :base(Tags.BidForwardPoints) {}
        public BidForwardPoints(Decimal val)
            :base(Tags.BidForwardPoints, val) {}
    }


    /// <summary>
    /// BidForwardPoints2 Field
    /// </summary>/
    public sealed class BidForwardPoints2 : DecimalField
    {
        public BidForwardPoints2()
            :base(Tags.BidForwardPoints2) {}
        public BidForwardPoints2(Decimal val)
            :base(Tags.BidForwardPoints2, val) {}
    }


    /// <summary>
    /// BidID Field
    /// </summary>/
    public sealed class BidID : StringField
    {
        public BidID()
            :base(Tags.BidID) {}
        public BidID(string val)
            :base(Tags.BidID, val) {}
    }


    /// <summary>
    /// BidPx Field
    /// </summary>/
    public sealed class BidPx : DecimalField
    {
        public BidPx()
            :base(Tags.BidPx) {}
        public BidPx(Decimal val)
            :base(Tags.BidPx, val) {}
    }


    /// <summary>
    /// BidRequestTransType Field
    /// </summary>/
    public sealed class BidRequestTransType : CharField
    {
        public BidRequestTransType()
            :base(Tags.BidRequestTransType) {}
        public BidRequestTransType(char val)
            :base(Tags.BidRequestTransType, val) {}
    }


    /// <summary>
    /// BidSize Field
    /// </summary>/
    public sealed class BidSize : DecimalField
    {
        public BidSize()
            :base(Tags.BidSize) {}
        public BidSize(Decimal val)
            :base(Tags.BidSize, val) {}
    }


    /// <summary>
    /// BidSpotRate Field
    /// </summary>/
    public sealed class BidSpotRate : DecimalField
    {
        public BidSpotRate()
            :base(Tags.BidSpotRate) {}
        public BidSpotRate(Decimal val)
            :base(Tags.BidSpotRate, val) {}
    }


    /// <summary>
    /// BidTradeType Field
    /// </summary>/
    public sealed class BidTradeType : CharField
    {
        public BidTradeType()
            :base(Tags.BidTradeType) {}
        public BidTradeType(char val)
            :base(Tags.BidTradeType, val) {}
    }


    /// <summary>
    /// BidType Field
    /// </summary>/
    public sealed class BidType : IntField
    {
        public BidType()
            :base(Tags.BidType) {}
        public BidType(int val)
            :base(Tags.BidType, val) {}
    }


    /// <summary>
    /// BidYield Field
    /// </summary>/
    public sealed class BidYield : DecimalField
    {
        public BidYield()
            :base(Tags.BidYield) {}
        public BidYield(Decimal val)
            :base(Tags.BidYield, val) {}
    }


    /// <summary>
    /// BodyLength Field
    /// </summary>/
    public sealed class BodyLength : DecimalField
    {
        public BodyLength()
            :base(Tags.BodyLength) {}
        public BodyLength(Decimal val)
            :base(Tags.BodyLength, val) {}
    }


    /// <summary>
    /// BookingRefID Field
    /// </summary>/
    public sealed class BookingRefID : StringField
    {
        public BookingRefID()
            :base(Tags.BookingRefID) {}
        public BookingRefID(string val)
            :base(Tags.BookingRefID, val) {}
    }


    /// <summary>
    /// BookingType Field
    /// </summary>/
    public sealed class BookingType : IntField
    {
        public BookingType()
            :base(Tags.BookingType) {}
        public BookingType(int val)
            :base(Tags.BookingType, val) {}
    }


    /// <summary>
    /// BookingUnit Field
    /// </summary>/
    public sealed class BookingUnit : CharField
    {
        public BookingUnit()
            :base(Tags.BookingUnit) {}
        public BookingUnit(char val)
            :base(Tags.BookingUnit, val) {}
    }


    /// <summary>
    /// BusinessRejectReason Field
    /// </summary>/
    public sealed class BusinessRejectReason : IntField
    {
        public BusinessRejectReason()
            :base(Tags.BusinessRejectReason) {}
        public BusinessRejectReason(int val)
            :base(Tags.BusinessRejectReason, val) {}
    }


    /// <summary>
    /// BusinessRejectRefID Field
    /// </summary>/
    public sealed class BusinessRejectRefID : StringField
    {
        public BusinessRejectRefID()
            :base(Tags.BusinessRejectRefID) {}
        public BusinessRejectRefID(string val)
            :base(Tags.BusinessRejectRefID, val) {}
    }


    /// <summary>
    /// BuyVolume Field
    /// </summary>/
    public sealed class BuyVolume : DecimalField
    {
        public BuyVolume()
            :base(Tags.BuyVolume) {}
        public BuyVolume(Decimal val)
            :base(Tags.BuyVolume, val) {}
    }


    /// <summary>
    /// CFICode Field
    /// </summary>/
    public sealed class CFICode : StringField
    {
        public CFICode()
            :base(Tags.CFICode) {}
        public CFICode(string val)
            :base(Tags.CFICode, val) {}
    }


    /// <summary>
    /// CPProgram Field
    /// </summary>/
    public sealed class CPProgram : IntField
    {
        public CPProgram()
            :base(Tags.CPProgram) {}
        public CPProgram(int val)
            :base(Tags.CPProgram, val) {}
    }


    /// <summary>
    /// CPRegType Field
    /// </summary>/
    public sealed class CPRegType : StringField
    {
        public CPRegType()
            :base(Tags.CPRegType) {}
        public CPRegType(string val)
            :base(Tags.CPRegType, val) {}
    }


    /// <summary>
    /// CancellationRights Field
    /// </summary>/
    public sealed class CancellationRights : CharField
    {
        public CancellationRights()
            :base(Tags.CancellationRights) {}
        public CancellationRights(char val)
            :base(Tags.CancellationRights, val) {}
    }


    /// <summary>
    /// CardExpDate Field
    /// </summary>/
    public sealed class CardExpDate : DateTimeField
    {
        public CardExpDate()
            :base(Tags.CardExpDate) {}
        public CardExpDate(DateTime val)
            :base(Tags.CardExpDate, val) {}
    }


    /// <summary>
    /// CardHolderName Field
    /// </summary>/
    public sealed class CardHolderName : StringField
    {
        public CardHolderName()
            :base(Tags.CardHolderName) {}
        public CardHolderName(string val)
            :base(Tags.CardHolderName, val) {}
    }


    /// <summary>
    /// CardIssNum Field
    /// </summary>/
    public sealed class CardIssNum : StringField
    {
        public CardIssNum()
            :base(Tags.CardIssNum) {}
        public CardIssNum(string val)
            :base(Tags.CardIssNum, val) {}
    }


    /// <summary>
    /// CardNumber Field
    /// </summary>/
    public sealed class CardNumber : StringField
    {
        public CardNumber()
            :base(Tags.CardNumber) {}
        public CardNumber(string val)
            :base(Tags.CardNumber, val) {}
    }


    /// <summary>
    /// CardStartDate Field
    /// </summary>/
    public sealed class CardStartDate : DateTimeField
    {
        public CardStartDate()
            :base(Tags.CardStartDate) {}
        public CardStartDate(DateTime val)
            :base(Tags.CardStartDate, val) {}
    }


    /// <summary>
    /// CashDistribAgentAcctName Field
    /// </summary>/
    public sealed class CashDistribAgentAcctName : StringField
    {
        public CashDistribAgentAcctName()
            :base(Tags.CashDistribAgentAcctName) {}
        public CashDistribAgentAcctName(string val)
            :base(Tags.CashDistribAgentAcctName, val) {}
    }


    /// <summary>
    /// CashDistribAgentAcctNumber Field
    /// </summary>/
    public sealed class CashDistribAgentAcctNumber : StringField
    {
        public CashDistribAgentAcctNumber()
            :base(Tags.CashDistribAgentAcctNumber) {}
        public CashDistribAgentAcctNumber(string val)
            :base(Tags.CashDistribAgentAcctNumber, val) {}
    }


    /// <summary>
    /// CashDistribAgentCode Field
    /// </summary>/
    public sealed class CashDistribAgentCode : StringField
    {
        public CashDistribAgentCode()
            :base(Tags.CashDistribAgentCode) {}
        public CashDistribAgentCode(string val)
            :base(Tags.CashDistribAgentCode, val) {}
    }


    /// <summary>
    /// CashDistribAgentName Field
    /// </summary>/
    public sealed class CashDistribAgentName : StringField
    {
        public CashDistribAgentName()
            :base(Tags.CashDistribAgentName) {}
        public CashDistribAgentName(string val)
            :base(Tags.CashDistribAgentName, val) {}
    }


    /// <summary>
    /// CashDistribCurr Field
    /// </summary>/
    public sealed class CashDistribCurr : DecimalField
    {
        public CashDistribCurr()
            :base(Tags.CashDistribCurr) {}
        public CashDistribCurr(Decimal val)
            :base(Tags.CashDistribCurr, val) {}
    }


    /// <summary>
    /// CashDistribPayRef Field
    /// </summary>/
    public sealed class CashDistribPayRef : StringField
    {
        public CashDistribPayRef()
            :base(Tags.CashDistribPayRef) {}
        public CashDistribPayRef(string val)
            :base(Tags.CashDistribPayRef, val) {}
    }


    /// <summary>
    /// CashMargin Field
    /// </summary>/
    public sealed class CashMargin : CharField
    {
        public CashMargin()
            :base(Tags.CashMargin) {}
        public CashMargin(char val)
            :base(Tags.CashMargin, val) {}
    }


    /// <summary>
    /// CashOrderQty Field
    /// </summary>/
    public sealed class CashOrderQty : DecimalField
    {
        public CashOrderQty()
            :base(Tags.CashOrderQty) {}
        public CashOrderQty(Decimal val)
            :base(Tags.CashOrderQty, val) {}
    }


    /// <summary>
    /// CashOutstanding Field
    /// </summary>/
    public sealed class CashOutstanding : DecimalField
    {
        public CashOutstanding()
            :base(Tags.CashOutstanding) {}
        public CashOutstanding(Decimal val)
            :base(Tags.CashOutstanding, val) {}
    }


    /// <summary>
    /// CheckSum Field
    /// </summary>/
    public sealed class CheckSum : StringField
    {
        public CheckSum()
            :base(Tags.CheckSum) {}
        public CheckSum(string val)
            :base(Tags.CheckSum, val) {}
    }


    /// <summary>
    /// ClOrdID Field
    /// </summary>/
    public sealed class ClOrdID : StringField
    {
        public ClOrdID()
            :base(Tags.ClOrdID) {}
        public ClOrdID(string val)
            :base(Tags.ClOrdID, val) {}
    }


    /// <summary>
    /// ClOrdLinkID Field
    /// </summary>/
    public sealed class ClOrdLinkID : StringField
    {
        public ClOrdLinkID()
            :base(Tags.ClOrdLinkID) {}
        public ClOrdLinkID(string val)
            :base(Tags.ClOrdLinkID, val) {}
    }


    /// <summary>
    /// ClearingBusinessDate Field
    /// </summary>/
    public sealed class ClearingBusinessDate : DateTimeField
    {
        public ClearingBusinessDate()
            :base(Tags.ClearingBusinessDate) {}
        public ClearingBusinessDate(DateTime val)
            :base(Tags.ClearingBusinessDate, val) {}
    }


    /// <summary>
    /// ClearingFeeIndicator Field
    /// </summary>/
    public sealed class ClearingFeeIndicator : StringField
    {
        public ClearingFeeIndicator()
            :base(Tags.ClearingFeeIndicator) {}
        public ClearingFeeIndicator(string val)
            :base(Tags.ClearingFeeIndicator, val) {}
    }


    /// <summary>
    /// ClearingInstruction Field
    /// </summary>/
    public sealed class ClearingInstruction : IntField
    {
        public ClearingInstruction()
            :base(Tags.ClearingInstruction) {}
        public ClearingInstruction(int val)
            :base(Tags.ClearingInstruction, val) {}
    }


    /// <summary>
    /// ClientBidID Field
    /// </summary>/
    public sealed class ClientBidID : StringField
    {
        public ClientBidID()
            :base(Tags.ClientBidID) {}
        public ClientBidID(string val)
            :base(Tags.ClientBidID, val) {}
    }


    /// <summary>
    /// CollAction Field
    /// </summary>/
    public sealed class CollAction : IntField
    {
        public CollAction()
            :base(Tags.CollAction) {}
        public CollAction(int val)
            :base(Tags.CollAction, val) {}
    }


    /// <summary>
    /// CollAsgnID Field
    /// </summary>/
    public sealed class CollAsgnID : StringField
    {
        public CollAsgnID()
            :base(Tags.CollAsgnID) {}
        public CollAsgnID(string val)
            :base(Tags.CollAsgnID, val) {}
    }


    /// <summary>
    /// CollAsgnReason Field
    /// </summary>/
    public sealed class CollAsgnReason : IntField
    {
        public CollAsgnReason()
            :base(Tags.CollAsgnReason) {}
        public CollAsgnReason(int val)
            :base(Tags.CollAsgnReason, val) {}
    }


    /// <summary>
    /// CollAsgnRefID Field
    /// </summary>/
    public sealed class CollAsgnRefID : StringField
    {
        public CollAsgnRefID()
            :base(Tags.CollAsgnRefID) {}
        public CollAsgnRefID(string val)
            :base(Tags.CollAsgnRefID, val) {}
    }


    /// <summary>
    /// CollAsgnRejectReason Field
    /// </summary>/
    public sealed class CollAsgnRejectReason : IntField
    {
        public CollAsgnRejectReason()
            :base(Tags.CollAsgnRejectReason) {}
        public CollAsgnRejectReason(int val)
            :base(Tags.CollAsgnRejectReason, val) {}
    }


    /// <summary>
    /// CollAsgnRespType Field
    /// </summary>/
    public sealed class CollAsgnRespType : IntField
    {
        public CollAsgnRespType()
            :base(Tags.CollAsgnRespType) {}
        public CollAsgnRespType(int val)
            :base(Tags.CollAsgnRespType, val) {}
    }


    /// <summary>
    /// CollAsgnTransType Field
    /// </summary>/
    public sealed class CollAsgnTransType : IntField
    {
        public CollAsgnTransType()
            :base(Tags.CollAsgnTransType) {}
        public CollAsgnTransType(int val)
            :base(Tags.CollAsgnTransType, val) {}
    }


    /// <summary>
    /// CollInquiryID Field
    /// </summary>/
    public sealed class CollInquiryID : StringField
    {
        public CollInquiryID()
            :base(Tags.CollInquiryID) {}
        public CollInquiryID(string val)
            :base(Tags.CollInquiryID, val) {}
    }


    /// <summary>
    /// CollInquiryQualifier Field
    /// </summary>/
    public sealed class CollInquiryQualifier : IntField
    {
        public CollInquiryQualifier()
            :base(Tags.CollInquiryQualifier) {}
        public CollInquiryQualifier(int val)
            :base(Tags.CollInquiryQualifier, val) {}
    }


    /// <summary>
    /// CollInquiryResult Field
    /// </summary>/
    public sealed class CollInquiryResult : IntField
    {
        public CollInquiryResult()
            :base(Tags.CollInquiryResult) {}
        public CollInquiryResult(int val)
            :base(Tags.CollInquiryResult, val) {}
    }


    /// <summary>
    /// CollInquiryStatus Field
    /// </summary>/
    public sealed class CollInquiryStatus : IntField
    {
        public CollInquiryStatus()
            :base(Tags.CollInquiryStatus) {}
        public CollInquiryStatus(int val)
            :base(Tags.CollInquiryStatus, val) {}
    }


    /// <summary>
    /// CollReqID Field
    /// </summary>/
    public sealed class CollReqID : StringField
    {
        public CollReqID()
            :base(Tags.CollReqID) {}
        public CollReqID(string val)
            :base(Tags.CollReqID, val) {}
    }


    /// <summary>
    /// CollRespID Field
    /// </summary>/
    public sealed class CollRespID : StringField
    {
        public CollRespID()
            :base(Tags.CollRespID) {}
        public CollRespID(string val)
            :base(Tags.CollRespID, val) {}
    }


    /// <summary>
    /// CollRptID Field
    /// </summary>/
    public sealed class CollRptID : StringField
    {
        public CollRptID()
            :base(Tags.CollRptID) {}
        public CollRptID(string val)
            :base(Tags.CollRptID, val) {}
    }


    /// <summary>
    /// CollStatus Field
    /// </summary>/
    public sealed class CollStatus : IntField
    {
        public CollStatus()
            :base(Tags.CollStatus) {}
        public CollStatus(int val)
            :base(Tags.CollStatus, val) {}
    }


    /// <summary>
    /// CommCurrency Field
    /// </summary>/
    public sealed class CommCurrency : DecimalField
    {
        public CommCurrency()
            :base(Tags.CommCurrency) {}
        public CommCurrency(Decimal val)
            :base(Tags.CommCurrency, val) {}
    }


    /// <summary>
    /// CommType Field
    /// </summary>/
    public sealed class CommType : CharField
    {
        public CommType()
            :base(Tags.CommType) {}
        public CommType(char val)
            :base(Tags.CommType, val) {}
    }


    /// <summary>
    /// Commission Field
    /// </summary>/
    public sealed class Commission : DecimalField
    {
        public Commission()
            :base(Tags.Commission) {}
        public Commission(Decimal val)
            :base(Tags.Commission, val) {}
    }


    /// <summary>
    /// ComplianceID Field
    /// </summary>/
    public sealed class ComplianceID : StringField
    {
        public ComplianceID()
            :base(Tags.ComplianceID) {}
        public ComplianceID(string val)
            :base(Tags.ComplianceID, val) {}
    }


    /// <summary>
    /// Concession Field
    /// </summary>/
    public sealed class Concession : DecimalField
    {
        public Concession()
            :base(Tags.Concession) {}
        public Concession(Decimal val)
            :base(Tags.Concession, val) {}
    }


    /// <summary>
    /// ConfirmID Field
    /// </summary>/
    public sealed class ConfirmID : StringField
    {
        public ConfirmID()
            :base(Tags.ConfirmID) {}
        public ConfirmID(string val)
            :base(Tags.ConfirmID, val) {}
    }


    /// <summary>
    /// ConfirmRefID Field
    /// </summary>/
    public sealed class ConfirmRefID : StringField
    {
        public ConfirmRefID()
            :base(Tags.ConfirmRefID) {}
        public ConfirmRefID(string val)
            :base(Tags.ConfirmRefID, val) {}
    }


    /// <summary>
    /// ConfirmRejReason Field
    /// </summary>/
    public sealed class ConfirmRejReason : IntField
    {
        public ConfirmRejReason()
            :base(Tags.ConfirmRejReason) {}
        public ConfirmRejReason(int val)
            :base(Tags.ConfirmRejReason, val) {}
    }


    /// <summary>
    /// ConfirmReqID Field
    /// </summary>/
    public sealed class ConfirmReqID : StringField
    {
        public ConfirmReqID()
            :base(Tags.ConfirmReqID) {}
        public ConfirmReqID(string val)
            :base(Tags.ConfirmReqID, val) {}
    }


    /// <summary>
    /// ConfirmStatus Field
    /// </summary>/
    public sealed class ConfirmStatus : IntField
    {
        public ConfirmStatus()
            :base(Tags.ConfirmStatus) {}
        public ConfirmStatus(int val)
            :base(Tags.ConfirmStatus, val) {}
    }


    /// <summary>
    /// ConfirmTransType Field
    /// </summary>/
    public sealed class ConfirmTransType : IntField
    {
        public ConfirmTransType()
            :base(Tags.ConfirmTransType) {}
        public ConfirmTransType(int val)
            :base(Tags.ConfirmTransType, val) {}
    }


    /// <summary>
    /// ConfirmType Field
    /// </summary>/
    public sealed class ConfirmType : IntField
    {
        public ConfirmType()
            :base(Tags.ConfirmType) {}
        public ConfirmType(int val)
            :base(Tags.ConfirmType, val) {}
    }


    /// <summary>
    /// ContAmtCurr Field
    /// </summary>/
    public sealed class ContAmtCurr : DecimalField
    {
        public ContAmtCurr()
            :base(Tags.ContAmtCurr) {}
        public ContAmtCurr(Decimal val)
            :base(Tags.ContAmtCurr, val) {}
    }


    /// <summary>
    /// ContAmtType Field
    /// </summary>/
    public sealed class ContAmtType : IntField
    {
        public ContAmtType()
            :base(Tags.ContAmtType) {}
        public ContAmtType(int val)
            :base(Tags.ContAmtType, val) {}
    }


    /// <summary>
    /// ContAmtValue Field
    /// </summary>/
    public sealed class ContAmtValue : DecimalField
    {
        public ContAmtValue()
            :base(Tags.ContAmtValue) {}
        public ContAmtValue(Decimal val)
            :base(Tags.ContAmtValue, val) {}
    }


    /// <summary>
    /// ContraBroker Field
    /// </summary>/
    public sealed class ContraBroker : StringField
    {
        public ContraBroker()
            :base(Tags.ContraBroker) {}
        public ContraBroker(string val)
            :base(Tags.ContraBroker, val) {}
    }


    /// <summary>
    /// ContraLegRefID Field
    /// </summary>/
    public sealed class ContraLegRefID : StringField
    {
        public ContraLegRefID()
            :base(Tags.ContraLegRefID) {}
        public ContraLegRefID(string val)
            :base(Tags.ContraLegRefID, val) {}
    }


    /// <summary>
    /// ContraTradeQty Field
    /// </summary>/
    public sealed class ContraTradeQty : DecimalField
    {
        public ContraTradeQty()
            :base(Tags.ContraTradeQty) {}
        public ContraTradeQty(Decimal val)
            :base(Tags.ContraTradeQty, val) {}
    }


    /// <summary>
    /// ContraTradeTime Field
    /// </summary>/
    public sealed class ContraTradeTime : DateTimeField
    {
        public ContraTradeTime()
            :base(Tags.ContraTradeTime) {}
        public ContraTradeTime(DateTime val)
            :base(Tags.ContraTradeTime, val) {}
    }


    /// <summary>
    /// ContraTrader Field
    /// </summary>/
    public sealed class ContraTrader : StringField
    {
        public ContraTrader()
            :base(Tags.ContraTrader) {}
        public ContraTrader(string val)
            :base(Tags.ContraTrader, val) {}
    }


    /// <summary>
    /// ContractMultiplier Field
    /// </summary>/
    public sealed class ContractMultiplier : DecimalField
    {
        public ContractMultiplier()
            :base(Tags.ContractMultiplier) {}
        public ContractMultiplier(Decimal val)
            :base(Tags.ContractMultiplier, val) {}
    }


    /// <summary>
    /// ContractSettlMonth Field
    /// </summary>/
    public sealed class ContractSettlMonth : DateTimeField
    {
        public ContractSettlMonth()
            :base(Tags.ContractSettlMonth) {}
        public ContractSettlMonth(DateTime val)
            :base(Tags.ContractSettlMonth, val) {}
    }


    /// <summary>
    /// ContraryInstructionIndicator Field
    /// </summary>/
    public sealed class ContraryInstructionIndicator : BooleanField
    {
        public ContraryInstructionIndicator()
            :base(Tags.ContraryInstructionIndicator) {}
        public ContraryInstructionIndicator(Boolean val)
            :base(Tags.ContraryInstructionIndicator, val) {}
    }


    /// <summary>
    /// CopyMsgIndicator Field
    /// </summary>/
    public sealed class CopyMsgIndicator : BooleanField
    {
        public CopyMsgIndicator()
            :base(Tags.CopyMsgIndicator) {}
        public CopyMsgIndicator(Boolean val)
            :base(Tags.CopyMsgIndicator, val) {}
    }


    /// <summary>
    /// CorporateAction Field
    /// </summary>/
    public sealed class CorporateAction : StringField
    {
        public CorporateAction()
            :base(Tags.CorporateAction) {}
        public CorporateAction(string val)
            :base(Tags.CorporateAction, val) {}
    }


    /// <summary>
    /// Country Field
    /// </summary>/
    public sealed class Country : StringField
    {
        public Country()
            :base(Tags.Country) {}
        public Country(string val)
            :base(Tags.Country, val) {}
    }


    /// <summary>
    /// CountryOfIssue Field
    /// </summary>/
    public sealed class CountryOfIssue : StringField
    {
        public CountryOfIssue()
            :base(Tags.CountryOfIssue) {}
        public CountryOfIssue(string val)
            :base(Tags.CountryOfIssue, val) {}
    }


    /// <summary>
    /// CouponPaymentDate Field
    /// </summary>/
    public sealed class CouponPaymentDate : DateTimeField
    {
        public CouponPaymentDate()
            :base(Tags.CouponPaymentDate) {}
        public CouponPaymentDate(DateTime val)
            :base(Tags.CouponPaymentDate, val) {}
    }


    /// <summary>
    /// CouponRate Field
    /// </summary>/
    public sealed class CouponRate : DecimalField
    {
        public CouponRate()
            :base(Tags.CouponRate) {}
        public CouponRate(Decimal val)
            :base(Tags.CouponRate, val) {}
    }


    /// <summary>
    /// CoveredOrUncovered Field
    /// </summary>/
    public sealed class CoveredOrUncovered : IntField
    {
        public CoveredOrUncovered()
            :base(Tags.CoveredOrUncovered) {}
        public CoveredOrUncovered(int val)
            :base(Tags.CoveredOrUncovered, val) {}
    }


    /// <summary>
    /// CreditRating Field
    /// </summary>/
    public sealed class CreditRating : StringField
    {
        public CreditRating()
            :base(Tags.CreditRating) {}
        public CreditRating(string val)
            :base(Tags.CreditRating, val) {}
    }


    /// <summary>
    /// CrossID Field
    /// </summary>/
    public sealed class CrossID : StringField
    {
        public CrossID()
            :base(Tags.CrossID) {}
        public CrossID(string val)
            :base(Tags.CrossID, val) {}
    }


    /// <summary>
    /// CrossPercent Field
    /// </summary>/
    public sealed class CrossPercent : DecimalField
    {
        public CrossPercent()
            :base(Tags.CrossPercent) {}
        public CrossPercent(Decimal val)
            :base(Tags.CrossPercent, val) {}
    }


    /// <summary>
    /// CrossPrioritization Field
    /// </summary>/
    public sealed class CrossPrioritization : IntField
    {
        public CrossPrioritization()
            :base(Tags.CrossPrioritization) {}
        public CrossPrioritization(int val)
            :base(Tags.CrossPrioritization, val) {}
    }


    /// <summary>
    /// CrossType Field
    /// </summary>/
    public sealed class CrossType : IntField
    {
        public CrossType()
            :base(Tags.CrossType) {}
        public CrossType(int val)
            :base(Tags.CrossType, val) {}
    }


    /// <summary>
    /// CumQty Field
    /// </summary>/
    public sealed class CumQty : DecimalField
    {
        public CumQty()
            :base(Tags.CumQty) {}
        public CumQty(Decimal val)
            :base(Tags.CumQty, val) {}
    }


    /// <summary>
    /// Currency Field
    /// </summary>/
    public sealed class Currency : DecimalField
    {
        public Currency()
            :base(Tags.Currency) {}
        public Currency(Decimal val)
            :base(Tags.Currency, val) {}
    }


    /// <summary>
    /// CustOrderCapacity Field
    /// </summary>/
    public sealed class CustOrderCapacity : IntField
    {
        public CustOrderCapacity()
            :base(Tags.CustOrderCapacity) {}
        public CustOrderCapacity(int val)
            :base(Tags.CustOrderCapacity, val) {}
    }


    /// <summary>
    /// CxlQty Field
    /// </summary>/
    public sealed class CxlQty : DecimalField
    {
        public CxlQty()
            :base(Tags.CxlQty) {}
        public CxlQty(Decimal val)
            :base(Tags.CxlQty, val) {}
    }


    /// <summary>
    /// CxlRejReason Field
    /// </summary>/
    public sealed class CxlRejReason : IntField
    {
        public CxlRejReason()
            :base(Tags.CxlRejReason) {}
        public CxlRejReason(int val)
            :base(Tags.CxlRejReason, val) {}
    }


    /// <summary>
    /// CxlRejResponseTo Field
    /// </summary>/
    public sealed class CxlRejResponseTo : CharField
    {
        public CxlRejResponseTo()
            :base(Tags.CxlRejResponseTo) {}
        public CxlRejResponseTo(char val)
            :base(Tags.CxlRejResponseTo, val) {}
    }


    /// <summary>
    /// DKReason Field
    /// </summary>/
    public sealed class DKReason : CharField
    {
        public DKReason()
            :base(Tags.DKReason) {}
        public DKReason(char val)
            :base(Tags.DKReason, val) {}
    }


    /// <summary>
    /// DateOfBirth Field
    /// </summary>/
    public sealed class DateOfBirth : DateTimeField
    {
        public DateOfBirth()
            :base(Tags.DateOfBirth) {}
        public DateOfBirth(DateTime val)
            :base(Tags.DateOfBirth, val) {}
    }


    /// <summary>
    /// DatedDate Field
    /// </summary>/
    public sealed class DatedDate : DateTimeField
    {
        public DatedDate()
            :base(Tags.DatedDate) {}
        public DatedDate(DateTime val)
            :base(Tags.DatedDate, val) {}
    }


    /// <summary>
    /// DayAvgPx Field
    /// </summary>/
    public sealed class DayAvgPx : DecimalField
    {
        public DayAvgPx()
            :base(Tags.DayAvgPx) {}
        public DayAvgPx(Decimal val)
            :base(Tags.DayAvgPx, val) {}
    }


    /// <summary>
    /// DayBookingInst Field
    /// </summary>/
    public sealed class DayBookingInst : CharField
    {
        public DayBookingInst()
            :base(Tags.DayBookingInst) {}
        public DayBookingInst(char val)
            :base(Tags.DayBookingInst, val) {}
    }


    /// <summary>
    /// DayCumQty Field
    /// </summary>/
    public sealed class DayCumQty : DecimalField
    {
        public DayCumQty()
            :base(Tags.DayCumQty) {}
        public DayCumQty(Decimal val)
            :base(Tags.DayCumQty, val) {}
    }


    /// <summary>
    /// DayOrderQty Field
    /// </summary>/
    public sealed class DayOrderQty : DecimalField
    {
        public DayOrderQty()
            :base(Tags.DayOrderQty) {}
        public DayOrderQty(Decimal val)
            :base(Tags.DayOrderQty, val) {}
    }


    /// <summary>
    /// DefBidSize Field
    /// </summary>/
    public sealed class DefBidSize : DecimalField
    {
        public DefBidSize()
            :base(Tags.DefBidSize) {}
        public DefBidSize(Decimal val)
            :base(Tags.DefBidSize, val) {}
    }


    /// <summary>
    /// DefOfferSize Field
    /// </summary>/
    public sealed class DefOfferSize : DecimalField
    {
        public DefOfferSize()
            :base(Tags.DefOfferSize) {}
        public DefOfferSize(Decimal val)
            :base(Tags.DefOfferSize, val) {}
    }


    /// <summary>
    /// DeleteReason Field
    /// </summary>/
    public sealed class DeleteReason : CharField
    {
        public DeleteReason()
            :base(Tags.DeleteReason) {}
        public DeleteReason(char val)
            :base(Tags.DeleteReason, val) {}
    }


    /// <summary>
    /// DeliverToCompID Field
    /// </summary>/
    public sealed class DeliverToCompID : StringField
    {
        public DeliverToCompID()
            :base(Tags.DeliverToCompID) {}
        public DeliverToCompID(string val)
            :base(Tags.DeliverToCompID, val) {}
    }


    /// <summary>
    /// DeliverToLocationID Field
    /// </summary>/
    public sealed class DeliverToLocationID : StringField
    {
        public DeliverToLocationID()
            :base(Tags.DeliverToLocationID) {}
        public DeliverToLocationID(string val)
            :base(Tags.DeliverToLocationID, val) {}
    }


    /// <summary>
    /// DeliverToSubID Field
    /// </summary>/
    public sealed class DeliverToSubID : StringField
    {
        public DeliverToSubID()
            :base(Tags.DeliverToSubID) {}
        public DeliverToSubID(string val)
            :base(Tags.DeliverToSubID, val) {}
    }


    /// <summary>
    /// DeliveryDate Field
    /// </summary>/
    public sealed class DeliveryDate : DateTimeField
    {
        public DeliveryDate()
            :base(Tags.DeliveryDate) {}
        public DeliveryDate(DateTime val)
            :base(Tags.DeliveryDate, val) {}
    }


    /// <summary>
    /// DeliveryForm Field
    /// </summary>/
    public sealed class DeliveryForm : IntField
    {
        public DeliveryForm()
            :base(Tags.DeliveryForm) {}
        public DeliveryForm(int val)
            :base(Tags.DeliveryForm, val) {}
    }


    /// <summary>
    /// DeliveryType Field
    /// </summary>/
    public sealed class DeliveryType : IntField
    {
        public DeliveryType()
            :base(Tags.DeliveryType) {}
        public DeliveryType(int val)
            :base(Tags.DeliveryType, val) {}
    }


    /// <summary>
    /// Designation Field
    /// </summary>/
    public sealed class Designation : StringField
    {
        public Designation()
            :base(Tags.Designation) {}
        public Designation(string val)
            :base(Tags.Designation, val) {}
    }


    /// <summary>
    /// DeskID Field
    /// </summary>/
    public sealed class DeskID : StringField
    {
        public DeskID()
            :base(Tags.DeskID) {}
        public DeskID(string val)
            :base(Tags.DeskID, val) {}
    }


    /// <summary>
    /// DiscretionInst Field
    /// </summary>/
    public sealed class DiscretionInst : CharField
    {
        public DiscretionInst()
            :base(Tags.DiscretionInst) {}
        public DiscretionInst(char val)
            :base(Tags.DiscretionInst, val) {}
    }


    /// <summary>
    /// DiscretionLimitType Field
    /// </summary>/
    public sealed class DiscretionLimitType : IntField
    {
        public DiscretionLimitType()
            :base(Tags.DiscretionLimitType) {}
        public DiscretionLimitType(int val)
            :base(Tags.DiscretionLimitType, val) {}
    }


    /// <summary>
    /// DiscretionMoveType Field
    /// </summary>/
    public sealed class DiscretionMoveType : IntField
    {
        public DiscretionMoveType()
            :base(Tags.DiscretionMoveType) {}
        public DiscretionMoveType(int val)
            :base(Tags.DiscretionMoveType, val) {}
    }


    /// <summary>
    /// DiscretionOffsetType Field
    /// </summary>/
    public sealed class DiscretionOffsetType : IntField
    {
        public DiscretionOffsetType()
            :base(Tags.DiscretionOffsetType) {}
        public DiscretionOffsetType(int val)
            :base(Tags.DiscretionOffsetType, val) {}
    }


    /// <summary>
    /// DiscretionOffsetValue Field
    /// </summary>/
    public sealed class DiscretionOffsetValue : DecimalField
    {
        public DiscretionOffsetValue()
            :base(Tags.DiscretionOffsetValue) {}
        public DiscretionOffsetValue(Decimal val)
            :base(Tags.DiscretionOffsetValue, val) {}
    }


    /// <summary>
    /// DiscretionPrice Field
    /// </summary>/
    public sealed class DiscretionPrice : DecimalField
    {
        public DiscretionPrice()
            :base(Tags.DiscretionPrice) {}
        public DiscretionPrice(Decimal val)
            :base(Tags.DiscretionPrice, val) {}
    }


    /// <summary>
    /// DiscretionRoundDirection Field
    /// </summary>/
    public sealed class DiscretionRoundDirection : IntField
    {
        public DiscretionRoundDirection()
            :base(Tags.DiscretionRoundDirection) {}
        public DiscretionRoundDirection(int val)
            :base(Tags.DiscretionRoundDirection, val) {}
    }


    /// <summary>
    /// DiscretionScope Field
    /// </summary>/
    public sealed class DiscretionScope : IntField
    {
        public DiscretionScope()
            :base(Tags.DiscretionScope) {}
        public DiscretionScope(int val)
            :base(Tags.DiscretionScope, val) {}
    }


    /// <summary>
    /// DistribPaymentMethod Field
    /// </summary>/
    public sealed class DistribPaymentMethod : IntField
    {
        public DistribPaymentMethod()
            :base(Tags.DistribPaymentMethod) {}
        public DistribPaymentMethod(int val)
            :base(Tags.DistribPaymentMethod, val) {}
    }


    /// <summary>
    /// DistribPercentage Field
    /// </summary>/
    public sealed class DistribPercentage : DecimalField
    {
        public DistribPercentage()
            :base(Tags.DistribPercentage) {}
        public DistribPercentage(Decimal val)
            :base(Tags.DistribPercentage, val) {}
    }


    /// <summary>
    /// DlvyInstType Field
    /// </summary>/
    public sealed class DlvyInstType : CharField
    {
        public DlvyInstType()
            :base(Tags.DlvyInstType) {}
        public DlvyInstType(char val)
            :base(Tags.DlvyInstType, val) {}
    }


    /// <summary>
    /// DueToRelated Field
    /// </summary>/
    public sealed class DueToRelated : BooleanField
    {
        public DueToRelated()
            :base(Tags.DueToRelated) {}
        public DueToRelated(Boolean val)
            :base(Tags.DueToRelated, val) {}
    }


    /// <summary>
    /// EFPTrackingError Field
    /// </summary>/
    public sealed class EFPTrackingError : DecimalField
    {
        public EFPTrackingError()
            :base(Tags.EFPTrackingError) {}
        public EFPTrackingError(Decimal val)
            :base(Tags.EFPTrackingError, val) {}
    }


    /// <summary>
    /// EffectiveTime Field
    /// </summary>/
    public sealed class EffectiveTime : DateTimeField
    {
        public EffectiveTime()
            :base(Tags.EffectiveTime) {}
        public EffectiveTime(DateTime val)
            :base(Tags.EffectiveTime, val) {}
    }


    /// <summary>
    /// EmailThreadID Field
    /// </summary>/
    public sealed class EmailThreadID : StringField
    {
        public EmailThreadID()
            :base(Tags.EmailThreadID) {}
        public EmailThreadID(string val)
            :base(Tags.EmailThreadID, val) {}
    }


    /// <summary>
    /// EmailType Field
    /// </summary>/
    public sealed class EmailType : CharField
    {
        public EmailType()
            :base(Tags.EmailType) {}
        public EmailType(char val)
            :base(Tags.EmailType, val) {}
    }


    /// <summary>
    /// EncodedAllocText Field
    /// </summary>/
    public sealed class EncodedAllocText : StringField
    {
        public EncodedAllocText()
            :base(Tags.EncodedAllocText) {}
        public EncodedAllocText(string val)
            :base(Tags.EncodedAllocText, val) {}
    }


    /// <summary>
    /// EncodedAllocTextLen Field
    /// </summary>/
    public sealed class EncodedAllocTextLen : DecimalField
    {
        public EncodedAllocTextLen()
            :base(Tags.EncodedAllocTextLen) {}
        public EncodedAllocTextLen(Decimal val)
            :base(Tags.EncodedAllocTextLen, val) {}
    }


    /// <summary>
    /// EncodedHeadline Field
    /// </summary>/
    public sealed class EncodedHeadline : StringField
    {
        public EncodedHeadline()
            :base(Tags.EncodedHeadline) {}
        public EncodedHeadline(string val)
            :base(Tags.EncodedHeadline, val) {}
    }


    /// <summary>
    /// EncodedHeadlineLen Field
    /// </summary>/
    public sealed class EncodedHeadlineLen : DecimalField
    {
        public EncodedHeadlineLen()
            :base(Tags.EncodedHeadlineLen) {}
        public EncodedHeadlineLen(Decimal val)
            :base(Tags.EncodedHeadlineLen, val) {}
    }


    /// <summary>
    /// EncodedIssuer Field
    /// </summary>/
    public sealed class EncodedIssuer : StringField
    {
        public EncodedIssuer()
            :base(Tags.EncodedIssuer) {}
        public EncodedIssuer(string val)
            :base(Tags.EncodedIssuer, val) {}
    }


    /// <summary>
    /// EncodedIssuerLen Field
    /// </summary>/
    public sealed class EncodedIssuerLen : DecimalField
    {
        public EncodedIssuerLen()
            :base(Tags.EncodedIssuerLen) {}
        public EncodedIssuerLen(Decimal val)
            :base(Tags.EncodedIssuerLen, val) {}
    }


    /// <summary>
    /// EncodedLegIssuer Field
    /// </summary>/
    public sealed class EncodedLegIssuer : StringField
    {
        public EncodedLegIssuer()
            :base(Tags.EncodedLegIssuer) {}
        public EncodedLegIssuer(string val)
            :base(Tags.EncodedLegIssuer, val) {}
    }


    /// <summary>
    /// EncodedLegIssuerLen Field
    /// </summary>/
    public sealed class EncodedLegIssuerLen : DecimalField
    {
        public EncodedLegIssuerLen()
            :base(Tags.EncodedLegIssuerLen) {}
        public EncodedLegIssuerLen(Decimal val)
            :base(Tags.EncodedLegIssuerLen, val) {}
    }


    /// <summary>
    /// EncodedLegSecurityDesc Field
    /// </summary>/
    public sealed class EncodedLegSecurityDesc : StringField
    {
        public EncodedLegSecurityDesc()
            :base(Tags.EncodedLegSecurityDesc) {}
        public EncodedLegSecurityDesc(string val)
            :base(Tags.EncodedLegSecurityDesc, val) {}
    }


    /// <summary>
    /// EncodedLegSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedLegSecurityDescLen : DecimalField
    {
        public EncodedLegSecurityDescLen()
            :base(Tags.EncodedLegSecurityDescLen) {}
        public EncodedLegSecurityDescLen(Decimal val)
            :base(Tags.EncodedLegSecurityDescLen, val) {}
    }


    /// <summary>
    /// EncodedListExecInst Field
    /// </summary>/
    public sealed class EncodedListExecInst : StringField
    {
        public EncodedListExecInst()
            :base(Tags.EncodedListExecInst) {}
        public EncodedListExecInst(string val)
            :base(Tags.EncodedListExecInst, val) {}
    }


    /// <summary>
    /// EncodedListExecInstLen Field
    /// </summary>/
    public sealed class EncodedListExecInstLen : DecimalField
    {
        public EncodedListExecInstLen()
            :base(Tags.EncodedListExecInstLen) {}
        public EncodedListExecInstLen(Decimal val)
            :base(Tags.EncodedListExecInstLen, val) {}
    }


    /// <summary>
    /// EncodedListStatusText Field
    /// </summary>/
    public sealed class EncodedListStatusText : StringField
    {
        public EncodedListStatusText()
            :base(Tags.EncodedListStatusText) {}
        public EncodedListStatusText(string val)
            :base(Tags.EncodedListStatusText, val) {}
    }


    /// <summary>
    /// EncodedListStatusTextLen Field
    /// </summary>/
    public sealed class EncodedListStatusTextLen : DecimalField
    {
        public EncodedListStatusTextLen()
            :base(Tags.EncodedListStatusTextLen) {}
        public EncodedListStatusTextLen(Decimal val)
            :base(Tags.EncodedListStatusTextLen, val) {}
    }


    /// <summary>
    /// EncodedSecurityDesc Field
    /// </summary>/
    public sealed class EncodedSecurityDesc : StringField
    {
        public EncodedSecurityDesc()
            :base(Tags.EncodedSecurityDesc) {}
        public EncodedSecurityDesc(string val)
            :base(Tags.EncodedSecurityDesc, val) {}
    }


    /// <summary>
    /// EncodedSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedSecurityDescLen : DecimalField
    {
        public EncodedSecurityDescLen()
            :base(Tags.EncodedSecurityDescLen) {}
        public EncodedSecurityDescLen(Decimal val)
            :base(Tags.EncodedSecurityDescLen, val) {}
    }


    /// <summary>
    /// EncodedSubject Field
    /// </summary>/
    public sealed class EncodedSubject : StringField
    {
        public EncodedSubject()
            :base(Tags.EncodedSubject) {}
        public EncodedSubject(string val)
            :base(Tags.EncodedSubject, val) {}
    }


    /// <summary>
    /// EncodedSubjectLen Field
    /// </summary>/
    public sealed class EncodedSubjectLen : DecimalField
    {
        public EncodedSubjectLen()
            :base(Tags.EncodedSubjectLen) {}
        public EncodedSubjectLen(Decimal val)
            :base(Tags.EncodedSubjectLen, val) {}
    }


    /// <summary>
    /// EncodedText Field
    /// </summary>/
    public sealed class EncodedText : StringField
    {
        public EncodedText()
            :base(Tags.EncodedText) {}
        public EncodedText(string val)
            :base(Tags.EncodedText, val) {}
    }


    /// <summary>
    /// EncodedTextLen Field
    /// </summary>/
    public sealed class EncodedTextLen : DecimalField
    {
        public EncodedTextLen()
            :base(Tags.EncodedTextLen) {}
        public EncodedTextLen(Decimal val)
            :base(Tags.EncodedTextLen, val) {}
    }


    /// <summary>
    /// EncodedUnderlyingIssuer Field
    /// </summary>/
    public sealed class EncodedUnderlyingIssuer : StringField
    {
        public EncodedUnderlyingIssuer()
            :base(Tags.EncodedUnderlyingIssuer) {}
        public EncodedUnderlyingIssuer(string val)
            :base(Tags.EncodedUnderlyingIssuer, val) {}
    }


    /// <summary>
    /// EncodedUnderlyingIssuerLen Field
    /// </summary>/
    public sealed class EncodedUnderlyingIssuerLen : DecimalField
    {
        public EncodedUnderlyingIssuerLen()
            :base(Tags.EncodedUnderlyingIssuerLen) {}
        public EncodedUnderlyingIssuerLen(Decimal val)
            :base(Tags.EncodedUnderlyingIssuerLen, val) {}
    }


    /// <summary>
    /// EncodedUnderlyingSecurityDesc Field
    /// </summary>/
    public sealed class EncodedUnderlyingSecurityDesc : StringField
    {
        public EncodedUnderlyingSecurityDesc()
            :base(Tags.EncodedUnderlyingSecurityDesc) {}
        public EncodedUnderlyingSecurityDesc(string val)
            :base(Tags.EncodedUnderlyingSecurityDesc, val) {}
    }


    /// <summary>
    /// EncodedUnderlyingSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedUnderlyingSecurityDescLen : DecimalField
    {
        public EncodedUnderlyingSecurityDescLen()
            :base(Tags.EncodedUnderlyingSecurityDescLen) {}
        public EncodedUnderlyingSecurityDescLen(Decimal val)
            :base(Tags.EncodedUnderlyingSecurityDescLen, val) {}
    }


    /// <summary>
    /// EncryptMethod Field
    /// </summary>/
    public sealed class EncryptMethod : IntField
    {
        public EncryptMethod()
            :base(Tags.EncryptMethod) {}
        public EncryptMethod(int val)
            :base(Tags.EncryptMethod, val) {}
    }


    /// <summary>
    /// EndAccruedInterestAmt Field
    /// </summary>/
    public sealed class EndAccruedInterestAmt : DecimalField
    {
        public EndAccruedInterestAmt()
            :base(Tags.EndAccruedInterestAmt) {}
        public EndAccruedInterestAmt(Decimal val)
            :base(Tags.EndAccruedInterestAmt, val) {}
    }


    /// <summary>
    /// EndCash Field
    /// </summary>/
    public sealed class EndCash : DecimalField
    {
        public EndCash()
            :base(Tags.EndCash) {}
        public EndCash(Decimal val)
            :base(Tags.EndCash, val) {}
    }


    /// <summary>
    /// EndDate Field
    /// </summary>/
    public sealed class EndDate : DateTimeField
    {
        public EndDate()
            :base(Tags.EndDate) {}
        public EndDate(DateTime val)
            :base(Tags.EndDate, val) {}
    }


    /// <summary>
    /// EndSeqNo Field
    /// </summary>/
    public sealed class EndSeqNo : IntField
    {
        public EndSeqNo()
            :base(Tags.EndSeqNo) {}
        public EndSeqNo(int val)
            :base(Tags.EndSeqNo, val) {}
    }


    /// <summary>
    /// EventDate Field
    /// </summary>/
    public sealed class EventDate : DateTimeField
    {
        public EventDate()
            :base(Tags.EventDate) {}
        public EventDate(DateTime val)
            :base(Tags.EventDate, val) {}
    }


    /// <summary>
    /// EventPx Field
    /// </summary>/
    public sealed class EventPx : DecimalField
    {
        public EventPx()
            :base(Tags.EventPx) {}
        public EventPx(Decimal val)
            :base(Tags.EventPx, val) {}
    }


    /// <summary>
    /// EventText Field
    /// </summary>/
    public sealed class EventText : StringField
    {
        public EventText()
            :base(Tags.EventText) {}
        public EventText(string val)
            :base(Tags.EventText, val) {}
    }


    /// <summary>
    /// EventType Field
    /// </summary>/
    public sealed class EventType : IntField
    {
        public EventType()
            :base(Tags.EventType) {}
        public EventType(int val)
            :base(Tags.EventType, val) {}
    }


    /// <summary>
    /// ExDate Field
    /// </summary>/
    public sealed class ExDate : DateTimeField
    {
        public ExDate()
            :base(Tags.ExDate) {}
        public ExDate(DateTime val)
            :base(Tags.ExDate, val) {}
    }


    /// <summary>
    /// ExDestination Field
    /// </summary>/
    public sealed class ExDestination : StringField
    {
        public ExDestination()
            :base(Tags.ExDestination) {}
        public ExDestination(string val)
            :base(Tags.ExDestination, val) {}
    }


    /// <summary>
    /// ExchangeForPhysical Field
    /// </summary>/
    public sealed class ExchangeForPhysical : BooleanField
    {
        public ExchangeForPhysical()
            :base(Tags.ExchangeForPhysical) {}
        public ExchangeForPhysical(Boolean val)
            :base(Tags.ExchangeForPhysical, val) {}
    }


    /// <summary>
    /// ExchangeRule Field
    /// </summary>/
    public sealed class ExchangeRule : StringField
    {
        public ExchangeRule()
            :base(Tags.ExchangeRule) {}
        public ExchangeRule(string val)
            :base(Tags.ExchangeRule, val) {}
    }


    /// <summary>
    /// ExecID Field
    /// </summary>/
    public sealed class ExecID : StringField
    {
        public ExecID()
            :base(Tags.ExecID) {}
        public ExecID(string val)
            :base(Tags.ExecID, val) {}
    }


    /// <summary>
    /// ExecInst Field
    /// </summary>/
    public sealed class ExecInst : StringField
    {
        public ExecInst()
            :base(Tags.ExecInst) {}
        public ExecInst(string val)
            :base(Tags.ExecInst, val) {}
    }


    /// <summary>
    /// ExecPriceAdjustment Field
    /// </summary>/
    public sealed class ExecPriceAdjustment : DecimalField
    {
        public ExecPriceAdjustment()
            :base(Tags.ExecPriceAdjustment) {}
        public ExecPriceAdjustment(Decimal val)
            :base(Tags.ExecPriceAdjustment, val) {}
    }


    /// <summary>
    /// ExecPriceType Field
    /// </summary>/
    public sealed class ExecPriceType : CharField
    {
        public ExecPriceType()
            :base(Tags.ExecPriceType) {}
        public ExecPriceType(char val)
            :base(Tags.ExecPriceType, val) {}
    }


    /// <summary>
    /// ExecRefID Field
    /// </summary>/
    public sealed class ExecRefID : StringField
    {
        public ExecRefID()
            :base(Tags.ExecRefID) {}
        public ExecRefID(string val)
            :base(Tags.ExecRefID, val) {}
    }


    /// <summary>
    /// ExecRestatementReason Field
    /// </summary>/
    public sealed class ExecRestatementReason : IntField
    {
        public ExecRestatementReason()
            :base(Tags.ExecRestatementReason) {}
        public ExecRestatementReason(int val)
            :base(Tags.ExecRestatementReason, val) {}
    }


    /// <summary>
    /// ExecType Field
    /// </summary>/
    public sealed class ExecType : CharField
    {
        public ExecType()
            :base(Tags.ExecType) {}
        public ExecType(char val)
            :base(Tags.ExecType, val) {}
    }


    /// <summary>
    /// ExecValuationPoint Field
    /// </summary>/
    public sealed class ExecValuationPoint : DateTimeField
    {
        public ExecValuationPoint()
            :base(Tags.ExecValuationPoint) {}
        public ExecValuationPoint(DateTime val)
            :base(Tags.ExecValuationPoint, val) {}
    }


    /// <summary>
    /// ExerciseMethod Field
    /// </summary>/
    public sealed class ExerciseMethod : CharField
    {
        public ExerciseMethod()
            :base(Tags.ExerciseMethod) {}
        public ExerciseMethod(char val)
            :base(Tags.ExerciseMethod, val) {}
    }


    /// <summary>
    /// ExpirationCycle Field
    /// </summary>/
    public sealed class ExpirationCycle : IntField
    {
        public ExpirationCycle()
            :base(Tags.ExpirationCycle) {}
        public ExpirationCycle(int val)
            :base(Tags.ExpirationCycle, val) {}
    }


    /// <summary>
    /// ExpireDate Field
    /// </summary>/
    public sealed class ExpireDate : DateTimeField
    {
        public ExpireDate()
            :base(Tags.ExpireDate) {}
        public ExpireDate(DateTime val)
            :base(Tags.ExpireDate, val) {}
    }


    /// <summary>
    /// ExpireTime Field
    /// </summary>/
    public sealed class ExpireTime : DateTimeField
    {
        public ExpireTime()
            :base(Tags.ExpireTime) {}
        public ExpireTime(DateTime val)
            :base(Tags.ExpireTime, val) {}
    }


    /// <summary>
    /// Factor Field
    /// </summary>/
    public sealed class Factor : DecimalField
    {
        public Factor()
            :base(Tags.Factor) {}
        public Factor(Decimal val)
            :base(Tags.Factor, val) {}
    }


    /// <summary>
    /// FairValue Field
    /// </summary>/
    public sealed class FairValue : DecimalField
    {
        public FairValue()
            :base(Tags.FairValue) {}
        public FairValue(Decimal val)
            :base(Tags.FairValue, val) {}
    }


    /// <summary>
    /// FinancialStatus Field
    /// </summary>/
    public sealed class FinancialStatus : StringField
    {
        public FinancialStatus()
            :base(Tags.FinancialStatus) {}
        public FinancialStatus(string val)
            :base(Tags.FinancialStatus, val) {}
    }


    /// <summary>
    /// ForexReq Field
    /// </summary>/
    public sealed class ForexReq : BooleanField
    {
        public ForexReq()
            :base(Tags.ForexReq) {}
        public ForexReq(Boolean val)
            :base(Tags.ForexReq, val) {}
    }


    /// <summary>
    /// FundRenewWaiv Field
    /// </summary>/
    public sealed class FundRenewWaiv : CharField
    {
        public FundRenewWaiv()
            :base(Tags.FundRenewWaiv) {}
        public FundRenewWaiv(char val)
            :base(Tags.FundRenewWaiv, val) {}
    }


    /// <summary>
    /// GTBookingInst Field
    /// </summary>/
    public sealed class GTBookingInst : IntField
    {
        public GTBookingInst()
            :base(Tags.GTBookingInst) {}
        public GTBookingInst(int val)
            :base(Tags.GTBookingInst, val) {}
    }


    /// <summary>
    /// GapFillFlag Field
    /// </summary>/
    public sealed class GapFillFlag : BooleanField
    {
        public GapFillFlag()
            :base(Tags.GapFillFlag) {}
        public GapFillFlag(Boolean val)
            :base(Tags.GapFillFlag, val) {}
    }


    /// <summary>
    /// GrossTradeAmt Field
    /// </summary>/
    public sealed class GrossTradeAmt : DecimalField
    {
        public GrossTradeAmt()
            :base(Tags.GrossTradeAmt) {}
        public GrossTradeAmt(Decimal val)
            :base(Tags.GrossTradeAmt, val) {}
    }


    /// <summary>
    /// HaltReason Field
    /// </summary>/
    public sealed class HaltReason : CharField
    {
        public HaltReason()
            :base(Tags.HaltReason) {}
        public HaltReason(char val)
            :base(Tags.HaltReason, val) {}
    }


    /// <summary>
    /// HandlInst Field
    /// </summary>/
    public sealed class HandlInst : CharField
    {
        public HandlInst()
            :base(Tags.HandlInst) {}
        public HandlInst(char val)
            :base(Tags.HandlInst, val) {}
    }


    /// <summary>
    /// Headline Field
    /// </summary>/
    public sealed class Headline : StringField
    {
        public Headline()
            :base(Tags.Headline) {}
        public Headline(string val)
            :base(Tags.Headline, val) {}
    }


    /// <summary>
    /// HeartBtInt Field
    /// </summary>/
    public sealed class HeartBtInt : IntField
    {
        public HeartBtInt()
            :base(Tags.HeartBtInt) {}
        public HeartBtInt(int val)
            :base(Tags.HeartBtInt, val) {}
    }


    /// <summary>
    /// HighPx Field
    /// </summary>/
    public sealed class HighPx : DecimalField
    {
        public HighPx()
            :base(Tags.HighPx) {}
        public HighPx(Decimal val)
            :base(Tags.HighPx, val) {}
    }


    /// <summary>
    /// HopCompID Field
    /// </summary>/
    public sealed class HopCompID : StringField
    {
        public HopCompID()
            :base(Tags.HopCompID) {}
        public HopCompID(string val)
            :base(Tags.HopCompID, val) {}
    }


    /// <summary>
    /// HopRefID Field
    /// </summary>/
    public sealed class HopRefID : IntField
    {
        public HopRefID()
            :base(Tags.HopRefID) {}
        public HopRefID(int val)
            :base(Tags.HopRefID, val) {}
    }


    /// <summary>
    /// HopSendingTime Field
    /// </summary>/
    public sealed class HopSendingTime : DateTimeField
    {
        public HopSendingTime()
            :base(Tags.HopSendingTime) {}
        public HopSendingTime(DateTime val)
            :base(Tags.HopSendingTime, val) {}
    }


    /// <summary>
    /// IOINaturalFlag Field
    /// </summary>/
    public sealed class IOINaturalFlag : BooleanField
    {
        public IOINaturalFlag()
            :base(Tags.IOINaturalFlag) {}
        public IOINaturalFlag(Boolean val)
            :base(Tags.IOINaturalFlag, val) {}
    }


    /// <summary>
    /// IOIQltyInd Field
    /// </summary>/
    public sealed class IOIQltyInd : CharField
    {
        public IOIQltyInd()
            :base(Tags.IOIQltyInd) {}
        public IOIQltyInd(char val)
            :base(Tags.IOIQltyInd, val) {}
    }


    /// <summary>
    /// IOIQty Field
    /// </summary>/
    public sealed class IOIQty : StringField
    {
        public IOIQty()
            :base(Tags.IOIQty) {}
        public IOIQty(string val)
            :base(Tags.IOIQty, val) {}
    }


    /// <summary>
    /// IOIQualifier Field
    /// </summary>/
    public sealed class IOIQualifier : CharField
    {
        public IOIQualifier()
            :base(Tags.IOIQualifier) {}
        public IOIQualifier(char val)
            :base(Tags.IOIQualifier, val) {}
    }


    /// <summary>
    /// IOIRefID Field
    /// </summary>/
    public sealed class IOIRefID : StringField
    {
        public IOIRefID()
            :base(Tags.IOIRefID) {}
        public IOIRefID(string val)
            :base(Tags.IOIRefID, val) {}
    }


    /// <summary>
    /// IOITransType Field
    /// </summary>/
    public sealed class IOITransType : CharField
    {
        public IOITransType()
            :base(Tags.IOITransType) {}
        public IOITransType(char val)
            :base(Tags.IOITransType, val) {}
    }


    /// <summary>
    /// IOIid Field
    /// </summary>/
    public sealed class IOIid : StringField
    {
        public IOIid()
            :base(Tags.IOIid) {}
        public IOIid(string val)
            :base(Tags.IOIid, val) {}
    }


    /// <summary>
    /// InViewOfCommon Field
    /// </summary>/
    public sealed class InViewOfCommon : BooleanField
    {
        public InViewOfCommon()
            :base(Tags.InViewOfCommon) {}
        public InViewOfCommon(Boolean val)
            :base(Tags.InViewOfCommon, val) {}
    }


    /// <summary>
    /// IncTaxInd Field
    /// </summary>/
    public sealed class IncTaxInd : IntField
    {
        public IncTaxInd()
            :base(Tags.IncTaxInd) {}
        public IncTaxInd(int val)
            :base(Tags.IncTaxInd, val) {}
    }


    /// <summary>
    /// IndividualAllocID Field
    /// </summary>/
    public sealed class IndividualAllocID : StringField
    {
        public IndividualAllocID()
            :base(Tags.IndividualAllocID) {}
        public IndividualAllocID(string val)
            :base(Tags.IndividualAllocID, val) {}
    }


    /// <summary>
    /// IndividualAllocRejCode Field
    /// </summary>/
    public sealed class IndividualAllocRejCode : IntField
    {
        public IndividualAllocRejCode()
            :base(Tags.IndividualAllocRejCode) {}
        public IndividualAllocRejCode(int val)
            :base(Tags.IndividualAllocRejCode, val) {}
    }


    /// <summary>
    /// InstrAttribType Field
    /// </summary>/
    public sealed class InstrAttribType : IntField
    {
        public InstrAttribType()
            :base(Tags.InstrAttribType) {}
        public InstrAttribType(int val)
            :base(Tags.InstrAttribType, val) {}
    }


    /// <summary>
    /// InstrAttribValue Field
    /// </summary>/
    public sealed class InstrAttribValue : StringField
    {
        public InstrAttribValue()
            :base(Tags.InstrAttribValue) {}
        public InstrAttribValue(string val)
            :base(Tags.InstrAttribValue, val) {}
    }


    /// <summary>
    /// InstrRegistry Field
    /// </summary>/
    public sealed class InstrRegistry : StringField
    {
        public InstrRegistry()
            :base(Tags.InstrRegistry) {}
        public InstrRegistry(string val)
            :base(Tags.InstrRegistry, val) {}
    }


    /// <summary>
    /// InterestAccrualDate Field
    /// </summary>/
    public sealed class InterestAccrualDate : DateTimeField
    {
        public InterestAccrualDate()
            :base(Tags.InterestAccrualDate) {}
        public InterestAccrualDate(DateTime val)
            :base(Tags.InterestAccrualDate, val) {}
    }


    /// <summary>
    /// InterestAtMaturity Field
    /// </summary>/
    public sealed class InterestAtMaturity : DecimalField
    {
        public InterestAtMaturity()
            :base(Tags.InterestAtMaturity) {}
        public InterestAtMaturity(Decimal val)
            :base(Tags.InterestAtMaturity, val) {}
    }


    /// <summary>
    /// InvestorCountryOfResidence Field
    /// </summary>/
    public sealed class InvestorCountryOfResidence : StringField
    {
        public InvestorCountryOfResidence()
            :base(Tags.InvestorCountryOfResidence) {}
        public InvestorCountryOfResidence(string val)
            :base(Tags.InvestorCountryOfResidence, val) {}
    }


    /// <summary>
    /// IssueDate Field
    /// </summary>/
    public sealed class IssueDate : DateTimeField
    {
        public IssueDate()
            :base(Tags.IssueDate) {}
        public IssueDate(DateTime val)
            :base(Tags.IssueDate, val) {}
    }


    /// <summary>
    /// Issuer Field
    /// </summary>/
    public sealed class Issuer : StringField
    {
        public Issuer()
            :base(Tags.Issuer) {}
        public Issuer(string val)
            :base(Tags.Issuer, val) {}
    }


    /// <summary>
    /// LastCapacity Field
    /// </summary>/
    public sealed class LastCapacity : CharField
    {
        public LastCapacity()
            :base(Tags.LastCapacity) {}
        public LastCapacity(char val)
            :base(Tags.LastCapacity, val) {}
    }


    /// <summary>
    /// LastForwardPoints Field
    /// </summary>/
    public sealed class LastForwardPoints : DecimalField
    {
        public LastForwardPoints()
            :base(Tags.LastForwardPoints) {}
        public LastForwardPoints(Decimal val)
            :base(Tags.LastForwardPoints, val) {}
    }


    /// <summary>
    /// LastForwardPoints2 Field
    /// </summary>/
    public sealed class LastForwardPoints2 : DecimalField
    {
        public LastForwardPoints2()
            :base(Tags.LastForwardPoints2) {}
        public LastForwardPoints2(Decimal val)
            :base(Tags.LastForwardPoints2, val) {}
    }


    /// <summary>
    /// LastFragment Field
    /// </summary>/
    public sealed class LastFragment : BooleanField
    {
        public LastFragment()
            :base(Tags.LastFragment) {}
        public LastFragment(Boolean val)
            :base(Tags.LastFragment, val) {}
    }


    /// <summary>
    /// LastLiquidityInd Field
    /// </summary>/
    public sealed class LastLiquidityInd : IntField
    {
        public LastLiquidityInd()
            :base(Tags.LastLiquidityInd) {}
        public LastLiquidityInd(int val)
            :base(Tags.LastLiquidityInd, val) {}
    }


    /// <summary>
    /// LastMkt Field
    /// </summary>/
    public sealed class LastMkt : StringField
    {
        public LastMkt()
            :base(Tags.LastMkt) {}
        public LastMkt(string val)
            :base(Tags.LastMkt, val) {}
    }


    /// <summary>
    /// LastMsgSeqNumProcessed Field
    /// </summary>/
    public sealed class LastMsgSeqNumProcessed : IntField
    {
        public LastMsgSeqNumProcessed()
            :base(Tags.LastMsgSeqNumProcessed) {}
        public LastMsgSeqNumProcessed(int val)
            :base(Tags.LastMsgSeqNumProcessed, val) {}
    }


    /// <summary>
    /// LastNetworkResponseID Field
    /// </summary>/
    public sealed class LastNetworkResponseID : StringField
    {
        public LastNetworkResponseID()
            :base(Tags.LastNetworkResponseID) {}
        public LastNetworkResponseID(string val)
            :base(Tags.LastNetworkResponseID, val) {}
    }


    /// <summary>
    /// LastParPx Field
    /// </summary>/
    public sealed class LastParPx : DecimalField
    {
        public LastParPx()
            :base(Tags.LastParPx) {}
        public LastParPx(Decimal val)
            :base(Tags.LastParPx, val) {}
    }


    /// <summary>
    /// LastPx Field
    /// </summary>/
    public sealed class LastPx : DecimalField
    {
        public LastPx()
            :base(Tags.LastPx) {}
        public LastPx(Decimal val)
            :base(Tags.LastPx, val) {}
    }


    /// <summary>
    /// LastQty Field
    /// </summary>/
    public sealed class LastQty : DecimalField
    {
        public LastQty()
            :base(Tags.LastQty) {}
        public LastQty(Decimal val)
            :base(Tags.LastQty, val) {}
    }


    /// <summary>
    /// LastRptRequested Field
    /// </summary>/
    public sealed class LastRptRequested : BooleanField
    {
        public LastRptRequested()
            :base(Tags.LastRptRequested) {}
        public LastRptRequested(Boolean val)
            :base(Tags.LastRptRequested, val) {}
    }


    /// <summary>
    /// LastSpotRate Field
    /// </summary>/
    public sealed class LastSpotRate : DecimalField
    {
        public LastSpotRate()
            :base(Tags.LastSpotRate) {}
        public LastSpotRate(Decimal val)
            :base(Tags.LastSpotRate, val) {}
    }


    /// <summary>
    /// LastUpdateTime Field
    /// </summary>/
    public sealed class LastUpdateTime : DateTimeField
    {
        public LastUpdateTime()
            :base(Tags.LastUpdateTime) {}
        public LastUpdateTime(DateTime val)
            :base(Tags.LastUpdateTime, val) {}
    }


    /// <summary>
    /// LeavesQty Field
    /// </summary>/
    public sealed class LeavesQty : DecimalField
    {
        public LeavesQty()
            :base(Tags.LeavesQty) {}
        public LeavesQty(Decimal val)
            :base(Tags.LeavesQty, val) {}
    }


    /// <summary>
    /// LegAllocAccount Field
    /// </summary>/
    public sealed class LegAllocAccount : StringField
    {
        public LegAllocAccount()
            :base(Tags.LegAllocAccount) {}
        public LegAllocAccount(string val)
            :base(Tags.LegAllocAccount, val) {}
    }


    /// <summary>
    /// LegAllocAcctIDSource Field
    /// </summary>/
    public sealed class LegAllocAcctIDSource : StringField
    {
        public LegAllocAcctIDSource()
            :base(Tags.LegAllocAcctIDSource) {}
        public LegAllocAcctIDSource(string val)
            :base(Tags.LegAllocAcctIDSource, val) {}
    }


    /// <summary>
    /// LegAllocQty Field
    /// </summary>/
    public sealed class LegAllocQty : DecimalField
    {
        public LegAllocQty()
            :base(Tags.LegAllocQty) {}
        public LegAllocQty(Decimal val)
            :base(Tags.LegAllocQty, val) {}
    }


    /// <summary>
    /// LegBenchmarkCurveCurrency Field
    /// </summary>/
    public sealed class LegBenchmarkCurveCurrency : DecimalField
    {
        public LegBenchmarkCurveCurrency()
            :base(Tags.LegBenchmarkCurveCurrency) {}
        public LegBenchmarkCurveCurrency(Decimal val)
            :base(Tags.LegBenchmarkCurveCurrency, val) {}
    }


    /// <summary>
    /// LegBenchmarkCurveName Field
    /// </summary>/
    public sealed class LegBenchmarkCurveName : StringField
    {
        public LegBenchmarkCurveName()
            :base(Tags.LegBenchmarkCurveName) {}
        public LegBenchmarkCurveName(string val)
            :base(Tags.LegBenchmarkCurveName, val) {}
    }


    /// <summary>
    /// LegBenchmarkCurvePoint Field
    /// </summary>/
    public sealed class LegBenchmarkCurvePoint : StringField
    {
        public LegBenchmarkCurvePoint()
            :base(Tags.LegBenchmarkCurvePoint) {}
        public LegBenchmarkCurvePoint(string val)
            :base(Tags.LegBenchmarkCurvePoint, val) {}
    }


    /// <summary>
    /// LegBenchmarkPrice Field
    /// </summary>/
    public sealed class LegBenchmarkPrice : DecimalField
    {
        public LegBenchmarkPrice()
            :base(Tags.LegBenchmarkPrice) {}
        public LegBenchmarkPrice(Decimal val)
            :base(Tags.LegBenchmarkPrice, val) {}
    }


    /// <summary>
    /// LegBenchmarkPriceType Field
    /// </summary>/
    public sealed class LegBenchmarkPriceType : IntField
    {
        public LegBenchmarkPriceType()
            :base(Tags.LegBenchmarkPriceType) {}
        public LegBenchmarkPriceType(int val)
            :base(Tags.LegBenchmarkPriceType, val) {}
    }


    /// <summary>
    /// LegBidPx Field
    /// </summary>/
    public sealed class LegBidPx : DecimalField
    {
        public LegBidPx()
            :base(Tags.LegBidPx) {}
        public LegBidPx(Decimal val)
            :base(Tags.LegBidPx, val) {}
    }


    /// <summary>
    /// LegCFICode Field
    /// </summary>/
    public sealed class LegCFICode : StringField
    {
        public LegCFICode()
            :base(Tags.LegCFICode) {}
        public LegCFICode(string val)
            :base(Tags.LegCFICode, val) {}
    }


    /// <summary>
    /// LegContractMultiplier Field
    /// </summary>/
    public sealed class LegContractMultiplier : DecimalField
    {
        public LegContractMultiplier()
            :base(Tags.LegContractMultiplier) {}
        public LegContractMultiplier(Decimal val)
            :base(Tags.LegContractMultiplier, val) {}
    }


    /// <summary>
    /// LegContractSettlMonth Field
    /// </summary>/
    public sealed class LegContractSettlMonth : DateTimeField
    {
        public LegContractSettlMonth()
            :base(Tags.LegContractSettlMonth) {}
        public LegContractSettlMonth(DateTime val)
            :base(Tags.LegContractSettlMonth, val) {}
    }


    /// <summary>
    /// LegCountryOfIssue Field
    /// </summary>/
    public sealed class LegCountryOfIssue : StringField
    {
        public LegCountryOfIssue()
            :base(Tags.LegCountryOfIssue) {}
        public LegCountryOfIssue(string val)
            :base(Tags.LegCountryOfIssue, val) {}
    }


    /// <summary>
    /// LegCouponPaymentDate Field
    /// </summary>/
    public sealed class LegCouponPaymentDate : DateTimeField
    {
        public LegCouponPaymentDate()
            :base(Tags.LegCouponPaymentDate) {}
        public LegCouponPaymentDate(DateTime val)
            :base(Tags.LegCouponPaymentDate, val) {}
    }


    /// <summary>
    /// LegCouponRate Field
    /// </summary>/
    public sealed class LegCouponRate : DecimalField
    {
        public LegCouponRate()
            :base(Tags.LegCouponRate) {}
        public LegCouponRate(Decimal val)
            :base(Tags.LegCouponRate, val) {}
    }


    /// <summary>
    /// LegCoveredOrUncovered Field
    /// </summary>/
    public sealed class LegCoveredOrUncovered : IntField
    {
        public LegCoveredOrUncovered()
            :base(Tags.LegCoveredOrUncovered) {}
        public LegCoveredOrUncovered(int val)
            :base(Tags.LegCoveredOrUncovered, val) {}
    }


    /// <summary>
    /// LegCreditRating Field
    /// </summary>/
    public sealed class LegCreditRating : StringField
    {
        public LegCreditRating()
            :base(Tags.LegCreditRating) {}
        public LegCreditRating(string val)
            :base(Tags.LegCreditRating, val) {}
    }


    /// <summary>
    /// LegCurrency Field
    /// </summary>/
    public sealed class LegCurrency : DecimalField
    {
        public LegCurrency()
            :base(Tags.LegCurrency) {}
        public LegCurrency(Decimal val)
            :base(Tags.LegCurrency, val) {}
    }


    /// <summary>
    /// LegDatedDate Field
    /// </summary>/
    public sealed class LegDatedDate : DateTimeField
    {
        public LegDatedDate()
            :base(Tags.LegDatedDate) {}
        public LegDatedDate(DateTime val)
            :base(Tags.LegDatedDate, val) {}
    }


    /// <summary>
    /// LegFactor Field
    /// </summary>/
    public sealed class LegFactor : DecimalField
    {
        public LegFactor()
            :base(Tags.LegFactor) {}
        public LegFactor(Decimal val)
            :base(Tags.LegFactor, val) {}
    }


    /// <summary>
    /// LegIOIQty Field
    /// </summary>/
    public sealed class LegIOIQty : StringField
    {
        public LegIOIQty()
            :base(Tags.LegIOIQty) {}
        public LegIOIQty(string val)
            :base(Tags.LegIOIQty, val) {}
    }


    /// <summary>
    /// LegIndividualAllocID Field
    /// </summary>/
    public sealed class LegIndividualAllocID : StringField
    {
        public LegIndividualAllocID()
            :base(Tags.LegIndividualAllocID) {}
        public LegIndividualAllocID(string val)
            :base(Tags.LegIndividualAllocID, val) {}
    }


    /// <summary>
    /// LegInstrRegistry Field
    /// </summary>/
    public sealed class LegInstrRegistry : StringField
    {
        public LegInstrRegistry()
            :base(Tags.LegInstrRegistry) {}
        public LegInstrRegistry(string val)
            :base(Tags.LegInstrRegistry, val) {}
    }


    /// <summary>
    /// LegInterestAccrualDate Field
    /// </summary>/
    public sealed class LegInterestAccrualDate : DateTimeField
    {
        public LegInterestAccrualDate()
            :base(Tags.LegInterestAccrualDate) {}
        public LegInterestAccrualDate(DateTime val)
            :base(Tags.LegInterestAccrualDate, val) {}
    }


    /// <summary>
    /// LegIssueDate Field
    /// </summary>/
    public sealed class LegIssueDate : DateTimeField
    {
        public LegIssueDate()
            :base(Tags.LegIssueDate) {}
        public LegIssueDate(DateTime val)
            :base(Tags.LegIssueDate, val) {}
    }


    /// <summary>
    /// LegIssuer Field
    /// </summary>/
    public sealed class LegIssuer : StringField
    {
        public LegIssuer()
            :base(Tags.LegIssuer) {}
        public LegIssuer(string val)
            :base(Tags.LegIssuer, val) {}
    }


    /// <summary>
    /// LegLastPx Field
    /// </summary>/
    public sealed class LegLastPx : DecimalField
    {
        public LegLastPx()
            :base(Tags.LegLastPx) {}
        public LegLastPx(Decimal val)
            :base(Tags.LegLastPx, val) {}
    }


    /// <summary>
    /// LegLocaleOfIssue Field
    /// </summary>/
    public sealed class LegLocaleOfIssue : StringField
    {
        public LegLocaleOfIssue()
            :base(Tags.LegLocaleOfIssue) {}
        public LegLocaleOfIssue(string val)
            :base(Tags.LegLocaleOfIssue, val) {}
    }


    /// <summary>
    /// LegMaturityDate Field
    /// </summary>/
    public sealed class LegMaturityDate : DateTimeField
    {
        public LegMaturityDate()
            :base(Tags.LegMaturityDate) {}
        public LegMaturityDate(DateTime val)
            :base(Tags.LegMaturityDate, val) {}
    }


    /// <summary>
    /// LegMaturityMonthYear Field
    /// </summary>/
    public sealed class LegMaturityMonthYear : DateTimeField
    {
        public LegMaturityMonthYear()
            :base(Tags.LegMaturityMonthYear) {}
        public LegMaturityMonthYear(DateTime val)
            :base(Tags.LegMaturityMonthYear, val) {}
    }


    /// <summary>
    /// LegOfferPx Field
    /// </summary>/
    public sealed class LegOfferPx : DecimalField
    {
        public LegOfferPx()
            :base(Tags.LegOfferPx) {}
        public LegOfferPx(Decimal val)
            :base(Tags.LegOfferPx, val) {}
    }


    /// <summary>
    /// LegOptAttribute Field
    /// </summary>/
    public sealed class LegOptAttribute : CharField
    {
        public LegOptAttribute()
            :base(Tags.LegOptAttribute) {}
        public LegOptAttribute(char val)
            :base(Tags.LegOptAttribute, val) {}
    }


    /// <summary>
    /// LegOrderQty Field
    /// </summary>/
    public sealed class LegOrderQty : DecimalField
    {
        public LegOrderQty()
            :base(Tags.LegOrderQty) {}
        public LegOrderQty(Decimal val)
            :base(Tags.LegOrderQty, val) {}
    }


    /// <summary>
    /// LegPool Field
    /// </summary>/
    public sealed class LegPool : StringField
    {
        public LegPool()
            :base(Tags.LegPool) {}
        public LegPool(string val)
            :base(Tags.LegPool, val) {}
    }


    /// <summary>
    /// LegPositionEffect Field
    /// </summary>/
    public sealed class LegPositionEffect : CharField
    {
        public LegPositionEffect()
            :base(Tags.LegPositionEffect) {}
        public LegPositionEffect(char val)
            :base(Tags.LegPositionEffect, val) {}
    }


    /// <summary>
    /// LegPrice Field
    /// </summary>/
    public sealed class LegPrice : DecimalField
    {
        public LegPrice()
            :base(Tags.LegPrice) {}
        public LegPrice(Decimal val)
            :base(Tags.LegPrice, val) {}
    }


    /// <summary>
    /// LegPriceType Field
    /// </summary>/
    public sealed class LegPriceType : IntField
    {
        public LegPriceType()
            :base(Tags.LegPriceType) {}
        public LegPriceType(int val)
            :base(Tags.LegPriceType, val) {}
    }


    /// <summary>
    /// LegProduct Field
    /// </summary>/
    public sealed class LegProduct : IntField
    {
        public LegProduct()
            :base(Tags.LegProduct) {}
        public LegProduct(int val)
            :base(Tags.LegProduct, val) {}
    }


    /// <summary>
    /// LegQty Field
    /// </summary>/
    public sealed class LegQty : DecimalField
    {
        public LegQty()
            :base(Tags.LegQty) {}
        public LegQty(Decimal val)
            :base(Tags.LegQty, val) {}
    }


    /// <summary>
    /// LegRatioQty Field
    /// </summary>/
    public sealed class LegRatioQty : DecimalField
    {
        public LegRatioQty()
            :base(Tags.LegRatioQty) {}
        public LegRatioQty(Decimal val)
            :base(Tags.LegRatioQty, val) {}
    }


    /// <summary>
    /// LegRedemptionDate Field
    /// </summary>/
    public sealed class LegRedemptionDate : DateTimeField
    {
        public LegRedemptionDate()
            :base(Tags.LegRedemptionDate) {}
        public LegRedemptionDate(DateTime val)
            :base(Tags.LegRedemptionDate, val) {}
    }


    /// <summary>
    /// LegRefID Field
    /// </summary>/
    public sealed class LegRefID : StringField
    {
        public LegRefID()
            :base(Tags.LegRefID) {}
        public LegRefID(string val)
            :base(Tags.LegRefID, val) {}
    }


    /// <summary>
    /// LegRepoCollateralSecurityType Field
    /// </summary>/
    public sealed class LegRepoCollateralSecurityType : IntField
    {
        public LegRepoCollateralSecurityType()
            :base(Tags.LegRepoCollateralSecurityType) {}
        public LegRepoCollateralSecurityType(int val)
            :base(Tags.LegRepoCollateralSecurityType, val) {}
    }


    /// <summary>
    /// LegRepurchaseRate Field
    /// </summary>/
    public sealed class LegRepurchaseRate : DecimalField
    {
        public LegRepurchaseRate()
            :base(Tags.LegRepurchaseRate) {}
        public LegRepurchaseRate(Decimal val)
            :base(Tags.LegRepurchaseRate, val) {}
    }


    /// <summary>
    /// LegRepurchaseTerm Field
    /// </summary>/
    public sealed class LegRepurchaseTerm : IntField
    {
        public LegRepurchaseTerm()
            :base(Tags.LegRepurchaseTerm) {}
        public LegRepurchaseTerm(int val)
            :base(Tags.LegRepurchaseTerm, val) {}
    }


    /// <summary>
    /// LegSecurityAltID Field
    /// </summary>/
    public sealed class LegSecurityAltID : StringField
    {
        public LegSecurityAltID()
            :base(Tags.LegSecurityAltID) {}
        public LegSecurityAltID(string val)
            :base(Tags.LegSecurityAltID, val) {}
    }


    /// <summary>
    /// LegSecurityAltIDSource Field
    /// </summary>/
    public sealed class LegSecurityAltIDSource : StringField
    {
        public LegSecurityAltIDSource()
            :base(Tags.LegSecurityAltIDSource) {}
        public LegSecurityAltIDSource(string val)
            :base(Tags.LegSecurityAltIDSource, val) {}
    }


    /// <summary>
    /// LegSecurityDesc Field
    /// </summary>/
    public sealed class LegSecurityDesc : StringField
    {
        public LegSecurityDesc()
            :base(Tags.LegSecurityDesc) {}
        public LegSecurityDesc(string val)
            :base(Tags.LegSecurityDesc, val) {}
    }


    /// <summary>
    /// LegSecurityExchange Field
    /// </summary>/
    public sealed class LegSecurityExchange : StringField
    {
        public LegSecurityExchange()
            :base(Tags.LegSecurityExchange) {}
        public LegSecurityExchange(string val)
            :base(Tags.LegSecurityExchange, val) {}
    }


    /// <summary>
    /// LegSecurityID Field
    /// </summary>/
    public sealed class LegSecurityID : StringField
    {
        public LegSecurityID()
            :base(Tags.LegSecurityID) {}
        public LegSecurityID(string val)
            :base(Tags.LegSecurityID, val) {}
    }


    /// <summary>
    /// LegSecurityIDSource Field
    /// </summary>/
    public sealed class LegSecurityIDSource : StringField
    {
        public LegSecurityIDSource()
            :base(Tags.LegSecurityIDSource) {}
        public LegSecurityIDSource(string val)
            :base(Tags.LegSecurityIDSource, val) {}
    }


    /// <summary>
    /// LegSecuritySubType Field
    /// </summary>/
    public sealed class LegSecuritySubType : StringField
    {
        public LegSecuritySubType()
            :base(Tags.LegSecuritySubType) {}
        public LegSecuritySubType(string val)
            :base(Tags.LegSecuritySubType, val) {}
    }


    /// <summary>
    /// LegSecurityType Field
    /// </summary>/
    public sealed class LegSecurityType : StringField
    {
        public LegSecurityType()
            :base(Tags.LegSecurityType) {}
        public LegSecurityType(string val)
            :base(Tags.LegSecurityType, val) {}
    }


    /// <summary>
    /// LegSettlCurrency Field
    /// </summary>/
    public sealed class LegSettlCurrency : DecimalField
    {
        public LegSettlCurrency()
            :base(Tags.LegSettlCurrency) {}
        public LegSettlCurrency(Decimal val)
            :base(Tags.LegSettlCurrency, val) {}
    }


    /// <summary>
    /// LegSettlDate Field
    /// </summary>/
    public sealed class LegSettlDate : DateTimeField
    {
        public LegSettlDate()
            :base(Tags.LegSettlDate) {}
        public LegSettlDate(DateTime val)
            :base(Tags.LegSettlDate, val) {}
    }


    /// <summary>
    /// LegSettlType Field
    /// </summary>/
    public sealed class LegSettlType : CharField
    {
        public LegSettlType()
            :base(Tags.LegSettlType) {}
        public LegSettlType(char val)
            :base(Tags.LegSettlType, val) {}
    }


    /// <summary>
    /// LegSide Field
    /// </summary>/
    public sealed class LegSide : CharField
    {
        public LegSide()
            :base(Tags.LegSide) {}
        public LegSide(char val)
            :base(Tags.LegSide, val) {}
    }


    /// <summary>
    /// LegStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class LegStateOrProvinceOfIssue : StringField
    {
        public LegStateOrProvinceOfIssue()
            :base(Tags.LegStateOrProvinceOfIssue) {}
        public LegStateOrProvinceOfIssue(string val)
            :base(Tags.LegStateOrProvinceOfIssue, val) {}
    }


    /// <summary>
    /// LegStipulationType Field
    /// </summary>/
    public sealed class LegStipulationType : StringField
    {
        public LegStipulationType()
            :base(Tags.LegStipulationType) {}
        public LegStipulationType(string val)
            :base(Tags.LegStipulationType, val) {}
    }


    /// <summary>
    /// LegStipulationValue Field
    /// </summary>/
    public sealed class LegStipulationValue : StringField
    {
        public LegStipulationValue()
            :base(Tags.LegStipulationValue) {}
        public LegStipulationValue(string val)
            :base(Tags.LegStipulationValue, val) {}
    }


    /// <summary>
    /// LegStrikeCurrency Field
    /// </summary>/
    public sealed class LegStrikeCurrency : DecimalField
    {
        public LegStrikeCurrency()
            :base(Tags.LegStrikeCurrency) {}
        public LegStrikeCurrency(Decimal val)
            :base(Tags.LegStrikeCurrency, val) {}
    }


    /// <summary>
    /// LegStrikePrice Field
    /// </summary>/
    public sealed class LegStrikePrice : DecimalField
    {
        public LegStrikePrice()
            :base(Tags.LegStrikePrice) {}
        public LegStrikePrice(Decimal val)
            :base(Tags.LegStrikePrice, val) {}
    }


    /// <summary>
    /// LegSwapType Field
    /// </summary>/
    public sealed class LegSwapType : IntField
    {
        public LegSwapType()
            :base(Tags.LegSwapType) {}
        public LegSwapType(int val)
            :base(Tags.LegSwapType, val) {}
    }


    /// <summary>
    /// LegSymbol Field
    /// </summary>/
    public sealed class LegSymbol : StringField
    {
        public LegSymbol()
            :base(Tags.LegSymbol) {}
        public LegSymbol(string val)
            :base(Tags.LegSymbol, val) {}
    }


    /// <summary>
    /// LegSymbolSfx Field
    /// </summary>/
    public sealed class LegSymbolSfx : StringField
    {
        public LegSymbolSfx()
            :base(Tags.LegSymbolSfx) {}
        public LegSymbolSfx(string val)
            :base(Tags.LegSymbolSfx, val) {}
    }


    /// <summary>
    /// LegalConfirm Field
    /// </summary>/
    public sealed class LegalConfirm : BooleanField
    {
        public LegalConfirm()
            :base(Tags.LegalConfirm) {}
        public LegalConfirm(Boolean val)
            :base(Tags.LegalConfirm, val) {}
    }


    /// <summary>
    /// LinesOfText Field
    /// </summary>/
    public sealed class LinesOfText : IntField
    {
        public LinesOfText()
            :base(Tags.LinesOfText) {}
        public LinesOfText(int val)
            :base(Tags.LinesOfText, val) {}
    }


    /// <summary>
    /// LiquidityIndType Field
    /// </summary>/
    public sealed class LiquidityIndType : IntField
    {
        public LiquidityIndType()
            :base(Tags.LiquidityIndType) {}
        public LiquidityIndType(int val)
            :base(Tags.LiquidityIndType, val) {}
    }


    /// <summary>
    /// LiquidityNumSecurities Field
    /// </summary>/
    public sealed class LiquidityNumSecurities : IntField
    {
        public LiquidityNumSecurities()
            :base(Tags.LiquidityNumSecurities) {}
        public LiquidityNumSecurities(int val)
            :base(Tags.LiquidityNumSecurities, val) {}
    }


    /// <summary>
    /// LiquidityPctHigh Field
    /// </summary>/
    public sealed class LiquidityPctHigh : DecimalField
    {
        public LiquidityPctHigh()
            :base(Tags.LiquidityPctHigh) {}
        public LiquidityPctHigh(Decimal val)
            :base(Tags.LiquidityPctHigh, val) {}
    }


    /// <summary>
    /// LiquidityPctLow Field
    /// </summary>/
    public sealed class LiquidityPctLow : DecimalField
    {
        public LiquidityPctLow()
            :base(Tags.LiquidityPctLow) {}
        public LiquidityPctLow(Decimal val)
            :base(Tags.LiquidityPctLow, val) {}
    }


    /// <summary>
    /// LiquidityValue Field
    /// </summary>/
    public sealed class LiquidityValue : DecimalField
    {
        public LiquidityValue()
            :base(Tags.LiquidityValue) {}
        public LiquidityValue(Decimal val)
            :base(Tags.LiquidityValue, val) {}
    }


    /// <summary>
    /// ListExecInst Field
    /// </summary>/
    public sealed class ListExecInst : StringField
    {
        public ListExecInst()
            :base(Tags.ListExecInst) {}
        public ListExecInst(string val)
            :base(Tags.ListExecInst, val) {}
    }


    /// <summary>
    /// ListExecInstType Field
    /// </summary>/
    public sealed class ListExecInstType : CharField
    {
        public ListExecInstType()
            :base(Tags.ListExecInstType) {}
        public ListExecInstType(char val)
            :base(Tags.ListExecInstType, val) {}
    }


    /// <summary>
    /// ListID Field
    /// </summary>/
    public sealed class ListID : StringField
    {
        public ListID()
            :base(Tags.ListID) {}
        public ListID(string val)
            :base(Tags.ListID, val) {}
    }


    /// <summary>
    /// ListName Field
    /// </summary>/
    public sealed class ListName : StringField
    {
        public ListName()
            :base(Tags.ListName) {}
        public ListName(string val)
            :base(Tags.ListName, val) {}
    }


    /// <summary>
    /// ListOrderStatus Field
    /// </summary>/
    public sealed class ListOrderStatus : IntField
    {
        public ListOrderStatus()
            :base(Tags.ListOrderStatus) {}
        public ListOrderStatus(int val)
            :base(Tags.ListOrderStatus, val) {}
    }


    /// <summary>
    /// ListSeqNo Field
    /// </summary>/
    public sealed class ListSeqNo : IntField
    {
        public ListSeqNo()
            :base(Tags.ListSeqNo) {}
        public ListSeqNo(int val)
            :base(Tags.ListSeqNo, val) {}
    }


    /// <summary>
    /// ListStatusText Field
    /// </summary>/
    public sealed class ListStatusText : StringField
    {
        public ListStatusText()
            :base(Tags.ListStatusText) {}
        public ListStatusText(string val)
            :base(Tags.ListStatusText, val) {}
    }


    /// <summary>
    /// ListStatusType Field
    /// </summary>/
    public sealed class ListStatusType : IntField
    {
        public ListStatusType()
            :base(Tags.ListStatusType) {}
        public ListStatusType(int val)
            :base(Tags.ListStatusType, val) {}
    }


    /// <summary>
    /// LocaleOfIssue Field
    /// </summary>/
    public sealed class LocaleOfIssue : StringField
    {
        public LocaleOfIssue()
            :base(Tags.LocaleOfIssue) {}
        public LocaleOfIssue(string val)
            :base(Tags.LocaleOfIssue, val) {}
    }


    /// <summary>
    /// LocateReqd Field
    /// </summary>/
    public sealed class LocateReqd : BooleanField
    {
        public LocateReqd()
            :base(Tags.LocateReqd) {}
        public LocateReqd(Boolean val)
            :base(Tags.LocateReqd, val) {}
    }


    /// <summary>
    /// LocationID Field
    /// </summary>/
    public sealed class LocationID : StringField
    {
        public LocationID()
            :base(Tags.LocationID) {}
        public LocationID(string val)
            :base(Tags.LocationID, val) {}
    }


    /// <summary>
    /// LongQty Field
    /// </summary>/
    public sealed class LongQty : DecimalField
    {
        public LongQty()
            :base(Tags.LongQty) {}
        public LongQty(Decimal val)
            :base(Tags.LongQty, val) {}
    }


    /// <summary>
    /// LowPx Field
    /// </summary>/
    public sealed class LowPx : DecimalField
    {
        public LowPx()
            :base(Tags.LowPx) {}
        public LowPx(Decimal val)
            :base(Tags.LowPx, val) {}
    }


    /// <summary>
    /// MDEntryBuyer Field
    /// </summary>/
    public sealed class MDEntryBuyer : StringField
    {
        public MDEntryBuyer()
            :base(Tags.MDEntryBuyer) {}
        public MDEntryBuyer(string val)
            :base(Tags.MDEntryBuyer, val) {}
    }


    /// <summary>
    /// MDEntryDate Field
    /// </summary>/
    public sealed class MDEntryDate : DateTimeField
    {
        public MDEntryDate()
            :base(Tags.MDEntryDate) {}
        public MDEntryDate(DateTime val)
            :base(Tags.MDEntryDate, val) {}
    }


    /// <summary>
    /// MDEntryID Field
    /// </summary>/
    public sealed class MDEntryID : StringField
    {
        public MDEntryID()
            :base(Tags.MDEntryID) {}
        public MDEntryID(string val)
            :base(Tags.MDEntryID, val) {}
    }


    /// <summary>
    /// MDEntryOriginator Field
    /// </summary>/
    public sealed class MDEntryOriginator : StringField
    {
        public MDEntryOriginator()
            :base(Tags.MDEntryOriginator) {}
        public MDEntryOriginator(string val)
            :base(Tags.MDEntryOriginator, val) {}
    }


    /// <summary>
    /// MDEntryPositionNo Field
    /// </summary>/
    public sealed class MDEntryPositionNo : IntField
    {
        public MDEntryPositionNo()
            :base(Tags.MDEntryPositionNo) {}
        public MDEntryPositionNo(int val)
            :base(Tags.MDEntryPositionNo, val) {}
    }


    /// <summary>
    /// MDEntryPx Field
    /// </summary>/
    public sealed class MDEntryPx : DecimalField
    {
        public MDEntryPx()
            :base(Tags.MDEntryPx) {}
        public MDEntryPx(Decimal val)
            :base(Tags.MDEntryPx, val) {}
    }


    /// <summary>
    /// MDEntryRefID Field
    /// </summary>/
    public sealed class MDEntryRefID : StringField
    {
        public MDEntryRefID()
            :base(Tags.MDEntryRefID) {}
        public MDEntryRefID(string val)
            :base(Tags.MDEntryRefID, val) {}
    }


    /// <summary>
    /// MDEntrySeller Field
    /// </summary>/
    public sealed class MDEntrySeller : StringField
    {
        public MDEntrySeller()
            :base(Tags.MDEntrySeller) {}
        public MDEntrySeller(string val)
            :base(Tags.MDEntrySeller, val) {}
    }


    /// <summary>
    /// MDEntrySize Field
    /// </summary>/
    public sealed class MDEntrySize : DecimalField
    {
        public MDEntrySize()
            :base(Tags.MDEntrySize) {}
        public MDEntrySize(Decimal val)
            :base(Tags.MDEntrySize, val) {}
    }


    /// <summary>
    /// MDEntryTime Field
    /// </summary>/
    public sealed class MDEntryTime : DateTimeField
    {
        public MDEntryTime()
            :base(Tags.MDEntryTime) {}
        public MDEntryTime(DateTime val)
            :base(Tags.MDEntryTime, val) {}
    }


    /// <summary>
    /// MDEntryType Field
    /// </summary>/
    public sealed class MDEntryType : CharField
    {
        public MDEntryType()
            :base(Tags.MDEntryType) {}
        public MDEntryType(char val)
            :base(Tags.MDEntryType, val) {}
    }


    /// <summary>
    /// MDImplicitDelete Field
    /// </summary>/
    public sealed class MDImplicitDelete : BooleanField
    {
        public MDImplicitDelete()
            :base(Tags.MDImplicitDelete) {}
        public MDImplicitDelete(Boolean val)
            :base(Tags.MDImplicitDelete, val) {}
    }


    /// <summary>
    /// MDMkt Field
    /// </summary>/
    public sealed class MDMkt : StringField
    {
        public MDMkt()
            :base(Tags.MDMkt) {}
        public MDMkt(string val)
            :base(Tags.MDMkt, val) {}
    }


    /// <summary>
    /// MDReqID Field
    /// </summary>/
    public sealed class MDReqID : StringField
    {
        public MDReqID()
            :base(Tags.MDReqID) {}
        public MDReqID(string val)
            :base(Tags.MDReqID, val) {}
    }


    /// <summary>
    /// MDReqRejReason Field
    /// </summary>/
    public sealed class MDReqRejReason : CharField
    {
        public MDReqRejReason()
            :base(Tags.MDReqRejReason) {}
        public MDReqRejReason(char val)
            :base(Tags.MDReqRejReason, val) {}
    }


    /// <summary>
    /// MDUpdateAction Field
    /// </summary>/
    public sealed class MDUpdateAction : CharField
    {
        public MDUpdateAction()
            :base(Tags.MDUpdateAction) {}
        public MDUpdateAction(char val)
            :base(Tags.MDUpdateAction, val) {}
    }


    /// <summary>
    /// MDUpdateType Field
    /// </summary>/
    public sealed class MDUpdateType : IntField
    {
        public MDUpdateType()
            :base(Tags.MDUpdateType) {}
        public MDUpdateType(int val)
            :base(Tags.MDUpdateType, val) {}
    }


    /// <summary>
    /// MailingDtls Field
    /// </summary>/
    public sealed class MailingDtls : StringField
    {
        public MailingDtls()
            :base(Tags.MailingDtls) {}
        public MailingDtls(string val)
            :base(Tags.MailingDtls, val) {}
    }


    /// <summary>
    /// MailingInst Field
    /// </summary>/
    public sealed class MailingInst : StringField
    {
        public MailingInst()
            :base(Tags.MailingInst) {}
        public MailingInst(string val)
            :base(Tags.MailingInst, val) {}
    }


    /// <summary>
    /// MarginExcess Field
    /// </summary>/
    public sealed class MarginExcess : DecimalField
    {
        public MarginExcess()
            :base(Tags.MarginExcess) {}
        public MarginExcess(Decimal val)
            :base(Tags.MarginExcess, val) {}
    }


    /// <summary>
    /// MarginRatio Field
    /// </summary>/
    public sealed class MarginRatio : DecimalField
    {
        public MarginRatio()
            :base(Tags.MarginRatio) {}
        public MarginRatio(Decimal val)
            :base(Tags.MarginRatio, val) {}
    }


    /// <summary>
    /// MarketDepth Field
    /// </summary>/
    public sealed class MarketDepth : IntField
    {
        public MarketDepth()
            :base(Tags.MarketDepth) {}
        public MarketDepth(int val)
            :base(Tags.MarketDepth, val) {}
    }


    /// <summary>
    /// MassCancelRejectReason Field
    /// </summary>/
    public sealed class MassCancelRejectReason : CharField
    {
        public MassCancelRejectReason()
            :base(Tags.MassCancelRejectReason) {}
        public MassCancelRejectReason(char val)
            :base(Tags.MassCancelRejectReason, val) {}
    }


    /// <summary>
    /// MassCancelRequestType Field
    /// </summary>/
    public sealed class MassCancelRequestType : CharField
    {
        public MassCancelRequestType()
            :base(Tags.MassCancelRequestType) {}
        public MassCancelRequestType(char val)
            :base(Tags.MassCancelRequestType, val) {}
    }


    /// <summary>
    /// MassCancelResponse Field
    /// </summary>/
    public sealed class MassCancelResponse : CharField
    {
        public MassCancelResponse()
            :base(Tags.MassCancelResponse) {}
        public MassCancelResponse(char val)
            :base(Tags.MassCancelResponse, val) {}
    }


    /// <summary>
    /// MassStatusReqID Field
    /// </summary>/
    public sealed class MassStatusReqID : StringField
    {
        public MassStatusReqID()
            :base(Tags.MassStatusReqID) {}
        public MassStatusReqID(string val)
            :base(Tags.MassStatusReqID, val) {}
    }


    /// <summary>
    /// MassStatusReqType Field
    /// </summary>/
    public sealed class MassStatusReqType : IntField
    {
        public MassStatusReqType()
            :base(Tags.MassStatusReqType) {}
        public MassStatusReqType(int val)
            :base(Tags.MassStatusReqType, val) {}
    }


    /// <summary>
    /// MatchStatus Field
    /// </summary>/
    public sealed class MatchStatus : CharField
    {
        public MatchStatus()
            :base(Tags.MatchStatus) {}
        public MatchStatus(char val)
            :base(Tags.MatchStatus, val) {}
    }


    /// <summary>
    /// MatchType Field
    /// </summary>/
    public sealed class MatchType : StringField
    {
        public MatchType()
            :base(Tags.MatchType) {}
        public MatchType(string val)
            :base(Tags.MatchType, val) {}
    }


    /// <summary>
    /// MaturityDate Field
    /// </summary>/
    public sealed class MaturityDate : DateTimeField
    {
        public MaturityDate()
            :base(Tags.MaturityDate) {}
        public MaturityDate(DateTime val)
            :base(Tags.MaturityDate, val) {}
    }


    /// <summary>
    /// MaturityMonthYear Field
    /// </summary>/
    public sealed class MaturityMonthYear : DateTimeField
    {
        public MaturityMonthYear()
            :base(Tags.MaturityMonthYear) {}
        public MaturityMonthYear(DateTime val)
            :base(Tags.MaturityMonthYear, val) {}
    }


    /// <summary>
    /// MaturityNetMoney Field
    /// </summary>/
    public sealed class MaturityNetMoney : DecimalField
    {
        public MaturityNetMoney()
            :base(Tags.MaturityNetMoney) {}
        public MaturityNetMoney(Decimal val)
            :base(Tags.MaturityNetMoney, val) {}
    }


    /// <summary>
    /// MaxFloor Field
    /// </summary>/
    public sealed class MaxFloor : DecimalField
    {
        public MaxFloor()
            :base(Tags.MaxFloor) {}
        public MaxFloor(Decimal val)
            :base(Tags.MaxFloor, val) {}
    }


    /// <summary>
    /// MaxMessageSize Field
    /// </summary>/
    public sealed class MaxMessageSize : DecimalField
    {
        public MaxMessageSize()
            :base(Tags.MaxMessageSize) {}
        public MaxMessageSize(Decimal val)
            :base(Tags.MaxMessageSize, val) {}
    }


    /// <summary>
    /// MaxShow Field
    /// </summary>/
    public sealed class MaxShow : DecimalField
    {
        public MaxShow()
            :base(Tags.MaxShow) {}
        public MaxShow(Decimal val)
            :base(Tags.MaxShow, val) {}
    }


    /// <summary>
    /// MessageEncoding Field
    /// </summary>/
    public sealed class MessageEncoding : StringField
    {
        public MessageEncoding()
            :base(Tags.MessageEncoding) {}
        public MessageEncoding(string val)
            :base(Tags.MessageEncoding, val) {}
    }


    /// <summary>
    /// MidPx Field
    /// </summary>/
    public sealed class MidPx : DecimalField
    {
        public MidPx()
            :base(Tags.MidPx) {}
        public MidPx(Decimal val)
            :base(Tags.MidPx, val) {}
    }


    /// <summary>
    /// MidYield Field
    /// </summary>/
    public sealed class MidYield : DecimalField
    {
        public MidYield()
            :base(Tags.MidYield) {}
        public MidYield(Decimal val)
            :base(Tags.MidYield, val) {}
    }


    /// <summary>
    /// MinBidSize Field
    /// </summary>/
    public sealed class MinBidSize : DecimalField
    {
        public MinBidSize()
            :base(Tags.MinBidSize) {}
        public MinBidSize(Decimal val)
            :base(Tags.MinBidSize, val) {}
    }


    /// <summary>
    /// MinOfferSize Field
    /// </summary>/
    public sealed class MinOfferSize : DecimalField
    {
        public MinOfferSize()
            :base(Tags.MinOfferSize) {}
        public MinOfferSize(Decimal val)
            :base(Tags.MinOfferSize, val) {}
    }


    /// <summary>
    /// MinQty Field
    /// </summary>/
    public sealed class MinQty : DecimalField
    {
        public MinQty()
            :base(Tags.MinQty) {}
        public MinQty(Decimal val)
            :base(Tags.MinQty, val) {}
    }


    /// <summary>
    /// MinTradeVol Field
    /// </summary>/
    public sealed class MinTradeVol : DecimalField
    {
        public MinTradeVol()
            :base(Tags.MinTradeVol) {}
        public MinTradeVol(Decimal val)
            :base(Tags.MinTradeVol, val) {}
    }


    /// <summary>
    /// MiscFeeAmt Field
    /// </summary>/
    public sealed class MiscFeeAmt : DecimalField
    {
        public MiscFeeAmt()
            :base(Tags.MiscFeeAmt) {}
        public MiscFeeAmt(Decimal val)
            :base(Tags.MiscFeeAmt, val) {}
    }


    /// <summary>
    /// MiscFeeBasis Field
    /// </summary>/
    public sealed class MiscFeeBasis : IntField
    {
        public MiscFeeBasis()
            :base(Tags.MiscFeeBasis) {}
        public MiscFeeBasis(int val)
            :base(Tags.MiscFeeBasis, val) {}
    }


    /// <summary>
    /// MiscFeeCurr Field
    /// </summary>/
    public sealed class MiscFeeCurr : DecimalField
    {
        public MiscFeeCurr()
            :base(Tags.MiscFeeCurr) {}
        public MiscFeeCurr(Decimal val)
            :base(Tags.MiscFeeCurr, val) {}
    }


    /// <summary>
    /// MiscFeeType Field
    /// </summary>/
    public sealed class MiscFeeType : CharField
    {
        public MiscFeeType()
            :base(Tags.MiscFeeType) {}
        public MiscFeeType(char val)
            :base(Tags.MiscFeeType, val) {}
    }


    /// <summary>
    /// MktBidPx Field
    /// </summary>/
    public sealed class MktBidPx : DecimalField
    {
        public MktBidPx()
            :base(Tags.MktBidPx) {}
        public MktBidPx(Decimal val)
            :base(Tags.MktBidPx, val) {}
    }


    /// <summary>
    /// MktOfferPx Field
    /// </summary>/
    public sealed class MktOfferPx : DecimalField
    {
        public MktOfferPx()
            :base(Tags.MktOfferPx) {}
        public MktOfferPx(Decimal val)
            :base(Tags.MktOfferPx, val) {}
    }


    /// <summary>
    /// MoneyLaunderingStatus Field
    /// </summary>/
    public sealed class MoneyLaunderingStatus : CharField
    {
        public MoneyLaunderingStatus()
            :base(Tags.MoneyLaunderingStatus) {}
        public MoneyLaunderingStatus(char val)
            :base(Tags.MoneyLaunderingStatus, val) {}
    }


    /// <summary>
    /// MsgDirection Field
    /// </summary>/
    public sealed class MsgDirection : CharField
    {
        public MsgDirection()
            :base(Tags.MsgDirection) {}
        public MsgDirection(char val)
            :base(Tags.MsgDirection, val) {}
    }


    /// <summary>
    /// MsgSeqNum Field
    /// </summary>/
    public sealed class MsgSeqNum : IntField
    {
        public MsgSeqNum()
            :base(Tags.MsgSeqNum) {}
        public MsgSeqNum(int val)
            :base(Tags.MsgSeqNum, val) {}
    }


    /// <summary>
    /// MsgType Field
    /// </summary>/
    public sealed class MsgType : StringField
    {
        public MsgType()
            :base(Tags.MsgType) {}
        public MsgType(string val)
            :base(Tags.MsgType, val) {}
    }


    /// <summary>
    /// MultiLegReportingType Field
    /// </summary>/
    public sealed class MultiLegReportingType : CharField
    {
        public MultiLegReportingType()
            :base(Tags.MultiLegReportingType) {}
        public MultiLegReportingType(char val)
            :base(Tags.MultiLegReportingType, val) {}
    }


    /// <summary>
    /// MultiLegRptTypeReq Field
    /// </summary>/
    public sealed class MultiLegRptTypeReq : IntField
    {
        public MultiLegRptTypeReq()
            :base(Tags.MultiLegRptTypeReq) {}
        public MultiLegRptTypeReq(int val)
            :base(Tags.MultiLegRptTypeReq, val) {}
    }


    /// <summary>
    /// Nested2PartyID Field
    /// </summary>/
    public sealed class Nested2PartyID : StringField
    {
        public Nested2PartyID()
            :base(Tags.Nested2PartyID) {}
        public Nested2PartyID(string val)
            :base(Tags.Nested2PartyID, val) {}
    }


    /// <summary>
    /// Nested2PartyIDSource Field
    /// </summary>/
    public sealed class Nested2PartyIDSource : CharField
    {
        public Nested2PartyIDSource()
            :base(Tags.Nested2PartyIDSource) {}
        public Nested2PartyIDSource(char val)
            :base(Tags.Nested2PartyIDSource, val) {}
    }


    /// <summary>
    /// Nested2PartyRole Field
    /// </summary>/
    public sealed class Nested2PartyRole : IntField
    {
        public Nested2PartyRole()
            :base(Tags.Nested2PartyRole) {}
        public Nested2PartyRole(int val)
            :base(Tags.Nested2PartyRole, val) {}
    }


    /// <summary>
    /// Nested2PartySubID Field
    /// </summary>/
    public sealed class Nested2PartySubID : StringField
    {
        public Nested2PartySubID()
            :base(Tags.Nested2PartySubID) {}
        public Nested2PartySubID(string val)
            :base(Tags.Nested2PartySubID, val) {}
    }


    /// <summary>
    /// Nested2PartySubIDType Field
    /// </summary>/
    public sealed class Nested2PartySubIDType : IntField
    {
        public Nested2PartySubIDType()
            :base(Tags.Nested2PartySubIDType) {}
        public Nested2PartySubIDType(int val)
            :base(Tags.Nested2PartySubIDType, val) {}
    }


    /// <summary>
    /// Nested3PartyID Field
    /// </summary>/
    public sealed class Nested3PartyID : StringField
    {
        public Nested3PartyID()
            :base(Tags.Nested3PartyID) {}
        public Nested3PartyID(string val)
            :base(Tags.Nested3PartyID, val) {}
    }


    /// <summary>
    /// Nested3PartyIDSource Field
    /// </summary>/
    public sealed class Nested3PartyIDSource : CharField
    {
        public Nested3PartyIDSource()
            :base(Tags.Nested3PartyIDSource) {}
        public Nested3PartyIDSource(char val)
            :base(Tags.Nested3PartyIDSource, val) {}
    }


    /// <summary>
    /// Nested3PartyRole Field
    /// </summary>/
    public sealed class Nested3PartyRole : IntField
    {
        public Nested3PartyRole()
            :base(Tags.Nested3PartyRole) {}
        public Nested3PartyRole(int val)
            :base(Tags.Nested3PartyRole, val) {}
    }


    /// <summary>
    /// Nested3PartySubID Field
    /// </summary>/
    public sealed class Nested3PartySubID : StringField
    {
        public Nested3PartySubID()
            :base(Tags.Nested3PartySubID) {}
        public Nested3PartySubID(string val)
            :base(Tags.Nested3PartySubID, val) {}
    }


    /// <summary>
    /// Nested3PartySubIDType Field
    /// </summary>/
    public sealed class Nested3PartySubIDType : IntField
    {
        public Nested3PartySubIDType()
            :base(Tags.Nested3PartySubIDType) {}
        public Nested3PartySubIDType(int val)
            :base(Tags.Nested3PartySubIDType, val) {}
    }


    /// <summary>
    /// NestedPartyID Field
    /// </summary>/
    public sealed class NestedPartyID : StringField
    {
        public NestedPartyID()
            :base(Tags.NestedPartyID) {}
        public NestedPartyID(string val)
            :base(Tags.NestedPartyID, val) {}
    }


    /// <summary>
    /// NestedPartyIDSource Field
    /// </summary>/
    public sealed class NestedPartyIDSource : CharField
    {
        public NestedPartyIDSource()
            :base(Tags.NestedPartyIDSource) {}
        public NestedPartyIDSource(char val)
            :base(Tags.NestedPartyIDSource, val) {}
    }


    /// <summary>
    /// NestedPartyRole Field
    /// </summary>/
    public sealed class NestedPartyRole : IntField
    {
        public NestedPartyRole()
            :base(Tags.NestedPartyRole) {}
        public NestedPartyRole(int val)
            :base(Tags.NestedPartyRole, val) {}
    }


    /// <summary>
    /// NestedPartySubID Field
    /// </summary>/
    public sealed class NestedPartySubID : StringField
    {
        public NestedPartySubID()
            :base(Tags.NestedPartySubID) {}
        public NestedPartySubID(string val)
            :base(Tags.NestedPartySubID, val) {}
    }


    /// <summary>
    /// NestedPartySubIDType Field
    /// </summary>/
    public sealed class NestedPartySubIDType : IntField
    {
        public NestedPartySubIDType()
            :base(Tags.NestedPartySubIDType) {}
        public NestedPartySubIDType(int val)
            :base(Tags.NestedPartySubIDType, val) {}
    }


    /// <summary>
    /// NetChgPrevDay Field
    /// </summary>/
    public sealed class NetChgPrevDay : DecimalField
    {
        public NetChgPrevDay()
            :base(Tags.NetChgPrevDay) {}
        public NetChgPrevDay(Decimal val)
            :base(Tags.NetChgPrevDay, val) {}
    }


    /// <summary>
    /// NetGrossInd Field
    /// </summary>/
    public sealed class NetGrossInd : IntField
    {
        public NetGrossInd()
            :base(Tags.NetGrossInd) {}
        public NetGrossInd(int val)
            :base(Tags.NetGrossInd, val) {}
    }


    /// <summary>
    /// NetMoney Field
    /// </summary>/
    public sealed class NetMoney : DecimalField
    {
        public NetMoney()
            :base(Tags.NetMoney) {}
        public NetMoney(Decimal val)
            :base(Tags.NetMoney, val) {}
    }


    /// <summary>
    /// NetworkRequestID Field
    /// </summary>/
    public sealed class NetworkRequestID : StringField
    {
        public NetworkRequestID()
            :base(Tags.NetworkRequestID) {}
        public NetworkRequestID(string val)
            :base(Tags.NetworkRequestID, val) {}
    }


    /// <summary>
    /// NetworkRequestType Field
    /// </summary>/
    public sealed class NetworkRequestType : IntField
    {
        public NetworkRequestType()
            :base(Tags.NetworkRequestType) {}
        public NetworkRequestType(int val)
            :base(Tags.NetworkRequestType, val) {}
    }


    /// <summary>
    /// NetworkResponseID Field
    /// </summary>/
    public sealed class NetworkResponseID : StringField
    {
        public NetworkResponseID()
            :base(Tags.NetworkResponseID) {}
        public NetworkResponseID(string val)
            :base(Tags.NetworkResponseID, val) {}
    }


    /// <summary>
    /// NetworkStatusResponseType Field
    /// </summary>/
    public sealed class NetworkStatusResponseType : IntField
    {
        public NetworkStatusResponseType()
            :base(Tags.NetworkStatusResponseType) {}
        public NetworkStatusResponseType(int val)
            :base(Tags.NetworkStatusResponseType, val) {}
    }


    /// <summary>
    /// NewPassword Field
    /// </summary>/
    public sealed class NewPassword : StringField
    {
        public NewPassword()
            :base(Tags.NewPassword) {}
        public NewPassword(string val)
            :base(Tags.NewPassword, val) {}
    }


    /// <summary>
    /// NewSeqNo Field
    /// </summary>/
    public sealed class NewSeqNo : IntField
    {
        public NewSeqNo()
            :base(Tags.NewSeqNo) {}
        public NewSeqNo(int val)
            :base(Tags.NewSeqNo, val) {}
    }


    /// <summary>
    /// NextExpectedMsgSeqNum Field
    /// </summary>/
    public sealed class NextExpectedMsgSeqNum : IntField
    {
        public NextExpectedMsgSeqNum()
            :base(Tags.NextExpectedMsgSeqNum) {}
        public NextExpectedMsgSeqNum(int val)
            :base(Tags.NextExpectedMsgSeqNum, val) {}
    }


    /// <summary>
    /// NoAffectedOrders Field
    /// </summary>/
    public sealed class NoAffectedOrders : IntField
    {
        public NoAffectedOrders()
            :base(Tags.NoAffectedOrders) {}
        public NoAffectedOrders(int val)
            :base(Tags.NoAffectedOrders, val) {}
    }


    /// <summary>
    /// NoAllocs Field
    /// </summary>/
    public sealed class NoAllocs : IntField
    {
        public NoAllocs()
            :base(Tags.NoAllocs) {}
        public NoAllocs(int val)
            :base(Tags.NoAllocs, val) {}
    }


    /// <summary>
    /// NoAltMDSource Field
    /// </summary>/
    public sealed class NoAltMDSource : IntField
    {
        public NoAltMDSource()
            :base(Tags.NoAltMDSource) {}
        public NoAltMDSource(int val)
            :base(Tags.NoAltMDSource, val) {}
    }


    /// <summary>
    /// NoBidComponents Field
    /// </summary>/
    public sealed class NoBidComponents : IntField
    {
        public NoBidComponents()
            :base(Tags.NoBidComponents) {}
        public NoBidComponents(int val)
            :base(Tags.NoBidComponents, val) {}
    }


    /// <summary>
    /// NoBidDescriptors Field
    /// </summary>/
    public sealed class NoBidDescriptors : IntField
    {
        public NoBidDescriptors()
            :base(Tags.NoBidDescriptors) {}
        public NoBidDescriptors(int val)
            :base(Tags.NoBidDescriptors, val) {}
    }


    /// <summary>
    /// NoCapacities Field
    /// </summary>/
    public sealed class NoCapacities : IntField
    {
        public NoCapacities()
            :base(Tags.NoCapacities) {}
        public NoCapacities(int val)
            :base(Tags.NoCapacities, val) {}
    }


    /// <summary>
    /// NoClearingInstructions Field
    /// </summary>/
    public sealed class NoClearingInstructions : IntField
    {
        public NoClearingInstructions()
            :base(Tags.NoClearingInstructions) {}
        public NoClearingInstructions(int val)
            :base(Tags.NoClearingInstructions, val) {}
    }


    /// <summary>
    /// NoCollInquiryQualifier Field
    /// </summary>/
    public sealed class NoCollInquiryQualifier : IntField
    {
        public NoCollInquiryQualifier()
            :base(Tags.NoCollInquiryQualifier) {}
        public NoCollInquiryQualifier(int val)
            :base(Tags.NoCollInquiryQualifier, val) {}
    }


    /// <summary>
    /// NoCompIDs Field
    /// </summary>/
    public sealed class NoCompIDs : IntField
    {
        public NoCompIDs()
            :base(Tags.NoCompIDs) {}
        public NoCompIDs(int val)
            :base(Tags.NoCompIDs, val) {}
    }


    /// <summary>
    /// NoContAmts Field
    /// </summary>/
    public sealed class NoContAmts : IntField
    {
        public NoContAmts()
            :base(Tags.NoContAmts) {}
        public NoContAmts(int val)
            :base(Tags.NoContAmts, val) {}
    }


    /// <summary>
    /// NoContraBrokers Field
    /// </summary>/
    public sealed class NoContraBrokers : IntField
    {
        public NoContraBrokers()
            :base(Tags.NoContraBrokers) {}
        public NoContraBrokers(int val)
            :base(Tags.NoContraBrokers, val) {}
    }


    /// <summary>
    /// NoDates Field
    /// </summary>/
    public sealed class NoDates : IntField
    {
        public NoDates()
            :base(Tags.NoDates) {}
        public NoDates(int val)
            :base(Tags.NoDates, val) {}
    }


    /// <summary>
    /// NoDistribInsts Field
    /// </summary>/
    public sealed class NoDistribInsts : IntField
    {
        public NoDistribInsts()
            :base(Tags.NoDistribInsts) {}
        public NoDistribInsts(int val)
            :base(Tags.NoDistribInsts, val) {}
    }


    /// <summary>
    /// NoDlvyInst Field
    /// </summary>/
    public sealed class NoDlvyInst : IntField
    {
        public NoDlvyInst()
            :base(Tags.NoDlvyInst) {}
        public NoDlvyInst(int val)
            :base(Tags.NoDlvyInst, val) {}
    }


    /// <summary>
    /// NoEvents Field
    /// </summary>/
    public sealed class NoEvents : IntField
    {
        public NoEvents()
            :base(Tags.NoEvents) {}
        public NoEvents(int val)
            :base(Tags.NoEvents, val) {}
    }


    /// <summary>
    /// NoExecs Field
    /// </summary>/
    public sealed class NoExecs : IntField
    {
        public NoExecs()
            :base(Tags.NoExecs) {}
        public NoExecs(int val)
            :base(Tags.NoExecs, val) {}
    }


    /// <summary>
    /// NoHops Field
    /// </summary>/
    public sealed class NoHops : IntField
    {
        public NoHops()
            :base(Tags.NoHops) {}
        public NoHops(int val)
            :base(Tags.NoHops, val) {}
    }


    /// <summary>
    /// NoIOIQualifiers Field
    /// </summary>/
    public sealed class NoIOIQualifiers : IntField
    {
        public NoIOIQualifiers()
            :base(Tags.NoIOIQualifiers) {}
        public NoIOIQualifiers(int val)
            :base(Tags.NoIOIQualifiers, val) {}
    }


    /// <summary>
    /// NoInstrAttrib Field
    /// </summary>/
    public sealed class NoInstrAttrib : IntField
    {
        public NoInstrAttrib()
            :base(Tags.NoInstrAttrib) {}
        public NoInstrAttrib(int val)
            :base(Tags.NoInstrAttrib, val) {}
    }


    /// <summary>
    /// NoLegAllocs Field
    /// </summary>/
    public sealed class NoLegAllocs : IntField
    {
        public NoLegAllocs()
            :base(Tags.NoLegAllocs) {}
        public NoLegAllocs(int val)
            :base(Tags.NoLegAllocs, val) {}
    }


    /// <summary>
    /// NoLegSecurityAltID Field
    /// </summary>/
    public sealed class NoLegSecurityAltID : StringField
    {
        public NoLegSecurityAltID()
            :base(Tags.NoLegSecurityAltID) {}
        public NoLegSecurityAltID(string val)
            :base(Tags.NoLegSecurityAltID, val) {}
    }


    /// <summary>
    /// NoLegStipulations Field
    /// </summary>/
    public sealed class NoLegStipulations : IntField
    {
        public NoLegStipulations()
            :base(Tags.NoLegStipulations) {}
        public NoLegStipulations(int val)
            :base(Tags.NoLegStipulations, val) {}
    }


    /// <summary>
    /// NoLegs Field
    /// </summary>/
    public sealed class NoLegs : IntField
    {
        public NoLegs()
            :base(Tags.NoLegs) {}
        public NoLegs(int val)
            :base(Tags.NoLegs, val) {}
    }


    /// <summary>
    /// NoMDEntries Field
    /// </summary>/
    public sealed class NoMDEntries : IntField
    {
        public NoMDEntries()
            :base(Tags.NoMDEntries) {}
        public NoMDEntries(int val)
            :base(Tags.NoMDEntries, val) {}
    }


    /// <summary>
    /// NoMDEntryTypes Field
    /// </summary>/
    public sealed class NoMDEntryTypes : IntField
    {
        public NoMDEntryTypes()
            :base(Tags.NoMDEntryTypes) {}
        public NoMDEntryTypes(int val)
            :base(Tags.NoMDEntryTypes, val) {}
    }


    /// <summary>
    /// NoMiscFees Field
    /// </summary>/
    public sealed class NoMiscFees : IntField
    {
        public NoMiscFees()
            :base(Tags.NoMiscFees) {}
        public NoMiscFees(int val)
            :base(Tags.NoMiscFees, val) {}
    }


    /// <summary>
    /// NoMsgTypes Field
    /// </summary>/
    public sealed class NoMsgTypes : IntField
    {
        public NoMsgTypes()
            :base(Tags.NoMsgTypes) {}
        public NoMsgTypes(int val)
            :base(Tags.NoMsgTypes, val) {}
    }


    /// <summary>
    /// NoNested2PartyIDs Field
    /// </summary>/
    public sealed class NoNested2PartyIDs : IntField
    {
        public NoNested2PartyIDs()
            :base(Tags.NoNested2PartyIDs) {}
        public NoNested2PartyIDs(int val)
            :base(Tags.NoNested2PartyIDs, val) {}
    }


    /// <summary>
    /// NoNested2PartySubIDs Field
    /// </summary>/
    public sealed class NoNested2PartySubIDs : IntField
    {
        public NoNested2PartySubIDs()
            :base(Tags.NoNested2PartySubIDs) {}
        public NoNested2PartySubIDs(int val)
            :base(Tags.NoNested2PartySubIDs, val) {}
    }


    /// <summary>
    /// NoNested3PartyIDs Field
    /// </summary>/
    public sealed class NoNested3PartyIDs : IntField
    {
        public NoNested3PartyIDs()
            :base(Tags.NoNested3PartyIDs) {}
        public NoNested3PartyIDs(int val)
            :base(Tags.NoNested3PartyIDs, val) {}
    }


    /// <summary>
    /// NoNested3PartySubIDs Field
    /// </summary>/
    public sealed class NoNested3PartySubIDs : IntField
    {
        public NoNested3PartySubIDs()
            :base(Tags.NoNested3PartySubIDs) {}
        public NoNested3PartySubIDs(int val)
            :base(Tags.NoNested3PartySubIDs, val) {}
    }


    /// <summary>
    /// NoNestedPartyIDs Field
    /// </summary>/
    public sealed class NoNestedPartyIDs : IntField
    {
        public NoNestedPartyIDs()
            :base(Tags.NoNestedPartyIDs) {}
        public NoNestedPartyIDs(int val)
            :base(Tags.NoNestedPartyIDs, val) {}
    }


    /// <summary>
    /// NoNestedPartySubIDs Field
    /// </summary>/
    public sealed class NoNestedPartySubIDs : IntField
    {
        public NoNestedPartySubIDs()
            :base(Tags.NoNestedPartySubIDs) {}
        public NoNestedPartySubIDs(int val)
            :base(Tags.NoNestedPartySubIDs, val) {}
    }


    /// <summary>
    /// NoOrders Field
    /// </summary>/
    public sealed class NoOrders : IntField
    {
        public NoOrders()
            :base(Tags.NoOrders) {}
        public NoOrders(int val)
            :base(Tags.NoOrders, val) {}
    }


    /// <summary>
    /// NoPartyIDs Field
    /// </summary>/
    public sealed class NoPartyIDs : IntField
    {
        public NoPartyIDs()
            :base(Tags.NoPartyIDs) {}
        public NoPartyIDs(int val)
            :base(Tags.NoPartyIDs, val) {}
    }


    /// <summary>
    /// NoPartySubIDs Field
    /// </summary>/
    public sealed class NoPartySubIDs : IntField
    {
        public NoPartySubIDs()
            :base(Tags.NoPartySubIDs) {}
        public NoPartySubIDs(int val)
            :base(Tags.NoPartySubIDs, val) {}
    }


    /// <summary>
    /// NoPosAmt Field
    /// </summary>/
    public sealed class NoPosAmt : IntField
    {
        public NoPosAmt()
            :base(Tags.NoPosAmt) {}
        public NoPosAmt(int val)
            :base(Tags.NoPosAmt, val) {}
    }


    /// <summary>
    /// NoPositions Field
    /// </summary>/
    public sealed class NoPositions : IntField
    {
        public NoPositions()
            :base(Tags.NoPositions) {}
        public NoPositions(int val)
            :base(Tags.NoPositions, val) {}
    }


    /// <summary>
    /// NoQuoteEntries Field
    /// </summary>/
    public sealed class NoQuoteEntries : IntField
    {
        public NoQuoteEntries()
            :base(Tags.NoQuoteEntries) {}
        public NoQuoteEntries(int val)
            :base(Tags.NoQuoteEntries, val) {}
    }


    /// <summary>
    /// NoQuoteQualifiers Field
    /// </summary>/
    public sealed class NoQuoteQualifiers : IntField
    {
        public NoQuoteQualifiers()
            :base(Tags.NoQuoteQualifiers) {}
        public NoQuoteQualifiers(int val)
            :base(Tags.NoQuoteQualifiers, val) {}
    }


    /// <summary>
    /// NoQuoteSets Field
    /// </summary>/
    public sealed class NoQuoteSets : IntField
    {
        public NoQuoteSets()
            :base(Tags.NoQuoteSets) {}
        public NoQuoteSets(int val)
            :base(Tags.NoQuoteSets, val) {}
    }


    /// <summary>
    /// NoRegistDtls Field
    /// </summary>/
    public sealed class NoRegistDtls : IntField
    {
        public NoRegistDtls()
            :base(Tags.NoRegistDtls) {}
        public NoRegistDtls(int val)
            :base(Tags.NoRegistDtls, val) {}
    }


    /// <summary>
    /// NoRelatedSym Field
    /// </summary>/
    public sealed class NoRelatedSym : IntField
    {
        public NoRelatedSym()
            :base(Tags.NoRelatedSym) {}
        public NoRelatedSym(int val)
            :base(Tags.NoRelatedSym, val) {}
    }


    /// <summary>
    /// NoRoutingIDs Field
    /// </summary>/
    public sealed class NoRoutingIDs : IntField
    {
        public NoRoutingIDs()
            :base(Tags.NoRoutingIDs) {}
        public NoRoutingIDs(int val)
            :base(Tags.NoRoutingIDs, val) {}
    }


    /// <summary>
    /// NoRpts Field
    /// </summary>/
    public sealed class NoRpts : IntField
    {
        public NoRpts()
            :base(Tags.NoRpts) {}
        public NoRpts(int val)
            :base(Tags.NoRpts, val) {}
    }


    /// <summary>
    /// NoSecurityAltID Field
    /// </summary>/
    public sealed class NoSecurityAltID : IntField
    {
        public NoSecurityAltID()
            :base(Tags.NoSecurityAltID) {}
        public NoSecurityAltID(int val)
            :base(Tags.NoSecurityAltID, val) {}
    }


    /// <summary>
    /// NoSecurityTypes Field
    /// </summary>/
    public sealed class NoSecurityTypes : IntField
    {
        public NoSecurityTypes()
            :base(Tags.NoSecurityTypes) {}
        public NoSecurityTypes(int val)
            :base(Tags.NoSecurityTypes, val) {}
    }


    /// <summary>
    /// NoSettlInst Field
    /// </summary>/
    public sealed class NoSettlInst : IntField
    {
        public NoSettlInst()
            :base(Tags.NoSettlInst) {}
        public NoSettlInst(int val)
            :base(Tags.NoSettlInst, val) {}
    }


    /// <summary>
    /// NoSettlPartyIDs Field
    /// </summary>/
    public sealed class NoSettlPartyIDs : IntField
    {
        public NoSettlPartyIDs()
            :base(Tags.NoSettlPartyIDs) {}
        public NoSettlPartyIDs(int val)
            :base(Tags.NoSettlPartyIDs, val) {}
    }


    /// <summary>
    /// NoSettlPartySubIDs Field
    /// </summary>/
    public sealed class NoSettlPartySubIDs : IntField
    {
        public NoSettlPartySubIDs()
            :base(Tags.NoSettlPartySubIDs) {}
        public NoSettlPartySubIDs(int val)
            :base(Tags.NoSettlPartySubIDs, val) {}
    }


    /// <summary>
    /// NoSides Field
    /// </summary>/
    public sealed class NoSides : IntField
    {
        public NoSides()
            :base(Tags.NoSides) {}
        public NoSides(int val)
            :base(Tags.NoSides, val) {}
    }


    /// <summary>
    /// NoStipulations Field
    /// </summary>/
    public sealed class NoStipulations : IntField
    {
        public NoStipulations()
            :base(Tags.NoStipulations) {}
        public NoStipulations(int val)
            :base(Tags.NoStipulations, val) {}
    }


    /// <summary>
    /// NoStrikes Field
    /// </summary>/
    public sealed class NoStrikes : IntField
    {
        public NoStrikes()
            :base(Tags.NoStrikes) {}
        public NoStrikes(int val)
            :base(Tags.NoStrikes, val) {}
    }


    /// <summary>
    /// NoTrades Field
    /// </summary>/
    public sealed class NoTrades : IntField
    {
        public NoTrades()
            :base(Tags.NoTrades) {}
        public NoTrades(int val)
            :base(Tags.NoTrades, val) {}
    }


    /// <summary>
    /// NoTradingSessions Field
    /// </summary>/
    public sealed class NoTradingSessions : IntField
    {
        public NoTradingSessions()
            :base(Tags.NoTradingSessions) {}
        public NoTradingSessions(int val)
            :base(Tags.NoTradingSessions, val) {}
    }


    /// <summary>
    /// NoTrdRegTimestamps Field
    /// </summary>/
    public sealed class NoTrdRegTimestamps : IntField
    {
        public NoTrdRegTimestamps()
            :base(Tags.NoTrdRegTimestamps) {}
        public NoTrdRegTimestamps(int val)
            :base(Tags.NoTrdRegTimestamps, val) {}
    }


    /// <summary>
    /// NoUnderlyingSecurityAltID Field
    /// </summary>/
    public sealed class NoUnderlyingSecurityAltID : IntField
    {
        public NoUnderlyingSecurityAltID()
            :base(Tags.NoUnderlyingSecurityAltID) {}
        public NoUnderlyingSecurityAltID(int val)
            :base(Tags.NoUnderlyingSecurityAltID, val) {}
    }


    /// <summary>
    /// NoUnderlyingStips Field
    /// </summary>/
    public sealed class NoUnderlyingStips : IntField
    {
        public NoUnderlyingStips()
            :base(Tags.NoUnderlyingStips) {}
        public NoUnderlyingStips(int val)
            :base(Tags.NoUnderlyingStips, val) {}
    }


    /// <summary>
    /// NoUnderlyings Field
    /// </summary>/
    public sealed class NoUnderlyings : IntField
    {
        public NoUnderlyings()
            :base(Tags.NoUnderlyings) {}
        public NoUnderlyings(int val)
            :base(Tags.NoUnderlyings, val) {}
    }


    /// <summary>
    /// NotifyBrokerOfCredit Field
    /// </summary>/
    public sealed class NotifyBrokerOfCredit : BooleanField
    {
        public NotifyBrokerOfCredit()
            :base(Tags.NotifyBrokerOfCredit) {}
        public NotifyBrokerOfCredit(Boolean val)
            :base(Tags.NotifyBrokerOfCredit, val) {}
    }


    /// <summary>
    /// NumBidders Field
    /// </summary>/
    public sealed class NumBidders : IntField
    {
        public NumBidders()
            :base(Tags.NumBidders) {}
        public NumBidders(int val)
            :base(Tags.NumBidders, val) {}
    }


    /// <summary>
    /// NumDaysInterest Field
    /// </summary>/
    public sealed class NumDaysInterest : IntField
    {
        public NumDaysInterest()
            :base(Tags.NumDaysInterest) {}
        public NumDaysInterest(int val)
            :base(Tags.NumDaysInterest, val) {}
    }


    /// <summary>
    /// NumTickets Field
    /// </summary>/
    public sealed class NumTickets : IntField
    {
        public NumTickets()
            :base(Tags.NumTickets) {}
        public NumTickets(int val)
            :base(Tags.NumTickets, val) {}
    }


    /// <summary>
    /// NumberOfOrders Field
    /// </summary>/
    public sealed class NumberOfOrders : IntField
    {
        public NumberOfOrders()
            :base(Tags.NumberOfOrders) {}
        public NumberOfOrders(int val)
            :base(Tags.NumberOfOrders, val) {}
    }


    /// <summary>
    /// OddLot Field
    /// </summary>/
    public sealed class OddLot : BooleanField
    {
        public OddLot()
            :base(Tags.OddLot) {}
        public OddLot(Boolean val)
            :base(Tags.OddLot, val) {}
    }


    /// <summary>
    /// OfferForwardPoints Field
    /// </summary>/
    public sealed class OfferForwardPoints : DecimalField
    {
        public OfferForwardPoints()
            :base(Tags.OfferForwardPoints) {}
        public OfferForwardPoints(Decimal val)
            :base(Tags.OfferForwardPoints, val) {}
    }


    /// <summary>
    /// OfferForwardPoints2 Field
    /// </summary>/
    public sealed class OfferForwardPoints2 : DecimalField
    {
        public OfferForwardPoints2()
            :base(Tags.OfferForwardPoints2) {}
        public OfferForwardPoints2(Decimal val)
            :base(Tags.OfferForwardPoints2, val) {}
    }


    /// <summary>
    /// OfferPx Field
    /// </summary>/
    public sealed class OfferPx : DecimalField
    {
        public OfferPx()
            :base(Tags.OfferPx) {}
        public OfferPx(Decimal val)
            :base(Tags.OfferPx, val) {}
    }


    /// <summary>
    /// OfferSize Field
    /// </summary>/
    public sealed class OfferSize : DecimalField
    {
        public OfferSize()
            :base(Tags.OfferSize) {}
        public OfferSize(Decimal val)
            :base(Tags.OfferSize, val) {}
    }


    /// <summary>
    /// OfferSpotRate Field
    /// </summary>/
    public sealed class OfferSpotRate : DecimalField
    {
        public OfferSpotRate()
            :base(Tags.OfferSpotRate) {}
        public OfferSpotRate(Decimal val)
            :base(Tags.OfferSpotRate, val) {}
    }


    /// <summary>
    /// OfferYield Field
    /// </summary>/
    public sealed class OfferYield : DecimalField
    {
        public OfferYield()
            :base(Tags.OfferYield) {}
        public OfferYield(Decimal val)
            :base(Tags.OfferYield, val) {}
    }


    /// <summary>
    /// OnBehalfOfCompID Field
    /// </summary>/
    public sealed class OnBehalfOfCompID : StringField
    {
        public OnBehalfOfCompID()
            :base(Tags.OnBehalfOfCompID) {}
        public OnBehalfOfCompID(string val)
            :base(Tags.OnBehalfOfCompID, val) {}
    }


    /// <summary>
    /// OnBehalfOfLocationID Field
    /// </summary>/
    public sealed class OnBehalfOfLocationID : StringField
    {
        public OnBehalfOfLocationID()
            :base(Tags.OnBehalfOfLocationID) {}
        public OnBehalfOfLocationID(string val)
            :base(Tags.OnBehalfOfLocationID, val) {}
    }


    /// <summary>
    /// OnBehalfOfSubID Field
    /// </summary>/
    public sealed class OnBehalfOfSubID : StringField
    {
        public OnBehalfOfSubID()
            :base(Tags.OnBehalfOfSubID) {}
        public OnBehalfOfSubID(string val)
            :base(Tags.OnBehalfOfSubID, val) {}
    }


    /// <summary>
    /// OpenCloseSettlFlag Field
    /// </summary>/
    public sealed class OpenCloseSettlFlag : StringField
    {
        public OpenCloseSettlFlag()
            :base(Tags.OpenCloseSettlFlag) {}
        public OpenCloseSettlFlag(string val)
            :base(Tags.OpenCloseSettlFlag, val) {}
    }


    /// <summary>
    /// OpenInterest Field
    /// </summary>/
    public sealed class OpenInterest : DecimalField
    {
        public OpenInterest()
            :base(Tags.OpenInterest) {}
        public OpenInterest(Decimal val)
            :base(Tags.OpenInterest, val) {}
    }


    /// <summary>
    /// OptAttribute Field
    /// </summary>/
    public sealed class OptAttribute : CharField
    {
        public OptAttribute()
            :base(Tags.OptAttribute) {}
        public OptAttribute(char val)
            :base(Tags.OptAttribute, val) {}
    }


    /// <summary>
    /// OrdRejReason Field
    /// </summary>/
    public sealed class OrdRejReason : IntField
    {
        public OrdRejReason()
            :base(Tags.OrdRejReason) {}
        public OrdRejReason(int val)
            :base(Tags.OrdRejReason, val) {}
    }


    /// <summary>
    /// OrdStatus Field
    /// </summary>/
    public sealed class OrdStatus : CharField
    {
        public OrdStatus()
            :base(Tags.OrdStatus) {}
        public OrdStatus(char val)
            :base(Tags.OrdStatus, val) {}
    }


    /// <summary>
    /// OrdStatusReqID Field
    /// </summary>/
    public sealed class OrdStatusReqID : StringField
    {
        public OrdStatusReqID()
            :base(Tags.OrdStatusReqID) {}
        public OrdStatusReqID(string val)
            :base(Tags.OrdStatusReqID, val) {}
    }


    /// <summary>
    /// OrdType Field
    /// </summary>/
    public sealed class OrdType : CharField
    {
        public OrdType()
            :base(Tags.OrdType) {}
        public OrdType(char val)
            :base(Tags.OrdType, val) {}
    }


    /// <summary>
    /// OrderAvgPx Field
    /// </summary>/
    public sealed class OrderAvgPx : DecimalField
    {
        public OrderAvgPx()
            :base(Tags.OrderAvgPx) {}
        public OrderAvgPx(Decimal val)
            :base(Tags.OrderAvgPx, val) {}
    }


    /// <summary>
    /// OrderBookingQty Field
    /// </summary>/
    public sealed class OrderBookingQty : DecimalField
    {
        public OrderBookingQty()
            :base(Tags.OrderBookingQty) {}
        public OrderBookingQty(Decimal val)
            :base(Tags.OrderBookingQty, val) {}
    }


    /// <summary>
    /// OrderCapacity Field
    /// </summary>/
    public sealed class OrderCapacity : CharField
    {
        public OrderCapacity()
            :base(Tags.OrderCapacity) {}
        public OrderCapacity(char val)
            :base(Tags.OrderCapacity, val) {}
    }


    /// <summary>
    /// OrderCapacityQty Field
    /// </summary>/
    public sealed class OrderCapacityQty : DecimalField
    {
        public OrderCapacityQty()
            :base(Tags.OrderCapacityQty) {}
        public OrderCapacityQty(Decimal val)
            :base(Tags.OrderCapacityQty, val) {}
    }


    /// <summary>
    /// OrderID Field
    /// </summary>/
    public sealed class OrderID : StringField
    {
        public OrderID()
            :base(Tags.OrderID) {}
        public OrderID(string val)
            :base(Tags.OrderID, val) {}
    }


    /// <summary>
    /// OrderInputDevice Field
    /// </summary>/
    public sealed class OrderInputDevice : StringField
    {
        public OrderInputDevice()
            :base(Tags.OrderInputDevice) {}
        public OrderInputDevice(string val)
            :base(Tags.OrderInputDevice, val) {}
    }


    /// <summary>
    /// OrderPercent Field
    /// </summary>/
    public sealed class OrderPercent : DecimalField
    {
        public OrderPercent()
            :base(Tags.OrderPercent) {}
        public OrderPercent(Decimal val)
            :base(Tags.OrderPercent, val) {}
    }


    /// <summary>
    /// OrderQty Field
    /// </summary>/
    public sealed class OrderQty : DecimalField
    {
        public OrderQty()
            :base(Tags.OrderQty) {}
        public OrderQty(Decimal val)
            :base(Tags.OrderQty, val) {}
    }


    /// <summary>
    /// OrderQty2 Field
    /// </summary>/
    public sealed class OrderQty2 : DecimalField
    {
        public OrderQty2()
            :base(Tags.OrderQty2) {}
        public OrderQty2(Decimal val)
            :base(Tags.OrderQty2, val) {}
    }


    /// <summary>
    /// OrderRestrictions Field
    /// </summary>/
    public sealed class OrderRestrictions : StringField
    {
        public OrderRestrictions()
            :base(Tags.OrderRestrictions) {}
        public OrderRestrictions(string val)
            :base(Tags.OrderRestrictions, val) {}
    }


    /// <summary>
    /// OrigClOrdID Field
    /// </summary>/
    public sealed class OrigClOrdID : StringField
    {
        public OrigClOrdID()
            :base(Tags.OrigClOrdID) {}
        public OrigClOrdID(string val)
            :base(Tags.OrigClOrdID, val) {}
    }


    /// <summary>
    /// OrigCrossID Field
    /// </summary>/
    public sealed class OrigCrossID : StringField
    {
        public OrigCrossID()
            :base(Tags.OrigCrossID) {}
        public OrigCrossID(string val)
            :base(Tags.OrigCrossID, val) {}
    }


    /// <summary>
    /// OrigOrdModTime Field
    /// </summary>/
    public sealed class OrigOrdModTime : DateTimeField
    {
        public OrigOrdModTime()
            :base(Tags.OrigOrdModTime) {}
        public OrigOrdModTime(DateTime val)
            :base(Tags.OrigOrdModTime, val) {}
    }


    /// <summary>
    /// OrigPosReqRefID Field
    /// </summary>/
    public sealed class OrigPosReqRefID : StringField
    {
        public OrigPosReqRefID()
            :base(Tags.OrigPosReqRefID) {}
        public OrigPosReqRefID(string val)
            :base(Tags.OrigPosReqRefID, val) {}
    }


    /// <summary>
    /// OrigSendingTime Field
    /// </summary>/
    public sealed class OrigSendingTime : DateTimeField
    {
        public OrigSendingTime()
            :base(Tags.OrigSendingTime) {}
        public OrigSendingTime(DateTime val)
            :base(Tags.OrigSendingTime, val) {}
    }


    /// <summary>
    /// OrigTime Field
    /// </summary>/
    public sealed class OrigTime : DateTimeField
    {
        public OrigTime()
            :base(Tags.OrigTime) {}
        public OrigTime(DateTime val)
            :base(Tags.OrigTime, val) {}
    }


    /// <summary>
    /// OutMainCntryUIndex Field
    /// </summary>/
    public sealed class OutMainCntryUIndex : DecimalField
    {
        public OutMainCntryUIndex()
            :base(Tags.OutMainCntryUIndex) {}
        public OutMainCntryUIndex(Decimal val)
            :base(Tags.OutMainCntryUIndex, val) {}
    }


    /// <summary>
    /// OutsideIndexPct Field
    /// </summary>/
    public sealed class OutsideIndexPct : DecimalField
    {
        public OutsideIndexPct()
            :base(Tags.OutsideIndexPct) {}
        public OutsideIndexPct(Decimal val)
            :base(Tags.OutsideIndexPct, val) {}
    }


    /// <summary>
    /// OwnerType Field
    /// </summary>/
    public sealed class OwnerType : IntField
    {
        public OwnerType()
            :base(Tags.OwnerType) {}
        public OwnerType(int val)
            :base(Tags.OwnerType, val) {}
    }


    /// <summary>
    /// OwnershipType Field
    /// </summary>/
    public sealed class OwnershipType : CharField
    {
        public OwnershipType()
            :base(Tags.OwnershipType) {}
        public OwnershipType(char val)
            :base(Tags.OwnershipType, val) {}
    }


    /// <summary>
    /// ParticipationRate Field
    /// </summary>/
    public sealed class ParticipationRate : DecimalField
    {
        public ParticipationRate()
            :base(Tags.ParticipationRate) {}
        public ParticipationRate(Decimal val)
            :base(Tags.ParticipationRate, val) {}
    }


    /// <summary>
    /// PartyID Field
    /// </summary>/
    public sealed class PartyID : StringField
    {
        public PartyID()
            :base(Tags.PartyID) {}
        public PartyID(string val)
            :base(Tags.PartyID, val) {}
    }


    /// <summary>
    /// PartyIDSource Field
    /// </summary>/
    public sealed class PartyIDSource : CharField
    {
        public PartyIDSource()
            :base(Tags.PartyIDSource) {}
        public PartyIDSource(char val)
            :base(Tags.PartyIDSource, val) {}
    }


    /// <summary>
    /// PartyRole Field
    /// </summary>/
    public sealed class PartyRole : IntField
    {
        public PartyRole()
            :base(Tags.PartyRole) {}
        public PartyRole(int val)
            :base(Tags.PartyRole, val) {}
    }


    /// <summary>
    /// PartySubID Field
    /// </summary>/
    public sealed class PartySubID : StringField
    {
        public PartySubID()
            :base(Tags.PartySubID) {}
        public PartySubID(string val)
            :base(Tags.PartySubID, val) {}
    }


    /// <summary>
    /// PartySubIDType Field
    /// </summary>/
    public sealed class PartySubIDType : IntField
    {
        public PartySubIDType()
            :base(Tags.PartySubIDType) {}
        public PartySubIDType(int val)
            :base(Tags.PartySubIDType, val) {}
    }


    /// <summary>
    /// Password Field
    /// </summary>/
    public sealed class Password : StringField
    {
        public Password()
            :base(Tags.Password) {}
        public Password(string val)
            :base(Tags.Password, val) {}
    }


    /// <summary>
    /// PaymentDate Field
    /// </summary>/
    public sealed class PaymentDate : DateTimeField
    {
        public PaymentDate()
            :base(Tags.PaymentDate) {}
        public PaymentDate(DateTime val)
            :base(Tags.PaymentDate, val) {}
    }


    /// <summary>
    /// PaymentMethod Field
    /// </summary>/
    public sealed class PaymentMethod : IntField
    {
        public PaymentMethod()
            :base(Tags.PaymentMethod) {}
        public PaymentMethod(int val)
            :base(Tags.PaymentMethod, val) {}
    }


    /// <summary>
    /// PaymentRef Field
    /// </summary>/
    public sealed class PaymentRef : StringField
    {
        public PaymentRef()
            :base(Tags.PaymentRef) {}
        public PaymentRef(string val)
            :base(Tags.PaymentRef, val) {}
    }


    /// <summary>
    /// PaymentRemitterID Field
    /// </summary>/
    public sealed class PaymentRemitterID : StringField
    {
        public PaymentRemitterID()
            :base(Tags.PaymentRemitterID) {}
        public PaymentRemitterID(string val)
            :base(Tags.PaymentRemitterID, val) {}
    }


    /// <summary>
    /// PctAtRisk Field
    /// </summary>/
    public sealed class PctAtRisk : DecimalField
    {
        public PctAtRisk()
            :base(Tags.PctAtRisk) {}
        public PctAtRisk(Decimal val)
            :base(Tags.PctAtRisk, val) {}
    }


    /// <summary>
    /// PegLimitType Field
    /// </summary>/
    public sealed class PegLimitType : IntField
    {
        public PegLimitType()
            :base(Tags.PegLimitType) {}
        public PegLimitType(int val)
            :base(Tags.PegLimitType, val) {}
    }


    /// <summary>
    /// PegMoveType Field
    /// </summary>/
    public sealed class PegMoveType : IntField
    {
        public PegMoveType()
            :base(Tags.PegMoveType) {}
        public PegMoveType(int val)
            :base(Tags.PegMoveType, val) {}
    }


    /// <summary>
    /// PegOffsetType Field
    /// </summary>/
    public sealed class PegOffsetType : IntField
    {
        public PegOffsetType()
            :base(Tags.PegOffsetType) {}
        public PegOffsetType(int val)
            :base(Tags.PegOffsetType, val) {}
    }


    /// <summary>
    /// PegOffsetValue Field
    /// </summary>/
    public sealed class PegOffsetValue : DecimalField
    {
        public PegOffsetValue()
            :base(Tags.PegOffsetValue) {}
        public PegOffsetValue(Decimal val)
            :base(Tags.PegOffsetValue, val) {}
    }


    /// <summary>
    /// PegRoundDirection Field
    /// </summary>/
    public sealed class PegRoundDirection : IntField
    {
        public PegRoundDirection()
            :base(Tags.PegRoundDirection) {}
        public PegRoundDirection(int val)
            :base(Tags.PegRoundDirection, val) {}
    }


    /// <summary>
    /// PegScope Field
    /// </summary>/
    public sealed class PegScope : IntField
    {
        public PegScope()
            :base(Tags.PegScope) {}
        public PegScope(int val)
            :base(Tags.PegScope, val) {}
    }


    /// <summary>
    /// PeggedPrice Field
    /// </summary>/
    public sealed class PeggedPrice : DecimalField
    {
        public PeggedPrice()
            :base(Tags.PeggedPrice) {}
        public PeggedPrice(Decimal val)
            :base(Tags.PeggedPrice, val) {}
    }


    /// <summary>
    /// Pool Field
    /// </summary>/
    public sealed class Pool : StringField
    {
        public Pool()
            :base(Tags.Pool) {}
        public Pool(string val)
            :base(Tags.Pool, val) {}
    }


    /// <summary>
    /// PosAmt Field
    /// </summary>/
    public sealed class PosAmt : DecimalField
    {
        public PosAmt()
            :base(Tags.PosAmt) {}
        public PosAmt(Decimal val)
            :base(Tags.PosAmt, val) {}
    }


    /// <summary>
    /// PosAmtType Field
    /// </summary>/
    public sealed class PosAmtType : StringField
    {
        public PosAmtType()
            :base(Tags.PosAmtType) {}
        public PosAmtType(string val)
            :base(Tags.PosAmtType, val) {}
    }


    /// <summary>
    /// PosMaintAction Field
    /// </summary>/
    public sealed class PosMaintAction : IntField
    {
        public PosMaintAction()
            :base(Tags.PosMaintAction) {}
        public PosMaintAction(int val)
            :base(Tags.PosMaintAction, val) {}
    }


    /// <summary>
    /// PosMaintResult Field
    /// </summary>/
    public sealed class PosMaintResult : IntField
    {
        public PosMaintResult()
            :base(Tags.PosMaintResult) {}
        public PosMaintResult(int val)
            :base(Tags.PosMaintResult, val) {}
    }


    /// <summary>
    /// PosMaintRptID Field
    /// </summary>/
    public sealed class PosMaintRptID : StringField
    {
        public PosMaintRptID()
            :base(Tags.PosMaintRptID) {}
        public PosMaintRptID(string val)
            :base(Tags.PosMaintRptID, val) {}
    }


    /// <summary>
    /// PosMaintRptRefID Field
    /// </summary>/
    public sealed class PosMaintRptRefID : StringField
    {
        public PosMaintRptRefID()
            :base(Tags.PosMaintRptRefID) {}
        public PosMaintRptRefID(string val)
            :base(Tags.PosMaintRptRefID, val) {}
    }


    /// <summary>
    /// PosMaintStatus Field
    /// </summary>/
    public sealed class PosMaintStatus : IntField
    {
        public PosMaintStatus()
            :base(Tags.PosMaintStatus) {}
        public PosMaintStatus(int val)
            :base(Tags.PosMaintStatus, val) {}
    }


    /// <summary>
    /// PosQtyStatus Field
    /// </summary>/
    public sealed class PosQtyStatus : IntField
    {
        public PosQtyStatus()
            :base(Tags.PosQtyStatus) {}
        public PosQtyStatus(int val)
            :base(Tags.PosQtyStatus, val) {}
    }


    /// <summary>
    /// PosReqID Field
    /// </summary>/
    public sealed class PosReqID : StringField
    {
        public PosReqID()
            :base(Tags.PosReqID) {}
        public PosReqID(string val)
            :base(Tags.PosReqID, val) {}
    }


    /// <summary>
    /// PosReqResult Field
    /// </summary>/
    public sealed class PosReqResult : IntField
    {
        public PosReqResult()
            :base(Tags.PosReqResult) {}
        public PosReqResult(int val)
            :base(Tags.PosReqResult, val) {}
    }


    /// <summary>
    /// PosReqStatus Field
    /// </summary>/
    public sealed class PosReqStatus : IntField
    {
        public PosReqStatus()
            :base(Tags.PosReqStatus) {}
        public PosReqStatus(int val)
            :base(Tags.PosReqStatus, val) {}
    }


    /// <summary>
    /// PosReqType Field
    /// </summary>/
    public sealed class PosReqType : IntField
    {
        public PosReqType()
            :base(Tags.PosReqType) {}
        public PosReqType(int val)
            :base(Tags.PosReqType, val) {}
    }


    /// <summary>
    /// PosTransType Field
    /// </summary>/
    public sealed class PosTransType : IntField
    {
        public PosTransType()
            :base(Tags.PosTransType) {}
        public PosTransType(int val)
            :base(Tags.PosTransType, val) {}
    }


    /// <summary>
    /// PosType Field
    /// </summary>/
    public sealed class PosType : StringField
    {
        public PosType()
            :base(Tags.PosType) {}
        public PosType(string val)
            :base(Tags.PosType, val) {}
    }


    /// <summary>
    /// PositionEffect Field
    /// </summary>/
    public sealed class PositionEffect : CharField
    {
        public PositionEffect()
            :base(Tags.PositionEffect) {}
        public PositionEffect(char val)
            :base(Tags.PositionEffect, val) {}
    }


    /// <summary>
    /// PossDupFlag Field
    /// </summary>/
    public sealed class PossDupFlag : BooleanField
    {
        public PossDupFlag()
            :base(Tags.PossDupFlag) {}
        public PossDupFlag(Boolean val)
            :base(Tags.PossDupFlag, val) {}
    }


    /// <summary>
    /// PossResend Field
    /// </summary>/
    public sealed class PossResend : BooleanField
    {
        public PossResend()
            :base(Tags.PossResend) {}
        public PossResend(Boolean val)
            :base(Tags.PossResend, val) {}
    }


    /// <summary>
    /// PreallocMethod Field
    /// </summary>/
    public sealed class PreallocMethod : CharField
    {
        public PreallocMethod()
            :base(Tags.PreallocMethod) {}
        public PreallocMethod(char val)
            :base(Tags.PreallocMethod, val) {}
    }


    /// <summary>
    /// PrevClosePx Field
    /// </summary>/
    public sealed class PrevClosePx : DecimalField
    {
        public PrevClosePx()
            :base(Tags.PrevClosePx) {}
        public PrevClosePx(Decimal val)
            :base(Tags.PrevClosePx, val) {}
    }


    /// <summary>
    /// PreviouslyReported Field
    /// </summary>/
    public sealed class PreviouslyReported : BooleanField
    {
        public PreviouslyReported()
            :base(Tags.PreviouslyReported) {}
        public PreviouslyReported(Boolean val)
            :base(Tags.PreviouslyReported, val) {}
    }


    /// <summary>
    /// Price Field
    /// </summary>/
    public sealed class Price : DecimalField
    {
        public Price()
            :base(Tags.Price) {}
        public Price(Decimal val)
            :base(Tags.Price, val) {}
    }


    /// <summary>
    /// Price2 Field
    /// </summary>/
    public sealed class Price2 : DecimalField
    {
        public Price2()
            :base(Tags.Price2) {}
        public Price2(Decimal val)
            :base(Tags.Price2, val) {}
    }


    /// <summary>
    /// PriceDelta Field
    /// </summary>/
    public sealed class PriceDelta : DecimalField
    {
        public PriceDelta()
            :base(Tags.PriceDelta) {}
        public PriceDelta(Decimal val)
            :base(Tags.PriceDelta, val) {}
    }


    /// <summary>
    /// PriceImprovement Field
    /// </summary>/
    public sealed class PriceImprovement : DecimalField
    {
        public PriceImprovement()
            :base(Tags.PriceImprovement) {}
        public PriceImprovement(Decimal val)
            :base(Tags.PriceImprovement, val) {}
    }


    /// <summary>
    /// PriceType Field
    /// </summary>/
    public sealed class PriceType : IntField
    {
        public PriceType()
            :base(Tags.PriceType) {}
        public PriceType(int val)
            :base(Tags.PriceType, val) {}
    }


    /// <summary>
    /// PriorSettlPrice Field
    /// </summary>/
    public sealed class PriorSettlPrice : DecimalField
    {
        public PriorSettlPrice()
            :base(Tags.PriorSettlPrice) {}
        public PriorSettlPrice(Decimal val)
            :base(Tags.PriorSettlPrice, val) {}
    }


    /// <summary>
    /// PriorSpreadIndicator Field
    /// </summary>/
    public sealed class PriorSpreadIndicator : BooleanField
    {
        public PriorSpreadIndicator()
            :base(Tags.PriorSpreadIndicator) {}
        public PriorSpreadIndicator(Boolean val)
            :base(Tags.PriorSpreadIndicator, val) {}
    }


    /// <summary>
    /// PriorityIndicator Field
    /// </summary>/
    public sealed class PriorityIndicator : IntField
    {
        public PriorityIndicator()
            :base(Tags.PriorityIndicator) {}
        public PriorityIndicator(int val)
            :base(Tags.PriorityIndicator, val) {}
    }


    /// <summary>
    /// ProcessCode Field
    /// </summary>/
    public sealed class ProcessCode : CharField
    {
        public ProcessCode()
            :base(Tags.ProcessCode) {}
        public ProcessCode(char val)
            :base(Tags.ProcessCode, val) {}
    }


    /// <summary>
    /// Product Field
    /// </summary>/
    public sealed class Product : IntField
    {
        public Product()
            :base(Tags.Product) {}
        public Product(int val)
            :base(Tags.Product, val) {}
    }


    /// <summary>
    /// ProgPeriodInterval Field
    /// </summary>/
    public sealed class ProgPeriodInterval : IntField
    {
        public ProgPeriodInterval()
            :base(Tags.ProgPeriodInterval) {}
        public ProgPeriodInterval(int val)
            :base(Tags.ProgPeriodInterval, val) {}
    }


    /// <summary>
    /// ProgRptReqs Field
    /// </summary>/
    public sealed class ProgRptReqs : IntField
    {
        public ProgRptReqs()
            :base(Tags.ProgRptReqs) {}
        public ProgRptReqs(int val)
            :base(Tags.ProgRptReqs, val) {}
    }


    /// <summary>
    /// PublishTrdIndicator Field
    /// </summary>/
    public sealed class PublishTrdIndicator : BooleanField
    {
        public PublishTrdIndicator()
            :base(Tags.PublishTrdIndicator) {}
        public PublishTrdIndicator(Boolean val)
            :base(Tags.PublishTrdIndicator, val) {}
    }


    /// <summary>
    /// QtyType Field
    /// </summary>/
    public sealed class QtyType : IntField
    {
        public QtyType()
            :base(Tags.QtyType) {}
        public QtyType(int val)
            :base(Tags.QtyType, val) {}
    }


    /// <summary>
    /// Quantity Field
    /// </summary>/
    public sealed class Quantity : DecimalField
    {
        public Quantity()
            :base(Tags.Quantity) {}
        public Quantity(Decimal val)
            :base(Tags.Quantity, val) {}
    }


    /// <summary>
    /// QuantityType Field
    /// </summary>/
    public sealed class QuantityType : IntField
    {
        public QuantityType()
            :base(Tags.QuantityType) {}
        public QuantityType(int val)
            :base(Tags.QuantityType, val) {}
    }


    /// <summary>
    /// QuoteCancelType Field
    /// </summary>/
    public sealed class QuoteCancelType : IntField
    {
        public QuoteCancelType()
            :base(Tags.QuoteCancelType) {}
        public QuoteCancelType(int val)
            :base(Tags.QuoteCancelType, val) {}
    }


    /// <summary>
    /// QuoteCondition Field
    /// </summary>/
    public sealed class QuoteCondition : StringField
    {
        public QuoteCondition()
            :base(Tags.QuoteCondition) {}
        public QuoteCondition(string val)
            :base(Tags.QuoteCondition, val) {}
    }


    /// <summary>
    /// QuoteEntryID Field
    /// </summary>/
    public sealed class QuoteEntryID : StringField
    {
        public QuoteEntryID()
            :base(Tags.QuoteEntryID) {}
        public QuoteEntryID(string val)
            :base(Tags.QuoteEntryID, val) {}
    }


    /// <summary>
    /// QuoteEntryRejectReason Field
    /// </summary>/
    public sealed class QuoteEntryRejectReason : IntField
    {
        public QuoteEntryRejectReason()
            :base(Tags.QuoteEntryRejectReason) {}
        public QuoteEntryRejectReason(int val)
            :base(Tags.QuoteEntryRejectReason, val) {}
    }


    /// <summary>
    /// QuoteID Field
    /// </summary>/
    public sealed class QuoteID : StringField
    {
        public QuoteID()
            :base(Tags.QuoteID) {}
        public QuoteID(string val)
            :base(Tags.QuoteID, val) {}
    }


    /// <summary>
    /// QuotePriceType Field
    /// </summary>/
    public sealed class QuotePriceType : IntField
    {
        public QuotePriceType()
            :base(Tags.QuotePriceType) {}
        public QuotePriceType(int val)
            :base(Tags.QuotePriceType, val) {}
    }


    /// <summary>
    /// QuoteQualifier Field
    /// </summary>/
    public sealed class QuoteQualifier : CharField
    {
        public QuoteQualifier()
            :base(Tags.QuoteQualifier) {}
        public QuoteQualifier(char val)
            :base(Tags.QuoteQualifier, val) {}
    }


    /// <summary>
    /// QuoteRejectReason Field
    /// </summary>/
    public sealed class QuoteRejectReason : IntField
    {
        public QuoteRejectReason()
            :base(Tags.QuoteRejectReason) {}
        public QuoteRejectReason(int val)
            :base(Tags.QuoteRejectReason, val) {}
    }


    /// <summary>
    /// QuoteReqID Field
    /// </summary>/
    public sealed class QuoteReqID : StringField
    {
        public QuoteReqID()
            :base(Tags.QuoteReqID) {}
        public QuoteReqID(string val)
            :base(Tags.QuoteReqID, val) {}
    }


    /// <summary>
    /// QuoteRequestRejectReason Field
    /// </summary>/
    public sealed class QuoteRequestRejectReason : IntField
    {
        public QuoteRequestRejectReason()
            :base(Tags.QuoteRequestRejectReason) {}
        public QuoteRequestRejectReason(int val)
            :base(Tags.QuoteRequestRejectReason, val) {}
    }


    /// <summary>
    /// QuoteRequestType Field
    /// </summary>/
    public sealed class QuoteRequestType : IntField
    {
        public QuoteRequestType()
            :base(Tags.QuoteRequestType) {}
        public QuoteRequestType(int val)
            :base(Tags.QuoteRequestType, val) {}
    }


    /// <summary>
    /// QuoteRespID Field
    /// </summary>/
    public sealed class QuoteRespID : StringField
    {
        public QuoteRespID()
            :base(Tags.QuoteRespID) {}
        public QuoteRespID(string val)
            :base(Tags.QuoteRespID, val) {}
    }


    /// <summary>
    /// QuoteRespType Field
    /// </summary>/
    public sealed class QuoteRespType : IntField
    {
        public QuoteRespType()
            :base(Tags.QuoteRespType) {}
        public QuoteRespType(int val)
            :base(Tags.QuoteRespType, val) {}
    }


    /// <summary>
    /// QuoteResponseLevel Field
    /// </summary>/
    public sealed class QuoteResponseLevel : IntField
    {
        public QuoteResponseLevel()
            :base(Tags.QuoteResponseLevel) {}
        public QuoteResponseLevel(int val)
            :base(Tags.QuoteResponseLevel, val) {}
    }


    /// <summary>
    /// QuoteSetID Field
    /// </summary>/
    public sealed class QuoteSetID : StringField
    {
        public QuoteSetID()
            :base(Tags.QuoteSetID) {}
        public QuoteSetID(string val)
            :base(Tags.QuoteSetID, val) {}
    }


    /// <summary>
    /// QuoteSetValidUntilTime Field
    /// </summary>/
    public sealed class QuoteSetValidUntilTime : DateTimeField
    {
        public QuoteSetValidUntilTime()
            :base(Tags.QuoteSetValidUntilTime) {}
        public QuoteSetValidUntilTime(DateTime val)
            :base(Tags.QuoteSetValidUntilTime, val) {}
    }


    /// <summary>
    /// QuoteStatus Field
    /// </summary>/
    public sealed class QuoteStatus : IntField
    {
        public QuoteStatus()
            :base(Tags.QuoteStatus) {}
        public QuoteStatus(int val)
            :base(Tags.QuoteStatus, val) {}
    }


    /// <summary>
    /// QuoteStatusReqID Field
    /// </summary>/
    public sealed class QuoteStatusReqID : StringField
    {
        public QuoteStatusReqID()
            :base(Tags.QuoteStatusReqID) {}
        public QuoteStatusReqID(string val)
            :base(Tags.QuoteStatusReqID, val) {}
    }


    /// <summary>
    /// QuoteType Field
    /// </summary>/
    public sealed class QuoteType : IntField
    {
        public QuoteType()
            :base(Tags.QuoteType) {}
        public QuoteType(int val)
            :base(Tags.QuoteType, val) {}
    }


    /// <summary>
    /// RFQReqID Field
    /// </summary>/
    public sealed class RFQReqID : StringField
    {
        public RFQReqID()
            :base(Tags.RFQReqID) {}
        public RFQReqID(string val)
            :base(Tags.RFQReqID, val) {}
    }


    /// <summary>
    /// RawData Field
    /// </summary>/
    public sealed class RawData : StringField
    {
        public RawData()
            :base(Tags.RawData) {}
        public RawData(string val)
            :base(Tags.RawData, val) {}
    }


    /// <summary>
    /// RawDataLength Field
    /// </summary>/
    public sealed class RawDataLength : DecimalField
    {
        public RawDataLength()
            :base(Tags.RawDataLength) {}
        public RawDataLength(Decimal val)
            :base(Tags.RawDataLength, val) {}
    }


    /// <summary>
    /// RedemptionDate Field
    /// </summary>/
    public sealed class RedemptionDate : DateTimeField
    {
        public RedemptionDate()
            :base(Tags.RedemptionDate) {}
        public RedemptionDate(DateTime val)
            :base(Tags.RedemptionDate, val) {}
    }


    /// <summary>
    /// RefAllocID Field
    /// </summary>/
    public sealed class RefAllocID : StringField
    {
        public RefAllocID()
            :base(Tags.RefAllocID) {}
        public RefAllocID(string val)
            :base(Tags.RefAllocID, val) {}
    }


    /// <summary>
    /// RefCompID Field
    /// </summary>/
    public sealed class RefCompID : StringField
    {
        public RefCompID()
            :base(Tags.RefCompID) {}
        public RefCompID(string val)
            :base(Tags.RefCompID, val) {}
    }


    /// <summary>
    /// RefMsgType Field
    /// </summary>/
    public sealed class RefMsgType : StringField
    {
        public RefMsgType()
            :base(Tags.RefMsgType) {}
        public RefMsgType(string val)
            :base(Tags.RefMsgType, val) {}
    }


    /// <summary>
    /// RefSeqNum Field
    /// </summary>/
    public sealed class RefSeqNum : IntField
    {
        public RefSeqNum()
            :base(Tags.RefSeqNum) {}
        public RefSeqNum(int val)
            :base(Tags.RefSeqNum, val) {}
    }


    /// <summary>
    /// RefSubID Field
    /// </summary>/
    public sealed class RefSubID : StringField
    {
        public RefSubID()
            :base(Tags.RefSubID) {}
        public RefSubID(string val)
            :base(Tags.RefSubID, val) {}
    }


    /// <summary>
    /// RefTagID Field
    /// </summary>/
    public sealed class RefTagID : IntField
    {
        public RefTagID()
            :base(Tags.RefTagID) {}
        public RefTagID(int val)
            :base(Tags.RefTagID, val) {}
    }


    /// <summary>
    /// RegistAcctType Field
    /// </summary>/
    public sealed class RegistAcctType : StringField
    {
        public RegistAcctType()
            :base(Tags.RegistAcctType) {}
        public RegistAcctType(string val)
            :base(Tags.RegistAcctType, val) {}
    }


    /// <summary>
    /// RegistDtls Field
    /// </summary>/
    public sealed class RegistDtls : StringField
    {
        public RegistDtls()
            :base(Tags.RegistDtls) {}
        public RegistDtls(string val)
            :base(Tags.RegistDtls, val) {}
    }


    /// <summary>
    /// RegistEmail Field
    /// </summary>/
    public sealed class RegistEmail : StringField
    {
        public RegistEmail()
            :base(Tags.RegistEmail) {}
        public RegistEmail(string val)
            :base(Tags.RegistEmail, val) {}
    }


    /// <summary>
    /// RegistID Field
    /// </summary>/
    public sealed class RegistID : StringField
    {
        public RegistID()
            :base(Tags.RegistID) {}
        public RegistID(string val)
            :base(Tags.RegistID, val) {}
    }


    /// <summary>
    /// RegistRefID Field
    /// </summary>/
    public sealed class RegistRefID : StringField
    {
        public RegistRefID()
            :base(Tags.RegistRefID) {}
        public RegistRefID(string val)
            :base(Tags.RegistRefID, val) {}
    }


    /// <summary>
    /// RegistRejReasonCode Field
    /// </summary>/
    public sealed class RegistRejReasonCode : IntField
    {
        public RegistRejReasonCode()
            :base(Tags.RegistRejReasonCode) {}
        public RegistRejReasonCode(int val)
            :base(Tags.RegistRejReasonCode, val) {}
    }


    /// <summary>
    /// RegistRejReasonText Field
    /// </summary>/
    public sealed class RegistRejReasonText : StringField
    {
        public RegistRejReasonText()
            :base(Tags.RegistRejReasonText) {}
        public RegistRejReasonText(string val)
            :base(Tags.RegistRejReasonText, val) {}
    }


    /// <summary>
    /// RegistStatus Field
    /// </summary>/
    public sealed class RegistStatus : CharField
    {
        public RegistStatus()
            :base(Tags.RegistStatus) {}
        public RegistStatus(char val)
            :base(Tags.RegistStatus, val) {}
    }


    /// <summary>
    /// RegistTransType Field
    /// </summary>/
    public sealed class RegistTransType : CharField
    {
        public RegistTransType()
            :base(Tags.RegistTransType) {}
        public RegistTransType(char val)
            :base(Tags.RegistTransType, val) {}
    }


    /// <summary>
    /// RepoCollateralSecurityType Field
    /// </summary>/
    public sealed class RepoCollateralSecurityType : IntField
    {
        public RepoCollateralSecurityType()
            :base(Tags.RepoCollateralSecurityType) {}
        public RepoCollateralSecurityType(int val)
            :base(Tags.RepoCollateralSecurityType, val) {}
    }


    /// <summary>
    /// ReportToExch Field
    /// </summary>/
    public sealed class ReportToExch : BooleanField
    {
        public ReportToExch()
            :base(Tags.ReportToExch) {}
        public ReportToExch(Boolean val)
            :base(Tags.ReportToExch, val) {}
    }


    /// <summary>
    /// ReportedPx Field
    /// </summary>/
    public sealed class ReportedPx : DecimalField
    {
        public ReportedPx()
            :base(Tags.ReportedPx) {}
        public ReportedPx(Decimal val)
            :base(Tags.ReportedPx, val) {}
    }


    /// <summary>
    /// RepurchaseRate Field
    /// </summary>/
    public sealed class RepurchaseRate : DecimalField
    {
        public RepurchaseRate()
            :base(Tags.RepurchaseRate) {}
        public RepurchaseRate(Decimal val)
            :base(Tags.RepurchaseRate, val) {}
    }


    /// <summary>
    /// RepurchaseTerm Field
    /// </summary>/
    public sealed class RepurchaseTerm : IntField
    {
        public RepurchaseTerm()
            :base(Tags.RepurchaseTerm) {}
        public RepurchaseTerm(int val)
            :base(Tags.RepurchaseTerm, val) {}
    }


    /// <summary>
    /// ResetSeqNumFlag Field
    /// </summary>/
    public sealed class ResetSeqNumFlag : BooleanField
    {
        public ResetSeqNumFlag()
            :base(Tags.ResetSeqNumFlag) {}
        public ResetSeqNumFlag(Boolean val)
            :base(Tags.ResetSeqNumFlag, val) {}
    }


    /// <summary>
    /// ResponseDestination Field
    /// </summary>/
    public sealed class ResponseDestination : StringField
    {
        public ResponseDestination()
            :base(Tags.ResponseDestination) {}
        public ResponseDestination(string val)
            :base(Tags.ResponseDestination, val) {}
    }


    /// <summary>
    /// ResponseTransportType Field
    /// </summary>/
    public sealed class ResponseTransportType : IntField
    {
        public ResponseTransportType()
            :base(Tags.ResponseTransportType) {}
        public ResponseTransportType(int val)
            :base(Tags.ResponseTransportType, val) {}
    }


    /// <summary>
    /// ReversalIndicator Field
    /// </summary>/
    public sealed class ReversalIndicator : BooleanField
    {
        public ReversalIndicator()
            :base(Tags.ReversalIndicator) {}
        public ReversalIndicator(Boolean val)
            :base(Tags.ReversalIndicator, val) {}
    }


    /// <summary>
    /// RoundLot Field
    /// </summary>/
    public sealed class RoundLot : DecimalField
    {
        public RoundLot()
            :base(Tags.RoundLot) {}
        public RoundLot(Decimal val)
            :base(Tags.RoundLot, val) {}
    }


    /// <summary>
    /// RoundingDirection Field
    /// </summary>/
    public sealed class RoundingDirection : CharField
    {
        public RoundingDirection()
            :base(Tags.RoundingDirection) {}
        public RoundingDirection(char val)
            :base(Tags.RoundingDirection, val) {}
    }


    /// <summary>
    /// RoundingModulus Field
    /// </summary>/
    public sealed class RoundingModulus : DecimalField
    {
        public RoundingModulus()
            :base(Tags.RoundingModulus) {}
        public RoundingModulus(Decimal val)
            :base(Tags.RoundingModulus, val) {}
    }


    /// <summary>
    /// RoutingID Field
    /// </summary>/
    public sealed class RoutingID : StringField
    {
        public RoutingID()
            :base(Tags.RoutingID) {}
        public RoutingID(string val)
            :base(Tags.RoutingID, val) {}
    }


    /// <summary>
    /// RoutingType Field
    /// </summary>/
    public sealed class RoutingType : IntField
    {
        public RoutingType()
            :base(Tags.RoutingType) {}
        public RoutingType(int val)
            :base(Tags.RoutingType, val) {}
    }


    /// <summary>
    /// RptSeq Field
    /// </summary>/
    public sealed class RptSeq : IntField
    {
        public RptSeq()
            :base(Tags.RptSeq) {}
        public RptSeq(int val)
            :base(Tags.RptSeq, val) {}
    }


    /// <summary>
    /// Scope Field
    /// </summary>/
    public sealed class Scope : StringField
    {
        public Scope()
            :base(Tags.Scope) {}
        public Scope(string val)
            :base(Tags.Scope, val) {}
    }


    /// <summary>
    /// SecondaryAllocID Field
    /// </summary>/
    public sealed class SecondaryAllocID : StringField
    {
        public SecondaryAllocID()
            :base(Tags.SecondaryAllocID) {}
        public SecondaryAllocID(string val)
            :base(Tags.SecondaryAllocID, val) {}
    }


    /// <summary>
    /// SecondaryClOrdID Field
    /// </summary>/
    public sealed class SecondaryClOrdID : StringField
    {
        public SecondaryClOrdID()
            :base(Tags.SecondaryClOrdID) {}
        public SecondaryClOrdID(string val)
            :base(Tags.SecondaryClOrdID, val) {}
    }


    /// <summary>
    /// SecondaryExecID Field
    /// </summary>/
    public sealed class SecondaryExecID : StringField
    {
        public SecondaryExecID()
            :base(Tags.SecondaryExecID) {}
        public SecondaryExecID(string val)
            :base(Tags.SecondaryExecID, val) {}
    }


    /// <summary>
    /// SecondaryOrderID Field
    /// </summary>/
    public sealed class SecondaryOrderID : StringField
    {
        public SecondaryOrderID()
            :base(Tags.SecondaryOrderID) {}
        public SecondaryOrderID(string val)
            :base(Tags.SecondaryOrderID, val) {}
    }


    /// <summary>
    /// SecondaryTradeReportID Field
    /// </summary>/
    public sealed class SecondaryTradeReportID : StringField
    {
        public SecondaryTradeReportID()
            :base(Tags.SecondaryTradeReportID) {}
        public SecondaryTradeReportID(string val)
            :base(Tags.SecondaryTradeReportID, val) {}
    }


    /// <summary>
    /// SecondaryTradeReportRefID Field
    /// </summary>/
    public sealed class SecondaryTradeReportRefID : StringField
    {
        public SecondaryTradeReportRefID()
            :base(Tags.SecondaryTradeReportRefID) {}
        public SecondaryTradeReportRefID(string val)
            :base(Tags.SecondaryTradeReportRefID, val) {}
    }


    /// <summary>
    /// SecondaryTrdType Field
    /// </summary>/
    public sealed class SecondaryTrdType : IntField
    {
        public SecondaryTrdType()
            :base(Tags.SecondaryTrdType) {}
        public SecondaryTrdType(int val)
            :base(Tags.SecondaryTrdType, val) {}
    }


    /// <summary>
    /// SecureData Field
    /// </summary>/
    public sealed class SecureData : StringField
    {
        public SecureData()
            :base(Tags.SecureData) {}
        public SecureData(string val)
            :base(Tags.SecureData, val) {}
    }


    /// <summary>
    /// SecureDataLen Field
    /// </summary>/
    public sealed class SecureDataLen : DecimalField
    {
        public SecureDataLen()
            :base(Tags.SecureDataLen) {}
        public SecureDataLen(Decimal val)
            :base(Tags.SecureDataLen, val) {}
    }


    /// <summary>
    /// SecurityAltID Field
    /// </summary>/
    public sealed class SecurityAltID : StringField
    {
        public SecurityAltID()
            :base(Tags.SecurityAltID) {}
        public SecurityAltID(string val)
            :base(Tags.SecurityAltID, val) {}
    }


    /// <summary>
    /// SecurityAltIDSource Field
    /// </summary>/
    public sealed class SecurityAltIDSource : StringField
    {
        public SecurityAltIDSource()
            :base(Tags.SecurityAltIDSource) {}
        public SecurityAltIDSource(string val)
            :base(Tags.SecurityAltIDSource, val) {}
    }


    /// <summary>
    /// SecurityDesc Field
    /// </summary>/
    public sealed class SecurityDesc : StringField
    {
        public SecurityDesc()
            :base(Tags.SecurityDesc) {}
        public SecurityDesc(string val)
            :base(Tags.SecurityDesc, val) {}
    }


    /// <summary>
    /// SecurityExchange Field
    /// </summary>/
    public sealed class SecurityExchange : StringField
    {
        public SecurityExchange()
            :base(Tags.SecurityExchange) {}
        public SecurityExchange(string val)
            :base(Tags.SecurityExchange, val) {}
    }


    /// <summary>
    /// SecurityID Field
    /// </summary>/
    public sealed class SecurityID : StringField
    {
        public SecurityID()
            :base(Tags.SecurityID) {}
        public SecurityID(string val)
            :base(Tags.SecurityID, val) {}
    }


    /// <summary>
    /// SecurityIDSource Field
    /// </summary>/
    public sealed class SecurityIDSource : StringField
    {
        public SecurityIDSource()
            :base(Tags.SecurityIDSource) {}
        public SecurityIDSource(string val)
            :base(Tags.SecurityIDSource, val) {}
    }


    /// <summary>
    /// SecurityListRequestType Field
    /// </summary>/
    public sealed class SecurityListRequestType : IntField
    {
        public SecurityListRequestType()
            :base(Tags.SecurityListRequestType) {}
        public SecurityListRequestType(int val)
            :base(Tags.SecurityListRequestType, val) {}
    }


    /// <summary>
    /// SecurityReqID Field
    /// </summary>/
    public sealed class SecurityReqID : StringField
    {
        public SecurityReqID()
            :base(Tags.SecurityReqID) {}
        public SecurityReqID(string val)
            :base(Tags.SecurityReqID, val) {}
    }


    /// <summary>
    /// SecurityRequestResult Field
    /// </summary>/
    public sealed class SecurityRequestResult : IntField
    {
        public SecurityRequestResult()
            :base(Tags.SecurityRequestResult) {}
        public SecurityRequestResult(int val)
            :base(Tags.SecurityRequestResult, val) {}
    }


    /// <summary>
    /// SecurityRequestType Field
    /// </summary>/
    public sealed class SecurityRequestType : IntField
    {
        public SecurityRequestType()
            :base(Tags.SecurityRequestType) {}
        public SecurityRequestType(int val)
            :base(Tags.SecurityRequestType, val) {}
    }


    /// <summary>
    /// SecurityResponseID Field
    /// </summary>/
    public sealed class SecurityResponseID : StringField
    {
        public SecurityResponseID()
            :base(Tags.SecurityResponseID) {}
        public SecurityResponseID(string val)
            :base(Tags.SecurityResponseID, val) {}
    }


    /// <summary>
    /// SecurityResponseType Field
    /// </summary>/
    public sealed class SecurityResponseType : IntField
    {
        public SecurityResponseType()
            :base(Tags.SecurityResponseType) {}
        public SecurityResponseType(int val)
            :base(Tags.SecurityResponseType, val) {}
    }


    /// <summary>
    /// SecurityStatusReqID Field
    /// </summary>/
    public sealed class SecurityStatusReqID : StringField
    {
        public SecurityStatusReqID()
            :base(Tags.SecurityStatusReqID) {}
        public SecurityStatusReqID(string val)
            :base(Tags.SecurityStatusReqID, val) {}
    }


    /// <summary>
    /// SecuritySubType Field
    /// </summary>/
    public sealed class SecuritySubType : StringField
    {
        public SecuritySubType()
            :base(Tags.SecuritySubType) {}
        public SecuritySubType(string val)
            :base(Tags.SecuritySubType, val) {}
    }


    /// <summary>
    /// SecurityTradingStatus Field
    /// </summary>/
    public sealed class SecurityTradingStatus : IntField
    {
        public SecurityTradingStatus()
            :base(Tags.SecurityTradingStatus) {}
        public SecurityTradingStatus(int val)
            :base(Tags.SecurityTradingStatus, val) {}
    }


    /// <summary>
    /// SecurityType Field
    /// </summary>/
    public sealed class SecurityType : StringField
    {
        public SecurityType()
            :base(Tags.SecurityType) {}
        public SecurityType(string val)
            :base(Tags.SecurityType, val) {}
    }


    /// <summary>
    /// SellVolume Field
    /// </summary>/
    public sealed class SellVolume : DecimalField
    {
        public SellVolume()
            :base(Tags.SellVolume) {}
        public SellVolume(Decimal val)
            :base(Tags.SellVolume, val) {}
    }


    /// <summary>
    /// SellerDays Field
    /// </summary>/
    public sealed class SellerDays : IntField
    {
        public SellerDays()
            :base(Tags.SellerDays) {}
        public SellerDays(int val)
            :base(Tags.SellerDays, val) {}
    }


    /// <summary>
    /// SenderCompID Field
    /// </summary>/
    public sealed class SenderCompID : StringField
    {
        public SenderCompID()
            :base(Tags.SenderCompID) {}
        public SenderCompID(string val)
            :base(Tags.SenderCompID, val) {}
    }


    /// <summary>
    /// SenderLocationID Field
    /// </summary>/
    public sealed class SenderLocationID : StringField
    {
        public SenderLocationID()
            :base(Tags.SenderLocationID) {}
        public SenderLocationID(string val)
            :base(Tags.SenderLocationID, val) {}
    }


    /// <summary>
    /// SenderSubID Field
    /// </summary>/
    public sealed class SenderSubID : StringField
    {
        public SenderSubID()
            :base(Tags.SenderSubID) {}
        public SenderSubID(string val)
            :base(Tags.SenderSubID, val) {}
    }


    /// <summary>
    /// SendingTime Field
    /// </summary>/
    public sealed class SendingTime : DateTimeField
    {
        public SendingTime()
            :base(Tags.SendingTime) {}
        public SendingTime(DateTime val)
            :base(Tags.SendingTime, val) {}
    }


    /// <summary>
    /// SessionRejectReason Field
    /// </summary>/
    public sealed class SessionRejectReason : IntField
    {
        public SessionRejectReason()
            :base(Tags.SessionRejectReason) {}
        public SessionRejectReason(int val)
            :base(Tags.SessionRejectReason, val) {}
    }


    /// <summary>
    /// SettlCurrAmt Field
    /// </summary>/
    public sealed class SettlCurrAmt : DecimalField
    {
        public SettlCurrAmt()
            :base(Tags.SettlCurrAmt) {}
        public SettlCurrAmt(Decimal val)
            :base(Tags.SettlCurrAmt, val) {}
    }


    /// <summary>
    /// SettlCurrBidFxRate Field
    /// </summary>/
    public sealed class SettlCurrBidFxRate : DecimalField
    {
        public SettlCurrBidFxRate()
            :base(Tags.SettlCurrBidFxRate) {}
        public SettlCurrBidFxRate(Decimal val)
            :base(Tags.SettlCurrBidFxRate, val) {}
    }


    /// <summary>
    /// SettlCurrFxRate Field
    /// </summary>/
    public sealed class SettlCurrFxRate : DecimalField
    {
        public SettlCurrFxRate()
            :base(Tags.SettlCurrFxRate) {}
        public SettlCurrFxRate(Decimal val)
            :base(Tags.SettlCurrFxRate, val) {}
    }


    /// <summary>
    /// SettlCurrFxRateCalc Field
    /// </summary>/
    public sealed class SettlCurrFxRateCalc : CharField
    {
        public SettlCurrFxRateCalc()
            :base(Tags.SettlCurrFxRateCalc) {}
        public SettlCurrFxRateCalc(char val)
            :base(Tags.SettlCurrFxRateCalc, val) {}
    }


    /// <summary>
    /// SettlCurrOfferFxRate Field
    /// </summary>/
    public sealed class SettlCurrOfferFxRate : DecimalField
    {
        public SettlCurrOfferFxRate()
            :base(Tags.SettlCurrOfferFxRate) {}
        public SettlCurrOfferFxRate(Decimal val)
            :base(Tags.SettlCurrOfferFxRate, val) {}
    }


    /// <summary>
    /// SettlCurrency Field
    /// </summary>/
    public sealed class SettlCurrency : DecimalField
    {
        public SettlCurrency()
            :base(Tags.SettlCurrency) {}
        public SettlCurrency(Decimal val)
            :base(Tags.SettlCurrency, val) {}
    }


    /// <summary>
    /// SettlDate Field
    /// </summary>/
    public sealed class SettlDate : DateTimeField
    {
        public SettlDate()
            :base(Tags.SettlDate) {}
        public SettlDate(DateTime val)
            :base(Tags.SettlDate, val) {}
    }


    /// <summary>
    /// SettlDate2 Field
    /// </summary>/
    public sealed class SettlDate2 : DateTimeField
    {
        public SettlDate2()
            :base(Tags.SettlDate2) {}
        public SettlDate2(DateTime val)
            :base(Tags.SettlDate2, val) {}
    }


    /// <summary>
    /// SettlDeliveryType Field
    /// </summary>/
    public sealed class SettlDeliveryType : IntField
    {
        public SettlDeliveryType()
            :base(Tags.SettlDeliveryType) {}
        public SettlDeliveryType(int val)
            :base(Tags.SettlDeliveryType, val) {}
    }


    /// <summary>
    /// SettlInstID Field
    /// </summary>/
    public sealed class SettlInstID : StringField
    {
        public SettlInstID()
            :base(Tags.SettlInstID) {}
        public SettlInstID(string val)
            :base(Tags.SettlInstID, val) {}
    }


    /// <summary>
    /// SettlInstMode Field
    /// </summary>/
    public sealed class SettlInstMode : CharField
    {
        public SettlInstMode()
            :base(Tags.SettlInstMode) {}
        public SettlInstMode(char val)
            :base(Tags.SettlInstMode, val) {}
    }


    /// <summary>
    /// SettlInstMsgID Field
    /// </summary>/
    public sealed class SettlInstMsgID : StringField
    {
        public SettlInstMsgID()
            :base(Tags.SettlInstMsgID) {}
        public SettlInstMsgID(string val)
            :base(Tags.SettlInstMsgID, val) {}
    }


    /// <summary>
    /// SettlInstRefID Field
    /// </summary>/
    public sealed class SettlInstRefID : StringField
    {
        public SettlInstRefID()
            :base(Tags.SettlInstRefID) {}
        public SettlInstRefID(string val)
            :base(Tags.SettlInstRefID, val) {}
    }


    /// <summary>
    /// SettlInstReqID Field
    /// </summary>/
    public sealed class SettlInstReqID : StringField
    {
        public SettlInstReqID()
            :base(Tags.SettlInstReqID) {}
        public SettlInstReqID(string val)
            :base(Tags.SettlInstReqID, val) {}
    }


    /// <summary>
    /// SettlInstReqRejCode Field
    /// </summary>/
    public sealed class SettlInstReqRejCode : IntField
    {
        public SettlInstReqRejCode()
            :base(Tags.SettlInstReqRejCode) {}
        public SettlInstReqRejCode(int val)
            :base(Tags.SettlInstReqRejCode, val) {}
    }


    /// <summary>
    /// SettlInstSource Field
    /// </summary>/
    public sealed class SettlInstSource : CharField
    {
        public SettlInstSource()
            :base(Tags.SettlInstSource) {}
        public SettlInstSource(char val)
            :base(Tags.SettlInstSource, val) {}
    }


    /// <summary>
    /// SettlInstTransType Field
    /// </summary>/
    public sealed class SettlInstTransType : CharField
    {
        public SettlInstTransType()
            :base(Tags.SettlInstTransType) {}
        public SettlInstTransType(char val)
            :base(Tags.SettlInstTransType, val) {}
    }


    /// <summary>
    /// SettlPartyID Field
    /// </summary>/
    public sealed class SettlPartyID : StringField
    {
        public SettlPartyID()
            :base(Tags.SettlPartyID) {}
        public SettlPartyID(string val)
            :base(Tags.SettlPartyID, val) {}
    }


    /// <summary>
    /// SettlPartyIDSource Field
    /// </summary>/
    public sealed class SettlPartyIDSource : CharField
    {
        public SettlPartyIDSource()
            :base(Tags.SettlPartyIDSource) {}
        public SettlPartyIDSource(char val)
            :base(Tags.SettlPartyIDSource, val) {}
    }


    /// <summary>
    /// SettlPartyRole Field
    /// </summary>/
    public sealed class SettlPartyRole : IntField
    {
        public SettlPartyRole()
            :base(Tags.SettlPartyRole) {}
        public SettlPartyRole(int val)
            :base(Tags.SettlPartyRole, val) {}
    }


    /// <summary>
    /// SettlPartySubID Field
    /// </summary>/
    public sealed class SettlPartySubID : StringField
    {
        public SettlPartySubID()
            :base(Tags.SettlPartySubID) {}
        public SettlPartySubID(string val)
            :base(Tags.SettlPartySubID, val) {}
    }


    /// <summary>
    /// SettlPartySubIDType Field
    /// </summary>/
    public sealed class SettlPartySubIDType : IntField
    {
        public SettlPartySubIDType()
            :base(Tags.SettlPartySubIDType) {}
        public SettlPartySubIDType(int val)
            :base(Tags.SettlPartySubIDType, val) {}
    }


    /// <summary>
    /// SettlPrice Field
    /// </summary>/
    public sealed class SettlPrice : DecimalField
    {
        public SettlPrice()
            :base(Tags.SettlPrice) {}
        public SettlPrice(Decimal val)
            :base(Tags.SettlPrice, val) {}
    }


    /// <summary>
    /// SettlPriceType Field
    /// </summary>/
    public sealed class SettlPriceType : IntField
    {
        public SettlPriceType()
            :base(Tags.SettlPriceType) {}
        public SettlPriceType(int val)
            :base(Tags.SettlPriceType, val) {}
    }


    /// <summary>
    /// SettlSessID Field
    /// </summary>/
    public sealed class SettlSessID : StringField
    {
        public SettlSessID()
            :base(Tags.SettlSessID) {}
        public SettlSessID(string val)
            :base(Tags.SettlSessID, val) {}
    }


    /// <summary>
    /// SettlSessSubID Field
    /// </summary>/
    public sealed class SettlSessSubID : StringField
    {
        public SettlSessSubID()
            :base(Tags.SettlSessSubID) {}
        public SettlSessSubID(string val)
            :base(Tags.SettlSessSubID, val) {}
    }


    /// <summary>
    /// SettlType Field
    /// </summary>/
    public sealed class SettlType : CharField
    {
        public SettlType()
            :base(Tags.SettlType) {}
        public SettlType(char val)
            :base(Tags.SettlType, val) {}
    }


    /// <summary>
    /// SharedCommission Field
    /// </summary>/
    public sealed class SharedCommission : DecimalField
    {
        public SharedCommission()
            :base(Tags.SharedCommission) {}
        public SharedCommission(Decimal val)
            :base(Tags.SharedCommission, val) {}
    }


    /// <summary>
    /// ShortQty Field
    /// </summary>/
    public sealed class ShortQty : DecimalField
    {
        public ShortQty()
            :base(Tags.ShortQty) {}
        public ShortQty(Decimal val)
            :base(Tags.ShortQty, val) {}
    }


    /// <summary>
    /// ShortSaleReason Field
    /// </summary>/
    public sealed class ShortSaleReason : IntField
    {
        public ShortSaleReason()
            :base(Tags.ShortSaleReason) {}
        public ShortSaleReason(int val)
            :base(Tags.ShortSaleReason, val) {}
    }


    /// <summary>
    /// Side Field
    /// </summary>/
    public sealed class Side : CharField
    {
        public Side()
            :base(Tags.Side) {}
        public Side(char val)
            :base(Tags.Side, val) {}
    }


    /// <summary>
    /// SideComplianceID Field
    /// </summary>/
    public sealed class SideComplianceID : StringField
    {
        public SideComplianceID()
            :base(Tags.SideComplianceID) {}
        public SideComplianceID(string val)
            :base(Tags.SideComplianceID, val) {}
    }


    /// <summary>
    /// SideMultiLegReportingType Field
    /// </summary>/
    public sealed class SideMultiLegReportingType : IntField
    {
        public SideMultiLegReportingType()
            :base(Tags.SideMultiLegReportingType) {}
        public SideMultiLegReportingType(int val)
            :base(Tags.SideMultiLegReportingType, val) {}
    }


    /// <summary>
    /// SideValue1 Field
    /// </summary>/
    public sealed class SideValue1 : DecimalField
    {
        public SideValue1()
            :base(Tags.SideValue1) {}
        public SideValue1(Decimal val)
            :base(Tags.SideValue1, val) {}
    }


    /// <summary>
    /// SideValue2 Field
    /// </summary>/
    public sealed class SideValue2 : DecimalField
    {
        public SideValue2()
            :base(Tags.SideValue2) {}
        public SideValue2(Decimal val)
            :base(Tags.SideValue2, val) {}
    }


    /// <summary>
    /// SideValueInd Field
    /// </summary>/
    public sealed class SideValueInd : IntField
    {
        public SideValueInd()
            :base(Tags.SideValueInd) {}
        public SideValueInd(int val)
            :base(Tags.SideValueInd, val) {}
    }


    /// <summary>
    /// Signature Field
    /// </summary>/
    public sealed class Signature : StringField
    {
        public Signature()
            :base(Tags.Signature) {}
        public Signature(string val)
            :base(Tags.Signature, val) {}
    }


    /// <summary>
    /// SignatureLength Field
    /// </summary>/
    public sealed class SignatureLength : DecimalField
    {
        public SignatureLength()
            :base(Tags.SignatureLength) {}
        public SignatureLength(Decimal val)
            :base(Tags.SignatureLength, val) {}
    }


    /// <summary>
    /// SolicitedFlag Field
    /// </summary>/
    public sealed class SolicitedFlag : BooleanField
    {
        public SolicitedFlag()
            :base(Tags.SolicitedFlag) {}
        public SolicitedFlag(Boolean val)
            :base(Tags.SolicitedFlag, val) {}
    }


    /// <summary>
    /// Spread Field
    /// </summary>/
    public sealed class Spread : DecimalField
    {
        public Spread()
            :base(Tags.Spread) {}
        public Spread(Decimal val)
            :base(Tags.Spread, val) {}
    }


    /// <summary>
    /// StandInstDbID Field
    /// </summary>/
    public sealed class StandInstDbID : StringField
    {
        public StandInstDbID()
            :base(Tags.StandInstDbID) {}
        public StandInstDbID(string val)
            :base(Tags.StandInstDbID, val) {}
    }


    /// <summary>
    /// StandInstDbName Field
    /// </summary>/
    public sealed class StandInstDbName : StringField
    {
        public StandInstDbName()
            :base(Tags.StandInstDbName) {}
        public StandInstDbName(string val)
            :base(Tags.StandInstDbName, val) {}
    }


    /// <summary>
    /// StandInstDbType Field
    /// </summary>/
    public sealed class StandInstDbType : IntField
    {
        public StandInstDbType()
            :base(Tags.StandInstDbType) {}
        public StandInstDbType(int val)
            :base(Tags.StandInstDbType, val) {}
    }


    /// <summary>
    /// StartCash Field
    /// </summary>/
    public sealed class StartCash : DecimalField
    {
        public StartCash()
            :base(Tags.StartCash) {}
        public StartCash(Decimal val)
            :base(Tags.StartCash, val) {}
    }


    /// <summary>
    /// StartDate Field
    /// </summary>/
    public sealed class StartDate : DateTimeField
    {
        public StartDate()
            :base(Tags.StartDate) {}
        public StartDate(DateTime val)
            :base(Tags.StartDate, val) {}
    }


    /// <summary>
    /// StateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class StateOrProvinceOfIssue : StringField
    {
        public StateOrProvinceOfIssue()
            :base(Tags.StateOrProvinceOfIssue) {}
        public StateOrProvinceOfIssue(string val)
            :base(Tags.StateOrProvinceOfIssue, val) {}
    }


    /// <summary>
    /// StatusText Field
    /// </summary>/
    public sealed class StatusText : StringField
    {
        public StatusText()
            :base(Tags.StatusText) {}
        public StatusText(string val)
            :base(Tags.StatusText, val) {}
    }


    /// <summary>
    /// StatusValue Field
    /// </summary>/
    public sealed class StatusValue : IntField
    {
        public StatusValue()
            :base(Tags.StatusValue) {}
        public StatusValue(int val)
            :base(Tags.StatusValue, val) {}
    }


    /// <summary>
    /// StipulationType Field
    /// </summary>/
    public sealed class StipulationType : StringField
    {
        public StipulationType()
            :base(Tags.StipulationType) {}
        public StipulationType(string val)
            :base(Tags.StipulationType, val) {}
    }


    /// <summary>
    /// StipulationValue Field
    /// </summary>/
    public sealed class StipulationValue : StringField
    {
        public StipulationValue()
            :base(Tags.StipulationValue) {}
        public StipulationValue(string val)
            :base(Tags.StipulationValue, val) {}
    }


    /// <summary>
    /// StopPx Field
    /// </summary>/
    public sealed class StopPx : DecimalField
    {
        public StopPx()
            :base(Tags.StopPx) {}
        public StopPx(Decimal val)
            :base(Tags.StopPx, val) {}
    }


    /// <summary>
    /// StrikeCurrency Field
    /// </summary>/
    public sealed class StrikeCurrency : DecimalField
    {
        public StrikeCurrency()
            :base(Tags.StrikeCurrency) {}
        public StrikeCurrency(Decimal val)
            :base(Tags.StrikeCurrency, val) {}
    }


    /// <summary>
    /// StrikePrice Field
    /// </summary>/
    public sealed class StrikePrice : DecimalField
    {
        public StrikePrice()
            :base(Tags.StrikePrice) {}
        public StrikePrice(Decimal val)
            :base(Tags.StrikePrice, val) {}
    }


    /// <summary>
    /// StrikeTime Field
    /// </summary>/
    public sealed class StrikeTime : DateTimeField
    {
        public StrikeTime()
            :base(Tags.StrikeTime) {}
        public StrikeTime(DateTime val)
            :base(Tags.StrikeTime, val) {}
    }


    /// <summary>
    /// Subject Field
    /// </summary>/
    public sealed class Subject : StringField
    {
        public Subject()
            :base(Tags.Subject) {}
        public Subject(string val)
            :base(Tags.Subject, val) {}
    }


    /// <summary>
    /// SubscriptionRequestType Field
    /// </summary>/
    public sealed class SubscriptionRequestType : CharField
    {
        public SubscriptionRequestType()
            :base(Tags.SubscriptionRequestType) {}
        public SubscriptionRequestType(char val)
            :base(Tags.SubscriptionRequestType, val) {}
    }


    /// <summary>
    /// Symbol Field
    /// </summary>/
    public sealed class Symbol : StringField
    {
        public Symbol()
            :base(Tags.Symbol) {}
        public Symbol(string val)
            :base(Tags.Symbol, val) {}
    }


    /// <summary>
    /// SymbolSfx Field
    /// </summary>/
    public sealed class SymbolSfx : StringField
    {
        public SymbolSfx()
            :base(Tags.SymbolSfx) {}
        public SymbolSfx(string val)
            :base(Tags.SymbolSfx, val) {}
    }


    /// <summary>
    /// TargetCompID Field
    /// </summary>/
    public sealed class TargetCompID : StringField
    {
        public TargetCompID()
            :base(Tags.TargetCompID) {}
        public TargetCompID(string val)
            :base(Tags.TargetCompID, val) {}
    }


    /// <summary>
    /// TargetLocationID Field
    /// </summary>/
    public sealed class TargetLocationID : StringField
    {
        public TargetLocationID()
            :base(Tags.TargetLocationID) {}
        public TargetLocationID(string val)
            :base(Tags.TargetLocationID, val) {}
    }


    /// <summary>
    /// TargetStrategy Field
    /// </summary>/
    public sealed class TargetStrategy : IntField
    {
        public TargetStrategy()
            :base(Tags.TargetStrategy) {}
        public TargetStrategy(int val)
            :base(Tags.TargetStrategy, val) {}
    }


    /// <summary>
    /// TargetStrategyParameters Field
    /// </summary>/
    public sealed class TargetStrategyParameters : StringField
    {
        public TargetStrategyParameters()
            :base(Tags.TargetStrategyParameters) {}
        public TargetStrategyParameters(string val)
            :base(Tags.TargetStrategyParameters, val) {}
    }


    /// <summary>
    /// TargetStrategyPerformance Field
    /// </summary>/
    public sealed class TargetStrategyPerformance : DecimalField
    {
        public TargetStrategyPerformance()
            :base(Tags.TargetStrategyPerformance) {}
        public TargetStrategyPerformance(Decimal val)
            :base(Tags.TargetStrategyPerformance, val) {}
    }


    /// <summary>
    /// TargetSubID Field
    /// </summary>/
    public sealed class TargetSubID : StringField
    {
        public TargetSubID()
            :base(Tags.TargetSubID) {}
        public TargetSubID(string val)
            :base(Tags.TargetSubID, val) {}
    }


    /// <summary>
    /// TaxAdvantageType Field
    /// </summary>/
    public sealed class TaxAdvantageType : IntField
    {
        public TaxAdvantageType()
            :base(Tags.TaxAdvantageType) {}
        public TaxAdvantageType(int val)
            :base(Tags.TaxAdvantageType, val) {}
    }


    /// <summary>
    /// TerminationType Field
    /// </summary>/
    public sealed class TerminationType : IntField
    {
        public TerminationType()
            :base(Tags.TerminationType) {}
        public TerminationType(int val)
            :base(Tags.TerminationType, val) {}
    }


    /// <summary>
    /// TestMessageIndicator Field
    /// </summary>/
    public sealed class TestMessageIndicator : BooleanField
    {
        public TestMessageIndicator()
            :base(Tags.TestMessageIndicator) {}
        public TestMessageIndicator(Boolean val)
            :base(Tags.TestMessageIndicator, val) {}
    }


    /// <summary>
    /// TestReqID Field
    /// </summary>/
    public sealed class TestReqID : StringField
    {
        public TestReqID()
            :base(Tags.TestReqID) {}
        public TestReqID(string val)
            :base(Tags.TestReqID, val) {}
    }


    /// <summary>
    /// Text Field
    /// </summary>/
    public sealed class Text : StringField
    {
        public Text()
            :base(Tags.Text) {}
        public Text(string val)
            :base(Tags.Text, val) {}
    }


    /// <summary>
    /// ThresholdAmount Field
    /// </summary>/
    public sealed class ThresholdAmount : DecimalField
    {
        public ThresholdAmount()
            :base(Tags.ThresholdAmount) {}
        public ThresholdAmount(Decimal val)
            :base(Tags.ThresholdAmount, val) {}
    }


    /// <summary>
    /// TickDirection Field
    /// </summary>/
    public sealed class TickDirection : CharField
    {
        public TickDirection()
            :base(Tags.TickDirection) {}
        public TickDirection(char val)
            :base(Tags.TickDirection, val) {}
    }


    /// <summary>
    /// TimeBracket Field
    /// </summary>/
    public sealed class TimeBracket : StringField
    {
        public TimeBracket()
            :base(Tags.TimeBracket) {}
        public TimeBracket(string val)
            :base(Tags.TimeBracket, val) {}
    }


    /// <summary>
    /// TimeInForce Field
    /// </summary>/
    public sealed class TimeInForce : CharField
    {
        public TimeInForce()
            :base(Tags.TimeInForce) {}
        public TimeInForce(char val)
            :base(Tags.TimeInForce, val) {}
    }


    /// <summary>
    /// TotNoAllocs Field
    /// </summary>/
    public sealed class TotNoAllocs : IntField
    {
        public TotNoAllocs()
            :base(Tags.TotNoAllocs) {}
        public TotNoAllocs(int val)
            :base(Tags.TotNoAllocs, val) {}
    }


    /// <summary>
    /// TotNoOrders Field
    /// </summary>/
    public sealed class TotNoOrders : IntField
    {
        public TotNoOrders()
            :base(Tags.TotNoOrders) {}
        public TotNoOrders(int val)
            :base(Tags.TotNoOrders, val) {}
    }


    /// <summary>
    /// TotNoQuoteEntries Field
    /// </summary>/
    public sealed class TotNoQuoteEntries : IntField
    {
        public TotNoQuoteEntries()
            :base(Tags.TotNoQuoteEntries) {}
        public TotNoQuoteEntries(int val)
            :base(Tags.TotNoQuoteEntries, val) {}
    }


    /// <summary>
    /// TotNoRelatedSym Field
    /// </summary>/
    public sealed class TotNoRelatedSym : IntField
    {
        public TotNoRelatedSym()
            :base(Tags.TotNoRelatedSym) {}
        public TotNoRelatedSym(int val)
            :base(Tags.TotNoRelatedSym, val) {}
    }


    /// <summary>
    /// TotNoSecurityTypes Field
    /// </summary>/
    public sealed class TotNoSecurityTypes : IntField
    {
        public TotNoSecurityTypes()
            :base(Tags.TotNoSecurityTypes) {}
        public TotNoSecurityTypes(int val)
            :base(Tags.TotNoSecurityTypes, val) {}
    }


    /// <summary>
    /// TotNoStrikes Field
    /// </summary>/
    public sealed class TotNoStrikes : IntField
    {
        public TotNoStrikes()
            :base(Tags.TotNoStrikes) {}
        public TotNoStrikes(int val)
            :base(Tags.TotNoStrikes, val) {}
    }


    /// <summary>
    /// TotNumAssignmentReports Field
    /// </summary>/
    public sealed class TotNumAssignmentReports : IntField
    {
        public TotNumAssignmentReports()
            :base(Tags.TotNumAssignmentReports) {}
        public TotNumAssignmentReports(int val)
            :base(Tags.TotNumAssignmentReports, val) {}
    }


    /// <summary>
    /// TotNumReports Field
    /// </summary>/
    public sealed class TotNumReports : IntField
    {
        public TotNumReports()
            :base(Tags.TotNumReports) {}
        public TotNumReports(int val)
            :base(Tags.TotNumReports, val) {}
    }


    /// <summary>
    /// TotNumTradeReports Field
    /// </summary>/
    public sealed class TotNumTradeReports : IntField
    {
        public TotNumTradeReports()
            :base(Tags.TotNumTradeReports) {}
        public TotNumTradeReports(int val)
            :base(Tags.TotNumTradeReports, val) {}
    }


    /// <summary>
    /// TotalAccruedInterestAmt Field
    /// </summary>/
    public sealed class TotalAccruedInterestAmt : DecimalField
    {
        public TotalAccruedInterestAmt()
            :base(Tags.TotalAccruedInterestAmt) {}
        public TotalAccruedInterestAmt(Decimal val)
            :base(Tags.TotalAccruedInterestAmt, val) {}
    }


    /// <summary>
    /// TotalAffectedOrders Field
    /// </summary>/
    public sealed class TotalAffectedOrders : IntField
    {
        public TotalAffectedOrders()
            :base(Tags.TotalAffectedOrders) {}
        public TotalAffectedOrders(int val)
            :base(Tags.TotalAffectedOrders, val) {}
    }


    /// <summary>
    /// TotalNetValue Field
    /// </summary>/
    public sealed class TotalNetValue : DecimalField
    {
        public TotalNetValue()
            :base(Tags.TotalNetValue) {}
        public TotalNetValue(Decimal val)
            :base(Tags.TotalNetValue, val) {}
    }


    /// <summary>
    /// TotalNumPosReports Field
    /// </summary>/
    public sealed class TotalNumPosReports : IntField
    {
        public TotalNumPosReports()
            :base(Tags.TotalNumPosReports) {}
        public TotalNumPosReports(int val)
            :base(Tags.TotalNumPosReports, val) {}
    }


    /// <summary>
    /// TotalTakedown Field
    /// </summary>/
    public sealed class TotalTakedown : DecimalField
    {
        public TotalTakedown()
            :base(Tags.TotalTakedown) {}
        public TotalTakedown(Decimal val)
            :base(Tags.TotalTakedown, val) {}
    }


    /// <summary>
    /// TotalVolumeTraded Field
    /// </summary>/
    public sealed class TotalVolumeTraded : DecimalField
    {
        public TotalVolumeTraded()
            :base(Tags.TotalVolumeTraded) {}
        public TotalVolumeTraded(Decimal val)
            :base(Tags.TotalVolumeTraded, val) {}
    }


    /// <summary>
    /// TradSesCloseTime Field
    /// </summary>/
    public sealed class TradSesCloseTime : DateTimeField
    {
        public TradSesCloseTime()
            :base(Tags.TradSesCloseTime) {}
        public TradSesCloseTime(DateTime val)
            :base(Tags.TradSesCloseTime, val) {}
    }


    /// <summary>
    /// TradSesEndTime Field
    /// </summary>/
    public sealed class TradSesEndTime : DateTimeField
    {
        public TradSesEndTime()
            :base(Tags.TradSesEndTime) {}
        public TradSesEndTime(DateTime val)
            :base(Tags.TradSesEndTime, val) {}
    }


    /// <summary>
    /// TradSesMethod Field
    /// </summary>/
    public sealed class TradSesMethod : IntField
    {
        public TradSesMethod()
            :base(Tags.TradSesMethod) {}
        public TradSesMethod(int val)
            :base(Tags.TradSesMethod, val) {}
    }


    /// <summary>
    /// TradSesMode Field
    /// </summary>/
    public sealed class TradSesMode : IntField
    {
        public TradSesMode()
            :base(Tags.TradSesMode) {}
        public TradSesMode(int val)
            :base(Tags.TradSesMode, val) {}
    }


    /// <summary>
    /// TradSesOpenTime Field
    /// </summary>/
    public sealed class TradSesOpenTime : DateTimeField
    {
        public TradSesOpenTime()
            :base(Tags.TradSesOpenTime) {}
        public TradSesOpenTime(DateTime val)
            :base(Tags.TradSesOpenTime, val) {}
    }


    /// <summary>
    /// TradSesPreCloseTime Field
    /// </summary>/
    public sealed class TradSesPreCloseTime : DateTimeField
    {
        public TradSesPreCloseTime()
            :base(Tags.TradSesPreCloseTime) {}
        public TradSesPreCloseTime(DateTime val)
            :base(Tags.TradSesPreCloseTime, val) {}
    }


    /// <summary>
    /// TradSesReqID Field
    /// </summary>/
    public sealed class TradSesReqID : StringField
    {
        public TradSesReqID()
            :base(Tags.TradSesReqID) {}
        public TradSesReqID(string val)
            :base(Tags.TradSesReqID, val) {}
    }


    /// <summary>
    /// TradSesStartTime Field
    /// </summary>/
    public sealed class TradSesStartTime : DateTimeField
    {
        public TradSesStartTime()
            :base(Tags.TradSesStartTime) {}
        public TradSesStartTime(DateTime val)
            :base(Tags.TradSesStartTime, val) {}
    }


    /// <summary>
    /// TradSesStatus Field
    /// </summary>/
    public sealed class TradSesStatus : IntField
    {
        public TradSesStatus()
            :base(Tags.TradSesStatus) {}
        public TradSesStatus(int val)
            :base(Tags.TradSesStatus, val) {}
    }


    /// <summary>
    /// TradSesStatusRejReason Field
    /// </summary>/
    public sealed class TradSesStatusRejReason : IntField
    {
        public TradSesStatusRejReason()
            :base(Tags.TradSesStatusRejReason) {}
        public TradSesStatusRejReason(int val)
            :base(Tags.TradSesStatusRejReason, val) {}
    }


    /// <summary>
    /// TradeAllocIndicator Field
    /// </summary>/
    public sealed class TradeAllocIndicator : IntField
    {
        public TradeAllocIndicator()
            :base(Tags.TradeAllocIndicator) {}
        public TradeAllocIndicator(int val)
            :base(Tags.TradeAllocIndicator, val) {}
    }


    /// <summary>
    /// TradeCondition Field
    /// </summary>/
    public sealed class TradeCondition : StringField
    {
        public TradeCondition()
            :base(Tags.TradeCondition) {}
        public TradeCondition(string val)
            :base(Tags.TradeCondition, val) {}
    }


    /// <summary>
    /// TradeDate Field
    /// </summary>/
    public sealed class TradeDate : DateTimeField
    {
        public TradeDate()
            :base(Tags.TradeDate) {}
        public TradeDate(DateTime val)
            :base(Tags.TradeDate, val) {}
    }


    /// <summary>
    /// TradeInputDevice Field
    /// </summary>/
    public sealed class TradeInputDevice : StringField
    {
        public TradeInputDevice()
            :base(Tags.TradeInputDevice) {}
        public TradeInputDevice(string val)
            :base(Tags.TradeInputDevice, val) {}
    }


    /// <summary>
    /// TradeInputSource Field
    /// </summary>/
    public sealed class TradeInputSource : StringField
    {
        public TradeInputSource()
            :base(Tags.TradeInputSource) {}
        public TradeInputSource(string val)
            :base(Tags.TradeInputSource, val) {}
    }


    /// <summary>
    /// TradeLegRefID Field
    /// </summary>/
    public sealed class TradeLegRefID : StringField
    {
        public TradeLegRefID()
            :base(Tags.TradeLegRefID) {}
        public TradeLegRefID(string val)
            :base(Tags.TradeLegRefID, val) {}
    }


    /// <summary>
    /// TradeLinkID Field
    /// </summary>/
    public sealed class TradeLinkID : StringField
    {
        public TradeLinkID()
            :base(Tags.TradeLinkID) {}
        public TradeLinkID(string val)
            :base(Tags.TradeLinkID, val) {}
    }


    /// <summary>
    /// TradeOriginationDate Field
    /// </summary>/
    public sealed class TradeOriginationDate : DateTimeField
    {
        public TradeOriginationDate()
            :base(Tags.TradeOriginationDate) {}
        public TradeOriginationDate(DateTime val)
            :base(Tags.TradeOriginationDate, val) {}
    }


    /// <summary>
    /// TradeReportID Field
    /// </summary>/
    public sealed class TradeReportID : StringField
    {
        public TradeReportID()
            :base(Tags.TradeReportID) {}
        public TradeReportID(string val)
            :base(Tags.TradeReportID, val) {}
    }


    /// <summary>
    /// TradeReportRefID Field
    /// </summary>/
    public sealed class TradeReportRefID : StringField
    {
        public TradeReportRefID()
            :base(Tags.TradeReportRefID) {}
        public TradeReportRefID(string val)
            :base(Tags.TradeReportRefID, val) {}
    }


    /// <summary>
    /// TradeReportRejectReason Field
    /// </summary>/
    public sealed class TradeReportRejectReason : IntField
    {
        public TradeReportRejectReason()
            :base(Tags.TradeReportRejectReason) {}
        public TradeReportRejectReason(int val)
            :base(Tags.TradeReportRejectReason, val) {}
    }


    /// <summary>
    /// TradeReportTransType Field
    /// </summary>/
    public sealed class TradeReportTransType : IntField
    {
        public TradeReportTransType()
            :base(Tags.TradeReportTransType) {}
        public TradeReportTransType(int val)
            :base(Tags.TradeReportTransType, val) {}
    }


    /// <summary>
    /// TradeReportType Field
    /// </summary>/
    public sealed class TradeReportType : IntField
    {
        public TradeReportType()
            :base(Tags.TradeReportType) {}
        public TradeReportType(int val)
            :base(Tags.TradeReportType, val) {}
    }


    /// <summary>
    /// TradeRequestID Field
    /// </summary>/
    public sealed class TradeRequestID : StringField
    {
        public TradeRequestID()
            :base(Tags.TradeRequestID) {}
        public TradeRequestID(string val)
            :base(Tags.TradeRequestID, val) {}
    }


    /// <summary>
    /// TradeRequestResult Field
    /// </summary>/
    public sealed class TradeRequestResult : IntField
    {
        public TradeRequestResult()
            :base(Tags.TradeRequestResult) {}
        public TradeRequestResult(int val)
            :base(Tags.TradeRequestResult, val) {}
    }


    /// <summary>
    /// TradeRequestStatus Field
    /// </summary>/
    public sealed class TradeRequestStatus : IntField
    {
        public TradeRequestStatus()
            :base(Tags.TradeRequestStatus) {}
        public TradeRequestStatus(int val)
            :base(Tags.TradeRequestStatus, val) {}
    }


    /// <summary>
    /// TradeRequestType Field
    /// </summary>/
    public sealed class TradeRequestType : IntField
    {
        public TradeRequestType()
            :base(Tags.TradeRequestType) {}
        public TradeRequestType(int val)
            :base(Tags.TradeRequestType, val) {}
    }


    /// <summary>
    /// TradedFlatSwitch Field
    /// </summary>/
    public sealed class TradedFlatSwitch : BooleanField
    {
        public TradedFlatSwitch()
            :base(Tags.TradedFlatSwitch) {}
        public TradedFlatSwitch(Boolean val)
            :base(Tags.TradedFlatSwitch, val) {}
    }


    /// <summary>
    /// TradingSessionID Field
    /// </summary>/
    public sealed class TradingSessionID : StringField
    {
        public TradingSessionID()
            :base(Tags.TradingSessionID) {}
        public TradingSessionID(string val)
            :base(Tags.TradingSessionID, val) {}
    }


    /// <summary>
    /// TradingSessionSubID Field
    /// </summary>/
    public sealed class TradingSessionSubID : StringField
    {
        public TradingSessionSubID()
            :base(Tags.TradingSessionSubID) {}
        public TradingSessionSubID(string val)
            :base(Tags.TradingSessionSubID, val) {}
    }


    /// <summary>
    /// TransBkdTime Field
    /// </summary>/
    public sealed class TransBkdTime : DateTimeField
    {
        public TransBkdTime()
            :base(Tags.TransBkdTime) {}
        public TransBkdTime(DateTime val)
            :base(Tags.TransBkdTime, val) {}
    }


    /// <summary>
    /// TransactTime Field
    /// </summary>/
    public sealed class TransactTime : DateTimeField
    {
        public TransactTime()
            :base(Tags.TransactTime) {}
        public TransactTime(DateTime val)
            :base(Tags.TransactTime, val) {}
    }


    /// <summary>
    /// TransferReason Field
    /// </summary>/
    public sealed class TransferReason : StringField
    {
        public TransferReason()
            :base(Tags.TransferReason) {}
        public TransferReason(string val)
            :base(Tags.TransferReason, val) {}
    }


    /// <summary>
    /// TrdMatchID Field
    /// </summary>/
    public sealed class TrdMatchID : StringField
    {
        public TrdMatchID()
            :base(Tags.TrdMatchID) {}
        public TrdMatchID(string val)
            :base(Tags.TrdMatchID, val) {}
    }


    /// <summary>
    /// TrdRegTimestamp Field
    /// </summary>/
    public sealed class TrdRegTimestamp : DateTimeField
    {
        public TrdRegTimestamp()
            :base(Tags.TrdRegTimestamp) {}
        public TrdRegTimestamp(DateTime val)
            :base(Tags.TrdRegTimestamp, val) {}
    }


    /// <summary>
    /// TrdRegTimestampOrigin Field
    /// </summary>/
    public sealed class TrdRegTimestampOrigin : StringField
    {
        public TrdRegTimestampOrigin()
            :base(Tags.TrdRegTimestampOrigin) {}
        public TrdRegTimestampOrigin(string val)
            :base(Tags.TrdRegTimestampOrigin, val) {}
    }


    /// <summary>
    /// TrdRegTimestampType Field
    /// </summary>/
    public sealed class TrdRegTimestampType : IntField
    {
        public TrdRegTimestampType()
            :base(Tags.TrdRegTimestampType) {}
        public TrdRegTimestampType(int val)
            :base(Tags.TrdRegTimestampType, val) {}
    }


    /// <summary>
    /// TrdRptStatus Field
    /// </summary>/
    public sealed class TrdRptStatus : IntField
    {
        public TrdRptStatus()
            :base(Tags.TrdRptStatus) {}
        public TrdRptStatus(int val)
            :base(Tags.TrdRptStatus, val) {}
    }


    /// <summary>
    /// TrdSubType Field
    /// </summary>/
    public sealed class TrdSubType : IntField
    {
        public TrdSubType()
            :base(Tags.TrdSubType) {}
        public TrdSubType(int val)
            :base(Tags.TrdSubType, val) {}
    }


    /// <summary>
    /// TrdType Field
    /// </summary>/
    public sealed class TrdType : IntField
    {
        public TrdType()
            :base(Tags.TrdType) {}
        public TrdType(int val)
            :base(Tags.TrdType, val) {}
    }


    /// <summary>
    /// URLLink Field
    /// </summary>/
    public sealed class URLLink : StringField
    {
        public URLLink()
            :base(Tags.URLLink) {}
        public URLLink(string val)
            :base(Tags.URLLink, val) {}
    }


    /// <summary>
    /// UnderlyingCFICode Field
    /// </summary>/
    public sealed class UnderlyingCFICode : StringField
    {
        public UnderlyingCFICode()
            :base(Tags.UnderlyingCFICode) {}
        public UnderlyingCFICode(string val)
            :base(Tags.UnderlyingCFICode, val) {}
    }


    /// <summary>
    /// UnderlyingCPProgram Field
    /// </summary>/
    public sealed class UnderlyingCPProgram : StringField
    {
        public UnderlyingCPProgram()
            :base(Tags.UnderlyingCPProgram) {}
        public UnderlyingCPProgram(string val)
            :base(Tags.UnderlyingCPProgram, val) {}
    }


    /// <summary>
    /// UnderlyingCPRegType Field
    /// </summary>/
    public sealed class UnderlyingCPRegType : StringField
    {
        public UnderlyingCPRegType()
            :base(Tags.UnderlyingCPRegType) {}
        public UnderlyingCPRegType(string val)
            :base(Tags.UnderlyingCPRegType, val) {}
    }


    /// <summary>
    /// UnderlyingContractMultiplier Field
    /// </summary>/
    public sealed class UnderlyingContractMultiplier : DecimalField
    {
        public UnderlyingContractMultiplier()
            :base(Tags.UnderlyingContractMultiplier) {}
        public UnderlyingContractMultiplier(Decimal val)
            :base(Tags.UnderlyingContractMultiplier, val) {}
    }


    /// <summary>
    /// UnderlyingCountryOfIssue Field
    /// </summary>/
    public sealed class UnderlyingCountryOfIssue : StringField
    {
        public UnderlyingCountryOfIssue()
            :base(Tags.UnderlyingCountryOfIssue) {}
        public UnderlyingCountryOfIssue(string val)
            :base(Tags.UnderlyingCountryOfIssue, val) {}
    }


    /// <summary>
    /// UnderlyingCouponPaymentDate Field
    /// </summary>/
    public sealed class UnderlyingCouponPaymentDate : DateTimeField
    {
        public UnderlyingCouponPaymentDate()
            :base(Tags.UnderlyingCouponPaymentDate) {}
        public UnderlyingCouponPaymentDate(DateTime val)
            :base(Tags.UnderlyingCouponPaymentDate, val) {}
    }


    /// <summary>
    /// UnderlyingCouponRate Field
    /// </summary>/
    public sealed class UnderlyingCouponRate : DecimalField
    {
        public UnderlyingCouponRate()
            :base(Tags.UnderlyingCouponRate) {}
        public UnderlyingCouponRate(Decimal val)
            :base(Tags.UnderlyingCouponRate, val) {}
    }


    /// <summary>
    /// UnderlyingCreditRating Field
    /// </summary>/
    public sealed class UnderlyingCreditRating : StringField
    {
        public UnderlyingCreditRating()
            :base(Tags.UnderlyingCreditRating) {}
        public UnderlyingCreditRating(string val)
            :base(Tags.UnderlyingCreditRating, val) {}
    }


    /// <summary>
    /// UnderlyingCurrency Field
    /// </summary>/
    public sealed class UnderlyingCurrency : DecimalField
    {
        public UnderlyingCurrency()
            :base(Tags.UnderlyingCurrency) {}
        public UnderlyingCurrency(Decimal val)
            :base(Tags.UnderlyingCurrency, val) {}
    }


    /// <summary>
    /// UnderlyingCurrentValue Field
    /// </summary>/
    public sealed class UnderlyingCurrentValue : DecimalField
    {
        public UnderlyingCurrentValue()
            :base(Tags.UnderlyingCurrentValue) {}
        public UnderlyingCurrentValue(Decimal val)
            :base(Tags.UnderlyingCurrentValue, val) {}
    }


    /// <summary>
    /// UnderlyingDirtyPrice Field
    /// </summary>/
    public sealed class UnderlyingDirtyPrice : DecimalField
    {
        public UnderlyingDirtyPrice()
            :base(Tags.UnderlyingDirtyPrice) {}
        public UnderlyingDirtyPrice(Decimal val)
            :base(Tags.UnderlyingDirtyPrice, val) {}
    }


    /// <summary>
    /// UnderlyingEndPrice Field
    /// </summary>/
    public sealed class UnderlyingEndPrice : DecimalField
    {
        public UnderlyingEndPrice()
            :base(Tags.UnderlyingEndPrice) {}
        public UnderlyingEndPrice(Decimal val)
            :base(Tags.UnderlyingEndPrice, val) {}
    }


    /// <summary>
    /// UnderlyingEndValue Field
    /// </summary>/
    public sealed class UnderlyingEndValue : DecimalField
    {
        public UnderlyingEndValue()
            :base(Tags.UnderlyingEndValue) {}
        public UnderlyingEndValue(Decimal val)
            :base(Tags.UnderlyingEndValue, val) {}
    }


    /// <summary>
    /// UnderlyingFactor Field
    /// </summary>/
    public sealed class UnderlyingFactor : DecimalField
    {
        public UnderlyingFactor()
            :base(Tags.UnderlyingFactor) {}
        public UnderlyingFactor(Decimal val)
            :base(Tags.UnderlyingFactor, val) {}
    }


    /// <summary>
    /// UnderlyingInstrRegistry Field
    /// </summary>/
    public sealed class UnderlyingInstrRegistry : StringField
    {
        public UnderlyingInstrRegistry()
            :base(Tags.UnderlyingInstrRegistry) {}
        public UnderlyingInstrRegistry(string val)
            :base(Tags.UnderlyingInstrRegistry, val) {}
    }


    /// <summary>
    /// UnderlyingIssueDate Field
    /// </summary>/
    public sealed class UnderlyingIssueDate : DateTimeField
    {
        public UnderlyingIssueDate()
            :base(Tags.UnderlyingIssueDate) {}
        public UnderlyingIssueDate(DateTime val)
            :base(Tags.UnderlyingIssueDate, val) {}
    }


    /// <summary>
    /// UnderlyingIssuer Field
    /// </summary>/
    public sealed class UnderlyingIssuer : StringField
    {
        public UnderlyingIssuer()
            :base(Tags.UnderlyingIssuer) {}
        public UnderlyingIssuer(string val)
            :base(Tags.UnderlyingIssuer, val) {}
    }


    /// <summary>
    /// UnderlyingLastPx Field
    /// </summary>/
    public sealed class UnderlyingLastPx : DecimalField
    {
        public UnderlyingLastPx()
            :base(Tags.UnderlyingLastPx) {}
        public UnderlyingLastPx(Decimal val)
            :base(Tags.UnderlyingLastPx, val) {}
    }


    /// <summary>
    /// UnderlyingLastQty Field
    /// </summary>/
    public sealed class UnderlyingLastQty : DecimalField
    {
        public UnderlyingLastQty()
            :base(Tags.UnderlyingLastQty) {}
        public UnderlyingLastQty(Decimal val)
            :base(Tags.UnderlyingLastQty, val) {}
    }


    /// <summary>
    /// UnderlyingLocaleOfIssue Field
    /// </summary>/
    public sealed class UnderlyingLocaleOfIssue : StringField
    {
        public UnderlyingLocaleOfIssue()
            :base(Tags.UnderlyingLocaleOfIssue) {}
        public UnderlyingLocaleOfIssue(string val)
            :base(Tags.UnderlyingLocaleOfIssue, val) {}
    }


    /// <summary>
    /// UnderlyingMaturityDate Field
    /// </summary>/
    public sealed class UnderlyingMaturityDate : DateTimeField
    {
        public UnderlyingMaturityDate()
            :base(Tags.UnderlyingMaturityDate) {}
        public UnderlyingMaturityDate(DateTime val)
            :base(Tags.UnderlyingMaturityDate, val) {}
    }


    /// <summary>
    /// UnderlyingMaturityMonthYear Field
    /// </summary>/
    public sealed class UnderlyingMaturityMonthYear : DateTimeField
    {
        public UnderlyingMaturityMonthYear()
            :base(Tags.UnderlyingMaturityMonthYear) {}
        public UnderlyingMaturityMonthYear(DateTime val)
            :base(Tags.UnderlyingMaturityMonthYear, val) {}
    }


    /// <summary>
    /// UnderlyingOptAttribute Field
    /// </summary>/
    public sealed class UnderlyingOptAttribute : CharField
    {
        public UnderlyingOptAttribute()
            :base(Tags.UnderlyingOptAttribute) {}
        public UnderlyingOptAttribute(char val)
            :base(Tags.UnderlyingOptAttribute, val) {}
    }


    /// <summary>
    /// UnderlyingProduct Field
    /// </summary>/
    public sealed class UnderlyingProduct : IntField
    {
        public UnderlyingProduct()
            :base(Tags.UnderlyingProduct) {}
        public UnderlyingProduct(int val)
            :base(Tags.UnderlyingProduct, val) {}
    }


    /// <summary>
    /// UnderlyingPx Field
    /// </summary>/
    public sealed class UnderlyingPx : DecimalField
    {
        public UnderlyingPx()
            :base(Tags.UnderlyingPx) {}
        public UnderlyingPx(Decimal val)
            :base(Tags.UnderlyingPx, val) {}
    }


    /// <summary>
    /// UnderlyingQty Field
    /// </summary>/
    public sealed class UnderlyingQty : DecimalField
    {
        public UnderlyingQty()
            :base(Tags.UnderlyingQty) {}
        public UnderlyingQty(Decimal val)
            :base(Tags.UnderlyingQty, val) {}
    }


    /// <summary>
    /// UnderlyingRedemptionDate Field
    /// </summary>/
    public sealed class UnderlyingRedemptionDate : DateTimeField
    {
        public UnderlyingRedemptionDate()
            :base(Tags.UnderlyingRedemptionDate) {}
        public UnderlyingRedemptionDate(DateTime val)
            :base(Tags.UnderlyingRedemptionDate, val) {}
    }


    /// <summary>
    /// UnderlyingRepoCollateralSecurityType Field
    /// </summary>/
    public sealed class UnderlyingRepoCollateralSecurityType : IntField
    {
        public UnderlyingRepoCollateralSecurityType()
            :base(Tags.UnderlyingRepoCollateralSecurityType) {}
        public UnderlyingRepoCollateralSecurityType(int val)
            :base(Tags.UnderlyingRepoCollateralSecurityType, val) {}
    }


    /// <summary>
    /// UnderlyingRepurchaseRate Field
    /// </summary>/
    public sealed class UnderlyingRepurchaseRate : DecimalField
    {
        public UnderlyingRepurchaseRate()
            :base(Tags.UnderlyingRepurchaseRate) {}
        public UnderlyingRepurchaseRate(Decimal val)
            :base(Tags.UnderlyingRepurchaseRate, val) {}
    }


    /// <summary>
    /// UnderlyingRepurchaseTerm Field
    /// </summary>/
    public sealed class UnderlyingRepurchaseTerm : IntField
    {
        public UnderlyingRepurchaseTerm()
            :base(Tags.UnderlyingRepurchaseTerm) {}
        public UnderlyingRepurchaseTerm(int val)
            :base(Tags.UnderlyingRepurchaseTerm, val) {}
    }


    /// <summary>
    /// UnderlyingSecurityAltID Field
    /// </summary>/
    public sealed class UnderlyingSecurityAltID : StringField
    {
        public UnderlyingSecurityAltID()
            :base(Tags.UnderlyingSecurityAltID) {}
        public UnderlyingSecurityAltID(string val)
            :base(Tags.UnderlyingSecurityAltID, val) {}
    }


    /// <summary>
    /// UnderlyingSecurityAltIDSource Field
    /// </summary>/
    public sealed class UnderlyingSecurityAltIDSource : StringField
    {
        public UnderlyingSecurityAltIDSource()
            :base(Tags.UnderlyingSecurityAltIDSource) {}
        public UnderlyingSecurityAltIDSource(string val)
            :base(Tags.UnderlyingSecurityAltIDSource, val) {}
    }


    /// <summary>
    /// UnderlyingSecurityDesc Field
    /// </summary>/
    public sealed class UnderlyingSecurityDesc : StringField
    {
        public UnderlyingSecurityDesc()
            :base(Tags.UnderlyingSecurityDesc) {}
        public UnderlyingSecurityDesc(string val)
            :base(Tags.UnderlyingSecurityDesc, val) {}
    }


    /// <summary>
    /// UnderlyingSecurityExchange Field
    /// </summary>/
    public sealed class UnderlyingSecurityExchange : StringField
    {
        public UnderlyingSecurityExchange()
            :base(Tags.UnderlyingSecurityExchange) {}
        public UnderlyingSecurityExchange(string val)
            :base(Tags.UnderlyingSecurityExchange, val) {}
    }


    /// <summary>
    /// UnderlyingSecurityID Field
    /// </summary>/
    public sealed class UnderlyingSecurityID : StringField
    {
        public UnderlyingSecurityID()
            :base(Tags.UnderlyingSecurityID) {}
        public UnderlyingSecurityID(string val)
            :base(Tags.UnderlyingSecurityID, val) {}
    }


    /// <summary>
    /// UnderlyingSecurityIDSource Field
    /// </summary>/
    public sealed class UnderlyingSecurityIDSource : StringField
    {
        public UnderlyingSecurityIDSource()
            :base(Tags.UnderlyingSecurityIDSource) {}
        public UnderlyingSecurityIDSource(string val)
            :base(Tags.UnderlyingSecurityIDSource, val) {}
    }


    /// <summary>
    /// UnderlyingSecuritySubType Field
    /// </summary>/
    public sealed class UnderlyingSecuritySubType : StringField
    {
        public UnderlyingSecuritySubType()
            :base(Tags.UnderlyingSecuritySubType) {}
        public UnderlyingSecuritySubType(string val)
            :base(Tags.UnderlyingSecuritySubType, val) {}
    }


    /// <summary>
    /// UnderlyingSecurityType Field
    /// </summary>/
    public sealed class UnderlyingSecurityType : StringField
    {
        public UnderlyingSecurityType()
            :base(Tags.UnderlyingSecurityType) {}
        public UnderlyingSecurityType(string val)
            :base(Tags.UnderlyingSecurityType, val) {}
    }


    /// <summary>
    /// UnderlyingSettlPrice Field
    /// </summary>/
    public sealed class UnderlyingSettlPrice : DecimalField
    {
        public UnderlyingSettlPrice()
            :base(Tags.UnderlyingSettlPrice) {}
        public UnderlyingSettlPrice(Decimal val)
            :base(Tags.UnderlyingSettlPrice, val) {}
    }


    /// <summary>
    /// UnderlyingSettlPriceType Field
    /// </summary>/
    public sealed class UnderlyingSettlPriceType : IntField
    {
        public UnderlyingSettlPriceType()
            :base(Tags.UnderlyingSettlPriceType) {}
        public UnderlyingSettlPriceType(int val)
            :base(Tags.UnderlyingSettlPriceType, val) {}
    }


    /// <summary>
    /// UnderlyingStartValue Field
    /// </summary>/
    public sealed class UnderlyingStartValue : DecimalField
    {
        public UnderlyingStartValue()
            :base(Tags.UnderlyingStartValue) {}
        public UnderlyingStartValue(Decimal val)
            :base(Tags.UnderlyingStartValue, val) {}
    }


    /// <summary>
    /// UnderlyingStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class UnderlyingStateOrProvinceOfIssue : StringField
    {
        public UnderlyingStateOrProvinceOfIssue()
            :base(Tags.UnderlyingStateOrProvinceOfIssue) {}
        public UnderlyingStateOrProvinceOfIssue(string val)
            :base(Tags.UnderlyingStateOrProvinceOfIssue, val) {}
    }


    /// <summary>
    /// UnderlyingStipType Field
    /// </summary>/
    public sealed class UnderlyingStipType : StringField
    {
        public UnderlyingStipType()
            :base(Tags.UnderlyingStipType) {}
        public UnderlyingStipType(string val)
            :base(Tags.UnderlyingStipType, val) {}
    }


    /// <summary>
    /// UnderlyingStipValue Field
    /// </summary>/
    public sealed class UnderlyingStipValue : StringField
    {
        public UnderlyingStipValue()
            :base(Tags.UnderlyingStipValue) {}
        public UnderlyingStipValue(string val)
            :base(Tags.UnderlyingStipValue, val) {}
    }


    /// <summary>
    /// UnderlyingStrikeCurrency Field
    /// </summary>/
    public sealed class UnderlyingStrikeCurrency : DecimalField
    {
        public UnderlyingStrikeCurrency()
            :base(Tags.UnderlyingStrikeCurrency) {}
        public UnderlyingStrikeCurrency(Decimal val)
            :base(Tags.UnderlyingStrikeCurrency, val) {}
    }


    /// <summary>
    /// UnderlyingStrikePrice Field
    /// </summary>/
    public sealed class UnderlyingStrikePrice : DecimalField
    {
        public UnderlyingStrikePrice()
            :base(Tags.UnderlyingStrikePrice) {}
        public UnderlyingStrikePrice(Decimal val)
            :base(Tags.UnderlyingStrikePrice, val) {}
    }


    /// <summary>
    /// UnderlyingSymbol Field
    /// </summary>/
    public sealed class UnderlyingSymbol : StringField
    {
        public UnderlyingSymbol()
            :base(Tags.UnderlyingSymbol) {}
        public UnderlyingSymbol(string val)
            :base(Tags.UnderlyingSymbol, val) {}
    }


    /// <summary>
    /// UnderlyingSymbolSfx Field
    /// </summary>/
    public sealed class UnderlyingSymbolSfx : StringField
    {
        public UnderlyingSymbolSfx()
            :base(Tags.UnderlyingSymbolSfx) {}
        public UnderlyingSymbolSfx(string val)
            :base(Tags.UnderlyingSymbolSfx, val) {}
    }


    /// <summary>
    /// UnderlyingTradingSessionID Field
    /// </summary>/
    public sealed class UnderlyingTradingSessionID : StringField
    {
        public UnderlyingTradingSessionID()
            :base(Tags.UnderlyingTradingSessionID) {}
        public UnderlyingTradingSessionID(string val)
            :base(Tags.UnderlyingTradingSessionID, val) {}
    }


    /// <summary>
    /// UnderlyingTradingSessionSubID Field
    /// </summary>/
    public sealed class UnderlyingTradingSessionSubID : StringField
    {
        public UnderlyingTradingSessionSubID()
            :base(Tags.UnderlyingTradingSessionSubID) {}
        public UnderlyingTradingSessionSubID(string val)
            :base(Tags.UnderlyingTradingSessionSubID, val) {}
    }


    /// <summary>
    /// UnsolicitedIndicator Field
    /// </summary>/
    public sealed class UnsolicitedIndicator : BooleanField
    {
        public UnsolicitedIndicator()
            :base(Tags.UnsolicitedIndicator) {}
        public UnsolicitedIndicator(Boolean val)
            :base(Tags.UnsolicitedIndicator, val) {}
    }


    /// <summary>
    /// Urgency Field
    /// </summary>/
    public sealed class Urgency : CharField
    {
        public Urgency()
            :base(Tags.Urgency) {}
        public Urgency(char val)
            :base(Tags.Urgency, val) {}
    }


    /// <summary>
    /// UserRequestID Field
    /// </summary>/
    public sealed class UserRequestID : StringField
    {
        public UserRequestID()
            :base(Tags.UserRequestID) {}
        public UserRequestID(string val)
            :base(Tags.UserRequestID, val) {}
    }


    /// <summary>
    /// UserRequestType Field
    /// </summary>/
    public sealed class UserRequestType : IntField
    {
        public UserRequestType()
            :base(Tags.UserRequestType) {}
        public UserRequestType(int val)
            :base(Tags.UserRequestType, val) {}
    }


    /// <summary>
    /// UserStatus Field
    /// </summary>/
    public sealed class UserStatus : IntField
    {
        public UserStatus()
            :base(Tags.UserStatus) {}
        public UserStatus(int val)
            :base(Tags.UserStatus, val) {}
    }


    /// <summary>
    /// UserStatusText Field
    /// </summary>/
    public sealed class UserStatusText : StringField
    {
        public UserStatusText()
            :base(Tags.UserStatusText) {}
        public UserStatusText(string val)
            :base(Tags.UserStatusText, val) {}
    }


    /// <summary>
    /// Username Field
    /// </summary>/
    public sealed class Username : StringField
    {
        public Username()
            :base(Tags.Username) {}
        public Username(string val)
            :base(Tags.Username, val) {}
    }


    /// <summary>
    /// ValidUntilTime Field
    /// </summary>/
    public sealed class ValidUntilTime : DateTimeField
    {
        public ValidUntilTime()
            :base(Tags.ValidUntilTime) {}
        public ValidUntilTime(DateTime val)
            :base(Tags.ValidUntilTime, val) {}
    }


    /// <summary>
    /// ValueOfFutures Field
    /// </summary>/
    public sealed class ValueOfFutures : DecimalField
    {
        public ValueOfFutures()
            :base(Tags.ValueOfFutures) {}
        public ValueOfFutures(Decimal val)
            :base(Tags.ValueOfFutures, val) {}
    }


    /// <summary>
    /// WaveNo Field
    /// </summary>/
    public sealed class WaveNo : StringField
    {
        public WaveNo()
            :base(Tags.WaveNo) {}
        public WaveNo(string val)
            :base(Tags.WaveNo, val) {}
    }


    /// <summary>
    /// WorkingIndicator Field
    /// </summary>/
    public sealed class WorkingIndicator : BooleanField
    {
        public WorkingIndicator()
            :base(Tags.WorkingIndicator) {}
        public WorkingIndicator(Boolean val)
            :base(Tags.WorkingIndicator, val) {}
    }


    /// <summary>
    /// WtAverageLiquidity Field
    /// </summary>/
    public sealed class WtAverageLiquidity : DecimalField
    {
        public WtAverageLiquidity()
            :base(Tags.WtAverageLiquidity) {}
        public WtAverageLiquidity(Decimal val)
            :base(Tags.WtAverageLiquidity, val) {}
    }


    /// <summary>
    /// XmlData Field
    /// </summary>/
    public sealed class XmlData : StringField
    {
        public XmlData()
            :base(Tags.XmlData) {}
        public XmlData(string val)
            :base(Tags.XmlData, val) {}
    }


    /// <summary>
    /// XmlDataLen Field
    /// </summary>/
    public sealed class XmlDataLen : DecimalField
    {
        public XmlDataLen()
            :base(Tags.XmlDataLen) {}
        public XmlDataLen(Decimal val)
            :base(Tags.XmlDataLen, val) {}
    }


    /// <summary>
    /// Yield Field
    /// </summary>/
    public sealed class Yield : DecimalField
    {
        public Yield()
            :base(Tags.Yield) {}
        public Yield(Decimal val)
            :base(Tags.Yield, val) {}
    }


    /// <summary>
    /// YieldCalcDate Field
    /// </summary>/
    public sealed class YieldCalcDate : DateTimeField
    {
        public YieldCalcDate()
            :base(Tags.YieldCalcDate) {}
        public YieldCalcDate(DateTime val)
            :base(Tags.YieldCalcDate, val) {}
    }


    /// <summary>
    /// YieldRedemptionDate Field
    /// </summary>/
    public sealed class YieldRedemptionDate : DateTimeField
    {
        public YieldRedemptionDate()
            :base(Tags.YieldRedemptionDate) {}
        public YieldRedemptionDate(DateTime val)
            :base(Tags.YieldRedemptionDate, val) {}
    }


    /// <summary>
    /// YieldRedemptionPrice Field
    /// </summary>/
    public sealed class YieldRedemptionPrice : DecimalField
    {
        public YieldRedemptionPrice()
            :base(Tags.YieldRedemptionPrice) {}
        public YieldRedemptionPrice(Decimal val)
            :base(Tags.YieldRedemptionPrice, val) {}
    }


    /// <summary>
    /// YieldRedemptionPriceType Field
    /// </summary>/
    public sealed class YieldRedemptionPriceType : IntField
    {
        public YieldRedemptionPriceType()
            :base(Tags.YieldRedemptionPriceType) {}
        public YieldRedemptionPriceType(int val)
            :base(Tags.YieldRedemptionPriceType, val) {}
    }


    /// <summary>
    /// YieldType Field
    /// </summary>/
    public sealed class YieldType : StringField
    {
        public YieldType()
            :base(Tags.YieldType) {}
        public YieldType(string val)
            :base(Tags.YieldType, val) {}
    }


}
