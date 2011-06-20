echo off

set RESULT=0

pushd UnitTests\bin\Release\
    del TestResult.xml UnitTests.html
    nunit-console UnitTests.dll
    if ERRORLEVEL 1 set RESULT=1
    xsltproc.exe -o UnitTests.html ..\..\nunit.xsl TestResult.xml
popd

exit /B %RESULT%

