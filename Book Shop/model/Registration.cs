using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop.model
{
    internal class Registration
    {
        public int CustomerID;
        public string ISBN;
        public string RegDate;
        public Registration(Customer customer, Book book, string date)
        {
            this.CustomerID = customer.CustomerID;
            this.ISBN = book.ISBN;
            this.RegDate = date;
        }

        public override string ToString()
        {
            return $"CustomerID: {CustomerID}\nISBN: {ISBN}\nRegistered on: {RegDate} ";
        }
    }
}
