using NUnit.Framework;
using QuickFix;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AcceptanceTest;

public class Fix43 : TestBase
{
    private const string DefinitionsBaseDirPath = "definitions/server/fix43";

    protected override SessionSettings Settings => new(@"cfg/at_43.cfg");

    [TestCaseSource(nameof(Definitions))]
    public void Fix43Test(string definitionFileName)
    {
        RunTest(Path.Combine(DefinitionsBaseDirPath, definitionFileName));
    }

    private static IEnumerable<string> Definitions()
    {
        return Directory.EnumerateFiles(DefinitionsBaseDirPath, "*.def").Select(f => Path.GetFileName(f)!);
    }
}