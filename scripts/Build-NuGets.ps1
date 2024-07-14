if ($args.Length -gt 0) {
    Write-Error "This script does not take any parameters."
    Write-Error "The version number comes from the project files, which are updated by Build-NuGets.ps1"
    Exit 1
}

$ErrorActionPreference = "Stop"

$rootpath = Join-Path $PSScriptRoot '..' | Resolve-Path
$nugetOutPath = Join-Path $rootpath 'tmp' 'nuget'

cd $rootpath
dotnet pack -c Release --include-symbols -o $nugetOutPath ./QuickFIXn.sln

if ($LastExitCode -eq 0) {
    Write-Host '* Built QuickFIX/n NuGet packages' -ForegroundColor Cyan
} else {
    Write-Error "There was an error building QuickFIX/n."
    Exit $ExitCode
}

Write-Host "* Created NuGet packages in $nugetOutPath" -ForegroundColor Cyan

Write-Host "NuGet packages created successfully" -ForegroundColor Green
