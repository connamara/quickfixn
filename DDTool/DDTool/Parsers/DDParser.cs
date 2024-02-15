using System;
using System.Xml;
using DDTool.Structures;

namespace DDTool.Parsers;

public static class DDParser {
    public static DataDictionary ParseFile(string path) {
        var dd = new DataDictionary(path);

        XmlReaderSettings readerSettings = new() { IgnoreComments = true };

        using (var reader = XmlReader.Create(path, readerSettings)) {
            var doc = new XmlDocument();
            doc.Load(reader);

            VersionParser.SetVersionInfo(doc, dd);
            FieldParser.ParseFields(doc, dd);
            MessageParser.ParseMessages(doc, dd);
            /*
            ParseHeader(RootDoc);
            ParseTrailer(RootDoc)
            */
        }

        return dd;
    }
}
