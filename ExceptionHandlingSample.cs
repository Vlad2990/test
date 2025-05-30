using System;

public class ExceptionExample
{
    public void Handle()
    {
        try
        {
            int x = 1 / 0;
        }
        catch (Exception)
        {
            throw; // Уязвимость: перехватывается общий Exception без логирования
        }
    }
}