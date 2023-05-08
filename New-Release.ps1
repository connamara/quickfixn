[CmdletBinding()]
Param (
	[Parameter(Position=0, Mandatory)]
	[string]$TagVersion,

	[Parameter(Position=1, Mandatory)]
	[Alias('AccessKey')]
	[string]$AwsAccessKey,

	[Parameter(Position=2, Mandatory)]
	[Alias('SecretKey')]
	[string]$AwsSecretKey,

	[Parameter(Position=3)]
	[string]$NuGetApiKey,

	[switch]$PushNuGetPackages,

	[switch]$UseWslRuby
)

$QFDir = "quickfixn-$TagVersion"
$BuildTarget = if ($NuGetApiKey) { 'pack' } else { 'build' }
$BuildProps = @('-c', 'Release', @(if ($NuGetApiKey) { @('--include-symbols', '-o', 'tmp\NuGet') }))

Write-Host '--== QuickFIX/n Package Release Script ==--' -ForegroundColor Cyan
Write-Host "`nTag Version: $TagVersion`n"

if ($UseWslRuby -and $UseWslRuby.IsPresent) {
	wsl ruby scripts/update_assembly_version.rb "v$TagVersion" QuickFIXn/QuickFix.csproj Messages/FIX40/QuickFix.FIX40.csproj Messages/FIX41/QuickFix.FIX41.csproj Messages/FIX42/QuickFix.FIX42.csproj Messages/FIX43/QuickFix.FIX43.csproj Messages/FIX44/QuickFix.FIX44.csproj Messages/FIX50/QuickFix.FIX50.csproj Messages/FIX50SP1/QuickFix.FIX50SP1.csproj Messages/FIX50SP2/QuickFix.FIX50SP2.csproj
} else {
	ruby scripts\update_assembly_version.rb "v$TagVersion" QuickFIXn\QuickFix.csproj Messages\FIX40\QuickFix.FIX40.csproj Messages\FIX41\QuickFix.FIX41.csproj Messages\FIX42\QuickFix.FIX42.csproj Messages\FIX43\QuickFix.FIX43.csproj Messages\FIX44\QuickFix.FIX44.csproj Messages\FIX50\QuickFix.FIX50.csproj Messages\FIX50SP1\QuickFix.FIX50SP1.csproj Messages\FIX50SP2\QuickFix.FIX50SP2.csproj
}

$ExitCode = $LASTEXITCODE
if ($ExitCode -eq 0) {
	Write-Host '* QuickFix *.csproj files updated with new version number.'
} else {
	Write-Error 'update_assembly_version.rb FAILED'
	Exit $ExitCode
}

git add QuickFIXn\QuickFix.csproj
git add Messages\FIX40\QuickFix.FIX40.csproj
git add Messages\FIX41\QuickFix.FIX41.csproj
git add Messages\FIX42\QuickFix.FIX42.csproj
git add Messages\FIX43\QuickFix.FIX43.csproj
git add Messages\FIX44\QuickFix.FIX44.csproj
git add Messages\FIX50\QuickFix.FIX50.csproj
git add Messages\FIX50SP1\QuickFix.FIX50SP1.csproj
git add Messages\FIX50SP2\QuickFix.FIX50SP2.csproj
git commit -m "version number for version %TAG_VERSION%"
Write-Host '* Version number committed.'

git tag -a $TagVersion -m 'Release version $TagVersion'
Write-Host '* Created tag.'

git checkout $TagVersion
$ExitCode = $LASTEXITCODE
if ($ExitCode -eq 0) {
	Write-Host "* Checked out tag $TagVersion"
} else {
	Write-Error "There was an error checking out QuickFIX/n $TagVersion"
	Exit $ExitCode
}

if ($UsWslRuby -and $UseWslRuby.IsPresent) {
	wsl ruby generator/generate.rb
} else {
	ruby generator/generate.rb
}

$ExitCode = $LASTEXITCODE
if ($ExitCode -eq 0) {
	Write-Host '* Generated code.'
} else {
	Write-Error "There was an error generating code from the data dictionaries"
	Exit $ExitCode
}

if (Test-Path 'tmp') {
	Get-ChildItem 'tmp' -Recurse | Remove-Item -Recurse -Force > $null
}

