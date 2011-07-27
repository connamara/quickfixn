System Setup
------------

This project requires MSBuild, NUnit, and xsltproc.

You can get xsltproc via cygwin, or by installing libxslt (which requires
libxml2 and zlib).


Build
-----
To generate the code from Data Dictionaries (spec/fix), you need Ruby/JRuby (http://jruby.org/download) and the ruby gem Nokogiri.

    (j)gem install nokogiri
    (j)ruby generator/generate.rb


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


Acceptance Tests
----------

To run the acceptance tests, run:

    acceptance_test.bat

An HTML report of the test results will then be available here:

    AcceptanceTests\AcceptanceTests.html
