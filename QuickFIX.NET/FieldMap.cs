using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET
{
    public abstract class FieldMap
    {
        public FieldMap()
        { }

        public void setField(Fields.IField field)
        {
            _fields[field.Tag] = field;
        }

        public void getField(Fields.BooleanField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.BooleanField)_fields[field.Tag]).Obj;
            else
                throw new FieldNotFoundException(field.Tag);
        } 
        
        public void getField(Fields.StringField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.StringField)_fields[field.Tag]).Obj;
            else
                throw new FieldNotFoundException(field.Tag);
        }

        public void getField(Fields.CharField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.CharField)_fields[field.Tag]).Obj;
            else
                throw new FieldNotFoundException(field.Tag);
        }

        public void getField(Fields.IntField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.IntField)_fields[field.Tag]).Obj;
            else
                throw new FieldNotFoundException(field.Tag);
        }

        public void getField(Fields.DecimalField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.DecimalField)_fields[field.Tag]).Obj;
            else
                throw new FieldNotFoundException(field.Tag);
        }

        public void getField(Fields.DateTimeField field)
        {
            if (_fields.ContainsKey(field.Tag))
                field.Obj = ((Fields.DateTimeField)_fields[field.Tag]).Obj;
            else
                throw new FieldNotFoundException(field.Tag);
        }


        /// <summary>
        /// getField without a type defaults to returning a string
        /// </summary>
        /// <param name="tag"></param>
        public string getField(int tag)
        {
            if (_fields.ContainsKey(tag))
                return _fields[tag].ToString();
            else
                throw new FieldNotFoundException(tag);
        }

        #region Private Members
        protected Dictionary<int, Fields.IField> _fields = new Dictionary<int, QuickFIX.NET.Fields.IField>();
        #endregion
    }
}
