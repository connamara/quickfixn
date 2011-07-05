using System.Collections.Generic;
using System.Text;

namespace QuickFix
{
    public class Parser
    {
        private StringBuilder buffer_ = new StringBuilder();

        /// <summary>
        /// FIXME
        /// </summary>
        /// <param name="data"></param>
        public void AddToStream(string data)
        {
            buffer_.Append(data);
        }

        /// <summary>
        /// FIXME
        /// </summary>
        /// <returns></returns>
        public string ReadFixMessage()
        {
            string msg = buffer_.ToString();
            buffer_ = new StringBuilder();
            return msg;
        }
    }
}
