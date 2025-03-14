.PHONY: pack publish

generate:
	pwsh scripts/Generate-Message-Sources.ps1

pack:
	dotnet pack -c Release

PKG_VERSION=1.11.111

publish: pack
	dotnet nuget push QuickFIXn/bin/Release/ArtexFIX.Core.$(PKG_VERSION).nupkg  --source https://api.nuget.org/v3/index.json --api-key $(NUGET_API_KEY)
	dotnet nuget push Messages/FIXT11/bin/Release/ArtexFIX.FIXT1.1.$(PKG_VERSION).nupkg  --source https://api.nuget.org/v3/index.json --api-key $(NUGET_API_KEY)
	dotnet nuget push Messages/FIX50SP2artex/bin/Release/ArtexFIX.FIX5.0SP2.$(PKG_VERSION).nupkg  --source https://api.nuget.org/v3/index.json --api-key $(NUGET_API_KEY)


publish_local: pack
	dotnet nuget push QuickFIXn/bin/Release/ArtexFIX.Core.$(PKG_VERSION).nupkg --source $(HOME)/.nuget/local_repo/
	dotnet nuget push Messages/FIXT11/bin/Release/ArtexFIX.FIXT1.1.$(PKG_VERSION).nupkg --source $(HOME)/.nuget/local_repo/
	dotnet nuget push Messages/FIX50SP2artex/bin/Release/ArtexFIX.FIX5.0SP2.$(PKG_VERSION).nupkg --source $(HOME)/.nuget/local_repo/
