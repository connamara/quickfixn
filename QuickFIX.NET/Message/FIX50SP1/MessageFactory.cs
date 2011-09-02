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
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.IOI.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.IOI.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.IOI.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.IOI.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.IOI.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.IOI.NoLegs();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50SP1.IOI.NoIOIQualifiers();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.IOI.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.IOI.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Advertisement.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Advertisement.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Advertisement.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Advertisement.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Advertisement.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP1.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ExecutionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50SP1.ExecutionReport.NoContraBrokers();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ExecutionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ExecutionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ExecutionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ExecutionReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.ExecutionReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50SP1.ExecutionReport.NoContAmts();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.ExecutionReport.NoLegs();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.ExecutionReport.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.ExecutionReport.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.ExecutionReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.ExecutionReport.NoAllocs();
                        case QuickFix.Fields.Tags.NoFills: return new QuickFix.FIX50SP1.ExecutionReport.NoFills();
                    }
                }

                if (QuickFix.FIX50SP1.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.News.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.News.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.News.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.News.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP1.News.NoLinesOfText();
                    }
                }

                if (QuickFix.FIX50SP1.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.Email.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.Email.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Email.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Email.NoLegs();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP1.Email.NoLinesOfText();
                    }
                }

                if (QuickFix.FIX50SP1.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.NewOrderSingle.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.NewOrderSingle.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderSingle.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderSingle.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderSingle.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderSingle.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderSingle.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.NewOrderSingle.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderSingle.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.NewOrderSingle.NoTrdRegTimestamps();
                    }
                }

                if (QuickFix.FIX50SP1.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.NewOrderList.NoOrders();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.NewOrderList.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderCancelRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderCancelRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP1.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.OrderCancelReplaceRequest.NoTrdRegTimestamps();
                    }
                }

                if (QuickFix.FIX50SP1.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.OrderStatusRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationInstruction.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationInstruction.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstruction.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationInstruction.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationInstruction.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationInstruction.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationInstruction.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationInstruction.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstruction.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationInstruction.NoStipulations();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstruction.NoAllocs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationInstruction.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP1.ListCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ListCancelRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.ListStatus.NoOrders();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstructionAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX50SP1.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.DontKnowTrade.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.DontKnowTrade.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.DontKnowTrade.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.DontKnowTrade.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.DontKnowTrade.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.QuoteRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.QuoteRequest.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.Quote.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.Quote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Quote.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Quote.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Quote.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Quote.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.Quote.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Quote.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP1.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50SP1.SettlementInstructions.NoSettlInst();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50SP1.MarketDataRequest.NoMDEntryTypes();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.MarketDataRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.MarketDataRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MarketDataRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoLegs();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoMDEntries();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.MarketDataSnapshotFullRefresh.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoMDEntries();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50SP1.MarketDataIncrementalRefresh.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50SP1.MarketDataRequestReject.NoAltMDSource();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MarketDataRequestReject.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteCancel.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP1.QuoteCancel.NoQuoteEntries();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteStatusRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP1.MassQuoteAcknowledgement.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinitionRequest.NoStipulations();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinition.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinition.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinition.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinition.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinition.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinition.NoLegs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinition.NoStipulations();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.SecurityDefinition.NoMarketSegments();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityStatusRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityStatus.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityStatus.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityStatus.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityStatus.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityStatus.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityStatus.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP1.TradingSessionStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradingSessionStatus.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradingSessionStatus.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradingSessionStatus.NoInstrumentParties();
                    }
                }

                if (QuickFix.FIX50SP1.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MassQuote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50SP1.MassQuote.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX50SP1.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50SP1.BidRequest.NoBidDescriptors();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP1.BidRequest.NoBidComponents();
                    }
                }

                if (QuickFix.FIX50SP1.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50SP1.BidResponse.NoBidComponents();
                    }
                }

                if (QuickFix.FIX50SP1.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50SP1.ListStrikePrice.NoStrikes();
                    }
                }

                if (QuickFix.FIX50SP1.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RegistrationInstructions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50SP1.RegistrationInstructions.NoRegistDtls();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50SP1.RegistrationInstructions.NoDistribInsts();
                    }
                }

                if (QuickFix.FIX50SP1.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RegistrationInstructionsResponse.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassCancelRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoAffectedOrders();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP1.OrderMassCancelReport.NoNotAffectedOrders();
                    }
                }

                if (QuickFix.FIX50SP1.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.NewOrderCross.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderCross.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderCross.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderCross.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderCross.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.NewOrderCross.NoLegs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderCross.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.NewOrderCross.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderCross.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.NewOrderCross.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelReplaceRequest.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.CrossOrderCancelRequest.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50SP1.SecurityTypes.NoSecurityTypes();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityListRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityListRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityListRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityListRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityListRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityListRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.SecurityList.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50SP1.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeSecurityAltID();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeEvents();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListRequest.NoDerivativeInstrumentParties();
                    }
                }

                if (QuickFix.FIX50SP1.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeSecurityAltID();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeEvents();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeInstrumentParties();
                        case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoDerivativeInstrAttrib();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.DerivativeSecurityList.NoMarketSegments();
                    }
                }

                if (QuickFix.FIX50SP1.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.NewOrderMultileg.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.NewOrderMultileg.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.NewOrderMultileg.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.NewOrderMultileg.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.NewOrderMultileg.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.NewOrderMultileg.NoLegs();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.NewOrderMultileg.NoStrategyParameters();
                    }
                }

                if (QuickFix.FIX50SP1.MultilegOrderCancelReplace.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoLegs();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50SP1.MultilegOrderCancelReplace.NoStrategyParameters();
                    }
                }

                if (QuickFix.FIX50SP1.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50SP1.TradeCaptureReportRequest.NoDates();
                    }
                }

                if (QuickFix.FIX50SP1.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.TradeCaptureReport.NoPosAmt();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoLegs();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.TradeCaptureReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.TradeCaptureReport.NoSides();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReport.NoRootPartyIDs();
                        case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP1.TradeCaptureReport.NoTrdRepIndicators();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassStatusRequest.NoUndlyInstrumentParties();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.QuoteRequestReject.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.RFQRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RFQRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteStatusReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteStatusReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteStatusReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteStatusReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.QuoteStatusReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteStatusReport.NoLegs();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.QuoteStatusReport.NoQuoteQualifiers();
                    }
                }

                if (QuickFix.FIX50SP1.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50SP1.QuoteResponse.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.QuoteResponse.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.QuoteResponse.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.QuoteResponse.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.QuoteResponse.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.QuoteResponse.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.QuoteResponse.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.QuoteResponse.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP1.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.Confirmation.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.Confirmation.NoOrders();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.Confirmation.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.Confirmation.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.Confirmation.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.Confirmation.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.Confirmation.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.Confirmation.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.Confirmation.NoLegs();
                        case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50SP1.Confirmation.NoCapacities();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.Confirmation.NoDlvyInst();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.Confirmation.NoStipulations();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.Confirmation.NoMiscFees();
                    }
                }

                if (QuickFix.FIX50SP1.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionMaintenanceRequest.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP1.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionMaintenanceReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP1.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RequestForPositions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositions.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.RequestForPositions.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.RequestForPositions.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.RequestForPositions.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.RequestForPositions.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.RequestForPositions.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX50SP1.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.RequestForPositionsAck.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP1.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.PositionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.PositionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.PositionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.PositionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.PositionReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.PositionReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.PositionReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.PositionReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP1.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportRequestAck.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP1.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoLegs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoPosAmt();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoSides();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoRootPartyIDs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRepIndicators: return new QuickFix.FIX50SP1.TradeCaptureReportAck.NoTrdRepIndicators();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationReport.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationReport.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationReport.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationReport.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationReport.NoAllocs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationReportAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationReportAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX50SP1.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.SettlementInstructionRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50SP1.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AssignmentReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AssignmentReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AssignmentReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AssignmentReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AssignmentReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AssignmentReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.AssignmentReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AssignmentReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralRequest.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralRequest.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralRequest.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralRequest.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralRequest.NoStipulations();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralAssignment.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralAssignment.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralAssignment.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralAssignment.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralAssignment.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralAssignment.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralAssignment.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralAssignment.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralAssignment.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralAssignment.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralAssignment.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralAssignment.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralResponse.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralResponse.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralResponse.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralResponse.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralResponse.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralResponse.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralResponse.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralResponse.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralResponse.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralResponse.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralResponse.NoStipulations();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralReport.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralReport.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50SP1.CollateralReport.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralReport.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP1.CollateralInquiry.NoCollInquiryQualifier();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralInquiry.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralInquiry.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralInquiry.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiry.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralInquiry.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralInquiry.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralInquiry.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralInquiry.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50SP1.CollateralInquiry.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.CollateralInquiry.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50SP1.CollateralInquiry.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50SP1.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP1.NetworkCounterpartySystemStatusRequest.NoCompIDs();
                    }
                }

                if (QuickFix.FIX50SP1.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50SP1.NetworkCounterpartySystemStatusResponse.NoCompIDs();
                    }
                }

                if (QuickFix.FIX50SP1.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoCollInquiryQualifier();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.CollateralInquiryAck.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP1.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.ConfirmationRequest.NoOrders();
                    }
                }

                if (QuickFix.FIX50SP1.ContraryIntentionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoExpiration();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ContraryIntentionReport.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoLegs();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.SecurityDefinitionUpdateReport.NoMarketSegments();
                    }
                }

                if (QuickFix.FIX50SP1.SecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.SecurityListUpdateReport.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50SP1.AdjustedPositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoPositions();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.AdjustedPositionReport.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50SP1.AllocationInstructionAlert.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoStipulations();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoPosAmt();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50SP1.AllocationInstructionAlert.NoAllocs();
                    }
                }

                if (QuickFix.FIX50SP1.ExecutionAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50SP1.ExecutionAcknowledgement.NoLegs();
                    }
                }

                if (QuickFix.FIX50SP1.TradingSessionList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.TradingSessionList.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX50SP1.SettlementObligationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlOblig: return new QuickFix.FIX50SP1.SettlementObligationReport.NoSettlOblig();
                    }
                }

                if (QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoDerivativeSecurityAltID: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeSecurityAltID();
                        case QuickFix.Fields.Tags.NoDerivativeEvents: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeEvents();
                        case QuickFix.Fields.Tags.NoDerivativeInstrumentParties: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeInstrumentParties();
                        case QuickFix.Fields.Tags.NoDerivativeInstrAttrib: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoDerivativeInstrAttrib();
                        case QuickFix.Fields.Tags.NoMarketSegments: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoMarketSegments();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP1.DerivativeSecurityListUpdateReport.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50SP1.TradingSessionListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50SP1.TradingSessionListUpdateReport.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.MarketDefinition.NoTickRules();
                        case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.MarketDefinition.NoLotTypeRules();
                        case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.MarketDefinition.NoOrdTypeRules();
                        case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.MarketDefinition.NoTimeInForceRules();
                        case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.MarketDefinition.NoExecInstRules();
                    }
                }

                if (QuickFix.FIX50SP1.MarketDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTickRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoTickRules();
                        case QuickFix.Fields.Tags.NoLotTypeRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoLotTypeRules();
                        case QuickFix.Fields.Tags.NoOrdTypeRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoOrdTypeRules();
                        case QuickFix.Fields.Tags.NoTimeInForceRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoTimeInForceRules();
                        case QuickFix.Fields.Tags.NoExecInstRules: return new QuickFix.FIX50SP1.MarketDefinitionUpdateReport.NoExecInstRules();
                    }
                }

                if (QuickFix.FIX50SP1.ApplicationMessageRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageRequest.NoApplIDs();
                    }
                }

                if (QuickFix.FIX50SP1.ApplicationMessageRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageRequestAck.NoApplIDs();
                    }
                }

                if (QuickFix.FIX50SP1.ApplicationMessageReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoApplIDs: return new QuickFix.FIX50SP1.ApplicationMessageReport.NoApplIDs();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassActionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50SP1.OrderMassActionReport.NoAffectedOrders();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassActionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassActionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionReport.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoNotAffectedOrders: return new QuickFix.FIX50SP1.OrderMassActionReport.NoNotAffectedOrders();
                    }
                }

                if (QuickFix.FIX50SP1.OrderMassActionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50SP1.OrderMassActionRequest.NoUndlyInstrumentParties();
                    }
                }

                return null;
            }

        }
    }
}
