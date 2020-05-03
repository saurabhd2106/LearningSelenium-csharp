using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CommonLibs.Utils
{
    public class DataBaseConnector
    {
        private readonly MySqlConnection connection;

        public DataBaseConnector(string server, string database, string username, string password)
        {
           
                string connectionString = $"server={server};database={database};uid={username};pwd={password}";
                MySqlConnection connection;

                connection = new MySqlConnection(connectionString);

                Console.Write("Connection Established!");


        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


    }
}
