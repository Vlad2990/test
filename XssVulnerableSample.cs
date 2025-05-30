using System;
using System.Web;

public class XssExample
{
    public void Output(HttpResponse response, string userInput)
    {
        response.Write(userInput); // Уязвимость: прямой вывод пользовательских данных
    }
}