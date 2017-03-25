using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix.Fields;
using QuickFix.Fields.Converters;

namespace QuickFix
{
    /// <summary>
    /// Field container used by messages, groups, and composites
    /// </summary>
    public class FieldMap : IEnumerable<KeyValuePair<int, Fields.IField>>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public FieldMap()
        {
            _fields = new SortedDictionary<int, Fields.IField>(); // FIXME sorted dict is a hack to get quasi-correct field order
            _groups = new Dictionary<int, List<Group>>();
            this.RepeatedTags = new List<Fields.IField>();
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
            CopyStateFrom(src);
        }

        public void CopyStateFrom(FieldMap src)
        {
            this._fieldOrder = src._fieldOrder;

            this._fields = new SortedDictionary<int, Fields.IField>(src._fields);

            this._groups = new Dictionary<int, List<Group>>();
            foreach (KeyValuePair<int, List<Group>> g in src._groups)
                this._groups.Add(g.Key, new List<Group>(g.Value));

            this.RepeatedTags = new List<Fields.IField>(src.RepeatedTags);
        }

        /// <summary>
        /// FieldOrder Property
        /// order of field tags as an integer array
        /// </summary>
        public int[] FieldOrder
        {
            get { return _fieldOrder; }
        }

        /// <summary>
        /// QuickFIX-CPP compat, see FieldOrder property
        /// </summary>
        /// <returns>field order integer array</returns>
        public int[] getFieldOrder()
        {
            return _fieldOrder;
        }

        /// <summary>
        /// Remove a field from the fieldmap
        /// </summary>
        /// <param name="field"></param>
        /// <returns>true if field was removed, false otherwise</returns>
        public bool RemoveField(int field)
        {
            return _fields.Remove(field);
        }

        /// <summary>
        /// set field in the fieldmap
        /// will overwrite field if it exists
        /// </summary>
        public void SetField(Fields.IField field)
        {
            _fields[field.Tag] = field;
        }

        /// <summary>
        /// set many fields at the same time
        /// </summary>
        public void SetFields(IEnumerable<Fields.IField> fields)
        {
            foreach (var field in fields)
            {
                _fields[field.Tag] = field;
            }
        }

        /// <summary>
        /// Set field, with optional override check
        /// </summary>
        /// <param name="field"></param>
        /// <param name="overwrite">will overwrite existing field if set to true</param>
        /// <returns>false if overwrite would be violated, else true</returns>
        public bool SetField(Fields.IField field, bool overwrite)
        {
            if (_fields.ContainsKey(field.Tag) && !overwrite)
                return false;
            
            SetField(field);
            return true;
        }

