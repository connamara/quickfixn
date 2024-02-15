using System;
using System.Collections.Generic;
using DDTool.Exceptions;

namespace DDTool.Structures;

public class DataDictionary {
    /// <summary>
    /// This is purely informative.  You can set it to nonsense if you want.
    /// </summary>
    /// <value></value>
    public string SourceFile { get; }

    public int? MajorVersion { get; set; }
    public int? MinorVersion { get; set; }
    public int? ServicePack { get; set; }
    public bool IsFIXT { get; set; }

    public Dictionary<int, DDField> FieldsByTag { get; } = new();
    public Dictionary<string, DDField> FieldsByName { get; } = new();
    public Dictionary<string, DDMessage> Messages { get; } = new();

    public DataDictionary(string sourceFile) {
        SourceFile = sourceFile;
    }

    /// <summary>
    /// A combination of type/Major/Minor/SP.
    /// This is NOT the FIX BeginString.
    /// </summary>
    /// <value>e.g. "FIX.4.2", "FIXT.1.1", "FIX.5.0.SP2"</value>
    public string Identifier
    {
        get
        {
            var prefix = IsFIXT ? "FIXT" : "FIX";
            var svcPack = ServicePack is null ? "" : $"SP{ServicePack}";
            return $"{prefix}.{MajorVersion}.{MinorVersion}{svcPack}";
        }
    }

    /// <summary>
    /// Returns e.g. "FIX42", "FIXT11", "FIX50SP2"
    /// </summary>
    public string IdentifierNoDots => Identifier.Replace(".", "");

    public void AddField(DDField fld) {
        if (FieldsByTag.ContainsKey(fld.Tag))
            throw new ParsingException($"Field tag is defined twice: {fld.Tag}");
        FieldsByTag[fld.Tag] = fld;

        if (FieldsByName.ContainsKey(fld.Name))
            throw new ParsingException($"Field name is defined twice: {fld.Tag}");
        FieldsByName[fld.Name] = fld;
    }

    public void AddMessage(DDMessage msg) {
        if (Messages.ContainsKey(msg.MsgType))
            throw new ParsingException($"Message type is defined twice: {msg.MsgType}");
        Messages[msg.MsgType] = msg;
    }

    /// <summary>
    /// Lookup the field by name.  Throw ParsingException if not found.
    /// </summary>
    /// <param name="fieldName"></param>
    public DDField LookupField(string fieldName) {
        if (!FieldsByName.ContainsKey(fieldName))
            throw new ParsingException($"Field '{fieldName}' is not defined in <fields> section.");
        return FieldsByName[fieldName];
    }
}
