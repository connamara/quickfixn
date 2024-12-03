QuickFIX/n Release Notes
========================

Welcome to QuickFIX/n
---------------------
QuickFIX/n is a .NET port of QuickFIX, an open source C++ FIX engine.

What's New
----------

**CAUTION:**  
* **1.13.0 has moved to .NET 8 (as Microsoft is ending .NET 6 support on Nov 12, 2024)
* **There are breaking changes between 1.12 and 1.13!  Please review the 1.12.0 notes below.**
* **There are breaking changes between 1.11 and 1.12!  Please review the 1.12.0 notes below.**
* **There are breaking changes between 1.10 and 1.11!  Please review the 1.11.0 notes below.**


### upcoming v1.13.0

**Breaking changes**
* #883 - Moved to .NET 8 (huypn12)
* #878 - corrections to tag 45 "Side" in various DDs (gbirchmeier) - most people won't notice, easy fix if they do
     * fix typo in FIX50 and FIX50SP1: `CROSS_SHORT_EXXMPT` fixed to `CROSS_SHORT_EXEMPT`
     * correction in FIX41 and FIX42: `D` to `UNDISCLOSED`
* #863 - Change Message.ToString() to not alter object state anymore. (gbirchmeier)
         Use new function Message.ConstructString() if you need BodyLength/CheckSum to be updated.
* #887 - cleanup/nullable-ize FixValues, Session, DataDictionary, DataDictionaryProvider, Message, MessageCracker,
         SocketSettings, SslStreamFactory (gbirchmeier)
     * DataDictionary.CheckIsInGroup is now static
     * Get rid of non-static DataDictionary.Validate functions

**Non-breaking changes**
* #864 - when multiple threads race to init DefaultMessageFactory,
         fix it so that later threads do not return before the first thread
         finishes loading all the dlls (gbirchmeier, with thanks to diagnosis by Brian Leach aka baffled)
         (Note: this may be the cause of spurious "incorrect BeginString" issues that have been observed)
* #877 - throw an exception if Message.ToJSON(dd=null,convertEnumsToDescriptions=true) is called (gbirchmeier)
* #888 - cleanup/nullable-ize IField-derived classes (gbirchmeier)
     * deprecate lower-case-starting function names (renamed to upper-case-starting)
     * deprecate <Foo>Field.Obj (renamed to Value)
     * deprecate <Foo>Field.getValue/setValue (just use Value getter/setter)
* #889 - nullable-ize Examples and fix deprecations (gbirchmeier)
* #892 - nullable-ize UnitTests project (gbirchmeier)
     * also deprecate a AcceptorSocketDescriptor ctor due to unused param
* #900 - correct CompositeLog to use IFactory.CreateNonSessionLog when appropriate (gbirchmeier)
* #891 - make NonSessionLog implement IDisposable and fix the IOException (VAllens)

### v1.12.0

**Breaking changes**
* #768 - span-ify parser (Rob-Hague) - makes a change to QuickFix.Parser interface, which isn't likely to affect users
* #820 - cleanup/nullable-ize initiator/acceptor files (gbirchmeier) -
         changed some Session Generate* functions to return void instead of null, 
         very low likelihood that any user code will be affected.
* #821 - delete dead code: ByteSizeString class & test, do-nothing ConfigTest (gbirchmeier) -
         ByteSizeString is public, but probably no one uses it
* #822 - cleanup/nullable-ize Message/ classes (gbirchmeier)
     * FieldMap: getFieldOrder() deleted.  Just call FieldOrder.
     * FieldMap: GetGroup(int num, Group group) now returns void instead of redundant Group
     * Group: rename Field to CounterField
     * Message: changed `SOH`'s type from string to char
     * Message: ctor Message(string msgstr, DataDictionary.DataDictionary dataDictionary, bool validate) deleted.
       You can use the 2-DD version, though for FIX4 those DDs will be the same.
     * Message: ExtractField()'s 2 DD params removed.  They were never used.
     * Message: static GetFieldOrDefault() changed to private.  Unlikely anyone will notice.
     * Message: static GetReverseSessionID(Message) changed to private.  Unlikely anyone will notice.
       (The version with the string param is still public)
     * Message: FromStringHeader renamed and made private.  Unlikely anyone will notice.
     * Message: ToXML() and ToJSON() require DD params for any tag/enum translation.
       (Message no longer stores a DD instance var.)
       These functions are new, probably not widely used yet.
       Function docs are now clear on this behavior.
