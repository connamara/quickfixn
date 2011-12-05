using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.DataDictionary
{
    public class DDField
    {
        public DDField(int tag, String name, HashSet<String> enums, String fixFldType)
        {
            this.Tag = tag;
            this.Name = name;
            this.Enums = enums;
            this.FixFldType = fixFldType;
            this.FieldType = FieldTypeFromFix(this.FixFldType);
        }

        public int Tag;
        public String Name;
        public HashSet<String> Enums;
        public String FixFldType;
        public Boolean Required = false;
        public Type FieldType;

        public Boolean HasEnums()
        {
            return Enums.Count > 0;
        }

        public Type FieldTypeFromFix(String type)
        {
            switch (type)
            {
                case "STRING": return typeof(Fields.StringField);
                case "CHAR": return typeof(Fields.CharField);
                case "PRICE": return typeof(Fields.DecimalField);
                case "INT": return typeof(Fields.IntField);
                case "AMT": return typeof(Fields.DecimalField);
                case "QTY": return typeof(Fields.DecimalField);
                case "CURRENCY": return typeof(Fields.StringField);
                case "MULTIPLEVALUESTRING": return typeof(Fields.StringField);
                case "MULTIPLESTRINGVALUE": return typeof(Fields.StringField);
                case "MULTIPLECHARVALUE": return typeof(Fields.StringField);
                case "EXCHANGE": return typeof(Fields.StringField);
                case "UTCTIMESTAMP": return typeof(Fields.DateTimeField);
                case "BOOLEAN": return typeof(Fields.BooleanField);
                case "LOCALMKTDATE": return typeof(Fields.StringField);
                case "DATA": return typeof(Fields.StringField);
                case "FLOAT": return typeof(Fields.DecimalField);
                case "PRICEOFFSET": return typeof(Fields.DecimalField);
                case "MONTHYEAR": return typeof(Fields.StringField);
                case "DAYOFMONTH": return typeof(Fields.StringField);
                case "UTCDATE": return typeof(Fields.DateTimeField);
                case "UTCDATEONLY": return typeof(Fields.DateOnlyField);
                case "UTCTIMEONLY": return typeof(Fields.TimeOnlyField);
                case "NUMINGROUP": return typeof(Fields.IntField);
                case "PERCENTAGE": return typeof(Fields.DecimalField);
                case "SEQNUM": return typeof(Fields.IntField);
                case "LENGTH": return typeof(Fields.IntField);
                case "COUNTRY": return typeof(Fields.StringField);
                case "TZTIMEONLY": return typeof(Fields.StringField);
                case "TZTIMESTAMP": return typeof(Fields.StringField); 
                case "XMLDATA": return typeof(Fields.StringField);
                case "LANGUAGE": return typeof(Fields.StringField);

                case "TIME": return typeof(Fields.DateTimeField);
                case "DATE": return typeof(Fields.StringField);
                default: throw new DictionaryParseException("invalid type: " + type);
            }
        }
    }
}
