echo off

set CONFIGURATION=%1

if "%1" == "" set CONFIGURATION=Release

pwsh -v >nul 2>&1
if "%ERRORLEVEL%" == "0" (
	pwsh .\build.ps1 %CONFIGURATION%
) else (
	powershell .\build.ps1 %CONFIGURATION%
)
