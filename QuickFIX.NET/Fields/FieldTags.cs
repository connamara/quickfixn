using System;

namespace QuickFix.Fields
{
    /// <summary>
    /// FIX Field Tag Values
    /// </summary>/
    public static class Tags
    {
        public const int Account = 1;
        public const int AdvId = 2;
        public const int AdvRefID = 3;
        public const int AdvSide = 4;
        public const int AdvTransType = 5;
        public const int AvgPx = 6;
        public const int BeginSeqNo = 7;
        public const int BeginString = 8;
        public const int BodyLength = 9;
        public const int CheckSum = 10;
        public const int ClOrdID = 11;
        public const int Commission = 12;
        public const int CommType = 13;
        public const int CumQty = 14;
        public const int Currency = 15;
        public const int EndSeqNo = 16;
        public const int ExecID = 17;
        public const int ExecInst = 18;
        public const int ExecRefID = 19;
        public const int ExecTransType = 20;
        public const int HandlInst = 21;
        public const int SecurityIDSource = 22;
        public const int IOIID = 23;
        public const int IOIOthSvc = 24;
        public const int IOIQltyInd = 25;
        public const int IOIRefID = 26;
        public const int IOIQty = 27;
        public const int IOITransType = 28;
        public const int LastCapacity = 29;
        public const int LastMkt = 30;
        public const int LastPx = 31;
        public const int LastQty = 32;
        public const int NoLinesOfText = 33;
        public const int MsgSeqNum = 34;
        public const int MsgType = 35;
        public const int NewSeqNo = 36;
        public const int OrderID = 37;
        public const int OrderQty = 38;
        public const int OrdStatus = 39;
        public const int OrdType = 40;
        public const int OrigClOrdID = 41;
        public const int OrigTime = 42;
        public const int PossDupFlag = 43;
        public const int Price = 44;
        public const int RefSeqNum = 45;
        public const int RelatdSym = 46;
        public const int Rule80A = 47;
        public const int SecurityID = 48;
        public const int SenderCompID = 49;
        public const int SenderSubID = 50;
        public const int SendingDate = 51;
        public const int SendingTime = 52;
        public const int Quantity = 53;
        public const int Side = 54;
        public const int Symbol = 55;
        public const int TargetCompID = 56;
        public const int TargetSubID = 57;
        public const int Text = 58;
        public const int TimeInForce = 59;
        public const int TransactTime = 60;
        public const int Urgency = 61;
        public const int ValidUntilTime = 62;
        public const int SettlType = 63;
        public const int SettlDate = 64;
        public const int SymbolSfx = 65;
        public const int ListID = 66;
        public const int ListSeqNo = 67;
        public const int TotNoOrders = 68;
        public const int ListExecInst = 69;
        public const int AllocID = 70;
        public const int AllocTransType = 71;
        public const int RefAllocID = 72;
        public const int NoOrders = 73;
        public const int AvgPxPrecision = 74;
        public const int TradeDate = 75;
        public const int ExecBroker = 76;
        public const int PositionEffect = 77;
        public const int NoAllocs = 78;
        public const int AllocAccount = 79;
        public const int AllocQty = 80;
        public const int ProcessCode = 81;
        public const int NoRpts = 82;
        public const int RptSeq = 83;
        public const int CxlQty = 84;
        public const int NoDlvyInst = 85;
        public const int DlvyInst = 86;
        public const int AllocStatus = 87;
        public const int AllocRejCode = 88;
        public const int Signature = 89;
        public const int SecureDataLen = 90;
        public const int SecureData = 91;
        public const int BrokerOfCredit = 92;
        public const int SignatureLength = 93;
        public const int EmailType = 94;
        public const int RawDataLength = 95;
        public const int RawData = 96;
        public const int PossResend = 97;
        public const int EncryptMethod = 98;
        public const int StopPx = 99;
        public const int ExDestination = 100;
        public const int CxlRejReason = 102;
        public const int OrdRejReason = 103;
        public const int IOIQualifier = 104;
        public const int WaveNo = 105;
        public const int Issuer = 106;
        public const int SecurityDesc = 107;
        public const int HeartBtInt = 108;
        public const int ClientID = 109;
        public const int MinQty = 110;
        public const int MaxFloor = 111;
        public const int TestReqID = 112;
        public const int ReportToExch = 113;
        public const int LocateReqd = 114;
        public const int OnBehalfOfCompID = 115;
        public const int OnBehalfOfSubID = 116;
        public const int QuoteID = 117;
        public const int NetMoney = 118;
        public const int SettlCurrAmt = 119;
        public const int SettlCurrency = 120;
        public const int ForexReq = 121;
        public const int OrigSendingTime = 122;
        public const int GapFillFlag = 123;
        public const int NoExecs = 124;
        public const int CxlType = 125;
        public const int ExpireTime = 126;
        public const int DKReason = 127;
        public const int DeliverToCompID = 128;
        public const int DeliverToSubID = 129;
        public const int IOINaturalFlag = 130;
        public const int QuoteReqID = 131;
        public const int BidPx = 132;
        public const int OfferPx = 133;
        public const int BidSize = 134;
        public const int OfferSize = 135;
        public const int NoMiscFees = 136;
        public const int MiscFeeAmt = 137;
        public const int MiscFeeCurr = 138;
        public const int MiscFeeType = 139;
        public const int PrevClosePx = 140;
        public const int ResetSeqNumFlag = 141;
        public const int SenderLocationID = 142;
        public const int TargetLocationID = 143;
        public const int OnBehalfOfLocationID = 144;
        public const int DeliverToLocationID = 145;
        public const int NoRelatedSym = 146;
        public const int Subject = 147;
        public const int Headline = 148;
        public const int URLLink = 149;
        public const int ExecType = 150;
        public const int LeavesQty = 151;
        public const int CashOrderQty = 152;
        public const int AllocAvgPx = 153;
        public const int AllocNetMoney = 154;
        public const int SettlCurrFxRate = 155;
        public const int SettlCurrFxRateCalc = 156;
        public const int NumDaysInterest = 157;
        public const int AccruedInterestRate = 158;
        public const int AccruedInterestAmt = 159;
        public const int SettlInstMode = 160;
        public const int AllocText = 161;
        public const int SettlInstID = 162;
        public const int SettlInstTransType = 163;
        public const int EmailThreadID = 164;
        public const int SettlInstSource = 165;
        public const int SettlLocation = 166;
        public const int SecurityType = 167;
        public const int EffectiveTime = 168;
        public const int StandInstDbType = 169;
        public const int StandInstDbName = 170;
        public const int StandInstDbID = 171;
        public const int SettlDeliveryType = 172;
        public const int SettlDepositoryCode = 173;
        public const int SettlBrkrCode = 174;
        public const int SettlInstCode = 175;
        public const int SecuritySettlAgentName = 176;
        public const int SecuritySettlAgentCode = 177;
        public const int SecuritySettlAgentAcctNum = 178;
        public const int SecuritySettlAgentAcctName = 179;
        public const int SecuritySettlAgentContactName = 180;
        public const int SecuritySettlAgentContactPhone = 181;
        public const int CashSettlAgentName = 182;
        public const int CashSettlAgentCode = 183;
        public const int CashSettlAgentAcctNum = 184;
        public const int CashSettlAgentAcctName = 185;
        public const int CashSettlAgentContactName = 186;
        public const int CashSettlAgentContactPhone = 187;
        public const int BidSpotRate = 188;
        public const int BidForwardPoints = 189;
        public const int OfferSpotRate = 190;
        public const int OfferForwardPoints = 191;
        public const int OrderQty2 = 192;
        public const int SettlDate2 = 193;
        public const int LastSpotRate = 194;
        public const int LastForwardPoints = 195;
        public const int AllocLinkID = 196;
        public const int AllocLinkType = 197;
        public const int SecondaryOrderID = 198;
        public const int NoIOIQualifiers = 199;
        public const int MaturityMonthYear = 200;
        public const int PutOrCall = 201;
        public const int StrikePrice = 202;
        public const int CoveredOrUncovered = 203;
        public const int CustomerOrFirm = 204;
        public const int MaturityDay = 205;
        public const int OptAttribute = 206;
        public const int SecurityExchange = 207;
        public const int NotifyBrokerOfCredit = 208;
        public const int AllocHandlInst = 209;
        public const int MaxShow = 210;
        public const int PegOffsetValue = 211;
        public const int XmlDataLen = 212;
        public const int XmlData = 213;
        public const int SettlInstRefID = 214;
        public const int NoRoutingIDs = 215;
        public const int RoutingType = 216;
        public const int RoutingID = 217;
        public const int Spread = 218;
        public const int Benchmark = 219;
        public const int BenchmarkCurveCurrency = 220;
        public const int BenchmarkCurveName = 221;
        public const int BenchmarkCurvePoint = 222;
        public const int CouponRate = 223;
        public const int CouponPaymentDate = 224;
        public const int IssueDate = 225;
        public const int RepurchaseTerm = 226;
        public const int RepurchaseRate = 227;
        public const int Factor = 228;
        public const int TradeOriginationDate = 229;
        public const int ExDate = 230;
        public const int ContractMultiplier = 231;
        public const int NoStipulations = 232;
        public const int StipulationType = 233;
        public const int StipulationValue = 234;
        public const int YieldType = 235;
        public const int Yield = 236;
        public const int TotalTakedown = 237;
        public const int Concession = 238;
        public const int RepoCollateralSecurityType = 239;
        public const int RedemptionDate = 240;
        public const int UnderlyingCouponPaymentDate = 241;
        public const int UnderlyingIssueDate = 242;
        public const int UnderlyingRepoCollateralSecurityType = 243;
        public const int UnderlyingRepurchaseTerm = 244;
        public const int UnderlyingRepurchaseRate = 245;
        public const int UnderlyingFactor = 246;
        public const int UnderlyingRedemptionDate = 247;
        public const int LegCouponPaymentDate = 248;
        public const int LegIssueDate = 249;
        public const int LegRepoCollateralSecurityType = 250;
        public const int LegRepurchaseTerm = 251;
        public const int LegRepurchaseRate = 252;
        public const int LegFactor = 253;
        public const int LegRedemptionDate = 254;
        public const int CreditRating = 255;
        public const int UnderlyingCreditRating = 256;
        public const int LegCreditRating = 257;
        public const int TradedFlatSwitch = 258;
        public const int BasisFeatureDate = 259;
        public const int BasisFeaturePrice = 260;
        public const int MDReqID = 262;
        public const int SubscriptionRequestType = 263;
        public const int MarketDepth = 264;
        public const int MDUpdateType = 265;
        public const int AggregatedBook = 266;
        public const int NoMDEntryTypes = 267;
        public const int NoMDEntries = 268;
        public const int MDEntryType = 269;
        public const int MDEntryPx = 270;
        public const int MDEntrySize = 271;
        public const int MDEntryDate = 272;
        public const int MDEntryTime = 273;
        public const int TickDirection = 274;
        public const int MDMkt = 275;
        public const int QuoteCondition = 276;
        public const int TradeCondition = 277;
        public const int MDEntryID = 278;
        public const int MDUpdateAction = 279;
        public const int MDEntryRefID = 280;
        public const int MDReqRejReason = 281;
        public const int MDEntryOriginator = 282;
        public const int LocationID = 283;
        public const int DeskID = 284;
        public const int DeleteReason = 285;
        public const int OpenCloseSettlFlag = 286;
        public const int SellerDays = 287;
        public const int MDEntryBuyer = 288;
        public const int MDEntrySeller = 289;
        public const int MDEntryPositionNo = 290;
        public const int FinancialStatus = 291;
        public const int CorporateAction = 292;
        public const int DefBidSize = 293;
        public const int DefOfferSize = 294;
        public const int NoQuoteEntries = 295;
        public const int NoQuoteSets = 296;
        public const int QuoteStatus = 297;
        public const int QuoteCancelType = 298;
        public const int QuoteEntryID = 299;
        public const int QuoteRejectReason = 300;
        public const int QuoteResponseLevel = 301;
        public const int QuoteSetID = 302;
        public const int QuoteRequestType = 303;
        public const int TotNoQuoteEntries = 304;
        public const int UnderlyingSecurityIDSource = 305;
        public const int UnderlyingIssuer = 306;
        public const int UnderlyingSecurityDesc = 307;
        public const int UnderlyingSecurityExchange = 308;
        public const int UnderlyingSecurityID = 309;
        public const int UnderlyingSecurityType = 310;
        public const int UnderlyingSymbol = 311;
        public const int UnderlyingSymbolSfx = 312;
        public const int UnderlyingMaturityMonthYear = 313;
        public const int UnderlyingMaturityDay = 314;
        public const int UnderlyingPutOrCall = 315;
        public const int UnderlyingStrikePrice = 316;
        public const int UnderlyingOptAttribute = 317;
        public const int UnderlyingCurrency = 318;
        public const int RatioQty = 319;
        public const int SecurityReqID = 320;
        public const int SecurityRequestType = 321;
        public const int SecurityResponseID = 322;
        public const int SecurityResponseType = 323;
        public const int SecurityStatusReqID = 324;
        public const int UnsolicitedIndicator = 325;
        public const int SecurityTradingStatus = 326;
        public const int HaltReasonChar = 327;
        public const int InViewOfCommon = 328;
        public const int DueToRelated = 329;
        public const int BuyVolume = 330;
        public const int SellVolume = 331;
        public const int HighPx = 332;
        public const int LowPx = 333;
        public const int Adjustment = 334;
        public const int TradSesReqID = 335;
        public const int TradingSessionID = 336;
        public const int ContraTrader = 337;
        public const int TradSesMethod = 338;
        public const int TradSesMode = 339;
        public const int TradSesStatus = 340;
        public const int TradSesStartTime = 341;
        public const int TradSesOpenTime = 342;
        public const int TradSesPreCloseTime = 343;
        public const int TradSesCloseTime = 344;
        public const int TradSesEndTime = 345;
        public const int NumberOfOrders = 346;
        public const int MessageEncoding = 347;
        public const int EncodedIssuerLen = 348;
        public const int EncodedIssuer = 349;
        public const int EncodedSecurityDescLen = 350;
        public const int EncodedSecurityDesc = 351;
        public const int EncodedListExecInstLen = 352;
        public const int EncodedListExecInst = 353;
        public const int EncodedTextLen = 354;
        public const int EncodedText = 355;
        public const int EncodedSubjectLen = 356;
        public const int EncodedSubject = 357;
        public const int EncodedHeadlineLen = 358;
        public const int EncodedHeadline = 359;
        public const int EncodedAllocTextLen = 360;
        public const int EncodedAllocText = 361;
        public const int EncodedUnderlyingIssuerLen = 362;
        public const int EncodedUnderlyingIssuer = 363;
        public const int EncodedUnderlyingSecurityDescLen = 364;
        public const int EncodedUnderlyingSecurityDesc = 365;
        public const int AllocPrice = 366;
        public const int QuoteSetValidUntilTime = 367;
        public const int QuoteEntryRejectReason = 368;
        public const int LastMsgSeqNumProcessed = 369;
        public const int OnBehalfOfSendingTime = 370;
        public const int RefTagID = 371;
        public const int RefMsgType = 372;
        public const int SessionRejectReason = 373;
        public const int BidRequestTransType = 374;
        public const int ContraBroker = 375;
        public const int ComplianceID = 376;
        public const int SolicitedFlag = 377;
        public const int ExecRestatementReason = 378;
        public const int BusinessRejectRefID = 379;
        public const int BusinessRejectReason = 380;
        public const int GrossTradeAmt = 381;
        public const int NoContraBrokers = 382;
        public const int MaxMessageSize = 383;
        public const int NoMsgTypes = 384;
        public const int MsgDirection = 385;
        public const int NoTradingSessions = 386;
        public const int TotalVolumeTraded = 387;
        public const int DiscretionInst = 388;
        public const int DiscretionOffsetValue = 389;
        public const int BidID = 390;
        public const int ClientBidID = 391;
        public const int ListName = 392;
        public const int TotNoRelatedSym = 393;
        public const int BidType = 394;
        public const int NumTickets = 395;
        public const int SideValue1 = 396;
        public const int SideValue2 = 397;
        public const int NoBidDescriptors = 398;
        public const int BidDescriptorType = 399;
        public const int BidDescriptor = 400;
        public const int SideValueInd = 401;
        public const int LiquidityPctLow = 402;
        public const int LiquidityPctHigh = 403;
        public const int LiquidityValue = 404;
        public const int EFPTrackingError = 405;
        public const int FairValue = 406;
        public const int OutsideIndexPct = 407;
        public const int ValueOfFutures = 408;
        public const int LiquidityIndType = 409;
        public const int WtAverageLiquidity = 410;
        public const int ExchangeForPhysical = 411;
        public const int OutMainCntryUIndex = 412;
        public const int CrossPercent = 413;
        public const int ProgRptReqs = 414;
        public const int ProgPeriodInterval = 415;
        public const int IncTaxInd = 416;
        public const int NumBidders = 417;
        public const int BidTradeType = 418;
        public const int BasisPxType = 419;
        public const int NoBidComponents = 420;
        public const int Country = 421;
        public const int TotNoStrikes = 422;
        public const int PriceType = 423;
        public const int DayOrderQty = 424;
        public const int DayCumQty = 425;
        public const int DayAvgPx = 426;
        public const int GTBookingInst = 427;
        public const int NoStrikes = 428;
        public const int ListStatusType = 429;
        public const int NetGrossInd = 430;
        public const int ListOrderStatus = 431;
        public const int ExpireDate = 432;
        public const int ListExecInstType = 433;
        public const int CxlRejResponseTo = 434;
        public const int UnderlyingCouponRate = 435;
        public const int UnderlyingContractMultiplier = 436;
        public const int ContraTradeQty = 437;
        public const int ContraTradeTime = 438;
        public const int ClearingFirm = 439;
        public const int ClearingAccount = 440;
        public const int LiquidityNumSecurities = 441;
        public const int MultiLegReportingType = 442;
        public const int StrikeTime = 443;
        public const int ListStatusText = 444;
        public const int EncodedListStatusTextLen = 445;
        public const int EncodedListStatusText = 446;
        public const int PartyIDSource = 447;
        public const int PartyID = 448;
        public const int TotalVolumeTradedDate = 449;
        public const int TotalVolumeTradedTime = 450;
        public const int NetChgPrevDay = 451;
        public const int PartyRole = 452;
        public const int NoPartyIDs = 453;
        public const int NoSecurityAltID = 454;
        public const int SecurityAltID = 455;
        public const int SecurityAltIDSource = 456;
        public const int NoUnderlyingSecurityAltID = 457;
        public const int UnderlyingSecurityAltID = 458;
        public const int UnderlyingSecurityAltIDSource = 459;
        public const int Product = 460;
        public const int CFICode = 461;
        public const int UnderlyingProduct = 462;
        public const int UnderlyingCFICode = 463;
        public const int TestMessageIndicator = 464;
        public const int QuantityType = 465;
        public const int BookingRefID = 466;
        public const int IndividualAllocID = 467;
        public const int RoundingDirection = 468;
        public const int RoundingModulus = 469;
        public const int CountryOfIssue = 470;
        public const int StateOrProvinceOfIssue = 471;
        public const int LocaleOfIssue = 472;
        public const int NoRegistDtls = 473;
        public const int MailingDtls = 474;
        public const int InvestorCountryOfResidence = 475;
        public const int PaymentRef = 476;
        public const int DistribPaymentMethod = 477;
        public const int CashDistribCurr = 478;
        public const int CommCurrency = 479;
        public const int CancellationRights = 480;
        public const int MoneyLaunderingStatus = 481;
        public const int MailingInst = 482;
        public const int TransBkdTime = 483;
        public const int ExecPriceType = 484;
        public const int ExecPriceAdjustment = 485;
        public const int DateOfBirth = 486;
        public const int TradeReportTransType = 487;
        public const int CardHolderName = 488;
        public const int CardNumber = 489;
        public const int CardExpDate = 490;
        public const int CardIssNum = 491;
        public const int PaymentMethod = 492;
        public const int RegistAcctType = 493;
        public const int Designation = 494;
        public const int TaxAdvantageType = 495;
        public const int RegistRejReasonText = 496;
        public const int FundRenewWaiv = 497;
        public const int CashDistribAgentName = 498;
        public const int CashDistribAgentCode = 499;
        public const int CashDistribAgentAcctNumber = 500;
        public const int CashDistribPayRef = 501;
        public const int CashDistribAgentAcctName = 502;
        public const int CardStartDate = 503;
        public const int PaymentDate = 504;
        public const int PaymentRemitterID = 505;
        public const int RegistStatus = 506;
        public const int RegistRejReasonCode = 507;
        public const int RegistRefID = 508;
        public const int RegistDtls = 509;
        public const int NoDistribInsts = 510;
        public const int RegistEmail = 511;
        public const int DistribPercentage = 512;
        public const int RegistID = 513;
        public const int RegistTransType = 514;
        public const int ExecValuationPoint = 515;
        public const int OrderPercent = 516;
        public const int OwnershipType = 517;
        public const int NoContAmts = 518;
        public const int ContAmtType = 519;
        public const int ContAmtValue = 520;
        public const int ContAmtCurr = 521;
        public const int OwnerType = 522;
        public const int PartySubID = 523;
        public const int NestedPartyID = 524;
        public const int NestedPartyIDSource = 525;
        public const int SecondaryClOrdID = 526;
        public const int SecondaryExecID = 527;
        public const int OrderCapacity = 528;
        public const int OrderRestrictions = 529;
        public const int MassCancelRequestType = 530;
        public const int MassCancelResponse = 531;
        public const int MassCancelRejectReason = 532;
        public const int TotalAffectedOrders = 533;
        public const int NoAffectedOrders = 534;
        public const int AffectedOrderID = 535;
        public const int AffectedSecondaryOrderID = 536;
        public const int QuoteType = 537;
        public const int NestedPartyRole = 538;
        public const int NoNestedPartyIDs = 539;
        public const int TotalAccruedInterestAmt = 540;
        public const int MaturityDate = 541;
        public const int UnderlyingMaturityDate = 542;
        public const int InstrRegistry = 543;
        public const int CashMargin = 544;
        public const int NestedPartySubID = 545;
        public const int Scope = 546;
        public const int MDImplicitDelete = 547;
        public const int CrossID = 548;
        public const int CrossType = 549;
        public const int CrossPrioritization = 550;
        public const int OrigCrossID = 551;
        public const int NoSides = 552;
        public const int Username = 553;
        public const int Password = 554;
        public const int NoLegs = 555;
        public const int LegCurrency = 556;
        public const int TotNoSecurityTypes = 557;
        public const int NoSecurityTypes = 558;
        public const int SecurityListRequestType = 559;
        public const int SecurityRequestResult = 560;
        public const int RoundLot = 561;
        public const int MinTradeVol = 562;
        public const int MultiLegRptTypeReq = 563;
        public const int LegPositionEffect = 564;
        public const int LegCoveredOrUncovered = 565;
        public const int LegPrice = 566;
        public const int TradSesStatusRejReason = 567;
        public const int TradeRequestID = 568;
        public const int TradeRequestType = 569;
        public const int PreviouslyReported = 570;
        public const int TradeReportID = 571;
        public const int TradeReportRefID = 572;
        public const int MatchStatus = 573;
        public const int MatchType = 574;
        public const int OddLot = 575;
        public const int NoClearingInstructions = 576;
        public const int ClearingInstruction = 577;
        public const int TradeInputSource = 578;
        public const int TradeInputDevice = 579;
        public const int NoDates = 580;
        public const int AccountType = 581;
        public const int CustOrderCapacity = 582;
        public const int ClOrdLinkID = 583;
        public const int MassStatusReqID = 584;
        public const int MassStatusReqType = 585;
        public const int OrigOrdModTime = 586;
        public const int LegSettlType = 587;
        public const int LegSettlDate = 588;
        public const int DayBookingInst = 589;
        public const int BookingUnit = 590;
        public const int PreallocMethod = 591;
        public const int UnderlyingCountryOfIssue = 592;
        public const int UnderlyingStateOrProvinceOfIssue = 593;
        public const int UnderlyingLocaleOfIssue = 594;
        public const int UnderlyingInstrRegistry = 595;
        public const int LegCountryOfIssue = 596;
        public const int LegStateOrProvinceOfIssue = 597;
        public const int LegLocaleOfIssue = 598;
        public const int LegInstrRegistry = 599;
        public const int LegSymbol = 600;
        public const int LegSymbolSfx = 601;
        public const int LegSecurityID = 602;
        public const int LegSecurityIDSource = 603;
        public const int NoLegSecurityAltID = 604;
        public const int LegSecurityAltID = 605;
        public const int LegSecurityAltIDSource = 606;
        public const int LegProduct = 607;
        public const int LegCFICode = 608;
        public const int LegSecurityType = 609;
        public const int LegMaturityMonthYear = 610;
        public const int LegMaturityDate = 611;
        public const int LegStrikePrice = 612;
        public const int LegOptAttribute = 613;
        public const int LegContractMultiplier = 614;
        public const int LegCouponRate = 615;
        public const int LegSecurityExchange = 616;
        public const int LegIssuer = 617;
        public const int EncodedLegIssuerLen = 618;
        public const int EncodedLegIssuer = 619;
        public const int LegSecurityDesc = 620;
        public const int EncodedLegSecurityDescLen = 621;
        public const int EncodedLegSecurityDesc = 622;
        public const int LegRatioQty = 623;
        public const int LegSide = 624;
        public const int TradingSessionSubID = 625;
        public const int AllocType = 626;
        public const int NoHops = 627;
        public const int HopCompID = 628;
        public const int HopSendingTime = 629;
        public const int HopRefID = 630;
        public const int MidPx = 631;
        public const int BidYield = 632;
        public const int MidYield = 633;
        public const int OfferYield = 634;
        public const int ClearingFeeIndicator = 635;
        public const int WorkingIndicator = 636;
        public const int LegLastPx = 637;
        public const int PriorityIndicator = 638;
        public const int PriceImprovement = 639;
        public const int Price2 = 640;
        public const int LastForwardPoints2 = 641;
        public const int BidForwardPoints2 = 642;
        public const int OfferForwardPoints2 = 643;
        public const int RFQReqID = 644;
        public const int MktBidPx = 645;
        public const int MktOfferPx = 646;
        public const int MinBidSize = 647;
        public const int MinOfferSize = 648;
        public const int QuoteStatusReqID = 649;
        public const int LegalConfirm = 650;
        public const int UnderlyingLastPx = 651;
        public const int UnderlyingLastQty = 652;
        public const int SecDefStatus = 653;
        public const int LegRefID = 654;
        public const int ContraLegRefID = 655;
        public const int SettlCurrBidFxRate = 656;
        public const int SettlCurrOfferFxRate = 657;
        public const int QuoteRequestRejectReason = 658;
        public const int SideComplianceID = 659;
        public const int AcctIDSource = 660;
        public const int AllocAcctIDSource = 661;
        public const int BenchmarkPrice = 662;
        public const int BenchmarkPriceType = 663;
        public const int ConfirmID = 664;
        public const int ConfirmStatus = 665;
        public const int ConfirmTransType = 666;
        public const int ContractSettlMonth = 667;
        public const int DeliveryForm = 668;
        public const int LastParPx = 669;
        public const int NoLegAllocs = 670;
        public const int LegAllocAccount = 671;
        public const int LegIndividualAllocID = 672;
        public const int LegAllocQty = 673;
        public const int LegAllocAcctIDSource = 674;
        public const int LegSettlCurrency = 675;
        public const int LegBenchmarkCurveCurrency = 676;
        public const int LegBenchmarkCurveName = 677;
        public const int LegBenchmarkCurvePoint = 678;
        public const int LegBenchmarkPrice = 679;
        public const int LegBenchmarkPriceType = 680;
        public const int LegBidPx = 681;
        public const int LegIOIQty = 682;
        public const int NoLegStipulations = 683;
        public const int LegOfferPx = 684;
        public const int LegOrderQty = 685;
        public const int LegPriceType = 686;
        public const int LegQty = 687;
        public const int LegStipulationType = 688;
        public const int LegStipulationValue = 689;
        public const int LegSwapType = 690;
        public const int Pool = 691;
        public const int QuotePriceType = 692;
        public const int QuoteRespID = 693;
        public const int QuoteRespType = 694;
        public const int QuoteQualifier = 695;
        public const int YieldRedemptionDate = 696;
        public const int YieldRedemptionPrice = 697;
        public const int YieldRedemptionPriceType = 698;
        public const int BenchmarkSecurityID = 699;
        public const int ReversalIndicator = 700;
        public const int YieldCalcDate = 701;
        public const int NoPositions = 702;
        public const int PosType = 703;
        public const int LongQty = 704;
        public const int ShortQty = 705;
        public const int PosQtyStatus = 706;
        public const int PosAmtType = 707;
        public const int PosAmt = 708;
        public const int PosTransType = 709;
        public const int PosReqID = 710;
        public const int NoUnderlyings = 711;
        public const int PosMaintAction = 712;
        public const int OrigPosReqRefID = 713;
        public const int PosMaintRptRefID = 714;
        public const int ClearingBusinessDate = 715;
        public const int SettlSessID = 716;
        public const int SettlSessSubID = 717;
        public const int AdjustmentType = 718;
        public const int ContraryInstructionIndicator = 719;
        public const int PriorSpreadIndicator = 720;
        public const int PosMaintRptID = 721;
        public const int PosMaintStatus = 722;
        public const int PosMaintResult = 723;
        public const int PosReqType = 724;
        public const int ResponseTransportType = 725;
        public const int ResponseDestination = 726;
        public const int TotalNumPosReports = 727;
        public const int PosReqResult = 728;
        public const int PosReqStatus = 729;
        public const int SettlPrice = 730;
        public const int SettlPriceType = 731;
        public const int UnderlyingSettlPrice = 732;
        public const int UnderlyingSettlPriceType = 733;
        public const int PriorSettlPrice = 734;
        public const int NoQuoteQualifiers = 735;
        public const int AllocSettlCurrency = 736;
        public const int AllocSettlCurrAmt = 737;
        public const int InterestAtMaturity = 738;
        public const int LegDatedDate = 739;
        public const int LegPool = 740;
        public const int AllocInterestAtMaturity = 741;
        public const int AllocAccruedInterestAmt = 742;
        public const int DeliveryDate = 743;
        public const int AssignmentMethod = 744;
        public const int AssignmentUnit = 745;
        public const int OpenInterest = 746;
        public const int ExerciseMethod = 747;
        public const int TotNumTradeReports = 748;
        public const int TradeRequestResult = 749;
        public const int TradeRequestStatus = 750;
        public const int TradeReportRejectReason = 751;
        public const int SideMultiLegReportingType = 752;
        public const int NoPosAmt = 753;
        public const int AutoAcceptIndicator = 754;
        public const int AllocReportID = 755;
        public const int NoNested2PartyIDs = 756;
        public const int Nested2PartyID = 757;
        public const int Nested2PartyIDSource = 758;
        public const int Nested2PartyRole = 759;
        public const int Nested2PartySubID = 760;
        public const int BenchmarkSecurityIDSource = 761;
        public const int SecuritySubType = 762;
        public const int UnderlyingSecuritySubType = 763;
        public const int LegSecuritySubType = 764;
        public const int AllowableOneSidednessPct = 765;
        public const int AllowableOneSidednessValue = 766;
        public const int AllowableOneSidednessCurr = 767;
        public const int NoTrdRegTimestamps = 768;
        public const int TrdRegTimestamp = 769;
        public const int TrdRegTimestampType = 770;
        public const int TrdRegTimestampOrigin = 771;
        public const int ConfirmRefID = 772;
        public const int ConfirmType = 773;
        public const int ConfirmRejReason = 774;
        public const int BookingType = 775;
        public const int IndividualAllocRejCode = 776;
        public const int SettlInstMsgID = 777;
        public const int NoSettlInst = 778;
        public const int LastUpdateTime = 779;
        public const int AllocSettlInstType = 780;
        public const int NoSettlPartyIDs = 781;
        public const int SettlPartyID = 782;
        public const int SettlPartyIDSource = 783;
        public const int SettlPartyRole = 784;
        public const int SettlPartySubID = 785;
        public const int SettlPartySubIDType = 786;
        public const int DlvyInstType = 787;
        public const int TerminationType = 788;
        public const int NextExpectedMsgSeqNum = 789;
        public const int OrdStatusReqID = 790;
        public const int SettlInstReqID = 791;
        public const int SettlInstReqRejCode = 792;
        public const int SecondaryAllocID = 793;
        public const int AllocReportType = 794;
        public const int AllocReportRefID = 795;
        public const int AllocCancReplaceReason = 796;
        public const int CopyMsgIndicator = 797;
        public const int AllocAccountType = 798;
        public const int OrderAvgPx = 799;
        public const int OrderBookingQty = 800;
        public const int NoSettlPartySubIDs = 801;
        public const int NoPartySubIDs = 802;
        public const int PartySubIDType = 803;
        public const int NoNestedPartySubIDs = 804;
        public const int NestedPartySubIDType = 805;
        public const int NoNested2PartySubIDs = 806;
        public const int Nested2PartySubIDType = 807;
        public const int AllocIntermedReqType = 808;
        public const int UnderlyingPx = 810;
        public const int PriceDelta = 811;
        public const int ApplQueueMax = 812;
        public const int ApplQueueDepth = 813;
        public const int ApplQueueResolution = 814;
        public const int ApplQueueAction = 815;
        public const int NoAltMDSource = 816;
        public const int AltMDSourceID = 817;
        public const int SecondaryTradeReportID = 818;
        public const int AvgPxIndicator = 819;
        public const int TradeLinkID = 820;
        public const int OrderInputDevice = 821;
        public const int UnderlyingTradingSessionID = 822;
        public const int UnderlyingTradingSessionSubID = 823;
        public const int TradeLegRefID = 824;
        public const int ExchangeRule = 825;
        public const int TradeAllocIndicator = 826;
        public const int ExpirationCycle = 827;
        public const int TrdType = 828;
        public const int TrdSubType = 829;
        public const int TransferReason = 830;
        public const int AsgnReqID = 831;
        public const int TotNumAssignmentReports = 832;
        public const int AsgnRptID = 833;
        public const int ThresholdAmount = 834;
        public const int PegMoveType = 835;
        public const int PegOffsetType = 836;
        public const int PegLimitType = 837;
        public const int PegRoundDirection = 838;
        public const int PeggedPrice = 839;
        public const int PegScope = 840;
        public const int DiscretionMoveType = 841;
        public const int DiscretionOffsetType = 842;
        public const int DiscretionLimitType = 843;
        public const int DiscretionRoundDirection = 844;
        public const int DiscretionPrice = 845;
        public const int DiscretionScope = 846;
        public const int TargetStrategy = 847;
        public const int TargetStrategyParameters = 848;
        public const int ParticipationRate = 849;
        public const int TargetStrategyPerformance = 850;
        public const int LastLiquidityInd = 851;
        public const int PublishTrdIndicator = 852;
        public const int ShortSaleReason = 853;
        public const int QtyType = 854;
        public const int SecondaryTrdType = 855;
        public const int TradeReportType = 856;
        public const int AllocNoOrdersType = 857;
        public const int SharedCommission = 858;
        public const int ConfirmReqID = 859;
        public const int AvgParPx = 860;
        public const int ReportedPx = 861;
        public const int NoCapacities = 862;
        public const int OrderCapacityQty = 863;
        public const int NoEvents = 864;
        public const int EventType = 865;
        public const int EventDate = 866;
        public const int EventPx = 867;
        public const int EventText = 868;
        public const int PctAtRisk = 869;
        public const int NoInstrAttrib = 870;
        public const int InstrAttribType = 871;
        public const int InstrAttribValue = 872;
        public const int DatedDate = 873;
        public const int InterestAccrualDate = 874;
        public const int CPProgram = 875;
        public const int CPRegType = 876;
        public const int UnderlyingCPProgram = 877;
        public const int UnderlyingCPRegType = 878;
        public const int UnderlyingQty = 879;
        public const int TrdMatchID = 880;
        public const int SecondaryTradeReportRefID = 881;
        public const int UnderlyingDirtyPrice = 882;
        public const int UnderlyingEndPrice = 883;
        public const int UnderlyingStartValue = 884;
        public const int UnderlyingCurrentValue = 885;
        public const int UnderlyingEndValue = 886;
        public const int NoUnderlyingStips = 887;
        public const int UnderlyingStipType = 888;
        public const int UnderlyingStipValue = 889;
        public const int MaturityNetMoney = 890;
        public const int MiscFeeBasis = 891;
        public const int TotNoAllocs = 892;
        public const int LastFragment = 893;
        public const int CollReqID = 894;
        public const int CollAsgnReason = 895;
        public const int CollInquiryQualifier = 896;
        public const int NoTrades = 897;
        public const int MarginRatio = 898;
        public const int MarginExcess = 899;
        public const int TotalNetValue = 900;
        public const int CashOutstanding = 901;
        public const int CollAsgnID = 902;
        public const int CollAsgnTransType = 903;
        public const int CollRespID = 904;
        public const int CollAsgnRespType = 905;
        public const int CollAsgnRejectReason = 906;
        public const int CollAsgnRefID = 907;
        public const int CollRptID = 908;
        public const int CollInquiryID = 909;
        public const int CollStatus = 910;
        public const int TotNumReports = 911;
        public const int LastRptRequested = 912;
        public const int AgreementDesc = 913;
        public const int AgreementID = 914;
        public const int AgreementDate = 915;
        public const int StartDate = 916;
        public const int EndDate = 917;
        public const int AgreementCurrency = 918;
        public const int DeliveryType = 919;
        public const int EndAccruedInterestAmt = 920;
        public const int StartCash = 921;
        public const int EndCash = 922;
        public const int UserRequestID = 923;
        public const int UserRequestType = 924;
        public const int NewPassword = 925;
        public const int UserStatus = 926;
        public const int UserStatusText = 927;
        public const int StatusValue = 928;
        public const int StatusText = 929;
        public const int RefCompID = 930;
        public const int RefSubID = 931;
        public const int NetworkResponseID = 932;
        public const int NetworkRequestID = 933;
        public const int LastNetworkResponseID = 934;
        public const int NetworkRequestType = 935;
        public const int NoCompIDs = 936;
        public const int NetworkStatusResponseType = 937;
        public const int NoCollInquiryQualifier = 938;
        public const int TrdRptStatus = 939;
        public const int AffirmStatus = 940;
        public const int UnderlyingStrikeCurrency = 941;
        public const int LegStrikeCurrency = 942;
        public const int TimeBracket = 943;
        public const int CollAction = 944;
        public const int CollInquiryStatus = 945;
        public const int CollInquiryResult = 946;
        public const int StrikeCurrency = 947;
        public const int NoNested3PartyIDs = 948;
        public const int Nested3PartyID = 949;
        public const int Nested3PartyIDSource = 950;
        public const int Nested3PartyRole = 951;
        public const int NoNested3PartySubIDs = 952;
        public const int Nested3PartySubID = 953;
        public const int Nested3PartySubIDType = 954;
        public const int LegContractSettlMonth = 955;
        public const int LegInterestAccrualDate = 956;
        public const int NoStrategyParameters = 957;
        public const int StrategyParameterName = 958;
        public const int StrategyParameterType = 959;
        public const int StrategyParameterValue = 960;
        public const int HostCrossID = 961;
        public const int SideTimeInForce = 962;
        public const int MDReportID = 963;
        public const int SecurityReportID = 964;
        public const int SecurityStatus = 965;
        public const int SettleOnOpenFlag = 966;
        public const int StrikeMultiplier = 967;
        public const int StrikeValue = 968;
        public const int MinPriceIncrement = 969;
        public const int PositionLimit = 970;
        public const int NTPositionLimit = 971;
        public const int UnderlyingAllocationPercent = 972;
        public const int UnderlyingCashAmount = 973;
        public const int UnderlyingCashType = 974;
        public const int UnderlyingSettlementType = 975;
        public const int QuantityDate = 976;
        public const int ContIntRptID = 977;
        public const int LateIndicator = 978;
        public const int InputSource = 979;
        public const int SecurityUpdateAction = 980;
        public const int NoExpiration = 981;
        public const int ExpType = 982;
        public const int ExpQty = 983;
        public const int NoUnderlyingAmounts = 984;
        public const int UnderlyingPayAmount = 985;
        public const int UnderlyingCollectAmount = 986;
        public const int UnderlyingSettlementDate = 987;
        public const int UnderlyingSettlementStatus = 988;
        public const int SecondaryIndividualAllocID = 989;
        public const int LegReportID = 990;
        public const int RndPx = 991;
        public const int IndividualAllocType = 992;
        public const int AllocCustomerCapacity = 993;
        public const int TierCode = 994;
        public const int UnitOfMeasure = 996;
        public const int TimeUnit = 997;
        public const int UnderlyingUnitOfMeasure = 998;
        public const int LegUnitOfMeasure = 999;
        public const int UnderlyingTimeUnit = 1000;
        public const int LegTimeUnit = 1001;
        public const int AllocMethod = 1002;
        public const int TradeID = 1003;
        public const int SideTradeReportID = 1005;
        public const int SideFillStationCd = 1006;
        public const int SideReasonCd = 1007;
        public const int SideTrdSubTyp = 1008;
        public const int SideQty = 1009;
        public const int MessageEventSource = 1011;
        public const int SideTrdRegTimestamp = 1012;
        public const int SideTrdRegTimestampType = 1013;
        public const int SideTrdRegTimestampSrc = 1014;
        public const int AsOfIndicator = 1015;
        public const int NoSideTrdRegTS = 1016;
        public const int LegOptionRatio = 1017;
        public const int NoInstrumentParties = 1018;
        public const int InstrumentPartyID = 1019;
        public const int TradeVolume = 1020;
        public const int MDBookType = 1021;
        public const int MDFeedType = 1022;
        public const int MDPriceLevel = 1023;
        public const int MDOriginType = 1024;
        public const int FirstPx = 1025;
        public const int MDEntrySpotRate = 1026;
        public const int MDEntryForwardPoints = 1027;
        public const int ManualOrderIndicator = 1028;
        public const int CustDirectedOrder = 1029;
        public const int ReceivedDeptID = 1030;
        public const int CustOrderHandlingInst = 1031;
        public const int OrderHandlingInstSource = 1032;
        public const int DeskType = 1033;
        public const int DeskTypeSource = 1034;
        public const int DeskOrderHandlingInst = 1035;
        public const int ExecAckStatus = 1036;
        public const int UnderlyingDeliveryAmount = 1037;
        public const int UnderlyingCapValue = 1038;
        public const int UnderlyingSettlMethod = 1039;
        public const int SecondaryTradeID = 1040;
        public const int FirmTradeID = 1041;
        public const int SecondaryFirmTradeID = 1042;
        public const int CollApplType = 1043;
        public const int UnderlyingAdjustedQuantity = 1044;
        public const int UnderlyingFXRate = 1045;
        public const int UnderlyingFXRateCalc = 1046;
        public const int AllocPositionEffect = 1047;
        public const int DealingCapacity = 1048;
        public const int InstrmtAssignmentMethod = 1049;
        public const int InstrumentPartyIDSource = 1050;
        public const int InstrumentPartyRole = 1051;
        public const int NoInstrumentPartySubIDs = 1052;
        public const int InstrumentPartySubID = 1053;
        public const int InstrumentPartySubIDType = 1054;
        public const int PositionCurrency = 1055;
        public const int CalculatedCcyLastQty = 1056;
        public const int AggressorIndicator = 1057;
        public const int NoUndlyInstrumentParties = 1058;
        public const int UndlyInstrumentPartyID = 1059;
        public const int UndlyInstrumentPartyIDSource = 1060;
        public const int UndlyInstrumentPartyRole = 1061;
        public const int NoUndlyInstrumentPartySubIDs = 1062;
        public const int UndlyInstrumentPartySubID = 1063;
        public const int UndlyInstrumentPartySubIDType = 1064;
        public const int BidSwapPoints = 1065;
        public const int OfferSwapPoints = 1066;
        public const int LegBidForwardPoints = 1067;
        public const int LegOfferForwardPoints = 1068;
        public const int SwapPoints = 1069;
        public const int MDQuoteType = 1070;
        public const int LastSwapPoints = 1071;
        public const int SideGrossTradeAmt = 1072;
        public const int LegLastForwardPoints = 1073;
        public const int LegCalculatedCcyLastQty = 1074;
        public const int LegGrossTradeAmt = 1075;
        public const int MaturityTime = 1079;
        public const int RefOrderID = 1080;
        public const int RefOrderIDSource = 1081;
        public const int SecondaryDisplayQty = 1082;
        public const int DisplayWhen = 1083;
        public const int DisplayMethod = 1084;
        public const int DisplayLowQty = 1085;
        public const int DisplayHighQty = 1086;
        public const int DisplayMinIncr = 1087;
        public const int RefreshQty = 1088;
        public const int MatchIncrement = 1089;
        public const int MaxPriceLevels = 1090;
        public const int PreTradeAnonymity = 1091;
        public const int PriceProtectionScope = 1092;
        public const int LotType = 1093;
        public const int PegPriceType = 1094;
        public const int PeggedRefPrice = 1095;
        public const int PegSecurityIDSource = 1096;
        public const int PegSecurityID = 1097;
        public const int PegSymbol = 1098;
        public const int PegSecurityDesc = 1099;
        public const int TriggerType = 1100;
        public const int TriggerAction = 1101;
        public const int TriggerPrice = 1102;
        public const int TriggerSymbol = 1103;
        public const int TriggerSecurityID = 1104;
        public const int TriggerSecurityIDSource = 1105;
        public const int TriggerSecurityDesc = 1106;
        public const int TriggerPriceType = 1107;
        public const int TriggerPriceTypeScope = 1108;
        public const int TriggerPriceDirection = 1109;
        public const int TriggerNewPrice = 1110;
        public const int TriggerOrderType = 1111;
        public const int TriggerNewQty = 1112;
        public const int TriggerTradingSessionID = 1113;
        public const int TriggerTradingSessionSubID = 1114;
        public const int OrderCategory = 1115;
        public const int NoRootPartyIDs = 1116;
        public const int RootPartyID = 1117;
        public const int RootPartyIDSource = 1118;
        public const int RootPartyRole = 1119;
        public const int NoRootPartySubIDs = 1120;
        public const int RootPartySubID = 1121;
        public const int RootPartySubIDType = 1122;
        public const int TradeHandlingInstr = 1123;
        public const int OrigTradeHandlingInstr = 1124;
        public const int OrigTradeDate = 1125;
        public const int OrigTradeID = 1126;
        public const int OrigSecondaryTradeID = 1127;
        public const int ApplVerID = 1128;
        public const int CstmApplVerID = 1129;
        public const int RefApplVerID = 1130;
        public const int RefCstmApplVerID = 1131;
        public const int TZTransactTime = 1132;
        public const int ExDestinationIDSource = 1133;
        public const int ReportedPxDiff = 1134;
        public const int RptSys = 1135;
        public const int AllocClearingFeeIndicator = 1136;
        public const int DefaultApplVerID = 1137;
        public const int DisplayQty = 1138;
        public const int ExchangeSpecialInstructions = 1139;
    }
}
