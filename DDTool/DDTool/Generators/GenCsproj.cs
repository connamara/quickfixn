using System;
using System.Collections.Generic;
using System.IO;

namespace DDTool.Generators;

public static class GenCsproj {
    private static string ProjFilePath(string outputDir, string ddName) {
        return Path.Join(outputDir, "Messages", ddName, $"QuickFix.{ddName}.csproj");
    }

    public static bool IsExistingCsproj(string outputDir, string ddName) {
        return File.Exists(
            ProjFilePath(outputDir, ddName));
    }

    public static string WriteFile(string outputDir, string ddName, string repoRoot) {
        string csprojPath = ProjFilePath(outputDir, ddName);
        File.WriteAllText(
            csprojPath, Generate(ddName, repoRoot));
        return csprojPath;
    }

    private static string Generate(string name, string repoRoot) {
        string qfPath = Path.Join(repoRoot, "QuickFIXn", "QuickFix.csproj");

        var lines = new List<string>
        {
            "<Project Sdk=\"Microsoft.NET.Sdk\">",
            "  <!--",
            "      This is a generated file.  HOWEVER, the generator won't clobber it if it exists.",
            "      If you want it regenerated, you must delete it.",
            "  -->",
            "",
            "  <PropertyGroup>",
            "    <TargetFramework>net8.0</TargetFramework>",
            $"    <Description>Custom '{name}' build of QF/n message definitions</Description>",
            "    <Nullable>enable</Nullable>",
            "  </PropertyGroup>",
            "",
            "  <ItemGroup>",
            $"    <ProjectReference Include=\"{qfPath}\" />",
            "  </ItemGroup>",
            "</Project>",
            ""
        };

        return string.Join(Environment.NewLine, lines);
    }
}
