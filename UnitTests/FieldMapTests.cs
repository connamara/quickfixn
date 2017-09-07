using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using QuickFix;
using QuickFix.Fields;

namespace UnitTests
{
    public class FieldMapTests
    {
        private FieldMap fieldmap;
        public FieldMapTests()
        {
            this.fieldmap = new FieldMap();
        }

        [Fact]
        public void CharFieldTest()
        {

            CharField field = new CharField(100, 'd');
            fieldmap.SetField(field);
            CharField refield = new CharField(100);
            fieldmap.GetField(refield);
            Assert.Equal('d', refield.Obj);
            field.Obj = 'e';
            fieldmap.SetField(field);
            CharField r = fieldmap.GetField(refield);
            Assert.Equal('e', refield.Obj);

            Assert.Same(refield, r);
        }
        
        [Fact]
        public void GetCharTest()
        {
            fieldmap.SetField(new CharField(20, 'a'));
            Assert.Equal('a', fieldmap.GetChar(20));
            fieldmap.SetField(new StringField(21, "b"));
            Assert.Equal('b', fieldmap.GetChar(21));
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetString(99900); });
        }

        [Fact]
        public void GetDecimalTest()
        {
            var val = new Decimal(20.4);
            fieldmap.SetField(new DecimalField(200, val));
            Assert.Equal(fieldmap.GetDecimal(200), val);
            fieldmap.SetField(new StringField(201, "33.22"));
            Assert.Equal(33.22M, fieldmap.GetDecimal(201));
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetString(99900); });
        }

        [Fact]
        public void StringFieldTest()
        {

            fieldmap.SetField(new Account("hello"));
            Account acct = new Account();
            fieldmap.GetField(acct);
            Assert.Equal("hello", acct.Obj);
            fieldmap.SetField(new Account("helloworld"));
            StringField r = fieldmap.GetField(acct);
            Assert.Equal("helloworld", acct.getValue());

            Assert.Same(r, acct);
        }

        [Fact]
        public void GetStringTest()
        {
            fieldmap.SetField(new Account("hello"));
            Assert.Equal("hello", fieldmap.GetString(QuickFix.Fields.Tags.Account));
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetString(99900); });
        }

        [Fact]
        public void DateTimeFieldTest()
        {

            fieldmap.SetField(new DateTimeField(Tags.TransactTime, new DateTime(2009, 12, 10)));
            TransactTime tt = new TransactTime();
            fieldmap.GetField(tt);
            Assert.Equal(new DateTime(2009, 12, 10), tt.Obj);
            fieldmap.SetField(new TransactTime(new DateTime(2010, 12, 10)));
            DateTimeField r = fieldmap.GetField(tt);
            Assert.Equal(new DateTime(2010, 12, 10), tt.getValue());

            Assert.Same(r, tt);
        }

        [Fact]
        public void DateOnlyFieldTest()
        {
            fieldmap.SetField(new DateOnlyField(Tags.MDEntryDate, new DateTime(2009, 12, 10, 1, 2, 3)));
            MDEntryDate ed = new MDEntryDate();
            fieldmap.GetField(ed);
            Assert.Equal(new DateTime(2009, 12, 10), ed.Obj);
            fieldmap.SetField(new MDEntryDate(new DateTime(2010, 12, 10)));
            DateOnlyField r = fieldmap.GetField(ed);
            Assert.Equal(new DateTime(2010, 12, 10), ed.getValue());            
            
            Assert.Same(r, ed);
            Assert.Equal("20101210", ed.ToString());
        }

        [Fact]
        public void TimeOnlyFieldTest()
        {            
            fieldmap.SetField(new TimeOnlyField(Tags.MDEntryTime, new DateTime(1, 1, 1, 1, 2, 3), false));
            MDEntryTime et = new MDEntryTime();
            fieldmap.GetField(et);
            Assert.Equal(new DateTime(1, 1, 1, 1, 2, 3).TimeOfDay, et.Obj.TimeOfDay);
            fieldmap.SetField(new MDEntryTime(new DateTime(1, 1, 1, 1, 2, 5)));
            TimeOnlyField r = fieldmap.GetField(et);
            Assert.Equal(new DateTime(1, 1, 1, 1, 2, 5).TimeOfDay, et.getValue().TimeOfDay);
            
            Assert.Same(r, et);
            Assert.Equal("01:02:05.000", et.ToString());
        }

        [Fact]
        public void GetDateTimeTest()
        {
            fieldmap.SetField(new DateTimeField(Tags.TransactTime, new DateTime(2009, 12, 10)));
            Assert.Equal(fieldmap.GetDateTime(Tags.TransactTime), new DateTime(2009, 12, 10));
            fieldmap.SetField(new StringField(233, "20091211-12:12:44"));
            Assert.Equal(fieldmap.GetDateTime(233), new DateTime(2009, 12, 11, 12, 12, 44));
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetDateTime(99900); });
        }

        [Fact]
        public void GetDateOnlyTest()
        {
            fieldmap.SetField(new DateOnlyField(Tags.MDEntryDate, new DateTime(2009, 12, 10, 1, 2, 3)));
            Assert.Equal(new DateTime(2009, 12, 10), fieldmap.GetDateTime(Tags.MDEntryDate));
            fieldmap.SetField(new StringField(233, "20091211"));
            Assert.Equal(new DateTime(2009, 12, 11), fieldmap.GetDateOnly(233));
        }

        [Fact]
        public void GetTimeOnlyTest()
        {
            fieldmap.SetField(new TimeOnlyField(Tags.MDEntryTime, new DateTime(2009, 12, 10, 1, 2, 3)));
            Assert.Equal(new DateTime(2009, 12, 10, 1, 2, 3).TimeOfDay, fieldmap.GetDateTime(Tags.MDEntryTime).TimeOfDay);
            fieldmap.SetField(new StringField(233, "07:30:47"));
            Assert.Equal(new DateTime(2009, 12, 11, 7, 30, 47).TimeOfDay, fieldmap.GetTimeOnly(233).TimeOfDay);
        }

        [Fact]
        public void BooleanFieldTest()
        {
            BooleanField field = new BooleanField(200, true);
            BooleanField refield = new BooleanField(200);
            fieldmap.SetField(field);
            fieldmap.GetField(refield);
            Assert.True(refield.Obj);
            field.setValue(false);
            fieldmap.SetField(field);
            BooleanField r = fieldmap.GetField(refield);
            Assert.False(refield.Obj);

            Assert.Same(r, refield);
        }

        [Fact]
        public void GetBooleanTest()
        {
            fieldmap.SetField(new BooleanField(200, true));
            Assert.True(fieldmap.GetBoolean(200));
            fieldmap.SetField(new StringField(201, "N"));
            Assert.False(fieldmap.GetBoolean(201));
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetString(99900); });
        }

        [Fact]
        public void IntFieldTest()
        {

            IntField field = new IntField(200, 101);
            IntField refield = new IntField(200);
            fieldmap.SetField(field);
            fieldmap.GetField(refield);
            Assert.Equal(101,refield.Obj);
            field.setValue(102);
            fieldmap.SetField(field);
            IntField r = fieldmap.GetField(refield);
            Assert.Equal(102, refield.Obj);

            Assert.Same(r, refield);
        }

        [Fact]
        public void GetIntTest()
        {

            IntField field = new IntField(200, 101);
            fieldmap.SetField(field);
            Assert.Equal(101, fieldmap.GetInt(200));
            fieldmap.SetField(new StringField(202, "2222"));
            Assert.Equal(2222, fieldmap.GetInt(202));
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetInt(99900); });
        }

        [Fact]
        public void DecimalFieldTest()
        {
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            DecimalField refield = new DecimalField(200);
            fieldmap.SetField(field);
            fieldmap.GetField(refield);
            Assert.Equal(101.0001M, refield.Obj);
            field.setValue(new Decimal(101.0002));
            fieldmap.SetField(field);
            DecimalField r = fieldmap.GetField(refield);
            Assert.Equal(101.0002M, refield.Obj);

            Assert.Same(r, refield);
        }

        [Fact]
        public void DefaultFieldTest()
        {
            DecimalField field = new DecimalField(200, new Decimal(101.0001));
            fieldmap.SetField(field);
            string refield = fieldmap.GetField(200);
            Assert.Equal("101.0001", refield);
        }

        [Fact]
        public void SetFieldOverwriteTest()
        {
            IntField field = new IntField(21901, 1011);
            IntField refield = new IntField(21901);
            fieldmap.SetField(field, false);
            fieldmap.GetField(refield);
            Assert.Equal(1011, refield.Obj);
            field.setValue(1021);
            IntField refield2 = new IntField(21901);
            fieldmap.SetField(field, false);
            fieldmap.GetField(refield2);
            Assert.Equal(1011, refield.Obj);
            fieldmap.SetField(field, true);
            IntField refield3 = new IntField(21901);
            fieldmap.GetField(refield3);
            Assert.Equal(1021, refield3.Obj);
        }

        [Fact]
        public void FieldNotFoundTest()
        {
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetField(99900); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetField(new DateTimeField(1002030)); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetField(new CharField(23099)); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetField(new BooleanField(99900)); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetField(new StringField(99900)); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetField(new IntField(99900)); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetField(new DecimalField(99900)); });
        }

        [Fact]
        public void SimpleFieldOrderTest()
        {
            int[] fieldord = { 10, 11, 12, 13, 200 };
            FieldMap fm = new FieldMap(fieldord);
            Assert.Equal(fm.FieldOrder,fieldord);
        }

        [Fact]
        public void GroupDelimTest()
        {
            Group g1 = new Group(100, 200);
            Assert.Equal(100, g1.Field); //counter
            Assert.Equal(200, g1.Delim);

            g1.SetField(new StringField(200, "delim!"));

            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            Assert.Equal(1, fm.GetInt(100));

            Group g2 = new Group(100, 200);
            g2.SetField(new StringField(200, "again!"));
            fm.AddGroup(g2);
            Assert.Equal(2, fm.GetInt(100));
        }

        [Fact]
        public void AddGetGroupTest()
        {
            Group g1 = new Group(100, 200);
            Group g2 = new Group(100, 201);
            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            fm.AddGroup(g2);
            Assert.Equal(fm.GetGroup(1, 100), g1);
            Assert.Equal(fm.GetGroup(2, 100), g2);

            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetGroup(0, 101); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetGroup(3, 100); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetGroup(1, 101); });
        }

        [Fact]
        public void RemoveGroupTest()
        {
            Group g1 = new Group(100, 200);
            Group g2 = new Group(100, 201);
            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            fm.AddGroup(g2);
            Assert.Equal(fm.GetGroup(1, 100), g1);
            Assert.Equal(fm.GetGroup(2, 100),g2);

            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.RemoveGroup(0, 101); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.RemoveGroup(3, 100); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.RemoveGroup(1, 101); });

            fm.RemoveGroup(1, 100);
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetGroup(2, 100); });
            fm.RemoveGroup(1, 100);
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.GetGroup(1, 100); });
        }

        [Fact]
        public void ReplaceGroupTest()
        {
            Group g1 = new Group(100, 200);
            Group g2 = new Group(100, 201);
            FieldMap fm = new FieldMap();
            fm.AddGroup(g1);
            fm.AddGroup(g2);
            Assert.Equal(fm.GetGroup(1, 100), g1);
            Assert.Equal(fm.GetGroup(2, 100),g2);

            Group g3 = new Group(100, 202);
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.ReplaceGroup(0, 101, g3); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.ReplaceGroup(3, 100, g3); });
            Assert.Throws<FieldNotFoundException>(delegate { fieldmap.ReplaceGroup(1, 101, g3); });

            fm.ReplaceGroup(1, 100, g3);
            fm.ReplaceGroup(2, 100, g3);
            Assert.Equal(fm.GetGroup(1, 100), g3);
            Assert.Equal(fm.GetGroup(2, 100), g3);
        }

        [Fact]
        public void IsFieldSetTest()
        {
            FieldMap fieldmap = new FieldMap();
            BooleanField field = new BooleanField(200, true);
            Assert.False(fieldmap.IsSetField(field));
            Assert.False(fieldmap.IsSetField(field.Tag));
            fieldmap.SetField(field);
            Assert.True(fieldmap.IsSetField(field));
            Assert.True(fieldmap.IsSetField(field.Tag));
        }

        [Fact]
        public void ClearAndIsEmptyTest()
        {
            FieldMap fieldmap = new FieldMap();
            BooleanField field = new BooleanField(200, true);
            Assert.True(fieldmap.IsEmpty());
            fieldmap.SetField(field);
            Assert.False(fieldmap.IsEmpty());
            fieldmap.Clear();
            Assert.True(fieldmap.IsEmpty());
            Group g = new Group(100, 101);
            fieldmap.AddGroup(g);
            Assert.False(fieldmap.IsEmpty());
            fieldmap.Clear();
            Assert.True(fieldmap.IsEmpty());
        }

        [Fact]
        public void AddGroupKeepTypeTest()
        {
            // bug found during issue 56 - Group object was losing type after being added
            FieldMap fm = new FieldMap();
            QuickFix.FIX42.News.LinesOfTextGroup linesGroup = new QuickFix.FIX42.News.LinesOfTextGroup();
            linesGroup.Text = new QuickFix.Fields.Text("foo");
            fm.AddGroup(linesGroup);

            var rvGroup = fm.GetGroup(1, Tags.LinesOfText);
            Assert.IsType<QuickFix.FIX42.News.LinesOfTextGroup>(rvGroup);
        }
    }
}
