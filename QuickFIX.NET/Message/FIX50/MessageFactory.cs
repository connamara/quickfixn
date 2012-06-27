// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX50
    {
        public class MessageFactory : IMessageFactory
        {
            public QuickFix.Message Create(string beginString, string msgType)
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
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.IOI.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.IOI.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.IOI.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.IOI.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.IOI.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.IOI.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoIOIQualifiers: return new QuickFix.FIX50.IOI.NoIOIQualifiersGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.IOI.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.IOI.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.Advertisement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Advertisement.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Advertisement.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Advertisement.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Advertisement.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Advertisement.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ExecutionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoContraBrokers: return new QuickFix.FIX50.ExecutionReport.NoContraBrokersGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ExecutionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ExecutionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ExecutionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ExecutionReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.ExecutionReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoContAmts: return new QuickFix.FIX50.ExecutionReport.NoContAmtsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.ExecutionReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.ExecutionReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.ExecutionReport.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.ExecutionReport.NoTrdRegTimestampsGroup();
                    }
                }

                if (QuickFix.FIX50.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.News.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.News.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.News.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50.News.NoLinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX50.Email.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.Email.NoRoutingIDsGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.Email.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Email.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Email.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50.Email.NoLinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX50.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.NewOrderSingle.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.NewOrderSingle.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderSingle.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderSingle.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderSingle.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderSingle.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderSingle.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.NewOrderSingle.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderSingle.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.NewOrderSingle.NoTrdRegTimestampsGroup();
                    }
                }

                if (QuickFix.FIX50.NewOrderList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.NewOrderList.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.NewOrderList.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderCancelRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderCancelRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.OrderCancelReplaceRequest.NoTrdRegTimestampsGroup();
                    }
                }

                if (QuickFix.FIX50.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.OrderStatusRequest.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50.AllocationInstruction.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationInstruction.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationInstruction.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationInstruction.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationInstruction.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationInstruction.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationInstruction.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationInstruction.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationInstruction.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstruction.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationInstruction.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstruction.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationInstruction.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50.ListCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ListCancelRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.ListStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.ListStatus.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX50.AllocationInstructionAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstructionAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstructionAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50.DontKnowTrade.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.DontKnowTrade.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.DontKnowTrade.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.DontKnowTrade.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.DontKnowTrade.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.DontKnowTrade.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.QuoteRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.QuoteRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.Quote.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.Quote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Quote.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Quote.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Quote.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Quote.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.Quote.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Quote.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.SettlementInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSettlInst: return new QuickFix.FIX50.SettlementInstructions.NoSettlInstGroup();
                    }
                }

                if (QuickFix.FIX50.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.MarketDataRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.MarketDataRequest.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX50.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.MarketDataSnapshotFullRefresh.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX50.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                        case QuickFix.Fields.Tags.NoRoutingIDs: return new QuickFix.FIX50.MarketDataIncrementalRefresh.NoRoutingIDsGroup();
                    }
                }

                if (QuickFix.FIX50.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAltMDSource: return new QuickFix.FIX50.MarketDataRequestReject.NoAltMDSourceGroup();
                    }
                }

                if (QuickFix.FIX50.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteCancel.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50.QuoteCancel.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX50.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteStatusRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteStatusRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.MassQuoteAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50.MassQuoteAcknowledgement.NoQuoteSetsGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityDefinitionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinitionRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityDefinitionRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityDefinitionRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinitionRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.SubscriptionRequestType: return new QuickFix.FIX50.SecurityDefinitionRequest.SubscriptionRequestTypeGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityDefinition.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinition.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinition.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinition.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityDefinition.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityDefinition.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinition.NoLegsGroup();
                        case QuickFix.Fields.Tags.ClearingBusinessDate: return new QuickFix.FIX50.SecurityDefinition.ClearingBusinessDateGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityStatusRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityStatusRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityStatusRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityStatus.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityStatus.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityStatus.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityStatus.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityStatus.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityStatus.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.TradingSessionStatus.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradingSessionStatus.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradingSessionStatus.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradingSessionStatus.NoInstrumentPartiesGroup();
                    }
                }

                if (QuickFix.FIX50.MassQuote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MassQuote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteSets: return new QuickFix.FIX50.MassQuote.NoQuoteSetsGroup();
                    }
                }

                if (QuickFix.FIX50.BidRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidDescriptors: return new QuickFix.FIX50.BidRequest.NoBidDescriptorsGroup();
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50.BidRequest.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX50.BidResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoBidComponents: return new QuickFix.FIX50.BidResponse.NoBidComponentsGroup();
                    }
                }

                if (QuickFix.FIX50.ListStrikePrice.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoStrikes: return new QuickFix.FIX50.ListStrikePrice.NoStrikesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ListStrikePrice.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50.RegistrationInstructions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RegistrationInstructions.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoRegistDtls: return new QuickFix.FIX50.RegistrationInstructions.NoRegistDtlsGroup();
                        case QuickFix.Fields.Tags.NoDistribInsts: return new QuickFix.FIX50.RegistrationInstructions.NoDistribInstsGroup();
                    }
                }

                if (QuickFix.FIX50.RegistrationInstructionsResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RegistrationInstructionsResponse.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassCancelRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassCancelRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassCancelRequest.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassCancelRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoAffectedOrders: return new QuickFix.FIX50.OrderMassCancelReport.NoAffectedOrdersGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassCancelReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassCancelReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassCancelReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassCancelReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassCancelReport.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassCancelReport.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassCancelReport.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.NewOrderCross.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.NewOrderCross.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderCross.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderCross.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderCross.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderCross.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.NewOrderCross.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderCross.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.NewOrderCross.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderCross.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.NewOrderCross.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.CrossOrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoStrategyParametersGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.CrossOrderCancelReplaceRequest.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.CrossOrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.CrossOrderCancelRequest.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CrossOrderCancelRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CrossOrderCancelRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CrossOrderCancelRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CrossOrderCancelRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.CrossOrderCancelRequest.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityTypes.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityTypes: return new QuickFix.FIX50.SecurityTypes.NoSecurityTypesGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityListRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityListRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityListRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.SecurityListRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.SecurityListRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityListRequest.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.SecurityList.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50.DerivativeSecurityListRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.DerivativeSecurityListRequest.NoUndlyInstrumentPartiesGroup();
                    }
                }

                if (QuickFix.FIX50.DerivativeSecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.DerivativeSecurityList.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.DerivativeSecurityList.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.DerivativeSecurityList.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.DerivativeSecurityList.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50.NewOrderMultileg.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.NewOrderMultileg.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.NewOrderMultileg.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.NewOrderMultileg.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.NewOrderMultileg.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.NewOrderMultileg.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.NewOrderMultileg.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.NewOrderMultileg.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.NewOrderMultileg.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.NewOrderMultileg.NoStrategyParametersGroup();
                    }
                }

                if (QuickFix.FIX50.MultilegOrderCancelReplace.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoStrategyParameters: return new QuickFix.FIX50.MultilegOrderCancelReplace.NoStrategyParametersGroup();
                    }
                }

                if (QuickFix.FIX50.TradeCaptureReportRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.TradeCaptureReportRequest.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoDates: return new QuickFix.FIX50.TradeCaptureReportRequest.NoDatesGroup();
                    }
                }

                if (QuickFix.FIX50.TradeCaptureReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.TradeCaptureReport.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.TradeCaptureReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.TradeCaptureReport.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.TradeCaptureReport.NoRootPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.OrderMassStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.OrderMassStatusRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.OrderMassStatusRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.OrderMassStatusRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.OrderMassStatusRequest.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.OrderMassStatusRequest.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.OrderMassStatusRequest.NoUndlyInstrumentPartiesGroup();
                    }
                }

                if (QuickFix.FIX50.QuoteRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.QuoteRequestReject.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50.RFQRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.RFQRequest.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteStatusReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteStatusReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteStatusReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteStatusReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteStatusReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.QuoteStatusReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteStatusReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.QuoteStatusReport.NoQuoteQualifiersGroup();
                    }
                }

                if (QuickFix.FIX50.QuoteResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoQuoteQualifiers: return new QuickFix.FIX50.QuoteResponse.NoQuoteQualifiersGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.QuoteResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.QuoteResponse.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.QuoteResponse.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.QuoteResponse.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.QuoteResponse.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.QuoteResponse.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.QuoteResponse.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.Confirmation.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.Confirmation.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.Confirmation.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.Confirmation.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.Confirmation.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.Confirmation.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.Confirmation.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.Confirmation.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.Confirmation.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.Confirmation.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoCapacities: return new QuickFix.FIX50.Confirmation.NoCapacitiesGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.Confirmation.NoDlvyInstGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.Confirmation.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.Confirmation.NoMiscFeesGroup();
                    }
                }

                if (QuickFix.FIX50.PositionMaintenanceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionMaintenanceRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionMaintenanceRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionMaintenanceRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionMaintenanceRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.PositionMaintenanceRequest.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionMaintenanceRequest.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50.PositionMaintenanceReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionMaintenanceReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionMaintenanceReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionMaintenanceReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionMaintenanceReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionMaintenanceReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionMaintenanceReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.PositionMaintenanceReport.NoTradingSessionsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionMaintenanceReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionMaintenanceReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50.RequestForPositions.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RequestForPositions.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.RequestForPositions.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.RequestForPositions.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.RequestForPositions.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.RequestForPositions.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.RequestForPositions.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.RequestForPositions.NoTradingSessionsGroup();
                    }
                }

                if (QuickFix.FIX50.RequestForPositionsAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.RequestForPositionsAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.RequestForPositionsAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.RequestForPositionsAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.RequestForPositionsAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.RequestForPositionsAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.RequestForPositionsAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50.PositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.PositionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.PositionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.PositionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.PositionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.PositionReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.PositionReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.PositionReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.PositionReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50.TradeCaptureReportRequestAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportRequestAck.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.TradeCaptureReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.TradeCaptureReportAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.TradeCaptureReportAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.TradeCaptureReportAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.TradeCaptureReportAck.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.TradeCaptureReportAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.TradeCaptureReportAck.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoSides: return new QuickFix.FIX50.TradeCaptureReportAck.NoSidesGroup();
                        case QuickFix.Fields.Tags.NoRootPartyIDs: return new QuickFix.FIX50.TradeCaptureReportAck.NoRootPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.TradeCaptureReportAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50.AllocationReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationReport.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationReport.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationReport.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationReport.NoAllocsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50.AllocationReportAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationReportAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationReportAck.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50.SettlementInstructionRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.SettlementInstructionRequest.NoPartyIDsGroup();
                    }
                }

                if (QuickFix.FIX50.AssignmentReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AssignmentReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AssignmentReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AssignmentReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AssignmentReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AssignmentReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AssignmentReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.AssignmentReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AssignmentReport.NoPosAmtGroup();
                    }
                }

                if (QuickFix.FIX50.CollateralRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralRequest.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralRequest.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralRequest.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralRequest.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralRequest.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralRequest.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralRequest.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralRequest.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralRequest.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralRequest.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX50.CollateralAssignment.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralAssignment.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralAssignment.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralAssignment.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralAssignment.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralAssignment.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralAssignment.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralAssignment.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralAssignment.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralAssignment.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralAssignment.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralAssignment.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralAssignment.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50.CollateralResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralResponse.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralResponse.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralResponse.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralResponse.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralResponse.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralResponse.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralResponse.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralResponse.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralResponse.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralResponse.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralResponse.NoStipulationsGroup();
                    }
                }

                if (QuickFix.FIX50.CollateralReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralReport.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralReport.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralReport.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralReport.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralReport.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoMiscFees: return new QuickFix.FIX50.CollateralReport.NoMiscFeesGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralReport.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralReport.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50.CollateralInquiry.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50.CollateralInquiry.NoCollInquiryQualifierGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralInquiry.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralInquiry.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralInquiry.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralInquiry.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralInquiry.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralInquiry.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralInquiry.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralInquiry.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoTrdRegTimestamps: return new QuickFix.FIX50.CollateralInquiry.NoTrdRegTimestampsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.CollateralInquiry.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoDlvyInst: return new QuickFix.FIX50.CollateralInquiry.NoDlvyInstGroup();
                    }
                }

                if (QuickFix.FIX50.NetworkCounterpartySystemStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50.NetworkCounterpartySystemStatusRequest.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FIX50.NetworkCounterpartySystemStatusResponse.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCompIDs: return new QuickFix.FIX50.NetworkCounterpartySystemStatusResponse.NoCompIDsGroup();
                    }
                }

                if (QuickFix.FIX50.CollateralInquiryAck.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoCollInquiryQualifier: return new QuickFix.FIX50.CollateralInquiryAck.NoCollInquiryQualifierGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.CollateralInquiryAck.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.CollateralInquiryAck.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoTrades: return new QuickFix.FIX50.CollateralInquiryAck.NoTradesGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.CollateralInquiryAck.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.CollateralInquiryAck.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.CollateralInquiryAck.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.CollateralInquiryAck.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.CollateralInquiryAck.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50.ConfirmationRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.ConfirmationRequest.NoOrdersGroup();
                    }
                }

                if (QuickFix.FIX50.ContraryIntentionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.ContraryIntentionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoExpiration: return new QuickFix.FIX50.ContraryIntentionReport.NoExpirationGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ContraryIntentionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ContraryIntentionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ContraryIntentionReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ContraryIntentionReport.NoUnderlyingsGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityDefinitionUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingSecurityAltID: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUnderlyingSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoUnderlyingStips: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUnderlyingStipsGroup();
                        case QuickFix.Fields.Tags.NoUndlyInstrumentParties: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoUndlyInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.SecurityDefinitionUpdateReport.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.SecurityListUpdateReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50.SecurityListUpdateReport.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50.AdjustedPositionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AdjustedPositionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPositions: return new QuickFix.FIX50.AdjustedPositionReport.NoPositionsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AdjustedPositionReport.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AdjustedPositionReport.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AdjustedPositionReport.NoInstrumentPartiesGroup();
                    }
                }

                if (QuickFix.FIX50.AllocationInstructionAlert.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoOrders: return new QuickFix.FIX50.AllocationInstructionAlert.NoOrdersGroup();
                        case QuickFix.Fields.Tags.NoExecs: return new QuickFix.FIX50.AllocationInstructionAlert.NoExecsGroup();
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.AllocationInstructionAlert.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.AllocationInstructionAlert.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.AllocationInstructionAlert.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoInstrAttrib: return new QuickFix.FIX50.AllocationInstructionAlert.NoInstrAttribGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.AllocationInstructionAlert.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.AllocationInstructionAlert.NoLegsGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50.AllocationInstructionAlert.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoStipulations: return new QuickFix.FIX50.AllocationInstructionAlert.NoStipulationsGroup();
                        case QuickFix.Fields.Tags.NoPosAmt: return new QuickFix.FIX50.AllocationInstructionAlert.NoPosAmtGroup();
                        case QuickFix.Fields.Tags.NoAllocs: return new QuickFix.FIX50.AllocationInstructionAlert.NoAllocsGroup();
                    }
                }

                if (QuickFix.FIX50.ExecutionAcknowledgement.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoSecurityAltID: return new QuickFix.FIX50.ExecutionAcknowledgement.NoSecurityAltIDGroup();
                        case QuickFix.Fields.Tags.NoEvents: return new QuickFix.FIX50.ExecutionAcknowledgement.NoEventsGroup();
                        case QuickFix.Fields.Tags.NoInstrumentParties: return new QuickFix.FIX50.ExecutionAcknowledgement.NoInstrumentPartiesGroup();
                        case QuickFix.Fields.Tags.NoUnderlyings: return new QuickFix.FIX50.ExecutionAcknowledgement.NoUnderlyingsGroup();
                        case QuickFix.Fields.Tags.NoLegs: return new QuickFix.FIX50.ExecutionAcknowledgement.NoLegsGroup();
                    }
                }

                if (QuickFix.FIX50.TradingSessionList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoTradingSessions: return new QuickFix.FIX50.TradingSessionList.NoTradingSessionsGroup();
                    }
                }

                return null;
            }

        }
    }
}
