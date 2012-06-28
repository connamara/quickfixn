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

echo ==QuickFIX/N Package release script==
echo tag version: %TAG_VERSION%
echo

rem Update the assembly version
ruby scripts\update_assembly_version.rb %TAG_VERSION% QuickFIXn\Properties\AssemblyInfo.cs
if %errorlevel% neq 0 echo "update_assembly_version.rb failed" && exit /b %errorlevel%
echo * AssemblyInfo updated for new version number.

rem Update downloads page - NOTE this must be done first
ruby scripts\update_download_page.rb web/views/download.md %TAG_VERSION%
if %errorlevel% neq 0 echo "There was an error uploading the downloads page" && exit /b %errorlevel%
echo * Downloads page updated.

rem commit the downloads page and version file, so it will be part of the tag
call git add web\views\download.md
call git add QuickFIXn\Properties\AssemblyInfo.cs
call git commit -m "Download page / version number for version %TAG_VERSION%"
echo * Downloads page / version number committed.

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
call build.bat
if %errorlevel% neq 0 echo "There was an error building QuickFIX/n" && exit /b %errorlevel%
echo * Built QuickFIX/n.

rem Copy files to temp directory
IF EXIST tmp rmdir /s /q tmp
mkdir tmp
mkdir tmp\%QF_DIR%
mkdir tmp\%QF_DIR%\bin
mkdir tmp\%QF_DIR%\spec
mkdir tmp\%QF_DIR%\config
copy QuickFIXn\bin\Release\QuickFix.dll tmp\%QF_DIR%\bin
xcopy spec tmp\%QF_DIR%\spec /e /y
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
echo Usage: package_release.bat [VERSION] [S3_ACCESS_KEY] [S3_SECRET_KEY]
set RESULT=1

:quit
exit /B %RESULT%
