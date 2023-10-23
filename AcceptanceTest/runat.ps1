[CmdletBinding()]
Param(
    [Parameter(Mandatory, Position=0)]
    [ValidateSet('debug','release')]
    [string]$Configuration,

    [Parameter(Mandatory, Position=1)]
    [ValidateRange(1, 65535)]
    [int]$Port,

    [Parameter(Mandatory, Position=2)]
    [string]$Tests,

    [Parameter(Mandatory, Position=3)]
    [string] $Conf,

    [Parameter(Mandatory, Position=4)]
    [ValidateSet('net6.0','net461','netcoreapp2.1')]
    [string] $Framework,

    [switch]$UseWsl
)

function KillChildren {
    Param (
        [Parameter(Position = 0, Mandatory, ValueFromPipeline)]
        [int[]]$ProcessId,

        [switch]$PassThru
    )

    process {
        foreach ($p in $ProcessId) {
            $ChildPid = if ($IsWindows) {
                (Get-CimInstance -Class Win32_Process -Filter "ParentProcessId = $p AND Name != 'conhost.exe'" -Property ProcessId).ProcessId
            } else {
                (Get-Process | Where-Object { $_.Parent.Id -eq $p }).Id
            }

            if ($ChildPid)
            {
                $ChildPid |
                    KillChildren -PassThru |
                    ForEach-Object {
                        Stop-Process -Id $_ -ErrorAction Ignore -Force
                    }
            }

            if ($PassThru -and $PassThru.IsPresent) {
                $p
            }
        }
    }
}

function Write-TestResult {
    Param (
        [Parameter(Position = 0, Mandatory, ValueFromPipeline)]
        [xml]$TestResult
    )

    begin {
        $TestRegex = [regex]'(?in)^.*/(?<FixVersion>fix\d{2}(sp\d+)?)(([^/]*)/)?(?<TestName>.*)$'
        $FixRegex = [regex]'(?in)^fix(?<Major>\d)(?<Minor>\d)(?<ServicePack>(?<Prefix>SP)(?<Number>\d+))?$'
    }

    process {
        # Canonicalize the FIX protocal version for the test results being displayed
        $FixVersion = $TestResult.FirstChild.SelectSingleNode('test').name -replace $TestRegex, '${FixVersion}'
        $FixVersion = $($FixVersion -replace $FixRegex, 'FIX ${Major}.${Minor} ${Prefix} ${Number}').TrimEnd().ToUpperInvariant()

        Write-Host "`nTest Results for:  $FixVersion ($Framework)"

        $TestResult.at.test |
            ForEach-Object {
                $ErrorMessage = ''
                if ($_.result -ine 'success') {
                    $ErrorMessage = 'Could not extract message from XML.  See log.'
                    try {
                        $ErrorMessage = $_.message.ChildNodes[0].Value.Trim()
                    }catch{
                        # ignore
                    }
                }

                [PSCustomObject]@{
                    Name = $_.name -replace $TestRegex, '${TestName}'
                    Result = if ($_.result -ieq 'success') { 'PASS' } else { 'FAIL' }
                    Message = $ErrorMessage
                }
            } |
            Format-Table

        $TotalResults = $TestResult.at.results
        Write-Host $('-'*80)
        Write-Host "$FixVersion ($Framework) Results:"
        Write-Host "  Total Tests: $($TotalResults.total)"
        Write-Host "      Passing: $($TotalResults.total - $TotalResults.failures)"
        Write-Host "      Failing: $($TotalResults.failures)`n"
    }
}

function StartTests
{
    $sep = if ($IsWindows) { "\" } else { "/" }

    @"
[DEFAULT]
Verbose=Y
FileLogPath=log
ConnectionType=acceptor
SocketAcceptPort=$Port
SocketReuseAddress=Y
StartTime=00:00:00
EndTime=00:00:00
SenderCompID=ISLD
TargetCompID=TW
ResetOnLogon=Y
FileStorePath=store
[SESSION]
BeginString=FIX.4.0
DataDictionary=..${sep}spec${sep}fix${sep}FIX40.xml
[SESSION]
BeginString=FIX.4.1
DataDictionary=..${sep}spec${sep}fix${sep}FIX41.xml
[SESSION]
BeginString=FIX.4.2
DataDictionary=..${sep}spec${sep}fix${sep}FIX42.xml
[SESSION]
BeginString=FIX.4.3
DataDictionary=..${sep}spec${sep}fix${sep}FIX43.xml
[SESSION]
BeginString=FIX.4.4
DataDictionary=..${sep}spec${sep}fix${sep}FIX44.xml
[SESSION]
BeginString=FIXT.1.1
DefaultApplVerID=FIX.5.0SP1
TransportDataDictionary=..${sep}spec${sep}fix${sep}FIXT11.xml
AppDataDictionary=..${sep}spec${sep}fix${sep}FIX50SP1.xml
"@ | Out-File "cfg${sep}at.cfg" -Encoding utf8

    # Start the acceptor...
    # (this runs the exe or dll in AcceptanceTest/bin/)
    Start-Process -FilePath dotnet -ArgumentList "run -c $Configuration -f $Framework --no-build --no-restore -- $Conf" -NoNewWindow -PassThru |
      Out-Null # suppress process output

    if ($UseWsl -and $UseWsl.IsPresent) {
        wsl ruby Runner.rb '127.0.0.1' $Port "$Tests" > TestResult.xml
    } else {
        ruby Runner.rb '127.0.0.1' $Port $Tests > TestResult.xml
    }

    if ($LASTEXITCODE -ne 0) { $Result = $LASTEXITCODE }

    KillChildren $pid

    [xml]$TestResult = Get-Content TestResult.xml -Raw
    Write-TestResult $TestResult

    Exit $Result
}

StartTests

