using System.Xml;

public class XxeExample
{
    public void ParseXml(string xml)
    {
        var xmlDoc = new XmlDocument(); // Уязвимость: небезопасный тип
        xmlDoc.LoadXml(xml);
    }
}