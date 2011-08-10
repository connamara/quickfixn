echo off
set PORT=%1
echo [DEFAULT] > cfg\at.cfg
REM FIXME:
echo Verbose=Y >> cfg\at.cfg
echo FileLogPath=log >> cfg\at.cfg
echo ConnectionType=acceptor >> cfg\at.cfg
echo SocketAcceptPort=%PORT% >> cfg\at.cfg
echo SocketReuseAddress=Y >> cfg\at.cfg
echo StartTime=00:00:00 >> cfg\at.cfg
echo EndTime=00:00:00 >> cfg\at.cfg
echo SenderCompID=ISLD >> cfg\at.cfg
echo TargetCompID=TW >> cfg\at.cfg
echo ResetOnLogon=Y >> cfg\at.cfg
echo FileStorePath=store >> cfg\at.cfg
echo [SESSION] >> cfg\at.cfg
echo BeginString=FIX.4.0 >> cfg\at.cfg
echo DataDictionary=..\spec\fix\FIX40.xml >> cfg\at.cfg
echo [SESSION] >> cfg\at.cfg
echo BeginString=FIX.4.1 >> cfg\at.cfg
echo DataDictionary=..\spec\fix\FIX41.xml >> cfg\at.cfg
echo [SESSION] >> cfg\at.cfg
echo BeginString=FIX.4.2 >> cfg\at.cfg
echo DataDictionary=..\spec\fix\FIX42.xml >> cfg\at.cfg
echo [SESSION] >> cfg\at.cfg
echo BeginString=FIX.4.3 >> cfg\at.cfg
echo DataDictionary=..\spec\fix\FIX43.xml >> cfg\at.cfg
echo [SESSION] >> cfg\at.cfg
echo BeginString=FIX.4.4 >> cfg\at.cfg
echo DataDictionary=..\spec\fix\FIX44.xml >> cfg\at.cfg
REM echo [SESSION] >> cfg\at.cfg
REM echo BeginString=FIXT.1.1 >> cfg\at.cfg
REM echo DefaultApplVerID=FIX.5.0 >> cfg\at.cfg
REM echo TransportDataDictionary=..\spec\fix\FIXT11.xml >> cfg\at.cfg
REM echo AppDataDictionary=..\spec\fix\FIX50.xml >> cfg\at.cfg
