if ($args.Length -gt 0) {
    Write-Error "This script does not take any parameters."
    Exit 1
}

$rootpath = Join-Path $PSScriptRoot '..' | Resolve-Path

$isErr = $false

$fieldFiles = @(
    Join-Path $rootpath QuickFIXn Fields Fields.cs
    Join-Path $rootpath QuickFIXn Fields FieldTags.cs
)

$messagePath = Join-Path $rootpath Messages FIX* *cs
$messageFiles = $messagePath | Resolve-Path




Write-Host '--Deleting generated code--' -ForegroundColor Cyan
Write-Host 'Field definition files:' -ForegroundColor Cyan

foreach ($file in $fieldFiles) {
    Write-Host "* Attempting to delete file: $file" -ForegroundColor Cyan
    if (Test-Path $file) {
        Remove-Item $file
    } else {
        Write-Host '  WARNING: File does not exist' -ForegroundColor Red
        $isErr = $true
    }
}

Write-Host 'Message definition files:' -ForegroundColor Cyan

if ($messageFiles.Count -eq 0) {
    Write-Host "  WARNING: '$messagePath' has no matches." -ForegroundColor Red
    $isErr = $true
} else {
    Remove-Item $messageFiles
    Write-Host "* All '$messagePath' files are deleted." -ForegroundColor Cyan
}

if ($isErr) {
  Write-Host -ForegroundColor Red "---"
  Write-Host -ForegroundColor Red "GENERAL ERROR: Not all expected files were found, but all that *were* found were deleted."
  Write-Host -ForegroundColor Red "  This may be ok, for instance, if you ran this script multiple times in a row."
  Write-Host -ForegroundColor Red "  This should *not* happen on a fresh checkout, or right after running the generator."
  Write-Host -ForegroundColor Red "  Users of this script must evaluate this result accordingly."
}

Write-Host -ForegroundColor Green "Deletion complete."
