using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            this.FieldType = FieldTypeFromFix(this.FixFldType, out this._isMultipleValueFieldWithEnums);
        }

        /// <summary>
        /// Converter used only by the obsolete constructor and Enums attribute.
        /// </summary>
        private static Dictionary<string,string> HashSetToDict(HashSet<String> enums)
        {
            Dictionary<String, String> dict = new Dictionary<string, string>();
            foreach (String s in enums)
                dict[s] = "";
            return dict;
        }

        /// <summary>
        /// Old version of constructor.  Discarded in favor of version that takes Dictionary instead of HashSet
        /// (so that enum desc strings can be preserved).
        /// </summary>
        [Obsolete("Use DDField(int,String,Dictionary<String,String>,string) instead")]
        public DDField(int tag, String name, HashSet<String> enums, String fixFldType)
            : this(tag, name, HashSetToDict(enums), fixFldType)
        { }

        //TODO in version 2.0 - these probably shouldn't be public writable
        public int Tag;
        public String Name;
        public Dictionary<String, String> EnumDict;
        public String FixFldType;
        public Type FieldType;

        /// <summary>
        /// true if FIX field has an enum and if its type is one of: {MultipleValueString,MultipleStringValue,MultipleCharValue}
        /// </summary>
        public bool IsMultipleValueFieldWithEnums { get { return _isMultipleValueFieldWithEnums; } }
        private bool _isMultipleValueFieldWithEnums;

        /// <summary>
        /// Replaced by EnumDict, which preserves the enum's description.
        /// This attribute is a wrapper around EnumDict for backward-compatibility only.
        /// The getter constructs a new HashSet, so is probably inefficient.
        /// The setter sets EnumDict where all values are empty string.
        /// </summary>
        [Obsolete("Use EnumDict instead.  See this property's doc comments.")]
        public HashSet<String> Enums
        {
            get { return new HashSet<String>(EnumDict.Keys); }
            set { EnumDict = HashSetToDict(value); }
        }

        /// <summary>
        /// This field deprecated because it makes no sense; being required is not a quality of the field,
        /// but a quality of the message that contains the field.
        /// </summary>
        [Obsolete("Always false.  Use the containing message's DDMap.ReqFields instead.")]
        public Boolean Required
        {
            get { return false; }
            set { }
        }

        public Boolean HasEnums()
        {
            return EnumDict.Count > 0;
        }

        [Obsolete("Will be removed from the public interface in a future major release.")]
        public Type FieldTypeFromFix(String type)
        {
            bool discardedVar = false;
            return FieldTypeFromFix(type, out discardedVar);
        }
        
        private Type FieldTypeFromFix(String type, out bool multipleValueFieldWithEnums )
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
                case "MULTIPLEVALUESTRING": multipleValueFieldWithEnums = true; return typeof( Fields.StringField );
                case "MULTIPLESTRINGVALUE": multipleValueFieldWithEnums = true; return typeof( Fields.StringField );
                case "MULTIPLECHARVALUE": multipleValueFieldWithEnums = true; return typeof( Fields.StringField );
                case "EXCHANGE": return typeof(Fields.StringField);
                case "UTCTIMESTAMP": return typeof(Fields.DateTimeField);
                case "BOOLEAN": return typeof(Fields.BooleanField);
                case "LOCALMKTDATE": return typeof(Fields.StringField);
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
