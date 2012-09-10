[![QuickFIX/N][1]](http://quickfixn.org)


For tutorials on how to use QuickFIX/n, see the `tutorial` folder at the root
of this project or visit the [website](http://quickfixn.org/tutorial/creating-an-application).

This README is about setting up your system to do QuickFIX/n
development.

System Setup
------------
This project requires the following:

**To build**

* [Ruby (1.9.2 recommended)](http://rubyinstaller.org/) (used to generate message and field classes from the DataDictionary xml file)
* Visual Studio 2010 or higher

**To run tests**

* [NUnit](http://nunit.org)
* xsltproc (can be gotten via cygwin, or by installing libxslt (which requires libxml2 and zlib)).
  * xsltproc is only used for pretty-formatting the test output.  If you don't mind the error messages that appear because it's not found, you can ignore it.  ([We may get rid of this dependency.](https://github.com/connamara/quickfixn/issues/104)).


Code Generation
---------------
To regenerate the message and field class source from the Data Dictionaries, you need Ruby and the Nokogiri gem:

    gem install nokogiri
    generate.bat


Build
-----
To build the project, run:

    build.bat

You can also override the default target, configuration, and .NET framework version by giving command line arguments:

    build.bat Rebuild Release v3.5


The build.bat script expects MSBuild.exe to be on your PATH.  If you run it
from a Visual Studio cmd shell, this should not be a problem.  However, if you
run it from some other shell (e.g. cygwin), you may need to append something
like:

    C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319

to your PATH environment variable.  (Note, this build tools dir does not mean that the project
will build for .NET 4.0; these are merely the build tools that come with VS 2010.)


Unit Tests
----------
To run the NUnit tests, run:

    unit_test.bat

(This script expects nunit-console.exe to be on your PATH.  You may have to append
something like `C:\Program Files\NUnit 2.6.1\bin` to your PATH environment variable.)

An HTML report of the test results will then be available here:

    UnitTests\bin\Release\UnitTests.html

To run a Unit Test in the debugger (not sure if it works in VS Express):

1. Right-click UnitTests project, click 'Properties'
2. Go to Debug tab
3. Change Start Action to 'Start external program: C:\Program Files\NUnit 2.6.1\bin\nunit.exe'
   (change the path to what is appropriate for your system)
4. Set your 'Command line arguments' to 'C:\dev\quickfixn\UnitTests\bin\Debug\UnitTests.dll'
   (change the path to what is appropriate for your system)
5. Set your 'Working directory' to 'C:\dev\quickfixn\UnitTests\bin\Debug\'
   (change the path to what is appropriate for your system)
6. Open NUnit in debugger as follows:
   Right-click UnitTests, choose Debug->Start New Instance
7. NUnit GUI will open and VS will be in debugger mode.  You can choose and run tests.
   If you recompile, you may need to close and relaunch NUnit.


Acceptance Tests
----------------
To run the full suite of acceptance tests:

    acceptance_test.bat

An HTML report of the test results will then be available here:

    AcceptanceTests\AcceptanceTests.html

To run one particular acceptance test, e.g. fix42\14e_IncorrectEnumValue.def:

    cd AcceptanceTest
    runat.bat release 5003 definitions\server\fix42\14e_IncorrectEnumValue.def cfg\at_42.cfg

(See acceptance_test.bat for the proper port numbers and config files to use in the above command.)

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

Automated Build Server
----------------------
We have an automated build server that builds and runs all unit and acceptance tests after code changes.

You can see the current build status here:

http://quickfixbuild.connamara.com/job/quickfix-n/


Website
-------

The website is a small Ruby Sinatra application.

For development, you should install Ruby 1.9.2 and the bundler gem then
bundle:

    gem install bundler
    bundle

Upon installing the gems, you can run this in the top directory to
start the website:

    thin start

`thin` automatically picks up the Rackfile `config.ru` in the top
directory.

Website specific files live in `/web`.

The website also serves tutorial files from the `/tutorial` directory

Markdown should be used for all tutorial files whenever possible, so
that viewers of the source can easily read plain text documentation.

For development purposes, you can install the `shotgun` web server;
this will re-load the website on every request. To start the website
with shotgun, simply run shotgun at the top directory:

    shotgun -p 3002


[0]: http://quickfixn.org
[1]: http://quickfixn.org/images/qfn-logo/QuickFIX-n_logo-small.png
