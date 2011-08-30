// This is a generated file.  Don't edit it directly!

namespace QuickFix
{
    namespace FIX43
    {
        public class MessageFactory : IMessageFactory
        {
            public Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX43.Heartbeat.MsgType: return new QuickFix.FIX43.Heartbeat();
                    case QuickFix.FIX43.Logon.MsgType: return new QuickFix.FIX43.Logon();
                    case QuickFix.FIX43.TestRequest.MsgType: return new QuickFix.FIX43.TestRequest();
                    case QuickFix.FIX43.ResendRequest.MsgType: return new QuickFix.FIX43.ResendRequest();
                    case QuickFix.FIX43.Reject.MsgType: return new QuickFix.FIX43.Reject();
                    case QuickFix.FIX43.SequenceReset.MsgType: return new QuickFix.FIX43.SequenceReset();
                    case QuickFix.FIX43.Logout.MsgType: return new QuickFix.FIX43.Logout();
                    case QuickFix.FIX43.BusinessMessageReject.MsgType: return new QuickFix.FIX43.BusinessMessageReject();
                    case QuickFix.FIX43.Advertisement.MsgType: return new QuickFix.FIX43.Advertisement();
                    case QuickFix.FIX43.IndicationOfInterest.MsgType: return new QuickFix.FIX43.IndicationOfInterest();
                    case QuickFix.FIX43.News.MsgType: return new QuickFix.FIX43.News();
                    case QuickFix.FIX43.Email.MsgType: return new QuickFix.FIX43.Email();
                    case QuickFix.FIX43.QuoteRequest.MsgType: return new QuickFix.FIX43.QuoteRequest();
                    case QuickFix.FIX43.QuoteRequestReject.MsgType: return new QuickFix.FIX43.QuoteRequestReject();
                    case QuickFix.FIX43.RFQRequest.MsgType: return new QuickFix.FIX43.RFQRequest();
                    case QuickFix.FIX43.Quote.MsgType: return new QuickFix.FIX43.Quote();
                    case QuickFix.FIX43.QuoteCancel.MsgType: return new QuickFix.FIX43.QuoteCancel();
                    case QuickFix.FIX43.QuoteStatusRequest.MsgType: return new QuickFix.FIX43.QuoteStatusRequest();
                    case QuickFix.FIX43.QuoteStatusReport.MsgType: return new QuickFix.FIX43.QuoteStatusReport();
                    case QuickFix.FIX43.MassQuote.MsgType: return new QuickFix.FIX43.MassQuote();
                    case QuickFix.FIX43.MassQuoteAcknowledgement.MsgType: return new QuickFix.FIX43.MassQuoteAcknowledgement();
                    case QuickFix.FIX43.MarketDataRequest.MsgType: return new QuickFix.FIX43.MarketDataRequest();
                    case QuickFix.FIX43.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX43.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX43.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX43.MarketDataIncrementalRefresh();
                    case QuickFix.FIX43.MarketDataRequestReject.MsgType: return new QuickFix.FIX43.MarketDataRequestReject();
                    case QuickFix.FIX43.SecurityDefinitionRequest.MsgType: return new QuickFix.FIX43.SecurityDefinitionRequest();
                    case QuickFix.FIX43.SecurityDefinition.MsgType: return new QuickFix.FIX43.SecurityDefinition();
                    case QuickFix.FIX43.SecurityTypeRequest.MsgType: return new QuickFix.FIX43.SecurityTypeRequest();
                    case QuickFix.FIX43.SecurityTypes.MsgType: return new QuickFix.FIX43.SecurityTypes();
                    case QuickFix.FIX43.SecurityListRequest.MsgType: return new QuickFix.FIX43.SecurityListRequest();
                    case QuickFix.FIX43.SecurityList.MsgType: return new QuickFix.FIX43.SecurityList();
                    case QuickFix.FIX43.DerivativeSecurityListRequest.MsgType: return new QuickFix.FIX43.DerivativeSecurityListRequest();
                    case QuickFix.FIX43.DerivativeSecurityList.MsgType: return new QuickFix.FIX43.DerivativeSecurityList();
                    case QuickFix.FIX43.SecurityStatusRequest.MsgType: return new QuickFix.FIX43.SecurityStatusRequest();
                    case QuickFix.FIX43.SecurityStatus.MsgType: return new QuickFix.FIX43.SecurityStatus();
                    case QuickFix.FIX43.TradingSessionStatusRequest.MsgType: return new QuickFix.FIX43.TradingSessionStatusRequest();
                    case QuickFix.FIX43.TradingSessionStatus.MsgType: return new QuickFix.FIX43.TradingSessionStatus();
                    case QuickFix.FIX43.NewOrderSingle.MsgType: return new QuickFix.FIX43.NewOrderSingle();
                    case QuickFix.FIX43.ExecutionReport.MsgType: return new QuickFix.FIX43.ExecutionReport();
                    case QuickFix.FIX43.DontKnowTrade.MsgType: return new QuickFix.FIX43.DontKnowTrade();
                    case QuickFix.FIX43.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX43.OrderCancelReplaceRequest();
                    case QuickFix.FIX43.OrderCancelRequest.MsgType: return new QuickFix.FIX43.OrderCancelRequest();
                    case QuickFix.FIX43.OrderCancelReject.MsgType: return new QuickFix.FIX43.OrderCancelReject();
                    case QuickFix.FIX43.OrderStatusRequest.MsgType: return new QuickFix.FIX43.OrderStatusRequest();
                    case QuickFix.FIX43.OrderMassCancelRequest.MsgType: return new QuickFix.FIX43.OrderMassCancelRequest();
                    case QuickFix.FIX43.OrderMassCancelReport.MsgType: return new QuickFix.FIX43.OrderMassCancelReport();
                    case QuickFix.FIX43.OrderMassStatusRequest.MsgType: return new QuickFix.FIX43.OrderMassStatusRequest();
                    case QuickFix.FIX43.NewOrderCross.MsgType: return new QuickFix.FIX43.NewOrderCross();
                    case QuickFix.FIX43.CrossOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX43.CrossOrderCancelReplaceRequest();
                    case QuickFix.FIX43.CrossOrderCancelRequest.MsgType: return new QuickFix.FIX43.CrossOrderCancelRequest();
                    case QuickFix.FIX43.NewOrderMultileg.MsgType: return new QuickFix.FIX43.NewOrderMultileg();
                    case QuickFix.FIX43.MultilegOrderCancelReplaceRequest.MsgType: return new QuickFix.FIX43.MultilegOrderCancelReplaceRequest();
                    case QuickFix.FIX43.BidRequest.MsgType: return new QuickFix.FIX43.BidRequest();
                    case QuickFix.FIX43.BidResponse.MsgType: return new QuickFix.FIX43.BidResponse();
                    case QuickFix.FIX43.NewOrderList.MsgType: return new QuickFix.FIX43.NewOrderList();
                    case QuickFix.FIX43.ListStrikePrice.MsgType: return new QuickFix.FIX43.ListStrikePrice();
                    case QuickFix.FIX43.ListExecute.MsgType: return new QuickFix.FIX43.ListExecute();
                    case QuickFix.FIX43.ListCancelRequest.MsgType: return new QuickFix.FIX43.ListCancelRequest();
                    case QuickFix.FIX43.ListStatusRequest.MsgType: return new QuickFix.FIX43.ListStatusRequest();
                    case QuickFix.FIX43.ListStatus.MsgType: return new QuickFix.FIX43.ListStatus();
                    case QuickFix.FIX43.Allocation.MsgType: return new QuickFix.FIX43.Allocation();
                    case QuickFix.FIX43.AllocationACK.MsgType: return new QuickFix.FIX43.AllocationACK();
                    case QuickFix.FIX43.SettlementInstructions.MsgType: return new QuickFix.FIX43.SettlementInstructions();
                    case QuickFix.FIX43.TradeCaptureReportRequest.MsgType: return new QuickFix.FIX43.TradeCaptureReportRequest();
                    case QuickFix.FIX43.TradeCaptureReport.MsgType: return new QuickFix.FIX43.TradeCaptureReport();
                    case QuickFix.FIX43.RegistrationInstructions.MsgType: return new QuickFix.FIX43.RegistrationInstructions();
                    case QuickFix.FIX43.RegistrationInstructionsResponse.MsgType: return new QuickFix.FIX43.RegistrationInstructionsResponse();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                throw new System.Exception();
            }

        }
    }
}
