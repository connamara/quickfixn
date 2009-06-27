using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFIX.NET.Config
{
    /// <summary>
    /// Config file parser/reader.
    /// </summary>
    public class Config
    {
        public Config(string configFileName)
        {
            _configFileName = configFileName;
        }

        private string _configFileName;
    }
}
