Param (
    [Parameter(
        Position=0,
        Mandatory=$true,
        HelpMessage='Tag of the format "vN.N.N"')]
    [ValidateScript({
        If ($_ -match '^v[\d]+\.[\d]+\.[\d]+$') {
            $True
        }else{
            Throw "Value '$_' does not match pattern 'vN.N.N'"
        }
    })]
    [string]$NewVersion
)
$ErrorActionPreference = "Stop"

$NuGetApiKey = [Environment]::GetEnvironmentVariable('NUGET_QFN_API_KEY')
if (!$NuGetApiKey) {
    Write-Error "Env var NUGET_QFN_API_KEY is not set"
    Exit 1
}

$ver = $NewVersion.substring(1) # chop off initial "v"

$rootpath = Join-Path $PSScriptRoot '..' | Resolve-Path
$nugetPath = Join-Path $rootpath 'tmp' 'nuget'

cd $nugetPath
Write-Host "Checking presence of packages: " -ForegroundColor Cyan
$missing = $false
$toPush = @()
foreach ($rls in 'Core', 'FIXT1.1', 'FIX4.0', 'FIX4.1', 'FIX4.2', 'FIX4.3', 'FIX4.4', 'FIX5.0', 'FIX5.0SP1', 'FIX5.0SP2') {
    $nupkg = Join-Path $nugetPath "QuickFIXn.$rls.$ver.nupkg"
    $snupkg = Join-Path $nugetPath "QuickFIXn.$rls.$ver.snupkg"

    foreach ($file in $nupkg, $snupkg) {
        Write-Host -NoNewline "* Looking for $nupkg ... " -ForegroundColor Cyan
        If (Test-Path $nupkg) { 
            Write-Host "Found" -ForegroundColor Green
        } else { 
            # The PSStyle.Reset is to work around a bgcolor-bleeding bug
            Write-Host "Not Found!$($PSStyle.Reset)" -ForegroundColor Black -BackgroundColor Red
            $missing = $true
        }
    }

    $toPush += $nupkg
}

if ($missing) {
    Write-Host 'A package was missing.  Please check output above.' -ForegroundColor Red
    Exit 1
}

Write-Host "==============================================" -ForegroundColor Red
Write-Host "          * * * ATTENTION * * *               " -ForegroundColor Yellow
Write-Host "==============================================" -ForegroundColor Red
Write-Host "I am about to push packages to NuGet.org "
$confirmation = (Read-Host "If you want to proceed, enter 'YES' in all-caps").Trim()
if ($confirmation -cne 'YES') {
    Write-Host "User entered '$confirmation' -- aborting."
    Exit 1
}

Write-Host "Pushing packages to NuGet.org:" -ForegroundColor Cyan
foreach ($filepath in $toPush) {
    Write-Host "* Pushing $(Split-Path $filepath -Leaf) and .snupkg" -ForegroundColor Cyan

    # this command also pushes snupkg if present (which it should be)
    dotnet nuget push $filepath -s 'https://api.nuget.org/v3/index.json' -k $NuGetApiKey
}

Write-Host "NuGet pushes complete!" -ForegroundColor Green
