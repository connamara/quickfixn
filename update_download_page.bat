@echo off

rem Setup variables
set TAG_VERSION=%1
if "%TAG_VERSION%" == "" echo "Please provide a version (e.g. update_download_page.bat v1.0)" && exit /b

rem Update downloads page - NOTE this must be done first
ruby scripts\update_downloads_page.rb web/views/download.md %TAG_VERSION%
if %errorlevel% neq 0 echo "There was an error uploading the downloads page" && exit /b %errorlevel%

rem commit the downloads page, so it will be part of the tag
git add web/views/download.md
git commit -m "Download page for version %TAG_VERSION%"