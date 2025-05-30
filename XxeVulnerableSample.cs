using System.Xml;

public class Example
{
    public void LoadXml(string xml)
    {
        XmlDocument doc = new XmlDocument();
        doc.XmlResolver = null; // ← безопасно
        doc.LoadXml(xml);
    }
}
