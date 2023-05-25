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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Zadaca3
{
    public partial class FrmNewWorker : Form
    {

        public bool EditMode { get; set; }

        public FrmNewWorker()
        {
            InitializeComponent();
        }

        private void FrmNewWorker_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                btnAdd.Enabled = false;
            } else
            {
                btnEdit.Enabled = false;
            }
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

        public void ChangeWorkerData()
        {
            txtName.Text = SelectedWorker.Name.ToString();
            txtSurname.Text = SelectedWorker.Surname.ToString();    
            txtEmail.Text = SelectedWorker.Email.ToString();
            txtCnumber.Text = SelectedWorker.Cnumber.ToString();
            txtIBAN.Text = SelectedWorker.IBAN.ToString();
            txtHourly.Text = SelectedWorker.Hourly.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
