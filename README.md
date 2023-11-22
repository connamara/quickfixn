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

XML reports of the test results will then be available here:

    AcceptanceTest\AcceptanceTests_*.xml

To run a subset of the acceptance tests, run the AcceptanceTest .NET project with the desired arguments:

`<test_definitions> <config_filepath> <use_wsl>(true|false)`

For example,

```
cd AcceptanceTest

dotnet run -c Release -f net6.0 -- definitions/server/fix40/*.def cfg/at_40.cfg true

# or
bin/Release/net6.0/AcceptanceTest.exe definitions/server/fix42\14e_IncorrectEnumValue.def cfg/at_42.cfg true

# or run from Visual Studio with the arguments specified by the launch profile ("Debug" menu bar item then "AcceptanceTest Debug Properties")
```

The third option allows the tests to debugged.

The test results will then be available in AcceptanceTests\TestResults.xml and
debug information will be available in the AcceptanceTests\log directory.

Credits
-------

![Connamara Systems](http://quickfixn.org/web/public/images/Connamara-Logo.png)

QuickFIXn is maintained and funded by [Connamara](http://connamara.com).

The names and logos for Connamara are trademarks of Connamara Systems, LLC.

Licensing
---------

This software is available under the QuickFIX Software License. Please see the [LICENSE](LICENSE) for the terms specified by the QuickFIX Software License.

[1]: http://quickfixn.org/web/public/images/qfn-logo/QuickFIX-n_logo-small.png
