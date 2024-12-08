using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop.controller
{
    internal class CustomerDB
    {
        // Create a new customer
        public static void CreateCustomer(string title, string firstName, string lastName, string dateOfBirth)
        {
            string query = "INSERT INTO Customer (Title, FirstName, LastName, DateOfBirth) VALUES (@title, @firstName, @lastName, @dateOfBirth)";
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Read all customers
        public static List<Dictionary<string, object>> ReadCustomers()
        {
            string query = "SELECT * FROM Customer";
            return DBHelper.Read(query);
        }
    }
}
