
Param(
  [Parameter(Mandatory=$True,Position=1)]
   [string]$configuration,
	
  [Parameter(Mandatory=$True,Position=2)]
   [string]$port,

  [Parameter(Position=3)]
   [string]$tests=$null,

  [Parameter(Position=4)]
    [string] $conf= "cfg\at.cfg", 

  [Parameter(Position=5)]
    [string] $framework= "net461"
)

$result = 0


if([string]::IsNullOrEmpty($tests))
{
    $tests = "definitions/server/fix42/*.def"
}


if(($configuration -ne "release" -And $configuration -ne "debug") -Or ($framework -ne "net461" -And $framework -ne "netcoreapp2.0"))
{
    Usage
}

function KillChildren
{
    Param(
        [Parameter(Mandatory=$True,Position=1)]
            [int]$parentProcessId
    )

    Get-WmiObject win32_process | where {$_.ParentProcessId -eq $parentProcessId} | ForEach { KillChildren $_.ProcessId }
    Get-WmiObject win32_process | where {$_.ParentProcessId -eq $parentProcessId} | ForEach { Stop-Process $_.ProcessId 2>$null }
}

function StartTests
{
    Start-Process -FilePath .\setup.bat -ArgumentList $port -NoNewWindow -Wait

    $atProcess = Start-Process -FilePath dotnet.exe -ArgumentList "run -c $configuration -f $framework --no-build --no-restore -- $conf" -NoNewWindow -PassThru

    Invoke-Expression "ruby Runner.rb 127.0.0.1 $port $tests > TestResult.xml"

    if($LASTEXITCODE -ne 0){ $script:result = 1 }
       
    KillChildren $pid 

    type TestResult.xml
    Quit
}

function Usage
{
    echo "Usage: runat [release | debug] [port] [TESTFILE...] [net461|netcoreapp2.0]"
    $script:result = 1
    Quit
}

function Quit
{
    Exit $result
}

StartTests
