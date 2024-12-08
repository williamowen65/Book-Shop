using Book_Shop.model;
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
        public static void RegisterBook(Registration registration) {
            MessageBox.Show($"Would save {registration}");

        }
    }
}
