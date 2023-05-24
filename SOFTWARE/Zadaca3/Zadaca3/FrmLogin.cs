using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca3
{
    public partial class FrmLogin : Form
    {
        string username = "vlasnica";
        string password = "ovonijepassword";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("You must unter a username to login.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "")
            {
                MessageBox.Show("You must enter a password to login.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    FrmPreview frmPreview = new FrmPreview();
                    Hide();
                    frmPreview.ShowDialog();
                    Close();
                } else
                {
                    MessageBox.Show("The credentials you've entered are incorrect.", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
