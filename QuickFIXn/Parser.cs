using System.Text;

namespace QuickFix
{
    /// <summary>
    /// </summary>
    public class Parser
    {
        public static readonly Encoding EightBitTransparentEncoding = Encoding.GetEncoding("iso-8859-1"); // we cannot use ASCII or UTF-8 etc., as they mangle bytes > 7F, which can be used in fields of type DATA

        private byte[] buffer_ = new byte[512];
        int usedBufferLength = 0;

        public void AddToStream(byte[] data, int offset, int count)
        {
            if (buffer_.Length < usedBufferLength + count)
                System.Array.Resize<byte>(ref buffer_, (usedBufferLength + count));
            System.Buffer.BlockCopy(data, offset, buffer_, usedBufferLength , count);
            usedBufferLength += count;
        }

        public void AddToStream(string data)
        {
            byte[] bytes = EightBitTransparentEncoding.GetBytes(data);
            AddToStream(bytes, 0, bytes.Length);
        }

        public bool ReadFixMessage(out string msg)
        {
            msg = "";
            
            if(buffer_.Length < 2)
                return false;
            
            int pos = 0;
            pos = IndexOf(buffer_, "8=", 0);
            if(-1 == pos)
                return false;

            buffer_ = Remove(buffer_, pos);
            pos = 0;

            int length = 0;

            try
            {
                if (!ExtractLength(out length, out pos, buffer_))
                    return false;

                pos += length;
                if (buffer_.Length < pos)
                    return false;
           
                pos = IndexOf(buffer_, "\x01" + "10=", pos - 1);
                if (-1 == pos)
                    return false;
                pos += 4;

                pos = IndexOf(buffer_, "\x01", pos);
                if (-1 == pos)
                    return false;
                pos += 1;

                msg = Substring(buffer_, 0, pos);
                buffer_ = Remove(buffer_, pos);
                return true;
            }
            catch (MessageParseError e)
            {
                if ((length > 0) && (pos <= buffer_.Length))
                    buffer_ = Remove(buffer_, pos);
                else
                    buffer_ = Remove(buffer_, buffer_.Length);
                throw e;
            }
        }

        public bool ExtractLength(out int length, out int pos, string buf)
        {
            return ExtractLength(out length, out pos, EightBitTransparentEncoding.GetBytes(buf));
        }

        public bool ExtractLength(out int length, out int pos, byte[] buf)
        {
            length = 0;
            pos = 0;

            if (buf.Length < 1)
                return false;

            int startPos = IndexOf(buf, "\x01" + "9=", 0);
            if(-1 == startPos)
                return false;
            startPos +=3;

            int endPos = IndexOf(buf, "\x01", startPos);
            if(-1 == endPos)
                return false;

            string strLength = Substring(buf, startPos, endPos - startPos);
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

        private int IndexOf(byte[] arrayToSearchThrough, string stringPatternToFind, int offset)
        {
            byte[] patternToFind = EightBitTransparentEncoding.GetBytes(stringPatternToFind);
            if (patternToFind.Length > arrayToSearchThrough.Length)
                return -1;
            for (int i = offset; i <= arrayToSearchThrough.Length - patternToFind.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < patternToFind.Length; j++)
                {
                    if (arrayToSearchThrough[i + j] != patternToFind[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return i;
                }
            }
            return -1;
        }
        private byte[] Remove(byte[] array, int count)
        {
            if (count == 0)
                return array;

            byte[] returnByte = new byte[array.Length - count];
            System.Buffer.BlockCopy(array, count, returnByte,0, array.Length - count);
            usedBufferLength -= count;
            return returnByte;
        }

        private string Substring(byte[] array, int startIndex, int length)
        {
            byte[] returnByte = new byte[length];
            System.Buffer.BlockCopy(array, startIndex, returnByte, 0, length);
            return EightBitTransparentEncoding.GetString(returnByte);
        }
    }
}
