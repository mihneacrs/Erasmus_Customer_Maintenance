﻿using System;
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
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void tblJobDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblJobDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cMS2022ENGDataSet);

        }

        private void JobDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMS2022ENGDataSet.tblJobDetails' table. You can move, or remove it, as needed.
            this.tblJobDetailsTableAdapter.Fill(this.cMS2022ENGDataSet.tblJobDetails);

        }
    }
}
