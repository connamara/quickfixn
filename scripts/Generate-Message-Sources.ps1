if ($args.Length -gt 0) {
    Write-Error "This script does not take any parameters."
    Exit 1
}

$rootpath = Join-Path $PSScriptRoot '..' | Resolve-Path

$specs = Join-Path $rootpath spec fix *xml | Resolve-Path

pushd (Join-Path $rootpath DDTool)
dotnet run --project DDTool --outputdir $rootpath $specs
popd
