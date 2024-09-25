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
    public class FieldMap : IEnumerable<KeyValuePair<int, IField>> {
        private SortedDictionary<int, IField> _fields = new();

        /// FIXME sorted dict is a hack to get quasi-correct field order
        private Dictionary<int, List<Group>> _groups = new();

        /// <summary>
        /// order of field tags as an integer array
        /// </summary>
        public int[] FieldOrder { get; private set; } = Array.Empty<int>();

        /// <summary>
        /// Used for validation.  Only set during Message parsing.
        /// </summary>
        public List<IField> RepeatedTags { get; private set; } = new();

        /// <summary>
        /// Default constructor
        /// </summary>
        public FieldMap()
        {
        }

        /// <summary>
        /// Constructor with field order
        /// </summary>
        /// <param name="fieldOrd"></param>
        public FieldMap(int[] fieldOrd)
            : this()
        {
            FieldOrder = fieldOrd;
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
            FieldOrder = src.FieldOrder;

            _fields = new SortedDictionary<int, IField>(src._fields);

            _groups = new Dictionary<int, List<Group>>();
            foreach (KeyValuePair<int, List<Group>> g in src._groups)
                _groups.Add(g.Key, new List<Group>(g.Value));

            RepeatedTags = new List<IField>(src.RepeatedTags);
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
        public void SetField(IField field)
        {
            _fields[field.Tag] = field;
        }

        /// <summary>
        /// set many fields at the same time
        /// </summary>
        public void SetFields(IEnumerable<IField> fields)
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
        /// <returns>false if overwrite=true and is denied</returns>
        public bool SetField(IField field, bool overwrite)
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
        public BooleanField GetField(BooleanField field)
        {
            field.Value = GetBoolean(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a string field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public StringField GetField(StringField field)
        {
            field.Value = GetString(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a char field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public CharField GetField(CharField field)
        {
            field.Value = GetChar(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a int field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public IntField GetField(IntField field)
        {
            field.Value = GetInt(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a ulong field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public ULongField GetField(ULongField field)
        {
            field.Value = GetULong(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a decimal field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public DecimalField GetField(DecimalField field)
        {
            field.Value = GetDecimal(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a datetime field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public DateTimeField GetField(DateTimeField field)
        {
            field.Value = GetDateTime(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a date only field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public DateOnlyField GetField(DateOnlyField field)
        {
            field.Value = GetDateOnly(field.Tag);
            return field;
        }

        /// <summary>
        /// Gets a time only field; saves its value into the parameter object, which is also the return value.
        /// </summary>
        /// <param name="field">this field's tag is used to extract the value from the message; that value is saved back into this object</param>
        /// <exception cref="FieldNotFoundException">thrown if <paramref name="field"/> isn't found</exception>
        /// <returns><paramref name="field"/></returns>
        public TimeOnlyField GetField(TimeOnlyField field)
        {
            field.Value = GetTimeOnly(field.Tag);
            return field;
        }

        /// <summary>
        /// Check to see if field is set
        /// </summary>
        /// <param name="field">Field Object</param>
        /// <returns>true if set</returns>
        public bool IsSetField(IField field)
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

            if (!_groups.ContainsKey(group.CounterField))
                _groups.Add(group.CounterField, new List<Group>());
            _groups[group.CounterField].Add(group);

            if (autoIncCounter)
            {
                // increment group size
                int groupsize = _groups[group.CounterField].Count;
                int counttag = group.CounterField;
                IntField count = new IntField(counttag, groupsize);
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

        /// <summary>
        /// Extracts a repeating-group item into <paramref name="group"/>
        /// </summary>
        /// <param name="num">index of desired group item (index starts at 1, not 0)</param>
        /// <param name="group">group to populate (<c>group.Field</c> is used by this function to extract the group)</param>
        public void GetGroup(int num, Group group)
        {
            int tag = group.CounterField;
            group.CopyStateFrom(this.GetGroup(num, tag));
        }

        /// <summary>
        /// Gets the integer value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the integer field value</returns>
        /// <exception cref="FieldNotFoundException" />
        public int GetInt(int tag)
        {
            if (!_fields.TryGetValue(tag, out IField? fld))
                throw new FieldNotFoundException(tag);

            if (fld is FieldBase<int> intField)
                return intField.Value;

            return IntConverter.Convert(fld.ToString());
        }

        /// <summary>
        /// Gets the ulong value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the ulong field value</returns>
        /// <exception cref="FieldNotFoundException" />
        public ulong GetULong(int tag)
        {
            try
            {
                IField fld = _fields[tag];
                if (fld.GetType() == typeof(ULongField))
                    return ((ULongField)fld).Value;
                return ULongConverter.Convert(fld.ToString());
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
        public DateTime GetDateTime(int tag)
        {
            if (!_fields.TryGetValue(tag, out IField? fld))
                throw new FieldNotFoundException(tag);

            return fld switch
            {
                DateOnlyField dateOnlyField => dateOnlyField.Value.Date,
                TimeOnlyField timeOnlyField => new DateTime(1980, 01, 01).Add(timeOnlyField.Value.TimeOfDay),
                FieldBase<DateTime> dateTimeField => dateTimeField.Value,
                _ => DateTimeConverter.ParseToDateTime(fld.ToString())
            };
        }

        /// <summary>
        /// Gets the DateOnly value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the DateTime value</returns>
        /// <exception cref="FieldNotFoundException" />
        public DateTime GetDateOnly(int tag)
        {
            if (!_fields.TryGetValue(tag, out IField? fld))
                throw new FieldNotFoundException(tag);

            if (fld is FieldBase<DateTime> dateTimeField)
                return dateTimeField.Value.Date;

            return DateTimeConverter.ParseToDateOnly(fld.ToString());
        }

        /// <summary>
        /// Gets the TimeOnly value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the DateTime value</returns>
        /// <exception cref="FieldNotFoundException" />
        public DateTime GetTimeOnly(int tag)
        {
            if (!_fields.TryGetValue(tag, out IField? fld))
                throw new FieldNotFoundException(tag);

            if (fld is FieldBase<DateTime> dateTimeField)
                return new DateTime(1980, 01, 01).Add(dateTimeField.Value.TimeOfDay);

            return DateTimeConverter.ParseToTimeOnly(fld.ToString());
        }

        /// <summary>
        /// Gets the boolean value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the bool value</returns>
        /// <exception cref="FieldNotFoundException" />
        public bool GetBoolean(int tag)
        {
            if (!_fields.TryGetValue(tag, out IField? fld))
                throw new FieldNotFoundException(tag);

            if (fld is FieldBase<bool> boolField)
                return boolField.Value;

            return BoolConverter.Convert(fld.ToString());
        }

        /// <summary>
        /// Gets the string value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the string value</returns>
        /// <exception cref="FieldNotFoundException" />
        public string GetString(int tag)
        {
            if (!_fields.TryGetValue(tag, out IField? fld))
                throw new FieldNotFoundException(tag);

            return fld.ToString();
        }

        /// <summary>
        /// Gets the char value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the char value</returns>
        /// <exception cref="FieldNotFoundException" />
        public char GetChar(int tag)
        {
            if (!_fields.TryGetValue(tag, out IField? fld))
                throw new FieldNotFoundException(tag);

            if (fld is FieldBase<char> charField)
                return charField.Value;

            return CharConverter.Convert(fld.ToString());
        }

        /// <summary>
        /// Gets the decimal value of a field
        /// </summary>
        /// <param name="tag">the FIX tag</param>
        /// <returns>the decimal value</returns>
        /// <exception cref="FieldNotFoundException" />
        public decimal GetDecimal(int tag)
        {
            if (!_fields.TryGetValue(tag, out IField? fld))
                throw new FieldNotFoundException(tag);

            if (fld is FieldBase<decimal> decimalField)
                return decimalField.Value;

            return DecimalConverter.Convert(fld.ToString());
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
            return (_fields.Count == 0) && (_groups.Count == 0);
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach (IField field in _fields.Values)
            {
                if (field.Tag != Fields.Tags.CheckSum)
                    total += field.GetTotal();
            }

            foreach (IField field in this.RepeatedTags)
            {
                if (field.Tag != Fields.Tags.CheckSum)
                    total += field.GetTotal();
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
            foreach (IField field in _fields.Values)
            {
                if (field.Tag != Tags.BeginString
                    && field.Tag != Tags.BodyLength
                    && field.Tag != Tags.CheckSum)
                {
                    total += field.GetLength();
                }
            }

            foreach (IField field in this.RepeatedTags)
            {
                if (field.Tag != Tags.BeginString
                    && field.Tag != Tags.BodyLength
                    && field.Tag != Tags.CheckSum)
                {
                    total += field.GetLength();
                }
            }

            foreach (List<Group> groupList in _groups.Values)
            {
                foreach (Group group in groupList)
                    total += group.CalculateLength();
            }
    
            return total;
        }

        /// <summary>
        /// Creates a FIX (ish) string representation of this FieldMap (does not change the object state)
        /// </summary>
        /// <returns></returns>
        public virtual string CalculateString()
        {
            return CalculateString(new StringBuilder(), FieldOrder);
        }

        /// <summary>
        /// Creates a FIX (ish) string representation of this FieldMap (does not change the object state)
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="preFields"></param>
        /// <returns></returns>
        public virtual string CalculateString(StringBuilder sb, int[] preFields)
        {
            HashSet<int> groupCounterTags = new(_groups.Keys);
            
            foreach (int preField in preFields)
            {
                if (IsSetField(preField))
                {
                    sb.Append(preField + "=" + GetString(preField)).Append(Message.SOH);
                    if (groupCounterTags.Contains(preField))
                    {
                        List<Group> glist = _groups[preField];
                        foreach (Group g in glist)
                            sb.Append(g.CalculateString());
                    }
                }
            }

            foreach (IField field in _fields.Values)
            {
                if (groupCounterTags.Contains(field.Tag))
                    continue;
                if (preFields.Contains(field.Tag))
                    continue; //already did this one
                sb.Append($"{field.Tag}={field.ToString()}");
                sb.Append(Message.SOH);
            }

            foreach(int counterTag in _groups.Keys)
            {
                if (preFields.Contains(counterTag))
                    continue; //already did this one

                List<Group> groupList = _groups[counterTag];
                if (groupList.Count == 0)
                    continue; //probably unnecessary, but it doesn't hurt to check

                sb.Append(_fields[counterTag].ToStringField());
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
        public int GroupCount(int fieldNo) {
            return _groups.TryGetValue(fieldNo, out var group) ? group.Count : 0;
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
