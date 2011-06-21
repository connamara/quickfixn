using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    partial class DataDictionaryParser
    {
        private sealed class FieldEntry
        {
            public FieldEntry(string name, int tag, Type type)
            {
                FieldType = type;
                Tag = tag;
                Name = name;
            }

            #region Properties
            public string Name { get; private set; }
            public int Tag { get; private set; }
            public Type FieldType { get; private set; }
            #endregion

            public static FieldEntry MakeFromType(string name, int tag, string type)
            {
                switch (type)
                {
                    case "STRING": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "CHAR": return new FieldEntry(name, tag, typeof(Fields.CharField));
                    case "PRICE": return new FieldEntry(name, tag, typeof(Fields.DecimalField));
                    case "INT": return new FieldEntry(name, tag, typeof(Fields.IntField));
                    case "AMT": return new FieldEntry(name, tag, typeof(Fields.DecimalField));
                    case "QTY": return new FieldEntry(name, tag, typeof(Fields.DecimalField));
                    case "CURRENCY": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "MULTIPLEVALUESTRING": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "EXCHANGE": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "UTCTIMESTAMP": return new FieldEntry(name, tag, typeof(Fields.DateTimeField));
                    case "BOOLEAN": return new FieldEntry(name, tag, typeof(Fields.BooleanField));
                    case "LOCALMKTDATE": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "DATA": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "FLOAT": return new FieldEntry(name, tag, typeof(Fields.DecimalField));
                    case "PRICEOFFSET": return new FieldEntry(name, tag, typeof(Fields.DecimalField));
                    case "MONTHYEAR": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "DAYOFMONTH": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "UTCDATEONLY": return new FieldEntry(name, tag, typeof(Fields.DateTimeField));
                    case "UTCDATE": return new FieldEntry(name, tag, typeof(Fields.DateTimeField));
                    case "UTCTIMEONLY": return new FieldEntry(name, tag, typeof(Fields.DateTimeField));
                    case "Time": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    case "NUMINGROUP": return new FieldEntry(name, tag, typeof(Fields.IntField));
                    case "PERCENTAGE": return new FieldEntry(name, tag, typeof(Fields.DecimalField));
                    case "SEQNUM": return new FieldEntry(name, tag, typeof(Fields.IntField));
                    case "LENGTH": return new FieldEntry(name, tag, typeof(Fields.IntField));
                    case "COUNTRY": return new FieldEntry(name, tag, typeof(Fields.StringField));
                    default: throw new DictionaryParseException("invalid type: " + type);
                }
            }
        }
    }
}
