@echo off

if "%VERSION%" == "" set VERSION="1.7.0"

echo Restoring dependencies
dotnet restore -v q /nologo /p:Version=%VERSION%
if %ERRORLEVEL% NEQ 0 goto exit

echo Compiling project
dotnet build -c Release -v q /nologo /p:Version=%VERSION%
if %ERRORLEVEL% NEQ 0 goto exit

echo Creating nuget package
dotnet pack  -c Release -v q --no-build -o ../artifacts ./QuickFIXn/QuickFIX.csproj /nologo  /p:Version=%VERSION%
echo Done

:exit