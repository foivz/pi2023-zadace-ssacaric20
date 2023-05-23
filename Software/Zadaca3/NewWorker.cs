using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zadaca3
{
    public partial class NewWorker : Form
    {
        public NewWorker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("You've left the name field of the new worker empty!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtSurname.Text == "")
            {
                MessageBox.Show("You've left the surname field of the new worker empty!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtSurname.Text == "")
            {
                MessageBox.Show("You've left the IBAN field empty!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtHourly.Text == "")
            {
                MessageBox.Show("You've left the Hourly rate field empty!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtNumber.Text == "")
            {
                MessageBox.Show("You've left the Contact number field empty!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else
            {
                if (txtName.Text != "" && txtSurname.Text != "" && txtIBAN.Text != "" && txtHourly.Text != "")
                {
                    MessageBox.Show("A new worker has been added!", "Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
