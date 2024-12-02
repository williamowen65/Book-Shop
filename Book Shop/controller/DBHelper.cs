using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
/**
 * This class provides a way to interact with the database
 * An instance has it's own connection to the database
 * and can perform all the CRUD ops needed by any other class.
 */
namespace Book_Shop.controller
{
    internal class DBHelper
    {
        private string connectionString;

        public DBHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }
    }
}
