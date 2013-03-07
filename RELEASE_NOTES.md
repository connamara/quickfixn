QuickFIX/n Release Notes
========================

Welcome to QuickFIX/n
---------------------
QuickFIX/n is a .NET port of QuickFIX, an open source C++ FIX engine.

What's New
----------

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
