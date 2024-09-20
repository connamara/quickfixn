using System.Collections.Generic;

namespace QuickFix
{
    public class DataDictionaryProvider
    {
        private readonly Dictionary<string, DataDictionary.DataDictionary> _transportDataDictionaries;
        private readonly Dictionary<string, DataDictionary.DataDictionary> _applicationDataDictionaries;
        private readonly DataDictionary.DataDictionary _emptyDataDictionary;

        public DataDictionaryProvider()
        {
            _transportDataDictionaries = new Dictionary<string, DataDictionary.DataDictionary>();
            _applicationDataDictionaries = new Dictionary<string, DataDictionary.DataDictionary>();
            _emptyDataDictionary = new DataDictionary.DataDictionary();
        }

        /// TODO need to make deeper copy?
        public DataDictionaryProvider(DataDictionaryProvider src)
        {
            _transportDataDictionaries = new Dictionary<string, DataDictionary.DataDictionary>(src._transportDataDictionaries);
            _applicationDataDictionaries = new Dictionary<string, DataDictionary.DataDictionary>(src._applicationDataDictionaries);
            _emptyDataDictionary = new DataDictionary.DataDictionary(src._emptyDataDictionary);
        }

        public void AddTransportDataDictionary(string beginString, DataDictionary.DataDictionary dataDictionary)
        {
            _transportDataDictionaries[beginString] = dataDictionary;
        }

        public void AddApplicationDataDictionary(string applVerId, DataDictionary.DataDictionary dataDictionary)
        {
            _applicationDataDictionaries[applVerId] = dataDictionary;
        }

        public DataDictionary.DataDictionary GetSessionDataDictionary(string beginString)
        {
            return _transportDataDictionaries.GetValueOrDefault(beginString, _emptyDataDictionary);
        }

        public DataDictionary.DataDictionary GetApplicationDataDictionary(string applVerId)
        {
            return _applicationDataDictionaries.GetValueOrDefault(applVerId, _emptyDataDictionary);
        }
    }
}
