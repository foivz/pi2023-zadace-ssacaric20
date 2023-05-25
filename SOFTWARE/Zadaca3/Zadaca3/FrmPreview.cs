using Zadaca3.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

using Zadaca3.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Zadaca3
{
    public partial class FrmPreview : Form
    {
        public FrmPreview()
        {
            InitializeComponent();
        }

        private void FrmPreview_Load(object sender, EventArgs e)
        {
            ShowWorkers();
        }

        private void ShowWorkers()
        {
            var workers = WorkerRepository.GetWorkers();
            dgvWorkers.DataSource = workers;

            dgvWorkers.Columns["Id"].DisplayIndex = 0;
            dgvWorkers.Columns["Name"].DisplayIndex = 1;
            dgvWorkers.Columns["Surname"].DisplayIndex = 2;
            dgvWorkers.Columns["Email"].DisplayIndex = 3;
            dgvWorkers.Columns["Cnumber"].DisplayIndex = 4;
            dgvWorkers.Columns["IBAN"].DisplayIndex = 5;
            dgvWorkers.Columns["Hourly"].DisplayIndex = 6;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new FrmNewWorker();

            form.ShowDialog();
            ShowWorkers();
        }

        private void FrmNewWorker_UpdateFrmPreview(object sender, EventArgs e)
        {
            ShowWorkers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Worker selectedWorker = dgvWorkers.CurrentRow.DataBoundItem as Worker;
            if (selectedWorker != null)
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you would like to delete this worker from the database {0} {1}?", selectedWorker.Name, selectedWorker.Surname), "Deleting", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Owner owner = new Owner();
                    owner.DeleteWorker(selectedWorker.Id);
                    ShowWorkers();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Worker selectedWorker = dgvWorkers.CurrentRow.DataBoundItem as Worker;
            if (selectedWorker != null)
            {
                FrmNewWorker frmNewWorker = new FrmNewWorker(selectedWorker);
                frmNewWorker.ChangeWorkerData();

                frmNewWorker.ShowDialog();
                ShowWorkers();

            }
        }
    }
}
