Param (
	[Parameter(Position=0, ValueFromPipeline)]
	[ValidateSet('debug','release')]
	[string[]]$Configuration = 'release'
)

foreach ($c in $Configuration) {
	Write-Host "Running unit tests with config: $Configuration"
	dotnet test -c $Configuration --no-build --no-restore UnitTests --logger trx
}

