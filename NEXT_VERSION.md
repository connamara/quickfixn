Changes Slated for the Next Version
===================================

This is a running list of changes for the changelog of the next version.

Upon the next release, the items below will be copied to the release notes.

For each change, please indicate the issue number (if any), and how the
change should affect the version level (e.g. patch/minor/major):

* **Patch version Z (x.y.Z)** MUST be incremented if only backwards compatible bug fixes are introduced. A bug fix is defined as an internal change that fixes incorrect behavior.
* **Minor version Y (x.Y.z)** MUST be incremented if new, backwards compatible functionality is introduced to the public API. It MUST be incremented if any public API functionality is marked as deprecated. It MAY be incremented if substantial new functionality or improvements are introduced within the private code. It MAY include patch level changes. Patch version MUST be reset to 0 when minor version is incremented.
* **Major version X (X.y.z)** MUST be incremented if any backwards incompatible changes are introduced to the public API. It MAY include minor and patch level changes. Patch and minor version MUST be reset to 0 when major version is incremented.

Don't forget to note the contributor's name or git handle!


Changes since the last version:
-------------------------------
* (minor) Extended Session.cs to enable setting of NextTargetSequenceNum and NextSenderSequenceNum. (chrisbarker)
* (minor) Extended Session.cs to implement static method DoesSessionExist(SessionID sessionID) as per QuickFIX. (chrisbarker)

