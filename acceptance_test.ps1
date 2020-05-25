$return_value=0
$success_string="`r`nTest Suite Results:"

function TestSpec
{
    param(
     [Parameter(Mandatory=$True,Position=0)]
      [string]$configuration,
	
     [Parameter(Mandatory=$True,Position=1)]
      [string]$framework,
	
     [Parameter(Mandatory=$True,Position=2)]
     [string]$port,

    [Parameter(Mandatory=$True,Position=3)]
     [string]$def,

    [Parameter(Mandatory=$True,Position=4)]
     [string]$conf,

    [Parameter(Mandatory=$True,Position=5)]
     [string]$dest
    )
    if(Test-Path TestResult.xml){ Remove-Item TestResult.xml }

    $Command = ".\runat.ps1 $configuration $port $def $conf $framework"
    Invoke-Expression $Command

    if($LASTEXITCODE -ne 0){ $script:return_value = $script:return_value + 1 }
    $result = "$dest tests result:$LASTEXITCODE"
    echo $result
    $script:success_string = $script:success_string + "`r`n`t$result"
    Copy-Item TestResult.xml -Destination $dest
}

function RunSuite
{
    param(
     [Parameter(Mandatory=$True,Position=0)]
      [string]$configuration,
	
     [Parameter(Mandatory=$True,Position=1)]
      [string]$framework
    )   

    # Fix 40
    TestSpec $configuration $framework "5001" "definitions/server/fix40/*.def" "cfg/at_40.cfg" "AcceptanceTests_40_$framework.xml"

    # Fix 41
    TestSpec $configuration $framework "5002" "definitions/server/fix41/*.def" "cfg/at_41.cfg" "AcceptanceTests_41_$framework.xml"
    
    # Fix 42
    TestSpec $configuration $framework "5003" "definitions/server/fix42/*.def" "cfg/at_42.cfg" "AcceptanceTests_42_$framework.xml"

    # Fix 43    
    TestSpec $configuration $framework "5004" "definitions/server/fix43/*.def" "cfg/at_43.cfg" "AcceptanceTests_43_$framework.xml"
    
    # Fix 44
    TestSpec $configuration $framework "5005" "definitions/server/fix44/*.def" "cfg/at_44.cfg" "AcceptanceTests_44_$framework.xml"

    # Fix 44 No Reset
    TestSpec $configuration $framework "5005" "definitions/server/fix44noreset/*.def" "cfg/at_44_noreset.cfg" "AcceptanceTests_44_noreset_$framework.xml"

    # Fix 50
    TestSpec $configuration $framework "5006" "definitions/server/fix50/*.def" "cfg/at_50.cfg" "AcceptanceTests_50_$framework.xml"
    
    # Fix 50sp1
    TestSpec $configuration $framework "5007" "definitions/server/fix50sp1/*.def" "cfg/at_50_sp1.cfg" "AcceptanceTests_50_SP1_$framework.xml"
    
    # Fix 50sp2
    TestSpec $configuration $framework "5008" "definitions/server/fix50sp2/*.def" "cfg/at_50_sp2.cfg" "AcceptanceTests_50_SP2_$framework.xml"
	
    # Misc
    TestSpec $configuration $framework "5003" "definitions/server/misc/*.def" "cfg/at_42.misc.cfg" "AcceptanceTests_Misc_$framework.xml"
}

Push-Location -Path "AcceptanceTest" -StackName AcceptanceTest
    
    Remove-Item AcceptanceTests_*.xml

    RunSuite "release" "net461"

    RunSuite "release" "netcoreapp2.0"

Pop-Location -StackName AcceptanceTest

echo $success_string

echo "Script returns: $return_value"
echo "(0 means success)"
Exit $return_value
