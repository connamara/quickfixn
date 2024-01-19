using System.Collections.Generic;
using System.Linq;
using DDTool.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Structures;

[TestClass]
public class DDMessageTests {

    [TestMethod]
    public void Groups() {
        var msg = new DDMessage("Foo", "F", "app");

        msg.AddElement(new DDField(99, "Blah", new List<EnumValue>(), "INT"), false);

        var counter = new DDField(888, "NoPile", new List<EnumValue>(), "NUMINGROUP");
        msg.AddElement(new DDGroup(counter), false);

        Assert.AreEqual(1, msg.Groups.Count());

        var grp = msg.Groups.First();
        Assert.AreEqual("NoPile", grp.Name);
    }

}