* #826 - cleanup/nullable-ize Socket & Session classes (gbirchmeier)
     * ClientHandlerThread is now internal.  Unlikely anyone will notice.
     * SocketReader: delete public ctor.  Probably no one is using it.
     * Session: rename (capitalize) TargetDefaultApplVerId property
     * SessionState: ctor now requires a MessageStore.  (Existing callers used an object initializer anyway)
     * Many protected functions were altered, but probably no user code is touching them
* #827 - cleanup/nullable-ize StreamFactory, SessionID, Settings, SessionSettings, SessionSchedule (gbirchmeier)
     * StreamFactory: privatized a lot of members; I don't think users are inheriting from this
     * SessionSchedule: remove unused LastEndTime()
* #831 - cleanup/nullable-ize Logging/Store classes, fix path-separator bug (gbirchmeier)
     * Move all logger classes to new QuickFix.Logger namespace
     * Move all store classes to new QuickFix.Store namespace
     * FileLog: remove the single-param ctor, no reason for anyone to use it
     * ScreenLog ctor: removed unused sessionId param
     * ScreenLogFactory: remove unused public vars
* #708 - In FIX50, rename field SecurityStat to SecurityStatus, to match SP1 and SP2 (gbirchmeier)
* #639 - address Dictionary ctor bug, then cleanup/nullable-ize (gbirchmeier)
     * rename to SettingsDictionary to reduce name confusion with System.Collections.Generic.Dictionary
     * privatize a ctor that takes a generic Dict; apps shouldn't use it
     * remove the copy ctor that takes only a SessionDict; replace it with one
       that explicitly requires a name also
* #842 - Fix nano-datetime-to-string bug (gbirchmeier)
     * Also refactor the heck out of DateTimeConverter & tests: many functions renamed/deprecated
* #847 - remove setting MillisecondsInTimeStamp (gbirchmeier)
     * Use TimestampPrecision instead (same as QF/j)
* #830 - replace ClientThreadHandler "Debug" logs with NonSessionLog (gbirchmeier)
     * ILogFactory extended with a `CreateNonSessionLog()`.  Pretty easy to implement though.
     * Some classes were internalized, but I can't imagine people are using them in their app code.
     * See details/explanation at https://github.com/connamara/quickfixn/pull/830

**Non-breaking changes**
* #400 - added DDTool, a C#-based codegen, and deleted Ruby-based generator (gbirchmeier)
* #811 - convert AT platform to be NUnit-based, get rid of Ruby runner (Rob-Hague)
* #813 - fix incorrect logging of acceptor heartbeat (gbirchmeier)
* #815 - update broken/neglected example apps & docs (gbirchmeier)
* #764 - fix positive UTC offset parsing in DateTimeConverter (Rob-Hague)
* #766 - use ordinal string operations (Rob-Hague)
* #767 - avoid string conversions in FieldMap.Get{FieldType} where possible (Rob-Hague)
* #785 - use correct SocketError "Shutdown" code when socket is deliberately shutdown (oclancy)
* #711 - fix explicit 0.0.0.0 address binding (bohdanstefaniuk)
* #823 - get rid of IOIQty enums in FIX5 DDs, allow free string (gbirchmeier)
* #786 - rewrite HttpServer: better HTML, no crash on errors (gbirchmeier)
* #697 - new SocketIgnoreProxy setting (ABSJ415)
* #740 - Capture inner exception messages when handling authentication exceptions (rars)
* #833 - Add Try/Catch logic to SocketInitiator.OnStart() (Falcz)
* #782 - proper handling of XmlData field (larsope)
* #770 - fix unobserved SocketException
    * Perform socket read operations according to Task-based asynchronous pattern (TAP) instead of Asynchronous
      Programming Model (APM), in order to catch unobserved SocketExceptions (nmandzyk)
    * Cleanup/nullable-ize SocketInitiatorThread (gbirchmeier)
* #839 - change ScreenLog to output FIX messages with "|" instead of non-visible SOH (gbirchmeier)
* #844 - implement "Weekdays" setting (MichalUssuri/gbirchmeier)
* #859 - implement proper path searching for CA certs in config (gbirchmeier)

### v1.11.2:
* same as v1.11.1, but I fixed the readme in the pushed nuget packages

### v1.11.1:
* #793 - Continuous Markets bugfix: make DD treat SEQNUM as ULong, not Int (gbirchmeier)
* #790/#787 - break up monolithic release script, add symbols & DD to nugets/zip, delete old scripts (gbirchmeier)

