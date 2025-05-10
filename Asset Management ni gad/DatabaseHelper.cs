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

    public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
    {
        int result = 0;
        try
        {
            OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(query, GetConnection()))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
        return result;
    }



    // Close the connection
    public void CloseConnection()
    {
        if (connection.State != ConnectionState.Closed)
        {
            connection.Close();
        }
    }
    public int ExecuteNonQuery(string query)
    {
        int rowsAffected = 0;
        try
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            rowsAffected = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
        return rowsAffected;
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
    public MySqlConnection GetConnection()
    {
        return connection;
    }
    public DataTable ExecuteParameterizedQuery(string query, MySqlParameter[] parameters)
    {
        DataTable dt = new DataTable();
        try
        {
            OpenConnection(); // Open the database connection

            // Create the command using the query and the connection
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                // Add the parameters to the command
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                // Create a data adapter to execute the query and fill the data table
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message); // Log the error
        }
        finally
        {
            CloseConnection(); // Always close the connection
        }

        return dt; // Return the populated data table
    }


}

