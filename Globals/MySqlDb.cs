using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblivres.Globals
{
    internal class MySqlDb
    {
        public MySqlConnection connection;
        public MySqlCommand command;
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
