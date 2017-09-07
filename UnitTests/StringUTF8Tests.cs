using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickFix;
using QuickFix.Fields;
using Xunit;
using Assert = Xunit.Assert;

namespace UnitTests
{
    public class StringUTF8Tests
    {
        [Fact]
        public void NextTagTest()
        {
            byte[] str = new byte[5];
            str = Encoding.UTF8.GetBytes("35=8\u0001");
            ByteSizeString utf8str = new ByteSizeString(str, 5);
            
            int pos = 0;
            int tag = utf8str.GetNextTag(ref pos);
            Assert.Equal(3, pos);
            ByteSizeString val = utf8str.GetNextValue(ref pos);

            Assert.Equal(35, tag);
            Assert.Equal(5, pos);
            Assert.Equal(val.ByteArray, Encoding.UTF8.GetBytes("8"));
            Assert.Equal("8", val.ToString());
        }
    }
}