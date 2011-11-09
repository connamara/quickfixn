@echo off

rem Setup variables
set TAG_VERSION=%1
if "%TAG_VERSION%" == "" echo "Please provide a version (e.g. package_release.bat v1.0)" && exit /b
set QF_DIR=quickfixn-%TAG_VERSION%

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
copy README tmp\%QF_DIR%\
copy LICENSE tmp\%QF_DIR%\

rem Create ZIP
set ZIP_NAME=%QF_DIR%.zip
del /q %ZIP_NAME%
ruby scripts\create_zip.rb tmp/%QF_DIR% %ZIP_NAME%
if %errorlevel% neq 0 echo "There was an error creating QuickFIX/n ZIP: %ZIP_NAME%" && exit /b %errorlevel%

rem Upload ZIP
python C:\Python27\Scripts\s3cmd -P put %ZIP_NAME% s3://quickfixn/%ZIP_NAME%
if %errorlevel% neq 0 echo "There was an error uploading %ZIP_NAME% into the s3" && exit /b %errorlevel%

rem Remove temp directory
rmdir /s/q tmp

echo 
echo Successfully created QuickFIX/n %TAG_VERSION%.
echo You can download the zip here: http://quickfixn.s3.amazonaws.com/%ZIP_NAME%
echo You must manually add and commit web/views/download.md, and deploy the website
