Changes Slated for the Next Version
===================================

This is a running list of changes for the changelog of the next version.

Upon the next release, the items below will be copied to the release notes.

For each change, please indicate the issue number (if any), and how the
change should affect the version level (e.g. patch/minor/major).

(For Semantic Versioning number rules, see http://semver.org)

Don't forget to note the contributor's name or git handle!


Changes since the last version:
-------------------------------
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
