echo off

set RESULT=0

pushd UnitTests\bin\Release\
    del TestResult.xml
    nunit-console UnitTests.dll
    if ERRORLEVEL 1 set RESULT=1
popd

exit /B %RESULT%

