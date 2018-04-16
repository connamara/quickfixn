using System.IO;
using NUnit.Framework;
using QuickFix.DataDictionary;

namespace UnitTests.TestHelpers
{
    internal static class DataDictionaryLoadExtensions
    {
        public static void LoadFIXSpec(this DataDictionary self, string name)
        {
            self.Load(Path.Combine(TestContext.CurrentContext.TestDirectory, "spec", "fix", $"{name}.xml"));
        }

        public static void LoadTestFIXSpec(this DataDictionary self, string name)
        {
            self.Load(Path.Combine(TestContext.CurrentContext.TestDirectory, "spec", "test", $"{name}.xml"));
        }
    }
}
