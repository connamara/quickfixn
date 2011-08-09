using System.Collections.Generic;

namespace QuickFix
{
    public class DataDictionaryProvider
    {
        private Dictionary<string, DataDictionaryParser> transportDataDictionaries_;
        private Dictionary<string, DataDictionaryParser> applicationDataDictionaries_;
        private DataDictionaryParser emptyDataDictionary_;

        public DataDictionaryProvider()
        {
            transportDataDictionaries_ = new Dictionary<string, DataDictionaryParser>();
            applicationDataDictionaries_ = new Dictionary<string, DataDictionaryParser>();
            emptyDataDictionary_ = new DataDictionaryParser();
        }

        /// TODO need to make deeper copy?
        public DataDictionaryProvider(DataDictionaryProvider src)
        {
            transportDataDictionaries_ = new Dictionary<string, DataDictionaryParser>(src.transportDataDictionaries_);
            applicationDataDictionaries_ = new Dictionary<string, DataDictionaryParser>(src.applicationDataDictionaries_);
            emptyDataDictionary_ = new DataDictionaryParser(src.emptyDataDictionary_);
        }

        public void AddTransportDataDictionary(string beginString, DataDictionaryParser dataDictionary)
        {
            transportDataDictionaries_[beginString] = dataDictionary;
        }

        public void AddApplicationDataDictionary(string applVerID, DataDictionaryParser dataDictionary)
        {
            applicationDataDictionaries_[applVerID] = dataDictionary;
        }

        public DataDictionaryParser GetSessionDataDictionary(string beginString)
        {
            DataDictionaryParser dd;
            if (!transportDataDictionaries_.TryGetValue(beginString, out dd))
                return emptyDataDictionary_;
            return dd;
        }

        public DataDictionaryParser GetApplicationDataDictionary(string applVerID)
        {
            DataDictionaryParser dd;
            if (!applicationDataDictionaries_.TryGetValue(applVerID, out dd))
                return emptyDataDictionary_;
            return dd;
        }
    }
}
