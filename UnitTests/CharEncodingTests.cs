using System;
using System.Text;
using NUnit.Framework;
using QuickFix;

namespace UnitTests;

[TestFixture]
public class CharEncodingTests
{
    [TearDown]
    public void TearDown()
    {
        CharEncoding.ResetToDefaultEncoding();
    }

    [Test]
    public void GetBytes_Simple()
    {
        CharEncoding.SetEncoding("iso-8859-1");
        byte[] isoBytes = CharEncoding.GetBytes("ïèâî");
        Assert.That(isoBytes, Is.EqualTo(new byte[] {0xEF, 0xE8, 0xE2, 0xEE}));

        CharEncoding.SetEncoding("windows-1251");
        byte[] altBytes = CharEncoding.GetBytes("пиво");
        Assert.That(altBytes, Is.EqualTo(new byte[] {0xEF, 0xE8, 0xE2, 0xEE}));
    }

    [Test]
    public void GetBytes_Pooled()
    {
        CharEncoding.SetEncoding("iso-8859-1");
        using ValueDisposable _ = CharEncoding.GetBytes("ïèâî", out ReadOnlySpan<byte> isoByteSpan);
        Assert.That(isoByteSpan.ToArray(), Is.EqualTo(new byte[] {0xEF, 0xE8, 0xE2, 0xEE}));

        CharEncoding.SetEncoding("windows-1251");
        using ValueDisposable _2 = CharEncoding.GetBytes("пиво", out ReadOnlySpan<byte> altByteSpan);
        Assert.That(altByteSpan.ToArray(), Is.EqualTo(new byte[] {0xEF, 0xE8, 0xE2, 0xEE}));
    }
}
