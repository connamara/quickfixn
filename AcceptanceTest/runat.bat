@echo off

set RESULT=0

if "%1" == "" goto usage
if "%2" == "" goto usage
if "%4" == "" (
    set CONF_FILE="cfg\at.cfg"
)ELSE (
    set CONF_FILE=%4
)

set TESTS="definitions/server/fix42/*.def"
if "%3" == "" goto getconfig:
set TESTS="%3"
goto getconfig

set CONFFILE="cfg\at.cfg"

:getconfig
if "%1" == "debug" goto debug
if "%1" == "release" goto release
goto usage

:debug
set DIR=bin\Debug
goto start

:release
set DIR=bin\Release
goto start

:start

call setup.bat %2

start %DIR%\AcceptanceTest.exe %CONF_FILE%
ruby Runner.rb 127.0.0.1 %2 %TESTS% > TestResult.xml
taskkill /F /IM AcceptanceTest.exe

if ERRORLEVEL 1 set RESULT=1
type TestResult.xml
goto quit

:usage
echo "Usage: runat [release | debug] [port] [TESTFILE...]"
set RESULT=1

:quit
exit /B %RESULT%

