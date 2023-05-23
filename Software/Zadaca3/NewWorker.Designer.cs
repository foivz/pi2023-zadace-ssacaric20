namespace Zadaca3
{
    partial class NewWorker
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
            btnSave = new Button();
            lblSurname = new Label();
            lblEmail = new Label();
            lblNumber = new Label();
            lblIBAN = new Label();
            lblHourly = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtNumber = new TextBox();
            txtIBAN = new TextBox();
            txtHourly = new TextBox();
            btnCancel = new Button();
            NewEntry = new Label();
            lblName = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(416, 426);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(103, 161);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(54, 15);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(103, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(103, 219);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(94, 15);
            lblNumber.TabIndex = 4;
            lblNumber.Text = "Contact number";
            // 
            // lblIBAN
            // 
            lblIBAN.AutoSize = true;
            lblIBAN.Location = new Point(103, 248);
            lblIBAN.Name = "lblIBAN";
            lblIBAN.Size = new Size(34, 15);
            lblIBAN.TabIndex = 5;
            lblIBAN.Text = "IBAN";
            // 
            // lblHourly
            // 
            lblHourly.AutoSize = true;
            lblHourly.Location = new Point(103, 277);
            lblHourly.Name = "lblHourly";
            lblHourly.Size = new Size(66, 15);
            lblHourly.TabIndex = 6;
            lblHourly.Text = "Hourly rate";
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 23);
            txtName.TabIndex = 8;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(203, 158);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(199, 23);
            txtSurname.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(203, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(203, 216);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(199, 23);
            txtNumber.TabIndex = 11;
            // 
            // txtIBAN
            // 
            txtIBAN.Location = new Point(203, 245);
            txtIBAN.Name = "txtIBAN";
            txtIBAN.Size = new Size(199, 23);
            txtIBAN.TabIndex = 12;
            // 
            // txtHourly
            // 
            txtHourly.Location = new Point(203, 274);
            txtHourly.Name = "txtHourly";
            txtHourly.Size = new Size(199, 23);
            txtHourly.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 426);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // NewEntry
            // 
            NewEntry.AutoSize = true;
            NewEntry.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NewEntry.Location = new Point(203, 36);
            NewEntry.Name = "NewEntry";
            NewEntry.Size = new Size(101, 28);
            NewEntry.TabIndex = 16;
            NewEntry.Text = "New entry";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(103, 132);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.Click += label1_Click;
            // 
            // NewWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 461);
            Controls.Add(NewEntry);
            Controls.Add(btnCancel);
            Controls.Add(txtHourly);
            Controls.Add(txtIBAN);
            Controls.Add(txtNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblHourly);
            Controls.Add(lblIBAN);
            Controls.Add(lblNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewWorker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewWorker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblSurname;
        private Label lblEmail;
        private Label lblNumber;
        private Label lblIBAN;
        private Label lblHourly;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtNumber;
        private TextBox txtIBAN;
        private TextBox txtHourly;
        private Button btnCancel;
        private Label NewEntry;
        private Label lblName;
    }
}