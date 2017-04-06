echo off

set RESULT=0

pushd UnitTests\bin\Release\
    if exist TestResult.xml del TestResult.xml
    if exist UnitTests.html del UnitTests.html
    nunit-console UnitTests.dll
    if ERRORLEVEL 1 set RESULT=1
popd

exit /B %RESULT%
