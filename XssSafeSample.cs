using System.Web;

public class Example
{
    public void Render(HttpResponse response, string userInput)
    {
        response.Write(HttpUtility.HtmlEncode(userInput)); // ← безопасно
    }
}
