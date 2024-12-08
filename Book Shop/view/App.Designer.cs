namespace Book_Shop
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddCustomer = new Button();
            btnOpenBookForm = new Button();
            label1 = new Label();
            cmboCustomer = new ComboBox();
            cmboBook = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            btnRegisterBook = new Button();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(738, 33);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(523, 226);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnOpenBookForm
            // 
            btnOpenBookForm.Location = new Point(738, 330);
            btnOpenBookForm.Name = "btnOpenBookForm";
            btnOpenBookForm.Size = new Size(523, 226);
            btnOpenBookForm.TabIndex = 1;
            btnOpenBookForm.Text = "Add Book";
            btnOpenBookForm.UseVisualStyleBackColor = true;
            btnOpenBookForm.Click += btnOpenBookForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(147, 41);
            label1.TabIndex = 2;
            label1.Text = "Customer";
            // 
            // cmboCustomer
            // 
            cmboCustomer.FormattingEnabled = true;
            cmboCustomer.Location = new Point(29, 77);
            cmboCustomer.Name = "cmboCustomer";
            cmboCustomer.Size = new Size(603, 49);
            cmboCustomer.TabIndex = 3;
            // 
            // cmboBook
            // 
            cmboBook.FormattingEnabled = true;
            cmboBook.Location = new Point(29, 187);
            cmboBook.Name = "cmboBook";
            cmboBook.Size = new Size(603, 49);
            cmboBook.TabIndex = 5;
            cmboBook.SelectedIndexChanged += cmboBook_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 143);
            label2.Name = "label2";
            label2.Size = new Size(86, 41);
            label2.TabIndex = 4;
            label2.Text = "Book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 266);
            label3.Name = "label3";
            label3.Size = new Size(80, 41);
            label3.TabIndex = 6;
            label3.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(29, 310);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(603, 47);
            dtpDate.TabIndex = 7;
            dtpDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnRegisterBook
            // 
            btnRegisterBook.Location = new Point(29, 383);
            btnRegisterBook.Name = "btnRegisterBook";
            btnRegisterBook.Size = new Size(603, 173);
            btnRegisterBook.TabIndex = 8;
            btnRegisterBook.Text = "Register Book";
            btnRegisterBook.UseVisualStyleBackColor = true;
            btnRegisterBook.Click += btnRegisterBook_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 573);
            Controls.Add(btnRegisterBook);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(cmboBook);
            Controls.Add(label2);
            Controls.Add(cmboCustomer);
            Controls.Add(label1);
            Controls.Add(btnOpenBookForm);
            Controls.Add(btnAddCustomer);
            Name = "App";
            Text = "Book Registration";
            Load += App_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private Button btnOpenBookForm;
        private Label label1;
        private ComboBox cmboCustomer;
        private ComboBox cmboBook;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDate;
        private Button btnRegisterBook;
    }
}
