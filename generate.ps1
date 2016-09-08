# see: http://stackoverflow.com/questions/29147715/make-visualstudio-run-a-command-to-generate-c-sharp-code

$specPath = [string]"spec/tmp/" # spec/fix

function Tabinate()
{
  param($line, $tabs)
  $line
}

function FixVersion()
{
  param($dataDictionary)
  [string] $fixType = if ([string]::IsNullOrEmpty($dataDictionary.type)) { "FIX" } else { $dataDictionary.type }
  [string] $versionPrefix = [string]::Format("{0}{1}{2}", $fixType, $dataDictionary.major, $dataDictionary.minor)
  [string] $fixVersion = if ([string]::IsNullOrEmpty($dataDictionary.servicepack) -or $dataDictionary.servicepack -eq "0") { $versionPrefix } else { [string]::Format("{0}SP{1}", $versionPrefix, $dataDictionary.servicepack) }
  $fixVersion
}

function WriteCode()
{
  param($path, $code)
  [string]$warning = "// This is a generated file.  Don't edit it directly!`n`n";
  [string]$out = [string]::Format("{0}{1}`n", $warning, $code)
  $status = New-Item $path -type file -force -value $out
}

function GenerateMessageClass()
{
  param($dd)
  [string]$fixVersion = FixVersion $dd
  [string]$template = (Get-Content -Path QuickFIXn/Templates/Message.cst) -join "`n"
  [string]$code = $template -replace "<%version%>", $fixVersion
  [string]$path = [string]::Format("QuickFIXn/Message/{0}/Message.cs", $fixVersion)
  WriteCode $path $code
}

function GenerateMessageTypeCases()
{
  param($dd)
  [string]$fixVersion = FixVersion $dd
  $sb = New-Object -TypeName "System.Text.StringBuilder"
  $dd.messages.message | ForEach-Object {
    [string]$msgName = $_.name
    $case = [string]::Format("`ncase QuickFix.{0}.{1}.MsgType: return new QuickFix.{0}.{1}();", $fixVersion, $msgName)
    [string]$out = Tabinate $case 8
    Write-Host $out
    $sb.Append($out)
  }
  $sb.ToString()
}

function GenerateMessageFactoryClass()
{
  param($dd)
  [string]$fixVersion = FixVersion $dd
  [string]$template = (Get-Content -Path QuickFIXn/Templates/MessageFactory.cst) -join "`n"
  [string]$code = $template -replace "<#version#>", $fixVersion
  $msgTypeCases = GenerateMessageTypeCases $dd
  [string]$code = $code -replace "<#msgTypeCases#>", $msgTypeCases
  [string]$code = $code -replace "<#createGroups#>", ""
  [string]$path = [string]::Format("QuickFIXn/Message/{0}/MessageFactory.cs", $fixVersion)
  WriteCode $path $code
}

function GenerateMessageClasses()
{

}

Get-ChildItem $specPath | ForEach-Object {
  [xml]$xml = Get-Content -Path $specPath$_
  $dataDictionary = $xml.fix
  GenerateMessageClass $dataDictionary
  GenerateMessageFactoryClass $dataDictionary
}
