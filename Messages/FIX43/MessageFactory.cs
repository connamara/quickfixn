// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix.FIX43;

public class MessageFactory : IMessageFactory
{
    public ICollection<string> GetSupportedBeginStrings()
    {
       return new [] { BeginString.FIX43 };
    }

    public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
    {
        return Create(beginString, msgType);
    }

    public QuickFix.Message Create(string beginString, string msgType)
    {
        return msgType switch
        {
            QuickFix.FIX43.Heartbeat.MsgType => new QuickFix.FIX43.Heartbeat(),
            QuickFix.FIX43.Logon.MsgType => new QuickFix.FIX43.Logon(),
            QuickFix.FIX43.TestRequest.MsgType => new QuickFix.FIX43.TestRequest(),
            QuickFix.FIX43.ResendRequest.MsgType => new QuickFix.FIX43.ResendRequest(),
            QuickFix.FIX43.Reject.MsgType => new QuickFix.FIX43.Reject(),
            QuickFix.FIX43.SequenceReset.MsgType => new QuickFix.FIX43.SequenceReset(),
            QuickFix.FIX43.Logout.MsgType => new QuickFix.FIX43.Logout(),
            QuickFix.FIX43.BusinessMessageReject.MsgType => new QuickFix.FIX43.BusinessMessageReject(),
            QuickFix.FIX43.XMLnonFIX.MsgType => new QuickFix.FIX43.XMLnonFIX(),
            QuickFix.FIX43.Advertisement.MsgType => new QuickFix.FIX43.Advertisement(),
            QuickFix.FIX43.IndicationOfInterest.MsgType => new QuickFix.FIX43.IndicationOfInterest(),
            QuickFix.FIX43.News.MsgType => new QuickFix.FIX43.News(),
            QuickFix.FIX43.Email.MsgType => new QuickFix.FIX43.Email(),
            QuickFix.FIX43.QuoteRequest.MsgType => new QuickFix.FIX43.QuoteRequest(),
            QuickFix.FIX43.QuoteRequestReject.MsgType => new QuickFix.FIX43.QuoteRequestReject(),
            QuickFix.FIX43.RFQRequest.MsgType => new QuickFix.FIX43.RFQRequest(),
            QuickFix.FIX43.Quote.MsgType => new QuickFix.FIX43.Quote(),
            QuickFix.FIX43.QuoteCancel.MsgType => new QuickFix.FIX43.QuoteCancel(),
            QuickFix.FIX43.QuoteStatusRequest.MsgType => new QuickFix.FIX43.QuoteStatusRequest(),
            QuickFix.FIX43.QuoteStatusReport.MsgType => new QuickFix.FIX43.QuoteStatusReport(),
            QuickFix.FIX43.MassQuote.MsgType => new QuickFix.FIX43.MassQuote(),
            QuickFix.FIX43.MassQuoteAcknowledgement.MsgType => new QuickFix.FIX43.MassQuoteAcknowledgement(),
            QuickFix.FIX43.MarketDataRequest.MsgType => new QuickFix.FIX43.MarketDataRequest(),
            QuickFix.FIX43.MarketDataSnapshotFullRefresh.MsgType => new QuickFix.FIX43.MarketDataSnapshotFullRefresh(),
            QuickFix.FIX43.MarketDataIncrementalRefresh.MsgType => new QuickFix.FIX43.MarketDataIncrementalRefresh(),
            QuickFix.FIX43.MarketDataRequestReject.MsgType => new QuickFix.FIX43.MarketDataRequestReject(),
            QuickFix.FIX43.SecurityDefinitionRequest.MsgType => new QuickFix.FIX43.SecurityDefinitionRequest(),
            QuickFix.FIX43.SecurityDefinition.MsgType => new QuickFix.FIX43.SecurityDefinition(),
            QuickFix.FIX43.SecurityTypeRequest.MsgType => new QuickFix.FIX43.SecurityTypeRequest(),
            QuickFix.FIX43.SecurityTypes.MsgType => new QuickFix.FIX43.SecurityTypes(),
            QuickFix.FIX43.SecurityListRequest.MsgType => new QuickFix.FIX43.SecurityListRequest(),
            QuickFix.FIX43.SecurityList.MsgType => new QuickFix.FIX43.SecurityList(),
            QuickFix.FIX43.DerivativeSecurityListRequest.MsgType => new QuickFix.FIX43.DerivativeSecurityListRequest(),
            QuickFix.FIX43.DerivativeSecurityList.MsgType => new QuickFix.FIX43.DerivativeSecurityList(),
            QuickFix.FIX43.SecurityStatusRequest.MsgType => new QuickFix.FIX43.SecurityStatusRequest(),
            QuickFix.FIX43.SecurityStatus.MsgType => new QuickFix.FIX43.SecurityStatus(),
            QuickFix.FIX43.TradingSessionStatusRequest.MsgType => new QuickFix.FIX43.TradingSessionStatusRequest(),
            QuickFix.FIX43.TradingSessionStatus.MsgType => new QuickFix.FIX43.TradingSessionStatus(),
            QuickFix.FIX43.NewOrderSingle.MsgType => new QuickFix.FIX43.NewOrderSingle(),
            QuickFix.FIX43.ExecutionReport.MsgType => new QuickFix.FIX43.ExecutionReport(),
            QuickFix.FIX43.DontKnowTrade.MsgType => new QuickFix.FIX43.DontKnowTrade(),
            QuickFix.FIX43.OrderCancelReplaceRequest.MsgType => new QuickFix.FIX43.OrderCancelReplaceRequest(),
            QuickFix.FIX43.OrderCancelRequest.MsgType => new QuickFix.FIX43.OrderCancelRequest(),
            QuickFix.FIX43.OrderCancelReject.MsgType => new QuickFix.FIX43.OrderCancelReject(),
            QuickFix.FIX43.OrderStatusRequest.MsgType => new QuickFix.FIX43.OrderStatusRequest(),
            QuickFix.FIX43.OrderMassCancelRequest.MsgType => new QuickFix.FIX43.OrderMassCancelRequest(),
            QuickFix.FIX43.OrderMassCancelReport.MsgType => new QuickFix.FIX43.OrderMassCancelReport(),
            QuickFix.FIX43.OrderMassStatusRequest.MsgType => new QuickFix.FIX43.OrderMassStatusRequest(),
            QuickFix.FIX43.NewOrderCross.MsgType => new QuickFix.FIX43.NewOrderCross(),
            QuickFix.FIX43.CrossOrderCancelReplaceRequest.MsgType => new QuickFix.FIX43.CrossOrderCancelReplaceRequest(),
            QuickFix.FIX43.CrossOrderCancelRequest.MsgType => new QuickFix.FIX43.CrossOrderCancelRequest(),
            QuickFix.FIX43.NewOrderMultileg.MsgType => new QuickFix.FIX43.NewOrderMultileg(),
            QuickFix.FIX43.MultilegOrderCancelReplaceRequest.MsgType => new QuickFix.FIX43.MultilegOrderCancelReplaceRequest(),
            QuickFix.FIX43.BidRequest.MsgType => new QuickFix.FIX43.BidRequest(),
            QuickFix.FIX43.BidResponse.MsgType => new QuickFix.FIX43.BidResponse(),
            QuickFix.FIX43.NewOrderList.MsgType => new QuickFix.FIX43.NewOrderList(),
            QuickFix.FIX43.ListStrikePrice.MsgType => new QuickFix.FIX43.ListStrikePrice(),
            QuickFix.FIX43.ListExecute.MsgType => new QuickFix.FIX43.ListExecute(),
            QuickFix.FIX43.ListCancelRequest.MsgType => new QuickFix.FIX43.ListCancelRequest(),
            QuickFix.FIX43.ListStatusRequest.MsgType => new QuickFix.FIX43.ListStatusRequest(),
            QuickFix.FIX43.ListStatus.MsgType => new QuickFix.FIX43.ListStatus(),
            QuickFix.FIX43.Allocation.MsgType => new QuickFix.FIX43.Allocation(),
            QuickFix.FIX43.AllocationACK.MsgType => new QuickFix.FIX43.AllocationACK(),
            QuickFix.FIX43.SettlementInstructions.MsgType => new QuickFix.FIX43.SettlementInstructions(),
            QuickFix.FIX43.TradeCaptureReportRequest.MsgType => new QuickFix.FIX43.TradeCaptureReportRequest(),
            QuickFix.FIX43.TradeCaptureReport.MsgType => new QuickFix.FIX43.TradeCaptureReport(),
            QuickFix.FIX43.RegistrationInstructions.MsgType => new QuickFix.FIX43.RegistrationInstructions(),
            QuickFix.FIX43.RegistrationInstructionsResponse.MsgType => new QuickFix.FIX43.RegistrationInstructionsResponse(),
            _ => new QuickFix.Message()
        };
    }

