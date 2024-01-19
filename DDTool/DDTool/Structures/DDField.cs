using System;
using System.Collections.Generic;

namespace DDTool.Structures;

public class DDField : IElement {
    public int Tag { get; }
    public string Name { get; }
    public List<EnumValue> Enums { get; set; }
    public string TypeFromXml { get; }
    public string CsClass { get; }
    public string BaseType { get; }

    public override string ToString() {
        return $"{Tag}/{Name}/{TypeFromXml} CsClass={CsClass} BaseType={BaseType} EnumsCount={Enums.Count}";
    }

    /// <summary>
    /// Represents a field from a DataDictionary file.
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="name"></param>
    /// <param name="enums">dictionary of enum=>description values</param>
    /// <param name="typeFromXml">the 'type' attribute from XML</param>
    public DDField(int tag, string name, List<EnumValue> enums, string typeFromXml) {
        this.Tag = tag;
        this.Name = name;
        this.Enums = new List<EnumValue>(enums);
        this.TypeFromXml = typeFromXml.ToUpperInvariant();

        DeriveTypeInfo(typeFromXml, out string csClass, out string baseType );
        this.CsClass = csClass;
        this.BaseType = baseType;
    }

    private static void DeriveTypeInfo(string typeFromXml, out string csClass, out string baseType) {
        switch (typeFromXml.ToUpperInvariant()) {
            case "CHAR":
                csClass = "CharField";
                baseType = "char";
                return;
            case "INT":
            case "NUMINGROUP":
            case "LENGTH":
                csClass = "IntField";
                baseType = "int";
                return;
            case "SEQNUM":
                csClass = "SeqNumFieldType";
                baseType = "SeqNumType";
                return;
            case "AMT":
            case "PERCENTAGE":
            case "PRICE":
            case "QTY":
            case "PRICEOFFSET":
            case "FLOAT":
                csClass = "DecimalField";
                baseType = "Decimal";
                return;
            case "UTCTIMESTAMP":
            case "TZTIMESTAMP":
            case "TIME":
                csClass = "DateTimeField";
                baseType = "DateTime";
                return;
            case "UTCDATEONLY":
            case "UTCDATE":
            case "DATE":
                csClass = "DateOnlyField";
                baseType = "DateTime";
                return;
            case "UTCTIMEONLY":
                csClass = "TimeOnlyField";
                baseType = "DateTime";
                return;
            case "BOOLEAN":
                csClass = "BooleanField";
                baseType = "Boolean";
                return;
            case "STRING":
            case "MULTIPLEVALUESTRING":
            case "MULTIPLECHARVALUE":
            case "DATA":
            case "EXCHANGE":
            case "LOCALMKTDATE":
            case "MONTHYEAR":
            case "DAYOFMONTH":
            case "COUNTRY":
            case "TZTIMEONLY":
            case "MULTIPLESTRINGVALUE":
            case "XMLDATA":
            case "LANGUAGE":
            case "CURRENCY":
                csClass = "StringField";
                baseType = "string";
                return;
            default:
                throw new Exception($"field type not supported! #{typeFromXml}");
        }
    }
}
