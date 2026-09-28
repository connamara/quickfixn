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
        IMessageFactory mf = new MessageFactoryBuilder()
            .Build();

        Message m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.Not.InstanceOf<QuickFix.FIX42.Allocation>());

        Message m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.Not.InstanceOf<QuickFix.FIX43.BidRequest>());

        Message m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.Not.InstanceOf<QuickFix.FIX44.Advertisement>());
    }

    [Test]
    public void MessageFactoryBuilderTest_Typed()
    {
        IMessageFactory mf = new MessageFactoryBuilder()
            .Add<QuickFix.FIX42.MessageFactory>()
            .Add(typeof(QuickFix.FIX44.MessageFactory))
            .Build();

        Message m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.InstanceOf<QuickFix.FIX42.Allocation>());

        Message m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.Not.InstanceOf<QuickFix.FIX43.BidRequest>());

        Message m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.InstanceOf<QuickFix.FIX44.Advertisement>());
    }

    [Test]
    public void MessageFactoryBuilderTest_LoadedDlls()
    {
        IMessageFactory mf = new MessageFactoryBuilder()
            .AddLoadedDlls()
            .Build();

        Message m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.InstanceOf<QuickFix.FIX42.Allocation>());

        Message m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.InstanceOf<QuickFix.FIX43.BidRequest>());
        
        Message m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.InstanceOf<QuickFix.FIX44.Advertisement>());
    }

    [Test]
    public void MessageFactoryBuilderTest_LocalDlls()
    {
        IMessageFactory mf = new MessageFactoryBuilder()
            .LoadLocalDlls()
            .Build();

        Message m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.InstanceOf<QuickFix.FIX42.Allocation>());

        Message m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.InstanceOf<QuickFix.FIX43.BidRequest>());

        Message m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.InstanceOf<QuickFix.FIX44.Advertisement>());
    }

    [Test]
    public void MessageFactoryBuilderTest_Assemblies()
    {
        IMessageFactory mf = new MessageFactoryBuilder()
            .Add(typeof(QuickFix.FIX42.Message).Assembly)
            .Add(typeof(QuickFix.FIX43.Message).Assembly)
            .Build();

        Message m42 = mf.Create("FIX.4.2", "J");
        Assert.That(m42, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m42, Is.InstanceOf<QuickFix.FIX42.Allocation>());

        Message m43 = mf.Create("FIX.4.3", "k");
        Assert.That(m43, Is.Not.TypeOf<QuickFix.Message>());
        Assert.That(m43, Is.InstanceOf<QuickFix.FIX43.BidRequest>());

        Message m44 = mf.Create("FIX.4.4", "7");
        Assert.That(m44, Is.TypeOf<QuickFix.Message>());
        Assert.That(m44, Is.Not.InstanceOf<QuickFix.FIX44.Advertisement>());
    }
}
