using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using QuickFix.Fields.Converters;

namespace QuickFix
{
    /// <summary>
    /// Name/value pairs used for specifying groups of settings
    /// </summary>
    public class Dictionary : System.Collections.IEnumerable
    {
        #region Private Members

        private string name_;
        private System.Collections.Generic.Dictionary<string, string> data_ = new System.Collections.Generic.Dictionary<string, string>();
    
        #endregion

        #region Properties

        public string Name
        {
            get { return name_; }
            private set { name_ = value; }
        }
        
        public int Count
        {
            get { return data_.Count; }
        }

        /// <summary>
        /// Alias for Count
        /// </summary>
        public int Size
        {
            get { return Count; }
        }
        
        #endregion

        #region Public Methods
        public Dictionary()
        { }

        public Dictionary(string name)
            : this(name, new System.Collections.Generic.Dictionary<string,string>())
        { }

        public Dictionary(Dictionary d)
            : this(d.name_, d.data_)
        { }

        public Dictionary(string name, System.Collections.Generic.Dictionary<string,string> data)
        {
            name_ = name;
            data_ = new System.Collections.Generic.Dictionary<string, string>(data);
        }

        public string GetString(string key)
        {
            string val = "";
            if (!data_.TryGetValue(key.ToUpper(), out val))
                throw new ConfigError("No value for key: " + key);
            return val;
        }

        public String GetString(string key, bool capitalize)
        {
            string s = GetString(key);
            return capitalize ? s.ToUpper() : s;
        }

        public int GetInt(string key)
        {
            try
            {
                return Convert.ToInt32(GetString(key));
            }
            catch (FormatException)
            {
                throw new ConfigError("Incorrect data type");
            }
            catch (QuickFIXException)
            {
                throw new ConfigError("No value for key: " + key);
            }
        }

        public long GetLong(string key)
        {
            try
            {
                return Convert.ToInt64(GetString(key));
            }
            catch(FormatException)
            {
                throw new ConfigError("Incorrect data type");
            }
            catch(QuickFIXException)
            {
                throw new ConfigError("No value for key: " + key);
            }
        }

        public double GetDouble(string key)
        {
            try
            {
                return Convert.ToDouble(GetString(key), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (FormatException)
            {
                throw new ConfigError("Incorrect data type");
            }
            catch (QuickFIXException)
            {
                throw new ConfigError("No value for key: " + key);
            }
        }

        public bool GetBool(string key)
        {
            try
            {
                return Fields.Converters.BoolConverter.Convert(GetString(key));
            }
            catch (FormatException)
            {
                throw new ConfigError("Incorrect data type");
            }
            catch (QuickFIXException)
            {
                throw new ConfigError("No value for key: " + key);
            }
        }

        public System.DayOfWeek GetDay(string key)
        {
            string abbr = GetString(key).Substring(0, 2).ToUpper();
            switch(abbr)
            {
                case "SU": return System.DayOfWeek.Sunday;
                case "MO": return System.DayOfWeek.Monday;
                case "TU": return System.DayOfWeek.Tuesday;
                case "WE": return System.DayOfWeek.Wednesday;
                case "TH": return System.DayOfWeek.Thursday;
                case "FR": return System.DayOfWeek.Friday;
                case "SA": return System.DayOfWeek.Saturday;
                default: throw new ConfigError("Illegal value " + GetString(key) + " for " + key);
            }
        }

        public TimeStampPrecision GetTimeStampPrecision( string key )
        {
            string precision = GetString( key ).ToUpper();
            switch( precision )
            {
                case "SECOND":
                    return TimeStampPrecision.Second;
                case "MILLISECOND":
                case "MILLI":
                    return TimeStampPrecision.Millisecond;
                case "MICROSECOND":
                case "MICRO":
                    return TimeStampPrecision.Microsecond;
                case "NANOSECOND":
                case "NANO":
                    return TimeStampPrecision.Nanosecond;
                default: throw new ConfigError( "Illegal value " + GetString( key ) + " for " + key );
            }
        }

        public void SetString(string key, string val)
        {
            data_[key.ToUpper()] = val;
        }

        public void SetLong(string key, long val)
        {
            SetString(key, Convert.ToString(val));
        }

        public void SetDouble(string key, double val)
        {
            SetString(key, Convert.ToString(val, System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
        }

        public void SetBool(string key, bool val)
        {
            SetString(key, Fields.Converters.BoolConverter.Convert(val));
        }

        public void SetDay(string key, System.DayOfWeek val)
        {
            switch(val)
            {
                case System.DayOfWeek.Sunday: SetString(key, "SU"); break;
                case System.DayOfWeek.Monday: SetString(key, "MO"); break;
                case System.DayOfWeek.Tuesday: SetString(key, "TU"); break;
                case System.DayOfWeek.Wednesday: SetString(key, "WE"); break;
                case System.DayOfWeek.Thursday: SetString(key, "TH"); break;
                case System.DayOfWeek.Friday: SetString(key, "FR"); break;
                case System.DayOfWeek.Saturday: SetString(key, "SA"); break;
                default: throw new ConfigError("Illegal value " + val + " for " + key);
            }
        }

        public bool Has(string key)
        {
            return data_.ContainsKey(key.ToUpper());
        }

        public void Merge(Dictionary toMerge)
        {
            foreach (System.Collections.Generic.KeyValuePair<string, string> entry in toMerge.data_)
                if(!data_.ContainsKey(entry.Key))
                    data_[entry.Key] = entry.Value;
        }
        #endregion

        #region Public Overrides
        /// <summary>
        /// Test Dictionary objects for equality.
        /// Dictionaries are deemed to be equal if their names and dictionary contents are the same
        /// </summary>
        /// <param name="other">Dictionary to compare against</param>
        /// <returns>true if the two Dictionary objects are the same in terms of contents, else false</returns>
        public override bool Equals(object other)
        {
            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(this, other))
                return true;

            //Check whether the compared object is null.
            if (Object.ReferenceEquals(other, null))
                return false;

            //Check whether the names and dictionary contents are the same
            var otherDict = (Dictionary)other;
            if (Name != otherDict.Name || Count != otherDict.Count)
                return false;

            // Could use LINQ query here, but this is probably faster!
            string otherDictValue = null;
            foreach (var kvp in data_)
                if (!otherDict.data_.TryGetValue(kvp.Key, out otherDictValue) || otherDictValue != kvp.Value)
                    return false;
            return true;
        }

        /// <summary>
        /// Generate hash code for the Dictionary.
        /// If Equals() returns true for a compared object,
        /// then GetHashCode() must return the same value for this object and the compared object.
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            int nameHash = Object.ReferenceEquals(Name, null) ? 1 : Name.GetHashCode();
            return nameHash + 100 * Count;
        }
        #endregion

        #region IEnumerable Members

        public System.Collections.IEnumerator GetEnumerator()
        {
            return data_.GetEnumerator();
        }

        #endregion
    }
}
