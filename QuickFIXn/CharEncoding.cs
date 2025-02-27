using System;
using System.Buffers;
using System.Runtime.CompilerServices;

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ResetToDefaultEncoding() => SetEncoding(DefaultCharEncoding);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SetEncoding(string encoding) => SelectedEncoding = System.Text.Encoding.GetEncoding(encoding);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte[] GetBytes(string data) => SelectedEncoding.GetBytes(data);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IDisposable GetBytes(ReadOnlySpan<char> data, out ArraySegment<byte> bytes)
    {
        System.Text.Encoding encoding = SelectedEncoding;
        int byteCount = encoding.GetByteCount(data);
        byte[] arr = ArrayPool<byte>.Shared.Rent(byteCount);

        byteCount = encoding.GetBytes(data, arr);
        bytes = new ArraySegment<byte>(arr, 0, byteCount);

        return new ValueDisposable(arr);
    }

    private readonly struct ValueDisposable(byte[] bytes) : IDisposable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose() => ArrayPool<byte>.Shared.Return(bytes);
    }
}
