[![QuickFIX/N][1]](http://quickfixn.org)

[![Build status](https://ci.appveyor.com/api/projects/status/ccu2yp2coad3oam0?svg=true)](https://ci.appveyor.com/project/cbusbey/quickfixn-jib50)

For tutorials on how to use QuickFIX/n, visit the [website](http://quickfixn.org/tutorial/creating-an-application.html).

This README is about setting up your system to do QuickFIX/n
development.

System Setup
------------
This project requires the following:

**To build and run tests**

* [Ruby (1.9.3 recommended)](http://rubyinstaller.org/) (used to generate message and field classes from the DataDictionary xml file)
* From the command-line: dotnet 2.0.0 or higher
* From Visual Studio: version 2017 or higher

Code Generation
---------------
To regenerate the message and field class source from the Data Dictionaries, you need Ruby and the Nokogiri gem:

```
gem install nokogiri -v 1.6.8.1
generate.bat
```

(Nokogiri versions 1.7+ require Ruby 2.0, so we must use this older version.)


Build
-----
To build the project, run:

```
build.bat
```

You can also override the default configuration (Release) by giving a command line argument:

```
build.bat Debug
```

The build.bat script expects dotnet to be on your PATH.

Alternatively, simply use the dotnet tools.

Unit Tests
----------
To run the NUnit tests, run:

```
unit_test.bat
```

(This script expects `dotnet` to be on your PATH.)

TRX reports of the test results (one each for NET Framework 4.5.2 and NET Standard 2.0) will then be available here:

```
UnitTests\TestResults
```

Alternatively, simply use `dotnet`:

```
dotnet test UnitTests
```

To run a Unit Test in the debugger:

1. Open the TestExplorer from Test -> Windows -> Test Explorer
2. Navigate to the test
3. Right-click and select "Debug Selected Tests"


Acceptance Tests
----------------
To run the full suite of acceptance tests:

```
acceptance_test.ps1
```

An HTML report of the test results will then be available here:

    AcceptanceTests\AcceptanceTests.html

To run one particular acceptance test, e.g. fix42\14e_IncorrectEnumValue.def:

```
cd AcceptanceTest
runat.ps1 release 5003 definitions\server\fix42\14e_IncorrectEnumValue.def cfg\at_42.cfg
```

(See acceptance_test.ps1 for the proper port numbers and config files to use in the above command.)

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

QuickFIXn is maintained and funded by [Connamara Systems, LLC](http://connamara.com).

The names and logos for Connamara Systems are trademarks of Connamara Systems, LLC.

Licensing
---------

This software is available under the QuickFIX Software License. Please see the [LICENSE](LICENSE) for the terms specified by the QuickFIX Software License.

[1]: http://quickfixn.org/web/public/images/qfn-logo/QuickFIX-n_logo-small.png