dotnet $BuildTarget @BuildProps QuickFIXn.sln
$ExitCode = $LASTEXITCODE
if ($ExitCode -eq 0) {
	Write-Host '* Built QuickFIX/n and created NuGet packages at .\tmp\Nuget'
} else {
	Write-Error "There was an error building and/or packaging QuickFIX/n."
	Exit $ExitCode
}

# DO NOT remove quotes around *.nupkg. Due to a bug in older versions of the .NET SDK,
# without the surrounding quotes, only the first package will be pushed.
if ($BuildTarget -ieq 'pack' -and $PushNuGetPackages -and $PushNuGetPackages.IsPresent) {
	dotnet nuget push '*.nupkg' -s 'https://api.nuget.org/v3/index.json' -k $NuGetApiKey 'tmp\NuGet'

	$ExitCode = $LASTEXITCODE
	if ($ExitCode -eq 0) {
		Write-Host '* Pushed QuickFIX/n NuGet packages to NuGet.org'
	} else {
		Write-Error 'A problem occurred while pushing NuGet packages to NuGet.org'
		Exit $ExitCode
	}
} else {
	Write-Host '* Skipping Nuget package push because -PushNugetPackages was not indicated'
}

@(
	"tmp\$QFDir"
	"tmp\$QFDir\bin"
	"tmp\$QFDir\bin\net6.0"
	"tmp\$QFDir\spec"
	"tmp\$QFDir\spec\fix"
	"tmp\$QFDir\config"
) | ForEach-Object { New-Item -ItemType Directory $_ }

@(
	'QuickFIXn\bin\Release\net6.0\QuickFix.dll',
	'Messages\FIX40\bin\Release\net6.0\QuickFix.FIX40.dll',
	'Messages\FIX41\bin\Release\net6.0\QuickFix.FIX41.dll',
	'Messages\FIX42\bin\Release\net6.0\QuickFix.FIX42.dll',
	'Messages\FIX43\bin\Release\net6.0\QuickFix.FIX43.dll',
	'Messages\FIX44\bin\Release\net6.0\QuickFix.FIX44.dll',
	'Messages\FIX50\bin\Release\net6.0\QuickFix.FIX50.dll',
	'Messages\FIX50SP1\bin\Release\net6.0\QuickFix.FIX50SP1.dll',
	'Messages\FIX50SP2\bin\Release\net6.0\QuickFix.FIX50SP2.dll'
) | ForEach-Object {
	$Filename = Split-Path $_ -Leaf
	Copy-Item -Path $_ -Destination "tmp\$QFDir\bin\net6.0\$Filename"
}

Copy-Item -Path 'spec\fix' -Destination "tmp\$QFDir\spec\fix" -Recurse -Force

Copy-Item -Path 'config\*.cfg' -Destination "tmp\$QFDir\config"
Copy-Item -Path 'RELEASE_README.md' -Destination "tmp\$QFDir\README.md"
@('LICENSE', 'RELEASE_NOTES.md') | ForEach-Object { Copy-Item -Path $_ -Destination "tmp\$QFDir" }
Write-Host '* Copied files to ''tmp'' directory.'

Compress-Archive -CompressionLevel Optimal -Path ".\tmp\$QFDir" -DestinationPath "$QFDir.zip" -Force
Write-Host '* Created zip.'

if ($UseWslRuby -and $UseWslRuby.IsPresent) {
	wsl ruby scripts\s3_upload.rb "$QFDir.zip" $AwsAccessKey $AwsSecretKey
} else {
	ruby scripts\s3_upload.rb "$QFDir.zip" $AwsAccessKey $AwsSecretKey
}

$ExitCode = $LASTEXITCODE
if ($ExitCode -eq 0) {
	Write-Host '* Uploaded zip.'
} else {
	Write-Error "There was an error uploading $QFDir.zip into Amazon S3"
	Exit $ExitCode
}

Get-ChildItem -Path 'tmp' -Recurse | Remove-Item -Recurse -Force
Write-Host '* Removed ''tmp'' directory.'

git checkout master
Write-Host '* Changed back to master.'

Write-Host "`nSuccessfully created QuickFIX/n $TagVersion" -ForegroundColor Green
Write-Host "You can download the zip here: https://quickfix.s3.amazonaws.com/$QFDir.zip"
if ($NuGetApiKey) {
	Write-Host "Alternatively, you can download the NuGet packages from NuGet.org."
}
Write-Host "You must commit the new tag and deploy the website"

Exit 0
