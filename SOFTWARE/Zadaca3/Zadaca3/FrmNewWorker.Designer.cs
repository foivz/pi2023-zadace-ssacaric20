namespace Zadaca3
{
    partial class FrmNewWorker
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCnumber = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtHourly = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCnumber = new System.Windows.Forms.Label();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblHourly = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNewWorker = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(112, 91);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(199, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtCnumber
            // 
            this.txtCnumber.Location = new System.Drawing.Point(112, 175);
            this.txtCnumber.Name = "txtCnumber";
            this.txtCnumber.Size = new System.Drawing.Size(199, 20);
            this.txtCnumber.TabIndex = 4;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(112, 217);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(199, 20);
            this.txtIBAN.TabIndex = 5;
            // 
            // txtHourly
            // 
            this.txtHourly.Location = new System.Drawing.Point(112, 259);
            this.txtHourly.Name = "txtHourly";
            this.txtHourly.Size = new System.Drawing.Size(199, 20);
            this.txtHourly.TabIndex = 6;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(24, 94);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblCnumber
            // 
            this.lblCnumber.AutoSize = true;
            this.lblCnumber.Location = new System.Drawing.Point(24, 178);
            this.lblCnumber.Name = "lblCnumber";
            this.lblCnumber.Size = new System.Drawing.Size(82, 13);
            this.lblCnumber.TabIndex = 9;
            this.lblCnumber.Text = "Contact number";
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.Location = new System.Drawing.Point(24, 220);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(32, 13);
            this.lblIBAN.TabIndex = 10;
            this.lblIBAN.Text = "IBAN";
            // 
            // lblHourly
            // 
            this.lblHourly.AutoSize = true;
            this.lblHourly.Location = new System.Drawing.Point(24, 262);
            this.lblHourly.Name = "lblHourly";
            this.lblHourly.Size = new System.Drawing.Size(58, 13);
            this.lblHourly.TabIndex = 11;
            this.lblHourly.Text = "Hourly rate";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(276, 375);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(357, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNewWorker
            // 
            this.lblNewWorker.AutoSize = true;
            this.lblNewWorker.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewWorker.Location = new System.Drawing.Point(180, 47);
            this.lblNewWorker.Name = "lblNewWorker";
            this.lblNewWorker.Size = new System.Drawing.Size(84, 18);
            this.lblNewWorker.TabIndex = 15;
            this.lblNewWorker.Text = "Worker data";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblHourly);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.lblIBAN);
            this.panel1.Controls.Add(this.txtCnumber);
            this.panel1.Controls.Add(this.lblCnumber);
            this.panel1.Controls.Add(this.txtIBAN);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtHourly);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Location = new System.Drawing.Point(54, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 313);
            this.panel1.TabIndex = 16;
            // 
            // FrmNewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 410);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNewWorker);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNewWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new worker";
            this.Load += new System.EventHandler(this.FrmNewWorker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCnumber;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtHourly;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCnumber;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblHourly;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNewWorker;
        private System.Windows.Forms.Panel panel1;
    }
}