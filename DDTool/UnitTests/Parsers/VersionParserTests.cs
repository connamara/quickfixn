using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Parsers;

[TestClass]
public class VersionParserTests {
    [TestMethod]
    public void SetVersionInfo() {
        var dd = ParserTestUtil.ReadDD("<fix major='4' minor='4'/>", ParserTask.Version);
        Assert.AreEqual("4.4 [] False", $"{dd.MajorVersion}.{dd.MinorVersion} [{dd.ServicePack}] {dd.IsFIXT}");

        dd = ParserTestUtil.ReadDD("<fix major='5' type='FIX' servicepack='0' minor='0'/>", ParserTask.Version);
        Assert.AreEqual("5.0 [] False", $"{dd.MajorVersion}.{dd.MinorVersion} [{dd.ServicePack}] {dd.IsFIXT}");

        dd = ParserTestUtil.ReadDD("<fix major='5' type='FIX' servicepack='2' minor='0'/>", ParserTask.Version);
        Assert.AreEqual("5.0 [2] False", $"{dd.MajorVersion}.{dd.MinorVersion} [{dd.ServicePack}] {dd.IsFIXT}");

        dd = ParserTestUtil.ReadDD("<fix type='FIXT' major='1' minor='1' servicepack='0'/>", ParserTask.Version);
        Assert.AreEqual("1.1 [] True", $"{dd.MajorVersion}.{dd.MinorVersion} [{dd.ServicePack}] {dd.IsFIXT}");
    }
}
