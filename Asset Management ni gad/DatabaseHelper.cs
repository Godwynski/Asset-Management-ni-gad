using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System;
using System.Data;

public class DatabaseHelper
{
    private MySqlConnection connection;

    public DatabaseHelper(string server, string database, string username, string password)
    {
        string connectionString = $"Server={server}; database={database}; uid={username}; pwd={password}";
        connection = new MySqlConnection(connectionString);
    }

    // Open the connection
    public void OpenConnection()
    {
        if (connection.State != ConnectionState.Open)
        {
            connection.Open();
        }
    }

    // Close the connection
    public void CloseConnection()
    {
        if (connection.State != ConnectionState.Closed)
        {
            connection.Close();
        }
    }

    // Execute a non-query command (INSERT, UPDATE, DELETE)
    public void ExecuteNonQuery(string query)
    {
        try
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }

    // Execute a query that returns data (SELECT)
    public DataTable ExecuteQuery(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            OpenConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
        return dt;
    }
}

