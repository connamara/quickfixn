﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFix.DataDictionary;

namespace UnitTests;

[TestFixture]
public class DDFieldTests
{
    [Test]
    public void CtorEnum()
    {
        Dictionary<string, string> enums = new()
        {
            ["a"] = "AAA",
            ["b"] = "BBB"
        };

        DDField ddf = new(5, "Foo", enums, "STRING");

        Assert.That(5, Is.EqualTo(ddf.Tag));
        Assert.That("Foo", Is.EqualTo(ddf.Name));
        Assert.That(enums, Is.EqualTo(ddf.EnumDict));
        Assert.That("STRING", Is.EqualTo(ddf.FixFldType));
        Assert.That(typeof(QuickFix.Fields.StringField), Is.EqualTo(ddf.FieldType));

        Assert.That(ddf.IsMultipleValueFieldWithEnums, Is.False);
        Assert.That(ddf.HasEnums(), Is.True);
    }

    [Test]
    public void CtorMultipleValueFieldWithEnums()
    {
        DDField ddf = new(111, "MultiX", new Dictionary<string, string>(), "MULTIPLEVALUESTRING");

        Assert.That(111, Is.EqualTo(ddf.Tag));
        Assert.That("MultiX", Is.EqualTo(ddf.Name));
        Assert.That(0, Is.EqualTo(ddf.EnumDict.Count));
        Assert.That("MULTIPLEVALUESTRING", Is.EqualTo(ddf.FixFldType));
        Assert.That(typeof(QuickFix.Fields.StringField), Is.EqualTo(ddf.FieldType));

        Assert.That(ddf.IsMultipleValueFieldWithEnums, Is.True);
        Assert.That(ddf.HasEnums(), Is.False);
    }
}
