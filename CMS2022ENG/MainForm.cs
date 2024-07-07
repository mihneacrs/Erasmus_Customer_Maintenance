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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm newForm = new WorkerForm();
            newForm.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm newForm = new CustomerForm();
            newForm.ShowDialog();
        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobDetailsForm newForm = new JobDetailsForm();
            newForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
