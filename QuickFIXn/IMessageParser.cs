namespace QuickFix
{
    public interface IMessageParser
    {
        Message ParseMessage(string fixMessage, bool validate = true);
    }
}
