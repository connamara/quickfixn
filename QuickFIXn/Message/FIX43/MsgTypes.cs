// This is a generated file.  Don't edit it directly!

using System.IO;
using System.Reflection;
using System.Xml;

namespace QuickFix
{
    namespace FIX43
    {
        internal static class MsgTypes
        {
            public static int GetMsgType(string msgType)
            {
                int result = 0;
                for (int i = 0; i < msgType.Length; i++)
                {
                    result += (msgType[i]<<(8*i));
                }
                return result;
            }
          
            public const int Heartbeat = '0';
            public const int Logon = 'A';
            public const int TestRequest = '1';
            public const int ResendRequest = '2';
            public const int Reject = '3';
            public const int SequenceReset = '4';
            public const int Logout = '5';
            public const int BusinessMessageReject = 'j';
            public const int Advertisement = '7';
            public const int IndicationOfInterest = '6';
            public const int News = 'B';
            public const int Email = 'C';
            public const int QuoteRequest = 'R';
            public const int QuoteRequestReject = 'A' + ('G' << 8);
            public const int RFQRequest = 'A' + ('H' << 8);
            public const int Quote = 'S';
            public const int QuoteCancel = 'Z';
            public const int QuoteStatusRequest = 'a';
            public const int QuoteStatusReport = 'A' + ('I' << 8);
            public const int MassQuote = 'i';
            public const int MassQuoteAcknowledgement = 'b';
            public const int MarketDataRequest = 'V';
            public const int MarketDataSnapshotFullRefresh = 'W';
            public const int MarketDataIncrementalRefresh = 'X';
            public const int MarketDataRequestReject = 'Y';
            public const int SecurityDefinitionRequest = 'c';
            public const int SecurityDefinition = 'd';
            public const int SecurityTypeRequest = 'v';
            public const int SecurityTypes = 'w';
            public const int SecurityListRequest = 'x';
            public const int SecurityList = 'y';
            public const int DerivativeSecurityListRequest = 'z';
            public const int DerivativeSecurityList = 'A' + ('A' << 8);
            public const int SecurityStatusRequest = 'e';
            public const int SecurityStatus = 'f';
            public const int TradingSessionStatusRequest = 'g';
            public const int TradingSessionStatus = 'h';
            public const int NewOrderSingle = 'D';
            public const int ExecutionReport = '8';
            public const int DontKnowTrade = 'Q';
            public const int OrderCancelReplaceRequest = 'G';
            public const int OrderCancelRequest = 'F';
            public const int OrderCancelReject = '9';
            public const int OrderStatusRequest = 'H';
            public const int OrderMassCancelRequest = 'q';
            public const int OrderMassCancelReport = 'r';
            public const int OrderMassStatusRequest = 'A' + ('F' << 8);
            public const int NewOrderCross = 's';
            public const int CrossOrderCancelReplaceRequest = 't';
            public const int CrossOrderCancelRequest = 'u';
            public const int NewOrderMultileg = 'A' + ('B' << 8);
            public const int MultilegOrderCancelReplaceRequest = 'A' + ('C' << 8);
            public const int BidRequest = 'k';
            public const int BidResponse = 'l';
            public const int NewOrderList = 'E';
            public const int ListStrikePrice = 'm';
            public const int ListExecute = 'L';
            public const int ListCancelRequest = 'K';
            public const int ListStatusRequest = 'M';
            public const int ListStatus = 'N';
            public const int Allocation = 'J';
            public const int AllocationACK = 'P';
            public const int SettlementInstructions = 'T';
            public const int TradeCaptureReportRequest = 'A' + ('D' << 8);
            public const int TradeCaptureReport = 'A' + ('E' << 8);
            public const int RegistrationInstructions = 'o';
            public const int RegistrationInstructionsResponse = 'p';
        }
        
    }
}
