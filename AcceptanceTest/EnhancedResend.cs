using NUnit.Framework;
using QuickFix;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AcceptanceTest;

public class EnhancedResend : TestBase
{
    private const string DefinitionsBaseDirPath = "definitions/server/enhancedresend";

    protected override SessionSettings Settings => new(@"cfg/at_44_enhancedresend.cfg");

    [TestCaseSource(nameof(Definitions))]
    public void EnhancedResendTest(string definitionFileName)
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
