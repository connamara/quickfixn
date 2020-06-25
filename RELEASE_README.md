QuickFIX/n
==========
Thank you for using QuickFIX/n!  
Here's an overview of what's in this zip package.

Introduction
------------
QuickFIX/n implements the FIX protocol on .NET.
For more information, visit [http://www.quickfixn.org] (http://www.quickfixn.org)

File and Directory Information
------------------------------
* RELEASE_NOTES.md - release notes
* README.md - this file
* LICENSE - license information
* bin - Contains the QuickFix.dll and message libraries for different target platforms
* config - Contains sample config files for an acceptor or initiator
* spec - Contains the various FIX data dictionaries

Getting Started
---------------
The directory bin/netstandard2.0 contains
* the QF/n core, QuickFix.dll
* a message-definition dll for each FIX version (e.g. QuickFix.FIX40.dll, QuickFix.FIX41.dll, ...)

**Everyone needs QuickFix.dll**, so copy that into your project and reference it.

Now you'll also need a message-definition dll.  Most users will only need one.  
(In rare cases it's possible to have an app that makes multiple connections
to different counterparties using different versions.
If that's you, chances are you already know what you're doing.)

So copy your selected message-definition dll into your project and reference it.

Then read the [documentation](http://quickfixn.org/tutorial/creating-an-application) and get coding!

