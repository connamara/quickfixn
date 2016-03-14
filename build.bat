echo off

set TARGET=%1
set CONFIGURATION=%2
set NET_VERSION=%3
set PLATFORM=%4

if "%1" == "" set TARGET=Rebuild
if "%2" == "" set CONFIGURATION=Release
if "%3" == "" set NET_VERSION=v4.5
if "%4" == "" set PLATFORM=x86

set BUILD_CMD=MSBuild.exe QuickFIXn.sln /t:%TARGET% /p:Configuration=%CONFIGURATION%;TargetFrameworkVersion=%NET_VERSION%;Platform=%PLATFORM%
echo Build command: %BUILD_CMD%
%BUILD_CMD%
