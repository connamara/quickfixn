@echo off

pushd UnitTests
dotnet restore -v q /nologo
dotnet xunit -nobuild -configuration Release -xml ../artifacts/UnitTests.xml
popd
exit /B %ERRORLEVEL%
