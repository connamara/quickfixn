using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{

    [TestFixture]
    public class FieldMapTests
    {
        private FieldMap fieldmap;
        public FieldMapTests()
        {
            this.fieldmap = new FieldMap();
        }

        [Test]
        public void CharFieldTest()
        {

            CharField field = new CharField(100, 'd');
            fieldmap.SetField(field);
            CharField refield = new CharField(100);
            fieldmap.GetField(refield);
            Assert.That('d', Is.EqualTo(refield.Obj));
            field.Obj = 'e';
            fieldmap.SetField(field);
            CharField r = fieldmap.GetField(refield);
            Assert.That('e', Is.EqualTo(refield.Obj));

            Assert.AreSame(refield, r);
        }


        [Test]
        public void GetCharTest()
        {
            fieldmap.SetField(new CharField(20, 'a'));
            Assert.That(fieldmap.GetChar(20), Is.EqualTo('a'));
            fieldmap.SetField(new StringField(21, "b"));
            Assert.That(fieldmap.GetChar(21), Is.EqualTo('b'));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetString(99900); });
        }

        [Test]
        public void GetDecimalTest()
        {
            var val = new Decimal(20.4);
            fieldmap.SetField(new DecimalField(200, val));
            Assert.That(fieldmap.GetDecimal(200), Is.EqualTo(val));
            fieldmap.SetField(new StringField(201, "33.22"));
            Assert.That(fieldmap.GetDecimal(201), Is.EqualTo(new Decimal(33.22)));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetString(99900); });
        }
        

        [Test]
        public void StringFieldTest()
        {

            fieldmap.SetField(new Account("hello"));
            Account acct = new Account();
            fieldmap.GetField(acct);
            Assert.That("hello", Is.EqualTo(acct.Obj));
            fieldmap.SetField(new Account("helloworld"));
            StringField r = fieldmap.GetField(acct);
            Assert.That("helloworld", Is.EqualTo(acct.getValue()));

            Assert.AreSame(r, acct);
        }

        [Test]
        public void GetStringTest()
        {
            fieldmap.SetField(new Account("hello"));
            Assert.That(fieldmap.GetString(QuickFix.Fields.Tags.Account), Is.EqualTo("hello"));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetString(99900); });
        }

        [Test]
        public void DateTimeFieldTest()
        {

            fieldmap.SetField(new DateTimeField(Tags.TransactTime, new DateTime(2009, 12, 10)));
            TransactTime tt = new TransactTime();
            fieldmap.GetField(tt);
            Assert.That(new DateTime(2009, 12, 10), Is.EqualTo(tt.Obj));
            fieldmap.SetField(new TransactTime(new DateTime(2010, 12, 10)));
            DateTimeField r = fieldmap.GetField(tt);
            Assert.That(new DateTime(2010, 12, 10), Is.EqualTo(tt.getValue()));

            Assert.AreSame(r, tt);
        }

        [Test]
        public void DateOnlyFieldTest()
        {
            fieldmap.SetField(new DateOnlyField(Tags.MDEntryDate, new DateTime(2009, 12, 10, 1, 2, 3)));
            MDEntryDate ed = new MDEntryDate();
            fieldmap.GetField(ed);
            Assert.AreEqual(new DateTime(2009, 12, 10), ed.Obj);
            fieldmap.SetField(new MDEntryDate(new DateTime(2010, 12, 10)));
            DateOnlyField r = fieldmap.GetField(ed);
            Assert.AreEqual(new DateTime(2010, 12, 10), ed.getValue());            
            
            Assert.AreSame(r, ed);
            Assert.AreEqual("20101210", ed.ToString());
        }

        [Test]
        public void TimeOnlyFieldTest()
        {            
            fieldmap.SetField(new TimeOnlyField(Tags.MDEntryTime, new DateTime(1, 1, 1, 1, 2, 3), false));
            MDEntryTime et = new MDEntryTime();
            fieldmap.GetField(et);
            Assert.AreEqual(new DateTime(1, 1, 1, 1, 2, 3).TimeOfDay, et.Obj.TimeOfDay);
            fieldmap.SetField(new MDEntryTime(new DateTime(1, 1, 1, 1, 2, 5)));
            TimeOnlyField r = fieldmap.GetField(et);
            Assert.AreEqual(new DateTime(1, 1, 1, 1, 2, 5).TimeOfDay, et.getValue().TimeOfDay);
            
            Assert.AreSame(r, et);
            Assert.AreEqual("01:02:05.000", et.ToString());
        }

        [Test]
        public void GetDateTimeTest()
        {
            fieldmap.SetField(new DateTimeField(Tags.TransactTime, new DateTime(2009, 12, 10)));
            Assert.That(fieldmap.GetDateTime(Tags.TransactTime), Is.EqualTo(new DateTime(2009, 12, 10)));
            fieldmap.SetField(new StringField(233, "20091211-12:12:44"));
            Assert.That(fieldmap.GetDateTime(233), Is.EqualTo(new DateTime(2009, 12, 11, 12, 12, 44)));
            Assert.Throws(typeof(FieldNotFoundException),
                    delegate { fieldmap.GetDateTime(99900); });
        }

        [Test]
        public void GetDateOnlyTest()
        {
            fieldmap.SetField(new DateOnlyField(Tags.MDEntryDate, new DateTime(2009, 12, 10, 1, 2, 3)));
            Assert.AreEqual(new DateTime(2009, 12, 10), fieldmap.GetDateTime(Tags.MDEntryDate));
            fieldmap.SetField(new StringField(233, "20091211"));
            Assert.AreEqual(new DateTime(2009, 12, 11), fieldmap.GetDateOnly(233));
        }

        [Test]
        public void GetTimeOnlyTest()
        {
            fieldmap.SetField(new TimeOnlyField(Tags.MDEntryTime, new DateTime(2009, 12, 10, 1, 2, 3)));
            Assert.AreEqual(new DateTime(2009, 12, 10, 1, 2, 3).TimeOfDay, fieldmap.GetDateTime(Tags.MDEntryTime).TimeOfDay);
            fieldmap.SetField(new StringField(233, "07:30:47"));
            Assert.AreEqual(new DateTime(2009, 12, 11, 7, 30, 47).TimeOfDay, fieldmap.GetTimeOnly(233).TimeOfDay);
        }

        [Test]
        public void BooleanFieldTest()
        {
            BooleanField field = new BooleanField(200, true);
            BooleanField refield = new BooleanField(200);
            fieldmap.SetField(field);
            fieldmap.GetField(refield);
            Assert.That(true, Is.EqualTo(refield.Obj));
            field.setValue(false);
            fieldmap.SetField(field);
            BooleanField r = fieldmap.GetField(refield);
            Assert.That(false, Is.EqualTo(refield.Obj));

            Assert.AreSame(r, refield);
        }

        [Test]
        public void GetBooleanTest()
        {
            fieldmap.SetField(new BooleanField(200, true));
            Assert.That(fieldmap.GetBoolean(200), Is.EqualTo(true));
            fieldmap.SetField(new StringField(201, "N"));
            Assert.That(fieldmap.GetBoolean(201), Is.EqualTo(false));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetString(99900); });
        }

        [Test]
        public void IntFieldTest()
        {

            IntField field = new IntField(200, 101);
            IntField refield = new IntField(200);
            fieldmap.SetField(field);
            fieldmap.GetField(refield);
            Assert.That(101, Is.EqualTo(refield.Obj));
            field.setValue(102);
            fieldmap.SetField(field);
            IntField r = fieldmap.GetField(refield);
            Assert.That(102, Is.EqualTo(refield.Obj));

            Assert.AreSame(r, refield);
        }

        [Test]
        public void GetIntTest()
        {

            IntField field = new IntField(200, 101);
            fieldmap.SetField(field);
            Assert.That(fieldmap.GetInt(200), Is.EqualTo(101));
            fieldmap.SetField(new StringField(202, "2222"));
            Assert.That(fieldmap.GetInt(202), Is.EqualTo(2222));
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetInt(99900); });
        }

        [Test]
        public void DecimalFieldTest()
        {
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            DecimalField refield = new DecimalField(200);
            fieldmap.SetField(field);
            fieldmap.GetField(refield);
            Assert.That(101.0001, Is.EqualTo(refield.Obj));
            field.setValue(new Decimal(101.0002));
            fieldmap.SetField(field);
            DecimalField r = fieldmap.GetField(refield);
            Assert.That(101.0002, Is.EqualTo(refield.Obj));

            Assert.AreSame(r, refield);
        }

        [Test]
        public void DefaultFieldTest()
        {
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            fieldmap.SetField(field);
            string refield = fieldmap.GetField(200);
            Assert.That("101.0001", Is.EqualTo(refield));
        }

        [Test]
        public void SetFieldOverwriteTest()
        {
            IntField field = new IntField(21901, 1011);
            IntField refield = new IntField(21901);
            fieldmap.SetField(field, false);
            fieldmap.GetField(refield);
            Assert.That(1011, Is.EqualTo(refield.Obj));
            field.setValue(1021);
            IntField refield2 = new IntField(21901);
            fieldmap.SetField(field, false);
            fieldmap.GetField(refield2);
            Assert.That(refield.Obj, Is.EqualTo(1011));
            fieldmap.SetField(field, true);
            IntField refield3 = new IntField(21901);
            fieldmap.GetField(refield3);
            Assert.That(1021, Is.EqualTo(refield3.Obj));
        }

        [Test]
        public void FieldNotFoundTest()
        {
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetField(99900); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetField(new DateTimeField(1002030)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { fieldmap.GetField(new CharField(23099)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { fieldmap.GetField(new BooleanField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                 delegate { fieldmap.GetField(new StringField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetField(new IntField(99900)); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetField(new DecimalField(99900)); });
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
            Assert.AreEqual(100, g1.Field); //counter
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
                delegate { fieldmap.GetGroup(0, 101); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetGroup(3, 100); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetGroup(1, 101); });
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
                delegate { fieldmap.RemoveGroup(0, 101); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.RemoveGroup(3, 100); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.RemoveGroup(1, 101); });

            fm.RemoveGroup(1, 100);
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetGroup(2, 100); });
            fm.RemoveGroup(1, 100);
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.GetGroup(1, 100); });
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
                delegate { fieldmap.ReplaceGroup(0, 101, g3); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.ReplaceGroup(3, 100, g3); });
            Assert.Throws(typeof(FieldNotFoundException),
                delegate { fieldmap.ReplaceGroup(1, 101, g3); });

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
