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

$rootpath = Join-Path $PSScriptRoot '..' | Resolve-Path
$zipContentPath = Join-Path $rootpath 'tmp' 'zip' "quickfixn-$NewVersion"
$zipOutPath = Join-Path $rootpath 'tmp' 'zip' "quickfixn-$NewVersion.zip"

cd $rootpath
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

@(
	"bin"
	"bin\net6.0"
	"spec"
	"spec\fix"
	"config"
) | ForEach-Object {
    $d = Join-Path $zipContentPath $_
    New-Item -ItemType Directory $d > $null
}

@(
	'QuickFIXn\bin\Release\net6.0\QuickFix.dll',
	'Messages\FIXT11\bin\Release\net6.0\QuickFix.FIXT11.dll',
	'Messages\FIX40\bin\Release\net6.0\QuickFix.FIX40.dll',
	'Messages\FIX41\bin\Release\net6.0\QuickFix.FIX41.dll',
	'Messages\FIX42\bin\Release\net6.0\QuickFix.FIX42.dll',
	'Messages\FIX43\bin\Release\net6.0\QuickFix.FIX43.dll',
	'Messages\FIX44\bin\Release\net6.0\QuickFix.FIX44.dll',
	'Messages\FIX50\bin\Release\net6.0\QuickFix.FIX50.dll',
	'Messages\FIX50SP1\bin\Release\net6.0\QuickFix.FIX50SP1.dll',
	'Messages\FIX50SP2\bin\Release\net6.0\QuickFix.FIX50SP2.dll'
) | ForEach-Object {
    $fullpath = Join-Path $rootpath $_ | Resolve-Path
	$filename = Split-Path $fullpath -Leaf
    $topath = Join-Path $zipContentPath $filename
	Copy-Item -Path $_ -Destination $topath
    Write-Host "* Copied file to $fullpath" -ForegroundColor Cyan
}

$dest = Join-Path $zipContentPath 'spec\fix' | Resolve-Path
Copy-Item -Path (Join-Path $rootpath 'spec\fix' | Resolve-Path) -Destination $dest -Recurse -Force
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