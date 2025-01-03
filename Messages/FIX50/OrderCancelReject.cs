// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50;

public class OrderCancelReject : Message
{
    public const string MsgType = "9";

    public OrderCancelReject() : base()
    {
        Header.SetField(new MsgType("9"));
    }

    public OrderCancelReject(
            OrderID aOrderID,
            ClOrdID aClOrdID,
            OrigClOrdID aOrigClOrdID,
            OrdStatus aOrdStatus,
            CxlRejResponseTo aCxlRejResponseTo
        ) : this()
    {
        OrderID = aOrderID;
        ClOrdID = aClOrdID;
        OrigClOrdID = aOrigClOrdID;
        OrdStatus = aOrdStatus;
        CxlRejResponseTo = aCxlRejResponseTo;
    }

    public OrderID OrderID
    {
        get
        {
            OrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrderID val) { OrderID = val; }
    public OrderID Get(OrderID val) { GetField(val); return val; }
    public bool IsSet(OrderID val) { return IsSetOrderID(); }
    public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

    public SecondaryOrderID SecondaryOrderID
    {
        get
        {
            SecondaryOrderID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryOrderID val) { SecondaryOrderID = val; }
    public SecondaryOrderID Get(SecondaryOrderID val) { GetField(val); return val; }
    public bool IsSet(SecondaryOrderID val) { return IsSetSecondaryOrderID(); }
    public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }

    public SecondaryClOrdID SecondaryClOrdID
    {
        get
        {
            SecondaryClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecondaryClOrdID val) { SecondaryClOrdID = val; }
    public SecondaryClOrdID Get(SecondaryClOrdID val) { GetField(val); return val; }
    public bool IsSet(SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }
    public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }

    public ClOrdID ClOrdID
    {
        get
        {
            ClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdID val) { ClOrdID = val; }
    public ClOrdID Get(ClOrdID val) { GetField(val); return val; }
    public bool IsSet(ClOrdID val) { return IsSetClOrdID(); }
    public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }

    public ClOrdLinkID ClOrdLinkID
    {
        get
        {
            ClOrdLinkID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClOrdLinkID val) { ClOrdLinkID = val; }
    public ClOrdLinkID Get(ClOrdLinkID val) { GetField(val); return val; }
    public bool IsSet(ClOrdLinkID val) { return IsSetClOrdLinkID(); }
    public bool IsSetClOrdLinkID() { return IsSetField(Tags.ClOrdLinkID); }

    public OrigClOrdID OrigClOrdID
    {
        get
        {
            OrigClOrdID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigClOrdID val) { OrigClOrdID = val; }
    public OrigClOrdID Get(OrigClOrdID val) { GetField(val); return val; }
    public bool IsSet(OrigClOrdID val) { return IsSetOrigClOrdID(); }
    public bool IsSetOrigClOrdID() { return IsSetField(Tags.OrigClOrdID); }

    public OrdStatus OrdStatus
    {
        get
        {
            OrdStatus val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrdStatus val) { OrdStatus = val; }
    public OrdStatus Get(OrdStatus val) { GetField(val); return val; }
    public bool IsSet(OrdStatus val) { return IsSetOrdStatus(); }
    public bool IsSetOrdStatus() { return IsSetField(Tags.OrdStatus); }

    public WorkingIndicator WorkingIndicator
    {
        get
        {
            WorkingIndicator val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(WorkingIndicator val) { WorkingIndicator = val; }
    public WorkingIndicator Get(WorkingIndicator val) { GetField(val); return val; }
    public bool IsSet(WorkingIndicator val) { return IsSetWorkingIndicator(); }
    public bool IsSetWorkingIndicator() { return IsSetField(Tags.WorkingIndicator); }

    public OrigOrdModTime OrigOrdModTime
    {
        get
        {
            OrigOrdModTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(OrigOrdModTime val) { OrigOrdModTime = val; }
    public OrigOrdModTime Get(OrigOrdModTime val) { GetField(val); return val; }
    public bool IsSet(OrigOrdModTime val) { return IsSetOrigOrdModTime(); }
    public bool IsSetOrigOrdModTime() { return IsSetField(Tags.OrigOrdModTime); }

    public ListID ListID
    {
        get
        {
            ListID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ListID val) { ListID = val; }
    public ListID Get(ListID val) { GetField(val); return val; }
    public bool IsSet(ListID val) { return IsSetListID(); }
    public bool IsSetListID() { return IsSetField(Tags.ListID); }

    public Account Account
    {
        get
        {
            Account val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Account val) { Account = val; }
    public Account Get(Account val) { GetField(val); return val; }
    public bool IsSet(Account val) { return IsSetAccount(); }
    public bool IsSetAccount() { return IsSetField(Tags.Account); }

    public AcctIDSource AcctIDSource
    {
        get
        {
            AcctIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AcctIDSource val) { AcctIDSource = val; }
    public AcctIDSource Get(AcctIDSource val) { GetField(val); return val; }
    public bool IsSet(AcctIDSource val) { return IsSetAcctIDSource(); }
    public bool IsSetAcctIDSource() { return IsSetField(Tags.AcctIDSource); }

    public AccountType AccountType
    {
        get
        {
            AccountType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(AccountType val) { AccountType = val; }
    public AccountType Get(AccountType val) { GetField(val); return val; }
    public bool IsSet(AccountType val) { return IsSetAccountType(); }
    public bool IsSetAccountType() { return IsSetField(Tags.AccountType); }

    public TradeOriginationDate TradeOriginationDate
    {
        get
        {
            TradeOriginationDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeOriginationDate val) { TradeOriginationDate = val; }
    public TradeOriginationDate Get(TradeOriginationDate val) { GetField(val); return val; }
    public bool IsSet(TradeOriginationDate val) { return IsSetTradeOriginationDate(); }
    public bool IsSetTradeOriginationDate() { return IsSetField(Tags.TradeOriginationDate); }

    public TradeDate TradeDate
    {
        get
        {
            TradeDate val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TradeDate val) { TradeDate = val; }
    public TradeDate Get(TradeDate val) { GetField(val); return val; }
    public bool IsSet(TradeDate val) { return IsSetTradeDate(); }
    public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public CxlRejResponseTo CxlRejResponseTo
    {
        get
        {
            CxlRejResponseTo val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CxlRejResponseTo val) { CxlRejResponseTo = val; }
    public CxlRejResponseTo Get(CxlRejResponseTo val) { GetField(val); return val; }
    public bool IsSet(CxlRejResponseTo val) { return IsSetCxlRejResponseTo(); }
    public bool IsSetCxlRejResponseTo() { return IsSetField(Tags.CxlRejResponseTo); }

    public CxlRejReason CxlRejReason
    {
        get
        {
            CxlRejReason val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(CxlRejReason val) { CxlRejReason = val; }
    public CxlRejReason Get(CxlRejReason val) { GetField(val); return val; }
    public bool IsSet(CxlRejReason val) { return IsSetCxlRejReason(); }
    public bool IsSetCxlRejReason() { return IsSetField(Tags.CxlRejReason); }

    public Text Text
    {
        get
        {
            Text val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Text val) { Text = val; }
    public Text Get(Text val) { GetField(val); return val; }
    public bool IsSet(Text val) { return IsSetText(); }
    public bool IsSetText() { return IsSetField(Tags.Text); }

    public EncodedTextLen EncodedTextLen
    {
        get
        {
            EncodedTextLen val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedTextLen val) { EncodedTextLen = val; }
    public EncodedTextLen Get(EncodedTextLen val) { GetField(val); return val; }
    public bool IsSet(EncodedTextLen val) { return IsSetEncodedTextLen(); }
    public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }

    public EncodedText EncodedText
    {
        get
        {
            EncodedText val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(EncodedText val) { EncodedText = val; }
    public EncodedText Get(EncodedText val) { GetField(val); return val; }
    public bool IsSet(EncodedText val) { return IsSetEncodedText(); }
    public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }
}
