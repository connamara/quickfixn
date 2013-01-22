REM reset script vars that this script uses
REM (in case the environment has them inexplicably set already)
set RESULT40=
set RESULT41=
set RESULT42=
set RESULT43=
set RESULT44=
set RESULT50=
set RESULT50SP1=
set RESULT50SP2=
set RESULTMISC=
set RETURNVALUE=

pushd AcceptanceTest
    del AcceptanceTests_*.xml

    call pause
    del TestResult.xml
    call runat release 5001 definitions/server/fix40/*.def cfg/at_40.cfg
    if ERRORLEVEL 1 set RESULT40=1
    echo "40 tests result: %RESULT40%"
    copy TestResult.xml AcceptanceTests_40.xml

    call pause
    del TestResult.xml
    call runat release 5002 definitions/server/fix41/*.def cfg/at_41.cfg
    if ERRORLEVEL 1 set RESULT41=1
    echo "41 tests result: %RESULT41%"
    copy TestResult.xml AcceptanceTests_41.xml
    
    call pause
    del TestResult.xml
    call runat release 5003 definitions/server/fix42/*.def cfg/at_42.cfg
    if ERRORLEVEL 1 set RESULT42=1
    echo "42 tests result: %RESULT42%"
    copy TestResult.xml AcceptanceTests_42.xml

    call pause    
    del TestResult.xml
    call runat release 5004 definitions/server/fix43/*.def cfg/at_43.cfg
    if ERRORLEVEL 1 set RESULT43=1
    echo "43 tests result: %RESULT43%"
    copy TestResult.xml AcceptanceTests_43.xml
    
    call pause
    del TestResult.xml
    call runat release 5005 definitions/server/fix44/*.def cfg/at_44.cfg
    if ERRORLEVEL 1 set RESULT44=1
    echo "44 tests result: %RESULT44%"
    copy TestResult.xml AcceptanceTests_44.xml
    
    call pause
    del TestResult.xml
    call runat release 5006 definitions/server/fix50/*.def cfg/at_50.cfg
    if ERRORLEVEL 1 set RESULT50=1
    echo "50 tests result: %RESULT50%"
    copy TestResult.xml AcceptanceTests_50.xml
    
    call pause
    del TestResult.xml
    call runat release 5007 definitions/server/fix50sp1/*.def cfg/at_50_sp1.cfg
    if ERRORLEVEL 1 set RESULT50SP1=1
    echo "50 SP1 tests result: %RESULT50SP1%"
    copy TestResult.xml AcceptanceTests_50_SP1.xml
    
    call pause
    del TestResult.xml
    call runat release 5008 definitions/server/fix50sp2/*.def cfg/at_50_sp2.cfg
    if ERRORLEVEL 1 set RESULT50SP2=1
    echo "50 SP2 tests result: %RESULT50SP2%"
    copy TestResult.xml AcceptanceTests_50_SP2.xml
	
    call pause
    del TestResult.xml
    call runat release 5003 definitions/server/misc/*.def cfg/at_42.misc.cfg
    if ERRORLEVEL 1 set RESULTMISC=1
    echo "Misc tests result: %RESULTMISC%"
    copy TestResult.xml AcceptanceTests_Misc.xml
popd

echo ""
echo ""
echo "test suite results (blank means success):"
echo "    40: %RESULT40%"
echo "    41: %RESULT41%"
echo "    42: %RESULT42%"
echo "    43: %RESULT43%"
echo "    44: %RESULT44%"
echo "    50: %RESULT50%"
echo "50 SP1: %RESULT50SP1%"
echo "50 SP2: %RESULT50SP2%"
echo "  MISC: %RESULTMISC%"

set /a RETURNVALUE=RESULT40+RESULT41+RESULT42+RESULT43+RESULT44+RESULT50+RESULT50SP1+RESULT50SP2+RESULTMISC

echo "Script returns: %RETURNVALUE%"
exit /B %RETURNVALUE%
