using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET
{
    /// <summary>
    /// FIX Message Trailer
    /// </summary>
    public class Trailer
    {
        public int Checksum
        {
            get { return _checksum; }
            set { _checksum = value;}
        }

        public Trailer(int checksum)
        {
            _checksum = checksum;
        }

        private int _checksum = 0;
    }
}
