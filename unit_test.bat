echo off

set RESULT=0

pushd UnitTests\bin\Release\
    if exist TestResult.xml del TestResult.xml
    if exist UnitTests.html del UnitTests.html
    "C:\Program Files (x86)\NUnit 2.6.1\bin\nunit-console" UnitTests.dll
    if ERRORLEVEL 1 set RESULT=1
    xsltproc.exe -o UnitTests.html ..\..\nunit.xsl TestResult.xml
popd

PAUSE
exit /B %RESULT%

