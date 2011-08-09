using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix.Fields;

namespace QuickFix
{
    public class FieldMap
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public FieldMap()
        {
            _fields = new SortedDictionary<int, Fields.IField>(); /// FIXME sorted dict is a hack to get quasi-correct field order
            _groups = new Dictionary<int, List<Group>>();
        }

        /// <summary>
        /// Constructor with field order
        /// </summary>
        /// <param name="fieldOrd"></param>
        public FieldMap(int[] fieldOrd)
            : this()
        {
            _fieldOrder = fieldOrd;
        }


        /// <summary>
        /// FIXME this should probably make a deeper copy
        /// </summary>
        /// <param name="src">The QuickFix.FieldMap to copy</param>
        /// <returns>A copy of the given QuickFix.FieldMap</returns>
        public FieldMap(FieldMap src)
        {
            this._fieldOrder = src._fieldOrder;
            
            this._fields = new SortedDictionary<int, Fields.IField>(src._fields);
            
            this._groups = new Dictionary<int, List<Group>>();
            foreach (KeyValuePair<int, List<Group>> g in src._groups)
                this._groups.Add(g.Key, new List<Group>(g.Value));
        }

        /// <summary>
        /// FieldOrder Property
        /// order of field tags as an integer array
        /// </summary>
        public int[] FieldOrder
        {
            get { return _fieldOrder; }
            private set { _fieldOrder = value; }
        }

        /// <summary>
        /// QuickFIX-CPP compat, see FieldOrder property
        /// </summary>
        /// <returns>field order integer array</returns>
        public int[] getFieldOrder()
        {
            return _fieldOrder;
        }

        public bool RemoveField(int field)
        {
            return _fields.Remove(field);
        }

        /// <summary>
        /// set field in the fieldmap
        /// will overwrite field if it exists
        /// </summary>
        public void setField(Fields.IField field)
        {
            _fields[field.Tag] = field;
        }

        /// <summary>
        /// Set field with overwrite flag
        /// </summary>
        /// <param name="field"></param>
        /// <param name="overwrite">will overwrite existing field if set to true</param>
        public void setField(Fields.IField field, bool overwrite)
        {
            if (_fields.ContainsKey(field.Tag) && !overwrite)
                return;
            else
                setField(field);
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
        /// Check to see if field is set
        /// </summary>
        /// <param name="field">Field Object</param>
        /// <returns>true if set</returns>
        public bool isSetField(Fields.IField field)
        {
            return isSetField(field.Tag);
        }

        /// <summary>
        /// Check to see if field is set
        /// </summary>
        /// <param name="tag">Tag Number</param>
        /// <returns>true if set</returns>
        public bool isSetField(int tag)
        {
            return _fields.ContainsKey(tag);
        }

        public void AddGroup(Group group)
        {
            if (!_groups.ContainsKey(group.Field))
                _groups.Add(group.Field, new List<Group>());
            _groups[group.Field].Add(group);
        }

        /// <summary>
        /// Gets specific group instance
        /// </summary>
        /// <param name="num">num of group (starting at 1)</param>
        /// <param name="field">tag of group</param>
        /// <returns>Group object</returns>
        /// <exception cref="FieldNotFoundException" />
        public Group GetGroup(int num, int field)
        {
            if (!_groups.ContainsKey(field))
                throw new FieldNotFoundException(field);
            if (num <= 0)
                throw new FieldNotFoundException(field);
            if (_groups[field].Count < num)
                throw new FieldNotFoundException(field);

            return _groups[field][num - 1];
        }

        /// <summary>
        /// Removes specific group instance
        /// </summary>
        /// <param name="num">num of group (starting at 1)</param>
        /// <param name="field">tag of group</param>
        /// <exception cref="FieldNotFoundException" />
        public void RemoveGroup(int num, int field)
        {
            if (!_groups.ContainsKey(field))
                throw new FieldNotFoundException(field);
            if (num <= 0)
                throw new FieldNotFoundException(field);
            if (_groups[field].Count < num)
                throw new FieldNotFoundException(field);

            if (_groups[field].Count.Equals(1))
                _groups.Remove(field);
            else
                _groups[field].RemoveAt(num - 1);
        }

        /// <summary>
        /// Replaces specific group instance
        /// </summary>
        /// <param name="num">num of group (starting at 1)</param>
        /// <param name="field">tag of group</param>
        /// <returns>Group object</returns>
        /// <exception cref="FieldNotFoundException" />
        public Group ReplaceGroup(int num, int field, Group group)
        {
            if (!_groups.ContainsKey(field))
                throw new FieldNotFoundException(field);
            if (num <= 0)
                throw new FieldNotFoundException(field);
            if (_groups[field].Count < num)
                throw new FieldNotFoundException(field);

            return _groups[field][num - 1] = group;
        }


        /// <summary>
        /// getField without a type defaults to returning a string
        /// </summary>
        /// <param name="tag">fix tag</param>
        public string GetField(int tag)
        {
            if (_fields.ContainsKey(tag))
                return _fields[tag].ToString();
            else
                throw new FieldNotFoundException(tag);
        }

        /// <summary>
        /// Removes fields and groups in message
        /// </summary>
        public virtual void Clear()
        {
            _fields.Clear();
            _groups.Clear();
        }

        /// <summary>
        /// Checks emptiness of message
        /// </summary>
        /// <returns>true if no fields or groups have been set</returns>
        public bool IsEmpty()
        {
            return ((_fields.Count == 0) && (_groups.Count == 0));
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach (Fields.IField field in _fields.Values)
            {
                if (field.Tag != Fields.Tags.CheckSum)
                    total += field.getTotal();
            }

            foreach (List<Group> groupList in _groups.Values)
            {
                foreach (Group group in groupList)
                    total += group.CalculateTotal();
            }
            return total;
        }

        public int CalculateLength()
        {
            int total = 0;
            foreach (Fields.IField field in _fields.Values)
            {
                if (field != null
                    && field.Tag != Tags.BeginString
                    && field.Tag != Tags.BodyLength
                    && field.Tag != Tags.CheckSum)
                {
                    total += field.getLength();
                }
            }

            foreach (List<Group> groupList in _groups.Values)
            {
                foreach (Group group in groupList)
                    total += group.CalculateLength();
            }
            return total;
        }

        public virtual string CalculateString()
        {
            return CalculateString(new StringBuilder(), new int[0]);
        }

        public virtual string CalculateString(StringBuilder sb, int[] preFields)
        {
            foreach (int preField in preFields)
            {
                if (isSetField(preField))
                    sb.Append(preField + "=" + GetField(preField)).Append(Message.SOH);
            }

            foreach (Fields.IField field in _fields.Values)
            {
                if (IsOrderedField(field.Tag, preFields))
                    continue;
                sb.Append(field.Tag.ToString() + "=" + field.ToString());
                sb.Append(Message.SOH);
            }

            foreach (List<Group> groupList in _groups.Values)
            {
                foreach (Group group in groupList)
                    sb.Append(CalculateString());
            }

            return sb.ToString();
        }

        private bool IsOrderedField(int field, int[] fieldOrder)
        {
            foreach (int f in fieldOrder)
            {
                if (field == f)
                    return true;
            }
        
            return false;
        }

        #region Private Members
        private SortedDictionary<int, Fields.IField> _fields; /// FIXME sorted dict is a hack to get quasi-correct field order
        private Dictionary<int, List<Group>> _groups;
        private int[] _fieldOrder;
        #endregion
    }
}
