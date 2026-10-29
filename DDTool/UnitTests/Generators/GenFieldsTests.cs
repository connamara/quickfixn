using System.Collections.Generic;
using DDTool.Generators;
using DDTool.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Generators;

[TestClass]
public class GenFieldsTests {

    [TestMethod]
    public void GenerateUtcTimestampHasUtcDateTimeFieldBaseClass()
    {
        var fields = new List<DDField> { new(52, "SendingTime", [], "UTCTIMESTAMP") };
        StringAssert.Contains(GenFields.Generate(fields), "public sealed class SendingTime : UtcDateTimeField");
    }

    [TestMethod]
    public void GenerateTzTimestampHasDateTimeFieldBaseClass()
    {
        var fields = new List<DDField> { new(1132, "TZTransactTime", [], "TZTIMESTAMP") };
        StringAssert.Contains(GenFields.Generate(fields), "public sealed class TZTransactTime : DateTimeField");
    }
}
