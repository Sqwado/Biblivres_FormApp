using System;
using MySql.Data.MySqlClient;

namespace Biblivres.Globals
{
    internal class MySqlDb
    {
        public MySqlCommand command;
        public MySqlConnection connection;
        public MySqlDataAdapter data;

        public void InitConnection()
        {
            try
            {
                connection = new MySqlConnection(Globals.connectionString);
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
        }
    }
}