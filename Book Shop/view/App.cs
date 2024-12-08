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
            OpenChildForm(new FormAddCustomer());
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen

            childForm.Show();
        }

        private void btnOpenBookForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddBook());
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
            // Add customers to the combobox
             cmboCustomer.Items.Add(new Customer("Mr", "John", "Doe", "Jan 10, 1990"));

            // Add books to the combobox    
             cmboBook.Items.Add(new Book("The Great Gatsby", 123, "123213"));
        }
    }
}
