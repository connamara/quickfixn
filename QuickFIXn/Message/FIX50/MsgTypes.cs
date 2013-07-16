// This is a generated file.  Don't edit it directly!

using System.IO;
using System.Reflection;
using System.Xml;

namespace QuickFix
{
    namespace FIX50
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
          
            public const int IOI = '6';
            public const int Advertisement = '7';
            public const int ExecutionReport = '8';
            public const int OrderCancelReject = '9';
            public const int News = 'B';
            public const int Email = 'C';
            public const int NewOrderSingle = 'D';
            public const int NewOrderList = 'E';
            public const int OrderCancelRequest = 'F';
            public const int OrderCancelReplaceRequest = 'G';
            public const int OrderStatusRequest = 'H';
            public const int AllocationInstruction = 'J';
            public const int ListCancelRequest = 'K';
            public const int ListExecute = 'L';
            public const int ListStatusRequest = 'M';
            public const int ListStatus = 'N';
            public const int AllocationInstructionAck = 'P';
            public const int DontKnowTrade = 'Q';
            public const int QuoteRequest = 'R';
            public const int Quote = 'S';
            public const int SettlementInstructions = 'T';
            public const int MarketDataRequest = 'V';
            public const int MarketDataSnapshotFullRefresh = 'W';
            public const int MarketDataIncrementalRefresh = 'X';
            public const int MarketDataRequestReject = 'Y';
            public const int QuoteCancel = 'Z';
            public const int QuoteStatusRequest = 'a';
            public const int MassQuoteAcknowledgement = 'b';
            public const int SecurityDefinitionRequest = 'c';
            public const int SecurityDefinition = 'd';
            public const int SecurityStatusRequest = 'e';
            public const int SecurityStatus = 'f';
            public const int TradingSessionStatusRequest = 'g';
            public const int TradingSessionStatus = 'h';
            public const int MassQuote = 'i';
            public const int BusinessMessageReject = 'j';
            public const int BidRequest = 'k';
            public const int BidResponse = 'l';
            public const int ListStrikePrice = 'm';
            public const int RegistrationInstructions = 'o';
            public const int RegistrationInstructionsResponse = 'p';
            public const int OrderMassCancelRequest = 'q';
            public const int OrderMassCancelReport = 'r';
            public const int NewOrderCross = 's';
            public const int CrossOrderCancelReplaceRequest = 't';
            public const int CrossOrderCancelRequest = 'u';
            public const int SecurityTypeRequest = 'v';
            public const int SecurityTypes = 'w';
            public const int SecurityListRequest = 'x';
            public const int SecurityList = 'y';
            public const int DerivativeSecurityListRequest = 'z';
            public const int DerivativeSecurityList = 'A' + ('A' << 8);
            public const int NewOrderMultileg = 'A' + ('B' << 8);
            public const int MultilegOrderCancelReplace = 'A' + ('C' << 8);
            public const int TradeCaptureReportRequest = 'A' + ('D' << 8);
            public const int TradeCaptureReport = 'A' + ('E' << 8);
            public const int OrderMassStatusRequest = 'A' + ('F' << 8);
            public const int QuoteRequestReject = 'A' + ('G' << 8);
            public const int RFQRequest = 'A' + ('H' << 8);
            public const int QuoteStatusReport = 'A' + ('I' << 8);
            public const int QuoteResponse = 'A' + ('J' << 8);
            public const int Confirmation = 'A' + ('K' << 8);
            public const int PositionMaintenanceRequest = 'A' + ('L' << 8);
            public const int PositionMaintenanceReport = 'A' + ('M' << 8);
            public const int RequestForPositions = 'A' + ('N' << 8);
            public const int RequestForPositionsAck = 'A' + ('O' << 8);
            public const int PositionReport = 'A' + ('P' << 8);
            public const int TradeCaptureReportRequestAck = 'A' + ('Q' << 8);
            public const int TradeCaptureReportAck = 'A' + ('R' << 8);
            public const int AllocationReport = 'A' + ('S' << 8);
            public const int AllocationReportAck = 'A' + ('T' << 8);
            public const int ConfirmationAck = 'A' + ('U' << 8);
            public const int SettlementInstructionRequest = 'A' + ('V' << 8);
            public const int AssignmentReport = 'A' + ('W' << 8);
            public const int CollateralRequest = 'A' + ('X' << 8);
            public const int CollateralAssignment = 'A' + ('Y' << 8);
            public const int CollateralResponse = 'A' + ('Z' << 8);
            public const int CollateralReport = 'B' + ('A' << 8);
            public const int CollateralInquiry = 'B' + ('B' << 8);
            public const int NetworkCounterpartySystemStatusRequest = 'B' + ('C' << 8);
            public const int NetworkCounterpartySystemStatusResponse = 'B' + ('D' << 8);
            public const int UserRequest = 'B' + ('E' << 8);
            public const int UserResponse = 'B' + ('F' << 8);
            public const int CollateralInquiryAck = 'B' + ('G' << 8);
            public const int ConfirmationRequest = 'B' + ('H' << 8);
            public const int ContraryIntentionReport = 'B' + ('O' << 8);
            public const int SecurityDefinitionUpdateReport = 'B' + ('P' << 8);
            public const int SecurityListUpdateReport = 'B' + ('K' << 8);
            public const int AdjustedPositionReport = 'B' + ('L' << 8);
            public const int AllocationInstructionAlert = 'B' + ('M' << 8);
            public const int ExecutionAcknowledgement = 'B' + ('N' << 8);
            public const int TradingSessionList = 'B' + ('J' << 8);
            public const int TradingSessionListRequest = 'B' + ('I' << 8);
        }
        
    }
}
