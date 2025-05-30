using System;

public class ExceptionExample
{
    public void Handle()
    {
        try
        {
            int x = 1 / 0;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Handled exception: {ex.Message}"); // Безопасная и конкретная обработка исключения
        }
    }
}