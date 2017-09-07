#!/bin/sh

set -e

if [ -z "$VERSION" ]; then
    VERSION=1.7.0
fi

echo "Restoring dependencies"
dotnet restore -v q  /nologo /p:Version=$VERSION

echo "Compiling project"
dotnet build -c Release -v q /nologo /p:Version=$VERSION

echo "Creating nuget package"
dotnet pack  -c Release -v q --no-build -o ../artifacts ./QuickFIXn/QuickFIX.csproj /nologo /p:Version=$VERSION
echo Done