namespace Book_Shop.view
{
    partial class FormAddCustomer
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
            txtTitle = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            txtISBN = new TextBox();
            btnCreateBook = new Button();
            lablel1 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(204, 168);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(394, 47);
            txtTitle.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 174);
            label4.Name = "label4";
            label4.Size = new Size(184, 41);
            label4.TabIndex = 12;
            label4.Text = "Date of Birth";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(204, 95);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(394, 47);
            txtPrice.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 101);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(204, 22);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(394, 47);
            txtISBN.TabIndex = 9;
            // 
            // btnCreateBook
            // 
            btnCreateBook.Location = new Point(68, 242);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(509, 58);
            btnCreateBook.TabIndex = 8;
            btnCreateBook.Text = "Add Customer to Store";
            btnCreateBook.UseVisualStyleBackColor = true;
            // 
            // lablel1
            // 
            lablel1.AutoSize = true;
            lablel1.Location = new Point(18, 28);
            lablel1.Name = "lablel1";
            lablel1.Size = new Size(160, 41);
            lablel1.TabIndex = 7;
            lablel1.Text = "First Name";
            // 
            // FormAddCustomer
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 329);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtISBN);
            Controls.Add(btnCreateBook);
            Controls.Add(lablel1);
            Name = "FormAddCustomer";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label4;
        private TextBox txtPrice;
        private Label label2;
        private TextBox txtISBN;
        private Button btnCreateBook;
        private Label label3;
        private Label lablel1;
    }
}