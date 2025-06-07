using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Configuration;

public class DatabaseHelper
{
    private static string connectionString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}

