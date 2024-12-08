using Book_Shop.model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop.controller
{
    internal class BookDB
    {
        public static void CreateBook(string isbn, string title, decimal price)
        {
            string query = "INSERT INTO Book (ISBN, Title, Price) VALUES (@isbn, @title, @price)";
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@isbn", isbn);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@price", price);
                    command.ExecuteNonQuery();

                }
            }
        }

        //public static List<Dictionary<string, object>> GetAllBooks()
         public static List<Book> GetAllBooks()
        {
            string query = "SELECT * FROM Book";
            List<Dictionary<string, object>> result = DBHelper.Read(query);
            List<Book> books = new List<Book>();

            foreach (var row in result)
            {
                string isbn = row["ISBN"].ToString();
                string title = row["Title"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);
                books.Add(new Book(title, price, isbn));
            }

            return books;
        }
    }
}
