set RESULT=0

pushd AcceptanceTest
    del TestResult.xml AcceptanceTests.html
    call runat release 5001
    if ERRORLEVEL 1 set RESULT=1
    xsltproc.exe -o AcceptanceTests.html at.xsl TestResult.xml
popd

exit /B %RESULT%