### v1.11.0:
This build removes deprecations, and also updates to .NET 6.0.  
We decided this wasn't big enough to warrant a v2 release, even though
it technically violates semantic versioning.

**Breaking changes in release** 
* #732 - generate FIXT11 msg classes so they can be cracked (mgatny) IMPORTANT: FIX5+ applications now need the new FIXT11 dll!
* #748 - Update all csproj files to net6.0, fix .NET deprecations, update pwsh scripts, remove some non-pwsh scripts (gbirchmeier)
* #749 - All deprecations are removed (gbirchmeier)
* #746 - remove some unused public `FIXnn_LAST_FIELD` constants; corrected FIX44 DD `UNKOWN_ID` typo (gbirchmeier)
* #756 - privatize DDField property setters,
         change various Get/SetNextSenderMsgSeqNum & Get/SetNextTargetMsgSeqNum functions to properties (gbirchmeier)
* #760 - change seqnums to UInt64 to support Continuous Markets (mgatny)  
         (ATTENTION! Note the INT->SEQNUM changes in FIX40/41/42.xml DDs!  You may need to update your DDs!)

**Non-breaking changes**
* (minor) #745 - JSON-to-FIX (mgatny)
* (minor) #724 - FIX-to-JSON serialization, and a ToXML() bugfix (mgatny)
* (patch) #647 - replace lock with memory barrier to avoid deadlocks (brunobelmondo)
* (patch) #623 - fix issues with New-Release.ps1 (fourpastmidnight)
* (patch) #727/#728 - improve dictionary parsing speed (sylr)
* (minor) #724 - Add methods for serializing to FIX JSON Encoding (mgatny)
* (patch) #630 - Make DefaultMessageFactory reflect only over QF/n assemblies (gbirchmeier)
* (patch) #643 - add 1156 (ApplExtId) to FIXT11.xml (gbirchmeier)
* (patch) #642 - allow decimal fields to have exponential notation (rakker91)
* (patch) #663/#657 - fix call to Directory.GetFiles for case-sensitive filesystems (johna1203/jatrofka)
* (patch) #626 - Dynamic SocketAcceptPort bugfix (akamyshanov)
* (patch) #662 - fix NullRefEx in AbstractInitiator.IsLoggedOn (gbirchmeier, thanks to akpwhg)
* (patch) #542 - log before crash when port is not available (rodrigopscampos)

### v1.10.0:
* (patch) #505 - Fix ObjectDisposedException when SocketInitiator is stopped before connection attempt fails (musashibg)
* (patch) #571 - StreamFactory fix: unexpected null from GetProxy (mkoca & mcmillab)
* (patch) #547 - Implement Refresh() method in FileStore (roederja2)
* (minor) #570 - change Parser.AddToStream() interface to not use 'ref' (roederja2)
* (patch) #526 - Do not ignore MsgSeqNum on ResendRequest when no persistence (ledusskapis)
* (patch) #430 - Support config AllowUnknownMsgFields (peto268/gbirchmeier)
* (patch) #349 - Improvement to repeating-group error detection when delimiter is missing (gbirchmeier)
* (minor) #561 - Fix nanosecond config throw (dckorben)
* (minor) #512 - Support config SocketSendTimeout/SocketReceiveTimeout to prevent SSL socket timeouts (allysutherland)
* (patch) #383/#582 - Fix debug logfile name clash (chizz5056/gbirchmeier)
* (patch) #410/#583 - SocketAcceptPort now fully-obeyed (mvdtom)
* (minor) #585/#323 - Add Message.ToXML() (baffles/gbirchmeier)
* (patch) #591 - Nanosecond DateTime reader bugfix (gbirchmeier)
* (patch) #592/#601 - better detection of malformed DD elements (gbirchmeier/roederja2)
* (patch) #606 - fix IDisposable implementations to follow MS general pattern (pavka1799)
* (patch) #566 - SSLValidateCertificates=N overrides SSLCheckCertificateRevocation (gbirchmeier, h/t to Mad-Lynx)
* (patch) #405 - CheckFieldsHaveValues needs to work for non-strings too (gbirchmeier)
* (minor) #596 - Support HeartBtInt=0 (gbirchmeier)
* (minor) #136 - add static TAG property to each field (gbirchmeier)
* (patch) #564 - NuGet package creation! (fourpastmidnight)
* (patch) #612 - add Serilog standalone example (pavka1799)
* (patch) #602 - Correct DD.CheckValue() to be compatible with AllowUnknownMessageFields (roblugt/gbirchmeier)
* (patch) none - use SslProtocol.None instead of deprecated .Default (gbirchmeier)

