using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET.Fields
{
    public sealed class FIXDateTime
    {
        public FIXDateTime() { }

        public FIXDateTime(DateTime dt)
        {
            this._dt = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
        }

        //YYYYMMDD-HH:MM:SS
        public override string ToString()
        {
            return String.Format("{0:yyyyMMDD-HH:mm:ss}", _dt);
        }


        #region Private members
        private DateTime _dt;
        #endregion
    }
}
