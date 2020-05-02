Param (
	[Parameter(HelpText='Generating a data dictionary uses Ruby. This parameter allows you to use an installation of Ruby in a WSL instance.')]
	[switch]$UseWSL,

	[Parameter(HelpText='Allows you to specify the WSL distribution to use. If not provided, the default distro will be used.')]
	[string]$Distro
)

function Build-DataDictionary {
	Params (
		[switch]$UseWSL,

		[string]$Distro
	)

	Process {
		if ($UseWSL -and $UseWSL.IsPresent)
		{
			if ($Distro) {
				wsl -d "$Distro" ruby ./generator/generate.rb
			} else {
				wsl ruby ./generator/generate.rb
			}
		} else {
			ruby ./generator/generate.rb
		}
	}
}