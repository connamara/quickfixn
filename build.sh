#!/bin/sh

set -e

if [ -z "$VERSION" ]; then
    VERSION="1.7.0"
fi

if [ -z "$PACKAGE_ID" ]; then
    PACKAGE_ID="QuickFix.Net"
fi

echo "Restoring dependencies"
dotnet restore -v q  /nologo /p:Version=$VERSION

echo "Compiling project"
dotnet build -c Release -v q /nologo /p:Version=$VERSION

echo "Creating nuget package"
dotnet pack  -c Release -v q --no-build -o ../artifacts ./QuickFIXn/QuickFIX.csproj /nologo /p:Version=$VERSION /p:PackageId=$PACKAGE_ID
echo Done