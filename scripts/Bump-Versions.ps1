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


$projs = @(
    Join-Path 'QuickFIXn' 'QuickFix.csproj'
)
foreach($rls in '40','41','42','43','44','50','50SP1','50SP2','T11') {
    $projs += Join-Path 'Messages' "FIX$rls" "QuickFix.FIX$rls.csproj"
}


$newver = $NewVersion.substring(1) # chop off initial "v"

foreach($proj in $projs) {
    $path = Join-Path $PSScriptRoot ".." $proj | Resolve-Path
    Write-Host "Updating version in $path" -ForegroundColor DarkGray

    (Get-Content $path) -replace '<Version>[^<]*<\/Version>', "<Version>$newver</Version>" |
        Out-File $path
}

Write-Host 'Bump-Version completed successfully.' -ForegroundColor Green
Write-Host '(Don''t forget to commit these csproj changes after reviewing.)' -ForegroundColor Green



#-----------------------
# Not yet sure if I want the rest of this in a script or not


#git tag -a $TagVersion -m 'Release version $TagVersion'
#Write-Host '* Created tag.'

#git checkout -c advice.detachedHead=false $TagVersion
#$ExitCode = $LASTEXITCODE
#if ($ExitCode -eq 0) {
#    Write-Host "* Checked out tag $TagVersion"
#} else {
#    Write-Error "There was an error checking out QuickFIX/n $TagVersion"
#    Exit $ExitCode
#}