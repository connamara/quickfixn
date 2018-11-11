using NUnit.Framework;
using QuickFix;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace UnitTests {
  [TestFixture]
  public class MultibyteCharTests {
    [Test]
    public void SocketInitiatorTest() {

      var sit = new SocketInitiatorThread(null, null, null, null);
      string str = 'a' + new string((char)0x0430, 260); // Error
      //string str = new string((char)0x0430, 260);     // OK

      byte[] buf = Encoding.UTF8.GetBytes(str);
      MemoryStream ms = new MemoryStream(buf);
      sit.GetType().GetField("stream_", BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.Instance).SetValue(sit, ms);
      sit.Read();
      sit.Read();

      var parser = sit.GetType().GetField("parser_", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance).GetValue(sit);
      var usedBufferLength = parser.GetType().GetField("usedBufferLength", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance).GetValue(parser);
      Assert.That((int)usedBufferLength == buf.Length);
    }

    [Test]
    public void SocketReaderTest() {

      SocketReader sr = FormatterServices.GetUninitializedObject(typeof(SocketReader)) as SocketReader;

      string str = 'a' + new string((char)0x0430, 260); // Error
      //string str = new string((char)0x0430, 260);     // OK

      byte[] buf = Encoding.UTF8.GetBytes(str);
      MemoryStream ms = new MemoryStream(buf);
      byte[] readBuffer = new byte[512];
      Parser parser = new Parser();
      sr.GetType().GetField("readBuffer_", BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.Instance).SetValue(sr, readBuffer);
      sr.GetType().GetField("parser_", BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.Instance).SetValue(sr, parser);
      sr.GetType().GetField("stream_", BindingFlags.NonPublic | BindingFlags.SetField | BindingFlags.Instance).SetValue(sr, ms);
      sr.Read();
      sr.Read();

      var usedBufferLength = parser.GetType().GetField("usedBufferLength", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance).GetValue(parser);
      Assert.That((int)usedBufferLength == buf.Length);

    }
  }
}
