@echo off

rem Setup variables
set TAG_VERSION=%1
if "%TAG_VERSION%" == "" goto usage
set QF_DIR=quickfixn-%TAG_VERSION%

SET ACCESS_KEY=%2
if "%ACCESS_KEY%" == "" goto usage

set SECRET_KEY=%3
if "%SECRET_KEY%" == "" goto usage

rem Update downloads page - NOTE this must be done first
ruby scripts\update_download_page.rb web/views/download.md %TAG_VERSION%
if %errorlevel% neq 0 echo "There was an error uploading the downloads page" && exit /b %errorlevel%

rem commit the downloads page, so it will be part of the tag
git add web/views/download.md
git commit -m "Download page for version %TAG_VERSION%"

rem create the tag
git tag -a %TAG_VERSION% -m "Created a tag for version %TAG_VERSION%"

rem Get requested version
git checkout %TAG_VERSION%
if %errorlevel% neq 0 echo "There was an error checking out QuickFIX/n %TAG_VERSION%" && exit /b %errorlevel%

rem Generate code from dd
ruby generator/generate.rb
if %errorlevel% neq 0 echo "There was an error generating code from the data dictionaries" && exit /b %errorlevel%

rem Build QuickFIX/n
call build.bat
if %errorlevel% neq 0 echo "There was an error building QuickFIX/n" && exit /b %errorlevel%

rem Copy files to temp directory
rmdir /s /q tmp
mkdir tmp
mkdir tmp\%QF_DIR%
mkdir tmp\%QF_DIR%\bin
mkdir tmp\%QF_DIR%\spec
mkdir tmp\%QF_DIR%\config
copy QuickFIX.NET\bin\Release\QuickFix.dll tmp\%QF_DIR%\bin
xcopy spec tmp\%QF_DIR%\spec /e /y
copy config\sample_acceptor.cfg tmp\%QF_DIR%\config\
copy config\sample_initiator.cfg tmp\%QF_DIR%\config\
copy RELEASE_README.md tmp\%QF_DIR%\README.md
copy LICENSE tmp\%QF_DIR%\
copy RELEASE_NOTES.md tmp\%QF_DIR%\

rem Create ZIP
set ZIP_NAME=%QF_DIR%.zip
del /q %ZIP_NAME%
ruby scripts\create_zip.rb tmp/%QF_DIR% %ZIP_NAME%
if %errorlevel% neq 0 echo "There was an error creating QuickFIX/n ZIP: %ZIP_NAME%" && exit /b %errorlevel%

rem Upload ZIP
ruby scripts\s3_upload.rb %ZIP_NAME% %ACCESS_KEY% %SECRET_KEY%
if %errorlevel% neq 0 echo "There was an error uploading %ZIP_NAME% into the s3" && exit /b %errorlevel%

rem Remove temp directory
rmdir /s/q tmp

rem Switch back to master
git checkout master

echo 
echo Successfully created QuickFIX/n %TAG_VERSION%.
echo You can download the zip here: http://quickfixn.s3.amazonaws.com/%ZIP_NAME%
echo You must commit the new tag and deploy the website
set RESULT=0
goto quit

:usage
echo "Usage: package_release.bat [VERSION] [S3_ACCESS_KEY] [S3_SECRET_KEY]"
set RESULT=1

:quit
exit /B %RESULT%
