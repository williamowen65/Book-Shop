using Book_Shop.controller;
using Book_Shop.model;
using Book_Shop.view;

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

            // Show results in dialog
            MessageBox.Show("Customer: " + customer);

        }

        private void cmboBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {
            // Read all customers and books from the database
            List<Dictionary<string, object>> allBooks = BookDB.ReadBooks();
            List<Dictionary<string, object>> allCustomers = CustomerDB.ReadCustomers();


            // Add customers to the combobox
            foreach (var customer in allCustomers)
            {
                cmboCustomer.Items.Add(new Customer(customer["Title"].ToString(), customer["FirstName"].ToString(), customer["LastName"].ToString(), customer["DateOfBirth"].ToString()));
            }


            // Add books to the combobox
            foreach (var book in allBooks)
            {
                cmboBook.Items.Add(new Book(book["Title"].ToString(), Convert.ToInt32(book["Price"]), book["ISBN"].ToString()));
            }
        }
    }
}
