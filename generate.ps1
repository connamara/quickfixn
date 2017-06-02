# see: http://stackoverflow.com/questions/29147715/make-visualstudio-run-a-command-to-generate-c-sharp-code

$specPath = [string]"spec/tmp/" # spec/fix

function Load-Template()
{
  param($path, [int]$tabcount)
  $lines = @()
  Get-Content -Path $path | ForEach-Object {
    $lines += TabinateLine $_ $tabcount
  }
  Join-Lines $lines
}

function TabinateLine()
{
  param($line, [int]$tabcount)
  if ($line.StartsWith("<#")) { return $line }
  [string]$sb = [string]""
  For ($i = 0; $i -lt $tabcount; $i++) {
    [string]$sb += [string]"    "
  }
  [string]$sb += [string]$line
  $sb
}

# takes in array of lines, outputs array of lines tabinated
function Tabinate()
{
  param($data, [int]$tabcount)
  $out = @()
  $lines = @()
  if ([int]$data.Count -eq 1) {
    $lines += $data
  } else {
    $lines = $data
  }
  $lines | ForEach-Object {
    $out += TabinateLine $_ $tabcount
  }
  $out
}

function Join-Lines()
{
  param($arr)
  [string]($arr -join "`n")
}

function Fix-Version()
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
  [string]$fixVersion = Fix-Version $dd
  [string]$template = Load-Template QuickFIXn/Templates/Message.cst 0
  [string]$code = $template -replace "<%version%>", $fixVersion
  [string]$path = [string]::Format("QuickFIXn/Message/{0}/Message.cs", $fixVersion)
  WriteCode $path $code
}

function GenerateMessageTypeCases()
{
  param($dd)
  [string]$fixVersion = Fix-Version $dd
  $cases = @()
  $dd.messages.message | ForEach-Object {
    [string]$msgName = $_.name
    $case = [string]::Format("case QuickFix.{0}.{1}.MsgType: return new QuickFix.{0}.{1}();", $fixVersion, $msgName)
    $out = Tabinate $case 5
    $cases += Join-Lines $out
  }
  Join-Lines $cases
}

function BuildGroupCases()
{
    param([string]$fixVersion, [string]$namespace, $o)
    $cases = @()
    $groups = @()
    if ($o.group -ne $null) {
      if ($o.group.Count -gt 0) {
        $groups = $o.group
      } else {
        $groups += $o.group
      }
    }
    if ($groups.Count -gt 0) {
      $groups | ForEach-Object {
        $g = $_
        $case = [string]::Format("case QuickFix.Fields.Tags.{2}: return new QuickFix.{0}.{1}.{2}Group();", $fixVersion, $namespace, $g.name)
        $cases += $case
        $recursiveNamespace = [string]::Format("{0}.{1}Group", $namespace, $g.name)
        $r = BuildGroupCases $fixVersion $recursiveNamespace $g
        if ($r.Count -gt 0) {
            $cases += $r
        }
      }
    }
    $cases
}

function GenerateMessageGroups()
{
  param($dd)
  [string]$fixVersion = Fix-Version $dd
  [string]$template = Load-Template QuickFIXn/Templates/MessageGroup.cst 4
  $template = $template -replace "<#version#>", $fixVersion
  $out = @()
  $dd.messages.message | ForEach-Object {
    $cases = BuildGroupCases $fixVersion $_.name $_
    if ($cases.Count -gt 0) {
        $msgTemplate = $template -replace "<#msgName#>", $_.name
        $out += ($msgTemplate -replace "<#msgGroupCases#>", (Join-Lines (Tabinate $cases 6)))
        $out += ""
    }
  }
  Join-Lines $out
}

function GenerateMessageFactoryClass()
{
  param($dd)
  [string]$fixVersion = Fix-Version $dd
  [string]$template = Load-Template QuickFIXn/Templates/MessageFactory.cst 0
  [string]$code = $template -replace "<#version#>", $fixVersion
  $msgTypeCases = GenerateMessageTypeCases $dd
  [string]$code = $code -replace "<#msgTypeCases#>", $msgTypeCases
  $createMsgGroups = GenerateMessageGroups $dd
  [string]$code = $code -replace "<#createMessageGroups#>", $createMsgGroups
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
