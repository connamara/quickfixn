// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix
{
    namespace FIX50SP2
    {
        public class MessageFactory : IMessageFactory
        {
            public ICollection<string> GetSupportedBeginStrings()
            {
                return new [] { BeginString.FIX50SP2 };
            }


            public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
            {
                return Create(beginString, msgType);
            }


            public QuickFix.Message Create(string beginString, string msgType)
            {
                switch (msgType)
                {
                    case QuickFix.FIX50SP2.ExecutionReport.MsgType: return new QuickFix.FIX50SP2.ExecutionReport();
                    case QuickFix.FIX50SP2.OrderCancelReject.MsgType: return new QuickFix.FIX50SP2.OrderCancelReject();
                    case QuickFix.FIX50SP2.News.MsgType: return new QuickFix.FIX50SP2.News();
                    case QuickFix.FIX50SP2.NewOrderSingle.MsgType: return new QuickFix.FIX50SP2.NewOrderSingle();
                    case QuickFix.FIX50SP2.OrderCancelRequest.MsgType: return new QuickFix.FIX50SP2.OrderCancelRequest();
                    case QuickFix.FIX50SP2.OrderCancelReplaceRequest.MsgType: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest();
                    case QuickFix.FIX50SP2.OrderStatusRequest.MsgType: return new QuickFix.FIX50SP2.OrderStatusRequest();
                    case QuickFix.FIX50SP2.Quote.MsgType: return new QuickFix.FIX50SP2.Quote();
                    case QuickFix.FIX50SP2.MarketDataRequest.MsgType: return new QuickFix.FIX50SP2.MarketDataRequest();
                    case QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.MsgType: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh();
                    case QuickFix.FIX50SP2.MarketDataIncrementalRefresh.MsgType: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh();
                    case QuickFix.FIX50SP2.MarketDataRequestReject.MsgType: return new QuickFix.FIX50SP2.MarketDataRequestReject();
                    case QuickFix.FIX50SP2.QuoteCancel.MsgType: return new QuickFix.FIX50SP2.QuoteCancel();
                    case QuickFix.FIX50SP2.QuoteStatusRequest.MsgType: return new QuickFix.FIX50SP2.QuoteStatusRequest();
                    case QuickFix.FIX50SP2.SecurityStatus.MsgType: return new QuickFix.FIX50SP2.SecurityStatus();
                    case QuickFix.FIX50SP2.SecurityStatusRequest.MsgType: return new QuickFix.FIX50SP2.SecurityStatusRequest();
                    case QuickFix.FIX50SP2.BusinessMessageReject.MsgType: return new QuickFix.FIX50SP2.BusinessMessageReject();
                    case QuickFix.FIX50SP2.OrderMassCancelRequest.MsgType: return new QuickFix.FIX50SP2.OrderMassCancelRequest();
                    case QuickFix.FIX50SP2.OrderMassCancelReport.MsgType: return new QuickFix.FIX50SP2.OrderMassCancelReport();
                    case QuickFix.FIX50SP2.SecurityListRequest.MsgType: return new QuickFix.FIX50SP2.SecurityListRequest();
                    case QuickFix.FIX50SP2.SecurityList.MsgType: return new QuickFix.FIX50SP2.SecurityList();
                    case QuickFix.FIX50SP2.OrderMassStatusRequest.MsgType: return new QuickFix.FIX50SP2.OrderMassStatusRequest();
                    case QuickFix.FIX50SP2.QuoteStatusReport.MsgType: return new QuickFix.FIX50SP2.QuoteStatusReport();
                }

                return new QuickFix.Message();
            }


            public Group Create(string beginString, string msgType, int correspondingFieldID)
            {
                if (QuickFix.FIX50SP2.ExecutionReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderCancelReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelReject.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelReject.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.News.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP2.News.NoLinesOfTextGroup();
                    }
                }

                if (QuickFix.FIX50SP2.NewOrderSingle.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderCancelReplaceRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.Quote.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.Quote.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.Quote.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50SP2.MarketDataRequest.NoMDEntryTypesGroup();
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup();
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.MarketDataRequestReject.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteCancel.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoPartyIDsGroup.NoPartySubIDsGroup();
                        case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassCancelRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassCancelReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.SecurityList.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup();
                    }
                }

                if (QuickFix.FIX50SP2.OrderMassStatusRequest.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                if (QuickFix.FIX50SP2.QuoteStatusReport.MsgType.Equals(msgType))
                {
                    switch (correspondingFieldID)
                    {
                        case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoPartyIDsGroup();
                        case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoPartyIDsGroup.NoPartySubIDsGroup();
                    }
                }

                return null;
            }

        }
    }
}
