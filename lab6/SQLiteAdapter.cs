using lab6;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

public class SQLiteAdapter : IDataProvider
{
    private readonly string _connectionString;

    public SQLiteAdapter(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<string> GetData()
    {
        var data = new List<string>();
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand("SELECT Name FROM ExampleTable", connection);
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

