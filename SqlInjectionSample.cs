using System.Data.SqlClient;

public class SqlInjectionExample
{
    public void Query(string userInput)
    {
        string query = "SELECT * FROM Users WHERE name = '" + userInput + "'"; // Уязвимость: конкатенация строки
        var command = new SqlCommand(query);
        command.ExecuteReader();
    }
}