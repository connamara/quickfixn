using System;
using System.Collections.Generic;

namespace QuickFix.DataDictionary
{
    public class DDField
    {
        /// <summary>
        /// Represents field data from a DataDictionary file.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="name"></param>
        /// <param name="enums">dictionary of enum=>description values</param>
        /// <param name="fixFldType"></param>
        public DDField(int tag, String name, Dictionary<String, String> enums, String fixFldType)
        {
            this.Tag = tag;
            this.Name = name;
            this.EnumDict = enums;
            this.FixFldType = fixFldType;
            this.FieldType = FieldTypeFromFix(this.FixFldType, out bool isMVFWE);
            this.IsMultipleValueFieldWithEnums = isMVFWE;
        }

        public int Tag { get; private set; }
        public String Name { get; private set; }
        public Dictionary<String, String> EnumDict { get; private set; }
        public String FixFldType { get; private set; }
        public Type FieldType { get; private set; }

        /// <summary>
        /// true if FIX field has an enum and if its type is one of: {MultipleValueString,MultipleStringValue,MultipleCharValue}
        /// </summary>
        public bool IsMultipleValueFieldWithEnums { get; private set; }

        public Boolean HasEnums()
        {
            return EnumDict.Count > 0;
        }

        private Type FieldTypeFromFix(String type, out bool multipleValueFieldWithEnums)
        {
            multipleValueFieldWithEnums = false;

            switch (type)
            {
                case "STRING": return typeof(Fields.StringField);
                case "CHAR": return typeof(Fields.CharField);
                case "PRICE": return typeof(Fields.DecimalField);
                case "INT": return typeof(Fields.IntField);
                case "AMT": return typeof(Fields.DecimalField);
                case "QTY": return typeof(Fields.DecimalField);
                case "CURRENCY": return typeof(Fields.StringField);
                case "MULTIPLEVALUESTRING": multipleValueFieldWithEnums = true; return typeof(Fields.StringField);
                case "MULTIPLESTRINGVALUE": multipleValueFieldWithEnums = true; return typeof(Fields.StringField);
                case "MULTIPLECHARVALUE": multipleValueFieldWithEnums = true; return typeof(Fields.StringField);
                case "EXCHANGE": return typeof(Fields.StringField);
                case "UTCTIMESTAMP": return typeof(Fields.DateTimeField);
                case "BOOLEAN": return typeof(Fields.BooleanField);
                case "LOCALMKTDATE": return typeof(Fields.StringField);
                case "LOCALMKTTIME": return typeof(Fields.StringField);
                case "DATA": return typeof(Fields.StringField);
                case "FLOAT": return typeof(Fields.DecimalField);
                case "PRICEOFFSET": return typeof(Fields.DecimalField);
                case "MONTHYEAR": return typeof(Fields.StringField);
                case "DAYOFMONTH": return typeof(Fields.StringField);
                case "UTCDATE": return typeof(Fields.DateOnlyField);
                case "UTCDATEONLY": return typeof(Fields.DateOnlyField);
                case "UTCTIMEONLY": return typeof(Fields.TimeOnlyField);
                case "NUMINGROUP": return typeof(Fields.IntField);
                case "PERCENTAGE": return typeof(Fields.DecimalField);
                case "SEQNUM": return typeof(Fields.IntField);
                case "TAGNUM": return typeof(Fields.IntField);
                case "LENGTH": return typeof(Fields.IntField);
                case "COUNTRY": return typeof(Fields.StringField);
                case "TZTIMEONLY": return typeof(Fields.StringField);
                case "TZTIMESTAMP": return typeof(Fields.StringField);
                case "XMLDATA": return typeof(Fields.StringField);
                case "LANGUAGE": return typeof(Fields.StringField);
                case "XID": return typeof(Fields.StringField);
                case "XIDREF": return typeof(Fields.StringField);

                case "TIME": return typeof(Fields.DateTimeField);
                case "DATE": return typeof(Fields.StringField);
                default: throw new DictionaryParseException("invalid type: " + type);
            }
        }
    }
}
