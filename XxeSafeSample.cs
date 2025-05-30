using System.Xml;

public class Example
{
    public void LoadXml(string xml)
    {
        XmlDocument doc = new XmlDocument();
        doc.XmlResolver = new XmlUrlResolver(); // ← уязвимость
        doc.LoadXml(xml);
    }
}
