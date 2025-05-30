using System.Data.SqlClient;

public class SqlInjectionExample
{
    public void Query(string userInput)
    {
        var command = new SqlCommand("SELECT * FROM Users WHERE name = @name");
        command.Parameters.AddWithValue("@name", userInput); // Безопасное использование параметров
        command.ExecuteReader();
    }
}