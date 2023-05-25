using Zadaca3.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca3.Models;

namespace Zadaca3
{
    public partial class FrmNewWorker : Form
    {
        public FrmNewWorker()
        {
            InitializeComponent();
        }

        private Worker worker;
        public Worker SelectedWorker { get => worker; set => worker = value; }
        public FrmNewWorker(Worker selectedWorker)
        {
            InitializeComponent();
            SelectedWorker = selectedWorker;

            if (selectedWorker == null)
            {
                this.Text = "New worker";
            } else
            {
                this.Text = "Edit existing worker";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string cnumber = txtCnumber.Text;
            string iban = txtIBAN.Text;
            int hourly = int.Parse(txtHourly.Text);

            Owner owner = new Owner();

            owner.CheckWorker(SelectedWorker, name, surname, email, cnumber, iban, hourly);

            FrmPreview frmPreview = new FrmPreview();
            this.Close();
        }
    }
}
