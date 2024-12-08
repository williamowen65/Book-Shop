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
            label4 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            btnCreateCustomer = new Button();
            lablel1 = new Label();
            dobInput = new DateTimePicker();
            txtTitle = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 247);
            label4.Name = "label4";
            label4.Size = new Size(184, 41);
            label4.TabIndex = 12;
            label4.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(210, 168);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(394, 47);
            txtLastName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 174);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(210, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(394, 47);
            txtFirstName.TabIndex = 9;
            // 
            // btnCreateCustomer
            // 
            btnCreateCustomer.Location = new Point(74, 315);
            btnCreateCustomer.Name = "btnCreateCustomer";
            btnCreateCustomer.Size = new Size(509, 58);
            btnCreateCustomer.TabIndex = 8;
            btnCreateCustomer.Text = "Add Customer to Store";
            btnCreateCustomer.UseVisualStyleBackColor = true;
            btnCreateCustomer.Click += btnCreateCustomer_Click;
            // 
            // lablel1
            // 
            lablel1.AutoSize = true;
            lablel1.Location = new Point(24, 101);
            lablel1.Name = "lablel1";
            lablel1.Size = new Size(160, 41);
            lablel1.TabIndex = 7;
            lablel1.Text = "First Name";
            // 
            // dobInput
            // 
            dobInput.Format = DateTimePickerFormat.Short;
            dobInput.Location = new Point(214, 241);
            dobInput.Name = "dobInput";
            dobInput.Size = new Size(390, 47);
            dobInput.TabIndex = 13;
            dobInput.Value = new DateTime(2024, 12, 8, 9, 3, 4, 0);
            dobInput.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(214, 18);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(387, 47);
            txtTitle.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(74, 41);
            label1.TabIndex = 14;
            label1.Text = "Title";
            // 
            // FormAddCustomer
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 410);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(dobInput);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(btnCreateCustomer);
            Controls.Add(lablel1);
            Name = "FormAddCustomer";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Button btnCreateCustomer;
        private Label label3;
        private Label lablel1;
        private DateTimePicker dobInput;
        private TextBox txtTitle;
    }
}