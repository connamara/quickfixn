<#
This file will run unit tests and produce a .trx file as well as code coverage reporting.

When using --logger the coverage.cobertura.xml file is written twice - once in TestResults/{GUID}
and once in TestResults/{TRXFILENAME} where TRXFILENAME is the name of the generated .trx file
(see https://github.com/microsoft/vstest/issues/2334).

After generating the html coverage report in TestResults/{TRXFILENAME}/CoverageReport we then delete
the TestResults/{GUID} directory containing the duplicate xml to keep things a bit cleaner.
#>

Param (
	[Parameter(Position=0, ValueFromPipeline)]
	[ValidateSet('debug','release')]
	[string]$Configuration = 'release'
)


# Run the unit tests and store the console output in $TestOutput.
dotnet test -c $Configuration --logger trx --settings UnitTests/coverlet.runsettings | Tee-Object -variable TestOutput

# Find the string 
# "Results File: C:\[...]\gitrepos\quickfixn\UnitTests\TestResults\[...].trx"
# in the output and extract the filepath.
$TrxFilePath = $TestOutput | Select-String .trx | Select -First 1 | %{$_.Line.TrimStart("Results File: ")}

# Remove the ".trx" extension to get path of the generated directory
$TestRunDirPath = $TrxFilePath.Substring(0, $TrxFilePath.Length - 4)

# Generate the html report in the generated directory whose name matches the .trx file.
# The reportgenerator version should match that specified in UnitTests.csproj.
&"$env:UserProfile\.nuget\packages\reportgenerator\5.1.19\tools\net6.0\ReportGenerator.exe" -reports:"$TestRunDirPath\**\coverage.cobertura.xml" -targetdir:"$TestRunDirPath\CoverageReport" -historydir:UnitTests\TestResults\CoverageHistory

# Find the duplicate generated coverage filepaths from the output and delete their directories,
# e.g. extract the string
# "C:\[...]\gitrepos\quickfixn\UnitTests\TestResults\71e26483-0757-48ab-9b0c-8b35a62ec891\coverage.cobertura.xml"
# and then delete the directory
# C:\[...]\gitrepos\quickfixn\UnitTests\TestResults\71e26483-0757-48ab-9b0c-8b35a62ec891
$TestOutput | Select-String coverage.cobertura.xml | ForEach-Object { [System.IO.Path]::GetDirectoryName($_.Line.Trim()) } | Remove-Item -Recurse