[![QuickFIX/N][1]](http://quickfixn.org)

![Build status](https://github.com/connamara/quickfixn/actions/workflows/dotnet.yml/badge.svg)
[![NuGet Version](https://img.shields.io/nuget/v/QuickFIXn.Core)](https://www.nuget.org/packages/QuickFIXn.Core/)

For tutorials on how to use QuickFIX/n, visit the [website](http://quickfixn.org/tutorial/creating-an-application.html).

This README is about setting up your system to do QuickFIX/n
development.

System Setup
------------

* This project uses .NET 6.

* All scripts are in Powershell, and should work on both Windows and Unix-based platforms.


Code Generation
---------------
DDTool is a C#-based tool for analyzing DataDictionary files and
regenerating the source for message and field classes.

Check out the DDTool directory to learn more, or you can just run this script:

```
pwsh scripts\Generate-Message-Sources.ps1
```


Build and Test
--------------
It is assumed that developers know how to use `dotnet` cli tools
or their IDE of choice.

The simplest spin-up instructions are:
* `dotnet build` - to build
* `dotnet test` - to run all unit and acceptance tests (which use NUnit)

To run *only* UTs or *only* ATs:
* `dotnet test UnitTests`
* `dotnet test AcceptanceTests`

To get more detail in the test ouput:
* `dotnet test -l "console;verbosity=detailed" AcceptanceTest`

To run a specific suite, use ``--filter``, e.g.
* `dotnet test --filter Fix44Test AcceptanceTest`
(`Fix44Test` is the `TestCaseSource` function in Fix44.cs)

AcceptanceTest logs are output to `bin/Debug/net6.0/log`.


Credits
-------

![Connamara Systems](http://quickfixn.org/web/public/images/Connamara-Logo.png)

QuickFIXn is maintained and funded by [Connamara](http://connamara.com).

The names and logos for Connamara are trademarks of Connamara Systems, LLC.

Licensing
---------

This software is available under the QuickFIX Software License. Please see the [LICENSE](LICENSE) for the terms specified by the QuickFIX Software License.

[1]: http://quickfixn.org/web/public/images/qfn-logo/QuickFIX-n_logo-small.png
