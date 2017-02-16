echo off

set RESULT=0
 
xcopy /s /y resources\nunit\* UnitTests\bin\Release\

pushd UnitTests\bin\Release\
    if exist TestResult.xml del TestResult.xml
    if exist UnitTests.html del UnitTests.html
    nunit3-console UnitTests.dll
    if ERRORLEVEL 1 set RESULT=1
popd

exit /B %RESULT%
