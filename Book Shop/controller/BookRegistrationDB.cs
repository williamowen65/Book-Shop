using Book_Shop.model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop.controller
{
    internal class BookRegistrationDB
    {
        /// <summary>
        /// Saves a Book to the DB
        /// </summary>
        public static void RegisterBook(Registration registration)
        {

            string query = "INSERT INTO Registration (CustomerID, ISBN, RegDate) VALUES (@customerID, @isbn, @regDate)";
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerID", registration.CustomerID);
                    command.Parameters.AddWithValue("@isbn", registration.ISBN);
                    command.Parameters.AddWithValue("@regDate", registration.RegDate);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show($"Record logged in database:\n\n{registration}", "Book Registration");
        }
    }
}