### v1.9.0:
* (minor) #469 - Add support for NET Standard 2.0 (jhickson)
* (minor) #476 - Separate FIX message assemblies from the main project (akamyshanov)
* (minor) #482 - x64 support (brobits)
* (patch) #486 - More informative exception for DD parsing errors (gbirchmeier)
* (patch) #492 - fix delete-generated script (gbirchmeier)
* (patch) #493 - fix DD parsing issue with certain comments (gbirchmeier)
* (minor) #448 - Fix message load error within \*nix environments (mtnbiker99)
* (minor) #497 - Support full cross-platform operation (michaelwilner)
* (patch) #498 - Fix hanging on ThreadedSocketReactor exit (michaelwilner)
* (minor) #489 - fixes for DefaultMessageFactory / FIX50sp1/2 (gbirchmeier)
* (patch) #499 - fix bug in SessionState MessageQueue (vigzel)
* (minor) #507 - better feedback for "Incorrect BeginString" errors (gbirchmeier)
* (minor) #521 - fix misspelled session reject reason (vpfau)
* (minor) #524 - add tunnel support; expand cert store search to include LocalMachine (nileshwagel/gbirchmeier)
* (minor) #531 - change encoding to iso-8859-1 (aka latin1) (amibar/gbirchmeier)
* (patch) #532 - bug in #524: don't attempt non-.NET-Core-supported functionality (gbirchmeier)
* (patch) #533 - file maintenance (gbirchmeier)
* (patch) #509 - Consistent sessionID argument name in IApplication (eugbaranov)
* (patch) #296 - make FieldMap.GetField obsolete; favor .GetString instead (staffanu)
* (patch) #478 - eliminate unnecessary string/byte flip-flop (gbirchmeier)
* (patch) #473 - correct ordering of fields in message trailer (Ieshaj/gbirchmeier)
* (patch) #513 - Allow groups where the first entry is a group (twoi/gbirchmeier)
* (minor) #549 - SessionFactory.Create creates a more-appropriate DefaultMessageFactory; also add NullLogFactory (gbirchmeier)

### v1.8.0:
* (patch) #402 - Multithreading fix to please NUnit 2.6.3 and above (arkadiuszwojcik)
* (patch) #406 - Remove xslt (brobits)
* (patch) #417 - Bring unit tests up-to-date with NUnit v3.4.1 (zherr)
* (minor) #418 - Target .NET 4.5 (zherr)
* (minor) #419 - Atrun dep removal (zherr)
* (minor) #421 - added class for web interface (mohit-kumar-3pillar)
* (minor) #425 - Updating DateTimeConverter to be able to convert between microseconds (huwmongoose)
* (patch) #428 - lock down nokogiri version (cbusbey)
* (minor) #444 - generator doc update + deletion script (gbirchmeier)
* (patch) #445 - remove wonky whitespace from generated message classes (gbirchmeier)
* (minor) #459 - Nanosecond support for QuickFIX timestamp fields (brobits)
* (patch) #463 - adds fix50sp1-sp2 to FixMessages proj, fixes generator bug (cbusbey)

### v1.7.0: 
* (patch) #276 - SSL Fixes (akamyshanov)
* (minor) #292 - Allow To Set Several Fields At The Same Time (tix52)
* (minor) #294 - Added SocketSendBufferSize and SocketReceiveBufferSize settings (staffanu)
* (patch) #295 - Use only ipv4 addresses returned by Dns.GetHostAddresses (staffanu)
* (minor) #334 - Implement NonStopSession, for compatibility with quickfixj (staffanu)
* (patch) #340 - TreadedSocketAcceptor does not dispose underlying sessions on stop bug (akamyshanov)
* (minor) #356 - implement optional session setting ValidateLengthAndChecksum (dafanasiev)
* (patch) #358 - BeginString not being transformed into the correct file name when no DataDictionary session setting is present. (Cooker1977)
* (patch) #365 - fixes for dynamic session functionality (martinadams)
* (patch) #380 - Website docs and cleanup (cbusbey)

