echo off
if "%1" == "" goto usage
if "%2" == "" goto usage

if "%1" == "debug" goto debug:
if "%1" == "release" goto release:
goto usage

:debug
set DIR=bin\Debug
goto start

:release
set DIR=bin\Release
goto start

:start
call setup.bat %2
release\at\atrun -t run -s "%DIR%\AcceptanceTest.exe -f cfg\at.cfg" -d . -c "ruby Runner.rb 127.0.0.1 %2 definitions\server\fix40\*.def definitions\server\fix41\*.def definitions\server\fix42\*.def definitions\server\fix43\*.def definitions\server\fix44\*.def definitions\server\fix50\*.def definitions\server\fix50sp1\*.def definitions\server\fix50sp2\*.def" -i .\
goto quit

:usage
echo "Usage: runat [release | debug] [port]"

:quit
