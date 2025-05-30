using System;
using System.Web;

public class XssExample
{
    public void Output(HttpResponse response, string userInput)
    {
        var encodedInput = HttpUtility.HtmlEncode(userInput);
        response.Write(encodedInput); // Безопасный вывод: данные экранированы
    }
}