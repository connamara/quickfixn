System Setup
------------
This project requires MSBuild, NUnit, Ruby, and xsltproc.

You can get xsltproc via cygwin, or by installing libxslt (which requires
libxml2 and zlib).


Code Generation
---------------
To generate the code from Data Dictionaries, you need Ruby/JRuby (http://jruby.org/download) and the Nokogiri gem:

    gem install nokogiri
    ruby generator/generate.rb


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

    C:\WINDOWS\Microsoft.NET\Framework\v3.5

to your PATH environment variable.


Unit Tests
----------
To run the NUnit tests, run:

    unit_test.bat

An HTML report of the test results will then be available here:

    UnitTests\bin\Release\UnitTests.html

To run a Unit Test in the debugger (does not work in VS Express):

1. Right-click UnitTests project, click 'Properties'
2. Go to Debug tab
3. Change Start Action to 'Start external program: C:\Program Files\NUnit-2.5.9.10348\bin\net-2.0\nunit.exe'
   (change the path to what is appropriate for your system)
4. Set your 'Command line arguments' to 'C:\dev\qfnet\quickfix.net\UnitTests\bin\Debug\UnitTests.dll'
   (change the path to what is appropriate for your system)
5. Set your 'Working directory' to 'C:\dev\qfnet\quickfix.net\UnitTests\bin\Debug\'
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

    cd AcceptanceTests
    runat.bat release 5001 definitions\server\fix42\14e_IncorrectEnumValue.def

The test results will then be available in AcceptanceTests\TestResults.xml and
debug information will be available in the AcceptanceTests\log directory.

To run a test with the debugger, 

  1. Open the solution file in Visual Studio
  2. Right click on "AcceptanceTest" project
  3. Open the "properties" tab
  4. Click "Debug" on the left hand nav bar
  5. Set "Command line arguments" to "cfg\at.cfg"
  6. Set the working folder to "... AcceptanceTest"
  7. Save the properties
  7. Right click the "AcceptanceTest" project, go to Debug -> Start New Instance
  8. In command terminal, go into "AcceptanceTest" directory
  9. Run: `ruby Runner.rb 127.0.0.1 5001 definitions\server\fix42\YourTestName.def`




