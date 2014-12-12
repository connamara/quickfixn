using System;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// </summary>
    public sealed class Parser
    {
        private static readonly byte[] LengthFieldStartBytes = new byte[] { Message.SohByteValue, (byte)'9', (byte)'=' };
        private static readonly byte[] CheckSumFieldStartBytes = new byte[] { (byte)'1', (byte)'0', (byte)'=' };

        private byte[] _buffer = new byte[1];
        private int _readpos;
        private int _writepos;
    
        public void AddToStream(byte[] data, int bytesAdded)
        {
            int oldBufferSize = _buffer.Length;
            int bytesInBuffer = (_writepos - _readpos + oldBufferSize) % oldBufferSize;

            if (oldBufferSize <= bytesInBuffer + bytesAdded) // Notice that we cannot use the last byte.
            {
                byte[] newBuffer = new byte[Math.Max(bytesInBuffer + bytesAdded + 1, 2 * oldBufferSize)];
                CopyFromCircularToLinear(_buffer, _readpos, bytesInBuffer, newBuffer, 0);
                _buffer = newBuffer;
                _readpos = 0;
                _writepos = bytesInBuffer;
            }

            AddToBuffer(data, 0, bytesAdded);
        }

        public bool ReadFixMessage(out byte[] msg)
        {
            msg = new byte[0];

            int bytesInBuffer = (_writepos - _readpos + _buffer.Length) % _buffer.Length;

            if (bytesInBuffer < 2)
                return false;

            int messageStartPos = ByteArray.IndexOfCircular(_buffer, _readpos, bytesInBuffer, Message.StartOfBeginStringBytes);
            if (messageStartPos == -1)
                return false;
            _readpos = messageStartPos;

            bytesInBuffer = (_writepos - _readpos + _buffer.Length) % _buffer.Length;

            try
            {
                int readposAfterLength;
                int length;
                if (!ExtractLength(out length, out readposAfterLength, _buffer, _readpos, bytesInBuffer))
                    return false;

                if ((_writepos - readposAfterLength + _buffer.Length) % _buffer.Length < length)
                    return false;

                int readposAfterSkip = (readposAfterLength + length) % _buffer.Length;

                if (_buffer[(readposAfterSkip - 1) % _buffer.Length] != Message.SohByteValue)
                {
                    throw new MessageParseError("SOH expected just before end of skipping " + length + " bytes.");
                }

                int checkSumPos = ByteArray.IndexOfCircular(_buffer, readposAfterSkip, (_writepos - readposAfterSkip + _buffer.Length) % _buffer.Length, CheckSumFieldStartBytes);
                if (checkSumPos == -1)
                {
                    return false;
                }
                int endOfCheckSumPos = ByteArray.IndexOfCircular(_buffer, checkSumPos, (_writepos - checkSumPos + _buffer.Length) % _buffer.Length, Message.SohByteValue);
                if (endOfCheckSumPos == -1)
                {
                    return false;
                }

                int newReadPos = (endOfCheckSumPos + 1) % _buffer.Length;
                int messageLength = (newReadPos - _readpos + _buffer.Length) % _buffer.Length;

                msg = new byte[messageLength];
                CopyFromCircularToLinear(_buffer, _readpos, messageLength, msg, 0);
                _readpos = newReadPos;
                return true;
            }
            catch (MessageParseError e)
            {
                _readpos = _writepos;
                throw e;
            }
        }

        public static bool ExtractLength(out int length, out int readpos, byte[] buf, int offset, int bytesInBuffer)
        {
            length = 0;
            readpos = 0;

            if (bytesInBuffer < 1)
                return false;

            int startPos = ByteArray.IndexOfCircular(buf, offset, bytesInBuffer, LengthFieldStartBytes);
            if (startPos == -1)
            {
                return false;
            }
            startPos = (startPos + LengthFieldStartBytes.Length) % buf.Length;

            int endPos = ByteArray.IndexOfCircular(buf, startPos, bytesInBuffer - LengthFieldStartBytes.Length, Message.SohByteValue);
            if (endPos == -1)
            {
                return false;
            }

            try
            {
                if (endPos < startPos)
                {
                    byte[] lengthBytes = new byte[(endPos - startPos + buf.Length) % buf.Length];
                    CopyFromCircularToLinear(buf, startPos, endPos - startPos + buf.Length, lengthBytes, 0);
                    length = Fields.Converters.IntConverter.Convert(System.Text.Encoding.ASCII.GetString(lengthBytes));
                }
                else
                {
                    length = Fields.Converters.IntConverter.Convert(System.Text.Encoding.ASCII.GetString(buf, startPos, endPos - startPos));
                }
                if (length < 0)
                {
                    throw new MessageParseError("Invalid BodyLength (" + length + ")");
                }
            }
            catch(FieldConvertError e)
            {
                throw new MessageParseError(e.Message, e);
            }
            readpos = endPos + 1;
            return true;
        }

        private void AddToBuffer(byte[] data, int offset, int length)
        {
            int bufferSize = _buffer.Length;

            int bytesToCopy1 = Math.Min(length, bufferSize - _writepos);
            System.Buffer.BlockCopy(data, offset, _buffer, _writepos, bytesToCopy1);
            _writepos = (_writepos + bytesToCopy1) % bufferSize;

            int bytesToCopy2 = length - bytesToCopy1;
            if (length > bytesToCopy1)
            {
                System.Buffer.BlockCopy(data, offset + bytesToCopy1, _buffer, _writepos, bytesToCopy2);
                _writepos = (_writepos + bytesToCopy2) % bufferSize;
            }
        }

        private static void CopyFromCircularToLinear(byte[] source, int sourceOffset, int bytesToCopy, byte[] destination, int destinationOffset)
        {
            int bytesBeforeWrap = Math.Min(bytesToCopy, source.Length - sourceOffset);
            System.Buffer.BlockCopy(source, sourceOffset, destination, 0, bytesBeforeWrap);
            if (bytesBeforeWrap < bytesToCopy)
            {
                System.Buffer.BlockCopy(source, 0, destination, bytesBeforeWrap, bytesToCopy - bytesBeforeWrap);
            }
        }
    }
}
