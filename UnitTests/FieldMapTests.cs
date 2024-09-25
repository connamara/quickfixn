using System;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{

    [TestFixture]
    public class FieldMapTests
    {
        private FieldMap _fieldmap;
        public FieldMapTests()
        {
            this._fieldmap = new FieldMap();
        }

        [Test]
        public void CharFieldTest()
        {

            CharField field = new CharField(100, 'd');
            _fieldmap.SetField(field);
            CharField refield = new CharField(100);
            _fieldmap.GetField(refield);
            Assert.That('d', Is.EqualTo(refield.Value));
            field.Value = 'e';
            _fieldmap.SetField(field);
            CharField r = _fieldmap.GetField(refield);
            Assert.That('e', Is.EqualTo(refield.Value));

            Assert.AreSame(refield, r);
        }


        [Test]
        public void GetCharTest()
        {
            _fieldmap.SetField(new CharField(20, 'a'));
            Assert.That(_fieldmap.GetChar(20), Is.EqualTo('a'));
            _fieldmap.SetField(new StringField(21, "b"));
            Assert.That(_fieldmap.GetChar(21), Is.EqualTo('b'));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetString(99900); });
        }

        [Test]
        public void GetDecimalTest()
        {
            var val = new Decimal(20.4);
            _fieldmap.SetField(new DecimalField(200, val));
            Assert.That(_fieldmap.GetDecimal(200), Is.EqualTo(val));
            _fieldmap.SetField(new StringField(201, "33.22"));
            Assert.That(_fieldmap.GetDecimal(201), Is.EqualTo(new Decimal(33.22)));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetString(99900); });
        }


        [Test]
        public void StringFieldTest()
        {

            _fieldmap.SetField(new Account("hello"));
            Account acct = new Account();
            _fieldmap.GetField(acct);
            Assert.That("hello", Is.EqualTo(acct.Value));
            _fieldmap.SetField(new Account("helloworld"));
            StringField r = _fieldmap.GetField(acct);
            Assert.That("helloworld", Is.EqualTo(acct.Value));

            Assert.AreSame(r, acct);
        }

        [Test]
        public void GetStringTest()
        {
            _fieldmap.SetField(new Account("hello"));
            Assert.That(_fieldmap.GetString(QuickFix.Fields.Tags.Account), Is.EqualTo("hello"));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetString(99900); });
        }

        [Test]
        public void DateTimeFieldTest()
        {

            _fieldmap.SetField(new DateTimeField(Tags.TransactTime, new DateTime(2009, 12, 10)));
            TransactTime tt = new TransactTime();
            _fieldmap.GetField(tt);
            Assert.That(new DateTime(2009, 12, 10), Is.EqualTo(tt.Value));
            _fieldmap.SetField(new TransactTime(new DateTime(2010, 12, 10)));
            DateTimeField r = _fieldmap.GetField(tt);
            Assert.That(new DateTime(2010, 12, 10), Is.EqualTo(tt.Value));

            Assert.AreSame(r, tt);
        }

        [Test]
        public void DateTimeFieldNanoTest()
        {
            _fieldmap.SetField(new StringField(Tags.TransactTime, "20200309-20:53:10.643649215"));
            TransactTime tt = new TransactTime();
            _fieldmap.GetField(tt);
            // Ticks resolution is 100 nanoseconds, so we lose the last 2 decimal points
            Assert.That(tt.Value.Ticks, Is.EqualTo(637193839906436492));
        }

        [Test]
        public void DateOnlyFieldTest()
        {
            _fieldmap.SetField(new DateOnlyField(Tags.MDEntryDate, new DateTime(2009, 12, 10, 1, 2, 3)));
            MDEntryDate ed = new MDEntryDate();
            _fieldmap.GetField(ed);
            Assert.AreEqual(new DateTime(2009, 12, 10), ed.Value);
            _fieldmap.SetField(new MDEntryDate(new DateTime(2010, 12, 10)));
            DateOnlyField r = _fieldmap.GetField(ed);
            Assert.AreEqual(new DateTime(2010, 12, 10), ed.Value);

            Assert.AreSame(r, ed);
            Assert.AreEqual("20101210", ed.ToString());
        }

        [Test]
        public void TimeOnlyFieldTest()
        {
            _fieldmap.SetField(new TimeOnlyField(Tags.MDEntryTime, new DateTime(1, 1, 1, 1, 2, 3), false));
            MDEntryTime et = new MDEntryTime();
            _fieldmap.GetField(et);
            Assert.AreEqual(new DateTime(1980, 01, 01, 1, 2, 3), et.Value);
            _fieldmap.SetField(new MDEntryTime(new DateTime(1, 1, 1, 1, 2, 5)));
            TimeOnlyField r = _fieldmap.GetField(et);
            Assert.AreEqual(new DateTime(1980, 01, 01, 1, 2, 5), et.Value);

            Assert.AreSame(r, et);
            Assert.AreEqual("01:02:05.000", et.ToString());
        }

        [Test]
        public void GetDateTimeTest()
        {
            _fieldmap.SetField(new DateTimeField(Tags.TransactTime, new DateTime(2009, 12, 10)));
            Assert.That(_fieldmap.GetDateTime(Tags.TransactTime), Is.EqualTo(new DateTime(2009, 12, 10)));
            _fieldmap.SetField(new StringField(233, "20091211-12:12:44"));
            Assert.That(_fieldmap.GetDateTime(233), Is.EqualTo(new DateTime(2009, 12, 11, 12, 12, 44)));
            Assert.Throws(typeof(FieldNotFoundException),
                    delegate { _fieldmap.GetDateTime(99900); });
        }

        [Test]
        public void GetDateOnlyTest()
        {
            _fieldmap.SetField(new DateOnlyField(Tags.MDEntryDate, new DateTime(2009, 12, 10, 1, 2, 3)));
            Assert.AreEqual(new DateTime(2009, 12, 10), _fieldmap.GetDateTime(Tags.MDEntryDate));
            _fieldmap.SetField(new StringField(233, "20091211"));
            Assert.AreEqual(new DateTime(2009, 12, 11), _fieldmap.GetDateOnly(233));
        }

        [Test]
        public void GetTimeOnlyTest()
        {
            _fieldmap.SetField(new TimeOnlyField(Tags.MDEntryTime, new DateTime(2009, 12, 10, 1, 2, 3)));
            Assert.AreEqual(new DateTime(1980, 01, 01, 1, 2, 3), _fieldmap.GetDateTime(Tags.MDEntryTime));
            _fieldmap.SetField(new StringField(233, "07:30:47"));
            Assert.AreEqual(new DateTime(1980, 01, 01, 7, 30, 47), _fieldmap.GetTimeOnly(233));
        }

        [Test]
        public void BooleanFieldTest()
        {
            BooleanField field = new BooleanField(200, true);
            BooleanField refield = new BooleanField(200);
            _fieldmap.SetField(field);
            _fieldmap.GetField(refield);
            Assert.That(true, Is.EqualTo(refield.Value));
            field.Value = false;
            _fieldmap.SetField(field);
            BooleanField r = _fieldmap.GetField(refield);
            Assert.That(false, Is.EqualTo(refield.Value));

            Assert.AreSame(r, refield);
        }

        [Test]
        public void GetBooleanTest()
        {
            _fieldmap.SetField(new BooleanField(200, true));
            Assert.That(_fieldmap.GetBoolean(200), Is.EqualTo(true));
            _fieldmap.SetField(new StringField(201, "N"));
            Assert.That(_fieldmap.GetBoolean(201), Is.EqualTo(false));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetString(99900); });
        }

        [Test]
        public void IntFieldTest()
        {

            IntField field = new IntField(200, 101);
            IntField refield = new IntField(200);
            _fieldmap.SetField(field);
            _fieldmap.GetField(refield);
            Assert.That(101, Is.EqualTo(refield.Value));
            field.Value = 102;
            _fieldmap.SetField(field);
            IntField r = _fieldmap.GetField(refield);
            Assert.That(102, Is.EqualTo(refield.Value));

            Assert.AreSame(r, refield);
        }

        [Test]
        public void GetIntTest()
        {

            IntField field = new IntField(200, 101);
            _fieldmap.SetField(field);
            Assert.That(_fieldmap.GetInt(200), Is.EqualTo(101));
            _fieldmap.SetField(new StringField(202, "2222"));
            Assert.That(_fieldmap.GetInt(202), Is.EqualTo(2222));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetInt(99900); });
        }

        [Test]
        public void DecimalFieldTest()
        {
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            DecimalField refield = new DecimalField(200);
            _fieldmap.SetField(field);
            _fieldmap.GetField(refield);
            Assert.That(101.0001, Is.EqualTo(refield.Value));
            field.Value = 101.0002m;
            _fieldmap.SetField(field);
            DecimalField r = _fieldmap.GetField(refield);
            Assert.That(101.0002, Is.EqualTo(refield.Value));

            Assert.AreSame(r, refield);
        }

        [Test]
        public void DefaultFieldTest()
        {
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            _fieldmap.SetField(field);
            string refield = _fieldmap.GetString(200);
            Assert.That("101.0001", Is.EqualTo(refield));
        }

        [Test]
        public void SetFieldOverwriteTest()
        {
            IntField field = new IntField(21901, 1011);
            IntField refield = new IntField(21901);
            _fieldmap.SetField(field, false);
            _fieldmap.GetField(refield);
            Assert.That(1011, Is.EqualTo(refield.Value));
            field.Value = 1021;
            IntField refield2 = new IntField(21901);
            _fieldmap.SetField(field, false);
            _fieldmap.GetField(refield2);
            Assert.That(refield.Value, Is.EqualTo(1011));
            _fieldmap.SetField(field, true);
            IntField refield3 = new IntField(21901);
            _fieldmap.GetField(refield3);
            Assert.That(1021, Is.EqualTo(refield3.Value));
        }

        [Test]
        public void FieldNotFoundTest()
        {
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetString(99900); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetField(new DateTimeField(1002030)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { _fieldmap.GetField(new CharField(23099)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { _fieldmap.GetField(new BooleanField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { _fieldmap.GetField(new StringField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetField(new IntField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetField(new DecimalField(99900)); });
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
            Assert.AreEqual(100, g1.CounterField); //counter
            Assert.AreEqual(200, g1.Delim);

            g1.SetField(new StringField(200, "delim!"));

            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            Assert.AreEqual(1, fm.GetInt(100));

            Group g2 = new Group(100, 200);
            g2.SetField(new StringField(200, "again!"));
            fm.AddGroup(g2);
            Assert.AreEqual(2, fm.GetInt(100));
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
                delegate { _fieldmap.GetGroup(0, 101); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetGroup(3, 100); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetGroup(1, 101); });
        }

        [Test]
        public void RemoveGroupTest()
        {
            Group g1 = new Group(100, 200);
            Group g2 = new Group(100, 201);
            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            fm.AddGroup(g2);
            Assert.That(fm.GetGroup(1, 100), Is.EqualTo(g1));
            Assert.That(fm.GetGroup(2, 100), Is.EqualTo(g2));

            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.RemoveGroup(0, 101); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.RemoveGroup(3, 100); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.RemoveGroup(1, 101); });

            fm.RemoveGroup(1, 100);
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetGroup(2, 100); });
            fm.RemoveGroup(1, 100);
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.GetGroup(1, 100); });
        }

        [Test]
        public void ReplaceGroupTest()
        {
            Group g1 = new Group(100, 200);
            Group g2 = new Group(100, 201);
            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            fm.AddGroup(g2);
            Assert.That(fm.GetGroup(1, 100), Is.EqualTo(g1));
            Assert.That(fm.GetGroup(2, 100), Is.EqualTo(g2));

            Group g3 = new Group(100, 202);
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.ReplaceGroup(0, 101, g3); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.ReplaceGroup(3, 100, g3); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { _fieldmap.ReplaceGroup(1, 101, g3); });

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
            linesGroup.Text = new QuickFix.Fields.Text("foo");
            fm.AddGroup(linesGroup);

            var rvGroup = fm.GetGroup(1, Tags.LinesOfText);
            Assert.IsInstanceOf<QuickFix.FIX42.News.LinesOfTextGroup>(rvGroup);
        }
    }
}
