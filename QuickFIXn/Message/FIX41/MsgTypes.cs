// This is a generated file.  Don't edit it directly!

using System.IO;
using System.Reflection;
using System.Xml;

namespace QuickFix
{
    namespace FIX41
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
            public const int Advertisement = '7';
            public const int IndicationofInterest = '6';
            public const int News = 'B';
            public const int Email = 'C';
            public const int QuoteRequest = 'R';
            public const int Quote = 'S';
            public const int NewOrderSingle = 'D';
            public const int ExecutionReport = '8';
            public const int DontKnowTrade = 'Q';
            public const int OrderCancelReplaceRequest = 'G';
            public const int OrderCancelRequest = 'F';
            public const int OrderCancelReject = '9';
            public const int OrderStatusRequest = 'H';
            public const int Allocation = 'J';
            public const int AllocationACK = 'P';
            public const int SettlementInstructions = 'T';
            public const int NewOrderList = 'E';
            public const int ListStatus = 'N';
            public const int ListExecute = 'L';
            public const int ListCancelRequest = 'K';
            public const int ListStatusRequest = 'M';
        }
        
    }
}
