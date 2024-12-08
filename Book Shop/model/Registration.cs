using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop.model
{
    internal class Registration
    {
        int CustomerID;
        string ISBN;
        public Registration(Customer customer, Book book)
        {
            this.CustomerID = customer.CustomerID;
            this.ISBN = book.ISBN;
        }

        public override string ToString()
        {
            return $"CustomerID: {CustomerID}\n ISBN: {ISBN}";
        }
    }
}
