#!/bin/bash
#

RESULT=0

set +e

dotnet test -c Release --no-build --no-restore UnitTests -l trx

RESULT=$?

exit $RESULT
