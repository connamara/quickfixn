using NUnit.Framework;
using QuickFix;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AcceptanceTest;

public class Fix44 : TestBase
{
    private const string DefinitionsBaseDirPath = "definitions/server/fix44";

    protected override SessionSettings Settings => new(@"cfg/at_44.cfg");

    [TestCaseSource(nameof(Definitions))]
    public void TestCase(string definitionFileName)
    {
        RunTest(Path.Combine(DefinitionsBaseDirPath, definitionFileName));
    }

    private static IEnumerable<string> Definitions()
    {
        return Directory.EnumerateFiles(DefinitionsBaseDirPath, "*.def").Select(Path.GetFileName);
    }
}