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
    public partial class FrmPreview : Form
    {
        public FrmPreview()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmNewWorker frmNewWorker = new FrmNewWorker();
            frmNewWorker.ShowDialog();
        }

        private void FrmPreview_Load(object sender, EventArgs e)
        {
            ShowWorkers();
        }

        private void ShowWorkers()
        {
            List<WorkerRepository> workers = WorkerRepository.GetWorkers();
            dgvWorkers.DataSource = workers;

            dgvWorkers.Columns["Id"].DisplayIndex = 0;
        }
    }
}
