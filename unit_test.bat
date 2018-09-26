@echo off

dotnet test -c Release --no-build --no-restore UnitTests -l trx
