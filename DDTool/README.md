# DDTool
DataDictionary analyzer/codegen for QuickFIX/n

It doesn't do much analyzing yet.

It intentionally has minimal dependencies, and the UTs use
Microsoft's default TestFramework.

## To run

To parse DDs, but only analyze (not generate):  
`> dotnet run --project DDTool <ddFile> <ddFile>...`

To parse DDs and generate:  
`> dotnet run --project DDTool --reporoot <qfRepoDir> --outputdir <destDir> <ddFile> <ddFile>...`

## NuGet / MSBuild (broker projects)

Pack this project as `QuickFIXn.DDTool`. Consumers reference it; FIX XML is taken from
`FIXDataDictionary` items, or from `*.xml` in the project directory when that item is omitted:

```xml
<ItemGroup>
  <PackageReference Include="QuickFIXn.DDTool" Version="x.y.z" PrivateAssets="all" />
</ItemGroup>

<!-- Optional; defaults to *.xml in the project directory -->
<ItemGroup>
  <FIXDataDictionary Include="DDFIX.xml" />
</ItemGroup>
```

On build, the package runs DDTool with `--brokerproject` and writes generated C# under `{DDName}/` (e.g. `{DDName}/MessageFactory.cs`).

With `--brokerproject`, every input dictionary must set a unique `customname` on the root `<fix>` tag.
