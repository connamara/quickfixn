using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFIX.NET;

namespace UnitTests
{
    [TestFixture]
    public class DataDictionaryTests
    {
        [Test]
        public void FieldEntryTest()
        {
            QuickFIX.NET.DataDictionary dd = new QuickFIX.NET.DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Assert.That(dd.MajorVersion, Is.EqualTo("4"));
            Assert.That(dd.MinorVersion, Is.EqualTo("4"));
            Assert.That(dd.Version, Is.EqualTo("FIX.4.4"));
        }

        public void MakeFromType()
        {
            DataDictionary dd = new DataDictionary();
            dd.Load("../../../spec/fix/FIX44.xml");
            Type ft = dd.GetFieldType(1);
            QuickFIX.NET.Fields.IntField field = (QuickFIX.NET.Fields.IntField)Activator.CreateInstance(dd.GetFieldType(1));
            field.Tag = 1;
            field.Obj = 2;
            Assert.That(field.Tag, Is.EqualTo(1));
            Assert.That(field.Obj, Is.EqualTo(2));
        }
    }
}