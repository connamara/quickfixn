Param (
    [ValidateSet('debug','release')]
    [string]$Configuration = 'release',

    [switch]$UseWsl
)

$rootpath = Join-Path $PSScriptRoot '..' | Resolve-Path

$ReturnValue=0
$SuiteResults = @()

function TestSpec
{
    param(
        [Parameter(Mandatory, Position=0)]
        [string]$configuration,

        [Parameter(Mandatory, Position=1)]
        [string]$Framework,

        [Parameter(Mandatory, Position=2)]
        [ValidateRange(1, 65535)]
        [int]$Port,

        [Parameter(Mandatory, Position=3)]
        [string]$Def,

        [Parameter(Mandatory, Position=4)]
        [string]$Conf,

        [Parameter(Mandatory, Position=5)]
        [string]$Dest,

        [switch]$UseWsl
    )

    Write-Host -ForegroundColor Cyan "====="
    Write-Host -ForegroundColor Cyan "Launching AT for result file $Dest"

    .\runat.ps1 $Configuration $Port "$Def" "$Conf" $Framework -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

    if ($LASTEXITCODE -ne 0) {
        $Script:ReturnValue += 1
    }

    if (Test-Path TestResult.xml) {
        Move-Item TestResult.xml -Destination $Dest
    }

    $Script:SuiteResults += "$Dest tests result: $LASTEXITCODE"
}

function RunSuite
{
    param(
        [Parameter(Mandatory, Position=0)]
        [ValidateSet('debug','release')]
        [string]$Configuration,

        [Parameter(Mandatory, Position=1, ValueFromPipeline)]
        [ValidateSet('net6.0','net461','netcoreapp2.1')]
        [string[]]$Framework,

        [switch]$UseWsl
    )

    process {
        foreach ($f in $Framework) {

            # Fix 40
            TestSpec $Configuration $f 5001 "definitions/server/fix40/*.def" "cfg/at_40.cfg" "AcceptanceTests_40_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Fix 41
            TestSpec $Configuration $f 5002 "definitions/server/fix41/*.def" "cfg/at_41.cfg" "AcceptanceTests_41_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Fix 42
            TestSpec $Configuration $f 5003 "definitions/server/fix42/*.def" "cfg/at_42.cfg" "AcceptanceTests_42_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Fix 43
            TestSpec $Configuration $f 5004 "definitions/server/fix43/*.def" "cfg/at_43.cfg" "AcceptanceTests_43_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Fix 44
            TestSpec $Configuration $f 5005 "definitions/server/fix44/*.def" "cfg/at_44.cfg" "AcceptanceTests_44_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Fix 44 No Reset
            TestSpec $Configuration $f 5005 "definitions/server/fix44noreset/*.def" "cfg/at_44_noreset.cfg" "AcceptanceTests_44_noreset_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Fix 50
            TestSpec $Configuration $f 5006 "definitions/server/fix50/*.def" "cfg/at_50.cfg" "AcceptanceTests_50_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Fix 50sp1
            TestSpec $Configuration $f 5007 "definitions/server/fix50sp1/*.def" "cfg/at_50_sp1.cfg" "AcceptanceTests_50_SP1_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Fix 50sp2
            TestSpec $Configuration $f 5008 "definitions/server/fix50sp2/*.def" "cfg/at_50_sp2.cfg" "AcceptanceTests_50_SP2_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)

            # Misc
            TestSpec $Configuration $f 5003 "definitions/server/misc/*.def" "cfg/at_42.misc.cfg" "AcceptanceTests_Misc_$f.xml" -UseWsl:$($UseWsl -and $UseWsl.IsPresent)
        }
    }
}

try {
    Write-Host -ForegroundColor Cyan "Launching acceptance tests..."

    Push-Location -Path (Join-Path $rootpath AcceptanceTest)

    Remove-Item AcceptanceTests_*.xml

    'net6.0' | RunSuite -Configuration $Configuration -UseWsl:$($UseWsl -and $UseWsl.IsPresent)
} finally {
    Pop-Location

    Write-Host -ForegroundColor Yellow "Test Suite Results:"
    foreach ($result in $SuiteResults) {
        $color = If ($result -match "0$") {"Green"} Else {"Red"}
        Write-Host -ForegroundColor $color "    $result"
    }
    Write-Host ""

    if ($ReturnValue -eq 0) {
        Write-Host -ForegroundColor Green "Success!  All tests passed."
    } else {
        Write-Host -ForegroundColor Red "Failures detected.  Check the output above."
    }
    Write-Host ""
}

Exit $ReturnValue
