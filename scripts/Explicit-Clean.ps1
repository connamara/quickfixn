if ($args.Length -gt 0) {
    Write-Error "This script does not take any parameters."
    Exit 1
}

# `dotnet clean` is pretty disappointing.  It doesn't delete all the bin and obj dirs!
# So I wrote this to do the job, and delete store dirs also.


$rootpath = Join-Path $PSScriptRoot '..' | Resolve-Path

@(
    "AcceptanceTest",
    "DDTool\DDTool",
    "DDTool\UnitTests",
    "Examples\Executor",
    "Examples\FixToJson",
    "Examples\JsonToFix",
    "Examples\SimpleAcceptor",
    "Examples\Standalone\SerilogLog",
    "Examples\Standalone\SerilogLog\UnitTests",
    "Examples\TradeClient",
    "Messages\FIX40",
    "Messages\FIX41",
    "Messages\FIX42",
    "Messages\FIX43",
    "Messages\FIX44",
    "Messages\FIX50",
    "Messages\FIX50SP1",
    "Messages\FIX50SP2",
    "Messages\FIXT11",
    # Don't include "QuickFIXn" because there is a "Store" source dir!
    "UnitTests"
) | ForEach-Object {

    $projPath = Join-Path $rootpath $_

    $binPath = Join-Path $projPath 'bin'
    $objPath = Join-Path $projPath 'obj'
    $storePath = Join-Path $projPath 'store'

    if (Test-Path -Path $binPath) {
        Remove-Item -Recurse -Force $binPath
    }
    if (Test-Path -Path $objPath) {
        Remove-Item -Recurse -Force $objPath
    }
    if (Test-Path -Path $storePath) {
        Remove-Item -Recurse -Force $storePath
    }

    Write-Host "* Cleaned $projPath"
}

@(
    "QuickFIXn/bin",
    "QuickFIXn/obj"
) | ForEach-Object {
    $delPath = Join-Path $rootpath $_
    if (Test-Path -Path $delPath) {
        Remove-Item -Recurse -Force $delPath
    }
    Write-Host "* Deleted $delPath"
}


Write-Host "Finished."

