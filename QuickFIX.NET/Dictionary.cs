using System;

namespace QuickFix
{
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
                return Convert.ToDouble(GetString(key));
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

        public int GetDay(string key)
        {
            string abbr = GetString(key).Substring(0, 2).ToUpper();
            switch(abbr)
            {
                case "SU": return 1;
                case "MO": return 2;
                case "TU": return 3;
                case "WE": return 4;
                case "TH": return 5;
                case "FR": return 6;
                case "SA": return 7;
                default: throw new ConfigError("Illegal value " + GetString(key) + " for " + key);
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
            SetString(key, Convert.ToString(val));
        }

        public void SetBool(string key, bool val)
        {
            SetString(key, Fields.Converters.BoolConverter.Convert(val));
        }

        public void SetDay(string key, int val)
        {
            switch(val)
            {
                case 1: SetString(key, "SU"); break;
                case 2: SetString(key, "MO"); break;
                case 3: SetString(key, "TU"); break;
                case 4: SetString(key, "WE"); break;
                case 5: SetString(key, "TH"); break;
                case 6: SetString(key, "FR"); break;
                case 7: SetString(key, "SA"); break;
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

        #region IEnumerable Members

        public System.Collections.IEnumerator GetEnumerator()
        {
            return data_.GetEnumerator();
        }

        #endregion
    }
}
