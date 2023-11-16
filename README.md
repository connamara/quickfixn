[![QuickFIX/N][1]](http://quickfixn.org)

[![Build status](https://ci.appveyor.com/api/projects/status/ccu2yp2coad3oam0?svg=true)](https://ci.appveyor.com/project/cbusbey/quickfixn-jib50)

For tutorials on how to use QuickFIX/n, visit the [website](http://quickfixn.org/tutorial/creating-an-application.html).

This README is about setting up your system to do QuickFIX/n
development.

System Setup
------------

* This project uses .NET 6.

* All scripts are in Powershell, and should work on both Windows and Unix-based platforms.

* Ruby is needed for acceptance tests *only*. (We are working to eliminate this dependency.)


Code Generation
---------------
DDTool is a C#-based tool for analyzing DataDictionary files and
regenerating the source for message and field classes.

Check out the DDTool directory to learn more, or you can just run this script:

```
pwsh scripts\Generate-Message-Sources.ps1
```


Build and Unit Test
--------------
It is assumed that developers know how to use `dotnet` cli tools
or their IDE of choice.

The simplest spin-up instructions are:
* `dotnet build` - to build
* `dotnet test` - to run unit tests (which use NUnit)


Acceptance Tests
----------------
To run the full suite of acceptance tests:

```
pwsh .\scripts\AcceptanceTest.ps1
```

An HTML report of the test results will then be available here:

    AcceptanceTests\AcceptanceTests.html

To run one particular acceptance test, e.g. fix42\14e_IncorrectEnumValue.def:

```
cd AcceptanceTest
pwsh runat.ps1 release 5003 definitions\server\fix42\14e_IncorrectEnumValue.def cfg\at_42.cfg net6.0
```

The final param *must* be "net6.0".

(See `scripts\Acceptance-Test.ps1` for the proper port numbers and config files to use in the above command.)

The test results will then be available in AcceptanceTests\TestResults.xml and
debug information will be available in the AcceptanceTests\log directory.

To run a test with the debugger,

  1. Open the solution file in Visual Studio
  2. Right click on "AcceptanceTest" project and choose "Properties" from the menu
  3. Click "Debug" on the left hand nav bar
  4. Set "Command line arguments" to the relevant "cfg\at_XX.cfg" for your test
  5. Set the working directory to "[yourpath]\quickfixn\AcceptanceTest"
  6. Save the properties
  7. Right click the "AcceptanceTest" project, go to Debug -> Start New Instance
  8. In command terminal, go into "AcceptanceTest" directory
  9. Run: `ruby Runner.rb 127.0.0.1 5001 definitions\server\fix42\YourTestName.def`

Credits
-------

![Connamara Systems](http://quickfixn.org/web/public/images/Connamara-Logo.png)

QuickFIXn is maintained and funded by [Connamara](http://connamara.com).

The names and logos for Connamara are trademarks of Connamara Systems, LLC.

Licensing
---------

This software is available under the QuickFIX Software License. Please see the [LICENSE](LICENSE) for the terms specified by the QuickFIX Software License.

[1]: http://quickfixn.org/web/public/images/qfn-logo/QuickFIX-n_logo-small.png
