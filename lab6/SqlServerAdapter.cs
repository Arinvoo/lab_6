using lab6;
using System.Collections.Generic;
using System.Data.SqlClient;

public class SqlServerAdapter : IDataProvider
{
    private readonly string _connectionString;

    public SqlServerAdapter(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<string> GetData()
    {
        var data = new List<string>();
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("SELECT Name FROM ExampleTable", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    data.Add(reader.GetString(0));
                }
            }
        }
        return data;
    }
}

