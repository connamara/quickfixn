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

REM release\at\atrun -t run -s "%DIR%\AcceptanceTest.exe cfg\at.cfg" -d . -c "ruby Runner.rb 127.0.0.1 %2 definitions\server\fix40\*.def definitions\server\fix41\*.def definitions\server\fix42\*.def definitions\server\fix43\*.def definitions\server\fix44\*.def definitions\server\fix50\*.def definitions\server\fix50sp1\*.def definitions\server\fix50sp2\*.def" -i .\  -o TestResult.xml 
release\at\atrun -t run -s "%DIR%\AcceptanceTest.exe %CONF_FILE%" -d . -c "ruby Runner.rb 127.0.0.1 %2 %TESTS%" -i .\  -o TestResult.xml 
if ERRORLEVEL 1 set RESULT=1
type TestResult.xml
goto quit

:usage
echo "Usage: runat [release | debug] [TESTFILE...]"
set RESULT=1

:quit
exit /B %RESULT%