    public Group? Create(string beginString, string msgType, int correspondingFieldId)
    {
        if (QuickFix.FIX43.Logon.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMsgTypes: return new QuickFix.FIX43.Logon.NoMsgTypesGroup();
            }
        }

        if (QuickFix.FIX43.Advertisement.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Advertisement.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.IndicationOfInterest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.IndicationOfInterest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX43.IndicationOfInterest.NoIOIQualifiersGroup();
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.IndicationOfInterest.NoRoutingIDsGroup();
            }
        }

        if (QuickFix.FIX43.News.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.News.NoRoutingIDsGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.News.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.News.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX43.News.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX43.Email.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX43.Email.NoRoutingIDsGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.Email.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Email.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.LinesOfText: return new QuickFix.FIX43.Email.LinesOfTextGroup();
            }
        }

        if (QuickFix.FIX43.QuoteRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.QuoteRequest.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.QuoteRequest.NoRelatedSymGroup.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX43.QuoteRequestReject.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.QuoteRequestReject.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteRequestReject.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.QuoteRequestReject.NoRelatedSymGroup.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX43.RFQRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.RFQRequest.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.RFQRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.Quote.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.Quote.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Quote.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.QuoteCancel.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteCancel.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX43.QuoteCancel.NoQuoteEntriesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteCancel.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.QuoteStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteStatusRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteStatusRequest.NoPartyIDsGroup();
            }
        }

        if (QuickFix.FIX43.QuoteStatusReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.QuoteStatusReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.QuoteStatusReport.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.MassQuote.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MassQuote.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX43.MassQuote.NoQuoteSetsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.MassQuote.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX43.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MassQuote.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.MassQuoteAcknowledgement.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSetsGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MassQuoteAcknowledgement.NoQuoteSetsGroup.NoQuoteEntriesGroup.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.MarketDataRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX43.MarketDataRequest.NoMDEntryTypesGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.MarketDataRequest.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MarketDataRequest.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.MarketDataRequest.NoTradingSessionsGroup();
            }
        }

        if (QuickFix.FIX43.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX43.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
            }
        }

        if (QuickFix.FIX43.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX43.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MarketDataIncrementalRefresh.NoMDEntriesGroup.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.SecurityDefinitionRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityDefinitionRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.SecurityDefinitionRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.SecurityDefinitionRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.SecurityDefinition.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityDefinition.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.SecurityDefinition.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.SecurityDefinition.NoLegsGroup.NoLegSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.SecurityTypes.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX43.SecurityTypes.NoSecurityTypesGroup();
            }
        }

        if (QuickFix.FIX43.SecurityListRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityListRequest.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.SecurityList.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.SecurityList.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.SecurityList.NoRelatedSymGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.SecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.DerivativeSecurityListRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.DerivativeSecurityList.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSymGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.DerivativeSecurityList.NoRelatedSymGroup.NoLegsGroup.NoLegSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.SecurityStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityStatusRequest.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.SecurityStatus.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.SecurityStatus.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.NewOrderSingle.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderSingle.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderSingle.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.NewOrderSingle.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderSingle.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderSingle.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.NewOrderSingle.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX43.ExecutionReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.ExecutionReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX43.ExecutionReport.NoContraBrokersGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.ExecutionReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.ExecutionReport.NoStipulationsGroup();
                case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX43.ExecutionReport.NoContAmtsGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.ExecutionReport.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.ExecutionReport.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.ExecutionReport.NoLegsGroup.NoNestedPartyIDsGroup();
            }
        }

        if (QuickFix.FIX43.DontKnowTrade.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.DontKnowTrade.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.OrderCancelReplaceRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.OrderCancelRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderCancelRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderCancelRequest.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.OrderStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderStatusRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderStatusRequest.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.OrderMassCancelRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassCancelRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.OrderMassCancelReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX43.OrderMassCancelReport.NoAffectedOrdersGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassCancelReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.OrderMassStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.OrderMassStatusRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.OrderMassStatusRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX43.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.NewOrderCross.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.NewOrderCross.NoSidesGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderCross.NoSidesGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderCross.NoSidesGroup.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.NewOrderCross.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderCross.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderCross.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.NewOrderCross.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX43.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSidesGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSidesGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSidesGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX43.CrossOrderCancelRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.CrossOrderCancelRequest.NoSidesGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.CrossOrderCancelRequest.NoSidesGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.CrossOrderCancelRequest.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.NewOrderMultileg.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderMultileg.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderMultileg.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderMultileg.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderMultileg.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.NewOrderMultileg.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.NewOrderMultileg.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.NewOrderMultileg.NoLegsGroup.NoNestedPartyIDsGroup();
            }
        }

        if (QuickFix.FIX43.MultilegOrderCancelReplaceRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoLegsGroup();
                case QuickFix.Fields.Tags.NoLegSecurityAltID: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoLegSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest.NoLegsGroup.NoNestedPartyIDsGroup();
            }
        }

        if (QuickFix.FIX43.BidRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX43.BidRequest.NoBidDescriptorsGroup();
                case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX43.BidRequest.NoBidComponentsGroup();
            }
        }

        if (QuickFix.FIX43.BidResponse.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX43.BidResponse.NoBidComponentsGroup();
            }
        }

        if (QuickFix.FIX43.NewOrderList.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoTradingSessionsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX43.NewOrderList.NoOrdersGroup.NoStipulationsGroup();
            }
        }

        if (QuickFix.FIX43.ListStrikePrice.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX43.ListStrikePrice.NoStrikesGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.ListStrikePrice.NoStrikesGroup.NoSecurityAltIDGroup();
            }
        }

        if (QuickFix.FIX43.ListStatus.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.ListStatus.NoOrdersGroup();
            }
        }

        if (QuickFix.FIX43.Allocation.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX43.Allocation.NoOrdersGroup();
                case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX43.Allocation.NoExecsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.Allocation.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.Allocation.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX43.Allocation.NoAllocsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.Allocation.NoAllocsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX43.Allocation.NoAllocsGroup.NoMiscFeesGroup();
            }
        }

        if (QuickFix.FIX43.AllocationACK.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.AllocationACK.NoPartyIDsGroup();
            }
        }

        if (QuickFix.FIX43.SettlementInstructions.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.SettlementInstructions.NoPartyIDsGroup();
            }
        }

        if (QuickFix.FIX43.TradeCaptureReportRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.TradeCaptureReportRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.TradeCaptureReportRequest.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX43.TradeCaptureReportRequest.NoDatesGroup();
            }
        }

        if (QuickFix.FIX43.TradeCaptureReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX43.TradeCaptureReport.NoSecurityAltIDGroup();
                case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoClearingInstructions: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup.NoClearingInstructionsGroup();
                case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup.NoContAmtsGroup();
                case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX43.TradeCaptureReport.NoSidesGroup.NoMiscFeesGroup();
            }
        }

        if (QuickFix.FIX43.RegistrationInstructions.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.RegistrationInstructions.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX43.RegistrationInstructions.NoRegistDtlsGroup();
                case QuickFix.Fields.Tags.NoNestedPartyIDs: return new QuickFix.FIX43.RegistrationInstructions.NoRegistDtlsGroup.NoNestedPartyIDsGroup();
                case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX43.RegistrationInstructions.NoDistribInstsGroup();
            }
        }

        if (QuickFix.FIX43.RegistrationInstructionsResponse.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX43.RegistrationInstructionsResponse.NoPartyIDsGroup();
            }
        }

        return null;
    }
}
