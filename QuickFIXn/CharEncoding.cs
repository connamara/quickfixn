namespace QuickFix;

/// <summary>
/// Static class that manages the selected character encoding.
/// This impl is kind of a hack -- we're using a static class
/// so we don't have to alter a bunch of other classes to pass
/// a CharEncoding reference around.
/// </summary>
public static class CharEncoding {
    public const string DefaultCharEncoding = "iso-8859-1";

    public static System.Text.Encoding SelectedEncoding { get; private set; }

    static CharEncoding() {
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        SelectedEncoding = System.Text.Encoding.GetEncoding(DefaultCharEncoding);
    }

    public static void ResetToDefaultEncoding() {
        SetEncoding(DefaultCharEncoding);
    }

    public static void SetEncoding(string encoding) {
        SelectedEncoding = System.Text.Encoding.GetEncoding(encoding);
    }

    public static byte[] GetBytes(string data) {
        return SelectedEncoding.GetBytes(data);
    }
}
