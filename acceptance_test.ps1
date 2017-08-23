$return_value=0
$success_string="`r`nTest Suite Results:"

function TestSpec
{
    param(
     [Parameter(Mandatory=$True,Position=0)]
      [string]$release,
	
     [Parameter(Mandatory=$True,Position=1)]
     [string]$port,

    [Parameter(Mandatory=$True,Position=2)]
     [string]$def,

    [Parameter(Mandatory=$True,Position=3)]
     [string]$conf,

    [Parameter(Mandatory=$True,Position=4)]
     [string]$dest
    )
    if(Test-Path TestResult.xml){ Remove-Item TestResult.xml }

    Invoke-Expression ".\runat.ps1 $release $port $def $conf"
    
    if($LASTEXITCODE -eq 1){ $script:return_value = $script:return_value + 1 }
    $result = "$dest tests result:$LASTEXITCODE"
    echo $result
    $script:success_string = $script:success_string + "`r`n`t$result"
    Copy-Item TestResult.xml -Destination $dest
}

Push-Location -Path "AcceptanceTest" -StackName AcceptanceTest
    
    Remove-Item AcceptanceTests_*.xml

    # Fix 40
    TestSpec "release" "5001" "definitions/server/fix40/*.def" "cfg/at_40.cfg" "AcceptanceTests_40.xml"

    # Fix 41
    TestSpec "release" "5002" "definitions/server/fix41/*.def" "cfg/at_41.cfg" "AcceptanceTests_41.xml"
    
    # Fix 42
    TestSpec "release" "5003" "definitions/server/fix42/*.def" "cfg/at_42.cfg" "AcceptanceTests_42.xml"

    # Fix 43    
    TestSpec "release" "5004" "definitions/server/fix43/*.def" "cfg/at_43.cfg" "AcceptanceTests_43.xml"
    
    # Fix 44
    TestSpec "release" "5005" "definitions/server/fix44/*.def" "cfg/at_44.cfg" "AcceptanceTests_44.xml"

    # Fix 44 No Reset
    TestSpec "release" "5005" "definitions/server/fix44noreset/*.def" "cfg/at_44_noreset.cfg" "AcceptanceTests_44_noreset.xml"

    # Fix 50
    TestSpec "release" "5006" "definitions/server/fix50/*.def" "cfg/at_50.cfg" "AcceptanceTests_50.xml"
    
    # Fix 50sp1
    TestSpec "release" "5007" "definitions/server/fix50sp1/*.def" "cfg/at_50_sp1.cfg" "AcceptanceTests_50_SP1.xml"
    
    # Fix 50sp2
    TestSpec "release" "5008" "definitions/server/fix50sp2/*.def" "cfg/at_50_sp2.cfg" "AcceptanceTests_50_SP2.xml"
	
    # Misc
    TestSpec "release" "5003" "definitions/server/misc/*.def" "cfg/at_42.misc.cfg" "AcceptanceTests_Misc.xml"

Pop-Location -StackName AcceptanceTest

echo $success_string

echo "Script returns: $return_value"
echo "(0 means success)"
Exit $return_value
