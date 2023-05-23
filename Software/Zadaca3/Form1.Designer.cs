namespace Zadaca3
{
    partial class Form1
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

        //test
        //omg

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvZaposlenici = new DataGridView();
            btnNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvZaposlenici).BeginInit();
            SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            dgvZaposlenici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZaposlenici.Location = new Point(37, 12);
            dgvZaposlenici.Name = "dgvZaposlenici";
            dgvZaposlenici.RowTemplate.Height = 25;
            dgvZaposlenici.Size = new Size(998, 316);
            dgvZaposlenici.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(960, 422);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 1;
            btnNew.Text = "Add";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 470);
            Controls.Add(btnNew);
            Controls.Add(dgvZaposlenici);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvZaposlenici).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvZaposlenici;
        private Button btnNew;
    }
}