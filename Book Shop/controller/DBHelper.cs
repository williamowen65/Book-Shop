using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
/**
 * This class provides a way to interact with the database
 * An instance has it's own connection to the database
 * and can perform all the CRUD ops needed by any other class.
 */
namespace Book_Shop.controller
{
    internal class DBHelper
    {

        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection("Data Source=DESKTOP-COPKNK8\\SQLEXPRESS;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred in: " + ex.Message);
                return null;
            }
        }


        /// <summary>
        /// Create: CRUD operations ( maybe call this OpenConnection() )
        /// </summary>
        /// <param name="query"></param>
        public static void Create(string query)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                //MessageBox.Show("Connection Opened \n" + query);


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Dictionary<string, object>> Read(string query)
        {
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                //MessageBox.Show("Connection Opened \n" + query);

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            results.Add(row);
                        }
                    }
                }
            }

            return results;
        }


    }
}
