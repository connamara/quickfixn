using System;
using System.Collections.Generic;
using System.Linq;
using QuickFix.Fields.Converters;

namespace QuickFix;

/// <summary>
/// Name/value pairs used for specifying groups of settings.
/// All keys usages are case-insensitive (internally all are converted to upper-case).
/// </summary>
public class SettingsDictionary : System.Collections.IEnumerable
{
    private readonly Dictionary<string, string> _data;

    public string Name { get; }
    public int Count => _data.Count;

    /// <summary>
    /// Alias for Count
    /// </summary>
    public int Size => Count;

    public SettingsDictionary()
        : this("unnamed")
    { }

    public SettingsDictionary(string name)
        : this(name, new Dictionary<string,string>())
    { }

    /// <summary>
    /// Create a new SettingsDictionary with specified name but data copied from
    /// the dataSource SettingsDictionary
    /// </summary>
    /// <param name="name"></param>
    /// <param name="dataSource"></param>
    public SettingsDictionary(string name, SettingsDictionary dataSource)
        : this(name, dataSource._data)
    { }

    private SettingsDictionary(string name, Dictionary<string,string> dataSource)
    {
        Name = name;
        _data = dataSource
            .Select(kvp => new {k = kvp.Key.ToUpperInvariant(), v = kvp.Value})
            .ToDictionary(x => x.k, x => x.v);
    }

    public string GetString(string key)
    {
        if (_data.TryGetValue(key.ToUpperInvariant(), out var val))
            return val;
        throw new ConfigError($"No value for key: {key}");
    }

    public String GetString(string key, bool capitalize)
    {
        string s = GetString(key);
        return capitalize ? s.ToUpperInvariant() : s;
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
            throw new ConfigError($"No value for key: {key}");
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
            throw new ConfigError($"No value for key: {key}");
        }
    }

    public ulong GetULong(string key)
    {
        try
        {
            return Convert.ToUInt64(GetString(key));
        }
        catch(FormatException)
        {
            throw new ConfigError("Incorrect data type");
        }
        catch(QuickFIXException)
        {
            throw new ConfigError($"No value for key: {key}");
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
            throw new ConfigError($"No value for key: {key}");
        }
    }

    public bool GetBool(string key)
    {
        try
        {
            return BoolConverter.Convert(GetString(key));
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

    /// <summary>
    /// Return true if key is present AND value is true, else false
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public bool IsBoolPresentAndTrue(string key) {
        return Has(key) && GetBool(key);
    }

    public HashSet<DayOfWeek> GetDays(string key)
    {
        string[] weekdayNameArray = GetString(key).Split(",");
        var result = new HashSet<DayOfWeek>(weekdayNameArray.Length);
        foreach (var weekDayName in weekdayNameArray)
        {
            string abbr = weekDayName.Trim().Substring(0, 2).ToUpper();
            result.Add(DeduceDay(abbr));
        }

        return result;
    }

    public DayOfWeek GetDay(string key) {
        return DeduceDay(GetString(key));
    }

    private static DayOfWeek DeduceDay(string dayStr) {
        string abbr = dayStr.Substring(0, 2).ToUpperInvariant();
        return abbr switch
        {
            "SU" => DayOfWeek.Sunday,
            "MO" => DayOfWeek.Monday,
            "TU" => DayOfWeek.Tuesday,
            "WE" => DayOfWeek.Wednesday,
            "TH" => DayOfWeek.Thursday,
            "FR" => DayOfWeek.Friday,
            "SA" => DayOfWeek.Saturday,
            _ => throw new ArgumentException($"Cannot recognize this day: '{dayStr}'")
        };
    }

    public TimeStampPrecision GetTimeStampPrecision(string key)
    {
        string precision = GetString(key).ToUpperInvariant();
        if (precision.StartsWith("SECOND", StringComparison.InvariantCulture))
            return TimeStampPrecision.Second;
        if (precision.StartsWith("MILLI", StringComparison.InvariantCulture))
            return TimeStampPrecision.Millisecond;
        if (precision.StartsWith("MICRO", StringComparison.InvariantCulture))
            return TimeStampPrecision.Microsecond;
        if (precision.StartsWith("NANO", StringComparison.InvariantCulture))
            return TimeStampPrecision.Nanosecond;
        throw new ConfigError($"Illegal value {GetString(key)} for {key}");
    }

    public void SetString(string key, string val)
    {
        _data[key.ToUpperInvariant()] = val;
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
        SetString(key, BoolConverter.Convert(val));
    }

    public void SetDay(string key, DayOfWeek val) {
        if (Enum.IsDefined(val)) {
            SetString(key, val.ToString());
            return;
        }
        throw new ArgumentException("Not a valid DayOfWeek value");
    }

    /// <summary>
    /// returns true if this SettingsDictionary has a value set for this key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public bool Has(string key)
    {
        return _data.ContainsKey(key.ToUpperInvariant());
    }

    public void Merge(SettingsDictionary toMerge)
    {
        foreach (KeyValuePair<string, string> entry in toMerge._data)
        {
            _data.TryAdd(entry.Key, entry.Value);
        }
    }

    #region Object Overrides
    /// <summary>
    /// Test Dictionary objects for equality.
    /// Dictionaries are deemed to be equal if their names and dictionary contents are the same
    /// </summary>
    /// <param name="other">Dictionary to compare against</param>
    /// <returns>true if the two Dictionary objects are the same in terms of contents, else false</returns>
    public override bool Equals(object? other)
    {
        //Check whether the compared objects reference the same data.
        if (ReferenceEquals(this, other))
            return true;

        //Check whether the compared object is null.
        if (ReferenceEquals(other, null))
            return false;

        //Check whether the names and dictionary contents are the same
        var otherDict = (SettingsDictionary)other;
        if (Name != otherDict.Name || Count != otherDict.Count)
            return false;

        // Could use LINQ query here, but this is probably faster!
        foreach (var kvp in _data)
            if (!otherDict._data.TryGetValue(kvp.Key, out var otherDictValue) || otherDictValue != kvp.Value)
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
        int nameHash = ReferenceEquals(Name, null) ? 1 : Name.GetHashCode();
        return nameHash + 100 * Count;
    }
    #endregion

    #region IEnumerable Members

    public System.Collections.IEnumerator GetEnumerator()
    {
        return _data.GetEnumerator();
    }

    #endregion
}