###v1.6.0:
* (patch) #362 - expanded CI to code genertion and acceptance tests (aswaney)
* (minor) #247 - support for CheckLatency/MaxLatency config settings (ruaanviljoen)
* (patch) #256 - bug in 247, defaults override config (akamyshanov)
* (patch) #258 - threadsafe SessionState.Get/Set to fix garbled message issue (jacsuper)
* (patch) #251 - restore the session type check in AbstractInitiator.Start (oract)
* (patch) #255 - release ClientHandlerThread resources on client disconnect (mgatny)
* (patch) #266 - Session not explicitly handling DoNotSend from Application::ToApp (cbusbey)
* (patch) #267 - Resent Messages not being relayed to Application::ToApp (cbusbey)
* (minor) #286 - FieldBase.Equals() and .GetHashcode() (steffanu)
* (patch) #287 - sync fix in Session class (steffanu)
* (patch) #275 - SessionID.IsSet() should be used instead of !=SessionID.NOT_SET (akamyshanov)
* (patch) #297 - revert #287
* (patch) #290 - support for RefreshOnLogon (martinadams)
* (patch) #80  - fixes to tag-141-related sequence resets (TomasVetrovsky,akamyshanov,gbirchmeier)
* (patch) #315 - make config file section headers be case-insensitive, for parity with QF/j (gbirchmeier)
* (minor) #314 - New feature: add/remove sessions dynamically (martinadams)
* (patch) #273 - prevent non-logon message traffic unless fully logged on (martinadams)
* (patch) #278 - fix for mis-sequenced gap fills in re-requested messages (martinadams)
* (patch) #283 - fix to ensure IApplication.FromAdmin() gets called for received resend requests (martinadams)
* (minor) #312 - New config option: can force session-level rejects to be resent (martinadams)
* (minor) #270/#146 - Correct rejection behavior when msg groups do not use correct delimiter tag (gbirchmeier)
* (patch) #280 - fix to prevent StackOverflowException due to recursion (martinadams)
* (patch) #364 - remove accidental introduction of .NET 4.0 features (gbirchmeier)

**NOTE: Breaking changes in release**  
This version has changes that technically alter the public interface.
Most likely no one is affected.  But just in case, here are the details:

* **class `OtherTagException` was deleted.**  The class `GroupDelimiterTagException` used to
  be descended from this class, but now descends directly from `TagException`.
