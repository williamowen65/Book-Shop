using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop.model
{
    internal class Customer
    {

        string DateOfBirth;
        string FirstName;
        string LastName;
        string Title;

        public Customer(string Title, string FirstName, string LastName, string DateOfBirth)
        {
            this.DateOfBirth = DateOfBirth;
            this.FirstName = FirstName;
            this.Title = Title;
            this.LastName = LastName;
        }

        public override string ToString()
        {
            return $"{Title} {FirstName} {LastName}, born on {DateOfBirth}";
        }
    }
}
