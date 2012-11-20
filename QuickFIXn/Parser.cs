
namespace QuickFix
{
    /// <summary>
    /// TODO use a byte[]/char[] for buffer_ instead of a string
    /// </summary>
    public class Parser
    {
        private string buffer_ = "";

        public void AddToStream(string data)
        {
            buffer_ += data;
        }

        public bool ReadFixMessage(out string msg)
        {
            msg = "";
            
            if(buffer_.Length < 2)
                return false;
            
            int pos = 0;

            pos = buffer_.IndexOf("8=");
            if(-1 == pos)
                return false;

            buffer_ = buffer_.Remove(0, pos);
            pos = 0;

            int length = 0;
            int msgBodyStart = 0;
            int msgBodyEnd = 0;

            try
            {
                if (!ExtractLength(out length, out pos, buffer_))
                    return false;

                msgBodyStart = pos;
                
                pos += length;
                if (buffer_.Length < pos)
                    return false;

                pos = buffer_.IndexOf("\x01" + "10=", pos - 1);
                if (-1 == pos)
                    return false;
                msgBodyEnd = pos + 1;
                pos += 4;

                pos = buffer_.IndexOf("\x01", pos);
                if (-1 == pos)
                    return false;
                pos += 1;

                if ((msgBodyEnd - msgBodyStart) != length)
                    throw new MessageParseError("Invalid body length");

                msg = buffer_.Substring(0, pos);
                buffer_ = buffer_.Remove(0, pos);
                return true;
            }
            catch (MessageParseError e)
            {
                if ((length > 0) && (pos <= buffer_.Length))
                    buffer_ = buffer_.Remove(0, pos);
                else
                    buffer_ = buffer_.Remove(0, buffer_.Length);
                throw e;
            }
        }

        public bool ExtractLength(out int length, out int pos, string buf)
        {
            length = 0;
            pos = 0;

            if (buf.Length < 1)
                return false;

            int startPos = buf.IndexOf("\x01" + "9=", 0);
            if(-1 == startPos)
                return false;
            startPos +=3;

            int endPos = buf.IndexOf("\x01", startPos);
            if(-1 == endPos)
                return false;

            string strLength = buf.Substring(startPos, endPos - startPos);

            try
            {
                length = Fields.Converters.IntConverter.Convert(strLength);
                if(length < 0)
                    throw new MessageParseError("Invalid BodyLength (" + length + ")");
            }
            catch(FieldConvertError e)
            {
                throw new MessageParseError(e.Message, e);
            }

            pos = endPos + 1;
            return true;
        }

        private bool Fail(string what)
        {
            System.Console.WriteLine("Parser failed: " + what);
            return false;
        }
    }
}
