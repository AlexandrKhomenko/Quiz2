namespace WindowsFormsApp1
{
    partial class Form1
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.clearForm = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(201, 88);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First  name";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(311, 85);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(134, 20);
            this.firstName.TabIndex = 1;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(201, 138);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last name";
            this.lastNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(311, 135);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(134, 20);
            this.lastName.TabIndex = 3;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(201, 186);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 4;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(311, 183);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(134, 20);
            this.phone.TabIndex = 5;
            // 
            // clearForm
            // 
            this.clearForm.Location = new System.Drawing.Point(204, 254);
            this.clearForm.Name = "clearForm";
            this.clearForm.Size = new System.Drawing.Size(92, 23);
            this.clearForm.TabIndex = 6;
            this.clearForm.Text = "Clear Form";
            this.clearForm.UseVisualStyleBackColor = true;
            this.clearForm.Click += new System.EventHandler(this.clearForm_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(204, 308);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(92, 23);
            this.Count.TabIndex = 8;
            this.Count.Text = "Count of users";
            this.Count.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(335, 308);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 23);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete Users";
            this.Delete.UseCompatibleTextRendering = true;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button4_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(335, 254);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(100, 23);
            this.Register.TabIndex = 10;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.clearForm);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Register;
    }
}

