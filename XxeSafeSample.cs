using System.Xml;

public class XxeExample
{
    public void ParseXml(string xml)
    {
        var settings = new XmlReaderSettings
        {
            DtdProcessing = DtdProcessing.Prohibit
        };
        using var reader = XmlReader.Create(new System.IO.StringReader(xml), settings);
        var xmlDoc = new XmlDocument();
        xmlDoc.Load(reader); // Безопасная загрузка XML
    }
}