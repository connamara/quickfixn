@echo off

set RESULT=0

dotnet test -c Release --no-build --no-restore UnitTests -l trx

exit /B %RESULT%
