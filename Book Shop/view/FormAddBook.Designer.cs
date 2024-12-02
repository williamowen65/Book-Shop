namespace Book_Shop.view
{
    partial class FormAddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCreateBook = new Button();
            txtISBN = new TextBox();
            txtPrice = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 43);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // btnCreateBook
            // 
            btnCreateBook.Location = new Point(90, 257);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(509, 58);
            btnCreateBook.TabIndex = 1;
            btnCreateBook.Text = "Add book to store inventory";
            btnCreateBook.UseVisualStyleBackColor = true;
            btnCreateBook.Click += btnCreateBook_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(226, 37);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(394, 47);
            txtISBN.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(226, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(394, 47);
            txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 116);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(226, 183);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(394, 47);
            txtTitle.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 189);
            label4.Name = "label4";
            label4.Size = new Size(74, 41);
            label4.TabIndex = 5;
            label4.Text = "Title";
            // 
            // FormAddBook
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 343);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtISBN);
            Controls.Add(btnCreateBook);
            Controls.Add(label1);
            Name = "FormAddBook";
            Text = "Add a New Book";
            Load += FormAddBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCreateBook;
        private TextBox txtISBN;
        private TextBox txtPrice;
        private Label label2;
        private TextBox txtTitle;
        private Label label4;
    }
}