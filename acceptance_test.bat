set RESULT=0

pushd AcceptanceTest
    del TestResult.xml AcceptanceTests_40.html AcceptanceTests_41.xml AcceptanceTests_42.xml AcceptanceTests_43.xml AcceptanceTests_44.xml
    call runat release 5001 definitions/server/fix40/*.def
    if ERRORLEVEL 1 set RESULT=1
    echo "40 tests result: %ERRORLEVEL% %RESULT%"
    xsltproc.exe -o AcceptanceTests_40.html at.xsl TestResult.xml
    
    call runat release 5001 definitions/server/fix41/*.def
    if ERRORLEVEL 1 set RESULT=1
    echo "41 tests result: %ERRORLEVEL% %RESULT%"
    xsltproc.exe -o AcceptanceTests_41.html at.xsl TestResult.xml
    
    call runat release 5001 definitions/server/fix42/*.def
    if ERRORLEVEL 1 set RESULT=1
    echo "42 tests result: %ERRORLEVEL% %RESULT%"
    xsltproc.exe -o AcceptanceTests_42.html at.xsl TestResult.xml
    
    call runat release 5001 definitions/server/fix43/*.def
    if ERRORLEVEL 1 set RESULT=1
    echo "43 tests result: %ERRORLEVEL% %RESULT%"
    xsltproc.exe -o AcceptanceTests_43.html at.xsl TestResult.xml
    
    call runat release 5001 definitions/server/fix44/*.def
    if ERRORLEVEL 1 set RESULT=1
    echo "44 tests result: %ERRORLEVEL% %RESULT%"
    xsltproc.exe -o AcceptanceTests_44.html at.xsl TestResult.xml
popd

echo "script return code: %RESULT%"

exit /B %RESULT%

