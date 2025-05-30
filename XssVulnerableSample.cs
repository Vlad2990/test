using System.Web;

public class Example
{
    public void Render(HttpResponse response, string userInput)
    {
        Response.Write(userInput);              // direct variable
        Response.Write("Hi " + userInput);     // concatenation
        Response.Write($"Hello {userInput}");  // interpolation
        Html.Raw(userInput);    
    }
}
