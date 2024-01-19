using System;
using System.IO;
using System.Text;
using System.Xml;
using DDTool.Structures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Parsers;

public enum ParserTask
{
    Version,
    Fields,
    Messages
}

public static class ParserTestUtil {
    public static DataDictionary ReadDD(string xml, ParserTask task) {
        var dd = new DataDictionary("unittest");

        XmlReaderSettings readerSettings = new XmlReaderSettings();
        readerSettings.IgnoreComments = true;
        using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml))) {
            using (var reader = XmlReader.Create(stream, readerSettings)) {
                var doc = new XmlDocument();
                doc.Load(reader);

                switch (task) {
                    case ParserTask.Version:
                        DDTool.Parsers.VersionParser.SetVersionInfo(doc, dd);
                        break;
                    case ParserTask.Fields:
                        DDTool.Parsers.FieldParser.ParseFields(doc, dd);
                        break;
                    case ParserTask.Messages:
                        DDTool.Parsers.FieldParser.ParseFields(doc, dd);
                        DDTool.Parsers.MessageParser.ParseMessages(doc, dd);
                        break;
                    default:
                        Assert.Fail("unsupported task");
                        break;
                }
            }
        }

        return dd;
    }
}
