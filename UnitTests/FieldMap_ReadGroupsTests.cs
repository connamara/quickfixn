using System;
using System.Linq;
using NUnit.Framework;
using QuickFix.FIX42;
using QuickFix.Fields;

namespace UnitTests;

[TestFixture]
public class FieldMap_ReadGroupsTests {
    public class GroupExtensionTest
    {
        private static News CreateNewsForTest(int numberOfLines) {
            News msg = new();
            msg.Headline = new Headline("Blah headline");
            for (int i = 0; i < numberOfLines; i++) {
                News.LinesOfTextGroup grp = new();
                grp.SetField(new Text($"OHHAI_{i}"));
                msg.AddGroup(grp);
            }
            return msg;
        }

        [Test]
        public void ReadGroups_NormalScenario() {
            News msg = CreateNewsForTest(10);
            int iterCount = 0;
            foreach (News.LinesOfTextGroup item in msg.ReadGroups<News.LinesOfTextGroup>(Tags.NoLinesOfText))
                Assert.That(item.Text.Value, Is.EqualTo($"OHHAI_{iterCount++}"));
            Assert.That(iterCount == 10);
        }

        [Test]
        public void ReadGroups_ZeroCount() {
            News msg = new();
            Assert.That(msg.ReadGroups<News.LinesOfTextGroup>(Tags.NoLinesOfText).ToList(), Is.Empty);
        }

        [Test]
        public void ReadGroups_WrongTag() {
            // Tag doesn't match the templated group
            // case 1: incorrect tag is not present in message
            News msg = CreateNewsForTest(3);
            Assert.That(msg.IsSetField(Tags.Account), Is.False);
            Assert.That(msg.ReadGroups<News.LinesOfTextGroup>(Tags.Account).ToList(), Is.Empty);

            // case 2: incorrect tag present but value isn't an int (like a group counter would be)
            Assert.That(msg.IsSetHeadline());
            Assert.That(msg.ReadGroups<News.LinesOfTextGroup>(Tags.Headline).ToList(), Is.Empty);

            // case 3: incorrect tag present and an int, but isn't group counter at all
            msg.SetField(new RawDataLength(100));
            Assert.That(msg.ReadGroups<News.LinesOfTextGroup>(Tags.RawDataLength).ToList(), Is.Empty);
        }

        [Test]
        public void ReadGroups_WrongGroup() {
            // The tag is good, but the template type is incorrect
            // Case 1: The tag's group is empty, so the templated type doesn't matter.
            News msg = CreateNewsForTest(0);
            Assert.That(msg.ReadGroups<QuickFix.FIX44.ExecutionReport.NoLegsGroup>(Tags.NoLinesOfText).ToList(),
                Is.Empty);

            // Case 2: Group is not empty, so InvalidCastException will occur
            msg = CreateNewsForTest(1);
            var ex = Assert.Throws<InvalidCastException>(
                () => msg.ReadGroups<QuickFix.FIX44.ExecutionReport.NoLegsGroup>(Tags.NoLinesOfText).ToList());
            Assert.That(ex!.Message, Is.EqualTo("Can't cast QuickFix.FIX42.News+LinesOfTextGroup to QuickFix.FIX44.ExecutionReport+NoLegsGroup"));
        }
    }
}
