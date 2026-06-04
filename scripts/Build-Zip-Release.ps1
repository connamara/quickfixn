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

$dotNetVers = 'net8.0','net10.0'

$rootPath = Join-Path $PSScriptRoot '..' | Resolve-Path
$zipContentPath = Join-Path $rootPath 'tmp' 'zip' "quickfixn-$NewVersion"
$zipOutPath = Join-Path $rootPath 'tmp' 'zip' "quickfixn-$NewVersion.zip"

cd $rootPath
dotnet build -c Release ./QuickFIXn.sln

if ($LastExitCode -eq 0) {
    Write-Host '* Built QuickFIX/n solution' -ForegroundColor Cyan
} else {
    Write-Error "There was an error building QuickFIX/n."
    Exit $LastExitCode
}

if (Test-Path $zipContentPath) {
    # empty it
    Get-ChildItem 'tmp' -Recurse | Remove-Item -Recurse -Force > $null
}else{
    New-Item -ItemType Directory -Path $zipContentPath > $null
}



$dirsToCreate = @(
    "bin"
    "spec"
    "spec\fix"
    "config"
)
foreach($dnv in $dotNetVers) {
    $dirsToCreate += "bin\$dnv"
}
foreach($dir in $dirsToCreate) {
    $d = Join-Path $zipContentPath $dir
    New-Item -ItemType Directory $d > $null
}



foreach($dnv in $dotNetVers) {
    @(
        "QuickFIXn\bin\Release\$dnv\QuickFix.dll",
        "Messages\FIXT11\bin\Release\$dnv\QuickFix.FIXT11.dll",
        "Messages\FIX40\bin\Release\$dnv\QuickFix.FIX40.dll",
        "Messages\FIX41\bin\Release\$dnv\QuickFix.FIX41.dll",
        "Messages\FIX42\bin\Release\$dnv\QuickFix.FIX42.dll",
        "Messages\FIX43\bin\Release\$dnv\QuickFix.FIX43.dll",
        "Messages\FIX44\bin\Release\$dnv\QuickFix.FIX44.dll",
        "Messages\FIX50\bin\Release\$dnv\QuickFix.FIX50.dll",
        "Messages\FIX50SP1\bin\Release\$dnv\QuickFix.FIX50SP1.dll",
        "Messages\FIX50SP2\bin\Release\$dnv\QuickFix.FIX50SP2.dll"
    ) | ForEach-Object {
        $toPath = Join-Path $zipContentPath 'bin' $dnv
    
        $dllPath = Join-Path $rootPath $_ | Resolve-Path
        Copy-Item $_ -Destination $toPath
        Write-Host "* Copied $dllPath to $toPath" -ForegroundColor Cyan
    
        $debugPath = ($dllPath -replace 'dll', 'pdb')
        Copy-Item $debugPath -Destination $toPath
        Write-Host "* Copied $debugpath to $toPath" -ForegroundColor Cyan
    }
}

$dest = Join-Path $zipContentPath 'spec\fix' | Resolve-Path
Copy-Item -Path (Join-Path $rootPath 'spec' 'fix' 'FIX*.xml' ) -Destination $dest
Write-Host "* Copied xml dictionaries to $dest" -ForegroundColor Cyan

$dest = Join-Path $zipContentPath 'config'
Copy-Item -Path 'config\*.cfg' -Destination $dest
Write-Host "* Copied cfg files to $dest" -ForegroundColor Cyan

$dest = Join-Path $zipContentPath 'README.md'
Copy-Item -Path 'RELEASE_README.md' -Destination $dest
Write-Host "* Copied RELEASE_README.md to $dest (yes, this is a filename-change)" -ForegroundColor Cyan

@('LICENSE', 'RELEASE_NOTES.md') | ForEach-Object {
    Copy-Item -Path $_ -Destination $zipContentPath
    Write-Host "* Copied $_ to $zipContentPath"  -ForegroundColor Cyan
}

Compress-Archive -CompressionLevel Optimal -Path $zipContentPath -DestinationPath $zipOutPath -Force
Write-Host "* Created zip $zipOutPath"  -ForegroundColor Cyan

Write-Host "Zip created successfully" -ForegroundColor Green
