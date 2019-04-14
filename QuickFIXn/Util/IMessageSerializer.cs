using System.Xml;
using System.Xml.Linq;

namespace QuickFix.Util
{
    public interface IMessageSerializer
    {
        XDocument ToXDocument(Message message);
        XmlDocument ToXmlDocument(Message message);
    }
}
