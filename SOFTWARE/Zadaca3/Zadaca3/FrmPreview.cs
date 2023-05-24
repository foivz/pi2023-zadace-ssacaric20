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
using System.Data.SqlClient;

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
            /*WorkerRepository selectedWorker = dgvWorkers.CurrentRow.DataBoundItem as Worker;
            if (selectedWorker != null)
            {
                FrmEvaluation frmEvaluation = new FrmEvaluation(selectedStudent);
                frmEvaluation.ShowDialog();
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var form = new FrmFinalReport();
            form.ShowDialog();*/
        }
    }
    }
