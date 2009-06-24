using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET
{
    public abstract class FieldMap
    {
        public FieldMap()
        {
            this._fields = new Dictionary<int, QuickFIX.NET.Fields.IField>();
        }

        protected Dictionary<int, Fields.IField> _fields;

        public void setField(Fields.IField field)
        {
            _fields[field.Tag] = field;
        }

        public void getField(Fields.BooleanField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.BooleanField)_fields[field.Tag]).Obj;
        } 
        
        public void getField(Fields.StringField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.StringField)_fields[field.Tag]).Obj;
        }

        public void getField(Fields.CharField field)
        {
            if(_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.CharField)_fields[field.Tag]).Obj;
        }

        public void getField(Fields.IntField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.IntField)_fields[field.Tag]).Obj;
        }

        public void getField(Fields.DecimalField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.DecimalField)_fields[field.Tag]).Obj;
        }

        /// <summary>
        /// getField without a type defaults to returning a string
        /// </summary>
        /// <param name="tag"></param>
        public string getField(int tag)
        {
            return _fields[tag].ToString();
        }
    }
}
