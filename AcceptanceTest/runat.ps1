
Param(
  [Parameter(Mandatory=$True,Position=1)]
   [string]$release,
	
  [Parameter(Mandatory=$True,Position=2)]
   [string]$port,

  [Parameter(Position=3)]
   [string]$tests=$null,

  [Parameter(Position=4)]
    [string] $conf= "cfg\at.cfg" 
)

$result = 0


if([string]::IsNullOrEmpty($tests)) {
    $tests = "definitions/server/fix42/*.def"
}


if($release -eq "release") {
    $dir = "bin\Release"
}
elseif($release -eq "debug") {
    $dir = "bin\Debug"
}
else { Usage }


function StartTests
{
    Start-Process -FilePath setup.bat -ArgumentList $port

    Start-Process -FilePath $dir\AcceptanceTest.exe -ArgumentList $conf -NoNewWindow

    Invoke-Expression -Command "ruby Runner.rb 127.0.0.1 $port $tests > TestResult.xml"

    Stop-Process -Name AcceptanceTest

    if($LASTEXITCODE -eq 1){ $script:result = 1 }
       
    type TestResult.xml
    Quit
}

function Usage
{
    echo "Usage: runat [release | debug] [port] [TESTFILE...]"
    $script:result = 1
    Quit
}

function Quit
{
    Exit $result
}

StartTests
