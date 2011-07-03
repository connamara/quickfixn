using System.Collections.Generic;
using System.Text;

namespace QuickFix
{
    public class Parser
    {
        private StringBuilder buffer_ = new StringBuilder();

        public void AddToStream(string data)
        {
            buffer_.Append(data);
        }
    }
}
