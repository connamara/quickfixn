Changes Slated for the Next Version
===================================

This is a running list of changes for the changelog of the next version.

Upon the next release, the items below will be copied to the release notes.

For each change, please indicate the issue number (if any), and how the
change should affect the version level (e.g. patch/minor/major).

(For Semantic Versioning number rules, see http://semver.org)

Don't forget to note the contributor's name or git handle
and add their name to web/views/about/credits.md


Changes since the last version (oldest first):
----------------------------------------------
* (major/minor/patch) desc of fixed issue (contributor)

* (minor) #247 - support for CheckLatency/MaxLatency config settings (ruaanviljoen)
* (patch) #256 - bug in 247, defaults override config (akamyshanov)
* (patch) #258 - threadsafe SessionState.Get/Set to fix garbled message issue (jacsuper)
* (patch) #251 - restore the session type check in AbstractInitiator.Start (oract)
* (patch) #266 - Session not explicitly handling DoNotSend from Application::ToApp (cbusbey)
* (patch) #267 - Resent Messages not being relayed to Application::ToApp (cbusbey)
* (minor) #286 - FieldBase.Equals() and .GetHashcode() (steffanu)
* (patch) #287 - sync fix in Session class (steffanu)
* (patch) #275 - SessionID.IsSet() should be used instead of !=SessionID.NOT_SET (akamyshanov)
* (patch) #297 - revert #287
* (patch) #290 - support for RefreshOnLogon (martinadams)


