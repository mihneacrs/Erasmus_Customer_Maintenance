using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS2022ENG
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void tblWorkerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblWorkerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cMS2022ENGDataSet);

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMS2022ENGDataSet.tblWorker' table. You can move, or remove it, as needed.
            this.tblWorkerTableAdapter.Fill(this.cMS2022ENGDataSet.tblWorker);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            tblWorkerBindingSource.EndEdit();
            tblWorkerTableAdapter.Update(cMS2022ENGDataSet.tblWorker);
            MessageBox.Show("The Worker table is updated.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cMS2022ENGDataSet.Clear();
            tblWorkerTableAdapter.Fill(cMS2022ENGDataSet.tblWorker);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tblWorkerBindingSource.RemoveCurrent();
            tblWorkerTableAdapter.Update(cMS2022ENGDataSet.tblWorker);
            MessageBox.Show("The row is deleted.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
