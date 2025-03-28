using System;
using System.Buffers;

namespace QuickFix;

/// <summary>
/// Static class that manages the selected character encoding.
/// This impl is kind of a hack -- we're using a static class
/// so we don't have to alter a bunch of other classes to pass
/// a CharEncoding reference around.
/// </summary>
public static class CharEncoding
{
    public const string DefaultCharEncoding = "iso-8859-1";

    public static System.Text.Encoding SelectedEncoding { get; private set; }

    static CharEncoding()
    {
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        SelectedEncoding = System.Text.Encoding.GetEncoding(DefaultCharEncoding);
    }

    public static void ResetToDefaultEncoding() => SetEncoding(DefaultCharEncoding);

    public static void SetEncoding(string encoding) => SelectedEncoding = System.Text.Encoding.GetEncoding(encoding);

    /// <summary>
    /// Convert a string to a byte array using the current globally-set encoding.
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static byte[] GetBytes(string data) => SelectedEncoding.GetBytes(data);

    /// <summary>
    /// Convert a string to a byte array using the current globally-set encoding.
    /// This function uses a shared byte-pool for efficiency.
    /// The return value needs to be disposed; `using` is recommended (see existing usages).
    /// This function is still internal; we're not sure if we want to make it part of the public interface.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="bytes"></param>
    /// <returns></returns>
    internal static ValueDisposable GetBytes(ReadOnlySpan<char> data, out ReadOnlySpan<byte> bytes)
    {
        System.Text.Encoding encoding = SelectedEncoding;
        int byteCount = encoding.GetByteCount(data);
        byte[] buffer = ArrayPool<byte>.Shared.Rent(byteCount);

        encoding.GetBytes(data, new Span<byte>(buffer, 0, byteCount));
        bytes = new ReadOnlySpan<byte>(buffer, 0, byteCount);

        return new ValueDisposable(buffer);
    }
}

internal readonly ref struct ValueDisposable(byte[]? bytes)
{
    public void Dispose()
    {
        if (bytes == null) return;
        if (bytes.Length > 0) ArrayPool<byte>.Shared.Return(bytes);
    }
}
