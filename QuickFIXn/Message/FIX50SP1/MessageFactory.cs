// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX50SP1
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX50SP1.IOI.MsgType: return new QuickFix.FIX50SP1.IOI();
                    case QuickFix.FIX50SP1.Advertisement.MsgType: return new QuickFix.FIX50SP1.Advertisement();
                    case QuickFix.FIX50SP1.ExecutionReport.MsgType: return new QuickFix.FIX50SP1.ExecutionReport();
                    case QuickFix.FIX50SP1.OrderCancelReject.MsgType: return new QuickFix.FIX50SP1.OrderCancelReject();
                    case QuickFix.FIX50SP1.News.MsgType: return new QuickFix.FIX50SP1.News();
                    case QuickFix.FIX50SP1.Email.MsgType: return new QuickFix.FIX50SP1.Email();
                    case QuickFix.FIX50SP1.NewOrderSingle.MsgType: return new QuickFix.FIX50SP1.NewOrderSingle();
                    case QuickFix.FIX50SP1.NewOrderList.MsgType: return new QuickFix.FIX50SP1.NewOrderList();
                    case QuickFix.FIX50SP1.OrderCancelRequest.MsgType: return new QuickFix.FIX50SP1.OrderCancelRequest();
                    case QuickFix.FIX50SP1.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest();
                    case QuickFix.FIX50SP1.OrderStatusRequest.MsgType: return new QuickFix.FIX50SP1.OrderStatusRequest();
                    case QuickFix.FIX50SP1.AllocationInstruction.MsgType: return new QuickFix.FIX50SP1.AllocationInstruction();
                    case QuickFix.FIX50SP1.ListCancelRequest.MsgType: return new QuickFix.FIX50SP1.ListCancelRequest();
                    case QuickFix.FIX50SP1.ListExecute.MsgType: return new QuickFix.FIX50SP1.ListExecute();
                    case QuickFix.FIX50SP1.ListStatusRequest.MsgType: return new QuickFix.FIX50SP1.ListStatusRequest();
                    case QuickFix.FIX50SP1.ListStatus.MsgType: return new QuickFix.FIX50SP1.ListStatus();
                    case QuickFix.FIX50SP1.AllocationInstructionAck.MsgType: return new QuickFix.FIX50SP1.AllocationInstructionAck();
                    case QuickFix.FIX50SP1.DontKnowTrade.MsgType: return new QuickFix.FIX50SP1.DontKnowTrade();
                    case QuickFix.FIX50SP1.QuoteRequest.MsgType: return new QuickFix.FIX50SP1.QuoteRequest();
                    case QuickFix.FIX50SP1.Quote.MsgType: return new QuickFix.FIX50SP1.Quote();
                    case QuickFix.FIX50SP1.SettlementInstructions.MsgType: return new QuickFix.FIX50SP1.SettlementInstructions();
                    case QuickFix.FIX50SP1.MarketDataRequest.MsgType: return new QuickFix.FIX50SP1.MarketDataRequest();
                    case QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX50SP1.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh();
                    case QuickFix.FIX50SP1.MarketDataRequestReject.MsgType: return new QuickFix.FIX50SP1.MarketDataRequestReject();
                    case QuickFix.FIX50SP1.QuoteCancel.MsgType: return new QuickFix.FIX50SP1.QuoteCancel();
                    case QuickFix.FIX50SP1.QuoteStatusRequest.MsgType: return new QuickFix.FIX50SP1.QuoteStatusRequest();
                    case QuickFix.FIX50SP1.MassQuoteAcknowledgement.MsgType: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement();
                    case QuickFix.FIX50SP1.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX50SP1.SecurityDefinitionRequest();
                    case QuickFix.FIX50SP1.SecurityDefinition.MsgType: return new QuickFix.FIX50SP1.SecurityDefinition();
                    case QuickFix.FIX50SP1.SecurityStatusRequest.MsgType: return new QuickFix.FIX50SP1.SecurityStatusRequest();
                    case QuickFix.FIX50SP1.SecurityStatus.MsgType: return new QuickFix.FIX50SP1.SecurityStatus();
                    case QuickFix.FIX50SP1.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX50SP1.TradingSessionStatusRequest();
                    case QuickFix.FIX50SP1.TradingSessionStatus.MsgType: return new QuickFix.FIX50SP1.TradingSessionStatus();
                    case QuickFix.FIX50SP1.MassQuote.MsgType: return new QuickFix.FIX50SP1.MassQuote();
                    case QuickFix.FIX50SP1.BusinessMessageReject.MsgType: return new QuickFix.FIX50SP1.BusinessMessageReject();
                    case QuickFix.FIX50SP1.BidRequest.MsgType: return new QuickFix.FIX50SP1.BidRequest();
                    case QuickFix.FIX50SP1.BidResponse.MsgType: return new QuickFix.FIX50SP1.BidResponse();
                    case QuickFix.FIX50SP1.ListStrikePrice.MsgType: return new QuickFix.FIX50SP1.ListStrikePrice();
                    case QuickFix.FIX50SP1.RegistrationInstructions.MsgType: return new QuickFix.FIX50SP1.RegistrationInstructions();
                    case QuickFix.FIX50SP1.RegistrationInstructionsResponse.MsgType: return new QuickFix.FIX50SP1.RegistrationInstructionsResponse();
                    case QuickFix.FIX50SP1.OrderMassCancelRequest.MsgType: return new QuickFix.FIX50SP1.OrderMassCancelRequest();
                    case QuickFix.FIX50SP1.OrderMassCancelReport.MsgType: return new QuickFix.FIX50SP1.OrderMassCancelReport();
                    case QuickFix.FIX50SP1.NewOrderCross.MsgType: return new QuickFix.FIX50SP1.NewOrderCross();
                    case QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest();
                    case QuickFix.FIX50SP1.CrossOrderCancelRequest.MsgType: return new QuickFix.FIX50SP1.CrossOrderCancelRequest();
                    case QuickFix.FIX50SP1.SecurityTypeRequest.MsgType: return new QuickFix.FIX50SP1.SecurityTypeRequest();
                    case QuickFix.FIX50SP1.SecurityTypes.MsgType: return new QuickFix.FIX50SP1.SecurityTypes();
                    case QuickFix.FIX50SP1.SecurityListRequest.MsgType: return new QuickFix.FIX50SP1.SecurityListRequest();
                    case QuickFix.FIX50SP1.SecurityList.MsgType: return new QuickFix.FIX50SP1.SecurityList();
                    case QuickFix.FIX50SP1.DerivativeSecurityListRequest.MsgType: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest();
                    case QuickFix.FIX50SP1.DerivativeSecurityList.MsgType: return new QuickFix.FIX50SP1.DerivativeSecurityList();
                    case QuickFix.FIX50SP1.NewOrderMultileg.MsgType: return new QuickFix.FIX50SP1.NewOrderMultileg();
                    case QuickFix.FIX50SP1.MultilegOrderCancelReplace.MsgType: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace();
                    case QuickFix.FIX50SP1.TradeCaptureReportRequest.MsgType: return new QuickFix.FIX50SP1.TradeCaptureReportRequest();
                    case QuickFix.FIX50SP1.TradeCaptureReport.MsgType: return new QuickFix.FIX50SP1.TradeCaptureReport();
                    case QuickFix.FIX50SP1.OrderMassStatusRequest.MsgType: return new QuickFix.FIX50SP1.OrderMassStatusRequest();
                    case QuickFix.FIX50SP1.QuoteRequestReject.MsgType: return new QuickFix.FIX50SP1.QuoteRequestReject();
                    case QuickFix.FIX50SP1.RFQRequest.MsgType: return new QuickFix.FIX50SP1.RFQRequest();
                    case QuickFix.FIX50SP1.QuoteStatusReport.MsgType: return new QuickFix.FIX50SP1.QuoteStatusReport();
                    case QuickFix.FIX50SP1.QuoteResponse.MsgType: return new QuickFix.FIX50SP1.QuoteResponse();
                    case QuickFix.FIX50SP1.Confirmation.MsgType: return new QuickFix.FIX50SP1.Confirmation();
                    case QuickFix.FIX50SP1.PositionMaintenanceRequest.MsgType: return new QuickFix.FIX50SP1.PositionMaintenanceRequest();
                    case QuickFix.FIX50SP1.PositionMaintenanceReport.MsgType: return new QuickFix.FIX50SP1.PositionMaintenanceReport();
                    case QuickFix.FIX50SP1.RequestForPositions.MsgType: return new QuickFix.FIX50SP1.RequestForPositions();
                    case QuickFix.FIX50SP1.RequestForPositionsAck.MsgType: return new QuickFix.FIX50SP1.RequestForPositionsAck();
                    case QuickFix.FIX50SP1.PositionReport.MsgType: return new QuickFix.FIX50SP1.PositionReport();
                    case QuickFix.FIX50SP1.TradeCaptureReportRequestAck.MsgType: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck();
                    case QuickFix.FIX50SP1.TradeCaptureReportAck.MsgType: return new QuickFix.FIX50SP1.TradeCaptureReportAck();
                    case QuickFix.FIX50SP1.AllocationReport.MsgType: return new QuickFix.FIX50SP1.AllocationReport();
                    case QuickFix.FIX50SP1.AllocationReportAck.MsgType: return new QuickFix.FIX50SP1.AllocationReportAck();
                    case QuickFix.FIX50SP1.ConfirmationAck.MsgType: return new QuickFix.FIX50SP1.ConfirmationAck();
                    case QuickFix.FIX50SP1.SettlementInstructionRequest.MsgType: return new QuickFix.FIX50SP1.SettlementInstructionRequest();
                    case QuickFix.FIX50SP1.AssignmentReport.MsgType: return new QuickFix.FIX50SP1.AssignmentReport();
                    case QuickFix.FIX50SP1.CollateralRequest.MsgType: return new QuickFix.FIX50SP1.CollateralRequest();
                    case QuickFix.FIX50SP1.CollateralAssignment.MsgType: return new QuickFix.FIX50SP1.CollateralAssignment();
                    case QuickFix.FIX50SP1.CollateralResponse.MsgType: return new QuickFix.FIX50SP1.CollateralResponse();
                    case QuickFix.FIX50SP1.CollateralReport.MsgType: return new QuickFix.FIX50SP1.CollateralReport();
                    case QuickFix.FIX50SP1.CollateralInquiry.MsgType: return new QuickFix.FIX50SP1.CollateralInquiry();
                    case QuickFix.FIX50SP1.NetworkCounterpartySystemStatusRequest.MsgType: return new QuickFix.FIX50SP1.NetworkCounterpartySystemStatusRequest();
                    case QuickFix.FIX50SP1.NetworkCounterpartySystemStatusResponse.MsgType: return new QuickFix.FIX50SP1.NetworkCounterpartySystemStatusResponse();
                    case QuickFix.FIX50SP1.UserRequest.MsgType: return new QuickFix.FIX50SP1.UserRequest();
                    case QuickFix.FIX50SP1.UserResponse.MsgType: return new QuickFix.FIX50SP1.UserResponse();
                    case QuickFix.FIX50SP1.CollateralInquiryAck.MsgType: return new QuickFix.FIX50SP1.CollateralInquiryAck();
                    case QuickFix.FIX50SP1.ConfirmationRequest.MsgType: return new QuickFix.FIX50SP1.ConfirmationRequest();
                    case QuickFix.FIX50SP1.ContraryIntentionReport.MsgType: return new QuickFix.FIX50SP1.ContraryIntentionReport();
                    case QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.MsgType: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport();
                    case QuickFix.FIX50SP1.SecurityListUpdateReport.MsgType: return new QuickFix.FIX50SP1.SecurityListUpdateReport();
                    case QuickFix.FIX50SP1.AdjustedPositionReport.MsgType: return new QuickFix.FIX50SP1.AdjustedPositionReport();
                    case QuickFix.FIX50SP1.AllocationInstructionAlert.MsgType: return new QuickFix.FIX50SP1.AllocationInstructionAlert();
                    case QuickFix.FIX50SP1.ExecutionAcknowledgement.MsgType: return new QuickFix.FIX50SP1.ExecutionAcknowledgement();
                    case QuickFix.FIX50SP1.TradingSessionList.MsgType: return new QuickFix.FIX50SP1.TradingSessionList();
                    case QuickFix.FIX50SP1.TradingSessionListRequest.MsgType: return new QuickFix.FIX50SP1.TradingSessionListRequest();
                    case QuickFix.FIX50SP1.SettlementObligationReport.MsgType: return new QuickFix.FIX50SP1.SettlementObligationReport();
                    case QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.MsgType: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport();
                    case QuickFix.FIX50SP1.TradingSessionListUpdateReport.MsgType: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport();
                    case QuickFix.FIX50SP1.MarketDefinitionRequest.MsgType: return new QuickFix.FIX50SP1.MarketDefinitionRequest();
                    case QuickFix.FIX50SP1.MarketDefinition.MsgType: return new QuickFix.FIX50SP1.MarketDefinition();
                    case QuickFix.FIX50SP1.MarketDefinitionUpdateReport.MsgType: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport();
                    case QuickFix.FIX50SP1.ApplicationMessageRequest.MsgType: return new QuickFix.FIX50SP1.ApplicationMessageRequest();
                    case QuickFix.FIX50SP1.ApplicationMessageRequestAck.MsgType: return new QuickFix.FIX50SP1.ApplicationMessageRequestAck();
                    case QuickFix.FIX50SP1.ApplicationMessageReport.MsgType: return new QuickFix.FIX50SP1.ApplicationMessageReport();
                    case QuickFix.FIX50SP1.OrderMassActionReport.MsgType: return new QuickFix.FIX50SP1.OrderMassActionReport();
                    case QuickFix.FIX50SP1.OrderMassActionRequest.MsgType: return new QuickFix.FIX50SP1.OrderMassActionRequest();
                    case QuickFix.FIX50SP1.UserNotification.MsgType: return new QuickFix.FIX50SP1.UserNotification();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX50SP1.IOI.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.IOI.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.IOI.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.IOI.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.IOI.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.IOI.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.IOI.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50SP1.IOI.NoIOIQualifiersGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.IOI.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.IOI.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Advertisement.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Advertisement.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Advertisement.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Advertisement.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Advertisement.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50SP1.ExecutionReport.NoContraBrokersGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ExecutionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ExecutionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ExecutionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ExecutionReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.ExecutionReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP1.ExecutionReport.NoContAmtsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.ExecutionReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.ExecutionReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.ExecutionReport.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.ExecutionReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.ExecutionReport.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoFills: return new QuickFix.FIX50SP1.ExecutionReport.NoFillsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.News.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.News.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.News.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP1.News.NoLinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX50SP1.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.Email.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.Email.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Email.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Email.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP1.Email.NoLinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX50SP1.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.NewOrderSingle.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.NewOrderSingle.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderSingle.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderSingle.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderSingle.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderSingle.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderSingle.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.NewOrderSingle.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderSingle.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.NewOrderSingle.NoTrdRegTimestampsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.NewOrderList.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.NewOrderList.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderCancelRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderCancelRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoTrdRegTimestampsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderStatusRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationInstruction.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationInstruction.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstruction.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationInstruction.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationInstruction.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationInstruction.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationInstruction.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationInstruction.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationInstruction.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationInstruction.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ListCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ListCancelRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.ListStatus.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.DontKnowTrade.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.DontKnowTrade.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.DontKnowTrade.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.DontKnowTrade.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.DontKnowTrade.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.Quote.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.Quote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Quote.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Quote.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Quote.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Quote.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.Quote.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Quote.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50SP1.SettlementInstructions.NoSettlInstGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50SP1.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.MarketDataRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MarketDataRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50SP1.MarketDataRequestReject.NoAltMDSourceGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MarketDataRequestReject.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteCancel.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSetsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinition.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinition.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinition.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinition.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinition.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinition.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinition.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegmentsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatus.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityStatus.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityStatus.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityStatus.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityStatus.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityStatus.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.TradingSessionStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradingSessionStatus.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradingSessionStatus.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradingSessionStatus.NoInstrumentPartiesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MassQuote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSetsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50SP1.BidRequest.NoBidDescriptorsGroup();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP1.BidRequest.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP1.BidResponse.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RegistrationInstructions.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50SP1.RegistrationInstructions.NoRegistDtlsGroup();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50SP1.RegistrationInstructions.NoDistribInstsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RegistrationInstructionsResponse.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoAffectedOrdersGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoNotAffectedOrdersGroup();
                    }
                }

                if (QuickFix.FIX50SP1.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.NewOrderCross.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderCross.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderCross.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderCross.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderCross.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.NewOrderCross.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderCross.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.NewOrderCross.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderCross.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50SP1.SecurityTypes.NoSecurityTypesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityListRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityListRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityListRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityListRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityListRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityListRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP1.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeEventsGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeInstrumentPartiesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeEventsGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegmentsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderMultileg.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderMultileg.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderMultileg.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderMultileg.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderMultileg.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderMultileg.NoStrategyParametersGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MultilegOrderCancelReplace.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoStrategyParametersGroup();
                    }
                }

                if (QuickFix.FIX50SP1.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoDatesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.TradeCaptureReport.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.TradeCaptureReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoRootPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP1.TradeCaptureReport.NoTrdRepIndicatorsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RFQRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteStatusReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteStatusReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteStatusReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.QuoteStatusReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.QuoteStatusReport.NoQuoteQualifiersGroup();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.QuoteResponse.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteResponse.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteResponse.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteResponse.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteResponse.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.QuoteResponse.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteResponse.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.Confirmation.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.Confirmation.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.Confirmation.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Confirmation.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Confirmation.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Confirmation.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.Confirmation.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Confirmation.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Confirmation.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50SP1.Confirmation.NoCapacitiesGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.Confirmation.NoDlvyInstGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.Confirmation.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.Confirmation.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP1.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP1.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RequestForPositions.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositions.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.RequestForPositions.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.RequestForPositions.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.RequestForPositions.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.RequestForPositions.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.RequestForPositions.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP1.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoRootPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoTrdRepIndicatorsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationReport.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationReport.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationReport.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationReport.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationReportAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationReportAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.SettlementInstructionRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AssignmentReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AssignmentReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AssignmentReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AssignmentReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AssignmentReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AssignmentReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.AssignmentReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AssignmentReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralRequest.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralRequest.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralRequest.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralRequest.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralAssignment.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralAssignment.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralAssignment.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralAssignment.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralAssignment.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralAssignment.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralAssignment.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralAssignment.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralAssignment.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralAssignment.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralAssignment.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralAssignment.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralResponse.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralResponse.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralResponse.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralResponse.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralResponse.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralResponse.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralResponse.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralResponse.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralResponse.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralResponse.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralReport.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralReport.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralReport.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP1.CollateralInquiry.NoCollInquiryQualifierGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralInquiry.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralInquiry.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralInquiry.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiry.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralInquiry.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralInquiry.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralInquiry.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralInquiry.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralInquiry.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralInquiry.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralInquiry.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50SP1.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP1.NetworkCounterpartySystemStatusRequest.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP1.NetworkCounterpartySystemStatusResponse.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoCollInquiryQualifierGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.ConfirmationRequest.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ContraryIntentionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoExpirationGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegmentsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP1.AdjustedPositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationInstructionAlert.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ExecutionAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.TradingSessionList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.TradingSessionList.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.SettlementObligationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlOblig: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlObligGroup();
                    }
                }

                if (QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeEventsGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegmentsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP1.TradingSessionListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.MarketDefinition.NoTickRulesGroup();
                        case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.MarketDefinition.NoLotTypeRulesGroup();
                        case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.MarketDefinition.NoOrdTypeRulesGroup();
                        case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.MarketDefinition.NoTimeInForceRulesGroup();
                        case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.MarketDefinition.NoExecInstRulesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoTickRulesGroup();
                        case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoLotTypeRulesGroup();
                        case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoOrdTypeRulesGroup();
                        case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoTimeInForceRulesGroup();
                        case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoExecInstRulesGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ApplicationMessageRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageRequest.NoApplIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ApplicationMessageRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageRequestAck.NoApplIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.ApplicationMessageReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageReport.NoApplIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassActionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP1.OrderMassActionReport.NoAffectedOrdersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassActionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassActionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP1.OrderMassActionReport.NoNotAffectedOrdersGroup();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassActionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUndlyInstrumentPartiesGroup();
                    }
                }

                return null;
            }

        }
    }
}
