#!/bin/bash
#
#  Arguments will be passed to nunit-console, so you can do things like:
#    ./unit_test.sh -run=UnitTests.SessionScheduleTests
#

RESULT=0

set +e

pushd UnitTests/bin/Release/
	rm -rf TestResult.xml UnitTests.html
	nunit-console UnitTests.dll $@
	RESULT=$?
	xsltproc -o UnitTests.html ../../nunit.xsl TestResult.xml
popd

exit $RESULT

