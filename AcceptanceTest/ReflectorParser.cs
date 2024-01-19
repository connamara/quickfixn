using System;

namespace AcceptanceTest;

/// <summary>
/// Parses bytestream into messages
/// </summary>
public class ReflectorParser
{
    private byte[] buffer_ = new byte[512];
    int usedBufferLength = 0;

    static readonly System.Text.Encoding DefaultEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");

    public void AddToStream(byte[] data, int bytesAdded)
    {
        if (buffer_.Length < usedBufferLength + bytesAdded)
            Array.Resize(ref buffer_, (usedBufferLength + bytesAdded));
        Buffer.BlockCopy(data, 0, buffer_, usedBufferLength, bytesAdded);
        usedBufferLength += bytesAdded;
    }

    public bool ReadFixMessage(out string msg)
    {
        msg = "";

        if (buffer_.Length < 2)
            return false;

        int pos = IndexOf(buffer_, "8=", 0);
        if (-1 == pos)
            return false;

        buffer_ = Remove(buffer_, pos);
        pos = 0;

        int length = 0;

        if (!ExtractLength(out length, out pos, buffer_))
            return false;

        // pos is at first character past the BodyLength field (tag 9)

        pos += length;
        if (buffer_.Length < pos)
            return false;

        pos = IndexOf(buffer_, "\x01" + "10=", pos - 1);
        if (-1 == pos)
            return false; // no tag 10 received yet
        pos += 4; // pos now just after "10="

        pos = IndexOf(buffer_, "\x01", pos);
        if (-1 == pos)
            return false;
        pos += 1;

        msg = Substring(buffer_, 0, pos);
        buffer_ = Remove(buffer_, pos);
        return true;
    }

    public static bool ExtractLength(out int length, out int pos, string buf)
    {
        return ExtractLength(out length, out pos, DefaultEncoding.GetBytes(buf));
    }

    public static bool ExtractLength(out int length, out int pos, byte[] buf)
    {
        length = 0;
        pos = 0;

        if (buf.Length < 1)
            return false;

        int startPos = IndexOf(buf, "\x01" + "9=", 0);
        if (-1 == startPos)
            return false;
        startPos += 3;

        int endPos = IndexOf(buf, "\x01", startPos);
        if (-1 == endPos)
            return false;

        string strLength = Substring(buf, startPos, endPos - startPos);
        length = System.Convert.ToInt32(strLength);
        if (length < 0)
            throw new Exception("Invalid BodyLength (" + length + ")");

        pos = endPos + 1;
        return true;
    }

    private static int IndexOf(byte[] arrayToSearchThrough, string stringPatternToFind, int offset)
    {
        byte[] patternToFind = DefaultEncoding.GetBytes(stringPatternToFind);
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
        byte[] returnByte = new byte[array.Length - count];
        Buffer.BlockCopy(array, count, returnByte, 0, array.Length - count);
        usedBufferLength -= count;
        return returnByte;
    }

    private static string Substring(byte[] array, int startIndex, int length)
    {
        byte[] returnByte = new byte[length];
        Buffer.BlockCopy(array, startIndex, returnByte, 0, length);
        return DefaultEncoding.GetString(returnByte);
    }
}