* **method `Session.Next(Message message)` was deleted.**  This should never have been public.
  If you were using it and this is a problem for you, please contact us
  via our [Contact Page](http://quickfixn.org/about/contact) and we'll see if we can help.

###v1.5.0:
* (patch) pr #181 - add null checks to SessionID constructor (roji)
* (minor) issue #48 - IInitiator.Stop() must release resources (jungers42/gbirchmeier)
* (patch) issue #160 - floats without leading zeros (e.g. ".23") now parsed properly (gbirchmeier)
* (patch) issue #187 - make IInitiator implement IDisposable (gbirchmeier)
* (minor) pr #178 - can now load DD from a stream instead of a file (robsonj)
* (patch) issue #183 - Session.Reset should only logout if already logged in (ligu)
* (patch) issue #40 - remove redundant/misplaced body length check in parser (gbirchmeier)
* (minor) pr #180 - new CompositeLogFactory (roji)
* (patch) issue #179 - bug in parsing groups when message factory is null (klmcwhirter/TomasVetrovsky/gbirchmeier)
* (minor) issue #102 - allow SequenceReset/PossDup messages to omit tag 122 (thomasfleming/gbirchmeier)
* (patch) issue #153 - Chunked resends are now sent "on-demand" instead of all-at-once (roji)
* (patch) issue #173 - bug in Message.IsAdmin/IsApp (TomasVetrovsky/gbirchmeier)
* (patch) issue #166 - FIX44 spec missing PutOrCall and UnderlyingPutOrCall (gbirchmeier)
* (patch) corrections/updates to FIX44 spec based on diff with QF/j version (gbirchmeier)
* (minor) issue #66 - correct validation of multiple-value-string fields (harvinder)
* (patch) pr #125 - MessageCracker optimization (unclepaul84)
* (minor) pr #220/#235 - IIinitiator/IAcceptor.IsLoggedOn method changed to property (vbfox/gbirchmeier)
* (patch) issue #95 - deep-level repeating groups getting mangled in resend-requests (aelgasser)
* (patch) issue #204 - concurrency issue in Message.ToString (gbirchmeier)
* (patch) issue #175 - correct some date fields to be generated/validated as DateOnlyField types (gbirchmeier)
* (patch) pr #225 - fix for FileStore seqnum file corruption risk (roken)
* (minor) issue #18 - native SSL support (Daniel-Svensson)

###v1.4.0:
* (minor) issue #101 - better exception for when group doesn't use proper delimiter (gbirchmeier)
* (minor) issue #28 - rename interfaces to start with "I" (gbirchmeier)
* (patch) issue #128 - simplify/improve TradeClient example app (gbirchmeier)
* (minor) issue #135 - fix DateOnly/TimeOnly field support (formator)
* (patch) issue #134 - if DD field/group/component is missing "required" attribute, treat it as "required=N" (gbirchmeier)
* (patch) issue #114 - enum dupe-check script; corrections to FIX43 tag 574/MatchType (gbirchmeier)
* (patch) scripts and fixes for experimental Mono support (mgatny)
* (minor) issue #97 - tolerance for non-ASCII (e.g. UTF-8) characters (andbjorn/gbirchmeier)
* (patch) issues #139/#144/#151 - session schedule problems (gbirchmeier/formator)

###v1.3.0:
* (patch) issue #82 - add stacktraces to certain disconnect logging messages (gbirchmeier)
* (minor) issue #56 - make engine create concrete group types instead of generic Group objects (gbirchmeier)
* (minor) issues #60/#87 - add config settings for UseLocalTime and TimeZone (martsyn)
* (patch) issue #73 - conflicting directory lettercase with MessageFactory classes (gbirchmeier)
* (patch) issue #43 - Change occurrences of "QuickFIX.NET" to "QuickFIXn" (dir name, sln name, scripts) (gbirchmeier)
* (patch) issue #58 - convert sln to vs2010 (gbirchmeier)
* (patch) issue #90 - Dictionary.Get/SetDouble was not using invariant culture (formator/gbirchmeier)
* (minor) pr #108/#117 - add DD class support for enum descriptions (formator/gbirchmeier)
* (patch) pr #111/#120 - settings file can have = signs in value (ligu/gbirchmeier)
* (minor) issue #91 - support for custom message factories (formator)
* (minor) pr #113/#122 - config setting DebugLogFilePath (ligu/gbirchmeier)
* (minor) pr #110 - session reset logged to eventlog (ligu)
* (patch) issue #93 - bugfix: change 'h' to 'n' in Message.IsAdminMsgType (gbirchmeier)
* (patch) issue #98 - bugfix: required fields inside components are erroneously causing the component to be treated as required (gbirchmeier)
* (minor) issue #22 - bugfix: seq nums not being reset when restarting application after session StartTime (ligu)
* (patch) issue #49 - close config file after reading (gbirchmeier)

###v1.2.0:
* (minor) Extended Session.cs to enable setting of NextTargetSequenceNum and NextSenderSequenceNum. (chrisbarker)
* (minor) Extended Session.cs to implement static method DoesSessionExist(SessionID sessionID) as per QuickFIX. (chrisbarker)
* (patch) Fixed issue #21 - DecimalConverter is now culture-insensitive (harvinder)
* (minor) Fixed issue #22 - Sequence numbers not being reset (kkozel)
* (patch) Repeating groups always write to default DD order. (gbirchmeier)
* (minor) Fixed issue #16 - added GetSessionID methods to IAcceptor and IInitiator (gbirchmeier)
* (patch) Fixed issue #35 - Proper BeginString for FIX5 messages (gbirchmeier)
* (patch) Fixed issue #36 - update version number in release script (gbirchmeier)
* (patch) Fixed issue #11 reopen - nested group's counter erroneously appearing twice (gbirchmeier)
* (patch) Fixed issue #39 - "length" types generated as ints, was wrongly being generated as decimal (g0t4)
* (patch) Fixed issue #44 - LogonTimedOut (mgatny)
* (patch) Fixed issue #42 - Environment.TickCount bug (mjwood7)
* (patch) Fixed issue #59 - Bug in determining whether we're inside a weeklong session (cbusbey)
* (patch) Fixed issue #57 - Heartbeat not sent during constant traffic (cbusbey)
* (patch) Fixed issue #47 - Missing values in PartyRole enum (gbirchmeier)
* (minor) Fixed issue #37 - Deprecate DDField.Required, because it makes no sense (zakev/gbirchmeier)

###v1.1.0:
* (patch) fix for #13 - CURRENCY-type fields should be strings, not decimals
* (patch) fix for  #9 - fix broken Message.GetMsgType()
* (patch) fix for #10 - repeating group serialization now puts delimiter first
* (minor) fix for  #5 - field-type checks for repeating groups, support for TimeOnly/DateOnly fields

###v1.0.0 First release and announcement
###v0.9.1 Confirmation of release of QuickFIX/n
###v0.9.0 First pre-release of QuickFIX/n
