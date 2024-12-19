using System;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{

    [TestFixture]
    public class FieldMapTests
    {
        [Test]
        public void CharFieldTest()
        {
            FieldMap fm = new();
            CharField field = new CharField(100, 'd');
            fm.SetField(field);
            CharField refield = new CharField(100);
            fm.GetField(refield);
            Assert.That('d', Is.EqualTo(refield.Value));

            field.Value = 'e';
            fm.SetField(field);
            CharField r = fm.GetField(refield);
            Assert.That('e', Is.EqualTo(refield.Value));

            Assert.That(r, Is.SameAs(refield));
        }

        [Test]
        public void GetCharTest()
        {
            FieldMap fm = new();
            fm.SetField(new CharField(20, 'a'));
            Assert.That(fm.GetChar(20), Is.EqualTo('a'));

            fm.SetField(new StringField(21, "b"));
            Assert.That(fm.GetChar(21), Is.EqualTo('b'));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetString(99900); });
        }

        [Test]
        public void GetDecimalTest()
        {
            FieldMap fm = new();
            var val = new Decimal(20.4);
            fm.SetField(new DecimalField(200, val));
            Assert.That(fm.GetDecimal(200), Is.EqualTo(val));

            fm.SetField(new StringField(201, "33.22"));
            Assert.That(fm.GetDecimal(201), Is.EqualTo(new Decimal(33.22)));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetString(99900); });
        }


        [Test]
        public void StringFieldTest()
        {
            FieldMap fm = new();
            fm.SetField(new Account("hello"));
            Account acct = new Account();
            fm.GetField(acct);
            Assert.That("hello", Is.EqualTo(acct.Value));

            fm.SetField(new Account("helloworld"));
            StringField r = fm.GetField(acct);
            Assert.That("helloworld", Is.EqualTo(acct.Value));

            Assert.That(acct, Is.SameAs(r));
        }

        [Test]
        public void GetStringTest()
        {
            FieldMap fm = new();
            fm.SetField(new Account("hello"));
            Assert.That(fm.GetString(Tags.Account), Is.EqualTo("hello"));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetString(99900); });
        }

        [Test]
        public void DateTimeFieldTest()
        {
            FieldMap fm = new();
            fm.SetField(new DateTimeField(Tags.TransactTime, new DateTime(2009, 12, 10)));
            TransactTime tt = new TransactTime();
            fm.GetField(tt);
            Assert.That(new DateTime(2009, 12, 10), Is.EqualTo(tt.Value));

            fm.SetField(new TransactTime(new DateTime(2010, 12, 10)));
            DateTimeField r = fm.GetField(tt);
            Assert.That(new DateTime(2010, 12, 10), Is.EqualTo(tt.Value));

            Assert.That(tt, Is.SameAs(r));
        }

        [Test]
        public void DateTimeFieldNanoTest()
        {
            FieldMap fm = new();
            fm.SetField(new StringField(Tags.TransactTime, "20200309-20:53:10.643649215"));
            TransactTime tt = new TransactTime();
            fm.GetField(tt);
            // Ticks resolution is 100 nanoseconds, so we lose the last 2 decimal points
            Assert.That(tt.Value.Ticks, Is.EqualTo(637193839906436492));
        }

        [Test]
        public void DateOnlyFieldTest()
        {
            FieldMap fm = new();
            fm.SetField(new DateOnlyField(Tags.MDEntryDate, new DateTime(2009, 12, 10, 1, 2, 3)));
            MDEntryDate ed = new MDEntryDate();
            fm.GetField(ed);
            Assert.That(ed.Value, Is.EqualTo(new DateTime(2009, 12, 10)));

            fm.SetField(new MDEntryDate(new DateTime(2010, 12, 10)));
            DateOnlyField r = fm.GetField(ed);
            Assert.That(ed.Value, Is.EqualTo(new DateTime(2010, 12, 10)));

            Assert.That(ed, Is.SameAs(r));
            Assert.That(ed.ToString(), Is.EqualTo("20101210"));
        }

        [Test]
        public void TimeOnlyFieldTest()
        {
            FieldMap fm = new();
            fm.SetField(new TimeOnlyField(Tags.MDEntryTime, new DateTime(1, 1, 1, 1, 2, 3), false));
            MDEntryTime et = new MDEntryTime();
            fm.GetField(et);
            Assert.That(et.Value, Is.EqualTo(new DateTime(1980, 01, 01, 1, 2, 3)));

            fm.SetField(new MDEntryTime(new DateTime(1, 1, 1, 1, 2, 5)));
            TimeOnlyField r = fm.GetField(et);
            Assert.That(et.Value, Is.EqualTo(new DateTime(1980, 01, 01, 1, 2, 5)));

            Assert.That(et, Is.SameAs(r));
            Assert.That(et.ToString(), Is.EqualTo("01:02:05.000"));
        }

        [Test]
        public void GetDateTimeTest()
        {
            FieldMap fm = new();
            fm.SetField(new DateTimeField(Tags.TransactTime, new DateTime(2009, 12, 10)));
            Assert.That(fm.GetDateTime(Tags.TransactTime), Is.EqualTo(new DateTime(2009, 12, 10)));

            fm.SetField(new StringField(Tags.TransactTime, "20091211-12:12:44"));
            Assert.That(fm.GetDateTime(Tags.TransactTime), Is.EqualTo(new DateTime(2009, 12, 11, 12, 12, 44)));

            Assert.Throws(typeof(FieldNotFoundException),
                    delegate { fm.GetDateTime(99900); });
        }

        [Test]
        public void GetDateOnlyTest()
        {
            FieldMap fm = new();
            fm.SetField(new DateOnlyField(Tags.MDEntryDate, new DateTime(2009, 12, 10, 1, 2, 3)));
            Assert.That(fm.GetDateTime(Tags.MDEntryDate), Is.EqualTo(new DateTime(2009, 12, 10)));

            fm.SetField(new StringField(Tags.MDEntryDate, "20091211"));
            Assert.That(fm.GetDateOnly(Tags.MDEntryDate), Is.EqualTo(new DateTime(2009, 12, 11)));

            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetDateOnly(99900); });
        }

        [Test]
        public void GetTimeOnlyTest()
        {
            FieldMap fm = new();
            fm.SetField(new TimeOnlyField(Tags.MDEntryTime, new DateTime(2009, 12, 10, 1, 2, 3)));
            Assert.That(fm.GetDateTime(Tags.MDEntryTime), Is.EqualTo(new DateTime(1980, 01, 01, 1, 2, 3)));

            fm.SetField(new StringField(Tags.MDEntryTime, "07:30:47"));
            Assert.That(fm.GetTimeOnly(Tags.MDEntryTime), Is.EqualTo(new DateTime(1980, 01, 01, 7, 30, 47)));

            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetTimeOnly(99900); });
        }

        [Test]
        public void BooleanFieldTest()
        {
            FieldMap fm = new();
            BooleanField field = new BooleanField(200, true);
            BooleanField refield = new BooleanField(200);
            fm.SetField(field);
            fm.GetField(refield);
            Assert.That(true, Is.EqualTo(refield.Value));

            field.Value = false;
            fm.SetField(field);
            BooleanField r = fm.GetField(refield);
            Assert.That(false, Is.EqualTo(refield.Value));

            Assert.That(refield, Is.SameAs(r));
        }

        [Test]
        public void GetBooleanTest()
        {
            FieldMap fm = new();
            fm.SetField(new BooleanField(200, true));
            Assert.That(fm.GetBoolean(200), Is.EqualTo(true));

            fm.SetField(new StringField(201, "N"));
            Assert.That(fm.GetBoolean(201), Is.EqualTo(false));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetString(99900); });
        }

        [Test]
        public void IntFieldTest()
        {
            FieldMap fm = new();
            IntField field = new IntField(200, 101);
            IntField refield = new IntField(200);
            fm.SetField(field);
            fm.GetField(refield);
            Assert.That(101, Is.EqualTo(refield.Value));

            field.Value = 102;
            fm.SetField(field);
            IntField r = fm.GetField(refield);
            Assert.That(102, Is.EqualTo(refield.Value));

            Assert.That(refield, Is.SameAs(r));
        }

        [Test]
        public void GetIntTest()
        {
            FieldMap fm = new();
            IntField field = new IntField(200, 101);
            fm.SetField(field);
            Assert.That(fm.GetInt(200), Is.EqualTo(101));

            fm.SetField(new StringField(202, "2222"));
            Assert.That(fm.GetInt(202), Is.EqualTo(2222));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetInt(99900); });
        }

        [Test]
        public void DecimalFieldTest()
        {
            FieldMap fm = new();
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            DecimalField refield = new DecimalField(200);
            fm.SetField(field);
            fm.GetField(refield);
            Assert.That(101.0001, Is.EqualTo(refield.Value));

            field.Value = 101.0002m;
            fm.SetField(field);
            DecimalField r = fm.GetField(refield);
            Assert.That(101.0002, Is.EqualTo(refield.Value));

            Assert.That(refield, Is.SameAs(r));
        }

        [Test]
        public void DefaultFieldTest()
        {
            FieldMap fm = new();
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            fm.SetField(field);
            string refield = fm.GetString(200);
            Assert.That("101.0001", Is.EqualTo(refield));
        }

        [Test]
        public void SetFieldOverwriteTest()
        {
            FieldMap fm = new();
            IntField field = new IntField(21901, 1011);
            IntField refield = new IntField(21901);
            fm.SetField(field, false);
            fm.GetField(refield);
            Assert.That(1011, Is.EqualTo(refield.Value));

            field.Value = 1021;
            IntField refield2 = new IntField(21901);
            fm.SetField(field, false);
            fm.GetField(refield2);
            Assert.That(refield.Value, Is.EqualTo(1011));

            fm.SetField(field, true);
            IntField refield3 = new IntField(21901);
            fm.GetField(refield3);
            Assert.That(1021, Is.EqualTo(refield3.Value));
        }

        [Test]
        public void FieldNotFoundTest()
        {
            FieldMap fm = new();
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetString(99900); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetField(new DateTimeField(1002030)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { fm.GetField(new CharField(23099)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { fm.GetField(new BooleanField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { fm.GetField(new StringField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetField(new IntField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetField(new DecimalField(99900)); });
        }

        [Test]
        public void SimpleFieldOrderTest()
        {
            int[] fieldord = { 10, 11, 12, 13, 200 };
            FieldMap fm = new FieldMap(fieldord);
            Assert.That(fm.FieldOrder, Is.EqualTo(fieldord));
        }

        [Test]
        public void GroupDelimTest()
        {
            Group g1 = new Group(100, 200);
            Assert.That(g1.CounterField, Is.EqualTo(100)); //counter
            Assert.That(g1.Delim, Is.EqualTo(200));

            g1.SetField(new StringField(200, "delim!"));

            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            Assert.That(fm.GetInt(100), Is.EqualTo(1));

            Group g2 = new Group(100, 200);
            g2.SetField(new StringField(200, "again!"));
            fm.AddGroup(g2);
            Assert.That(fm.GetInt(100), Is.EqualTo(2));
        }

        [Test]
        public void AddGetGroupTest()
        {
            Group g1 = new Group(100, 200);
            Group g2 = new Group(100, 201);
            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            fm.AddGroup(g2);
            Assert.That(fm.GetGroup(1, 100), Is.EqualTo(g1));
            Assert.That(fm.GetGroup(2, 100), Is.EqualTo(g2));

            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetGroup(1, 101); }); // group counter 101 not found
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetGroup(0, 100); }); // num too low
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetGroup(3, 100); }); // num too high
        }

        [Test]
        public void RemoveGroupTest()
        {
            Group g1 = new Group(100, 200);
            Group g2 = new Group(100, 201);
            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            fm.AddGroup(g2);

            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.RemoveGroup(1, 101); }); // group counter 101 not found
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.RemoveGroup(0, 100); }); // num too low
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.RemoveGroup(3, 101); }); // num too high

            fm.RemoveGroup(1, 100);
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetGroup(2, 100); }); // try to remove item 2 (of 1)

            Assert.That(fm.GetGroupTags().Contains(100)); // still true, because there's still 1 group

            fm.RemoveGroup(1, 100);
            Assert.That(fm.GetGroupTags().Contains(100), Is.False);

            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.GetGroup(1, 100); }); // try to remove item 1 (of 0)
        }

        [Test]
        public void ReplaceGroupTest()
        {
            Group g1 = new Group(100, 200);
            Group g2 = new Group(100, 201);
            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            fm.AddGroup(g2);

            Group g3 = new Group(100, 202);
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.ReplaceGroup(1, 101, g3); }); // group counter 101 not found
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.ReplaceGroup(0, 100, g3); }); // num too low
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fm.ReplaceGroup(3, 100, g3); }); // num too high

            fm.ReplaceGroup(1, 100, g3);
            fm.ReplaceGroup(2, 100, g3);
            Assert.That(fm.GetGroup(1, 100), Is.EqualTo(g3));
            Assert.That(fm.GetGroup(2, 100), Is.EqualTo(g3));
        }

        [Test]
        public void IsFieldSetTest()
        {
            FieldMap fieldmap = new FieldMap();
            BooleanField field = new BooleanField(200, true);
            Assert.That(fieldmap.IsSetField(field), Is.EqualTo(false));
            Assert.That(fieldmap.IsSetField(field.Tag), Is.EqualTo(false));
            fieldmap.SetField(field);
            Assert.That(fieldmap.IsSetField(field), Is.EqualTo(true));
            Assert.That(fieldmap.IsSetField(field.Tag), Is.EqualTo(true));
        }

        [Test]
        public void ClearAndIsEmptyTest()
        {
            FieldMap fieldmap = new FieldMap();
            BooleanField field = new BooleanField(200, true);
            Assert.That(fieldmap.IsEmpty(), Is.EqualTo(true));
            fieldmap.SetField(field);
            Assert.That(fieldmap.IsEmpty(), Is.EqualTo(false));
            fieldmap.Clear();
            Assert.That(fieldmap.IsEmpty(), Is.EqualTo(true));
            Group g = new Group(100, 101);
            fieldmap.AddGroup(g);
            Assert.That(fieldmap.IsEmpty(), Is.EqualTo(false));
            fieldmap.Clear();
            Assert.That(fieldmap.IsEmpty(), Is.EqualTo(true));
        }

        [Test]
        public void AddGroupKeepTypeTest()
        {
            // bug found during issue 56 - Group object was losing type after being added
            FieldMap fm = new FieldMap();
            QuickFix.FIX42.News.LinesOfTextGroup linesGroup = new QuickFix.FIX42.News.LinesOfTextGroup();
            linesGroup.Text = new Text("foo");
            fm.AddGroup(linesGroup);

            var rvGroup = fm.GetGroup(1, Tags.LinesOfText);
            Assert.That(rvGroup, Is.InstanceOf<QuickFix.FIX42.News.LinesOfTextGroup>());
        }
    }
}
