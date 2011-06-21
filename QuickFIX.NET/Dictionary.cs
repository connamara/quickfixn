using System;
using System.Text;

namespace QuickFIX.NET
{
    class Dictionary
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
            string s = data_[key];
            if(s == null)
                throw new ConfigError("No value for key: " + key);
            return s;
        }

        public String GetString(string key, bool capitalize)
        {
            string s = GetString(key);
            return capitalize ? s.ToUpper() : s;
        }

        public long GetLong(string key)
        {
            try
            {
                string val = "";
                if (!data_.TryGetValue(key, out val))
                    throw new ConfigError("No value for key: " + key);
                return Convert.ToInt64(val);

            }
            catch(FormatException)
            {
                throw new FieldConvertError("Incorrect data type");
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
                string val = "";
                if (!data_.TryGetValue(key, out val))
                    throw new ConfigError("No value for key: " + key);
                return Convert.ToDouble(val);
            }
            catch (FormatException)
            {
                throw new FieldConvertError("Incorrect data type");
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
                string val = "";
                if (!data_.TryGetValue(key, out val))
                    throw new ConfigError("No value for key: " + key);
                return Convert.ToBoolean(val);
            }
            catch (FormatException)
            {
                throw new FieldConvertError("Incorrect data type");
            }
            catch (QuickFIXException)
            {
                throw new ConfigError("No value for key: " + key);
            }
        }

        public int GetDay(string key)
        {
            throw new System.NotImplementedException("FIXME - Dictionary.GetDay not implemented!");
            /*
            string s = data_[key];
            if (s == null)
                throw new ConfigError("No value for key.");
            try
            {
                return DayConverter.ToInteger(s);
            }
            catch (System.Exception e)
            {
                throw new ConfigError("Invalid data type for day value: " + e.Message);
            }
            */
        }

        public void SetString(string key, string val)
        {
            data_[key] = val;
        }

        public void SetLong(string key, long val)
        {
            data_[key] = Convert.ToString(val);
        }

        public void SetDouble(string key, double val)
        {
            data_[key] = Convert.ToString(val);
        }

        public void SetBool(string key, bool val)
        {
            data_[key] = Convert.ToString(val);
        }

        public void SetDay(string key, int val)
        {
            throw new System.NotImplementedException("FIXME - Dictionary.SetDay not implemented!");
            /*
            try
            {
                data_[key] = DayConverter.ToString(val));
            }
            catch (ConfigError e)
            {
                // JNI API doesn't allow a ConfigError to be thrown
                throw new RuntimeError(e);
            }
            */
        }

        public void SetDay(string key, string dayName)
        {
            data_[key] = dayName;
        }

        public bool Has(string key)
        {
            return data_.ContainsKey(key);
        }

        public void Merge(Dictionary toMerge)
        {
            foreach (System.Collections.Generic.KeyValuePair<string, string> entry in toMerge.data_)
                data_[entry.Key] = entry.Value;
        }
    }
}
