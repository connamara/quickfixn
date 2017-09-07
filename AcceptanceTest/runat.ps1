
Param(
  [Parameter(Mandatory=$True,Position=1)]
   [string]$release,
	
  [Parameter(Mandatory=$True,Position=2)]
   [string]$port,

  [Parameter(Position=3)]
   [string]$tests=$null,

  [Parameter(Position=4)]
    [string] $conf= "cfg\at.cfg",

[Parameter(Mandatory=$True,Position=5)]
    [string]$reportPath
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
    Start-Process -FilePath setup.bat -ArgumentList $port -NoNewWindow -Wait

    $arguments = @("run", "-f", "netcoreapp1.1", "-c", "Release", "--no-build", "--no-restore", "--", $conf)
    $p = Start-Process -FilePath "dotnet" -ArgumentList $arguments -NoNewWindow -PassThru

    Invoke-Expression -Command "ruby Runner.rb 127.0.0.1 $port $tests > $reportPath"

    Stop-Process -Id $p.Id -Force

    if($LASTEXITCODE -eq 1){ $script:result = 1 }
       
    type $reportPath
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
