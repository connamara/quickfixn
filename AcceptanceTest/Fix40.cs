using NUnit.Framework;
using QuickFix;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AcceptanceTest;

public class Fix40 : TestBase
{
    private const string DefinitionsBaseDirPath = "definitions/server/fix40";

    protected override SessionSettings Settings => new(@"cfg/at_40.cfg");

    [TestCaseSource(nameof(Definitions))]
    public void Fix40Test(string definitionFileName)
    {
        RunTest(Path.Combine(DefinitionsBaseDirPath, definitionFileName));
    }

    private static IEnumerable<string> Definitions()
    {
        return Directory.EnumerateFiles(DefinitionsBaseDirPath, "*.def")
            .Select(f => Path.GetFileName(f)!)
            .OrderBy(s => s);
    }
}