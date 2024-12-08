﻿using Book_Shop.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Book_Shop.controller;

namespace Book_Shop.view
{
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("ISBN cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isPriceValid = decimal.TryParse(txtPrice.Text, out decimal price);

            if (!isPriceValid)
            {
                MessageBox.Show("Price cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with creating the book

            // Get values from form and trim whitespace
            string isbn = txtISBN.Text.Trim();
            string title = txtTitle.Text.Trim();
          

            BookDB.CreateBook(isbn, title, price);

            MessageBox.Show("Book created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtPrice.Text = "";

            // focus first input
            txtISBN.Focus();


        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}