System Setup
------------

This project requires MSBuild, NUnit, and xsltproc.

You can get xsltproc via cygwin, or by installing libxslt (which requires
libxml2 and zlib).


Build
-----

To build the project, run:

    build.bat

You can also override the default target, configuration, and .NET framework version by giving command line arguments:

    build.bat Rebuild Release v3.5


Unit Tests
----------

To run the NUnit tests, run:

    unit_test.bat

An HTML report of the test results will then be available here:

    UnitTests\bin\Release\UnitTests.html
