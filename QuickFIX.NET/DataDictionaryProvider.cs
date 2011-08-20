using System.Collections.Generic;

namespace QuickFix
{
    public class DataDictionaryProvider
    {
        private Dictionary<string, DataDictionary.DD2> transportDataDictionaries_;
        private Dictionary<string, DataDictionary.DD2> applicationDataDictionaries_;
        private DataDictionary.DD2 emptyDataDictionary_;

        public DataDictionaryProvider()
        {
            transportDataDictionaries_ = new Dictionary<string, DataDictionary.DD2>();
            applicationDataDictionaries_ = new Dictionary<string, DataDictionary.DD2>();
            emptyDataDictionary_ = new DataDictionary.DD2();
        }

        /// TODO need to make deeper copy?
        public DataDictionaryProvider(DataDictionaryProvider src)
        {
            transportDataDictionaries_ = new Dictionary<string, DataDictionary.DD2>(src.transportDataDictionaries_);
            applicationDataDictionaries_ = new Dictionary<string, DataDictionary.DD2>(src.applicationDataDictionaries_);
            emptyDataDictionary_ = new DataDictionary.DD2(src.emptyDataDictionary_);
        }

        public void AddTransportDataDictionary(string beginString, DataDictionary.DD2 dataDictionary)
        {
            transportDataDictionaries_[beginString] = dataDictionary;
        }

        public void AddApplicationDataDictionary(string applVerID, DataDictionary.DD2 dataDictionary)
        {
            applicationDataDictionaries_[applVerID] = dataDictionary;
        }

        public DataDictionary.DD2 GetSessionDataDictionary(string beginString)
        {
            DataDictionary.DD2 dd;
            if (!transportDataDictionaries_.TryGetValue(beginString, out dd))
                return emptyDataDictionary_;
            return dd;
        }

        public DataDictionary.DD2 GetApplicationDataDictionary(string applVerID)
        {
            DataDictionary.DD2 dd;
            if (!applicationDataDictionaries_.TryGetValue(applVerID, out dd))
                return emptyDataDictionary_;
            return dd;
        }
    }
}
