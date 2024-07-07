namespace CMS2022ENG
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label carNoLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label makeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.cMS2022ENGDataSet = new CMS2022ENG.CMS2022ENGDataSet();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new CMS2022ENG.CMS2022ENGDataSetTableAdapters.tblCustomerTableAdapter();
            this.tableAdapterManager = new CMS2022ENG.CMS2022ENGDataSetTableAdapters.TableAdapterManager();
            this.tblCustomerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblCustomerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carNoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.btnWord = new System.Windows.Forms.Button();
            carNoLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cMS2022ENGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingNavigator)).BeginInit();
            this.tblCustomerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // carNoLabel
            // 
            carNoLabel.AutoSize = true;
            carNoLabel.Location = new System.Drawing.Point(7, 31);
            carNoLabel.Name = "carNoLabel";
            carNoLabel.Size = new System.Drawing.Size(43, 13);
            carNoLabel.TabIndex = 1;
            carNoLabel.Text = "Car No:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(7, 57);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(7, 83);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(42, 13);
            adressLabel.TabIndex = 5;
            adressLabel.Text = "Adress:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(7, 109);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 7;
            makeLabel.Text = "Make:";
            // 
            // cMS2022ENGDataSet
            // 
            this.cMS2022ENGDataSet.DataSetName = "CMS2022ENGDataSet";
            this.cMS2022ENGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.cMS2022ENGDataSet;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCustomerTableAdapter = this.tblCustomerTableAdapter;
            this.tableAdapterManager.tblJobDetailsTableAdapter = null;
            this.tableAdapterManager.tblWorkerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CMS2022ENG.CMS2022ENGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCustomerBindingNavigator
            // 
            this.tblCustomerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblCustomerBindingNavigator.BindingSource = this.tblCustomerBindingSource;
            this.tblCustomerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCustomerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblCustomerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblCustomerBindingNavigatorSaveItem});
            this.tblCustomerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCustomerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCustomerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCustomerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCustomerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCustomerBindingNavigator.Name = "tblCustomerBindingNavigator";
            this.tblCustomerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCustomerBindingNavigator.Size = new System.Drawing.Size(489, 25);
            this.tblCustomerBindingNavigator.TabIndex = 0;
            this.tblCustomerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblCustomerBindingNavigatorSaveItem
            // 
            this.tblCustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblCustomerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblCustomerBindingNavigatorSaveItem.Image")));
            this.tblCustomerBindingNavigatorSaveItem.Name = "tblCustomerBindingNavigatorSaveItem";
            this.tblCustomerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblCustomerBindingNavigatorSaveItem.Text = "Save Data";
            this.tblCustomerBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblCustomerBindingNavigatorSaveItem_Click);
            // 
            // carNoTextBox
            // 
            this.carNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "CarNo", true));
            this.carNoTextBox.Location = new System.Drawing.Point(56, 28);
            this.carNoTextBox.Name = "carNoTextBox";
            this.carNoTextBox.Size = new System.Drawing.Size(367, 20);
            this.carNoTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(56, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(367, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(56, 80);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(367, 20);
            this.adressTextBox.TabIndex = 6;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(56, 106);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(367, 20);
            this.makeTextBox.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(267, 163);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(105, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(24, 163);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(56, 212);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(316, 209);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(105, 282);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(156, 20);
            this.textSearch.TabIndex = 18;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(87, 309);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(271, 150);
            this.dataGridViewSearch.TabIndex = 19;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(219, 465);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(139, 23);
            this.btnWord.TabIndex = 20;
            this.btnWord.Text = "Export to Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 538);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(carNoLabel);
            this.Controls.Add(this.carNoTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.tblCustomerBindingNavigator);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cMS2022ENGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingNavigator)).EndInit();
            this.tblCustomerBindingNavigator.ResumeLayout(false);
            this.tblCustomerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CMS2022ENGDataSet cMS2022ENGDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private CMS2022ENGDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private CMS2022ENGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblCustomerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox carNoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Button btnWord;
    }
}