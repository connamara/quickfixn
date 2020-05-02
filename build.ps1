Param (
	[Parameter(Position=0, ValueFromPipeline)]
	[ValidateSet('debug','release')]
	[string[]]$Configuration = 'release'
)

foreach ($c in $Configuration) {
	dotnet build -c $Configuration
}