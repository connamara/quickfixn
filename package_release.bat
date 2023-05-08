@echo off
REM || echo -e "\n*** Run this in DOS, not bash!\n" && exit

rem Setup variables
set TAG_VERSION=%1
if "%TAG_VERSION%" == "" goto usage
set QF_DIR=quickfixn-%TAG_VERSION%

SET ACCESS_KEY=%2
if "%ACCESS_KEY%" == "" goto usage

set SECRET_KEY=%3
if "%SECRET_KEY%" == "" goto usage

set BUILD_TARGET=build
set BUILD_PROPS="-c Release"
set NUGET_API_KEY=%4
if "%NUGET_API_KEY%" NEQ "" (
	set BUILD_TARGET=pack
	set BUILD_PROPS="%BUILD_PROPS% --include-symbols -o tmp\NuGet"
)

echo ==QuickFIX/N Package release script==
echo tag version: %TAG_VERSION%
echo

rem Update the assembly version
ruby scripts\update_assembly_version.rb %TAG_VERSION% QuickFIXn\QuickFix.csproj Messages\FIX40\QuickFix.FIX40.csproj Messages\FIX41\QuickFix.FIX41.csproj Messages\FIX42\QuickFix.FIX42.csproj Messages\FIX43\QuickFix.FIX43.csproj Messages\FIX44\QuickFix.FIX44.csproj Messages\FIX50\QuickFix.FIX50.csproj Messages\FIX50SP1\QuickFix.FIX50SP1.csproj Messages\FIX50SP2\QuickFix.FIX50SP2.csproj
if %errorlevel% neq 0 echo "update_assembly_version.rb failed" && exit /b %errorlevel%
echo * QuickFix .csproj files updated for new version number.

rem commit the version file, so it will be part of the tag
call git add QuickFIXn\QuickFix.csproj
call git add Messages\FIX40\QuickFix.FIX40.csproj
call git add Messages\FIX41\QuickFix.FIX41.csproj
call git add Messages\FIX42\QuickFix.FIX42.csproj
call git add Messages\FIX43\QuickFix.FIX43.csproj
call git add Messages\FIX44\QuickFix.FIX44.csproj
call git add Messages\FIX50\QuickFix.FIX50.csproj
call git add Messages\FIX50SP1\QuickFix.FIX50SP1.csproj
call git add Messages\FIX50SP2\QuickFix.FIX50SP2.csproj
call git commit -m "version number for version %TAG_VERSION%"
echo * Version number committed.

rem create the tag
call git tag -a %TAG_VERSION% -m "Release version %TAG_VERSION%"
echo * Created tag.

rem Get requested version
call git checkout %TAG_VERSION%
if %errorlevel% neq 0 echo "There was an error checking out QuickFIX/n %TAG_VERSION%" && exit /b %errorlevel%
echo * Checked out tag.

rem Generate code from dd
ruby generator/generate.rb
if %errorlevel% neq 0 echo "There was an error generating code from the data dictionaries" && exit /b %errorlevel%
echo * Generated code.

rem Build QuickFIX/n
IF EXIST tmp\NuGet del /q tmp\NuGet\*.*nupkg
rem This builds the projects and packages them.
dotnet %BUILD_TARGET% %BUILD_PROPS% QuickFIXn.sln
if %errorlevel% neq 0 echo "There was an error building QuickFIX/n" && exit /b %errorlevel%
echo * Built QuickFIX/n and created NuGet packages.

rem Push NuGet packages (and symbol packages) to nuget.org
rem DO NOT remove quotes around *.nupkg. Due to a bug in older versions of .NET SDK,
rem without quotes, only the first package will be pushed.
if "%BUILD_TARGET%" == "pack" dotnet nuget push '*.nupkg' -s https://api.nuget.org/v3/index.json -k %NUGET_API_KEY% tmp\NuGet
echo * Pushed QuickFIX/n NuGet packages to NuGet.org

rem Copy files to temp directory
IF EXIST tmp rmdir /s /q tmp
mkdir tmp
mkdir tmp\%QF_DIR%
mkdir tmp\%QF_DIR%\bin
mkdir tmp\%QF_DIR%\bin\net6.0
mkdir tmp\%QF_DIR%\spec
mkdir tmp\%QF_DIR%\spec\fix
mkdir tmp\%QF_DIR%\config
copy QuickFIXn\bin\Release\net6.0\QuickFix.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.dll

copy Messages\FIX40\bin\Release\net6.0\QuickFix.FIX40.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.FIX40.dll
copy Messages\FIX41\bin\Release\net6.0\QuickFix.FIX41.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.FIX41.dll
copy Messages\FIX42\bin\Release\net6.0\QuickFix.FIX42.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.FIX42.dll
copy Messages\FIX43\bin\Release\net6.0\QuickFix.FIX43.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.FIX43.dll
copy Messages\FIX44\bin\Release\net6.0\QuickFix.FIX44.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.FIX44.dll
copy Messages\FIX50\bin\Release\net6.0\QuickFix.FIX50.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.FIX50.dll
copy Messages\FIX50SP1\bin\Release\net6.0\QuickFix.FIX50SP1.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.FIX50SP1.dll
copy Messages\FIX50SP2\bin\Release\net6.0\QuickFix.FIX50SP2.dll tmp\%QF_DIR%\bin\net6.0\QuickFix.FIX50SP2.dll

xcopy spec\fix tmp\%QF_DIR%\spec\fix /e /y
copy config\sample_acceptor.cfg tmp\%QF_DIR%\config\
copy config\sample_initiator.cfg tmp\%QF_DIR%\config\
copy RELEASE_README.md tmp\%QF_DIR%\README.md
copy LICENSE tmp\%QF_DIR%\
copy RELEASE_NOTES.md tmp\%QF_DIR%\
echo * Copied files to tmp directory.

rem Create ZIP
set ZIP_NAME=%QF_DIR%.zip
IF EXIST %ZIP_NAME% del /q %ZIP_NAME%
ruby scripts\create_zip.rb tmp/%QF_DIR% %ZIP_NAME%
if %errorlevel% neq 0 echo "There was an error creating QuickFIX/n ZIP: %ZIP_NAME%" && exit /b %errorlevel%
echo * Created zip.

rem Upload ZIP
ruby scripts\s3_upload.rb %ZIP_NAME% %ACCESS_KEY% %SECRET_KEY%
if %errorlevel% neq 0 echo "There was an error uploading %ZIP_NAME% into the s3" && exit /b %errorlevel%
echo * Uploaded zip.

rem Remove temp directory
rmdir /s/q tmp
echo * Removed tmp directory.

rem Switch back to master
call git checkout master
echo * Changed back to master.

echo
echo Successfully created QuickFIX/n %TAG_VERSION%.
echo You can download the zip here: http://quickfixn.s3.amazonaws.com/%ZIP_NAME%
echo You must commit the new tag and deploy the website
set RESULT=0
goto quit

:usage
echo Usage: package_release.bat <VERSION> <S3_ACCESS_KEY> <S3_SECRET_KEY> [<NUGET_API_KEY>]
set RESULT=1

:quit
exit /B %RESULT%
