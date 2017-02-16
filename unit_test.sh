#!/bin/bash
#
#  Arguments will be passed to nunit-console, so you can do things like:
#    ./unit_test.sh -run=UnitTests.SessionScheduleTests
#

RESULT=0

set +e

cp  -r -f resources/nunit/* UnitTests/bin/Release/

pushd UnitTests/bin/Release/
	rm -rf TestResult.xml UnitTests.html
	nunit-console UnitTests.dll $@
	RESULT=$?
popd

exit $RESULT
