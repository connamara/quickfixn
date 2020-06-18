// This is a generated file.  Don't edit it directly!

using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// Account Field
    /// </summary>/
    public sealed class Account : StringField
    {
        public const int TAG = 1;

        public Account()
            :base(Tags.Account) {}
        public Account(string val)
            :base(Tags.Account, val) {}

    }


    /// <summary>
    /// AdvId Field
    /// </summary>/
    public sealed class AdvId : StringField
    {
        public const int TAG = 2;

        public AdvId()
            :base(Tags.AdvId) {}
        public AdvId(string val)
            :base(Tags.AdvId, val) {}

    }


    /// <summary>
    /// AdvRefID Field
    /// </summary>/
    public sealed class AdvRefID : StringField
    {
        public const int TAG = 3;

        public AdvRefID()
            :base(Tags.AdvRefID) {}
        public AdvRefID(string val)
            :base(Tags.AdvRefID, val) {}

    }


    /// <summary>
    /// AdvSide Field
    /// </summary>/
    public sealed class AdvSide : CharField
    {
        public const int TAG = 4;

        public AdvSide()
            :base(Tags.AdvSide) {}
        public AdvSide(char val)
            :base(Tags.AdvSide, val) {}


        // Field Enumerations
        public const char BUY = 'B';
        public const char SELL = 'S';
        public const char TRADE = 'T';
        public const char CROSS = 'X';
    }


    /// <summary>
    /// AdvTransType Field
    /// </summary>/
    public sealed class AdvTransType : StringField
    {
        public const int TAG = 5;

        public AdvTransType()
            :base(Tags.AdvTransType) {}
        public AdvTransType(string val)
            :base(Tags.AdvTransType, val) {}


        // Field Enumerations
        public const string CANCEL = "C";
        public const string NEW = "N";
        public const string REPLACE = "R";
    }


    /// <summary>
    /// AvgPx Field
    /// </summary>/
    public sealed class AvgPx : DecimalField
    {
        public const int TAG = 6;

        public AvgPx()
            :base(Tags.AvgPx) {}
        public AvgPx(Decimal val)
            :base(Tags.AvgPx, val) {}

    }


    /// <summary>
    /// BeginSeqNo Field
    /// </summary>/
    public sealed class BeginSeqNo : IntField
    {
        public const int TAG = 7;

        public BeginSeqNo()
            :base(Tags.BeginSeqNo) {}
        public BeginSeqNo(int val)
            :base(Tags.BeginSeqNo, val) {}

    }


    /// <summary>
    /// BeginString Field
    /// </summary>/
    public sealed class BeginString : StringField
    {
        public const int TAG = 8;

        public BeginString()
            :base(Tags.BeginString) {}
        public BeginString(string val)
            :base(Tags.BeginString, val) {}

    }


    /// <summary>
    /// BodyLength Field
    /// </summary>/
    public sealed class BodyLength : IntField
    {
        public const int TAG = 9;

        public BodyLength()
            :base(Tags.BodyLength) {}
        public BodyLength(int val)
            :base(Tags.BodyLength, val) {}

    }


    /// <summary>
    /// CheckSum Field
    /// </summary>/
    public sealed class CheckSum : StringField
    {
        public const int TAG = 10;

        public CheckSum()
            :base(Tags.CheckSum) {}
        public CheckSum(string val)
            :base(Tags.CheckSum, val) {}

    }


    /// <summary>
    /// ClOrdID Field
    /// </summary>/
    public sealed class ClOrdID : StringField
    {
        public const int TAG = 11;

        public ClOrdID()
            :base(Tags.ClOrdID) {}
        public ClOrdID(string val)
            :base(Tags.ClOrdID, val) {}

    }


    /// <summary>
    /// Commission Field
    /// </summary>/
    public sealed class Commission : DecimalField
    {
        public const int TAG = 12;

        public Commission()
            :base(Tags.Commission) {}
        public Commission(Decimal val)
            :base(Tags.Commission, val) {}

    }


    /// <summary>
    /// CommType Field
    /// </summary>/
    public sealed class CommType : CharField
    {
        public const int TAG = 13;

        public CommType()
            :base(Tags.CommType) {}
        public CommType(char val)
            :base(Tags.CommType, val) {}


        // Field Enumerations
        public const char PER_UNIT = '1';
        public const char PERCENT = '2';
        public const char ABSOLUTE = '3';
        public const char PERCENTAGE_WAIVED_4 = '4';
        public const char PERCENTAGE_WAIVED_5 = '5';
        public const char POINTS_PER_BOND_OR_CONTRACT = '6';
        public const char PERCENTAGE = '2';
        public const char PERCENTAGE_WAIVED_CASH_DISCOUNT = '4';
        public const char PERCENTAGE_WAIVED_ENHANCED_UNITS = '5';
        public const char POINTS_PER_BOND_OR_OR_CONTRACT = '6';
        public const char PER_SHARE = '1';
        public const char PER_BOND = '6';
    }


    /// <summary>
    /// CumQty Field
    /// </summary>/
    public sealed class CumQty : DecimalField
    {
        public const int TAG = 14;

        public CumQty()
            :base(Tags.CumQty) {}
        public CumQty(Decimal val)
            :base(Tags.CumQty, val) {}

    }


    /// <summary>
    /// Currency Field
    /// </summary>/
    public sealed class Currency : StringField
    {
        public const int TAG = 15;

        public Currency()
            :base(Tags.Currency) {}
        public Currency(string val)
            :base(Tags.Currency, val) {}

    }


    /// <summary>
    /// EndSeqNo Field
    /// </summary>/
    public sealed class EndSeqNo : IntField
    {
        public const int TAG = 16;

        public EndSeqNo()
            :base(Tags.EndSeqNo) {}
        public EndSeqNo(int val)
            :base(Tags.EndSeqNo, val) {}

    }


    /// <summary>
    /// ExecID Field
    /// </summary>/
    public sealed class ExecID : StringField
    {
        public const int TAG = 17;

        public ExecID()
            :base(Tags.ExecID) {}
        public ExecID(string val)
            :base(Tags.ExecID, val) {}

    }


    /// <summary>
    /// ExecInst Field
    /// </summary>/
    public sealed class ExecInst : StringField
    {
        public const int TAG = 18;

        public ExecInst()
            :base(Tags.ExecInst) {}
        public ExecInst(string val)
            :base(Tags.ExecInst, val) {}


        // Field Enumerations
        public const string STAY_ON_OFFER_SIDE = "0";
        public const string NOT_HELD = "1";
        public const string WORK = "2";
        public const string GO_ALONG = "3";
        public const string OVER_THE_DAY = "4";
        public const string HELD = "5";
        public const string PARTICIPANT_DONT_INITIATE = "6";
        public const string STRICT_SCALE = "7";
        public const string TRY_TO_SCALE = "8";
        public const string STAY_ON_BID_SIDE = "9";
        public const string NO_CROSS = "A";
        public const string TRAILING_STOP_PEG = "a";
        public const string OK_TO_CROSS = "B";
        public const string STRICT_LIMIT = "b";
        public const string IGNORE_PRICE_VALIDITY_CHECKS = "c";
        public const string CALL_FIRST = "C";
        public const string PEG_TO_LIMIT_PRICE = "d";
        public const string PERCENT_OF_VOLUME = "D";
        public const string DO_NOT_INCREASE = "E";
        public const string WORK_TO_TARGET_STRATEGY = "e";
        public const string DO_NOT_REDUCE = "F";
        public const string ALL_OR_NONE = "G";
        public const string REINSTATE_ON_SYSTEM_FAILURE = "H";
        public const string INSTITUTIONS_ONLY = "I";
        public const string REINSTATE_ON_TRADING_HALT = "J";
        public const string CANCEL_ON_TRADING_HALT = "K";
        public const string LAST_PEG = "L";
        public const string MID_PRICE_PEG = "M";
        public const string NON_NEGOTIABLE = "N";
        public const string OPENING_PEG = "O";
        public const string MARKET_PEG = "P";
        public const string CANCEL_ON_SYSTEM_FAILURE = "Q";
        public const string PRIMARY_PEG = "R";
        public const string SUSPEND = "S";
        public const string CUSTOMER_DISPLAY_INSTRUCTION = "U";
        public const string NETTING = "V";
        public const string PEG_TO_VWAP = "W";
        public const string TRADE_ALONG = "X";
        public const string TRY_TO_STOP = "Y";
        public const string CANCEL_IF_NOT_BEST = "Z";
        public const string INTERMARKET_SWEEP = "f";
        public const string SINGLE_EXECUTION_REQUESTED_FOR_BLOCK_TRADE = "j";
        public const string EXTERNAL_ROUTING_ALLOWED = "g";
        public const string EXTERNAL_ROUTING_NOT_ALLOWED = "h";
        public const string IMBALANCE_ONLY = "i";
        public const string FIXED_PEG_TO_LOCAL_BEST_BID_OR_OFFER_AT_TIME_OF_ORDER = "T";
        public const string BEST_EXECUTION = "k";
        public const string SUSPEND_ON_SYSTEM_FAILURE = "l";
        public const string SUSPEND_ON_TRADING_HALT = "m";
        public const string REINSTATE_ON_CONNECTION_LOSS = "n";
        public const string CANCEL_ON_CONNECTION_LOSS = "o";
        public const string SUSPEND_ON_CONNECTION_LOSS = "p";
        public const string RELEASE_FROM_SUSPENSION = "q";
        public const string EXECUTE_AS_DELTA_NEUTRAL_USING_VOLATILITY_PROVIDED = "r";
        public const string EXECUTE_AS_DURATION_NEUTRAL = "s";
        public const string EXECUTE_AS_FX_NEUTRAL = "t";
        public const string REINSTATE_ON_SYSTEM_FAILUE = "H";
        public const string PARTICIPATE_DONT_INITIATE = "6";
        public const string STAY_ON_BIDSIDE = "9";
        public const string STAY_ON_OFFERSIDE = "0";
        public const string MID_PRICE = "M";
        public const string FIXED_PEG = "T";
        public const string DO_NOT_INCREASE_DNI = "E";
        public const string DO_NOT_REDUCE_DNR = "F";
        public const string ALL_OR_NONE_AON = "G";
        public const string MIDPRICE_PEG = "M";
        public const string NONNEGOTIABLE = "N";
    }


    /// <summary>
    /// ExecRefID Field
    /// </summary>/
    public sealed class ExecRefID : StringField
    {
        public const int TAG = 19;

        public ExecRefID()
            :base(Tags.ExecRefID) {}
        public ExecRefID(string val)
            :base(Tags.ExecRefID, val) {}

    }


    /// <summary>
    /// ExecTransType Field
    /// </summary>/
    public sealed class ExecTransType : CharField
    {
        public const int TAG = 20;

        public ExecTransType()
            :base(Tags.ExecTransType) {}
        public ExecTransType(char val)
            :base(Tags.ExecTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char CANCEL = '1';
        public const char CORRECT = '2';
        public const char STATUS = '3';
    }


    /// <summary>
    /// HandlInst Field
    /// </summary>/
    public sealed class HandlInst : CharField
    {
        public const int TAG = 21;

        public HandlInst()
            :base(Tags.HandlInst) {}
        public HandlInst(char val)
            :base(Tags.HandlInst, val) {}


        // Field Enumerations
        public const char AUTOMATED_EXECUTION_ORDER_PRIVATE_NO_BROKER_INTERVENTION = '1';
        public const char AUTOMATED_EXECUTION_ORDER_PUBLIC_BROKER_INTERVENTION_OK = '2';
        public const char MANUAL_ORDER_BEST_EXECUTION = '3';
        public const char AUTOMATED_EXECUTION_ORDER_PRIVATE = '1';
        public const char AUTOMATED_EXECUTION_ORDER_PUBLIC = '2';
        public const char MANUAL_ORDER = '3';
    }


    /// <summary>
    /// IDSource Field
    /// </summary>/
    public sealed class IDSource : StringField
    {
        public const int TAG = 22;

        public IDSource()
            :base(Tags.IDSource) {}
        public IDSource(string val)
            :base(Tags.IDSource, val) {}


        // Field Enumerations
        public const string CUSIP = "1";
        public const string SEDOL = "2";
        public const string QUIK = "3";
        public const string ISIN_NUMBER = "4";
        public const string RIC_CODE = "5";
        public const string ISO_CURRENCY_CODE = "6";
        public const string ISO_COUNTRY_CODE = "7";
        public const string EXCHANGE_SYMBOL = "8";
        public const string CONSOLIDATED_TAPE_ASSOCIATION = "9";
    }


    /// <summary>
    /// IOIid Field
    /// </summary>/
    public sealed class IOIid : StringField
    {
        public const int TAG = 23;

        public IOIid()
            :base(Tags.IOIid) {}
        public IOIid(string val)
            :base(Tags.IOIid, val) {}

    }


    /// <summary>
    /// IOIOthSvc Field
    /// </summary>/
    public sealed class IOIOthSvc : CharField
    {
        public const int TAG = 24;

        public IOIOthSvc()
            :base(Tags.IOIOthSvc) {}
        public IOIOthSvc(char val)
            :base(Tags.IOIOthSvc, val) {}

    }


    /// <summary>
    /// IOIQltyInd Field
    /// </summary>/
    public sealed class IOIQltyInd : CharField
    {
        public const int TAG = 25;

        public IOIQltyInd()
            :base(Tags.IOIQltyInd) {}
        public IOIQltyInd(char val)
            :base(Tags.IOIQltyInd, val) {}


        // Field Enumerations
        public const char HIGH = 'H';
        public const char LOW = 'L';
        public const char MEDIUM = 'M';
    }


    /// <summary>
    /// IOIRefID Field
    /// </summary>/
    public sealed class IOIRefID : StringField
    {
        public const int TAG = 26;

        public IOIRefID()
            :base(Tags.IOIRefID) {}
        public IOIRefID(string val)
            :base(Tags.IOIRefID, val) {}

    }


    /// <summary>
    /// IOIShares Field
    /// </summary>/
    public sealed class IOIShares : StringField
    {
        public const int TAG = 27;

        public IOIShares()
            :base(Tags.IOIShares) {}
        public IOIShares(string val)
            :base(Tags.IOIShares, val) {}

    }


    /// <summary>
    /// IOITransType Field
    /// </summary>/
    public sealed class IOITransType : CharField
    {
        public const int TAG = 28;

        public IOITransType()
            :base(Tags.IOITransType) {}
        public IOITransType(char val)
            :base(Tags.IOITransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NEW = 'N';
        public const char REPLACE = 'R';
    }


    /// <summary>
    /// LastCapacity Field
    /// </summary>/
    public sealed class LastCapacity : CharField
    {
        public const int TAG = 29;

        public LastCapacity()
            :base(Tags.LastCapacity) {}
        public LastCapacity(char val)
            :base(Tags.LastCapacity, val) {}


        // Field Enumerations
        public const char AGENT = '1';
        public const char CROSS_AS_AGENT = '2';
        public const char CROSS_AS_PRINCIPAL = '3';
        public const char PRINCIPAL = '4';
    }


    /// <summary>
    /// LastMkt Field
    /// </summary>/
    public sealed class LastMkt : StringField
    {
        public const int TAG = 30;

        public LastMkt()
            :base(Tags.LastMkt) {}
        public LastMkt(string val)
            :base(Tags.LastMkt, val) {}

    }


    /// <summary>
    /// LastPx Field
    /// </summary>/
    public sealed class LastPx : DecimalField
    {
        public const int TAG = 31;

        public LastPx()
            :base(Tags.LastPx) {}
        public LastPx(Decimal val)
            :base(Tags.LastPx, val) {}

    }


    /// <summary>
    /// LastShares Field
    /// </summary>/
    public sealed class LastShares : DecimalField
    {
        public const int TAG = 32;

        public LastShares()
            :base(Tags.LastShares) {}
        public LastShares(Decimal val)
            :base(Tags.LastShares, val) {}

    }


    /// <summary>
    /// LinesOfText Field
    /// </summary>/
    public sealed class LinesOfText : IntField
    {
        public const int TAG = 33;

        public LinesOfText()
            :base(Tags.LinesOfText) {}
        public LinesOfText(int val)
            :base(Tags.LinesOfText, val) {}

    }


    /// <summary>
    /// MsgSeqNum Field
    /// </summary>/
    public sealed class MsgSeqNum : IntField
    {
        public const int TAG = 34;

        public MsgSeqNum()
            :base(Tags.MsgSeqNum) {}
        public MsgSeqNum(int val)
            :base(Tags.MsgSeqNum, val) {}

    }


    /// <summary>
    /// MsgType Field
    /// </summary>/
    public sealed class MsgType : StringField
    {
        public const int TAG = 35;

        public MsgType()
            :base(Tags.MsgType) {}
        public MsgType(string val)
            :base(Tags.MsgType, val) {}


        // Field Enumerations
        public const string HEARTBEAT = "0";
        public const string TESTREQUEST = "1";
        public const string RESENDREQUEST = "2";
        public const string REJECT = "3";
        public const string SEQUENCERESET = "4";
        public const string LOGOUT = "5";
        public const string IOI = "6";
        public const string ADVERTISEMENT = "7";
        public const string EXECUTIONREPORT = "8";
        public const string ORDERCANCELREJECT = "9";
        public const string LOGON = "A";
        public const string DERIVATIVESECURITYLIST = "AA";
        public const string NEWORDERMULTILEG = "AB";
        public const string MULTILEGORDERCANCELREPLACE = "AC";
        public const string TRADECAPTUREREPORTREQUEST = "AD";
        public const string TRADECAPTUREREPORT = "AE";
        public const string ORDERMASSSTATUSREQUEST = "AF";
        public const string QUOTEREQUESTREJECT = "AG";
        public const string RFQREQUEST = "AH";
        public const string QUOTESTATUSREPORT = "AI";
        public const string QUOTERESPONSE = "AJ";
        public const string CONFIRMATION = "AK";
        public const string POSITIONMAINTENANCEREQUEST = "AL";
        public const string POSITIONMAINTENANCEREPORT = "AM";
        public const string REQUESTFORPOSITIONS = "AN";
        public const string REQUESTFORPOSITIONSACK = "AO";
        public const string POSITIONREPORT = "AP";
        public const string TRADECAPTUREREPORTREQUESTACK = "AQ";
        public const string TRADECAPTUREREPORTACK = "AR";
        public const string ALLOCATIONREPORT = "AS";
        public const string ALLOCATIONREPORTACK = "AT";
        public const string CONFIRMATION_ACK = "AU";
        public const string SETTLEMENTINSTRUCTIONREQUEST = "AV";
        public const string ASSIGNMENTREPORT = "AW";
        public const string COLLATERALREQUEST = "AX";
        public const string COLLATERALASSIGNMENT = "AY";
        public const string COLLATERALRESPONSE = "AZ";
        public const string NEWS = "B";
        public const string COLLATERALREPORT = "BA";
        public const string COLLATERALINQUIRY = "BB";
        public const string NETWORKCOUNTERPARTYSYSTEMSTATUSREQUEST = "BC";
        public const string NETWORKCOUNTERPARTYSYSTEMSTATUSRESPONSE = "BD";
        public const string USERREQUEST = "BE";
        public const string USERRESPONSE = "BF";
        public const string COLLATERALINQUIRYACK = "BG";
        public const string CONFIRMATIONREQUEST = "BH";
        public const string TRADINGSESSIONLISTREQUEST = "BI";
        public const string TRADINGSESSIONLIST = "BJ";
        public const string SECURITYLISTUPDATEREPORT = "BK";
        public const string ADJUSTEDPOSITIONREPORT = "BL";
        public const string ALLOCATIONINSTRUCTIONALERT = "BM";
        public const string EXECUTIONACKNOWLEDGEMENT = "BN";
        public const string CONTRARYINTENTIONREPORT = "BO";
        public const string SECURITYDEFINITIONUPDATEREPORT = "BP";
        public const string SETTLEMENTOBLIGATIONREPORT = "BQ";
        public const string DERIVATIVESECURITYLISTUPDATEREPORT = "BR";
        public const string TRADINGSESSIONLISTUPDATEREPORT = "BS";
        public const string MARKETDEFINITIONREQUEST = "BT";
        public const string MARKETDEFINITION = "BU";
        public const string MARKETDEFINITIONUPDATEREPORT = "BV";
        public const string APPLICATIONMESSAGEREQUEST = "BW";
        public const string APPLICATIONMESSAGEREQUESTACK = "BX";
        public const string APPLICATIONMESSAGEREPORT = "BY";
        public const string ORDERMASSACTIONREPORT = "BZ";
        public const string EMAIL = "C";
        public const string ORDERMASSACTIONREQUEST = "CA";
        public const string USERNOTIFICATION = "CB";
        public const string STREAMASSIGNMENTREQUEST = "CC";
        public const string STREAMASSIGNMENTREPORT = "CD";
        public const string STREAMASSIGNMENTREPORTACK = "CE";
        public const string PARTYDETAILSLISTREQUEST = "CF";
        public const string PARTYDETAILSLISTREPORT = "CG";
        public const string NEWORDERSINGLE = "D";
        public const string NEWORDERLIST = "E";
        public const string ORDERCANCELREQUEST = "F";
        public const string ORDERCANCELREPLACEREQUEST = "G";
        public const string ORDERSTATUSREQUEST = "H";
        public const string ALLOCATIONINSTRUCTION = "J";
        public const string LISTCANCELREQUEST = "K";
        public const string LISTEXECUTE = "L";
        public const string LISTSTATUSREQUEST = "M";
        public const string LISTSTATUS = "N";
        public const string ALLOCATIONINSTRUCTIONACK = "P";
        public const string DONTKNOWTRADEDK = "Q";
        public const string QUOTEREQUEST = "R";
        public const string QUOTE = "S";
        public const string SETTLEMENTINSTRUCTIONS = "T";
        public const string MARKETDATAREQUEST = "V";
        public const string MARKETDATASNAPSHOTFULLREFRESH = "W";
        public const string MARKETDATAINCREMENTALREFRESH = "X";
        public const string MARKETDATAREQUESTREJECT = "Y";
        public const string QUOTECANCEL = "Z";
        public const string QUOTESTATUSREQUEST = "a";
        public const string MASSQUOTEACKNOWLEDGEMENT = "b";
        public const string SECURITYDEFINITIONREQUEST = "c";
        public const string SECURITYDEFINITION = "d";
        public const string SECURITYSTATUSREQUEST = "e";
        public const string SECURITYSTATUS = "f";
        public const string TRADINGSESSIONSTATUSREQUEST = "g";
        public const string TRADINGSESSIONSTATUS = "h";
        public const string MASSQUOTE = "i";
        public const string BUSINESSMESSAGEREJECT = "j";
        public const string BIDREQUEST = "k";
        public const string BIDRESPONSE = "l";
        public const string LISTSTRIKEPRICE = "m";
        public const string XML_NON_FIX = "n";
        public const string REGISTRATIONINSTRUCTIONS = "o";
        public const string REGISTRATIONINSTRUCTIONSRESPONSE = "p";
        public const string ORDERMASSCANCELREQUEST = "q";
        public const string ORDERMASSCANCELREPORT = "r";
        public const string NEWORDERCROSS = "s";
        public const string CROSSORDERCANCELREPLACEREQUEST = "t";
        public const string CROSSORDERCANCELREQUEST = "u";
        public const string SECURITYTYPEREQUEST = "v";
        public const string SECURITYTYPES = "w";
        public const string SECURITYLISTREQUEST = "x";
        public const string SECURITYLIST = "y";
        public const string DERIVATIVESECURITYLISTREQUEST = "z";
        public const string TEST_REQUEST = "1";
        public const string RESEND_REQUEST = "2";
        public const string SEQUENCE_RESET = "4";
        public const string INDICATION_OF_INTEREST = "6";
        public const string EXECUTION_REPORT = "8";
        public const string ORDER_CANCEL_REJECT = "9";
        public const string QUOTE_STATUS_REQUEST = "a";
        public const string DERIVATIVE_SECURITY_LIST = "AA";
        public const string NEW_ORDER_AB = "AB";
        public const string MULTILEG_ORDER_CANCEL_REPLACE = "AC";
        public const string TRADE_CAPTURE_REPORT_REQUEST = "AD";
        public const string TRADE_CAPTURE_REPORT = "AE";
        public const string ORDER_MASS_STATUS_REQUEST = "AF";
        public const string QUOTE_REQUEST_REJECT = "AG";
        public const string RFQ_REQUEST = "AH";
        public const string QUOTE_STATUS_REPORT = "AI";
        public const string QUOTE_RESPONSE = "AJ";
        public const string POSITION_MAINTENANCE_REQUEST = "AL";
        public const string POSITION_MAINTENANCE_REPORT = "AM";
        public const string REQUEST_FOR_POSITIONS = "AN";
        public const string REQUEST_FOR_POSITIONS_ACK = "AO";
        public const string POSITION_REPORT = "AP";
        public const string TRADE_CAPTURE_REPORT_REQUEST_ACK = "AQ";
        public const string TRADE_CAPTURE_REPORT_ACK = "AR";
        public const string ALLOCATION_REPORT = "AS";
        public const string ALLOCATION_REPORT_ACK = "AT";
        public const string SETTLEMENT_INSTRUCTION_REQUEST = "AV";
        public const string ASSIGNMENT_REPORT = "AW";
        public const string COLLATERAL_REQUEST = "AX";
        public const string COLLATERAL_ASSIGNMENT = "AY";
        public const string COLLATERAL_RESPONSE = "AZ";
        public const string MASS_QUOTE_ACKNOWLEDGEMENT = "b";
        public const string COLLATERAL_REPORT = "BA";
        public const string COLLATERAL_INQUIRY = "BB";
        public const string NETWORK_COUNTERPARTY_SYSTEM_STATUS_REQUEST = "BC";
        public const string NETWORK_COUNTERPARTY_SYSTEM_STATUS_RESPONSE = "BD";
        public const string USER_REQUEST = "BE";
        public const string USER_RESPONSE = "BF";
        public const string COLLATERAL_INQUIRY_ACK = "BG";
        public const string CONFIRMATION_REQUEST = "BH";
        public const string SECURITY_DEFINITION_REQUEST = "c";
        public const string SECURITY_DEFINITION = "d";
        public const string NEW_ORDER_D = "D";
        public const string SECURITY_STATUS_REQUEST = "e";
        public const string NEW_ORDER_E = "E";
        public const string ORDER_CANCEL_REQUEST = "F";
        public const string SECURITY_STATUS = "f";
        public const string ORDER_CANCEL_REPLACE_REQUEST = "G";
        public const string TRADING_SESSION_STATUS_REQUEST = "g";
        public const string ORDER_STATUS_REQUEST = "H";
        public const string TRADING_SESSION_STATUS = "h";
        public const string MASS_QUOTE = "i";
        public const string BUSINESS_MESSAGE_REJECT = "j";
        public const string ALLOCATION_INSTRUCTION = "J";
        public const string BID_REQUEST = "k";
        public const string LIST_CANCEL_REQUEST = "K";
        public const string BID_RESPONSE = "l";
        public const string LIST_EXECUTE = "L";
        public const string LIST_STRIKE_PRICE = "m";
        public const string LIST_STATUS_REQUEST = "M";
        public const string XML_MESSAGE = "n";
        public const string LIST_STATUS = "N";
        public const string REGISTRATION_INSTRUCTIONS = "o";
        public const string REGISTRATION_INSTRUCTIONS_RESPONSE = "p";
        public const string ALLOCATION_INSTRUCTION_ACK = "P";
        public const string ORDER_MASS_CANCEL_REQUEST = "q";
        public const string DONT_KNOW_TRADE = "Q";
        public const string QUOTE_REQUEST = "R";
        public const string ORDER_MASS_CANCEL_REPORT = "r";
        public const string NEW_ORDER_s = "s";
        public const string SETTLEMENT_INSTRUCTIONS = "T";
        public const string CROSS_ORDER_CANCEL_REPLACE_REQUEST = "t";
        public const string CROSS_ORDER_CANCEL_REQUEST = "u";
        public const string MARKET_DATA_REQUEST = "V";
        public const string SECURITY_TYPE_REQUEST = "v";
        public const string SECURITY_TYPES = "w";
        public const string MARKET_DATA_W = "W";
        public const string SECURITY_LIST_REQUEST = "x";
        public const string MARKET_DATA_X = "X";
        public const string MARKET_DATA_REQUEST_REJECT = "Y";
        public const string SECURITY_LIST = "y";
        public const string QUOTE_CANCEL = "Z";
        public const string DERIVATIVE_SECURITY_LIST_REQUEST = "z";
        public const string CONTRARY_INTENTION_REPORT = "BO";
        public const string SECURITY_DEFINITION_UPDATE_REPORT = "BP";
        public const string SECURITY_LIST_UPDATE_REPORT = "BK";
        public const string ADJUSTED_POSITION_REPORT = "BL";
        public const string ALLOCATION_INSTRUCTION_ALERT = "BM";
        public const string EXECUTION_ACKNOWLEDGEMENT = "BN";
        public const string TRADING_SESSION_LIST = "BJ";
        public const string TRADING_SESSION_LIST_REQUEST = "BI";
        public const string ORDER_SINGLE = "D";
        public const string ORDER_LIST = "E";
        public const string MARKET_DATA_SNAPSHOT_FULL_REFRESH = "W";
        public const string MARKET_DATA_INCREMENTAL_REFRESH = "X";
        public const string NEW_ORDER_CROSS = "s";
        public const string NEW_ORDER_MULTILEG = "AB";
        public const string NETWORK_STATUS_REQUEST = "BC";
        public const string NETWORK_STATUS_RESPONSE = "BD";
        public const string ORDER_CANCEL = "G";
        public const string ALLOCATION = "J";
        public const string ALLOCATION_ACK = "P";
        public const string MARKET_DATA_SNAPSHOT = "W";
        public const string CROSS_ORDER_CANCEL = "t";
        public const string MULTILEG_ORDER_CANCEL = "AC";
    }


    /// <summary>
    /// NewSeqNo Field
    /// </summary>/
    public sealed class NewSeqNo : IntField
    {
        public const int TAG = 36;

        public NewSeqNo()
            :base(Tags.NewSeqNo) {}
        public NewSeqNo(int val)
            :base(Tags.NewSeqNo, val) {}

    }


    /// <summary>
    /// OrderID Field
    /// </summary>/
    public sealed class OrderID : StringField
    {
        public const int TAG = 37;

        public OrderID()
            :base(Tags.OrderID) {}
        public OrderID(string val)
            :base(Tags.OrderID, val) {}

    }


    /// <summary>
    /// OrderQty Field
    /// </summary>/
    public sealed class OrderQty : DecimalField
    {
        public const int TAG = 38;

        public OrderQty()
            :base(Tags.OrderQty) {}
        public OrderQty(Decimal val)
            :base(Tags.OrderQty, val) {}

    }


    /// <summary>
    /// OrdStatus Field
    /// </summary>/
    public sealed class OrdStatus : CharField
    {
        public const int TAG = 39;

        public OrdStatus()
            :base(Tags.OrdStatus) {}
        public OrdStatus(char val)
            :base(Tags.OrdStatus, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char PARTIALLY_FILLED = '1';
        public const char FILLED = '2';
        public const char DONE_FOR_DAY = '3';
        public const char CANCELED = '4';
        public const char PENDING_CANCEL = '6';
        public const char STOPPED = '7';
        public const char REJECTED = '8';
        public const char SUSPENDED = '9';
        public const char PENDING_NEW = 'A';
        public const char CALCULATED = 'B';
        public const char EXPIRED = 'C';
        public const char ACCEPTED_FOR_BIDDING = 'D';
        public const char PENDING_REPLACE = 'E';
        public const char REPLACED = '5';
        public const char PENDING_CANCELREPLACE = '6';
    }


    /// <summary>
    /// OrdType Field
    /// </summary>/
    public sealed class OrdType : CharField
    {
        public const int TAG = 40;

        public OrdType()
            :base(Tags.OrdType) {}
        public OrdType(char val)
            :base(Tags.OrdType, val) {}


        // Field Enumerations
        public const char MARKET = '1';
        public const char LIMIT = '2';
        public const char STOP = '3';
        public const char STOP_LIMIT = '4';
        public const char MARKET_ON_CLOSE = '5';
        public const char WITH_OR_WITHOUT = '6';
        public const char LIMIT_OR_BETTER = '7';
        public const char LIMIT_WITH_OR_WITHOUT = '8';
        public const char ON_BASIS = '9';
        public const char ON_CLOSE = 'A';
        public const char LIMIT_ON_CLOSE = 'B';
        public const char FOREX_MARKET = 'C';
        public const char PREVIOUSLY_QUOTED = 'D';
        public const char PREVIOUSLY_INDICATED = 'E';
        public const char FOREX_LIMIT = 'F';
        public const char FOREX_SWAP = 'G';
        public const char FOREX_PREVIOUSLY_QUOTED = 'H';
        public const char FUNARI = 'I';
        public const char MARKET_IF_TOUCHED = 'J';
        public const char MARKET_WITH_LEFT_OVER_AS_LIMIT = 'K';
        public const char PREVIOUS_FUND_VALUATION_POINT = 'L';
        public const char NEXT_FUND_VALUATION_POINT = 'M';
        public const char PEGGED = 'P';
        public const char COUNTER_ORDER_SELECTION = 'Q';
        public const char MARKET_WITH_LEFTOVER_AS_LIMIT = 'K';
        public const char FOREX = 'C';
    }


    /// <summary>
    /// OrigClOrdID Field
    /// </summary>/
    public sealed class OrigClOrdID : StringField
    {
        public const int TAG = 41;

        public OrigClOrdID()
            :base(Tags.OrigClOrdID) {}
        public OrigClOrdID(string val)
            :base(Tags.OrigClOrdID, val) {}

    }


    /// <summary>
    /// OrigTime Field
    /// </summary>/
    public sealed class OrigTime : DateTimeField
    {
        public const int TAG = 42;

        public OrigTime()
            :base(Tags.OrigTime) {}
        public OrigTime(DateTime val)
            :base(Tags.OrigTime, val) {}
        public OrigTime(DateTime val, bool showMilliseconds)
            :base(Tags.OrigTime, val, showMilliseconds) {}
		public OrigTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.OrigTime, val, precision) {}

    }


    /// <summary>
    /// PossDupFlag Field
    /// </summary>/
    public sealed class PossDupFlag : BooleanField
    {
        public const int TAG = 43;

        public PossDupFlag()
            :base(Tags.PossDupFlag) {}
        public PossDupFlag(Boolean val)
            :base(Tags.PossDupFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean POSSIBLE_DUPLICATE = true;
        public const Boolean ORIGINAL_TRANSMISSION = false;
    }


    /// <summary>
    /// Price Field
    /// </summary>/
    public sealed class Price : DecimalField
    {
        public const int TAG = 44;

        public Price()
            :base(Tags.Price) {}
        public Price(Decimal val)
            :base(Tags.Price, val) {}

    }


    /// <summary>
    /// RefSeqNum Field
    /// </summary>/
    public sealed class RefSeqNum : IntField
    {
        public const int TAG = 45;

        public RefSeqNum()
            :base(Tags.RefSeqNum) {}
        public RefSeqNum(int val)
            :base(Tags.RefSeqNum, val) {}

    }


    /// <summary>
    /// RelatdSym Field
    /// </summary>/
    public sealed class RelatdSym : StringField
    {
        public const int TAG = 46;

        public RelatdSym()
            :base(Tags.RelatdSym) {}
        public RelatdSym(string val)
            :base(Tags.RelatdSym, val) {}

    }


    /// <summary>
    /// Rule80A Field
    /// </summary>/
    public sealed class Rule80A : CharField
    {
        public const int TAG = 47;

        public Rule80A()
            :base(Tags.Rule80A) {}
        public Rule80A(char val)
            :base(Tags.Rule80A, val) {}


        // Field Enumerations
        public const char AGENCY_SINGLE_ORDER = 'A';
        public const char SHORT_EXEMPT_TRANSACTION_B = 'B';
        public const char PROPRIETARY_NON_ALGORITHMIC_PROGRAM_TRADE = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_MEMBER_FIRM_ORG = 'D';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_PRINCIPAL = 'E';
        public const char SHORT_EXEMPT_TRANSACTION_F = 'F';
        public const char SHORT_EXEMPT_TRANSACTION_H = 'H';
        public const char INDIVIDUAL_INVESTOR_SINGLE_ORDER = 'I';
        public const char PROPRIETARY_ALGORITHMIC_PROGRAM_TRADING = 'J';
        public const char AGENCY_ALGORITHMIC_PROGRAM_TRADING = 'K';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_MEMBER_COMPETING_MARKET_MAKER_AFFLIATED_WITH_THE_FIRM_CLEARING_THE_TRADE = 'L';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_OTHER_MEMBER = 'M';
        public const char AGENT_FOR_OTHER_MEMBER_NON_ALGORITHMIC_PROGRAM_TRADE = 'N';
        public const char PROPRIETARY_TRANSACTIONS_FOR_COMPETING_MARKET_MAKER_THAT_IS_AFFILIATED_WITH_THE_CLEARING_MEMBER = 'O';
        public const char PRINCIPAL = 'P';
        public const char TRANSACTIONS_FOR_THE_ACCOUNT_OF_A_NON_MEMBER_COMPTING_MARKET_MAKER = 'R';
        public const char SPECIALIST_TRADES = 'S';
        public const char TRANSACTIONS_FOR_THE_ACCOUNT_OF_AN_UNAFFILIATED_MEMBERS_COMPETING_MARKET_MAKER = 'T';
        public const char AGENCY_INDEX_ARBITRAGE = 'U';
        public const char ALL_OTHER_ORDERS_AS_AGENT_FOR_OTHER_MEMBER = 'W';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_MEMBER_COMPETING_MARKET_MAKER_NOT_AFFILIATED_WITH_THE_FIRM_CLEARING_THE_TRADE = 'X';
        public const char AGENCY_NON_ALGORITHMIC_PROGRAM_TRADE = 'Y';
        public const char SHORT_EXEMPT_TRANSACTION_FOR_NON_MEMBER_COMPETING_MARKET_MAKER = 'Z';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_MEMBER_FIRM_ORG = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_INDIVIDUAL_CUSTOMER = 'J';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_INDIVIDUAL_CUSTOMER = 'K';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_OTHER_MEMBER = 'N';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_OTHER_AGENCY = 'U';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_OTHER_AGENCY = 'Y';
        public const char SHORT_EXEMPT_TRANSACTION_REFER_TO_A_TYPE = 'B';
        public const char PROGRAM_ORDER_NON_INDEX_ARB_FOR_MEMBER_FIRM = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_MEMBER_FIRM = 'D';
        public const char SHORT_EXEMPT_TRANSACTION_REFER_TO_W_TYPE = 'F';
        public const char SHORT_EXEMPT_TRANSACTION_REFER_TO_I_TYPE = 'H';
        public const char INDIVIDUAL_INVESTOR = 'I';
        public const char SHORT_EXEMPT_AFFILIATED = 'L';
        public const char PROPRIETARY_AFFILIATED = 'O';
        public const char TRANSACTIONS_NON_MEMBER = 'R';
        public const char TRANSACTIONS_UNAFFILIATED_MEMBER = 'T';
        public const char SHORT_EXEMPT_NOT_AFFILIATED = 'X';
        public const char SHORT_EXEMPT_NONMEMBER = 'Z';
        public const char PROGRAM_ORDER_NONINDEX_ARB_FOR_MEMBER_FIRMORG = 'C';
        public const char PROGRAM_ORDER_INDEX_ARB_FOR_MEMBER_FIRMORG = 'D';
        public const char REGISTERED_EQUITY_MARKET_MAKER_TRADES = 'E';
        public const char PROGRAM_ORDER_NONINDEX_ARB_FOR_INDIVIDUAL_CUSTOMER = 'K';
        public const char PROGRAM_ORDER_NONINDEX_ARB_FOR_OTHER_MEMBER = 'N';
        public const char COMPETING_DEALER_TRADES_O = 'O';
        public const char COMPETING_DEALER_TRADES_R = 'R';
        public const char COMPETING_DEALER_TRADES_T = 'T';
        public const char PROGRAM_ORDER_NONINDEX_ARB_FOR_OTHER_AGENCY = 'Y';
    }


    /// <summary>
    /// SecurityID Field
    /// </summary>/
    public sealed class SecurityID : StringField
    {
        public const int TAG = 48;

        public SecurityID()
            :base(Tags.SecurityID) {}
        public SecurityID(string val)
            :base(Tags.SecurityID, val) {}

    }


    /// <summary>
    /// SenderCompID Field
    /// </summary>/
    public sealed class SenderCompID : StringField
    {
        public const int TAG = 49;

        public SenderCompID()
            :base(Tags.SenderCompID) {}
        public SenderCompID(string val)
            :base(Tags.SenderCompID, val) {}

    }


    /// <summary>
    /// SenderSubID Field
    /// </summary>/
    public sealed class SenderSubID : StringField
    {
        public const int TAG = 50;

        public SenderSubID()
            :base(Tags.SenderSubID) {}
        public SenderSubID(string val)
            :base(Tags.SenderSubID, val) {}

    }


    /// <summary>
    /// SendingTime Field
    /// </summary>/
    public sealed class SendingTime : DateTimeField
    {
        public const int TAG = 52;

        public SendingTime()
            :base(Tags.SendingTime) {}
        public SendingTime(DateTime val)
            :base(Tags.SendingTime, val) {}
        public SendingTime(DateTime val, bool showMilliseconds)
            :base(Tags.SendingTime, val, showMilliseconds) {}
		public SendingTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.SendingTime, val, precision) {}

    }


    /// <summary>
    /// Shares Field
    /// </summary>/
    public sealed class Shares : DecimalField
    {
        public const int TAG = 53;

        public Shares()
            :base(Tags.Shares) {}
        public Shares(Decimal val)
            :base(Tags.Shares, val) {}

    }


    /// <summary>
    /// Side Field
    /// </summary>/
    public sealed class Side : CharField
    {
        public const int TAG = 54;

        public Side()
            :base(Tags.Side) {}
        public Side(char val)
            :base(Tags.Side, val) {}


        // Field Enumerations
        public const char BUY = '1';
        public const char SELL = '2';
        public const char BUY_MINUS = '3';
        public const char SELL_PLUS = '4';
        public const char SELL_SHORT = '5';
        public const char SELL_SHORT_EXEMPT = '6';
        public const char UNDISCLOSED = '7';
        public const char CROSS = '8';
        public const char CROSS_SHORT = '9';
        public const char CROSS_SHORT_EXEMPT = 'A';
        public const char AS_DEFINED = 'B';
        public const char OPPOSITE = 'C';
        public const char SUBSCRIBE = 'D';
        public const char REDEEM = 'E';
        public const char LEND = 'F';
        public const char BORROW = 'G';
        public const char CROSS_SHORT_EXXMPT = 'A';
        public const char D = '7';
    }


    /// <summary>
    /// Symbol Field
    /// </summary>/
    public sealed class Symbol : StringField
    {
        public const int TAG = 55;

        public Symbol()
            :base(Tags.Symbol) {}
        public Symbol(string val)
            :base(Tags.Symbol, val) {}

    }


    /// <summary>
    /// TargetCompID Field
    /// </summary>/
    public sealed class TargetCompID : StringField
    {
        public const int TAG = 56;

        public TargetCompID()
            :base(Tags.TargetCompID) {}
        public TargetCompID(string val)
            :base(Tags.TargetCompID, val) {}

    }


    /// <summary>
    /// TargetSubID Field
    /// </summary>/
    public sealed class TargetSubID : StringField
    {
        public const int TAG = 57;

        public TargetSubID()
            :base(Tags.TargetSubID) {}
        public TargetSubID(string val)
            :base(Tags.TargetSubID, val) {}

    }


    /// <summary>
    /// Text Field
    /// </summary>/
    public sealed class Text : StringField
    {
        public const int TAG = 58;

        public Text()
            :base(Tags.Text) {}
        public Text(string val)
            :base(Tags.Text, val) {}

    }


    /// <summary>
    /// TimeInForce Field
    /// </summary>/
    public sealed class TimeInForce : CharField
    {
        public const int TAG = 59;

        public TimeInForce()
            :base(Tags.TimeInForce) {}
        public TimeInForce(char val)
            :base(Tags.TimeInForce, val) {}


        // Field Enumerations
        public const char DAY = '0';
        public const char GOOD_TILL_CANCEL = '1';
        public const char AT_THE_OPENING = '2';
        public const char IMMEDIATE_OR_CANCEL = '3';
        public const char FILL_OR_KILL = '4';
        public const char GOOD_TILL_CROSSING = '5';
        public const char GOOD_TILL_DATE = '6';
        public const char AT_THE_CLOSE = '7';
        public const char GOOD_THROUGH_CROSSING = '8';
        public const char AT_CROSSING = '9';
    }


    /// <summary>
    /// TransactTime Field
    /// </summary>/
    public sealed class TransactTime : DateTimeField
    {
        public const int TAG = 60;

        public TransactTime()
            :base(Tags.TransactTime) {}
        public TransactTime(DateTime val)
            :base(Tags.TransactTime, val) {}
        public TransactTime(DateTime val, bool showMilliseconds)
            :base(Tags.TransactTime, val, showMilliseconds) {}
		public TransactTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TransactTime, val, precision) {}

    }


    /// <summary>
    /// Urgency Field
    /// </summary>/
    public sealed class Urgency : CharField
    {
        public const int TAG = 61;

        public Urgency()
            :base(Tags.Urgency) {}
        public Urgency(char val)
            :base(Tags.Urgency, val) {}


        // Field Enumerations
        public const char NORMAL = '0';
        public const char FLASH = '1';
        public const char BACKGROUND = '2';
    }


    /// <summary>
    /// ValidUntilTime Field
    /// </summary>/
    public sealed class ValidUntilTime : DateTimeField
    {
        public const int TAG = 62;

        public ValidUntilTime()
            :base(Tags.ValidUntilTime) {}
        public ValidUntilTime(DateTime val)
            :base(Tags.ValidUntilTime, val) {}
        public ValidUntilTime(DateTime val, bool showMilliseconds)
            :base(Tags.ValidUntilTime, val, showMilliseconds) {}
		public ValidUntilTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.ValidUntilTime, val, precision) {}

    }


    /// <summary>
    /// SettlmntTyp Field
    /// </summary>/
    public sealed class SettlmntTyp : CharField
    {
        public const int TAG = 63;

        public SettlmntTyp()
            :base(Tags.SettlmntTyp) {}
        public SettlmntTyp(char val)
            :base(Tags.SettlmntTyp, val) {}


        // Field Enumerations
        public const char REGULAR = '0';
        public const char CASH = '1';
        public const char NEXT_DAY = '2';
        public const char T_PLUS_2 = '3';
        public const char T_PLUS_3 = '4';
        public const char T_PLUS_4 = '5';
        public const char FUTURE = '6';
        public const char WHEN_AND_IF_ISSUED = '7';
        public const char SELLERS_OPTION = '8';
        public const char T_PLUS_5 = '9';
        public const char T_PLUS_1 = 'A';
        public const char TPLUS2 = '3';
        public const char TPLUS3 = '4';
        public const char TPLUS4 = '5';
        public const char WHEN_ISSUED = '7';
        public const char TPLUS5 = '9';
    }


    /// <summary>
    /// FutSettDate Field
    /// </summary>/
    public sealed class FutSettDate : StringField
    {
        public const int TAG = 64;

        public FutSettDate()
            :base(Tags.FutSettDate) {}
        public FutSettDate(string val)
            :base(Tags.FutSettDate, val) {}

    }


    /// <summary>
    /// SymbolSfx Field
    /// </summary>/
    public sealed class SymbolSfx : StringField
    {
        public const int TAG = 65;

        public SymbolSfx()
            :base(Tags.SymbolSfx) {}
        public SymbolSfx(string val)
            :base(Tags.SymbolSfx, val) {}


        // Field Enumerations
        public const string EUCP_WITH_LUMP_SUM_INTEREST_RATHER_THAN_DISCOUNT_PRICE = "CD";
        public const string WHEN_ISSUED_FOR_A_SECURITY_TO_BE_REISSUED_UNDER_AN_OLD_CUSIP_OR_ISIN = "WI";
        public const string WHEN_ISSUED = "WI";
        public const string A_EUCP_WITH_LUMP_SUM_INTEREST = "CD";
    }


    /// <summary>
    /// ListID Field
    /// </summary>/
    public sealed class ListID : StringField
    {
        public const int TAG = 66;

        public ListID()
            :base(Tags.ListID) {}
        public ListID(string val)
            :base(Tags.ListID, val) {}

    }


    /// <summary>
    /// ListSeqNo Field
    /// </summary>/
    public sealed class ListSeqNo : IntField
    {
        public const int TAG = 67;

        public ListSeqNo()
            :base(Tags.ListSeqNo) {}
        public ListSeqNo(int val)
            :base(Tags.ListSeqNo, val) {}

    }


    /// <summary>
    /// ListNoOrds Field
    /// </summary>/
    public sealed class ListNoOrds : IntField
    {
        public const int TAG = 68;

        public ListNoOrds()
            :base(Tags.ListNoOrds) {}
        public ListNoOrds(int val)
            :base(Tags.ListNoOrds, val) {}

    }


    /// <summary>
    /// ListExecInst Field
    /// </summary>/
    public sealed class ListExecInst : StringField
    {
        public const int TAG = 69;

        public ListExecInst()
            :base(Tags.ListExecInst) {}
        public ListExecInst(string val)
            :base(Tags.ListExecInst, val) {}

    }


    /// <summary>
    /// AllocID Field
    /// </summary>/
    public sealed class AllocID : StringField
    {
        public const int TAG = 70;

        public AllocID()
            :base(Tags.AllocID) {}
        public AllocID(string val)
            :base(Tags.AllocID, val) {}

    }


    /// <summary>
    /// AllocTransType Field
    /// </summary>/
    public sealed class AllocTransType : CharField
    {
        public const int TAG = 71;

        public AllocTransType()
            :base(Tags.AllocTransType) {}
        public AllocTransType(char val)
            :base(Tags.AllocTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLACE = '1';
        public const char CANCEL = '2';
        public const char PRELIMINARY = '3';
        public const char CALCULATED = '4';
        public const char CALCULATED_WITHOUT_PRELIMINARY = '5';
        public const char REVERSAL = '6';
    }


    /// <summary>
    /// RefAllocID Field
    /// </summary>/
    public sealed class RefAllocID : StringField
    {
        public const int TAG = 72;

        public RefAllocID()
            :base(Tags.RefAllocID) {}
        public RefAllocID(string val)
            :base(Tags.RefAllocID, val) {}

    }


    /// <summary>
    /// NoOrders Field
    /// </summary>/
    public sealed class NoOrders : IntField
    {
        public const int TAG = 73;

        public NoOrders()
            :base(Tags.NoOrders) {}
        public NoOrders(int val)
            :base(Tags.NoOrders, val) {}

    }


    /// <summary>
    /// AvgPrxPrecision Field
    /// </summary>/
    public sealed class AvgPrxPrecision : IntField
    {
        public const int TAG = 74;

        public AvgPrxPrecision()
            :base(Tags.AvgPrxPrecision) {}
        public AvgPrxPrecision(int val)
            :base(Tags.AvgPrxPrecision, val) {}

    }


    /// <summary>
    /// TradeDate Field
    /// </summary>/
    public sealed class TradeDate : StringField
    {
        public const int TAG = 75;

        public TradeDate()
            :base(Tags.TradeDate) {}
        public TradeDate(string val)
            :base(Tags.TradeDate, val) {}

    }


    /// <summary>
    /// ExecBroker Field
    /// </summary>/
    public sealed class ExecBroker : StringField
    {
        public const int TAG = 76;

        public ExecBroker()
            :base(Tags.ExecBroker) {}
        public ExecBroker(string val)
            :base(Tags.ExecBroker, val) {}

    }


    /// <summary>
    /// OpenClose Field
    /// </summary>/
    public sealed class OpenClose : CharField
    {
        public const int TAG = 77;

        public OpenClose()
            :base(Tags.OpenClose) {}
        public OpenClose(char val)
            :base(Tags.OpenClose, val) {}


        // Field Enumerations
        public const char OPEN = 'O';
        public const char CLOSE = 'C';
    }


    /// <summary>
    /// NoAllocs Field
    /// </summary>/
    public sealed class NoAllocs : IntField
    {
        public const int TAG = 78;

        public NoAllocs()
            :base(Tags.NoAllocs) {}
        public NoAllocs(int val)
            :base(Tags.NoAllocs, val) {}

    }


    /// <summary>
    /// AllocAccount Field
    /// </summary>/
    public sealed class AllocAccount : StringField
    {
        public const int TAG = 79;

        public AllocAccount()
            :base(Tags.AllocAccount) {}
        public AllocAccount(string val)
            :base(Tags.AllocAccount, val) {}

    }


    /// <summary>
    /// AllocShares Field
    /// </summary>/
    public sealed class AllocShares : DecimalField
    {
        public const int TAG = 80;

        public AllocShares()
            :base(Tags.AllocShares) {}
        public AllocShares(Decimal val)
            :base(Tags.AllocShares, val) {}

    }


    /// <summary>
    /// ProcessCode Field
    /// </summary>/
    public sealed class ProcessCode : CharField
    {
        public const int TAG = 81;

        public ProcessCode()
            :base(Tags.ProcessCode) {}
        public ProcessCode(char val)
            :base(Tags.ProcessCode, val) {}


        // Field Enumerations
        public const char REGULAR = '0';
        public const char SOFT_DOLLAR = '1';
        public const char STEP_IN = '2';
        public const char STEP_OUT = '3';
        public const char SOFT_DOLLAR_STEP_IN = '4';
        public const char SOFT_DOLLAR_STEP_OUT = '5';
        public const char PLAN_SPONSOR = '6';
        public const char STEPIN = '2';
        public const char STEPOUT = '3';
        public const char SOFTDOLLAR_STEPIN = '4';
        public const char SOFTDOLLAR_STEPOUT = '5';
    }


    /// <summary>
    /// NoRpts Field
    /// </summary>/
    public sealed class NoRpts : IntField
    {
        public const int TAG = 82;

        public NoRpts()
            :base(Tags.NoRpts) {}
        public NoRpts(int val)
            :base(Tags.NoRpts, val) {}

    }


    /// <summary>
    /// RptSeq Field
    /// </summary>/
    public sealed class RptSeq : IntField
    {
        public const int TAG = 83;

        public RptSeq()
            :base(Tags.RptSeq) {}
        public RptSeq(int val)
            :base(Tags.RptSeq, val) {}

    }


    /// <summary>
    /// CxlQty Field
    /// </summary>/
    public sealed class CxlQty : DecimalField
    {
        public const int TAG = 84;

        public CxlQty()
            :base(Tags.CxlQty) {}
        public CxlQty(Decimal val)
            :base(Tags.CxlQty, val) {}

    }


    /// <summary>
    /// NoDlvyInst Field
    /// </summary>/
    public sealed class NoDlvyInst : IntField
    {
        public const int TAG = 85;

        public NoDlvyInst()
            :base(Tags.NoDlvyInst) {}
        public NoDlvyInst(int val)
            :base(Tags.NoDlvyInst, val) {}

    }


    /// <summary>
    /// DlvyInst Field
    /// </summary>/
    public sealed class DlvyInst : StringField
    {
        public const int TAG = 86;

        public DlvyInst()
            :base(Tags.DlvyInst) {}
        public DlvyInst(string val)
            :base(Tags.DlvyInst, val) {}

    }


    /// <summary>
    /// AllocStatus Field
    /// </summary>/
    public sealed class AllocStatus : IntField
    {
        public const int TAG = 87;

        public AllocStatus()
            :base(Tags.AllocStatus) {}
        public AllocStatus(int val)
            :base(Tags.AllocStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int BLOCK_LEVEL_REJECT = 1;
        public const int ACCOUNT_LEVEL_REJECT = 2;
        public const int RECEIVED = 3;
        public const int INCOMPLETE = 4;
        public const int REJECTED_BY_INTERMEDIARY = 5;
        public const int ALLOCATION_PENDING = 6;
        public const int REVERSED = 7;
        public const int REJECTED = 1;
        public const int PARTIAL_ACCEPT = 2;
    }


    /// <summary>
    /// AllocRejCode Field
    /// </summary>/
    public sealed class AllocRejCode : IntField
    {
        public const int TAG = 88;

        public AllocRejCode()
            :base(Tags.AllocRejCode) {}
        public AllocRejCode(int val)
            :base(Tags.AllocRejCode, val) {}


        // Field Enumerations
        public const int UNKNOWN_ACCOUNT = 0;
        public const int INCORRECT_QUANTITY = 1;
        public const int UNKNOWN_OR_STALE_EXECID = 10;
        public const int MISMATCHED_DATA = 11;
        public const int UNKNOWN_CLORDID = 12;
        public const int WAREHOUSE_REQUEST_REJECTED = 13;
        public const int INCORRECT_AVERAGEG_PRICE = 2;
        public const int UNKNOWN_EXECUTING_BROKER_MNEMONIC = 3;
        public const int COMMISSION_DIFFERENCE = 4;
        public const int UNKNOWN_ORDERID = 5;
        public const int UNKNOWN_LISTID = 6;
        public const int OTHER_7 = 7;
        public const int INCORRECT_ALLOCATED_QUANTITY = 8;
        public const int CALCULATION_DIFFERENCE = 9;
        public const int OTHER_99 = 99;
        public const int OTHER = 7;
        public const int INCORRECT_AVERAGE_PRICE = 2;
        public const int UNKNOWN_OR_STALE_EXEC_ID = 10;
        public const int MISMATCHED_DATA_VALUE = 11;
    }


    /// <summary>
    /// Signature Field
    /// </summary>/
    public sealed class Signature : StringField
    {
        public const int TAG = 89;

        public Signature()
            :base(Tags.Signature) {}
        public Signature(string val)
            :base(Tags.Signature, val) {}

    }


    /// <summary>
    /// SecureDataLen Field
    /// </summary>/
    public sealed class SecureDataLen : IntField
    {
        public const int TAG = 90;

        public SecureDataLen()
            :base(Tags.SecureDataLen) {}
        public SecureDataLen(int val)
            :base(Tags.SecureDataLen, val) {}

    }


    /// <summary>
    /// SecureData Field
    /// </summary>/
    public sealed class SecureData : StringField
    {
        public const int TAG = 91;

        public SecureData()
            :base(Tags.SecureData) {}
        public SecureData(string val)
            :base(Tags.SecureData, val) {}

    }


    /// <summary>
    /// BrokerOfCredit Field
    /// </summary>/
    public sealed class BrokerOfCredit : StringField
    {
        public const int TAG = 92;

        public BrokerOfCredit()
            :base(Tags.BrokerOfCredit) {}
        public BrokerOfCredit(string val)
            :base(Tags.BrokerOfCredit, val) {}

    }


    /// <summary>
    /// SignatureLength Field
    /// </summary>/
    public sealed class SignatureLength : IntField
    {
        public const int TAG = 93;

        public SignatureLength()
            :base(Tags.SignatureLength) {}
        public SignatureLength(int val)
            :base(Tags.SignatureLength, val) {}

    }


    /// <summary>
    /// EmailType Field
    /// </summary>/
    public sealed class EmailType : CharField
    {
        public const int TAG = 94;

        public EmailType()
            :base(Tags.EmailType) {}
        public EmailType(char val)
            :base(Tags.EmailType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLY = '1';
        public const char ADMIN_REPLY = '2';
    }


    /// <summary>
    /// RawDataLength Field
    /// </summary>/
    public sealed class RawDataLength : IntField
    {
        public const int TAG = 95;

        public RawDataLength()
            :base(Tags.RawDataLength) {}
        public RawDataLength(int val)
            :base(Tags.RawDataLength, val) {}

    }


    /// <summary>
    /// RawData Field
    /// </summary>/
    public sealed class RawData : StringField
    {
        public const int TAG = 96;

        public RawData()
            :base(Tags.RawData) {}
        public RawData(string val)
            :base(Tags.RawData, val) {}

    }


    /// <summary>
    /// PossResend Field
    /// </summary>/
    public sealed class PossResend : BooleanField
    {
        public const int TAG = 97;

        public PossResend()
            :base(Tags.PossResend) {}
        public PossResend(Boolean val)
            :base(Tags.PossResend, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// EncryptMethod Field
    /// </summary>/
    public sealed class EncryptMethod : IntField
    {
        public const int TAG = 98;

        public EncryptMethod()
            :base(Tags.EncryptMethod) {}
        public EncryptMethod(int val)
            :base(Tags.EncryptMethod, val) {}


        // Field Enumerations
        public const int NONE = 0;
        public const int PKCS_1 = 1;
        public const int DES = 2;
        public const int PKCS_3 = 3;
        public const int PGP_4 = 4;
        public const int PGP_5 = 5;
        public const int PEM = 6;
        public const int NONE_OTHER = 0;
        public const int PKCS = 1;
        public const int PKCS_DES = 3;
        public const int PGP_DES = 4;
        public const int PGP_DES_MD5 = 5;
        public const int PEM_DES_MD5 = 6;
        public const int PKCS_PROPRIETARY = 1;
        public const int PKCSDES = 3;
        public const int PGPDES = 4;
        public const int PGPDESMD5 = 5;
        public const int PEMDESMD5 = 6;
    }


    /// <summary>
    /// StopPx Field
    /// </summary>/
    public sealed class StopPx : DecimalField
    {
        public const int TAG = 99;

        public StopPx()
            :base(Tags.StopPx) {}
        public StopPx(Decimal val)
            :base(Tags.StopPx, val) {}

    }


    /// <summary>
    /// ExDestination Field
    /// </summary>/
    public sealed class ExDestination : StringField
    {
        public const int TAG = 100;

        public ExDestination()
            :base(Tags.ExDestination) {}
        public ExDestination(string val)
            :base(Tags.ExDestination, val) {}


        // Field Enumerations
        public const string NONE = "0";
        public const string POSIT = "4";
    }


    /// <summary>
    /// CxlRejReason Field
    /// </summary>/
    public sealed class CxlRejReason : IntField
    {
        public const int TAG = 102;

        public CxlRejReason()
            :base(Tags.CxlRejReason) {}
        public CxlRejReason(int val)
            :base(Tags.CxlRejReason, val) {}


        // Field Enumerations
        public const int TOO_LATE_TO_CANCEL = 0;
        public const int UNKNOWN_ORDER = 1;
        public const int BROKER = 2;
        public const int ORDER_ALREADY_IN_PENDING_CANCEL_OR_PENDING_REPLACE_STATUS = 3;
        public const int UNABLE_TO_PROCESS_ORDER_MASS_CANCEL_REQUEST = 4;
        public const int ORIGORDMODTIME = 5;
        public const int DUPLICATE_CLORDID = 6;
        public const int OTHER = 99;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int PRICE_EXCEEDS_CURRENT_PRICE = 7;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND = 8;
        public const int BROKER_EXCHANGE_OPTION = 2;
        public const int ORIGORDMODTIME_DID_NOT_MATCH_LAST_TRANSACTTIME_OF_ORDER = 5;
        public const int DUPLICATE_CLORDID_RECEIVED = 6;
        public const int ALREADY_PENDING = 3;
        public const int BROKER_OPTION = 2;
    }


    /// <summary>
    /// OrdRejReason Field
    /// </summary>/
    public sealed class OrdRejReason : IntField
    {
        public const int TAG = 103;

        public OrdRejReason()
            :base(Tags.OrdRejReason) {}
        public OrdRejReason(int val)
            :base(Tags.OrdRejReason, val) {}


        // Field Enumerations
        public const int BROKER = 0;
        public const int UNKNOWN_SYMBOL = 1;
        public const int INVALID_INVESTOR_ID = 10;
        public const int UNSUPPORTED_ORDER_CHARACTERISTIC = 11;
        public const int SURVEILLENCE_OPTION = 12;
        public const int INCORRECT_QUANTITY = 13;
        public const int INCORRECT_ALLOCATED_QUANTITY = 14;
        public const int UNKNOWN_ACCOUNT = 15;
        public const int EXCHANGE_CLOSED = 2;
        public const int ORDER_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_ORDER = 5;
        public const int DUPLICATE_ORDER = 6;
        public const int DUPLICATE_OF_A_VERBALLY_COMMUNICATED_ORDER = 7;
        public const int STALE_ORDER = 8;
        public const int TRADE_ALONG_REQUIRED = 9;
        public const int OTHER = 99;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND = 16;
        public const int BROKER_EXCHANGE_OPTION = 0;
        public const int BROKER_OPTION = 0;
        public const int DUPLICATE_VERBAL = 7;
        public const int DUPLICATE_VERBALYES = 7;
    }


    /// <summary>
    /// IOIQualifier Field
    /// </summary>/
    public sealed class IOIQualifier : CharField
    {
        public const int TAG = 104;

        public IOIQualifier()
            :base(Tags.IOIQualifier) {}
        public IOIQualifier(char val)
            :base(Tags.IOIQualifier, val) {}


        // Field Enumerations
        public const char ALL_OR_NONE = 'A';
        public const char MARKET_ON_CLOSE = 'B';
        public const char AT_THE_CLOSE = 'C';
        public const char VWAP = 'D';
        public const char IN_TOUCH_WITH = 'I';
        public const char LIMIT = 'L';
        public const char MORE_BEHIND = 'M';
        public const char AT_THE_OPEN = 'O';
        public const char TAKING_A_POSITION = 'P';
        public const char AT_THE_MARKET = 'Q';
        public const char READY_TO_TRADE = 'R';
        public const char PORTFOLIO_SHOWN = 'S';
        public const char THROUGH_THE_DAY = 'T';
        public const char VERSUS = 'V';
        public const char INDICATION = 'W';
        public const char CROSSING_OPPORTUNITY = 'X';
        public const char AT_THE_MIDPOINT = 'Y';
        public const char PRE_OPEN = 'Z';
        public const char INDIDCATION = 'W';
        public const char INDICATION_WORKING_AWAY = 'W';
        public const char PREOPEN = 'Z';
        public const char CURRENT_QUOTE = 'Q';
    }


    /// <summary>
    /// WaveNo Field
    /// </summary>/
    public sealed class WaveNo : StringField
    {
        public const int TAG = 105;

        public WaveNo()
            :base(Tags.WaveNo) {}
        public WaveNo(string val)
            :base(Tags.WaveNo, val) {}

    }


    /// <summary>
    /// Issuer Field
    /// </summary>/
    public sealed class Issuer : StringField
    {
        public const int TAG = 106;

        public Issuer()
            :base(Tags.Issuer) {}
        public Issuer(string val)
            :base(Tags.Issuer, val) {}

    }


    /// <summary>
    /// SecurityDesc Field
    /// </summary>/
    public sealed class SecurityDesc : StringField
    {
        public const int TAG = 107;

        public SecurityDesc()
            :base(Tags.SecurityDesc) {}
        public SecurityDesc(string val)
            :base(Tags.SecurityDesc, val) {}

    }


    /// <summary>
    /// HeartBtInt Field
    /// </summary>/
    public sealed class HeartBtInt : IntField
    {
        public const int TAG = 108;

        public HeartBtInt()
            :base(Tags.HeartBtInt) {}
        public HeartBtInt(int val)
            :base(Tags.HeartBtInt, val) {}

    }


    /// <summary>
    /// ClientID Field
    /// </summary>/
    public sealed class ClientID : StringField
    {
        public const int TAG = 109;

        public ClientID()
            :base(Tags.ClientID) {}
        public ClientID(string val)
            :base(Tags.ClientID, val) {}

    }


    /// <summary>
    /// MinQty Field
    /// </summary>/
    public sealed class MinQty : DecimalField
    {
        public const int TAG = 110;

        public MinQty()
            :base(Tags.MinQty) {}
        public MinQty(Decimal val)
            :base(Tags.MinQty, val) {}

    }


    /// <summary>
    /// MaxFloor Field
    /// </summary>/
    public sealed class MaxFloor : DecimalField
    {
        public const int TAG = 111;

        public MaxFloor()
            :base(Tags.MaxFloor) {}
        public MaxFloor(Decimal val)
            :base(Tags.MaxFloor, val) {}

    }


    /// <summary>
    /// TestReqID Field
    /// </summary>/
    public sealed class TestReqID : StringField
    {
        public const int TAG = 112;

        public TestReqID()
            :base(Tags.TestReqID) {}
        public TestReqID(string val)
            :base(Tags.TestReqID, val) {}

    }


    /// <summary>
    /// ReportToExch Field
    /// </summary>/
    public sealed class ReportToExch : BooleanField
    {
        public const int TAG = 113;

        public ReportToExch()
            :base(Tags.ReportToExch) {}
        public ReportToExch(Boolean val)
            :base(Tags.ReportToExch, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// LocateReqd Field
    /// </summary>/
    public sealed class LocateReqd : BooleanField
    {
        public const int TAG = 114;

        public LocateReqd()
            :base(Tags.LocateReqd) {}
        public LocateReqd(Boolean val)
            :base(Tags.LocateReqd, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// OnBehalfOfCompID Field
    /// </summary>/
    public sealed class OnBehalfOfCompID : StringField
    {
        public const int TAG = 115;

        public OnBehalfOfCompID()
            :base(Tags.OnBehalfOfCompID) {}
        public OnBehalfOfCompID(string val)
            :base(Tags.OnBehalfOfCompID, val) {}

    }


    /// <summary>
    /// OnBehalfOfSubID Field
    /// </summary>/
    public sealed class OnBehalfOfSubID : StringField
    {
        public const int TAG = 116;

        public OnBehalfOfSubID()
            :base(Tags.OnBehalfOfSubID) {}
        public OnBehalfOfSubID(string val)
            :base(Tags.OnBehalfOfSubID, val) {}

    }


    /// <summary>
    /// QuoteID Field
    /// </summary>/
    public sealed class QuoteID : StringField
    {
        public const int TAG = 117;

        public QuoteID()
            :base(Tags.QuoteID) {}
        public QuoteID(string val)
            :base(Tags.QuoteID, val) {}

    }


    /// <summary>
    /// NetMoney Field
    /// </summary>/
    public sealed class NetMoney : DecimalField
    {
        public const int TAG = 118;

        public NetMoney()
            :base(Tags.NetMoney) {}
        public NetMoney(Decimal val)
            :base(Tags.NetMoney, val) {}

    }


    /// <summary>
    /// SettlCurrAmt Field
    /// </summary>/
    public sealed class SettlCurrAmt : DecimalField
    {
        public const int TAG = 119;

        public SettlCurrAmt()
            :base(Tags.SettlCurrAmt) {}
        public SettlCurrAmt(Decimal val)
            :base(Tags.SettlCurrAmt, val) {}

    }


    /// <summary>
    /// SettlCurrency Field
    /// </summary>/
    public sealed class SettlCurrency : StringField
    {
        public const int TAG = 120;

        public SettlCurrency()
            :base(Tags.SettlCurrency) {}
        public SettlCurrency(string val)
            :base(Tags.SettlCurrency, val) {}

    }


    /// <summary>
    /// ForexReq Field
    /// </summary>/
    public sealed class ForexReq : BooleanField
    {
        public const int TAG = 121;

        public ForexReq()
            :base(Tags.ForexReq) {}
        public ForexReq(Boolean val)
            :base(Tags.ForexReq, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// OrigSendingTime Field
    /// </summary>/
    public sealed class OrigSendingTime : DateTimeField
    {
        public const int TAG = 122;

        public OrigSendingTime()
            :base(Tags.OrigSendingTime) {}
        public OrigSendingTime(DateTime val)
            :base(Tags.OrigSendingTime, val) {}
        public OrigSendingTime(DateTime val, bool showMilliseconds)
            :base(Tags.OrigSendingTime, val, showMilliseconds) {}
		public OrigSendingTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.OrigSendingTime, val, precision) {}

    }


    /// <summary>
    /// GapFillFlag Field
    /// </summary>/
    public sealed class GapFillFlag : BooleanField
    {
        public const int TAG = 123;

        public GapFillFlag()
            :base(Tags.GapFillFlag) {}
        public GapFillFlag(Boolean val)
            :base(Tags.GapFillFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean GAP_FILL_MESSAGE_MSGSEQNUM_FIELD_VALID = true;
        public const Boolean SEQUENCE_RESET_IGNORE_MSGSEQNUM = false;
    }


    /// <summary>
    /// NoExecs Field
    /// </summary>/
    public sealed class NoExecs : IntField
    {
        public const int TAG = 124;

        public NoExecs()
            :base(Tags.NoExecs) {}
        public NoExecs(int val)
            :base(Tags.NoExecs, val) {}

    }


    /// <summary>
    /// CxlType Field
    /// </summary>/
    public sealed class CxlType : CharField
    {
        public const int TAG = 125;

        public CxlType()
            :base(Tags.CxlType) {}
        public CxlType(char val)
            :base(Tags.CxlType, val) {}


        // Field Enumerations
        public const char PARTIAL_CANCEL = 'P';
        public const char FULL_REMAINING_QUANTITY = 'F';
    }


    /// <summary>
    /// ExpireTime Field
    /// </summary>/
    public sealed class ExpireTime : DateTimeField
    {
        public const int TAG = 126;

        public ExpireTime()
            :base(Tags.ExpireTime) {}
        public ExpireTime(DateTime val)
            :base(Tags.ExpireTime, val) {}
        public ExpireTime(DateTime val, bool showMilliseconds)
            :base(Tags.ExpireTime, val, showMilliseconds) {}
		public ExpireTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.ExpireTime, val, precision) {}

    }


    /// <summary>
    /// DKReason Field
    /// </summary>/
    public sealed class DKReason : CharField
    {
        public const int TAG = 127;

        public DKReason()
            :base(Tags.DKReason) {}
        public DKReason(char val)
            :base(Tags.DKReason, val) {}


        // Field Enumerations
        public const char UNKNOWN_SYMBOL = 'A';
        public const char WRONG_SIDE = 'B';
        public const char QUANTITY_EXCEEDS_ORDER = 'C';
        public const char NO_MATCHING_ORDER = 'D';
        public const char PRICE_EXCEEDS_LIMIT = 'E';
        public const char CALCULATION_DIFFERENCE = 'F';
        public const char OTHER = 'Z';
    }


    /// <summary>
    /// DeliverToCompID Field
    /// </summary>/
    public sealed class DeliverToCompID : StringField
    {
        public const int TAG = 128;

        public DeliverToCompID()
            :base(Tags.DeliverToCompID) {}
        public DeliverToCompID(string val)
            :base(Tags.DeliverToCompID, val) {}

    }


    /// <summary>
    /// DeliverToSubID Field
    /// </summary>/
    public sealed class DeliverToSubID : StringField
    {
        public const int TAG = 129;

        public DeliverToSubID()
            :base(Tags.DeliverToSubID) {}
        public DeliverToSubID(string val)
            :base(Tags.DeliverToSubID, val) {}

    }


    /// <summary>
    /// IOINaturalFlag Field
    /// </summary>/
    public sealed class IOINaturalFlag : BooleanField
    {
        public const int TAG = 130;

        public IOINaturalFlag()
            :base(Tags.IOINaturalFlag) {}
        public IOINaturalFlag(Boolean val)
            :base(Tags.IOINaturalFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean NATURAL = true;
        public const Boolean NOT_NATURAL = false;
    }


    /// <summary>
    /// QuoteReqID Field
    /// </summary>/
    public sealed class QuoteReqID : StringField
    {
        public const int TAG = 131;

        public QuoteReqID()
            :base(Tags.QuoteReqID) {}
        public QuoteReqID(string val)
            :base(Tags.QuoteReqID, val) {}

    }


    /// <summary>
    /// BidPx Field
    /// </summary>/
    public sealed class BidPx : DecimalField
    {
        public const int TAG = 132;

        public BidPx()
            :base(Tags.BidPx) {}
        public BidPx(Decimal val)
            :base(Tags.BidPx, val) {}

    }


    /// <summary>
    /// OfferPx Field
    /// </summary>/
    public sealed class OfferPx : DecimalField
    {
        public const int TAG = 133;

        public OfferPx()
            :base(Tags.OfferPx) {}
        public OfferPx(Decimal val)
            :base(Tags.OfferPx, val) {}

    }


    /// <summary>
    /// BidSize Field
    /// </summary>/
    public sealed class BidSize : DecimalField
    {
        public const int TAG = 134;

        public BidSize()
            :base(Tags.BidSize) {}
        public BidSize(Decimal val)
            :base(Tags.BidSize, val) {}

    }


    /// <summary>
    /// OfferSize Field
    /// </summary>/
    public sealed class OfferSize : DecimalField
    {
        public const int TAG = 135;

        public OfferSize()
            :base(Tags.OfferSize) {}
        public OfferSize(Decimal val)
            :base(Tags.OfferSize, val) {}

    }


    /// <summary>
    /// NoMiscFees Field
    /// </summary>/
    public sealed class NoMiscFees : IntField
    {
        public const int TAG = 136;

        public NoMiscFees()
            :base(Tags.NoMiscFees) {}
        public NoMiscFees(int val)
            :base(Tags.NoMiscFees, val) {}

    }


    /// <summary>
    /// MiscFeeAmt Field
    /// </summary>/
    public sealed class MiscFeeAmt : DecimalField
    {
        public const int TAG = 137;

        public MiscFeeAmt()
            :base(Tags.MiscFeeAmt) {}
        public MiscFeeAmt(Decimal val)
            :base(Tags.MiscFeeAmt, val) {}

    }


    /// <summary>
    /// MiscFeeCurr Field
    /// </summary>/
    public sealed class MiscFeeCurr : StringField
    {
        public const int TAG = 138;

        public MiscFeeCurr()
            :base(Tags.MiscFeeCurr) {}
        public MiscFeeCurr(string val)
            :base(Tags.MiscFeeCurr, val) {}

    }


    /// <summary>
    /// MiscFeeType Field
    /// </summary>/
    public sealed class MiscFeeType : StringField
    {
        public const int TAG = 139;

        public MiscFeeType()
            :base(Tags.MiscFeeType) {}
        public MiscFeeType(string val)
            :base(Tags.MiscFeeType, val) {}


        // Field Enumerations
        public const string REGULATORY = "1";
        public const string PER_TRANSACTION = "10";
        public const string CONVERSION = "11";
        public const string AGENT = "12";
        public const string TAX = "2";
        public const string LOCAL_COMMISSION = "3";
        public const string EXCHANGE_FEES = "4";
        public const string STAMP = "5";
        public const string LEVY = "6";
        public const string OTHER = "7";
        public const string MARKUP = "8";
        public const string CONSUMPTION_TAX = "9";
        public const string TRANSFER_FEE = "13";
        public const string SECURITY_LENDING = "14";
    }


    /// <summary>
    /// PrevClosePx Field
    /// </summary>/
    public sealed class PrevClosePx : DecimalField
    {
        public const int TAG = 140;

        public PrevClosePx()
            :base(Tags.PrevClosePx) {}
        public PrevClosePx(Decimal val)
            :base(Tags.PrevClosePx, val) {}

    }


    /// <summary>
    /// ResetSeqNumFlag Field
    /// </summary>/
    public sealed class ResetSeqNumFlag : BooleanField
    {
        public const int TAG = 141;

        public ResetSeqNumFlag()
            :base(Tags.ResetSeqNumFlag) {}
        public ResetSeqNumFlag(Boolean val)
            :base(Tags.ResetSeqNumFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean YES_RESET_SEQUENCE_NUMBERS = true;
    }


    /// <summary>
    /// SenderLocationID Field
    /// </summary>/
    public sealed class SenderLocationID : StringField
    {
        public const int TAG = 142;

        public SenderLocationID()
            :base(Tags.SenderLocationID) {}
        public SenderLocationID(string val)
            :base(Tags.SenderLocationID, val) {}

    }


    /// <summary>
    /// TargetLocationID Field
    /// </summary>/
    public sealed class TargetLocationID : StringField
    {
        public const int TAG = 143;

        public TargetLocationID()
            :base(Tags.TargetLocationID) {}
        public TargetLocationID(string val)
            :base(Tags.TargetLocationID, val) {}

    }


    /// <summary>
    /// OnBehalfOfLocationID Field
    /// </summary>/
    public sealed class OnBehalfOfLocationID : StringField
    {
        public const int TAG = 144;

        public OnBehalfOfLocationID()
            :base(Tags.OnBehalfOfLocationID) {}
        public OnBehalfOfLocationID(string val)
            :base(Tags.OnBehalfOfLocationID, val) {}

    }


    /// <summary>
    /// DeliverToLocationID Field
    /// </summary>/
    public sealed class DeliverToLocationID : StringField
    {
        public const int TAG = 145;

        public DeliverToLocationID()
            :base(Tags.DeliverToLocationID) {}
        public DeliverToLocationID(string val)
            :base(Tags.DeliverToLocationID, val) {}

    }


    /// <summary>
    /// NoRelatedSym Field
    /// </summary>/
    public sealed class NoRelatedSym : IntField
    {
        public const int TAG = 146;

        public NoRelatedSym()
            :base(Tags.NoRelatedSym) {}
        public NoRelatedSym(int val)
            :base(Tags.NoRelatedSym, val) {}

    }


    /// <summary>
    /// Subject Field
    /// </summary>/
    public sealed class Subject : StringField
    {
        public const int TAG = 147;

        public Subject()
            :base(Tags.Subject) {}
        public Subject(string val)
            :base(Tags.Subject, val) {}

    }


    /// <summary>
    /// Headline Field
    /// </summary>/
    public sealed class Headline : StringField
    {
        public const int TAG = 148;

        public Headline()
            :base(Tags.Headline) {}
        public Headline(string val)
            :base(Tags.Headline, val) {}

    }


    /// <summary>
    /// URLLink Field
    /// </summary>/
    public sealed class URLLink : StringField
    {
        public const int TAG = 149;

        public URLLink()
            :base(Tags.URLLink) {}
        public URLLink(string val)
            :base(Tags.URLLink, val) {}

    }


    /// <summary>
    /// ExecType Field
    /// </summary>/
    public sealed class ExecType : CharField
    {
        public const int TAG = 150;

        public ExecType()
            :base(Tags.ExecType) {}
        public ExecType(char val)
            :base(Tags.ExecType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char DONE_FOR_DAY = '3';
        public const char CANCELED = '4';
        public const char REPLACED = '5';
        public const char PENDING_CANCEL = '6';
        public const char STOPPED = '7';
        public const char REJECTED = '8';
        public const char SUSPENDED = '9';
        public const char PENDING_NEW = 'A';
        public const char CALCULATED = 'B';
        public const char EXPIRED = 'C';
        public const char RESTATED = 'D';
        public const char PENDING_REPLACE = 'E';
        public const char TRADE = 'F';
        public const char TRADE_CORRECT = 'G';
        public const char TRADE_CANCEL = 'H';
        public const char ORDER_STATUS = 'I';
        public const char TRADE_IN_A_CLEARING_HOLD = 'J';
        public const char TRADE_HAS_BEEN_RELEASED_TO_CLEARING = 'K';
        public const char TRIGGERED_OR_ACTIVATED_BY_SYSTEM = 'L';
        public const char PARTIAL_FILL = '1';
        public const char FILL = '2';
        public const char REPLACE = '5';
        public const char CANCELLED = '4';
        public const char PENDING_CANCELREPLACE = '6';
    }


    /// <summary>
    /// LeavesQty Field
    /// </summary>/
    public sealed class LeavesQty : DecimalField
    {
        public const int TAG = 151;

        public LeavesQty()
            :base(Tags.LeavesQty) {}
        public LeavesQty(Decimal val)
            :base(Tags.LeavesQty, val) {}

    }


    /// <summary>
    /// CashOrderQty Field
    /// </summary>/
    public sealed class CashOrderQty : DecimalField
    {
        public const int TAG = 152;

        public CashOrderQty()
            :base(Tags.CashOrderQty) {}
        public CashOrderQty(Decimal val)
            :base(Tags.CashOrderQty, val) {}

    }


    /// <summary>
    /// AllocAvgPx Field
    /// </summary>/
    public sealed class AllocAvgPx : DecimalField
    {
        public const int TAG = 153;

        public AllocAvgPx()
            :base(Tags.AllocAvgPx) {}
        public AllocAvgPx(Decimal val)
            :base(Tags.AllocAvgPx, val) {}

    }


    /// <summary>
    /// AllocNetMoney Field
    /// </summary>/
    public sealed class AllocNetMoney : DecimalField
    {
        public const int TAG = 154;

        public AllocNetMoney()
            :base(Tags.AllocNetMoney) {}
        public AllocNetMoney(Decimal val)
            :base(Tags.AllocNetMoney, val) {}

    }


    /// <summary>
    /// SettlCurrFxRate Field
    /// </summary>/
    public sealed class SettlCurrFxRate : DecimalField
    {
        public const int TAG = 155;

        public SettlCurrFxRate()
            :base(Tags.SettlCurrFxRate) {}
        public SettlCurrFxRate(Decimal val)
            :base(Tags.SettlCurrFxRate, val) {}

    }


    /// <summary>
    /// SettlCurrFxRateCalc Field
    /// </summary>/
    public sealed class SettlCurrFxRateCalc : CharField
    {
        public const int TAG = 156;

        public SettlCurrFxRateCalc()
            :base(Tags.SettlCurrFxRateCalc) {}
        public SettlCurrFxRateCalc(char val)
            :base(Tags.SettlCurrFxRateCalc, val) {}


        // Field Enumerations
        public const char MULTIPLY = 'M';
        public const char DIVIDE = 'D';
    }


    /// <summary>
    /// NumDaysInterest Field
    /// </summary>/
    public sealed class NumDaysInterest : IntField
    {
        public const int TAG = 157;

        public NumDaysInterest()
            :base(Tags.NumDaysInterest) {}
        public NumDaysInterest(int val)
            :base(Tags.NumDaysInterest, val) {}

    }


    /// <summary>
    /// AccruedInterestRate Field
    /// </summary>/
    public sealed class AccruedInterestRate : DecimalField
    {
        public const int TAG = 158;

        public AccruedInterestRate()
            :base(Tags.AccruedInterestRate) {}
        public AccruedInterestRate(Decimal val)
            :base(Tags.AccruedInterestRate, val) {}

    }


    /// <summary>
    /// AccruedInterestAmt Field
    /// </summary>/
    public sealed class AccruedInterestAmt : DecimalField
    {
        public const int TAG = 159;

        public AccruedInterestAmt()
            :base(Tags.AccruedInterestAmt) {}
        public AccruedInterestAmt(Decimal val)
            :base(Tags.AccruedInterestAmt, val) {}

    }


    /// <summary>
    /// SettlInstMode Field
    /// </summary>/
    public sealed class SettlInstMode : CharField
    {
        public const int TAG = 160;

        public SettlInstMode()
            :base(Tags.SettlInstMode) {}
        public SettlInstMode(char val)
            :base(Tags.SettlInstMode, val) {}


        // Field Enumerations
        public const char DEFAULT = '0';
        public const char STANDING_INSTRUCTIONS_PROVIDED = '1';
        public const char SPECIFIC_ALLOCATION_ACCOUNT_OVERRIDING = '2';
        public const char SPECIFIC_ALLOCATION_ACCOUNT_STANDING = '3';
        public const char SPECIFIC_ORDER_FOR_A_SINGLE_ACCOUNT = '4';
        public const char REQUEST_REJECT = '5';
    }


    /// <summary>
    /// AllocText Field
    /// </summary>/
    public sealed class AllocText : StringField
    {
        public const int TAG = 161;

        public AllocText()
            :base(Tags.AllocText) {}
        public AllocText(string val)
            :base(Tags.AllocText, val) {}

    }


    /// <summary>
    /// SettlInstID Field
    /// </summary>/
    public sealed class SettlInstID : StringField
    {
        public const int TAG = 162;

        public SettlInstID()
            :base(Tags.SettlInstID) {}
        public SettlInstID(string val)
            :base(Tags.SettlInstID, val) {}

    }


    /// <summary>
    /// SettlInstTransType Field
    /// </summary>/
    public sealed class SettlInstTransType : CharField
    {
        public const int TAG = 163;

        public SettlInstTransType()
            :base(Tags.SettlInstTransType) {}
        public SettlInstTransType(char val)
            :base(Tags.SettlInstTransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NEW = 'N';
        public const char REPLACE = 'R';
        public const char RESTATE = 'T';
    }


    /// <summary>
    /// EmailThreadID Field
    /// </summary>/
    public sealed class EmailThreadID : StringField
    {
        public const int TAG = 164;

        public EmailThreadID()
            :base(Tags.EmailThreadID) {}
        public EmailThreadID(string val)
            :base(Tags.EmailThreadID, val) {}

    }


    /// <summary>
    /// SettlInstSource Field
    /// </summary>/
    public sealed class SettlInstSource : CharField
    {
        public const int TAG = 165;

        public SettlInstSource()
            :base(Tags.SettlInstSource) {}
        public SettlInstSource(char val)
            :base(Tags.SettlInstSource, val) {}


        // Field Enumerations
        public const char BROKERS_INSTRUCTIONS = '1';
        public const char INSTITUTIONS_INSTRUCTIONS = '2';
        public const char INVESTOR = '3';
        public const char BROKER = '1';
        public const char INSTITUTION = '2';
    }


    /// <summary>
    /// SettlLocation Field
    /// </summary>/
    public sealed class SettlLocation : StringField
    {
        public const int TAG = 166;

        public SettlLocation()
            :base(Tags.SettlLocation) {}
        public SettlLocation(string val)
            :base(Tags.SettlLocation, val) {}


        // Field Enumerations
        public const string CEDEL = "CED";
        public const string DEPOSITORY_TRUST_COMPANY = "DTC";
        public const string EURO_CLEAR = "EUR";
        public const string FEDERAL_BOOK_ENTRY = "FED";
        public const string LOCAL_MARKET_SETTLE_LOCATION = "ISO_Country_Code";
        public const string PHYSICAL = "PNY";
        public const string PARTICIPANT_TRUST_COMPANY = "PTC";
        public const string EUROCLEAR = "EUR";
        public const string PARTICIPANT_TRUST_COMPANY_ISO_COUNTRY = "PTC";
    }


    /// <summary>
    /// SecurityType Field
    /// </summary>/
    public sealed class SecurityType : StringField
    {
        public const int TAG = 167;

        public SecurityType()
            :base(Tags.SecurityType) {}
        public SecurityType(string val)
            :base(Tags.SecurityType, val) {}


        // Field Enumerations
        public const string ASSET_BACKED_SECURITIES = "ABS";
        public const string AMENDED_RESTATED = "AMENDED";
        public const string OTHER_ANTICIPATION_NOTES = "AN";
        public const string BANKERS_ACCEPTANCE = "BA";
        public const string BANK_NOTES = "BN";
        public const string BILL_OF_EXCHANGES = "BOX";
        public const string BRADY_BOND = "BRADY";
        public const string BRIDGE_LOAN = "BRIDGE";
        public const string BUY_SELLBACK = "BUYSELL";
        public const string CONVERTIBLE_BOND = "CB";
        public const string CERTIFICATE_OF_DEPOSIT = "CD";
        public const string CALL_LOANS = "CL";
        public const string CORP_MORTGAGE_BACKED_SECURITIES = "CMBS";
        public const string COLLATERALIZED_MORTGAGE_OBLIGATION = "CMO";
        public const string CERTIFICATE_OF_OBLIGATION = "COFO";
        public const string CERTIFICATE_OF_PARTICIPATION = "COFP";
        public const string CORPORATE_BOND = "CORP";
        public const string COMMERCIAL_PAPER = "CP";
        public const string CORPORATE_PRIVATE_PLACEMENT = "CPP";
        public const string COMMON_STOCK = "CS";
        public const string DEFAULTED = "DEFLTED";
        public const string DEBTOR_IN_POSSESSION = "DINP";
        public const string DEPOSIT_NOTES = "DN";
        public const string DUAL_CURRENCY = "DUAL";
        public const string EURO_CERTIFICATE_OF_DEPOSIT = "EUCD";
        public const string EURO_CORPORATE_BOND = "EUCORP";
        public const string EURO_COMMERCIAL_PAPER = "EUCP";
        public const string EURO_SOVEREIGNS = "EUSOV";
        public const string EURO_SUPRANATIONAL_COUPONS = "EUSUPRA";
        public const string FEDERAL_AGENCY_COUPON = "FAC";
        public const string FEDERAL_AGENCY_DISCOUNT_NOTE = "FADN";
        public const string FOREIGN_EXCHANGE_CONTRACT = "FOR";
        public const string FORWARD = "FORWARD";
        public const string FUTURE = "FUT";
        public const string GENERAL_OBLIGATION_BONDS = "GO";
        public const string IOETTE_MORTGAGE = "IET";
        public const string LETTER_OF_CREDIT = "LOFC";
        public const string LIQUIDITY_NOTE = "LQN";
        public const string MATURED = "MATURED";
        public const string MORTGAGE_BACKED_SECURITIES = "MBS";
        public const string MUTUAL_FUND = "MF";
        public const string MORTGAGE_INTEREST_ONLY = "MIO";
        public const string MULTILEG_INSTRUMENT = "MLEG";
        public const string MORTGAGE_PRINCIPAL_ONLY = "MPO";
        public const string MORTGAGE_PRIVATE_PLACEMENT = "MPP";
        public const string MISCELLANEOUS_PASS_THROUGH = "MPT";
        public const string MANDATORY_TENDER = "MT";
        public const string MEDIUM_TERM_NOTES = "MTN";
        public const string NO_SECURITY_TYPE = "NONE";
        public const string OVERNIGHT = "ONITE";
        public const string OPTION = "OPT";
        public const string PRIVATE_EXPORT_FUNDING = "PEF";
        public const string PFANDBRIEFE = "PFAND";
        public const string PROMISSORY_NOTE = "PN";
        public const string PREFERRED_STOCK = "PS";
        public const string PLAZOS_FIJOS = "PZFJ";
        public const string REVENUE_ANTICIPATION_NOTE = "RAN";
        public const string REPLACED = "REPLACD";
        public const string REPURCHASE = "REPO";
        public const string RETIRED = "RETIRED";
        public const string REVENUE_BONDS = "REV";
        public const string REVOLVER_LOAN = "RVLV";
        public const string REVOLVER_TERM_LOAN = "RVLVTRM";
        public const string SECURITIES_LOAN = "SECLOAN";
        public const string SECURITIES_PLEDGE = "SECPLEDGE";
        public const string SPECIAL_ASSESSMENT = "SPCLA";
        public const string SPECIAL_OBLIGATION = "SPCLO";
        public const string SPECIAL_TAX = "SPCLT";
        public const string SHORT_TERM_LOAN_NOTE = "STN";
        public const string STRUCTURED_NOTES = "STRUCT";
        public const string USD_SUPRANATIONAL_COUPONS = "SUPRA";
        public const string SWING_LINE_FACILITY = "SWING";
        public const string TAX_ANTICIPATION_NOTE = "TAN";
        public const string TAX_ALLOCATION = "TAXA";
        public const string TO_BE_ANNOUNCED = "TBA";
        public const string US_TREASURY_BILL_TBILL = "TBILL";
        public const string US_TREASURY_BOND = "TBOND";
        public const string PRINCIPAL_STRIP_OF_A_CALLABLE_BOND_OR_NOTE = "TCAL";
        public const string TIME_DEPOSIT = "TD";
        public const string TAX_EXEMPT_COMMERCIAL_PAPER = "TECP";
        public const string TERM_LOAN = "TERM";
        public const string INTEREST_STRIP_FROM_ANY_BOND_OR_NOTE = "TINT";
        public const string TREASURY_INFLATION_PROTECTED_SECURITIES = "TIPS";
        public const string US_TREASURY_NOTE_TNOTE = "TNOTE";
        public const string PRINCIPAL_STRIP_FROM_A_NON_CALLABLE_BOND_OR_NOTE = "TPRN";
        public const string TAX_REVENUE_ANTICIPATION_NOTE = "TRAN";
        public const string US_TREASURY_NOTE_UST = "UST";
        public const string US_TREASURY_BILL_USTB = "USTB";
        public const string VARIABLE_RATE_DEMAND_NOTE = "VRDN";
        public const string WARRANT = "WAR";
        public const string WITHDRAWN = "WITHDRN";
        public const string WILDCARD_ENTRY_FOR_USE_ON_SECURITY_DEFINITION_REQUEST = "?";
        public const string EXTENDED_COMM_NOTE = "XCN";
        public const string INDEXED_LINKED = "XLINKD";
        public const string YANKEE_CORPORATE_BOND = "YANK";
        public const string YANKEE_CERTIFICATE_OF_DEPOSIT = "YCD";
        public const string OPTIONS_ON_PHYSICAL = "OOP";
        public const string OPTIONS_ON_FUTURES = "OOF";
        public const string CASH = "CASH";
        public const string OPTIONS_ON_COMBO = "OOC";
        public const string INTEREST_RATE_SWAP = "IRS";
        public const string BANK_DEPOSITORY_NOTE = "BDN";
        public const string CANADIAN_MONEY_MARKETS = "CAMM";
        public const string CANADIAN_TREASURY_NOTES = "CAN";
        public const string CANADIAN_TREASURY_BILLS = "CTB";
        public const string CREDIT_DEFAULT_SWAP = "CDS";
        public const string CANADIAN_MORTGAGE_BONDS = "CMB";
        public const string EURO_CORPORATE_FLOATING_RATE_NOTES = "EUFRN";
        public const string US_CORPORATE_FLOATING_RATE_NOTES = "FRN";
        public const string CANADIAN_PROVINCIAL_BONDS = "PROV";
        public const string SECURED_LIQUIDITY_NOTE = "SLQN";
        public const string TREASURY_BILL = "TB";
        public const string TERM_LIQUIDITY_NOTE = "TLQN";
        public const string TAXABLE_MUNICIPAL_CP = "TMCP";
        public const string NON_DELIVERABLE_FORWARD = "FXNDF";
        public const string FX_SPOT = "FXSPOT";
        public const string FX_FORWARD = "FXFWD";
        public const string FX_SWAP = "FXSWAP";
        public const string WILDCARD_ENTRY = "WLD";
        public const string US_TREASURY_NOTE = "TNOTE";
        public const string US_TREASURY_BILL = "TBILL";
        public const string AMENDED_AND_RESTATED = "AMENDED";
        public const string TAX_AND_REVENUE_ANTICIPATION_NOTE = "TRAN";
        public const string MULTI_LEG_INSTRUMENT = "MLEG";
        public const string WILDCARD = "?";
        public const string CONVERTABLE_BOND = "CB";
        public const string INDEX_LINKED = "XLINKD";
        public const string PREFERED_STOCK = "PS";
        public const string US_TREASURY_NOTE_BOND = "UST";
        public const string LIQUIDITY_NOTES = "LQN";
        public const string OVERNITE = "ONITE";
        public const string PROMISSORY_NOTES = "PN";
        public const string REPURCHASE_AGREEMENT = "RP";
        public const string REVERSE_REPURCHASE_AGREEMENT = "RVRP";
        public const string AGENCY_POOLS = "POOL";
        public const string COLLATERALIZE_MORTGAGE_OBLIGATION = "CMO";
        public const string FEDERAL_HOUSING_AUTHORITY = "FHA";
        public const string FEDERAL_HOME_LOAN = "FHL";
        public const string FEDERAL_NATIONAL_MORTGAGE_ASSOCIATION = "FN";
        public const string GOVERNMENT_NATIONAL_MORTGAGE_ASSOCIATION = "GN";
        public const string TREASURIES_PLUS_AGENCY_DEBENTURE = "GOVT";
        public const string MISCELLANEOUS_PASSTHRU = "MPT";
        public const string MUNICIPAL_BOND = "MUNI";
        public const string NO_ISITC_SECURITY_TYPE = "NONE";
        public const string STUDENT_LOAN_MARKETING_ASSOCIATION = "SL";
        public const string CATS_TIGERS = "ZOO";
        public const string MORTGAGE_PRINCIPLE_ONLY = "MPO";
    }


    /// <summary>
    /// EffectiveTime Field
    /// </summary>/
    public sealed class EffectiveTime : DateTimeField
    {
        public const int TAG = 168;

        public EffectiveTime()
            :base(Tags.EffectiveTime) {}
        public EffectiveTime(DateTime val)
            :base(Tags.EffectiveTime, val) {}
        public EffectiveTime(DateTime val, bool showMilliseconds)
            :base(Tags.EffectiveTime, val, showMilliseconds) {}
		public EffectiveTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.EffectiveTime, val, precision) {}

    }


    /// <summary>
    /// StandInstDbType Field
    /// </summary>/
    public sealed class StandInstDbType : IntField
    {
        public const int TAG = 169;

        public StandInstDbType()
            :base(Tags.StandInstDbType) {}
        public StandInstDbType(int val)
            :base(Tags.StandInstDbType, val) {}


        // Field Enumerations
        public const int OTHER = 0;
        public const int DTC_SID = 1;
        public const int THOMSON_ALERT = 2;
        public const int A_GLOBAL_CUSTODIAN = 3;
        public const int ACCOUNTNET = 4;
    }


    /// <summary>
    /// StandInstDbName Field
    /// </summary>/
    public sealed class StandInstDbName : StringField
    {
        public const int TAG = 170;

        public StandInstDbName()
            :base(Tags.StandInstDbName) {}
        public StandInstDbName(string val)
            :base(Tags.StandInstDbName, val) {}

    }


    /// <summary>
    /// StandInstDbID Field
    /// </summary>/
    public sealed class StandInstDbID : StringField
    {
        public const int TAG = 171;

        public StandInstDbID()
            :base(Tags.StandInstDbID) {}
        public StandInstDbID(string val)
            :base(Tags.StandInstDbID, val) {}

    }


    /// <summary>
    /// SettlDeliveryType Field
    /// </summary>/
    public sealed class SettlDeliveryType : IntField
    {
        public const int TAG = 172;

        public SettlDeliveryType()
            :base(Tags.SettlDeliveryType) {}
        public SettlDeliveryType(int val)
            :base(Tags.SettlDeliveryType, val) {}


        // Field Enumerations
        public const int VERSUS_PAYMENT_DELIVER = 0;
        public const int FREE_DELIVER = 1;
        public const int TRI_PARTY = 2;
        public const int HOLD_IN_CUSTODY = 3;
        public const int VERSUS_PAYMENT = 0;
        public const int FREE = 1;
    }


    /// <summary>
    /// SettlDepositoryCode Field
    /// </summary>/
    public sealed class SettlDepositoryCode : StringField
    {
        public const int TAG = 173;

        public SettlDepositoryCode()
            :base(Tags.SettlDepositoryCode) {}
        public SettlDepositoryCode(string val)
            :base(Tags.SettlDepositoryCode, val) {}

    }


    /// <summary>
    /// SettlBrkrCode Field
    /// </summary>/
    public sealed class SettlBrkrCode : StringField
    {
        public const int TAG = 174;

        public SettlBrkrCode()
            :base(Tags.SettlBrkrCode) {}
        public SettlBrkrCode(string val)
            :base(Tags.SettlBrkrCode, val) {}

    }


    /// <summary>
    /// SettlInstCode Field
    /// </summary>/
    public sealed class SettlInstCode : StringField
    {
        public const int TAG = 175;

        public SettlInstCode()
            :base(Tags.SettlInstCode) {}
        public SettlInstCode(string val)
            :base(Tags.SettlInstCode, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentName Field
    /// </summary>/
    public sealed class SecuritySettlAgentName : StringField
    {
        public const int TAG = 176;

        public SecuritySettlAgentName()
            :base(Tags.SecuritySettlAgentName) {}
        public SecuritySettlAgentName(string val)
            :base(Tags.SecuritySettlAgentName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentCode Field
    /// </summary>/
    public sealed class SecuritySettlAgentCode : StringField
    {
        public const int TAG = 177;

        public SecuritySettlAgentCode()
            :base(Tags.SecuritySettlAgentCode) {}
        public SecuritySettlAgentCode(string val)
            :base(Tags.SecuritySettlAgentCode, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentAcctNum Field
    /// </summary>/
    public sealed class SecuritySettlAgentAcctNum : StringField
    {
        public const int TAG = 178;

        public SecuritySettlAgentAcctNum()
            :base(Tags.SecuritySettlAgentAcctNum) {}
        public SecuritySettlAgentAcctNum(string val)
            :base(Tags.SecuritySettlAgentAcctNum, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentAcctName Field
    /// </summary>/
    public sealed class SecuritySettlAgentAcctName : StringField
    {
        public const int TAG = 179;

        public SecuritySettlAgentAcctName()
            :base(Tags.SecuritySettlAgentAcctName) {}
        public SecuritySettlAgentAcctName(string val)
            :base(Tags.SecuritySettlAgentAcctName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentContactName Field
    /// </summary>/
    public sealed class SecuritySettlAgentContactName : StringField
    {
        public const int TAG = 180;

        public SecuritySettlAgentContactName()
            :base(Tags.SecuritySettlAgentContactName) {}
        public SecuritySettlAgentContactName(string val)
            :base(Tags.SecuritySettlAgentContactName, val) {}

    }


    /// <summary>
    /// SecuritySettlAgentContactPhone Field
    /// </summary>/
    public sealed class SecuritySettlAgentContactPhone : StringField
    {
        public const int TAG = 181;

        public SecuritySettlAgentContactPhone()
            :base(Tags.SecuritySettlAgentContactPhone) {}
        public SecuritySettlAgentContactPhone(string val)
            :base(Tags.SecuritySettlAgentContactPhone, val) {}

    }


    /// <summary>
    /// CashSettlAgentName Field
    /// </summary>/
    public sealed class CashSettlAgentName : StringField
    {
        public const int TAG = 182;

        public CashSettlAgentName()
            :base(Tags.CashSettlAgentName) {}
        public CashSettlAgentName(string val)
            :base(Tags.CashSettlAgentName, val) {}

    }


    /// <summary>
    /// CashSettlAgentCode Field
    /// </summary>/
    public sealed class CashSettlAgentCode : StringField
    {
        public const int TAG = 183;

        public CashSettlAgentCode()
            :base(Tags.CashSettlAgentCode) {}
        public CashSettlAgentCode(string val)
            :base(Tags.CashSettlAgentCode, val) {}

    }


    /// <summary>
    /// CashSettlAgentAcctNum Field
    /// </summary>/
    public sealed class CashSettlAgentAcctNum : StringField
    {
        public const int TAG = 184;

        public CashSettlAgentAcctNum()
            :base(Tags.CashSettlAgentAcctNum) {}
        public CashSettlAgentAcctNum(string val)
            :base(Tags.CashSettlAgentAcctNum, val) {}

    }


    /// <summary>
    /// CashSettlAgentAcctName Field
    /// </summary>/
    public sealed class CashSettlAgentAcctName : StringField
    {
        public const int TAG = 185;

        public CashSettlAgentAcctName()
            :base(Tags.CashSettlAgentAcctName) {}
        public CashSettlAgentAcctName(string val)
            :base(Tags.CashSettlAgentAcctName, val) {}

    }


    /// <summary>
    /// CashSettlAgentContactName Field
    /// </summary>/
    public sealed class CashSettlAgentContactName : StringField
    {
        public const int TAG = 186;

        public CashSettlAgentContactName()
            :base(Tags.CashSettlAgentContactName) {}
        public CashSettlAgentContactName(string val)
            :base(Tags.CashSettlAgentContactName, val) {}

    }


    /// <summary>
    /// CashSettlAgentContactPhone Field
    /// </summary>/
    public sealed class CashSettlAgentContactPhone : StringField
    {
        public const int TAG = 187;

        public CashSettlAgentContactPhone()
            :base(Tags.CashSettlAgentContactPhone) {}
        public CashSettlAgentContactPhone(string val)
            :base(Tags.CashSettlAgentContactPhone, val) {}

    }


    /// <summary>
    /// BidSpotRate Field
    /// </summary>/
    public sealed class BidSpotRate : DecimalField
    {
        public const int TAG = 188;

        public BidSpotRate()
            :base(Tags.BidSpotRate) {}
        public BidSpotRate(Decimal val)
            :base(Tags.BidSpotRate, val) {}

    }


    /// <summary>
    /// BidForwardPoints Field
    /// </summary>/
    public sealed class BidForwardPoints : DecimalField
    {
        public const int TAG = 189;

        public BidForwardPoints()
            :base(Tags.BidForwardPoints) {}
        public BidForwardPoints(Decimal val)
            :base(Tags.BidForwardPoints, val) {}

    }


    /// <summary>
    /// OfferSpotRate Field
    /// </summary>/
    public sealed class OfferSpotRate : DecimalField
    {
        public const int TAG = 190;

        public OfferSpotRate()
            :base(Tags.OfferSpotRate) {}
        public OfferSpotRate(Decimal val)
            :base(Tags.OfferSpotRate, val) {}

    }


    /// <summary>
    /// OfferForwardPoints Field
    /// </summary>/
    public sealed class OfferForwardPoints : DecimalField
    {
        public const int TAG = 191;

        public OfferForwardPoints()
            :base(Tags.OfferForwardPoints) {}
        public OfferForwardPoints(Decimal val)
            :base(Tags.OfferForwardPoints, val) {}

    }


    /// <summary>
    /// OrderQty2 Field
    /// </summary>/
    public sealed class OrderQty2 : DecimalField
    {
        public const int TAG = 192;

        public OrderQty2()
            :base(Tags.OrderQty2) {}
        public OrderQty2(Decimal val)
            :base(Tags.OrderQty2, val) {}

    }


    /// <summary>
    /// FutSettDate2 Field
    /// </summary>/
    public sealed class FutSettDate2 : StringField
    {
        public const int TAG = 193;

        public FutSettDate2()
            :base(Tags.FutSettDate2) {}
        public FutSettDate2(string val)
            :base(Tags.FutSettDate2, val) {}

    }


    /// <summary>
    /// LastSpotRate Field
    /// </summary>/
    public sealed class LastSpotRate : DecimalField
    {
        public const int TAG = 194;

        public LastSpotRate()
            :base(Tags.LastSpotRate) {}
        public LastSpotRate(Decimal val)
            :base(Tags.LastSpotRate, val) {}

    }


    /// <summary>
    /// LastForwardPoints Field
    /// </summary>/
    public sealed class LastForwardPoints : DecimalField
    {
        public const int TAG = 195;

        public LastForwardPoints()
            :base(Tags.LastForwardPoints) {}
        public LastForwardPoints(Decimal val)
            :base(Tags.LastForwardPoints, val) {}

    }


    /// <summary>
    /// AllocLinkID Field
    /// </summary>/
    public sealed class AllocLinkID : StringField
    {
        public const int TAG = 196;

        public AllocLinkID()
            :base(Tags.AllocLinkID) {}
        public AllocLinkID(string val)
            :base(Tags.AllocLinkID, val) {}

    }


    /// <summary>
    /// AllocLinkType Field
    /// </summary>/
    public sealed class AllocLinkType : IntField
    {
        public const int TAG = 197;

        public AllocLinkType()
            :base(Tags.AllocLinkType) {}
        public AllocLinkType(int val)
            :base(Tags.AllocLinkType, val) {}


        // Field Enumerations
        public const int FX_NETTING = 0;
        public const int FX_SWAP = 1;
        public const int F_X_NETTING = 0;
        public const int F_X_SWAP = 1;
    }


    /// <summary>
    /// SecondaryOrderID Field
    /// </summary>/
    public sealed class SecondaryOrderID : StringField
    {
        public const int TAG = 198;

        public SecondaryOrderID()
            :base(Tags.SecondaryOrderID) {}
        public SecondaryOrderID(string val)
            :base(Tags.SecondaryOrderID, val) {}

    }


    /// <summary>
    /// NoIOIQualifiers Field
    /// </summary>/
    public sealed class NoIOIQualifiers : IntField
    {
        public const int TAG = 199;

        public NoIOIQualifiers()
            :base(Tags.NoIOIQualifiers) {}
        public NoIOIQualifiers(int val)
            :base(Tags.NoIOIQualifiers, val) {}

    }


    /// <summary>
    /// MaturityMonthYear Field
    /// </summary>/
    public sealed class MaturityMonthYear : StringField
    {
        public const int TAG = 200;

        public MaturityMonthYear()
            :base(Tags.MaturityMonthYear) {}
        public MaturityMonthYear(string val)
            :base(Tags.MaturityMonthYear, val) {}

    }


    /// <summary>
    /// PutOrCall Field
    /// </summary>/
    public sealed class PutOrCall : IntField
    {
        public const int TAG = 201;

        public PutOrCall()
            :base(Tags.PutOrCall) {}
        public PutOrCall(int val)
            :base(Tags.PutOrCall, val) {}


        // Field Enumerations
        public const int PUT = 0;
        public const int CALL = 1;
    }


    /// <summary>
    /// StrikePrice Field
    /// </summary>/
    public sealed class StrikePrice : DecimalField
    {
        public const int TAG = 202;

        public StrikePrice()
            :base(Tags.StrikePrice) {}
        public StrikePrice(Decimal val)
            :base(Tags.StrikePrice, val) {}

    }


    /// <summary>
    /// CoveredOrUncovered Field
    /// </summary>/
    public sealed class CoveredOrUncovered : IntField
    {
        public const int TAG = 203;

        public CoveredOrUncovered()
            :base(Tags.CoveredOrUncovered) {}
        public CoveredOrUncovered(int val)
            :base(Tags.CoveredOrUncovered, val) {}


        // Field Enumerations
        public const int COVERED = 0;
        public const int UNCOVERED = 1;
    }


    /// <summary>
    /// CustomerOrFirm Field
    /// </summary>/
    public sealed class CustomerOrFirm : IntField
    {
        public const int TAG = 204;

        public CustomerOrFirm()
            :base(Tags.CustomerOrFirm) {}
        public CustomerOrFirm(int val)
            :base(Tags.CustomerOrFirm, val) {}


        // Field Enumerations
        public const int CUSTOMER = 0;
        public const int FIRM = 1;
    }


    /// <summary>
    /// MaturityDay Field
    /// </summary>/
    public sealed class MaturityDay : StringField
    {
        public const int TAG = 205;

        public MaturityDay()
            :base(Tags.MaturityDay) {}
        public MaturityDay(string val)
            :base(Tags.MaturityDay, val) {}

    }


    /// <summary>
    /// OptAttribute Field
    /// </summary>/
    public sealed class OptAttribute : CharField
    {
        public const int TAG = 206;

        public OptAttribute()
            :base(Tags.OptAttribute) {}
        public OptAttribute(char val)
            :base(Tags.OptAttribute, val) {}

    }


    /// <summary>
    /// SecurityExchange Field
    /// </summary>/
    public sealed class SecurityExchange : StringField
    {
        public const int TAG = 207;

        public SecurityExchange()
            :base(Tags.SecurityExchange) {}
        public SecurityExchange(string val)
            :base(Tags.SecurityExchange, val) {}

    }


    /// <summary>
    /// NotifyBrokerOfCredit Field
    /// </summary>/
    public sealed class NotifyBrokerOfCredit : BooleanField
    {
        public const int TAG = 208;

        public NotifyBrokerOfCredit()
            :base(Tags.NotifyBrokerOfCredit) {}
        public NotifyBrokerOfCredit(Boolean val)
            :base(Tags.NotifyBrokerOfCredit, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean DETAILS_SHOULD_BE_COMMUNICATED = true;
        public const Boolean DETAILS_SHOULD_NOT_BE_COMMUNICATED = false;
    }


    /// <summary>
    /// AllocHandlInst Field
    /// </summary>/
    public sealed class AllocHandlInst : IntField
    {
        public const int TAG = 209;

        public AllocHandlInst()
            :base(Tags.AllocHandlInst) {}
        public AllocHandlInst(int val)
            :base(Tags.AllocHandlInst, val) {}


        // Field Enumerations
        public const int MATCH = 1;
        public const int FORWARD = 2;
        public const int FORWARD_AND_MATCH = 3;
    }


    /// <summary>
    /// MaxShow Field
    /// </summary>/
    public sealed class MaxShow : DecimalField
    {
        public const int TAG = 210;

        public MaxShow()
            :base(Tags.MaxShow) {}
        public MaxShow(Decimal val)
            :base(Tags.MaxShow, val) {}

    }


    /// <summary>
    /// PegDifference Field
    /// </summary>/
    public sealed class PegDifference : DecimalField
    {
        public const int TAG = 211;

        public PegDifference()
            :base(Tags.PegDifference) {}
        public PegDifference(Decimal val)
            :base(Tags.PegDifference, val) {}

    }


    /// <summary>
    /// TotNoOrders Field
    /// </summary>/
    public sealed class TotNoOrders : IntField
    {
        public const int TAG = 68;

        public TotNoOrders()
            :base(Tags.TotNoOrders) {}
        public TotNoOrders(int val)
            :base(Tags.TotNoOrders, val) {}

    }


    /// <summary>
    /// XmlDataLen Field
    /// </summary>/
    public sealed class XmlDataLen : IntField
    {
        public const int TAG = 212;

        public XmlDataLen()
            :base(Tags.XmlDataLen) {}
        public XmlDataLen(int val)
            :base(Tags.XmlDataLen, val) {}

    }


    /// <summary>
    /// XmlData Field
    /// </summary>/
    public sealed class XmlData : StringField
    {
        public const int TAG = 213;

        public XmlData()
            :base(Tags.XmlData) {}
        public XmlData(string val)
            :base(Tags.XmlData, val) {}

    }


    /// <summary>
    /// SettlInstRefID Field
    /// </summary>/
    public sealed class SettlInstRefID : StringField
    {
        public const int TAG = 214;

        public SettlInstRefID()
            :base(Tags.SettlInstRefID) {}
        public SettlInstRefID(string val)
            :base(Tags.SettlInstRefID, val) {}

    }


    /// <summary>
    /// NoRoutingIDs Field
    /// </summary>/
    public sealed class NoRoutingIDs : IntField
    {
        public const int TAG = 215;

        public NoRoutingIDs()
            :base(Tags.NoRoutingIDs) {}
        public NoRoutingIDs(int val)
            :base(Tags.NoRoutingIDs, val) {}

    }


    /// <summary>
    /// RoutingType Field
    /// </summary>/
    public sealed class RoutingType : IntField
    {
        public const int TAG = 216;

        public RoutingType()
            :base(Tags.RoutingType) {}
        public RoutingType(int val)
            :base(Tags.RoutingType, val) {}


        // Field Enumerations
        public const int TARGET_FIRM = 1;
        public const int TARGET_LIST = 2;
        public const int BLOCK_FIRM = 3;
        public const int BLOCK_LIST = 4;
    }


    /// <summary>
    /// RoutingID Field
    /// </summary>/
    public sealed class RoutingID : StringField
    {
        public const int TAG = 217;

        public RoutingID()
            :base(Tags.RoutingID) {}
        public RoutingID(string val)
            :base(Tags.RoutingID, val) {}

    }


    /// <summary>
    /// SpreadToBenchmark Field
    /// </summary>/
    public sealed class SpreadToBenchmark : DecimalField
    {
        public const int TAG = 218;

        public SpreadToBenchmark()
            :base(Tags.SpreadToBenchmark) {}
        public SpreadToBenchmark(Decimal val)
            :base(Tags.SpreadToBenchmark, val) {}

    }


    /// <summary>
    /// Benchmark Field
    /// </summary>/
    public sealed class Benchmark : CharField
    {
        public const int TAG = 219;

        public Benchmark()
            :base(Tags.Benchmark) {}
        public Benchmark(char val)
            :base(Tags.Benchmark, val) {}


        // Field Enumerations
        public const char CURVE = '1';
        public const char VAL_5YR = '2';
        public const char OLD5 = '3';
        public const char VAL_10YR = '4';
        public const char OLD10 = '5';
        public const char VAL_30YR = '6';
        public const char OLD30 = '7';
        public const char VAL_3MOLIBOR = '8';
        public const char VAL_6MOLIBOR = '9';
        public const char FIVEYR = '2';
        public const char TENYR = '4';
        public const char THIRTYYR = '6';
        public const char THREEMOLIBOR = '8';
        public const char SIXMOLIBOR = '9';
    }


    /// <summary>
    /// CouponRate Field
    /// </summary>/
    public sealed class CouponRate : DecimalField
    {
        public const int TAG = 223;

        public CouponRate()
            :base(Tags.CouponRate) {}
        public CouponRate(Decimal val)
            :base(Tags.CouponRate, val) {}

    }


    /// <summary>
    /// ContractMultiplier Field
    /// </summary>/
    public sealed class ContractMultiplier : DecimalField
    {
        public const int TAG = 231;

        public ContractMultiplier()
            :base(Tags.ContractMultiplier) {}
        public ContractMultiplier(Decimal val)
            :base(Tags.ContractMultiplier, val) {}

    }


    /// <summary>
    /// MDReqID Field
    /// </summary>/
    public sealed class MDReqID : StringField
    {
        public const int TAG = 262;

        public MDReqID()
            :base(Tags.MDReqID) {}
        public MDReqID(string val)
            :base(Tags.MDReqID, val) {}

    }


    /// <summary>
    /// SubscriptionRequestType Field
    /// </summary>/
    public sealed class SubscriptionRequestType : CharField
    {
        public const int TAG = 263;

        public SubscriptionRequestType()
            :base(Tags.SubscriptionRequestType) {}
        public SubscriptionRequestType(char val)
            :base(Tags.SubscriptionRequestType, val) {}


        // Field Enumerations
        public const char SNAPSHOT = '0';
        public const char SNAPSHOT_PLUS_UPDATES = '1';
        public const char DISABLE_PREVIOUS_SNAPSHOT_PLUS_UPDATE_REQUEST = '2';
        public const char DISABLE_PREVIOUS = '2';
    }


    /// <summary>
    /// MarketDepth Field
    /// </summary>/
    public sealed class MarketDepth : IntField
    {
        public const int TAG = 264;

        public MarketDepth()
            :base(Tags.MarketDepth) {}
        public MarketDepth(int val)
            :base(Tags.MarketDepth, val) {}

    }


    /// <summary>
    /// MDUpdateType Field
    /// </summary>/
    public sealed class MDUpdateType : IntField
    {
        public const int TAG = 265;

        public MDUpdateType()
            :base(Tags.MDUpdateType) {}
        public MDUpdateType(int val)
            :base(Tags.MDUpdateType, val) {}


        // Field Enumerations
        public const int FULL_REFRESH = 0;
        public const int INCREMENTAL_REFRESH = 1;
    }


    /// <summary>
    /// AggregatedBook Field
    /// </summary>/
    public sealed class AggregatedBook : BooleanField
    {
        public const int TAG = 266;

        public AggregatedBook()
            :base(Tags.AggregatedBook) {}
        public AggregatedBook(Boolean val)
            :base(Tags.AggregatedBook, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
        public const Boolean ONE_BOOK_ENTRY_PER_SIDE_PER_PRICE = true;
        public const Boolean MULTIPLE_ENTRIES_PER_SIDE_PER_PRICE_ALLOWED = false;
    }


    /// <summary>
    /// NoMDEntryTypes Field
    /// </summary>/
    public sealed class NoMDEntryTypes : IntField
    {
        public const int TAG = 267;

        public NoMDEntryTypes()
            :base(Tags.NoMDEntryTypes) {}
        public NoMDEntryTypes(int val)
            :base(Tags.NoMDEntryTypes, val) {}

    }


    /// <summary>
    /// NoMDEntries Field
    /// </summary>/
    public sealed class NoMDEntries : IntField
    {
        public const int TAG = 268;

        public NoMDEntries()
            :base(Tags.NoMDEntries) {}
        public NoMDEntries(int val)
            :base(Tags.NoMDEntries, val) {}

    }


    /// <summary>
    /// MDEntryType Field
    /// </summary>/
    public sealed class MDEntryType : CharField
    {
        public const int TAG = 269;

        public MDEntryType()
            :base(Tags.MDEntryType) {}
        public MDEntryType(char val)
            :base(Tags.MDEntryType, val) {}


        // Field Enumerations
        public const char BID = '0';
        public const char OFFER = '1';
        public const char TRADE = '2';
        public const char INDEX_VALUE = '3';
        public const char OPENING_PRICE = '4';
        public const char CLOSING_PRICE = '5';
        public const char SETTLEMENT_PRICE = '6';
        public const char TRADING_SESSION_HIGH_PRICE = '7';
        public const char TRADING_SESSION_LOW_PRICE = '8';
        public const char TRADING_SESSION_VWAP_PRICE = '9';
        public const char IMBALANCE = 'A';
        public const char TRADE_VOLUME = 'B';
        public const char OPEN_INTEREST = 'C';
        public const char COMPOSITE_UNDERLYING_PRICE = 'D';
        public const char SIMULATED_SELL_PRICE = 'E';
        public const char SIMULATED_BUY_PRICE = 'F';
        public const char MARGIN_RATE = 'G';
        public const char MID_PRICE = 'H';
        public const char EMPTY_BOOK = 'J';
        public const char SETTLE_HIGH_PRICE = 'K';
        public const char SETTLE_LOW_PRICE = 'L';
        public const char PRIOR_SETTLE_PRICE = 'M';
        public const char SESSION_HIGH_BID = 'N';
        public const char SESSION_LOW_OFFER = 'O';
        public const char EARLY_PRICES = 'P';
        public const char AUCTION_CLEARING_PRICE = 'Q';
        public const char SWAP_VALUE_FACTOR = 'S';
        public const char DAILY_VALUE_ADJUSTMENT_FOR_LONG_POSITIONS = 'R';
        public const char CUMULATIVE_VALUE_ADJUSTMENT_FOR_LONG_POSITIONS = 'T';
        public const char DAILY_VALUE_ADJUSTMENT_FOR_SHORT_POSITIONS = 'U';
        public const char CUMULATIVE_VALUE_ADJUSTMENT_FOR_SHORT_POSITIONS = 'V';
        public const char RECOVERY_RATE = 'Y';
        public const char RECOVERY_RATE_FOR_LONG = 'Z';
        public const char RECOVERY_RATE_FOR_SHORT = 'a';
        public const char FIXING_PRICE = 'W';
        public const char CASH_RATE = 'X';
    }


    /// <summary>
    /// MDEntryPx Field
    /// </summary>/
    public sealed class MDEntryPx : DecimalField
    {
        public const int TAG = 270;

        public MDEntryPx()
            :base(Tags.MDEntryPx) {}
        public MDEntryPx(Decimal val)
            :base(Tags.MDEntryPx, val) {}

    }


    /// <summary>
    /// MDEntrySize Field
    /// </summary>/
    public sealed class MDEntrySize : DecimalField
    {
        public const int TAG = 271;

        public MDEntrySize()
            :base(Tags.MDEntrySize) {}
        public MDEntrySize(Decimal val)
            :base(Tags.MDEntrySize, val) {}

    }


    /// <summary>
    /// MDEntryDate Field
    /// </summary>/
    public sealed class MDEntryDate : DateOnlyField
    {
        public const int TAG = 272;

        public MDEntryDate()
            :base(Tags.MDEntryDate) {}
        public MDEntryDate(DateTime val)
            :base(Tags.MDEntryDate, val) {}

    }


    /// <summary>
    /// MDEntryTime Field
    /// </summary>/
    public sealed class MDEntryTime : TimeOnlyField
    {
        public const int TAG = 273;

        public MDEntryTime()
            :base(Tags.MDEntryTime) {}
        public MDEntryTime(DateTime val)
            :base(Tags.MDEntryTime, val) {}
        public MDEntryTime(DateTime val, bool showMilliseconds)
            :base(Tags.MDEntryTime, val, showMilliseconds) {}
		public MDEntryTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.MDEntryTime, val, precision) {}

    }


    /// <summary>
    /// TickDirection Field
    /// </summary>/
    public sealed class TickDirection : CharField
    {
        public const int TAG = 274;

        public TickDirection()
            :base(Tags.TickDirection) {}
        public TickDirection(char val)
            :base(Tags.TickDirection, val) {}


        // Field Enumerations
        public const char PLUS_TICK = '0';
        public const char ZERO_PLUS_TICK = '1';
        public const char MINUS_TICK = '2';
        public const char ZERO_MINUS_TICK = '3';
        public const char ZEROPLUS_TICK = '1';
        public const char ZEROMINUS_TICK = '3';
    }


    /// <summary>
    /// MDMkt Field
    /// </summary>/
    public sealed class MDMkt : StringField
    {
        public const int TAG = 275;

        public MDMkt()
            :base(Tags.MDMkt) {}
        public MDMkt(string val)
            :base(Tags.MDMkt, val) {}

    }


    /// <summary>
    /// QuoteCondition Field
    /// </summary>/
    public sealed class QuoteCondition : StringField
    {
        public const int TAG = 276;

        public QuoteCondition()
            :base(Tags.QuoteCondition) {}
        public QuoteCondition(string val)
            :base(Tags.QuoteCondition, val) {}


        // Field Enumerations
        public const string OPEN_ACTIVE = "A";
        public const string CLOSED_INACTIVE = "B";
        public const string EXCHANGE_BEST = "C";
        public const string CONSOLIDATED_BEST = "D";
        public const string LOCKED = "E";
        public const string CROSSED = "F";
        public const string DEPTH = "G";
        public const string FAST_TRADING = "H";
        public const string NON_FIRM = "I";
        public const string MANUAL_SLOW_QUOTE = "L";
        public const string OUTRIGHT_PRICE = "J";
        public const string IMPLIED_PRICE = "K";
        public const string DEPTH_ON_OFFER = "M";
        public const string DEPTH_ON_BID = "N";
        public const string CLOSING = "O";
        public const string NEWS_DISSEMINATION = "P";
        public const string TRADING_RANGE = "Q";
        public const string ORDER_INFLUX = "R";
        public const string DUE_TO_RELATED = "S";
        public const string NEWS_PENDING = "T";
        public const string ADDITIONAL_INFO = "U";
        public const string ADDITIONAL_INFO_DUE_TO_RELATED = "V";
        public const string RESUME = "W";
        public const string VIEW_OF_COMMON = "X";
        public const string VOLUME_ALERT = "Y";
        public const string ORDER_IMBALANCE = "Z";
        public const string EQUIPMENT_CHANGEOVER = "a";
        public const string NO_OPEN = "b";
        public const string REGULAR_ETH = "c";
        public const string AUTOMATIC_EXECUTION = "d";
        public const string AUTOMATIC_EXECUTION_ETH = "e";
        public const string FAST_MARKET_ETH = "f ";
        public const string INACTIVE_ETH = "g";
        public const string ROTATION = "h";
        public const string ROTATION_ETH = "i";
        public const string HALT = "j";
        public const string HALT_ETH = "k";
        public const string DUE_TO_NEWS_DISSEMINATION = "l";
        public const string DUE_TO_NEWS_PENDING = "m";
        public const string TRADING_RESUME = "n";
        public const string OUT_OF_SEQUENCE = "o";
        public const string BID_SPECIALIST = "p";
        public const string OFFER_SPECIALIST = "q";
        public const string BID_OFFER_SPECIALIST = "r";
        public const string END_OF_DAY_SAM = "s";
        public const string FORBIDDEN_SAM = "t";
        public const string FROZEN_SAM = "u";
        public const string PREOPENING_SAM = "v";
        public const string OPENING_SAM = "w";
        public const string OPEN_SAM = "x";
        public const string SURVEILLANCE_SAM = "y";
        public const string SUSPENDED_SAM = "z";
        public const string RESERVED_SAM = "0";
        public const string NO_ACTIVE_SAM = "1";
        public const string RESTRICTED = "2";
        public const string REST_OF_BOOK_VWAP = "3";
        public const string BETTER_PRICES_IN_CONDITIONAL_ORDERS = "4";
        public const string MEDIAN_PRICE = "5";
        public const string FULL_CURVE = "6";
        public const string FLAT_CURVE = "7";
        public const string OPEN = "A";
        public const string CLOSED = "B";
        public const string NONFIRM = "I";
    }


    /// <summary>
    /// TradeCondition Field
    /// </summary>/
    public sealed class TradeCondition : StringField
    {
        public const int TAG = 277;

        public TradeCondition()
            :base(Tags.TradeCondition) {}
        public TradeCondition(string val)
            :base(Tags.TradeCondition, val) {}


        // Field Enumerations
        public const string CASH = "A";
        public const string AVERAGE_PRICE_TRADE = "B";
        public const string CASH_TRADE = "C";
        public const string NEXT_DAY = "D";
        public const string OPENING_REOPENING_TRADE_DETAIL = "E";
        public const string INTRADAY_TRADE_DETAIL = "F";
        public const string RULE_127_TRADE = "G";
        public const string RULE_155_TRADE = "H";
        public const string SOLD_LAST = "I";
        public const string NEXT_DAY_TRADE = "J";
        public const string OPENED = "K";
        public const string SELLER = "L";
        public const string SOLD = "M";
        public const string STOPPED_STOCK = "N";
        public const string IMBALANCE_MORE_BUYERS = "P";
        public const string IMBALANCE_MORE_SELLERS = "Q";
        public const string OPENING_PRICE = "R";
        public const string TRADES_RESULTING_FROM_MANUAL_SLOW_QUOTE = "Y";
        public const string TRADES_RESULTING_FROM_INTERMARKET_SWEEP = "Z";
        public const string BARGAIN_CONDITION = "S";
        public const string CONVERTED_PRICE_INDICATOR = "T";
        public const string EXCHANGE_LAST = "U";
        public const string FINAL_PRICE_OF_SESSION = "V";
        public const string EX_PIT = "W";
        public const string CROSSED_X = "X";
        public const string CANCEL = "0";
        public const string VOLUME_ONLY = "a";
        public const string DIRECT_PLUS = "b";
        public const string ACQUISITION = "c";
        public const string BUNCHED = "d";
        public const string DISTRIBUTION = "e";
        public const string BUNCHED_SALE = "f";
        public const string SPLIT_TRADE = "g";
        public const string CANCEL_STOPPED = "h";
        public const string CANCEL_ETH = "i";
        public const string CANCEL_STOPPED_ETH = "j";
        public const string OUT_OF_SEQUENCE_ETH = "k";
        public const string CANCEL_LAST_ETH = "l";
        public const string SOLD_LAST_SALE_ETH = "m";
        public const string CANCEL_LAST = "n";
        public const string SOLD_LAST_SALE = "o";
        public const string CANCEL_OPEN = "p";
        public const string CANCEL_OPEN_ETH = "q";
        public const string OPENED_SALE_ETH = "r";
        public const string CANCEL_ONLY = "s";
        public const string CANCEL_ONLY_ETH = "t";
        public const string LATE_OPEN_ETH = "u";
        public const string AUTO_EXECUTION_ETH = "v";
        public const string REOPEN = "w";
        public const string REOPEN_ETH = "x";
        public const string ADJUSTED = "y";
        public const string ADJUSTED_ETH = "z";
        public const string SPREAD = "AA";
        public const string SPREAD_ETH = "AB";
        public const string STRADDLE = "AC";
        public const string STRADDLE_ETH = "AD";
        public const string STOPPED = "AE";
        public const string STOPPED_ETH = "AF";
        public const string REGULAR_ETH = "AG";
        public const string COMBO = "AH";
        public const string COMBO_ETH = "AI";
        public const string OFFICIAL_CLOSING_PRICE = "AJ";
        public const string PRIOR_REFERENCE_PRICE = "AK";
        public const string STOPPED_SOLD_LAST = "AL";
        public const string STOPPED_OUT_OF_SEQUENCE = "AM";
        public const string OFFICAL_CLOSING_PRICE = "AN";
        public const string CROSSED_AO = "AO";
        public const string FAST_MARKET = "AP";
        public const string AUTOMATIC_EXECUTION = "AQ";
        public const string FORM_T = "AR";
        public const string BASKET_INDEX = "AS";
        public const string BURST_BASKET = "AT";
        public const string IMPLIED_TRADE = "1";
        public const string OUTSIDE_SPREAD = "AV";
        public const string MARKETPLACE_ENTERED_TRADE = "2";
        public const string MULT_ASSET_CLASS_MULTILEG_TRADE = "3";
        public const string MULTILEG_TO_MULTILEG_TRADE = "4";
        public const string CASH_MARKET = "A";
        public const string NEXT_DAY_MARKET = "D";
        public const string RULE127 = "G";
        public const string RULE155 = "H";
        public const string OPENING = "E";
    }


    /// <summary>
    /// MDEntryID Field
    /// </summary>/
    public sealed class MDEntryID : StringField
    {
        public const int TAG = 278;

        public MDEntryID()
            :base(Tags.MDEntryID) {}
        public MDEntryID(string val)
            :base(Tags.MDEntryID, val) {}

    }


    /// <summary>
    /// MDUpdateAction Field
    /// </summary>/
    public sealed class MDUpdateAction : CharField
    {
        public const int TAG = 279;

        public MDUpdateAction()
            :base(Tags.MDUpdateAction) {}
        public MDUpdateAction(char val)
            :base(Tags.MDUpdateAction, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char CHANGE = '1';
        public const char DELETE = '2';
        public const char DELETE_THRU = '3';
        public const char DELETE_FROM = '4';
        public const char OVERLAY = '5';
    }


    /// <summary>
    /// MDEntryRefID Field
    /// </summary>/
    public sealed class MDEntryRefID : StringField
    {
        public const int TAG = 280;

        public MDEntryRefID()
            :base(Tags.MDEntryRefID) {}
        public MDEntryRefID(string val)
            :base(Tags.MDEntryRefID, val) {}

    }


    /// <summary>
    /// MDReqRejReason Field
    /// </summary>/
    public sealed class MDReqRejReason : CharField
    {
        public const int TAG = 281;

        public MDReqRejReason()
            :base(Tags.MDReqRejReason) {}
        public MDReqRejReason(char val)
            :base(Tags.MDReqRejReason, val) {}


        // Field Enumerations
        public const char UNKNOWN_SYMBOL = '0';
        public const char DUPLICATE_MDREQID = '1';
        public const char INSUFFICIENT_BANDWIDTH = '2';
        public const char INSUFFICIENT_PERMISSIONS = '3';
        public const char UNSUPPORTED_SUBSCRIPTIONREQUESTTYPE = '4';
        public const char UNSUPPORTED_MARKETDEPTH = '5';
        public const char UNSUPPORTED_MDUPDATETYPE = '6';
        public const char UNSUPPORTED_AGGREGATEDBOOK = '7';
        public const char UNSUPPORTED_MDENTRYTYPE = '8';
        public const char UNSUPPORTED_TRADINGSESSIONID = '9';
        public const char UNSUPPORTED_SCOPE = 'A';
        public const char UNSUPPORTED_OPENCLOSESETTLEFLAG = 'B';
        public const char UNSUPPORTED_MDIMPLICITDELETE = 'C';
        public const char INSUFFICIENT_CREDIT = 'D';
    }


    /// <summary>
    /// MDEntryOriginator Field
    /// </summary>/
    public sealed class MDEntryOriginator : StringField
    {
        public const int TAG = 282;

        public MDEntryOriginator()
            :base(Tags.MDEntryOriginator) {}
        public MDEntryOriginator(string val)
            :base(Tags.MDEntryOriginator, val) {}

    }


    /// <summary>
    /// LocationID Field
    /// </summary>/
    public sealed class LocationID : StringField
    {
        public const int TAG = 283;

        public LocationID()
            :base(Tags.LocationID) {}
        public LocationID(string val)
            :base(Tags.LocationID, val) {}

    }


    /// <summary>
    /// DeskID Field
    /// </summary>/
    public sealed class DeskID : StringField
    {
        public const int TAG = 284;

        public DeskID()
            :base(Tags.DeskID) {}
        public DeskID(string val)
            :base(Tags.DeskID, val) {}

    }


    /// <summary>
    /// DeleteReason Field
    /// </summary>/
    public sealed class DeleteReason : CharField
    {
        public const int TAG = 285;

        public DeleteReason()
            :base(Tags.DeleteReason) {}
        public DeleteReason(char val)
            :base(Tags.DeleteReason, val) {}


        // Field Enumerations
        public const char CANCELLATION = '0';
        public const char ERROR = '1';
        public const char CANCELATION_TRADE_BUST = '0';
        public const char CANCELATION = '0';
    }


    /// <summary>
    /// OpenCloseSettleFlag Field
    /// </summary>/
    public sealed class OpenCloseSettleFlag : StringField
    {
        public const int TAG = 286;

        public OpenCloseSettleFlag()
            :base(Tags.OpenCloseSettleFlag) {}
        public OpenCloseSettleFlag(string val)
            :base(Tags.OpenCloseSettleFlag, val) {}


        // Field Enumerations
        public const string DAILY_OPEN = "0";
        public const string SESSION_OPEN = "1";
        public const string DELIVERY_SETTLEMENT_PRICE = "2";
        public const string EXPECTED_PRICE = "3";
        public const string PRICE_FROM_PREVIOUS_BUSINESS_DAY = "4";
        public const string DAILY_OPEN_CLOSE__SETTLEMENT_PRICE = "0";
        public const string SESSION_OPEN_CLOSE__SETTLEMENT_PRICE = "1";
    }


    /// <summary>
    /// SellerDays Field
    /// </summary>/
    public sealed class SellerDays : IntField
    {
        public const int TAG = 287;

        public SellerDays()
            :base(Tags.SellerDays) {}
        public SellerDays(int val)
            :base(Tags.SellerDays, val) {}

    }


    /// <summary>
    /// MDEntryBuyer Field
    /// </summary>/
    public sealed class MDEntryBuyer : StringField
    {
        public const int TAG = 288;

        public MDEntryBuyer()
            :base(Tags.MDEntryBuyer) {}
        public MDEntryBuyer(string val)
            :base(Tags.MDEntryBuyer, val) {}

    }


    /// <summary>
    /// MDEntrySeller Field
    /// </summary>/
    public sealed class MDEntrySeller : StringField
    {
        public const int TAG = 289;

        public MDEntrySeller()
            :base(Tags.MDEntrySeller) {}
        public MDEntrySeller(string val)
            :base(Tags.MDEntrySeller, val) {}

    }


    /// <summary>
    /// MDEntryPositionNo Field
    /// </summary>/
    public sealed class MDEntryPositionNo : IntField
    {
        public const int TAG = 290;

        public MDEntryPositionNo()
            :base(Tags.MDEntryPositionNo) {}
        public MDEntryPositionNo(int val)
            :base(Tags.MDEntryPositionNo, val) {}

    }


    /// <summary>
    /// FinancialStatus Field
    /// </summary>/
    public sealed class FinancialStatus : StringField
    {
        public const int TAG = 291;

        public FinancialStatus()
            :base(Tags.FinancialStatus) {}
        public FinancialStatus(string val)
            :base(Tags.FinancialStatus, val) {}


        // Field Enumerations
        public const string BANKRUPT = "1";
        public const string PENDING_DELISTING = "2";
        public const string RESTRICTED = "3";
    }


    /// <summary>
    /// CorporateAction Field
    /// </summary>/
    public sealed class CorporateAction : StringField
    {
        public const int TAG = 292;

        public CorporateAction()
            :base(Tags.CorporateAction) {}
        public CorporateAction(string val)
            :base(Tags.CorporateAction, val) {}


        // Field Enumerations
        public const string EX_DIVIDEND = "A";
        public const string EX_DISTRIBUTION = "B";
        public const string EX_RIGHTS = "C";
        public const string NEW = "D";
        public const string EX_INTEREST = "E";
        public const string CASH_DIVIDEND = "F";
        public const string STOCK_DIVIDEND = "G";
        public const string NON_INTEGER_STOCK_SPLIT = "H";
        public const string REVERSE_STOCK_SPLIT = "I";
        public const string STANDARD_INTEGER_STOCK_SPLIT = "J";
        public const string POSITION_CONSOLIDATION = "K";
        public const string LIQUIDATION_REORGANIZATION = "L";
        public const string MERGER_REORGANIZATION = "M";
        public const string RIGHTS_OFFERING = "N";
        public const string SHAREHOLDER_MEETING = "O";
        public const string SPINOFF = "P";
        public const string TENDER_OFFER = "Q";
        public const string WARRANT = "R";
        public const string SPECIAL_ACTION = "S";
        public const string SYMBOL_CONVERSION = "T";
        public const string CUSIP = "U";
        public const string LEAP_ROLLOVER = "V";
        public const string SUCCESSION_EVENT = "W";
        public const string EXDIVIDEND = "A";
        public const string EXDISTRIBUTION = "B";
        public const string EXRIGHTS = "C";
        public const string EXINTEREST = "E";
    }


    /// <summary>
    /// DefBidSize Field
    /// </summary>/
    public sealed class DefBidSize : DecimalField
    {
        public const int TAG = 293;

        public DefBidSize()
            :base(Tags.DefBidSize) {}
        public DefBidSize(Decimal val)
            :base(Tags.DefBidSize, val) {}

    }


    /// <summary>
    /// DefOfferSize Field
    /// </summary>/
    public sealed class DefOfferSize : DecimalField
    {
        public const int TAG = 294;

        public DefOfferSize()
            :base(Tags.DefOfferSize) {}
        public DefOfferSize(Decimal val)
            :base(Tags.DefOfferSize, val) {}

    }


    /// <summary>
    /// NoQuoteEntries Field
    /// </summary>/
    public sealed class NoQuoteEntries : IntField
    {
        public const int TAG = 295;

        public NoQuoteEntries()
            :base(Tags.NoQuoteEntries) {}
        public NoQuoteEntries(int val)
            :base(Tags.NoQuoteEntries, val) {}

    }


    /// <summary>
    /// NoQuoteSets Field
    /// </summary>/
    public sealed class NoQuoteSets : IntField
    {
        public const int TAG = 296;

        public NoQuoteSets()
            :base(Tags.NoQuoteSets) {}
        public NoQuoteSets(int val)
            :base(Tags.NoQuoteSets, val) {}

    }


    /// <summary>
    /// QuoteAckStatus Field
    /// </summary>/
    public sealed class QuoteAckStatus : IntField
    {
        public const int TAG = 297;

        public QuoteAckStatus()
            :base(Tags.QuoteAckStatus) {}
        public QuoteAckStatus(int val)
            :base(Tags.QuoteAckStatus, val) {}

    }


    /// <summary>
    /// QuoteCancelType Field
    /// </summary>/
    public sealed class QuoteCancelType : IntField
    {
        public const int TAG = 298;

        public QuoteCancelType()
            :base(Tags.QuoteCancelType) {}
        public QuoteCancelType(int val)
            :base(Tags.QuoteCancelType, val) {}


        // Field Enumerations
        public const int CANCEL_FOR_ONE_OR_MORE_SECURITIES = 1;
        public const int CANCEL_FOR_SECURITY_TYPE = 2;
        public const int CANCEL_FOR_UNDERLYING_SECURITY = 3;
        public const int CANCEL_ALL_QUOTES = 4;
        public const int CANCEL_QUOTE_SPECIFIED_IN_QUOTEID = 5;
        public const int CANCEL_BY_QUOTETYPE = 6;
        public const int CANCEL_FOR_SECURITY_ISSUER = 7;
        public const int CANCEL_FOR_ISSUER_OF_UNDERLYING_SECURITY = 8;
        public const int CANCEL_FOR_SYMBOL = 1;
        public const int CANCEL_FOR_UNDERLYING_SYMBOL = 3;
    }


    /// <summary>
    /// QuoteEntryID Field
    /// </summary>/
    public sealed class QuoteEntryID : StringField
    {
        public const int TAG = 299;

        public QuoteEntryID()
            :base(Tags.QuoteEntryID) {}
        public QuoteEntryID(string val)
            :base(Tags.QuoteEntryID, val) {}

    }


    /// <summary>
    /// QuoteRejectReason Field
    /// </summary>/
    public sealed class QuoteRejectReason : IntField
    {
        public const int TAG = 300;

        public QuoteRejectReason()
            :base(Tags.QuoteRejectReason) {}
        public QuoteRejectReason(int val)
            :base(Tags.QuoteRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int EXCHANGE = 2;
        public const int QUOTE_REQUEST_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_QUOTE = 5;
        public const int DUPLICATE_QUOTE = 6;
        public const int INVALID_BID_ASK_SPREAD = 7;
        public const int INVALID_PRICE = 8;
        public const int NOT_AUTHORIZED_TO_QUOTE_SECURITY = 9;
        public const int OTHER = 99;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND = 10;
        public const int QUOTE_LOCKED = 11;
        public const int INVALID_OR_UNKNOWN_SECURITY_ISSUER = 12;
        public const int INVALID_OR_UNKNOWN_ISSUER_OF_UNDERLYING_SECURITY = 13;
        public const int EXCHANGE_CLOSED = 2;
        public const int DUPLICATE_QUOTE_7 = 6;
    }


    /// <summary>
    /// QuoteResponseLevel Field
    /// </summary>/
    public sealed class QuoteResponseLevel : IntField
    {
        public const int TAG = 301;

        public QuoteResponseLevel()
            :base(Tags.QuoteResponseLevel) {}
        public QuoteResponseLevel(int val)
            :base(Tags.QuoteResponseLevel, val) {}


        // Field Enumerations
        public const int NO_ACKNOWLEDGEMENT = 0;
        public const int ACKNOWLEDGE_ONLY_NEGATIVE_OR_ERRONEOUS_QUOTES = 1;
        public const int ACKNOWLEDGE_EACH_QUOTE_MESSAGE = 2;
        public const int SUMMARY_ACKNOWLEDGEMENT = 3;
        public const int ACKNOWLEDGE_EACH_QUOTE_MESSAGES = 2;
    }


    /// <summary>
    /// QuoteSetID Field
    /// </summary>/
    public sealed class QuoteSetID : StringField
    {
        public const int TAG = 302;

        public QuoteSetID()
            :base(Tags.QuoteSetID) {}
        public QuoteSetID(string val)
            :base(Tags.QuoteSetID, val) {}

    }


    /// <summary>
    /// QuoteRequestType Field
    /// </summary>/
    public sealed class QuoteRequestType : IntField
    {
        public const int TAG = 303;

        public QuoteRequestType()
            :base(Tags.QuoteRequestType) {}
        public QuoteRequestType(int val)
            :base(Tags.QuoteRequestType, val) {}


        // Field Enumerations
        public const int MANUAL = 1;
        public const int AUTOMATIC = 2;
    }


    /// <summary>
    /// TotQuoteEntries Field
    /// </summary>/
    public sealed class TotQuoteEntries : IntField
    {
        public const int TAG = 304;

        public TotQuoteEntries()
            :base(Tags.TotQuoteEntries) {}
        public TotQuoteEntries(int val)
            :base(Tags.TotQuoteEntries, val) {}

    }


    /// <summary>
    /// UnderlyingIDSource Field
    /// </summary>/
    public sealed class UnderlyingIDSource : StringField
    {
        public const int TAG = 305;

        public UnderlyingIDSource()
            :base(Tags.UnderlyingIDSource) {}
        public UnderlyingIDSource(string val)
            :base(Tags.UnderlyingIDSource, val) {}

    }


    /// <summary>
    /// UnderlyingIssuer Field
    /// </summary>/
    public sealed class UnderlyingIssuer : StringField
    {
        public const int TAG = 306;

        public UnderlyingIssuer()
            :base(Tags.UnderlyingIssuer) {}
        public UnderlyingIssuer(string val)
            :base(Tags.UnderlyingIssuer, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityDesc Field
    /// </summary>/
    public sealed class UnderlyingSecurityDesc : StringField
    {
        public const int TAG = 307;

        public UnderlyingSecurityDesc()
            :base(Tags.UnderlyingSecurityDesc) {}
        public UnderlyingSecurityDesc(string val)
            :base(Tags.UnderlyingSecurityDesc, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityExchange Field
    /// </summary>/
    public sealed class UnderlyingSecurityExchange : StringField
    {
        public const int TAG = 308;

        public UnderlyingSecurityExchange()
            :base(Tags.UnderlyingSecurityExchange) {}
        public UnderlyingSecurityExchange(string val)
            :base(Tags.UnderlyingSecurityExchange, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityID Field
    /// </summary>/
    public sealed class UnderlyingSecurityID : StringField
    {
        public const int TAG = 309;

        public UnderlyingSecurityID()
            :base(Tags.UnderlyingSecurityID) {}
        public UnderlyingSecurityID(string val)
            :base(Tags.UnderlyingSecurityID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityType Field
    /// </summary>/
    public sealed class UnderlyingSecurityType : StringField
    {
        public const int TAG = 310;

        public UnderlyingSecurityType()
            :base(Tags.UnderlyingSecurityType) {}
        public UnderlyingSecurityType(string val)
            :base(Tags.UnderlyingSecurityType, val) {}

    }


    /// <summary>
    /// UnderlyingSymbol Field
    /// </summary>/
    public sealed class UnderlyingSymbol : StringField
    {
        public const int TAG = 311;

        public UnderlyingSymbol()
            :base(Tags.UnderlyingSymbol) {}
        public UnderlyingSymbol(string val)
            :base(Tags.UnderlyingSymbol, val) {}

    }


    /// <summary>
    /// UnderlyingSymbolSfx Field
    /// </summary>/
    public sealed class UnderlyingSymbolSfx : StringField
    {
        public const int TAG = 312;

        public UnderlyingSymbolSfx()
            :base(Tags.UnderlyingSymbolSfx) {}
        public UnderlyingSymbolSfx(string val)
            :base(Tags.UnderlyingSymbolSfx, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityMonthYear Field
    /// </summary>/
    public sealed class UnderlyingMaturityMonthYear : StringField
    {
        public const int TAG = 313;

        public UnderlyingMaturityMonthYear()
            :base(Tags.UnderlyingMaturityMonthYear) {}
        public UnderlyingMaturityMonthYear(string val)
            :base(Tags.UnderlyingMaturityMonthYear, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityDay Field
    /// </summary>/
    public sealed class UnderlyingMaturityDay : StringField
    {
        public const int TAG = 314;

        public UnderlyingMaturityDay()
            :base(Tags.UnderlyingMaturityDay) {}
        public UnderlyingMaturityDay(string val)
            :base(Tags.UnderlyingMaturityDay, val) {}

    }


    /// <summary>
    /// UnderlyingPutOrCall Field
    /// </summary>/
    public sealed class UnderlyingPutOrCall : IntField
    {
        public const int TAG = 315;

        public UnderlyingPutOrCall()
            :base(Tags.UnderlyingPutOrCall) {}
        public UnderlyingPutOrCall(int val)
            :base(Tags.UnderlyingPutOrCall, val) {}


        // Field Enumerations
        public const int PUT = 0;
        public const int CALL = 1;
    }


    /// <summary>
    /// UnderlyingStrikePrice Field
    /// </summary>/
    public sealed class UnderlyingStrikePrice : DecimalField
    {
        public const int TAG = 316;

        public UnderlyingStrikePrice()
            :base(Tags.UnderlyingStrikePrice) {}
        public UnderlyingStrikePrice(Decimal val)
            :base(Tags.UnderlyingStrikePrice, val) {}

    }


    /// <summary>
    /// UnderlyingOptAttribute Field
    /// </summary>/
    public sealed class UnderlyingOptAttribute : CharField
    {
        public const int TAG = 317;

        public UnderlyingOptAttribute()
            :base(Tags.UnderlyingOptAttribute) {}
        public UnderlyingOptAttribute(char val)
            :base(Tags.UnderlyingOptAttribute, val) {}

    }


    /// <summary>
    /// UnderlyingCurrency Field
    /// </summary>/
    public sealed class UnderlyingCurrency : StringField
    {
        public const int TAG = 318;

        public UnderlyingCurrency()
            :base(Tags.UnderlyingCurrency) {}
        public UnderlyingCurrency(string val)
            :base(Tags.UnderlyingCurrency, val) {}

    }


    /// <summary>
    /// RatioQty Field
    /// </summary>/
    public sealed class RatioQty : DecimalField
    {
        public const int TAG = 319;

        public RatioQty()
            :base(Tags.RatioQty) {}
        public RatioQty(Decimal val)
            :base(Tags.RatioQty, val) {}

    }


    /// <summary>
    /// SecurityReqID Field
    /// </summary>/
    public sealed class SecurityReqID : StringField
    {
        public const int TAG = 320;

        public SecurityReqID()
            :base(Tags.SecurityReqID) {}
        public SecurityReqID(string val)
            :base(Tags.SecurityReqID, val) {}

    }


    /// <summary>
    /// SecurityRequestType Field
    /// </summary>/
    public sealed class SecurityRequestType : IntField
    {
        public const int TAG = 321;

        public SecurityRequestType()
            :base(Tags.SecurityRequestType) {}
        public SecurityRequestType(int val)
            :base(Tags.SecurityRequestType, val) {}


        // Field Enumerations
        public const int REQUEST_SECURITY_IDENTITY_AND_SPECIFICATIONS = 0;
        public const int REQUEST_SECURITY_IDENTITY_FOR_THE_SPECIFICATIONS_PROVIDED = 1;
        public const int REQUEST_LIST_SECURITY_TYPES = 2;
        public const int REQUEST_LIST_SECURITIES = 3;
        public const int SYMBOL = 4;
        public const int SECURITYTYPE_AND_OR_CFICODE = 5;
        public const int PRODUCT = 6;
        public const int TRADINGSESSIONID = 7;
        public const int ALL_SECURITIES = 8;
        public const int MARKETID_OR_MARKETID_PLUS_MARKETSEGMENTID = 9;
    }


    /// <summary>
    /// SecurityResponseID Field
    /// </summary>/
    public sealed class SecurityResponseID : StringField
    {
        public const int TAG = 322;

        public SecurityResponseID()
            :base(Tags.SecurityResponseID) {}
        public SecurityResponseID(string val)
            :base(Tags.SecurityResponseID, val) {}

    }


    /// <summary>
    /// SecurityResponseType Field
    /// </summary>/
    public sealed class SecurityResponseType : IntField
    {
        public const int TAG = 323;

        public SecurityResponseType()
            :base(Tags.SecurityResponseType) {}
        public SecurityResponseType(int val)
            :base(Tags.SecurityResponseType, val) {}


        // Field Enumerations
        public const int ACCEPT_SECURITY_PROPOSAL_AS_IS = 1;
        public const int ACCEPT_SECURITY_PROPOSAL_WITH_REVISIONS_AS_INDICATED_IN_THE_MESSAGE = 2;
        public const int LIST_OF_SECURITY_TYPES_RETURNED_PER_REQUEST = 3;
        public const int LIST_OF_SECURITIES_RETURNED_PER_REQUEST = 4;
        public const int REJECT_SECURITY_PROPOSAL = 5;
        public const int CANNOT_MATCH_SELECTION_CRITERIA = 6;
        public const int CAN_NOT_MATCH_SELECTION_CRITERIA = 6;
    }


    /// <summary>
    /// SecurityStatusReqID Field
    /// </summary>/
    public sealed class SecurityStatusReqID : StringField
    {
        public const int TAG = 324;

        public SecurityStatusReqID()
            :base(Tags.SecurityStatusReqID) {}
        public SecurityStatusReqID(string val)
            :base(Tags.SecurityStatusReqID, val) {}

    }


    /// <summary>
    /// UnsolicitedIndicator Field
    /// </summary>/
    public sealed class UnsolicitedIndicator : BooleanField
    {
        public const int TAG = 325;

        public UnsolicitedIndicator()
            :base(Tags.UnsolicitedIndicator) {}
        public UnsolicitedIndicator(Boolean val)
            :base(Tags.UnsolicitedIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean MESSAGE_IS_BEING_SENT_UNSOLICITED = true;
        public const Boolean MESSAGE_IS_BEING_SENT_AS_A_RESULT_OF_A_PRIOR_REQUEST = false;
    }


    /// <summary>
    /// SecurityTradingStatus Field
    /// </summary>/
    public sealed class SecurityTradingStatus : IntField
    {
        public const int TAG = 326;

        public SecurityTradingStatus()
            :base(Tags.SecurityTradingStatus) {}
        public SecurityTradingStatus(int val)
            :base(Tags.SecurityTradingStatus, val) {}


        // Field Enumerations
        public const int OPENING_DELAY = 1;
        public const int MARKET_ON_CLOSE_IMBALANCE_SELL = 10;
        public const int VAL_11 = 11;
        public const int NO_MARKET_IMBALANCE = 12;
        public const int NO_MARKET_ON_CLOSE_IMBALANCE = 13;
        public const int ITS_PRE_OPENING = 14;
        public const int NEW_PRICE_INDICATION = 15;
        public const int TRADE_DISSEMINATION_TIME = 16;
        public const int READY_TO_TRADE = 17;
        public const int NOT_AVAILABLE_FOR_TRADING = 18;
        public const int NOT_TRADED_ON_THIS_MARKET = 19;
        public const int TRADING_HALT = 2;
        public const int UNKNOWN_OR_INVALID = 20;
        public const int PRE_OPEN = 21;
        public const int OPENING_ROTATION = 22;
        public const int FAST_MARKET = 23;
        public const int RESUME = 3;
        public const int NO_OPEN = 4;
        public const int PRICE_INDICATION = 5;
        public const int TRADING_RANGE_INDICATION = 6;
        public const int MARKET_IMBALANCE_BUY = 7;
        public const int MARKET_IMBALANCE_SELL = 8;
        public const int MARKET_ON_CLOSE_IMBALANCE_BUY = 9;
        public const int PRE_CROSS = 24;
        public const int CROSS = 25;
        public const int POST_CLOSE = 26;
        public const int NO_OPEN_NO_RESUME = 4;
        public const int NOT_ASSIGNED = 11;
        public const int READY_TO_TRADE_START_OF_SESSION = 17;
        public const int NOT_AVAILABLE_FOR_TRADING_END_OF_SESSION = 18;
        public const int NO_OPENNO_RESUME = 4;
        public const int ITS_PREOPENING = 14;
    }


    /// <summary>
    /// HaltReason Field
    /// </summary>/
    public sealed class HaltReason : CharField
    {
        public const int TAG = 327;

        public HaltReason()
            :base(Tags.HaltReason) {}
        public HaltReason(char val)
            :base(Tags.HaltReason, val) {}


        // Field Enumerations
        public const char ORDER_IMBALANCE = 'I';
        public const char EQUIPMENT_CHANGEOVER = 'X';
        public const char NEWS_PENDING = 'P';
        public const char NEWS_DISSEMINATION = 'D';
        public const char ORDER_INFLUX = 'E';
        public const char ADDITIONAL_INFORMATION = 'M';
    }


    /// <summary>
    /// InViewOfCommon Field
    /// </summary>/
    public sealed class InViewOfCommon : BooleanField
    {
        public const int TAG = 328;

        public InViewOfCommon()
            :base(Tags.InViewOfCommon) {}
        public InViewOfCommon(Boolean val)
            :base(Tags.InViewOfCommon, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean HALT_WAS_DUE_TO_COMMON_STOCK_BEING_HALTED = true;
        public const Boolean HALT_WAS_NOT_RELATED_TO_A_HALT_OF_THE_COMMON_STOCK = false;
    }


    /// <summary>
    /// DueToRelated Field
    /// </summary>/
    public sealed class DueToRelated : BooleanField
    {
        public const int TAG = 329;

        public DueToRelated()
            :base(Tags.DueToRelated) {}
        public DueToRelated(Boolean val)
            :base(Tags.DueToRelated, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean HALT_WAS_DUE_TO_RELATED_SECURITY_BEING_HALTED = true;
        public const Boolean HALT_WAS_NOT_RELATED_TO_A_HALT_OF_THE_RELATED_SECURITY = false;
    }


    /// <summary>
    /// BuyVolume Field
    /// </summary>/
    public sealed class BuyVolume : DecimalField
    {
        public const int TAG = 330;

        public BuyVolume()
            :base(Tags.BuyVolume) {}
        public BuyVolume(Decimal val)
            :base(Tags.BuyVolume, val) {}

    }


    /// <summary>
    /// SellVolume Field
    /// </summary>/
    public sealed class SellVolume : DecimalField
    {
        public const int TAG = 331;

        public SellVolume()
            :base(Tags.SellVolume) {}
        public SellVolume(Decimal val)
            :base(Tags.SellVolume, val) {}

    }


    /// <summary>
    /// HighPx Field
    /// </summary>/
    public sealed class HighPx : DecimalField
    {
        public const int TAG = 332;

        public HighPx()
            :base(Tags.HighPx) {}
        public HighPx(Decimal val)
            :base(Tags.HighPx, val) {}

    }


    /// <summary>
    /// LowPx Field
    /// </summary>/
    public sealed class LowPx : DecimalField
    {
        public const int TAG = 333;

        public LowPx()
            :base(Tags.LowPx) {}
        public LowPx(Decimal val)
            :base(Tags.LowPx, val) {}

    }


    /// <summary>
    /// Adjustment Field
    /// </summary>/
    public sealed class Adjustment : IntField
    {
        public const int TAG = 334;

        public Adjustment()
            :base(Tags.Adjustment) {}
        public Adjustment(int val)
            :base(Tags.Adjustment, val) {}


        // Field Enumerations
        public const int CANCEL = 1;
        public const int ERROR = 2;
        public const int CORRECTION = 3;
    }


    /// <summary>
    /// TradSesReqID Field
    /// </summary>/
    public sealed class TradSesReqID : StringField
    {
        public const int TAG = 335;

        public TradSesReqID()
            :base(Tags.TradSesReqID) {}
        public TradSesReqID(string val)
            :base(Tags.TradSesReqID, val) {}

    }


    /// <summary>
    /// TradingSessionID Field
    /// </summary>/
    public sealed class TradingSessionID : StringField
    {
        public const int TAG = 336;

        public TradingSessionID()
            :base(Tags.TradingSessionID) {}
        public TradingSessionID(string val)
            :base(Tags.TradingSessionID, val) {}


        // Field Enumerations
        public const string DAY = "1";
        public const string HALFDAY = "2";
        public const string MORNING = "3";
        public const string AFTERNOON = "4";
        public const string EVENING = "5";
        public const string AFTER_HOURS = "6";
    }


    /// <summary>
    /// ContraTrader Field
    /// </summary>/
    public sealed class ContraTrader : StringField
    {
        public const int TAG = 337;

        public ContraTrader()
            :base(Tags.ContraTrader) {}
        public ContraTrader(string val)
            :base(Tags.ContraTrader, val) {}

    }


    /// <summary>
    /// TradSesMethod Field
    /// </summary>/
    public sealed class TradSesMethod : IntField
    {
        public const int TAG = 338;

        public TradSesMethod()
            :base(Tags.TradSesMethod) {}
        public TradSesMethod(int val)
            :base(Tags.TradSesMethod, val) {}


        // Field Enumerations
        public const int ELECTRONIC = 1;
        public const int OPEN_OUTCRY = 2;
        public const int TWO_PARTY = 3;
    }


    /// <summary>
    /// TradSesMode Field
    /// </summary>/
    public sealed class TradSesMode : IntField
    {
        public const int TAG = 339;

        public TradSesMode()
            :base(Tags.TradSesMode) {}
        public TradSesMode(int val)
            :base(Tags.TradSesMode, val) {}


        // Field Enumerations
        public const int TESTING = 1;
        public const int SIMULATED = 2;
        public const int PRODUCTION = 3;
    }


    /// <summary>
    /// TradSesStatus Field
    /// </summary>/
    public sealed class TradSesStatus : IntField
    {
        public const int TAG = 340;

        public TradSesStatus()
            :base(Tags.TradSesStatus) {}
        public TradSesStatus(int val)
            :base(Tags.TradSesStatus, val) {}


        // Field Enumerations
        public const int UNKNOWN = 0;
        public const int HALTED = 1;
        public const int OPEN = 2;
        public const int CLOSED = 3;
        public const int PRE_OPEN = 4;
        public const int PRE_CLOSE = 5;
        public const int REQUEST_REJECTED = 6;
        public const int PREOPEN = 4;
        public const int PRECLOSE = 5;
    }


    /// <summary>
    /// TradSesStartTime Field
    /// </summary>/
    public sealed class TradSesStartTime : DateTimeField
    {
        public const int TAG = 341;

        public TradSesStartTime()
            :base(Tags.TradSesStartTime) {}
        public TradSesStartTime(DateTime val)
            :base(Tags.TradSesStartTime, val) {}
        public TradSesStartTime(DateTime val, bool showMilliseconds)
            :base(Tags.TradSesStartTime, val, showMilliseconds) {}
		public TradSesStartTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TradSesStartTime, val, precision) {}

    }


    /// <summary>
    /// TradSesOpenTime Field
    /// </summary>/
    public sealed class TradSesOpenTime : DateTimeField
    {
        public const int TAG = 342;

        public TradSesOpenTime()
            :base(Tags.TradSesOpenTime) {}
        public TradSesOpenTime(DateTime val)
            :base(Tags.TradSesOpenTime, val) {}
        public TradSesOpenTime(DateTime val, bool showMilliseconds)
            :base(Tags.TradSesOpenTime, val, showMilliseconds) {}
		public TradSesOpenTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TradSesOpenTime, val, precision) {}

    }


    /// <summary>
    /// TradSesPreCloseTime Field
    /// </summary>/
    public sealed class TradSesPreCloseTime : DateTimeField
    {
        public const int TAG = 343;

        public TradSesPreCloseTime()
            :base(Tags.TradSesPreCloseTime) {}
        public TradSesPreCloseTime(DateTime val)
            :base(Tags.TradSesPreCloseTime, val) {}
        public TradSesPreCloseTime(DateTime val, bool showMilliseconds)
            :base(Tags.TradSesPreCloseTime, val, showMilliseconds) {}
		public TradSesPreCloseTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TradSesPreCloseTime, val, precision) {}

    }


    /// <summary>
    /// TradSesCloseTime Field
    /// </summary>/
    public sealed class TradSesCloseTime : DateTimeField
    {
        public const int TAG = 344;

        public TradSesCloseTime()
            :base(Tags.TradSesCloseTime) {}
        public TradSesCloseTime(DateTime val)
            :base(Tags.TradSesCloseTime, val) {}
        public TradSesCloseTime(DateTime val, bool showMilliseconds)
            :base(Tags.TradSesCloseTime, val, showMilliseconds) {}
		public TradSesCloseTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TradSesCloseTime, val, precision) {}

    }


    /// <summary>
    /// TradSesEndTime Field
    /// </summary>/
    public sealed class TradSesEndTime : DateTimeField
    {
        public const int TAG = 345;

        public TradSesEndTime()
            :base(Tags.TradSesEndTime) {}
        public TradSesEndTime(DateTime val)
            :base(Tags.TradSesEndTime, val) {}
        public TradSesEndTime(DateTime val, bool showMilliseconds)
            :base(Tags.TradSesEndTime, val, showMilliseconds) {}
		public TradSesEndTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TradSesEndTime, val, precision) {}

    }


    /// <summary>
    /// NumberOfOrders Field
    /// </summary>/
    public sealed class NumberOfOrders : IntField
    {
        public const int TAG = 346;

        public NumberOfOrders()
            :base(Tags.NumberOfOrders) {}
        public NumberOfOrders(int val)
            :base(Tags.NumberOfOrders, val) {}

    }


    /// <summary>
    /// MessageEncoding Field
    /// </summary>/
    public sealed class MessageEncoding : StringField
    {
        public const int TAG = 347;

        public MessageEncoding()
            :base(Tags.MessageEncoding) {}
        public MessageEncoding(string val)
            :base(Tags.MessageEncoding, val) {}


        // Field Enumerations
        public const string ISO_2022_JP = "ISO-2022-JP";
        public const string EUC_JP = "EUC-JP";
        public const string SHIFT_JIS = "SHIFT_JIS";
        public const string UTF_8 = "UTF-8";
    }


    /// <summary>
    /// EncodedIssuerLen Field
    /// </summary>/
    public sealed class EncodedIssuerLen : IntField
    {
        public const int TAG = 348;

        public EncodedIssuerLen()
            :base(Tags.EncodedIssuerLen) {}
        public EncodedIssuerLen(int val)
            :base(Tags.EncodedIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedIssuer Field
    /// </summary>/
    public sealed class EncodedIssuer : StringField
    {
        public const int TAG = 349;

        public EncodedIssuer()
            :base(Tags.EncodedIssuer) {}
        public EncodedIssuer(string val)
            :base(Tags.EncodedIssuer, val) {}

    }


    /// <summary>
    /// EncodedSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedSecurityDescLen : IntField
    {
        public const int TAG = 350;

        public EncodedSecurityDescLen()
            :base(Tags.EncodedSecurityDescLen) {}
        public EncodedSecurityDescLen(int val)
            :base(Tags.EncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedSecurityDesc Field
    /// </summary>/
    public sealed class EncodedSecurityDesc : StringField
    {
        public const int TAG = 351;

        public EncodedSecurityDesc()
            :base(Tags.EncodedSecurityDesc) {}
        public EncodedSecurityDesc(string val)
            :base(Tags.EncodedSecurityDesc, val) {}

    }


    /// <summary>
    /// EncodedListExecInstLen Field
    /// </summary>/
    public sealed class EncodedListExecInstLen : IntField
    {
        public const int TAG = 352;

        public EncodedListExecInstLen()
            :base(Tags.EncodedListExecInstLen) {}
        public EncodedListExecInstLen(int val)
            :base(Tags.EncodedListExecInstLen, val) {}

    }


    /// <summary>
    /// EncodedListExecInst Field
    /// </summary>/
    public sealed class EncodedListExecInst : StringField
    {
        public const int TAG = 353;

        public EncodedListExecInst()
            :base(Tags.EncodedListExecInst) {}
        public EncodedListExecInst(string val)
            :base(Tags.EncodedListExecInst, val) {}

    }


    /// <summary>
    /// EncodedTextLen Field
    /// </summary>/
    public sealed class EncodedTextLen : IntField
    {
        public const int TAG = 354;

        public EncodedTextLen()
            :base(Tags.EncodedTextLen) {}
        public EncodedTextLen(int val)
            :base(Tags.EncodedTextLen, val) {}

    }


    /// <summary>
    /// EncodedText Field
    /// </summary>/
    public sealed class EncodedText : StringField
    {
        public const int TAG = 355;

        public EncodedText()
            :base(Tags.EncodedText) {}
        public EncodedText(string val)
            :base(Tags.EncodedText, val) {}

    }


    /// <summary>
    /// EncodedSubjectLen Field
    /// </summary>/
    public sealed class EncodedSubjectLen : IntField
    {
        public const int TAG = 356;

        public EncodedSubjectLen()
            :base(Tags.EncodedSubjectLen) {}
        public EncodedSubjectLen(int val)
            :base(Tags.EncodedSubjectLen, val) {}

    }


    /// <summary>
    /// EncodedSubject Field
    /// </summary>/
    public sealed class EncodedSubject : StringField
    {
        public const int TAG = 357;

        public EncodedSubject()
            :base(Tags.EncodedSubject) {}
        public EncodedSubject(string val)
            :base(Tags.EncodedSubject, val) {}

    }


    /// <summary>
    /// EncodedHeadlineLen Field
    /// </summary>/
    public sealed class EncodedHeadlineLen : IntField
    {
        public const int TAG = 358;

        public EncodedHeadlineLen()
            :base(Tags.EncodedHeadlineLen) {}
        public EncodedHeadlineLen(int val)
            :base(Tags.EncodedHeadlineLen, val) {}

    }


    /// <summary>
    /// EncodedHeadline Field
    /// </summary>/
    public sealed class EncodedHeadline : StringField
    {
        public const int TAG = 359;

        public EncodedHeadline()
            :base(Tags.EncodedHeadline) {}
        public EncodedHeadline(string val)
            :base(Tags.EncodedHeadline, val) {}

    }


    /// <summary>
    /// EncodedAllocTextLen Field
    /// </summary>/
    public sealed class EncodedAllocTextLen : IntField
    {
        public const int TAG = 360;

        public EncodedAllocTextLen()
            :base(Tags.EncodedAllocTextLen) {}
        public EncodedAllocTextLen(int val)
            :base(Tags.EncodedAllocTextLen, val) {}

    }


    /// <summary>
    /// EncodedAllocText Field
    /// </summary>/
    public sealed class EncodedAllocText : StringField
    {
        public const int TAG = 361;

        public EncodedAllocText()
            :base(Tags.EncodedAllocText) {}
        public EncodedAllocText(string val)
            :base(Tags.EncodedAllocText, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingIssuerLen Field
    /// </summary>/
    public sealed class EncodedUnderlyingIssuerLen : IntField
    {
        public const int TAG = 362;

        public EncodedUnderlyingIssuerLen()
            :base(Tags.EncodedUnderlyingIssuerLen) {}
        public EncodedUnderlyingIssuerLen(int val)
            :base(Tags.EncodedUnderlyingIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingIssuer Field
    /// </summary>/
    public sealed class EncodedUnderlyingIssuer : StringField
    {
        public const int TAG = 363;

        public EncodedUnderlyingIssuer()
            :base(Tags.EncodedUnderlyingIssuer) {}
        public EncodedUnderlyingIssuer(string val)
            :base(Tags.EncodedUnderlyingIssuer, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedUnderlyingSecurityDescLen : IntField
    {
        public const int TAG = 364;

        public EncodedUnderlyingSecurityDescLen()
            :base(Tags.EncodedUnderlyingSecurityDescLen) {}
        public EncodedUnderlyingSecurityDescLen(int val)
            :base(Tags.EncodedUnderlyingSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedUnderlyingSecurityDesc Field
    /// </summary>/
    public sealed class EncodedUnderlyingSecurityDesc : StringField
    {
        public const int TAG = 365;

        public EncodedUnderlyingSecurityDesc()
            :base(Tags.EncodedUnderlyingSecurityDesc) {}
        public EncodedUnderlyingSecurityDesc(string val)
            :base(Tags.EncodedUnderlyingSecurityDesc, val) {}

    }


    /// <summary>
    /// AllocPrice Field
    /// </summary>/
    public sealed class AllocPrice : DecimalField
    {
        public const int TAG = 366;

        public AllocPrice()
            :base(Tags.AllocPrice) {}
        public AllocPrice(Decimal val)
            :base(Tags.AllocPrice, val) {}

    }


    /// <summary>
    /// QuoteSetValidUntilTime Field
    /// </summary>/
    public sealed class QuoteSetValidUntilTime : DateTimeField
    {
        public const int TAG = 367;

        public QuoteSetValidUntilTime()
            :base(Tags.QuoteSetValidUntilTime) {}
        public QuoteSetValidUntilTime(DateTime val)
            :base(Tags.QuoteSetValidUntilTime, val) {}
        public QuoteSetValidUntilTime(DateTime val, bool showMilliseconds)
            :base(Tags.QuoteSetValidUntilTime, val, showMilliseconds) {}
		public QuoteSetValidUntilTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.QuoteSetValidUntilTime, val, precision) {}

    }


    /// <summary>
    /// QuoteEntryRejectReason Field
    /// </summary>/
    public sealed class QuoteEntryRejectReason : IntField
    {
        public const int TAG = 368;

        public QuoteEntryRejectReason()
            :base(Tags.QuoteEntryRejectReason) {}
        public QuoteEntryRejectReason(int val)
            :base(Tags.QuoteEntryRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int EXHCNAGE = 2;
        public const int QUOTE_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_QUOTE = 5;
        public const int DUPLICATE_QUOTE = 6;
        public const int INVALID_BID_ASK_SPREAD = 7;
        public const int INVALID_PRICE = 8;
        public const int NOT_AUTHORIZED_TO_QUOTE_SECURITY = 9;
        public const int OTHER = 99;
        public const int EXCHANGE_CLOSED = 2;
        public const int EXCHANGE = 2;
        public const int INVALID_BID = 7;
        public const int INVALID_BIDASK_SPREAD = 7;
    }


    /// <summary>
    /// LastMsgSeqNumProcessed Field
    /// </summary>/
    public sealed class LastMsgSeqNumProcessed : IntField
    {
        public const int TAG = 369;

        public LastMsgSeqNumProcessed()
            :base(Tags.LastMsgSeqNumProcessed) {}
        public LastMsgSeqNumProcessed(int val)
            :base(Tags.LastMsgSeqNumProcessed, val) {}

    }


    /// <summary>
    /// OnBehalfOfSendingTime Field
    /// </summary>/
    public sealed class OnBehalfOfSendingTime : DateTimeField
    {
        public const int TAG = 370;

        public OnBehalfOfSendingTime()
            :base(Tags.OnBehalfOfSendingTime) {}
        public OnBehalfOfSendingTime(DateTime val)
            :base(Tags.OnBehalfOfSendingTime, val) {}
        public OnBehalfOfSendingTime(DateTime val, bool showMilliseconds)
            :base(Tags.OnBehalfOfSendingTime, val, showMilliseconds) {}
		public OnBehalfOfSendingTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.OnBehalfOfSendingTime, val, precision) {}

    }


    /// <summary>
    /// RefTagID Field
    /// </summary>/
    public sealed class RefTagID : IntField
    {
        public const int TAG = 371;

        public RefTagID()
            :base(Tags.RefTagID) {}
        public RefTagID(int val)
            :base(Tags.RefTagID, val) {}

    }


    /// <summary>
    /// RefMsgType Field
    /// </summary>/
    public sealed class RefMsgType : StringField
    {
        public const int TAG = 372;

        public RefMsgType()
            :base(Tags.RefMsgType) {}
        public RefMsgType(string val)
            :base(Tags.RefMsgType, val) {}

    }


    /// <summary>
    /// SessionRejectReason Field
    /// </summary>/
    public sealed class SessionRejectReason : IntField
    {
        public const int TAG = 373;

        public SessionRejectReason()
            :base(Tags.SessionRejectReason) {}
        public SessionRejectReason(int val)
            :base(Tags.SessionRejectReason, val) {}


        // Field Enumerations
        public const int INVALID_TAG_NUMBER = 0;
        public const int REQUIRED_TAG_MISSING = 1;
        public const int SENDINGTIME_ACCURACY_PROBLEM = 10;
        public const int INVALID_MSGTYPE = 11;
        public const int XML_VALIDATION_ERROR = 12;
        public const int TAG_APPEARS_MORE_THAN_ONCE = 13;
        public const int TAG_SPECIFIED_OUT_OF_REQUIRED_ORDER = 14;
        public const int REPEATING_GROUP_FIELDS_OUT_OF_ORDER = 15;
        public const int INCORRECT_NUMINGROUP_COUNT_FOR_REPEATING_GROUP = 16;
        public const int NON_DATA_VALUE_INCLUDES_FIELD_DELIMITER = 17;
        public const int TAG_NOT_DEFINED_FOR_THIS_MESSAGE_TYPE = 2;
        public const int UNDEFINED_TAG = 3;
        public const int TAG_SPECIFIED_WITHOUT_A_VALUE = 4;
        public const int VALUE_IS_INCORRECT = 5;
        public const int INCORRECT_DATA_FORMAT_FOR_VALUE = 6;
        public const int DECRYPTION_PROBLEM = 7;
        public const int SIGNATURE_PROBLEM = 8;
        public const int COMPID_PROBLEM = 9;
        public const int OTHER = 99;
        public const int INVALID_UNSUPPORTED_APPLICATION_VERSION = 18;
        public const int E = 11;
    }


    /// <summary>
    /// BidRequestTransType Field
    /// </summary>/
    public sealed class BidRequestTransType : CharField
    {
        public const int TAG = 374;

        public BidRequestTransType()
            :base(Tags.BidRequestTransType) {}
        public BidRequestTransType(char val)
            :base(Tags.BidRequestTransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NO = 'N';
        public const char NEW = 'N';
    }


    /// <summary>
    /// ContraBroker Field
    /// </summary>/
    public sealed class ContraBroker : StringField
    {
        public const int TAG = 375;

        public ContraBroker()
            :base(Tags.ContraBroker) {}
        public ContraBroker(string val)
            :base(Tags.ContraBroker, val) {}

    }


    /// <summary>
    /// ComplianceID Field
    /// </summary>/
    public sealed class ComplianceID : StringField
    {
        public const int TAG = 376;

        public ComplianceID()
            :base(Tags.ComplianceID) {}
        public ComplianceID(string val)
            :base(Tags.ComplianceID, val) {}

    }


    /// <summary>
    /// SolicitedFlag Field
    /// </summary>/
    public sealed class SolicitedFlag : BooleanField
    {
        public const int TAG = 377;

        public SolicitedFlag()
            :base(Tags.SolicitedFlag) {}
        public SolicitedFlag(Boolean val)
            :base(Tags.SolicitedFlag, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean WAS_SOLCITIED = true;
        public const Boolean WAS_NOT_SOLICITED = false;
    }


    /// <summary>
    /// ExecRestatementReason Field
    /// </summary>/
    public sealed class ExecRestatementReason : IntField
    {
        public const int TAG = 378;

        public ExecRestatementReason()
            :base(Tags.ExecRestatementReason) {}
        public ExecRestatementReason(int val)
            :base(Tags.ExecRestatementReason, val) {}


        // Field Enumerations
        public const int GT_CORPORATE_ACTION = 0;
        public const int GT_RENEWAL = 1;
        public const int WAREHOUSE_RECAP = 10;
        public const int VERBAL_CHANGE = 2;
        public const int REPRICING_OF_ORDER = 3;
        public const int BROKER_OPTION = 4;
        public const int PARTIAL_DECLINE_OF_ORDERQTY = 5;
        public const int CANCEL_ON_TRADING_HALT = 6;
        public const int CANCEL_ON_SYSTEM_FAILURE = 7;
        public const int MARKET = 8;
        public const int CANCELED_NOT_BEST = 9;
        public const int OTHER = 99;
        public const int PEG_REFRESH = 11;
        public const int GT_RENEWAL_RESTATEMENT = 1;
        public const int MARKET_OPTION = 8;
    }


    /// <summary>
    /// BusinessRejectRefID Field
    /// </summary>/
    public sealed class BusinessRejectRefID : StringField
    {
        public const int TAG = 379;

        public BusinessRejectRefID()
            :base(Tags.BusinessRejectRefID) {}
        public BusinessRejectRefID(string val)
            :base(Tags.BusinessRejectRefID, val) {}

    }


    /// <summary>
    /// BusinessRejectReason Field
    /// </summary>/
    public sealed class BusinessRejectReason : IntField
    {
        public const int TAG = 380;

        public BusinessRejectReason()
            :base(Tags.BusinessRejectReason) {}
        public BusinessRejectReason(int val)
            :base(Tags.BusinessRejectReason, val) {}


        // Field Enumerations
        public const int OTHER = 0;
        public const int UNKNOWN_ID = 1;
        public const int UNKNOWN_SECURITY = 2;
        public const int UNSUPPORTED_MESSAGE_TYPE = 3;
        public const int APPLICATION_NOT_AVAILABLE = 4;
        public const int CONDITIONALLY_REQUIRED_FIELD_MISSING = 5;
        public const int NOT_AUTHORIZED = 6;
        public const int DELIVERTO_FIRM_NOT_AVAILABLE_AT_THIS_TIME = 7;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int UNKNOWN_MESSAGE_TYPE = 3;
        public const int UNKOWN_ID = 1;
    }


    /// <summary>
    /// GrossTradeAmt Field
    /// </summary>/
    public sealed class GrossTradeAmt : DecimalField
    {
        public const int TAG = 381;

        public GrossTradeAmt()
            :base(Tags.GrossTradeAmt) {}
        public GrossTradeAmt(Decimal val)
            :base(Tags.GrossTradeAmt, val) {}

    }


    /// <summary>
    /// NoContraBrokers Field
    /// </summary>/
    public sealed class NoContraBrokers : IntField
    {
        public const int TAG = 382;

        public NoContraBrokers()
            :base(Tags.NoContraBrokers) {}
        public NoContraBrokers(int val)
            :base(Tags.NoContraBrokers, val) {}

    }


    /// <summary>
    /// MaxMessageSize Field
    /// </summary>/
    public sealed class MaxMessageSize : IntField
    {
        public const int TAG = 383;

        public MaxMessageSize()
            :base(Tags.MaxMessageSize) {}
        public MaxMessageSize(int val)
            :base(Tags.MaxMessageSize, val) {}

    }


    /// <summary>
    /// NoMsgTypes Field
    /// </summary>/
    public sealed class NoMsgTypes : IntField
    {
        public const int TAG = 384;

        public NoMsgTypes()
            :base(Tags.NoMsgTypes) {}
        public NoMsgTypes(int val)
            :base(Tags.NoMsgTypes, val) {}

    }


    /// <summary>
    /// MsgDirection Field
    /// </summary>/
    public sealed class MsgDirection : CharField
    {
        public const int TAG = 385;

        public MsgDirection()
            :base(Tags.MsgDirection) {}
        public MsgDirection(char val)
            :base(Tags.MsgDirection, val) {}


        // Field Enumerations
        public const char RECEIVE = 'R';
        public const char SEND = 'S';
    }


    /// <summary>
    /// NoTradingSessions Field
    /// </summary>/
    public sealed class NoTradingSessions : IntField
    {
        public const int TAG = 386;

        public NoTradingSessions()
            :base(Tags.NoTradingSessions) {}
        public NoTradingSessions(int val)
            :base(Tags.NoTradingSessions, val) {}

    }


    /// <summary>
    /// TotalVolumeTraded Field
    /// </summary>/
    public sealed class TotalVolumeTraded : DecimalField
    {
        public const int TAG = 387;

        public TotalVolumeTraded()
            :base(Tags.TotalVolumeTraded) {}
        public TotalVolumeTraded(Decimal val)
            :base(Tags.TotalVolumeTraded, val) {}

    }


    /// <summary>
    /// DiscretionInst Field
    /// </summary>/
    public sealed class DiscretionInst : CharField
    {
        public const int TAG = 388;

        public DiscretionInst()
            :base(Tags.DiscretionInst) {}
        public DiscretionInst(char val)
            :base(Tags.DiscretionInst, val) {}


        // Field Enumerations
        public const char RELATED_TO_DISPLAYED_PRICE = '0';
        public const char RELATED_TO_MARKET_PRICE = '1';
        public const char RELATED_TO_PRIMARY_PRICE = '2';
        public const char RELATED_TO_LOCAL_PRIMARY_PRICE = '3';
        public const char RELATED_TO_MIDPOINT_PRICE = '4';
        public const char RELATED_TO_LAST_TRADE_PRICE = '5';
        public const char RELATED_TO_VWAP = '6';
        public const char AVERAGE_PRICE_GUARANTEE = '7';
    }


    /// <summary>
    /// DiscretionOffset Field
    /// </summary>/
    public sealed class DiscretionOffset : DecimalField
    {
        public const int TAG = 389;

        public DiscretionOffset()
            :base(Tags.DiscretionOffset) {}
        public DiscretionOffset(Decimal val)
            :base(Tags.DiscretionOffset, val) {}

    }


    /// <summary>
    /// BidID Field
    /// </summary>/
    public sealed class BidID : StringField
    {
        public const int TAG = 390;

        public BidID()
            :base(Tags.BidID) {}
        public BidID(string val)
            :base(Tags.BidID, val) {}

    }


    /// <summary>
    /// ClientBidID Field
    /// </summary>/
    public sealed class ClientBidID : StringField
    {
        public const int TAG = 391;

        public ClientBidID()
            :base(Tags.ClientBidID) {}
        public ClientBidID(string val)
            :base(Tags.ClientBidID, val) {}

    }


    /// <summary>
    /// ListName Field
    /// </summary>/
    public sealed class ListName : StringField
    {
        public const int TAG = 392;

        public ListName()
            :base(Tags.ListName) {}
        public ListName(string val)
            :base(Tags.ListName, val) {}

    }


    /// <summary>
    /// TotalNumSecurities Field
    /// </summary>/
    public sealed class TotalNumSecurities : IntField
    {
        public const int TAG = 393;

        public TotalNumSecurities()
            :base(Tags.TotalNumSecurities) {}
        public TotalNumSecurities(int val)
            :base(Tags.TotalNumSecurities, val) {}

    }


    /// <summary>
    /// BidType Field
    /// </summary>/
    public sealed class BidType : IntField
    {
        public const int TAG = 394;

        public BidType()
            :base(Tags.BidType) {}
        public BidType(int val)
            :base(Tags.BidType, val) {}


        // Field Enumerations
        public const int NON_DISCLOSED_STYLE = 1;
        public const int DISCLOSED_SYTLE = 2;
        public const int NO_BIDDING_PROCESS = 3;
        public const int NON_DISCLOSED = 1;
        public const int DISCLOSED_STYLE = 2;
    }


    /// <summary>
    /// NumTickets Field
    /// </summary>/
    public sealed class NumTickets : IntField
    {
        public const int TAG = 395;

        public NumTickets()
            :base(Tags.NumTickets) {}
        public NumTickets(int val)
            :base(Tags.NumTickets, val) {}

    }


    /// <summary>
    /// SideValue1 Field
    /// </summary>/
    public sealed class SideValue1 : DecimalField
    {
        public const int TAG = 396;

        public SideValue1()
            :base(Tags.SideValue1) {}
        public SideValue1(Decimal val)
            :base(Tags.SideValue1, val) {}

    }


    /// <summary>
    /// SideValue2 Field
    /// </summary>/
    public sealed class SideValue2 : DecimalField
    {
        public const int TAG = 397;

        public SideValue2()
            :base(Tags.SideValue2) {}
        public SideValue2(Decimal val)
            :base(Tags.SideValue2, val) {}

    }


    /// <summary>
    /// NoBidDescriptors Field
    /// </summary>/
    public sealed class NoBidDescriptors : IntField
    {
        public const int TAG = 398;

        public NoBidDescriptors()
            :base(Tags.NoBidDescriptors) {}
        public NoBidDescriptors(int val)
            :base(Tags.NoBidDescriptors, val) {}

    }


    /// <summary>
    /// BidDescriptorType Field
    /// </summary>/
    public sealed class BidDescriptorType : IntField
    {
        public const int TAG = 399;

        public BidDescriptorType()
            :base(Tags.BidDescriptorType) {}
        public BidDescriptorType(int val)
            :base(Tags.BidDescriptorType, val) {}


        // Field Enumerations
        public const int SECTOR = 1;
        public const int COUNTRY = 2;
        public const int INDEX = 3;
    }


    /// <summary>
    /// BidDescriptor Field
    /// </summary>/
    public sealed class BidDescriptor : StringField
    {
        public const int TAG = 400;

        public BidDescriptor()
            :base(Tags.BidDescriptor) {}
        public BidDescriptor(string val)
            :base(Tags.BidDescriptor, val) {}

    }


    /// <summary>
    /// SideValueInd Field
    /// </summary>/
    public sealed class SideValueInd : IntField
    {
        public const int TAG = 401;

        public SideValueInd()
            :base(Tags.SideValueInd) {}
        public SideValueInd(int val)
            :base(Tags.SideValueInd, val) {}


        // Field Enumerations
        public const int SIDE_VALUE_1 = 1;
        public const int SIDE_VALUE_2 = 2;
        public const int SIDEVALUE1 = 1;
        public const int SIDEVALUE2 = 2;
        public const int SIDEVALUE_2 = 2;
    }


    /// <summary>
    /// LiquidityPctLow Field
    /// </summary>/
    public sealed class LiquidityPctLow : DecimalField
    {
        public const int TAG = 402;

        public LiquidityPctLow()
            :base(Tags.LiquidityPctLow) {}
        public LiquidityPctLow(Decimal val)
            :base(Tags.LiquidityPctLow, val) {}

    }


    /// <summary>
    /// LiquidityPctHigh Field
    /// </summary>/
    public sealed class LiquidityPctHigh : DecimalField
    {
        public const int TAG = 403;

        public LiquidityPctHigh()
            :base(Tags.LiquidityPctHigh) {}
        public LiquidityPctHigh(Decimal val)
            :base(Tags.LiquidityPctHigh, val) {}

    }


    /// <summary>
    /// LiquidityValue Field
    /// </summary>/
    public sealed class LiquidityValue : DecimalField
    {
        public const int TAG = 404;

        public LiquidityValue()
            :base(Tags.LiquidityValue) {}
        public LiquidityValue(Decimal val)
            :base(Tags.LiquidityValue, val) {}

    }


    /// <summary>
    /// EFPTrackingError Field
    /// </summary>/
    public sealed class EFPTrackingError : DecimalField
    {
        public const int TAG = 405;

        public EFPTrackingError()
            :base(Tags.EFPTrackingError) {}
        public EFPTrackingError(Decimal val)
            :base(Tags.EFPTrackingError, val) {}

    }


    /// <summary>
    /// FairValue Field
    /// </summary>/
    public sealed class FairValue : DecimalField
    {
        public const int TAG = 406;

        public FairValue()
            :base(Tags.FairValue) {}
        public FairValue(Decimal val)
            :base(Tags.FairValue, val) {}

    }


    /// <summary>
    /// OutsideIndexPct Field
    /// </summary>/
    public sealed class OutsideIndexPct : DecimalField
    {
        public const int TAG = 407;

        public OutsideIndexPct()
            :base(Tags.OutsideIndexPct) {}
        public OutsideIndexPct(Decimal val)
            :base(Tags.OutsideIndexPct, val) {}

    }


    /// <summary>
    /// ValueOfFutures Field
    /// </summary>/
    public sealed class ValueOfFutures : DecimalField
    {
        public const int TAG = 408;

        public ValueOfFutures()
            :base(Tags.ValueOfFutures) {}
        public ValueOfFutures(Decimal val)
            :base(Tags.ValueOfFutures, val) {}

    }


    /// <summary>
    /// LiquidityIndType Field
    /// </summary>/
    public sealed class LiquidityIndType : IntField
    {
        public const int TAG = 409;

        public LiquidityIndType()
            :base(Tags.LiquidityIndType) {}
        public LiquidityIndType(int val)
            :base(Tags.LiquidityIndType, val) {}


        // Field Enumerations
        public const int VAL_5_DAY_MOVING_AVERAGE = 1;
        public const int VAL_20_DAY_MOVING_AVERAGE = 2;
        public const int NORMAL_MARKET_SIZE = 3;
        public const int OTHER = 4;
        public const int FIVEDAY_MOVING_AVERAGE = 1;
        public const int TWENTYDAY_MOVING_AVERAGE = 2;
    }


    /// <summary>
    /// WtAverageLiquidity Field
    /// </summary>/
    public sealed class WtAverageLiquidity : DecimalField
    {
        public const int TAG = 410;

        public WtAverageLiquidity()
            :base(Tags.WtAverageLiquidity) {}
        public WtAverageLiquidity(Decimal val)
            :base(Tags.WtAverageLiquidity, val) {}

    }


    /// <summary>
    /// ExchangeForPhysical Field
    /// </summary>/
    public sealed class ExchangeForPhysical : BooleanField
    {
        public const int TAG = 411;

        public ExchangeForPhysical()
            :base(Tags.ExchangeForPhysical) {}
        public ExchangeForPhysical(Boolean val)
            :base(Tags.ExchangeForPhysical, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
        public const Boolean TRUE = true;
        public const Boolean FALSE = false;
    }


    /// <summary>
    /// OutMainCntryUIndex Field
    /// </summary>/
    public sealed class OutMainCntryUIndex : DecimalField
    {
        public const int TAG = 412;

        public OutMainCntryUIndex()
            :base(Tags.OutMainCntryUIndex) {}
        public OutMainCntryUIndex(Decimal val)
            :base(Tags.OutMainCntryUIndex, val) {}

    }


    /// <summary>
    /// CrossPercent Field
    /// </summary>/
    public sealed class CrossPercent : DecimalField
    {
        public const int TAG = 413;

        public CrossPercent()
            :base(Tags.CrossPercent) {}
        public CrossPercent(Decimal val)
            :base(Tags.CrossPercent, val) {}

    }


    /// <summary>
    /// ProgRptReqs Field
    /// </summary>/
    public sealed class ProgRptReqs : IntField
    {
        public const int TAG = 414;

        public ProgRptReqs()
            :base(Tags.ProgRptReqs) {}
        public ProgRptReqs(int val)
            :base(Tags.ProgRptReqs, val) {}


        // Field Enumerations
        public const int BUY_SIDE_EXPLICITLY_REQUESTS_STATUS_USING_STATUE_REQUEST = 1;
        public const int SELL_SIDE_PERIODICALLY_SENDS_STATUS_USING_LIST_STATUS_PERIOD_OPTIONALLY_SPECIFIED_IN_PROGRESSPERIOD = 2;
        public const int REAL_TIME_EXECUTION_REPORTS = 3;
        public const int BUYSIDE_EXPLICITLY_REQUESTS_STATUS_USING_STATUSREQUEST = 1;
        public const int SELLSIDE_PERIODICALLY_SENDS_STATUS_USING_LISTSTATUS = 2;
    }


    /// <summary>
    /// ProgPeriodInterval Field
    /// </summary>/
    public sealed class ProgPeriodInterval : IntField
    {
        public const int TAG = 415;

        public ProgPeriodInterval()
            :base(Tags.ProgPeriodInterval) {}
        public ProgPeriodInterval(int val)
            :base(Tags.ProgPeriodInterval, val) {}

    }


    /// <summary>
    /// IncTaxInd Field
    /// </summary>/
    public sealed class IncTaxInd : IntField
    {
        public const int TAG = 416;

        public IncTaxInd()
            :base(Tags.IncTaxInd) {}
        public IncTaxInd(int val)
            :base(Tags.IncTaxInd, val) {}


        // Field Enumerations
        public const int NET = 1;
        public const int GROSS = 2;
    }


    /// <summary>
    /// NumBidders Field
    /// </summary>/
    public sealed class NumBidders : IntField
    {
        public const int TAG = 417;

        public NumBidders()
            :base(Tags.NumBidders) {}
        public NumBidders(int val)
            :base(Tags.NumBidders, val) {}

    }


    /// <summary>
    /// TradeType Field
    /// </summary>/
    public sealed class TradeType : CharField
    {
        public const int TAG = 418;

        public TradeType()
            :base(Tags.TradeType) {}
        public TradeType(char val)
            :base(Tags.TradeType, val) {}

    }


    /// <summary>
    /// BasisPxType Field
    /// </summary>/
    public sealed class BasisPxType : CharField
    {
        public const int TAG = 419;

        public BasisPxType()
            :base(Tags.BasisPxType) {}
        public BasisPxType(char val)
            :base(Tags.BasisPxType, val) {}


        // Field Enumerations
        public const char CLOSING_PRICE_AT_MORNINGN_SESSION = '2';
        public const char CLOSING_PRICE = '3';
        public const char CURRENT_PRICE = '4';
        public const char SQ = '5';
        public const char VWAP_THROUGH_A_DAY = '6';
        public const char VWAP_THROUGH_A_MORNING_SESSION = '7';
        public const char VWAP_THROUGH_AN_AFTERNOON_SESSION = '8';
        public const char VWAP_THROUGH_A_DAY_EXCEPT_YORI = '9';
        public const char VWAP_THROUGH_A_MORNING_SESSION_EXCEPT_YORI = 'A';
        public const char VWAP_THROUGH_AN_AFTERNOON_SESSION_EXCEPT_YORI = 'B';
        public const char STRIKE = 'C';
        public const char OPEN = 'D';
        public const char OTHERS = 'Z';
        public const char CLOSING_PRICE_AT_MORNING_SESSION = '2';
    }


    /// <summary>
    /// NoBidComponents Field
    /// </summary>/
    public sealed class NoBidComponents : IntField
    {
        public const int TAG = 420;

        public NoBidComponents()
            :base(Tags.NoBidComponents) {}
        public NoBidComponents(int val)
            :base(Tags.NoBidComponents, val) {}

    }


    /// <summary>
    /// Country Field
    /// </summary>/
    public sealed class Country : StringField
    {
        public const int TAG = 421;

        public Country()
            :base(Tags.Country) {}
        public Country(string val)
            :base(Tags.Country, val) {}

    }


    /// <summary>
    /// TotNoStrikes Field
    /// </summary>/
    public sealed class TotNoStrikes : IntField
    {
        public const int TAG = 422;

        public TotNoStrikes()
            :base(Tags.TotNoStrikes) {}
        public TotNoStrikes(int val)
            :base(Tags.TotNoStrikes, val) {}

    }


    /// <summary>
    /// PriceType Field
    /// </summary>/
    public sealed class PriceType : IntField
    {
        public const int TAG = 423;

        public PriceType()
            :base(Tags.PriceType) {}
        public PriceType(int val)
            :base(Tags.PriceType, val) {}


        // Field Enumerations
        public const int PERCENTAGE = 1;
        public const int FIXED_CABINET_TRADE_PRICE = 10;
        public const int VARIABLE_CABINET_TRADE_PRICE = 11;
        public const int PER_UNIT = 2;
        public const int FIXED_AMOUNT = 3;
        public const int DISCOUNT = 4;
        public const int PREMIUM = 5;
        public const int SPREAD = 6;
        public const int TED_PRICE = 7;
        public const int TED_YIELD = 8;
        public const int YIELD = 9;
        public const int PRODUCT_TICKS_IN_HALFS = 13;
        public const int PRODUCT_TICKS_IN_FOURTHS = 14;
        public const int PRODUCT_TICKS_IN_EIGHTS = 15;
        public const int PRODUCT_TICKS_IN_SIXTEENTHS = 16;
        public const int PRODUCT_TICKS_IN_THIRTY_SECONDS = 17;
        public const int PRODUCT_TICKS_IN_SIXTY_FORTHS = 18;
        public const int PRODUCT_TICKS_IN_ONE_TWENTY_EIGHTS = 19;
        public const int PER_SHARE = 2;
        public const int BASIS_POINTS_RELATIVE_TO_BENCHMARK = 6;
    }


    /// <summary>
    /// DayOrderQty Field
    /// </summary>/
    public sealed class DayOrderQty : DecimalField
    {
        public const int TAG = 424;

        public DayOrderQty()
            :base(Tags.DayOrderQty) {}
        public DayOrderQty(Decimal val)
            :base(Tags.DayOrderQty, val) {}

    }


    /// <summary>
    /// DayCumQty Field
    /// </summary>/
    public sealed class DayCumQty : DecimalField
    {
        public const int TAG = 425;

        public DayCumQty()
            :base(Tags.DayCumQty) {}
        public DayCumQty(Decimal val)
            :base(Tags.DayCumQty, val) {}

    }


    /// <summary>
    /// DayAvgPx Field
    /// </summary>/
    public sealed class DayAvgPx : DecimalField
    {
        public const int TAG = 426;

        public DayAvgPx()
            :base(Tags.DayAvgPx) {}
        public DayAvgPx(Decimal val)
            :base(Tags.DayAvgPx, val) {}

    }


    /// <summary>
    /// GTBookingInst Field
    /// </summary>/
    public sealed class GTBookingInst : IntField
    {
        public const int TAG = 427;

        public GTBookingInst()
            :base(Tags.GTBookingInst) {}
        public GTBookingInst(int val)
            :base(Tags.GTBookingInst, val) {}


        // Field Enumerations
        public const int BOOK_OUT_ALL_TRADES_ON_DAY_OF_EXECUTION = 0;
        public const int ACCUMULATE_EXECTUIONS_UNTIL_FORDER_IS_FILLED_OR_EXPIRES = 1;
        public const int ACCUMULATE_UNTIL_VERBALLLY_NOTIFIED_OTHERWISE = 2;
        public const int ACCUMULATE_EXECUTIONS_UNTIL_ORDER_IS_FILLED_OR_EXPIRES = 1;
        public const int ACCUMULATE_UNTIL_VERBALLY_NOTIFIED_OTHERWISE = 2;
    }


    /// <summary>
    /// NoStrikes Field
    /// </summary>/
    public sealed class NoStrikes : IntField
    {
        public const int TAG = 428;

        public NoStrikes()
            :base(Tags.NoStrikes) {}
        public NoStrikes(int val)
            :base(Tags.NoStrikes, val) {}

    }


    /// <summary>
    /// ListStatusType Field
    /// </summary>/
    public sealed class ListStatusType : IntField
    {
        public const int TAG = 429;

        public ListStatusType()
            :base(Tags.ListStatusType) {}
        public ListStatusType(int val)
            :base(Tags.ListStatusType, val) {}


        // Field Enumerations
        public const int ACK = 1;
        public const int RESPONSE = 2;
        public const int TIMED = 3;
        public const int EXEC_STARTED = 4;
        public const int ALL_DONE = 5;
        public const int ALERT = 6;
        public const int EXECSTARTED = 4;
        public const int ALLDONE = 5;
    }


    /// <summary>
    /// NetGrossInd Field
    /// </summary>/
    public sealed class NetGrossInd : IntField
    {
        public const int TAG = 430;

        public NetGrossInd()
            :base(Tags.NetGrossInd) {}
        public NetGrossInd(int val)
            :base(Tags.NetGrossInd, val) {}


        // Field Enumerations
        public const int NET = 1;
        public const int GROSS = 2;
    }


    /// <summary>
    /// ListOrderStatus Field
    /// </summary>/
    public sealed class ListOrderStatus : IntField
    {
        public const int TAG = 431;

        public ListOrderStatus()
            :base(Tags.ListOrderStatus) {}
        public ListOrderStatus(int val)
            :base(Tags.ListOrderStatus, val) {}


        // Field Enumerations
        public const int IN_BIDDING_PROCESS = 1;
        public const int RECEIVED_FOR_EXECUTION = 2;
        public const int EXECUTING = 3;
        public const int CANCELLING = 4;
        public const int ALERT = 5;
        public const int ALL_DONE = 6;
        public const int REJECT = 7;
        public const int INBIDDINGPROCESS = 1;
        public const int RECEIVEDFOREXECUTION = 2;
        public const int CANCELING = 4;
    }


    /// <summary>
    /// ExpireDate Field
    /// </summary>/
    public sealed class ExpireDate : StringField
    {
        public const int TAG = 432;

        public ExpireDate()
            :base(Tags.ExpireDate) {}
        public ExpireDate(string val)
            :base(Tags.ExpireDate, val) {}

    }


    /// <summary>
    /// ListExecInstType Field
    /// </summary>/
    public sealed class ListExecInstType : CharField
    {
        public const int TAG = 433;

        public ListExecInstType()
            :base(Tags.ListExecInstType) {}
        public ListExecInstType(char val)
            :base(Tags.ListExecInstType, val) {}


        // Field Enumerations
        public const char IMMEDIATE = '1';
        public const char WAIT_FOR_EXECUT_INSTRUCTION = '2';
        public const char EXCHANGE_SWITCH_CIV_ORDER_3 = '3';
        public const char EXCHANGE_SWITCH_CIV_ORDER_4 = '4';
        public const char EXCHANGE_SWITCH_CIV_ORDER_5 = '5';
        public const char WAIT_FOR_EXECUTE_INSTRUCTION = '2';
        public const char EXCHANGE_SWITCH_CIV_ORDER_SELL_DRIVEN = '3';
        public const char EXCHANGE_SWITCH_CIV_ORDER_BUY_DRIVEN_CASH_TOP_UP = '4';
        public const char EXCHANGE_SWITCH_CIV_ORDER_BUY_DRIVEN_CASH_WITHDRAW = '5';
    }


    /// <summary>
    /// CxlRejResponseTo Field
    /// </summary>/
    public sealed class CxlRejResponseTo : CharField
    {
        public const int TAG = 434;

        public CxlRejResponseTo()
            :base(Tags.CxlRejResponseTo) {}
        public CxlRejResponseTo(char val)
            :base(Tags.CxlRejResponseTo, val) {}


        // Field Enumerations
        public const char ORDER_CANCEL_REQUEST = '1';
        public const char ORDER_CANCEL_REPLACE_REQUEST = '2';
    }


    /// <summary>
    /// UnderlyingCouponRate Field
    /// </summary>/
    public sealed class UnderlyingCouponRate : DecimalField
    {
        public const int TAG = 435;

        public UnderlyingCouponRate()
            :base(Tags.UnderlyingCouponRate) {}
        public UnderlyingCouponRate(Decimal val)
            :base(Tags.UnderlyingCouponRate, val) {}

    }


    /// <summary>
    /// UnderlyingContractMultiplier Field
    /// </summary>/
    public sealed class UnderlyingContractMultiplier : DecimalField
    {
        public const int TAG = 436;

        public UnderlyingContractMultiplier()
            :base(Tags.UnderlyingContractMultiplier) {}
        public UnderlyingContractMultiplier(Decimal val)
            :base(Tags.UnderlyingContractMultiplier, val) {}

    }


    /// <summary>
    /// ContraTradeQty Field
    /// </summary>/
    public sealed class ContraTradeQty : DecimalField
    {
        public const int TAG = 437;

        public ContraTradeQty()
            :base(Tags.ContraTradeQty) {}
        public ContraTradeQty(Decimal val)
            :base(Tags.ContraTradeQty, val) {}

    }


    /// <summary>
    /// ContraTradeTime Field
    /// </summary>/
    public sealed class ContraTradeTime : DateTimeField
    {
        public const int TAG = 438;

        public ContraTradeTime()
            :base(Tags.ContraTradeTime) {}
        public ContraTradeTime(DateTime val)
            :base(Tags.ContraTradeTime, val) {}
        public ContraTradeTime(DateTime val, bool showMilliseconds)
            :base(Tags.ContraTradeTime, val, showMilliseconds) {}
		public ContraTradeTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.ContraTradeTime, val, precision) {}

    }


    /// <summary>
    /// ClearingFirm Field
    /// </summary>/
    public sealed class ClearingFirm : StringField
    {
        public const int TAG = 439;

        public ClearingFirm()
            :base(Tags.ClearingFirm) {}
        public ClearingFirm(string val)
            :base(Tags.ClearingFirm, val) {}

    }


    /// <summary>
    /// ClearingAccount Field
    /// </summary>/
    public sealed class ClearingAccount : StringField
    {
        public const int TAG = 440;

        public ClearingAccount()
            :base(Tags.ClearingAccount) {}
        public ClearingAccount(string val)
            :base(Tags.ClearingAccount, val) {}

    }


    /// <summary>
    /// LiquidityNumSecurities Field
    /// </summary>/
    public sealed class LiquidityNumSecurities : IntField
    {
        public const int TAG = 441;

        public LiquidityNumSecurities()
            :base(Tags.LiquidityNumSecurities) {}
        public LiquidityNumSecurities(int val)
            :base(Tags.LiquidityNumSecurities, val) {}

    }


    /// <summary>
    /// MultiLegReportingType Field
    /// </summary>/
    public sealed class MultiLegReportingType : CharField
    {
        public const int TAG = 442;

        public MultiLegReportingType()
            :base(Tags.MultiLegReportingType) {}
        public MultiLegReportingType(char val)
            :base(Tags.MultiLegReportingType, val) {}


        // Field Enumerations
        public const char SINGLE_SECURITY = '1';
        public const char INDIVIDUAL_LEG_OF_A_MULTI_LEG_SECURITY = '2';
        public const char MULTI_LEG_SECURITY = '3';
        public const char INDIVIDUAL_LEG_OF_A_MULTILEG_SECURITY = '2';
    }


    /// <summary>
    /// StrikeTime Field
    /// </summary>/
    public sealed class StrikeTime : DateTimeField
    {
        public const int TAG = 443;

        public StrikeTime()
            :base(Tags.StrikeTime) {}
        public StrikeTime(DateTime val)
            :base(Tags.StrikeTime, val) {}
        public StrikeTime(DateTime val, bool showMilliseconds)
            :base(Tags.StrikeTime, val, showMilliseconds) {}
		public StrikeTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.StrikeTime, val, precision) {}

    }


    /// <summary>
    /// ListStatusText Field
    /// </summary>/
    public sealed class ListStatusText : StringField
    {
        public const int TAG = 444;

        public ListStatusText()
            :base(Tags.ListStatusText) {}
        public ListStatusText(string val)
            :base(Tags.ListStatusText, val) {}

    }


    /// <summary>
    /// EncodedListStatusTextLen Field
    /// </summary>/
    public sealed class EncodedListStatusTextLen : IntField
    {
        public const int TAG = 445;

        public EncodedListStatusTextLen()
            :base(Tags.EncodedListStatusTextLen) {}
        public EncodedListStatusTextLen(int val)
            :base(Tags.EncodedListStatusTextLen, val) {}

    }


    /// <summary>
    /// EncodedListStatusText Field
    /// </summary>/
    public sealed class EncodedListStatusText : StringField
    {
        public const int TAG = 446;

        public EncodedListStatusText()
            :base(Tags.EncodedListStatusText) {}
        public EncodedListStatusText(string val)
            :base(Tags.EncodedListStatusText, val) {}

    }


    /// <summary>
    /// SecurityIDSource Field
    /// </summary>/
    public sealed class SecurityIDSource : StringField
    {
        public const int TAG = 22;

        public SecurityIDSource()
            :base(Tags.SecurityIDSource) {}
        public SecurityIDSource(string val)
            :base(Tags.SecurityIDSource, val) {}


        // Field Enumerations
        public const string CUSIP = "1";
        public const string SEDOL = "2";
        public const string QUIK = "3";
        public const string ISIN_NUMBER = "4";
        public const string RIC_CODE = "5";
        public const string ISO_CURRENCY_CODE = "6";
        public const string ISO_COUNTRY_CODE = "7";
        public const string EXCHANGE_SYMBOL = "8";
        public const string CONSOLIDATED_TAPE_ASSOCIATION = "9";
        public const string BLOOMBERG_SYMBOL = "A";
        public const string WERTPAPIER = "B";
        public const string DUTCH = "C";
        public const string VALOREN = "D";
        public const string SICOVAM = "E";
        public const string BELGIAN = "F";
        public const string COMMON = "G";
        public const string CLEARING_HOUSE = "H";
        public const string ISDA_FPML_PRODUCT_SPECIFICATION = "I";
        public const string OPTION_PRICE_REPORTING_AUTHORITY = "J";
        public const string LETTER_OF_CREDIT = "L";
        public const string ISDA_FPML_PRODUCT_URL = "K";
        public const string MARKETPLACE_ASSIGNED_IDENTIFIER = "M";
        public const string CLEARING_HOUSE_CLEARING_ORGANIZATION = "H";
        public const string OPTIONS_PRICE_REPORTING_AUTHORITY = "J";
    }


    /// <summary>
    /// IOIQty Field
    /// </summary>/
    public sealed class IOIQty : StringField
    {
        public const int TAG = 27;

        public IOIQty()
            :base(Tags.IOIQty) {}
        public IOIQty(string val)
            :base(Tags.IOIQty, val) {}


        // Field Enumerations
        public const string VAL_1000000000 = "0";
        public const string SMALL = "S";
        public const string MEDIUM = "M";
        public const string LARGE = "L";
        public const string UNDISCLOSED_QUANTITY = "U";
    }


    /// <summary>
    /// LastQty Field
    /// </summary>/
    public sealed class LastQty : DecimalField
    {
        public const int TAG = 32;

        public LastQty()
            :base(Tags.LastQty) {}
        public LastQty(Decimal val)
            :base(Tags.LastQty, val) {}

    }


    /// <summary>
    /// SendingDate Field
    /// </summary>/
    public sealed class SendingDate : StringField
    {
        public const int TAG = 51;

        public SendingDate()
            :base(Tags.SendingDate) {}
        public SendingDate(string val)
            :base(Tags.SendingDate, val) {}

    }


    /// <summary>
    /// Quantity Field
    /// </summary>/
    public sealed class Quantity : DecimalField
    {
        public const int TAG = 53;

        public Quantity()
            :base(Tags.Quantity) {}
        public Quantity(Decimal val)
            :base(Tags.Quantity, val) {}

    }


    /// <summary>
    /// PositionEffect Field
    /// </summary>/
    public sealed class PositionEffect : CharField
    {
        public const int TAG = 77;

        public PositionEffect()
            :base(Tags.PositionEffect) {}
        public PositionEffect(char val)
            :base(Tags.PositionEffect, val) {}


        // Field Enumerations
        public const char CLOSE = 'C';
        public const char FIFO = 'F';
        public const char OPEN = 'O';
        public const char ROLLED = 'R';
        public const char CLOSE_BUT_NOTIFY_ON_OPEN = 'N';
        public const char DEFAULT = 'D';
    }


    /// <summary>
    /// AllocQty Field
    /// </summary>/
    public sealed class AllocQty : DecimalField
    {
        public const int TAG = 80;

        public AllocQty()
            :base(Tags.AllocQty) {}
        public AllocQty(Decimal val)
            :base(Tags.AllocQty, val) {}

    }


    /// <summary>
    /// Spread Field
    /// </summary>/
    public sealed class Spread : DecimalField
    {
        public const int TAG = 218;

        public Spread()
            :base(Tags.Spread) {}
        public Spread(Decimal val)
            :base(Tags.Spread, val) {}

    }


    /// <summary>
    /// BenchmarkCurveCurrency Field
    /// </summary>/
    public sealed class BenchmarkCurveCurrency : StringField
    {
        public const int TAG = 220;

        public BenchmarkCurveCurrency()
            :base(Tags.BenchmarkCurveCurrency) {}
        public BenchmarkCurveCurrency(string val)
            :base(Tags.BenchmarkCurveCurrency, val) {}

    }


    /// <summary>
    /// BenchmarkCurveName Field
    /// </summary>/
    public sealed class BenchmarkCurveName : StringField
    {
        public const int TAG = 221;

        public BenchmarkCurveName()
            :base(Tags.BenchmarkCurveName) {}
        public BenchmarkCurveName(string val)
            :base(Tags.BenchmarkCurveName, val) {}


        // Field Enumerations
        public const string EONIA = "EONIA";
        public const string EUREPO = "EUREPO";
        public const string EURIBOR = "Euribor";
        public const string FUTURESWAP = "FutureSWAP";
        public const string LIBID = "LIBID";
        public const string LIBOR = "LIBOR";
        public const string MUNIAAA = "MuniAAA";
        public const string OTHER = "OTHER";
        public const string PFANDBRIEFE = "Pfandbriefe";
        public const string SONIA = "SONIA";
        public const string SWAP = "SWAP";
        public const string TREASURY = "Treasury";
    }


    /// <summary>
    /// BenchmarkCurvePoint Field
    /// </summary>/
    public sealed class BenchmarkCurvePoint : StringField
    {
        public const int TAG = 222;

        public BenchmarkCurvePoint()
            :base(Tags.BenchmarkCurvePoint) {}
        public BenchmarkCurvePoint(string val)
            :base(Tags.BenchmarkCurvePoint, val) {}

    }


    /// <summary>
    /// CouponPaymentDate Field
    /// </summary>/
    public sealed class CouponPaymentDate : StringField
    {
        public const int TAG = 224;

        public CouponPaymentDate()
            :base(Tags.CouponPaymentDate) {}
        public CouponPaymentDate(string val)
            :base(Tags.CouponPaymentDate, val) {}

    }


    /// <summary>
    /// IssueDate Field
    /// </summary>/
    public sealed class IssueDate : StringField
    {
        public const int TAG = 225;

        public IssueDate()
            :base(Tags.IssueDate) {}
        public IssueDate(string val)
            :base(Tags.IssueDate, val) {}

    }


    /// <summary>
    /// RepurchaseTerm Field
    /// </summary>/
    public sealed class RepurchaseTerm : IntField
    {
        public const int TAG = 226;

        public RepurchaseTerm()
            :base(Tags.RepurchaseTerm) {}
        public RepurchaseTerm(int val)
            :base(Tags.RepurchaseTerm, val) {}

    }


    /// <summary>
    /// RepurchaseRate Field
    /// </summary>/
    public sealed class RepurchaseRate : DecimalField
    {
        public const int TAG = 227;

        public RepurchaseRate()
            :base(Tags.RepurchaseRate) {}
        public RepurchaseRate(Decimal val)
            :base(Tags.RepurchaseRate, val) {}

    }


    /// <summary>
    /// Factor Field
    /// </summary>/
    public sealed class Factor : DecimalField
    {
        public const int TAG = 228;

        public Factor()
            :base(Tags.Factor) {}
        public Factor(Decimal val)
            :base(Tags.Factor, val) {}

    }


    /// <summary>
    /// TradeOriginationDate Field
    /// </summary>/
    public sealed class TradeOriginationDate : StringField
    {
        public const int TAG = 229;

        public TradeOriginationDate()
            :base(Tags.TradeOriginationDate) {}
        public TradeOriginationDate(string val)
            :base(Tags.TradeOriginationDate, val) {}

    }


    /// <summary>
    /// ExDate Field
    /// </summary>/
    public sealed class ExDate : StringField
    {
        public const int TAG = 230;

        public ExDate()
            :base(Tags.ExDate) {}
        public ExDate(string val)
            :base(Tags.ExDate, val) {}

    }


    /// <summary>
    /// NoStipulations Field
    /// </summary>/
    public sealed class NoStipulations : IntField
    {
        public const int TAG = 232;

        public NoStipulations()
            :base(Tags.NoStipulations) {}
        public NoStipulations(int val)
            :base(Tags.NoStipulations, val) {}

    }


    /// <summary>
    /// StipulationType Field
    /// </summary>/
    public sealed class StipulationType : StringField
    {
        public const int TAG = 233;

        public StipulationType()
            :base(Tags.StipulationType) {}
        public StipulationType(string val)
            :base(Tags.StipulationType, val) {}


        // Field Enumerations
        public const string ABSOLUTE_PREPAYMENT_SPEED = "ABS";
        public const string ALTERNATIVE_MINIMUM_TAX = "AMT";
        public const string AUTO_REINVESTMENT_AT_RATE_OR_BETTER = "AUTOREINV";
        public const string BANK_QUALIFIED = "BANKQUAL";
        public const string BARGAIN_CONDITIONS = "BGNCON";
        public const string COUPON_RANGE = "COUPON";
        public const string CONSTANT_PREPAYMENT_PENALTY = "CPP";
        public const string CONSTANT_PREPAYMENT_RATE = "CPR";
        public const string CONSTANT_PREPAYMENT_YIELD = "CPY";
        public const string ISO_CURRENCY_CODE = "CURRENCY";
        public const string CUSTOM_START_END_DATE = "CUSTOMDATE";
        public const string GEOGRAPHICS_AND_RANGE = "GEOG";
        public const string VALUATION_DISCOUNT = "HAIRCUT";
        public const string FINAL_CPR_OF_HOME_EQUITY_PREPAYMENT_CURVE = "HEP";
        public const string INSURED = "INSURED";
        public const string YEAR_OR_YEAR_MONTH_OF_ISSUE = "ISSUE";
        public const string ISSUERS_TICKER = "ISSUER";
        public const string ISSUE_SIZE_RANGE = "ISSUESIZE";
        public const string LOOKBACK_DAYS = "LOOKBACK";
        public const string EXPLICIT_LOT_IDENTIFIER = "LOT";
        public const string LOT_VARIANCE = "LOTVAR";
        public const string MATURITY_YEAR_AND_MONTH = "MAT";
        public const string MATURITY_RANGE = "MATURITY";
        public const string MAXIMUM_SUBSTITUTIONS = "MAXSUBS";
        public const string PERCENT_OF_MANUFACTURED_HOUSING_PREPAYMENT_CURVE = "MHP";
        public const string MINIMUM_DENOMINATION = "MINDNOM";
        public const string MINIMUM_INCREMENT = "MININCR";
        public const string MINIMUM_QUANTITY = "MINQTY";
        public const string MONTHLY_PREPAYMENT_RATE = "MPR";
        public const string PAYMENT_FREQUENCY_CALENDAR = "PAYFREQ";
        public const string NUMBER_OF_PIECES = "PIECES";
        public const string POOLS_MAXIMUM = "PMAX";
        public const string PERCENT_OF_PROSPECTUS_PREPAYMENT_CURVE = "PPC";
        public const string POOLS_PER_LOT = "PPL";
        public const string POOLS_PER_MILLION = "PPM";
        public const string POOLS_PER_TRADE = "PPT";
        public const string PRICE_RANGE = "PRICE";
        public const string PRICING_FREQUENCY = "PRICEFREQ";
        public const string PRODUCTION_YEAR = "PROD";
        public const string CALL_PROTECTION = "PROTECT";
        public const string PERCENT_OF_BMA_PREPAYMENT_CURVE = "PSA";
        public const string PURPOSE = "PURPOSE";
        public const string BENCHMARK_PRICE_SOURCE = "PXSOURCE";
        public const string RATING_SOURCE_AND_RANGE = "RATING";
        public const string TYPE_OF_REDEMPTION = "REDEMPTION";
        public const string RESTRICTED = "RESTRICTED";
        public const string MARKET_SECTOR = "SECTOR";
        public const string SECURITY_TYPE_INCLUDED_OR_EXCLUDED = "SECTYPE";
        public const string SINGLE_MONTHLY_MORTALITY = "SMM";
        public const string STRUCTURE = "STRUCT";
        public const string SUBSTITUTIONS_FREQUENCY = "SUBSFREQ";
        public const string SUBSTITUTIONS_LEFT = "SUBSLEFT";
        public const string FREEFORM_TEXT = "TEXT";
        public const string TRADE_VARIANCE = "TRDVAR";
        public const string WEIGHTED_AVERAGE_COUPON = "WAC";
        public const string WEIGHTED_AVERAGE_LIFE_COUPON = "WAL";
        public const string WEIGHTED_AVERAGE_LOAN_AGE = "WALA";
        public const string WEIGHTED_AVERAGE_MATURITY = "WAM";
        public const string WHOLE_POOL = "WHOLE";
        public const string YIELD_RANGE = "YIELD";
        public const string AVERAGE_FICO_SCORE = "AVFICO";
        public const string AVERAGE_LOAN_SIZE = "AVSIZE";
        public const string MAXIMUM_LOAN_BALANCE = "MAXBAL";
        public const string POOL_IDENTIFIER = "POOL";
        public const string TYPE_OF_ROLL_TRADE = "ROLLTYPE";
        public const string REFERENCE_TO_ROLLING_OR_CLOSING_TRADE = "REFTRADE";
        public const string PRINCIPAL_OF_ROLLING_OR_CLOSING_TRADE = "REFPRIN";
        public const string INTEREST_OF_ROLLING_OR_CLOSING_TRADE = "REFINT";
        public const string AVAILABLE_OFFER_QUANTITY_TO_BE_SHOWN_TO_THE_STREET = "AVAILQTY";
        public const string BROKERS_SALES_CREDIT = "BROKERCREDIT";
        public const string OFFER_PRICE_TO_BE_SHOWN_TO_INTERNAL_BROKERS = "INTERNALPX";
        public const string OFFER_QUANTITY_TO_BE_SHOWN_TO_INTERNAL_BROKERS = "INTERNALQTY";
        public const string THE_MINIMUM_RESIDUAL_OFFER_QUANTITY = "LEAVEQTY";
        public const string MAXIMUM_ORDER_SIZE = "MAXORDQTY";
        public const string ORDER_QUANTITY_INCREMENT = "ORDRINCR";
        public const string PRIMARY_OR_SECONDARY_MARKET_INDICATOR = "PRIMARY";
        public const string BROKER_SALES_CREDIT_OVERRIDE = "SALESCREDITOVR";
        public const string TRADERS_CREDIT = "TRADERCREDIT";
        public const string DISCOUNT_RATE = "DISCOUNT";
        public const string YIELD_TO_MATURITY = "YTM";
        public const string AMT = "AMT";
        public const string AUTO_REINVESTMENT_AT_OR_BETTER = "AUTOREINV";
        public const string GEOGRAPHICS_AND_PERCENT_RANGE = "GEOG";
        public const string SECURITYTYPE_INCLUDED_OR_EXCLUDED = "SECTYPE";
    }


    /// <summary>
    /// StipulationValue Field
    /// </summary>/
    public sealed class StipulationValue : StringField
    {
        public const int TAG = 234;

        public StipulationValue()
            :base(Tags.StipulationValue) {}
        public StipulationValue(string val)
            :base(Tags.StipulationValue, val) {}


        // Field Enumerations
        public const string SPECIAL_CUM_DIVIDEND = "CD";
        public const string SPECIAL_EX_DIVIDEND = "XD";
        public const string SPECIAL_CUM_COUPON = "CC";
        public const string SPECIAL_EX_COUPON = "XC";
        public const string SPECIAL_CUM_BONUS = "CB";
        public const string SPECIAL_EX_BONUS = "XB";
        public const string SPECIAL_CUM_RIGHTS = "CR";
        public const string SPECIAL_EX_RIGHTS = "XR";
        public const string SPECIAL_CUM_CAPITAL_REPAYMENTS = "CP";
        public const string SPECIAL_EX_CAPITAL_REPAYMENTS = "XP";
        public const string CASH_SETTLEMENT = "CS";
        public const string SPECIAL_PRICE = "SP";
        public const string REPORT_FOR_EUROPEAN_EQUITY_MARKET_SECURITIES = "TR";
        public const string GUARANTEED_DELIVERY = "GD";
    }


    /// <summary>
    /// YieldType Field
    /// </summary>/
    public sealed class YieldType : StringField
    {
        public const int TAG = 235;

        public YieldType()
            :base(Tags.YieldType) {}
        public YieldType(string val)
            :base(Tags.YieldType, val) {}


        // Field Enumerations
        public const string AFTER_TAX_YIELD = "AFTERTAX";
        public const string ANNUAL_YIELD = "ANNUAL";
        public const string YIELD_AT_ISSUE = "ATISSUE";
        public const string YIELD_TO_AVG_MATURITY = "AVGMATURITY";
        public const string BOOK_YIELD = "BOOK";
        public const string YIELD_TO_NEXT_CALL = "CALL";
        public const string YIELD_CHANGE_SINCE_CLOSE = "CHANGE";
        public const string CLOSING_YIELD = "CLOSE";
        public const string COMPOUND_YIELD = "COMPOUND";
        public const string CURRENT_YIELD = "CURRENT";
        public const string GVNT_EQUIVALENT_YIELD = "GOVTEQUIV";
        public const string TRUE_GROSS_YIELD = "GROSS";
        public const string YIELD_WITH_INFLATION_ASSUMPTION = "INFLATION";
        public const string INVERSE_FLOATER_BOND_YIELD = "INVERSEFLOATER";
        public const string MOST_RECENT_CLOSING_YIELD = "LASTCLOSE";
        public const string CLOSING_YIELD_MOST_RECENT_MONTH = "LASTMONTH";
        public const string CLOSING_YIELD_MOST_RECENT_QUARTER = "LASTQUARTER";
        public const string CLOSING_YIELD_MOST_RECENT_YEAR = "LASTYEAR";
        public const string YIELD_TO_LONGEST_AVERAGE_LIFE = "LONGAVGLIFE";
        public const string MARK_TO_MARKET_YIELD = "MARK";
        public const string YIELD_TO_MATURITY = "MATURITY";
        public const string YIELD_TO_NEXT_REFUND = "NEXTREFUND";
        public const string OPEN_AVERAGE_YIELD = "OPENAVG";
        public const string PREVIOUS_CLOSE_YIELD = "PREVCLOSE";
        public const string PROCEEDS_YIELD = "PROCEEDS";
        public const string YIELD_TO_NEXT_PUT = "PUT";
        public const string SEMI_ANNUAL_YIELD = "SEMIANNUAL";
        public const string YIELD_TO_SHORTEST_AVERAGE_LIFE = "SHORTAVGLIFE";
        public const string SIMPLE_YIELD = "SIMPLE";
        public const string TAX_EQUIVALENT_YIELD = "TAXEQUIV";
        public const string YIELD_TO_TENDER_DATE = "TENDER";
        public const string TRUE_YIELD = "TRUE";
        public const string YIELD_VALUE_OF_1_32 = "VALUE1_32";
        public const string YIELD_TO_WORST = "WORST";
        public const string YIELD_TO_AVERAGE_MATURITY = "AVGMATURITY";
        public const string GOVERNMENT_EQUIVALENT_YIELD = "GOVTEQUIV";
        public const string YIELD_TO_AVERAGE_LIFE = "AVGLIFE";
        public const string YIELD_TO_LONGEST_AVERAGE = "LONGEST";
        public const string YIELD_TO_SHORTEST_AVERAGE = "SHORTEST";
        public const string YIELD_TO_WORST_CONVENTION = "WORST";
    }


    /// <summary>
    /// Yield Field
    /// </summary>/
    public sealed class Yield : DecimalField
    {
        public const int TAG = 236;

        public Yield()
            :base(Tags.Yield) {}
        public Yield(Decimal val)
            :base(Tags.Yield, val) {}

    }


    /// <summary>
    /// TotalTakedown Field
    /// </summary>/
    public sealed class TotalTakedown : DecimalField
    {
        public const int TAG = 237;

        public TotalTakedown()
            :base(Tags.TotalTakedown) {}
        public TotalTakedown(Decimal val)
            :base(Tags.TotalTakedown, val) {}

    }


    /// <summary>
    /// Concession Field
    /// </summary>/
    public sealed class Concession : DecimalField
    {
        public const int TAG = 238;

        public Concession()
            :base(Tags.Concession) {}
        public Concession(Decimal val)
            :base(Tags.Concession, val) {}

    }


    /// <summary>
    /// RepoCollateralSecurityType Field
    /// </summary>/
    public sealed class RepoCollateralSecurityType : IntField
    {
        public const int TAG = 239;

        public RepoCollateralSecurityType()
            :base(Tags.RepoCollateralSecurityType) {}
        public RepoCollateralSecurityType(int val)
            :base(Tags.RepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// RedemptionDate Field
    /// </summary>/
    public sealed class RedemptionDate : StringField
    {
        public const int TAG = 240;

        public RedemptionDate()
            :base(Tags.RedemptionDate) {}
        public RedemptionDate(string val)
            :base(Tags.RedemptionDate, val) {}

    }


    /// <summary>
    /// UnderlyingCouponPaymentDate Field
    /// </summary>/
    public sealed class UnderlyingCouponPaymentDate : StringField
    {
        public const int TAG = 241;

        public UnderlyingCouponPaymentDate()
            :base(Tags.UnderlyingCouponPaymentDate) {}
        public UnderlyingCouponPaymentDate(string val)
            :base(Tags.UnderlyingCouponPaymentDate, val) {}

    }


    /// <summary>
    /// UnderlyingIssueDate Field
    /// </summary>/
    public sealed class UnderlyingIssueDate : StringField
    {
        public const int TAG = 242;

        public UnderlyingIssueDate()
            :base(Tags.UnderlyingIssueDate) {}
        public UnderlyingIssueDate(string val)
            :base(Tags.UnderlyingIssueDate, val) {}

    }


    /// <summary>
    /// UnderlyingRepoCollateralSecurityType Field
    /// </summary>/
    public sealed class UnderlyingRepoCollateralSecurityType : IntField
    {
        public const int TAG = 243;

        public UnderlyingRepoCollateralSecurityType()
            :base(Tags.UnderlyingRepoCollateralSecurityType) {}
        public UnderlyingRepoCollateralSecurityType(int val)
            :base(Tags.UnderlyingRepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// UnderlyingRepurchaseTerm Field
    /// </summary>/
    public sealed class UnderlyingRepurchaseTerm : IntField
    {
        public const int TAG = 244;

        public UnderlyingRepurchaseTerm()
            :base(Tags.UnderlyingRepurchaseTerm) {}
        public UnderlyingRepurchaseTerm(int val)
            :base(Tags.UnderlyingRepurchaseTerm, val) {}

    }


    /// <summary>
    /// UnderlyingRepurchaseRate Field
    /// </summary>/
    public sealed class UnderlyingRepurchaseRate : DecimalField
    {
        public const int TAG = 245;

        public UnderlyingRepurchaseRate()
            :base(Tags.UnderlyingRepurchaseRate) {}
        public UnderlyingRepurchaseRate(Decimal val)
            :base(Tags.UnderlyingRepurchaseRate, val) {}

    }


    /// <summary>
    /// UnderlyingFactor Field
    /// </summary>/
    public sealed class UnderlyingFactor : DecimalField
    {
        public const int TAG = 246;

        public UnderlyingFactor()
            :base(Tags.UnderlyingFactor) {}
        public UnderlyingFactor(Decimal val)
            :base(Tags.UnderlyingFactor, val) {}

    }


    /// <summary>
    /// UnderlyingRedemptionDate Field
    /// </summary>/
    public sealed class UnderlyingRedemptionDate : StringField
    {
        public const int TAG = 247;

        public UnderlyingRedemptionDate()
            :base(Tags.UnderlyingRedemptionDate) {}
        public UnderlyingRedemptionDate(string val)
            :base(Tags.UnderlyingRedemptionDate, val) {}

    }


    /// <summary>
    /// LegCouponPaymentDate Field
    /// </summary>/
    public sealed class LegCouponPaymentDate : StringField
    {
        public const int TAG = 248;

        public LegCouponPaymentDate()
            :base(Tags.LegCouponPaymentDate) {}
        public LegCouponPaymentDate(string val)
            :base(Tags.LegCouponPaymentDate, val) {}

    }


    /// <summary>
    /// LegIssueDate Field
    /// </summary>/
    public sealed class LegIssueDate : StringField
    {
        public const int TAG = 249;

        public LegIssueDate()
            :base(Tags.LegIssueDate) {}
        public LegIssueDate(string val)
            :base(Tags.LegIssueDate, val) {}

    }


    /// <summary>
    /// LegRepoCollateralSecurityType Field
    /// </summary>/
    public sealed class LegRepoCollateralSecurityType : IntField
    {
        public const int TAG = 250;

        public LegRepoCollateralSecurityType()
            :base(Tags.LegRepoCollateralSecurityType) {}
        public LegRepoCollateralSecurityType(int val)
            :base(Tags.LegRepoCollateralSecurityType, val) {}

    }


    /// <summary>
    /// LegRepurchaseTerm Field
    /// </summary>/
    public sealed class LegRepurchaseTerm : IntField
    {
        public const int TAG = 251;

        public LegRepurchaseTerm()
            :base(Tags.LegRepurchaseTerm) {}
        public LegRepurchaseTerm(int val)
            :base(Tags.LegRepurchaseTerm, val) {}

    }


    /// <summary>
    /// LegRepurchaseRate Field
    /// </summary>/
    public sealed class LegRepurchaseRate : DecimalField
    {
        public const int TAG = 252;

        public LegRepurchaseRate()
            :base(Tags.LegRepurchaseRate) {}
        public LegRepurchaseRate(Decimal val)
            :base(Tags.LegRepurchaseRate, val) {}

    }


    /// <summary>
    /// LegFactor Field
    /// </summary>/
    public sealed class LegFactor : DecimalField
    {
        public const int TAG = 253;

        public LegFactor()
            :base(Tags.LegFactor) {}
        public LegFactor(Decimal val)
            :base(Tags.LegFactor, val) {}

    }


    /// <summary>
    /// LegRedemptionDate Field
    /// </summary>/
    public sealed class LegRedemptionDate : StringField
    {
        public const int TAG = 254;

        public LegRedemptionDate()
            :base(Tags.LegRedemptionDate) {}
        public LegRedemptionDate(string val)
            :base(Tags.LegRedemptionDate, val) {}

    }


    /// <summary>
    /// CreditRating Field
    /// </summary>/
    public sealed class CreditRating : StringField
    {
        public const int TAG = 255;

        public CreditRating()
            :base(Tags.CreditRating) {}
        public CreditRating(string val)
            :base(Tags.CreditRating, val) {}

    }


    /// <summary>
    /// UnderlyingCreditRating Field
    /// </summary>/
    public sealed class UnderlyingCreditRating : StringField
    {
        public const int TAG = 256;

        public UnderlyingCreditRating()
            :base(Tags.UnderlyingCreditRating) {}
        public UnderlyingCreditRating(string val)
            :base(Tags.UnderlyingCreditRating, val) {}

    }


    /// <summary>
    /// LegCreditRating Field
    /// </summary>/
    public sealed class LegCreditRating : StringField
    {
        public const int TAG = 257;

        public LegCreditRating()
            :base(Tags.LegCreditRating) {}
        public LegCreditRating(string val)
            :base(Tags.LegCreditRating, val) {}

    }


    /// <summary>
    /// TradedFlatSwitch Field
    /// </summary>/
    public sealed class TradedFlatSwitch : BooleanField
    {
        public const int TAG = 258;

        public TradedFlatSwitch()
            :base(Tags.TradedFlatSwitch) {}
        public TradedFlatSwitch(Boolean val)
            :base(Tags.TradedFlatSwitch, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// BasisFeatureDate Field
    /// </summary>/
    public sealed class BasisFeatureDate : StringField
    {
        public const int TAG = 259;

        public BasisFeatureDate()
            :base(Tags.BasisFeatureDate) {}
        public BasisFeatureDate(string val)
            :base(Tags.BasisFeatureDate, val) {}

    }


    /// <summary>
    /// BasisFeaturePrice Field
    /// </summary>/
    public sealed class BasisFeaturePrice : DecimalField
    {
        public const int TAG = 260;

        public BasisFeaturePrice()
            :base(Tags.BasisFeaturePrice) {}
        public BasisFeaturePrice(Decimal val)
            :base(Tags.BasisFeaturePrice, val) {}

    }


    /// <summary>
    /// QuoteStatus Field
    /// </summary>/
    public sealed class QuoteStatus : IntField
    {
        public const int TAG = 297;

        public QuoteStatus()
            :base(Tags.QuoteStatus) {}
        public QuoteStatus(int val)
            :base(Tags.QuoteStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int CANCEL_FOR_SYMBOL = 1;
        public const int PENDING = 10;
        public const int PASS = 11;
        public const int LOCKED_MARKET_WARNING = 12;
        public const int CROSS_MARKET_WARNING = 13;
        public const int CANCELED_DUE_TO_LOCK_MARKET = 14;
        public const int CANCELED_DUE_TO_CROSS_MARKET = 15;
        public const int CANCELED_FOR_SECURITY_TYPE = 2;
        public const int CANCELED_FOR_UNDERLYING = 3;
        public const int CANCELED_ALL = 4;
        public const int REJECTED = 5;
        public const int REMOVED_FROM_MARKET = 6;
        public const int EXPIRED = 7;
        public const int QUERY = 8;
        public const int QUOTE_NOT_FOUND = 9;
        public const int ACTIVE = 16;
        public const int CANCELED = 17;
        public const int UNSOLICITED_QUOTE_REPLENISHMENT = 18;
        public const int PENDING_END_TRADE = 19;
        public const int TOO_LATE_TO_END = 20;
        public const int CANCELED_FOR_SYMBOL = 1;
    }


    /// <summary>
    /// UnderlyingSecurityIDSource Field
    /// </summary>/
    public sealed class UnderlyingSecurityIDSource : StringField
    {
        public const int TAG = 305;

        public UnderlyingSecurityIDSource()
            :base(Tags.UnderlyingSecurityIDSource) {}
        public UnderlyingSecurityIDSource(string val)
            :base(Tags.UnderlyingSecurityIDSource, val) {}

    }


    /// <summary>
    /// PartyIDSource Field
    /// </summary>/
    public sealed class PartyIDSource : CharField
    {
        public const int TAG = 447;

        public PartyIDSource()
            :base(Tags.PartyIDSource) {}
        public PartyIDSource(char val)
            :base(Tags.PartyIDSource, val) {}


        // Field Enumerations
        public const char KOREAN_INVESTOR_ID = '1';
        public const char TAIWANESE_QUALIFIED_FOREIGN_INVESTOR_ID_QFII_FID = '2';
        public const char TAIWANESE_TRADING_ACCT = '3';
        public const char MALAYSIAN_CENTRAL_DEPOSITORY = '4';
        public const char CHINESE_INVESTOR_ID = '5';
        public const char UK_NATIONAL_INSURANCE_OR_PENSION_NUMBER = '6';
        public const char US_SOCIAL_SECURITY_NUMBER = '7';
        public const char US_EMPLOYER_OR_TAX_ID_NUMBER = '8';
        public const char AUSTRALIAN_BUSINESS_NUMBER = '9';
        public const char AUSTRALIAN_TAX_FILE_NUMBER = 'A';
        public const char BIC = 'B';
        public const char GENERALLY_ACCEPTED_MARKET_PARTICIPANT_IDENTIFIER = 'C';
        public const char PROPRIETARY = 'D';
        public const char ISO_COUNTRY_CODE = 'E';
        public const char SETTLEMENT_ENTITY_LOCATION = 'F';
        public const char MIC = 'G';
        public const char CSD_PARTICIPANT_MEMBER_CODE = 'H';
        public const char DIRECTED_BROKER_THREE_CHARACTER_ACRONYM_AS_DEFINED_IN_ISITC_ETC_BEST_PRACTICE_GUIDELINES_DOCUMENT = 'I';
        public const char PROPRIETARY_CUSTOM_CODE = 'D';
        public const char TAIWANESE_TRADING_ACCOUNT = '3';
        public const char MALAYSIAN_CENTRAL_DEPOSITORY_NUMBER = '4';
        public const char CHINESE_B_SHARE = '5';
        public const char US_EMPLOYER_IDENTIFICATION_NUMBER = '8';
        public const char DIRECTED_BROKER = 'I';
        public const char TAIWANESE_QUALIFIED_FOREIGN_INVESTOR_ID_QFII = '2';
    }


    /// <summary>
    /// PartyID Field
    /// </summary>/
    public sealed class PartyID : StringField
    {
        public const int TAG = 448;

        public PartyID()
            :base(Tags.PartyID) {}
        public PartyID(string val)
            :base(Tags.PartyID, val) {}

    }


    /// <summary>
    /// TotalVolumeTradedDate Field
    /// </summary>/
    public sealed class TotalVolumeTradedDate : DateOnlyField
    {
        public const int TAG = 449;

        public TotalVolumeTradedDate()
            :base(Tags.TotalVolumeTradedDate) {}
        public TotalVolumeTradedDate(DateTime val)
            :base(Tags.TotalVolumeTradedDate, val) {}

    }


    /// <summary>
    /// TotalVolumeTradedTime Field
    /// </summary>/
    public sealed class TotalVolumeTradedTime : TimeOnlyField
    {
        public const int TAG = 450;

        public TotalVolumeTradedTime()
            :base(Tags.TotalVolumeTradedTime) {}
        public TotalVolumeTradedTime(DateTime val)
            :base(Tags.TotalVolumeTradedTime, val) {}
        public TotalVolumeTradedTime(DateTime val, bool showMilliseconds)
            :base(Tags.TotalVolumeTradedTime, val, showMilliseconds) {}
		public TotalVolumeTradedTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TotalVolumeTradedTime, val, precision) {}

    }


    /// <summary>
    /// NetChgPrevDay Field
    /// </summary>/
    public sealed class NetChgPrevDay : DecimalField
    {
        public const int TAG = 451;

        public NetChgPrevDay()
            :base(Tags.NetChgPrevDay) {}
        public NetChgPrevDay(Decimal val)
            :base(Tags.NetChgPrevDay, val) {}

    }


    /// <summary>
    /// PartyRole Field
    /// </summary>/
    public sealed class PartyRole : IntField
    {
        public const int TAG = 452;

        public PartyRole()
            :base(Tags.PartyRole) {}
        public PartyRole(int val)
            :base(Tags.PartyRole, val) {}


        // Field Enumerations
        public const int EXECUTING_FIRM = 1;
        public const int SETTLEMENT_LOCATION = 10;
        public const int ORDER_ORIGINATION_TRADER = 11;
        public const int EXECUTING_TRADER = 12;
        public const int ORDER_ORIGINATION_FIRM = 13;
        public const int GIVEUP_CLEARING_FIRM = 14;
        public const int CORRESPONDANT_CLEARING_FIRM = 15;
        public const int EXECUTING_SYSTEM = 16;
        public const int CONTRA_FIRM = 17;
        public const int CONTRA_CLEARING_FIRM = 18;
        public const int SPONSORING_FIRM = 19;
        public const int BROKER_OF_CREDIT = 2;
        public const int UNDERLYING_CONTRA_FIRM = 20;
        public const int CLEARING_ORGANIZATION = 21;
        public const int EXCHANGE = 22;
        public const int CUSTOMER_ACCOUNT = 24;
        public const int CORRESPONDENT_CLEARING_ORGANIZATION = 25;
        public const int CORRESPONDENT_BROKER = 26;
        public const int BUYER_SELLER = 27;
        public const int CUSTODIAN = 28;
        public const int INTERMEDIARY = 29;
        public const int CLIENT_ID = 3;
        public const int AGENT = 30;
        public const int SUB_CUSTODIAN = 31;
        public const int BENEFICIARY = 32;
        public const int INTERESTED_PARTY = 33;
        public const int REGULATORY_BODY = 34;
        public const int LIQUIDITY_PROVIDER = 35;
        public const int ENTERING_TRADER = 36;
        public const int CONTRA_TRADER = 37;
        public const int POSITION_ACCOUNT = 38;
        public const int CLEARING_FIRM = 4;
        public const int INVESTOR_ID = 5;
        public const int INTRODUCING_FIRM = 6;
        public const int ENTERING_FIRM = 7;
        public const int LOCATE = 8;
        public const int FUND_MANAGER_CLIENT_ID = 9;
        public const int INTRODUCING_BROKER = 60;
        public const int CONTRA_POSITION_ACCOUNT = 41;
        public const int CONTRA_EXCHANGE = 42;
        public const int INTERNAL_CARRY_ACCOUNT = 43;
        public const int ORDER_ENTRY_OPERATOR_ID = 44;
        public const int SECONDARY_ACCOUNT_NUMBER = 45;
        public const int FOREIGN_FIRM = 46;
        public const int THIRD_PARTY_ALLOCATION_FIRM = 47;
        public const int CLAIMING_ACCOUNT = 48;
        public const int ASSET_MANAGER = 49;
        public const int PLEDGOR_ACCOUNT = 50;
        public const int PLEDGEE_ACCOUNT = 51;
        public const int LARGE_TRADER_REPORTABLE_ACCOUNT = 52;
        public const int TRADER_MNEMONIC = 53;
        public const int SENDER_LOCATION = 54;
        public const int SESSION_ID = 55;
        public const int ACCEPTABLE_COUNTERPARTY = 56;
        public const int UNACCEPTABLE_COUNTERPARTY = 57;
        public const int ENTERING_UNIT = 58;
        public const int EXECUTING_UNIT = 59;
        public const int CONTRA_INVESTOR_ID = 39;
        public const int TRANSFER_TO_FIRM = 40;
        public const int QUOTE_ORIGINATOR = 61;
        public const int REPORT_ORIGINATOR = 62;
        public const int SYSTEMATIC_INTERNALISER = 63;
        public const int MULTILATERAL_TRADING_FACILITY = 64;
        public const int REGULATED_MARKET = 65;
        public const int MARKET_MAKER = 66;
        public const int INVESTMENT_FIRM = 67;
        public const int HOST_COMPETENT_AUTHORITY = 68;
        public const int HOME_COMPETENT_AUTHORITY = 69;
        public const int COMPETENT_AUTHORITY_OF_THE_MOST_RELEVANT_MARKET_IN_TERMS_OF_LIQUIDITY = 70;
        public const int COMPETENT_AUTHORITY_OF_THE_TRANSACTION = 71;
        public const int REPORTING_INTERMEDIARY = 72;
        public const int EXECUTION_VENUE = 73;
        public const int MARKET_DATA_ENTRY_ORIGINATOR = 74;
        public const int LOCATION_ID = 75;
        public const int DESK_ID = 76;
        public const int MARKET_DATA_MARKET = 77;
        public const int ALLOCATION_ENTITY = 78;
        public const int PRIME_BROKER_PROVIDING_GENERAL_TRADE_SERVICES = 79;
        public const int STEP_OUT_FIRM = 80;
        public const int BROKERCLEARINGID = 81;
        public const int CENTRAL_REGISTRATION_DEPOSITORY = 82;
        public const int CLEARING_ACCOUNT = 83;
        public const int ACCEPTABLE_SETTLING_COUNTERPARTY = 84;
        public const int UNACCEPTABLE_SETTLING_COUNTERPARTY = 85;
        public const int FORIEGN_FIRM = 46;
        public const int LOCATE_LENDING_FIRM = 8;
    }


    /// <summary>
    /// NoPartyIDs Field
    /// </summary>/
    public sealed class NoPartyIDs : IntField
    {
        public const int TAG = 453;

        public NoPartyIDs()
            :base(Tags.NoPartyIDs) {}
        public NoPartyIDs(int val)
            :base(Tags.NoPartyIDs, val) {}

    }


    /// <summary>
    /// NoSecurityAltID Field
    /// </summary>/
    public sealed class NoSecurityAltID : IntField
    {
        public const int TAG = 454;

        public NoSecurityAltID()
            :base(Tags.NoSecurityAltID) {}
        public NoSecurityAltID(int val)
            :base(Tags.NoSecurityAltID, val) {}

    }


    /// <summary>
    /// SecurityAltID Field
    /// </summary>/
    public sealed class SecurityAltID : StringField
    {
        public const int TAG = 455;

        public SecurityAltID()
            :base(Tags.SecurityAltID) {}
        public SecurityAltID(string val)
            :base(Tags.SecurityAltID, val) {}

    }


    /// <summary>
    /// SecurityAltIDSource Field
    /// </summary>/
    public sealed class SecurityAltIDSource : StringField
    {
        public const int TAG = 456;

        public SecurityAltIDSource()
            :base(Tags.SecurityAltIDSource) {}
        public SecurityAltIDSource(string val)
            :base(Tags.SecurityAltIDSource, val) {}

    }


    /// <summary>
    /// NoUnderlyingSecurityAltID Field
    /// </summary>/
    public sealed class NoUnderlyingSecurityAltID : IntField
    {
        public const int TAG = 457;

        public NoUnderlyingSecurityAltID()
            :base(Tags.NoUnderlyingSecurityAltID) {}
        public NoUnderlyingSecurityAltID(int val)
            :base(Tags.NoUnderlyingSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityAltID Field
    /// </summary>/
    public sealed class UnderlyingSecurityAltID : StringField
    {
        public const int TAG = 458;

        public UnderlyingSecurityAltID()
            :base(Tags.UnderlyingSecurityAltID) {}
        public UnderlyingSecurityAltID(string val)
            :base(Tags.UnderlyingSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingSecurityAltIDSource Field
    /// </summary>/
    public sealed class UnderlyingSecurityAltIDSource : StringField
    {
        public const int TAG = 459;

        public UnderlyingSecurityAltIDSource()
            :base(Tags.UnderlyingSecurityAltIDSource) {}
        public UnderlyingSecurityAltIDSource(string val)
            :base(Tags.UnderlyingSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// Product Field
    /// </summary>/
    public sealed class Product : IntField
    {
        public const int TAG = 460;

        public Product()
            :base(Tags.Product) {}
        public Product(int val)
            :base(Tags.Product, val) {}


        // Field Enumerations
        public const int AGENCY = 1;
        public const int MORTGAGE = 10;
        public const int MUNICIPAL = 11;
        public const int OTHER = 12;
        public const int FINANCING = 13;
        public const int COMMODITY = 2;
        public const int CORPORATE = 3;
        public const int CURRENCY = 4;
        public const int EQUITY = 5;
        public const int GOVERNMENT = 6;
        public const int INDEX = 7;
        public const int LOAN = 8;
        public const int MONEYMARKET = 9;
    }


    /// <summary>
    /// CFICode Field
    /// </summary>/
    public sealed class CFICode : StringField
    {
        public const int TAG = 461;

        public CFICode()
            :base(Tags.CFICode) {}
        public CFICode(string val)
            :base(Tags.CFICode, val) {}

    }


    /// <summary>
    /// UnderlyingProduct Field
    /// </summary>/
    public sealed class UnderlyingProduct : IntField
    {
        public const int TAG = 462;

        public UnderlyingProduct()
            :base(Tags.UnderlyingProduct) {}
        public UnderlyingProduct(int val)
            :base(Tags.UnderlyingProduct, val) {}

    }


    /// <summary>
    /// UnderlyingCFICode Field
    /// </summary>/
    public sealed class UnderlyingCFICode : StringField
    {
        public const int TAG = 463;

        public UnderlyingCFICode()
            :base(Tags.UnderlyingCFICode) {}
        public UnderlyingCFICode(string val)
            :base(Tags.UnderlyingCFICode, val) {}

    }


    /// <summary>
    /// TestMessageIndicator Field
    /// </summary>/
    public sealed class TestMessageIndicator : BooleanField
    {
        public const int TAG = 464;

        public TestMessageIndicator()
            :base(Tags.TestMessageIndicator) {}
        public TestMessageIndicator(Boolean val)
            :base(Tags.TestMessageIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// QuantityType Field
    /// </summary>/
    public sealed class QuantityType : IntField
    {
        public const int TAG = 465;

        public QuantityType()
            :base(Tags.QuantityType) {}
        public QuantityType(int val)
            :base(Tags.QuantityType, val) {}


        // Field Enumerations
        public const int SHARES = 1;
        public const int BONDS = 2;
        public const int CURRENTFACE = 3;
        public const int ORIGINALFACE = 4;
        public const int CURRENCY = 5;
        public const int CONTRACTS = 6;
        public const int OTHER = 7;
        public const int PAR = 8;
    }


    /// <summary>
    /// BookingRefID Field
    /// </summary>/
    public sealed class BookingRefID : StringField
    {
        public const int TAG = 466;

        public BookingRefID()
            :base(Tags.BookingRefID) {}
        public BookingRefID(string val)
            :base(Tags.BookingRefID, val) {}

    }


    /// <summary>
    /// IndividualAllocID Field
    /// </summary>/
    public sealed class IndividualAllocID : StringField
    {
        public const int TAG = 467;

        public IndividualAllocID()
            :base(Tags.IndividualAllocID) {}
        public IndividualAllocID(string val)
            :base(Tags.IndividualAllocID, val) {}

    }


    /// <summary>
    /// RoundingDirection Field
    /// </summary>/
    public sealed class RoundingDirection : CharField
    {
        public const int TAG = 468;

        public RoundingDirection()
            :base(Tags.RoundingDirection) {}
        public RoundingDirection(char val)
            :base(Tags.RoundingDirection, val) {}


        // Field Enumerations
        public const char ROUND_TO_NEAREST = '0';
        public const char ROUND_DOWN = '1';
        public const char ROUND_UP = '2';
    }


    /// <summary>
    /// RoundingModulus Field
    /// </summary>/
    public sealed class RoundingModulus : DecimalField
    {
        public const int TAG = 469;

        public RoundingModulus()
            :base(Tags.RoundingModulus) {}
        public RoundingModulus(Decimal val)
            :base(Tags.RoundingModulus, val) {}

    }


    /// <summary>
    /// CountryOfIssue Field
    /// </summary>/
    public sealed class CountryOfIssue : StringField
    {
        public const int TAG = 470;

        public CountryOfIssue()
            :base(Tags.CountryOfIssue) {}
        public CountryOfIssue(string val)
            :base(Tags.CountryOfIssue, val) {}

    }


    /// <summary>
    /// StateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class StateOrProvinceOfIssue : StringField
    {
        public const int TAG = 471;

        public StateOrProvinceOfIssue()
            :base(Tags.StateOrProvinceOfIssue) {}
        public StateOrProvinceOfIssue(string val)
            :base(Tags.StateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// LocaleOfIssue Field
    /// </summary>/
    public sealed class LocaleOfIssue : StringField
    {
        public const int TAG = 472;

        public LocaleOfIssue()
            :base(Tags.LocaleOfIssue) {}
        public LocaleOfIssue(string val)
            :base(Tags.LocaleOfIssue, val) {}

    }


    /// <summary>
    /// NoRegistDtls Field
    /// </summary>/
    public sealed class NoRegistDtls : IntField
    {
        public const int TAG = 473;

        public NoRegistDtls()
            :base(Tags.NoRegistDtls) {}
        public NoRegistDtls(int val)
            :base(Tags.NoRegistDtls, val) {}

    }


    /// <summary>
    /// MailingDtls Field
    /// </summary>/
    public sealed class MailingDtls : StringField
    {
        public const int TAG = 474;

        public MailingDtls()
            :base(Tags.MailingDtls) {}
        public MailingDtls(string val)
            :base(Tags.MailingDtls, val) {}

    }


    /// <summary>
    /// InvestorCountryOfResidence Field
    /// </summary>/
    public sealed class InvestorCountryOfResidence : StringField
    {
        public const int TAG = 475;

        public InvestorCountryOfResidence()
            :base(Tags.InvestorCountryOfResidence) {}
        public InvestorCountryOfResidence(string val)
            :base(Tags.InvestorCountryOfResidence, val) {}

    }


    /// <summary>
    /// PaymentRef Field
    /// </summary>/
    public sealed class PaymentRef : StringField
    {
        public const int TAG = 476;

        public PaymentRef()
            :base(Tags.PaymentRef) {}
        public PaymentRef(string val)
            :base(Tags.PaymentRef, val) {}

    }


    /// <summary>
    /// DistribPaymentMethod Field
    /// </summary>/
    public sealed class DistribPaymentMethod : IntField
    {
        public const int TAG = 477;

        public DistribPaymentMethod()
            :base(Tags.DistribPaymentMethod) {}
        public DistribPaymentMethod(int val)
            :base(Tags.DistribPaymentMethod, val) {}


        // Field Enumerations
        public const int CREST = 1;
        public const int BPAY = 10;
        public const int HIGH_VALUE_CLEARING_SYSTEM_HVACS = 11;
        public const int REINVEST_IN_FUND = 12;
        public const int NSCC = 2;
        public const int EUROCLEAR = 3;
        public const int CLEARSTREAM = 4;
        public const int CHEQUE = 5;
        public const int TELEGRAPHIC_TRANSFER = 6;
        public const int FED_WIRE = 7;
        public const int DIRECT_CREDIT = 8;
        public const int ACH_CREDIT = 9;
        public const int FEDWIRE = 7;
        public const int HIGH_VALUE_CLEARING_SYSTEM = 11;
    }


    /// <summary>
    /// CashDistribCurr Field
    /// </summary>/
    public sealed class CashDistribCurr : StringField
    {
        public const int TAG = 478;

        public CashDistribCurr()
            :base(Tags.CashDistribCurr) {}
        public CashDistribCurr(string val)
            :base(Tags.CashDistribCurr, val) {}

    }


    /// <summary>
    /// CommCurrency Field
    /// </summary>/
    public sealed class CommCurrency : StringField
    {
        public const int TAG = 479;

        public CommCurrency()
            :base(Tags.CommCurrency) {}
        public CommCurrency(string val)
            :base(Tags.CommCurrency, val) {}

    }


    /// <summary>
    /// CancellationRights Field
    /// </summary>/
    public sealed class CancellationRights : CharField
    {
        public const int TAG = 480;

        public CancellationRights()
            :base(Tags.CancellationRights) {}
        public CancellationRights(char val)
            :base(Tags.CancellationRights, val) {}


        // Field Enumerations
        public const char NO_M = 'M';
        public const char NO_N = 'N';
        public const char NO_O = 'O';
        public const char YES = 'Y';
        public const char NO_EXECUTION_ONLY = 'N';
        public const char NO_WAIVER_AGREEMENT = 'M';
        public const char NO_INSTITUTIONAL = 'O';
    }


    /// <summary>
    /// MoneyLaunderingStatus Field
    /// </summary>/
    public sealed class MoneyLaunderingStatus : CharField
    {
        public const int TAG = 481;

        public MoneyLaunderingStatus()
            :base(Tags.MoneyLaunderingStatus) {}
        public MoneyLaunderingStatus(char val)
            :base(Tags.MoneyLaunderingStatus, val) {}


        // Field Enumerations
        public const char EXEMPT_1 = '1';
        public const char EXEMPT_2 = '2';
        public const char EXEMPT_3 = '3';
        public const char NOT_CHECKED = 'N';
        public const char PASSED = 'Y';
        public const char EXEMPT_BELOW_THE_LIMIT = '1';
        public const char EXEMPT_CLIENT_MONEY_TYPE_EXEMPTION = '2';
        public const char EXEMPT_AUTHORISED_CREDIT_OR_FINANCIAL_INSTITUTION = '3';
    }


    /// <summary>
    /// MailingInst Field
    /// </summary>/
    public sealed class MailingInst : StringField
    {
        public const int TAG = 482;

        public MailingInst()
            :base(Tags.MailingInst) {}
        public MailingInst(string val)
            :base(Tags.MailingInst, val) {}

    }


    /// <summary>
    /// TransBkdTime Field
    /// </summary>/
    public sealed class TransBkdTime : DateTimeField
    {
        public const int TAG = 483;

        public TransBkdTime()
            :base(Tags.TransBkdTime) {}
        public TransBkdTime(DateTime val)
            :base(Tags.TransBkdTime, val) {}
        public TransBkdTime(DateTime val, bool showMilliseconds)
            :base(Tags.TransBkdTime, val, showMilliseconds) {}
		public TransBkdTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TransBkdTime, val, precision) {}

    }


    /// <summary>
    /// ExecPriceType Field
    /// </summary>/
    public sealed class ExecPriceType : CharField
    {
        public const int TAG = 484;

        public ExecPriceType()
            :base(Tags.ExecPriceType) {}
        public ExecPriceType(char val)
            :base(Tags.ExecPriceType, val) {}


        // Field Enumerations
        public const char BID_PRICE = 'B';
        public const char CREATION_PRICE = 'C';
        public const char CREATION_PRICE_PLUS_ADJUSTMENT_PERCENT = 'D';
        public const char CREATION_PRICE_PLUS_ADJUSTMENT_AMOUNT = 'E';
        public const char OFFER_PRICE = 'O';
        public const char OFFER_PRICE_MINUS_ADJUSTMENT_PERCENT = 'P';
        public const char OFFER_PRICE_MINUS_ADJUSTMENT_AMOUNT = 'Q';
        public const char SINGLE_PRICE = 'S';
    }


    /// <summary>
    /// ExecPriceAdjustment Field
    /// </summary>/
    public sealed class ExecPriceAdjustment : DecimalField
    {
        public const int TAG = 485;

        public ExecPriceAdjustment()
            :base(Tags.ExecPriceAdjustment) {}
        public ExecPriceAdjustment(Decimal val)
            :base(Tags.ExecPriceAdjustment, val) {}

    }


    /// <summary>
    /// DateOfBirth Field
    /// </summary>/
    public sealed class DateOfBirth : StringField
    {
        public const int TAG = 486;

        public DateOfBirth()
            :base(Tags.DateOfBirth) {}
        public DateOfBirth(string val)
            :base(Tags.DateOfBirth, val) {}

    }


    /// <summary>
    /// TradeReportTransType Field
    /// </summary>/
    public sealed class TradeReportTransType : IntField
    {
        public const int TAG = 487;

        public TradeReportTransType()
            :base(Tags.TradeReportTransType) {}
        public TradeReportTransType(int val)
            :base(Tags.TradeReportTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int CANCEL = 1;
        public const int REPLACE = 2;
        public const int RELEASE = 3;
        public const int REVERSE = 4;
        public const int CANCEL_DUE_TO_BACK_OUT_OF_TRADE = 5;
    }


    /// <summary>
    /// CardHolderName Field
    /// </summary>/
    public sealed class CardHolderName : StringField
    {
        public const int TAG = 488;

        public CardHolderName()
            :base(Tags.CardHolderName) {}
        public CardHolderName(string val)
            :base(Tags.CardHolderName, val) {}

    }


    /// <summary>
    /// CardNumber Field
    /// </summary>/
    public sealed class CardNumber : StringField
    {
        public const int TAG = 489;

        public CardNumber()
            :base(Tags.CardNumber) {}
        public CardNumber(string val)
            :base(Tags.CardNumber, val) {}

    }


    /// <summary>
    /// CardExpDate Field
    /// </summary>/
    public sealed class CardExpDate : StringField
    {
        public const int TAG = 490;

        public CardExpDate()
            :base(Tags.CardExpDate) {}
        public CardExpDate(string val)
            :base(Tags.CardExpDate, val) {}

    }


    /// <summary>
    /// CardIssNo Field
    /// </summary>/
    public sealed class CardIssNo : StringField
    {
        public const int TAG = 491;

        public CardIssNo()
            :base(Tags.CardIssNo) {}
        public CardIssNo(string val)
            :base(Tags.CardIssNo, val) {}

    }


    /// <summary>
    /// PaymentMethod Field
    /// </summary>/
    public sealed class PaymentMethod : IntField
    {
        public const int TAG = 492;

        public PaymentMethod()
            :base(Tags.PaymentMethod) {}
        public PaymentMethod(int val)
            :base(Tags.PaymentMethod, val) {}


        // Field Enumerations
        public const int CREST = 1;
        public const int DIRECT_CREDIT = 10;
        public const int CREDIT_CARD = 11;
        public const int ACH_DEBIT = 12;
        public const int ACH_CREDIT = 13;
        public const int BPAY = 14;
        public const int HIGH_VALUE_CLEARING_SYSTEM = 15;
        public const int NSCC = 2;
        public const int EUROCLEAR = 3;
        public const int CLEARSTREAM = 4;
        public const int CHEQUE = 5;
        public const int TELEGRAPHIC_TRANSFER = 6;
        public const int FED_WIRE = 7;
        public const int DEBIT_CARD = 8;
        public const int DIRECT_DEBIT = 9;
        public const int FEDWIRE = 7;
    }


    /// <summary>
    /// RegistAcctType Field
    /// </summary>/
    public sealed class RegistAcctType : StringField
    {
        public const int TAG = 493;

        public RegistAcctType()
            :base(Tags.RegistAcctType) {}
        public RegistAcctType(string val)
            :base(Tags.RegistAcctType, val) {}

    }


    /// <summary>
    /// Designation Field
    /// </summary>/
    public sealed class Designation : StringField
    {
        public const int TAG = 494;

        public Designation()
            :base(Tags.Designation) {}
        public Designation(string val)
            :base(Tags.Designation, val) {}

    }


    /// <summary>
    /// TaxAdvantageType Field
    /// </summary>/
    public sealed class TaxAdvantageType : IntField
    {
        public const int TAG = 495;

        public TaxAdvantageType()
            :base(Tags.TaxAdvantageType) {}
        public TaxAdvantageType(int val)
            :base(Tags.TaxAdvantageType, val) {}


        // Field Enumerations
        public const int NONE_NOT_APPLICABLE = 0;
        public const int MAXI_ISA = 1;
        public const int EMPLOYEE_10 = 10;
        public const int EMPLOYER_11 = 11;
        public const int EMPLOYER_12 = 12;
        public const int NON_FUND_PROTOTYPE_IRA = 13;
        public const int NON_FUND_QUALIFIED_PLAN = 14;
        public const int DEFINED_CONTRIBUTION_PLAN = 15;
        public const int INDIVIDUAL_RETIREMENT_ACCOUNT_16 = 16;
        public const int INDIVIDUAL_RETIREMENT_ACCOUNT_17 = 17;
        public const int KEOGH = 18;
        public const int PROFIT_SHARING_PLAN = 19;
        public const int TESSA = 2;
        public const int VAL_401 = 20;
        public const int SELF_DIRECTED_IRA = 21;
        public const int VAL_403 = 22;
        public const int VAL_457 = 23;
        public const int ROTH_IRA_24 = 24;
        public const int ROTH_IRA_25 = 25;
        public const int ROTH_CONVERSION_IRA_26 = 26;
        public const int ROTH_CONVERSION_IRA_27 = 27;
        public const int EDUCATION_IRA_28 = 28;
        public const int EDUCATION_IRA_29 = 29;
        public const int MINI_CASH_ISA = 3;
        public const int MINI_STOCKS_AND_SHARES_ISA = 4;
        public const int MINI_INSURANCE_ISA = 5;
        public const int CURRENT_YEAR_PAYMENT = 6;
        public const int PRIOR_YEAR_PAYMENT = 7;
        public const int ASSET_TRANSFER = 8;
        public const int EMPLOYEE_9 = 9;
        public const int OTHER = 999;
        public const int NONE = 0;
        public const int EMPLOYEE_PRIOR_YEAR = 9;
    }


    /// <summary>
    /// RegistRejReasonText Field
    /// </summary>/
    public sealed class RegistRejReasonText : StringField
    {
        public const int TAG = 496;

        public RegistRejReasonText()
            :base(Tags.RegistRejReasonText) {}
        public RegistRejReasonText(string val)
            :base(Tags.RegistRejReasonText, val) {}

    }


    /// <summary>
    /// FundRenewWaiv Field
    /// </summary>/
    public sealed class FundRenewWaiv : CharField
    {
        public const int TAG = 497;

        public FundRenewWaiv()
            :base(Tags.FundRenewWaiv) {}
        public FundRenewWaiv(char val)
            :base(Tags.FundRenewWaiv, val) {}


        // Field Enumerations
        public const char NO = 'N';
        public const char YES = 'Y';
    }


    /// <summary>
    /// CashDistribAgentName Field
    /// </summary>/
    public sealed class CashDistribAgentName : StringField
    {
        public const int TAG = 498;

        public CashDistribAgentName()
            :base(Tags.CashDistribAgentName) {}
        public CashDistribAgentName(string val)
            :base(Tags.CashDistribAgentName, val) {}

    }


    /// <summary>
    /// CashDistribAgentCode Field
    /// </summary>/
    public sealed class CashDistribAgentCode : StringField
    {
        public const int TAG = 499;

        public CashDistribAgentCode()
            :base(Tags.CashDistribAgentCode) {}
        public CashDistribAgentCode(string val)
            :base(Tags.CashDistribAgentCode, val) {}

    }


    /// <summary>
    /// CashDistribAgentAcctNumber Field
    /// </summary>/
    public sealed class CashDistribAgentAcctNumber : StringField
    {
        public const int TAG = 500;

        public CashDistribAgentAcctNumber()
            :base(Tags.CashDistribAgentAcctNumber) {}
        public CashDistribAgentAcctNumber(string val)
            :base(Tags.CashDistribAgentAcctNumber, val) {}

    }


    /// <summary>
    /// CashDistribPayRef Field
    /// </summary>/
    public sealed class CashDistribPayRef : StringField
    {
        public const int TAG = 501;

        public CashDistribPayRef()
            :base(Tags.CashDistribPayRef) {}
        public CashDistribPayRef(string val)
            :base(Tags.CashDistribPayRef, val) {}

    }


    /// <summary>
    /// CashDistribAgentAcctName Field
    /// </summary>/
    public sealed class CashDistribAgentAcctName : StringField
    {
        public const int TAG = 502;

        public CashDistribAgentAcctName()
            :base(Tags.CashDistribAgentAcctName) {}
        public CashDistribAgentAcctName(string val)
            :base(Tags.CashDistribAgentAcctName, val) {}

    }


    /// <summary>
    /// CardStartDate Field
    /// </summary>/
    public sealed class CardStartDate : StringField
    {
        public const int TAG = 503;

        public CardStartDate()
            :base(Tags.CardStartDate) {}
        public CardStartDate(string val)
            :base(Tags.CardStartDate, val) {}

    }


    /// <summary>
    /// PaymentDate Field
    /// </summary>/
    public sealed class PaymentDate : StringField
    {
        public const int TAG = 504;

        public PaymentDate()
            :base(Tags.PaymentDate) {}
        public PaymentDate(string val)
            :base(Tags.PaymentDate, val) {}

    }


    /// <summary>
    /// PaymentRemitterID Field
    /// </summary>/
    public sealed class PaymentRemitterID : StringField
    {
        public const int TAG = 505;

        public PaymentRemitterID()
            :base(Tags.PaymentRemitterID) {}
        public PaymentRemitterID(string val)
            :base(Tags.PaymentRemitterID, val) {}

    }


    /// <summary>
    /// RegistStatus Field
    /// </summary>/
    public sealed class RegistStatus : CharField
    {
        public const int TAG = 506;

        public RegistStatus()
            :base(Tags.RegistStatus) {}
        public RegistStatus(char val)
            :base(Tags.RegistStatus, val) {}


        // Field Enumerations
        public const char ACCEPTED = 'A';
        public const char HELD = 'H';
        public const char REMINDER = 'N';
        public const char REJECTED = 'R';
    }


    /// <summary>
    /// RegistRejReasonCode Field
    /// </summary>/
    public sealed class RegistRejReasonCode : IntField
    {
        public const int TAG = 507;

        public RegistRejReasonCode()
            :base(Tags.RegistRejReasonCode) {}
        public RegistRejReasonCode(int val)
            :base(Tags.RegistRejReasonCode, val) {}


        // Field Enumerations
        public const int INVALID_UNACCEPTABLE_ACCOUNT_TYPE = 1;
        public const int INVALID_UNACEEPTABLE_INVESTOR_ID_SOURCE = 10;
        public const int INVALID_UNACCEPTABLE_DATE_OF_BIRTH = 11;
        public const int INVALID_UNACCEPTABLE_INVESTOR_COUNTRY_OF_RESIDENCE = 12;
        public const int INVALID_UNACCEPTABLE_NO_DISTRIB_INSTNS = 13;
        public const int INVALID_UNACCEPTABLE_DISTRIB_PERCENTAGE = 14;
        public const int INVALID_UNACCEPTABLE_DISTRIB_PAYMENT_METHOD = 15;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_ACCT_NAME = 16;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_CODE = 17;
        public const int INVALID_UNACCEPTABLE_CASH_DISTRIB_AGENT_ACCT_NUM = 18;
        public const int INVALID_UNACCEPTABLE_TAX_EXEMPT_TYPE = 2;
        public const int INVALID_UNACCEPTABLE_OWNERSHIP_TYPE = 3;
        public const int INVALID_UNACCEPTABLE_NO_REG_DETAILS = 4;
        public const int INVALID_UNACCEPTABLE_REG_SEQ_NO = 5;
        public const int INVALID_UNACCEPTABLE_REG_DETAILS = 6;
        public const int INVALID_UNACCEPTABLE_MAILING_DETAILS = 7;
        public const int INVALID_UNACCEPTABLE_MAILING_INSTRUCTIONS = 8;
        public const int INVALID_UNACCEPTABLE_INVESTOR_ID = 9;
        public const int OTHER = 99;
        public const int INVALID_UNACCEPTABLE_NO_REG_DETLS = 4;
        public const int INVALID_UNACCEPTABLE_REG_DTLS = 6;
        public const int INVALID_UNACCEPTABLE_MAILING_DTLS = 7;
        public const int INVALID_UNACCEPTABLE_MAILING_INST = 8;
        public const int INVALID_UNACCEPTABLE_INVESTOR_ID_SOURCE = 10;
        public const int INVALID_UNACCEPTABLE_NODISTRIBINSTNS = 13;
    }


    /// <summary>
    /// RegistRefID Field
    /// </summary>/
    public sealed class RegistRefID : StringField
    {
        public const int TAG = 508;

        public RegistRefID()
            :base(Tags.RegistRefID) {}
        public RegistRefID(string val)
            :base(Tags.RegistRefID, val) {}

    }


    /// <summary>
    /// RegistDetls Field
    /// </summary>/
    public sealed class RegistDetls : StringField
    {
        public const int TAG = 509;

        public RegistDetls()
            :base(Tags.RegistDetls) {}
        public RegistDetls(string val)
            :base(Tags.RegistDetls, val) {}

    }


    /// <summary>
    /// NoDistribInsts Field
    /// </summary>/
    public sealed class NoDistribInsts : IntField
    {
        public const int TAG = 510;

        public NoDistribInsts()
            :base(Tags.NoDistribInsts) {}
        public NoDistribInsts(int val)
            :base(Tags.NoDistribInsts, val) {}

    }


    /// <summary>
    /// RegistEmail Field
    /// </summary>/
    public sealed class RegistEmail : StringField
    {
        public const int TAG = 511;

        public RegistEmail()
            :base(Tags.RegistEmail) {}
        public RegistEmail(string val)
            :base(Tags.RegistEmail, val) {}

    }


    /// <summary>
    /// DistribPercentage Field
    /// </summary>/
    public sealed class DistribPercentage : DecimalField
    {
        public const int TAG = 512;

        public DistribPercentage()
            :base(Tags.DistribPercentage) {}
        public DistribPercentage(Decimal val)
            :base(Tags.DistribPercentage, val) {}

    }


    /// <summary>
    /// RegistID Field
    /// </summary>/
    public sealed class RegistID : StringField
    {
        public const int TAG = 513;

        public RegistID()
            :base(Tags.RegistID) {}
        public RegistID(string val)
            :base(Tags.RegistID, val) {}

    }


    /// <summary>
    /// RegistTransType Field
    /// </summary>/
    public sealed class RegistTransType : CharField
    {
        public const int TAG = 514;

        public RegistTransType()
            :base(Tags.RegistTransType) {}
        public RegistTransType(char val)
            :base(Tags.RegistTransType, val) {}


        // Field Enumerations
        public const char NEW = '0';
        public const char REPLACE = '1';
        public const char CANCEL = '2';
    }


    /// <summary>
    /// ExecValuationPoint Field
    /// </summary>/
    public sealed class ExecValuationPoint : DateTimeField
    {
        public const int TAG = 515;

        public ExecValuationPoint()
            :base(Tags.ExecValuationPoint) {}
        public ExecValuationPoint(DateTime val)
            :base(Tags.ExecValuationPoint, val) {}
        public ExecValuationPoint(DateTime val, bool showMilliseconds)
            :base(Tags.ExecValuationPoint, val, showMilliseconds) {}
		public ExecValuationPoint(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.ExecValuationPoint, val, precision) {}

    }


    /// <summary>
    /// OrderPercent Field
    /// </summary>/
    public sealed class OrderPercent : DecimalField
    {
        public const int TAG = 516;

        public OrderPercent()
            :base(Tags.OrderPercent) {}
        public OrderPercent(Decimal val)
            :base(Tags.OrderPercent, val) {}

    }


    /// <summary>
    /// OwnershipType Field
    /// </summary>/
    public sealed class OwnershipType : CharField
    {
        public const int TAG = 517;

        public OwnershipType()
            :base(Tags.OwnershipType) {}
        public OwnershipType(char val)
            :base(Tags.OwnershipType, val) {}


        // Field Enumerations
        public const char JOINT_TRUSTEES = '2';
        public const char JOINT_INVESTORS = 'J';
        public const char TENANTS_IN_COMMON = 'T';
    }


    /// <summary>
    /// NoContAmts Field
    /// </summary>/
    public sealed class NoContAmts : IntField
    {
        public const int TAG = 518;

        public NoContAmts()
            :base(Tags.NoContAmts) {}
        public NoContAmts(int val)
            :base(Tags.NoContAmts, val) {}

    }


    /// <summary>
    /// ContAmtType Field
    /// </summary>/
    public sealed class ContAmtType : IntField
    {
        public const int TAG = 519;

        public ContAmtType()
            :base(Tags.ContAmtType) {}
        public ContAmtType(int val)
            :base(Tags.ContAmtType, val) {}


        // Field Enumerations
        public const int COMMISSION_AMOUNT = 1;
        public const int EXIT_CHARGE_PERCENT = 10;
        public const int FUND_BASED_RENEWAL_COMMISSION_PERCENT = 11;
        public const int PROJECTED_FUND_VALUE = 12;
        public const int FUND_BASED_RENEWAL_COMMISSION_AMOUNT_13 = 13;
        public const int FUND_BASED_RENEWAL_COMMISSION_AMOUNT_14 = 14;
        public const int NET_SETTLEMENT_AMOUNT = 15;
        public const int COMMISSION_PERCENT = 2;
        public const int INITIAL_CHARGE_AMOUNT = 3;
        public const int INITIAL_CHARGE_PERCENT = 4;
        public const int DISCOUNT_AMOUNT = 5;
        public const int DISCOUNT_PERCENT = 6;
        public const int DILUTION_LEVY_AMOUNT = 7;
        public const int DILUTION_LEVY_PERCENT = 8;
        public const int EXIT_CHARGE_AMOUNT = 9;
    }


    /// <summary>
    /// ContAmtValue Field
    /// </summary>/
    public sealed class ContAmtValue : DecimalField
    {
        public const int TAG = 520;

        public ContAmtValue()
            :base(Tags.ContAmtValue) {}
        public ContAmtValue(Decimal val)
            :base(Tags.ContAmtValue, val) {}

    }


    /// <summary>
    /// ContAmtCurr Field
    /// </summary>/
    public sealed class ContAmtCurr : StringField
    {
        public const int TAG = 521;

        public ContAmtCurr()
            :base(Tags.ContAmtCurr) {}
        public ContAmtCurr(string val)
            :base(Tags.ContAmtCurr, val) {}

    }


    /// <summary>
    /// OwnerType Field
    /// </summary>/
    public sealed class OwnerType : IntField
    {
        public const int TAG = 522;

        public OwnerType()
            :base(Tags.OwnerType) {}
        public OwnerType(int val)
            :base(Tags.OwnerType, val) {}


        // Field Enumerations
        public const int INDIVIDUAL_INVESTOR = 1;
        public const int NETWORKING_SUB_ACCOUNT = 10;
        public const int NON_PROFIT_ORGANIZATION = 11;
        public const int CORPORATE_BODY = 12;
        public const int NOMINEE = 13;
        public const int PUBLIC_COMPANY = 2;
        public const int PRIVATE_COMPANY = 3;
        public const int INDIVIDUAL_TRUSTEE = 4;
        public const int COMPANY_TRUSTEE = 5;
        public const int PENSION_PLAN = 6;
        public const int CUSTODIAN_UNDER_GIFTS_TO_MINORS_ACT = 7;
        public const int TRUSTS = 8;
        public const int FIDUCIARIES = 9;
    }


    /// <summary>
    /// PartySubID Field
    /// </summary>/
    public sealed class PartySubID : StringField
    {
        public const int TAG = 523;

        public PartySubID()
            :base(Tags.PartySubID) {}
        public PartySubID(string val)
            :base(Tags.PartySubID, val) {}

    }


    /// <summary>
    /// NestedPartyID Field
    /// </summary>/
    public sealed class NestedPartyID : StringField
    {
        public const int TAG = 524;

        public NestedPartyID()
            :base(Tags.NestedPartyID) {}
        public NestedPartyID(string val)
            :base(Tags.NestedPartyID, val) {}

    }


    /// <summary>
    /// NestedPartyIDSource Field
    /// </summary>/
    public sealed class NestedPartyIDSource : CharField
    {
        public const int TAG = 525;

        public NestedPartyIDSource()
            :base(Tags.NestedPartyIDSource) {}
        public NestedPartyIDSource(char val)
            :base(Tags.NestedPartyIDSource, val) {}

    }


    /// <summary>
    /// SecondaryClOrdID Field
    /// </summary>/
    public sealed class SecondaryClOrdID : StringField
    {
        public const int TAG = 526;

        public SecondaryClOrdID()
            :base(Tags.SecondaryClOrdID) {}
        public SecondaryClOrdID(string val)
            :base(Tags.SecondaryClOrdID, val) {}

    }


    /// <summary>
    /// SecondaryExecID Field
    /// </summary>/
    public sealed class SecondaryExecID : StringField
    {
        public const int TAG = 527;

        public SecondaryExecID()
            :base(Tags.SecondaryExecID) {}
        public SecondaryExecID(string val)
            :base(Tags.SecondaryExecID, val) {}

    }


    /// <summary>
    /// OrderCapacity Field
    /// </summary>/
    public sealed class OrderCapacity : CharField
    {
        public const int TAG = 528;

        public OrderCapacity()
            :base(Tags.OrderCapacity) {}
        public OrderCapacity(char val)
            :base(Tags.OrderCapacity, val) {}


        // Field Enumerations
        public const char AGENCY = 'A';
        public const char PROPRIETARY = 'G';
        public const char INDIVIDUAL = 'I';
        public const char PRINCIPAL = 'P';
        public const char RISKLESS_PRINCIPAL = 'R';
        public const char AGENT_FOR_OTHER_MEMBER = 'W';
    }


    /// <summary>
    /// OrderRestrictions Field
    /// </summary>/
    public sealed class OrderRestrictions : StringField
    {
        public const int TAG = 529;

        public OrderRestrictions()
            :base(Tags.OrderRestrictions) {}
        public OrderRestrictions(string val)
            :base(Tags.OrderRestrictions, val) {}


        // Field Enumerations
        public const string PROGRAM_TRADE = "1";
        public const string INDEX_ARBITRAGE = "2";
        public const string NON_INDEX_ARBITRAGE = "3";
        public const string COMPETING_MARKET_MAKER = "4";
        public const string ACTING_AS_MARKET_MAKER_OR_SPECIALIST_IN_THE_SECURITY = "5";
        public const string ACTING_AS_MARKET_MAKER_OR_SPECIALIST_IN_THE_UNDERLYING_SECURITY_OF_A_DERIVATIVE_SECURITY = "6";
        public const string FOREIGN_ENTITY = "7";
        public const string EXTERNAL_MARKET_PARTICIPANT = "8";
        public const string EXTERNAL_INTER_CONNECTED_MARKET_LINKAGE = "9";
        public const string RISKLESS_ARBITRAGE = "A";
        public const string ISSUER_HOLDING = "B";
        public const string ISSUE_PRICE_STABILIZATION = "C";
        public const string NON_ALGORITHMIC = "D";
        public const string ALGORITHMIC = "E";
        public const string CROSS = "F";
        public const string ACTING_AS_MARKET_MAKER_OF_SPECIALIST_IN_THE_UNDERLYING_SECURITY_OF_A_DERIVATIVE_SEUCIRTY = "6";
        public const string EXTNERAL_INTER_CONNECTED_MARKET_LINKAGE = "9";
    }


    /// <summary>
    /// MassCancelRequestType Field
    /// </summary>/
    public sealed class MassCancelRequestType : CharField
    {
        public const int TAG = 530;

        public MassCancelRequestType()
            :base(Tags.MassCancelRequestType) {}
        public MassCancelRequestType(char val)
            :base(Tags.MassCancelRequestType, val) {}


        // Field Enumerations
        public const char CANCEL_ORDERS_FOR_A_SECURITY = '1';
        public const char CANCEL_ORDERS_FOR_AN_UNDERLYING_SECURITY = '2';
        public const char CANCEL_ORDERS_FOR_A_PRODUCT = '3';
        public const char CANCEL_ORDERS_FOR_A_CFICODE = '4';
        public const char CANCEL_ORDERS_FOR_A_SECURITYTYPE = '5';
        public const char CANCEL_ORDERS_FOR_A_TRADING_SESSION = '6';
        public const char CANCEL_ALL_ORDERS = '7';
        public const char CANCEL_ORDERS_FOR_A_MARKET = '8';
        public const char CANCEL_ORDERS_FOR_A_MARKET_SEGMENT = '9';
        public const char CANCEL_ORDERS_FOR_A_SECURITY_GROUP = 'A';
        public const char CANCEL_FOR_SECURITY_ISSUER = 'B';
        public const char CANCEL_FOR_ISSUER_OF_UNDERLYING_SECURITY = 'C';
    }


    /// <summary>
    /// MassCancelResponse Field
    /// </summary>/
    public sealed class MassCancelResponse : CharField
    {
        public const int TAG = 531;

        public MassCancelResponse()
            :base(Tags.MassCancelResponse) {}
        public MassCancelResponse(char val)
            :base(Tags.MassCancelResponse, val) {}


        // Field Enumerations
        public const char CANCEL_REQUEST_REJECTED = '0';
        public const char CANCEL_ORDERS_FOR_A_SECURITY = '1';
        public const char CANCEL_ORDERS_FOR_AN_UNDERLYING_SECURITY = '2';
        public const char CANCEL_ORDERS_FOR_A_PRODUCT = '3';
        public const char CANCEL_ORDERS_FOR_A_CFICODE = '4';
        public const char CANCEL_ORDERS_FOR_A_SECURITYTYPE = '5';
        public const char CANCEL_ORDERS_FOR_A_TRADING_SESSION = '6';
        public const char CANCEL_ALL_ORDERS = '7';
        public const char CANCEL_ORDERS_FOR_A_MARKET = '8';
        public const char CANCEL_ORDERS_FOR_A_MARKET_SEGMENT = '9';
        public const char CANCEL_ORDERS_FOR_A_SECURITY_GROUP = 'A';
        public const char CANCEL_ORDERS_FOR_A_SECURITIES_ISSUER = 'B';
        public const char CANCEL_ORDERS_FOR_ISSUER_OF_UNDERLYING_SECURITY = 'C';
    }


    /// <summary>
    /// MassCancelRejectReason Field
    /// </summary>/
    public sealed class MassCancelRejectReason : IntField
    {
        public const int TAG = 532;

        public MassCancelRejectReason()
            :base(Tags.MassCancelRejectReason) {}
        public MassCancelRejectReason(int val)
            :base(Tags.MassCancelRejectReason, val) {}


        // Field Enumerations
        public const int MASS_CANCEL_NOT_SUPPORTED = 0;
        public const int INVALID_OR_UNKNOWN_SECURITY = 1;
        public const int INVALID_OR_UNKOWN_UNDERLYING_SECURITY = 2;
        public const int INVALID_OR_UNKNOWN_PRODUCT = 3;
        public const int INVALID_OR_UNKNOWN_CFICODE = 4;
        public const int INVALID_OR_UNKNOWN_SECURITYTYPE = 5;
        public const int INVALID_OR_UNKNOWN_TRADING_SESSION = 6;
        public const int OTHER = 99;
        public const int INVALID_OR_UNKNOWN_MARKET = 7;
        public const int INVALID_OR_UNKOWN_MARKET_SEGMENT = 8;
        public const int INVALID_OR_UNKNOWN_SECURITY_GROUP = 9;
        public const int INVALID_OR_UNKNOWN_SECURITY_ISSUER = 10;
        public const int INVALID_OR_UNKNOWN_ISSUER_OF_UNDERLYING_SECURITY = 11;
        public const int INVALID_OR_UNKNOWN_UNDERLYING = 2;
        public const int INVALID_OR_UNKNOWN_SECURITY_TYPE = 5;
    }


    /// <summary>
    /// TotalAffectedOrders Field
    /// </summary>/
    public sealed class TotalAffectedOrders : IntField
    {
        public const int TAG = 533;

        public TotalAffectedOrders()
            :base(Tags.TotalAffectedOrders) {}
        public TotalAffectedOrders(int val)
            :base(Tags.TotalAffectedOrders, val) {}

    }


    /// <summary>
    /// NoAffectedOrders Field
    /// </summary>/
    public sealed class NoAffectedOrders : IntField
    {
        public const int TAG = 534;

        public NoAffectedOrders()
            :base(Tags.NoAffectedOrders) {}
        public NoAffectedOrders(int val)
            :base(Tags.NoAffectedOrders, val) {}

    }


    /// <summary>
    /// AffectedOrderID Field
    /// </summary>/
    public sealed class AffectedOrderID : StringField
    {
        public const int TAG = 535;

        public AffectedOrderID()
            :base(Tags.AffectedOrderID) {}
        public AffectedOrderID(string val)
            :base(Tags.AffectedOrderID, val) {}

    }


    /// <summary>
    /// AffectedSecondaryOrderID Field
    /// </summary>/
    public sealed class AffectedSecondaryOrderID : StringField
    {
        public const int TAG = 536;

        public AffectedSecondaryOrderID()
            :base(Tags.AffectedSecondaryOrderID) {}
        public AffectedSecondaryOrderID(string val)
            :base(Tags.AffectedSecondaryOrderID, val) {}

    }


    /// <summary>
    /// QuoteType Field
    /// </summary>/
    public sealed class QuoteType : IntField
    {
        public const int TAG = 537;

        public QuoteType()
            :base(Tags.QuoteType) {}
        public QuoteType(int val)
            :base(Tags.QuoteType, val) {}


        // Field Enumerations
        public const int INDICATIVE = 0;
        public const int TRADEABLE = 1;
        public const int RESTRICTED_TRADEABLE = 2;
        public const int COUNTER = 3;
    }


    /// <summary>
    /// NestedPartyRole Field
    /// </summary>/
    public sealed class NestedPartyRole : IntField
    {
        public const int TAG = 538;

        public NestedPartyRole()
            :base(Tags.NestedPartyRole) {}
        public NestedPartyRole(int val)
            :base(Tags.NestedPartyRole, val) {}

    }


    /// <summary>
    /// NoNestedPartyIDs Field
    /// </summary>/
    public sealed class NoNestedPartyIDs : IntField
    {
        public const int TAG = 539;

        public NoNestedPartyIDs()
            :base(Tags.NoNestedPartyIDs) {}
        public NoNestedPartyIDs(int val)
            :base(Tags.NoNestedPartyIDs, val) {}

    }


    /// <summary>
    /// TotalAccruedInterestAmt Field
    /// </summary>/
    public sealed class TotalAccruedInterestAmt : DecimalField
    {
        public const int TAG = 540;

        public TotalAccruedInterestAmt()
            :base(Tags.TotalAccruedInterestAmt) {}
        public TotalAccruedInterestAmt(Decimal val)
            :base(Tags.TotalAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// MaturityDate Field
    /// </summary>/
    public sealed class MaturityDate : StringField
    {
        public const int TAG = 541;

        public MaturityDate()
            :base(Tags.MaturityDate) {}
        public MaturityDate(string val)
            :base(Tags.MaturityDate, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityDate Field
    /// </summary>/
    public sealed class UnderlyingMaturityDate : StringField
    {
        public const int TAG = 542;

        public UnderlyingMaturityDate()
            :base(Tags.UnderlyingMaturityDate) {}
        public UnderlyingMaturityDate(string val)
            :base(Tags.UnderlyingMaturityDate, val) {}

    }


    /// <summary>
    /// InstrRegistry Field
    /// </summary>/
    public sealed class InstrRegistry : StringField
    {
        public const int TAG = 543;

        public InstrRegistry()
            :base(Tags.InstrRegistry) {}
        public InstrRegistry(string val)
            :base(Tags.InstrRegistry, val) {}


        // Field Enumerations
        public const string COUNTRY_IN_WHICH_REGISTRY_IS_KEPT = "Code";
        public const string PHYSICAL_OR_BEARER = "ZZ";
    }


    /// <summary>
    /// CashMargin Field
    /// </summary>/
    public sealed class CashMargin : CharField
    {
        public const int TAG = 544;

        public CashMargin()
            :base(Tags.CashMargin) {}
        public CashMargin(char val)
            :base(Tags.CashMargin, val) {}


        // Field Enumerations
        public const char CASH = '1';
        public const char MARGIN_OPEN = '2';
        public const char MARGIN_CLOSE = '3';
    }


    /// <summary>
    /// NestedPartySubID Field
    /// </summary>/
    public sealed class NestedPartySubID : StringField
    {
        public const int TAG = 545;

        public NestedPartySubID()
            :base(Tags.NestedPartySubID) {}
        public NestedPartySubID(string val)
            :base(Tags.NestedPartySubID, val) {}

    }


    /// <summary>
    /// Scope Field
    /// </summary>/
    public sealed class Scope : StringField
    {
        public const int TAG = 546;

        public Scope()
            :base(Tags.Scope) {}
        public Scope(string val)
            :base(Tags.Scope, val) {}


        // Field Enumerations
        public const string LOCAL_MARKET = "1";
        public const string NATIONAL = "2";
        public const string GLOBAL = "3";
        public const string LOCAL = "1";
    }


    /// <summary>
    /// MDImplicitDelete Field
    /// </summary>/
    public sealed class MDImplicitDelete : BooleanField
    {
        public const int TAG = 547;

        public MDImplicitDelete()
            :base(Tags.MDImplicitDelete) {}
        public MDImplicitDelete(Boolean val)
            :base(Tags.MDImplicitDelete, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// CrossID Field
    /// </summary>/
    public sealed class CrossID : StringField
    {
        public const int TAG = 548;

        public CrossID()
            :base(Tags.CrossID) {}
        public CrossID(string val)
            :base(Tags.CrossID, val) {}

    }


    /// <summary>
    /// CrossType Field
    /// </summary>/
    public sealed class CrossType : IntField
    {
        public const int TAG = 549;

        public CrossType()
            :base(Tags.CrossType) {}
        public CrossType(int val)
            :base(Tags.CrossType, val) {}


        // Field Enumerations
        public const int CROSS_AON = 1;
        public const int CROSS_IOC = 2;
        public const int CROSS_ONE_SIDE = 3;
        public const int CROSS_SAME_PRICE = 4;
        public const int CROSS_TRADE_WHICH_IS_EXECUTED_COMPLETELY_OR_NOT = 1;
        public const int CROSS_TRADE_WHICH_IS_EXECUTED_PARTIALLY_AND_THE_REST_IS_CANCELLED = 2;
        public const int CROSS_TRADE_WHICH_IS_PARTIALLY_EXECUTED_WITH_THE_UNFILLED_PORTIONS_REMAINING_ACTIVE = 3;
        public const int CROSS_TRADE_IS_EXECUTED_WITH_EXISTING_ORDERS_WITH_THE_SAME_PRICE = 4;
    }


    /// <summary>
    /// CrossPrioritization Field
    /// </summary>/
    public sealed class CrossPrioritization : IntField
    {
        public const int TAG = 550;

        public CrossPrioritization()
            :base(Tags.CrossPrioritization) {}
        public CrossPrioritization(int val)
            :base(Tags.CrossPrioritization, val) {}


        // Field Enumerations
        public const int NONE = 0;
        public const int BUY_SIDE_IS_PRIORITIZED = 1;
        public const int SELL_SIDE_IS_PRIORITIZED = 2;
    }


    /// <summary>
    /// OrigCrossID Field
    /// </summary>/
    public sealed class OrigCrossID : StringField
    {
        public const int TAG = 551;

        public OrigCrossID()
            :base(Tags.OrigCrossID) {}
        public OrigCrossID(string val)
            :base(Tags.OrigCrossID, val) {}

    }


    /// <summary>
    /// NoSides Field
    /// </summary>/
    public sealed class NoSides : IntField
    {
        public const int TAG = 552;

        public NoSides()
            :base(Tags.NoSides) {}
        public NoSides(int val)
            :base(Tags.NoSides, val) {}


        // Field Enumerations
        public const int ONE_SIDE = 1;
        public const int BOTH_SIDES = 2;
    }


    /// <summary>
    /// Username Field
    /// </summary>/
    public sealed class Username : StringField
    {
        public const int TAG = 553;

        public Username()
            :base(Tags.Username) {}
        public Username(string val)
            :base(Tags.Username, val) {}

    }


    /// <summary>
    /// Password Field
    /// </summary>/
    public sealed class Password : StringField
    {
        public const int TAG = 554;

        public Password()
            :base(Tags.Password) {}
        public Password(string val)
            :base(Tags.Password, val) {}

    }


    /// <summary>
    /// NoLegs Field
    /// </summary>/
    public sealed class NoLegs : IntField
    {
        public const int TAG = 555;

        public NoLegs()
            :base(Tags.NoLegs) {}
        public NoLegs(int val)
            :base(Tags.NoLegs, val) {}

    }


    /// <summary>
    /// LegCurrency Field
    /// </summary>/
    public sealed class LegCurrency : StringField
    {
        public const int TAG = 556;

        public LegCurrency()
            :base(Tags.LegCurrency) {}
        public LegCurrency(string val)
            :base(Tags.LegCurrency, val) {}

    }


    /// <summary>
    /// TotalNumSecurityTypes Field
    /// </summary>/
    public sealed class TotalNumSecurityTypes : IntField
    {
        public const int TAG = 557;

        public TotalNumSecurityTypes()
            :base(Tags.TotalNumSecurityTypes) {}
        public TotalNumSecurityTypes(int val)
            :base(Tags.TotalNumSecurityTypes, val) {}

    }


    /// <summary>
    /// NoSecurityTypes Field
    /// </summary>/
    public sealed class NoSecurityTypes : IntField
    {
        public const int TAG = 558;

        public NoSecurityTypes()
            :base(Tags.NoSecurityTypes) {}
        public NoSecurityTypes(int val)
            :base(Tags.NoSecurityTypes, val) {}

    }


    /// <summary>
    /// SecurityListRequestType Field
    /// </summary>/
    public sealed class SecurityListRequestType : IntField
    {
        public const int TAG = 559;

        public SecurityListRequestType()
            :base(Tags.SecurityListRequestType) {}
        public SecurityListRequestType(int val)
            :base(Tags.SecurityListRequestType, val) {}


        // Field Enumerations
        public const int SYMBOL = 0;
        public const int SECURITYTYPE_AND_OR_CFICODE = 1;
        public const int PRODUCT = 2;
        public const int TRADINGSESSIONID = 3;
        public const int ALL_SECURITIES = 4;
        public const int MARKETID_OR_MARKETID_PLUS_MARKETSEGMENTID = 5;
        public const int SECURITYTYPE_AND = 1;
    }


    /// <summary>
    /// SecurityRequestResult Field
    /// </summary>/
    public sealed class SecurityRequestResult : IntField
    {
        public const int TAG = 560;

        public SecurityRequestResult()
            :base(Tags.SecurityRequestResult) {}
        public SecurityRequestResult(int val)
            :base(Tags.SecurityRequestResult, val) {}


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_INSTRUMENTS_FOUND_THAT_MATCH_SELECTION_CRITERIA = 2;
        public const int NOT_AUTHORIZED_TO_RETRIEVE_INSTRUMENT_DATA = 3;
        public const int INSTRUMENT_DATA_TEMPORARILY_UNAVAILABLE = 4;
        public const int REQUEST_FOR_INSTRUMENT_DATA_NOT_SUPPORTED = 5;
    }


    /// <summary>
    /// RoundLot Field
    /// </summary>/
    public sealed class RoundLot : DecimalField
    {
        public const int TAG = 561;

        public RoundLot()
            :base(Tags.RoundLot) {}
        public RoundLot(Decimal val)
            :base(Tags.RoundLot, val) {}

    }


    /// <summary>
    /// MinTradeVol Field
    /// </summary>/
    public sealed class MinTradeVol : DecimalField
    {
        public const int TAG = 562;

        public MinTradeVol()
            :base(Tags.MinTradeVol) {}
        public MinTradeVol(Decimal val)
            :base(Tags.MinTradeVol, val) {}

    }


    /// <summary>
    /// MultiLegRptTypeReq Field
    /// </summary>/
    public sealed class MultiLegRptTypeReq : IntField
    {
        public const int TAG = 563;

        public MultiLegRptTypeReq()
            :base(Tags.MultiLegRptTypeReq) {}
        public MultiLegRptTypeReq(int val)
            :base(Tags.MultiLegRptTypeReq, val) {}


        // Field Enumerations
        public const int REPORT_BY_MULITLEG_SECURITY_ONLY = 0;
        public const int REPORT_BY_MULTILEG_SECURITY_AND_BY_INSTRUMENT_LEGS_BELONGING_TO_THE_MULTILEG_SECURITY = 1;
        public const int REPORT_BY_INSTRUMENT_LEGS_BELONGING_TO_THE_MULTILEG_SECURITY_ONLY = 2;
    }


    /// <summary>
    /// LegPositionEffect Field
    /// </summary>/
    public sealed class LegPositionEffect : CharField
    {
        public const int TAG = 564;

        public LegPositionEffect()
            :base(Tags.LegPositionEffect) {}
        public LegPositionEffect(char val)
            :base(Tags.LegPositionEffect, val) {}

    }


    /// <summary>
    /// LegCoveredOrUncovered Field
    /// </summary>/
    public sealed class LegCoveredOrUncovered : IntField
    {
        public const int TAG = 565;

        public LegCoveredOrUncovered()
            :base(Tags.LegCoveredOrUncovered) {}
        public LegCoveredOrUncovered(int val)
            :base(Tags.LegCoveredOrUncovered, val) {}

    }


    /// <summary>
    /// LegPrice Field
    /// </summary>/
    public sealed class LegPrice : DecimalField
    {
        public const int TAG = 566;

        public LegPrice()
            :base(Tags.LegPrice) {}
        public LegPrice(Decimal val)
            :base(Tags.LegPrice, val) {}

    }


    /// <summary>
    /// TradSesStatusRejReason Field
    /// </summary>/
    public sealed class TradSesStatusRejReason : IntField
    {
        public const int TAG = 567;

        public TradSesStatusRejReason()
            :base(Tags.TradSesStatusRejReason) {}
        public TradSesStatusRejReason(int val)
            :base(Tags.TradSesStatusRejReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_OR_INVALID_TRADINGSESSIONID = 1;
        public const int OTHER = 99;
    }


    /// <summary>
    /// TradeRequestID Field
    /// </summary>/
    public sealed class TradeRequestID : StringField
    {
        public const int TAG = 568;

        public TradeRequestID()
            :base(Tags.TradeRequestID) {}
        public TradeRequestID(string val)
            :base(Tags.TradeRequestID, val) {}

    }


    /// <summary>
    /// TradeRequestType Field
    /// </summary>/
    public sealed class TradeRequestType : IntField
    {
        public const int TAG = 569;

        public TradeRequestType()
            :base(Tags.TradeRequestType) {}
        public TradeRequestType(int val)
            :base(Tags.TradeRequestType, val) {}


        // Field Enumerations
        public const int ALL_TRADES = 0;
        public const int MATCHED_TRADES_MATCHING_CRITERIA_PROVIDED_ON_REQUEST = 1;
        public const int UNMATCHED_TRADES_THAT_MATCH_CRITERIA = 2;
        public const int UNREPORTED_TRADES_THAT_MATCH_CRITERIA = 3;
        public const int ADVISORIES_THAT_MATCH_CRITERIA = 4;
    }


    /// <summary>
    /// PreviouslyReported Field
    /// </summary>/
    public sealed class PreviouslyReported : BooleanField
    {
        public const int TAG = 570;

        public PreviouslyReported()
            :base(Tags.PreviouslyReported) {}
        public PreviouslyReported(Boolean val)
            :base(Tags.PreviouslyReported, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// TradeReportID Field
    /// </summary>/
    public sealed class TradeReportID : StringField
    {
        public const int TAG = 571;

        public TradeReportID()
            :base(Tags.TradeReportID) {}
        public TradeReportID(string val)
            :base(Tags.TradeReportID, val) {}

    }


    /// <summary>
    /// TradeReportRefID Field
    /// </summary>/
    public sealed class TradeReportRefID : StringField
    {
        public const int TAG = 572;

        public TradeReportRefID()
            :base(Tags.TradeReportRefID) {}
        public TradeReportRefID(string val)
            :base(Tags.TradeReportRefID, val) {}

    }


    /// <summary>
    /// MatchStatus Field
    /// </summary>/
    public sealed class MatchStatus : CharField
    {
        public const int TAG = 573;

        public MatchStatus()
            :base(Tags.MatchStatus) {}
        public MatchStatus(char val)
            :base(Tags.MatchStatus, val) {}


        // Field Enumerations
        public const char COMPARED_MATCHED_OR_AFFIRMED = '0';
        public const char UNCOMPARED_UNMATCHED_OR_UNAFFIRMED = '1';
        public const char ADVISORY_OR_ALERT = '2';
        public const char UNCOMPARED_UNMATCHED_OR_UNAFFIRED = '1';
        public const char COMPARED = '0';
        public const char UNCOMPARED = '1';
    }


    /// <summary>
    /// MatchType Field
    /// </summary>/
    public sealed class MatchType : StringField
    {
        public const int TAG = 574;

        public MatchType()
            :base(Tags.MatchType) {}
        public MatchType(string val)
            :base(Tags.MatchType, val) {}


        // Field Enumerations
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_FOUR_BADGES_AND_EXECUTION_TIME = "A1";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_FOUR_BADGES = "A2";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_TWO_BADGES_AND_EXECUTION_TIME = "A3";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_TWO_BADGES = "A4";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADETYPE_AND_SPECIAL_TRADE_INDICATOR_PLUS_EXECUTION_TIME = "A5";
        public const string ACT_ACCEPTED_TRADE = "M3";
        public const string ACT_DEFAULT_TRADE = "M4";
        public const string ACT_DEFAULT_AFTER_M2 = "M5";
        public const string ACT_M6_MATCH = "M6";
        public const string COMPARED_RECORDS_RESULTING_FROM_STAMPED_ADVISORIES_OR_SPECIALIST_ACCEPTS_PAIR_OFFS = "AQ";
        public const string EXACT_MATCH_ON_TRADE_DATE_STOCK_SYMBOL_QUANTITY_PRICE_TRADE_TYPE_AND_SPECIAL_TRADE_INDICATOR_MINUS_BADGES_AND_TIMES_ACT_M1_MATCH = "M1";
        public const string SUMMARIZED_MATCH_MINUS_BADGES_AND_TIMES_ACT_M2_MATCH = "M2";
        public const string OCS_LOCKED_IN_NON_ACT = "MT";
        public const string SUMMARIZED_MATCH_USING_A1_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIED = "S1";
        public const string SUMMARIZED_MATCH_USING_A2_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S2";
        public const string SUMMARIZED_MATCH_USING_A3_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S3";
        public const string SUMMARIZED_MATCH_USING_A4_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S4";
        public const string SUMMARIZED_MATCH_USING_A5_EXACT_MATCH_CRITERIA_EXCEPT_QUANTITY_IS_SUMMARIZED = "S5";
        public const string ONE_PARTY_TRADE_REPORT = "1";
        public const string TWO_PARTY_TRADE_REPORT = "2";
        public const string CONFIRMED_TRADE_REPORT = "3";
        public const string AUTO_MATCH = "4";
        public const string CROSS_AUCTION = "5";
        public const string COUNTER_ORDER_SELECTION = "6";
        public const string CALL_AUCTION = "7";
        public const string ISSUING_BUY_BACK_AUCTION = "8";
        public const string ONE_PARTY_PRIVATELY_NEGOTIATED_TRADE_REPORT = "60";
        public const string TWO_PARTY_PRIVATELY_NEGOTIATED_TRADE_REPORT = "61";
        public const string CONTINUOUS_AUTO_MATCH = "62";
        public const string CROSS_AUCTION_63 = "63";
        public const string COUNTER_ORDER_SELECTION_64 = "64";
        public const string CALL_AUCTION_65 = "65";
        public const string CROSS_AUCTION_5 = "5";
        public const string COUNTER_ORDER_SELECTION_6 = "6";
        public const string CALL_AUCTION_7 = "7";
        public const string EXACT_MATCH_PLUS_FOUR_BADGES_AND_EXECUTION_TIME = "A1";
        public const string EXACT_MATCH_PLUS_FOUR_BADGES = "A2";
        public const string EXACT_MATCH_PLUS_TWO_BADGES_AND_EXECUTION_TIME = "A3";
        public const string EXACT_MATCH_PLUS_TWO_BADGES = "A4";
        public const string EXACT_MATCH_PLUS_EXECUTION_TIME = "A5";
        public const string COMPARED_RECORDS_RESULTING_FROM_STAMPED_ADVISORIES_OR_SPECIALIST_ACCEPTS = "AQ";
        public const string SUMMARIZED_MATCH_USING_A1 = "S1";
        public const string SUMMARIZED_MATCH_USING_A2 = "S2";
        public const string SUMMARIZED_MATCH_USING_A3 = "S3";
        public const string SUMMARIZED_MATCH_USING_A4 = "S4";
        public const string SUMMARIZED_MATCH_USING_A5 = "S5";
        public const string EXACT_MATCH_MINUS_BADGES_AND_EXECUTION_TIME = "M1";
        public const string SUMMARIZED_MATCH_MINUS_BADGES_AND_TIMES = "M2";
        public const string OCS_LOCKED_IN = "MT";
        public const string ACT_M1_MATCH = "M1";
        public const string ACT_M2_MATCH = "M2";
        public const string NON_ACT = "MT";
    }


    /// <summary>
    /// OddLot Field
    /// </summary>/
    public sealed class OddLot : BooleanField
    {
        public const int TAG = 575;

        public OddLot()
            :base(Tags.OddLot) {}
        public OddLot(Boolean val)
            :base(Tags.OddLot, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// NoClearingInstructions Field
    /// </summary>/
    public sealed class NoClearingInstructions : IntField
    {
        public const int TAG = 576;

        public NoClearingInstructions()
            :base(Tags.NoClearingInstructions) {}
        public NoClearingInstructions(int val)
            :base(Tags.NoClearingInstructions, val) {}

    }


    /// <summary>
    /// ClearingInstruction Field
    /// </summary>/
    public sealed class ClearingInstruction : IntField
    {
        public const int TAG = 577;

        public ClearingInstruction()
            :base(Tags.ClearingInstruction) {}
        public ClearingInstruction(int val)
            :base(Tags.ClearingInstruction, val) {}


        // Field Enumerations
        public const int PROCESS_NORMALLY = 0;
        public const int EXCLUDE_FROM_ALL_NETTING = 1;
        public const int AUTOMATIC_GIVE_UP_MODE = 10;
        public const int QUALIFIED_SERVICE_REPRESENTATIVE_QSR = 11;
        public const int CUSTOMER_TRADE = 12;
        public const int SELF_CLEARING = 13;
        public const int BILATERAL_NETTING_ONLY = 2;
        public const int EX_CLEARING = 3;
        public const int SPECIAL_TRADE = 4;
        public const int MULTILATERAL_NETTING = 5;
        public const int CLEAR_AGAINST_CENTRAL_COUNTERPARTY = 6;
        public const int EXCLUDE_FROM_CENTRAL_COUNTERPARTY = 7;
        public const int MANUAL_MODE = 8;
        public const int AUTOMATIC_POSTING_MODE = 9;
        public const int QUALIFIED_SERVICE_REPRESENTATIVE = 11;
    }


    /// <summary>
    /// TradeInputSource Field
    /// </summary>/
    public sealed class TradeInputSource : StringField
    {
        public const int TAG = 578;

        public TradeInputSource()
            :base(Tags.TradeInputSource) {}
        public TradeInputSource(string val)
            :base(Tags.TradeInputSource, val) {}

    }


    /// <summary>
    /// TradeInputDevice Field
    /// </summary>/
    public sealed class TradeInputDevice : StringField
    {
        public const int TAG = 579;

        public TradeInputDevice()
            :base(Tags.TradeInputDevice) {}
        public TradeInputDevice(string val)
            :base(Tags.TradeInputDevice, val) {}

    }


    /// <summary>
    /// NoDates Field
    /// </summary>/
    public sealed class NoDates : IntField
    {
        public const int TAG = 580;

        public NoDates()
            :base(Tags.NoDates) {}
        public NoDates(int val)
            :base(Tags.NoDates, val) {}

    }


    /// <summary>
    /// AccountType Field
    /// </summary>/
    public sealed class AccountType : IntField
    {
        public const int TAG = 581;

        public AccountType()
            :base(Tags.AccountType) {}
        public AccountType(int val)
            :base(Tags.AccountType, val) {}


        // Field Enumerations
        public const int ACCOUNT_IS_CARRIED_ON_CUSTOMER_SIDE_OF_THE_BOOKS = 1;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS = 2;
        public const int HOUSE_TRADER = 3;
        public const int FLOOR_TRADER = 4;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS_AND_IS_CROSS_MARGINED = 6;
        public const int ACCOUNT_IS_HOUSE_TRADER_AND_IS_CROSS_MARGINED = 7;
        public const int JOINT_BACK_OFFICE_ACCOUNT = 8;
        public const int ACCOUNT_IS_CARRIED_ON_CUSTOMER_SIDE_OF_BOOKS = 1;
        public const int JOINT_BACKOFFICE_ACCOUNT = 8;
    }


    /// <summary>
    /// CustOrderCapacity Field
    /// </summary>/
    public sealed class CustOrderCapacity : IntField
    {
        public const int TAG = 582;

        public CustOrderCapacity()
            :base(Tags.CustOrderCapacity) {}
        public CustOrderCapacity(int val)
            :base(Tags.CustOrderCapacity, val) {}


        // Field Enumerations
        public const int MEMBER_TRADING_FOR_THEIR_OWN_ACCOUNT = 1;
        public const int CLEARING_FIRM_TRADING_FOR_ITS_PROPRIETARY_ACCOUNT = 2;
        public const int MEMBER_TRADING_FOR_ANOTHER_MEMBER = 3;
        public const int ALL_OTHER = 4;
    }


    /// <summary>
    /// ClOrdLinkID Field
    /// </summary>/
    public sealed class ClOrdLinkID : StringField
    {
        public const int TAG = 583;

        public ClOrdLinkID()
            :base(Tags.ClOrdLinkID) {}
        public ClOrdLinkID(string val)
            :base(Tags.ClOrdLinkID, val) {}

    }


    /// <summary>
    /// MassStatusReqID Field
    /// </summary>/
    public sealed class MassStatusReqID : StringField
    {
        public const int TAG = 584;

        public MassStatusReqID()
            :base(Tags.MassStatusReqID) {}
        public MassStatusReqID(string val)
            :base(Tags.MassStatusReqID, val) {}

    }


    /// <summary>
    /// MassStatusReqType Field
    /// </summary>/
    public sealed class MassStatusReqType : IntField
    {
        public const int TAG = 585;

        public MassStatusReqType()
            :base(Tags.MassStatusReqType) {}
        public MassStatusReqType(int val)
            :base(Tags.MassStatusReqType, val) {}


        // Field Enumerations
        public const int STATUS_FOR_ORDERS_FOR_A_SECURITY = 1;
        public const int STATUS_FOR_ORDERS_FOR_AN_UNDERLYING_SECURITY = 2;
        public const int STATUS_FOR_ORDERS_FOR_A_PRODUCT = 3;
        public const int STATUS_FOR_ORDERS_FOR_A_CFICODE = 4;
        public const int STATUS_FOR_ORDERS_FOR_A_SECURITYTYPE = 5;
        public const int STATUS_FOR_ORDERS_FOR_A_TRADING_SESSION = 6;
        public const int STATUS_FOR_ALL_ORDERS = 7;
        public const int STATUS_FOR_ORDERS_FOR_A_PARTYID = 8;
        public const int STATUS_FOR_SECURITY_ISSUER = 9;
        public const int STATUS_FOR_ISSUER_OF_UNDERLYING_SECURITY = 10;
    }


    /// <summary>
    /// OrigOrdModTime Field
    /// </summary>/
    public sealed class OrigOrdModTime : DateTimeField
    {
        public const int TAG = 586;

        public OrigOrdModTime()
            :base(Tags.OrigOrdModTime) {}
        public OrigOrdModTime(DateTime val)
            :base(Tags.OrigOrdModTime, val) {}
        public OrigOrdModTime(DateTime val, bool showMilliseconds)
            :base(Tags.OrigOrdModTime, val, showMilliseconds) {}
		public OrigOrdModTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.OrigOrdModTime, val, precision) {}

    }


    /// <summary>
    /// LegSettlmntTyp Field
    /// </summary>/
    public sealed class LegSettlmntTyp : CharField
    {
        public const int TAG = 587;

        public LegSettlmntTyp()
            :base(Tags.LegSettlmntTyp) {}
        public LegSettlmntTyp(char val)
            :base(Tags.LegSettlmntTyp, val) {}

    }


    /// <summary>
    /// LegFutSettDate Field
    /// </summary>/
    public sealed class LegFutSettDate : StringField
    {
        public const int TAG = 588;

        public LegFutSettDate()
            :base(Tags.LegFutSettDate) {}
        public LegFutSettDate(string val)
            :base(Tags.LegFutSettDate, val) {}

    }


    /// <summary>
    /// DayBookingInst Field
    /// </summary>/
    public sealed class DayBookingInst : CharField
    {
        public const int TAG = 589;

        public DayBookingInst()
            :base(Tags.DayBookingInst) {}
        public DayBookingInst(char val)
            :base(Tags.DayBookingInst, val) {}


        // Field Enumerations
        public const char CAN_TRIGGER_BOOKING_WITHOUT_REFERENCE_TO_THE_ORDER_INITIATOR = '0';
        public const char SPEAK_WITH_ORDER_INITIATOR_BEFORE_BOOKING = '1';
        public const char ACCUMULATE = '2';
    }


    /// <summary>
    /// BookingUnit Field
    /// </summary>/
    public sealed class BookingUnit : CharField
    {
        public const int TAG = 590;

        public BookingUnit()
            :base(Tags.BookingUnit) {}
        public BookingUnit(char val)
            :base(Tags.BookingUnit, val) {}


        // Field Enumerations
        public const char EACH_PARTIAL_EXECUTION_IS_A_BOOKABLE_UNIT = '0';
        public const char AGGREGATE_PARTIAL_EXECUTIONS_ON_THIS_ORDER_AND_BOOK_ONE_TRADE_PER_ORDER = '1';
        public const char AGGREGATE_EXECUTIONS_FOR_THIS_SYMBOL_SIDE_AND_SETTLEMENT_DATE = '2';
    }


    /// <summary>
    /// PreallocMethod Field
    /// </summary>/
    public sealed class PreallocMethod : CharField
    {
        public const int TAG = 591;

        public PreallocMethod()
            :base(Tags.PreallocMethod) {}
        public PreallocMethod(char val)
            :base(Tags.PreallocMethod, val) {}


        // Field Enumerations
        public const char PRO_RATA = '0';
        public const char DO_NOT_PRO_RATA = '1';
    }


    /// <summary>
    /// UnderlyingCountryOfIssue Field
    /// </summary>/
    public sealed class UnderlyingCountryOfIssue : StringField
    {
        public const int TAG = 592;

        public UnderlyingCountryOfIssue()
            :base(Tags.UnderlyingCountryOfIssue) {}
        public UnderlyingCountryOfIssue(string val)
            :base(Tags.UnderlyingCountryOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class UnderlyingStateOrProvinceOfIssue : StringField
    {
        public const int TAG = 593;

        public UnderlyingStateOrProvinceOfIssue()
            :base(Tags.UnderlyingStateOrProvinceOfIssue) {}
        public UnderlyingStateOrProvinceOfIssue(string val)
            :base(Tags.UnderlyingStateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingLocaleOfIssue Field
    /// </summary>/
    public sealed class UnderlyingLocaleOfIssue : StringField
    {
        public const int TAG = 594;

        public UnderlyingLocaleOfIssue()
            :base(Tags.UnderlyingLocaleOfIssue) {}
        public UnderlyingLocaleOfIssue(string val)
            :base(Tags.UnderlyingLocaleOfIssue, val) {}

    }


    /// <summary>
    /// UnderlyingInstrRegistry Field
    /// </summary>/
    public sealed class UnderlyingInstrRegistry : StringField
    {
        public const int TAG = 595;

        public UnderlyingInstrRegistry()
            :base(Tags.UnderlyingInstrRegistry) {}
        public UnderlyingInstrRegistry(string val)
            :base(Tags.UnderlyingInstrRegistry, val) {}

    }


    /// <summary>
    /// LegCountryOfIssue Field
    /// </summary>/
    public sealed class LegCountryOfIssue : StringField
    {
        public const int TAG = 596;

        public LegCountryOfIssue()
            :base(Tags.LegCountryOfIssue) {}
        public LegCountryOfIssue(string val)
            :base(Tags.LegCountryOfIssue, val) {}

    }


    /// <summary>
    /// LegStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class LegStateOrProvinceOfIssue : StringField
    {
        public const int TAG = 597;

        public LegStateOrProvinceOfIssue()
            :base(Tags.LegStateOrProvinceOfIssue) {}
        public LegStateOrProvinceOfIssue(string val)
            :base(Tags.LegStateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// LegLocaleOfIssue Field
    /// </summary>/
    public sealed class LegLocaleOfIssue : StringField
    {
        public const int TAG = 598;

        public LegLocaleOfIssue()
            :base(Tags.LegLocaleOfIssue) {}
        public LegLocaleOfIssue(string val)
            :base(Tags.LegLocaleOfIssue, val) {}

    }


    /// <summary>
    /// LegInstrRegistry Field
    /// </summary>/
    public sealed class LegInstrRegistry : StringField
    {
        public const int TAG = 599;

        public LegInstrRegistry()
            :base(Tags.LegInstrRegistry) {}
        public LegInstrRegistry(string val)
            :base(Tags.LegInstrRegistry, val) {}

    }


    /// <summary>
    /// LegSymbol Field
    /// </summary>/
    public sealed class LegSymbol : StringField
    {
        public const int TAG = 600;

        public LegSymbol()
            :base(Tags.LegSymbol) {}
        public LegSymbol(string val)
            :base(Tags.LegSymbol, val) {}

    }


    /// <summary>
    /// LegSymbolSfx Field
    /// </summary>/
    public sealed class LegSymbolSfx : StringField
    {
        public const int TAG = 601;

        public LegSymbolSfx()
            :base(Tags.LegSymbolSfx) {}
        public LegSymbolSfx(string val)
            :base(Tags.LegSymbolSfx, val) {}

    }


    /// <summary>
    /// LegSecurityID Field
    /// </summary>/
    public sealed class LegSecurityID : StringField
    {
        public const int TAG = 602;

        public LegSecurityID()
            :base(Tags.LegSecurityID) {}
        public LegSecurityID(string val)
            :base(Tags.LegSecurityID, val) {}

    }


    /// <summary>
    /// LegSecurityIDSource Field
    /// </summary>/
    public sealed class LegSecurityIDSource : StringField
    {
        public const int TAG = 603;

        public LegSecurityIDSource()
            :base(Tags.LegSecurityIDSource) {}
        public LegSecurityIDSource(string val)
            :base(Tags.LegSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoLegSecurityAltID Field
    /// </summary>/
    public sealed class NoLegSecurityAltID : StringField
    {
        public const int TAG = 604;

        public NoLegSecurityAltID()
            :base(Tags.NoLegSecurityAltID) {}
        public NoLegSecurityAltID(string val)
            :base(Tags.NoLegSecurityAltID, val) {}

    }


    /// <summary>
    /// LegSecurityAltID Field
    /// </summary>/
    public sealed class LegSecurityAltID : StringField
    {
        public const int TAG = 605;

        public LegSecurityAltID()
            :base(Tags.LegSecurityAltID) {}
        public LegSecurityAltID(string val)
            :base(Tags.LegSecurityAltID, val) {}

    }


    /// <summary>
    /// LegSecurityAltIDSource Field
    /// </summary>/
    public sealed class LegSecurityAltIDSource : StringField
    {
        public const int TAG = 606;

        public LegSecurityAltIDSource()
            :base(Tags.LegSecurityAltIDSource) {}
        public LegSecurityAltIDSource(string val)
            :base(Tags.LegSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// LegProduct Field
    /// </summary>/
    public sealed class LegProduct : IntField
    {
        public const int TAG = 607;

        public LegProduct()
            :base(Tags.LegProduct) {}
        public LegProduct(int val)
            :base(Tags.LegProduct, val) {}

    }


    /// <summary>
    /// LegCFICode Field
    /// </summary>/
    public sealed class LegCFICode : StringField
    {
        public const int TAG = 608;

        public LegCFICode()
            :base(Tags.LegCFICode) {}
        public LegCFICode(string val)
            :base(Tags.LegCFICode, val) {}

    }


    /// <summary>
    /// LegSecurityType Field
    /// </summary>/
    public sealed class LegSecurityType : StringField
    {
        public const int TAG = 609;

        public LegSecurityType()
            :base(Tags.LegSecurityType) {}
        public LegSecurityType(string val)
            :base(Tags.LegSecurityType, val) {}

    }


    /// <summary>
    /// LegMaturityMonthYear Field
    /// </summary>/
    public sealed class LegMaturityMonthYear : StringField
    {
        public const int TAG = 610;

        public LegMaturityMonthYear()
            :base(Tags.LegMaturityMonthYear) {}
        public LegMaturityMonthYear(string val)
            :base(Tags.LegMaturityMonthYear, val) {}

    }


    /// <summary>
    /// LegMaturityDate Field
    /// </summary>/
    public sealed class LegMaturityDate : StringField
    {
        public const int TAG = 611;

        public LegMaturityDate()
            :base(Tags.LegMaturityDate) {}
        public LegMaturityDate(string val)
            :base(Tags.LegMaturityDate, val) {}

    }


    /// <summary>
    /// LegStrikePrice Field
    /// </summary>/
    public sealed class LegStrikePrice : DecimalField
    {
        public const int TAG = 612;

        public LegStrikePrice()
            :base(Tags.LegStrikePrice) {}
        public LegStrikePrice(Decimal val)
            :base(Tags.LegStrikePrice, val) {}

    }


    /// <summary>
    /// LegOptAttribute Field
    /// </summary>/
    public sealed class LegOptAttribute : CharField
    {
        public const int TAG = 613;

        public LegOptAttribute()
            :base(Tags.LegOptAttribute) {}
        public LegOptAttribute(char val)
            :base(Tags.LegOptAttribute, val) {}

    }


    /// <summary>
    /// LegContractMultiplier Field
    /// </summary>/
    public sealed class LegContractMultiplier : DecimalField
    {
        public const int TAG = 614;

        public LegContractMultiplier()
            :base(Tags.LegContractMultiplier) {}
        public LegContractMultiplier(Decimal val)
            :base(Tags.LegContractMultiplier, val) {}

    }


    /// <summary>
    /// LegCouponRate Field
    /// </summary>/
    public sealed class LegCouponRate : DecimalField
    {
        public const int TAG = 615;

        public LegCouponRate()
            :base(Tags.LegCouponRate) {}
        public LegCouponRate(Decimal val)
            :base(Tags.LegCouponRate, val) {}

    }


    /// <summary>
    /// LegSecurityExchange Field
    /// </summary>/
    public sealed class LegSecurityExchange : StringField
    {
        public const int TAG = 616;

        public LegSecurityExchange()
            :base(Tags.LegSecurityExchange) {}
        public LegSecurityExchange(string val)
            :base(Tags.LegSecurityExchange, val) {}

    }


    /// <summary>
    /// LegIssuer Field
    /// </summary>/
    public sealed class LegIssuer : StringField
    {
        public const int TAG = 617;

        public LegIssuer()
            :base(Tags.LegIssuer) {}
        public LegIssuer(string val)
            :base(Tags.LegIssuer, val) {}

    }


    /// <summary>
    /// EncodedLegIssuerLen Field
    /// </summary>/
    public sealed class EncodedLegIssuerLen : IntField
    {
        public const int TAG = 618;

        public EncodedLegIssuerLen()
            :base(Tags.EncodedLegIssuerLen) {}
        public EncodedLegIssuerLen(int val)
            :base(Tags.EncodedLegIssuerLen, val) {}

    }


    /// <summary>
    /// EncodedLegIssuer Field
    /// </summary>/
    public sealed class EncodedLegIssuer : StringField
    {
        public const int TAG = 619;

        public EncodedLegIssuer()
            :base(Tags.EncodedLegIssuer) {}
        public EncodedLegIssuer(string val)
            :base(Tags.EncodedLegIssuer, val) {}

    }


    /// <summary>
    /// LegSecurityDesc Field
    /// </summary>/
    public sealed class LegSecurityDesc : StringField
    {
        public const int TAG = 620;

        public LegSecurityDesc()
            :base(Tags.LegSecurityDesc) {}
        public LegSecurityDesc(string val)
            :base(Tags.LegSecurityDesc, val) {}

    }


    /// <summary>
    /// EncodedLegSecurityDescLen Field
    /// </summary>/
    public sealed class EncodedLegSecurityDescLen : IntField
    {
        public const int TAG = 621;

        public EncodedLegSecurityDescLen()
            :base(Tags.EncodedLegSecurityDescLen) {}
        public EncodedLegSecurityDescLen(int val)
            :base(Tags.EncodedLegSecurityDescLen, val) {}

    }


    /// <summary>
    /// EncodedLegSecurityDesc Field
    /// </summary>/
    public sealed class EncodedLegSecurityDesc : StringField
    {
        public const int TAG = 622;

        public EncodedLegSecurityDesc()
            :base(Tags.EncodedLegSecurityDesc) {}
        public EncodedLegSecurityDesc(string val)
            :base(Tags.EncodedLegSecurityDesc, val) {}

    }


    /// <summary>
    /// LegRatioQty Field
    /// </summary>/
    public sealed class LegRatioQty : DecimalField
    {
        public const int TAG = 623;

        public LegRatioQty()
            :base(Tags.LegRatioQty) {}
        public LegRatioQty(Decimal val)
            :base(Tags.LegRatioQty, val) {}

    }


    /// <summary>
    /// LegSide Field
    /// </summary>/
    public sealed class LegSide : CharField
    {
        public const int TAG = 624;

        public LegSide()
            :base(Tags.LegSide) {}
        public LegSide(char val)
            :base(Tags.LegSide, val) {}

    }


    /// <summary>
    /// TradingSessionSubID Field
    /// </summary>/
    public sealed class TradingSessionSubID : StringField
    {
        public const int TAG = 625;

        public TradingSessionSubID()
            :base(Tags.TradingSessionSubID) {}
        public TradingSessionSubID(string val)
            :base(Tags.TradingSessionSubID, val) {}


        // Field Enumerations
        public const string PRE_TRADING = "1";
        public const string OPENING_OR_OPENING_AUCTION = "2";
        public const string VAL_3 = "3";
        public const string CLOSING_OR_CLOSING_AUCTION = "4";
        public const string POST_TRADING = "5";
        public const string INTRADAY_AUCTION = "6";
        public const string QUIESCENT = "7";
    }


    /// <summary>
    /// AllocType Field
    /// </summary>/
    public sealed class AllocType : IntField
    {
        public const int TAG = 626;

        public AllocType()
            :base(Tags.AllocType) {}
        public AllocType(int val)
            :base(Tags.AllocType, val) {}


        // Field Enumerations
        public const int CALCULATED = 1;
        public const int PRELIMINARY = 2;
        public const int SELLSIDE_CALCULATED_USING_PRELIMINARY = 3;
        public const int SELLSIDE_CALCULATED_WITHOUT_PRELIMINARY = 4;
        public const int READY_TO_BOOK = 5;
        public const int BUYSIDE_READY_TO_BOOK = 6;
        public const int WAREHOUSE_INSTRUCTION = 7;
        public const int REQUEST_TO_INTERMEDIARY = 8;
        public const int ACCEPT = 9;
        public const int REJECT = 10;
        public const int ACCEPT_PENDING = 11;
        public const int INCOMPLETE_GROUP = 12;
        public const int COMPLETE_GROUP = 13;
        public const int REVERSAL_PENDING = 14;
        public const int READY_TO_BOOK_SINGLE_ORDER = 5;
        public const int BUYSIDE_CALCULATED = 1;
        public const int BUYSIDE_PRELIMINARY = 2;
        public const int BUYSIDE_READY_TO_BOOK_SINGLE_ORDER = 5;
        public const int BUYSIDE_READY_TO_BOOK_COMBINED_SET_OF_ORDERS = 6;
    }


    /// <summary>
    /// NoHops Field
    /// </summary>/
    public sealed class NoHops : IntField
    {
        public const int TAG = 627;

        public NoHops()
            :base(Tags.NoHops) {}
        public NoHops(int val)
            :base(Tags.NoHops, val) {}

    }


    /// <summary>
    /// HopCompID Field
    /// </summary>/
    public sealed class HopCompID : StringField
    {
        public const int TAG = 628;

        public HopCompID()
            :base(Tags.HopCompID) {}
        public HopCompID(string val)
            :base(Tags.HopCompID, val) {}

    }


    /// <summary>
    /// HopSendingTime Field
    /// </summary>/
    public sealed class HopSendingTime : DateTimeField
    {
        public const int TAG = 629;

        public HopSendingTime()
            :base(Tags.HopSendingTime) {}
        public HopSendingTime(DateTime val)
            :base(Tags.HopSendingTime, val) {}
        public HopSendingTime(DateTime val, bool showMilliseconds)
            :base(Tags.HopSendingTime, val, showMilliseconds) {}
		public HopSendingTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.HopSendingTime, val, precision) {}

    }


    /// <summary>
    /// HopRefID Field
    /// </summary>/
    public sealed class HopRefID : IntField
    {
        public const int TAG = 630;

        public HopRefID()
            :base(Tags.HopRefID) {}
        public HopRefID(int val)
            :base(Tags.HopRefID, val) {}

    }


    /// <summary>
    /// MidPx Field
    /// </summary>/
    public sealed class MidPx : DecimalField
    {
        public const int TAG = 631;

        public MidPx()
            :base(Tags.MidPx) {}
        public MidPx(Decimal val)
            :base(Tags.MidPx, val) {}

    }


    /// <summary>
    /// BidYield Field
    /// </summary>/
    public sealed class BidYield : DecimalField
    {
        public const int TAG = 632;

        public BidYield()
            :base(Tags.BidYield) {}
        public BidYield(Decimal val)
            :base(Tags.BidYield, val) {}

    }


    /// <summary>
    /// MidYield Field
    /// </summary>/
    public sealed class MidYield : DecimalField
    {
        public const int TAG = 633;

        public MidYield()
            :base(Tags.MidYield) {}
        public MidYield(Decimal val)
            :base(Tags.MidYield, val) {}

    }


    /// <summary>
    /// OfferYield Field
    /// </summary>/
    public sealed class OfferYield : DecimalField
    {
        public const int TAG = 634;

        public OfferYield()
            :base(Tags.OfferYield) {}
        public OfferYield(Decimal val)
            :base(Tags.OfferYield, val) {}

    }


    /// <summary>
    /// ClearingFeeIndicator Field
    /// </summary>/
    public sealed class ClearingFeeIndicator : StringField
    {
        public const int TAG = 635;

        public ClearingFeeIndicator()
            :base(Tags.ClearingFeeIndicator) {}
        public ClearingFeeIndicator(string val)
            :base(Tags.ClearingFeeIndicator, val) {}


        // Field Enumerations
        public const string VAL_1ST_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "1";
        public const string VAL_2ND_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "2";
        public const string VAL_3RD_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "3";
        public const string VAL_4TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "4";
        public const string VAL_5TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "5";
        public const string VAL_6TH_YEAR_DELEGATE_TRADING_FOR_OWN_ACCOUNT = "9";
        public const string CBOE_MEMBER = "B";
        public const string NON_MEMBER_AND_CUSTOMER = "C";
        public const string EQUITY_MEMBER_AND_CLEARING_MEMBER = "E";
        public const string FULL_AND_ASSOCIATE_MEMBER_TRADING_FOR_OWN_ACCOUNT_AND_AS_FLOOR_BROKERS = "F";
        public const string VAL_106H_AND_106J_FIRMS = "H";
        public const string GIM_IDEM_AND_COM_MEMBERSHIP_INTEREST_HOLDERS = "I";
        public const string LESSEE_106F_EMPLOYEES = "L";
        public const string ALL_OTHER_OWNERSHIP_TYPES = "M";
        public const string FIRMS_106H_AND_106J = "H";
        public const string LESSEE_AND_106F_EMPLOYEES = "L";
    }


    /// <summary>
    /// WorkingIndicator Field
    /// </summary>/
    public sealed class WorkingIndicator : BooleanField
    {
        public const int TAG = 636;

        public WorkingIndicator()
            :base(Tags.WorkingIndicator) {}
        public WorkingIndicator(Boolean val)
            :base(Tags.WorkingIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// LegLastPx Field
    /// </summary>/
    public sealed class LegLastPx : DecimalField
    {
        public const int TAG = 637;

        public LegLastPx()
            :base(Tags.LegLastPx) {}
        public LegLastPx(Decimal val)
            :base(Tags.LegLastPx, val) {}

    }


    /// <summary>
    /// PriorityIndicator Field
    /// </summary>/
    public sealed class PriorityIndicator : IntField
    {
        public const int TAG = 638;

        public PriorityIndicator()
            :base(Tags.PriorityIndicator) {}
        public PriorityIndicator(int val)
            :base(Tags.PriorityIndicator, val) {}


        // Field Enumerations
        public const int PRIORITY_UNCHANGED = 0;
        public const int LOST_PRIORITY_AS_RESULT_OF_ORDER_CHANGE = 1;
    }


    /// <summary>
    /// PriceImprovement Field
    /// </summary>/
    public sealed class PriceImprovement : DecimalField
    {
        public const int TAG = 639;

        public PriceImprovement()
            :base(Tags.PriceImprovement) {}
        public PriceImprovement(Decimal val)
            :base(Tags.PriceImprovement, val) {}

    }


    /// <summary>
    /// Price2 Field
    /// </summary>/
    public sealed class Price2 : DecimalField
    {
        public const int TAG = 640;

        public Price2()
            :base(Tags.Price2) {}
        public Price2(Decimal val)
            :base(Tags.Price2, val) {}

    }


    /// <summary>
    /// LastForwardPoints2 Field
    /// </summary>/
    public sealed class LastForwardPoints2 : DecimalField
    {
        public const int TAG = 641;

        public LastForwardPoints2()
            :base(Tags.LastForwardPoints2) {}
        public LastForwardPoints2(Decimal val)
            :base(Tags.LastForwardPoints2, val) {}

    }


    /// <summary>
    /// BidForwardPoints2 Field
    /// </summary>/
    public sealed class BidForwardPoints2 : DecimalField
    {
        public const int TAG = 642;

        public BidForwardPoints2()
            :base(Tags.BidForwardPoints2) {}
        public BidForwardPoints2(Decimal val)
            :base(Tags.BidForwardPoints2, val) {}

    }


    /// <summary>
    /// OfferForwardPoints2 Field
    /// </summary>/
    public sealed class OfferForwardPoints2 : DecimalField
    {
        public const int TAG = 643;

        public OfferForwardPoints2()
            :base(Tags.OfferForwardPoints2) {}
        public OfferForwardPoints2(Decimal val)
            :base(Tags.OfferForwardPoints2, val) {}

    }


    /// <summary>
    /// RFQReqID Field
    /// </summary>/
    public sealed class RFQReqID : StringField
    {
        public const int TAG = 644;

        public RFQReqID()
            :base(Tags.RFQReqID) {}
        public RFQReqID(string val)
            :base(Tags.RFQReqID, val) {}

    }


    /// <summary>
    /// MktBidPx Field
    /// </summary>/
    public sealed class MktBidPx : DecimalField
    {
        public const int TAG = 645;

        public MktBidPx()
            :base(Tags.MktBidPx) {}
        public MktBidPx(Decimal val)
            :base(Tags.MktBidPx, val) {}

    }


    /// <summary>
    /// MktOfferPx Field
    /// </summary>/
    public sealed class MktOfferPx : DecimalField
    {
        public const int TAG = 646;

        public MktOfferPx()
            :base(Tags.MktOfferPx) {}
        public MktOfferPx(Decimal val)
            :base(Tags.MktOfferPx, val) {}

    }


    /// <summary>
    /// MinBidSize Field
    /// </summary>/
    public sealed class MinBidSize : DecimalField
    {
        public const int TAG = 647;

        public MinBidSize()
            :base(Tags.MinBidSize) {}
        public MinBidSize(Decimal val)
            :base(Tags.MinBidSize, val) {}

    }


    /// <summary>
    /// MinOfferSize Field
    /// </summary>/
    public sealed class MinOfferSize : DecimalField
    {
        public const int TAG = 648;

        public MinOfferSize()
            :base(Tags.MinOfferSize) {}
        public MinOfferSize(Decimal val)
            :base(Tags.MinOfferSize, val) {}

    }


    /// <summary>
    /// QuoteStatusReqID Field
    /// </summary>/
    public sealed class QuoteStatusReqID : StringField
    {
        public const int TAG = 649;

        public QuoteStatusReqID()
            :base(Tags.QuoteStatusReqID) {}
        public QuoteStatusReqID(string val)
            :base(Tags.QuoteStatusReqID, val) {}

    }


    /// <summary>
    /// LegalConfirm Field
    /// </summary>/
    public sealed class LegalConfirm : BooleanField
    {
        public const int TAG = 650;

        public LegalConfirm()
            :base(Tags.LegalConfirm) {}
        public LegalConfirm(Boolean val)
            :base(Tags.LegalConfirm, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// UnderlyingLastPx Field
    /// </summary>/
    public sealed class UnderlyingLastPx : DecimalField
    {
        public const int TAG = 651;

        public UnderlyingLastPx()
            :base(Tags.UnderlyingLastPx) {}
        public UnderlyingLastPx(Decimal val)
            :base(Tags.UnderlyingLastPx, val) {}

    }


    /// <summary>
    /// UnderlyingLastQty Field
    /// </summary>/
    public sealed class UnderlyingLastQty : DecimalField
    {
        public const int TAG = 652;

        public UnderlyingLastQty()
            :base(Tags.UnderlyingLastQty) {}
        public UnderlyingLastQty(Decimal val)
            :base(Tags.UnderlyingLastQty, val) {}

    }


    /// <summary>
    /// SecDefStatus Field
    /// </summary>/
    public sealed class SecDefStatus : IntField
    {
        public const int TAG = 653;

        public SecDefStatus()
            :base(Tags.SecDefStatus) {}
        public SecDefStatus(int val)
            :base(Tags.SecDefStatus, val) {}


        // Field Enumerations
        public const int PENDING_APPROVAL = 0;
        public const int APPROVED = 1;
        public const int REJECTED = 2;
        public const int UNAUTHORIZED_REQUEST = 3;
        public const int INVALID_DEFINITION_REQUEST = 4;
    }


    /// <summary>
    /// LegRefID Field
    /// </summary>/
    public sealed class LegRefID : StringField
    {
        public const int TAG = 654;

        public LegRefID()
            :base(Tags.LegRefID) {}
        public LegRefID(string val)
            :base(Tags.LegRefID, val) {}

    }


    /// <summary>
    /// ContraLegRefID Field
    /// </summary>/
    public sealed class ContraLegRefID : StringField
    {
        public const int TAG = 655;

        public ContraLegRefID()
            :base(Tags.ContraLegRefID) {}
        public ContraLegRefID(string val)
            :base(Tags.ContraLegRefID, val) {}

    }


    /// <summary>
    /// SettlCurrBidFxRate Field
    /// </summary>/
    public sealed class SettlCurrBidFxRate : DecimalField
    {
        public const int TAG = 656;

        public SettlCurrBidFxRate()
            :base(Tags.SettlCurrBidFxRate) {}
        public SettlCurrBidFxRate(Decimal val)
            :base(Tags.SettlCurrBidFxRate, val) {}

    }


    /// <summary>
    /// SettlCurrOfferFxRate Field
    /// </summary>/
    public sealed class SettlCurrOfferFxRate : DecimalField
    {
        public const int TAG = 657;

        public SettlCurrOfferFxRate()
            :base(Tags.SettlCurrOfferFxRate) {}
        public SettlCurrOfferFxRate(Decimal val)
            :base(Tags.SettlCurrOfferFxRate, val) {}

    }


    /// <summary>
    /// QuoteRequestRejectReason Field
    /// </summary>/
    public sealed class QuoteRequestRejectReason : IntField
    {
        public const int TAG = 658;

        public QuoteRequestRejectReason()
            :base(Tags.QuoteRequestRejectReason) {}
        public QuoteRequestRejectReason(int val)
            :base(Tags.QuoteRequestRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_SYMBOL = 1;
        public const int PASS = 10;
        public const int EXCHANGE = 2;
        public const int QUOTE_REQUEST_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int INVALID_PRICE = 5;
        public const int NOT_AUTHORIZED_TO_REQUEST_QUOTE = 6;
        public const int NO_MATCH_FOR_INQUIRY = 7;
        public const int NO_MARKET_FOR_INSTRUMENT = 8;
        public const int NO_INVENTORY = 9;
        public const int OTHER = 99;
        public const int INSUFFICIENT_CREDIT = 11;
        public const int EXCHANGE_CLOSED = 2;
    }


    /// <summary>
    /// SideComplianceID Field
    /// </summary>/
    public sealed class SideComplianceID : StringField
    {
        public const int TAG = 659;

        public SideComplianceID()
            :base(Tags.SideComplianceID) {}
        public SideComplianceID(string val)
            :base(Tags.SideComplianceID, val) {}

    }


    /// <summary>
    /// SettlType Field
    /// </summary>/
    public sealed class SettlType : StringField
    {
        public const int TAG = 63;

        public SettlType()
            :base(Tags.SettlType) {}
        public SettlType(string val)
            :base(Tags.SettlType, val) {}


        // Field Enumerations
        public const string REGULAR = "0";
        public const string CASH = "1";
        public const string NEXT_DAY = "2";
        public const string T_PLUS_2 = "3";
        public const string T_PLUS_3 = "4";
        public const string T_PLUS_4 = "5";
        public const string FUTURE = "6";
        public const string WHEN_AND_IF_ISSUED = "7";
        public const string SELLERS_OPTION = "8";
        public const string T_PLUS_5 = "9";
        public const string FX_SPOT_NEXT_SETTLEMENT = "C";
        public const string BROKEN_DATE = "B";
    }


    /// <summary>
    /// SettlDate Field
    /// </summary>/
    public sealed class SettlDate : StringField
    {
        public const int TAG = 64;

        public SettlDate()
            :base(Tags.SettlDate) {}
        public SettlDate(string val)
            :base(Tags.SettlDate, val) {}

    }


    /// <summary>
    /// AvgPxPrecision Field
    /// </summary>/
    public sealed class AvgPxPrecision : IntField
    {
        public const int TAG = 74;

        public AvgPxPrecision()
            :base(Tags.AvgPxPrecision) {}
        public AvgPxPrecision(int val)
            :base(Tags.AvgPxPrecision, val) {}

    }


    /// <summary>
    /// SettlDate2 Field
    /// </summary>/
    public sealed class SettlDate2 : StringField
    {
        public const int TAG = 193;

        public SettlDate2()
            :base(Tags.SettlDate2) {}
        public SettlDate2(string val)
            :base(Tags.SettlDate2, val) {}

    }


    /// <summary>
    /// PegOffsetValue Field
    /// </summary>/
    public sealed class PegOffsetValue : DecimalField
    {
        public const int TAG = 211;

        public PegOffsetValue()
            :base(Tags.PegOffsetValue) {}
        public PegOffsetValue(Decimal val)
            :base(Tags.PegOffsetValue, val) {}

    }


    /// <summary>
    /// OpenCloseSettlFlag Field
    /// </summary>/
    public sealed class OpenCloseSettlFlag : StringField
    {
        public const int TAG = 286;

        public OpenCloseSettlFlag()
            :base(Tags.OpenCloseSettlFlag) {}
        public OpenCloseSettlFlag(string val)
            :base(Tags.OpenCloseSettlFlag, val) {}


        // Field Enumerations
        public const string DAILY_OPEN = "0";
        public const string SESSION_OPEN = "1";
        public const string DELIVERY_SETTLEMENT_ENTRY = "2";
        public const string EXPECTED_ENTRY = "3";
        public const string ENTRY_FROM_PREVIOUS_BUSINESS_DAY = "4";
        public const string THEORETICAL_PRICE_VALUE = "5";
        public const string DAILY_OPEN_CLOSE_SETTLEMENT_ENTRY = "0";
        public const string SESSION_OPEN_CLOSE_SETTLEMENT_ENTRY = "1";
    }


    /// <summary>
    /// TotNoQuoteEntries Field
    /// </summary>/
    public sealed class TotNoQuoteEntries : IntField
    {
        public const int TAG = 304;

        public TotNoQuoteEntries()
            :base(Tags.TotNoQuoteEntries) {}
        public TotNoQuoteEntries(int val)
            :base(Tags.TotNoQuoteEntries, val) {}

    }


    /// <summary>
    /// DiscretionOffsetValue Field
    /// </summary>/
    public sealed class DiscretionOffsetValue : DecimalField
    {
        public const int TAG = 389;

        public DiscretionOffsetValue()
            :base(Tags.DiscretionOffsetValue) {}
        public DiscretionOffsetValue(Decimal val)
            :base(Tags.DiscretionOffsetValue, val) {}

    }


    /// <summary>
    /// TotNoRelatedSym Field
    /// </summary>/
    public sealed class TotNoRelatedSym : IntField
    {
        public const int TAG = 393;

        public TotNoRelatedSym()
            :base(Tags.TotNoRelatedSym) {}
        public TotNoRelatedSym(int val)
            :base(Tags.TotNoRelatedSym, val) {}

    }


    /// <summary>
    /// BidTradeType Field
    /// </summary>/
    public sealed class BidTradeType : CharField
    {
        public const int TAG = 418;

        public BidTradeType()
            :base(Tags.BidTradeType) {}
        public BidTradeType(char val)
            :base(Tags.BidTradeType, val) {}


        // Field Enumerations
        public const char AGENCY = 'A';
        public const char VWAP_GUARANTEE = 'G';
        public const char GUARANTEED_CLOSE = 'J';
        public const char RISK_TRADE = 'R';
    }


    /// <summary>
    /// CardIssNum Field
    /// </summary>/
    public sealed class CardIssNum : StringField
    {
        public const int TAG = 491;

        public CardIssNum()
            :base(Tags.CardIssNum) {}
        public CardIssNum(string val)
            :base(Tags.CardIssNum, val) {}

    }


    /// <summary>
    /// RegistDtls Field
    /// </summary>/
    public sealed class RegistDtls : StringField
    {
        public const int TAG = 509;

        public RegistDtls()
            :base(Tags.RegistDtls) {}
        public RegistDtls(string val)
            :base(Tags.RegistDtls, val) {}

    }


    /// <summary>
    /// TotNoSecurityTypes Field
    /// </summary>/
    public sealed class TotNoSecurityTypes : IntField
    {
        public const int TAG = 557;

        public TotNoSecurityTypes()
            :base(Tags.TotNoSecurityTypes) {}
        public TotNoSecurityTypes(int val)
            :base(Tags.TotNoSecurityTypes, val) {}

    }


    /// <summary>
    /// LegSettlType Field
    /// </summary>/
    public sealed class LegSettlType : CharField
    {
        public const int TAG = 587;

        public LegSettlType()
            :base(Tags.LegSettlType) {}
        public LegSettlType(char val)
            :base(Tags.LegSettlType, val) {}

    }


    /// <summary>
    /// LegSettlDate Field
    /// </summary>/
    public sealed class LegSettlDate : StringField
    {
        public const int TAG = 588;

        public LegSettlDate()
            :base(Tags.LegSettlDate) {}
        public LegSettlDate(string val)
            :base(Tags.LegSettlDate, val) {}

    }


    /// <summary>
    /// AcctIDSource Field
    /// </summary>/
    public sealed class AcctIDSource : IntField
    {
        public const int TAG = 660;

        public AcctIDSource()
            :base(Tags.AcctIDSource) {}
        public AcctIDSource(int val)
            :base(Tags.AcctIDSource, val) {}


        // Field Enumerations
        public const int BIC = 1;
        public const int SID_CODE = 2;
        public const int TFM = 3;
        public const int OMGEO = 4;
        public const int DTCC_CODE = 5;
        public const int OTHER = 99;
    }


    /// <summary>
    /// AllocAcctIDSource Field
    /// </summary>/
    public sealed class AllocAcctIDSource : IntField
    {
        public const int TAG = 661;

        public AllocAcctIDSource()
            :base(Tags.AllocAcctIDSource) {}
        public AllocAcctIDSource(int val)
            :base(Tags.AllocAcctIDSource, val) {}

    }


    /// <summary>
    /// BenchmarkPrice Field
    /// </summary>/
    public sealed class BenchmarkPrice : DecimalField
    {
        public const int TAG = 662;

        public BenchmarkPrice()
            :base(Tags.BenchmarkPrice) {}
        public BenchmarkPrice(Decimal val)
            :base(Tags.BenchmarkPrice, val) {}

    }


    /// <summary>
    /// BenchmarkPriceType Field
    /// </summary>/
    public sealed class BenchmarkPriceType : IntField
    {
        public const int TAG = 663;

        public BenchmarkPriceType()
            :base(Tags.BenchmarkPriceType) {}
        public BenchmarkPriceType(int val)
            :base(Tags.BenchmarkPriceType, val) {}

    }


    /// <summary>
    /// ConfirmID Field
    /// </summary>/
    public sealed class ConfirmID : StringField
    {
        public const int TAG = 664;

        public ConfirmID()
            :base(Tags.ConfirmID) {}
        public ConfirmID(string val)
            :base(Tags.ConfirmID, val) {}

    }


    /// <summary>
    /// ConfirmStatus Field
    /// </summary>/
    public sealed class ConfirmStatus : IntField
    {
        public const int TAG = 665;

        public ConfirmStatus()
            :base(Tags.ConfirmStatus) {}
        public ConfirmStatus(int val)
            :base(Tags.ConfirmStatus, val) {}


        // Field Enumerations
        public const int RECEIVED = 1;
        public const int MISMATCHED_ACCOUNT = 2;
        public const int MISSING_SETTLEMENT_INSTRUCTIONS = 3;
        public const int CONFIRMED = 4;
        public const int REQUEST_REJECTED = 5;
    }


    /// <summary>
    /// ConfirmTransType Field
    /// </summary>/
    public sealed class ConfirmTransType : IntField
    {
        public const int TAG = 666;

        public ConfirmTransType()
            :base(Tags.ConfirmTransType) {}
        public ConfirmTransType(int val)
            :base(Tags.ConfirmTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int REPLACE = 1;
        public const int CANCEL = 2;
    }


    /// <summary>
    /// ContractSettlMonth Field
    /// </summary>/
    public sealed class ContractSettlMonth : StringField
    {
        public const int TAG = 667;

        public ContractSettlMonth()
            :base(Tags.ContractSettlMonth) {}
        public ContractSettlMonth(string val)
            :base(Tags.ContractSettlMonth, val) {}

    }


    /// <summary>
    /// DeliveryForm Field
    /// </summary>/
    public sealed class DeliveryForm : IntField
    {
        public const int TAG = 668;

        public DeliveryForm()
            :base(Tags.DeliveryForm) {}
        public DeliveryForm(int val)
            :base(Tags.DeliveryForm, val) {}


        // Field Enumerations
        public const int BOOK_ENTRY = 1;
        public const int BEARER = 2;
        public const int BOOKENTRY = 1;
    }


    /// <summary>
    /// LastParPx Field
    /// </summary>/
    public sealed class LastParPx : DecimalField
    {
        public const int TAG = 669;

        public LastParPx()
            :base(Tags.LastParPx) {}
        public LastParPx(Decimal val)
            :base(Tags.LastParPx, val) {}

    }


    /// <summary>
    /// NoLegAllocs Field
    /// </summary>/
    public sealed class NoLegAllocs : IntField
    {
        public const int TAG = 670;

        public NoLegAllocs()
            :base(Tags.NoLegAllocs) {}
        public NoLegAllocs(int val)
            :base(Tags.NoLegAllocs, val) {}

    }


    /// <summary>
    /// LegAllocAccount Field
    /// </summary>/
    public sealed class LegAllocAccount : StringField
    {
        public const int TAG = 671;

        public LegAllocAccount()
            :base(Tags.LegAllocAccount) {}
        public LegAllocAccount(string val)
            :base(Tags.LegAllocAccount, val) {}

    }


    /// <summary>
    /// LegIndividualAllocID Field
    /// </summary>/
    public sealed class LegIndividualAllocID : StringField
    {
        public const int TAG = 672;

        public LegIndividualAllocID()
            :base(Tags.LegIndividualAllocID) {}
        public LegIndividualAllocID(string val)
            :base(Tags.LegIndividualAllocID, val) {}

    }


    /// <summary>
    /// LegAllocQty Field
    /// </summary>/
    public sealed class LegAllocQty : DecimalField
    {
        public const int TAG = 673;

        public LegAllocQty()
            :base(Tags.LegAllocQty) {}
        public LegAllocQty(Decimal val)
            :base(Tags.LegAllocQty, val) {}

    }


    /// <summary>
    /// LegAllocAcctIDSource Field
    /// </summary>/
    public sealed class LegAllocAcctIDSource : StringField
    {
        public const int TAG = 674;

        public LegAllocAcctIDSource()
            :base(Tags.LegAllocAcctIDSource) {}
        public LegAllocAcctIDSource(string val)
            :base(Tags.LegAllocAcctIDSource, val) {}

    }


    /// <summary>
    /// LegSettlCurrency Field
    /// </summary>/
    public sealed class LegSettlCurrency : StringField
    {
        public const int TAG = 675;

        public LegSettlCurrency()
            :base(Tags.LegSettlCurrency) {}
        public LegSettlCurrency(string val)
            :base(Tags.LegSettlCurrency, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurveCurrency Field
    /// </summary>/
    public sealed class LegBenchmarkCurveCurrency : StringField
    {
        public const int TAG = 676;

        public LegBenchmarkCurveCurrency()
            :base(Tags.LegBenchmarkCurveCurrency) {}
        public LegBenchmarkCurveCurrency(string val)
            :base(Tags.LegBenchmarkCurveCurrency, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurveName Field
    /// </summary>/
    public sealed class LegBenchmarkCurveName : StringField
    {
        public const int TAG = 677;

        public LegBenchmarkCurveName()
            :base(Tags.LegBenchmarkCurveName) {}
        public LegBenchmarkCurveName(string val)
            :base(Tags.LegBenchmarkCurveName, val) {}

    }


    /// <summary>
    /// LegBenchmarkCurvePoint Field
    /// </summary>/
    public sealed class LegBenchmarkCurvePoint : StringField
    {
        public const int TAG = 678;

        public LegBenchmarkCurvePoint()
            :base(Tags.LegBenchmarkCurvePoint) {}
        public LegBenchmarkCurvePoint(string val)
            :base(Tags.LegBenchmarkCurvePoint, val) {}

    }


    /// <summary>
    /// LegBenchmarkPrice Field
    /// </summary>/
    public sealed class LegBenchmarkPrice : DecimalField
    {
        public const int TAG = 679;

        public LegBenchmarkPrice()
            :base(Tags.LegBenchmarkPrice) {}
        public LegBenchmarkPrice(Decimal val)
            :base(Tags.LegBenchmarkPrice, val) {}

    }


    /// <summary>
    /// LegBenchmarkPriceType Field
    /// </summary>/
    public sealed class LegBenchmarkPriceType : IntField
    {
        public const int TAG = 680;

        public LegBenchmarkPriceType()
            :base(Tags.LegBenchmarkPriceType) {}
        public LegBenchmarkPriceType(int val)
            :base(Tags.LegBenchmarkPriceType, val) {}

    }


    /// <summary>
    /// LegBidPx Field
    /// </summary>/
    public sealed class LegBidPx : DecimalField
    {
        public const int TAG = 681;

        public LegBidPx()
            :base(Tags.LegBidPx) {}
        public LegBidPx(Decimal val)
            :base(Tags.LegBidPx, val) {}

    }


    /// <summary>
    /// LegIOIQty Field
    /// </summary>/
    public sealed class LegIOIQty : StringField
    {
        public const int TAG = 682;

        public LegIOIQty()
            :base(Tags.LegIOIQty) {}
        public LegIOIQty(string val)
            :base(Tags.LegIOIQty, val) {}

    }


    /// <summary>
    /// NoLegStipulations Field
    /// </summary>/
    public sealed class NoLegStipulations : IntField
    {
        public const int TAG = 683;

        public NoLegStipulations()
            :base(Tags.NoLegStipulations) {}
        public NoLegStipulations(int val)
            :base(Tags.NoLegStipulations, val) {}

    }


    /// <summary>
    /// LegOfferPx Field
    /// </summary>/
    public sealed class LegOfferPx : DecimalField
    {
        public const int TAG = 684;

        public LegOfferPx()
            :base(Tags.LegOfferPx) {}
        public LegOfferPx(Decimal val)
            :base(Tags.LegOfferPx, val) {}

    }


    /// <summary>
    /// LegOrderQty Field
    /// </summary>/
    public sealed class LegOrderQty : DecimalField
    {
        public const int TAG = 685;

        public LegOrderQty()
            :base(Tags.LegOrderQty) {}
        public LegOrderQty(Decimal val)
            :base(Tags.LegOrderQty, val) {}

    }


    /// <summary>
    /// LegPriceType Field
    /// </summary>/
    public sealed class LegPriceType : IntField
    {
        public const int TAG = 686;

        public LegPriceType()
            :base(Tags.LegPriceType) {}
        public LegPriceType(int val)
            :base(Tags.LegPriceType, val) {}

    }


    /// <summary>
    /// LegQty Field
    /// </summary>/
    public sealed class LegQty : DecimalField
    {
        public const int TAG = 687;

        public LegQty()
            :base(Tags.LegQty) {}
        public LegQty(Decimal val)
            :base(Tags.LegQty, val) {}

    }


    /// <summary>
    /// LegStipulationType Field
    /// </summary>/
    public sealed class LegStipulationType : StringField
    {
        public const int TAG = 688;

        public LegStipulationType()
            :base(Tags.LegStipulationType) {}
        public LegStipulationType(string val)
            :base(Tags.LegStipulationType, val) {}

    }


    /// <summary>
    /// LegStipulationValue Field
    /// </summary>/
    public sealed class LegStipulationValue : StringField
    {
        public const int TAG = 689;

        public LegStipulationValue()
            :base(Tags.LegStipulationValue) {}
        public LegStipulationValue(string val)
            :base(Tags.LegStipulationValue, val) {}

    }


    /// <summary>
    /// LegSwapType Field
    /// </summary>/
    public sealed class LegSwapType : IntField
    {
        public const int TAG = 690;

        public LegSwapType()
            :base(Tags.LegSwapType) {}
        public LegSwapType(int val)
            :base(Tags.LegSwapType, val) {}


        // Field Enumerations
        public const int PAR_FOR_PAR = 1;
        public const int MODIFIED_DURATION = 2;
        public const int RISK = 4;
        public const int PROCEEDS = 5;
    }


    /// <summary>
    /// Pool Field
    /// </summary>/
    public sealed class Pool : StringField
    {
        public const int TAG = 691;

        public Pool()
            :base(Tags.Pool) {}
        public Pool(string val)
            :base(Tags.Pool, val) {}

    }


    /// <summary>
    /// QuotePriceType Field
    /// </summary>/
    public sealed class QuotePriceType : IntField
    {
        public const int TAG = 692;

        public QuotePriceType()
            :base(Tags.QuotePriceType) {}
        public QuotePriceType(int val)
            :base(Tags.QuotePriceType, val) {}


        // Field Enumerations
        public const int PERCENT = 1;
        public const int YIELD = 10;
        public const int PER_SHARE = 2;
        public const int FIXED_AMOUNT = 3;
        public const int DISCOUNT = 4;
        public const int PREMIUM = 5;
        public const int SPREAD = 6;
        public const int TED_PRICE = 7;
        public const int TED_YIELD = 8;
        public const int YIELD_SPREAD = 9;
        public const int BASIS_POINTS_RELATIVE_TO_BENCHMARK = 6;
    }


    /// <summary>
    /// QuoteRespID Field
    /// </summary>/
    public sealed class QuoteRespID : StringField
    {
        public const int TAG = 693;

        public QuoteRespID()
            :base(Tags.QuoteRespID) {}
        public QuoteRespID(string val)
            :base(Tags.QuoteRespID, val) {}

    }


    /// <summary>
    /// QuoteRespType Field
    /// </summary>/
    public sealed class QuoteRespType : IntField
    {
        public const int TAG = 694;

        public QuoteRespType()
            :base(Tags.QuoteRespType) {}
        public QuoteRespType(int val)
            :base(Tags.QuoteRespType, val) {}


        // Field Enumerations
        public const int HIT_LIFT = 1;
        public const int COUNTER = 2;
        public const int EXPIRED = 3;
        public const int COVER = 4;
        public const int DONE_AWAY = 5;
        public const int PASS = 6;
        public const int END_TRADE = 7;
        public const int TIMED_OUT = 8;
    }


    /// <summary>
    /// QuoteQualifier Field
    /// </summary>/
    public sealed class QuoteQualifier : CharField
    {
        public const int TAG = 695;

        public QuoteQualifier()
            :base(Tags.QuoteQualifier) {}
        public QuoteQualifier(char val)
            :base(Tags.QuoteQualifier, val) {}

    }


    /// <summary>
    /// YieldRedemptionDate Field
    /// </summary>/
    public sealed class YieldRedemptionDate : StringField
    {
        public const int TAG = 696;

        public YieldRedemptionDate()
            :base(Tags.YieldRedemptionDate) {}
        public YieldRedemptionDate(string val)
            :base(Tags.YieldRedemptionDate, val) {}

    }


    /// <summary>
    /// YieldRedemptionPrice Field
    /// </summary>/
    public sealed class YieldRedemptionPrice : DecimalField
    {
        public const int TAG = 697;

        public YieldRedemptionPrice()
            :base(Tags.YieldRedemptionPrice) {}
        public YieldRedemptionPrice(Decimal val)
            :base(Tags.YieldRedemptionPrice, val) {}

    }


    /// <summary>
    /// YieldRedemptionPriceType Field
    /// </summary>/
    public sealed class YieldRedemptionPriceType : IntField
    {
        public const int TAG = 698;

        public YieldRedemptionPriceType()
            :base(Tags.YieldRedemptionPriceType) {}
        public YieldRedemptionPriceType(int val)
            :base(Tags.YieldRedemptionPriceType, val) {}

    }


    /// <summary>
    /// BenchmarkSecurityID Field
    /// </summary>/
    public sealed class BenchmarkSecurityID : StringField
    {
        public const int TAG = 699;

        public BenchmarkSecurityID()
            :base(Tags.BenchmarkSecurityID) {}
        public BenchmarkSecurityID(string val)
            :base(Tags.BenchmarkSecurityID, val) {}

    }


    /// <summary>
    /// ReversalIndicator Field
    /// </summary>/
    public sealed class ReversalIndicator : BooleanField
    {
        public const int TAG = 700;

        public ReversalIndicator()
            :base(Tags.ReversalIndicator) {}
        public ReversalIndicator(Boolean val)
            :base(Tags.ReversalIndicator, val) {}

    }


    /// <summary>
    /// YieldCalcDate Field
    /// </summary>/
    public sealed class YieldCalcDate : StringField
    {
        public const int TAG = 701;

        public YieldCalcDate()
            :base(Tags.YieldCalcDate) {}
        public YieldCalcDate(string val)
            :base(Tags.YieldCalcDate, val) {}

    }


    /// <summary>
    /// NoPositions Field
    /// </summary>/
    public sealed class NoPositions : IntField
    {
        public const int TAG = 702;

        public NoPositions()
            :base(Tags.NoPositions) {}
        public NoPositions(int val)
            :base(Tags.NoPositions, val) {}

    }


    /// <summary>
    /// PosType Field
    /// </summary>/
    public sealed class PosType : StringField
    {
        public const int TAG = 703;

        public PosType()
            :base(Tags.PosType) {}
        public PosType(string val)
            :base(Tags.PosType, val) {}


        // Field Enumerations
        public const string ALLOCATION_TRADE_QTY = "ALC";
        public const string OPTION_ASSIGNMENT = "AS";
        public const string AS_OF_TRADE_QTY = "ASF";
        public const string DELIVERY_QTY = "DLV";
        public const string ELECTRONIC_TRADE_QTY = "ETR";
        public const string OPTION_EXERCISE_QTY = "EX";
        public const string END_OF_DAY_QTY = "FIN";
        public const string INTRA_SPREAD_QTY = "IAS";
        public const string INTER_SPREAD_QTY = "IES";
        public const string ADJUSTMENT_QTY = "PA";
        public const string PIT_TRADE_QTY = "PIT";
        public const string START_OF_DAY_QTY = "SOD";
        public const string INTEGRAL_SPLIT = "SPL";
        public const string TRANSACTION_FROM_ASSIGNMENT = "TA";
        public const string TOTAL_TRANSACTION_QTY = "TOT";
        public const string TRANSACTION_QUANTITY = "TQ";
        public const string TRANSFER_TRADE_QTY = "TRF";
        public const string TRANSACTION_FROM_EXERCISE = "TX";
        public const string CROSS_MARGIN_QTY = "XM";
        public const string RECEIVE_QUANTITY = "RCV";
        public const string CORPORATE_ACTION_ADJUSTMENT = "CAA";
        public const string DELIVERY_NOTICE_QTY = "DN";
        public const string EXCHANGE_FOR_PHYSICAL_QTY = "EP";
        public const string PRIVATELY_NEGOTIATED_TRADE_QTY = "PNTN";
        public const string NET_DELTA_QTY = "DLT";
        public const string CREDIT_EVENT_ADJUSTMENT = "CEA";
        public const string SUCCESSION_EVENT_ADJUSTMENT = "SEA";
    }


    /// <summary>
    /// LongQty Field
    /// </summary>/
    public sealed class LongQty : DecimalField
    {
        public const int TAG = 704;

        public LongQty()
            :base(Tags.LongQty) {}
        public LongQty(Decimal val)
            :base(Tags.LongQty, val) {}

    }


    /// <summary>
    /// ShortQty Field
    /// </summary>/
    public sealed class ShortQty : DecimalField
    {
        public const int TAG = 705;

        public ShortQty()
            :base(Tags.ShortQty) {}
        public ShortQty(Decimal val)
            :base(Tags.ShortQty, val) {}

    }


    /// <summary>
    /// PosQtyStatus Field
    /// </summary>/
    public sealed class PosQtyStatus : IntField
    {
        public const int TAG = 706;

        public PosQtyStatus()
            :base(Tags.PosQtyStatus) {}
        public PosQtyStatus(int val)
            :base(Tags.PosQtyStatus, val) {}


        // Field Enumerations
        public const int SUBMITTED = 0;
        public const int ACCEPTED = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// PosAmtType Field
    /// </summary>/
    public sealed class PosAmtType : StringField
    {
        public const int TAG = 707;

        public PosAmtType()
            :base(Tags.PosAmtType) {}
        public PosAmtType(string val)
            :base(Tags.PosAmtType, val) {}


        // Field Enumerations
        public const string CASH_AMOUNT = "CASH";
        public const string CASH_RESIDUAL_AMOUNT = "CRES";
        public const string FINAL_MARK_TO_MARKET_AMOUNT = "FMTM";
        public const string INCREMENTAL_MARK_TO_MARKET_AMOUNT = "IMTM";
        public const string PREMIUM_AMOUNT = "PREM";
        public const string START_OF_DAY_MARK_TO_MARKET_AMOUNT = "SMTM";
        public const string TRADE_VARIATION_AMOUNT = "TVAR";
        public const string VALUE_ADJUSTED_AMOUNT = "VADJ";
        public const string SETTLEMENT_VALUE = "SETL";
        public const string INITIAL_TRADE_COUPON_AMOUNT = "ICPN";
        public const string ACCRUED_COUPON_AMOUNT = "ACPN";
        public const string COUPON_AMOUNT = "CPN";
        public const string INCREMENTAL_ACCRUED_COUPON = "IACPN";
        public const string COLLATERALIZED_MARK_TO_MARKET = "CMTM";
        public const string INCREMENTAL_COLLATERALIZED_MARK_TO_MARKET = "ICMTM";
        public const string COMPENSATION_AMOUNT = "DLV";
        public const string TOTAL_BANKED_AMOUNT = "BANK";
        public const string TOTAL_COLLATERALIZED_AMOUNT = "COLAT";
    }


    /// <summary>
    /// PosAmt Field
    /// </summary>/
    public sealed class PosAmt : DecimalField
    {
        public const int TAG = 708;

        public PosAmt()
            :base(Tags.PosAmt) {}
        public PosAmt(Decimal val)
            :base(Tags.PosAmt, val) {}

    }


    /// <summary>
    /// PosTransType Field
    /// </summary>/
    public sealed class PosTransType : IntField
    {
        public const int TAG = 709;

        public PosTransType()
            :base(Tags.PosTransType) {}
        public PosTransType(int val)
            :base(Tags.PosTransType, val) {}


        // Field Enumerations
        public const int EXERCISE = 1;
        public const int DO_NOT_EXERCISE = 2;
        public const int POSITION_ADJUSTMENT = 3;
        public const int POSITION_CHANGE_SUBMISSION_MARGIN_DISPOSITION = 4;
        public const int PLEDGE = 5;
        public const int LARGE_TRADER_SUBMISSION = 6;
    }


    /// <summary>
    /// PosReqID Field
    /// </summary>/
    public sealed class PosReqID : StringField
    {
        public const int TAG = 710;

        public PosReqID()
            :base(Tags.PosReqID) {}
        public PosReqID(string val)
            :base(Tags.PosReqID, val) {}

    }


    /// <summary>
    /// NoUnderlyings Field
    /// </summary>/
    public sealed class NoUnderlyings : IntField
    {
        public const int TAG = 711;

        public NoUnderlyings()
            :base(Tags.NoUnderlyings) {}
        public NoUnderlyings(int val)
            :base(Tags.NoUnderlyings, val) {}

    }


    /// <summary>
    /// PosMaintAction Field
    /// </summary>/
    public sealed class PosMaintAction : IntField
    {
        public const int TAG = 712;

        public PosMaintAction()
            :base(Tags.PosMaintAction) {}
        public PosMaintAction(int val)
            :base(Tags.PosMaintAction, val) {}


        // Field Enumerations
        public const int NEW = 1;
        public const int REPLACE = 2;
        public const int CANCEL = 3;
        public const int REVERSE = 4;
    }


    /// <summary>
    /// OrigPosReqRefID Field
    /// </summary>/
    public sealed class OrigPosReqRefID : StringField
    {
        public const int TAG = 713;

        public OrigPosReqRefID()
            :base(Tags.OrigPosReqRefID) {}
        public OrigPosReqRefID(string val)
            :base(Tags.OrigPosReqRefID, val) {}

    }


    /// <summary>
    /// PosMaintRptRefID Field
    /// </summary>/
    public sealed class PosMaintRptRefID : StringField
    {
        public const int TAG = 714;

        public PosMaintRptRefID()
            :base(Tags.PosMaintRptRefID) {}
        public PosMaintRptRefID(string val)
            :base(Tags.PosMaintRptRefID, val) {}

    }


    /// <summary>
    /// ClearingBusinessDate Field
    /// </summary>/
    public sealed class ClearingBusinessDate : StringField
    {
        public const int TAG = 715;

        public ClearingBusinessDate()
            :base(Tags.ClearingBusinessDate) {}
        public ClearingBusinessDate(string val)
            :base(Tags.ClearingBusinessDate, val) {}

    }


    /// <summary>
    /// SettlSessID Field
    /// </summary>/
    public sealed class SettlSessID : StringField
    {
        public const int TAG = 716;

        public SettlSessID()
            :base(Tags.SettlSessID) {}
        public SettlSessID(string val)
            :base(Tags.SettlSessID, val) {}


        // Field Enumerations
        public const string INTRADAY = "ITD";
        public const string REGULAR_TRADING_HOURS = "RTH";
        public const string ELECTRONIC_TRADING_HOURS = "ETH";
        public const string END_OF_DAY = "EOD";
    }


    /// <summary>
    /// SettlSessSubID Field
    /// </summary>/
    public sealed class SettlSessSubID : StringField
    {
        public const int TAG = 717;

        public SettlSessSubID()
            :base(Tags.SettlSessSubID) {}
        public SettlSessSubID(string val)
            :base(Tags.SettlSessSubID, val) {}

    }


    /// <summary>
    /// AdjustmentType Field
    /// </summary>/
    public sealed class AdjustmentType : IntField
    {
        public const int TAG = 718;

        public AdjustmentType()
            :base(Tags.AdjustmentType) {}
        public AdjustmentType(int val)
            :base(Tags.AdjustmentType, val) {}


        // Field Enumerations
        public const int PROCESS_REQUEST_AS_MARGIN_DISPOSITION = 0;
        public const int DELTA_PLUS = 1;
        public const int DELTA_MINUS = 2;
        public const int FINAL = 3;
    }


    /// <summary>
    /// ContraryInstructionIndicator Field
    /// </summary>/
    public sealed class ContraryInstructionIndicator : BooleanField
    {
        public const int TAG = 719;

        public ContraryInstructionIndicator()
            :base(Tags.ContraryInstructionIndicator) {}
        public ContraryInstructionIndicator(Boolean val)
            :base(Tags.ContraryInstructionIndicator, val) {}

    }


    /// <summary>
    /// PriorSpreadIndicator Field
    /// </summary>/
    public sealed class PriorSpreadIndicator : BooleanField
    {
        public const int TAG = 720;

        public PriorSpreadIndicator()
            :base(Tags.PriorSpreadIndicator) {}
        public PriorSpreadIndicator(Boolean val)
            :base(Tags.PriorSpreadIndicator, val) {}

    }


    /// <summary>
    /// PosMaintRptID Field
    /// </summary>/
    public sealed class PosMaintRptID : StringField
    {
        public const int TAG = 721;

        public PosMaintRptID()
            :base(Tags.PosMaintRptID) {}
        public PosMaintRptID(string val)
            :base(Tags.PosMaintRptID, val) {}

    }


    /// <summary>
    /// PosMaintStatus Field
    /// </summary>/
    public sealed class PosMaintStatus : IntField
    {
        public const int TAG = 722;

        public PosMaintStatus()
            :base(Tags.PosMaintStatus) {}
        public PosMaintStatus(int val)
            :base(Tags.PosMaintStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int ACCEPTED_WITH_WARNINGS = 1;
        public const int REJECTED = 2;
        public const int COMPLETED = 3;
        public const int COMPLETED_WITH_WARNINGS = 4;
    }


    /// <summary>
    /// PosMaintResult Field
    /// </summary>/
    public sealed class PosMaintResult : IntField
    {
        public const int TAG = 723;

        public PosMaintResult()
            :base(Tags.PosMaintResult) {}
        public PosMaintResult(int val)
            :base(Tags.PosMaintResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL_COMPLETION = 0;
        public const int REJECTED = 1;
        public const int OTHER = 99;
        public const int SUCCESSFUL_COMPLETION_NO_WARNINGS_OR_ERRORS = 0;
    }


    /// <summary>
    /// PosReqType Field
    /// </summary>/
    public sealed class PosReqType : IntField
    {
        public const int TAG = 724;

        public PosReqType()
            :base(Tags.PosReqType) {}
        public PosReqType(int val)
            :base(Tags.PosReqType, val) {}


        // Field Enumerations
        public const int POSITIONS = 0;
        public const int TRADES = 1;
        public const int EXERCISES = 2;
        public const int ASSIGNMENTS = 3;
        public const int SETTLEMENT_ACTIVITY = 4;
        public const int BACKOUT_MESSAGE = 5;
        public const int DELTA_POSITIONS = 6;
    }


    /// <summary>
    /// ResponseTransportType Field
    /// </summary>/
    public sealed class ResponseTransportType : IntField
    {
        public const int TAG = 725;

        public ResponseTransportType()
            :base(Tags.ResponseTransportType) {}
        public ResponseTransportType(int val)
            :base(Tags.ResponseTransportType, val) {}


        // Field Enumerations
        public const int INBAND = 0;
        public const int OUT_OF_BAND = 1;
    }


    /// <summary>
    /// ResponseDestination Field
    /// </summary>/
    public sealed class ResponseDestination : StringField
    {
        public const int TAG = 726;

        public ResponseDestination()
            :base(Tags.ResponseDestination) {}
        public ResponseDestination(string val)
            :base(Tags.ResponseDestination, val) {}

    }


    /// <summary>
    /// TotalNumPosReports Field
    /// </summary>/
    public sealed class TotalNumPosReports : IntField
    {
        public const int TAG = 727;

        public TotalNumPosReports()
            :base(Tags.TotalNumPosReports) {}
        public TotalNumPosReports(int val)
            :base(Tags.TotalNumPosReports, val) {}

    }


    /// <summary>
    /// PosReqResult Field
    /// </summary>/
    public sealed class PosReqResult : IntField
    {
        public const int TAG = 728;

        public PosReqResult()
            :base(Tags.PosReqResult) {}
        public PosReqResult(int val)
            :base(Tags.PosReqResult, val) {}


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_POSITIONS_FOUND_THAT_MATCH_CRITERIA = 2;
        public const int NOT_AUTHORIZED_TO_REQUEST_POSITIONS = 3;
        public const int REQUEST_FOR_POSITION_NOT_SUPPORTED = 4;
        public const int OTHER = 99;
    }


    /// <summary>
    /// PosReqStatus Field
    /// </summary>/
    public sealed class PosReqStatus : IntField
    {
        public const int TAG = 729;

        public PosReqStatus()
            :base(Tags.PosReqStatus) {}
        public PosReqStatus(int val)
            :base(Tags.PosReqStatus, val) {}


        // Field Enumerations
        public const int COMPLETED = 0;
        public const int COMPLETED_WITH_WARNINGS = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// SettlPrice Field
    /// </summary>/
    public sealed class SettlPrice : DecimalField
    {
        public const int TAG = 730;

        public SettlPrice()
            :base(Tags.SettlPrice) {}
        public SettlPrice(Decimal val)
            :base(Tags.SettlPrice, val) {}

    }


    /// <summary>
    /// SettlPriceType Field
    /// </summary>/
    public sealed class SettlPriceType : IntField
    {
        public const int TAG = 731;

        public SettlPriceType()
            :base(Tags.SettlPriceType) {}
        public SettlPriceType(int val)
            :base(Tags.SettlPriceType, val) {}


        // Field Enumerations
        public const int FINAL = 1;
        public const int THEORETICAL = 2;
    }


    /// <summary>
    /// UnderlyingSettlPrice Field
    /// </summary>/
    public sealed class UnderlyingSettlPrice : DecimalField
    {
        public const int TAG = 732;

        public UnderlyingSettlPrice()
            :base(Tags.UnderlyingSettlPrice) {}
        public UnderlyingSettlPrice(Decimal val)
            :base(Tags.UnderlyingSettlPrice, val) {}

    }


    /// <summary>
    /// UnderlyingSettlPriceType Field
    /// </summary>/
    public sealed class UnderlyingSettlPriceType : IntField
    {
        public const int TAG = 733;

        public UnderlyingSettlPriceType()
            :base(Tags.UnderlyingSettlPriceType) {}
        public UnderlyingSettlPriceType(int val)
            :base(Tags.UnderlyingSettlPriceType, val) {}

    }


    /// <summary>
    /// PriorSettlPrice Field
    /// </summary>/
    public sealed class PriorSettlPrice : DecimalField
    {
        public const int TAG = 734;

        public PriorSettlPrice()
            :base(Tags.PriorSettlPrice) {}
        public PriorSettlPrice(Decimal val)
            :base(Tags.PriorSettlPrice, val) {}

    }


    /// <summary>
    /// NoQuoteQualifiers Field
    /// </summary>/
    public sealed class NoQuoteQualifiers : IntField
    {
        public const int TAG = 735;

        public NoQuoteQualifiers()
            :base(Tags.NoQuoteQualifiers) {}
        public NoQuoteQualifiers(int val)
            :base(Tags.NoQuoteQualifiers, val) {}

    }


    /// <summary>
    /// AllocSettlCurrency Field
    /// </summary>/
    public sealed class AllocSettlCurrency : StringField
    {
        public const int TAG = 736;

        public AllocSettlCurrency()
            :base(Tags.AllocSettlCurrency) {}
        public AllocSettlCurrency(string val)
            :base(Tags.AllocSettlCurrency, val) {}

    }


    /// <summary>
    /// AllocSettlCurrAmt Field
    /// </summary>/
    public sealed class AllocSettlCurrAmt : DecimalField
    {
        public const int TAG = 737;

        public AllocSettlCurrAmt()
            :base(Tags.AllocSettlCurrAmt) {}
        public AllocSettlCurrAmt(Decimal val)
            :base(Tags.AllocSettlCurrAmt, val) {}

    }


    /// <summary>
    /// InterestAtMaturity Field
    /// </summary>/
    public sealed class InterestAtMaturity : DecimalField
    {
        public const int TAG = 738;

        public InterestAtMaturity()
            :base(Tags.InterestAtMaturity) {}
        public InterestAtMaturity(Decimal val)
            :base(Tags.InterestAtMaturity, val) {}

    }


    /// <summary>
    /// LegDatedDate Field
    /// </summary>/
    public sealed class LegDatedDate : StringField
    {
        public const int TAG = 739;

        public LegDatedDate()
            :base(Tags.LegDatedDate) {}
        public LegDatedDate(string val)
            :base(Tags.LegDatedDate, val) {}

    }


    /// <summary>
    /// LegPool Field
    /// </summary>/
    public sealed class LegPool : StringField
    {
        public const int TAG = 740;

        public LegPool()
            :base(Tags.LegPool) {}
        public LegPool(string val)
            :base(Tags.LegPool, val) {}

    }


    /// <summary>
    /// AllocInterestAtMaturity Field
    /// </summary>/
    public sealed class AllocInterestAtMaturity : DecimalField
    {
        public const int TAG = 741;

        public AllocInterestAtMaturity()
            :base(Tags.AllocInterestAtMaturity) {}
        public AllocInterestAtMaturity(Decimal val)
            :base(Tags.AllocInterestAtMaturity, val) {}

    }


    /// <summary>
    /// AllocAccruedInterestAmt Field
    /// </summary>/
    public sealed class AllocAccruedInterestAmt : DecimalField
    {
        public const int TAG = 742;

        public AllocAccruedInterestAmt()
            :base(Tags.AllocAccruedInterestAmt) {}
        public AllocAccruedInterestAmt(Decimal val)
            :base(Tags.AllocAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// DeliveryDate Field
    /// </summary>/
    public sealed class DeliveryDate : StringField
    {
        public const int TAG = 743;

        public DeliveryDate()
            :base(Tags.DeliveryDate) {}
        public DeliveryDate(string val)
            :base(Tags.DeliveryDate, val) {}

    }


    /// <summary>
    /// AssignmentMethod Field
    /// </summary>/
    public sealed class AssignmentMethod : CharField
    {
        public const int TAG = 744;

        public AssignmentMethod()
            :base(Tags.AssignmentMethod) {}
        public AssignmentMethod(char val)
            :base(Tags.AssignmentMethod, val) {}


        // Field Enumerations
        public const char PRO_RATA = 'P';
        public const char RANDOM = 'R';
        public const char PRORATA = 'P';
    }


    /// <summary>
    /// AssignmentUnit Field
    /// </summary>/
    public sealed class AssignmentUnit : DecimalField
    {
        public const int TAG = 745;

        public AssignmentUnit()
            :base(Tags.AssignmentUnit) {}
        public AssignmentUnit(Decimal val)
            :base(Tags.AssignmentUnit, val) {}

    }


    /// <summary>
    /// OpenInterest Field
    /// </summary>/
    public sealed class OpenInterest : DecimalField
    {
        public const int TAG = 746;

        public OpenInterest()
            :base(Tags.OpenInterest) {}
        public OpenInterest(Decimal val)
            :base(Tags.OpenInterest, val) {}

    }


    /// <summary>
    /// ExerciseMethod Field
    /// </summary>/
    public sealed class ExerciseMethod : CharField
    {
        public const int TAG = 747;

        public ExerciseMethod()
            :base(Tags.ExerciseMethod) {}
        public ExerciseMethod(char val)
            :base(Tags.ExerciseMethod, val) {}


        // Field Enumerations
        public const char AUTOMATIC = 'A';
        public const char MANUAL = 'M';
    }


    /// <summary>
    /// TotNumTradeReports Field
    /// </summary>/
    public sealed class TotNumTradeReports : IntField
    {
        public const int TAG = 748;

        public TotNumTradeReports()
            :base(Tags.TotNumTradeReports) {}
        public TotNumTradeReports(int val)
            :base(Tags.TotNumTradeReports, val) {}

    }


    /// <summary>
    /// TradeRequestResult Field
    /// </summary>/
    public sealed class TradeRequestResult : IntField
    {
        public const int TAG = 749;

        public TradeRequestResult()
            :base(Tags.TradeRequestResult) {}
        public TradeRequestResult(int val)
            :base(Tags.TradeRequestResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_OR_UNKNOWN_INSTRUMENT = 1;
        public const int INVALID_TYPE_OF_TRADE_REQUESTED = 2;
        public const int INVALID_PARTIES = 3;
        public const int INVALID_TRANSPORT_TYPE_REQUESTED = 4;
        public const int INVALID_DESTINATION_REQUESTED = 5;
        public const int TRADEREQUESTTYPE_NOT_SUPPORTED = 8;
        public const int NOT_AUTHORIZED = 9;
        public const int OTHER = 99;
        public const int UNAUTHORIZED_ROR_TRADE_CAPTURE_REPORT_REQUEST = 9;
        public const int UNAUTHORIZED_FOR_TRADE_CAPTURE_REPORT_REQUEST = 9;
        public const int YIELD = 10;
    }


    /// <summary>
    /// TradeRequestStatus Field
    /// </summary>/
    public sealed class TradeRequestStatus : IntField
    {
        public const int TAG = 750;

        public TradeRequestStatus()
            :base(Tags.TradeRequestStatus) {}
        public TradeRequestStatus(int val)
            :base(Tags.TradeRequestStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int COMPLETED = 1;
        public const int REJECTED = 2;
    }


    /// <summary>
    /// TradeReportRejectReason Field
    /// </summary>/
    public sealed class TradeReportRejectReason : IntField
    {
        public const int TAG = 751;

        public TradeReportRejectReason()
            :base(Tags.TradeReportRejectReason) {}
        public TradeReportRejectReason(int val)
            :base(Tags.TradeReportRejectReason, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_PARTY_ONFORMATION = 1;
        public const int UNKNOWN_INSTRUMENT = 2;
        public const int UNAUTHORIZED_TO_REPORT_TRADES = 3;
        public const int INVALID_TRADE_TYPE = 4;
        public const int OTHER = 99;
        public const int INVALID_PARTY_INFORMATION = 1;
        public const int YIELD = 10;
    }


    /// <summary>
    /// SideMultiLegReportingType Field
    /// </summary>/
    public sealed class SideMultiLegReportingType : IntField
    {
        public const int TAG = 752;

        public SideMultiLegReportingType()
            :base(Tags.SideMultiLegReportingType) {}
        public SideMultiLegReportingType(int val)
            :base(Tags.SideMultiLegReportingType, val) {}


        // Field Enumerations
        public const int SINGLE_SECURITY = 1;
        public const int INDIVIDUAL_LEG_OF_A_MULTILEG_SECURITY = 2;
        public const int MULTILEG_SECURITY = 3;
        public const int INDIVIDUAL_LEG_OF_A_MULTI_LEG_SECURITY = 2;
        public const int MULTI_LEG_SECURITY = 3;
    }


    /// <summary>
    /// NoPosAmt Field
    /// </summary>/
    public sealed class NoPosAmt : IntField
    {
        public const int TAG = 753;

        public NoPosAmt()
            :base(Tags.NoPosAmt) {}
        public NoPosAmt(int val)
            :base(Tags.NoPosAmt, val) {}

    }


    /// <summary>
    /// AutoAcceptIndicator Field
    /// </summary>/
    public sealed class AutoAcceptIndicator : BooleanField
    {
        public const int TAG = 754;

        public AutoAcceptIndicator()
            :base(Tags.AutoAcceptIndicator) {}
        public AutoAcceptIndicator(Boolean val)
            :base(Tags.AutoAcceptIndicator, val) {}

    }


    /// <summary>
    /// AllocReportID Field
    /// </summary>/
    public sealed class AllocReportID : StringField
    {
        public const int TAG = 755;

        public AllocReportID()
            :base(Tags.AllocReportID) {}
        public AllocReportID(string val)
            :base(Tags.AllocReportID, val) {}

    }


    /// <summary>
    /// NoNested2PartyIDs Field
    /// </summary>/
    public sealed class NoNested2PartyIDs : IntField
    {
        public const int TAG = 756;

        public NoNested2PartyIDs()
            :base(Tags.NoNested2PartyIDs) {}
        public NoNested2PartyIDs(int val)
            :base(Tags.NoNested2PartyIDs, val) {}

    }


    /// <summary>
    /// Nested2PartyID Field
    /// </summary>/
    public sealed class Nested2PartyID : StringField
    {
        public const int TAG = 757;

        public Nested2PartyID()
            :base(Tags.Nested2PartyID) {}
        public Nested2PartyID(string val)
            :base(Tags.Nested2PartyID, val) {}

    }


    /// <summary>
    /// Nested2PartyIDSource Field
    /// </summary>/
    public sealed class Nested2PartyIDSource : CharField
    {
        public const int TAG = 758;

        public Nested2PartyIDSource()
            :base(Tags.Nested2PartyIDSource) {}
        public Nested2PartyIDSource(char val)
            :base(Tags.Nested2PartyIDSource, val) {}

    }


    /// <summary>
    /// Nested2PartyRole Field
    /// </summary>/
    public sealed class Nested2PartyRole : IntField
    {
        public const int TAG = 759;

        public Nested2PartyRole()
            :base(Tags.Nested2PartyRole) {}
        public Nested2PartyRole(int val)
            :base(Tags.Nested2PartyRole, val) {}

    }


    /// <summary>
    /// Nested2PartySubID Field
    /// </summary>/
    public sealed class Nested2PartySubID : StringField
    {
        public const int TAG = 760;

        public Nested2PartySubID()
            :base(Tags.Nested2PartySubID) {}
        public Nested2PartySubID(string val)
            :base(Tags.Nested2PartySubID, val) {}

    }


    /// <summary>
    /// BenchmarkSecurityIDSource Field
    /// </summary>/
    public sealed class BenchmarkSecurityIDSource : StringField
    {
        public const int TAG = 761;

        public BenchmarkSecurityIDSource()
            :base(Tags.BenchmarkSecurityIDSource) {}
        public BenchmarkSecurityIDSource(string val)
            :base(Tags.BenchmarkSecurityIDSource, val) {}

    }


    /// <summary>
    /// SecuritySubType Field
    /// </summary>/
    public sealed class SecuritySubType : StringField
    {
        public const int TAG = 762;

        public SecuritySubType()
            :base(Tags.SecuritySubType) {}
        public SecuritySubType(string val)
            :base(Tags.SecuritySubType, val) {}

    }


    /// <summary>
    /// UnderlyingSecuritySubType Field
    /// </summary>/
    public sealed class UnderlyingSecuritySubType : StringField
    {
        public const int TAG = 763;

        public UnderlyingSecuritySubType()
            :base(Tags.UnderlyingSecuritySubType) {}
        public UnderlyingSecuritySubType(string val)
            :base(Tags.UnderlyingSecuritySubType, val) {}

    }


    /// <summary>
    /// LegSecuritySubType Field
    /// </summary>/
    public sealed class LegSecuritySubType : StringField
    {
        public const int TAG = 764;

        public LegSecuritySubType()
            :base(Tags.LegSecuritySubType) {}
        public LegSecuritySubType(string val)
            :base(Tags.LegSecuritySubType, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessPct Field
    /// </summary>/
    public sealed class AllowableOneSidednessPct : DecimalField
    {
        public const int TAG = 765;

        public AllowableOneSidednessPct()
            :base(Tags.AllowableOneSidednessPct) {}
        public AllowableOneSidednessPct(Decimal val)
            :base(Tags.AllowableOneSidednessPct, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessValue Field
    /// </summary>/
    public sealed class AllowableOneSidednessValue : DecimalField
    {
        public const int TAG = 766;

        public AllowableOneSidednessValue()
            :base(Tags.AllowableOneSidednessValue) {}
        public AllowableOneSidednessValue(Decimal val)
            :base(Tags.AllowableOneSidednessValue, val) {}

    }


    /// <summary>
    /// AllowableOneSidednessCurr Field
    /// </summary>/
    public sealed class AllowableOneSidednessCurr : StringField
    {
        public const int TAG = 767;

        public AllowableOneSidednessCurr()
            :base(Tags.AllowableOneSidednessCurr) {}
        public AllowableOneSidednessCurr(string val)
            :base(Tags.AllowableOneSidednessCurr, val) {}

    }


    /// <summary>
    /// NoTrdRegTimestamps Field
    /// </summary>/
    public sealed class NoTrdRegTimestamps : IntField
    {
        public const int TAG = 768;

        public NoTrdRegTimestamps()
            :base(Tags.NoTrdRegTimestamps) {}
        public NoTrdRegTimestamps(int val)
            :base(Tags.NoTrdRegTimestamps, val) {}

    }


    /// <summary>
    /// TrdRegTimestamp Field
    /// </summary>/
    public sealed class TrdRegTimestamp : DateTimeField
    {
        public const int TAG = 769;

        public TrdRegTimestamp()
            :base(Tags.TrdRegTimestamp) {}
        public TrdRegTimestamp(DateTime val)
            :base(Tags.TrdRegTimestamp, val) {}
        public TrdRegTimestamp(DateTime val, bool showMilliseconds)
            :base(Tags.TrdRegTimestamp, val, showMilliseconds) {}
		public TrdRegTimestamp(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TrdRegTimestamp, val, precision) {}

    }


    /// <summary>
    /// TrdRegTimestampType Field
    /// </summary>/
    public sealed class TrdRegTimestampType : IntField
    {
        public const int TAG = 770;

        public TrdRegTimestampType()
            :base(Tags.TrdRegTimestampType) {}
        public TrdRegTimestampType(int val)
            :base(Tags.TrdRegTimestampType, val) {}


        // Field Enumerations
        public const int EXECUTION_TIME = 1;
        public const int TIME_IN = 2;
        public const int TIME_OUT = 3;
        public const int BROKER_RECEIPT = 4;
        public const int BROKER_EXECUTION = 5;
        public const int DESK_RECEIPT = 6;
        public const int SUBMISSION_TO_CLEARING = 7;
    }


    /// <summary>
    /// TrdRegTimestampOrigin Field
    /// </summary>/
    public sealed class TrdRegTimestampOrigin : StringField
    {
        public const int TAG = 771;

        public TrdRegTimestampOrigin()
            :base(Tags.TrdRegTimestampOrigin) {}
        public TrdRegTimestampOrigin(string val)
            :base(Tags.TrdRegTimestampOrigin, val) {}

    }


    /// <summary>
    /// ConfirmRefID Field
    /// </summary>/
    public sealed class ConfirmRefID : StringField
    {
        public const int TAG = 772;

        public ConfirmRefID()
            :base(Tags.ConfirmRefID) {}
        public ConfirmRefID(string val)
            :base(Tags.ConfirmRefID, val) {}

    }


    /// <summary>
    /// ConfirmType Field
    /// </summary>/
    public sealed class ConfirmType : IntField
    {
        public const int TAG = 773;

        public ConfirmType()
            :base(Tags.ConfirmType) {}
        public ConfirmType(int val)
            :base(Tags.ConfirmType, val) {}


        // Field Enumerations
        public const int STATUS = 1;
        public const int CONFIRMATION = 2;
        public const int CONFIRMATION_REQUEST_REJECTED = 3;
    }


    /// <summary>
    /// ConfirmRejReason Field
    /// </summary>/
    public sealed class ConfirmRejReason : IntField
    {
        public const int TAG = 774;

        public ConfirmRejReason()
            :base(Tags.ConfirmRejReason) {}
        public ConfirmRejReason(int val)
            :base(Tags.ConfirmRejReason, val) {}


        // Field Enumerations
        public const int MISMATCHED_ACCOUNT = 1;
        public const int MISSING_SETTLEMENT_INSTRUCTIONS = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// BookingType Field
    /// </summary>/
    public sealed class BookingType : IntField
    {
        public const int TAG = 775;

        public BookingType()
            :base(Tags.BookingType) {}
        public BookingType(int val)
            :base(Tags.BookingType, val) {}


        // Field Enumerations
        public const int REGULAR_BOOKING = 0;
        public const int CFD = 1;
        public const int TOTAL_RETURN_SWAP = 2;
    }


    /// <summary>
    /// IndividualAllocRejCode Field
    /// </summary>/
    public sealed class IndividualAllocRejCode : IntField
    {
        public const int TAG = 776;

        public IndividualAllocRejCode()
            :base(Tags.IndividualAllocRejCode) {}
        public IndividualAllocRejCode(int val)
            :base(Tags.IndividualAllocRejCode, val) {}

    }


    /// <summary>
    /// SettlInstMsgID Field
    /// </summary>/
    public sealed class SettlInstMsgID : StringField
    {
        public const int TAG = 777;

        public SettlInstMsgID()
            :base(Tags.SettlInstMsgID) {}
        public SettlInstMsgID(string val)
            :base(Tags.SettlInstMsgID, val) {}

    }


    /// <summary>
    /// NoSettlInst Field
    /// </summary>/
    public sealed class NoSettlInst : IntField
    {
        public const int TAG = 778;

        public NoSettlInst()
            :base(Tags.NoSettlInst) {}
        public NoSettlInst(int val)
            :base(Tags.NoSettlInst, val) {}

    }


    /// <summary>
    /// LastUpdateTime Field
    /// </summary>/
    public sealed class LastUpdateTime : DateTimeField
    {
        public const int TAG = 779;

        public LastUpdateTime()
            :base(Tags.LastUpdateTime) {}
        public LastUpdateTime(DateTime val)
            :base(Tags.LastUpdateTime, val) {}
        public LastUpdateTime(DateTime val, bool showMilliseconds)
            :base(Tags.LastUpdateTime, val, showMilliseconds) {}
		public LastUpdateTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.LastUpdateTime, val, precision) {}

    }


    /// <summary>
    /// AllocSettlInstType Field
    /// </summary>/
    public sealed class AllocSettlInstType : IntField
    {
        public const int TAG = 780;

        public AllocSettlInstType()
            :base(Tags.AllocSettlInstType) {}
        public AllocSettlInstType(int val)
            :base(Tags.AllocSettlInstType, val) {}


        // Field Enumerations
        public const int USE_DEFAULT_INSTRUCTIONS = 0;
        public const int DERIVE_FROM_PARAMETERS_PROVIDED = 1;
        public const int FULL_DETAILS_PROVIDED = 2;
        public const int SSI_DB_IDS_PROVIDED = 3;
        public const int PHONE_FOR_INSTRUCTIONS = 4;
    }


    /// <summary>
    /// NoSettlPartyIDs Field
    /// </summary>/
    public sealed class NoSettlPartyIDs : IntField
    {
        public const int TAG = 781;

        public NoSettlPartyIDs()
            :base(Tags.NoSettlPartyIDs) {}
        public NoSettlPartyIDs(int val)
            :base(Tags.NoSettlPartyIDs, val) {}

    }


    /// <summary>
    /// SettlPartyID Field
    /// </summary>/
    public sealed class SettlPartyID : StringField
    {
        public const int TAG = 782;

        public SettlPartyID()
            :base(Tags.SettlPartyID) {}
        public SettlPartyID(string val)
            :base(Tags.SettlPartyID, val) {}

    }


    /// <summary>
    /// SettlPartyIDSource Field
    /// </summary>/
    public sealed class SettlPartyIDSource : CharField
    {
        public const int TAG = 783;

        public SettlPartyIDSource()
            :base(Tags.SettlPartyIDSource) {}
        public SettlPartyIDSource(char val)
            :base(Tags.SettlPartyIDSource, val) {}

    }


    /// <summary>
    /// SettlPartyRole Field
    /// </summary>/
    public sealed class SettlPartyRole : IntField
    {
        public const int TAG = 784;

        public SettlPartyRole()
            :base(Tags.SettlPartyRole) {}
        public SettlPartyRole(int val)
            :base(Tags.SettlPartyRole, val) {}

    }


    /// <summary>
    /// SettlPartySubID Field
    /// </summary>/
    public sealed class SettlPartySubID : StringField
    {
        public const int TAG = 785;

        public SettlPartySubID()
            :base(Tags.SettlPartySubID) {}
        public SettlPartySubID(string val)
            :base(Tags.SettlPartySubID, val) {}

    }


    /// <summary>
    /// SettlPartySubIDType Field
    /// </summary>/
    public sealed class SettlPartySubIDType : IntField
    {
        public const int TAG = 786;

        public SettlPartySubIDType()
            :base(Tags.SettlPartySubIDType) {}
        public SettlPartySubIDType(int val)
            :base(Tags.SettlPartySubIDType, val) {}

    }


    /// <summary>
    /// DlvyInstType Field
    /// </summary>/
    public sealed class DlvyInstType : CharField
    {
        public const int TAG = 787;

        public DlvyInstType()
            :base(Tags.DlvyInstType) {}
        public DlvyInstType(char val)
            :base(Tags.DlvyInstType, val) {}


        // Field Enumerations
        public const char CASH = 'C';
        public const char SECURITIES = 'S';
    }


    /// <summary>
    /// TerminationType Field
    /// </summary>/
    public sealed class TerminationType : IntField
    {
        public const int TAG = 788;

        public TerminationType()
            :base(Tags.TerminationType) {}
        public TerminationType(int val)
            :base(Tags.TerminationType, val) {}


        // Field Enumerations
        public const int OVERNIGHT = 1;
        public const int TERM = 2;
        public const int FLEXIBLE = 3;
        public const int OPEN = 4;
    }


    /// <summary>
    /// NextExpectedMsgSeqNum Field
    /// </summary>/
    public sealed class NextExpectedMsgSeqNum : IntField
    {
        public const int TAG = 789;

        public NextExpectedMsgSeqNum()
            :base(Tags.NextExpectedMsgSeqNum) {}
        public NextExpectedMsgSeqNum(int val)
            :base(Tags.NextExpectedMsgSeqNum, val) {}

    }


    /// <summary>
    /// OrdStatusReqID Field
    /// </summary>/
    public sealed class OrdStatusReqID : StringField
    {
        public const int TAG = 790;

        public OrdStatusReqID()
            :base(Tags.OrdStatusReqID) {}
        public OrdStatusReqID(string val)
            :base(Tags.OrdStatusReqID, val) {}

    }


    /// <summary>
    /// SettlInstReqID Field
    /// </summary>/
    public sealed class SettlInstReqID : StringField
    {
        public const int TAG = 791;

        public SettlInstReqID()
            :base(Tags.SettlInstReqID) {}
        public SettlInstReqID(string val)
            :base(Tags.SettlInstReqID, val) {}

    }


    /// <summary>
    /// SettlInstReqRejCode Field
    /// </summary>/
    public sealed class SettlInstReqRejCode : IntField
    {
        public const int TAG = 792;

        public SettlInstReqRejCode()
            :base(Tags.SettlInstReqRejCode) {}
        public SettlInstReqRejCode(int val)
            :base(Tags.SettlInstReqRejCode, val) {}


        // Field Enumerations
        public const int UNABLE_TO_PROCESS_REQUEST = 0;
        public const int UNKNOWN_ACCOUNT = 1;
        public const int NO_MATCHING_SETTLEMENT_INSTRUCTIONS_FOUND = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// SecondaryAllocID Field
    /// </summary>/
    public sealed class SecondaryAllocID : StringField
    {
        public const int TAG = 793;

        public SecondaryAllocID()
            :base(Tags.SecondaryAllocID) {}
        public SecondaryAllocID(string val)
            :base(Tags.SecondaryAllocID, val) {}

    }


    /// <summary>
    /// AllocReportType Field
    /// </summary>/
    public sealed class AllocReportType : IntField
    {
        public const int TAG = 794;

        public AllocReportType()
            :base(Tags.AllocReportType) {}
        public AllocReportType(int val)
            :base(Tags.AllocReportType, val) {}


        // Field Enumerations
        public const int SELLSIDE_CALCULATED_USING_PRELIMINARY = 3;
        public const int SELLSIDE_CALCULATED_WITHOUT_PRELIMINARY = 4;
        public const int WAREHOUSE_RECAP = 5;
        public const int REQUEST_TO_INTERMEDIARY = 8;
        public const int PRELIMINARY_REQUEST_TO_INTERMEDIARY = 2;
        public const int ACCEPT = 9;
        public const int REJECT = 10;
        public const int ACCEPT_PENDING = 11;
        public const int COMPLETE = 12;
        public const int REVERSE_PENDING = 14;
    }


    /// <summary>
    /// AllocReportRefID Field
    /// </summary>/
    public sealed class AllocReportRefID : StringField
    {
        public const int TAG = 795;

        public AllocReportRefID()
            :base(Tags.AllocReportRefID) {}
        public AllocReportRefID(string val)
            :base(Tags.AllocReportRefID, val) {}

    }


    /// <summary>
    /// AllocCancReplaceReason Field
    /// </summary>/
    public sealed class AllocCancReplaceReason : IntField
    {
        public const int TAG = 796;

        public AllocCancReplaceReason()
            :base(Tags.AllocCancReplaceReason) {}
        public AllocCancReplaceReason(int val)
            :base(Tags.AllocCancReplaceReason, val) {}


        // Field Enumerations
        public const int ORIGINAL_DETAILS_INCOMPLETE_INCORRECT = 1;
        public const int CHANGE_IN_UNDERLYING_ORDER_DETAILS = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CopyMsgIndicator Field
    /// </summary>/
    public sealed class CopyMsgIndicator : BooleanField
    {
        public const int TAG = 797;

        public CopyMsgIndicator()
            :base(Tags.CopyMsgIndicator) {}
        public CopyMsgIndicator(Boolean val)
            :base(Tags.CopyMsgIndicator, val) {}

    }


    /// <summary>
    /// AllocAccountType Field
    /// </summary>/
    public sealed class AllocAccountType : IntField
    {
        public const int TAG = 798;

        public AllocAccountType()
            :base(Tags.AllocAccountType) {}
        public AllocAccountType(int val)
            :base(Tags.AllocAccountType, val) {}


        // Field Enumerations
        public const int ACCOUNT_IS_CARRIED_PN_CUSTOMER_SIDE_OF_BOOKS = 1;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS = 2;
        public const int HOUSE_TRADER = 3;
        public const int FLOOR_TRADER = 4;
        public const int ACCOUNT_IS_CARRIED_ON_NON_CUSTOMER_SIDE_OF_BOOKS_AND_IS_CROSS_MARGINED = 6;
        public const int ACCOUNT_IS_HOUSE_TRADER_AND_IS_CROSS_MARGINED = 7;
        public const int JOINT_BACK_OFFICE_ACCOUNT = 8;
        public const int ACCOUNT_IS_CARRIED_ON_CUSTOMER_SIDE_OF_BOOKS = 1;
        public const int JOINT_BACKOFFICE_ACCOUNT = 8;
    }


    /// <summary>
    /// OrderAvgPx Field
    /// </summary>/
    public sealed class OrderAvgPx : DecimalField
    {
        public const int TAG = 799;

        public OrderAvgPx()
            :base(Tags.OrderAvgPx) {}
        public OrderAvgPx(Decimal val)
            :base(Tags.OrderAvgPx, val) {}

    }


    /// <summary>
    /// OrderBookingQty Field
    /// </summary>/
    public sealed class OrderBookingQty : DecimalField
    {
        public const int TAG = 800;

        public OrderBookingQty()
            :base(Tags.OrderBookingQty) {}
        public OrderBookingQty(Decimal val)
            :base(Tags.OrderBookingQty, val) {}

    }


    /// <summary>
    /// NoSettlPartySubIDs Field
    /// </summary>/
    public sealed class NoSettlPartySubIDs : IntField
    {
        public const int TAG = 801;

        public NoSettlPartySubIDs()
            :base(Tags.NoSettlPartySubIDs) {}
        public NoSettlPartySubIDs(int val)
            :base(Tags.NoSettlPartySubIDs, val) {}

    }


    /// <summary>
    /// NoPartySubIDs Field
    /// </summary>/
    public sealed class NoPartySubIDs : IntField
    {
        public const int TAG = 802;

        public NoPartySubIDs()
            :base(Tags.NoPartySubIDs) {}
        public NoPartySubIDs(int val)
            :base(Tags.NoPartySubIDs, val) {}

    }


    /// <summary>
    /// PartySubIDType Field
    /// </summary>/
    public sealed class PartySubIDType : IntField
    {
        public const int TAG = 803;

        public PartySubIDType()
            :base(Tags.PartySubIDType) {}
        public PartySubIDType(int val)
            :base(Tags.PartySubIDType, val) {}


        // Field Enumerations
        public const int FIRM = 1;
        public const int SECURITIES_ACCOUNT_NUMBER = 10;
        public const int REGISTRATION_NUMBER = 11;
        public const int REGISTERED_ADDRESS_12 = 12;
        public const int REGULATORY_STATUS = 13;
        public const int REGISTRATION_NAME = 14;
        public const int CASH_ACCOUNT_NUMBER = 15;
        public const int BIC = 16;
        public const int CSD_PARTICIPANT_MEMBER_CODE = 17;
        public const int REGISTERED_ADDRESS_18 = 18;
        public const int FUND_ACCOUNT_NAME = 19;
        public const int PERSON = 2;
        public const int TELEX_NUMBER = 20;
        public const int FAX_NUMBER = 21;
        public const int SECURITIES_ACCOUNT_NAME = 22;
        public const int CASH_ACCOUNT_NAME = 23;
        public const int DEPARTMENT = 24;
        public const int LOCATION_DESK = 25;
        public const int POSITION_ACCOUNT_TYPE = 26;
        public const int SYSTEM = 3;
        public const int APPLICATION = 4;
        public const int FULL_LEGAL_NAME_OF_FIRM = 5;
        public const int POSTAL_ADDRESS = 6;
        public const int PHONE_NUMBER = 7;
        public const int EMAIL_ADDRESS = 8;
        public const int CONTACT_NAME = 9;
        public const int SECURITY_LOCATE_ID = 27;
        public const int MARKET_MAKER = 28;
        public const int ELIGIBLE_COUNTERPARTY = 29;
        public const int PROFESSIONAL_CLIENT = 30;
        public const int LOCATION = 31;
        public const int EXECUTION_VENUE = 32;
        public const int CURRENCY_DELIVERY_IDENTIFIER = 33;
    }


    /// <summary>
    /// NoNestedPartySubIDs Field
    /// </summary>/
    public sealed class NoNestedPartySubIDs : IntField
    {
        public const int TAG = 804;

        public NoNestedPartySubIDs()
            :base(Tags.NoNestedPartySubIDs) {}
        public NoNestedPartySubIDs(int val)
            :base(Tags.NoNestedPartySubIDs, val) {}

    }


    /// <summary>
    /// NestedPartySubIDType Field
    /// </summary>/
    public sealed class NestedPartySubIDType : IntField
    {
        public const int TAG = 805;

        public NestedPartySubIDType()
            :base(Tags.NestedPartySubIDType) {}
        public NestedPartySubIDType(int val)
            :base(Tags.NestedPartySubIDType, val) {}

    }


    /// <summary>
    /// NoNested2PartySubIDs Field
    /// </summary>/
    public sealed class NoNested2PartySubIDs : IntField
    {
        public const int TAG = 806;

        public NoNested2PartySubIDs()
            :base(Tags.NoNested2PartySubIDs) {}
        public NoNested2PartySubIDs(int val)
            :base(Tags.NoNested2PartySubIDs, val) {}

    }


    /// <summary>
    /// Nested2PartySubIDType Field
    /// </summary>/
    public sealed class Nested2PartySubIDType : IntField
    {
        public const int TAG = 807;

        public Nested2PartySubIDType()
            :base(Tags.Nested2PartySubIDType) {}
        public Nested2PartySubIDType(int val)
            :base(Tags.Nested2PartySubIDType, val) {}

    }


    /// <summary>
    /// AllocIntermedReqType Field
    /// </summary>/
    public sealed class AllocIntermedReqType : IntField
    {
        public const int TAG = 808;

        public AllocIntermedReqType()
            :base(Tags.AllocIntermedReqType) {}
        public AllocIntermedReqType(int val)
            :base(Tags.AllocIntermedReqType, val) {}


        // Field Enumerations
        public const int PENDING_ACCEPT = 1;
        public const int PENDING_RELEASE = 2;
        public const int PENDING_REVERSAL = 3;
        public const int ACCEPT = 4;
        public const int BLOCK_LEVEL_REJECT = 5;
        public const int ACCOUNT_LEVEL_REJECT = 6;
    }


    /// <summary>
    /// UnderlyingPx Field
    /// </summary>/
    public sealed class UnderlyingPx : DecimalField
    {
        public const int TAG = 810;

        public UnderlyingPx()
            :base(Tags.UnderlyingPx) {}
        public UnderlyingPx(Decimal val)
            :base(Tags.UnderlyingPx, val) {}

    }


    /// <summary>
    /// PriceDelta Field
    /// </summary>/
    public sealed class PriceDelta : DecimalField
    {
        public const int TAG = 811;

        public PriceDelta()
            :base(Tags.PriceDelta) {}
        public PriceDelta(Decimal val)
            :base(Tags.PriceDelta, val) {}

    }


    /// <summary>
    /// ApplQueueMax Field
    /// </summary>/
    public sealed class ApplQueueMax : IntField
    {
        public const int TAG = 812;

        public ApplQueueMax()
            :base(Tags.ApplQueueMax) {}
        public ApplQueueMax(int val)
            :base(Tags.ApplQueueMax, val) {}

    }


    /// <summary>
    /// ApplQueueDepth Field
    /// </summary>/
    public sealed class ApplQueueDepth : IntField
    {
        public const int TAG = 813;

        public ApplQueueDepth()
            :base(Tags.ApplQueueDepth) {}
        public ApplQueueDepth(int val)
            :base(Tags.ApplQueueDepth, val) {}

    }


    /// <summary>
    /// ApplQueueResolution Field
    /// </summary>/
    public sealed class ApplQueueResolution : IntField
    {
        public const int TAG = 814;

        public ApplQueueResolution()
            :base(Tags.ApplQueueResolution) {}
        public ApplQueueResolution(int val)
            :base(Tags.ApplQueueResolution, val) {}


        // Field Enumerations
        public const int NO_ACTION_TAKEN = 0;
        public const int QUEUE_FLUSHED = 1;
        public const int OVERLAY_LAST = 2;
        public const int END_SESSION = 3;
    }


    /// <summary>
    /// ApplQueueAction Field
    /// </summary>/
    public sealed class ApplQueueAction : IntField
    {
        public const int TAG = 815;

        public ApplQueueAction()
            :base(Tags.ApplQueueAction) {}
        public ApplQueueAction(int val)
            :base(Tags.ApplQueueAction, val) {}


        // Field Enumerations
        public const int NO_ACTION_TAKEN = 0;
        public const int QUEUE_FLUSHED = 1;
        public const int OVERLAY_LAST = 2;
        public const int END_SESSION = 3;
    }


    /// <summary>
    /// NoAltMDSource Field
    /// </summary>/
    public sealed class NoAltMDSource : IntField
    {
        public const int TAG = 816;

        public NoAltMDSource()
            :base(Tags.NoAltMDSource) {}
        public NoAltMDSource(int val)
            :base(Tags.NoAltMDSource, val) {}

    }


    /// <summary>
    /// AltMDSourceID Field
    /// </summary>/
    public sealed class AltMDSourceID : StringField
    {
        public const int TAG = 817;

        public AltMDSourceID()
            :base(Tags.AltMDSourceID) {}
        public AltMDSourceID(string val)
            :base(Tags.AltMDSourceID, val) {}

    }


    /// <summary>
    /// SecondaryTradeReportID Field
    /// </summary>/
    public sealed class SecondaryTradeReportID : StringField
    {
        public const int TAG = 818;

        public SecondaryTradeReportID()
            :base(Tags.SecondaryTradeReportID) {}
        public SecondaryTradeReportID(string val)
            :base(Tags.SecondaryTradeReportID, val) {}

    }


    /// <summary>
    /// AvgPxIndicator Field
    /// </summary>/
    public sealed class AvgPxIndicator : IntField
    {
        public const int TAG = 819;

        public AvgPxIndicator()
            :base(Tags.AvgPxIndicator) {}
        public AvgPxIndicator(int val)
            :base(Tags.AvgPxIndicator, val) {}


        // Field Enumerations
        public const int NO_AVERAGE_PRICING = 0;
        public const int TRADE_IS_PART_OF_AN_AVERAGE_PRICE_GROUP_IDENTIFIED_BY_THE_TRADELINKID = 1;
        public const int LAST_TRADE_IS_THE_AVERAGE_PRICE_GROUP_IDENTIFIED_BY_THE_TRADELINKID = 2;
        public const int LAST_TRADE_IN_THE_AVERAGE_PRICE_GROUP_IDENTIFIED_BY_THE_TRADELINKID = 2;
    }


    /// <summary>
    /// TradeLinkID Field
    /// </summary>/
    public sealed class TradeLinkID : StringField
    {
        public const int TAG = 820;

        public TradeLinkID()
            :base(Tags.TradeLinkID) {}
        public TradeLinkID(string val)
            :base(Tags.TradeLinkID, val) {}

    }


    /// <summary>
    /// OrderInputDevice Field
    /// </summary>/
    public sealed class OrderInputDevice : StringField
    {
        public const int TAG = 821;

        public OrderInputDevice()
            :base(Tags.OrderInputDevice) {}
        public OrderInputDevice(string val)
            :base(Tags.OrderInputDevice, val) {}

    }


    /// <summary>
    /// UnderlyingTradingSessionID Field
    /// </summary>/
    public sealed class UnderlyingTradingSessionID : StringField
    {
        public const int TAG = 822;

        public UnderlyingTradingSessionID()
            :base(Tags.UnderlyingTradingSessionID) {}
        public UnderlyingTradingSessionID(string val)
            :base(Tags.UnderlyingTradingSessionID, val) {}

    }


    /// <summary>
    /// UnderlyingTradingSessionSubID Field
    /// </summary>/
    public sealed class UnderlyingTradingSessionSubID : StringField
    {
        public const int TAG = 823;

        public UnderlyingTradingSessionSubID()
            :base(Tags.UnderlyingTradingSessionSubID) {}
        public UnderlyingTradingSessionSubID(string val)
            :base(Tags.UnderlyingTradingSessionSubID, val) {}

    }


    /// <summary>
    /// TradeLegRefID Field
    /// </summary>/
    public sealed class TradeLegRefID : StringField
    {
        public const int TAG = 824;

        public TradeLegRefID()
            :base(Tags.TradeLegRefID) {}
        public TradeLegRefID(string val)
            :base(Tags.TradeLegRefID, val) {}

    }


    /// <summary>
    /// ExchangeRule Field
    /// </summary>/
    public sealed class ExchangeRule : StringField
    {
        public const int TAG = 825;

        public ExchangeRule()
            :base(Tags.ExchangeRule) {}
        public ExchangeRule(string val)
            :base(Tags.ExchangeRule, val) {}

    }


    /// <summary>
    /// TradeAllocIndicator Field
    /// </summary>/
    public sealed class TradeAllocIndicator : IntField
    {
        public const int TAG = 826;

        public TradeAllocIndicator()
            :base(Tags.TradeAllocIndicator) {}
        public TradeAllocIndicator(int val)
            :base(Tags.TradeAllocIndicator, val) {}


        // Field Enumerations
        public const int ALLOCATION_NOT_REQUIRED = 0;
        public const int ALLOCATION_REQUIRED = 1;
        public const int USE_ALLOCATION_PROVIDED_WITH_THE_TRADE = 2;
        public const int ALLOCATION_GIVE_UP_EXECUTOR = 3;
        public const int ALLOCATION_FROM_EXECUTOR = 4;
        public const int ALLOCATION_TO_CLAIM_ACCOUNT = 5;
    }


    /// <summary>
    /// ExpirationCycle Field
    /// </summary>/
    public sealed class ExpirationCycle : IntField
    {
        public const int TAG = 827;

        public ExpirationCycle()
            :base(Tags.ExpirationCycle) {}
        public ExpirationCycle(int val)
            :base(Tags.ExpirationCycle, val) {}


        // Field Enumerations
        public const int EXPIRE_ON_TRADING_SESSION_CLOSE = 0;
        public const int EXPIRE_ON_TRADING_SESSION_OPEN = 1;
        public const int TRADING_ELIGIBILITY_EXPIRATION_SPECIFIED_IN_THE_DATE_AND_TIME_FIELDS_EVENTDATE = 2;
    }


    /// <summary>
    /// TrdType Field
    /// </summary>/
    public sealed class TrdType : IntField
    {
        public const int TAG = 828;

        public TrdType()
            :base(Tags.TrdType) {}
        public TrdType(int val)
            :base(Tags.TrdType, val) {}


        // Field Enumerations
        public const int REGULAR_TRADE = 0;
        public const int BLOCK_TRADE_1 = 1;
        public const int AFTER_HOURS_TRADE = 10;
        public const int EFP = 2;
        public const int TRANSFER = 3;
        public const int LATE_TRADE = 4;
        public const int T_TRADE = 5;
        public const int WEIGHTED_AVERAGE_PRICE_TRADE = 6;
        public const int BUNCHED_TRADE = 7;
        public const int LATE_BUNCHED_TRADE = 8;
        public const int PRIOR_REFERENCE_PRICE_TRADE = 9;
        public const int EXCHANGE_FOR_RISK = 11;
        public const int EXCHANGE_FOR_SWAP = 12;
        public const int EXCHANGE_OF_FUTURES_FOR = 13;
        public const int EXCHANGE_OF_OPTIONS_FOR_OPTIONS = 14;
        public const int TRADING_AT_SETTLEMENT = 15;
        public const int ALL_OR_NONE = 16;
        public const int FUTURES_LARGE_ORDER_EXECUTION = 17;
        public const int EXCHANGE_OF_FUTURES_FOR_FUTURES = 18;
        public const int OPTION_INTERIM_TRADE = 19;
        public const int OPTION_CABINET_TRADE = 20;
        public const int PRIVATELY_NEGOTIATED_TRADES = 22;
        public const int SUBSTITUTION_OF_FUTURES_FOR_FORWARDS = 23;
        public const int ERROR_TRADE = 24;
        public const int SPECIAL_CUM_DIVIDEND = 25;
        public const int SPECIAL_EX_DIVIDEND = 26;
        public const int SPECIAL_CUM_COUPON = 27;
        public const int SPECIAL_EX_COUPON = 28;
        public const int CASH_SETTLEMENT = 29;
        public const int SPECIAL_PRICE = 30;
        public const int GUARANTEED_DELIVERY = 31;
        public const int SPECIAL_CUM_RIGHTS = 32;
        public const int SPECIAL_EX_RIGHTS = 33;
        public const int SPECIAL_CUM_CAPITAL_REPAYMENTS = 34;
        public const int SPECIAL_EX_CAPITAL_REPAYMENTS = 35;
        public const int SPECIAL_CUM_BONUS = 36;
        public const int SPECIAL_EX_BONUS = 37;
        public const int BLOCK_TRADE_38 = 38;
        public const int WORKED_PRINCIPAL_TRADE = 39;
        public const int BLOCK_TRADES = 40;
        public const int NAME_CHANGE = 41;
        public const int PORTFOLIO_TRANSFER = 42;
        public const int PROROGATION_BUY = 43;
        public const int PROROGATION_SELL = 44;
        public const int OPTION_EXERCISE = 45;
        public const int DELTA_NEUTRAL_TRANSACTION = 46;
        public const int FINANCING_TRANSACTION = 47;
        public const int NON_STANDARD_SETTLEMENT = 48;
        public const int DERIVATIVE_RELATED_TRANSACTION = 49;
        public const int PORTFOLIO_TRADE = 50;
        public const int VOLUME_WEIGHTED_AVERAGE_TRADE = 51;
        public const int EXCHANGE_GRANTED_TRADE = 52;
        public const int REPURCHASE_AGREEMENT = 53;
        public const int OTC = 54;
        public const int EXCHANGE_BASIS_FACILITY = 55;
        public const int BLOCK_TRADE = 1;
    }


    /// <summary>
    /// TrdSubType Field
    /// </summary>/
    public sealed class TrdSubType : IntField
    {
        public const int TAG = 829;

        public TrdSubType()
            :base(Tags.TrdSubType) {}
        public TrdSubType(int val)
            :base(Tags.TrdSubType, val) {}


        // Field Enumerations
        public const int CMTA = 0;
        public const int INTERNAL_TRANSFER_OR_ADJUSTMENT = 1;
        public const int EXTERNAL_TRANSFER_OR_TRANSFER_OF_ACCOUNT = 2;
        public const int REJECT_FOR_SUBMITTING_SIDE = 3;
        public const int ADVISORY_FOR_CONTRA_SIDE = 4;
        public const int OFFSET_DUE_TO_AN_ALLOCATION = 5;
        public const int ONSET_DUE_TO_AN_ALLOCATION = 6;
        public const int DIFFERENTIAL_SPREAD = 7;
        public const int IMPLIED_SPREAD_LEG_EXECUTED_AGAINST_AN_OUTRIGHT = 8;
        public const int TRANSACTION_FROM_EXERCISE = 9;
        public const int TRANSACTION_FROM_ASSIGNMENT = 10;
        public const int ACATS = 11;
        public const int AI = 14;
        public const int B = 15;
        public const int K = 16;
        public const int LC = 17;
        public const int M = 18;
        public const int N = 19;
        public const int NM = 20;
        public const int NR = 21;
        public const int P = 22;
        public const int PA = 23;
        public const int PC = 24;
        public const int PN = 25;
        public const int R = 26;
        public const int RO = 27;
        public const int RT = 28;
        public const int SW = 29;
        public const int T = 30;
        public const int WN = 31;
        public const int WT = 32;
        public const int OFF_HOURS_TRADE = 33;
        public const int ON_HOURS_TRADE = 34;
        public const int OTC_QUOTE = 35;
        public const int CONVERTED_SWAP = 36;
        public const int CROSSED_TRADE = 37;
        public const int INTERIM_PROTECTED_TRADE = 38;
        public const int LARGE_IN_SCALE = 39;
        public const int ONSET_DUT_TO_AN_ALLOCATION = 6;
    }


    /// <summary>
    /// TransferReason Field
    /// </summary>/
    public sealed class TransferReason : StringField
    {
        public const int TAG = 830;

        public TransferReason()
            :base(Tags.TransferReason) {}
        public TransferReason(string val)
            :base(Tags.TransferReason, val) {}

    }


    /// <summary>
    /// AsgnReqID Field
    /// </summary>/
    public sealed class AsgnReqID : StringField
    {
        public const int TAG = 831;

        public AsgnReqID()
            :base(Tags.AsgnReqID) {}
        public AsgnReqID(string val)
            :base(Tags.AsgnReqID, val) {}

    }


    /// <summary>
    /// TotNumAssignmentReports Field
    /// </summary>/
    public sealed class TotNumAssignmentReports : IntField
    {
        public const int TAG = 832;

        public TotNumAssignmentReports()
            :base(Tags.TotNumAssignmentReports) {}
        public TotNumAssignmentReports(int val)
            :base(Tags.TotNumAssignmentReports, val) {}

    }


    /// <summary>
    /// AsgnRptID Field
    /// </summary>/
    public sealed class AsgnRptID : StringField
    {
        public const int TAG = 833;

        public AsgnRptID()
            :base(Tags.AsgnRptID) {}
        public AsgnRptID(string val)
            :base(Tags.AsgnRptID, val) {}

    }


    /// <summary>
    /// ThresholdAmount Field
    /// </summary>/
    public sealed class ThresholdAmount : DecimalField
    {
        public const int TAG = 834;

        public ThresholdAmount()
            :base(Tags.ThresholdAmount) {}
        public ThresholdAmount(Decimal val)
            :base(Tags.ThresholdAmount, val) {}

    }


    /// <summary>
    /// PegMoveType Field
    /// </summary>/
    public sealed class PegMoveType : IntField
    {
        public const int TAG = 835;

        public PegMoveType()
            :base(Tags.PegMoveType) {}
        public PegMoveType(int val)
            :base(Tags.PegMoveType, val) {}


        // Field Enumerations
        public const int FLOATING = 0;
        public const int FIXED = 1;
    }


    /// <summary>
    /// PegOffsetType Field
    /// </summary>/
    public sealed class PegOffsetType : IntField
    {
        public const int TAG = 836;

        public PegOffsetType()
            :base(Tags.PegOffsetType) {}
        public PegOffsetType(int val)
            :base(Tags.PegOffsetType, val) {}


        // Field Enumerations
        public const int PRICE = 0;
        public const int BASIS_POINTS = 1;
        public const int TICKS = 2;
        public const int PRICE_TIER = 3;
        public const int PRICE_TIER_LEVEL = 3;
    }


    /// <summary>
    /// PegLimitType Field
    /// </summary>/
    public sealed class PegLimitType : IntField
    {
        public const int TAG = 837;

        public PegLimitType()
            :base(Tags.PegLimitType) {}
        public PegLimitType(int val)
            :base(Tags.PegLimitType, val) {}


        // Field Enumerations
        public const int OR_BETTER = 0;
        public const int STRICT = 1;
        public const int OR_WORSE = 2;
    }


    /// <summary>
    /// PegRoundDirection Field
    /// </summary>/
    public sealed class PegRoundDirection : IntField
    {
        public const int TAG = 838;

        public PegRoundDirection()
            :base(Tags.PegRoundDirection) {}
        public PegRoundDirection(int val)
            :base(Tags.PegRoundDirection, val) {}


        // Field Enumerations
        public const int MORE_AGGRESSIVE = 1;
        public const int MORE_PASSIVE = 2;
    }


    /// <summary>
    /// PeggedPrice Field
    /// </summary>/
    public sealed class PeggedPrice : DecimalField
    {
        public const int TAG = 839;

        public PeggedPrice()
            :base(Tags.PeggedPrice) {}
        public PeggedPrice(Decimal val)
            :base(Tags.PeggedPrice, val) {}

    }


    /// <summary>
    /// PegScope Field
    /// </summary>/
    public sealed class PegScope : IntField
    {
        public const int TAG = 840;

        public PegScope()
            :base(Tags.PegScope) {}
        public PegScope(int val)
            :base(Tags.PegScope, val) {}


        // Field Enumerations
        public const int LOCAL = 1;
        public const int NATIONAL = 2;
        public const int GLOBAL = 3;
        public const int NATIONAL_EXCLUDING_LOCAL = 4;
        public const int NATIONAL_XXCLUDING_LOCAL = 4;
    }


    /// <summary>
    /// DiscretionMoveType Field
    /// </summary>/
    public sealed class DiscretionMoveType : IntField
    {
        public const int TAG = 841;

        public DiscretionMoveType()
            :base(Tags.DiscretionMoveType) {}
        public DiscretionMoveType(int val)
            :base(Tags.DiscretionMoveType, val) {}


        // Field Enumerations
        public const int FLOATING = 0;
        public const int FIXED = 1;
    }


    /// <summary>
    /// DiscretionOffsetType Field
    /// </summary>/
    public sealed class DiscretionOffsetType : IntField
    {
        public const int TAG = 842;

        public DiscretionOffsetType()
            :base(Tags.DiscretionOffsetType) {}
        public DiscretionOffsetType(int val)
            :base(Tags.DiscretionOffsetType, val) {}


        // Field Enumerations
        public const int PRICE = 0;
        public const int BASIS_POINTS = 1;
        public const int TICKS = 2;
        public const int PRICE_TIER = 3;
        public const int PRICE_TIER_LEVEL = 3;
    }


    /// <summary>
    /// DiscretionLimitType Field
    /// </summary>/
    public sealed class DiscretionLimitType : IntField
    {
        public const int TAG = 843;

        public DiscretionLimitType()
            :base(Tags.DiscretionLimitType) {}
        public DiscretionLimitType(int val)
            :base(Tags.DiscretionLimitType, val) {}


        // Field Enumerations
        public const int OR_BETTER = 0;
        public const int STRICT = 1;
        public const int OR_WORSE = 2;
    }


    /// <summary>
    /// DiscretionRoundDirection Field
    /// </summary>/
    public sealed class DiscretionRoundDirection : IntField
    {
        public const int TAG = 844;

        public DiscretionRoundDirection()
            :base(Tags.DiscretionRoundDirection) {}
        public DiscretionRoundDirection(int val)
            :base(Tags.DiscretionRoundDirection, val) {}


        // Field Enumerations
        public const int MORE_AGGRESSIVE = 1;
        public const int MORE_PASSIVE = 2;
    }


    /// <summary>
    /// DiscretionPrice Field
    /// </summary>/
    public sealed class DiscretionPrice : DecimalField
    {
        public const int TAG = 845;

        public DiscretionPrice()
            :base(Tags.DiscretionPrice) {}
        public DiscretionPrice(Decimal val)
            :base(Tags.DiscretionPrice, val) {}

    }


    /// <summary>
    /// DiscretionScope Field
    /// </summary>/
    public sealed class DiscretionScope : IntField
    {
        public const int TAG = 846;

        public DiscretionScope()
            :base(Tags.DiscretionScope) {}
        public DiscretionScope(int val)
            :base(Tags.DiscretionScope, val) {}


        // Field Enumerations
        public const int LOCAL = 1;
        public const int NATIONAL = 2;
        public const int GLOBAL = 3;
        public const int NATIONAL_EXCLUDING_LOCAL = 4;
    }


    /// <summary>
    /// TargetStrategy Field
    /// </summary>/
    public sealed class TargetStrategy : IntField
    {
        public const int TAG = 847;

        public TargetStrategy()
            :base(Tags.TargetStrategy) {}
        public TargetStrategy(int val)
            :base(Tags.TargetStrategy, val) {}


        // Field Enumerations
        public const int VWAP = 1;
        public const int PARTICIPATE = 2;
        public const int MININIZE_MARKET_IMPACT = 3;
    }


    /// <summary>
    /// TargetStrategyParameters Field
    /// </summary>/
    public sealed class TargetStrategyParameters : StringField
    {
        public const int TAG = 848;

        public TargetStrategyParameters()
            :base(Tags.TargetStrategyParameters) {}
        public TargetStrategyParameters(string val)
            :base(Tags.TargetStrategyParameters, val) {}

    }


    /// <summary>
    /// ParticipationRate Field
    /// </summary>/
    public sealed class ParticipationRate : DecimalField
    {
        public const int TAG = 849;

        public ParticipationRate()
            :base(Tags.ParticipationRate) {}
        public ParticipationRate(Decimal val)
            :base(Tags.ParticipationRate, val) {}

    }


    /// <summary>
    /// TargetStrategyPerformance Field
    /// </summary>/
    public sealed class TargetStrategyPerformance : DecimalField
    {
        public const int TAG = 850;

        public TargetStrategyPerformance()
            :base(Tags.TargetStrategyPerformance) {}
        public TargetStrategyPerformance(Decimal val)
            :base(Tags.TargetStrategyPerformance, val) {}

    }


    /// <summary>
    /// LastLiquidityInd Field
    /// </summary>/
    public sealed class LastLiquidityInd : IntField
    {
        public const int TAG = 851;

        public LastLiquidityInd()
            :base(Tags.LastLiquidityInd) {}
        public LastLiquidityInd(int val)
            :base(Tags.LastLiquidityInd, val) {}


        // Field Enumerations
        public const int ADDED_LIQUIDITY = 1;
        public const int REMOVED_LIQUIDITY = 2;
        public const int LIQUIDITY_ROUTED_OUT = 3;
        public const int AUCTION = 4;
    }


    /// <summary>
    /// PublishTrdIndicator Field
    /// </summary>/
    public sealed class PublishTrdIndicator : BooleanField
    {
        public const int TAG = 852;

        public PublishTrdIndicator()
            :base(Tags.PublishTrdIndicator) {}
        public PublishTrdIndicator(Boolean val)
            :base(Tags.PublishTrdIndicator, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// ShortSaleReason Field
    /// </summary>/
    public sealed class ShortSaleReason : IntField
    {
        public const int TAG = 853;

        public ShortSaleReason()
            :base(Tags.ShortSaleReason) {}
        public ShortSaleReason(int val)
            :base(Tags.ShortSaleReason, val) {}


        // Field Enumerations
        public const int DEALER_SOLD_SHORT = 0;
        public const int DEALER_SOLD_SHORT_EXEMPT = 1;
        public const int SELLING_CUSTOMER_SOLD_SHORT = 2;
        public const int SELLING_CUSTOMER_SOLD_SHORT_EXEMPT = 3;
        public const int QUALIFIED_SERVICE_REPRESENTATIVE = 4;
        public const int QSR_OR_AGU_CONTRA_SIDE_SOLD_SHORT_EXEMPT = 5;
        public const int QUALIFED_SERVICE_REPRESENTATIVE_OR_AUTOMATIC_GIVEUP_CONTRA_SIDE_SOLD_SHORT = 4;
    }


    /// <summary>
    /// QtyType Field
    /// </summary>/
    public sealed class QtyType : IntField
    {
        public const int TAG = 854;

        public QtyType()
            :base(Tags.QtyType) {}
        public QtyType(int val)
            :base(Tags.QtyType, val) {}


        // Field Enumerations
        public const int UNITS = 0;
        public const int CONTRACTS = 1;
        public const int UNITS_OF_MEASURE_PER_TIME_UNIT = 2;
    }


    /// <summary>
    /// SecondaryTrdType Field
    /// </summary>/
    public sealed class SecondaryTrdType : IntField
    {
        public const int TAG = 855;

        public SecondaryTrdType()
            :base(Tags.SecondaryTrdType) {}
        public SecondaryTrdType(int val)
            :base(Tags.SecondaryTrdType, val) {}

    }


    /// <summary>
    /// TradeReportType Field
    /// </summary>/
    public sealed class TradeReportType : IntField
    {
        public const int TAG = 856;

        public TradeReportType()
            :base(Tags.TradeReportType) {}
        public TradeReportType(int val)
            :base(Tags.TradeReportType, val) {}


        // Field Enumerations
        public const int SUBMIT = 0;
        public const int ALLEGED_1 = 1;
        public const int ACCEPT = 2;
        public const int DECLINE = 3;
        public const int ADDENDUM = 4;
        public const int NO_WAS = 5;
        public const int TRADE_REPORT_CANCEL = 6;
        public const int VAL_7 = 7;
        public const int DEFAULTED = 8;
        public const int INVALID_CMTA = 9;
        public const int PENDED = 10;
        public const int ALLEGED_NEW = 11;
        public const int ALLEGED_ADDENDUM = 12;
        public const int ALLEGED_NO_WAS = 13;
        public const int ALLEGED_TRADE_REPORT_CANCEL = 14;
        public const int ALLEGED_15 = 15;
        public const int ALLEGED = 1;
        public const int LOCKED_IN_TRADE_BREAK = 7;
    }


    /// <summary>
    /// AllocNoOrdersType Field
    /// </summary>/
    public sealed class AllocNoOrdersType : IntField
    {
        public const int TAG = 857;

        public AllocNoOrdersType()
            :base(Tags.AllocNoOrdersType) {}
        public AllocNoOrdersType(int val)
            :base(Tags.AllocNoOrdersType, val) {}


        // Field Enumerations
        public const int NOT_SPECIFIED = 0;
        public const int EXPLICIT_LIST_PROVIDED = 1;
    }


    /// <summary>
    /// SharedCommission Field
    /// </summary>/
    public sealed class SharedCommission : DecimalField
    {
        public const int TAG = 858;

        public SharedCommission()
            :base(Tags.SharedCommission) {}
        public SharedCommission(Decimal val)
            :base(Tags.SharedCommission, val) {}

    }


    /// <summary>
    /// ConfirmReqID Field
    /// </summary>/
    public sealed class ConfirmReqID : StringField
    {
        public const int TAG = 859;

        public ConfirmReqID()
            :base(Tags.ConfirmReqID) {}
        public ConfirmReqID(string val)
            :base(Tags.ConfirmReqID, val) {}

    }


    /// <summary>
    /// AvgParPx Field
    /// </summary>/
    public sealed class AvgParPx : DecimalField
    {
        public const int TAG = 860;

        public AvgParPx()
            :base(Tags.AvgParPx) {}
        public AvgParPx(Decimal val)
            :base(Tags.AvgParPx, val) {}

    }


    /// <summary>
    /// ReportedPx Field
    /// </summary>/
    public sealed class ReportedPx : DecimalField
    {
        public const int TAG = 861;

        public ReportedPx()
            :base(Tags.ReportedPx) {}
        public ReportedPx(Decimal val)
            :base(Tags.ReportedPx, val) {}

    }


    /// <summary>
    /// NoCapacities Field
    /// </summary>/
    public sealed class NoCapacities : IntField
    {
        public const int TAG = 862;

        public NoCapacities()
            :base(Tags.NoCapacities) {}
        public NoCapacities(int val)
            :base(Tags.NoCapacities, val) {}

    }


    /// <summary>
    /// OrderCapacityQty Field
    /// </summary>/
    public sealed class OrderCapacityQty : DecimalField
    {
        public const int TAG = 863;

        public OrderCapacityQty()
            :base(Tags.OrderCapacityQty) {}
        public OrderCapacityQty(Decimal val)
            :base(Tags.OrderCapacityQty, val) {}

    }


    /// <summary>
    /// NoEvents Field
    /// </summary>/
    public sealed class NoEvents : IntField
    {
        public const int TAG = 864;

        public NoEvents()
            :base(Tags.NoEvents) {}
        public NoEvents(int val)
            :base(Tags.NoEvents, val) {}

    }


    /// <summary>
    /// EventType Field
    /// </summary>/
    public sealed class EventType : IntField
    {
        public const int TAG = 865;

        public EventType()
            :base(Tags.EventType) {}
        public EventType(int val)
            :base(Tags.EventType, val) {}


        // Field Enumerations
        public const int PUT = 1;
        public const int CALL = 2;
        public const int TENDER = 3;
        public const int SINKING_FUND_CALL = 4;
        public const int OTHER = 99;
        public const int ACTIVATION = 5;
        public const int INACTIVIATION = 6;
        public const int LAST_ELIGIBLE_TRADE_DATE = 7;
        public const int SWAP_START_DATE = 8;
        public const int SWAP_END_DATE = 9;
        public const int SWAP_NEXT_START_DATE = 11;
        public const int SWAP_ROLL_DATE = 10;
        public const int SWAP_NEXT_ROLL_DATE = 12;
        public const int FIRST_DELIVERY_DATE = 13;
        public const int LAST_DELIVERY_DATE = 14;
        public const int INITIAL_INVENTORY_DUE_DATE = 15;
        public const int FINAL_INVENTORY_DUE_DATE = 16;
        public const int FIRST_INTENT_DATE = 17;
        public const int LAST_INTENT_DATE = 18;
        public const int POSITION_REMOVAL_DATE = 19;
    }


    /// <summary>
    /// EventDate Field
    /// </summary>/
    public sealed class EventDate : StringField
    {
        public const int TAG = 866;

        public EventDate()
            :base(Tags.EventDate) {}
        public EventDate(string val)
            :base(Tags.EventDate, val) {}

    }


    /// <summary>
    /// EventPx Field
    /// </summary>/
    public sealed class EventPx : DecimalField
    {
        public const int TAG = 867;

        public EventPx()
            :base(Tags.EventPx) {}
        public EventPx(Decimal val)
            :base(Tags.EventPx, val) {}

    }


    /// <summary>
    /// EventText Field
    /// </summary>/
    public sealed class EventText : StringField
    {
        public const int TAG = 868;

        public EventText()
            :base(Tags.EventText) {}
        public EventText(string val)
            :base(Tags.EventText, val) {}

    }


    /// <summary>
    /// PctAtRisk Field
    /// </summary>/
    public sealed class PctAtRisk : DecimalField
    {
        public const int TAG = 869;

        public PctAtRisk()
            :base(Tags.PctAtRisk) {}
        public PctAtRisk(Decimal val)
            :base(Tags.PctAtRisk, val) {}

    }


    /// <summary>
    /// NoInstrAttrib Field
    /// </summary>/
    public sealed class NoInstrAttrib : IntField
    {
        public const int TAG = 870;

        public NoInstrAttrib()
            :base(Tags.NoInstrAttrib) {}
        public NoInstrAttrib(int val)
            :base(Tags.NoInstrAttrib, val) {}

    }


    /// <summary>
    /// InstrAttribType Field
    /// </summary>/
    public sealed class InstrAttribType : IntField
    {
        public const int TAG = 871;

        public InstrAttribType()
            :base(Tags.InstrAttribType) {}
        public InstrAttribType(int val)
            :base(Tags.InstrAttribType, val) {}


        // Field Enumerations
        public const int FLAT = 1;
        public const int ORIGINAL_ISSUE_DISCOUNT = 10;
        public const int CALLABLE_PUTTABLE = 11;
        public const int ESCROWED_TO_MATURITY = 12;
        public const int ESCROWED_TO_REDEMPTION_DATE = 13;
        public const int PRE_REFUNDED = 14;
        public const int IN_DEFAULT = 15;
        public const int UNRATED = 16;
        public const int TAXABLE = 17;
        public const int INDEXED = 18;
        public const int SUBJECT_TO_ALTERNATIVE_MINIMUM_TAX = 19;
        public const int ZERO_COUPON = 2;
        public const int ORIGINAL_ISSUE_DISCOUNT_PRICE_SUPPLY_PRICE_IN_THE_INSTRATTRIBVALUE = 20;
        public const int CALLABLE_BELOW_MATURITY_VALUE = 21;
        public const int CALLABLE_WITHOUT_NOTICE_BY_MAIL_TO_HOLDER_UNLESS_REGISTERED = 22;
        public const int INTEREST_BEARING = 3;
        public const int NO_PERIODIC_PAYMENTS = 4;
        public const int VARIABLE_RATE = 5;
        public const int LESS_FEE_FOR_PUT = 6;
        public const int STEPPED_COUPON = 7;
        public const int COUPON_PERIOD = 8;
        public const int WHEN_AND_IF_ISSUED = 9;
        public const int TEXT_SUPPLY_THE_TEXT_OF_THE_ATTRIBUTE_OR_DISCLAIMER_IN_THE_INSTRATTRIBVALUE = 99;
        public const int PRICE_TICK_RULES_FOR_SECURITY = 23;
        public const int TRADE_TYPE_ELIGIBILITY_DETAILS_FOR_SECURITY = 24;
        public const int INSTRUMENT_DENOMINATOR = 25;
        public const int INSTRUMENT_NUMERATOR = 26;
        public const int INSTRUMENT_PRICE_PRECISION = 27;
        public const int INSTRUMENT_STRIKE_PRICE = 28;
        public const int TRADEABLE_INDICATOR = 29;
        public const int ORIGINAL_ISSUE_DISCOUNT_PRICE = 20;
        public const int TEXT = 99;
    }


    /// <summary>
    /// InstrAttribValue Field
    /// </summary>/
    public sealed class InstrAttribValue : StringField
    {
        public const int TAG = 872;

        public InstrAttribValue()
            :base(Tags.InstrAttribValue) {}
        public InstrAttribValue(string val)
            :base(Tags.InstrAttribValue, val) {}

    }


    /// <summary>
    /// DatedDate Field
    /// </summary>/
    public sealed class DatedDate : StringField
    {
        public const int TAG = 873;

        public DatedDate()
            :base(Tags.DatedDate) {}
        public DatedDate(string val)
            :base(Tags.DatedDate, val) {}

    }


    /// <summary>
    /// InterestAccrualDate Field
    /// </summary>/
    public sealed class InterestAccrualDate : StringField
    {
        public const int TAG = 874;

        public InterestAccrualDate()
            :base(Tags.InterestAccrualDate) {}
        public InterestAccrualDate(string val)
            :base(Tags.InterestAccrualDate, val) {}

    }


    /// <summary>
    /// CPProgram Field
    /// </summary>/
    public sealed class CPProgram : IntField
    {
        public const int TAG = 875;

        public CPProgram()
            :base(Tags.CPProgram) {}
        public CPProgram(int val)
            :base(Tags.CPProgram, val) {}


        // Field Enumerations
        public const int VAL_3 = 1;
        public const int VAL_4 = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CPRegType Field
    /// </summary>/
    public sealed class CPRegType : StringField
    {
        public const int TAG = 876;

        public CPRegType()
            :base(Tags.CPRegType) {}
        public CPRegType(string val)
            :base(Tags.CPRegType, val) {}

    }


    /// <summary>
    /// UnderlyingCPProgram Field
    /// </summary>/
    public sealed class UnderlyingCPProgram : StringField
    {
        public const int TAG = 877;

        public UnderlyingCPProgram()
            :base(Tags.UnderlyingCPProgram) {}
        public UnderlyingCPProgram(string val)
            :base(Tags.UnderlyingCPProgram, val) {}

    }


    /// <summary>
    /// UnderlyingCPRegType Field
    /// </summary>/
    public sealed class UnderlyingCPRegType : StringField
    {
        public const int TAG = 878;

        public UnderlyingCPRegType()
            :base(Tags.UnderlyingCPRegType) {}
        public UnderlyingCPRegType(string val)
            :base(Tags.UnderlyingCPRegType, val) {}

    }


    /// <summary>
    /// UnderlyingQty Field
    /// </summary>/
    public sealed class UnderlyingQty : DecimalField
    {
        public const int TAG = 879;

        public UnderlyingQty()
            :base(Tags.UnderlyingQty) {}
        public UnderlyingQty(Decimal val)
            :base(Tags.UnderlyingQty, val) {}

    }


    /// <summary>
    /// TrdMatchID Field
    /// </summary>/
    public sealed class TrdMatchID : StringField
    {
        public const int TAG = 880;

        public TrdMatchID()
            :base(Tags.TrdMatchID) {}
        public TrdMatchID(string val)
            :base(Tags.TrdMatchID, val) {}

    }


    /// <summary>
    /// SecondaryTradeReportRefID Field
    /// </summary>/
    public sealed class SecondaryTradeReportRefID : StringField
    {
        public const int TAG = 881;

        public SecondaryTradeReportRefID()
            :base(Tags.SecondaryTradeReportRefID) {}
        public SecondaryTradeReportRefID(string val)
            :base(Tags.SecondaryTradeReportRefID, val) {}

    }


    /// <summary>
    /// UnderlyingDirtyPrice Field
    /// </summary>/
    public sealed class UnderlyingDirtyPrice : DecimalField
    {
        public const int TAG = 882;

        public UnderlyingDirtyPrice()
            :base(Tags.UnderlyingDirtyPrice) {}
        public UnderlyingDirtyPrice(Decimal val)
            :base(Tags.UnderlyingDirtyPrice, val) {}

    }


    /// <summary>
    /// UnderlyingEndPrice Field
    /// </summary>/
    public sealed class UnderlyingEndPrice : DecimalField
    {
        public const int TAG = 883;

        public UnderlyingEndPrice()
            :base(Tags.UnderlyingEndPrice) {}
        public UnderlyingEndPrice(Decimal val)
            :base(Tags.UnderlyingEndPrice, val) {}

    }


    /// <summary>
    /// UnderlyingStartValue Field
    /// </summary>/
    public sealed class UnderlyingStartValue : DecimalField
    {
        public const int TAG = 884;

        public UnderlyingStartValue()
            :base(Tags.UnderlyingStartValue) {}
        public UnderlyingStartValue(Decimal val)
            :base(Tags.UnderlyingStartValue, val) {}

    }


    /// <summary>
    /// UnderlyingCurrentValue Field
    /// </summary>/
    public sealed class UnderlyingCurrentValue : DecimalField
    {
        public const int TAG = 885;

        public UnderlyingCurrentValue()
            :base(Tags.UnderlyingCurrentValue) {}
        public UnderlyingCurrentValue(Decimal val)
            :base(Tags.UnderlyingCurrentValue, val) {}

    }


    /// <summary>
    /// UnderlyingEndValue Field
    /// </summary>/
    public sealed class UnderlyingEndValue : DecimalField
    {
        public const int TAG = 886;

        public UnderlyingEndValue()
            :base(Tags.UnderlyingEndValue) {}
        public UnderlyingEndValue(Decimal val)
            :base(Tags.UnderlyingEndValue, val) {}

    }


    /// <summary>
    /// NoUnderlyingStips Field
    /// </summary>/
    public sealed class NoUnderlyingStips : IntField
    {
        public const int TAG = 887;

        public NoUnderlyingStips()
            :base(Tags.NoUnderlyingStips) {}
        public NoUnderlyingStips(int val)
            :base(Tags.NoUnderlyingStips, val) {}

    }


    /// <summary>
    /// UnderlyingStipType Field
    /// </summary>/
    public sealed class UnderlyingStipType : StringField
    {
        public const int TAG = 888;

        public UnderlyingStipType()
            :base(Tags.UnderlyingStipType) {}
        public UnderlyingStipType(string val)
            :base(Tags.UnderlyingStipType, val) {}

    }


    /// <summary>
    /// UnderlyingStipValue Field
    /// </summary>/
    public sealed class UnderlyingStipValue : StringField
    {
        public const int TAG = 889;

        public UnderlyingStipValue()
            :base(Tags.UnderlyingStipValue) {}
        public UnderlyingStipValue(string val)
            :base(Tags.UnderlyingStipValue, val) {}

    }


    /// <summary>
    /// MaturityNetMoney Field
    /// </summary>/
    public sealed class MaturityNetMoney : DecimalField
    {
        public const int TAG = 890;

        public MaturityNetMoney()
            :base(Tags.MaturityNetMoney) {}
        public MaturityNetMoney(Decimal val)
            :base(Tags.MaturityNetMoney, val) {}

    }


    /// <summary>
    /// MiscFeeBasis Field
    /// </summary>/
    public sealed class MiscFeeBasis : IntField
    {
        public const int TAG = 891;

        public MiscFeeBasis()
            :base(Tags.MiscFeeBasis) {}
        public MiscFeeBasis(int val)
            :base(Tags.MiscFeeBasis, val) {}


        // Field Enumerations
        public const int ABSOLUTE = 0;
        public const int PER_UNIT = 1;
        public const int PERCENTAGE = 2;
    }


    /// <summary>
    /// TotNoAllocs Field
    /// </summary>/
    public sealed class TotNoAllocs : IntField
    {
        public const int TAG = 892;

        public TotNoAllocs()
            :base(Tags.TotNoAllocs) {}
        public TotNoAllocs(int val)
            :base(Tags.TotNoAllocs, val) {}

    }


    /// <summary>
    /// LastFragment Field
    /// </summary>/
    public sealed class LastFragment : BooleanField
    {
        public const int TAG = 893;

        public LastFragment()
            :base(Tags.LastFragment) {}
        public LastFragment(Boolean val)
            :base(Tags.LastFragment, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// CollReqID Field
    /// </summary>/
    public sealed class CollReqID : StringField
    {
        public const int TAG = 894;

        public CollReqID()
            :base(Tags.CollReqID) {}
        public CollReqID(string val)
            :base(Tags.CollReqID, val) {}

    }


    /// <summary>
    /// CollAsgnReason Field
    /// </summary>/
    public sealed class CollAsgnReason : IntField
    {
        public const int TAG = 895;

        public CollAsgnReason()
            :base(Tags.CollAsgnReason) {}
        public CollAsgnReason(int val)
            :base(Tags.CollAsgnReason, val) {}


        // Field Enumerations
        public const int INITIAL = 0;
        public const int SCHEDULED = 1;
        public const int TIME_WARNING = 2;
        public const int MARGIN_DEFICIENCY = 3;
        public const int MARGIN_EXCESS = 4;
        public const int FORWARD_COLLATERAL_DEMAND = 5;
        public const int EVENT_OF_DEFAULT = 6;
        public const int ADVERSE_TAX_EVENT = 7;
    }


    /// <summary>
    /// CollInquiryQualifier Field
    /// </summary>/
    public sealed class CollInquiryQualifier : IntField
    {
        public const int TAG = 896;

        public CollInquiryQualifier()
            :base(Tags.CollInquiryQualifier) {}
        public CollInquiryQualifier(int val)
            :base(Tags.CollInquiryQualifier, val) {}


        // Field Enumerations
        public const int TRADE_DATE = 0;
        public const int GC_INSTRUMENT = 1;
        public const int COLLATERAL_INSTRUMENT = 2;
        public const int SUBSTITUTION_ELIGIBLE = 3;
        public const int NOT_ASSIGNED = 4;
        public const int PARTIALLY_ASSIGNED = 5;
        public const int FULLY_ASSIGNED = 6;
        public const int OUTSTANDING_TRADES = 7;
        public const int TRADEDATE = 0;
        public const int COLLATERALINSTRUMENT = 2;
    }


    /// <summary>
    /// NoTrades Field
    /// </summary>/
    public sealed class NoTrades : IntField
    {
        public const int TAG = 897;

        public NoTrades()
            :base(Tags.NoTrades) {}
        public NoTrades(int val)
            :base(Tags.NoTrades, val) {}

    }


    /// <summary>
    /// MarginRatio Field
    /// </summary>/
    public sealed class MarginRatio : DecimalField
    {
        public const int TAG = 898;

        public MarginRatio()
            :base(Tags.MarginRatio) {}
        public MarginRatio(Decimal val)
            :base(Tags.MarginRatio, val) {}

    }


    /// <summary>
    /// MarginExcess Field
    /// </summary>/
    public sealed class MarginExcess : DecimalField
    {
        public const int TAG = 899;

        public MarginExcess()
            :base(Tags.MarginExcess) {}
        public MarginExcess(Decimal val)
            :base(Tags.MarginExcess, val) {}

    }


    /// <summary>
    /// TotalNetValue Field
    /// </summary>/
    public sealed class TotalNetValue : DecimalField
    {
        public const int TAG = 900;

        public TotalNetValue()
            :base(Tags.TotalNetValue) {}
        public TotalNetValue(Decimal val)
            :base(Tags.TotalNetValue, val) {}

    }


    /// <summary>
    /// CashOutstanding Field
    /// </summary>/
    public sealed class CashOutstanding : DecimalField
    {
        public const int TAG = 901;

        public CashOutstanding()
            :base(Tags.CashOutstanding) {}
        public CashOutstanding(Decimal val)
            :base(Tags.CashOutstanding, val) {}

    }


    /// <summary>
    /// CollAsgnID Field
    /// </summary>/
    public sealed class CollAsgnID : StringField
    {
        public const int TAG = 902;

        public CollAsgnID()
            :base(Tags.CollAsgnID) {}
        public CollAsgnID(string val)
            :base(Tags.CollAsgnID, val) {}

    }


    /// <summary>
    /// CollAsgnTransType Field
    /// </summary>/
    public sealed class CollAsgnTransType : IntField
    {
        public const int TAG = 903;

        public CollAsgnTransType()
            :base(Tags.CollAsgnTransType) {}
        public CollAsgnTransType(int val)
            :base(Tags.CollAsgnTransType, val) {}


        // Field Enumerations
        public const int NEW = 0;
        public const int REPLACE = 1;
        public const int CANCEL = 2;
        public const int RELEASE = 3;
        public const int REVERSE = 4;
    }


    /// <summary>
    /// CollRespID Field
    /// </summary>/
    public sealed class CollRespID : StringField
    {
        public const int TAG = 904;

        public CollRespID()
            :base(Tags.CollRespID) {}
        public CollRespID(string val)
            :base(Tags.CollRespID, val) {}

    }


    /// <summary>
    /// CollAsgnRespType Field
    /// </summary>/
    public sealed class CollAsgnRespType : IntField
    {
        public const int TAG = 905;

        public CollAsgnRespType()
            :base(Tags.CollAsgnRespType) {}
        public CollAsgnRespType(int val)
            :base(Tags.CollAsgnRespType, val) {}


        // Field Enumerations
        public const int RECEIVED = 0;
        public const int ACCEPTED = 1;
        public const int DECLINED = 2;
        public const int REJECTED = 3;
    }


    /// <summary>
    /// CollAsgnRejectReason Field
    /// </summary>/
    public sealed class CollAsgnRejectReason : IntField
    {
        public const int TAG = 906;

        public CollAsgnRejectReason()
            :base(Tags.CollAsgnRejectReason) {}
        public CollAsgnRejectReason(int val)
            :base(Tags.CollAsgnRejectReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_DEAL = 0;
        public const int UNKNOWN_OR_INVALID_INSTRUMENT = 1;
        public const int UNAUTHORIZED_TRANSACTION = 2;
        public const int INSUFFICIENT_COLLATERAL = 3;
        public const int INVALID_TYPE_OF_COLLATERAL = 4;
        public const int EXCESSIVE_SUBSTITUTION = 5;
        public const int OTHER = 99;
    }


    /// <summary>
    /// CollAsgnRefID Field
    /// </summary>/
    public sealed class CollAsgnRefID : StringField
    {
        public const int TAG = 907;

        public CollAsgnRefID()
            :base(Tags.CollAsgnRefID) {}
        public CollAsgnRefID(string val)
            :base(Tags.CollAsgnRefID, val) {}

    }


    /// <summary>
    /// CollRptID Field
    /// </summary>/
    public sealed class CollRptID : StringField
    {
        public const int TAG = 908;

        public CollRptID()
            :base(Tags.CollRptID) {}
        public CollRptID(string val)
            :base(Tags.CollRptID, val) {}

    }


    /// <summary>
    /// CollInquiryID Field
    /// </summary>/
    public sealed class CollInquiryID : StringField
    {
        public const int TAG = 909;

        public CollInquiryID()
            :base(Tags.CollInquiryID) {}
        public CollInquiryID(string val)
            :base(Tags.CollInquiryID, val) {}

    }


    /// <summary>
    /// CollStatus Field
    /// </summary>/
    public sealed class CollStatus : IntField
    {
        public const int TAG = 910;

        public CollStatus()
            :base(Tags.CollStatus) {}
        public CollStatus(int val)
            :base(Tags.CollStatus, val) {}


        // Field Enumerations
        public const int UNASSIGNED = 0;
        public const int PARTIALLY_ASSIGNED = 1;
        public const int ASSIGNMENT_PROPOSED = 2;
        public const int ASSIGNED = 3;
        public const int CHALLENGED = 4;
    }


    /// <summary>
    /// TotNumReports Field
    /// </summary>/
    public sealed class TotNumReports : IntField
    {
        public const int TAG = 911;

        public TotNumReports()
            :base(Tags.TotNumReports) {}
        public TotNumReports(int val)
            :base(Tags.TotNumReports, val) {}

    }


    /// <summary>
    /// LastRptRequested Field
    /// </summary>/
    public sealed class LastRptRequested : BooleanField
    {
        public const int TAG = 912;

        public LastRptRequested()
            :base(Tags.LastRptRequested) {}
        public LastRptRequested(Boolean val)
            :base(Tags.LastRptRequested, val) {}


        // Field Enumerations
        public const Boolean NO = false;
        public const Boolean YES = true;
    }


    /// <summary>
    /// AgreementDesc Field
    /// </summary>/
    public sealed class AgreementDesc : StringField
    {
        public const int TAG = 913;

        public AgreementDesc()
            :base(Tags.AgreementDesc) {}
        public AgreementDesc(string val)
            :base(Tags.AgreementDesc, val) {}

    }


    /// <summary>
    /// AgreementID Field
    /// </summary>/
    public sealed class AgreementID : StringField
    {
        public const int TAG = 914;

        public AgreementID()
            :base(Tags.AgreementID) {}
        public AgreementID(string val)
            :base(Tags.AgreementID, val) {}

    }


    /// <summary>
    /// AgreementDate Field
    /// </summary>/
    public sealed class AgreementDate : StringField
    {
        public const int TAG = 915;

        public AgreementDate()
            :base(Tags.AgreementDate) {}
        public AgreementDate(string val)
            :base(Tags.AgreementDate, val) {}

    }


    /// <summary>
    /// StartDate Field
    /// </summary>/
    public sealed class StartDate : StringField
    {
        public const int TAG = 916;

        public StartDate()
            :base(Tags.StartDate) {}
        public StartDate(string val)
            :base(Tags.StartDate, val) {}

    }


    /// <summary>
    /// EndDate Field
    /// </summary>/
    public sealed class EndDate : StringField
    {
        public const int TAG = 917;

        public EndDate()
            :base(Tags.EndDate) {}
        public EndDate(string val)
            :base(Tags.EndDate, val) {}

    }


    /// <summary>
    /// AgreementCurrency Field
    /// </summary>/
    public sealed class AgreementCurrency : StringField
    {
        public const int TAG = 918;

        public AgreementCurrency()
            :base(Tags.AgreementCurrency) {}
        public AgreementCurrency(string val)
            :base(Tags.AgreementCurrency, val) {}

    }


    /// <summary>
    /// DeliveryType Field
    /// </summary>/
    public sealed class DeliveryType : IntField
    {
        public const int TAG = 919;

        public DeliveryType()
            :base(Tags.DeliveryType) {}
        public DeliveryType(int val)
            :base(Tags.DeliveryType, val) {}


        // Field Enumerations
        public const int VERSUS_PAYMENT_DELIVER = 0;
        public const int FREE_DELIVER = 1;
        public const int TRI_PARTY = 2;
        public const int HOLD_IN_CUSTODY = 3;
        public const int VERSUS_PAYMENT = 0;
        public const int FREE = 1;
    }


    /// <summary>
    /// EndAccruedInterestAmt Field
    /// </summary>/
    public sealed class EndAccruedInterestAmt : DecimalField
    {
        public const int TAG = 920;

        public EndAccruedInterestAmt()
            :base(Tags.EndAccruedInterestAmt) {}
        public EndAccruedInterestAmt(Decimal val)
            :base(Tags.EndAccruedInterestAmt, val) {}

    }


    /// <summary>
    /// StartCash Field
    /// </summary>/
    public sealed class StartCash : DecimalField
    {
        public const int TAG = 921;

        public StartCash()
            :base(Tags.StartCash) {}
        public StartCash(Decimal val)
            :base(Tags.StartCash, val) {}

    }


    /// <summary>
    /// EndCash Field
    /// </summary>/
    public sealed class EndCash : DecimalField
    {
        public const int TAG = 922;

        public EndCash()
            :base(Tags.EndCash) {}
        public EndCash(Decimal val)
            :base(Tags.EndCash, val) {}

    }


    /// <summary>
    /// UserRequestID Field
    /// </summary>/
    public sealed class UserRequestID : StringField
    {
        public const int TAG = 923;

        public UserRequestID()
            :base(Tags.UserRequestID) {}
        public UserRequestID(string val)
            :base(Tags.UserRequestID, val) {}

    }


    /// <summary>
    /// UserRequestType Field
    /// </summary>/
    public sealed class UserRequestType : IntField
    {
        public const int TAG = 924;

        public UserRequestType()
            :base(Tags.UserRequestType) {}
        public UserRequestType(int val)
            :base(Tags.UserRequestType, val) {}


        // Field Enumerations
        public const int LOG_ON_USER = 1;
        public const int LOG_OFF_USER = 2;
        public const int CHANGE_PASSWORD_FOR_USER = 3;
        public const int REQUEST_INDIVIDUAL_USER_STATUS = 4;
        public const int LOGONUSER = 1;
        public const int LOGOFFUSER = 2;
        public const int CHANGEPASSWORDFORUSER = 3;
    }


    /// <summary>
    /// NewPassword Field
    /// </summary>/
    public sealed class NewPassword : StringField
    {
        public const int TAG = 925;

        public NewPassword()
            :base(Tags.NewPassword) {}
        public NewPassword(string val)
            :base(Tags.NewPassword, val) {}

    }


    /// <summary>
    /// UserStatus Field
    /// </summary>/
    public sealed class UserStatus : IntField
    {
        public const int TAG = 926;

        public UserStatus()
            :base(Tags.UserStatus) {}
        public UserStatus(int val)
            :base(Tags.UserStatus, val) {}


        // Field Enumerations
        public const int LOGGED_IN = 1;
        public const int NOT_LOGGED_IN = 2;
        public const int USER_NOT_RECOGNISED = 3;
        public const int PASSWORD_INCORRECT = 4;
        public const int PASSWORD_CHANGED = 5;
        public const int OTHER = 6;
        public const int FORCED_USER_LOGOUT_BY_EXCHANGE = 7;
        public const int SESSION_SHUTDOWN_WARNING = 8;
    }


    /// <summary>
    /// UserStatusText Field
    /// </summary>/
    public sealed class UserStatusText : StringField
    {
        public const int TAG = 927;

        public UserStatusText()
            :base(Tags.UserStatusText) {}
        public UserStatusText(string val)
            :base(Tags.UserStatusText, val) {}

    }


    /// <summary>
    /// StatusValue Field
    /// </summary>/
    public sealed class StatusValue : IntField
    {
        public const int TAG = 928;

        public StatusValue()
            :base(Tags.StatusValue) {}
        public StatusValue(int val)
            :base(Tags.StatusValue, val) {}


        // Field Enumerations
        public const int CONNECTED = 1;
        public const int NOT_CONNECTED_2 = 2;
        public const int NOT_CONNECTED_3 = 3;
        public const int IN_PROCESS = 4;
        public const int NOT_CONNECTED_DOWN_EXPECTED_UP = 2;
        public const int NOT_CONNECTED_DOWN_EXPECTED_DOWN = 3;
    }


    /// <summary>
    /// StatusText Field
    /// </summary>/
    public sealed class StatusText : StringField
    {
        public const int TAG = 929;

        public StatusText()
            :base(Tags.StatusText) {}
        public StatusText(string val)
            :base(Tags.StatusText, val) {}

    }


    /// <summary>
    /// RefCompID Field
    /// </summary>/
    public sealed class RefCompID : StringField
    {
        public const int TAG = 930;

        public RefCompID()
            :base(Tags.RefCompID) {}
        public RefCompID(string val)
            :base(Tags.RefCompID, val) {}

    }


    /// <summary>
    /// RefSubID Field
    /// </summary>/
    public sealed class RefSubID : StringField
    {
        public const int TAG = 931;

        public RefSubID()
            :base(Tags.RefSubID) {}
        public RefSubID(string val)
            :base(Tags.RefSubID, val) {}

    }


    /// <summary>
    /// NetworkResponseID Field
    /// </summary>/
    public sealed class NetworkResponseID : StringField
    {
        public const int TAG = 932;

        public NetworkResponseID()
            :base(Tags.NetworkResponseID) {}
        public NetworkResponseID(string val)
            :base(Tags.NetworkResponseID, val) {}

    }


    /// <summary>
    /// NetworkRequestID Field
    /// </summary>/
    public sealed class NetworkRequestID : StringField
    {
        public const int TAG = 933;

        public NetworkRequestID()
            :base(Tags.NetworkRequestID) {}
        public NetworkRequestID(string val)
            :base(Tags.NetworkRequestID, val) {}

    }


    /// <summary>
    /// LastNetworkResponseID Field
    /// </summary>/
    public sealed class LastNetworkResponseID : StringField
    {
        public const int TAG = 934;

        public LastNetworkResponseID()
            :base(Tags.LastNetworkResponseID) {}
        public LastNetworkResponseID(string val)
            :base(Tags.LastNetworkResponseID, val) {}

    }


    /// <summary>
    /// NetworkRequestType Field
    /// </summary>/
    public sealed class NetworkRequestType : IntField
    {
        public const int TAG = 935;

        public NetworkRequestType()
            :base(Tags.NetworkRequestType) {}
        public NetworkRequestType(int val)
            :base(Tags.NetworkRequestType, val) {}


        // Field Enumerations
        public const int SNAPSHOT = 1;
        public const int SUBSCRIBE = 2;
        public const int STOP_SUBSCRIBING = 4;
        public const int LEVEL_OF_DETAIL_THEN_NOCOMPIDS_BECOMES_REQUIRED = 8;
        public const int LEVEL_OF_DETAIL = 8;
    }


    /// <summary>
    /// NoCompIDs Field
    /// </summary>/
    public sealed class NoCompIDs : IntField
    {
        public const int TAG = 936;

        public NoCompIDs()
            :base(Tags.NoCompIDs) {}
        public NoCompIDs(int val)
            :base(Tags.NoCompIDs, val) {}

    }


    /// <summary>
    /// NetworkStatusResponseType Field
    /// </summary>/
    public sealed class NetworkStatusResponseType : IntField
    {
        public const int TAG = 937;

        public NetworkStatusResponseType()
            :base(Tags.NetworkStatusResponseType) {}
        public NetworkStatusResponseType(int val)
            :base(Tags.NetworkStatusResponseType, val) {}


        // Field Enumerations
        public const int FULL = 1;
        public const int INCREMENTAL_UPDATE = 2;
    }


    /// <summary>
    /// NoCollInquiryQualifier Field
    /// </summary>/
    public sealed class NoCollInquiryQualifier : IntField
    {
        public const int TAG = 938;

        public NoCollInquiryQualifier()
            :base(Tags.NoCollInquiryQualifier) {}
        public NoCollInquiryQualifier(int val)
            :base(Tags.NoCollInquiryQualifier, val) {}

    }


    /// <summary>
    /// TrdRptStatus Field
    /// </summary>/
    public sealed class TrdRptStatus : IntField
    {
        public const int TAG = 939;

        public TrdRptStatus()
            :base(Tags.TrdRptStatus) {}
        public TrdRptStatus(int val)
            :base(Tags.TrdRptStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int REJECTED = 1;
        public const int ACCEPTED_WITH_ERRORS = 3;
    }


    /// <summary>
    /// AffirmStatus Field
    /// </summary>/
    public sealed class AffirmStatus : IntField
    {
        public const int TAG = 940;

        public AffirmStatus()
            :base(Tags.AffirmStatus) {}
        public AffirmStatus(int val)
            :base(Tags.AffirmStatus, val) {}


        // Field Enumerations
        public const int RECEIVED = 1;
        public const int CONFIRM_REJECTED_IE_NOT_AFFIRMED = 2;
        public const int AFFIRMED = 3;
        public const int CONFIRM_REJECTED = 2;
    }


    /// <summary>
    /// UnderlyingStrikeCurrency Field
    /// </summary>/
    public sealed class UnderlyingStrikeCurrency : StringField
    {
        public const int TAG = 941;

        public UnderlyingStrikeCurrency()
            :base(Tags.UnderlyingStrikeCurrency) {}
        public UnderlyingStrikeCurrency(string val)
            :base(Tags.UnderlyingStrikeCurrency, val) {}

    }


    /// <summary>
    /// LegStrikeCurrency Field
    /// </summary>/
    public sealed class LegStrikeCurrency : StringField
    {
        public const int TAG = 942;

        public LegStrikeCurrency()
            :base(Tags.LegStrikeCurrency) {}
        public LegStrikeCurrency(string val)
            :base(Tags.LegStrikeCurrency, val) {}

    }


    /// <summary>
    /// TimeBracket Field
    /// </summary>/
    public sealed class TimeBracket : StringField
    {
        public const int TAG = 943;

        public TimeBracket()
            :base(Tags.TimeBracket) {}
        public TimeBracket(string val)
            :base(Tags.TimeBracket, val) {}

    }


    /// <summary>
    /// CollAction Field
    /// </summary>/
    public sealed class CollAction : IntField
    {
        public const int TAG = 944;

        public CollAction()
            :base(Tags.CollAction) {}
        public CollAction(int val)
            :base(Tags.CollAction, val) {}


        // Field Enumerations
        public const int RETAIN = 0;
        public const int ADD = 1;
        public const int REMOVE = 2;
    }


    /// <summary>
    /// CollInquiryStatus Field
    /// </summary>/
    public sealed class CollInquiryStatus : IntField
    {
        public const int TAG = 945;

        public CollInquiryStatus()
            :base(Tags.CollInquiryStatus) {}
        public CollInquiryStatus(int val)
            :base(Tags.CollInquiryStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int ACCEPTED_WITH_WARNINGS = 1;
        public const int COMPLETED = 2;
        public const int COMPLETED_WITH_WARNINGS = 3;
        public const int REJECTED = 4;
    }


    /// <summary>
    /// CollInquiryResult Field
    /// </summary>/
    public sealed class CollInquiryResult : IntField
    {
        public const int TAG = 946;

        public CollInquiryResult()
            :base(Tags.CollInquiryResult) {}
        public CollInquiryResult(int val)
            :base(Tags.CollInquiryResult, val) {}


        // Field Enumerations
        public const int SUCCESSFUL = 0;
        public const int INVALID_OR_UNKNOWN_INSTRUMENT = 1;
        public const int INVALID_OR_UNKNOWN_COLLATERAL_TYPE = 2;
        public const int INVALID_PARTIES = 3;
        public const int INVALID_TRANSPORT_TYPE_REQUESTED = 4;
        public const int INVALID_DESTINATION_REQUESTED = 5;
        public const int NO_COLLATERAL_FOUND_FOR_THE_TRADE_SPECIFIED = 6;
        public const int NO_COLLATERAL_FOUND_FOR_THE_ORDER_SPECIFIED = 7;
        public const int COLLATERAL_INQUIRY_TYPE_NOT_SUPPORTED = 8;
        public const int UNAUTHORIZED_FOR_COLLATERAL_INQUIRY = 9;
        public const int OTHER = 99;
    }


    /// <summary>
    /// StrikeCurrency Field
    /// </summary>/
    public sealed class StrikeCurrency : StringField
    {
        public const int TAG = 947;

        public StrikeCurrency()
            :base(Tags.StrikeCurrency) {}
        public StrikeCurrency(string val)
            :base(Tags.StrikeCurrency, val) {}

    }


    /// <summary>
    /// NoNested3PartyIDs Field
    /// </summary>/
    public sealed class NoNested3PartyIDs : IntField
    {
        public const int TAG = 948;

        public NoNested3PartyIDs()
            :base(Tags.NoNested3PartyIDs) {}
        public NoNested3PartyIDs(int val)
            :base(Tags.NoNested3PartyIDs, val) {}

    }


    /// <summary>
    /// Nested3PartyID Field
    /// </summary>/
    public sealed class Nested3PartyID : StringField
    {
        public const int TAG = 949;

        public Nested3PartyID()
            :base(Tags.Nested3PartyID) {}
        public Nested3PartyID(string val)
            :base(Tags.Nested3PartyID, val) {}

    }


    /// <summary>
    /// Nested3PartyIDSource Field
    /// </summary>/
    public sealed class Nested3PartyIDSource : CharField
    {
        public const int TAG = 950;

        public Nested3PartyIDSource()
            :base(Tags.Nested3PartyIDSource) {}
        public Nested3PartyIDSource(char val)
            :base(Tags.Nested3PartyIDSource, val) {}

    }


    /// <summary>
    /// Nested3PartyRole Field
    /// </summary>/
    public sealed class Nested3PartyRole : IntField
    {
        public const int TAG = 951;

        public Nested3PartyRole()
            :base(Tags.Nested3PartyRole) {}
        public Nested3PartyRole(int val)
            :base(Tags.Nested3PartyRole, val) {}

    }


    /// <summary>
    /// NoNested3PartySubIDs Field
    /// </summary>/
    public sealed class NoNested3PartySubIDs : IntField
    {
        public const int TAG = 952;

        public NoNested3PartySubIDs()
            :base(Tags.NoNested3PartySubIDs) {}
        public NoNested3PartySubIDs(int val)
            :base(Tags.NoNested3PartySubIDs, val) {}

    }


    /// <summary>
    /// Nested3PartySubID Field
    /// </summary>/
    public sealed class Nested3PartySubID : StringField
    {
        public const int TAG = 953;

        public Nested3PartySubID()
            :base(Tags.Nested3PartySubID) {}
        public Nested3PartySubID(string val)
            :base(Tags.Nested3PartySubID, val) {}

    }


    /// <summary>
    /// Nested3PartySubIDType Field
    /// </summary>/
    public sealed class Nested3PartySubIDType : IntField
    {
        public const int TAG = 954;

        public Nested3PartySubIDType()
            :base(Tags.Nested3PartySubIDType) {}
        public Nested3PartySubIDType(int val)
            :base(Tags.Nested3PartySubIDType, val) {}

    }


    /// <summary>
    /// LegContractSettlMonth Field
    /// </summary>/
    public sealed class LegContractSettlMonth : StringField
    {
        public const int TAG = 955;

        public LegContractSettlMonth()
            :base(Tags.LegContractSettlMonth) {}
        public LegContractSettlMonth(string val)
            :base(Tags.LegContractSettlMonth, val) {}

    }


    /// <summary>
    /// LegInterestAccrualDate Field
    /// </summary>/
    public sealed class LegInterestAccrualDate : StringField
    {
        public const int TAG = 956;

        public LegInterestAccrualDate()
            :base(Tags.LegInterestAccrualDate) {}
        public LegInterestAccrualDate(string val)
            :base(Tags.LegInterestAccrualDate, val) {}

    }


    /// <summary>
    /// IOIID Field
    /// </summary>/
    public sealed class IOIID : StringField
    {
        public const int TAG = 23;

        public IOIID()
            :base(Tags.IOIID) {}
        public IOIID(string val)
            :base(Tags.IOIID, val) {}

    }


    /// <summary>
    /// NoLinesOfText Field
    /// </summary>/
    public sealed class NoLinesOfText : IntField
    {
        public const int TAG = 33;

        public NoLinesOfText()
            :base(Tags.NoLinesOfText) {}
        public NoLinesOfText(int val)
            :base(Tags.NoLinesOfText, val) {}

    }


    /// <summary>
    /// HaltReasonChar Field
    /// </summary>/
    public sealed class HaltReasonChar : CharField
    {
        public const int TAG = 327;

        public HaltReasonChar()
            :base(Tags.HaltReasonChar) {}
        public HaltReasonChar(char val)
            :base(Tags.HaltReasonChar, val) {}


        // Field Enumerations
        public const char NEWS_DISSEMINATION = 'D';
        public const char ORDER_INFLUX = 'E';
        public const char ORDER_IMBALANCE = 'I';
        public const char ADDITIONAL_INFORMATION = 'M';
        public const char NEW_PENDING = 'P';
        public const char EQUIPMENT_CHANGEOVER = 'X';
    }


    /// <summary>
    /// NoStrategyParameters Field
    /// </summary>/
    public sealed class NoStrategyParameters : IntField
    {
        public const int TAG = 957;

        public NoStrategyParameters()
            :base(Tags.NoStrategyParameters) {}
        public NoStrategyParameters(int val)
            :base(Tags.NoStrategyParameters, val) {}

    }


    /// <summary>
    /// StrategyParameterName Field
    /// </summary>/
    public sealed class StrategyParameterName : StringField
    {
        public const int TAG = 958;

        public StrategyParameterName()
            :base(Tags.StrategyParameterName) {}
        public StrategyParameterName(string val)
            :base(Tags.StrategyParameterName, val) {}

    }


    /// <summary>
    /// StrategyParameterType Field
    /// </summary>/
    public sealed class StrategyParameterType : IntField
    {
        public const int TAG = 959;

        public StrategyParameterType()
            :base(Tags.StrategyParameterType) {}
        public StrategyParameterType(int val)
            :base(Tags.StrategyParameterType, val) {}


        // Field Enumerations
        public const int INT = 1;
        public const int LENGTH = 2;
        public const int NUMINGROUP = 3;
        public const int SEQNUM = 4;
        public const int TAGNUM = 5;
        public const int FLOAT = 6;
        public const int QTY = 7;
        public const int PRICE = 8;
        public const int PRICEOFFSET = 9;
        public const int AMT = 10;
        public const int PERCENTAGE = 11;
        public const int CHAR = 12;
        public const int BOOLEAN = 13;
        public const int STRING = 14;
        public const int MULTIPLECHARVALUE = 15;
        public const int CURRENCY = 16;
        public const int EXCHANGE = 17;
        public const int MONTHYEAR = 18;
        public const int UTCTIMESTAMP = 19;
        public const int UTCTIMEONLY = 20;
        public const int LOCALMKTDATE = 21;
        public const int UTCDATEONLY = 22;
        public const int DATA = 23;
        public const int MULTIPLESTRINGVALUE = 24;
        public const int COUNTRY = 25;
        public const int LANGUAGE = 26;
        public const int TZTIMEONLY = 27;
        public const int TZTIMESTAMP = 28;
        public const int TENOR = 29;
        public const int MONTH_YEAR = 18;
        public const int LOCALMKTTIME = 21;
        public const int UTCDATE = 22;
    }


    /// <summary>
    /// StrategyParameterValue Field
    /// </summary>/
    public sealed class StrategyParameterValue : StringField
    {
        public const int TAG = 960;

        public StrategyParameterValue()
            :base(Tags.StrategyParameterValue) {}
        public StrategyParameterValue(string val)
            :base(Tags.StrategyParameterValue, val) {}

    }


    /// <summary>
    /// HostCrossID Field
    /// </summary>/
    public sealed class HostCrossID : StringField
    {
        public const int TAG = 961;

        public HostCrossID()
            :base(Tags.HostCrossID) {}
        public HostCrossID(string val)
            :base(Tags.HostCrossID, val) {}

    }


    /// <summary>
    /// SideTimeInForce Field
    /// </summary>/
    public sealed class SideTimeInForce : DateTimeField
    {
        public const int TAG = 962;

        public SideTimeInForce()
            :base(Tags.SideTimeInForce) {}
        public SideTimeInForce(DateTime val)
            :base(Tags.SideTimeInForce, val) {}
        public SideTimeInForce(DateTime val, bool showMilliseconds)
            :base(Tags.SideTimeInForce, val, showMilliseconds) {}
		public SideTimeInForce(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.SideTimeInForce, val, precision) {}

    }


    /// <summary>
    /// MDReportID Field
    /// </summary>/
    public sealed class MDReportID : IntField
    {
        public const int TAG = 963;

        public MDReportID()
            :base(Tags.MDReportID) {}
        public MDReportID(int val)
            :base(Tags.MDReportID, val) {}

    }


    /// <summary>
    /// SecurityReportID Field
    /// </summary>/
    public sealed class SecurityReportID : IntField
    {
        public const int TAG = 964;

        public SecurityReportID()
            :base(Tags.SecurityReportID) {}
        public SecurityReportID(int val)
            :base(Tags.SecurityReportID, val) {}

    }


    /// <summary>
    /// SecurityStat Field
    /// </summary>/
    public sealed class SecurityStat : StringField
    {
        public const int TAG = 965;

        public SecurityStat()
            :base(Tags.SecurityStat) {}
        public SecurityStat(string val)
            :base(Tags.SecurityStat, val) {}


        // Field Enumerations
        public const string ACTIVE = "1";
        public const string INACTIVE = "2";
    }


    /// <summary>
    /// SettleOnOpenFlag Field
    /// </summary>/
    public sealed class SettleOnOpenFlag : StringField
    {
        public const int TAG = 966;

        public SettleOnOpenFlag()
            :base(Tags.SettleOnOpenFlag) {}
        public SettleOnOpenFlag(string val)
            :base(Tags.SettleOnOpenFlag, val) {}

    }


    /// <summary>
    /// StrikeMultiplier Field
    /// </summary>/
    public sealed class StrikeMultiplier : DecimalField
    {
        public const int TAG = 967;

        public StrikeMultiplier()
            :base(Tags.StrikeMultiplier) {}
        public StrikeMultiplier(Decimal val)
            :base(Tags.StrikeMultiplier, val) {}

    }


    /// <summary>
    /// StrikeValue Field
    /// </summary>/
    public sealed class StrikeValue : DecimalField
    {
        public const int TAG = 968;

        public StrikeValue()
            :base(Tags.StrikeValue) {}
        public StrikeValue(Decimal val)
            :base(Tags.StrikeValue, val) {}

    }


    /// <summary>
    /// MinPriceIncrement Field
    /// </summary>/
    public sealed class MinPriceIncrement : DecimalField
    {
        public const int TAG = 969;

        public MinPriceIncrement()
            :base(Tags.MinPriceIncrement) {}
        public MinPriceIncrement(Decimal val)
            :base(Tags.MinPriceIncrement, val) {}

    }


    /// <summary>
    /// PositionLimit Field
    /// </summary>/
    public sealed class PositionLimit : IntField
    {
        public const int TAG = 970;

        public PositionLimit()
            :base(Tags.PositionLimit) {}
        public PositionLimit(int val)
            :base(Tags.PositionLimit, val) {}

    }


    /// <summary>
    /// NTPositionLimit Field
    /// </summary>/
    public sealed class NTPositionLimit : IntField
    {
        public const int TAG = 971;

        public NTPositionLimit()
            :base(Tags.NTPositionLimit) {}
        public NTPositionLimit(int val)
            :base(Tags.NTPositionLimit, val) {}

    }


    /// <summary>
    /// UnderlyingAllocationPercent Field
    /// </summary>/
    public sealed class UnderlyingAllocationPercent : DecimalField
    {
        public const int TAG = 972;

        public UnderlyingAllocationPercent()
            :base(Tags.UnderlyingAllocationPercent) {}
        public UnderlyingAllocationPercent(Decimal val)
            :base(Tags.UnderlyingAllocationPercent, val) {}

    }


    /// <summary>
    /// UnderlyingCashAmount Field
    /// </summary>/
    public sealed class UnderlyingCashAmount : DecimalField
    {
        public const int TAG = 973;

        public UnderlyingCashAmount()
            :base(Tags.UnderlyingCashAmount) {}
        public UnderlyingCashAmount(Decimal val)
            :base(Tags.UnderlyingCashAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCashType Field
    /// </summary>/
    public sealed class UnderlyingCashType : StringField
    {
        public const int TAG = 974;

        public UnderlyingCashType()
            :base(Tags.UnderlyingCashType) {}
        public UnderlyingCashType(string val)
            :base(Tags.UnderlyingCashType, val) {}


        // Field Enumerations
        public const string FIXED = "FIXED";
        public const string DIFF = "DIFF";
    }


    /// <summary>
    /// UnderlyingSettlementType Field
    /// </summary>/
    public sealed class UnderlyingSettlementType : IntField
    {
        public const int TAG = 975;

        public UnderlyingSettlementType()
            :base(Tags.UnderlyingSettlementType) {}
        public UnderlyingSettlementType(int val)
            :base(Tags.UnderlyingSettlementType, val) {}


        // Field Enumerations
        public const int T_PLUS_1 = 2;
        public const int T_PLUS_3 = 4;
        public const int T_PLUS_4 = 5;
    }


    /// <summary>
    /// QuantityDate Field
    /// </summary>/
    public sealed class QuantityDate : StringField
    {
        public const int TAG = 976;

        public QuantityDate()
            :base(Tags.QuantityDate) {}
        public QuantityDate(string val)
            :base(Tags.QuantityDate, val) {}

    }


    /// <summary>
    /// ContIntRptID Field
    /// </summary>/
    public sealed class ContIntRptID : StringField
    {
        public const int TAG = 977;

        public ContIntRptID()
            :base(Tags.ContIntRptID) {}
        public ContIntRptID(string val)
            :base(Tags.ContIntRptID, val) {}

    }


    /// <summary>
    /// LateIndicator Field
    /// </summary>/
    public sealed class LateIndicator : BooleanField
    {
        public const int TAG = 978;

        public LateIndicator()
            :base(Tags.LateIndicator) {}
        public LateIndicator(Boolean val)
            :base(Tags.LateIndicator, val) {}

    }


    /// <summary>
    /// InputSource Field
    /// </summary>/
    public sealed class InputSource : StringField
    {
        public const int TAG = 979;

        public InputSource()
            :base(Tags.InputSource) {}
        public InputSource(string val)
            :base(Tags.InputSource, val) {}

    }


    /// <summary>
    /// SecurityUpdateAction Field
    /// </summary>/
    public sealed class SecurityUpdateAction : CharField
    {
        public const int TAG = 980;

        public SecurityUpdateAction()
            :base(Tags.SecurityUpdateAction) {}
        public SecurityUpdateAction(char val)
            :base(Tags.SecurityUpdateAction, val) {}


        // Field Enumerations
        public const char ADD = 'A';
        public const char DELETE = 'D';
        public const char MODIFY = 'M';
    }


    /// <summary>
    /// NoExpiration Field
    /// </summary>/
    public sealed class NoExpiration : IntField
    {
        public const int TAG = 981;

        public NoExpiration()
            :base(Tags.NoExpiration) {}
        public NoExpiration(int val)
            :base(Tags.NoExpiration, val) {}

    }


    /// <summary>
    /// ExpType Field
    /// </summary>/
    public sealed class ExpType : IntField
    {
        public const int TAG = 982;

        public ExpType()
            :base(Tags.ExpType) {}
        public ExpType(int val)
            :base(Tags.ExpType, val) {}


        // Field Enumerations
        public const int AUTO_EXERCISE = 1;
        public const int NON_AUTO_EXERCISE = 2;
        public const int FINAL_WILL_BE_EXERCISED = 3;
        public const int CONTRARY_INTENTION = 4;
        public const int DIFFERENCE = 5;
    }


    /// <summary>
    /// ExpQty Field
    /// </summary>/
    public sealed class ExpQty : DecimalField
    {
        public const int TAG = 983;

        public ExpQty()
            :base(Tags.ExpQty) {}
        public ExpQty(Decimal val)
            :base(Tags.ExpQty, val) {}

    }


    /// <summary>
    /// NoUnderlyingAmounts Field
    /// </summary>/
    public sealed class NoUnderlyingAmounts : IntField
    {
        public const int TAG = 984;

        public NoUnderlyingAmounts()
            :base(Tags.NoUnderlyingAmounts) {}
        public NoUnderlyingAmounts(int val)
            :base(Tags.NoUnderlyingAmounts, val) {}

    }


    /// <summary>
    /// UnderlyingPayAmount Field
    /// </summary>/
    public sealed class UnderlyingPayAmount : DecimalField
    {
        public const int TAG = 985;

        public UnderlyingPayAmount()
            :base(Tags.UnderlyingPayAmount) {}
        public UnderlyingPayAmount(Decimal val)
            :base(Tags.UnderlyingPayAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCollectAmount Field
    /// </summary>/
    public sealed class UnderlyingCollectAmount : DecimalField
    {
        public const int TAG = 986;

        public UnderlyingCollectAmount()
            :base(Tags.UnderlyingCollectAmount) {}
        public UnderlyingCollectAmount(Decimal val)
            :base(Tags.UnderlyingCollectAmount, val) {}

    }


    /// <summary>
    /// UnderlyingSettlementDate Field
    /// </summary>/
    public sealed class UnderlyingSettlementDate : StringField
    {
        public const int TAG = 987;

        public UnderlyingSettlementDate()
            :base(Tags.UnderlyingSettlementDate) {}
        public UnderlyingSettlementDate(string val)
            :base(Tags.UnderlyingSettlementDate, val) {}

    }


    /// <summary>
    /// UnderlyingSettlementStatus Field
    /// </summary>/
    public sealed class UnderlyingSettlementStatus : StringField
    {
        public const int TAG = 988;

        public UnderlyingSettlementStatus()
            :base(Tags.UnderlyingSettlementStatus) {}
        public UnderlyingSettlementStatus(string val)
            :base(Tags.UnderlyingSettlementStatus, val) {}

    }


    /// <summary>
    /// SecondaryIndividualAllocID Field
    /// </summary>/
    public sealed class SecondaryIndividualAllocID : StringField
    {
        public const int TAG = 989;

        public SecondaryIndividualAllocID()
            :base(Tags.SecondaryIndividualAllocID) {}
        public SecondaryIndividualAllocID(string val)
            :base(Tags.SecondaryIndividualAllocID, val) {}

    }


    /// <summary>
    /// LegReportID Field
    /// </summary>/
    public sealed class LegReportID : StringField
    {
        public const int TAG = 990;

        public LegReportID()
            :base(Tags.LegReportID) {}
        public LegReportID(string val)
            :base(Tags.LegReportID, val) {}

    }


    /// <summary>
    /// RndPx Field
    /// </summary>/
    public sealed class RndPx : DecimalField
    {
        public const int TAG = 991;

        public RndPx()
            :base(Tags.RndPx) {}
        public RndPx(Decimal val)
            :base(Tags.RndPx, val) {}

    }


    /// <summary>
    /// IndividualAllocType Field
    /// </summary>/
    public sealed class IndividualAllocType : IntField
    {
        public const int TAG = 992;

        public IndividualAllocType()
            :base(Tags.IndividualAllocType) {}
        public IndividualAllocType(int val)
            :base(Tags.IndividualAllocType, val) {}


        // Field Enumerations
        public const int SUB_ALLOCATE = 1;
        public const int THIRD_PARTY_ALLOCATION = 2;
    }


    /// <summary>
    /// AllocCustomerCapacity Field
    /// </summary>/
    public sealed class AllocCustomerCapacity : StringField
    {
        public const int TAG = 993;

        public AllocCustomerCapacity()
            :base(Tags.AllocCustomerCapacity) {}
        public AllocCustomerCapacity(string val)
            :base(Tags.AllocCustomerCapacity, val) {}

    }


    /// <summary>
    /// TierCode Field
    /// </summary>/
    public sealed class TierCode : StringField
    {
        public const int TAG = 994;

        public TierCode()
            :base(Tags.TierCode) {}
        public TierCode(string val)
            :base(Tags.TierCode, val) {}

    }


    /// <summary>
    /// UnitOfMeasure Field
    /// </summary>/
    public sealed class UnitOfMeasure : StringField
    {
        public const int TAG = 996;

        public UnitOfMeasure()
            :base(Tags.UnitOfMeasure) {}
        public UnitOfMeasure(string val)
            :base(Tags.UnitOfMeasure, val) {}


        // Field Enumerations
        public const string MEGAWATT_HOURS = "MWh";
        public const string ONE_MILLION_BTU = "MMBtu";
        public const string BARRELS = "Bbl";
        public const string GALLONS = "Gal";
        public const string METRIC_TONS = "t";
        public const string TONS = "tn";
        public const string MILLION_BARRELS = "MMbbl";
        public const string POUNDS = "lbs";
        public const string TROY_OUNCES = "oz_tr";
        public const string US_DOLLARS = "USD";
        public const string BILLION_CUBIC_FEET = "Bcf";
        public const string BUSHELS = "Bu";
        public const string ALLOWANCES = "Alw";
    }


    /// <summary>
    /// TimeUnit Field
    /// </summary>/
    public sealed class TimeUnit : StringField
    {
        public const int TAG = 997;

        public TimeUnit()
            :base(Tags.TimeUnit) {}
        public TimeUnit(string val)
            :base(Tags.TimeUnit, val) {}


        // Field Enumerations
        public const string SECOND = "S";
        public const string MINUTE = "Min";
        public const string HOUR = "H";
        public const string DAY = "D";
        public const string WEEK = "Wk";
        public const string MONTH = "Mo";
        public const string YEAR = "Yr";
    }


    /// <summary>
    /// UnderlyingUnitOfMeasure Field
    /// </summary>/
    public sealed class UnderlyingUnitOfMeasure : StringField
    {
        public const int TAG = 998;

        public UnderlyingUnitOfMeasure()
            :base(Tags.UnderlyingUnitOfMeasure) {}
        public UnderlyingUnitOfMeasure(string val)
            :base(Tags.UnderlyingUnitOfMeasure, val) {}

    }


    /// <summary>
    /// LegUnitOfMeasure Field
    /// </summary>/
    public sealed class LegUnitOfMeasure : StringField
    {
        public const int TAG = 999;

        public LegUnitOfMeasure()
            :base(Tags.LegUnitOfMeasure) {}
        public LegUnitOfMeasure(string val)
            :base(Tags.LegUnitOfMeasure, val) {}

    }


    /// <summary>
    /// UnderlyingTimeUnit Field
    /// </summary>/
    public sealed class UnderlyingTimeUnit : StringField
    {
        public const int TAG = 1000;

        public UnderlyingTimeUnit()
            :base(Tags.UnderlyingTimeUnit) {}
        public UnderlyingTimeUnit(string val)
            :base(Tags.UnderlyingTimeUnit, val) {}

    }


    /// <summary>
    /// LegTimeUnit Field
    /// </summary>/
    public sealed class LegTimeUnit : StringField
    {
        public const int TAG = 1001;

        public LegTimeUnit()
            :base(Tags.LegTimeUnit) {}
        public LegTimeUnit(string val)
            :base(Tags.LegTimeUnit, val) {}

    }


    /// <summary>
    /// AllocMethod Field
    /// </summary>/
    public sealed class AllocMethod : IntField
    {
        public const int TAG = 1002;

        public AllocMethod()
            :base(Tags.AllocMethod) {}
        public AllocMethod(int val)
            :base(Tags.AllocMethod, val) {}


        // Field Enumerations
        public const int AUTOMATIC = 1;
        public const int GUARANTOR = 2;
        public const int MANUAL = 3;
    }


    /// <summary>
    /// TradeID Field
    /// </summary>/
    public sealed class TradeID : StringField
    {
        public const int TAG = 1003;

        public TradeID()
            :base(Tags.TradeID) {}
        public TradeID(string val)
            :base(Tags.TradeID, val) {}

    }


    /// <summary>
    /// SideTradeReportID Field
    /// </summary>/
    public sealed class SideTradeReportID : StringField
    {
        public const int TAG = 1005;

        public SideTradeReportID()
            :base(Tags.SideTradeReportID) {}
        public SideTradeReportID(string val)
            :base(Tags.SideTradeReportID, val) {}

    }


    /// <summary>
    /// SideFillStationCd Field
    /// </summary>/
    public sealed class SideFillStationCd : StringField
    {
        public const int TAG = 1006;

        public SideFillStationCd()
            :base(Tags.SideFillStationCd) {}
        public SideFillStationCd(string val)
            :base(Tags.SideFillStationCd, val) {}

    }


    /// <summary>
    /// SideReasonCd Field
    /// </summary>/
    public sealed class SideReasonCd : StringField
    {
        public const int TAG = 1007;

        public SideReasonCd()
            :base(Tags.SideReasonCd) {}
        public SideReasonCd(string val)
            :base(Tags.SideReasonCd, val) {}

    }


    /// <summary>
    /// SideTrdSubTyp Field
    /// </summary>/
    public sealed class SideTrdSubTyp : IntField
    {
        public const int TAG = 1008;

        public SideTrdSubTyp()
            :base(Tags.SideTrdSubTyp) {}
        public SideTrdSubTyp(int val)
            :base(Tags.SideTrdSubTyp, val) {}


        // Field Enumerations
        public const int CMTA = 0;
        public const int INTERNAL_TRANSFER = 1;
        public const int EXTERNAL_TRANSFER = 2;
        public const int REJECT_FOR_SUBMITTING_TRADE = 3;
        public const int ADVISORY_FOR_CONTRA_SIDE = 4;
        public const int OFFSET_DUE_TO_AN_ALLOCATION = 5;
        public const int ONSET_DUE_TO_AN_ALLOCATION = 6;
        public const int DIFFERENTIAL_SPREAD = 7;
        public const int IMPLIED_SPREAD_LEG_EXECUTED_AGAINST_AN_OUTRIGHT = 8;
        public const int TRANSACTION_FROM_EXERCISE = 9;
        public const int TRANSACTION_FROM_ASSIGNMENT = 10;
    }


    /// <summary>
    /// SideQty Field
    /// </summary>/
    public sealed class SideQty : IntField
    {
        public const int TAG = 1009;

        public SideQty()
            :base(Tags.SideQty) {}
        public SideQty(int val)
            :base(Tags.SideQty, val) {}

    }


    /// <summary>
    /// MessageEventSource Field
    /// </summary>/
    public sealed class MessageEventSource : StringField
    {
        public const int TAG = 1011;

        public MessageEventSource()
            :base(Tags.MessageEventSource) {}
        public MessageEventSource(string val)
            :base(Tags.MessageEventSource, val) {}

    }


    /// <summary>
    /// SideTrdRegTimestamp Field
    /// </summary>/
    public sealed class SideTrdRegTimestamp : DateTimeField
    {
        public const int TAG = 1012;

        public SideTrdRegTimestamp()
            :base(Tags.SideTrdRegTimestamp) {}
        public SideTrdRegTimestamp(DateTime val)
            :base(Tags.SideTrdRegTimestamp, val) {}
        public SideTrdRegTimestamp(DateTime val, bool showMilliseconds)
            :base(Tags.SideTrdRegTimestamp, val, showMilliseconds) {}
		public SideTrdRegTimestamp(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.SideTrdRegTimestamp, val, precision) {}

    }


    /// <summary>
    /// SideTrdRegTimestampType Field
    /// </summary>/
    public sealed class SideTrdRegTimestampType : IntField
    {
        public const int TAG = 1013;

        public SideTrdRegTimestampType()
            :base(Tags.SideTrdRegTimestampType) {}
        public SideTrdRegTimestampType(int val)
            :base(Tags.SideTrdRegTimestampType, val) {}

    }


    /// <summary>
    /// SideTrdRegTimestampSrc Field
    /// </summary>/
    public sealed class SideTrdRegTimestampSrc : StringField
    {
        public const int TAG = 1014;

        public SideTrdRegTimestampSrc()
            :base(Tags.SideTrdRegTimestampSrc) {}
        public SideTrdRegTimestampSrc(string val)
            :base(Tags.SideTrdRegTimestampSrc, val) {}

    }


    /// <summary>
    /// AsOfIndicator Field
    /// </summary>/
    public sealed class AsOfIndicator : CharField
    {
        public const int TAG = 1015;

        public AsOfIndicator()
            :base(Tags.AsOfIndicator) {}
        public AsOfIndicator(char val)
            :base(Tags.AsOfIndicator, val) {}


        // Field Enumerations
        public const char FALSE = '0';
        public const char TRUE = '1';
    }


    /// <summary>
    /// NoSideTrdRegTS Field
    /// </summary>/
    public sealed class NoSideTrdRegTS : IntField
    {
        public const int TAG = 1016;

        public NoSideTrdRegTS()
            :base(Tags.NoSideTrdRegTS) {}
        public NoSideTrdRegTS(int val)
            :base(Tags.NoSideTrdRegTS, val) {}

    }


    /// <summary>
    /// LegOptionRatio Field
    /// </summary>/
    public sealed class LegOptionRatio : DecimalField
    {
        public const int TAG = 1017;

        public LegOptionRatio()
            :base(Tags.LegOptionRatio) {}
        public LegOptionRatio(Decimal val)
            :base(Tags.LegOptionRatio, val) {}

    }


    /// <summary>
    /// NoInstrumentParties Field
    /// </summary>/
    public sealed class NoInstrumentParties : IntField
    {
        public const int TAG = 1018;

        public NoInstrumentParties()
            :base(Tags.NoInstrumentParties) {}
        public NoInstrumentParties(int val)
            :base(Tags.NoInstrumentParties, val) {}

    }


    /// <summary>
    /// InstrumentPartyID Field
    /// </summary>/
    public sealed class InstrumentPartyID : StringField
    {
        public const int TAG = 1019;

        public InstrumentPartyID()
            :base(Tags.InstrumentPartyID) {}
        public InstrumentPartyID(string val)
            :base(Tags.InstrumentPartyID, val) {}

    }


    /// <summary>
    /// TradeVolume Field
    /// </summary>/
    public sealed class TradeVolume : DecimalField
    {
        public const int TAG = 1020;

        public TradeVolume()
            :base(Tags.TradeVolume) {}
        public TradeVolume(Decimal val)
            :base(Tags.TradeVolume, val) {}

    }


    /// <summary>
    /// MDBookType Field
    /// </summary>/
    public sealed class MDBookType : IntField
    {
        public const int TAG = 1021;

        public MDBookType()
            :base(Tags.MDBookType) {}
        public MDBookType(int val)
            :base(Tags.MDBookType, val) {}


        // Field Enumerations
        public const int TOP_OF_BOOK = 1;
        public const int PRICE_DEPTH = 2;
        public const int ORDER_DEPTH = 3;
    }


    /// <summary>
    /// MDFeedType Field
    /// </summary>/
    public sealed class MDFeedType : StringField
    {
        public const int TAG = 1022;

        public MDFeedType()
            :base(Tags.MDFeedType) {}
        public MDFeedType(string val)
            :base(Tags.MDFeedType, val) {}

    }


    /// <summary>
    /// MDPriceLevel Field
    /// </summary>/
    public sealed class MDPriceLevel : IntField
    {
        public const int TAG = 1023;

        public MDPriceLevel()
            :base(Tags.MDPriceLevel) {}
        public MDPriceLevel(int val)
            :base(Tags.MDPriceLevel, val) {}

    }


    /// <summary>
    /// MDOriginType Field
    /// </summary>/
    public sealed class MDOriginType : IntField
    {
        public const int TAG = 1024;

        public MDOriginType()
            :base(Tags.MDOriginType) {}
        public MDOriginType(int val)
            :base(Tags.MDOriginType, val) {}


        // Field Enumerations
        public const int BOOK = 0;
        public const int OFF_BOOK = 1;
        public const int CROSS = 2;
    }


    /// <summary>
    /// FirstPx Field
    /// </summary>/
    public sealed class FirstPx : DecimalField
    {
        public const int TAG = 1025;

        public FirstPx()
            :base(Tags.FirstPx) {}
        public FirstPx(Decimal val)
            :base(Tags.FirstPx, val) {}

    }


    /// <summary>
    /// MDEntrySpotRate Field
    /// </summary>/
    public sealed class MDEntrySpotRate : DecimalField
    {
        public const int TAG = 1026;

        public MDEntrySpotRate()
            :base(Tags.MDEntrySpotRate) {}
        public MDEntrySpotRate(Decimal val)
            :base(Tags.MDEntrySpotRate, val) {}

    }


    /// <summary>
    /// MDEntryForwardPoints Field
    /// </summary>/
    public sealed class MDEntryForwardPoints : DecimalField
    {
        public const int TAG = 1027;

        public MDEntryForwardPoints()
            :base(Tags.MDEntryForwardPoints) {}
        public MDEntryForwardPoints(Decimal val)
            :base(Tags.MDEntryForwardPoints, val) {}

    }


    /// <summary>
    /// ManualOrderIndicator Field
    /// </summary>/
    public sealed class ManualOrderIndicator : BooleanField
    {
        public const int TAG = 1028;

        public ManualOrderIndicator()
            :base(Tags.ManualOrderIndicator) {}
        public ManualOrderIndicator(Boolean val)
            :base(Tags.ManualOrderIndicator, val) {}

    }


    /// <summary>
    /// CustDirectedOrder Field
    /// </summary>/
    public sealed class CustDirectedOrder : BooleanField
    {
        public const int TAG = 1029;

        public CustDirectedOrder()
            :base(Tags.CustDirectedOrder) {}
        public CustDirectedOrder(Boolean val)
            :base(Tags.CustDirectedOrder, val) {}

    }


    /// <summary>
    /// ReceivedDeptID Field
    /// </summary>/
    public sealed class ReceivedDeptID : StringField
    {
        public const int TAG = 1030;

        public ReceivedDeptID()
            :base(Tags.ReceivedDeptID) {}
        public ReceivedDeptID(string val)
            :base(Tags.ReceivedDeptID, val) {}

    }


    /// <summary>
    /// CustOrderHandlingInst Field
    /// </summary>/
    public sealed class CustOrderHandlingInst : StringField
    {
        public const int TAG = 1031;

        public CustOrderHandlingInst()
            :base(Tags.CustOrderHandlingInst) {}
        public CustOrderHandlingInst(string val)
            :base(Tags.CustOrderHandlingInst, val) {}


        // Field Enumerations
        public const string ADD_ON_ORDER = "ADD";
        public const string ALL_OR_NONE = "AON";
        public const string CASH_NOT_HELD = "CNH";
        public const string DIRECTED_ORDER = "DIR";
        public const string EXCHANGE_FOR_PHYSICAL_TRANSACTION = "E.W";
        public const string FILL_OR_KILL = "FOK";
        public const string IMBALANCE_ONLY = "IO";
        public const string IMMEDIATE_OR_CANCEL = "IOC";
        public const string LIMIT_ON_OPEN = "LOO";
        public const string LIMIT_ON_CLOSE = "LOC";
        public const string MARKET_AT_OPEN = "MAO";
        public const string MARKET_AT_CLOSE = "MAC";
        public const string MARKET_ON_OPEN = "MOO";
        public const string MARKET_ON_CLOSE = "MOC";
        public const string MINIMUM_QUANTITY = "MQT";
        public const string NOT_HELD = "NH";
        public const string OVER_THE_DAY = "OVD";
        public const string PEGGED = "PEG";
        public const string RESERVE_SIZE_ORDER = "RSV";
        public const string STOP_STOCK_TRANSACTION = "S.W";
        public const string SCALE = "SCL";
        public const string TIME_ORDER = "TMO";
        public const string TRAILING_STOP = "TS";
        public const string WORK = "WRK";
    }


    /// <summary>
    /// OrderHandlingInstSource Field
    /// </summary>/
    public sealed class OrderHandlingInstSource : IntField
    {
        public const int TAG = 1032;

        public OrderHandlingInstSource()
            :base(Tags.OrderHandlingInstSource) {}
        public OrderHandlingInstSource(int val)
            :base(Tags.OrderHandlingInstSource, val) {}


        // Field Enumerations
        public const int NASD_OATS = 1;
    }


    /// <summary>
    /// DeskType Field
    /// </summary>/
    public sealed class DeskType : StringField
    {
        public const int TAG = 1033;

        public DeskType()
            :base(Tags.DeskType) {}
        public DeskType(string val)
            :base(Tags.DeskType, val) {}


        // Field Enumerations
        public const string AGENCY = "A";
        public const string ARBITRAGE = "AR";
        public const string DERIVATIVES = "D";
        public const string INTERNATIONAL = "IN";
        public const string INSTITUTIONAL = "IS";
        public const string OTHER = "O";
        public const string PREFERRED_TRADING = "PF";
        public const string PROPRIETARY = "PR";
        public const string PROGRAM_TRADING = "PT";
        public const string SALES = "S";
        public const string TRADING = "T";
    }


    /// <summary>
    /// DeskTypeSource Field
    /// </summary>/
    public sealed class DeskTypeSource : IntField
    {
        public const int TAG = 1034;

        public DeskTypeSource()
            :base(Tags.DeskTypeSource) {}
        public DeskTypeSource(int val)
            :base(Tags.DeskTypeSource, val) {}


        // Field Enumerations
        public const int NASD_OATS = 1;
    }


    /// <summary>
    /// DeskOrderHandlingInst Field
    /// </summary>/
    public sealed class DeskOrderHandlingInst : StringField
    {
        public const int TAG = 1035;

        public DeskOrderHandlingInst()
            :base(Tags.DeskOrderHandlingInst) {}
        public DeskOrderHandlingInst(string val)
            :base(Tags.DeskOrderHandlingInst, val) {}


        // Field Enumerations
        public const string ADD_ON_ORDER = "ADD";
        public const string ALL_OR_NONE = "AON";
        public const string CASH_NOT_HELD = "CNH";
        public const string DIRECTED_ORDER = "DIR";
        public const string EXCHANGE_FOR_PHYSICAL_TRANSACTION = "E.W";
        public const string FILL_OR_KILL = "FOK";
        public const string IMBALANCE_ONLY = "IO";
        public const string IMMEDIATE_OR_CANCEL = "IOC";
        public const string LIMIT_ON_OPEN = "LOO";
        public const string LIMIT_ON_CLOSE = "LOC";
        public const string MARKET_AT_OPEN = "MAO";
        public const string MARKET_AT_CLOSE = "MAC";
        public const string MARKET_ON_OPEN = "MOO";
        public const string MARKET_ON_CLOSE = "MOC";
        public const string MINIMUM_QUANTITY = "MQT";
        public const string NOT_HELD = "NH";
        public const string OVER_THE_DAY = "OVD";
        public const string PEGGED = "PEG";
        public const string RESERVE_SIZE_ORDER = "RSV";
        public const string STOP_STOCK_TRANSACTION = "S.W";
        public const string SCALE = "SCL";
        public const string TIME_ORDER = "TMO";
        public const string TRAILING_STOP = "TS";
        public const string WORK = "WRK";
    }


    /// <summary>
    /// ExecAckStatus Field
    /// </summary>/
    public sealed class ExecAckStatus : CharField
    {
        public const int TAG = 1036;

        public ExecAckStatus()
            :base(Tags.ExecAckStatus) {}
        public ExecAckStatus(char val)
            :base(Tags.ExecAckStatus, val) {}


        // Field Enumerations
        public const char RECEIVED_NOT_YET_PROCESSED = '0';
        public const char ACCEPTED = '1';
        public const char DONT_KNOW = '2';
    }


    /// <summary>
    /// UnderlyingDeliveryAmount Field
    /// </summary>/
    public sealed class UnderlyingDeliveryAmount : DecimalField
    {
        public const int TAG = 1037;

        public UnderlyingDeliveryAmount()
            :base(Tags.UnderlyingDeliveryAmount) {}
        public UnderlyingDeliveryAmount(Decimal val)
            :base(Tags.UnderlyingDeliveryAmount, val) {}

    }


    /// <summary>
    /// UnderlyingCapValue Field
    /// </summary>/
    public sealed class UnderlyingCapValue : DecimalField
    {
        public const int TAG = 1038;

        public UnderlyingCapValue()
            :base(Tags.UnderlyingCapValue) {}
        public UnderlyingCapValue(Decimal val)
            :base(Tags.UnderlyingCapValue, val) {}

    }


    /// <summary>
    /// UnderlyingSettlMethod Field
    /// </summary>/
    public sealed class UnderlyingSettlMethod : StringField
    {
        public const int TAG = 1039;

        public UnderlyingSettlMethod()
            :base(Tags.UnderlyingSettlMethod) {}
        public UnderlyingSettlMethod(string val)
            :base(Tags.UnderlyingSettlMethod, val) {}

    }


    /// <summary>
    /// SecondaryTradeID Field
    /// </summary>/
    public sealed class SecondaryTradeID : StringField
    {
        public const int TAG = 1040;

        public SecondaryTradeID()
            :base(Tags.SecondaryTradeID) {}
        public SecondaryTradeID(string val)
            :base(Tags.SecondaryTradeID, val) {}

    }


    /// <summary>
    /// FirmTradeID Field
    /// </summary>/
    public sealed class FirmTradeID : StringField
    {
        public const int TAG = 1041;

        public FirmTradeID()
            :base(Tags.FirmTradeID) {}
        public FirmTradeID(string val)
            :base(Tags.FirmTradeID, val) {}

    }


    /// <summary>
    /// SecondaryFirmTradeID Field
    /// </summary>/
    public sealed class SecondaryFirmTradeID : StringField
    {
        public const int TAG = 1042;

        public SecondaryFirmTradeID()
            :base(Tags.SecondaryFirmTradeID) {}
        public SecondaryFirmTradeID(string val)
            :base(Tags.SecondaryFirmTradeID, val) {}

    }


    /// <summary>
    /// CollApplType Field
    /// </summary>/
    public sealed class CollApplType : IntField
    {
        public const int TAG = 1043;

        public CollApplType()
            :base(Tags.CollApplType) {}
        public CollApplType(int val)
            :base(Tags.CollApplType, val) {}


        // Field Enumerations
        public const int SPECIFIC_DEPOSIT = 0;
        public const int GENERAL = 1;
    }


    /// <summary>
    /// UnderlyingAdjustedQuantity Field
    /// </summary>/
    public sealed class UnderlyingAdjustedQuantity : DecimalField
    {
        public const int TAG = 1044;

        public UnderlyingAdjustedQuantity()
            :base(Tags.UnderlyingAdjustedQuantity) {}
        public UnderlyingAdjustedQuantity(Decimal val)
            :base(Tags.UnderlyingAdjustedQuantity, val) {}

    }


    /// <summary>
    /// UnderlyingFXRate Field
    /// </summary>/
    public sealed class UnderlyingFXRate : DecimalField
    {
        public const int TAG = 1045;

        public UnderlyingFXRate()
            :base(Tags.UnderlyingFXRate) {}
        public UnderlyingFXRate(Decimal val)
            :base(Tags.UnderlyingFXRate, val) {}

    }


    /// <summary>
    /// UnderlyingFXRateCalc Field
    /// </summary>/
    public sealed class UnderlyingFXRateCalc : CharField
    {
        public const int TAG = 1046;

        public UnderlyingFXRateCalc()
            :base(Tags.UnderlyingFXRateCalc) {}
        public UnderlyingFXRateCalc(char val)
            :base(Tags.UnderlyingFXRateCalc, val) {}


        // Field Enumerations
        public const char MULTIPLY = 'M';
        public const char DIVIDE = 'D';
    }


    /// <summary>
    /// AllocPositionEffect Field
    /// </summary>/
    public sealed class AllocPositionEffect : CharField
    {
        public const int TAG = 1047;

        public AllocPositionEffect()
            :base(Tags.AllocPositionEffect) {}
        public AllocPositionEffect(char val)
            :base(Tags.AllocPositionEffect, val) {}


        // Field Enumerations
        public const char OPEN = 'O';
        public const char CLOSE = 'C';
        public const char ROLLED = 'R';
        public const char FIFO = 'F';
    }


    /// <summary>
    /// DealingCapacity Field
    /// </summary>/
    public sealed class DealingCapacity : CharField
    {
        public const int TAG = 1048;

        public DealingCapacity()
            :base(Tags.DealingCapacity) {}
        public DealingCapacity(char val)
            :base(Tags.DealingCapacity, val) {}


        // Field Enumerations
        public const char AGENT = 'A';
        public const char PRINCIPAL = 'P';
        public const char RISKLESS_PRINCIPAL = 'R';
    }


    /// <summary>
    /// InstrmtAssignmentMethod Field
    /// </summary>/
    public sealed class InstrmtAssignmentMethod : CharField
    {
        public const int TAG = 1049;

        public InstrmtAssignmentMethod()
            :base(Tags.InstrmtAssignmentMethod) {}
        public InstrmtAssignmentMethod(char val)
            :base(Tags.InstrmtAssignmentMethod, val) {}

    }


    /// <summary>
    /// InstrumentPartyIDSource Field
    /// </summary>/
    public sealed class InstrumentPartyIDSource : CharField
    {
        public const int TAG = 1050;

        public InstrumentPartyIDSource()
            :base(Tags.InstrumentPartyIDSource) {}
        public InstrumentPartyIDSource(char val)
            :base(Tags.InstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// InstrumentPartyRole Field
    /// </summary>/
    public sealed class InstrumentPartyRole : IntField
    {
        public const int TAG = 1051;

        public InstrumentPartyRole()
            :base(Tags.InstrumentPartyRole) {}
        public InstrumentPartyRole(int val)
            :base(Tags.InstrumentPartyRole, val) {}

    }


    /// <summary>
    /// NoInstrumentPartySubIDs Field
    /// </summary>/
    public sealed class NoInstrumentPartySubIDs : IntField
    {
        public const int TAG = 1052;

        public NoInstrumentPartySubIDs()
            :base(Tags.NoInstrumentPartySubIDs) {}
        public NoInstrumentPartySubIDs(int val)
            :base(Tags.NoInstrumentPartySubIDs, val) {}

    }


    /// <summary>
    /// InstrumentPartySubID Field
    /// </summary>/
    public sealed class InstrumentPartySubID : StringField
    {
        public const int TAG = 1053;

        public InstrumentPartySubID()
            :base(Tags.InstrumentPartySubID) {}
        public InstrumentPartySubID(string val)
            :base(Tags.InstrumentPartySubID, val) {}

    }


    /// <summary>
    /// InstrumentPartySubIDType Field
    /// </summary>/
    public sealed class InstrumentPartySubIDType : IntField
    {
        public const int TAG = 1054;

        public InstrumentPartySubIDType()
            :base(Tags.InstrumentPartySubIDType) {}
        public InstrumentPartySubIDType(int val)
            :base(Tags.InstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// PositionCurrency Field
    /// </summary>/
    public sealed class PositionCurrency : StringField
    {
        public const int TAG = 1055;

        public PositionCurrency()
            :base(Tags.PositionCurrency) {}
        public PositionCurrency(string val)
            :base(Tags.PositionCurrency, val) {}

    }


    /// <summary>
    /// CalculatedCcyLastQty Field
    /// </summary>/
    public sealed class CalculatedCcyLastQty : DecimalField
    {
        public const int TAG = 1056;

        public CalculatedCcyLastQty()
            :base(Tags.CalculatedCcyLastQty) {}
        public CalculatedCcyLastQty(Decimal val)
            :base(Tags.CalculatedCcyLastQty, val) {}

    }


    /// <summary>
    /// AggressorIndicator Field
    /// </summary>/
    public sealed class AggressorIndicator : BooleanField
    {
        public const int TAG = 1057;

        public AggressorIndicator()
            :base(Tags.AggressorIndicator) {}
        public AggressorIndicator(Boolean val)
            :base(Tags.AggressorIndicator, val) {}


        // Field Enumerations
        public const Boolean YES = true;
        public const Boolean NO = false;
    }


    /// <summary>
    /// NoUndlyInstrumentParties Field
    /// </summary>/
    public sealed class NoUndlyInstrumentParties : IntField
    {
        public const int TAG = 1058;

        public NoUndlyInstrumentParties()
            :base(Tags.NoUndlyInstrumentParties) {}
        public NoUndlyInstrumentParties(int val)
            :base(Tags.NoUndlyInstrumentParties, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyID Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyID : StringField
    {
        public const int TAG = 1059;

        public UndlyInstrumentPartyID()
            :base(Tags.UndlyInstrumentPartyID) {}
        public UndlyInstrumentPartyID(string val)
            :base(Tags.UndlyInstrumentPartyID, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyIDSource Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyIDSource : CharField
    {
        public const int TAG = 1060;

        public UndlyInstrumentPartyIDSource()
            :base(Tags.UndlyInstrumentPartyIDSource) {}
        public UndlyInstrumentPartyIDSource(char val)
            :base(Tags.UndlyInstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartyRole Field
    /// </summary>/
    public sealed class UndlyInstrumentPartyRole : IntField
    {
        public const int TAG = 1061;

        public UndlyInstrumentPartyRole()
            :base(Tags.UndlyInstrumentPartyRole) {}
        public UndlyInstrumentPartyRole(int val)
            :base(Tags.UndlyInstrumentPartyRole, val) {}

    }


    /// <summary>
    /// NoUndlyInstrumentPartySubIDs Field
    /// </summary>/
    public sealed class NoUndlyInstrumentPartySubIDs : IntField
    {
        public const int TAG = 1062;

        public NoUndlyInstrumentPartySubIDs()
            :base(Tags.NoUndlyInstrumentPartySubIDs) {}
        public NoUndlyInstrumentPartySubIDs(int val)
            :base(Tags.NoUndlyInstrumentPartySubIDs, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartySubID Field
    /// </summary>/
    public sealed class UndlyInstrumentPartySubID : StringField
    {
        public const int TAG = 1063;

        public UndlyInstrumentPartySubID()
            :base(Tags.UndlyInstrumentPartySubID) {}
        public UndlyInstrumentPartySubID(string val)
            :base(Tags.UndlyInstrumentPartySubID, val) {}

    }


    /// <summary>
    /// UndlyInstrumentPartySubIDType Field
    /// </summary>/
    public sealed class UndlyInstrumentPartySubIDType : IntField
    {
        public const int TAG = 1064;

        public UndlyInstrumentPartySubIDType()
            :base(Tags.UndlyInstrumentPartySubIDType) {}
        public UndlyInstrumentPartySubIDType(int val)
            :base(Tags.UndlyInstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// BidSwapPoints Field
    /// </summary>/
    public sealed class BidSwapPoints : DecimalField
    {
        public const int TAG = 1065;

        public BidSwapPoints()
            :base(Tags.BidSwapPoints) {}
        public BidSwapPoints(Decimal val)
            :base(Tags.BidSwapPoints, val) {}

    }


    /// <summary>
    /// OfferSwapPoints Field
    /// </summary>/
    public sealed class OfferSwapPoints : DecimalField
    {
        public const int TAG = 1066;

        public OfferSwapPoints()
            :base(Tags.OfferSwapPoints) {}
        public OfferSwapPoints(Decimal val)
            :base(Tags.OfferSwapPoints, val) {}

    }


    /// <summary>
    /// LegBidForwardPoints Field
    /// </summary>/
    public sealed class LegBidForwardPoints : DecimalField
    {
        public const int TAG = 1067;

        public LegBidForwardPoints()
            :base(Tags.LegBidForwardPoints) {}
        public LegBidForwardPoints(Decimal val)
            :base(Tags.LegBidForwardPoints, val) {}

    }


    /// <summary>
    /// LegOfferForwardPoints Field
    /// </summary>/
    public sealed class LegOfferForwardPoints : DecimalField
    {
        public const int TAG = 1068;

        public LegOfferForwardPoints()
            :base(Tags.LegOfferForwardPoints) {}
        public LegOfferForwardPoints(Decimal val)
            :base(Tags.LegOfferForwardPoints, val) {}

    }


    /// <summary>
    /// SwapPoints Field
    /// </summary>/
    public sealed class SwapPoints : DecimalField
    {
        public const int TAG = 1069;

        public SwapPoints()
            :base(Tags.SwapPoints) {}
        public SwapPoints(Decimal val)
            :base(Tags.SwapPoints, val) {}

    }


    /// <summary>
    /// MDQuoteType Field
    /// </summary>/
    public sealed class MDQuoteType : IntField
    {
        public const int TAG = 1070;

        public MDQuoteType()
            :base(Tags.MDQuoteType) {}
        public MDQuoteType(int val)
            :base(Tags.MDQuoteType, val) {}


        // Field Enumerations
        public const int INDICATIVE = 0;
        public const int TRADEABLE = 1;
        public const int RESTRICTED_TRADEABLE = 2;
        public const int COUNTER = 3;
        public const int INDICATIVE_AND_TRADEABLE = 4;
    }


    /// <summary>
    /// LastSwapPoints Field
    /// </summary>/
    public sealed class LastSwapPoints : DecimalField
    {
        public const int TAG = 1071;

        public LastSwapPoints()
            :base(Tags.LastSwapPoints) {}
        public LastSwapPoints(Decimal val)
            :base(Tags.LastSwapPoints, val) {}

    }


    /// <summary>
    /// SideGrossTradeAmt Field
    /// </summary>/
    public sealed class SideGrossTradeAmt : DecimalField
    {
        public const int TAG = 1072;

        public SideGrossTradeAmt()
            :base(Tags.SideGrossTradeAmt) {}
        public SideGrossTradeAmt(Decimal val)
            :base(Tags.SideGrossTradeAmt, val) {}

    }


    /// <summary>
    /// LegLastForwardPoints Field
    /// </summary>/
    public sealed class LegLastForwardPoints : DecimalField
    {
        public const int TAG = 1073;

        public LegLastForwardPoints()
            :base(Tags.LegLastForwardPoints) {}
        public LegLastForwardPoints(Decimal val)
            :base(Tags.LegLastForwardPoints, val) {}

    }


    /// <summary>
    /// LegCalculatedCcyLastQty Field
    /// </summary>/
    public sealed class LegCalculatedCcyLastQty : DecimalField
    {
        public const int TAG = 1074;

        public LegCalculatedCcyLastQty()
            :base(Tags.LegCalculatedCcyLastQty) {}
        public LegCalculatedCcyLastQty(Decimal val)
            :base(Tags.LegCalculatedCcyLastQty, val) {}

    }


    /// <summary>
    /// LegGrossTradeAmt Field
    /// </summary>/
    public sealed class LegGrossTradeAmt : DecimalField
    {
        public const int TAG = 1075;

        public LegGrossTradeAmt()
            :base(Tags.LegGrossTradeAmt) {}
        public LegGrossTradeAmt(Decimal val)
            :base(Tags.LegGrossTradeAmt, val) {}

    }


    /// <summary>
    /// MaturityTime Field
    /// </summary>/
    public sealed class MaturityTime : StringField
    {
        public const int TAG = 1079;

        public MaturityTime()
            :base(Tags.MaturityTime) {}
        public MaturityTime(string val)
            :base(Tags.MaturityTime, val) {}

    }


    /// <summary>
    /// RefOrderID Field
    /// </summary>/
    public sealed class RefOrderID : StringField
    {
        public const int TAG = 1080;

        public RefOrderID()
            :base(Tags.RefOrderID) {}
        public RefOrderID(string val)
            :base(Tags.RefOrderID, val) {}

    }


    /// <summary>
    /// RefOrderIDSource Field
    /// </summary>/
    public sealed class RefOrderIDSource : CharField
    {
        public const int TAG = 1081;

        public RefOrderIDSource()
            :base(Tags.RefOrderIDSource) {}
        public RefOrderIDSource(char val)
            :base(Tags.RefOrderIDSource, val) {}


        // Field Enumerations
        public const char SECONDARYORDERID = '0';
        public const char ORDERID = '1';
        public const char MDENTRYID = '2';
        public const char QUOTEENTRYID = '3';
        public const char ORIGINAL_ORDER_ID = '4';
        public const char SECONDARYORDEID = '0';
        public const char ORDEID = '1';
        public const char MENTRYID = '2';
        public const char QUOTENTRYID = '3';
    }


    /// <summary>
    /// SecondaryDisplayQty Field
    /// </summary>/
    public sealed class SecondaryDisplayQty : DecimalField
    {
        public const int TAG = 1082;

        public SecondaryDisplayQty()
            :base(Tags.SecondaryDisplayQty) {}
        public SecondaryDisplayQty(Decimal val)
            :base(Tags.SecondaryDisplayQty, val) {}

    }


    /// <summary>
    /// DisplayWhen Field
    /// </summary>/
    public sealed class DisplayWhen : CharField
    {
        public const int TAG = 1083;

        public DisplayWhen()
            :base(Tags.DisplayWhen) {}
        public DisplayWhen(char val)
            :base(Tags.DisplayWhen, val) {}


        // Field Enumerations
        public const char IMMEDIATE = '1';
        public const char EXHAUST = '2';
    }


    /// <summary>
    /// DisplayMethod Field
    /// </summary>/
    public sealed class DisplayMethod : CharField
    {
        public const int TAG = 1084;

        public DisplayMethod()
            :base(Tags.DisplayMethod) {}
        public DisplayMethod(char val)
            :base(Tags.DisplayMethod, val) {}


        // Field Enumerations
        public const char INITIAL = '1';
        public const char NEW = '2';
        public const char RANDOM = '3';
        public const char UNDISCLOSED = '4';
    }


    /// <summary>
    /// DisplayLowQty Field
    /// </summary>/
    public sealed class DisplayLowQty : DecimalField
    {
        public const int TAG = 1085;

        public DisplayLowQty()
            :base(Tags.DisplayLowQty) {}
        public DisplayLowQty(Decimal val)
            :base(Tags.DisplayLowQty, val) {}

    }


    /// <summary>
    /// DisplayHighQty Field
    /// </summary>/
    public sealed class DisplayHighQty : DecimalField
    {
        public const int TAG = 1086;

        public DisplayHighQty()
            :base(Tags.DisplayHighQty) {}
        public DisplayHighQty(Decimal val)
            :base(Tags.DisplayHighQty, val) {}

    }


    /// <summary>
    /// DisplayMinIncr Field
    /// </summary>/
    public sealed class DisplayMinIncr : DecimalField
    {
        public const int TAG = 1087;

        public DisplayMinIncr()
            :base(Tags.DisplayMinIncr) {}
        public DisplayMinIncr(Decimal val)
            :base(Tags.DisplayMinIncr, val) {}

    }


    /// <summary>
    /// RefreshQty Field
    /// </summary>/
    public sealed class RefreshQty : DecimalField
    {
        public const int TAG = 1088;

        public RefreshQty()
            :base(Tags.RefreshQty) {}
        public RefreshQty(Decimal val)
            :base(Tags.RefreshQty, val) {}

    }


    /// <summary>
    /// MatchIncrement Field
    /// </summary>/
    public sealed class MatchIncrement : DecimalField
    {
        public const int TAG = 1089;

        public MatchIncrement()
            :base(Tags.MatchIncrement) {}
        public MatchIncrement(Decimal val)
            :base(Tags.MatchIncrement, val) {}

    }


    /// <summary>
    /// MaxPriceLevels Field
    /// </summary>/
    public sealed class MaxPriceLevels : IntField
    {
        public const int TAG = 1090;

        public MaxPriceLevels()
            :base(Tags.MaxPriceLevels) {}
        public MaxPriceLevels(int val)
            :base(Tags.MaxPriceLevels, val) {}

    }


    /// <summary>
    /// PreTradeAnonymity Field
    /// </summary>/
    public sealed class PreTradeAnonymity : BooleanField
    {
        public const int TAG = 1091;

        public PreTradeAnonymity()
            :base(Tags.PreTradeAnonymity) {}
        public PreTradeAnonymity(Boolean val)
            :base(Tags.PreTradeAnonymity, val) {}

    }


    /// <summary>
    /// PriceProtectionScope Field
    /// </summary>/
    public sealed class PriceProtectionScope : CharField
    {
        public const int TAG = 1092;

        public PriceProtectionScope()
            :base(Tags.PriceProtectionScope) {}
        public PriceProtectionScope(char val)
            :base(Tags.PriceProtectionScope, val) {}


        // Field Enumerations
        public const char NONE = '0';
        public const char LOCAL = '1';
        public const char NATIONAL = '2';
        public const char GLOBAL = '3';
    }


    /// <summary>
    /// LotType Field
    /// </summary>/
    public sealed class LotType : CharField
    {
        public const int TAG = 1093;

        public LotType()
            :base(Tags.LotType) {}
        public LotType(char val)
            :base(Tags.LotType, val) {}


        // Field Enumerations
        public const char ODD_LOT = '1';
        public const char ROUND_LOT = '2';
        public const char BLOCK_LOT = '3';
        public const char ROUND_LOT_BASED_UPON_UNITOFMEASURE = '4';
    }


    /// <summary>
    /// PegPriceType Field
    /// </summary>/
    public sealed class PegPriceType : IntField
    {
        public const int TAG = 1094;

        public PegPriceType()
            :base(Tags.PegPriceType) {}
        public PegPriceType(int val)
            :base(Tags.PegPriceType, val) {}


        // Field Enumerations
        public const int LAST_PEG = 1;
        public const int MID_PRICE_PEG = 2;
        public const int OPENING_PEG = 3;
        public const int MARKET_PEG = 4;
        public const int PRIMARY_PEG = 5;
        public const int PEG_TO_VWAP = 7;
        public const int TRAILING_STOP_PEG = 8;
        public const int PEG_TO_LIMIT_PRICE = 9;
        public const int FIXED_PEG_TO_LOCAL_BEST_BID_OR_OFFER_AT_TIME_OF_ORDER = 6;
    }


    /// <summary>
    /// PeggedRefPrice Field
    /// </summary>/
    public sealed class PeggedRefPrice : DecimalField
    {
        public const int TAG = 1095;

        public PeggedRefPrice()
            :base(Tags.PeggedRefPrice) {}
        public PeggedRefPrice(Decimal val)
            :base(Tags.PeggedRefPrice, val) {}

    }


    /// <summary>
    /// PegSecurityIDSource Field
    /// </summary>/
    public sealed class PegSecurityIDSource : StringField
    {
        public const int TAG = 1096;

        public PegSecurityIDSource()
            :base(Tags.PegSecurityIDSource) {}
        public PegSecurityIDSource(string val)
            :base(Tags.PegSecurityIDSource, val) {}

    }


    /// <summary>
    /// PegSecurityID Field
    /// </summary>/
    public sealed class PegSecurityID : StringField
    {
        public const int TAG = 1097;

        public PegSecurityID()
            :base(Tags.PegSecurityID) {}
        public PegSecurityID(string val)
            :base(Tags.PegSecurityID, val) {}

    }


    /// <summary>
    /// PegSymbol Field
    /// </summary>/
    public sealed class PegSymbol : StringField
    {
        public const int TAG = 1098;

        public PegSymbol()
            :base(Tags.PegSymbol) {}
        public PegSymbol(string val)
            :base(Tags.PegSymbol, val) {}

    }


    /// <summary>
    /// PegSecurityDesc Field
    /// </summary>/
    public sealed class PegSecurityDesc : StringField
    {
        public const int TAG = 1099;

        public PegSecurityDesc()
            :base(Tags.PegSecurityDesc) {}
        public PegSecurityDesc(string val)
            :base(Tags.PegSecurityDesc, val) {}

    }


    /// <summary>
    /// TriggerType Field
    /// </summary>/
    public sealed class TriggerType : CharField
    {
        public const int TAG = 1100;

        public TriggerType()
            :base(Tags.TriggerType) {}
        public TriggerType(char val)
            :base(Tags.TriggerType, val) {}


        // Field Enumerations
        public const char PARTIAL_EXECUTION = '1';
        public const char SPECIFIED_TRADING_SESSION = '2';
        public const char NEXT_AUCTION = '3';
        public const char PRICE_MOVEMENT = '4';
    }


    /// <summary>
    /// TriggerAction Field
    /// </summary>/
    public sealed class TriggerAction : CharField
    {
        public const int TAG = 1101;

        public TriggerAction()
            :base(Tags.TriggerAction) {}
        public TriggerAction(char val)
            :base(Tags.TriggerAction, val) {}


        // Field Enumerations
        public const char ACTIVATE = '1';
        public const char MODIFY = '2';
        public const char CANCEL = '3';
    }


    /// <summary>
    /// TriggerPrice Field
    /// </summary>/
    public sealed class TriggerPrice : DecimalField
    {
        public const int TAG = 1102;

        public TriggerPrice()
            :base(Tags.TriggerPrice) {}
        public TriggerPrice(Decimal val)
            :base(Tags.TriggerPrice, val) {}

    }


    /// <summary>
    /// TriggerSymbol Field
    /// </summary>/
    public sealed class TriggerSymbol : StringField
    {
        public const int TAG = 1103;

        public TriggerSymbol()
            :base(Tags.TriggerSymbol) {}
        public TriggerSymbol(string val)
            :base(Tags.TriggerSymbol, val) {}

    }


    /// <summary>
    /// TriggerSecurityID Field
    /// </summary>/
    public sealed class TriggerSecurityID : StringField
    {
        public const int TAG = 1104;

        public TriggerSecurityID()
            :base(Tags.TriggerSecurityID) {}
        public TriggerSecurityID(string val)
            :base(Tags.TriggerSecurityID, val) {}

    }


    /// <summary>
    /// TriggerSecurityIDSource Field
    /// </summary>/
    public sealed class TriggerSecurityIDSource : StringField
    {
        public const int TAG = 1105;

        public TriggerSecurityIDSource()
            :base(Tags.TriggerSecurityIDSource) {}
        public TriggerSecurityIDSource(string val)
            :base(Tags.TriggerSecurityIDSource, val) {}

    }


    /// <summary>
    /// TriggerSecurityDesc Field
    /// </summary>/
    public sealed class TriggerSecurityDesc : StringField
    {
        public const int TAG = 1106;

        public TriggerSecurityDesc()
            :base(Tags.TriggerSecurityDesc) {}
        public TriggerSecurityDesc(string val)
            :base(Tags.TriggerSecurityDesc, val) {}

    }


    /// <summary>
    /// TriggerPriceType Field
    /// </summary>/
    public sealed class TriggerPriceType : CharField
    {
        public const int TAG = 1107;

        public TriggerPriceType()
            :base(Tags.TriggerPriceType) {}
        public TriggerPriceType(char val)
            :base(Tags.TriggerPriceType, val) {}


        // Field Enumerations
        public const char BEST_OFFER = '1';
        public const char LAST_TRADE = '2';
        public const char BEST_BID = '3';
        public const char BEST_BID_OR_LAST_TRADE = '4';
        public const char BEST_OFFER_OR_LAST_TRADE = '5';
        public const char BEST_MID = '6';
    }


    /// <summary>
    /// TriggerPriceTypeScope Field
    /// </summary>/
    public sealed class TriggerPriceTypeScope : CharField
    {
        public const int TAG = 1108;

        public TriggerPriceTypeScope()
            :base(Tags.TriggerPriceTypeScope) {}
        public TriggerPriceTypeScope(char val)
            :base(Tags.TriggerPriceTypeScope, val) {}


        // Field Enumerations
        public const char NONE = '0';
        public const char LOCAL = '1';
        public const char NATIONAL = '2';
        public const char GLOBAL = '3';
    }


    /// <summary>
    /// TriggerPriceDirection Field
    /// </summary>/
    public sealed class TriggerPriceDirection : CharField
    {
        public const int TAG = 1109;

        public TriggerPriceDirection()
            :base(Tags.TriggerPriceDirection) {}
        public TriggerPriceDirection(char val)
            :base(Tags.TriggerPriceDirection, val) {}


        // Field Enumerations
        public const char TRIGGER_IF_THE_PRICE_OF_THE_SPECIFIED_TYPE_GOES_UP_TO_OR_THROUGH_THE_SPECIFIED_TRIGGER_PRICE = 'U';
        public const char TRIGGER_IF_THE_PRICE_OF_THE_SPECIFIED_TYPE_GOES_DOWN_TO_OR_THROUGH_THE_SPECIFIED_TRIGGER_PRICE = 'D';
    }


    /// <summary>
    /// TriggerNewPrice Field
    /// </summary>/
    public sealed class TriggerNewPrice : DecimalField
    {
        public const int TAG = 1110;

        public TriggerNewPrice()
            :base(Tags.TriggerNewPrice) {}
        public TriggerNewPrice(Decimal val)
            :base(Tags.TriggerNewPrice, val) {}

    }


    /// <summary>
    /// TriggerOrderType Field
    /// </summary>/
    public sealed class TriggerOrderType : CharField
    {
        public const int TAG = 1111;

        public TriggerOrderType()
            :base(Tags.TriggerOrderType) {}
        public TriggerOrderType(char val)
            :base(Tags.TriggerOrderType, val) {}


        // Field Enumerations
        public const char MARKET = '1';
        public const char LIMIT = '2';
    }


    /// <summary>
    /// TriggerNewQty Field
    /// </summary>/
    public sealed class TriggerNewQty : DecimalField
    {
        public const int TAG = 1112;

        public TriggerNewQty()
            :base(Tags.TriggerNewQty) {}
        public TriggerNewQty(Decimal val)
            :base(Tags.TriggerNewQty, val) {}

    }


    /// <summary>
    /// TriggerTradingSessionID Field
    /// </summary>/
    public sealed class TriggerTradingSessionID : StringField
    {
        public const int TAG = 1113;

        public TriggerTradingSessionID()
            :base(Tags.TriggerTradingSessionID) {}
        public TriggerTradingSessionID(string val)
            :base(Tags.TriggerTradingSessionID, val) {}

    }


    /// <summary>
    /// TriggerTradingSessionSubID Field
    /// </summary>/
    public sealed class TriggerTradingSessionSubID : StringField
    {
        public const int TAG = 1114;

        public TriggerTradingSessionSubID()
            :base(Tags.TriggerTradingSessionSubID) {}
        public TriggerTradingSessionSubID(string val)
            :base(Tags.TriggerTradingSessionSubID, val) {}

    }


    /// <summary>
    /// OrderCategory Field
    /// </summary>/
    public sealed class OrderCategory : CharField
    {
        public const int TAG = 1115;

        public OrderCategory()
            :base(Tags.OrderCategory) {}
        public OrderCategory(char val)
            :base(Tags.OrderCategory, val) {}


        // Field Enumerations
        public const char ORDER = '1';
        public const char QUOTE = '2';
        public const char PRIVATELY_NEGOTIATED_TRADE = '3';
        public const char MULTILEG_ORDER = '4';
        public const char LINKED_ORDER = '5';
        public const char QUOTE_REQUEST = '6';
        public const char IMPLIED_ORDER = '7';
        public const char CROSS_ORDER = '8';
        public const char STREAMING_PRICE = '9';
    }


    /// <summary>
    /// NoRootPartyIDs Field
    /// </summary>/
    public sealed class NoRootPartyIDs : IntField
    {
        public const int TAG = 1116;

        public NoRootPartyIDs()
            :base(Tags.NoRootPartyIDs) {}
        public NoRootPartyIDs(int val)
            :base(Tags.NoRootPartyIDs, val) {}

    }


    /// <summary>
    /// RootPartyID Field
    /// </summary>/
    public sealed class RootPartyID : StringField
    {
        public const int TAG = 1117;

        public RootPartyID()
            :base(Tags.RootPartyID) {}
        public RootPartyID(string val)
            :base(Tags.RootPartyID, val) {}

    }


    /// <summary>
    /// RootPartyIDSource Field
    /// </summary>/
    public sealed class RootPartyIDSource : CharField
    {
        public const int TAG = 1118;

        public RootPartyIDSource()
            :base(Tags.RootPartyIDSource) {}
        public RootPartyIDSource(char val)
            :base(Tags.RootPartyIDSource, val) {}

    }


    /// <summary>
    /// RootPartyRole Field
    /// </summary>/
    public sealed class RootPartyRole : IntField
    {
        public const int TAG = 1119;

        public RootPartyRole()
            :base(Tags.RootPartyRole) {}
        public RootPartyRole(int val)
            :base(Tags.RootPartyRole, val) {}

    }


    /// <summary>
    /// NoRootPartySubIDs Field
    /// </summary>/
    public sealed class NoRootPartySubIDs : IntField
    {
        public const int TAG = 1120;

        public NoRootPartySubIDs()
            :base(Tags.NoRootPartySubIDs) {}
        public NoRootPartySubIDs(int val)
            :base(Tags.NoRootPartySubIDs, val) {}

    }


    /// <summary>
    /// RootPartySubID Field
    /// </summary>/
    public sealed class RootPartySubID : StringField
    {
        public const int TAG = 1121;

        public RootPartySubID()
            :base(Tags.RootPartySubID) {}
        public RootPartySubID(string val)
            :base(Tags.RootPartySubID, val) {}

    }


    /// <summary>
    /// RootPartySubIDType Field
    /// </summary>/
    public sealed class RootPartySubIDType : IntField
    {
        public const int TAG = 1122;

        public RootPartySubIDType()
            :base(Tags.RootPartySubIDType) {}
        public RootPartySubIDType(int val)
            :base(Tags.RootPartySubIDType, val) {}

    }


    /// <summary>
    /// TradeHandlingInstr Field
    /// </summary>/
    public sealed class TradeHandlingInstr : CharField
    {
        public const int TAG = 1123;

        public TradeHandlingInstr()
            :base(Tags.TradeHandlingInstr) {}
        public TradeHandlingInstr(char val)
            :base(Tags.TradeHandlingInstr, val) {}


        // Field Enumerations
        public const char TRADE_CONFIRMATION = '0';
        public const char TWO_PARTY_REPORT = '1';
        public const char ONE_PARTY_REPORT_FOR_MATCHING = '2';
        public const char ONE_PARTY_REPORT_FOR_PASS_THROUGH = '3';
        public const char AUTOMATED_FLOOR_ORDER_ROUTING = '4';
        public const char TWO_PARTY_REPORT_FOR_CLAIM = '5';
    }


    /// <summary>
    /// OrigTradeHandlingInstr Field
    /// </summary>/
    public sealed class OrigTradeHandlingInstr : CharField
    {
        public const int TAG = 1124;

        public OrigTradeHandlingInstr()
            :base(Tags.OrigTradeHandlingInstr) {}
        public OrigTradeHandlingInstr(char val)
            :base(Tags.OrigTradeHandlingInstr, val) {}

    }


    /// <summary>
    /// OrigTradeDate Field
    /// </summary>/
    public sealed class OrigTradeDate : StringField
    {
        public const int TAG = 1125;

        public OrigTradeDate()
            :base(Tags.OrigTradeDate) {}
        public OrigTradeDate(string val)
            :base(Tags.OrigTradeDate, val) {}

    }


    /// <summary>
    /// OrigTradeID Field
    /// </summary>/
    public sealed class OrigTradeID : StringField
    {
        public const int TAG = 1126;

        public OrigTradeID()
            :base(Tags.OrigTradeID) {}
        public OrigTradeID(string val)
            :base(Tags.OrigTradeID, val) {}

    }


    /// <summary>
    /// OrigSecondaryTradeID Field
    /// </summary>/
    public sealed class OrigSecondaryTradeID : StringField
    {
        public const int TAG = 1127;

        public OrigSecondaryTradeID()
            :base(Tags.OrigSecondaryTradeID) {}
        public OrigSecondaryTradeID(string val)
            :base(Tags.OrigSecondaryTradeID, val) {}

    }


    /// <summary>
    /// ApplVerID Field
    /// </summary>/
    public sealed class ApplVerID : StringField
    {
        public const int TAG = 1128;

        public ApplVerID()
            :base(Tags.ApplVerID) {}
        public ApplVerID(string val)
            :base(Tags.ApplVerID, val) {}


        // Field Enumerations
        public const string FIX27 = "0";
        public const string FIX30 = "1";
        public const string FIX40 = "2";
        public const string FIX41 = "3";
        public const string FIX42 = "4";
        public const string FIX43 = "5";
        public const string FIX44 = "6";
        public const string FIX50 = "7";
        public const string FIX50SP1 = "8";
        public const string FIX50SP2 = "9";
    }


    /// <summary>
    /// CstmApplVerID Field
    /// </summary>/
    public sealed class CstmApplVerID : StringField
    {
        public const int TAG = 1129;

        public CstmApplVerID()
            :base(Tags.CstmApplVerID) {}
        public CstmApplVerID(string val)
            :base(Tags.CstmApplVerID, val) {}

    }


    /// <summary>
    /// RefApplVerID Field
    /// </summary>/
    public sealed class RefApplVerID : StringField
    {
        public const int TAG = 1130;

        public RefApplVerID()
            :base(Tags.RefApplVerID) {}
        public RefApplVerID(string val)
            :base(Tags.RefApplVerID, val) {}

    }


    /// <summary>
    /// RefCstmApplVerID Field
    /// </summary>/
    public sealed class RefCstmApplVerID : StringField
    {
        public const int TAG = 1131;

        public RefCstmApplVerID()
            :base(Tags.RefCstmApplVerID) {}
        public RefCstmApplVerID(string val)
            :base(Tags.RefCstmApplVerID, val) {}

    }


    /// <summary>
    /// TZTransactTime Field
    /// </summary>/
    public sealed class TZTransactTime : DateTimeField
    {
        public const int TAG = 1132;

        public TZTransactTime()
            :base(Tags.TZTransactTime) {}
        public TZTransactTime(DateTime val)
            :base(Tags.TZTransactTime, val) {}
        public TZTransactTime(DateTime val, bool showMilliseconds)
            :base(Tags.TZTransactTime, val, showMilliseconds) {}
		public TZTransactTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.TZTransactTime, val, precision) {}

    }


    /// <summary>
    /// ExDestinationIDSource Field
    /// </summary>/
    public sealed class ExDestinationIDSource : CharField
    {
        public const int TAG = 1133;

        public ExDestinationIDSource()
            :base(Tags.ExDestinationIDSource) {}
        public ExDestinationIDSource(char val)
            :base(Tags.ExDestinationIDSource, val) {}


        // Field Enumerations
        public const char BIC = 'B';
        public const char GENERALLY_ACCEPTED_MARKET_PARTICIPANT_IDENTIFIER = 'C';
        public const char PROPRIETARY = 'D';
        public const char ISO_COUNTRY_CODE = 'E';
        public const char MIC = 'G';
    }


    /// <summary>
    /// ReportedPxDiff Field
    /// </summary>/
    public sealed class ReportedPxDiff : BooleanField
    {
        public const int TAG = 1134;

        public ReportedPxDiff()
            :base(Tags.ReportedPxDiff) {}
        public ReportedPxDiff(Boolean val)
            :base(Tags.ReportedPxDiff, val) {}

    }


    /// <summary>
    /// RptSys Field
    /// </summary>/
    public sealed class RptSys : StringField
    {
        public const int TAG = 1135;

        public RptSys()
            :base(Tags.RptSys) {}
        public RptSys(string val)
            :base(Tags.RptSys, val) {}

    }


    /// <summary>
    /// AllocClearingFeeIndicator Field
    /// </summary>/
    public sealed class AllocClearingFeeIndicator : StringField
    {
        public const int TAG = 1136;

        public AllocClearingFeeIndicator()
            :base(Tags.AllocClearingFeeIndicator) {}
        public AllocClearingFeeIndicator(string val)
            :base(Tags.AllocClearingFeeIndicator, val) {}

    }


    /// <summary>
    /// DefaultApplVerID Field
    /// </summary>/
    public sealed class DefaultApplVerID : StringField
    {
        public const int TAG = 1137;

        public DefaultApplVerID()
            :base(Tags.DefaultApplVerID) {}
        public DefaultApplVerID(string val)
            :base(Tags.DefaultApplVerID, val) {}

    }


    /// <summary>
    /// DisplayQty Field
    /// </summary>/
    public sealed class DisplayQty : DecimalField
    {
        public const int TAG = 1138;

        public DisplayQty()
            :base(Tags.DisplayQty) {}
        public DisplayQty(Decimal val)
            :base(Tags.DisplayQty, val) {}

    }


    /// <summary>
    /// ExchangeSpecialInstructions Field
    /// </summary>/
    public sealed class ExchangeSpecialInstructions : StringField
    {
        public const int TAG = 1139;

        public ExchangeSpecialInstructions()
            :base(Tags.ExchangeSpecialInstructions) {}
        public ExchangeSpecialInstructions(string val)
            :base(Tags.ExchangeSpecialInstructions, val) {}

    }


    /// <summary>
    /// SecurityStatus Field
    /// </summary>/
    public sealed class SecurityStatus : StringField
    {
        public const int TAG = 965;

        public SecurityStatus()
            :base(Tags.SecurityStatus) {}
        public SecurityStatus(string val)
            :base(Tags.SecurityStatus, val) {}


        // Field Enumerations
        public const string ACTIVE = "1";
        public const string INACTIVE = "2";
    }


    /// <summary>
    /// ExpirationQtyType Field
    /// </summary>/
    public sealed class ExpirationQtyType : IntField
    {
        public const int TAG = 982;

        public ExpirationQtyType()
            :base(Tags.ExpirationQtyType) {}
        public ExpirationQtyType(int val)
            :base(Tags.ExpirationQtyType, val) {}


        // Field Enumerations
        public const int AUTO_EXERCISE = 1;
        public const int NON_AUTO_EXERCISE = 2;
        public const int FINAL_WILL_BE_EXERCISED = 3;
        public const int CONTRARY_INTENTION = 4;
        public const int DIFFERENCE = 5;
    }


    /// <summary>
    /// MaxTradeVol Field
    /// </summary>/
    public sealed class MaxTradeVol : DecimalField
    {
        public const int TAG = 1140;

        public MaxTradeVol()
            :base(Tags.MaxTradeVol) {}
        public MaxTradeVol(Decimal val)
            :base(Tags.MaxTradeVol, val) {}

    }


    /// <summary>
    /// NoMDFeedTypes Field
    /// </summary>/
    public sealed class NoMDFeedTypes : IntField
    {
        public const int TAG = 1141;

        public NoMDFeedTypes()
            :base(Tags.NoMDFeedTypes) {}
        public NoMDFeedTypes(int val)
            :base(Tags.NoMDFeedTypes, val) {}

    }


    /// <summary>
    /// MatchAlgorithm Field
    /// </summary>/
    public sealed class MatchAlgorithm : StringField
    {
        public const int TAG = 1142;

        public MatchAlgorithm()
            :base(Tags.MatchAlgorithm) {}
        public MatchAlgorithm(string val)
            :base(Tags.MatchAlgorithm, val) {}

    }


    /// <summary>
    /// MaxPriceVariation Field
    /// </summary>/
    public sealed class MaxPriceVariation : DecimalField
    {
        public const int TAG = 1143;

        public MaxPriceVariation()
            :base(Tags.MaxPriceVariation) {}
        public MaxPriceVariation(Decimal val)
            :base(Tags.MaxPriceVariation, val) {}

    }


    /// <summary>
    /// ImpliedMarketIndicator Field
    /// </summary>/
    public sealed class ImpliedMarketIndicator : IntField
    {
        public const int TAG = 1144;

        public ImpliedMarketIndicator()
            :base(Tags.ImpliedMarketIndicator) {}
        public ImpliedMarketIndicator(int val)
            :base(Tags.ImpliedMarketIndicator, val) {}


        // Field Enumerations
        public const int NOT_IMPLIED = 0;
        public const int IMPLIED_IN = 1;
        public const int IMPLIED_OUT = 2;
        public const int BOTH_IMPLIED_IN_AND_IMPLIED_OUT = 3;
    }


    /// <summary>
    /// EventTime Field
    /// </summary>/
    public sealed class EventTime : DateTimeField
    {
        public const int TAG = 1145;

        public EventTime()
            :base(Tags.EventTime) {}
        public EventTime(DateTime val)
            :base(Tags.EventTime, val) {}
        public EventTime(DateTime val, bool showMilliseconds)
            :base(Tags.EventTime, val, showMilliseconds) {}
		public EventTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.EventTime, val, precision) {}

    }


    /// <summary>
    /// MinPriceIncrementAmount Field
    /// </summary>/
    public sealed class MinPriceIncrementAmount : DecimalField
    {
        public const int TAG = 1146;

        public MinPriceIncrementAmount()
            :base(Tags.MinPriceIncrementAmount) {}
        public MinPriceIncrementAmount(Decimal val)
            :base(Tags.MinPriceIncrementAmount, val) {}

    }


    /// <summary>
    /// UnitOfMeasureQty Field
    /// </summary>/
    public sealed class UnitOfMeasureQty : DecimalField
    {
        public const int TAG = 1147;

        public UnitOfMeasureQty()
            :base(Tags.UnitOfMeasureQty) {}
        public UnitOfMeasureQty(Decimal val)
            :base(Tags.UnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// LowLimitPrice Field
    /// </summary>/
    public sealed class LowLimitPrice : DecimalField
    {
        public const int TAG = 1148;

        public LowLimitPrice()
            :base(Tags.LowLimitPrice) {}
        public LowLimitPrice(Decimal val)
            :base(Tags.LowLimitPrice, val) {}

    }


    /// <summary>
    /// HighLimitPrice Field
    /// </summary>/
    public sealed class HighLimitPrice : DecimalField
    {
        public const int TAG = 1149;

        public HighLimitPrice()
            :base(Tags.HighLimitPrice) {}
        public HighLimitPrice(Decimal val)
            :base(Tags.HighLimitPrice, val) {}

    }


    /// <summary>
    /// TradingReferencePrice Field
    /// </summary>/
    public sealed class TradingReferencePrice : DecimalField
    {
        public const int TAG = 1150;

        public TradingReferencePrice()
            :base(Tags.TradingReferencePrice) {}
        public TradingReferencePrice(Decimal val)
            :base(Tags.TradingReferencePrice, val) {}

    }


    /// <summary>
    /// SecurityGroup Field
    /// </summary>/
    public sealed class SecurityGroup : StringField
    {
        public const int TAG = 1151;

        public SecurityGroup()
            :base(Tags.SecurityGroup) {}
        public SecurityGroup(string val)
            :base(Tags.SecurityGroup, val) {}

    }


    /// <summary>
    /// LegNumber Field
    /// </summary>/
    public sealed class LegNumber : IntField
    {
        public const int TAG = 1152;

        public LegNumber()
            :base(Tags.LegNumber) {}
        public LegNumber(int val)
            :base(Tags.LegNumber, val) {}

    }


    /// <summary>
    /// SettlementCycleNo Field
    /// </summary>/
    public sealed class SettlementCycleNo : IntField
    {
        public const int TAG = 1153;

        public SettlementCycleNo()
            :base(Tags.SettlementCycleNo) {}
        public SettlementCycleNo(int val)
            :base(Tags.SettlementCycleNo, val) {}

    }


    /// <summary>
    /// SideCurrency Field
    /// </summary>/
    public sealed class SideCurrency : StringField
    {
        public const int TAG = 1154;

        public SideCurrency()
            :base(Tags.SideCurrency) {}
        public SideCurrency(string val)
            :base(Tags.SideCurrency, val) {}

    }


    /// <summary>
    /// SideSettlCurrency Field
    /// </summary>/
    public sealed class SideSettlCurrency : StringField
    {
        public const int TAG = 1155;

        public SideSettlCurrency()
            :base(Tags.SideSettlCurrency) {}
        public SideSettlCurrency(string val)
            :base(Tags.SideSettlCurrency, val) {}

    }


    /// <summary>
    /// ApplExtID Field
    /// </summary>/
    public sealed class ApplExtID : IntField
    {
        public const int TAG = 1156;

        public ApplExtID()
            :base(Tags.ApplExtID) {}
        public ApplExtID(int val)
            :base(Tags.ApplExtID, val) {}

    }


    /// <summary>
    /// CcyAmt Field
    /// </summary>/
    public sealed class CcyAmt : DecimalField
    {
        public const int TAG = 1157;

        public CcyAmt()
            :base(Tags.CcyAmt) {}
        public CcyAmt(Decimal val)
            :base(Tags.CcyAmt, val) {}

    }


    /// <summary>
    /// NoSettlDetails Field
    /// </summary>/
    public sealed class NoSettlDetails : IntField
    {
        public const int TAG = 1158;

        public NoSettlDetails()
            :base(Tags.NoSettlDetails) {}
        public NoSettlDetails(int val)
            :base(Tags.NoSettlDetails, val) {}

    }


    /// <summary>
    /// SettlObligMode Field
    /// </summary>/
    public sealed class SettlObligMode : IntField
    {
        public const int TAG = 1159;

        public SettlObligMode()
            :base(Tags.SettlObligMode) {}
        public SettlObligMode(int val)
            :base(Tags.SettlObligMode, val) {}


        // Field Enumerations
        public const int PRELIMINARY = 1;
        public const int FINAL = 2;
    }


    /// <summary>
    /// SettlObligMsgID Field
    /// </summary>/
    public sealed class SettlObligMsgID : StringField
    {
        public const int TAG = 1160;

        public SettlObligMsgID()
            :base(Tags.SettlObligMsgID) {}
        public SettlObligMsgID(string val)
            :base(Tags.SettlObligMsgID, val) {}

    }


    /// <summary>
    /// SettlObligID Field
    /// </summary>/
    public sealed class SettlObligID : StringField
    {
        public const int TAG = 1161;

        public SettlObligID()
            :base(Tags.SettlObligID) {}
        public SettlObligID(string val)
            :base(Tags.SettlObligID, val) {}

    }


    /// <summary>
    /// SettlObligTransType Field
    /// </summary>/
    public sealed class SettlObligTransType : CharField
    {
        public const int TAG = 1162;

        public SettlObligTransType()
            :base(Tags.SettlObligTransType) {}
        public SettlObligTransType(char val)
            :base(Tags.SettlObligTransType, val) {}


        // Field Enumerations
        public const char CANCEL = 'C';
        public const char NEW = 'N';
        public const char REPLACE = 'R';
        public const char RESTATE = 'T';
    }


    /// <summary>
    /// SettlObligRefID Field
    /// </summary>/
    public sealed class SettlObligRefID : StringField
    {
        public const int TAG = 1163;

        public SettlObligRefID()
            :base(Tags.SettlObligRefID) {}
        public SettlObligRefID(string val)
            :base(Tags.SettlObligRefID, val) {}

    }


    /// <summary>
    /// SettlObligSource Field
    /// </summary>/
    public sealed class SettlObligSource : CharField
    {
        public const int TAG = 1164;

        public SettlObligSource()
            :base(Tags.SettlObligSource) {}
        public SettlObligSource(char val)
            :base(Tags.SettlObligSource, val) {}


        // Field Enumerations
        public const char INSTRUCTIONS_OF_BROKER = '1';
        public const char INSTRUCTIONS_FOR_INSTITUTION = '2';
        public const char INVESTOR = '3';
    }


    /// <summary>
    /// NoSettlOblig Field
    /// </summary>/
    public sealed class NoSettlOblig : IntField
    {
        public const int TAG = 1165;

        public NoSettlOblig()
            :base(Tags.NoSettlOblig) {}
        public NoSettlOblig(int val)
            :base(Tags.NoSettlOblig, val) {}

    }


    /// <summary>
    /// QuoteMsgID Field
    /// </summary>/
    public sealed class QuoteMsgID : StringField
    {
        public const int TAG = 1166;

        public QuoteMsgID()
            :base(Tags.QuoteMsgID) {}
        public QuoteMsgID(string val)
            :base(Tags.QuoteMsgID, val) {}

    }


    /// <summary>
    /// QuoteEntryStatus Field
    /// </summary>/
    public sealed class QuoteEntryStatus : IntField
    {
        public const int TAG = 1167;

        public QuoteEntryStatus()
            :base(Tags.QuoteEntryStatus) {}
        public QuoteEntryStatus(int val)
            :base(Tags.QuoteEntryStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int REJECTED = 5;
        public const int REMOVED_FROM_MARKET = 6;
        public const int EXPIRED = 7;
        public const int LOCKED_MARKET_WARNING = 12;
        public const int CROSS_MARKET_WARNING = 13;
        public const int CANCELED_DUE_TO_LOCK_MARKET = 14;
        public const int CANCELED_DUE_TO_CROSS_MARKET = 15;
        public const int ACTIVE = 16;
    }


    /// <summary>
    /// TotNoCxldQuotes Field
    /// </summary>/
    public sealed class TotNoCxldQuotes : IntField
    {
        public const int TAG = 1168;

        public TotNoCxldQuotes()
            :base(Tags.TotNoCxldQuotes) {}
        public TotNoCxldQuotes(int val)
            :base(Tags.TotNoCxldQuotes, val) {}

    }


    /// <summary>
    /// TotNoAccQuotes Field
    /// </summary>/
    public sealed class TotNoAccQuotes : IntField
    {
        public const int TAG = 1169;

        public TotNoAccQuotes()
            :base(Tags.TotNoAccQuotes) {}
        public TotNoAccQuotes(int val)
            :base(Tags.TotNoAccQuotes, val) {}

    }


    /// <summary>
    /// TotNoRejQuotes Field
    /// </summary>/
    public sealed class TotNoRejQuotes : IntField
    {
        public const int TAG = 1170;

        public TotNoRejQuotes()
            :base(Tags.TotNoRejQuotes) {}
        public TotNoRejQuotes(int val)
            :base(Tags.TotNoRejQuotes, val) {}

    }


    /// <summary>
    /// PrivateQuote Field
    /// </summary>/
    public sealed class PrivateQuote : BooleanField
    {
        public const int TAG = 1171;

        public PrivateQuote()
            :base(Tags.PrivateQuote) {}
        public PrivateQuote(Boolean val)
            :base(Tags.PrivateQuote, val) {}

    }


    /// <summary>
    /// RespondentType Field
    /// </summary>/
    public sealed class RespondentType : IntField
    {
        public const int TAG = 1172;

        public RespondentType()
            :base(Tags.RespondentType) {}
        public RespondentType(int val)
            :base(Tags.RespondentType, val) {}


        // Field Enumerations
        public const int ALL_MARKET_PARTICIPANTS = 1;
        public const int SPECIFIED_MARKET_PARTICIPANTS = 2;
        public const int ALL_MARKET_MAKERS = 3;
        public const int PRIMARY_MARKET_MAKER = 4;
    }


    /// <summary>
    /// MDSubBookType Field
    /// </summary>/
    public sealed class MDSubBookType : IntField
    {
        public const int TAG = 1173;

        public MDSubBookType()
            :base(Tags.MDSubBookType) {}
        public MDSubBookType(int val)
            :base(Tags.MDSubBookType, val) {}

    }


    /// <summary>
    /// SecurityTradingEvent Field
    /// </summary>/
    public sealed class SecurityTradingEvent : IntField
    {
        public const int TAG = 1174;

        public SecurityTradingEvent()
            :base(Tags.SecurityTradingEvent) {}
        public SecurityTradingEvent(int val)
            :base(Tags.SecurityTradingEvent, val) {}


        // Field Enumerations
        public const int ORDER_IMBALANCE_AUCTION_IS_EXTENDED = 1;
        public const int TRADING_RESUMES = 2;
        public const int PRICE_VOLATILITY_INTERRUPTION = 3;
        public const int CHANGE_OF_TRADING_SESSION = 4;
        public const int CHANGE_OF_TRADING_SUBSESSION = 5;
        public const int CHANGE_OF_SECURITY_TRADING_STATUS = 6;
        public const int CHANGE_OF_BOOK_TYPE = 7;
        public const int CHANGE_OF_MARKET_DEPTH = 8;
        public const int CHANGE_OF_SECURITY_STATUS = 6;
    }


    /// <summary>
    /// NoStatsIndicators Field
    /// </summary>/
    public sealed class NoStatsIndicators : IntField
    {
        public const int TAG = 1175;

        public NoStatsIndicators()
            :base(Tags.NoStatsIndicators) {}
        public NoStatsIndicators(int val)
            :base(Tags.NoStatsIndicators, val) {}

    }


    /// <summary>
    /// StatsType Field
    /// </summary>/
    public sealed class StatsType : IntField
    {
        public const int TAG = 1176;

        public StatsType()
            :base(Tags.StatsType) {}
        public StatsType(int val)
            :base(Tags.StatsType, val) {}


        // Field Enumerations
        public const int EXCHANGE_LAST = 1;
        public const int HIGH = 2;
        public const int AVERAGE_PRICE = 3;
        public const int TURNOVER = 4;
    }


    /// <summary>
    /// NoOfSecSizes Field
    /// </summary>/
    public sealed class NoOfSecSizes : IntField
    {
        public const int TAG = 1177;

        public NoOfSecSizes()
            :base(Tags.NoOfSecSizes) {}
        public NoOfSecSizes(int val)
            :base(Tags.NoOfSecSizes, val) {}

    }


    /// <summary>
    /// MDSecSizeType Field
    /// </summary>/
    public sealed class MDSecSizeType : IntField
    {
        public const int TAG = 1178;

        public MDSecSizeType()
            :base(Tags.MDSecSizeType) {}
        public MDSecSizeType(int val)
            :base(Tags.MDSecSizeType, val) {}


        // Field Enumerations
        public const int CUSTOMER = 1;
    }


    /// <summary>
    /// MDSecSize Field
    /// </summary>/
    public sealed class MDSecSize : DecimalField
    {
        public const int TAG = 1179;

        public MDSecSize()
            :base(Tags.MDSecSize) {}
        public MDSecSize(Decimal val)
            :base(Tags.MDSecSize, val) {}

    }


    /// <summary>
    /// ApplID Field
    /// </summary>/
    public sealed class ApplID : StringField
    {
        public const int TAG = 1180;

        public ApplID()
            :base(Tags.ApplID) {}
        public ApplID(string val)
            :base(Tags.ApplID, val) {}

    }


    /// <summary>
    /// ApplSeqNum Field
    /// </summary>/
    public sealed class ApplSeqNum : IntField
    {
        public const int TAG = 1181;

        public ApplSeqNum()
            :base(Tags.ApplSeqNum) {}
        public ApplSeqNum(int val)
            :base(Tags.ApplSeqNum, val) {}

    }


    /// <summary>
    /// ApplBegSeqNum Field
    /// </summary>/
    public sealed class ApplBegSeqNum : IntField
    {
        public const int TAG = 1182;

        public ApplBegSeqNum()
            :base(Tags.ApplBegSeqNum) {}
        public ApplBegSeqNum(int val)
            :base(Tags.ApplBegSeqNum, val) {}

    }


    /// <summary>
    /// ApplEndSeqNum Field
    /// </summary>/
    public sealed class ApplEndSeqNum : IntField
    {
        public const int TAG = 1183;

        public ApplEndSeqNum()
            :base(Tags.ApplEndSeqNum) {}
        public ApplEndSeqNum(int val)
            :base(Tags.ApplEndSeqNum, val) {}

    }


    /// <summary>
    /// SecurityXMLLen Field
    /// </summary>/
    public sealed class SecurityXMLLen : IntField
    {
        public const int TAG = 1184;

        public SecurityXMLLen()
            :base(Tags.SecurityXMLLen) {}
        public SecurityXMLLen(int val)
            :base(Tags.SecurityXMLLen, val) {}

    }


    /// <summary>
    /// SecurityXML Field
    /// </summary>/
    public sealed class SecurityXML : StringField
    {
        public const int TAG = 1185;

        public SecurityXML()
            :base(Tags.SecurityXML) {}
        public SecurityXML(string val)
            :base(Tags.SecurityXML, val) {}

    }


    /// <summary>
    /// SecurityXMLSchema Field
    /// </summary>/
    public sealed class SecurityXMLSchema : StringField
    {
        public const int TAG = 1186;

        public SecurityXMLSchema()
            :base(Tags.SecurityXMLSchema) {}
        public SecurityXMLSchema(string val)
            :base(Tags.SecurityXMLSchema, val) {}

    }


    /// <summary>
    /// RefreshIndicator Field
    /// </summary>/
    public sealed class RefreshIndicator : BooleanField
    {
        public const int TAG = 1187;

        public RefreshIndicator()
            :base(Tags.RefreshIndicator) {}
        public RefreshIndicator(Boolean val)
            :base(Tags.RefreshIndicator, val) {}

    }


    /// <summary>
    /// Volatility Field
    /// </summary>/
    public sealed class Volatility : DecimalField
    {
        public const int TAG = 1188;

        public Volatility()
            :base(Tags.Volatility) {}
        public Volatility(Decimal val)
            :base(Tags.Volatility, val) {}

    }


    /// <summary>
    /// TimeToExpiration Field
    /// </summary>/
    public sealed class TimeToExpiration : DecimalField
    {
        public const int TAG = 1189;

        public TimeToExpiration()
            :base(Tags.TimeToExpiration) {}
        public TimeToExpiration(Decimal val)
            :base(Tags.TimeToExpiration, val) {}

    }


    /// <summary>
    /// RiskFreeRate Field
    /// </summary>/
    public sealed class RiskFreeRate : DecimalField
    {
        public const int TAG = 1190;

        public RiskFreeRate()
            :base(Tags.RiskFreeRate) {}
        public RiskFreeRate(Decimal val)
            :base(Tags.RiskFreeRate, val) {}

    }


    /// <summary>
    /// PriceUnitOfMeasure Field
    /// </summary>/
    public sealed class PriceUnitOfMeasure : StringField
    {
        public const int TAG = 1191;

        public PriceUnitOfMeasure()
            :base(Tags.PriceUnitOfMeasure) {}
        public PriceUnitOfMeasure(string val)
            :base(Tags.PriceUnitOfMeasure, val) {}

    }


    /// <summary>
    /// PriceUnitOfMeasureQty Field
    /// </summary>/
    public sealed class PriceUnitOfMeasureQty : DecimalField
    {
        public const int TAG = 1192;

        public PriceUnitOfMeasureQty()
            :base(Tags.PriceUnitOfMeasureQty) {}
        public PriceUnitOfMeasureQty(Decimal val)
            :base(Tags.PriceUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// SettlMethod Field
    /// </summary>/
    public sealed class SettlMethod : CharField
    {
        public const int TAG = 1193;

        public SettlMethod()
            :base(Tags.SettlMethod) {}
        public SettlMethod(char val)
            :base(Tags.SettlMethod, val) {}


        // Field Enumerations
        public const char CASH_SETTLEMENT_REQUIRED = 'C';
        public const char PHYSICAL_SETTLEMENT_REQUIRED = 'P';
    }


    /// <summary>
    /// ExerciseStyle Field
    /// </summary>/
    public sealed class ExerciseStyle : IntField
    {
        public const int TAG = 1194;

        public ExerciseStyle()
            :base(Tags.ExerciseStyle) {}
        public ExerciseStyle(int val)
            :base(Tags.ExerciseStyle, val) {}


        // Field Enumerations
        public const int EUROPEAN = 0;
        public const int AMERICAN = 1;
        public const int BERMUDA = 2;
    }


    /// <summary>
    /// OptPayAmount Field
    /// </summary>/
    public sealed class OptPayAmount : DecimalField
    {
        public const int TAG = 1195;

        public OptPayAmount()
            :base(Tags.OptPayAmount) {}
        public OptPayAmount(Decimal val)
            :base(Tags.OptPayAmount, val) {}

    }


    /// <summary>
    /// PriceQuoteMethod Field
    /// </summary>/
    public sealed class PriceQuoteMethod : StringField
    {
        public const int TAG = 1196;

        public PriceQuoteMethod()
            :base(Tags.PriceQuoteMethod) {}
        public PriceQuoteMethod(string val)
            :base(Tags.PriceQuoteMethod, val) {}


        // Field Enumerations
        public const string STANDARD = "STD";
        public const string INDEX = "INX";
        public const string INTEREST_RATE_INDEX = "INT";
        public const string PERCENT_OF_PAR = "PCTPAR";
    }


    /// <summary>
    /// FuturesValuationMethod Field
    /// </summary>/
    public sealed class FuturesValuationMethod : StringField
    {
        public const int TAG = 1197;

        public FuturesValuationMethod()
            :base(Tags.FuturesValuationMethod) {}
        public FuturesValuationMethod(string val)
            :base(Tags.FuturesValuationMethod, val) {}


        // Field Enumerations
        public const string PREMIUM_STYLE = "EQTY";
        public const string FUTURES_STYLE_MARK_TO_MARKET = "FUT";
        public const string FUTURES_STYLE_WITH_AN_ATTACHED_CASH_ADJUSTMENT = "FUTDA";
    }


    /// <summary>
    /// ListMethod Field
    /// </summary>/
    public sealed class ListMethod : IntField
    {
        public const int TAG = 1198;

        public ListMethod()
            :base(Tags.ListMethod) {}
        public ListMethod(int val)
            :base(Tags.ListMethod, val) {}


        // Field Enumerations
        public const int PRE_LISTED_ONLY = 0;
        public const int USER_REQUESTED = 1;
    }


    /// <summary>
    /// CapPrice Field
    /// </summary>/
    public sealed class CapPrice : DecimalField
    {
        public const int TAG = 1199;

        public CapPrice()
            :base(Tags.CapPrice) {}
        public CapPrice(Decimal val)
            :base(Tags.CapPrice, val) {}

    }


    /// <summary>
    /// FloorPrice Field
    /// </summary>/
    public sealed class FloorPrice : DecimalField
    {
        public const int TAG = 1200;

        public FloorPrice()
            :base(Tags.FloorPrice) {}
        public FloorPrice(Decimal val)
            :base(Tags.FloorPrice, val) {}

    }


    /// <summary>
    /// NoStrikeRules Field
    /// </summary>/
    public sealed class NoStrikeRules : IntField
    {
        public const int TAG = 1201;

        public NoStrikeRules()
            :base(Tags.NoStrikeRules) {}
        public NoStrikeRules(int val)
            :base(Tags.NoStrikeRules, val) {}

    }


    /// <summary>
    /// StartStrikePxRange Field
    /// </summary>/
    public sealed class StartStrikePxRange : DecimalField
    {
        public const int TAG = 1202;

        public StartStrikePxRange()
            :base(Tags.StartStrikePxRange) {}
        public StartStrikePxRange(Decimal val)
            :base(Tags.StartStrikePxRange, val) {}

    }


    /// <summary>
    /// EndStrikePxRange Field
    /// </summary>/
    public sealed class EndStrikePxRange : DecimalField
    {
        public const int TAG = 1203;

        public EndStrikePxRange()
            :base(Tags.EndStrikePxRange) {}
        public EndStrikePxRange(Decimal val)
            :base(Tags.EndStrikePxRange, val) {}

    }


    /// <summary>
    /// StrikeIncrement Field
    /// </summary>/
    public sealed class StrikeIncrement : DecimalField
    {
        public const int TAG = 1204;

        public StrikeIncrement()
            :base(Tags.StrikeIncrement) {}
        public StrikeIncrement(Decimal val)
            :base(Tags.StrikeIncrement, val) {}

    }


    /// <summary>
    /// NoTickRules Field
    /// </summary>/
    public sealed class NoTickRules : IntField
    {
        public const int TAG = 1205;

        public NoTickRules()
            :base(Tags.NoTickRules) {}
        public NoTickRules(int val)
            :base(Tags.NoTickRules, val) {}

    }


    /// <summary>
    /// StartTickPriceRange Field
    /// </summary>/
    public sealed class StartTickPriceRange : DecimalField
    {
        public const int TAG = 1206;

        public StartTickPriceRange()
            :base(Tags.StartTickPriceRange) {}
        public StartTickPriceRange(Decimal val)
            :base(Tags.StartTickPriceRange, val) {}

    }


    /// <summary>
    /// EndTickPriceRange Field
    /// </summary>/
    public sealed class EndTickPriceRange : DecimalField
    {
        public const int TAG = 1207;

        public EndTickPriceRange()
            :base(Tags.EndTickPriceRange) {}
        public EndTickPriceRange(Decimal val)
            :base(Tags.EndTickPriceRange, val) {}

    }


    /// <summary>
    /// TickIncrement Field
    /// </summary>/
    public sealed class TickIncrement : DecimalField
    {
        public const int TAG = 1208;

        public TickIncrement()
            :base(Tags.TickIncrement) {}
        public TickIncrement(Decimal val)
            :base(Tags.TickIncrement, val) {}

    }


    /// <summary>
    /// TickRuleType Field
    /// </summary>/
    public sealed class TickRuleType : IntField
    {
        public const int TAG = 1209;

        public TickRuleType()
            :base(Tags.TickRuleType) {}
        public TickRuleType(int val)
            :base(Tags.TickRuleType, val) {}


        // Field Enumerations
        public const int REGULAR = 0;
        public const int VARIABLE = 1;
        public const int FIXED = 2;
        public const int TRADED_AS_A_SPREAD_LEG = 3;
        public const int SETTLED_AS_A_SPREAD_LEG = 4;
    }


    /// <summary>
    /// NestedInstrAttribType Field
    /// </summary>/
    public sealed class NestedInstrAttribType : IntField
    {
        public const int TAG = 1210;

        public NestedInstrAttribType()
            :base(Tags.NestedInstrAttribType) {}
        public NestedInstrAttribType(int val)
            :base(Tags.NestedInstrAttribType, val) {}

    }


    /// <summary>
    /// NestedInstrAttribValue Field
    /// </summary>/
    public sealed class NestedInstrAttribValue : StringField
    {
        public const int TAG = 1211;

        public NestedInstrAttribValue()
            :base(Tags.NestedInstrAttribValue) {}
        public NestedInstrAttribValue(string val)
            :base(Tags.NestedInstrAttribValue, val) {}

    }


    /// <summary>
    /// LegMaturityTime Field
    /// </summary>/
    public sealed class LegMaturityTime : StringField
    {
        public const int TAG = 1212;

        public LegMaturityTime()
            :base(Tags.LegMaturityTime) {}
        public LegMaturityTime(string val)
            :base(Tags.LegMaturityTime, val) {}

    }


    /// <summary>
    /// UnderlyingMaturityTime Field
    /// </summary>/
    public sealed class UnderlyingMaturityTime : StringField
    {
        public const int TAG = 1213;

        public UnderlyingMaturityTime()
            :base(Tags.UnderlyingMaturityTime) {}
        public UnderlyingMaturityTime(string val)
            :base(Tags.UnderlyingMaturityTime, val) {}

    }


    /// <summary>
    /// DerivativeSymbol Field
    /// </summary>/
    public sealed class DerivativeSymbol : StringField
    {
        public const int TAG = 1214;

        public DerivativeSymbol()
            :base(Tags.DerivativeSymbol) {}
        public DerivativeSymbol(string val)
            :base(Tags.DerivativeSymbol, val) {}

    }


    /// <summary>
    /// DerivativeSymbolSfx Field
    /// </summary>/
    public sealed class DerivativeSymbolSfx : StringField
    {
        public const int TAG = 1215;

        public DerivativeSymbolSfx()
            :base(Tags.DerivativeSymbolSfx) {}
        public DerivativeSymbolSfx(string val)
            :base(Tags.DerivativeSymbolSfx, val) {}

    }


    /// <summary>
    /// DerivativeSecurityID Field
    /// </summary>/
    public sealed class DerivativeSecurityID : StringField
    {
        public const int TAG = 1216;

        public DerivativeSecurityID()
            :base(Tags.DerivativeSecurityID) {}
        public DerivativeSecurityID(string val)
            :base(Tags.DerivativeSecurityID, val) {}

    }


    /// <summary>
    /// DerivativeSecurityIDSource Field
    /// </summary>/
    public sealed class DerivativeSecurityIDSource : StringField
    {
        public const int TAG = 1217;

        public DerivativeSecurityIDSource()
            :base(Tags.DerivativeSecurityIDSource) {}
        public DerivativeSecurityIDSource(string val)
            :base(Tags.DerivativeSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoDerivativeSecurityAltID Field
    /// </summary>/
    public sealed class NoDerivativeSecurityAltID : IntField
    {
        public const int TAG = 1218;

        public NoDerivativeSecurityAltID()
            :base(Tags.NoDerivativeSecurityAltID) {}
        public NoDerivativeSecurityAltID(int val)
            :base(Tags.NoDerivativeSecurityAltID, val) {}

    }


    /// <summary>
    /// DerivativeSecurityAltID Field
    /// </summary>/
    public sealed class DerivativeSecurityAltID : StringField
    {
        public const int TAG = 1219;

        public DerivativeSecurityAltID()
            :base(Tags.DerivativeSecurityAltID) {}
        public DerivativeSecurityAltID(string val)
            :base(Tags.DerivativeSecurityAltID, val) {}

    }


    /// <summary>
    /// DerivativeSecurityAltIDSource Field
    /// </summary>/
    public sealed class DerivativeSecurityAltIDSource : StringField
    {
        public const int TAG = 1220;

        public DerivativeSecurityAltIDSource()
            :base(Tags.DerivativeSecurityAltIDSource) {}
        public DerivativeSecurityAltIDSource(string val)
            :base(Tags.DerivativeSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// SecondaryLowLimitPrice Field
    /// </summary>/
    public sealed class SecondaryLowLimitPrice : DecimalField
    {
        public const int TAG = 1221;

        public SecondaryLowLimitPrice()
            :base(Tags.SecondaryLowLimitPrice) {}
        public SecondaryLowLimitPrice(Decimal val)
            :base(Tags.SecondaryLowLimitPrice, val) {}

    }


    /// <summary>
    /// MaturityRuleID Field
    /// </summary>/
    public sealed class MaturityRuleID : StringField
    {
        public const int TAG = 1222;

        public MaturityRuleID()
            :base(Tags.MaturityRuleID) {}
        public MaturityRuleID(string val)
            :base(Tags.MaturityRuleID, val) {}

    }


    /// <summary>
    /// StrikeRuleID Field
    /// </summary>/
    public sealed class StrikeRuleID : StringField
    {
        public const int TAG = 1223;

        public StrikeRuleID()
            :base(Tags.StrikeRuleID) {}
        public StrikeRuleID(string val)
            :base(Tags.StrikeRuleID, val) {}

    }


    /// <summary>
    /// LegUnitOfMeasureQty Field
    /// </summary>/
    public sealed class LegUnitOfMeasureQty : DecimalField
    {
        public const int TAG = 1224;

        public LegUnitOfMeasureQty()
            :base(Tags.LegUnitOfMeasureQty) {}
        public LegUnitOfMeasureQty(Decimal val)
            :base(Tags.LegUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// DerivativeOptPayAmount Field
    /// </summary>/
    public sealed class DerivativeOptPayAmount : DecimalField
    {
        public const int TAG = 1225;

        public DerivativeOptPayAmount()
            :base(Tags.DerivativeOptPayAmount) {}
        public DerivativeOptPayAmount(Decimal val)
            :base(Tags.DerivativeOptPayAmount, val) {}

    }


    /// <summary>
    /// EndMaturityMonthYear Field
    /// </summary>/
    public sealed class EndMaturityMonthYear : StringField
    {
        public const int TAG = 1226;

        public EndMaturityMonthYear()
            :base(Tags.EndMaturityMonthYear) {}
        public EndMaturityMonthYear(string val)
            :base(Tags.EndMaturityMonthYear, val) {}

    }


    /// <summary>
    /// ProductComplex Field
    /// </summary>/
    public sealed class ProductComplex : StringField
    {
        public const int TAG = 1227;

        public ProductComplex()
            :base(Tags.ProductComplex) {}
        public ProductComplex(string val)
            :base(Tags.ProductComplex, val) {}

    }


    /// <summary>
    /// DerivativeProductComplex Field
    /// </summary>/
    public sealed class DerivativeProductComplex : StringField
    {
        public const int TAG = 1228;

        public DerivativeProductComplex()
            :base(Tags.DerivativeProductComplex) {}
        public DerivativeProductComplex(string val)
            :base(Tags.DerivativeProductComplex, val) {}

    }


    /// <summary>
    /// MaturityMonthYearIncrement Field
    /// </summary>/
    public sealed class MaturityMonthYearIncrement : IntField
    {
        public const int TAG = 1229;

        public MaturityMonthYearIncrement()
            :base(Tags.MaturityMonthYearIncrement) {}
        public MaturityMonthYearIncrement(int val)
            :base(Tags.MaturityMonthYearIncrement, val) {}

    }


    /// <summary>
    /// SecondaryHighLimitPrice Field
    /// </summary>/
    public sealed class SecondaryHighLimitPrice : DecimalField
    {
        public const int TAG = 1230;

        public SecondaryHighLimitPrice()
            :base(Tags.SecondaryHighLimitPrice) {}
        public SecondaryHighLimitPrice(Decimal val)
            :base(Tags.SecondaryHighLimitPrice, val) {}

    }


    /// <summary>
    /// MinLotSize Field
    /// </summary>/
    public sealed class MinLotSize : DecimalField
    {
        public const int TAG = 1231;

        public MinLotSize()
            :base(Tags.MinLotSize) {}
        public MinLotSize(Decimal val)
            :base(Tags.MinLotSize, val) {}

    }


    /// <summary>
    /// NoExecInstRules Field
    /// </summary>/
    public sealed class NoExecInstRules : IntField
    {
        public const int TAG = 1232;

        public NoExecInstRules()
            :base(Tags.NoExecInstRules) {}
        public NoExecInstRules(int val)
            :base(Tags.NoExecInstRules, val) {}

    }


    /// <summary>
    /// NoLotTypeRules Field
    /// </summary>/
    public sealed class NoLotTypeRules : IntField
    {
        public const int TAG = 1234;

        public NoLotTypeRules()
            :base(Tags.NoLotTypeRules) {}
        public NoLotTypeRules(int val)
            :base(Tags.NoLotTypeRules, val) {}

    }


    /// <summary>
    /// NoMatchRules Field
    /// </summary>/
    public sealed class NoMatchRules : IntField
    {
        public const int TAG = 1235;

        public NoMatchRules()
            :base(Tags.NoMatchRules) {}
        public NoMatchRules(int val)
            :base(Tags.NoMatchRules, val) {}

    }


    /// <summary>
    /// NoMaturityRules Field
    /// </summary>/
    public sealed class NoMaturityRules : IntField
    {
        public const int TAG = 1236;

        public NoMaturityRules()
            :base(Tags.NoMaturityRules) {}
        public NoMaturityRules(int val)
            :base(Tags.NoMaturityRules, val) {}

    }


    /// <summary>
    /// NoOrdTypeRules Field
    /// </summary>/
    public sealed class NoOrdTypeRules : IntField
    {
        public const int TAG = 1237;

        public NoOrdTypeRules()
            :base(Tags.NoOrdTypeRules) {}
        public NoOrdTypeRules(int val)
            :base(Tags.NoOrdTypeRules, val) {}

    }


    /// <summary>
    /// NoTimeInForceRules Field
    /// </summary>/
    public sealed class NoTimeInForceRules : IntField
    {
        public const int TAG = 1239;

        public NoTimeInForceRules()
            :base(Tags.NoTimeInForceRules) {}
        public NoTimeInForceRules(int val)
            :base(Tags.NoTimeInForceRules, val) {}

    }


    /// <summary>
    /// SecondaryTradingReferencePrice Field
    /// </summary>/
    public sealed class SecondaryTradingReferencePrice : DecimalField
    {
        public const int TAG = 1240;

        public SecondaryTradingReferencePrice()
            :base(Tags.SecondaryTradingReferencePrice) {}
        public SecondaryTradingReferencePrice(Decimal val)
            :base(Tags.SecondaryTradingReferencePrice, val) {}

    }


    /// <summary>
    /// StartMaturityMonthYear Field
    /// </summary>/
    public sealed class StartMaturityMonthYear : StringField
    {
        public const int TAG = 1241;

        public StartMaturityMonthYear()
            :base(Tags.StartMaturityMonthYear) {}
        public StartMaturityMonthYear(string val)
            :base(Tags.StartMaturityMonthYear, val) {}

    }


    /// <summary>
    /// FlexProductEligibilityIndicator Field
    /// </summary>/
    public sealed class FlexProductEligibilityIndicator : BooleanField
    {
        public const int TAG = 1242;

        public FlexProductEligibilityIndicator()
            :base(Tags.FlexProductEligibilityIndicator) {}
        public FlexProductEligibilityIndicator(Boolean val)
            :base(Tags.FlexProductEligibilityIndicator, val) {}

    }


    /// <summary>
    /// DerivFlexProductEligibilityIndicator Field
    /// </summary>/
    public sealed class DerivFlexProductEligibilityIndicator : BooleanField
    {
        public const int TAG = 1243;

        public DerivFlexProductEligibilityIndicator()
            :base(Tags.DerivFlexProductEligibilityIndicator) {}
        public DerivFlexProductEligibilityIndicator(Boolean val)
            :base(Tags.DerivFlexProductEligibilityIndicator, val) {}

    }


    /// <summary>
    /// FlexibleIndicator Field
    /// </summary>/
    public sealed class FlexibleIndicator : BooleanField
    {
        public const int TAG = 1244;

        public FlexibleIndicator()
            :base(Tags.FlexibleIndicator) {}
        public FlexibleIndicator(Boolean val)
            :base(Tags.FlexibleIndicator, val) {}

    }


    /// <summary>
    /// TradingCurrency Field
    /// </summary>/
    public sealed class TradingCurrency : StringField
    {
        public const int TAG = 1245;

        public TradingCurrency()
            :base(Tags.TradingCurrency) {}
        public TradingCurrency(string val)
            :base(Tags.TradingCurrency, val) {}

    }


    /// <summary>
    /// DerivativeProduct Field
    /// </summary>/
    public sealed class DerivativeProduct : IntField
    {
        public const int TAG = 1246;

        public DerivativeProduct()
            :base(Tags.DerivativeProduct) {}
        public DerivativeProduct(int val)
            :base(Tags.DerivativeProduct, val) {}

    }


    /// <summary>
    /// DerivativeSecurityGroup Field
    /// </summary>/
    public sealed class DerivativeSecurityGroup : StringField
    {
        public const int TAG = 1247;

        public DerivativeSecurityGroup()
            :base(Tags.DerivativeSecurityGroup) {}
        public DerivativeSecurityGroup(string val)
            :base(Tags.DerivativeSecurityGroup, val) {}

    }


    /// <summary>
    /// DerivativeCFICode Field
    /// </summary>/
    public sealed class DerivativeCFICode : StringField
    {
        public const int TAG = 1248;

        public DerivativeCFICode()
            :base(Tags.DerivativeCFICode) {}
        public DerivativeCFICode(string val)
            :base(Tags.DerivativeCFICode, val) {}

    }


    /// <summary>
    /// DerivativeSecurityType Field
    /// </summary>/
    public sealed class DerivativeSecurityType : StringField
    {
        public const int TAG = 1249;

        public DerivativeSecurityType()
            :base(Tags.DerivativeSecurityType) {}
        public DerivativeSecurityType(string val)
            :base(Tags.DerivativeSecurityType, val) {}

    }


    /// <summary>
    /// DerivativeSecuritySubType Field
    /// </summary>/
    public sealed class DerivativeSecuritySubType : StringField
    {
        public const int TAG = 1250;

        public DerivativeSecuritySubType()
            :base(Tags.DerivativeSecuritySubType) {}
        public DerivativeSecuritySubType(string val)
            :base(Tags.DerivativeSecuritySubType, val) {}

    }


    /// <summary>
    /// DerivativeMaturityMonthYear Field
    /// </summary>/
    public sealed class DerivativeMaturityMonthYear : StringField
    {
        public const int TAG = 1251;

        public DerivativeMaturityMonthYear()
            :base(Tags.DerivativeMaturityMonthYear) {}
        public DerivativeMaturityMonthYear(string val)
            :base(Tags.DerivativeMaturityMonthYear, val) {}

    }


    /// <summary>
    /// DerivativeMaturityDate Field
    /// </summary>/
    public sealed class DerivativeMaturityDate : StringField
    {
        public const int TAG = 1252;

        public DerivativeMaturityDate()
            :base(Tags.DerivativeMaturityDate) {}
        public DerivativeMaturityDate(string val)
            :base(Tags.DerivativeMaturityDate, val) {}

    }


    /// <summary>
    /// DerivativeMaturityTime Field
    /// </summary>/
    public sealed class DerivativeMaturityTime : StringField
    {
        public const int TAG = 1253;

        public DerivativeMaturityTime()
            :base(Tags.DerivativeMaturityTime) {}
        public DerivativeMaturityTime(string val)
            :base(Tags.DerivativeMaturityTime, val) {}

    }


    /// <summary>
    /// DerivativeSettleOnOpenFlag Field
    /// </summary>/
    public sealed class DerivativeSettleOnOpenFlag : StringField
    {
        public const int TAG = 1254;

        public DerivativeSettleOnOpenFlag()
            :base(Tags.DerivativeSettleOnOpenFlag) {}
        public DerivativeSettleOnOpenFlag(string val)
            :base(Tags.DerivativeSettleOnOpenFlag, val) {}

    }


    /// <summary>
    /// DerivativeInstrmtAssignmentMethod Field
    /// </summary>/
    public sealed class DerivativeInstrmtAssignmentMethod : CharField
    {
        public const int TAG = 1255;

        public DerivativeInstrmtAssignmentMethod()
            :base(Tags.DerivativeInstrmtAssignmentMethod) {}
        public DerivativeInstrmtAssignmentMethod(char val)
            :base(Tags.DerivativeInstrmtAssignmentMethod, val) {}

    }


    /// <summary>
    /// DerivativeSecurityStatus Field
    /// </summary>/
    public sealed class DerivativeSecurityStatus : StringField
    {
        public const int TAG = 1256;

        public DerivativeSecurityStatus()
            :base(Tags.DerivativeSecurityStatus) {}
        public DerivativeSecurityStatus(string val)
            :base(Tags.DerivativeSecurityStatus, val) {}

    }


    /// <summary>
    /// DerivativeInstrRegistry Field
    /// </summary>/
    public sealed class DerivativeInstrRegistry : StringField
    {
        public const int TAG = 1257;

        public DerivativeInstrRegistry()
            :base(Tags.DerivativeInstrRegistry) {}
        public DerivativeInstrRegistry(string val)
            :base(Tags.DerivativeInstrRegistry, val) {}

    }


    /// <summary>
    /// DerivativeCountryOfIssue Field
    /// </summary>/
    public sealed class DerivativeCountryOfIssue : StringField
    {
        public const int TAG = 1258;

        public DerivativeCountryOfIssue()
            :base(Tags.DerivativeCountryOfIssue) {}
        public DerivativeCountryOfIssue(string val)
            :base(Tags.DerivativeCountryOfIssue, val) {}

    }


    /// <summary>
    /// DerivativeStateOrProvinceOfIssue Field
    /// </summary>/
    public sealed class DerivativeStateOrProvinceOfIssue : StringField
    {
        public const int TAG = 1259;

        public DerivativeStateOrProvinceOfIssue()
            :base(Tags.DerivativeStateOrProvinceOfIssue) {}
        public DerivativeStateOrProvinceOfIssue(string val)
            :base(Tags.DerivativeStateOrProvinceOfIssue, val) {}

    }


    /// <summary>
    /// DerivativeLocaleOfIssue Field
    /// </summary>/
    public sealed class DerivativeLocaleOfIssue : StringField
    {
        public const int TAG = 1260;

        public DerivativeLocaleOfIssue()
            :base(Tags.DerivativeLocaleOfIssue) {}
        public DerivativeLocaleOfIssue(string val)
            :base(Tags.DerivativeLocaleOfIssue, val) {}

    }


    /// <summary>
    /// DerivativeStrikePrice Field
    /// </summary>/
    public sealed class DerivativeStrikePrice : DecimalField
    {
        public const int TAG = 1261;

        public DerivativeStrikePrice()
            :base(Tags.DerivativeStrikePrice) {}
        public DerivativeStrikePrice(Decimal val)
            :base(Tags.DerivativeStrikePrice, val) {}

    }


    /// <summary>
    /// DerivativeStrikeCurrency Field
    /// </summary>/
    public sealed class DerivativeStrikeCurrency : StringField
    {
        public const int TAG = 1262;

        public DerivativeStrikeCurrency()
            :base(Tags.DerivativeStrikeCurrency) {}
        public DerivativeStrikeCurrency(string val)
            :base(Tags.DerivativeStrikeCurrency, val) {}

    }


    /// <summary>
    /// DerivativeStrikeMultiplier Field
    /// </summary>/
    public sealed class DerivativeStrikeMultiplier : DecimalField
    {
        public const int TAG = 1263;

        public DerivativeStrikeMultiplier()
            :base(Tags.DerivativeStrikeMultiplier) {}
        public DerivativeStrikeMultiplier(Decimal val)
            :base(Tags.DerivativeStrikeMultiplier, val) {}

    }


    /// <summary>
    /// DerivativeStrikeValue Field
    /// </summary>/
    public sealed class DerivativeStrikeValue : DecimalField
    {
        public const int TAG = 1264;

        public DerivativeStrikeValue()
            :base(Tags.DerivativeStrikeValue) {}
        public DerivativeStrikeValue(Decimal val)
            :base(Tags.DerivativeStrikeValue, val) {}

    }


    /// <summary>
    /// DerivativeOptAttribute Field
    /// </summary>/
    public sealed class DerivativeOptAttribute : CharField
    {
        public const int TAG = 1265;

        public DerivativeOptAttribute()
            :base(Tags.DerivativeOptAttribute) {}
        public DerivativeOptAttribute(char val)
            :base(Tags.DerivativeOptAttribute, val) {}

    }


    /// <summary>
    /// DerivativeContractMultiplier Field
    /// </summary>/
    public sealed class DerivativeContractMultiplier : DecimalField
    {
        public const int TAG = 1266;

        public DerivativeContractMultiplier()
            :base(Tags.DerivativeContractMultiplier) {}
        public DerivativeContractMultiplier(Decimal val)
            :base(Tags.DerivativeContractMultiplier, val) {}

    }


    /// <summary>
    /// DerivativeMinPriceIncrement Field
    /// </summary>/
    public sealed class DerivativeMinPriceIncrement : DecimalField
    {
        public const int TAG = 1267;

        public DerivativeMinPriceIncrement()
            :base(Tags.DerivativeMinPriceIncrement) {}
        public DerivativeMinPriceIncrement(Decimal val)
            :base(Tags.DerivativeMinPriceIncrement, val) {}

    }


    /// <summary>
    /// DerivativeMinPriceIncrementAmount Field
    /// </summary>/
    public sealed class DerivativeMinPriceIncrementAmount : DecimalField
    {
        public const int TAG = 1268;

        public DerivativeMinPriceIncrementAmount()
            :base(Tags.DerivativeMinPriceIncrementAmount) {}
        public DerivativeMinPriceIncrementAmount(Decimal val)
            :base(Tags.DerivativeMinPriceIncrementAmount, val) {}

    }


    /// <summary>
    /// DerivativeUnitOfMeasure Field
    /// </summary>/
    public sealed class DerivativeUnitOfMeasure : StringField
    {
        public const int TAG = 1269;

        public DerivativeUnitOfMeasure()
            :base(Tags.DerivativeUnitOfMeasure) {}
        public DerivativeUnitOfMeasure(string val)
            :base(Tags.DerivativeUnitOfMeasure, val) {}

    }


    /// <summary>
    /// DerivativeUnitOfMeasureQty Field
    /// </summary>/
    public sealed class DerivativeUnitOfMeasureQty : DecimalField
    {
        public const int TAG = 1270;

        public DerivativeUnitOfMeasureQty()
            :base(Tags.DerivativeUnitOfMeasureQty) {}
        public DerivativeUnitOfMeasureQty(Decimal val)
            :base(Tags.DerivativeUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// DerivativeTimeUnit Field
    /// </summary>/
    public sealed class DerivativeTimeUnit : StringField
    {
        public const int TAG = 1271;

        public DerivativeTimeUnit()
            :base(Tags.DerivativeTimeUnit) {}
        public DerivativeTimeUnit(string val)
            :base(Tags.DerivativeTimeUnit, val) {}

    }


    /// <summary>
    /// DerivativeSecurityExchange Field
    /// </summary>/
    public sealed class DerivativeSecurityExchange : StringField
    {
        public const int TAG = 1272;

        public DerivativeSecurityExchange()
            :base(Tags.DerivativeSecurityExchange) {}
        public DerivativeSecurityExchange(string val)
            :base(Tags.DerivativeSecurityExchange, val) {}

    }


    /// <summary>
    /// DerivativePositionLimit Field
    /// </summary>/
    public sealed class DerivativePositionLimit : IntField
    {
        public const int TAG = 1273;

        public DerivativePositionLimit()
            :base(Tags.DerivativePositionLimit) {}
        public DerivativePositionLimit(int val)
            :base(Tags.DerivativePositionLimit, val) {}

    }


    /// <summary>
    /// DerivativeNTPositionLimit Field
    /// </summary>/
    public sealed class DerivativeNTPositionLimit : IntField
    {
        public const int TAG = 1274;

        public DerivativeNTPositionLimit()
            :base(Tags.DerivativeNTPositionLimit) {}
        public DerivativeNTPositionLimit(int val)
            :base(Tags.DerivativeNTPositionLimit, val) {}

    }


    /// <summary>
    /// DerivativeIssuer Field
    /// </summary>/
    public sealed class DerivativeIssuer : StringField
    {
        public const int TAG = 1275;

        public DerivativeIssuer()
            :base(Tags.DerivativeIssuer) {}
        public DerivativeIssuer(string val)
            :base(Tags.DerivativeIssuer, val) {}

    }


    /// <summary>
    /// DerivativeIssueDate Field
    /// </summary>/
    public sealed class DerivativeIssueDate : StringField
    {
        public const int TAG = 1276;

        public DerivativeIssueDate()
            :base(Tags.DerivativeIssueDate) {}
        public DerivativeIssueDate(string val)
            :base(Tags.DerivativeIssueDate, val) {}

    }


    /// <summary>
    /// DerivativeEncodedIssuerLen Field
    /// </summary>/
    public sealed class DerivativeEncodedIssuerLen : IntField
    {
        public const int TAG = 1277;

        public DerivativeEncodedIssuerLen()
            :base(Tags.DerivativeEncodedIssuerLen) {}
        public DerivativeEncodedIssuerLen(int val)
            :base(Tags.DerivativeEncodedIssuerLen, val) {}

    }


    /// <summary>
    /// DerivativeEncodedIssuer Field
    /// </summary>/
    public sealed class DerivativeEncodedIssuer : StringField
    {
        public const int TAG = 1278;

        public DerivativeEncodedIssuer()
            :base(Tags.DerivativeEncodedIssuer) {}
        public DerivativeEncodedIssuer(string val)
            :base(Tags.DerivativeEncodedIssuer, val) {}

    }


    /// <summary>
    /// DerivativeSecurityDesc Field
    /// </summary>/
    public sealed class DerivativeSecurityDesc : StringField
    {
        public const int TAG = 1279;

        public DerivativeSecurityDesc()
            :base(Tags.DerivativeSecurityDesc) {}
        public DerivativeSecurityDesc(string val)
            :base(Tags.DerivativeSecurityDesc, val) {}

    }


    /// <summary>
    /// DerivativeEncodedSecurityDescLen Field
    /// </summary>/
    public sealed class DerivativeEncodedSecurityDescLen : IntField
    {
        public const int TAG = 1280;

        public DerivativeEncodedSecurityDescLen()
            :base(Tags.DerivativeEncodedSecurityDescLen) {}
        public DerivativeEncodedSecurityDescLen(int val)
            :base(Tags.DerivativeEncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// DerivativeEncodedSecurityDesc Field
    /// </summary>/
    public sealed class DerivativeEncodedSecurityDesc : StringField
    {
        public const int TAG = 1281;

        public DerivativeEncodedSecurityDesc()
            :base(Tags.DerivativeEncodedSecurityDesc) {}
        public DerivativeEncodedSecurityDesc(string val)
            :base(Tags.DerivativeEncodedSecurityDesc, val) {}

    }


    /// <summary>
    /// DerivativeSecurityXMLLen Field
    /// </summary>/
    public sealed class DerivativeSecurityXMLLen : IntField
    {
        public const int TAG = 1282;

        public DerivativeSecurityXMLLen()
            :base(Tags.DerivativeSecurityXMLLen) {}
        public DerivativeSecurityXMLLen(int val)
            :base(Tags.DerivativeSecurityXMLLen, val) {}

    }


    /// <summary>
    /// DerivativeSecurityXML Field
    /// </summary>/
    public sealed class DerivativeSecurityXML : StringField
    {
        public const int TAG = 1283;

        public DerivativeSecurityXML()
            :base(Tags.DerivativeSecurityXML) {}
        public DerivativeSecurityXML(string val)
            :base(Tags.DerivativeSecurityXML, val) {}

    }


    /// <summary>
    /// DerivativeSecurityXMLSchema Field
    /// </summary>/
    public sealed class DerivativeSecurityXMLSchema : StringField
    {
        public const int TAG = 1284;

        public DerivativeSecurityXMLSchema()
            :base(Tags.DerivativeSecurityXMLSchema) {}
        public DerivativeSecurityXMLSchema(string val)
            :base(Tags.DerivativeSecurityXMLSchema, val) {}

    }


    /// <summary>
    /// DerivativeContractSettlMonth Field
    /// </summary>/
    public sealed class DerivativeContractSettlMonth : StringField
    {
        public const int TAG = 1285;

        public DerivativeContractSettlMonth()
            :base(Tags.DerivativeContractSettlMonth) {}
        public DerivativeContractSettlMonth(string val)
            :base(Tags.DerivativeContractSettlMonth, val) {}

    }


    /// <summary>
    /// NoDerivativeEvents Field
    /// </summary>/
    public sealed class NoDerivativeEvents : IntField
    {
        public const int TAG = 1286;

        public NoDerivativeEvents()
            :base(Tags.NoDerivativeEvents) {}
        public NoDerivativeEvents(int val)
            :base(Tags.NoDerivativeEvents, val) {}

    }


    /// <summary>
    /// DerivativeEventType Field
    /// </summary>/
    public sealed class DerivativeEventType : IntField
    {
        public const int TAG = 1287;

        public DerivativeEventType()
            :base(Tags.DerivativeEventType) {}
        public DerivativeEventType(int val)
            :base(Tags.DerivativeEventType, val) {}

    }


    /// <summary>
    /// DerivativeEventDate Field
    /// </summary>/
    public sealed class DerivativeEventDate : StringField
    {
        public const int TAG = 1288;

        public DerivativeEventDate()
            :base(Tags.DerivativeEventDate) {}
        public DerivativeEventDate(string val)
            :base(Tags.DerivativeEventDate, val) {}

    }


    /// <summary>
    /// DerivativeEventTime Field
    /// </summary>/
    public sealed class DerivativeEventTime : DateTimeField
    {
        public const int TAG = 1289;

        public DerivativeEventTime()
            :base(Tags.DerivativeEventTime) {}
        public DerivativeEventTime(DateTime val)
            :base(Tags.DerivativeEventTime, val) {}
        public DerivativeEventTime(DateTime val, bool showMilliseconds)
            :base(Tags.DerivativeEventTime, val, showMilliseconds) {}
		public DerivativeEventTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.DerivativeEventTime, val, precision) {}

    }


    /// <summary>
    /// DerivativeEventPx Field
    /// </summary>/
    public sealed class DerivativeEventPx : DecimalField
    {
        public const int TAG = 1290;

        public DerivativeEventPx()
            :base(Tags.DerivativeEventPx) {}
        public DerivativeEventPx(Decimal val)
            :base(Tags.DerivativeEventPx, val) {}

    }


    /// <summary>
    /// DerivativeEventText Field
    /// </summary>/
    public sealed class DerivativeEventText : StringField
    {
        public const int TAG = 1291;

        public DerivativeEventText()
            :base(Tags.DerivativeEventText) {}
        public DerivativeEventText(string val)
            :base(Tags.DerivativeEventText, val) {}

    }


    /// <summary>
    /// NoDerivativeInstrumentParties Field
    /// </summary>/
    public sealed class NoDerivativeInstrumentParties : IntField
    {
        public const int TAG = 1292;

        public NoDerivativeInstrumentParties()
            :base(Tags.NoDerivativeInstrumentParties) {}
        public NoDerivativeInstrumentParties(int val)
            :base(Tags.NoDerivativeInstrumentParties, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartyID Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartyID : StringField
    {
        public const int TAG = 1293;

        public DerivativeInstrumentPartyID()
            :base(Tags.DerivativeInstrumentPartyID) {}
        public DerivativeInstrumentPartyID(string val)
            :base(Tags.DerivativeInstrumentPartyID, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartyIDSource Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartyIDSource : StringField
    {
        public const int TAG = 1294;

        public DerivativeInstrumentPartyIDSource()
            :base(Tags.DerivativeInstrumentPartyIDSource) {}
        public DerivativeInstrumentPartyIDSource(string val)
            :base(Tags.DerivativeInstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartyRole Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartyRole : IntField
    {
        public const int TAG = 1295;

        public DerivativeInstrumentPartyRole()
            :base(Tags.DerivativeInstrumentPartyRole) {}
        public DerivativeInstrumentPartyRole(int val)
            :base(Tags.DerivativeInstrumentPartyRole, val) {}

    }


    /// <summary>
    /// NoDerivativeInstrumentPartySubIDs Field
    /// </summary>/
    public sealed class NoDerivativeInstrumentPartySubIDs : IntField
    {
        public const int TAG = 1296;

        public NoDerivativeInstrumentPartySubIDs()
            :base(Tags.NoDerivativeInstrumentPartySubIDs) {}
        public NoDerivativeInstrumentPartySubIDs(int val)
            :base(Tags.NoDerivativeInstrumentPartySubIDs, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartySubID Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartySubID : StringField
    {
        public const int TAG = 1297;

        public DerivativeInstrumentPartySubID()
            :base(Tags.DerivativeInstrumentPartySubID) {}
        public DerivativeInstrumentPartySubID(string val)
            :base(Tags.DerivativeInstrumentPartySubID, val) {}

    }


    /// <summary>
    /// DerivativeInstrumentPartySubIDType Field
    /// </summary>/
    public sealed class DerivativeInstrumentPartySubIDType : IntField
    {
        public const int TAG = 1298;

        public DerivativeInstrumentPartySubIDType()
            :base(Tags.DerivativeInstrumentPartySubIDType) {}
        public DerivativeInstrumentPartySubIDType(int val)
            :base(Tags.DerivativeInstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// DerivativeExerciseStyle Field
    /// </summary>/
    public sealed class DerivativeExerciseStyle : CharField
    {
        public const int TAG = 1299;

        public DerivativeExerciseStyle()
            :base(Tags.DerivativeExerciseStyle) {}
        public DerivativeExerciseStyle(char val)
            :base(Tags.DerivativeExerciseStyle, val) {}

    }


    /// <summary>
    /// MarketSegmentID Field
    /// </summary>/
    public sealed class MarketSegmentID : StringField
    {
        public const int TAG = 1300;

        public MarketSegmentID()
            :base(Tags.MarketSegmentID) {}
        public MarketSegmentID(string val)
            :base(Tags.MarketSegmentID, val) {}

    }


    /// <summary>
    /// MarketID Field
    /// </summary>/
    public sealed class MarketID : StringField
    {
        public const int TAG = 1301;

        public MarketID()
            :base(Tags.MarketID) {}
        public MarketID(string val)
            :base(Tags.MarketID, val) {}

    }


    /// <summary>
    /// MaturityMonthYearIncrementUnits Field
    /// </summary>/
    public sealed class MaturityMonthYearIncrementUnits : IntField
    {
        public const int TAG = 1302;

        public MaturityMonthYearIncrementUnits()
            :base(Tags.MaturityMonthYearIncrementUnits) {}
        public MaturityMonthYearIncrementUnits(int val)
            :base(Tags.MaturityMonthYearIncrementUnits, val) {}


        // Field Enumerations
        public const int MONTHS = 0;
        public const int DAYS = 1;
        public const int WEEKS = 2;
        public const int YEARS = 3;
    }


    /// <summary>
    /// MaturityMonthYearFormat Field
    /// </summary>/
    public sealed class MaturityMonthYearFormat : IntField
    {
        public const int TAG = 1303;

        public MaturityMonthYearFormat()
            :base(Tags.MaturityMonthYearFormat) {}
        public MaturityMonthYearFormat(int val)
            :base(Tags.MaturityMonthYearFormat, val) {}


        // Field Enumerations
        public const int YEARMONTH_ONLY = 0;
        public const int YEARMONTHDAY = 1;
        public const int YEARMONTHWEEK = 2;
    }


    /// <summary>
    /// StrikeExerciseStyle Field
    /// </summary>/
    public sealed class StrikeExerciseStyle : IntField
    {
        public const int TAG = 1304;

        public StrikeExerciseStyle()
            :base(Tags.StrikeExerciseStyle) {}
        public StrikeExerciseStyle(int val)
            :base(Tags.StrikeExerciseStyle, val) {}

    }


    /// <summary>
    /// SecondaryPriceLimitType Field
    /// </summary>/
    public sealed class SecondaryPriceLimitType : IntField
    {
        public const int TAG = 1305;

        public SecondaryPriceLimitType()
            :base(Tags.SecondaryPriceLimitType) {}
        public SecondaryPriceLimitType(int val)
            :base(Tags.SecondaryPriceLimitType, val) {}

    }


    /// <summary>
    /// PriceLimitType Field
    /// </summary>/
    public sealed class PriceLimitType : IntField
    {
        public const int TAG = 1306;

        public PriceLimitType()
            :base(Tags.PriceLimitType) {}
        public PriceLimitType(int val)
            :base(Tags.PriceLimitType, val) {}


        // Field Enumerations
        public const int PRICE = 0;
        public const int TICKS = 1;
        public const int PERCENTAGE = 2;
    }


    /// <summary>
    /// DerivativeSecurityListRequestType Field
    /// </summary>/
    public sealed class DerivativeSecurityListRequestType : IntField
    {
        public const int TAG = 1307;

        public DerivativeSecurityListRequestType()
            :base(Tags.DerivativeSecurityListRequestType) {}
        public DerivativeSecurityListRequestType(int val)
            :base(Tags.DerivativeSecurityListRequestType, val) {}


        // Field Enumerations
        public const int SYMBOL = 0;
        public const int SECURITYTYPE_AND_OR_CFICODE = 1;
        public const int PRODUCT = 2;
        public const int TRADINGSESSIONID = 3;
        public const int ALL_SECURITIES = 4;
        public const int UNDELYINGSYMBOL = 5;
        public const int UNDERLYING_SECURITYTYPE_AND_OR_CFICODE = 6;
        public const int UNDERLYING_PRODUCT = 7;
        public const int MARKETID_OR_MARKETID_PLUS_MARKETSEGMENTID = 8;
    }


    /// <summary>
    /// ExecInstValue Field
    /// </summary>/
    public sealed class ExecInstValue : CharField
    {
        public const int TAG = 1308;

        public ExecInstValue()
            :base(Tags.ExecInstValue) {}
        public ExecInstValue(char val)
            :base(Tags.ExecInstValue, val) {}

    }


    /// <summary>
    /// NoTradingSessionRules Field
    /// </summary>/
    public sealed class NoTradingSessionRules : IntField
    {
        public const int TAG = 1309;

        public NoTradingSessionRules()
            :base(Tags.NoTradingSessionRules) {}
        public NoTradingSessionRules(int val)
            :base(Tags.NoTradingSessionRules, val) {}

    }


    /// <summary>
    /// NoMarketSegments Field
    /// </summary>/
    public sealed class NoMarketSegments : IntField
    {
        public const int TAG = 1310;

        public NoMarketSegments()
            :base(Tags.NoMarketSegments) {}
        public NoMarketSegments(int val)
            :base(Tags.NoMarketSegments, val) {}

    }


    /// <summary>
    /// NoDerivativeInstrAttrib Field
    /// </summary>/
    public sealed class NoDerivativeInstrAttrib : IntField
    {
        public const int TAG = 1311;

        public NoDerivativeInstrAttrib()
            :base(Tags.NoDerivativeInstrAttrib) {}
        public NoDerivativeInstrAttrib(int val)
            :base(Tags.NoDerivativeInstrAttrib, val) {}

    }


    /// <summary>
    /// NoNestedInstrAttrib Field
    /// </summary>/
    public sealed class NoNestedInstrAttrib : IntField
    {
        public const int TAG = 1312;

        public NoNestedInstrAttrib()
            :base(Tags.NoNestedInstrAttrib) {}
        public NoNestedInstrAttrib(int val)
            :base(Tags.NoNestedInstrAttrib, val) {}

    }


    /// <summary>
    /// DerivativeInstrAttribType Field
    /// </summary>/
    public sealed class DerivativeInstrAttribType : IntField
    {
        public const int TAG = 1313;

        public DerivativeInstrAttribType()
            :base(Tags.DerivativeInstrAttribType) {}
        public DerivativeInstrAttribType(int val)
            :base(Tags.DerivativeInstrAttribType, val) {}

    }


    /// <summary>
    /// DerivativeInstrAttribValue Field
    /// </summary>/
    public sealed class DerivativeInstrAttribValue : StringField
    {
        public const int TAG = 1314;

        public DerivativeInstrAttribValue()
            :base(Tags.DerivativeInstrAttribValue) {}
        public DerivativeInstrAttribValue(string val)
            :base(Tags.DerivativeInstrAttribValue, val) {}

    }


    /// <summary>
    /// DerivativePriceUnitOfMeasure Field
    /// </summary>/
    public sealed class DerivativePriceUnitOfMeasure : StringField
    {
        public const int TAG = 1315;

        public DerivativePriceUnitOfMeasure()
            :base(Tags.DerivativePriceUnitOfMeasure) {}
        public DerivativePriceUnitOfMeasure(string val)
            :base(Tags.DerivativePriceUnitOfMeasure, val) {}

    }


    /// <summary>
    /// DerivativePriceUnitOfMeasureQty Field
    /// </summary>/
    public sealed class DerivativePriceUnitOfMeasureQty : DecimalField
    {
        public const int TAG = 1316;

        public DerivativePriceUnitOfMeasureQty()
            :base(Tags.DerivativePriceUnitOfMeasureQty) {}
        public DerivativePriceUnitOfMeasureQty(Decimal val)
            :base(Tags.DerivativePriceUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// DerivativeSettlMethod Field
    /// </summary>/
    public sealed class DerivativeSettlMethod : CharField
    {
        public const int TAG = 1317;

        public DerivativeSettlMethod()
            :base(Tags.DerivativeSettlMethod) {}
        public DerivativeSettlMethod(char val)
            :base(Tags.DerivativeSettlMethod, val) {}

    }


    /// <summary>
    /// DerivativePriceQuoteMethod Field
    /// </summary>/
    public sealed class DerivativePriceQuoteMethod : StringField
    {
        public const int TAG = 1318;

        public DerivativePriceQuoteMethod()
            :base(Tags.DerivativePriceQuoteMethod) {}
        public DerivativePriceQuoteMethod(string val)
            :base(Tags.DerivativePriceQuoteMethod, val) {}

    }


    /// <summary>
    /// DerivativeFuturesValuationMethod Field
    /// </summary>/
    public sealed class DerivativeFuturesValuationMethod : StringField
    {
        public const int TAG = 1319;

        public DerivativeFuturesValuationMethod()
            :base(Tags.DerivativeFuturesValuationMethod) {}
        public DerivativeFuturesValuationMethod(string val)
            :base(Tags.DerivativeFuturesValuationMethod, val) {}

    }


    /// <summary>
    /// DerivativeListMethod Field
    /// </summary>/
    public sealed class DerivativeListMethod : IntField
    {
        public const int TAG = 1320;

        public DerivativeListMethod()
            :base(Tags.DerivativeListMethod) {}
        public DerivativeListMethod(int val)
            :base(Tags.DerivativeListMethod, val) {}

    }


    /// <summary>
    /// DerivativeCapPrice Field
    /// </summary>/
    public sealed class DerivativeCapPrice : DecimalField
    {
        public const int TAG = 1321;

        public DerivativeCapPrice()
            :base(Tags.DerivativeCapPrice) {}
        public DerivativeCapPrice(Decimal val)
            :base(Tags.DerivativeCapPrice, val) {}

    }


    /// <summary>
    /// DerivativeFloorPrice Field
    /// </summary>/
    public sealed class DerivativeFloorPrice : DecimalField
    {
        public const int TAG = 1322;

        public DerivativeFloorPrice()
            :base(Tags.DerivativeFloorPrice) {}
        public DerivativeFloorPrice(Decimal val)
            :base(Tags.DerivativeFloorPrice, val) {}

    }


    /// <summary>
    /// DerivativePutOrCall Field
    /// </summary>/
    public sealed class DerivativePutOrCall : IntField
    {
        public const int TAG = 1323;

        public DerivativePutOrCall()
            :base(Tags.DerivativePutOrCall) {}
        public DerivativePutOrCall(int val)
            :base(Tags.DerivativePutOrCall, val) {}

    }


    /// <summary>
    /// ListUpdateAction Field
    /// </summary>/
    public sealed class ListUpdateAction : CharField
    {
        public const int TAG = 1324;

        public ListUpdateAction()
            :base(Tags.ListUpdateAction) {}
        public ListUpdateAction(char val)
            :base(Tags.ListUpdateAction, val) {}

    }


    /// <summary>
    /// ParentMktSegmID Field
    /// </summary>/
    public sealed class ParentMktSegmID : StringField
    {
        public const int TAG = 1325;

        public ParentMktSegmID()
            :base(Tags.ParentMktSegmID) {}
        public ParentMktSegmID(string val)
            :base(Tags.ParentMktSegmID, val) {}

    }


    /// <summary>
    /// TradingSessionDesc Field
    /// </summary>/
    public sealed class TradingSessionDesc : StringField
    {
        public const int TAG = 1326;

        public TradingSessionDesc()
            :base(Tags.TradingSessionDesc) {}
        public TradingSessionDesc(string val)
            :base(Tags.TradingSessionDesc, val) {}

    }


    /// <summary>
    /// TradSesUpdateAction Field
    /// </summary>/
    public sealed class TradSesUpdateAction : CharField
    {
        public const int TAG = 1327;

        public TradSesUpdateAction()
            :base(Tags.TradSesUpdateAction) {}
        public TradSesUpdateAction(char val)
            :base(Tags.TradSesUpdateAction, val) {}

    }


    /// <summary>
    /// RejectText Field
    /// </summary>/
    public sealed class RejectText : StringField
    {
        public const int TAG = 1328;

        public RejectText()
            :base(Tags.RejectText) {}
        public RejectText(string val)
            :base(Tags.RejectText, val) {}

    }


    /// <summary>
    /// FeeMultiplier Field
    /// </summary>/
    public sealed class FeeMultiplier : DecimalField
    {
        public const int TAG = 1329;

        public FeeMultiplier()
            :base(Tags.FeeMultiplier) {}
        public FeeMultiplier(Decimal val)
            :base(Tags.FeeMultiplier, val) {}

    }


    /// <summary>
    /// UnderlyingLegSymbol Field
    /// </summary>/
    public sealed class UnderlyingLegSymbol : StringField
    {
        public const int TAG = 1330;

        public UnderlyingLegSymbol()
            :base(Tags.UnderlyingLegSymbol) {}
        public UnderlyingLegSymbol(string val)
            :base(Tags.UnderlyingLegSymbol, val) {}

    }


    /// <summary>
    /// UnderlyingLegSymbolSfx Field
    /// </summary>/
    public sealed class UnderlyingLegSymbolSfx : StringField
    {
        public const int TAG = 1331;

        public UnderlyingLegSymbolSfx()
            :base(Tags.UnderlyingLegSymbolSfx) {}
        public UnderlyingLegSymbolSfx(string val)
            :base(Tags.UnderlyingLegSymbolSfx, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityID Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityID : StringField
    {
        public const int TAG = 1332;

        public UnderlyingLegSecurityID()
            :base(Tags.UnderlyingLegSecurityID) {}
        public UnderlyingLegSecurityID(string val)
            :base(Tags.UnderlyingLegSecurityID, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityIDSource Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityIDSource : StringField
    {
        public const int TAG = 1333;

        public UnderlyingLegSecurityIDSource()
            :base(Tags.UnderlyingLegSecurityIDSource) {}
        public UnderlyingLegSecurityIDSource(string val)
            :base(Tags.UnderlyingLegSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoUnderlyingLegSecurityAltID Field
    /// </summary>/
    public sealed class NoUnderlyingLegSecurityAltID : IntField
    {
        public const int TAG = 1334;

        public NoUnderlyingLegSecurityAltID()
            :base(Tags.NoUnderlyingLegSecurityAltID) {}
        public NoUnderlyingLegSecurityAltID(int val)
            :base(Tags.NoUnderlyingLegSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityAltID Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityAltID : StringField
    {
        public const int TAG = 1335;

        public UnderlyingLegSecurityAltID()
            :base(Tags.UnderlyingLegSecurityAltID) {}
        public UnderlyingLegSecurityAltID(string val)
            :base(Tags.UnderlyingLegSecurityAltID, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityAltIDSource Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityAltIDSource : StringField
    {
        public const int TAG = 1336;

        public UnderlyingLegSecurityAltIDSource()
            :base(Tags.UnderlyingLegSecurityAltIDSource) {}
        public UnderlyingLegSecurityAltIDSource(string val)
            :base(Tags.UnderlyingLegSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityType Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityType : StringField
    {
        public const int TAG = 1337;

        public UnderlyingLegSecurityType()
            :base(Tags.UnderlyingLegSecurityType) {}
        public UnderlyingLegSecurityType(string val)
            :base(Tags.UnderlyingLegSecurityType, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecuritySubType Field
    /// </summary>/
    public sealed class UnderlyingLegSecuritySubType : StringField
    {
        public const int TAG = 1338;

        public UnderlyingLegSecuritySubType()
            :base(Tags.UnderlyingLegSecuritySubType) {}
        public UnderlyingLegSecuritySubType(string val)
            :base(Tags.UnderlyingLegSecuritySubType, val) {}

    }


    /// <summary>
    /// UnderlyingLegMaturityMonthYear Field
    /// </summary>/
    public sealed class UnderlyingLegMaturityMonthYear : StringField
    {
        public const int TAG = 1339;

        public UnderlyingLegMaturityMonthYear()
            :base(Tags.UnderlyingLegMaturityMonthYear) {}
        public UnderlyingLegMaturityMonthYear(string val)
            :base(Tags.UnderlyingLegMaturityMonthYear, val) {}

    }


    /// <summary>
    /// UnderlyingLegStrikePrice Field
    /// </summary>/
    public sealed class UnderlyingLegStrikePrice : DecimalField
    {
        public const int TAG = 1340;

        public UnderlyingLegStrikePrice()
            :base(Tags.UnderlyingLegStrikePrice) {}
        public UnderlyingLegStrikePrice(Decimal val)
            :base(Tags.UnderlyingLegStrikePrice, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityExchange Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityExchange : StringField
    {
        public const int TAG = 1341;

        public UnderlyingLegSecurityExchange()
            :base(Tags.UnderlyingLegSecurityExchange) {}
        public UnderlyingLegSecurityExchange(string val)
            :base(Tags.UnderlyingLegSecurityExchange, val) {}

    }


    /// <summary>
    /// NoOfLegUnderlyings Field
    /// </summary>/
    public sealed class NoOfLegUnderlyings : IntField
    {
        public const int TAG = 1342;

        public NoOfLegUnderlyings()
            :base(Tags.NoOfLegUnderlyings) {}
        public NoOfLegUnderlyings(int val)
            :base(Tags.NoOfLegUnderlyings, val) {}

    }


    /// <summary>
    /// UnderlyingLegPutOrCall Field
    /// </summary>/
    public sealed class UnderlyingLegPutOrCall : IntField
    {
        public const int TAG = 1343;

        public UnderlyingLegPutOrCall()
            :base(Tags.UnderlyingLegPutOrCall) {}
        public UnderlyingLegPutOrCall(int val)
            :base(Tags.UnderlyingLegPutOrCall, val) {}

    }


    /// <summary>
    /// UnderlyingLegCFICode Field
    /// </summary>/
    public sealed class UnderlyingLegCFICode : StringField
    {
        public const int TAG = 1344;

        public UnderlyingLegCFICode()
            :base(Tags.UnderlyingLegCFICode) {}
        public UnderlyingLegCFICode(string val)
            :base(Tags.UnderlyingLegCFICode, val) {}

    }


    /// <summary>
    /// UnderlyingLegMaturityDate Field
    /// </summary>/
    public sealed class UnderlyingLegMaturityDate : StringField
    {
        public const int TAG = 1345;

        public UnderlyingLegMaturityDate()
            :base(Tags.UnderlyingLegMaturityDate) {}
        public UnderlyingLegMaturityDate(string val)
            :base(Tags.UnderlyingLegMaturityDate, val) {}

    }


    /// <summary>
    /// ApplReqID Field
    /// </summary>/
    public sealed class ApplReqID : StringField
    {
        public const int TAG = 1346;

        public ApplReqID()
            :base(Tags.ApplReqID) {}
        public ApplReqID(string val)
            :base(Tags.ApplReqID, val) {}

    }


    /// <summary>
    /// ApplReqType Field
    /// </summary>/
    public sealed class ApplReqType : IntField
    {
        public const int TAG = 1347;

        public ApplReqType()
            :base(Tags.ApplReqType) {}
        public ApplReqType(int val)
            :base(Tags.ApplReqType, val) {}


        // Field Enumerations
        public const int RETRANSMISSION_OF_APPLICATION_MESSAGES_FOR_THE_SPECIFIED_APPLICATIONS = 0;
        public const int SUBSCRIPTION_TO_THE_SPECIFIED_APPLICATIONS = 1;
        public const int REQUEST_FOR_THE_LAST_APPLLASTSEQNUM_PUBLISHED_FOR_THE_SPECIFIED_APPLICATIONS = 2;
        public const int REQUEST_VALID_SET_OF_APPLICATIONS = 3;
        public const int UNSUBSCRIBE_TO_THE_SPECIFIED_APPLICATIONS = 4;
        public const int CANCEL_RETRANSMISSION = 5;
        public const int CANCEL_RETRANSMISSION_AND_UNSUBSCRIBE_TO_THE_SPECIFIED_APPLICATIONS = 6;
    }


    /// <summary>
    /// ApplResponseType Field
    /// </summary>/
    public sealed class ApplResponseType : IntField
    {
        public const int TAG = 1348;

        public ApplResponseType()
            :base(Tags.ApplResponseType) {}
        public ApplResponseType(int val)
            :base(Tags.ApplResponseType, val) {}


        // Field Enumerations
        public const int REQUEST_SUCCESSFULLY_PROCESSED = 0;
        public const int APPLICATION_DOES_NOT_EXIST = 1;
        public const int MESSAGES_NOT_AVAILABLE = 2;
    }


    /// <summary>
    /// ApplTotalMessageCount Field
    /// </summary>/
    public sealed class ApplTotalMessageCount : IntField
    {
        public const int TAG = 1349;

        public ApplTotalMessageCount()
            :base(Tags.ApplTotalMessageCount) {}
        public ApplTotalMessageCount(int val)
            :base(Tags.ApplTotalMessageCount, val) {}

    }


    /// <summary>
    /// ApplLastSeqNum Field
    /// </summary>/
    public sealed class ApplLastSeqNum : IntField
    {
        public const int TAG = 1350;

        public ApplLastSeqNum()
            :base(Tags.ApplLastSeqNum) {}
        public ApplLastSeqNum(int val)
            :base(Tags.ApplLastSeqNum, val) {}

    }


    /// <summary>
    /// NoApplIDs Field
    /// </summary>/
    public sealed class NoApplIDs : IntField
    {
        public const int TAG = 1351;

        public NoApplIDs()
            :base(Tags.NoApplIDs) {}
        public NoApplIDs(int val)
            :base(Tags.NoApplIDs, val) {}

    }


    /// <summary>
    /// ApplResendFlag Field
    /// </summary>/
    public sealed class ApplResendFlag : BooleanField
    {
        public const int TAG = 1352;

        public ApplResendFlag()
            :base(Tags.ApplResendFlag) {}
        public ApplResendFlag(Boolean val)
            :base(Tags.ApplResendFlag, val) {}

    }


    /// <summary>
    /// ApplResponseID Field
    /// </summary>/
    public sealed class ApplResponseID : StringField
    {
        public const int TAG = 1353;

        public ApplResponseID()
            :base(Tags.ApplResponseID) {}
        public ApplResponseID(string val)
            :base(Tags.ApplResponseID, val) {}

    }


    /// <summary>
    /// ApplResponseError Field
    /// </summary>/
    public sealed class ApplResponseError : IntField
    {
        public const int TAG = 1354;

        public ApplResponseError()
            :base(Tags.ApplResponseError) {}
        public ApplResponseError(int val)
            :base(Tags.ApplResponseError, val) {}


        // Field Enumerations
        public const int APPLICATION_DOES_NOT_EXIST = 0;
        public const int MESSAGES_REQUESTED_ARE_NOT_AVAILABLE = 1;
        public const int USER_NOT_AUTHORIZED_FOR_APPLICATION = 2;
    }


    /// <summary>
    /// RefApplID Field
    /// </summary>/
    public sealed class RefApplID : StringField
    {
        public const int TAG = 1355;

        public RefApplID()
            :base(Tags.RefApplID) {}
        public RefApplID(string val)
            :base(Tags.RefApplID, val) {}

    }


    /// <summary>
    /// ApplReportID Field
    /// </summary>/
    public sealed class ApplReportID : StringField
    {
        public const int TAG = 1356;

        public ApplReportID()
            :base(Tags.ApplReportID) {}
        public ApplReportID(string val)
            :base(Tags.ApplReportID, val) {}

    }


    /// <summary>
    /// RefApplLastSeqNum Field
    /// </summary>/
    public sealed class RefApplLastSeqNum : IntField
    {
        public const int TAG = 1357;

        public RefApplLastSeqNum()
            :base(Tags.RefApplLastSeqNum) {}
        public RefApplLastSeqNum(int val)
            :base(Tags.RefApplLastSeqNum, val) {}

    }


    /// <summary>
    /// LegPutOrCall Field
    /// </summary>/
    public sealed class LegPutOrCall : IntField
    {
        public const int TAG = 1358;

        public LegPutOrCall()
            :base(Tags.LegPutOrCall) {}
        public LegPutOrCall(int val)
            :base(Tags.LegPutOrCall, val) {}

    }


    /// <summary>
    /// EncodedSymbolLen Field
    /// </summary>/
    public sealed class EncodedSymbolLen : IntField
    {
        public const int TAG = 1359;

        public EncodedSymbolLen()
            :base(Tags.EncodedSymbolLen) {}
        public EncodedSymbolLen(int val)
            :base(Tags.EncodedSymbolLen, val) {}

    }


    /// <summary>
    /// EncodedSymbol Field
    /// </summary>/
    public sealed class EncodedSymbol : StringField
    {
        public const int TAG = 1360;

        public EncodedSymbol()
            :base(Tags.EncodedSymbol) {}
        public EncodedSymbol(string val)
            :base(Tags.EncodedSymbol, val) {}

    }


    /// <summary>
    /// TotNoFills Field
    /// </summary>/
    public sealed class TotNoFills : IntField
    {
        public const int TAG = 1361;

        public TotNoFills()
            :base(Tags.TotNoFills) {}
        public TotNoFills(int val)
            :base(Tags.TotNoFills, val) {}

    }


    /// <summary>
    /// NoFills Field
    /// </summary>/
    public sealed class NoFills : IntField
    {
        public const int TAG = 1362;

        public NoFills()
            :base(Tags.NoFills) {}
        public NoFills(int val)
            :base(Tags.NoFills, val) {}

    }


    /// <summary>
    /// FillExecID Field
    /// </summary>/
    public sealed class FillExecID : StringField
    {
        public const int TAG = 1363;

        public FillExecID()
            :base(Tags.FillExecID) {}
        public FillExecID(string val)
            :base(Tags.FillExecID, val) {}

    }


    /// <summary>
    /// FillPx Field
    /// </summary>/
    public sealed class FillPx : DecimalField
    {
        public const int TAG = 1364;

        public FillPx()
            :base(Tags.FillPx) {}
        public FillPx(Decimal val)
            :base(Tags.FillPx, val) {}

    }


    /// <summary>
    /// FillQty Field
    /// </summary>/
    public sealed class FillQty : DecimalField
    {
        public const int TAG = 1365;

        public FillQty()
            :base(Tags.FillQty) {}
        public FillQty(Decimal val)
            :base(Tags.FillQty, val) {}

    }


    /// <summary>
    /// LegAllocID Field
    /// </summary>/
    public sealed class LegAllocID : StringField
    {
        public const int TAG = 1366;

        public LegAllocID()
            :base(Tags.LegAllocID) {}
        public LegAllocID(string val)
            :base(Tags.LegAllocID, val) {}

    }


    /// <summary>
    /// LegAllocSettlCurrency Field
    /// </summary>/
    public sealed class LegAllocSettlCurrency : StringField
    {
        public const int TAG = 1367;

        public LegAllocSettlCurrency()
            :base(Tags.LegAllocSettlCurrency) {}
        public LegAllocSettlCurrency(string val)
            :base(Tags.LegAllocSettlCurrency, val) {}

    }


    /// <summary>
    /// TradSesEvent Field
    /// </summary>/
    public sealed class TradSesEvent : IntField
    {
        public const int TAG = 1368;

        public TradSesEvent()
            :base(Tags.TradSesEvent) {}
        public TradSesEvent(int val)
            :base(Tags.TradSesEvent, val) {}


        // Field Enumerations
        public const int TRADING_RESUMES = 0;
        public const int CHANGE_OF_TRADING_SESSION = 1;
        public const int CHANGE_OF_TRADING_SUBSESSION = 2;
        public const int CHANGE_OF_TRADING_STATUS = 3;
    }


    /// <summary>
    /// MassActionReportID Field
    /// </summary>/
    public sealed class MassActionReportID : StringField
    {
        public const int TAG = 1369;

        public MassActionReportID()
            :base(Tags.MassActionReportID) {}
        public MassActionReportID(string val)
            :base(Tags.MassActionReportID, val) {}

    }


    /// <summary>
    /// NoNotAffectedOrders Field
    /// </summary>/
    public sealed class NoNotAffectedOrders : IntField
    {
        public const int TAG = 1370;

        public NoNotAffectedOrders()
            :base(Tags.NoNotAffectedOrders) {}
        public NoNotAffectedOrders(int val)
            :base(Tags.NoNotAffectedOrders, val) {}

    }


    /// <summary>
    /// NotAffectedOrderID Field
    /// </summary>/
    public sealed class NotAffectedOrderID : StringField
    {
        public const int TAG = 1371;

        public NotAffectedOrderID()
            :base(Tags.NotAffectedOrderID) {}
        public NotAffectedOrderID(string val)
            :base(Tags.NotAffectedOrderID, val) {}

    }


    /// <summary>
    /// NotAffOrigClOrdID Field
    /// </summary>/
    public sealed class NotAffOrigClOrdID : StringField
    {
        public const int TAG = 1372;

        public NotAffOrigClOrdID()
            :base(Tags.NotAffOrigClOrdID) {}
        public NotAffOrigClOrdID(string val)
            :base(Tags.NotAffOrigClOrdID, val) {}

    }


    /// <summary>
    /// MassActionType Field
    /// </summary>/
    public sealed class MassActionType : IntField
    {
        public const int TAG = 1373;

        public MassActionType()
            :base(Tags.MassActionType) {}
        public MassActionType(int val)
            :base(Tags.MassActionType, val) {}


        // Field Enumerations
        public const int SUSPEND_ORDERS = 1;
        public const int RELEASE_ORDERS_FROM_SUSPENSION = 2;
        public const int CANCEL_ORDERS = 3;
    }


    /// <summary>
    /// MassActionScope Field
    /// </summary>/
    public sealed class MassActionScope : IntField
    {
        public const int TAG = 1374;

        public MassActionScope()
            :base(Tags.MassActionScope) {}
        public MassActionScope(int val)
            :base(Tags.MassActionScope, val) {}


        // Field Enumerations
        public const int ALL_ORDERS_FOR_A_SECURITY = 1;
        public const int ALL_ORDERS_FOR_AN_UNDERLYING_SECURITY = 2;
        public const int ALL_ORDERS_FOR_A_PRODUCT = 3;
        public const int ALL_ORDERS_FOR_A_CFICODE = 4;
        public const int ALL_ORDERS_FOR_A_SECURITYTYPE = 5;
        public const int ALL_ORDERS_FOR_A_TRADING_SESSION = 6;
        public const int ALL_ORDERS = 7;
        public const int ALL_ORDERS_FOR_A_MARKET = 8;
        public const int ALL_ORDERS_FOR_A_MARKET_SEGMENT = 9;
        public const int ALL_ORDERS_FOR_A_SECURITY_GROUP = 10;
        public const int CANCEL_FOR_SECURITY_ISSUER = 11;
        public const int CANCEL_FOR_ISSUER_OF_UNDERLYING_SECURITY = 12;
    }


    /// <summary>
    /// MassActionResponse Field
    /// </summary>/
    public sealed class MassActionResponse : IntField
    {
        public const int TAG = 1375;

        public MassActionResponse()
            :base(Tags.MassActionResponse) {}
        public MassActionResponse(int val)
            :base(Tags.MassActionResponse, val) {}


        // Field Enumerations
        public const int REJECTED = 0;
        public const int ACCEPTED = 1;
    }


    /// <summary>
    /// MassActionRejectReason Field
    /// </summary>/
    public sealed class MassActionRejectReason : IntField
    {
        public const int TAG = 1376;

        public MassActionRejectReason()
            :base(Tags.MassActionRejectReason) {}
        public MassActionRejectReason(int val)
            :base(Tags.MassActionRejectReason, val) {}


        // Field Enumerations
        public const int MASS_ACTION_NOT_SUPPORTED = 0;
        public const int INVALID_OR_UNKNOWN_SECURITY = 1;
        public const int INVALID_OR_UNKNOWN_UNDERLYING_SECURITY = 2;
        public const int INVALID_OR_UNKNOWN_PRODUCT = 3;
        public const int INVALID_OR_UNKNOWN_CFICODE = 4;
        public const int INVALID_OR_UNKNOWN_SECURITYTYPE = 5;
        public const int INVALID_OR_UNKNOWN_TRADING_SESSION = 6;
        public const int INVALID_OR_UNKNOWN_MARKET = 7;
        public const int INVALID_OR_UNKNOWN_MARKET_SEGMENT = 8;
        public const int INVALID_OR_UNKNOWN_SECURITY_GROUP = 9;
        public const int OTHER = 99;
        public const int INVALID_OR_UNKNOWN_SECURITY_ISSUER = 10;
        public const int INVALID_OR_UNKNOWN_ISSUER_OF_UNDERLYING_SECURITY = 11;
    }


    /// <summary>
    /// MultilegModel Field
    /// </summary>/
    public sealed class MultilegModel : IntField
    {
        public const int TAG = 1377;

        public MultilegModel()
            :base(Tags.MultilegModel) {}
        public MultilegModel(int val)
            :base(Tags.MultilegModel, val) {}


        // Field Enumerations
        public const int PREDEFINED_MULTILEG_SECURITY = 0;
        public const int USER_DEFINED_MULTLEG_SECURITY = 1;
        public const int USER_DEFINED_NON_SECURITIZED_MULTILEG = 2;
    }


    /// <summary>
    /// MultilegPriceMethod Field
    /// </summary>/
    public sealed class MultilegPriceMethod : IntField
    {
        public const int TAG = 1378;

        public MultilegPriceMethod()
            :base(Tags.MultilegPriceMethod) {}
        public MultilegPriceMethod(int val)
            :base(Tags.MultilegPriceMethod, val) {}


        // Field Enumerations
        public const int NET_PRICE = 0;
        public const int REVERSED_NET_PRICE = 1;
        public const int YIELD_DIFFERENCE = 2;
        public const int INDIVIDUAL = 3;
        public const int CONTRACT_WEIGHTED_AVERAGE_PRICE = 4;
        public const int MULTIPLIED_PRICE = 5;
    }


    /// <summary>
    /// LegVolatility Field
    /// </summary>/
    public sealed class LegVolatility : DecimalField
    {
        public const int TAG = 1379;

        public LegVolatility()
            :base(Tags.LegVolatility) {}
        public LegVolatility(Decimal val)
            :base(Tags.LegVolatility, val) {}

    }


    /// <summary>
    /// DividendYield Field
    /// </summary>/
    public sealed class DividendYield : DecimalField
    {
        public const int TAG = 1380;

        public DividendYield()
            :base(Tags.DividendYield) {}
        public DividendYield(Decimal val)
            :base(Tags.DividendYield, val) {}

    }


    /// <summary>
    /// LegDividendYield Field
    /// </summary>/
    public sealed class LegDividendYield : DecimalField
    {
        public const int TAG = 1381;

        public LegDividendYield()
            :base(Tags.LegDividendYield) {}
        public LegDividendYield(Decimal val)
            :base(Tags.LegDividendYield, val) {}

    }


    /// <summary>
    /// CurrencyRatio Field
    /// </summary>/
    public sealed class CurrencyRatio : DecimalField
    {
        public const int TAG = 1382;

        public CurrencyRatio()
            :base(Tags.CurrencyRatio) {}
        public CurrencyRatio(Decimal val)
            :base(Tags.CurrencyRatio, val) {}

    }


    /// <summary>
    /// LegCurrencyRatio Field
    /// </summary>/
    public sealed class LegCurrencyRatio : DecimalField
    {
        public const int TAG = 1383;

        public LegCurrencyRatio()
            :base(Tags.LegCurrencyRatio) {}
        public LegCurrencyRatio(Decimal val)
            :base(Tags.LegCurrencyRatio, val) {}

    }


    /// <summary>
    /// LegExecInst Field
    /// </summary>/
    public sealed class LegExecInst : StringField
    {
        public const int TAG = 1384;

        public LegExecInst()
            :base(Tags.LegExecInst) {}
        public LegExecInst(string val)
            :base(Tags.LegExecInst, val) {}

    }


    /// <summary>
    /// ContingencyType Field
    /// </summary>/
    public sealed class ContingencyType : IntField
    {
        public const int TAG = 1385;

        public ContingencyType()
            :base(Tags.ContingencyType) {}
        public ContingencyType(int val)
            :base(Tags.ContingencyType, val) {}


        // Field Enumerations
        public const int ONE_CANCELS_THE_OTHER = 1;
        public const int ONE_TRIGGERS_THE_OTHER = 2;
        public const int ONE_UPDATES_THE_OTHER_3 = 3;
        public const int ONE_UPDATES_THE_OTHER_4 = 4;
    }


    /// <summary>
    /// ListRejectReason Field
    /// </summary>/
    public sealed class ListRejectReason : IntField
    {
        public const int TAG = 1386;

        public ListRejectReason()
            :base(Tags.ListRejectReason) {}
        public ListRejectReason(int val)
            :base(Tags.ListRejectReason, val) {}


        // Field Enumerations
        public const int BROKER = 0;
        public const int EXCHANGE_CLOSED = 2;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_ORDER = 5;
        public const int DUPLICATE_ORDER = 6;
        public const int UNSUPPORTED_ORDER_CHARACTERISTIC = 11;
        public const int OTHER = 99;
    }


    /// <summary>
    /// NoTrdRepIndicators Field
    /// </summary>/
    public sealed class NoTrdRepIndicators : IntField
    {
        public const int TAG = 1387;

        public NoTrdRepIndicators()
            :base(Tags.NoTrdRepIndicators) {}
        public NoTrdRepIndicators(int val)
            :base(Tags.NoTrdRepIndicators, val) {}

    }


    /// <summary>
    /// TrdRepPartyRole Field
    /// </summary>/
    public sealed class TrdRepPartyRole : IntField
    {
        public const int TAG = 1388;

        public TrdRepPartyRole()
            :base(Tags.TrdRepPartyRole) {}
        public TrdRepPartyRole(int val)
            :base(Tags.TrdRepPartyRole, val) {}

    }


    /// <summary>
    /// TrdRepIndicator Field
    /// </summary>/
    public sealed class TrdRepIndicator : BooleanField
    {
        public const int TAG = 1389;

        public TrdRepIndicator()
            :base(Tags.TrdRepIndicator) {}
        public TrdRepIndicator(Boolean val)
            :base(Tags.TrdRepIndicator, val) {}

    }


    /// <summary>
    /// TradePublishIndicator Field
    /// </summary>/
    public sealed class TradePublishIndicator : IntField
    {
        public const int TAG = 1390;

        public TradePublishIndicator()
            :base(Tags.TradePublishIndicator) {}
        public TradePublishIndicator(int val)
            :base(Tags.TradePublishIndicator, val) {}


        // Field Enumerations
        public const int DO_NOT_PUBLISH_TRADE = 0;
        public const int PUBLISH_TRADE = 1;
        public const int DEFERRED_PUBLICATION = 2;
    }


    /// <summary>
    /// UnderlyingLegOptAttribute Field
    /// </summary>/
    public sealed class UnderlyingLegOptAttribute : CharField
    {
        public const int TAG = 1391;

        public UnderlyingLegOptAttribute()
            :base(Tags.UnderlyingLegOptAttribute) {}
        public UnderlyingLegOptAttribute(char val)
            :base(Tags.UnderlyingLegOptAttribute, val) {}

    }


    /// <summary>
    /// UnderlyingLegSecurityDesc Field
    /// </summary>/
    public sealed class UnderlyingLegSecurityDesc : StringField
    {
        public const int TAG = 1392;

        public UnderlyingLegSecurityDesc()
            :base(Tags.UnderlyingLegSecurityDesc) {}
        public UnderlyingLegSecurityDesc(string val)
            :base(Tags.UnderlyingLegSecurityDesc, val) {}

    }


    /// <summary>
    /// MarketReqID Field
    /// </summary>/
    public sealed class MarketReqID : StringField
    {
        public const int TAG = 1393;

        public MarketReqID()
            :base(Tags.MarketReqID) {}
        public MarketReqID(string val)
            :base(Tags.MarketReqID, val) {}

    }


    /// <summary>
    /// MarketReportID Field
    /// </summary>/
    public sealed class MarketReportID : StringField
    {
        public const int TAG = 1394;

        public MarketReportID()
            :base(Tags.MarketReportID) {}
        public MarketReportID(string val)
            :base(Tags.MarketReportID, val) {}

    }


    /// <summary>
    /// MarketUpdateAction Field
    /// </summary>/
    public sealed class MarketUpdateAction : CharField
    {
        public const int TAG = 1395;

        public MarketUpdateAction()
            :base(Tags.MarketUpdateAction) {}
        public MarketUpdateAction(char val)
            :base(Tags.MarketUpdateAction, val) {}


        // Field Enumerations
        public const char ADD = 'A';
        public const char DELETE = 'D';
        public const char MODIFY = 'M';
    }


    /// <summary>
    /// MarketSegmentDesc Field
    /// </summary>/
    public sealed class MarketSegmentDesc : StringField
    {
        public const int TAG = 1396;

        public MarketSegmentDesc()
            :base(Tags.MarketSegmentDesc) {}
        public MarketSegmentDesc(string val)
            :base(Tags.MarketSegmentDesc, val) {}

    }


    /// <summary>
    /// EncodedMktSegmDescLen Field
    /// </summary>/
    public sealed class EncodedMktSegmDescLen : IntField
    {
        public const int TAG = 1397;

        public EncodedMktSegmDescLen()
            :base(Tags.EncodedMktSegmDescLen) {}
        public EncodedMktSegmDescLen(int val)
            :base(Tags.EncodedMktSegmDescLen, val) {}

    }


    /// <summary>
    /// EncodedMktSegmDesc Field
    /// </summary>/
    public sealed class EncodedMktSegmDesc : StringField
    {
        public const int TAG = 1398;

        public EncodedMktSegmDesc()
            :base(Tags.EncodedMktSegmDesc) {}
        public EncodedMktSegmDesc(string val)
            :base(Tags.EncodedMktSegmDesc, val) {}

    }


    /// <summary>
    /// ApplNewSeqNum Field
    /// </summary>/
    public sealed class ApplNewSeqNum : IntField
    {
        public const int TAG = 1399;

        public ApplNewSeqNum()
            :base(Tags.ApplNewSeqNum) {}
        public ApplNewSeqNum(int val)
            :base(Tags.ApplNewSeqNum, val) {}

    }


    /// <summary>
    /// EncryptedPasswordMethod Field
    /// </summary>/
    public sealed class EncryptedPasswordMethod : IntField
    {
        public const int TAG = 1400;

        public EncryptedPasswordMethod()
            :base(Tags.EncryptedPasswordMethod) {}
        public EncryptedPasswordMethod(int val)
            :base(Tags.EncryptedPasswordMethod, val) {}

    }


    /// <summary>
    /// EncryptedPasswordLen Field
    /// </summary>/
    public sealed class EncryptedPasswordLen : IntField
    {
        public const int TAG = 1401;

        public EncryptedPasswordLen()
            :base(Tags.EncryptedPasswordLen) {}
        public EncryptedPasswordLen(int val)
            :base(Tags.EncryptedPasswordLen, val) {}

    }


    /// <summary>
    /// EncryptedPassword Field
    /// </summary>/
    public sealed class EncryptedPassword : StringField
    {
        public const int TAG = 1402;

        public EncryptedPassword()
            :base(Tags.EncryptedPassword) {}
        public EncryptedPassword(string val)
            :base(Tags.EncryptedPassword, val) {}

    }


    /// <summary>
    /// EncryptedNewPasswordLen Field
    /// </summary>/
    public sealed class EncryptedNewPasswordLen : IntField
    {
        public const int TAG = 1403;

        public EncryptedNewPasswordLen()
            :base(Tags.EncryptedNewPasswordLen) {}
        public EncryptedNewPasswordLen(int val)
            :base(Tags.EncryptedNewPasswordLen, val) {}

    }


    /// <summary>
    /// EncryptedNewPassword Field
    /// </summary>/
    public sealed class EncryptedNewPassword : StringField
    {
        public const int TAG = 1404;

        public EncryptedNewPassword()
            :base(Tags.EncryptedNewPassword) {}
        public EncryptedNewPassword(string val)
            :base(Tags.EncryptedNewPassword, val) {}

    }


    /// <summary>
    /// UnderlyingLegMaturityTime Field
    /// </summary>/
    public sealed class UnderlyingLegMaturityTime : StringField
    {
        public const int TAG = 1405;

        public UnderlyingLegMaturityTime()
            :base(Tags.UnderlyingLegMaturityTime) {}
        public UnderlyingLegMaturityTime(string val)
            :base(Tags.UnderlyingLegMaturityTime, val) {}

    }


    /// <summary>
    /// RefApplExtID Field
    /// </summary>/
    public sealed class RefApplExtID : IntField
    {
        public const int TAG = 1406;

        public RefApplExtID()
            :base(Tags.RefApplExtID) {}
        public RefApplExtID(int val)
            :base(Tags.RefApplExtID, val) {}

    }


    /// <summary>
    /// DefaultApplExtID Field
    /// </summary>/
    public sealed class DefaultApplExtID : IntField
    {
        public const int TAG = 1407;

        public DefaultApplExtID()
            :base(Tags.DefaultApplExtID) {}
        public DefaultApplExtID(int val)
            :base(Tags.DefaultApplExtID, val) {}

    }


    /// <summary>
    /// DefaultCstmApplVerID Field
    /// </summary>/
    public sealed class DefaultCstmApplVerID : StringField
    {
        public const int TAG = 1408;

        public DefaultCstmApplVerID()
            :base(Tags.DefaultCstmApplVerID) {}
        public DefaultCstmApplVerID(string val)
            :base(Tags.DefaultCstmApplVerID, val) {}

    }


    /// <summary>
    /// SessionStatus Field
    /// </summary>/
    public sealed class SessionStatus : IntField
    {
        public const int TAG = 1409;

        public SessionStatus()
            :base(Tags.SessionStatus) {}
        public SessionStatus(int val)
            :base(Tags.SessionStatus, val) {}


        // Field Enumerations
        public const int SESSION_ACTIVE = 0;
        public const int SESSION_PASSWORD_CHANGED = 1;
        public const int SESSION_PASSWORD_DUE_TO_EXPIRE = 2;
        public const int NEW_SESSION_PASSWORD_DOES_NOT_COMPLY_WITH_POLICY = 3;
        public const int SESSION_LOGOUT_COMPLETE = 4;
        public const int INVALID_USERNAME_OR_PASSWORD = 5;
        public const int ACCOUNT_LOCKED = 6;
        public const int LOGONS_ARE_NOT_ALLOWED_AT_THIS_TIME = 7;
        public const int PASSWORD_EXPIRED = 8;
    }


    /// <summary>
    /// DefaultVerIndicator Field
    /// </summary>/
    public sealed class DefaultVerIndicator : BooleanField
    {
        public const int TAG = 1410;

        public DefaultVerIndicator()
            :base(Tags.DefaultVerIndicator) {}
        public DefaultVerIndicator(Boolean val)
            :base(Tags.DefaultVerIndicator, val) {}

    }


    /// <summary>
    /// Nested4PartySubIDType Field
    /// </summary>/
    public sealed class Nested4PartySubIDType : IntField
    {
        public const int TAG = 1411;

        public Nested4PartySubIDType()
            :base(Tags.Nested4PartySubIDType) {}
        public Nested4PartySubIDType(int val)
            :base(Tags.Nested4PartySubIDType, val) {}

    }


    /// <summary>
    /// Nested4PartySubID Field
    /// </summary>/
    public sealed class Nested4PartySubID : StringField
    {
        public const int TAG = 1412;

        public Nested4PartySubID()
            :base(Tags.Nested4PartySubID) {}
        public Nested4PartySubID(string val)
            :base(Tags.Nested4PartySubID, val) {}

    }


    /// <summary>
    /// NoNested4PartySubIDs Field
    /// </summary>/
    public sealed class NoNested4PartySubIDs : IntField
    {
        public const int TAG = 1413;

        public NoNested4PartySubIDs()
            :base(Tags.NoNested4PartySubIDs) {}
        public NoNested4PartySubIDs(int val)
            :base(Tags.NoNested4PartySubIDs, val) {}

    }


    /// <summary>
    /// NoNested4PartyIDs Field
    /// </summary>/
    public sealed class NoNested4PartyIDs : IntField
    {
        public const int TAG = 1414;

        public NoNested4PartyIDs()
            :base(Tags.NoNested4PartyIDs) {}
        public NoNested4PartyIDs(int val)
            :base(Tags.NoNested4PartyIDs, val) {}

    }


    /// <summary>
    /// Nested4PartyID Field
    /// </summary>/
    public sealed class Nested4PartyID : StringField
    {
        public const int TAG = 1415;

        public Nested4PartyID()
            :base(Tags.Nested4PartyID) {}
        public Nested4PartyID(string val)
            :base(Tags.Nested4PartyID, val) {}

    }


    /// <summary>
    /// Nested4PartyIDSource Field
    /// </summary>/
    public sealed class Nested4PartyIDSource : CharField
    {
        public const int TAG = 1416;

        public Nested4PartyIDSource()
            :base(Tags.Nested4PartyIDSource) {}
        public Nested4PartyIDSource(char val)
            :base(Tags.Nested4PartyIDSource, val) {}

    }


    /// <summary>
    /// Nested4PartyRole Field
    /// </summary>/
    public sealed class Nested4PartyRole : IntField
    {
        public const int TAG = 1417;

        public Nested4PartyRole()
            :base(Tags.Nested4PartyRole) {}
        public Nested4PartyRole(int val)
            :base(Tags.Nested4PartyRole, val) {}

    }


    /// <summary>
    /// LegLastQty Field
    /// </summary>/
    public sealed class LegLastQty : DecimalField
    {
        public const int TAG = 1418;

        public LegLastQty()
            :base(Tags.LegLastQty) {}
        public LegLastQty(Decimal val)
            :base(Tags.LegLastQty, val) {}

    }


    /// <summary>
    /// UnderlyingExerciseStyle Field
    /// </summary>/
    public sealed class UnderlyingExerciseStyle : IntField
    {
        public const int TAG = 1419;

        public UnderlyingExerciseStyle()
            :base(Tags.UnderlyingExerciseStyle) {}
        public UnderlyingExerciseStyle(int val)
            :base(Tags.UnderlyingExerciseStyle, val) {}

    }


    /// <summary>
    /// LegExerciseStyle Field
    /// </summary>/
    public sealed class LegExerciseStyle : IntField
    {
        public const int TAG = 1420;

        public LegExerciseStyle()
            :base(Tags.LegExerciseStyle) {}
        public LegExerciseStyle(int val)
            :base(Tags.LegExerciseStyle, val) {}

    }


    /// <summary>
    /// LegPriceUnitOfMeasure Field
    /// </summary>/
    public sealed class LegPriceUnitOfMeasure : StringField
    {
        public const int TAG = 1421;

        public LegPriceUnitOfMeasure()
            :base(Tags.LegPriceUnitOfMeasure) {}
        public LegPriceUnitOfMeasure(string val)
            :base(Tags.LegPriceUnitOfMeasure, val) {}

    }


    /// <summary>
    /// LegPriceUnitOfMeasureQty Field
    /// </summary>/
    public sealed class LegPriceUnitOfMeasureQty : DecimalField
    {
        public const int TAG = 1422;

        public LegPriceUnitOfMeasureQty()
            :base(Tags.LegPriceUnitOfMeasureQty) {}
        public LegPriceUnitOfMeasureQty(Decimal val)
            :base(Tags.LegPriceUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// UnderlyingUnitOfMeasureQty Field
    /// </summary>/
    public sealed class UnderlyingUnitOfMeasureQty : DecimalField
    {
        public const int TAG = 1423;

        public UnderlyingUnitOfMeasureQty()
            :base(Tags.UnderlyingUnitOfMeasureQty) {}
        public UnderlyingUnitOfMeasureQty(Decimal val)
            :base(Tags.UnderlyingUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// UnderlyingPriceUnitOfMeasure Field
    /// </summary>/
    public sealed class UnderlyingPriceUnitOfMeasure : StringField
    {
        public const int TAG = 1424;

        public UnderlyingPriceUnitOfMeasure()
            :base(Tags.UnderlyingPriceUnitOfMeasure) {}
        public UnderlyingPriceUnitOfMeasure(string val)
            :base(Tags.UnderlyingPriceUnitOfMeasure, val) {}

    }


    /// <summary>
    /// UnderlyingPriceUnitOfMeasureQty Field
    /// </summary>/
    public sealed class UnderlyingPriceUnitOfMeasureQty : DecimalField
    {
        public const int TAG = 1425;

        public UnderlyingPriceUnitOfMeasureQty()
            :base(Tags.UnderlyingPriceUnitOfMeasureQty) {}
        public UnderlyingPriceUnitOfMeasureQty(Decimal val)
            :base(Tags.UnderlyingPriceUnitOfMeasureQty, val) {}

    }


    /// <summary>
    /// ApplReportType Field
    /// </summary>/
    public sealed class ApplReportType : IntField
    {
        public const int TAG = 1426;

        public ApplReportType()
            :base(Tags.ApplReportType) {}
        public ApplReportType(int val)
            :base(Tags.ApplReportType, val) {}


        // Field Enumerations
        public const int RESET_APPLSEQNUM_TO_NEW_VALUE_SPECIFIED_IN_APPLNEWSEQNUM = 0;
        public const int REPORTS_THAT_THE_LAST_MESSAGE_HAS_BEEN_SENT_FOR_THE_APPLIDS_REFER_TO_REFAPPLLASTSEQNUM = 1;
        public const int HEARTBEAT_MESSAGE_INDICATING_THAT_APPLICATION_IDENTIFIED_BY_REFAPPLID = 2;
        public const int APPLICATION_MESSAGE_RE_SEND_COMPLETED = 3;
    }


    /// <summary>
    /// HaltReasonInt Field
    /// </summary>/
    public sealed class HaltReasonInt : IntField
    {
        public const int TAG = 327;

        public HaltReasonInt()
            :base(Tags.HaltReasonInt) {}
        public HaltReasonInt(int val)
            :base(Tags.HaltReasonInt, val) {}


        // Field Enumerations
        public const int NEWS_DISSEMINATION = 0;
        public const int ORDER_INFLUX = 1;
        public const int ORDER_IMBALANCE = 2;
        public const int ADDITIONAL_INFORMATION = 3;
        public const int NEWS_PENDING = 4;
        public const int EQUIPMENT_CHANGEOVER = 5;
    }


    /// <summary>
    /// SideLastQty Field
    /// </summary>/
    public sealed class SideLastQty : IntField
    {
        public const int TAG = 1009;

        public SideLastQty()
            :base(Tags.SideLastQty) {}
        public SideLastQty(int val)
            :base(Tags.SideLastQty, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartyID Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartyID : StringField
    {
        public const int TAG = 1059;

        public UnderlyingInstrumentPartyID()
            :base(Tags.UnderlyingInstrumentPartyID) {}
        public UnderlyingInstrumentPartyID(string val)
            :base(Tags.UnderlyingInstrumentPartyID, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartyIDSource Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartyIDSource : CharField
    {
        public const int TAG = 1060;

        public UnderlyingInstrumentPartyIDSource()
            :base(Tags.UnderlyingInstrumentPartyIDSource) {}
        public UnderlyingInstrumentPartyIDSource(char val)
            :base(Tags.UnderlyingInstrumentPartyIDSource, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartyRole Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartyRole : IntField
    {
        public const int TAG = 1061;

        public UnderlyingInstrumentPartyRole()
            :base(Tags.UnderlyingInstrumentPartyRole) {}
        public UnderlyingInstrumentPartyRole(int val)
            :base(Tags.UnderlyingInstrumentPartyRole, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartySubID Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartySubID : StringField
    {
        public const int TAG = 1063;

        public UnderlyingInstrumentPartySubID()
            :base(Tags.UnderlyingInstrumentPartySubID) {}
        public UnderlyingInstrumentPartySubID(string val)
            :base(Tags.UnderlyingInstrumentPartySubID, val) {}

    }


    /// <summary>
    /// UnderlyingInstrumentPartySubIDType Field
    /// </summary>/
    public sealed class UnderlyingInstrumentPartySubIDType : IntField
    {
        public const int TAG = 1064;

        public UnderlyingInstrumentPartySubIDType()
            :base(Tags.UnderlyingInstrumentPartySubIDType) {}
        public UnderlyingInstrumentPartySubIDType(int val)
            :base(Tags.UnderlyingInstrumentPartySubIDType, val) {}

    }


    /// <summary>
    /// OptPayoutAmount Field
    /// </summary>/
    public sealed class OptPayoutAmount : DecimalField
    {
        public const int TAG = 1195;

        public OptPayoutAmount()
            :base(Tags.OptPayoutAmount) {}
        public OptPayoutAmount(Decimal val)
            :base(Tags.OptPayoutAmount, val) {}

    }


    /// <summary>
    /// ValuationMethod Field
    /// </summary>/
    public sealed class ValuationMethod : StringField
    {
        public const int TAG = 1197;

        public ValuationMethod()
            :base(Tags.ValuationMethod) {}
        public ValuationMethod(string val)
            :base(Tags.ValuationMethod, val) {}


        // Field Enumerations
        public const string PREMIUM_STYLE = "EQTY";
        public const string FUTURES_STYLE_MARK_TO_MARKET = "FUT";
        public const string FUTURES_STYLE_WITH_AN_ATTACHED_CASH_ADJUSTMENT = "FUTDA";
        public const string CDS_STYLE_COLLATERALIZATION_OF_MARKET_TO_MARKET_AND_COUPON = "CDS";
        public const string CDS_IN_DELIVERY = "CDSD";
    }


    /// <summary>
    /// DerivativeValuationMethod Field
    /// </summary>/
    public sealed class DerivativeValuationMethod : StringField
    {
        public const int TAG = 1319;

        public DerivativeValuationMethod()
            :base(Tags.DerivativeValuationMethod) {}
        public DerivativeValuationMethod(string val)
            :base(Tags.DerivativeValuationMethod, val) {}

    }


    /// <summary>
    /// SideExecID Field
    /// </summary>/
    public sealed class SideExecID : StringField
    {
        public const int TAG = 1427;

        public SideExecID()
            :base(Tags.SideExecID) {}
        public SideExecID(string val)
            :base(Tags.SideExecID, val) {}

    }


    /// <summary>
    /// OrderDelay Field
    /// </summary>/
    public sealed class OrderDelay : IntField
    {
        public const int TAG = 1428;

        public OrderDelay()
            :base(Tags.OrderDelay) {}
        public OrderDelay(int val)
            :base(Tags.OrderDelay, val) {}

    }


    /// <summary>
    /// OrderDelayUnit Field
    /// </summary>/
    public sealed class OrderDelayUnit : IntField
    {
        public const int TAG = 1429;

        public OrderDelayUnit()
            :base(Tags.OrderDelayUnit) {}
        public OrderDelayUnit(int val)
            :base(Tags.OrderDelayUnit, val) {}


        // Field Enumerations
        public const int SECONDS = 0;
        public const int TENTHS_OF_A_SECOND = 1;
        public const int HUNDREDTHS_OF_A_SECOND = 2;
        public const int MILLISECONDS = 3;
        public const int MICROSECONDS = 4;
        public const int NANOSECONDS = 5;
        public const int MINUTES = 10;
        public const int HOURS = 11;
        public const int DAYS = 12;
        public const int WEEKS = 13;
        public const int MONTHS = 14;
        public const int YEARS = 15;
    }


    /// <summary>
    /// VenueType Field
    /// </summary>/
    public sealed class VenueType : CharField
    {
        public const int TAG = 1430;

        public VenueType()
            :base(Tags.VenueType) {}
        public VenueType(char val)
            :base(Tags.VenueType, val) {}


        // Field Enumerations
        public const char ELECTRONIC = 'E';
        public const char PIT = 'P';
        public const char EX_PIT = 'X';
    }


    /// <summary>
    /// RefOrdIDReason Field
    /// </summary>/
    public sealed class RefOrdIDReason : IntField
    {
        public const int TAG = 1431;

        public RefOrdIDReason()
            :base(Tags.RefOrdIDReason) {}
        public RefOrdIDReason(int val)
            :base(Tags.RefOrdIDReason, val) {}


        // Field Enumerations
        public const int GTC_FROM_PREVIOUS_DAY = 0;
        public const int PARTIAL_FILL_REMAINING = 1;
        public const int ORDER_CHANGED = 2;
    }


    /// <summary>
    /// OrigCustOrderCapacity Field
    /// </summary>/
    public sealed class OrigCustOrderCapacity : IntField
    {
        public const int TAG = 1432;

        public OrigCustOrderCapacity()
            :base(Tags.OrigCustOrderCapacity) {}
        public OrigCustOrderCapacity(int val)
            :base(Tags.OrigCustOrderCapacity, val) {}


        // Field Enumerations
        public const int MEMBER_TRADING_FOR_THEIR_OWN_ACCOUNT = 1;
        public const int CLEARING_FIRM_TRADING_FOR_ITS_PROPRIETARY_ACCOUNT = 2;
        public const int MEMBER_TRADING_FOR_ANOTHER_MEMBER = 3;
        public const int ALL_OTHER = 4;
    }


    /// <summary>
    /// RefApplReqID Field
    /// </summary>/
    public sealed class RefApplReqID : StringField
    {
        public const int TAG = 1433;

        public RefApplReqID()
            :base(Tags.RefApplReqID) {}
        public RefApplReqID(string val)
            :base(Tags.RefApplReqID, val) {}

    }


    /// <summary>
    /// ModelType Field
    /// </summary>/
    public sealed class ModelType : IntField
    {
        public const int TAG = 1434;

        public ModelType()
            :base(Tags.ModelType) {}
        public ModelType(int val)
            :base(Tags.ModelType, val) {}


        // Field Enumerations
        public const int UTILITY_PROVIDED_STANDARD_MODEL = 0;
        public const int PROPRIETARY = 1;
    }


    /// <summary>
    /// ContractMultiplierUnit Field
    /// </summary>/
    public sealed class ContractMultiplierUnit : IntField
    {
        public const int TAG = 1435;

        public ContractMultiplierUnit()
            :base(Tags.ContractMultiplierUnit) {}
        public ContractMultiplierUnit(int val)
            :base(Tags.ContractMultiplierUnit, val) {}


        // Field Enumerations
        public const int SHARES = 0;
        public const int HOURS = 1;
        public const int DAYS = 2;
    }


    /// <summary>
    /// LegContractMultiplierUnit Field
    /// </summary>/
    public sealed class LegContractMultiplierUnit : IntField
    {
        public const int TAG = 1436;

        public LegContractMultiplierUnit()
            :base(Tags.LegContractMultiplierUnit) {}
        public LegContractMultiplierUnit(int val)
            :base(Tags.LegContractMultiplierUnit, val) {}

    }


    /// <summary>
    /// UnderlyingContractMultiplierUnit Field
    /// </summary>/
    public sealed class UnderlyingContractMultiplierUnit : IntField
    {
        public const int TAG = 1437;

        public UnderlyingContractMultiplierUnit()
            :base(Tags.UnderlyingContractMultiplierUnit) {}
        public UnderlyingContractMultiplierUnit(int val)
            :base(Tags.UnderlyingContractMultiplierUnit, val) {}

    }


    /// <summary>
    /// DerivativeContractMultiplierUnit Field
    /// </summary>/
    public sealed class DerivativeContractMultiplierUnit : IntField
    {
        public const int TAG = 1438;

        public DerivativeContractMultiplierUnit()
            :base(Tags.DerivativeContractMultiplierUnit) {}
        public DerivativeContractMultiplierUnit(int val)
            :base(Tags.DerivativeContractMultiplierUnit, val) {}

    }


    /// <summary>
    /// FlowScheduleType Field
    /// </summary>/
    public sealed class FlowScheduleType : IntField
    {
        public const int TAG = 1439;

        public FlowScheduleType()
            :base(Tags.FlowScheduleType) {}
        public FlowScheduleType(int val)
            :base(Tags.FlowScheduleType, val) {}


        // Field Enumerations
        public const int NERC_EASTERN_OFF_PEAK = 0;
        public const int NERC_WESTERN_OFF_PEAK = 1;
        public const int NERC_CALENDAR_ALL_DAYS_IN_MONTH = 2;
        public const int NERC_EASTERN_PEAK = 3;
        public const int NERC_WESTERN_PEAK = 4;
    }


    /// <summary>
    /// LegFlowScheduleType Field
    /// </summary>/
    public sealed class LegFlowScheduleType : IntField
    {
        public const int TAG = 1440;

        public LegFlowScheduleType()
            :base(Tags.LegFlowScheduleType) {}
        public LegFlowScheduleType(int val)
            :base(Tags.LegFlowScheduleType, val) {}

    }


    /// <summary>
    /// UnderlyingFlowScheduleType Field
    /// </summary>/
    public sealed class UnderlyingFlowScheduleType : IntField
    {
        public const int TAG = 1441;

        public UnderlyingFlowScheduleType()
            :base(Tags.UnderlyingFlowScheduleType) {}
        public UnderlyingFlowScheduleType(int val)
            :base(Tags.UnderlyingFlowScheduleType, val) {}

    }


    /// <summary>
    /// DerivativeFlowScheduleType Field
    /// </summary>/
    public sealed class DerivativeFlowScheduleType : IntField
    {
        public const int TAG = 1442;

        public DerivativeFlowScheduleType()
            :base(Tags.DerivativeFlowScheduleType) {}
        public DerivativeFlowScheduleType(int val)
            :base(Tags.DerivativeFlowScheduleType, val) {}

    }


    /// <summary>
    /// FillLiquidityInd Field
    /// </summary>/
    public sealed class FillLiquidityInd : IntField
    {
        public const int TAG = 1443;

        public FillLiquidityInd()
            :base(Tags.FillLiquidityInd) {}
        public FillLiquidityInd(int val)
            :base(Tags.FillLiquidityInd, val) {}

    }


    /// <summary>
    /// SideLiquidityInd Field
    /// </summary>/
    public sealed class SideLiquidityInd : IntField
    {
        public const int TAG = 1444;

        public SideLiquidityInd()
            :base(Tags.SideLiquidityInd) {}
        public SideLiquidityInd(int val)
            :base(Tags.SideLiquidityInd, val) {}

    }


    /// <summary>
    /// NoRateSources Field
    /// </summary>/
    public sealed class NoRateSources : IntField
    {
        public const int TAG = 1445;

        public NoRateSources()
            :base(Tags.NoRateSources) {}
        public NoRateSources(int val)
            :base(Tags.NoRateSources, val) {}

    }


    /// <summary>
    /// RateSource Field
    /// </summary>/
    public sealed class RateSource : IntField
    {
        public const int TAG = 1446;

        public RateSource()
            :base(Tags.RateSource) {}
        public RateSource(int val)
            :base(Tags.RateSource, val) {}


        // Field Enumerations
        public const int BLOOMBERG = 0;
        public const int REUTERS = 1;
        public const int TELERATE = 2;
        public const int OTHER = 99;
    }


    /// <summary>
    /// RateSourceType Field
    /// </summary>/
    public sealed class RateSourceType : IntField
    {
        public const int TAG = 1447;

        public RateSourceType()
            :base(Tags.RateSourceType) {}
        public RateSourceType(int val)
            :base(Tags.RateSourceType, val) {}


        // Field Enumerations
        public const int PRIMARY = 0;
        public const int SECONDARY = 1;
    }


    /// <summary>
    /// ReferencePage Field
    /// </summary>/
    public sealed class ReferencePage : StringField
    {
        public const int TAG = 1448;

        public ReferencePage()
            :base(Tags.ReferencePage) {}
        public ReferencePage(string val)
            :base(Tags.ReferencePage, val) {}

    }


    /// <summary>
    /// RestructuringType Field
    /// </summary>/
    public sealed class RestructuringType : StringField
    {
        public const int TAG = 1449;

        public RestructuringType()
            :base(Tags.RestructuringType) {}
        public RestructuringType(string val)
            :base(Tags.RestructuringType, val) {}


        // Field Enumerations
        public const string FULL_RESTRUCTURING = "FR";
        public const string MODIFIED_RESTRUCTURING = "MR";
        public const string MODIFIED_MOD_RESTRUCTURING = "MM";
        public const string NO_RESTRUCTURING_SPECIFIED = "XR";
    }


    /// <summary>
    /// Seniority Field
    /// </summary>/
    public sealed class Seniority : StringField
    {
        public const int TAG = 1450;

        public Seniority()
            :base(Tags.Seniority) {}
        public Seniority(string val)
            :base(Tags.Seniority, val) {}


        // Field Enumerations
        public const string SENIOR_SECURED = "SD";
        public const string SENIOR = "SR";
        public const string SUBORDINATED = "SB";
    }


    /// <summary>
    /// NotionalPercentageOutstanding Field
    /// </summary>/
    public sealed class NotionalPercentageOutstanding : DecimalField
    {
        public const int TAG = 1451;

        public NotionalPercentageOutstanding()
            :base(Tags.NotionalPercentageOutstanding) {}
        public NotionalPercentageOutstanding(Decimal val)
            :base(Tags.NotionalPercentageOutstanding, val) {}

    }


    /// <summary>
    /// OriginalNotionalPercentageOutstanding Field
    /// </summary>/
    public sealed class OriginalNotionalPercentageOutstanding : DecimalField
    {
        public const int TAG = 1452;

        public OriginalNotionalPercentageOutstanding()
            :base(Tags.OriginalNotionalPercentageOutstanding) {}
        public OriginalNotionalPercentageOutstanding(Decimal val)
            :base(Tags.OriginalNotionalPercentageOutstanding, val) {}

    }


    /// <summary>
    /// UnderlyingRestructuringType Field
    /// </summary>/
    public sealed class UnderlyingRestructuringType : StringField
    {
        public const int TAG = 1453;

        public UnderlyingRestructuringType()
            :base(Tags.UnderlyingRestructuringType) {}
        public UnderlyingRestructuringType(string val)
            :base(Tags.UnderlyingRestructuringType, val) {}

    }


    /// <summary>
    /// UnderlyingSeniority Field
    /// </summary>/
    public sealed class UnderlyingSeniority : StringField
    {
        public const int TAG = 1454;

        public UnderlyingSeniority()
            :base(Tags.UnderlyingSeniority) {}
        public UnderlyingSeniority(string val)
            :base(Tags.UnderlyingSeniority, val) {}

    }


    /// <summary>
    /// UnderlyingNotionalPercentageOutstanding Field
    /// </summary>/
    public sealed class UnderlyingNotionalPercentageOutstanding : DecimalField
    {
        public const int TAG = 1455;

        public UnderlyingNotionalPercentageOutstanding()
            :base(Tags.UnderlyingNotionalPercentageOutstanding) {}
        public UnderlyingNotionalPercentageOutstanding(Decimal val)
            :base(Tags.UnderlyingNotionalPercentageOutstanding, val) {}

    }


    /// <summary>
    /// UnderlyingOriginalNotionalPercentageOutstanding Field
    /// </summary>/
    public sealed class UnderlyingOriginalNotionalPercentageOutstanding : DecimalField
    {
        public const int TAG = 1456;

        public UnderlyingOriginalNotionalPercentageOutstanding()
            :base(Tags.UnderlyingOriginalNotionalPercentageOutstanding) {}
        public UnderlyingOriginalNotionalPercentageOutstanding(Decimal val)
            :base(Tags.UnderlyingOriginalNotionalPercentageOutstanding, val) {}

    }


    /// <summary>
    /// AttachmentPoint Field
    /// </summary>/
    public sealed class AttachmentPoint : DecimalField
    {
        public const int TAG = 1457;

        public AttachmentPoint()
            :base(Tags.AttachmentPoint) {}
        public AttachmentPoint(Decimal val)
            :base(Tags.AttachmentPoint, val) {}

    }


    /// <summary>
    /// DetachmentPoint Field
    /// </summary>/
    public sealed class DetachmentPoint : DecimalField
    {
        public const int TAG = 1458;

        public DetachmentPoint()
            :base(Tags.DetachmentPoint) {}
        public DetachmentPoint(Decimal val)
            :base(Tags.DetachmentPoint, val) {}

    }


    /// <summary>
    /// UnderlyingAttachmentPoint Field
    /// </summary>/
    public sealed class UnderlyingAttachmentPoint : DecimalField
    {
        public const int TAG = 1459;

        public UnderlyingAttachmentPoint()
            :base(Tags.UnderlyingAttachmentPoint) {}
        public UnderlyingAttachmentPoint(Decimal val)
            :base(Tags.UnderlyingAttachmentPoint, val) {}

    }


    /// <summary>
    /// UnderlyingDetachmentPoint Field
    /// </summary>/
    public sealed class UnderlyingDetachmentPoint : DecimalField
    {
        public const int TAG = 1460;

        public UnderlyingDetachmentPoint()
            :base(Tags.UnderlyingDetachmentPoint) {}
        public UnderlyingDetachmentPoint(Decimal val)
            :base(Tags.UnderlyingDetachmentPoint, val) {}

    }


    /// <summary>
    /// NoTargetPartyIDs Field
    /// </summary>/
    public sealed class NoTargetPartyIDs : IntField
    {
        public const int TAG = 1461;

        public NoTargetPartyIDs()
            :base(Tags.NoTargetPartyIDs) {}
        public NoTargetPartyIDs(int val)
            :base(Tags.NoTargetPartyIDs, val) {}

    }


    /// <summary>
    /// TargetPartyID Field
    /// </summary>/
    public sealed class TargetPartyID : StringField
    {
        public const int TAG = 1462;

        public TargetPartyID()
            :base(Tags.TargetPartyID) {}
        public TargetPartyID(string val)
            :base(Tags.TargetPartyID, val) {}

    }


    /// <summary>
    /// TargetPartyIDSource Field
    /// </summary>/
    public sealed class TargetPartyIDSource : CharField
    {
        public const int TAG = 1463;

        public TargetPartyIDSource()
            :base(Tags.TargetPartyIDSource) {}
        public TargetPartyIDSource(char val)
            :base(Tags.TargetPartyIDSource, val) {}

    }


    /// <summary>
    /// TargetPartyRole Field
    /// </summary>/
    public sealed class TargetPartyRole : IntField
    {
        public const int TAG = 1464;

        public TargetPartyRole()
            :base(Tags.TargetPartyRole) {}
        public TargetPartyRole(int val)
            :base(Tags.TargetPartyRole, val) {}

    }


    /// <summary>
    /// SecurityListID Field
    /// </summary>/
    public sealed class SecurityListID : StringField
    {
        public const int TAG = 1465;

        public SecurityListID()
            :base(Tags.SecurityListID) {}
        public SecurityListID(string val)
            :base(Tags.SecurityListID, val) {}

    }


    /// <summary>
    /// SecurityListRefID Field
    /// </summary>/
    public sealed class SecurityListRefID : StringField
    {
        public const int TAG = 1466;

        public SecurityListRefID()
            :base(Tags.SecurityListRefID) {}
        public SecurityListRefID(string val)
            :base(Tags.SecurityListRefID, val) {}

    }


    /// <summary>
    /// SecurityListDesc Field
    /// </summary>/
    public sealed class SecurityListDesc : StringField
    {
        public const int TAG = 1467;

        public SecurityListDesc()
            :base(Tags.SecurityListDesc) {}
        public SecurityListDesc(string val)
            :base(Tags.SecurityListDesc, val) {}

    }


    /// <summary>
    /// EncodedSecurityListDescLen Field
    /// </summary>/
    public sealed class EncodedSecurityListDescLen : IntField
    {
        public const int TAG = 1468;

        public EncodedSecurityListDescLen()
            :base(Tags.EncodedSecurityListDescLen) {}
        public EncodedSecurityListDescLen(int val)
            :base(Tags.EncodedSecurityListDescLen, val) {}

    }


    /// <summary>
    /// EncodedSecurityListDesc Field
    /// </summary>/
    public sealed class EncodedSecurityListDesc : StringField
    {
        public const int TAG = 1469;

        public EncodedSecurityListDesc()
            :base(Tags.EncodedSecurityListDesc) {}
        public EncodedSecurityListDesc(string val)
            :base(Tags.EncodedSecurityListDesc, val) {}

    }


    /// <summary>
    /// SecurityListType Field
    /// </summary>/
    public sealed class SecurityListType : IntField
    {
        public const int TAG = 1470;

        public SecurityListType()
            :base(Tags.SecurityListType) {}
        public SecurityListType(int val)
            :base(Tags.SecurityListType, val) {}


        // Field Enumerations
        public const int INDUSTRY_CLASSIFICATION = 1;
        public const int TRADING_LIST = 2;
        public const int MARKET = 3;
        public const int NEWSPAPER_LIST = 4;
    }


    /// <summary>
    /// SecurityListTypeSource Field
    /// </summary>/
    public sealed class SecurityListTypeSource : IntField
    {
        public const int TAG = 1471;

        public SecurityListTypeSource()
            :base(Tags.SecurityListTypeSource) {}
        public SecurityListTypeSource(int val)
            :base(Tags.SecurityListTypeSource, val) {}


        // Field Enumerations
        public const int ICB = 1;
        public const int NAICS = 2;
        public const int GICS = 3;
    }


    /// <summary>
    /// NewsID Field
    /// </summary>/
    public sealed class NewsID : StringField
    {
        public const int TAG = 1472;

        public NewsID()
            :base(Tags.NewsID) {}
        public NewsID(string val)
            :base(Tags.NewsID, val) {}

    }


    /// <summary>
    /// NewsCategory Field
    /// </summary>/
    public sealed class NewsCategory : IntField
    {
        public const int TAG = 1473;

        public NewsCategory()
            :base(Tags.NewsCategory) {}
        public NewsCategory(int val)
            :base(Tags.NewsCategory, val) {}


        // Field Enumerations
        public const int COMPANY_NEWS = 0;
        public const int MARKETPLACE_NEWS = 1;
        public const int FINANCIAL_MARKET_NEWS = 2;
        public const int TECHNICAL_NEWS = 3;
        public const int OTHER_NEWS = 99;
    }


    /// <summary>
    /// LanguageCode Field
    /// </summary>/
    public sealed class LanguageCode : StringField
    {
        public const int TAG = 1474;

        public LanguageCode()
            :base(Tags.LanguageCode) {}
        public LanguageCode(string val)
            :base(Tags.LanguageCode, val) {}

    }


    /// <summary>
    /// NoNewsRefIDs Field
    /// </summary>/
    public sealed class NoNewsRefIDs : IntField
    {
        public const int TAG = 1475;

        public NoNewsRefIDs()
            :base(Tags.NoNewsRefIDs) {}
        public NoNewsRefIDs(int val)
            :base(Tags.NoNewsRefIDs, val) {}

    }


    /// <summary>
    /// NewsRefID Field
    /// </summary>/
    public sealed class NewsRefID : StringField
    {
        public const int TAG = 1476;

        public NewsRefID()
            :base(Tags.NewsRefID) {}
        public NewsRefID(string val)
            :base(Tags.NewsRefID, val) {}

    }


    /// <summary>
    /// NewsRefType Field
    /// </summary>/
    public sealed class NewsRefType : IntField
    {
        public const int TAG = 1477;

        public NewsRefType()
            :base(Tags.NewsRefType) {}
        public NewsRefType(int val)
            :base(Tags.NewsRefType, val) {}


        // Field Enumerations
        public const int REPLACEMENT = 0;
        public const int OTHER_LANGUAGE = 1;
        public const int COMPLIMENTARY = 2;
    }


    /// <summary>
    /// StrikePriceDeterminationMethod Field
    /// </summary>/
    public sealed class StrikePriceDeterminationMethod : IntField
    {
        public const int TAG = 1478;

        public StrikePriceDeterminationMethod()
            :base(Tags.StrikePriceDeterminationMethod) {}
        public StrikePriceDeterminationMethod(int val)
            :base(Tags.StrikePriceDeterminationMethod, val) {}


        // Field Enumerations
        public const int FIXED_STRIKE = 1;
        public const int STRIKE_SET_AT_EXPIRATION_TO_UNDERLYING_OR_OTHER_VALUE = 2;
        public const int STRIKE_SET_TO_AVERAGE_OF_UNDERLYING_SETTLEMENT_PRICE_ACROSS_THE_LIFE_OF_THE_OPTION = 3;
        public const int STRIKE_SET_TO_OPTIMAL_VALUE = 4;
    }


    /// <summary>
    /// StrikePriceBoundaryMethod Field
    /// </summary>/
    public sealed class StrikePriceBoundaryMethod : IntField
    {
        public const int TAG = 1479;

        public StrikePriceBoundaryMethod()
            :base(Tags.StrikePriceBoundaryMethod) {}
        public StrikePriceBoundaryMethod(int val)
            :base(Tags.StrikePriceBoundaryMethod, val) {}


        // Field Enumerations
        public const int LESS_THAN_UNDERLYING_PRICE_IS_IN_THE_MONEY = 1;
        public const int LESS_THAN_OR_EQUAL_TO_THE_UNDERLYING_PRICE_IS_IN_THE_MONEY = 2;
        public const int EQUAL_TO_THE_UNDERLYING_PRICE_IS_IN_THE_MONEY = 3;
        public const int GREATER_THAN_OR_EQUAL_TO_UNDERLYING_PRICE_IS_IN_THE_MONEY = 4;
        public const int GREATER_THAN_UNDERLYING_IS_IN_THE_MONEY = 5;
    }


    /// <summary>
    /// StrikePriceBoundaryPrecision Field
    /// </summary>/
    public sealed class StrikePriceBoundaryPrecision : DecimalField
    {
        public const int TAG = 1480;

        public StrikePriceBoundaryPrecision()
            :base(Tags.StrikePriceBoundaryPrecision) {}
        public StrikePriceBoundaryPrecision(Decimal val)
            :base(Tags.StrikePriceBoundaryPrecision, val) {}

    }


    /// <summary>
    /// UnderlyingPriceDeterminationMethod Field
    /// </summary>/
    public sealed class UnderlyingPriceDeterminationMethod : IntField
    {
        public const int TAG = 1481;

        public UnderlyingPriceDeterminationMethod()
            :base(Tags.UnderlyingPriceDeterminationMethod) {}
        public UnderlyingPriceDeterminationMethod(int val)
            :base(Tags.UnderlyingPriceDeterminationMethod, val) {}


        // Field Enumerations
        public const int REGULAR = 1;
        public const int SPECIAL_REFERENCE = 2;
        public const int OPTIMAL_VALUE = 3;
        public const int AVERAGE_VALUE = 4;
    }


    /// <summary>
    /// OptPayoutType Field
    /// </summary>/
    public sealed class OptPayoutType : IntField
    {
        public const int TAG = 1482;

        public OptPayoutType()
            :base(Tags.OptPayoutType) {}
        public OptPayoutType(int val)
            :base(Tags.OptPayoutType, val) {}


        // Field Enumerations
        public const int VANILLA = 1;
        public const int CAPPED = 2;
        public const int BINARY = 3;
    }


    /// <summary>
    /// NoComplexEvents Field
    /// </summary>/
    public sealed class NoComplexEvents : IntField
    {
        public const int TAG = 1483;

        public NoComplexEvents()
            :base(Tags.NoComplexEvents) {}
        public NoComplexEvents(int val)
            :base(Tags.NoComplexEvents, val) {}

    }


    /// <summary>
    /// ComplexEventType Field
    /// </summary>/
    public sealed class ComplexEventType : IntField
    {
        public const int TAG = 1484;

        public ComplexEventType()
            :base(Tags.ComplexEventType) {}
        public ComplexEventType(int val)
            :base(Tags.ComplexEventType, val) {}


        // Field Enumerations
        public const int CAPPED = 1;
        public const int TRIGGER = 2;
        public const int KNOCK_IN_UP = 3;
        public const int KOCK_IN_DOWN = 4;
        public const int KNOCK_OUT_UP = 5;
        public const int KNOCK_OUT_DOWN = 6;
        public const int UNDERLYING = 7;
        public const int RESET_BARRIER = 8;
        public const int ROLLING_BARRIER = 9;
    }


    /// <summary>
    /// ComplexOptPayoutAmount Field
    /// </summary>/
    public sealed class ComplexOptPayoutAmount : DecimalField
    {
        public const int TAG = 1485;

        public ComplexOptPayoutAmount()
            :base(Tags.ComplexOptPayoutAmount) {}
        public ComplexOptPayoutAmount(Decimal val)
            :base(Tags.ComplexOptPayoutAmount, val) {}

    }


    /// <summary>
    /// ComplexEventPrice Field
    /// </summary>/
    public sealed class ComplexEventPrice : DecimalField
    {
        public const int TAG = 1486;

        public ComplexEventPrice()
            :base(Tags.ComplexEventPrice) {}
        public ComplexEventPrice(Decimal val)
            :base(Tags.ComplexEventPrice, val) {}

    }


    /// <summary>
    /// ComplexEventPriceBoundaryMethod Field
    /// </summary>/
    public sealed class ComplexEventPriceBoundaryMethod : IntField
    {
        public const int TAG = 1487;

        public ComplexEventPriceBoundaryMethod()
            :base(Tags.ComplexEventPriceBoundaryMethod) {}
        public ComplexEventPriceBoundaryMethod(int val)
            :base(Tags.ComplexEventPriceBoundaryMethod, val) {}


        // Field Enumerations
        public const int LESS_THAN_COMPLEXEVENTPRICE = 1;
        public const int LESS_THAN_OR_EQUAL_TO_COMPLEXEVENTPRICE = 2;
        public const int EQUAL_TO_COMPLEXEVENTPRICE = 3;
        public const int GREATER_THAN_OR_EQUAL_TO_COMPLEXEVENTPRICE = 4;
        public const int GREATER_THAN_COMPLEXEVENTPRICE = 5;
    }


    /// <summary>
    /// ComplexEventPriceBoundaryPrecision Field
    /// </summary>/
    public sealed class ComplexEventPriceBoundaryPrecision : DecimalField
    {
        public const int TAG = 1488;

        public ComplexEventPriceBoundaryPrecision()
            :base(Tags.ComplexEventPriceBoundaryPrecision) {}
        public ComplexEventPriceBoundaryPrecision(Decimal val)
            :base(Tags.ComplexEventPriceBoundaryPrecision, val) {}

    }


    /// <summary>
    /// ComplexEventPriceTimeType Field
    /// </summary>/
    public sealed class ComplexEventPriceTimeType : IntField
    {
        public const int TAG = 1489;

        public ComplexEventPriceTimeType()
            :base(Tags.ComplexEventPriceTimeType) {}
        public ComplexEventPriceTimeType(int val)
            :base(Tags.ComplexEventPriceTimeType, val) {}


        // Field Enumerations
        public const int EXPIRATION = 1;
        public const int IMMEDIATE = 2;
        public const int SPECIFIED_DATE_TIME = 3;
    }


    /// <summary>
    /// ComplexEventCondition Field
    /// </summary>/
    public sealed class ComplexEventCondition : IntField
    {
        public const int TAG = 1490;

        public ComplexEventCondition()
            :base(Tags.ComplexEventCondition) {}
        public ComplexEventCondition(int val)
            :base(Tags.ComplexEventCondition, val) {}


        // Field Enumerations
        public const int AND = 1;
        public const int OR = 2;
    }


    /// <summary>
    /// NoComplexEventDates Field
    /// </summary>/
    public sealed class NoComplexEventDates : IntField
    {
        public const int TAG = 1491;

        public NoComplexEventDates()
            :base(Tags.NoComplexEventDates) {}
        public NoComplexEventDates(int val)
            :base(Tags.NoComplexEventDates, val) {}

    }


    /// <summary>
    /// ComplexEventStartDate Field
    /// </summary>/
    public sealed class ComplexEventStartDate : DateTimeField
    {
        public const int TAG = 1492;

        public ComplexEventStartDate()
            :base(Tags.ComplexEventStartDate) {}
        public ComplexEventStartDate(DateTime val)
            :base(Tags.ComplexEventStartDate, val) {}
        public ComplexEventStartDate(DateTime val, bool showMilliseconds)
            :base(Tags.ComplexEventStartDate, val, showMilliseconds) {}
		public ComplexEventStartDate(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.ComplexEventStartDate, val, precision) {}

    }


    /// <summary>
    /// ComplexEventEndDate Field
    /// </summary>/
    public sealed class ComplexEventEndDate : DateTimeField
    {
        public const int TAG = 1493;

        public ComplexEventEndDate()
            :base(Tags.ComplexEventEndDate) {}
        public ComplexEventEndDate(DateTime val)
            :base(Tags.ComplexEventEndDate, val) {}
        public ComplexEventEndDate(DateTime val, bool showMilliseconds)
            :base(Tags.ComplexEventEndDate, val, showMilliseconds) {}
		public ComplexEventEndDate(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.ComplexEventEndDate, val, precision) {}

    }


    /// <summary>
    /// NoComplexEventTimes Field
    /// </summary>/
    public sealed class NoComplexEventTimes : IntField
    {
        public const int TAG = 1494;

        public NoComplexEventTimes()
            :base(Tags.NoComplexEventTimes) {}
        public NoComplexEventTimes(int val)
            :base(Tags.NoComplexEventTimes, val) {}

    }


    /// <summary>
    /// ComplexEventStartTime Field
    /// </summary>/
    public sealed class ComplexEventStartTime : TimeOnlyField
    {
        public const int TAG = 1495;

        public ComplexEventStartTime()
            :base(Tags.ComplexEventStartTime) {}
        public ComplexEventStartTime(DateTime val)
            :base(Tags.ComplexEventStartTime, val) {}
        public ComplexEventStartTime(DateTime val, bool showMilliseconds)
            :base(Tags.ComplexEventStartTime, val, showMilliseconds) {}
		public ComplexEventStartTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.ComplexEventStartTime, val, precision) {}

    }


    /// <summary>
    /// ComplexEventEndTime Field
    /// </summary>/
    public sealed class ComplexEventEndTime : TimeOnlyField
    {
        public const int TAG = 1496;

        public ComplexEventEndTime()
            :base(Tags.ComplexEventEndTime) {}
        public ComplexEventEndTime(DateTime val)
            :base(Tags.ComplexEventEndTime, val) {}
        public ComplexEventEndTime(DateTime val, bool showMilliseconds)
            :base(Tags.ComplexEventEndTime, val, showMilliseconds) {}
		public ComplexEventEndTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.ComplexEventEndTime, val, precision) {}

    }


    /// <summary>
    /// StreamAsgnReqID Field
    /// </summary>/
    public sealed class StreamAsgnReqID : StringField
    {
        public const int TAG = 1497;

        public StreamAsgnReqID()
            :base(Tags.StreamAsgnReqID) {}
        public StreamAsgnReqID(string val)
            :base(Tags.StreamAsgnReqID, val) {}

    }


    /// <summary>
    /// StreamAsgnReqType Field
    /// </summary>/
    public sealed class StreamAsgnReqType : IntField
    {
        public const int TAG = 1498;

        public StreamAsgnReqType()
            :base(Tags.StreamAsgnReqType) {}
        public StreamAsgnReqType(int val)
            :base(Tags.StreamAsgnReqType, val) {}


        // Field Enumerations
        public const int STREAM_ASSIGNMENT_FOR_NEW_CUSTOMER = 1;
        public const int STREAM_ASSIGNMENT_FOR_EXISTING_CUSTOMER = 2;
    }


    /// <summary>
    /// NoAsgnReqs Field
    /// </summary>/
    public sealed class NoAsgnReqs : IntField
    {
        public const int TAG = 1499;

        public NoAsgnReqs()
            :base(Tags.NoAsgnReqs) {}
        public NoAsgnReqs(int val)
            :base(Tags.NoAsgnReqs, val) {}

    }


    /// <summary>
    /// MDStreamID Field
    /// </summary>/
    public sealed class MDStreamID : StringField
    {
        public const int TAG = 1500;

        public MDStreamID()
            :base(Tags.MDStreamID) {}
        public MDStreamID(string val)
            :base(Tags.MDStreamID, val) {}

    }


    /// <summary>
    /// StreamAsgnRptID Field
    /// </summary>/
    public sealed class StreamAsgnRptID : StringField
    {
        public const int TAG = 1501;

        public StreamAsgnRptID()
            :base(Tags.StreamAsgnRptID) {}
        public StreamAsgnRptID(string val)
            :base(Tags.StreamAsgnRptID, val) {}

    }


    /// <summary>
    /// StreamAsgnRejReason Field
    /// </summary>/
    public sealed class StreamAsgnRejReason : IntField
    {
        public const int TAG = 1502;

        public StreamAsgnRejReason()
            :base(Tags.StreamAsgnRejReason) {}
        public StreamAsgnRejReason(int val)
            :base(Tags.StreamAsgnRejReason, val) {}


        // Field Enumerations
        public const int UNKNOWN_CLIENT = 0;
        public const int EXCEEDS_MAXIMUM_SIZE = 1;
        public const int UNKNOWN_OR_INVALID_CURRENCY_PAIR = 2;
        public const int NO_AVAILABLE_STREAM = 3;
        public const int OTHER = 99;
    }


    /// <summary>
    /// StreamAsgnAckType Field
    /// </summary>/
    public sealed class StreamAsgnAckType : IntField
    {
        public const int TAG = 1503;

        public StreamAsgnAckType()
            :base(Tags.StreamAsgnAckType) {}
        public StreamAsgnAckType(int val)
            :base(Tags.StreamAsgnAckType, val) {}


        // Field Enumerations
        public const int ASSIGNMENT_ACCEPTED = 0;
        public const int ASSIGNMENT_REJECTED = 1;
    }


    /// <summary>
    /// RelSymTransactTime Field
    /// </summary>/
    public sealed class RelSymTransactTime : DateTimeField
    {
        public const int TAG = 1504;

        public RelSymTransactTime()
            :base(Tags.RelSymTransactTime) {}
        public RelSymTransactTime(DateTime val)
            :base(Tags.RelSymTransactTime, val) {}
        public RelSymTransactTime(DateTime val, bool showMilliseconds)
            :base(Tags.RelSymTransactTime, val, showMilliseconds) {}
		public RelSymTransactTime(DateTime val, Converters.TimeStampPrecision precision)
            :base(Tags.RelSymTransactTime, val, precision) {}

    }


    /// <summary>
    /// PartyDetailsListRequestID Field
    /// </summary>/
    public sealed class PartyDetailsListRequestID : StringField
    {
        public const int TAG = 1505;

        public PartyDetailsListRequestID()
            :base(Tags.PartyDetailsListRequestID) {}
        public PartyDetailsListRequestID(string val)
            :base(Tags.PartyDetailsListRequestID, val) {}

    }


    /// <summary>
    /// NoPartyListResponseTypes Field
    /// </summary>/
    public sealed class NoPartyListResponseTypes : IntField
    {
        public const int TAG = 1506;

        public NoPartyListResponseTypes()
            :base(Tags.NoPartyListResponseTypes) {}
        public NoPartyListResponseTypes(int val)
            :base(Tags.NoPartyListResponseTypes, val) {}

    }


    /// <summary>
    /// PartyListResponseType Field
    /// </summary>/
    public sealed class PartyListResponseType : IntField
    {
        public const int TAG = 1507;

        public PartyListResponseType()
            :base(Tags.PartyListResponseType) {}
        public PartyListResponseType(int val)
            :base(Tags.PartyListResponseType, val) {}


        // Field Enumerations
        public const int RETURN_ALL_AVAILABLE_INFORMATION_ON_PARTIES_AND_RELATED_PARTIES = 0;
        public const int RETURN_ONLY_PARTY_INFORMATION = 1;
        public const int INCLUDE_INFORMATION_ON_RELATED_PARTIES = 2;
        public const int INCLUDE_RISK_LIMIT_INFORMATION = 3;
    }


    /// <summary>
    /// NoRequestedPartyRoles Field
    /// </summary>/
    public sealed class NoRequestedPartyRoles : IntField
    {
        public const int TAG = 1508;

        public NoRequestedPartyRoles()
            :base(Tags.NoRequestedPartyRoles) {}
        public NoRequestedPartyRoles(int val)
            :base(Tags.NoRequestedPartyRoles, val) {}

    }


    /// <summary>
    /// RequestedPartyRole Field
    /// </summary>/
    public sealed class RequestedPartyRole : IntField
    {
        public const int TAG = 1509;

        public RequestedPartyRole()
            :base(Tags.RequestedPartyRole) {}
        public RequestedPartyRole(int val)
            :base(Tags.RequestedPartyRole, val) {}

    }


    /// <summary>
    /// PartyDetailsListReportID Field
    /// </summary>/
    public sealed class PartyDetailsListReportID : StringField
    {
        public const int TAG = 1510;

        public PartyDetailsListReportID()
            :base(Tags.PartyDetailsListReportID) {}
        public PartyDetailsListReportID(string val)
            :base(Tags.PartyDetailsListReportID, val) {}

    }


    /// <summary>
    /// PartyDetailsRequestResult Field
    /// </summary>/
    public sealed class PartyDetailsRequestResult : IntField
    {
        public const int TAG = 1511;

        public PartyDetailsRequestResult()
            :base(Tags.PartyDetailsRequestResult) {}
        public PartyDetailsRequestResult(int val)
            :base(Tags.PartyDetailsRequestResult, val) {}


        // Field Enumerations
        public const int VALID_REQUEST = 0;
        public const int INVALID_OR_UNSUPPORTED_REQUEST = 1;
        public const int NO_PARTIES_OR_PARTY_DETAILS_FOUND_THAT_MATCH_SELECTION_CRITERIA = 2;
        public const int UNSUPPORTED_PARTYLISTRESPONSETYPE = 3;
        public const int NOT_AUTHORIZED_TO_RETRIEVE_PARTIES_OR_PARTY_DETAILS_DATA = 4;
        public const int PARTIES_OR_PARTY_DETAILS_DATA_TEMPORARILY_UNAVAILABLE = 5;
        public const int REQUEST_FOR_PARTIES_DATA_NOT_SUPPORTED = 6;
        public const int OTHER = 99;
    }


    /// <summary>
    /// TotNoPartyList Field
    /// </summary>/
    public sealed class TotNoPartyList : IntField
    {
        public const int TAG = 1512;

        public TotNoPartyList()
            :base(Tags.TotNoPartyList) {}
        public TotNoPartyList(int val)
            :base(Tags.TotNoPartyList, val) {}

    }


    /// <summary>
    /// NoPartyList Field
    /// </summary>/
    public sealed class NoPartyList : IntField
    {
        public const int TAG = 1513;

        public NoPartyList()
            :base(Tags.NoPartyList) {}
        public NoPartyList(int val)
            :base(Tags.NoPartyList, val) {}

    }


    /// <summary>
    /// NoPartyRelationships Field
    /// </summary>/
    public sealed class NoPartyRelationships : IntField
    {
        public const int TAG = 1514;

        public NoPartyRelationships()
            :base(Tags.NoPartyRelationships) {}
        public NoPartyRelationships(int val)
            :base(Tags.NoPartyRelationships, val) {}

    }


    /// <summary>
    /// PartyRelationship Field
    /// </summary>/
    public sealed class PartyRelationship : IntField
    {
        public const int TAG = 1515;

        public PartyRelationship()
            :base(Tags.PartyRelationship) {}
        public PartyRelationship(int val)
            :base(Tags.PartyRelationship, val) {}


        // Field Enumerations
        public const int IS_ALSO = 0;
        public const int CLEARS_FOR = 1;
        public const int CLEARS_THROUGH = 2;
        public const int TRADES_FOR = 3;
        public const int TRADES_THROUGH = 4;
        public const int SPONSORS = 5;
        public const int SPONSORED_THROUGH = 6;
        public const int PROVIDES_GUARANTEE_FOR = 7;
        public const int IS_GUARANTEED_BY = 8;
        public const int MEMBER_OF = 9;
        public const int HAS_MEMBERS = 10;
        public const int PROVIDES_MARKETPLACE_FOR = 11;
        public const int PARTICIPANT_OF_MARKETPLACE = 12;
        public const int CARRIES_POSITIONS_FOR = 13;
        public const int POSTS_TRADES_TO = 14;
        public const int ENTERS_TRADES_FOR = 15;
        public const int ENTERS_TRADES_THROUGH = 16;
        public const int PROVIDES_QUOTES_TO = 17;
        public const int REQUESTS_QUOTES_FROM = 18;
        public const int INVESTS_FOR = 19;
        public const int INVESTS_THROUGH = 20;
        public const int BROKERS_TRADES_FOR = 21;
        public const int BROKERS_TRADES_THROUGH = 22;
        public const int PROVIDES_TRADING_SERVICES_FOR = 23;
        public const int USES_TRADING_SERVICES_OF = 24;
        public const int APPROVES_OF = 25;
        public const int APPROVED_BY = 26;
        public const int PARENT_FIRM_FOR = 27;
        public const int SUBSIDIARY_OF = 28;
        public const int REGULATORY_OWNER_OF = 29;
        public const int OWNED_BY_30 = 30;
        public const int CONTROLS = 31;
        public const int IS_CONTROLLED_BY = 32;
        public const int LEGAL = 33;
        public const int OWNED_BY_34 = 34;
        public const int BENEFICIAL_OWNER_OF = 35;
        public const int OWNED_BY_36 = 36;
    }


    /// <summary>
    /// NoPartyAltIDs Field
    /// </summary>/
    public sealed class NoPartyAltIDs : IntField
    {
        public const int TAG = 1516;

        public NoPartyAltIDs()
            :base(Tags.NoPartyAltIDs) {}
        public NoPartyAltIDs(int val)
            :base(Tags.NoPartyAltIDs, val) {}

    }


    /// <summary>
    /// PartyAltID Field
    /// </summary>/
    public sealed class PartyAltID : StringField
    {
        public const int TAG = 1517;

        public PartyAltID()
            :base(Tags.PartyAltID) {}
        public PartyAltID(string val)
            :base(Tags.PartyAltID, val) {}

    }


    /// <summary>
    /// PartyAltIDSource Field
    /// </summary>/
    public sealed class PartyAltIDSource : CharField
    {
        public const int TAG = 1518;

        public PartyAltIDSource()
            :base(Tags.PartyAltIDSource) {}
        public PartyAltIDSource(char val)
            :base(Tags.PartyAltIDSource, val) {}

    }


    /// <summary>
    /// NoPartyAltSubIDs Field
    /// </summary>/
    public sealed class NoPartyAltSubIDs : IntField
    {
        public const int TAG = 1519;

        public NoPartyAltSubIDs()
            :base(Tags.NoPartyAltSubIDs) {}
        public NoPartyAltSubIDs(int val)
            :base(Tags.NoPartyAltSubIDs, val) {}

    }


    /// <summary>
    /// PartyAltSubID Field
    /// </summary>/
    public sealed class PartyAltSubID : StringField
    {
        public const int TAG = 1520;

        public PartyAltSubID()
            :base(Tags.PartyAltSubID) {}
        public PartyAltSubID(string val)
            :base(Tags.PartyAltSubID, val) {}

    }


    /// <summary>
    /// PartyAltSubIDType Field
    /// </summary>/
    public sealed class PartyAltSubIDType : IntField
    {
        public const int TAG = 1521;

        public PartyAltSubIDType()
            :base(Tags.PartyAltSubIDType) {}
        public PartyAltSubIDType(int val)
            :base(Tags.PartyAltSubIDType, val) {}

    }


    /// <summary>
    /// NoContextPartyIDs Field
    /// </summary>/
    public sealed class NoContextPartyIDs : IntField
    {
        public const int TAG = 1522;

        public NoContextPartyIDs()
            :base(Tags.NoContextPartyIDs) {}
        public NoContextPartyIDs(int val)
            :base(Tags.NoContextPartyIDs, val) {}

    }


    /// <summary>
    /// ContextPartyID Field
    /// </summary>/
    public sealed class ContextPartyID : StringField
    {
        public const int TAG = 1523;

        public ContextPartyID()
            :base(Tags.ContextPartyID) {}
        public ContextPartyID(string val)
            :base(Tags.ContextPartyID, val) {}

    }


    /// <summary>
    /// ContextPartyIDSource Field
    /// </summary>/
    public sealed class ContextPartyIDSource : CharField
    {
        public const int TAG = 1524;

        public ContextPartyIDSource()
            :base(Tags.ContextPartyIDSource) {}
        public ContextPartyIDSource(char val)
            :base(Tags.ContextPartyIDSource, val) {}

    }


    /// <summary>
    /// ContextPartyRole Field
    /// </summary>/
    public sealed class ContextPartyRole : IntField
    {
        public const int TAG = 1525;

        public ContextPartyRole()
            :base(Tags.ContextPartyRole) {}
        public ContextPartyRole(int val)
            :base(Tags.ContextPartyRole, val) {}

    }


    /// <summary>
    /// NoContextPartySubIDs Field
    /// </summary>/
    public sealed class NoContextPartySubIDs : IntField
    {
        public const int TAG = 1526;

        public NoContextPartySubIDs()
            :base(Tags.NoContextPartySubIDs) {}
        public NoContextPartySubIDs(int val)
            :base(Tags.NoContextPartySubIDs, val) {}

    }


    /// <summary>
    /// ContextPartySubID Field
    /// </summary>/
    public sealed class ContextPartySubID : StringField
    {
        public const int TAG = 1527;

        public ContextPartySubID()
            :base(Tags.ContextPartySubID) {}
        public ContextPartySubID(string val)
            :base(Tags.ContextPartySubID, val) {}

    }


    /// <summary>
    /// ContextPartySubIDType Field
    /// </summary>/
    public sealed class ContextPartySubIDType : IntField
    {
        public const int TAG = 1528;

        public ContextPartySubIDType()
            :base(Tags.ContextPartySubIDType) {}
        public ContextPartySubIDType(int val)
            :base(Tags.ContextPartySubIDType, val) {}

    }


    /// <summary>
    /// NoRiskLimits Field
    /// </summary>/
    public sealed class NoRiskLimits : IntField
    {
        public const int TAG = 1529;

        public NoRiskLimits()
            :base(Tags.NoRiskLimits) {}
        public NoRiskLimits(int val)
            :base(Tags.NoRiskLimits, val) {}

    }


    /// <summary>
    /// RiskLimitType Field
    /// </summary>/
    public sealed class RiskLimitType : IntField
    {
        public const int TAG = 1530;

        public RiskLimitType()
            :base(Tags.RiskLimitType) {}
        public RiskLimitType(int val)
            :base(Tags.RiskLimitType, val) {}


        // Field Enumerations
        public const int GROSS_LIMIT = 1;
        public const int NET_LIMIT = 2;
        public const int EXPOSURE = 3;
        public const int LONG_LIMIT = 4;
        public const int SHORT_LIMIT = 5;
    }


    /// <summary>
    /// RiskLimitAmount Field
    /// </summary>/
    public sealed class RiskLimitAmount : DecimalField
    {
        public const int TAG = 1531;

        public RiskLimitAmount()
            :base(Tags.RiskLimitAmount) {}
        public RiskLimitAmount(Decimal val)
            :base(Tags.RiskLimitAmount, val) {}

    }


    /// <summary>
    /// RiskLimitCurrency Field
    /// </summary>/
    public sealed class RiskLimitCurrency : StringField
    {
        public const int TAG = 1532;

        public RiskLimitCurrency()
            :base(Tags.RiskLimitCurrency) {}
        public RiskLimitCurrency(string val)
            :base(Tags.RiskLimitCurrency, val) {}

    }


    /// <summary>
    /// RiskLimitPlatform Field
    /// </summary>/
    public sealed class RiskLimitPlatform : StringField
    {
        public const int TAG = 1533;

        public RiskLimitPlatform()
            :base(Tags.RiskLimitPlatform) {}
        public RiskLimitPlatform(string val)
            :base(Tags.RiskLimitPlatform, val) {}

    }


    /// <summary>
    /// NoRiskInstruments Field
    /// </summary>/
    public sealed class NoRiskInstruments : IntField
    {
        public const int TAG = 1534;

        public NoRiskInstruments()
            :base(Tags.NoRiskInstruments) {}
        public NoRiskInstruments(int val)
            :base(Tags.NoRiskInstruments, val) {}

    }


    /// <summary>
    /// RiskInstrumentOperator Field
    /// </summary>/
    public sealed class RiskInstrumentOperator : IntField
    {
        public const int TAG = 1535;

        public RiskInstrumentOperator()
            :base(Tags.RiskInstrumentOperator) {}
        public RiskInstrumentOperator(int val)
            :base(Tags.RiskInstrumentOperator, val) {}


        // Field Enumerations
        public const int INCLUDE = 1;
        public const int EXCLUDE = 2;
    }


    /// <summary>
    /// RiskSymbol Field
    /// </summary>/
    public sealed class RiskSymbol : StringField
    {
        public const int TAG = 1536;

        public RiskSymbol()
            :base(Tags.RiskSymbol) {}
        public RiskSymbol(string val)
            :base(Tags.RiskSymbol, val) {}

    }


    /// <summary>
    /// RiskSymbolSfx Field
    /// </summary>/
    public sealed class RiskSymbolSfx : StringField
    {
        public const int TAG = 1537;

        public RiskSymbolSfx()
            :base(Tags.RiskSymbolSfx) {}
        public RiskSymbolSfx(string val)
            :base(Tags.RiskSymbolSfx, val) {}

    }


    /// <summary>
    /// RiskSecurityID Field
    /// </summary>/
    public sealed class RiskSecurityID : StringField
    {
        public const int TAG = 1538;

        public RiskSecurityID()
            :base(Tags.RiskSecurityID) {}
        public RiskSecurityID(string val)
            :base(Tags.RiskSecurityID, val) {}

    }


    /// <summary>
    /// RiskSecurityIDSource Field
    /// </summary>/
    public sealed class RiskSecurityIDSource : StringField
    {
        public const int TAG = 1539;

        public RiskSecurityIDSource()
            :base(Tags.RiskSecurityIDSource) {}
        public RiskSecurityIDSource(string val)
            :base(Tags.RiskSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoRiskSecurityAltID Field
    /// </summary>/
    public sealed class NoRiskSecurityAltID : IntField
    {
        public const int TAG = 1540;

        public NoRiskSecurityAltID()
            :base(Tags.NoRiskSecurityAltID) {}
        public NoRiskSecurityAltID(int val)
            :base(Tags.NoRiskSecurityAltID, val) {}

    }


    /// <summary>
    /// RiskSecurityAltID Field
    /// </summary>/
    public sealed class RiskSecurityAltID : StringField
    {
        public const int TAG = 1541;

        public RiskSecurityAltID()
            :base(Tags.RiskSecurityAltID) {}
        public RiskSecurityAltID(string val)
            :base(Tags.RiskSecurityAltID, val) {}

    }


    /// <summary>
    /// RiskSecurityAltIDSource Field
    /// </summary>/
    public sealed class RiskSecurityAltIDSource : StringField
    {
        public const int TAG = 1542;

        public RiskSecurityAltIDSource()
            :base(Tags.RiskSecurityAltIDSource) {}
        public RiskSecurityAltIDSource(string val)
            :base(Tags.RiskSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// RiskProduct Field
    /// </summary>/
    public sealed class RiskProduct : IntField
    {
        public const int TAG = 1543;

        public RiskProduct()
            :base(Tags.RiskProduct) {}
        public RiskProduct(int val)
            :base(Tags.RiskProduct, val) {}

    }


    /// <summary>
    /// RiskProductComplex Field
    /// </summary>/
    public sealed class RiskProductComplex : StringField
    {
        public const int TAG = 1544;

        public RiskProductComplex()
            :base(Tags.RiskProductComplex) {}
        public RiskProductComplex(string val)
            :base(Tags.RiskProductComplex, val) {}

    }


    /// <summary>
    /// RiskSecurityGroup Field
    /// </summary>/
    public sealed class RiskSecurityGroup : StringField
    {
        public const int TAG = 1545;

        public RiskSecurityGroup()
            :base(Tags.RiskSecurityGroup) {}
        public RiskSecurityGroup(string val)
            :base(Tags.RiskSecurityGroup, val) {}

    }


    /// <summary>
    /// RiskCFICode Field
    /// </summary>/
    public sealed class RiskCFICode : StringField
    {
        public const int TAG = 1546;

        public RiskCFICode()
            :base(Tags.RiskCFICode) {}
        public RiskCFICode(string val)
            :base(Tags.RiskCFICode, val) {}

    }


    /// <summary>
    /// RiskSecurityType Field
    /// </summary>/
    public sealed class RiskSecurityType : StringField
    {
        public const int TAG = 1547;

        public RiskSecurityType()
            :base(Tags.RiskSecurityType) {}
        public RiskSecurityType(string val)
            :base(Tags.RiskSecurityType, val) {}

    }


    /// <summary>
    /// RiskSecuritySubType Field
    /// </summary>/
    public sealed class RiskSecuritySubType : StringField
    {
        public const int TAG = 1548;

        public RiskSecuritySubType()
            :base(Tags.RiskSecuritySubType) {}
        public RiskSecuritySubType(string val)
            :base(Tags.RiskSecuritySubType, val) {}

    }


    /// <summary>
    /// RiskMaturityMonthYear Field
    /// </summary>/
    public sealed class RiskMaturityMonthYear : StringField
    {
        public const int TAG = 1549;

        public RiskMaturityMonthYear()
            :base(Tags.RiskMaturityMonthYear) {}
        public RiskMaturityMonthYear(string val)
            :base(Tags.RiskMaturityMonthYear, val) {}

    }


    /// <summary>
    /// RiskMaturityTime Field
    /// </summary>/
    public sealed class RiskMaturityTime : StringField
    {
        public const int TAG = 1550;

        public RiskMaturityTime()
            :base(Tags.RiskMaturityTime) {}
        public RiskMaturityTime(string val)
            :base(Tags.RiskMaturityTime, val) {}

    }


    /// <summary>
    /// RiskRestructuringType Field
    /// </summary>/
    public sealed class RiskRestructuringType : StringField
    {
        public const int TAG = 1551;

        public RiskRestructuringType()
            :base(Tags.RiskRestructuringType) {}
        public RiskRestructuringType(string val)
            :base(Tags.RiskRestructuringType, val) {}

    }


    /// <summary>
    /// RiskSeniority Field
    /// </summary>/
    public sealed class RiskSeniority : StringField
    {
        public const int TAG = 1552;

        public RiskSeniority()
            :base(Tags.RiskSeniority) {}
        public RiskSeniority(string val)
            :base(Tags.RiskSeniority, val) {}

    }


    /// <summary>
    /// RiskPutOrCall Field
    /// </summary>/
    public sealed class RiskPutOrCall : IntField
    {
        public const int TAG = 1553;

        public RiskPutOrCall()
            :base(Tags.RiskPutOrCall) {}
        public RiskPutOrCall(int val)
            :base(Tags.RiskPutOrCall, val) {}

    }


    /// <summary>
    /// RiskFlexibleIndicator Field
    /// </summary>/
    public sealed class RiskFlexibleIndicator : BooleanField
    {
        public const int TAG = 1554;

        public RiskFlexibleIndicator()
            :base(Tags.RiskFlexibleIndicator) {}
        public RiskFlexibleIndicator(Boolean val)
            :base(Tags.RiskFlexibleIndicator, val) {}

    }


    /// <summary>
    /// RiskCouponRate Field
    /// </summary>/
    public sealed class RiskCouponRate : DecimalField
    {
        public const int TAG = 1555;

        public RiskCouponRate()
            :base(Tags.RiskCouponRate) {}
        public RiskCouponRate(Decimal val)
            :base(Tags.RiskCouponRate, val) {}

    }


    /// <summary>
    /// RiskSecurityDesc Field
    /// </summary>/
    public sealed class RiskSecurityDesc : StringField
    {
        public const int TAG = 1556;

        public RiskSecurityDesc()
            :base(Tags.RiskSecurityDesc) {}
        public RiskSecurityDesc(string val)
            :base(Tags.RiskSecurityDesc, val) {}

    }


    /// <summary>
    /// RiskInstrumentSettlType Field
    /// </summary>/
    public sealed class RiskInstrumentSettlType : StringField
    {
        public const int TAG = 1557;

        public RiskInstrumentSettlType()
            :base(Tags.RiskInstrumentSettlType) {}
        public RiskInstrumentSettlType(string val)
            :base(Tags.RiskInstrumentSettlType, val) {}

    }


    /// <summary>
    /// RiskInstrumentMultiplier Field
    /// </summary>/
    public sealed class RiskInstrumentMultiplier : DecimalField
    {
        public const int TAG = 1558;

        public RiskInstrumentMultiplier()
            :base(Tags.RiskInstrumentMultiplier) {}
        public RiskInstrumentMultiplier(Decimal val)
            :base(Tags.RiskInstrumentMultiplier, val) {}

    }


    /// <summary>
    /// NoRiskWarningLevels Field
    /// </summary>/
    public sealed class NoRiskWarningLevels : IntField
    {
        public const int TAG = 1559;

        public NoRiskWarningLevels()
            :base(Tags.NoRiskWarningLevels) {}
        public NoRiskWarningLevels(int val)
            :base(Tags.NoRiskWarningLevels, val) {}

    }


    /// <summary>
    /// RiskWarningLevelPercent Field
    /// </summary>/
    public sealed class RiskWarningLevelPercent : DecimalField
    {
        public const int TAG = 1560;

        public RiskWarningLevelPercent()
            :base(Tags.RiskWarningLevelPercent) {}
        public RiskWarningLevelPercent(Decimal val)
            :base(Tags.RiskWarningLevelPercent, val) {}

    }


    /// <summary>
    /// RiskWarningLevelName Field
    /// </summary>/
    public sealed class RiskWarningLevelName : StringField
    {
        public const int TAG = 1561;

        public RiskWarningLevelName()
            :base(Tags.RiskWarningLevelName) {}
        public RiskWarningLevelName(string val)
            :base(Tags.RiskWarningLevelName, val) {}

    }


    /// <summary>
    /// NoRelatedPartyIDs Field
    /// </summary>/
    public sealed class NoRelatedPartyIDs : IntField
    {
        public const int TAG = 1562;

        public NoRelatedPartyIDs()
            :base(Tags.NoRelatedPartyIDs) {}
        public NoRelatedPartyIDs(int val)
            :base(Tags.NoRelatedPartyIDs, val) {}

    }


    /// <summary>
    /// RelatedPartyID Field
    /// </summary>/
    public sealed class RelatedPartyID : StringField
    {
        public const int TAG = 1563;

        public RelatedPartyID()
            :base(Tags.RelatedPartyID) {}
        public RelatedPartyID(string val)
            :base(Tags.RelatedPartyID, val) {}

    }


    /// <summary>
    /// RelatedPartyIDSource Field
    /// </summary>/
    public sealed class RelatedPartyIDSource : CharField
    {
        public const int TAG = 1564;

        public RelatedPartyIDSource()
            :base(Tags.RelatedPartyIDSource) {}
        public RelatedPartyIDSource(char val)
            :base(Tags.RelatedPartyIDSource, val) {}

    }


    /// <summary>
    /// RelatedPartyRole Field
    /// </summary>/
    public sealed class RelatedPartyRole : IntField
    {
        public const int TAG = 1565;

        public RelatedPartyRole()
            :base(Tags.RelatedPartyRole) {}
        public RelatedPartyRole(int val)
            :base(Tags.RelatedPartyRole, val) {}

    }


    /// <summary>
    /// NoRelatedPartySubIDs Field
    /// </summary>/
    public sealed class NoRelatedPartySubIDs : IntField
    {
        public const int TAG = 1566;

        public NoRelatedPartySubIDs()
            :base(Tags.NoRelatedPartySubIDs) {}
        public NoRelatedPartySubIDs(int val)
            :base(Tags.NoRelatedPartySubIDs, val) {}

    }


    /// <summary>
    /// RelatedPartySubID Field
    /// </summary>/
    public sealed class RelatedPartySubID : StringField
    {
        public const int TAG = 1567;

        public RelatedPartySubID()
            :base(Tags.RelatedPartySubID) {}
        public RelatedPartySubID(string val)
            :base(Tags.RelatedPartySubID, val) {}

    }


    /// <summary>
    /// RelatedPartySubIDType Field
    /// </summary>/
    public sealed class RelatedPartySubIDType : IntField
    {
        public const int TAG = 1568;

        public RelatedPartySubIDType()
            :base(Tags.RelatedPartySubIDType) {}
        public RelatedPartySubIDType(int val)
            :base(Tags.RelatedPartySubIDType, val) {}

    }


    /// <summary>
    /// NoRelatedPartyAltIDs Field
    /// </summary>/
    public sealed class NoRelatedPartyAltIDs : IntField
    {
        public const int TAG = 1569;

        public NoRelatedPartyAltIDs()
            :base(Tags.NoRelatedPartyAltIDs) {}
        public NoRelatedPartyAltIDs(int val)
            :base(Tags.NoRelatedPartyAltIDs, val) {}

    }


    /// <summary>
    /// RelatedPartyAltID Field
    /// </summary>/
    public sealed class RelatedPartyAltID : StringField
    {
        public const int TAG = 1570;

        public RelatedPartyAltID()
            :base(Tags.RelatedPartyAltID) {}
        public RelatedPartyAltID(string val)
            :base(Tags.RelatedPartyAltID, val) {}

    }


    /// <summary>
    /// RelatedPartyAltIDSource Field
    /// </summary>/
    public sealed class RelatedPartyAltIDSource : CharField
    {
        public const int TAG = 1571;

        public RelatedPartyAltIDSource()
            :base(Tags.RelatedPartyAltIDSource) {}
        public RelatedPartyAltIDSource(char val)
            :base(Tags.RelatedPartyAltIDSource, val) {}

    }


    /// <summary>
    /// NoRelatedPartyAltSubIDs Field
    /// </summary>/
    public sealed class NoRelatedPartyAltSubIDs : IntField
    {
        public const int TAG = 1572;

        public NoRelatedPartyAltSubIDs()
            :base(Tags.NoRelatedPartyAltSubIDs) {}
        public NoRelatedPartyAltSubIDs(int val)
            :base(Tags.NoRelatedPartyAltSubIDs, val) {}

    }


    /// <summary>
    /// RelatedPartyAltSubID Field
    /// </summary>/
    public sealed class RelatedPartyAltSubID : StringField
    {
        public const int TAG = 1573;

        public RelatedPartyAltSubID()
            :base(Tags.RelatedPartyAltSubID) {}
        public RelatedPartyAltSubID(string val)
            :base(Tags.RelatedPartyAltSubID, val) {}

    }


    /// <summary>
    /// RelatedPartyAltSubIDType Field
    /// </summary>/
    public sealed class RelatedPartyAltSubIDType : IntField
    {
        public const int TAG = 1574;

        public RelatedPartyAltSubIDType()
            :base(Tags.RelatedPartyAltSubIDType) {}
        public RelatedPartyAltSubIDType(int val)
            :base(Tags.RelatedPartyAltSubIDType, val) {}

    }


    /// <summary>
    /// NoRelatedContextPartyIDs Field
    /// </summary>/
    public sealed class NoRelatedContextPartyIDs : IntField
    {
        public const int TAG = 1575;

        public NoRelatedContextPartyIDs()
            :base(Tags.NoRelatedContextPartyIDs) {}
        public NoRelatedContextPartyIDs(int val)
            :base(Tags.NoRelatedContextPartyIDs, val) {}

    }


    /// <summary>
    /// RelatedContextPartyID Field
    /// </summary>/
    public sealed class RelatedContextPartyID : StringField
    {
        public const int TAG = 1576;

        public RelatedContextPartyID()
            :base(Tags.RelatedContextPartyID) {}
        public RelatedContextPartyID(string val)
            :base(Tags.RelatedContextPartyID, val) {}

    }


    /// <summary>
    /// RelatedContextPartyIDSource Field
    /// </summary>/
    public sealed class RelatedContextPartyIDSource : CharField
    {
        public const int TAG = 1577;

        public RelatedContextPartyIDSource()
            :base(Tags.RelatedContextPartyIDSource) {}
        public RelatedContextPartyIDSource(char val)
            :base(Tags.RelatedContextPartyIDSource, val) {}

    }


    /// <summary>
    /// RelatedContextPartyRole Field
    /// </summary>/
    public sealed class RelatedContextPartyRole : IntField
    {
        public const int TAG = 1578;

        public RelatedContextPartyRole()
            :base(Tags.RelatedContextPartyRole) {}
        public RelatedContextPartyRole(int val)
            :base(Tags.RelatedContextPartyRole, val) {}

    }


    /// <summary>
    /// NoRelatedContextPartySubIDs Field
    /// </summary>/
    public sealed class NoRelatedContextPartySubIDs : IntField
    {
        public const int TAG = 1579;

        public NoRelatedContextPartySubIDs()
            :base(Tags.NoRelatedContextPartySubIDs) {}
        public NoRelatedContextPartySubIDs(int val)
            :base(Tags.NoRelatedContextPartySubIDs, val) {}

    }


    /// <summary>
    /// RelatedContextPartySubID Field
    /// </summary>/
    public sealed class RelatedContextPartySubID : StringField
    {
        public const int TAG = 1580;

        public RelatedContextPartySubID()
            :base(Tags.RelatedContextPartySubID) {}
        public RelatedContextPartySubID(string val)
            :base(Tags.RelatedContextPartySubID, val) {}

    }


    /// <summary>
    /// RelatedContextPartySubIDType Field
    /// </summary>/
    public sealed class RelatedContextPartySubIDType : IntField
    {
        public const int TAG = 1581;

        public RelatedContextPartySubIDType()
            :base(Tags.RelatedContextPartySubIDType) {}
        public RelatedContextPartySubIDType(int val)
            :base(Tags.RelatedContextPartySubIDType, val) {}

    }


    /// <summary>
    /// NoRelationshipRiskLimits Field
    /// </summary>/
    public sealed class NoRelationshipRiskLimits : IntField
    {
        public const int TAG = 1582;

        public NoRelationshipRiskLimits()
            :base(Tags.NoRelationshipRiskLimits) {}
        public NoRelationshipRiskLimits(int val)
            :base(Tags.NoRelationshipRiskLimits, val) {}

    }


    /// <summary>
    /// RelationshipRiskLimitType Field
    /// </summary>/
    public sealed class RelationshipRiskLimitType : IntField
    {
        public const int TAG = 1583;

        public RelationshipRiskLimitType()
            :base(Tags.RelationshipRiskLimitType) {}
        public RelationshipRiskLimitType(int val)
            :base(Tags.RelationshipRiskLimitType, val) {}

    }


    /// <summary>
    /// RelationshipRiskLimitAmount Field
    /// </summary>/
    public sealed class RelationshipRiskLimitAmount : DecimalField
    {
        public const int TAG = 1584;

        public RelationshipRiskLimitAmount()
            :base(Tags.RelationshipRiskLimitAmount) {}
        public RelationshipRiskLimitAmount(Decimal val)
            :base(Tags.RelationshipRiskLimitAmount, val) {}

    }


    /// <summary>
    /// RelationshipRiskLimitCurrency Field
    /// </summary>/
    public sealed class RelationshipRiskLimitCurrency : StringField
    {
        public const int TAG = 1585;

        public RelationshipRiskLimitCurrency()
            :base(Tags.RelationshipRiskLimitCurrency) {}
        public RelationshipRiskLimitCurrency(string val)
            :base(Tags.RelationshipRiskLimitCurrency, val) {}

    }


    /// <summary>
    /// RelationshipRiskLimitPlatform Field
    /// </summary>/
    public sealed class RelationshipRiskLimitPlatform : StringField
    {
        public const int TAG = 1586;

        public RelationshipRiskLimitPlatform()
            :base(Tags.RelationshipRiskLimitPlatform) {}
        public RelationshipRiskLimitPlatform(string val)
            :base(Tags.RelationshipRiskLimitPlatform, val) {}

    }


    /// <summary>
    /// NoRelationshipRiskInstruments Field
    /// </summary>/
    public sealed class NoRelationshipRiskInstruments : IntField
    {
        public const int TAG = 1587;

        public NoRelationshipRiskInstruments()
            :base(Tags.NoRelationshipRiskInstruments) {}
        public NoRelationshipRiskInstruments(int val)
            :base(Tags.NoRelationshipRiskInstruments, val) {}

    }


    /// <summary>
    /// RelationshipRiskInstrumentOperator Field
    /// </summary>/
    public sealed class RelationshipRiskInstrumentOperator : IntField
    {
        public const int TAG = 1588;

        public RelationshipRiskInstrumentOperator()
            :base(Tags.RelationshipRiskInstrumentOperator) {}
        public RelationshipRiskInstrumentOperator(int val)
            :base(Tags.RelationshipRiskInstrumentOperator, val) {}

    }


    /// <summary>
    /// RelationshipRiskSymbol Field
    /// </summary>/
    public sealed class RelationshipRiskSymbol : StringField
    {
        public const int TAG = 1589;

        public RelationshipRiskSymbol()
            :base(Tags.RelationshipRiskSymbol) {}
        public RelationshipRiskSymbol(string val)
            :base(Tags.RelationshipRiskSymbol, val) {}

    }


    /// <summary>
    /// RelationshipRiskSymbolSfx Field
    /// </summary>/
    public sealed class RelationshipRiskSymbolSfx : StringField
    {
        public const int TAG = 1590;

        public RelationshipRiskSymbolSfx()
            :base(Tags.RelationshipRiskSymbolSfx) {}
        public RelationshipRiskSymbolSfx(string val)
            :base(Tags.RelationshipRiskSymbolSfx, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityID Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityID : StringField
    {
        public const int TAG = 1591;

        public RelationshipRiskSecurityID()
            :base(Tags.RelationshipRiskSecurityID) {}
        public RelationshipRiskSecurityID(string val)
            :base(Tags.RelationshipRiskSecurityID, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityIDSource Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityIDSource : StringField
    {
        public const int TAG = 1592;

        public RelationshipRiskSecurityIDSource()
            :base(Tags.RelationshipRiskSecurityIDSource) {}
        public RelationshipRiskSecurityIDSource(string val)
            :base(Tags.RelationshipRiskSecurityIDSource, val) {}

    }


    /// <summary>
    /// NoRelationshipRiskSecurityAltID Field
    /// </summary>/
    public sealed class NoRelationshipRiskSecurityAltID : IntField
    {
        public const int TAG = 1593;

        public NoRelationshipRiskSecurityAltID()
            :base(Tags.NoRelationshipRiskSecurityAltID) {}
        public NoRelationshipRiskSecurityAltID(int val)
            :base(Tags.NoRelationshipRiskSecurityAltID, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityAltID Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityAltID : StringField
    {
        public const int TAG = 1594;

        public RelationshipRiskSecurityAltID()
            :base(Tags.RelationshipRiskSecurityAltID) {}
        public RelationshipRiskSecurityAltID(string val)
            :base(Tags.RelationshipRiskSecurityAltID, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityAltIDSource Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityAltIDSource : StringField
    {
        public const int TAG = 1595;

        public RelationshipRiskSecurityAltIDSource()
            :base(Tags.RelationshipRiskSecurityAltIDSource) {}
        public RelationshipRiskSecurityAltIDSource(string val)
            :base(Tags.RelationshipRiskSecurityAltIDSource, val) {}

    }


    /// <summary>
    /// RelationshipRiskProduct Field
    /// </summary>/
    public sealed class RelationshipRiskProduct : IntField
    {
        public const int TAG = 1596;

        public RelationshipRiskProduct()
            :base(Tags.RelationshipRiskProduct) {}
        public RelationshipRiskProduct(int val)
            :base(Tags.RelationshipRiskProduct, val) {}

    }


    /// <summary>
    /// RelationshipRiskProductComplex Field
    /// </summary>/
    public sealed class RelationshipRiskProductComplex : StringField
    {
        public const int TAG = 1597;

        public RelationshipRiskProductComplex()
            :base(Tags.RelationshipRiskProductComplex) {}
        public RelationshipRiskProductComplex(string val)
            :base(Tags.RelationshipRiskProductComplex, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityGroup Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityGroup : StringField
    {
        public const int TAG = 1598;

        public RelationshipRiskSecurityGroup()
            :base(Tags.RelationshipRiskSecurityGroup) {}
        public RelationshipRiskSecurityGroup(string val)
            :base(Tags.RelationshipRiskSecurityGroup, val) {}

    }


    /// <summary>
    /// RelationshipRiskCFICode Field
    /// </summary>/
    public sealed class RelationshipRiskCFICode : StringField
    {
        public const int TAG = 1599;

        public RelationshipRiskCFICode()
            :base(Tags.RelationshipRiskCFICode) {}
        public RelationshipRiskCFICode(string val)
            :base(Tags.RelationshipRiskCFICode, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityType Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityType : StringField
    {
        public const int TAG = 1600;

        public RelationshipRiskSecurityType()
            :base(Tags.RelationshipRiskSecurityType) {}
        public RelationshipRiskSecurityType(string val)
            :base(Tags.RelationshipRiskSecurityType, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecuritySubType Field
    /// </summary>/
    public sealed class RelationshipRiskSecuritySubType : StringField
    {
        public const int TAG = 1601;

        public RelationshipRiskSecuritySubType()
            :base(Tags.RelationshipRiskSecuritySubType) {}
        public RelationshipRiskSecuritySubType(string val)
            :base(Tags.RelationshipRiskSecuritySubType, val) {}

    }


    /// <summary>
    /// RelationshipRiskMaturityMonthYear Field
    /// </summary>/
    public sealed class RelationshipRiskMaturityMonthYear : StringField
    {
        public const int TAG = 1602;

        public RelationshipRiskMaturityMonthYear()
            :base(Tags.RelationshipRiskMaturityMonthYear) {}
        public RelationshipRiskMaturityMonthYear(string val)
            :base(Tags.RelationshipRiskMaturityMonthYear, val) {}

    }


    /// <summary>
    /// RelationshipRiskMaturityTime Field
    /// </summary>/
    public sealed class RelationshipRiskMaturityTime : StringField
    {
        public const int TAG = 1603;

        public RelationshipRiskMaturityTime()
            :base(Tags.RelationshipRiskMaturityTime) {}
        public RelationshipRiskMaturityTime(string val)
            :base(Tags.RelationshipRiskMaturityTime, val) {}

    }


    /// <summary>
    /// RelationshipRiskRestructuringType Field
    /// </summary>/
    public sealed class RelationshipRiskRestructuringType : StringField
    {
        public const int TAG = 1604;

        public RelationshipRiskRestructuringType()
            :base(Tags.RelationshipRiskRestructuringType) {}
        public RelationshipRiskRestructuringType(string val)
            :base(Tags.RelationshipRiskRestructuringType, val) {}

    }


    /// <summary>
    /// RelationshipRiskSeniority Field
    /// </summary>/
    public sealed class RelationshipRiskSeniority : StringField
    {
        public const int TAG = 1605;

        public RelationshipRiskSeniority()
            :base(Tags.RelationshipRiskSeniority) {}
        public RelationshipRiskSeniority(string val)
            :base(Tags.RelationshipRiskSeniority, val) {}

    }


    /// <summary>
    /// RelationshipRiskPutOrCall Field
    /// </summary>/
    public sealed class RelationshipRiskPutOrCall : IntField
    {
        public const int TAG = 1606;

        public RelationshipRiskPutOrCall()
            :base(Tags.RelationshipRiskPutOrCall) {}
        public RelationshipRiskPutOrCall(int val)
            :base(Tags.RelationshipRiskPutOrCall, val) {}

    }


    /// <summary>
    /// RelationshipRiskFlexibleIndicator Field
    /// </summary>/
    public sealed class RelationshipRiskFlexibleIndicator : BooleanField
    {
        public const int TAG = 1607;

        public RelationshipRiskFlexibleIndicator()
            :base(Tags.RelationshipRiskFlexibleIndicator) {}
        public RelationshipRiskFlexibleIndicator(Boolean val)
            :base(Tags.RelationshipRiskFlexibleIndicator, val) {}

    }


    /// <summary>
    /// RelationshipRiskCouponRate Field
    /// </summary>/
    public sealed class RelationshipRiskCouponRate : DecimalField
    {
        public const int TAG = 1608;

        public RelationshipRiskCouponRate()
            :base(Tags.RelationshipRiskCouponRate) {}
        public RelationshipRiskCouponRate(Decimal val)
            :base(Tags.RelationshipRiskCouponRate, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityExchange Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityExchange : StringField
    {
        public const int TAG = 1609;

        public RelationshipRiskSecurityExchange()
            :base(Tags.RelationshipRiskSecurityExchange) {}
        public RelationshipRiskSecurityExchange(string val)
            :base(Tags.RelationshipRiskSecurityExchange, val) {}

    }


    /// <summary>
    /// RelationshipRiskSecurityDesc Field
    /// </summary>/
    public sealed class RelationshipRiskSecurityDesc : StringField
    {
        public const int TAG = 1610;

        public RelationshipRiskSecurityDesc()
            :base(Tags.RelationshipRiskSecurityDesc) {}
        public RelationshipRiskSecurityDesc(string val)
            :base(Tags.RelationshipRiskSecurityDesc, val) {}

    }


    /// <summary>
    /// RelationshipRiskInstrumentSettlType Field
    /// </summary>/
    public sealed class RelationshipRiskInstrumentSettlType : StringField
    {
        public const int TAG = 1611;

        public RelationshipRiskInstrumentSettlType()
            :base(Tags.RelationshipRiskInstrumentSettlType) {}
        public RelationshipRiskInstrumentSettlType(string val)
            :base(Tags.RelationshipRiskInstrumentSettlType, val) {}

    }


    /// <summary>
    /// RelationshipRiskInstrumentMultiplier Field
    /// </summary>/
    public sealed class RelationshipRiskInstrumentMultiplier : DecimalField
    {
        public const int TAG = 1612;

        public RelationshipRiskInstrumentMultiplier()
            :base(Tags.RelationshipRiskInstrumentMultiplier) {}
        public RelationshipRiskInstrumentMultiplier(Decimal val)
            :base(Tags.RelationshipRiskInstrumentMultiplier, val) {}

    }


    /// <summary>
    /// NoRelationshipRiskWarningLevels Field
    /// </summary>/
    public sealed class NoRelationshipRiskWarningLevels : IntField
    {
        public const int TAG = 1613;

        public NoRelationshipRiskWarningLevels()
            :base(Tags.NoRelationshipRiskWarningLevels) {}
        public NoRelationshipRiskWarningLevels(int val)
            :base(Tags.NoRelationshipRiskWarningLevels, val) {}

    }


    /// <summary>
    /// RelationshipRiskWarningLevelPercent Field
    /// </summary>/
    public sealed class RelationshipRiskWarningLevelPercent : DecimalField
    {
        public const int TAG = 1614;

        public RelationshipRiskWarningLevelPercent()
            :base(Tags.RelationshipRiskWarningLevelPercent) {}
        public RelationshipRiskWarningLevelPercent(Decimal val)
            :base(Tags.RelationshipRiskWarningLevelPercent, val) {}

    }


    /// <summary>
    /// RelationshipRiskWarningLevelName Field
    /// </summary>/
    public sealed class RelationshipRiskWarningLevelName : StringField
    {
        public const int TAG = 1615;

        public RelationshipRiskWarningLevelName()
            :base(Tags.RelationshipRiskWarningLevelName) {}
        public RelationshipRiskWarningLevelName(string val)
            :base(Tags.RelationshipRiskWarningLevelName, val) {}

    }


    /// <summary>
    /// RiskSecurityExchange Field
    /// </summary>/
    public sealed class RiskSecurityExchange : StringField
    {
        public const int TAG = 1616;

        public RiskSecurityExchange()
            :base(Tags.RiskSecurityExchange) {}
        public RiskSecurityExchange(string val)
            :base(Tags.RiskSecurityExchange, val) {}

    }


    /// <summary>
    /// StreamAsgnType Field
    /// </summary>/
    public sealed class StreamAsgnType : IntField
    {
        public const int TAG = 1617;

        public StreamAsgnType()
            :base(Tags.StreamAsgnType) {}
        public StreamAsgnType(int val)
            :base(Tags.StreamAsgnType, val) {}


        // Field Enumerations
        public const int ASSIGNMENT = 1;
        public const int REJECTED = 2;
        public const int TERMINATE_UNASSIGN = 3;
    }


    /// <summary>
    /// RelationshipRiskEncodedSecurityDescLen Field
    /// </summary>/
    public sealed class RelationshipRiskEncodedSecurityDescLen : IntField
    {
        public const int TAG = 1618;

        public RelationshipRiskEncodedSecurityDescLen()
            :base(Tags.RelationshipRiskEncodedSecurityDescLen) {}
        public RelationshipRiskEncodedSecurityDescLen(int val)
            :base(Tags.RelationshipRiskEncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// RelationshipRiskEncodedSecurityDesc Field
    /// </summary>/
    public sealed class RelationshipRiskEncodedSecurityDesc : StringField
    {
        public const int TAG = 1619;

        public RelationshipRiskEncodedSecurityDesc()
            :base(Tags.RelationshipRiskEncodedSecurityDesc) {}
        public RelationshipRiskEncodedSecurityDesc(string val)
            :base(Tags.RelationshipRiskEncodedSecurityDesc, val) {}

    }


    /// <summary>
    /// RiskEncodedSecurityDescLen Field
    /// </summary>/
    public sealed class RiskEncodedSecurityDescLen : IntField
    {
        public const int TAG = 1620;

        public RiskEncodedSecurityDescLen()
            :base(Tags.RiskEncodedSecurityDescLen) {}
        public RiskEncodedSecurityDescLen(int val)
            :base(Tags.RiskEncodedSecurityDescLen, val) {}

    }


    /// <summary>
    /// RiskEncodedSecurityDesc Field
    /// </summary>/
    public sealed class RiskEncodedSecurityDesc : StringField
    {
        public const int TAG = 1621;

        public RiskEncodedSecurityDesc()
            :base(Tags.RiskEncodedSecurityDesc) {}
        public RiskEncodedSecurityDesc(string val)
            :base(Tags.RiskEncodedSecurityDesc, val) {}

    }


}
