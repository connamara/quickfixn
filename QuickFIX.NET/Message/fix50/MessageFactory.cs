// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX50
    {
        public class MessageFactory : IMessageFactory
        {
            public Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX50.IOI.MsgType: return new QuickFix.FIX50.IOI();
                    case QuickFix.FIX50.Advertisement.MsgType: return new QuickFix.FIX50.Advertisement();
                    case QuickFix.FIX50.ExecutionReport.MsgType: return new QuickFix.FIX50.ExecutionReport();
                    case QuickFix.FIX50.OrderCancelReject.MsgType: return new QuickFix.FIX50.OrderCancelReject();
                    case QuickFix.FIX50.News.MsgType: return new QuickFix.FIX50.News();
                    case QuickFix.FIX50.Email.MsgType: return new QuickFix.FIX50.Email();
                    case QuickFix.FIX50.NewOrderSingle.MsgType: return new QuickFix.FIX50.NewOrderSingle();
                    case QuickFix.FIX50.NewOrderList.MsgType: return new QuickFix.FIX50.NewOrderList();
                    case QuickFix.FIX50.OrderCancelRequest.MsgType: return new QuickFix.FIX50.OrderCancelRequest();
                    case QuickFix.FIX50.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50.OrderCancelReplaceRequest();
                    case QuickFix.FIX50.OrderStatusRequest.MsgType: return new QuickFix.FIX50.OrderStatusRequest();
                    case QuickFix.FIX50.AllocationInstruction.MsgType: return new QuickFix.FIX50.AllocationInstruction();
                    case QuickFix.FIX50.ListCancelRequest.MsgType: return new QuickFix.FIX50.ListCancelRequest();
                    case QuickFix.FIX50.ListExecute.MsgType: return new QuickFix.FIX50.ListExecute();
                    case QuickFix.FIX50.ListStatusRequest.MsgType: return new QuickFix.FIX50.ListStatusRequest();
                    case QuickFix.FIX50.ListStatus.MsgType: return new QuickFix.FIX50.ListStatus();
                    case QuickFix.FIX50.AllocationInstructionAck.MsgType: return new QuickFix.FIX50.AllocationInstructionAck();
                    case QuickFix.FIX50.DontKnowTrade.MsgType: return new QuickFix.FIX50.DontKnowTrade();
                    case QuickFix.FIX50.QuoteRequest.MsgType: return new QuickFix.FIX50.QuoteRequest();
                    case QuickFix.FIX50.Quote.MsgType: return new QuickFix.FIX50.Quote();
                    case QuickFix.FIX50.SettlementInstructions.MsgType: return new QuickFix.FIX50.SettlementInstructions();
                    case QuickFix.FIX50.MarketDataRequest.MsgType: return new QuickFix.FIX50.MarketDataRequest();
                    case QuickFix.FIX50.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX50.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX50.MarketDataIncrementalRefresh();
                    case QuickFix.FIX50.MarketDataRequestReject.MsgType: return new QuickFix.FIX50.MarketDataRequestReject();
                    case QuickFix.FIX50.QuoteCancel.MsgType: return new QuickFix.FIX50.QuoteCancel();
                    case QuickFix.FIX50.QuoteStatusRequest.MsgType: return new QuickFix.FIX50.QuoteStatusRequest();
                    case QuickFix.FIX50.MassQuoteAcknowledgement.MsgType: return new QuickFix.FIX50.MassQuoteAcknowledgement();
                    case QuickFix.FIX50.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX50.SecurityDefinitionRequest();
                    case QuickFix.FIX50.SecurityDefinition.MsgType: return new QuickFix.FIX50.SecurityDefinition();
                    case QuickFix.FIX50.SecurityStatusRequest.MsgType: return new QuickFix.FIX50.SecurityStatusRequest();
                    case QuickFix.FIX50.SecurityStatus.MsgType: return new QuickFix.FIX50.SecurityStatus();
                    case QuickFix.FIX50.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX50.TradingSessionStatusRequest();
                    case QuickFix.FIX50.TradingSessionStatus.MsgType: return new QuickFix.FIX50.TradingSessionStatus();
                    case QuickFix.FIX50.MassQuote.MsgType: return new QuickFix.FIX50.MassQuote();
                    case QuickFix.FIX50.BusinessMessageReject.MsgType: return new QuickFix.FIX50.BusinessMessageReject();
                    case QuickFix.FIX50.BidRequest.MsgType: return new QuickFix.FIX50.BidRequest();
                    case QuickFix.FIX50.BidResponse.MsgType: return new QuickFix.FIX50.BidResponse();
                    case QuickFix.FIX50.ListStrikePrice.MsgType: return new QuickFix.FIX50.ListStrikePrice();
                    case QuickFix.FIX50.RegistrationInstructions.MsgType: return new QuickFix.FIX50.RegistrationInstructions();
                    case QuickFix.FIX50.RegistrationInstructionsResponse.MsgType: return new QuickFix.FIX50.RegistrationInstructionsResponse();
                    case QuickFix.FIX50.OrderMassCancelRequest.MsgType: return new QuickFix.FIX50.OrderMassCancelRequest();
                    case QuickFix.FIX50.OrderMassCancelReport.MsgType: return new QuickFix.FIX50.OrderMassCancelReport();
                    case QuickFix.FIX50.NewOrderCross.MsgType: return new QuickFix.FIX50.NewOrderCross();
                    case QuickFix.FIX50.CrossOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest();
                    case QuickFix.FIX50.CrossOrderCancelRequest.MsgType: return new QuickFix.FIX50.CrossOrderCancelRequest();
                    case QuickFix.FIX50.SecurityTypeRequest.MsgType: return new QuickFix.FIX50.SecurityTypeRequest();
                    case QuickFix.FIX50.SecurityTypes.MsgType: return new QuickFix.FIX50.SecurityTypes();
                    case QuickFix.FIX50.SecurityListRequest.MsgType: return new QuickFix.FIX50.SecurityListRequest();
                    case QuickFix.FIX50.SecurityList.MsgType: return new QuickFix.FIX50.SecurityList();
                    case QuickFix.FIX50.DerivativeSecurityListRequest.MsgType: return new QuickFix.FIX50.DerivativeSecurityListRequest();
                    case QuickFix.FIX50.DerivativeSecurityList.MsgType: return new QuickFix.FIX50.DerivativeSecurityList();
                    case QuickFix.FIX50.NewOrderMultileg.MsgType: return new QuickFix.FIX50.NewOrderMultileg();
                    case QuickFix.FIX50.MultilegOrderCancelReplace.MsgType: return new QuickFix.FIX50.MultilegOrderCancelReplace();
                    case QuickFix.FIX50.TradeCaptureReportRequest.MsgType: return new QuickFix.FIX50.TradeCaptureReportRequest();
                    case QuickFix.FIX50.TradeCaptureReport.MsgType: return new QuickFix.FIX50.TradeCaptureReport();
                    case QuickFix.FIX50.OrderMassStatusRequest.MsgType: return new QuickFix.FIX50.OrderMassStatusRequest();
                    case QuickFix.FIX50.QuoteRequestReject.MsgType: return new QuickFix.FIX50.QuoteRequestReject();
                    case QuickFix.FIX50.RFQRequest.MsgType: return new QuickFix.FIX50.RFQRequest();
                    case QuickFix.FIX50.QuoteStatusReport.MsgType: return new QuickFix.FIX50.QuoteStatusReport();
                    case QuickFix.FIX50.QuoteResponse.MsgType: return new QuickFix.FIX50.QuoteResponse();
                    case QuickFix.FIX50.Confirmation.MsgType: return new QuickFix.FIX50.Confirmation();
                    case QuickFix.FIX50.PositionMaintenanceRequest.MsgType: return new QuickFix.FIX50.PositionMaintenanceRequest();
                    case QuickFix.FIX50.PositionMaintenanceReport.MsgType: return new QuickFix.FIX50.PositionMaintenanceReport();
                    case QuickFix.FIX50.RequestForPositions.MsgType: return new QuickFix.FIX50.RequestForPositions();
                    case QuickFix.FIX50.RequestForPositionsAck.MsgType: return new QuickFix.FIX50.RequestForPositionsAck();
                    case QuickFix.FIX50.PositionReport.MsgType: return new QuickFix.FIX50.PositionReport();
                    case QuickFix.FIX50.TradeCaptureReportRequestAck.MsgType: return new QuickFix.FIX50.TradeCaptureReportRequestAck();
                    case QuickFix.FIX50.TradeCaptureReportAck.MsgType: return new QuickFix.FIX50.TradeCaptureReportAck();
                    case QuickFix.FIX50.AllocationReport.MsgType: return new QuickFix.FIX50.AllocationReport();
                    case QuickFix.FIX50.AllocationReportAck.MsgType: return new QuickFix.FIX50.AllocationReportAck();
                    case QuickFix.FIX50.ConfirmationAck.MsgType: return new QuickFix.FIX50.ConfirmationAck();
                    case QuickFix.FIX50.SettlementInstructionRequest.MsgType: return new QuickFix.FIX50.SettlementInstructionRequest();
                    case QuickFix.FIX50.AssignmentReport.MsgType: return new QuickFix.FIX50.AssignmentReport();
                    case QuickFix.FIX50.CollateralRequest.MsgType: return new QuickFix.FIX50.CollateralRequest();
                    case QuickFix.FIX50.CollateralAssignment.MsgType: return new QuickFix.FIX50.CollateralAssignment();
                    case QuickFix.FIX50.CollateralResponse.MsgType: return new QuickFix.FIX50.CollateralResponse();
                    case QuickFix.FIX50.CollateralReport.MsgType: return new QuickFix.FIX50.CollateralReport();
                    case QuickFix.FIX50.CollateralInquiry.MsgType: return new QuickFix.FIX50.CollateralInquiry();
                    case QuickFix.FIX50.NetworkCounterpartySystemStatusRequest.MsgType: return new QuickFix.FIX50.NetworkCounterpartySystemStatusRequest();
                    case QuickFix.FIX50.NetworkCounterpartySystemStatusResponse.MsgType: return new QuickFix.FIX50.NetworkCounterpartySystemStatusResponse();
                    case QuickFix.FIX50.UserRequest.MsgType: return new QuickFix.FIX50.UserRequest();
                    case QuickFix.FIX50.UserResponse.MsgType: return new QuickFix.FIX50.UserResponse();
                    case QuickFix.FIX50.CollateralInquiryAck.MsgType: return new QuickFix.FIX50.CollateralInquiryAck();
                    case QuickFix.FIX50.ConfirmationRequest.MsgType: return new QuickFix.FIX50.ConfirmationRequest();
                    case QuickFix.FIX50.ContraryIntentionReport.MsgType: return new QuickFix.FIX50.ContraryIntentionReport();
                    case QuickFix.FIX50.SecurityDefinitionUpdateReport.MsgType: return new QuickFix.FIX50.SecurityDefinitionUpdateReport();
                    case QuickFix.FIX50.SecurityListUpdateReport.MsgType: return new QuickFix.FIX50.SecurityListUpdateReport();
                    case QuickFix.FIX50.AdjustedPositionReport.MsgType: return new QuickFix.FIX50.AdjustedPositionReport();
                    case QuickFix.FIX50.AllocationInstructionAlert.MsgType: return new QuickFix.FIX50.AllocationInstructionAlert();
                    case QuickFix.FIX50.ExecutionAcknowledgement.MsgType: return new QuickFix.FIX50.ExecutionAcknowledgement();
                    case QuickFix.FIX50.TradingSessionList.MsgType: return new QuickFix.FIX50.TradingSessionList();
                    case QuickFix.FIX50.TradingSessionListRequest.MsgType: return new QuickFix.FIX50.TradingSessionListRequest();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX50.IOI.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.IOI.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.IOI.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.IOI.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.IOI.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.IOI.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.IOI.NoLegs();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50.IOI.NoIOIQualifiers();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.IOI.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.IOI.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Advertisement.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Advertisement.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Advertisement.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Advertisement.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Advertisement.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ExecutionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50.ExecutionReport.NoContraBrokers();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ExecutionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ExecutionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ExecutionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ExecutionReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.ExecutionReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50.ExecutionReport.NoContAmts();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.ExecutionReport.NoLegs();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.ExecutionReport.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.ExecutionReport.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.ExecutionReport.NoTrdRegTimestamps();
                    }
                }

                if (QuickFix.FIX50.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.News.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.News.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.News.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.News.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50.News.NoLinesOfText();
                    }
                }

                if (QuickFix.FIX50.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.Email.NoRoutingIDs();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.Email.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Email.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Email.NoLegs();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50.Email.NoLinesOfText();
                    }
                }

                if (QuickFix.FIX50.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.NewOrderSingle.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.NewOrderSingle.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderSingle.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderSingle.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderSingle.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderSingle.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderSingle.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.NewOrderSingle.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderSingle.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.NewOrderSingle.NoTrdRegTimestamps();
                    }
                }

                if (QuickFix.FIX50.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.NewOrderList.NoOrders();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.NewOrderList.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderCancelRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderCancelRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoTrdRegTimestamps();
                    }
                }

                if (QuickFix.FIX50.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderStatusRequest.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationInstruction.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationInstruction.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationInstruction.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationInstruction.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationInstruction.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationInstruction.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationInstruction.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationInstruction.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstruction.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationInstruction.NoStipulations();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstruction.NoAllocs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationInstruction.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50.ListCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ListCancelRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.ListStatus.NoOrders();
                    }
                }

                if (QuickFix.FIX50.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstructionAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstructionAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX50.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.DontKnowTrade.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.DontKnowTrade.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.DontKnowTrade.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.DontKnowTrade.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.DontKnowTrade.NoLegs();
                    }
                }

                if (QuickFix.FIX50.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.QuoteRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.Quote.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.Quote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Quote.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Quote.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Quote.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Quote.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.Quote.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Quote.NoLegs();
                    }
                }

                if (QuickFix.FIX50.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50.SettlementInstructions.NoSettlInst();
                    }
                }

                if (QuickFix.FIX50.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50.MarketDataRequest.NoMDEntryTypes();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSym();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.MarketDataRequest.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX50.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoLegs();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoMDEntries();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX50.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntries();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoRoutingIDs();
                    }
                }

                if (QuickFix.FIX50.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50.MarketDataRequestReject.NoAltMDSource();
                    }
                }

                if (QuickFix.FIX50.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteCancel.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntries();
                    }
                }

                if (QuickFix.FIX50.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteStatusRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteStatusRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteStatusRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX50.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinitionRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityDefinitionRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityDefinitionRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinitionRequest.NoLegs();
                        case QuickFix.Fields.Tags.SubscriptionRequestType: return new QuickFix.FIX50.SecurityDefinitionRequest.SubscriptionRequestType();
                    }
                }

                if (QuickFix.FIX50.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinition.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinition.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinition.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityDefinition.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityDefinition.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinition.NoLegs();
                        case QuickFix.Fields.Tags.ClearingBusinessDate: return new QuickFix.FIX50.SecurityDefinition.ClearingBusinessDate();
                    }
                }

                if (QuickFix.FIX50.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityStatusRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityStatusRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityStatusRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX50.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityStatus.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityStatus.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityStatus.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityStatus.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityStatus.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityStatus.NoLegs();
                    }
                }

                if (QuickFix.FIX50.TradingSessionStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradingSessionStatus.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradingSessionStatus.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradingSessionStatus.NoInstrumentParties();
                    }
                }

                if (QuickFix.FIX50.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MassQuote.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50.MassQuote.NoQuoteSets();
                    }
                }

                if (QuickFix.FIX50.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50.BidRequest.NoBidDescriptors();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50.BidRequest.NoBidComponents();
                    }
                }

                if (QuickFix.FIX50.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50.BidResponse.NoBidComponents();
                    }
                }

                if (QuickFix.FIX50.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50.ListStrikePrice.NoStrikes();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ListStrikePrice.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RegistrationInstructions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50.RegistrationInstructions.NoRegistDtls();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50.RegistrationInstructions.NoDistribInsts();
                    }
                }

                if (QuickFix.FIX50.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RegistrationInstructionsResponse.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassCancelRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassCancelRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassCancelRequest.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassCancelRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50.OrderMassCancelReport.NoAffectedOrders();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassCancelReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassCancelReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassCancelReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassCancelReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassCancelReport.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassCancelReport.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassCancelReport.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.NewOrderCross.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderCross.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderCross.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderCross.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderCross.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.NewOrderCross.NoLegs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderCross.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.NewOrderCross.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderCross.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.NewOrderCross.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoStipulations();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoStrategyParameters();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.CrossOrderCancelRequest.NoSides();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CrossOrderCancelRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CrossOrderCancelRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CrossOrderCancelRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50.SecurityTypes.NoSecurityTypes();
                    }
                }

                if (QuickFix.FIX50.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityListRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityListRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityListRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityListRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityListRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityListRequest.NoLegs();
                    }
                }

                if (QuickFix.FIX50.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.SecurityList.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUndlyInstrumentParties();
                    }
                }

                if (QuickFix.FIX50.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.DerivativeSecurityList.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.DerivativeSecurityList.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.DerivativeSecurityList.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.NewOrderMultileg.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.NewOrderMultileg.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderMultileg.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderMultileg.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderMultileg.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderMultileg.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderMultileg.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.NewOrderMultileg.NoLegs();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderMultileg.NoStrategyParameters();
                    }
                }

                if (QuickFix.FIX50.MultilegOrderCancelReplace.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoAllocs();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegs();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoStrategyParameters();
                    }
                }

                if (QuickFix.FIX50.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.TradeCaptureReportRequest.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50.TradeCaptureReportRequest.NoDates();
                    }
                }

                if (QuickFix.FIX50.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.TradeCaptureReport.NoPosAmt();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReport.NoLegs();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.TradeCaptureReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.TradeCaptureReport.NoSides();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.TradeCaptureReport.NoRootPartyIDs();
                    }
                }

                if (QuickFix.FIX50.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassStatusRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassStatusRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassStatusRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassStatusRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassStatusRequest.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassStatusRequest.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassStatusRequest.NoUndlyInstrumentParties();
                    }
                }

                if (QuickFix.FIX50.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.RFQRequest.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteStatusReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteStatusReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteStatusReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteStatusReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteStatusReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.QuoteStatusReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteStatusReport.NoLegs();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.QuoteStatusReport.NoQuoteQualifiers();
                    }
                }

                if (QuickFix.FIX50.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.QuoteResponse.NoQuoteQualifiers();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteResponse.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteResponse.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteResponse.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteResponse.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteResponse.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.QuoteResponse.NoStipulations();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteResponse.NoLegs();
                    }
                }

                if (QuickFix.FIX50.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.Confirmation.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.Confirmation.NoOrders();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.Confirmation.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Confirmation.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Confirmation.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Confirmation.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.Confirmation.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Confirmation.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Confirmation.NoLegs();
                        case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50.Confirmation.NoCapacities();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.Confirmation.NoDlvyInst();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.Confirmation.NoStipulations();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.Confirmation.NoMiscFees();
                    }
                }

                if (QuickFix.FIX50.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionMaintenanceRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionMaintenanceRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionMaintenanceRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.PositionMaintenanceRequest.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionMaintenanceReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionMaintenanceReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionMaintenanceReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionMaintenanceReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionMaintenanceReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.PositionMaintenanceReport.NoTradingSessions();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionMaintenanceReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionMaintenanceReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RequestForPositions.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.RequestForPositions.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.RequestForPositions.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.RequestForPositions.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.RequestForPositions.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.RequestForPositions.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.RequestForPositions.NoTradingSessions();
                    }
                }

                if (QuickFix.FIX50.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RequestForPositionsAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.RequestForPositionsAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.RequestForPositionsAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.RequestForPositionsAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.RequestForPositionsAck.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.RequestForPositionsAck.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoLegs();
                    }
                }

                if (QuickFix.FIX50.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.TradeCaptureReportAck.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportAck.NoLegs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.TradeCaptureReportAck.NoPosAmt();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.TradeCaptureReportAck.NoSides();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoRootPartyIDs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportAck.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationReport.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationReport.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationReport.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationReport.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationReport.NoAllocs();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationReportAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationReportAck.NoAllocs();
                    }
                }

                if (QuickFix.FIX50.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.SettlementInstructionRequest.NoPartyIDs();
                    }
                }

                if (QuickFix.FIX50.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AssignmentReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AssignmentReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AssignmentReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AssignmentReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AssignmentReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AssignmentReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.AssignmentReport.NoPositions();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AssignmentReport.NoPosAmt();
                    }
                }

                if (QuickFix.FIX50.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralRequest.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralRequest.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralRequest.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralRequest.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralRequest.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralRequest.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralRequest.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralRequest.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralRequest.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralRequest.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralRequest.NoStipulations();
                    }
                }

                if (QuickFix.FIX50.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralAssignment.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralAssignment.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralAssignment.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralAssignment.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralAssignment.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralAssignment.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralAssignment.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralAssignment.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralAssignment.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralAssignment.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralAssignment.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralAssignment.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralResponse.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralResponse.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralResponse.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralResponse.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralResponse.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralResponse.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralResponse.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralResponse.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralResponse.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralResponse.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralResponse.NoStipulations();
                    }
                }

                if (QuickFix.FIX50.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralReport.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralReport.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralReport.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralReport.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralReport.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralReport.NoMiscFees();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralReport.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralReport.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50.CollateralInquiry.NoCollInquiryQualifier();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralInquiry.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralInquiry.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralInquiry.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralInquiry.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralInquiry.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralInquiry.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralInquiry.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralInquiry.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralInquiry.NoTrdRegTimestamps();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralInquiry.NoStipulations();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralInquiry.NoDlvyInst();
                    }
                }

                if (QuickFix.FIX50.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50.NetworkCounterpartySystemStatusRequest.NoCompIDs();
                    }
                }

                if (QuickFix.FIX50.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50.NetworkCounterpartySystemStatusResponse.NoCompIDs();
                    }
                }

                if (QuickFix.FIX50.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50.CollateralInquiryAck.NoCollInquiryQualifier();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralInquiryAck.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralInquiryAck.NoExecs();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralInquiryAck.NoTrades();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralInquiryAck.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralInquiryAck.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralInquiryAck.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralInquiryAck.NoLegs();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralInquiryAck.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.ConfirmationRequest.NoOrders();
                    }
                }

                if (QuickFix.FIX50.ContraryIntentionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ContraryIntentionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50.ContraryIntentionReport.NoExpiration();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ContraryIntentionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ContraryIntentionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ContraryIntentionReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ContraryIntentionReport.NoUnderlyings();
                    }
                }

                if (QuickFix.FIX50.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUnderlyingSecurityAltID();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUnderlyingStips();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUndlyInstrumentParties();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoLegs();
                    }
                }

                if (QuickFix.FIX50.SecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSym();
                    }
                }

                if (QuickFix.FIX50.AdjustedPositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AdjustedPositionReport.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.AdjustedPositionReport.NoPositions();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AdjustedPositionReport.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AdjustedPositionReport.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AdjustedPositionReport.NoInstrumentParties();
                    }
                }

                if (QuickFix.FIX50.AllocationInstructionAlert.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationInstructionAlert.NoOrders();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationInstructionAlert.NoExecs();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationInstructionAlert.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationInstructionAlert.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationInstructionAlert.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationInstructionAlert.NoInstrAttrib();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationInstructionAlert.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationInstructionAlert.NoLegs();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoPartyIDs();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationInstructionAlert.NoStipulations();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationInstructionAlert.NoPosAmt();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocs();
                    }
                }

                if (QuickFix.FIX50.ExecutionAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ExecutionAcknowledgement.NoSecurityAltID();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ExecutionAcknowledgement.NoEvents();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ExecutionAcknowledgement.NoInstrumentParties();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ExecutionAcknowledgement.NoUnderlyings();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.ExecutionAcknowledgement.NoLegs();
                    }
                }

                if (QuickFix.FIX50.TradingSessionList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.TradingSessionList.NoTradingSessions();
                    }
                }

                return null;
            }

        }
    }
}
