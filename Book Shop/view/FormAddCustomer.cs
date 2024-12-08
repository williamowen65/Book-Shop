using Book_Shop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop.view
{
    public partial class FormAddCustomer : Form
    {
        App mainApp;
        public FormAddCustomer(App mainApp)
        {
            this.mainApp = mainApp;
            InitializeComponent();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            // Get values from form
            string title = txtTitle.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string dateOfBirth = dobInput.Value.ToString("yyyy-MM-dd");

            // Add customer to the database
            controller.CustomerDB.CreateCustomer(title, firstName, lastName, dateOfBirth);
            // Add Customer to DOM
            mainApp.cmboCustomer.Items.Add(new Customer(title, firstName, lastName, dateOfBirth));
            // Select the newly created customer
            mainApp.cmboCustomer.SelectedIndex = mainApp.cmboCustomer.Items.Count - 1;

            // Show success message
            MessageBox.Show("Customer created successfully");

            // Clear form
            txtTitle.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";

            // Focus on first textbox
            txtTitle.Focus();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
