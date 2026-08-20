using System;
using NUnit.Framework;
using QuickFix;

namespace UnitTests;

[TestFixture]
public class MessageFactoryBuilderTests
{
    [Test]
    public void MessageFactoryBuilderTest_None()
    {
        var mf = new MessageFactoryBuilder()
            .Build();

        var m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.Not.InstanceOf<QuickFix.FIX42.Allocation>());

        var m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.Not.InstanceOf<QuickFix.FIX43.BidRequest>());

        var m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.Not.InstanceOf<QuickFix.FIX44.Advertisement>());
    }

    [Test]
    public void MessageFactoryBuilderTest_Typed()
    {
        var mf = new MessageFactoryBuilder()
            .Add<QuickFix.FIX42.MessageFactory>()
            .Add(typeof(QuickFix.FIX44.MessageFactory))
            .Build();

        var m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.InstanceOf<QuickFix.FIX42.Allocation>());

        var m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.Not.InstanceOf<QuickFix.FIX43.BidRequest>());

        var m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.InstanceOf<QuickFix.FIX44.Advertisement>());
    }

    [Test]
    public void MessageFactoryBuilderTest_LoadedDlls()
    {
        var mf = new MessageFactoryBuilder()
            .AddLoadedDlls()
            .Build();

        var m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.InstanceOf<QuickFix.FIX42.Allocation>());

        var m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.InstanceOf<QuickFix.FIX43.BidRequest>());
        
        var m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.InstanceOf<QuickFix.FIX44.Advertisement>());
    }

    [Test]
    public void MessageFactoryBuilderTest_LocalDlls()
    {
        var mf = new MessageFactoryBuilder()
            .LoadLocalDlls()
            .Build();

        var m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.InstanceOf<QuickFix.FIX42.Allocation>());

        var m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.InstanceOf<QuickFix.FIX43.BidRequest>());

        var m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.InstanceOf<QuickFix.FIX44.Advertisement>());
    }

    [Test]
    public void MessageFactoryBuilderTest_Assemblies()
    {
        var mf = new MessageFactoryBuilder()
            .Add(typeof(QuickFix.FIX42.Message).Assembly)
            .Add(typeof(QuickFix.FIX43.Message).Assembly)
            .Build();

        var m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.InstanceOf<QuickFix.FIX42.Allocation>());

        var m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.InstanceOf<QuickFix.FIX43.BidRequest>());

        var m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.Not.InstanceOf<QuickFix.FIX44.Advertisement>());
    }
}
