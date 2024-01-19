using System;
using DDTool.Structures;

namespace DDTool.Validations;

public enum QfnFieldClass
{
    CharField, IntField, DecimalField, DateTimeField, DateOnlyField, TimeOnlyField, BooleanField, StringField
}

public static class FieldTypeInfo {
    public class FieldTypeInfoException : ApplicationException {
        public FieldTypeInfoException(string msg)
            : base(msg) {
        }
    }

    public static QfnFieldClass GetQfnFieldClass(DDField field) {
        switch (field.TypeFromXml) {
            case "CHAR":
                return QfnFieldClass.CharField;
            case "INT":
            case "NUMINGROUP":
            case "SEQNUM":
            case "LENGTH":
                return QfnFieldClass.IntField;
            case "AMT":
            case "PERCENTAGE":
            case "PRICE":
            case "QTY":
            case "PRICEOFFSET":
            case "FLOAT":
                return QfnFieldClass.DecimalField;
            case "UTCTIMESTAMP":
            case "TZTIMESTAMP":
            case "TIME":
                return QfnFieldClass.DateTimeField;
            case "UTCDATEONLY":
            case "UTCDATE":
            case "DATE":
                return QfnFieldClass.DateOnlyField;
            case "UTCTIMEONLY":
                return QfnFieldClass.TimeOnlyField;
            case "BOOLEAN":
                return QfnFieldClass.BooleanField;
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
                return QfnFieldClass.StringField;

            default:
                throw new FieldTypeInfoException($"Incorrect or unsupported FIX data type: {field.TypeFromXml}");
        }
    }

    public static string GetBaseType(DDField field) {
        var qfnFieldClass = GetQfnFieldClass(field);
        switch (qfnFieldClass) {
            case QfnFieldClass.CharField:
                return "char";
            case QfnFieldClass.IntField:
                return "int";
            case QfnFieldClass.DecimalField:
                return "decimal";
            case QfnFieldClass.DateTimeField:
            case QfnFieldClass.DateOnlyField:
            case QfnFieldClass.TimeOnlyField:
                return "DateTime";
            case QfnFieldClass.BooleanField:
                return "Boolean";
            case QfnFieldClass.StringField:
                return "string";

            default:
                // dev added a new QfnFieldClass but forgot to update this function
                throw new ApplicationException($"Unsupported QfnFieldClass: {qfnFieldClass.ToString()}");
        }
    }
}
