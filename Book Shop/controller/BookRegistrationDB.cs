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
                    try {
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Record logged in database:\n\n{registration}", "Book Registration");
                    }
                    catch (Microsoft.Data.SqlClient.SqlException ex) {
                        // check for duplicate key error
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("This book is already registered to this customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
            }

          

      
        }
    }
}
