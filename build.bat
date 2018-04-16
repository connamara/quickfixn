echo off

set CONFIGURATION=%1

if "%1" == "" set CONFIGURATION=Release

set BUILD_CMD=dotnet build -c %CONFIGURATION%
echo Build command: %BUILD_CMD%
%BUILD_CMD%
