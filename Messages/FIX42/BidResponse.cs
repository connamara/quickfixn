// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX42;

public class BidResponse : Message
{
    public const string MsgType = "l";

    public BidResponse() : base()
    {
        Header.SetField(new MsgType("l"));
    }

    public BidID BidID
    {
        get
        {
            BidID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(BidID val) { BidID = val; }
    public BidID Get(BidID val) { GetField(val); return val; }
    public bool IsSet(BidID val) { return IsSetBidID(); }
    public bool IsSetBidID() { return IsSetField(Tags.BidID); }

    public ClientBidID ClientBidID
    {
        get
        {
            ClientBidID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(ClientBidID val) { ClientBidID = val; }
    public ClientBidID Get(ClientBidID val) { GetField(val); return val; }
    public bool IsSet(ClientBidID val) { return IsSetClientBidID(); }
    public bool IsSetClientBidID() { return IsSetField(Tags.ClientBidID); }

    public NoBidComponents NoBidComponents
    {
        get
        {
            NoBidComponents val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoBidComponents val) { NoBidComponents = val; }
    public NoBidComponents Get(NoBidComponents val) { GetField(val); return val; }
    public bool IsSet(NoBidComponents val) { return IsSetNoBidComponents(); }
    public bool IsSetNoBidComponents() { return IsSetField(Tags.NoBidComponents); }

    public class NoBidComponentsGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.Commission, Tags.CommType, Tags.ListID, Tags.Country, Tags.Side, Tags.Price, Tags.PriceType, Tags.FairValue, Tags.NetGrossInd, Tags.SettlmntTyp, Tags.FutSettDate, Tags.TradingSessionID, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.Commission, Tags.CommType, Tags.ListID, Tags.Country, Tags.Side, Tags.Price, Tags.PriceType, Tags.FairValue, Tags.NetGrossInd, Tags.SettlmntTyp, Tags.FutSettDate, Tags.TradingSessionID, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};

        public NoBidComponentsGroup()
          : base(Tags.NoBidComponents, Tags.Commission, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoBidComponentsGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public Commission Commission
        {
            get
            {
                Commission val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Commission val) { Commission = val; }
        public Commission Get(Commission val) { GetField(val); return val; }
        public bool IsSet(Commission val) { return IsSetCommission(); }
        public bool IsSetCommission() { return IsSetField(Tags.Commission); }

        public CommType CommType
        {
            get
            {
                CommType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(CommType val) { CommType = val; }
        public CommType Get(CommType val) { GetField(val); return val; }
        public bool IsSet(CommType val) { return IsSetCommType(); }
        public bool IsSetCommType() { return IsSetField(Tags.CommType); }

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

        public Country Country
        {
            get
            {
                Country val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Country val) { Country = val; }
        public Country Get(Country val) { GetField(val); return val; }
        public bool IsSet(Country val) { return IsSetCountry(); }
        public bool IsSetCountry() { return IsSetField(Tags.Country); }

        public Side Side
        {
            get
            {
                Side val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Side val) { Side = val; }
        public Side Get(Side val) { GetField(val); return val; }
        public bool IsSet(Side val) { return IsSetSide(); }
        public bool IsSetSide() { return IsSetField(Tags.Side); }

        public Price Price
        {
            get
            {
                Price val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Price val) { Price = val; }
        public Price Get(Price val) { GetField(val); return val; }
        public bool IsSet(Price val) { return IsSetPrice(); }
        public bool IsSetPrice() { return IsSetField(Tags.Price); }

        public PriceType PriceType
        {
            get
            {
                PriceType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(PriceType val) { PriceType = val; }
        public PriceType Get(PriceType val) { GetField(val); return val; }
        public bool IsSet(PriceType val) { return IsSetPriceType(); }
        public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }

        public FairValue FairValue
        {
            get
            {
                FairValue val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FairValue val) { FairValue = val; }
        public FairValue Get(FairValue val) { GetField(val); return val; }
        public bool IsSet(FairValue val) { return IsSetFairValue(); }
        public bool IsSetFairValue() { return IsSetField(Tags.FairValue); }

        public NetGrossInd NetGrossInd
        {
            get
            {
                NetGrossInd val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(NetGrossInd val) { NetGrossInd = val; }
        public NetGrossInd Get(NetGrossInd val) { GetField(val); return val; }
        public bool IsSet(NetGrossInd val) { return IsSetNetGrossInd(); }
        public bool IsSetNetGrossInd() { return IsSetField(Tags.NetGrossInd); }

        public SettlmntTyp SettlmntTyp
        {
            get
            {
                SettlmntTyp val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(SettlmntTyp val) { SettlmntTyp = val; }
        public SettlmntTyp Get(SettlmntTyp val) { GetField(val); return val; }
        public bool IsSet(SettlmntTyp val) { return IsSetSettlmntTyp(); }
        public bool IsSetSettlmntTyp() { return IsSetField(Tags.SettlmntTyp); }

        public FutSettDate FutSettDate
        {
            get
            {
                FutSettDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(FutSettDate val) { FutSettDate = val; }
        public FutSettDate Get(FutSettDate val) { GetField(val); return val; }
        public bool IsSet(FutSettDate val) { return IsSetFutSettDate(); }
        public bool IsSetFutSettDate() { return IsSetField(Tags.FutSettDate); }

        public TradingSessionID TradingSessionID
        {
            get
            {
                TradingSessionID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradingSessionID val) { TradingSessionID = val; }
        public TradingSessionID Get(TradingSessionID val) { GetField(val); return val; }
        public bool IsSet(TradingSessionID val) { return IsSetTradingSessionID(); }
        public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }

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
}
