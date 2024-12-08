using Book_Shop.model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

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
        public static List<Customer> GetAllCustomers()
        {
            string query = "SELECT * FROM Customer";
            List<Dictionary<string, object>> result = DBHelper.Read(query);
            List<Customer> customers = new List<Customer>();
            foreach (var row in result)
            {
                int customerID = (int)row["CustomerID"];
                string title = (string)row["Title"];
                string firstName = (string)row["FirstName"];
                string lastName = (string)row["LastName"];
                string dateOfBirth = row["DateOfBirth"] != DBNull.Value ? ((DateTime)row["DateOfBirth"]).ToString("yyyy-MM-dd") : null;
                customers.Add(new Customer(customerID, title, firstName, lastName, dateOfBirth));
            }
            return customers;
        }

        // Get customer ID
        public static int GetCustomerID(string title, string firstName, string lastName, string dateOfBirth)
        {
            string query = "SELECT CustomerID FROM Customer WHERE Title = @title AND FirstName = @firstName AND LastName = @lastName AND DateOfBirth = @dateOfBirth";
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
