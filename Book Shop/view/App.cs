using Book_Shop.controller;
using Book_Shop.model;
using Book_Shop.view;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Book_Shop
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddCustomer(this));
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen

            childForm.Show();
        }

        private void btnOpenBookForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddBook(this));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            // Get values from form
            Customer? customer = (Customer)cmboCustomer.SelectedItem;
            Book? book = (Book)cmboBook.SelectedItem;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            // Validate fields
            if (customer == null)
            {
                MessageBox.Show("Please select a customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (book == null)
            {
                MessageBox.Show("Please select a book.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(date))
            {
                MessageBox.Show("Please select a date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new Registration
            Registration registration = new Registration(customer, book, date);

            // Save registration to db
            BookRegistrationDB.RegisterBook(registration);
            // clear the combobox selections 
            cmboCustomer.SelectedIndex = -1;
            cmboBook.SelectedIndex = -1;

        }


        private void cmboBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {
            // Read all customers and books from the database
            List<Book> allBooks = BookDB.GetAllBooks();
            List<Customer> allCustomers = CustomerDB.GetAllCustomers();


            // Add customers to the combobox
            foreach (var customer in allCustomers)
            {
                cmboCustomer.Items.Add(customer);
            }


            // Add books to the combobox
            foreach (Book book in allBooks)
            {
                cmboBook.Items.Add(book);
            }
        }
    }
}
