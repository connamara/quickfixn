using System.Text;
namespace QuickFix
{
    /// <summary>
    /// </summary>
    public sealed class Parser
    {
        static readonly byte[] LengthFieldStartBytes = new byte[] { Message.SohByteValue, (byte)'9', (byte)'=' };
        static readonly byte[] CheckSumFieldStartBytes = new byte[] { Message.SohByteValue, (byte)'1', (byte)'0', (byte)'=' };

        private byte[] buffer_ = new byte[512];
        private int usedBufferLength = 0;

        public void AddToStream(byte[] data, int bytesAdded)
        {
            if (buffer_.Length < usedBufferLength + bytesAdded)
                System.Array.Resize<byte>(ref buffer_, (usedBufferLength + bytesAdded));
            System.Buffer.BlockCopy(data, 0, buffer_, usedBufferLength , bytesAdded);
            usedBufferLength += bytesAdded;
        }       

        public bool ReadFixMessage(out byte[] msg)
        {
            msg = new byte[0];
            if (buffer_.Length < 2)
                return false;
            
            int pos = 0;
            pos = ByteArray.IndexOf(buffer_, Message.StartOfBeginStringBytes, 0);
            if (-1 == pos)
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
           
                pos = ByteArray.IndexOf(buffer_, CheckSumFieldStartBytes, pos - 1);
                if (-1 == pos)
                    return false;
                pos += 4;

                pos = ByteArray.IndexOf(buffer_, Message.SohByteValue, pos);
                if (-1 == pos)
                    return false;
                pos += 1;

                msg = new byte[pos];
                System.Buffer.BlockCopy(buffer_, 0, msg, 0, pos);

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

        public bool ExtractLength(out int length, out int pos, byte[] buf)
        {
            length = 0;
            pos = 0;

            if (buf.Length < 1)
                return false;

            int startPos = ByteArray.IndexOf(buf, LengthFieldStartBytes, 0);
            if(-1 == startPos)
                return false;
            startPos +=3;

            int endPos = ByteArray.IndexOf(buf, Message.SohByteValue, startPos);
            if(-1 == endPos)
                return false;

            try
            {
                length = Fields.Converters.IntConverter.Convert(System.Text.Encoding.ASCII.GetString(buf, startPos, endPos - startPos));
                if (length < 0)
                {
                    throw new MessageParseError("Invalid BodyLength (" + length + ")");
                }
            }
            catch(FieldConvertError e)
            {
                throw new MessageParseError(e.Message, e);
            }

            pos = endPos + 1;
            return true;
        }

        private byte[] Remove(byte[] array, int count)
        {
            byte[] returnByte = new byte[array.Length - count];
            System.Buffer.BlockCopy(array, count, returnByte,0, array.Length - count);
            usedBufferLength -= count;
            return returnByte;
        }
    }
}
