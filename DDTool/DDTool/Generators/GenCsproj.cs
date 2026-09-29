using System;
using System.Collections.Generic;
using System.IO;

namespace DDTool.Generators;

public static class GenCsproj {
    private static string ProjFilePath(string outputDir, string ddName) {
        return Path.Join(outputDir, $"QuickFix.{ddName}.csproj");
    }

    public static bool IsExistingCsproj(string outputDir, string ddName) {
        return File.Exists(
            ProjFilePath(outputDir, ddName));
    }

    public static string WriteFile(Options options, string ddName)
    {
        string csprojPath = ProjFilePath(options.OutputDir!, ddName);
        File.WriteAllText(
            csprojPath, Generate(options, ddName));
        return csprojPath;
    }

    private static string Generate(Options options, string ddName)
    {
        string qfPath = Path.Join(options.RepoRoot!, "QuickFIXn", "QuickFix.csproj");
        var framework = options.Framework ?? "net10.0";

        var lines = new List<string>
        {
            "<Project Sdk=\"Microsoft.NET.Sdk\">",
            "  <!--",
            "      This is a generated file.  HOWEVER, the generator won't clobber it if it exists.",
            "      If you want it regenerated, you must delete it.",
            "  -->",
            "",
            "  <PropertyGroup>",
            $"    <TargetFramework>{framework}</TargetFramework>",
            $"    <Description>Custom '{ddName}' build of QF/n message definitions</Description>",
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
