using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// Parses bytestream into messages
    /// </summary>
    public class Parser
    {
        private readonly Encoding _encoding;
        private readonly byte[] _beginStringBytes;
        private readonly byte[] _bodyLengthBytes;
        private readonly byte[] _checkSumBytes;

        private byte[] _buffer = new byte[512];
        private int _usedBufferLength = 0;
        private int _bufferStartIndex = 0;

        public Parser() : this(CharEncoding.DefaultEncoding)
        { }

        public Parser(Encoding encoding)
        {
            _encoding = encoding;
            _beginStringBytes = encoding.GetBytes("8=");
            _bodyLengthBytes = encoding.GetBytes('\u0001' + "9=");
            _checkSumBytes = encoding.GetBytes('\u0001' + "10=");
        }

        public void AddToStream(byte[] data, int bytesAdded)
            => AddToStream(data.AsSpan(0, bytesAdded));

        public void AddToStream(Span<byte> data)
        {
            // We attempt to copy the new bytes into the existing buffer.
            if (data.TryCopyTo(_buffer.AsSpan(_bufferStartIndex + _usedBufferLength)))
            {
                _usedBufferLength += data.Length;
            }
            else
            {
                // There is not enough space at the end of the buffer.
                // If the new length is less than the length of the existing buffer,
                // then we can just move the existing data to the start of the buffer
                // and copy the new bytes in successfully. Otherwise we allocate a
                // larger buffer and copy everything in.
                // This avoids allocating a new array in all but the last case.
                int requiredLength = _usedBufferLength + data.Length;
                byte[] buffer = (uint)requiredLength <= _buffer.Length ? _buffer : new byte[requiredLength * 2]; // Allocate double to reduce subsequent resizes

                _buffer.AsSpan(_bufferStartIndex, _usedBufferLength).CopyTo(buffer);
                data.CopyTo(buffer.AsSpan(_usedBufferLength));
                _buffer = buffer;
                _bufferStartIndex = 0;
                _usedBufferLength = requiredLength;
            }
        }

        public bool ReadFixMessage(out string msg)
        {
            msg = "";

            Span<byte> buffer = _buffer.AsSpan(_bufferStartIndex, _usedBufferLength);

            int pos;

            if ((pos = buffer.IndexOf(_beginStringBytes)) < 0)
            {
                // BeginString (e.g. 8=) not yet found
                return false;
            }

            // Discard everything in the buffer up to the first BeginString tag
            _bufferStartIndex += pos;
            _usedBufferLength -= pos;

            buffer = _buffer.AsSpan(_bufferStartIndex, _usedBufferLength);

            Debug.Assert(buffer.StartsWith(_beginStringBytes));

            if (!ExtractLength(out int bodyLength, out int bytesConsumed, buffer))
            {
                // BodyLength tag and value (e.g. |9=YY|) not yet found
                return false;
            }

            buffer = buffer.Slice(--bytesConsumed);

            // buffer starts at the terminating SOH of the BodyLength (9) field
            // e.g.
            // 8=XX|9=YY|......
            //          ^
            //          |

            Debug.Assert(buffer[0] == 1);
            Debug.Assert(bodyLength >= 0);

            if (buffer.Length < bodyLength)
            {
                return false;
            }

            buffer = buffer.Slice(bodyLength);
            bytesConsumed += bodyLength;

            if ((pos = buffer.IndexOf(_checkSumBytes)) < 0)
            {
                // CheckSum (e.g. |10=) not yet found
                return false;
            }

            Debug.Assert(_buffer.AsSpan(_bufferStartIndex + bytesConsumed + pos).StartsWith(_checkSumBytes));

            buffer = buffer.Slice(pos + _checkSumBytes.Length);
            bytesConsumed += pos + _checkSumBytes.Length;

            // buffer starts at the first byte of the CheckSum value
            // e.g.
            // 8=XX|9=YY|.........|10=......
            //                        ^
            //                        |

            if ((pos = buffer.IndexOf((byte)1)) < 0)
            {
                // No terminating SOH found yet
                return false;
            }

            Debug.Assert(_buffer[_bufferStartIndex + bytesConsumed + pos] == 1);

            bytesConsumed += pos + 1; // +1 to include the terminating SOH

            msg = _encoding.GetString(_buffer, _bufferStartIndex, bytesConsumed);

            // Discard this message in the buffer
            _bufferStartIndex += bytesConsumed;
            _usedBufferLength -= bytesConsumed;

            return true;
        }

        public bool ExtractLength(out int bodyLength, out int bytesConsumed, string buf)
        {
            return ExtractLength(out bodyLength, out bytesConsumed, _encoding.GetBytes(buf));
        }

        public bool ExtractLength(out int bodyLength, out int bytesConsumed, Span<byte> buffer)
        {
            bodyLength = 0;
            bytesConsumed = 0;

            int pos;

            if ((pos = buffer.IndexOf(_bodyLengthBytes)) < 0)
            {
                // No BodyLength tag (|9=) found yet
                return false;
            }

            bytesConsumed = pos + _bodyLengthBytes.Length;

            buffer = buffer.Slice(bytesConsumed);

            if ((pos = buffer.IndexOf((byte)1)) < 0)
            {
                // No terminating SOH found yet
                bytesConsumed = 0;
                return false;
            }

            // The longest string representation of an Int32 with NumberStyles.None is 10.
            Span<char> bodyLengthChars = stackalloc char[10];
            int charsWritten = _encoding.GetChars(buffer.Slice(0, pos), bodyLengthChars);

            if (!int.TryParse(bodyLengthChars.Slice(0, charsWritten), NumberStyles.None, CultureInfo.InvariantCulture, out bodyLength))
            {
                // Bad BodyLength value. Discard the data in the buffer up to this point.
                bytesConsumed += pos + 1; // +1 to include the terminating SOH
                _bufferStartIndex += bytesConsumed;
                _usedBufferLength -= bytesConsumed;
                bytesConsumed = 0;
                throw new MessageParseError($"Invalid BodyLength value \"{bodyLengthChars.Slice(0, charsWritten)}\"");
            }

            bytesConsumed += pos + 1; // +1 to include the terminating SOH

            return true;
        }
    }
}
