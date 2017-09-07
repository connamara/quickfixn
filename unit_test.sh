#!/bin/bash

RESULT=0

pushd UnitTests
dotnet restore -v q /nologo
dotnet xunit -nobuild -configuration Release -xml ../artifacts/UnitTests.xml
RESULT=$?
popd

exit $RESULT
