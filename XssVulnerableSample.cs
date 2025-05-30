using System.Web;

public class Example
{
    public void Render(HttpResponse response, string userInput)
    {
        response.Write(userInput); // ← XSS уязвимость
    }
}
