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
* (major/minor/patch) desc of fixed issue (contributor)

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

