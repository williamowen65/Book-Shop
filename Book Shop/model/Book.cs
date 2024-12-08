using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop.model
{
    internal class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
        public Book(string Title, decimal Price, string ISBN) {
            this.ISBN = ISBN;
            this.Price = Price;
            this.Title = Title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
