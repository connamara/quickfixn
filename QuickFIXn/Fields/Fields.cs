// This is a generated file.  Don't edit it directly!

using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// Account Field
    /// </summary>
    public sealed class Account : StringField
    {
        public const int TAG = 1;

        public Account()
            :base(Tags.Account) {}
        public Account(string val)
            :base(Tags.Account, val) {}

    }


    /// <summary>
    /// AvgPx Field
    /// </summary>
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
    /// </summary>
    public sealed class BeginSeqNo : SeqNumFieldType
    {
        public const int TAG = 7;

        public BeginSeqNo()
            :base(Tags.BeginSeqNo) {}
        public BeginSeqNo(SeqNumType val)
            :base(Tags.BeginSeqNo, val) {}

    }


    /// <summary>
    /// BeginString Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class ClOrdID : StringField
    {
        public const int TAG = 11;

        public ClOrdID()
            :base(Tags.ClOrdID) {}
        public ClOrdID(string val)
            :base(Tags.ClOrdID, val) {}

    }


    /// <summary>
    /// CumQty Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class EndSeqNo : SeqNumFieldType
    {
        public const int TAG = 16;

        public EndSeqNo()
            :base(Tags.EndSeqNo) {}
        public EndSeqNo(SeqNumType val)
            :base(Tags.EndSeqNo, val) {}

    }


    /// <summary>
    /// ExecID Field
    /// </summary>
    public sealed class ExecID : StringField
    {
        public const int TAG = 17;

        public ExecID()
            :base(Tags.ExecID) {}
        public ExecID(string val)
            :base(Tags.ExecID, val) {}

    }


    /// <summary>
    /// SecurityIDSource Field
    /// </summary>
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
        public const string ISIN = "4";
        public const string RIC = "5";
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
        public const string ISDA_FPML_PRODUCT_URL = "K";
        public const string LETTER_OF_CREDIT = "L";
        public const string MARKETPLACE_ASSIGNED_IDENTIFIER = "M";
        public const string MARKIT_RED_ENTITY_CLIP = "N";
        public const string MARKIT_RED_PAIR_CLIP = "P";
        public const string CFTC_COMMODITY_CODE = "Q";
        public const string ISDA_COMMODITY_REFERENCE_PRICE = "R";
        public const string FINANCIAL_INSTRUMENT_GLOBAL_IDENTIFIER = "S";
        public const string LEGAL_ENTITY_IDENTIFIER = "T";
        public const string SYNTHETIC = "U";
        public const string FIDESSA_INSTRUMENT_MNEMONIC = "V";
        public const string INDEX_NAME = "W";
        public const string UNIFORM_SYMBOL = "X";
    }


    /// <summary>
    /// LastPx Field
    /// </summary>
    public sealed class LastPx : DecimalField
    {
        public const int TAG = 31;

        public LastPx()
            :base(Tags.LastPx) {}
        public LastPx(Decimal val)
            :base(Tags.LastPx, val) {}

    }


    /// <summary>
    /// LastQty Field
    /// </summary>
    public sealed class LastQty : DecimalField
    {
        public const int TAG = 32;

        public LastQty()
            :base(Tags.LastQty) {}
        public LastQty(Decimal val)
            :base(Tags.LastQty, val) {}

    }


    /// <summary>
    /// NoLinesOfText Field
    /// </summary>
    public sealed class NoLinesOfText : IntField
    {
        public const int TAG = 33;

        public NoLinesOfText()
            :base(Tags.NoLinesOfText) {}
        public NoLinesOfText(int val)
            :base(Tags.NoLinesOfText, val) {}

    }


    /// <summary>
    /// MsgSeqNum Field
    /// </summary>
    public sealed class MsgSeqNum : SeqNumFieldType
    {
        public const int TAG = 34;

        public MsgSeqNum()
            :base(Tags.MsgSeqNum) {}
        public MsgSeqNum(SeqNumType val)
            :base(Tags.MsgSeqNum, val) {}

    }


    /// <summary>
    /// MsgType Field
    /// </summary>
    public sealed class MsgType : StringField
    {
        public const int TAG = 35;

        public MsgType()
            :base(Tags.MsgType) {}
        public MsgType(string val)
            :base(Tags.MsgType, val) {}


        // Field Enumerations
        public const string HEARTBEAT = "0";
        public const string TEST_REQUEST = "1";
        public const string RESEND_REQUEST = "2";
        public const string REJECT = "3";
        public const string SEQUENCE_RESET = "4";
        public const string LOGOUT = "5";
        public const string INDICATION_OF_INTEREST = "6";
        public const string ADVERTISEMENT = "7";
        public const string EXECUTION_REPORT = "8";
        public const string ORDER_CANCEL_REJECT = "9";
        public const string LOGON = "A";
        public const string NEWS = "B";
        public const string EMAIL = "C";
        public const string ORDER_SINGLE = "D";
        public const string ORDER_LIST = "E";
        public const string ORDER_CANCEL_REQUEST = "F";
        public const string ORDER_CANCEL_REPLACE_REQUEST = "G";
        public const string ORDER_STATUS_REQUEST = "H";
        public const string ALLOCATION_INSTRUCTION = "J";
        public const string LIST_CANCEL_REQUEST = "K";
        public const string LIST_EXECUTE = "L";
        public const string LIST_STATUS_REQUEST = "M";
        public const string LIST_STATUS = "N";
        public const string ALLOCATION_INSTRUCTION_ACK = "P";
        public const string DONT_KNOW_TRADE = "Q";
        public const string QUOTE_REQUEST = "R";
        public const string QUOTE = "S";
        public const string SETTLEMENT_INSTRUCTIONS = "T";
        public const string MARKET_DATA_REQUEST = "V";
        public const string MARKET_DATA_SNAPSHOT_FULL_REFRESH = "W";
        public const string MARKET_DATA_INCREMENTAL_REFRESH = "X";
        public const string MARKET_DATA_REQUEST_REJECT = "Y";
        public const string QUOTE_CANCEL = "Z";
        public const string QUOTE_STATUS_REQUEST = "a";
        public const string MASS_QUOTE_ACKNOWLEDGEMENT = "b";
        public const string SECURITY_DEFINITION_REQUEST = "c";
        public const string SECURITY_DEFINITION = "d";
        public const string SECURITY_STATUS_REQUEST = "e";
        public const string SECURITY_STATUS = "f";
        public const string TRADING_SESSION_STATUS_REQUEST = "g";
        public const string TRADING_SESSION_STATUS = "h";
        public const string MASS_QUOTE = "i";
        public const string BUSINESS_MESSAGE_REJECT = "j";
        public const string BID_REQUEST = "k";
        public const string BID_RESPONSE = "l";
        public const string LIST_STRIKE_PRICE = "m";
        public const string XML_MESSAGE = "n";
        public const string REGISTRATION_INSTRUCTIONS = "o";
        public const string REGISTRATION_INSTRUCTIONS_RESPONSE = "p";
        public const string ORDER_MASS_CANCEL_REQUEST = "q";
        public const string ORDER_MASS_CANCEL_REPORT = "r";
        public const string NEW_ORDER_CROSS = "s";
        public const string CROSS_ORDER_CANCEL_REPLACE_REQUEST = "t";
        public const string CROSS_ORDER_CANCEL_REQUEST = "u";
        public const string SECURITY_TYPE_REQUEST = "v";
        public const string SECURITY_TYPES = "w";
        public const string SECURITY_LIST_REQUEST = "x";
        public const string SECURITY_LIST = "y";
        public const string DERIVATIVE_SECURITY_LIST_REQUEST = "z";
        public const string DERIVATIVE_SECURITY_LIST = "AA";
        public const string NEW_ORDER_MULTILEG = "AB";
        public const string MULTILEG_ORDER_CANCEL_REPLACE = "AC";
        public const string TRADE_CAPTURE_REPORT_REQUEST = "AD";
        public const string TRADE_CAPTURE_REPORT = "AE";
        public const string ORDER_MASS_STATUS_REQUEST = "AF";
        public const string QUOTE_REQUEST_REJECT = "AG";
        public const string RFQ_REQUEST = "AH";
        public const string QUOTE_STATUS_REPORT = "AI";
        public const string QUOTE_RESPONSE = "AJ";
        public const string CONFIRMATION = "AK";
        public const string POSITION_MAINTENANCE_REQUEST = "AL";
        public const string POSITION_MAINTENANCE_REPORT = "AM";
        public const string REQUEST_FOR_POSITIONS = "AN";
        public const string REQUEST_FOR_POSITIONS_ACK = "AO";
        public const string POSITION_REPORT = "AP";
        public const string TRADE_CAPTURE_REPORT_REQUEST_ACK = "AQ";
        public const string TRADE_CAPTURE_REPORT_ACK = "AR";
        public const string ALLOCATION_REPORT = "AS";
        public const string ALLOCATION_REPORT_ACK = "AT";
        public const string CONFIRMATION_ACK = "AU";
        public const string SETTLEMENT_INSTRUCTION_REQUEST = "AV";
        public const string ASSIGNMENT_REPORT = "AW";
        public const string COLLATERAL_REQUEST = "AX";
        public const string COLLATERAL_ASSIGNMENT = "AY";
        public const string COLLATERAL_RESPONSE = "AZ";
        public const string COLLATERAL_REPORT = "BA";
        public const string COLLATERAL_INQUIRY = "BB";
        public const string NETWORK_STATUS_REQUEST = "BC";
        public const string NETWORK_STATUS_RESPONSE = "BD";
        public const string USER_REQUEST = "BE";
        public const string USER_RESPONSE = "BF";
        public const string COLLATERAL_INQUIRY_ACK = "BG";
        public const string CONFIRMATION_REQUEST = "BH";
        public const string TRADING_SESSION_LIST_REQUEST = "BI";
        public const string TRADING_SESSION_LIST = "BJ";
        public const string SECURITY_LIST_UPDATE_REPORT = "BK";
        public const string ADJUSTED_POSITION_REPORT = "BL";
        public const string ALLOCATION_INSTRUCTION_ALERT = "BM";
        public const string EXECUTION_ACKNOWLEDGEMENT = "BN";
        public const string CONTRARY_INTENTION_REPORT = "BO";
        public const string SECURITY_DEFINITION_UPDATE_REPORT = "BP";
        public const string ORDERCANCELREJECT = "9";
        public const string TRADINGSESSIONLIST = "BJ";
        public const string TRADINGSESSIONLISTREQUEST = "BI";
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
        public const string ORDERMASSACTIONREQUEST = "CA";
        public const string USERNOTIFICATION = "CB";
        public const string STREAMASSIGNMENTREQUEST = "CC";
        public const string STREAMASSIGNMENTREPORT = "CD";
        public const string STREAMASSIGNMENTREPORTACK = "CE";
        public const string PARTYDETAILSLISTREQUEST = "CF";
        public const string PARTYDETAILSLISTREPORT = "CG";
        public const string MARGINREQUIREMENTINQUIRY = "CH";
        public const string MARGINREQUIREMENTINQUIRYACK = "CI";
        public const string MARGINREQUIREMENTREPORT = "CJ";
        public const string PARTYDETAILSLISTUPDATEREPORT = "CK";
        public const string PARTYRISKLIMITSREQUEST = "CL";
        public const string PARTYRISKLIMITSREPORT = "CM";
        public const string SECURITYMASSSTATUSREQUEST = "CN";
        public const string SECURITYMASSSTATUS = "CO";
        public const string ACCOUNTSUMMARYREPORT = "CQ";
        public const string PARTYRISKLIMITSUPDATEREPORT = "CR";
        public const string PARTYRISKLIMITSDEFINITIONREQUEST = "CS";
        public const string PARTYRISKLIMITSDEFINITIONREQUESTACK = "CT";
        public const string PARTYENTITLEMENTSREQUEST = "CU";
        public const string PARTYENTITLEMENTSREPORT = "CV";
        public const string QUOTEACK = "CW";
        public const string PARTYDETAILSDEFINITIONREQUEST = "CX";
        public const string PARTYDETAILSDEFINITIONREQUESTACK = "CY";
        public const string PARTYENTITLEMENTSUPDATEREPORT = "CZ";
        public const string PARTYENTITLEMENTSDEFINITIONREQUEST = "DA";
        public const string PARTYENTITLEMENTSDEFINITIONREQUESTACK = "DB";
        public const string TRADEMATCHREPORT = "DC";
        public const string NEWORDERSINGLE = "D";
        public const string TRADEMATCHREPORTACK = "DD";
        public const string PARTYRISKLIMITSREPORTACK = "DE";
        public const string PARTYRISKLIMITCHECKREQUEST = "DF";
        public const string PARTYRISKLIMITCHECKREQUESTACK = "DG";
        public const string PARTYACTIONREQUEST = "DH";
        public const string PARTYACTIONREPORT = "DI";
        public const string MASSORDER = "DJ";
        public const string MASSORDERACK = "DK";
        public const string POSITIONTRANSFERINSTRUCTION = "DL";
        public const string POSITIONTRANSFERINSTRUCTIONACK = "DM";
        public const string NEWORDERLIST = "E";
        public const string POSITIONTRANSFERREPORT = "DN";
        public const string MARKETDATASTATISTICSREQUEST = "DO";
        public const string MARKETDATASTATISTICSREPORT = "DP";
        public const string COLLATERALREPORTACK = "DQ";
        public const string MARKETDATAREPORT = "DR";
        public const string CROSSREQUEST = "DS";
        public const string CROSSREQUESTACK = "DT";
        public const string ALLOCATIONINSTRUCTIONALERTREQUEST = "DU";
        public const string ALLOCATIONINSTRUCTIONALERTREQUESTACK = "DV";
        public const string TRADEAGGREGATIONREQUEST = "DW";
        public const string ORDERCANCELREQUEST = "F";
        public const string TRADEAGGREGATIONREPORT = "DX";
        public const string PAYMANAGEMENTREPORT = "EA";
        public const string PAYMANAGEMENTREPORTACK = "EB";
        public const string PAYMANAGEMENTREQUEST = "DY";
        public const string PAYMANAGEMENTREQUESTACK = "DZ";
        public const string ORDERCANCELREPLACEREQUEST = "G";
        public const string ORDERSTATUSREQUEST = "H";
        public const string ALLOCATIONINSTRUCTION = "J";
        public const string TESTREQUEST = "1";
        public const string LISTCANCELREQUEST = "K";
        public const string LISTEXECUTE = "L";
        public const string LISTSTATUSREQUEST = "M";
        public const string LISTSTATUS = "N";
        public const string ALLOCATIONINSTRUCTIONACK = "P";
        public const string DONTKNOWTRADE = "Q";
        public const string QUOTEREQUEST = "R";
        public const string SETTLEMENTINSTRUCTIONS = "T";
        public const string MARKETDATAREQUEST = "V";
        public const string RESENDREQUEST = "2";
        public const string MARKETDATASNAPSHOTFULLREFRESH = "W";
        public const string MARKETDATAINCREMENTALREFRESH = "X";
        public const string MARKETDATAREQUESTREJECT = "Y";
        public const string QUOTECANCEL = "Z";
        public const string QUOTESTATUSREQUEST = "a";
        public const string MASSQUOTEACK = "b";
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
        public const string XMLNONFIX = "n";
        public const string REGISTRATIONINSTRUCTIONS = "o";
        public const string REGISTRATIONINSTRUCTIONSRESPONSE = "p";
        public const string SEQUENCERESET = "4";
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
        public const string IOI = "6";
        public const string POSITIONMAINTENANCEREQUEST = "AL";
        public const string POSITIONMAINTENANCEREPORT = "AM";
        public const string REQUESTFORPOSITIONS = "AN";
        public const string REQUESTFORPOSITIONSACK = "AO";
        public const string POSITIONREPORT = "AP";
        public const string TRADECAPTUREREPORTREQUESTACK = "AQ";
        public const string TRADECAPTUREREPORTACK = "AR";
        public const string ALLOCATIONREPORT = "AS";
        public const string ALLOCATIONREPORTACK = "AT";
        public const string CONFIRMATIONACK = "AU";
        public const string SETTLEMENTINSTRUCTIONREQUEST = "AV";
        public const string ASSIGNMENTREPORT = "AW";
        public const string COLLATERALREQUEST = "AX";
        public const string COLLATERALASSIGNMENT = "AY";
        public const string COLLATERALRESPONSE = "AZ";
        public const string COLLATERALREPORT = "BA";
        public const string COLLATERALINQUIRY = "BB";
        public const string NETWORKCOUNTERPARTYSYSTEMSTATUSREQUEST = "BC";
        public const string NETWORKCOUNTERPARTYSYSTEMSTATUSRESPONSE = "BD";
        public const string EXECUTIONREPORT = "8";
        public const string USERREQUEST = "BE";
        public const string USERRESPONSE = "BF";
        public const string COLLATERALINQUIRYACK = "BG";
        public const string CONFIRMATIONREQUEST = "BH";
        public const string CONTRARYINTENTIONREPORT = "BO";
        public const string SECURITYDEFINITIONUPDATEREPORT = "BP";
        public const string SECURITYLISTUPDATEREPORT = "BK";
        public const string ADJUSTEDPOSITIONREPORT = "BL";
        public const string ALLOCATIONINSTRUCTIONALERT = "BM";
        public const string EXECUTIONACK = "BN";
    }


    /// <summary>
    /// NewSeqNo Field
    /// </summary>
    public sealed class NewSeqNo : SeqNumFieldType
    {
        public const int TAG = 36;

        public NewSeqNo()
            :base(Tags.NewSeqNo) {}
        public NewSeqNo(SeqNumType val)
            :base(Tags.NewSeqNo, val) {}

    }


    /// <summary>
    /// OrderID Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
        public const char REPLACED = '5';
        public const char PENDING_CANCEL = '6';
        public const char STOPPED = '7';
        public const char REJECTED = '8';
        public const char SUSPENDED = '9';
        public const char PENDING_NEW = 'A';
        public const char CALCULATED = 'B';
        public const char EXPIRED = 'C';
        public const char ACCEPTED_FOR_BIDDING = 'D';
        public const char PENDING_REPLACE = 'E';
    }


    /// <summary>
    /// OrdType Field
    /// </summary>
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
        public const char STOP_STOP_LOSS = '3';
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
        public const char STOP_ON_BID_OR_OFFER = 'R';
        public const char STOP_LIMIT_ON_BID_OR_OFFER = 'S';
    }


    /// <summary>
    /// OrigClOrdID Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    }


    /// <summary>
    /// Price Field
    /// </summary>
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
    /// </summary>
    public sealed class RefSeqNum : SeqNumFieldType
    {
        public const int TAG = 45;

        public RefSeqNum()
            :base(Tags.RefSeqNum) {}
        public RefSeqNum(SeqNumType val)
            :base(Tags.RefSeqNum, val) {}

    }


    /// <summary>
    /// SecurityID Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class SenderSubID : StringField
    {
        public const int TAG = 50;

        public SenderSubID()
            :base(Tags.SenderSubID) {}
        public SenderSubID(string val)
            :base(Tags.SenderSubID, val) {}

    }


    /// <summary>
    /// SendingDate Field
    /// </summary>
    public sealed class SendingDate : StringField
    {
        public const int TAG = 51;

        public SendingDate()
            :base(Tags.SendingDate) {}
        public SendingDate(string val)
            :base(Tags.SendingDate, val) {}

    }


    /// <summary>
    /// SendingTime Field
    /// </summary>
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
    /// Quantity Field
    /// </summary>
    public sealed class Quantity : DecimalField
    {
        public const int TAG = 53;

        public Quantity()
            :base(Tags.Quantity) {}
        public Quantity(Decimal val)
            :base(Tags.Quantity, val) {}

    }


    /// <summary>
    /// Side Field
    /// </summary>
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
        public const char SELL_UNDISCLOSED = 'H';
    }


    /// <summary>
    /// Symbol Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
        public const char GOOD_FOR_TIME = 'A';
        public const char GOOD_FOR_AUCTION = 'B';
        public const char GOOD_FOR_THIS_MONTH = 'C';
    }


    /// <summary>
    /// TransactTime Field
    /// </summary>
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
    /// </summary>
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
    /// PossResend Field
    /// </summary>
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
    /// </summary>
    public sealed class EncryptMethod : IntField
    {
        public const int TAG = 98;

        public EncryptMethod()
            :base(Tags.EncryptMethod) {}
        public EncryptMethod(int val)
            :base(Tags.EncryptMethod, val) {}


        // Field Enumerations
        public const int NONE_OTHER = 0;
        public const int PKCS = 1;
        public const int DES = 2;
        public const int PKCS_DES = 3;
        public const int PGP_DES = 4;
        public const int PGP_DES_MD5 = 5;
        public const int PEM_DES_MD5 = 6;
        public const int NONE = 0;
        public const int PKCS_1 = 1;
        public const int PKCS_3 = 3;
        public const int PGP_4 = 4;
        public const int PGP_5 = 5;
        public const int PEM = 6;
    }


    /// <summary>
    /// CxlRejReason Field
    /// </summary>
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
        public const int PRICE_EXCEEDS_CURRENT_PRICE = 7;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND = 8;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int OTHER = 99;
    }


    /// <summary>
    /// OrdRejReason Field
    /// </summary>
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
        public const int EXCHANGE_CLOSED = 2;
        public const int ORDER_EXCEEDS_LIMIT = 3;
        public const int TOO_LATE_TO_ENTER = 4;
        public const int UNKNOWN_ORDER = 5;
        public const int DUPLICATE_ORDER = 6;
        public const int DUPLICATE_OF_A_VERBALLY_COMMUNICATED_ORDER = 7;
        public const int STALE_ORDER = 8;
        public const int TRADE_ALONG_REQUIRED = 9;
        public const int INVALID_INVESTOR_ID = 10;
        public const int UNSUPPORTED_ORDER_CHARACTERISTIC = 11;
        public const int SURVEILLANCE_OPTION = 12;
        public const int INCORRECT_QUANTITY = 13;
        public const int INCORRECT_ALLOCATED_QUANTITY = 14;
        public const int UNKNOWN_ACCOUNT = 15;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND = 16;
        public const int INVALID_PRICE_INCREMENT = 18;
        public const int OTHER = 99;
        public const int REFERENCE_PRICE_NOT_AVAILABLE = 19;
        public const int NOTIONAL_VALUE_EXCEEDS_THRESHOLD = 20;
        public const int ALGORITHM_RISK_THRESHOLD_BREACHED = 21;
        public const int SHORT_SELL_NOT_PERMITTED = 22;
        public const int SHORT_SELL_REJECTED_DUE_TO_SECURITY_PRE_BORROW_RESTRICTION = 23;
        public const int SHORT_SELL_REJECTED_DUE_TO_ACCOUNT_PRE_BORROW_RESTRICTION = 24;
        public const int INSUFFICIENT_CREDIT_LIMIT = 25;
        public const int EXCEEDED_CLIP_SIZE_LIMIT = 26;
        public const int EXCEEDED_MAXIMUM_NOTIONAL_ORDER_AMOUNT = 27;
        public const int EXCEEDED_DV01_PV01_LIMIT = 28;
        public const int EXCEEDED_CS01_LIMIT = 29;
    }


    /// <summary>
    /// HeartBtInt Field
    /// </summary>
    public sealed class HeartBtInt : IntField
    {
        public const int TAG = 108;

        public HeartBtInt()
            :base(Tags.HeartBtInt) {}
        public HeartBtInt(int val)
            :base(Tags.HeartBtInt, val) {}

    }


    /// <summary>
    /// TestReqID Field
    /// </summary>
    public sealed class TestReqID : StringField
    {
        public const int TAG = 112;

        public TestReqID()
            :base(Tags.TestReqID) {}
        public TestReqID(string val)
            :base(Tags.TestReqID, val) {}

    }


    /// <summary>
    /// OnBehalfOfCompID Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class QuoteID : StringField
    {
        public const int TAG = 117;

        public QuoteID()
            :base(Tags.QuoteID) {}
        public QuoteID(string val)
            :base(Tags.QuoteID, val) {}

    }


    /// <summary>
    /// OrigSendingTime Field
    /// </summary>
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
    /// </summary>
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
    }


    /// <summary>
    /// BidPx Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class OfferSize : DecimalField
    {
        public const int TAG = 135;

        public OfferSize()
            :base(Tags.OfferSize) {}
        public OfferSize(Decimal val)
            :base(Tags.OfferSize, val) {}

    }


    /// <summary>
    /// ResetSeqNumFlag Field
    /// </summary>
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
    }


    /// <summary>
    /// NoRelatedSym Field
    /// </summary>
    public sealed class NoRelatedSym : IntField
    {
        public const int TAG = 146;

        public NoRelatedSym()
            :base(Tags.NoRelatedSym) {}
        public NoRelatedSym(int val)
            :base(Tags.NoRelatedSym, val) {}

    }


    /// <summary>
    /// Headline Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
        public const char LOCKED = 'M';
        public const char RELEASED = 'N';
    }


    /// <summary>
    /// LeavesQty Field
    /// </summary>
    public sealed class LeavesQty : DecimalField
    {
        public const int TAG = 151;

        public LeavesQty()
            :base(Tags.LeavesQty) {}
        public LeavesQty(Decimal val)
            :base(Tags.LeavesQty, val) {}

    }


    /// <summary>
    /// SecondaryOrderID Field
    /// </summary>
    public sealed class SecondaryOrderID : StringField
    {
        public const int TAG = 198;

        public SecondaryOrderID()
            :base(Tags.SecondaryOrderID) {}
        public SecondaryOrderID(string val)
            :base(Tags.SecondaryOrderID, val) {}

    }


    /// <summary>
    /// MDReqID Field
    /// </summary>
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
    /// </summary>
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
    }


    /// <summary>
    /// MarketDepth Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    }


    /// <summary>
    /// NoMDEntryTypes Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
        public const char VOLUME_WEIGHTED_AVERAGE_PRICE = '9';
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
        public const char RECOVERY_RATE_FOR_LONG_POSITIONS = 'Z';
        public const char RECOVERY_RATE_FOR_SHORT_POSITIONS = 'a';
        public const char FIXING_PRICE = 'W';
        public const char CASH_RATE = 'X';
        public const char MARKET_BID = 'b';
        public const char MARKET_OFFER = 'c';
        public const char SHORT_SALE_MINIMUM_PRICE = 'd';
        public const char PREVIOUS_CLOSING_PRICE = 'e';
        public const char THRESHOLD_LIMITS_AND_PRICE_BANDING = 'g';
        public const char DAILY_FINANCING_VALUE = 'h';
        public const char ACCRUED_FINANCING_VALUE = 'i';
        public const char TIME_WEIGHTED_AVERAGE_PRICE = 't';
    }


    /// <summary>
    /// MDEntryPx Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// TradeCondition Field
    /// </summary>
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
    }


    /// <summary>
    /// MDEntryID Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// OpenCloseSettlFlag Field
    /// </summary>
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
    }


    /// <summary>
    /// NoQuoteEntries Field
    /// </summary>
    public sealed class NoQuoteEntries : IntField
    {
        public const int TAG = 295;

        public NoQuoteEntries()
            :base(Tags.NoQuoteEntries) {}
        public NoQuoteEntries(int val)
            :base(Tags.NoQuoteEntries, val) {}

    }


    /// <summary>
    /// QuoteStatus Field
    /// </summary>
    public sealed class QuoteStatus : IntField
    {
        public const int TAG = 297;

        public QuoteStatus()
            :base(Tags.QuoteStatus) {}
        public QuoteStatus(int val)
            :base(Tags.QuoteStatus, val) {}


        // Field Enumerations
        public const int ACCEPTED = 0;
        public const int CANCELED_FOR_SPECIFIC_SECURITIES = 1;
        public const int CANCELED_FOR_SPECIFIC_SECURITYTYPES = 2;
        public const int CANCELED_FOR_UNDERLYING = 3;
        public const int CANCELED_ALL = 4;
        public const int REJECTED = 5;
        public const int REMOVED_FROM_MARKET = 6;
        public const int EXPIRED = 7;
        public const int QUERY = 8;
        public const int QUOTE_NOT_FOUND = 9;
        public const int PENDING = 10;
        public const int PASS = 11;
        public const int LOCKED_MARKET_WARNING = 12;
        public const int CROSSED_MARKET_WARNING = 13;
        public const int CANCELED_DUE_TO_LOCKED_MARKET = 14;
        public const int CANCELED_DUE_TO_CROSSED_MARKET = 15;
        public const int ACTIVE = 16;
        public const int CANCELED = 17;
        public const int UNSOLICITED_QUOTE_REPLENISHMENT = 18;
        public const int PENDING_END_TRADE = 19;
        public const int TOO_LATE_TO_END = 20;
        public const int TRADED = 21;
        public const int TRADED_AND_REMOVED = 22;
        public const int CONTRACT_TERMINATED = 23;
    }


    /// <summary>
    /// QuoteCancelType Field
    /// </summary>
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
        public const int CANCEL_SPECIFIED_SINGLE_QUOTE = 5;
        public const int CANCEL_BY_TYPE_OF_QUOTE = 6;
        public const int CANCEL_FOR_SECURITY_ISSUER = 7;
        public const int CANCEL_FOR_ISSUER_OF_UNDERLYING_SECURITY = 8;
    }


    /// <summary>
    /// QuoteEntryID Field
    /// </summary>
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
    /// </summary>
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
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND_10 = 10;
        public const int QUOTE_LOCKED = 11;
        public const int OTHER = 99;
        public const int INVALID_OR_UNKNOWN_SECURITY_ISSUER = 12;
        public const int INVALID_OR_UNKNOWN_ISSUER_OF_UNDERLYING_SECURITY = 13;
        public const int NOTIONAL_VALUE_EXCEEDS_THRESHOLD = 14;
        public const int PRICE_EXCEEDS_CURRENT_PRICE_BAND_15 = 15;
        public const int REFERENCE_PRICE_NOT_AVAILABLE = 16;
        public const int INSUFFICIENT_CREDIT_LIMIT = 17;
        public const int EXCEEDED_CLIP_SIZE_LIMIT = 18;
        public const int EXCEEDED_MAXIMUM_NOTIONAL_ORDER_AMOUNT = 19;
        public const int EXCEEDED_DV01_PV01_LIMIT = 20;
        public const int EXCEEDED_CS01_LIMIT = 21;
    }


    /// <summary>
    /// SecurityReqID Field
    /// </summary>
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
    /// </summary>
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
    /// SecurityStatusReqID Field
    /// </summary>
    public sealed class SecurityStatusReqID : StringField
    {
        public const int TAG = 324;

        public SecurityStatusReqID()
            :base(Tags.SecurityStatusReqID) {}
        public SecurityStatusReqID(string val)
            :base(Tags.SecurityStatusReqID, val) {}

    }


    /// <summary>
    /// SecurityResponseID Field
    /// </summary>
    public sealed class SecurityResponseID : StringField
    {
        public const int TAG = 322;

        public SecurityResponseID()
            :base(Tags.SecurityResponseID) {}
        public SecurityResponseID(string val)
            :base(Tags.SecurityResponseID, val) {}

    }


    /// <summary>
    /// SecurityTradingStatus Field
    /// </summary>
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
    }


    /// <summary>
    /// TradingSessionID Field
    /// </summary>
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
        public const string OFF_HOURS = "OH";
        public const string CONTINUOUS_TRADING = "CO";
        public const string OPENING_CALL_PERIOD = "OC";
        public const string OPENING_UNCROSSING = "OX";
        public const string CLOSING_CALL = "CC";
        public const string CLOSING_UNCROSSING = "CX";
        public const string BREAK = "BK";
    }


    /// <summary>
    /// RefTagID Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    }


    /// <summary>
    /// BusinessRejectReason Field
    /// </summary>
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
        public const int THROTTLE_LIMIT_EXCEEDED = 8;
        public const int THROTTLE_LIMIT_EXCEEDED_SESSION_WILL_BE_DISCONNECTED = 9;
        public const int THROTTLED_MESSAGES_REJECTED_ON_REQUEST = 10;
    }


    /// <summary>
    /// TotNoRelatedSym Field
    /// </summary>
    public sealed class TotNoRelatedSym : IntField
    {
        public const int TAG = 393;

        public TotNoRelatedSym()
            :base(Tags.TotNoRelatedSym) {}
        public TotNoRelatedSym(int val)
            :base(Tags.TotNoRelatedSym, val) {}

    }


    /// <summary>
    /// CxlRejResponseTo Field
    /// </summary>
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
    /// PartyIDSource Field
    /// </summary>
    public sealed class PartyIDSource : CharField
    {
        public const int TAG = 447;

        public PartyIDSource()
            :base(Tags.PartyIDSource) {}
        public PartyIDSource(char val)
            :base(Tags.PartyIDSource, val) {}


        // Field Enumerations
        public const char UK_NATIONAL_INSURANCE_OR_PENSION_NUMBER = '6';
        public const char US_SOCIAL_SECURITY_NUMBER = '7';
        public const char US_EMPLOYER_OR_TAX_ID_NUMBER = '8';
        public const char AUSTRALIAN_BUSINESS_NUMBER = '9';
        public const char AUSTRALIAN_TAX_FILE_NUMBER = 'A';
        public const char KOREAN_INVESTOR_ID = '1';
        public const char TAIWANESE_QUALIFIED_FOREIGN_INVESTOR_ID_QFII_FID = '2';
        public const char TAIWANESE_TRADING_ACCT = '3';
        public const char MALAYSIAN_CENTRAL_DEPOSITORY = '4';
        public const char CHINESE_INVESTOR_ID = '5';
        public const char DIRECTED_BROKER_THREE_CHARACTER_ACRONYM_AS_DEFINED_IN_ISITC_ETC_BEST_PRACTICE_GUIDELINES_DOCUMENT = 'I';
        public const char BIC = 'B';
        public const char GENERALLY_ACCEPTED_MARKET_PARTICIPANT_IDENTIFIER = 'C';
        public const char PROPRIETARY = 'D';
        public const char ISO_COUNTRY_CODE = 'E';
        public const char SETTLEMENT_ENTITY_LOCATION = 'F';
        public const char MARKET_IDENTIFIER_CODE = 'G';
        public const char CSD_PARTICIPANT_MEMBER_CODE = 'H';
        public const char TAX_ID = 'J';
        public const char AUSTRALIAN_COMPANY_NUMBER = 'K';
        public const char AUSTRALIAN_REGISTERED_BODY_NUMBER = 'L';
        public const char CFTC_REPORTING_FIRM_IDENTIFIER = 'M';
        public const char LEGAL_ENTITY_IDENTIFIER = 'N';
        public const char INTERIM_IDENTIFIER = 'O';
        public const char SHORT_CODE_IDENTIFIER = 'P';
        public const char NATIONAL_ID_OF_NATURAL_PERSON = 'Q';
        public const char INDIA_PERMANENT_ACCOUNT_NUMBER = 'R';
        public const char FIRM_DESIGNATED_IDENTIFIER = 'S';
        public const char SPECIAL_SEGREGATED_ACCOUNT_ID = 'T';
        public const char MASTER_SPECIAL_SEGREGATED_ACCOUNT_ID = 'U';
    }


    /// <summary>
    /// PartyID Field
    /// </summary>
    public sealed class PartyID : StringField
    {
        public const int TAG = 448;

        public PartyID()
            :base(Tags.PartyID) {}
        public PartyID(string val)
            :base(Tags.PartyID, val) {}

    }


    /// <summary>
    /// PartyRole Field
    /// </summary>
    public sealed class PartyRole : IntField
    {
        public const int TAG = 452;

        public PartyRole()
            :base(Tags.PartyRole) {}
        public PartyRole(int val)
            :base(Tags.PartyRole, val) {}


        // Field Enumerations
        public const int EXECUTING_FIRM = 1;
        public const int BROKER_OF_CREDIT = 2;
        public const int CLIENT_ID = 3;
        public const int CLEARING_FIRM = 4;
        public const int INVESTOR_ID = 5;
        public const int INTRODUCING_FIRM = 6;
        public const int ENTERING_FIRM = 7;
        public const int LOCATE = 8;
        public const int FUND_MANAGER_CLIENT_ID = 9;
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
        public const int UNDERLYING_CONTRA_FIRM = 20;
        public const int CLEARING_ORGANIZATION = 21;
        public const int EXCHANGE = 22;
        public const int CUSTOMER_ACCOUNT = 24;
        public const int CORRESPONDENT_CLEARING_ORGANIZATION = 25;
        public const int CORRESPONDENT_BROKER = 26;
        public const int BUYER_SELLER = 27;
        public const int CUSTODIAN = 28;
        public const int INTERMEDIARY = 29;
        public const int AGENT = 30;
        public const int SUB_CUSTODIAN = 31;
        public const int BENEFICIARY = 32;
        public const int INTERESTED_PARTY = 33;
        public const int REGULATORY_BODY = 34;
        public const int LIQUIDITY_PROVIDER = 35;
        public const int ENTERING_TRADER = 36;
        public const int CONTRA_TRADER = 37;
        public const int POSITION_ACCOUNT = 38;
        public const int CONTRA_INVESTOR_ID = 39;
        public const int TRANSFER_TO_FIRM = 40;
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
        public const int INTRODUCING_BROKER = 60;
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
        public const int BROKER_CIENT_ID = 81;
        public const int CENTRAL_REGISTRATION_DEPOSITORY = 82;
        public const int CLEARING_ACCOUNT = 83;
        public const int ACCEPTABLE_SETTLING_COUNTERPARTY = 84;
        public const int UNACCEPTABLE_SETTLING_COUNTERPARTY = 85;
        public const int CLS_MEMBER_BANK = 86;
        public const int IN_CONCERT_GROUP = 87;
        public const int IN_CONCERT_CONTROLLING_ENTITY = 88;
        public const int LARGE_POSITIONS_REPORTING_ACCOUNT = 89;
        public const int SETTLEMENT_FIRM = 90;
        public const int SETTLEMENT_ACCOUNT = 91;
        public const int REPORTING_MARKET_CENTER = 92;
        public const int RELATED_REPORTING_MARKET_CENTER = 93;
        public const int AWAY_MARKET = 94;
        public const int GIVE_UP = 95;
        public const int TAKE_UP = 96;
        public const int GIVE_UP_CLEARING_FIRM = 97;
        public const int TAKE_UP_CLEARING_FIRM = 98;
        public const int ORIGINATING_MARKET = 99;
        public const int MARGIN_ACCOUNT = 100;
        public const int COLLATERAL_ASSET_ACCOUNT = 101;
        public const int DATA_REPOSITORY = 102;
        public const int CALCULATION_AGENT = 103;
        public const int SENDER_OF_EXERCISE_NOTICE = 104;
        public const int RECEIVER_OF_EXERCISE_NOTICE = 105;
        public const int RATE_REFERENCE_BANK = 106;
        public const int CORRESPONDENT = 107;
        public const int BENEFICIARYS_BANK_OR_DEPOSITORY_INSTITUTION = 109;
        public const int BORROWER = 110;
        public const int PRIMARY_OBLIGATOR = 111;
        public const int GUARANTOR = 112;
        public const int EXCLUDED_REFERENCE_ENTITY = 113;
        public const int DETERMINING_PARTY = 114;
        public const int HEDGING_PARTY = 115;
        public const int REPORTING_ENTITY = 116;
        public const int SALES_PERSON = 117;
        public const int OPERATOR = 118;
        public const int CENTRAL_SECURITIES_DEPOSITORY_119 = 119;
        public const int INTERNATIONAL_CENTRAL_SECURITIES_DEPOSITORY = 120;
        public const int TRADING_SUB_ACCOUNT = 121;
        public const int INVESTMENT_DECISION_MAKER = 122;
        public const int PUBLISHING_INTERMEDIARY = 123;
        public const int CENTRAL_SECURITIES_DEPOSITORY_124 = 124;
        public const int ISSUER = 125;
        public const int CONTRA_CUSTOMER_ACCOUNT = 126;
        public const int CONTRA_INVESTMENT_DECISION_MAKER = 127;
    }


    /// <summary>
    /// NoPartyIDs Field
    /// </summary>
    public sealed class NoPartyIDs : IntField
    {
        public const int TAG = 453;

        public NoPartyIDs()
            :base(Tags.NoPartyIDs) {}
        public NoPartyIDs(int val)
            :base(Tags.NoPartyIDs, val) {}

    }


    /// <summary>
    /// PartySubID Field
    /// </summary>
    public sealed class PartySubID : StringField
    {
        public const int TAG = 523;

        public PartySubID()
            :base(Tags.PartySubID) {}
        public PartySubID(string val)
            :base(Tags.PartySubID, val) {}

    }


    /// <summary>
    /// MassCancelRequestType Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
        public const int INVALID_OR_UNKNOWN_MARKET = 7;
        public const int INVALID_OR_UNKOWN_MARKET_SEGMENT = 8;
        public const int INVALID_OR_UNKNOWN_SECURITY_GROUP = 9;
        public const int OTHER = 99;
        public const int INVALID_OR_UNKNOWN_SECURITY_ISSUER = 10;
        public const int INVALID_OR_UNKNOWN_ISSUER_OF_UNDERLYING_SECURITY = 11;
    }


    /// <summary>
    /// Username Field
    /// </summary>
    public sealed class Username : StringField
    {
        public const int TAG = 553;

        public Username()
            :base(Tags.Username) {}
        public Username(string val)
            :base(Tags.Username, val) {}

    }


    /// <summary>
    /// SecurityListRequestType Field
    /// </summary>
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
    }


    /// <summary>
    /// SecurityRequestResult Field
    /// </summary>
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
    /// LastUpdateTime Field
    /// </summary>
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
    /// NoPartySubIDs Field
    /// </summary>
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
    /// </summary>
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
    /// TrdMatchID Field
    /// </summary>
    public sealed class TrdMatchID : StringField
    {
        public const int TAG = 880;

        public TrdMatchID()
            :base(Tags.TrdMatchID) {}
        public TrdMatchID(string val)
            :base(Tags.TrdMatchID, val) {}

    }


    /// <summary>
    /// LastFragment Field
    /// </summary>
    public sealed class LastFragment : BooleanField
    {
        public const int TAG = 893;

        public LastFragment()
            :base(Tags.LastFragment) {}
        public LastFragment(Boolean val)
            :base(Tags.LastFragment, val) {}

    }


    /// <summary>
    /// TradeID Field
    /// </summary>
    public sealed class TradeID : StringField
    {
        public const int TAG = 1003;

        public TradeID()
            :base(Tags.TradeID) {}
        public TradeID(string val)
            :base(Tags.TradeID, val) {}

    }


    /// <summary>
    /// DefaultApplVerID Field
    /// </summary>
    public sealed class DefaultApplVerID : StringField
    {
        public const int TAG = 1137;

        public DefaultApplVerID()
            :base(Tags.DefaultApplVerID) {}
        public DefaultApplVerID(string val)
            :base(Tags.DefaultApplVerID, val) {}

    }


    /// <summary>
    /// QuoteMsgID Field
    /// </summary>
    public sealed class QuoteMsgID : StringField
    {
        public const int TAG = 1166;

        public QuoteMsgID()
            :base(Tags.QuoteMsgID) {}
        public QuoteMsgID(string val)
            :base(Tags.QuoteMsgID, val) {}

    }


    /// <summary>
    /// MarketID Field
    /// </summary>
    public sealed class MarketID : StringField
    {
        public const int TAG = 1301;

        public MarketID()
            :base(Tags.MarketID) {}
        public MarketID(string val)
            :base(Tags.MarketID, val) {}

    }


    /// <summary>
    /// MassActionReportID Field
    /// </summary>
    public sealed class MassActionReportID : StringField
    {
        public const int TAG = 1369;

        public MassActionReportID()
            :base(Tags.MassActionReportID) {}
        public MassActionReportID(string val)
            :base(Tags.MassActionReportID, val) {}

    }


    /// <summary>
    /// OrderOrigination Field
    /// </summary>
    public sealed class OrderOrigination : IntField
    {
        public const int TAG = 1724;

        public OrderOrigination()
            :base(Tags.OrderOrigination) {}
        public OrderOrigination(int val)
            :base(Tags.OrderOrigination, val) {}


        // Field Enumerations
        public const int ORDER_RECEIVED_FROM_A_CUSTOMER = 1;
        public const int ORDER_RECEIVED_FROM_WITHIN_THE_FIRM = 2;
        public const int ORDER_RECEIVED_FROM_ANOTHER_BROKER_DEALER = 3;
        public const int ORDER_RECEIVED_FROM_A_CUSTOMER_OR_ORIGINATED_FROM_WITHIN_THE_FIRM = 4;
        public const int ORDER_RECEIVED_FROM_A_DIRECT_ACCESS_OR_SPONSORED_ACCESS_CUSTOMER = 5;
        public const int ORDER_RECEIVED_FROM_A_FOREIGN_DEALER_EQUIVALENT = 6;
        public const int ORDER_RECEIVED_FROM_AN_EXECUTION_ONLY_SERVICE = 7;
    }


    /// <summary>
    /// BidMDEntryID Field
    /// </summary>
    public sealed class BidMDEntryID : StringField
    {
        public const int TAG = 1745;

        public BidMDEntryID()
            :base(Tags.BidMDEntryID) {}
        public BidMDEntryID(string val)
            :base(Tags.BidMDEntryID, val) {}

    }


    /// <summary>
    /// OfferMDEntryID Field
    /// </summary>
    public sealed class OfferMDEntryID : StringField
    {
        public const int TAG = 1746;

        public OfferMDEntryID()
            :base(Tags.OfferMDEntryID) {}
        public OfferMDEntryID(string val)
            :base(Tags.OfferMDEntryID, val) {}

    }


    /// <summary>
    /// BidQuoteID Field
    /// </summary>
    public sealed class BidQuoteID : StringField
    {
        public const int TAG = 1747;

        public BidQuoteID()
            :base(Tags.BidQuoteID) {}
        public BidQuoteID(string val)
            :base(Tags.BidQuoteID, val) {}

    }


    /// <summary>
    /// OfferQuoteID Field
    /// </summary>
    public sealed class OfferQuoteID : StringField
    {
        public const int TAG = 1748;

        public OfferQuoteID()
            :base(Tags.OfferQuoteID) {}
        public OfferQuoteID(string val)
            :base(Tags.OfferQuoteID, val) {}

    }


    /// <summary>
    /// PartyRoleQualifier Field
    /// </summary>
    public sealed class PartyRoleQualifier : IntField
    {
        public const int TAG = 2376;

        public PartyRoleQualifier()
            :base(Tags.PartyRoleQualifier) {}
        public PartyRoleQualifier(int val)
            :base(Tags.PartyRoleQualifier, val) {}


        // Field Enumerations
        public const int AGENCY = 0;
        public const int PRINCIPAL = 1;
        public const int RISKLESS_PRINCIPAL = 2;
        public const int GENERAL_CLEARING_MEMBER = 3;
        public const int INDIVIDUAL_CLEARING_MEMBER = 4;
        public const int PREFERRED_MARKET_MAKER = 5;
        public const int DIRECTED_MARKET_MAKER = 6;
        public const int BANK = 7;
        public const int HUB = 8;
        public const int PRIMARY_TRADE_REPOSITORY = 9;
        public const int ORIGINAL_TRADE_REPOSITORY = 10;
        public const int ADDITIONAL_INTERNATIONAL_TRADE_REPOSITORY = 11;
        public const int ADDITIONAL_DOMESTIC_TRADE_REPOSITORY = 12;
        public const int RELATED_EXCHANGE = 13;
        public const int OPTIONS_EXCHANGE = 14;
        public const int SPECIFIED_EXCHANGE = 15;
        public const int CONSTITUENT_EXCHANGE = 16;
        public const int EXEMPT_FROM_TRADE_REPORTING = 17;
        public const int CURRENT = 18;
        public const int NEW = 19;
        public const int DESIGNATED_SPONSOR = 20;
        public const int SPECIALIST = 21;
        public const int ALGORITHM = 22;
        public const int FIRM_OR_LEGAL_ENTITY = 23;
        public const int NATURAL_PERSON = 24;
        public const int REGULAR_TRADER = 25;
        public const int HEAD_TRADER = 26;
        public const int SUPERVISOR = 27;
        public const int TRI_PARTY = 28;
        public const int LENDER = 29;
    }


    /// <summary>
    /// Signature Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class SecureData : StringField
    {
        public const int TAG = 91;

        public SecureData()
            :base(Tags.SecureData) {}
        public SecureData(string val)
            :base(Tags.SecureData, val) {}

    }


    /// <summary>
    /// SignatureLength Field
    /// </summary>
    public sealed class SignatureLength : IntField
    {
        public const int TAG = 93;

        public SignatureLength()
            :base(Tags.SignatureLength) {}
        public SignatureLength(int val)
            :base(Tags.SignatureLength, val) {}

    }


    /// <summary>
    /// RawDataLength Field
    /// </summary>
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
    /// </summary>
    public sealed class RawData : StringField
    {
        public const int TAG = 96;

        public RawData()
            :base(Tags.RawData) {}
        public RawData(string val)
            :base(Tags.RawData, val) {}

    }


    /// <summary>
    /// DeliverToCompID Field
    /// </summary>
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
    /// </summary>
    public sealed class DeliverToSubID : StringField
    {
        public const int TAG = 129;

        public DeliverToSubID()
            :base(Tags.DeliverToSubID) {}
        public DeliverToSubID(string val)
            :base(Tags.DeliverToSubID, val) {}

    }


    /// <summary>
    /// SenderLocationID Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class DeliverToLocationID : StringField
    {
        public const int TAG = 145;

        public DeliverToLocationID()
            :base(Tags.DeliverToLocationID) {}
        public DeliverToLocationID(string val)
            :base(Tags.DeliverToLocationID, val) {}

    }


    /// <summary>
    /// XmlDataLen Field
    /// </summary>
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
    /// </summary>
    public sealed class XmlData : StringField
    {
        public const int TAG = 213;

        public XmlData()
            :base(Tags.XmlData) {}
        public XmlData(string val)
            :base(Tags.XmlData, val) {}

    }


    /// <summary>
    /// MessageEncoding Field
    /// </summary>
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
    /// EncodedTextLen Field
    /// </summary>
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
    /// </summary>
    public sealed class EncodedText : StringField
    {
        public const int TAG = 355;

        public EncodedText()
            :base(Tags.EncodedText) {}
        public EncodedText(string val)
            :base(Tags.EncodedText, val) {}

    }


    /// <summary>
    /// LastMsgSeqNumProcessed Field
    /// </summary>
    public sealed class LastMsgSeqNumProcessed : SeqNumFieldType
    {
        public const int TAG = 369;

        public LastMsgSeqNumProcessed()
            :base(Tags.LastMsgSeqNumProcessed) {}
        public LastMsgSeqNumProcessed(SeqNumType val)
            :base(Tags.LastMsgSeqNumProcessed, val) {}

    }


    /// <summary>
    /// MaxMessageSize Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// TestMessageIndicator Field
    /// </summary>
    public sealed class TestMessageIndicator : BooleanField
    {
        public const int TAG = 464;

        public TestMessageIndicator()
            :base(Tags.TestMessageIndicator) {}
        public TestMessageIndicator(Boolean val)
            :base(Tags.TestMessageIndicator, val) {}

    }


    /// <summary>
    /// Password Field
    /// </summary>
    public sealed class Password : StringField
    {
        public const int TAG = 554;

        public Password()
            :base(Tags.Password) {}
        public Password(string val)
            :base(Tags.Password, val) {}

    }


    /// <summary>
    /// NoHops Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class HopRefID : SeqNumFieldType
    {
        public const int TAG = 630;

        public HopRefID()
            :base(Tags.HopRefID) {}
        public HopRefID(SeqNumType val)
            :base(Tags.HopRefID, val) {}

    }


    /// <summary>
    /// NextExpectedMsgSeqNum Field
    /// </summary>
    public sealed class NextExpectedMsgSeqNum : SeqNumFieldType
    {
        public const int TAG = 789;

        public NextExpectedMsgSeqNum()
            :base(Tags.NextExpectedMsgSeqNum) {}
        public NextExpectedMsgSeqNum(SeqNumType val)
            :base(Tags.NextExpectedMsgSeqNum, val) {}

    }


    /// <summary>
    /// ApplVerID Field
    /// </summary>
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
    /// </summary>
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
    /// </summary>
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
    /// </summary>
    public sealed class RefCstmApplVerID : StringField
    {
        public const int TAG = 1131;

        public RefCstmApplVerID()
            :base(Tags.RefCstmApplVerID) {}
        public RefCstmApplVerID(string val)
            :base(Tags.RefCstmApplVerID, val) {}

    }


    /// <summary>
    /// ApplExtID Field
    /// </summary>
    public sealed class ApplExtID : IntField
    {
        public const int TAG = 1156;

        public ApplExtID()
            :base(Tags.ApplExtID) {}
        public ApplExtID(int val)
            :base(Tags.ApplExtID, val) {}

    }


}