        /// <summary>
        /// Gets a boolean field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public Fields.BooleanField GetField(Fields.BooleanField field)
        {
            field.Obj = GetBoolean(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a string field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public Fields.StringField GetField(Fields.StringField field)
        {
            field.Obj = GetString(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a char field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public Fields.CharField GetField(Fields.CharField field)
        {
            field.Obj = GetChar(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a int field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public Fields.IntField GetField(Fields.IntField field)
        {
            field.Obj = GetInt(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a decimal field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public Fields.DecimalField GetField(Fields.DecimalField field)
        {
            field.Obj = GetDecimal(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a datetime field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public Fields.DateTimeField GetField(Fields.DateTimeField field)
        {
            field.Obj = GetDateTime(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a date only field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public Fields.DateOnlyField GetField(Fields.DateOnlyField field)
        {
            field.Obj = GetDateOnly(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a time only field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public Fields.TimeOnlyField GetField(Fields.TimeOnlyField field)
        {
            field.Obj = GetTimeOnly(field.Tag);
            return field;
        }

        /// <summary>
        /// Check to see if field is set
        /// </summary>
        /// <param name="field">Field Object</param>
        /// <returns>true if set</returns>
        public bool IsSetField(Fields.IField field)
        {
            return IsSetField(field.Tag);
        }

        /// <summary>
        /// Check to see if field is set
        /// </summary>
        /// <param name="tag">Tag Number</param>
        /// <returns>true if set</returns>
        public bool IsSetField(int tag)
        {
            return _fields.ContainsKey(tag);
        }

        /// <summary>
        /// Add a group to message; the group counter is automatically incremented.
        /// </summary>
        /// <param name="grp">group to add</param>
        public void AddGroup(Group grp)
        {
            AddGroup(grp, true);
        }

        /// <summary>
        /// Add a group to message; optionally auto-increment the counter.
        /// When parsing from a string (e.g. Message::FromString()), we want to leave the counter alone
        /// so we can detect when the counterparty has set it wrong.
        /// </summary>
        /// <param name="grp">group to add</param>
        /// <param name="autoIncCounter">if true, auto-increment the counter, else leave it as-is</param>
        internal void AddGroup(Group grp, bool autoIncCounter)
        {
            // copy, in case user code reuses input object
            Group group = grp.Clone();

            if (!_groups.ContainsKey(group.Field))
                _groups.Add(group.Field, new List<Group>());
            _groups[group.Field].Add(group);

            if (autoIncCounter)
            {
                // increment group size
                int groupsize = _groups[group.Field].Count;
                int counttag = group.Field;
                IntField count = null;

                count = new IntField(counttag, groupsize);
                this.SetField(count, true);
            }
        }

        /// <summary>
        /// Gets an instance of a group.  Note: use GetGroup(int,Group) if you want
        /// your group as the proper subtype (e.g. NoPartyIDsGroup instead of the generic Group)
        /// </summary>
        /// <param name="num">index of desired group (starting at 1)</param>
        /// <param name="field">counter tag of repeating group</param>
        /// <returns>retrieved group object</returns>
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

        //TODO v2: change this to return void
        /// <summary>
        /// Extracts a repeating-group item into <paramref name="group"/>
        /// </summary>
        /// <param name="num">index of desired group item (index starts at 1, not 0)</param>
        /// <param name="group">group to populate (<c>group.Field</c> is used by this function to extract the group)</param>
        /// <returns>A redundant reference to <paramref name="group"/><b>Do not use this.  This method will be changed to return void in a future release.</b></returns>
        public Group GetGroup(int num, Group group)
        {
            int tag = group.Field;
            group.CopyStateFrom(this.GetGroup(num, tag));
            return group;
        }

        /// <summary>
        /// Gets the integer value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the integer field value</returns>
        /// <exception cref="FieldNotFoundException" />
        public int GetInt(int tag)
        {
            try
            {
                Fields.IField fld = _fields[tag];
                if (fld.GetType() == typeof(IntField))
                    return ((IntField)fld).Obj;
                else
                    return IntConverter.Convert(fld.ToString());
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                throw new FieldNotFoundException(tag);
            }
        }

        /// <summary>
        /// Gets the DateTime value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the DateTime value</returns>
        /// <exception cref="FieldNotFoundException" />
        public System.DateTime GetDateTime(int tag)
        {
            try
            {
                Fields.IField fld = _fields[tag];
                Type fldTyp = fld.GetType();
                if (fldTyp == typeof(DateTimeField))
                    return ((DateTimeField)(fld)).Obj;
                if (fldTyp == typeof(DateOnlyField))
                    return GetDateOnly(tag);
                if (fldTyp == typeof(TimeOnlyField))
                    return GetTimeOnly(tag);
                else
                    return DateTimeConverter.ConvertToDateTime(fld.ToString());
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                throw new FieldNotFoundException(tag);
            }
        }

        /// <summary>
        /// Gets the DateOnly value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the DateTime value</returns>
        /// <exception cref="FieldNotFoundException" />
        public System.DateTime GetDateOnly(int tag)
        {
            try
            {
                Fields.IField fld = _fields[tag];                
                return DateTimeConverter.ConvertToDateOnly(fld.ToString());
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                throw new FieldNotFoundException(tag);
            }
        }

        /// <summary>
        /// Gets the TimeOnly value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the DateTime value</returns>
        /// <exception cref="FieldNotFoundException" />
        public System.DateTime GetTimeOnly(int tag)
        {
            try
            {
                Fields.IField fld = _fields[tag];
                return DateTimeConverter.ConvertToTimeOnly(fld.ToString());
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                throw new FieldNotFoundException(tag);
            }
        }

        /// <summary>
        /// Gets the boolean value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the bool value</returns>
        /// <exception cref="FieldNotFoundException" />
        public bool GetBoolean(int tag)
        {
            try
            {
                Fields.IField fld = _fields[tag];
                if (fld.GetType() == typeof(BooleanField))
                    return ((BooleanField)fld).Obj;
                else
                    return BoolConverter.Convert(fld.ToString());
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                throw new FieldNotFoundException(tag);
            }
        }

        /// <summary>
        /// Gets the string value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the string value</returns>
        /// <exception cref="FieldNotFoundException" />
        public String GetString(int tag)
        {
            try
            {
                return _fields[tag].ToString();
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                throw new FieldNotFoundException(tag);
            }
        }

        /// <summary>
        /// Gets the char value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the char value</returns>
        /// <exception cref="FieldNotFoundException" />
        public char GetChar(int tag)
        {
            try
            {
                Fields.IField fld = _fields[tag];
                if (fld.GetType() == typeof(CharField))
                    return ((CharField)fld).Obj;
                else
                    return CharConverter.Convert(fld.ToString());
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                throw new FieldNotFoundException(tag);
            }
        }

        /// <summary>
        /// Gets the decimal value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the decimal value</returns>
        /// <exception cref="FieldNotFoundException" />
        public Decimal GetDecimal(int tag)
        {
            try
            {
                Fields.IField fld = _fields[tag];
                if (fld.GetType() == typeof(DecimalField))
                    return ((DecimalField)fld).Obj;
                else
                    return DecimalConverter.Convert(fld.ToString());
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                throw new FieldNotFoundException(tag);
            }
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
        /// <param name="group">the group to replace it with</param>
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

        public int CalculateTotal(Encoding encoding)
        {
            int total = 0;
            foreach (Fields.IField field in _fields.Values)
            {
                if (field.Tag != Fields.Tags.CheckSum)
                    total += field.getTotal(encoding);
            }

            foreach (Fields.IField field in this.RepeatedTags)
            {
                if (field.Tag != Fields.Tags.CheckSum)
                    total += field.getTotal(encoding);
            }

            foreach (List<Group> groupList in _groups.Values)
            {
                foreach (Group group in groupList)
                    total += group.CalculateTotal(encoding);
            }
            return total;
        }

        public int CalculateLength(Encoding encoding)
        {
            int total = 0;
            foreach (Fields.IField field in _fields.Values)
            {
                if (field != null
                    && field.Tag != Tags.BeginString
                    && field.Tag != Tags.BodyLength
                    && field.Tag != Tags.CheckSum)
                {
                    total += field.getLength(encoding);
                }
            }

            foreach (Fields.IField field in this.RepeatedTags)
            {
                if (field != null
                    && field.Tag != Tags.BeginString
                    && field.Tag != Tags.BodyLength
                    && field.Tag != Tags.CheckSum)
                {
                    total += field.getLength(encoding);
                }
            }

            foreach (List<Group> groupList in _groups.Values)
            {
                foreach (Group group in groupList)
                    total += group.CalculateLength(encoding);
            }
    
            return total;
        }

        public virtual string CalculateString()
        {
            if( FieldOrder != null )
                return CalculateString(new StringBuilder(), FieldOrder);
            else
                return CalculateString(new StringBuilder(), new int[0]);
        }

        public virtual string CalculateString(StringBuilder sb, int[] preFields)
        {
            HashSet<int> groupCounterTags = new HashSet<int>(_groups.Keys);
            
            foreach (int preField in preFields)
            {
                if (IsSetField(preField))
                {
                    sb.Append(preField + "=" + GetField(preField)).Append(Message.SOH);
                    if (groupCounterTags.Contains(preField))
                    {
                        List<Group> glist = _groups[preField];
                        foreach (Group g in glist)
                            sb.Append(g.CalculateString());
                    }
                }
            }

            foreach (Fields.IField field in _fields.Values)
            {
                if (groupCounterTags.Contains(field.Tag))
                    continue;
                if (preFields.Contains(field.Tag))
                    continue; //already did this one
                sb.Append(field.Tag.ToString() + "=" + field.ToString());
                sb.Append(Message.SOH);
            }

            foreach(int counterTag in _groups.Keys)
            {
                if (preFields.Contains(counterTag))
                    continue; //already did this one

                List<Group> groupList = _groups[counterTag];
                if (groupList.Count == 0)
                    continue; //probably unnecessary, but it doesn't hurt to check

                sb.Append(_fields[counterTag].toStringField());
                sb.Append(Message.SOH);

                foreach (Group group in groupList)
                    sb.Append(group.CalculateString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Get count of items in the repeating group
        /// </summary>
        /// <param name="fieldNo">the counter tag of the group</param>
        /// <returns></returns>
        public int GroupCount(int fieldNo)
        {
            if(_groups.ContainsKey(fieldNo))
            {
                return _groups[fieldNo].Count;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Return a List containing the counter tag for each group in this message.
        /// (The returned List is a static copy.)
        /// </summary>
        /// <returns></returns>
        public List<int> GetGroupTags()
        {
            return new List<int>(_groups.Keys);
        }

        #region Private Members
        private SortedDictionary<int, Fields.IField> _fields; /// FIXME sorted dict is a hack to get quasi-correct field order
        private Dictionary<int, List<Group>> _groups;
        protected int[] _fieldOrder;
        #endregion

        #region Properties
        /// <summary>
        /// Used for validation.  Only set during Message parsing.
        /// </summary>
        public List<Fields.IField> RepeatedTags { get; private set; }
        #endregion

        #region IEnumerable<KeyValuePair<int,IField>> Members

        public IEnumerator<KeyValuePair<int, IField>> GetEnumerator()
        {
            return _fields.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _fields.GetEnumerator();
        }

        #endregion
    }
}
