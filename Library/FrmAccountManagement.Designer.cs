namespace Library
{
    partial class FrmAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountManagement));
            this.dgvManagement = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new Library.libraryDBDataSet();
            this.depositoryTableAdapter = new Library.libraryDBDataSetTableAdapters.DepositoryTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.UserIdRdb = new System.Windows.Forms.RadioButton();
            this.bookIdRdb = new System.Windows.Forms.RadioButton();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManagement
            // 
            this.dgvManagement.AllowUserToAddRows = false;
            this.dgvManagement.AllowUserToDeleteRows = false;
            this.dgvManagement.AutoGenerateColumns = false;
            this.dgvManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.borrowerIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.maxDateDataGridViewTextBoxColumn});
            this.dgvManagement.DataSource = this.depositoryBindingSource;
            this.dgvManagement.Location = new System.Drawing.Point(12, 12);
            this.dgvManagement.Name = "dgvManagement";
            this.dgvManagement.ReadOnly = true;
            this.dgvManagement.Size = new System.Drawing.Size(760, 302);
            this.dgvManagement.TabIndex = 0;
            this.dgvManagement.Click += new System.EventHandler(this.dgvManagement_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "شناسه کتاب";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowerIdDataGridViewTextBoxColumn
            // 
            this.borrowerIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.borrowerIdDataGridViewTextBoxColumn.DataPropertyName = "borrowerId";
            this.borrowerIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.borrowerIdDataGridViewTextBoxColumn.HeaderText = "شناسه امانت گیرنده";
            this.borrowerIdDataGridViewTextBoxColumn.Name = "borrowerIdDataGridViewTextBoxColumn";
            this.borrowerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "تاریخ امانت";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDateDataGridViewTextBoxColumn
            // 
            this.maxDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxDateDataGridViewTextBoxColumn.DataPropertyName = "maxDate";
            this.maxDateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.maxDateDataGridViewTextBoxColumn.HeaderText = "تاریخ برگشت";
            this.maxDateDataGridViewTextBoxColumn.Name = "maxDateDataGridViewTextBoxColumn";
            this.maxDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depositoryBindingSource
            // 
            this.depositoryBindingSource.DataMember = "Depository";
            this.depositoryBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "libraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositoryTableAdapter
            // 
            this.depositoryTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.UserIdRdb);
            this.groupBox1.Controls.Add(this.bookIdRdb);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(6, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // UserIdRdb
            // 
            this.UserIdRdb.AutoSize = true;
            this.UserIdRdb.Location = new System.Drawing.Point(6, 30);
            this.UserIdRdb.Name = "UserIdRdb";
            this.UserIdRdb.Size = new System.Drawing.Size(88, 28);
            this.UserIdRdb.TabIndex = 1;
            this.UserIdRdb.Text = "شناسه کاربر";
            this.UserIdRdb.UseVisualStyleBackColor = true;
            // 
            // bookIdRdb
            // 
            this.bookIdRdb.AutoSize = true;
            this.bookIdRdb.Checked = true;
            this.bookIdRdb.Location = new System.Drawing.Point(100, 30);
            this.bookIdRdb.Name = "bookIdRdb";
            this.bookIdRdb.Size = new System.Drawing.Size(90, 28);
            this.bookIdRdb.TabIndex = 0;
            this.bookIdRdb.TabStop = true;
            this.bookIdRdb.Text = "شناسه کتاب";
            this.bookIdRdb.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(388, 350);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(149, 55);
            this.btnDeleteCategory.TabIndex = 8;
            this.btnDeleteCategory.Text = "حذف";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(233, 350);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(149, 55);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "اضافه";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(282, 319);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(197, 25);
            this.txtId.TabIndex = 9;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(543, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "تازه سازی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dgvManagement);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAccountManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت حساب";
            this.Load += new System.EventHandler(this.FrmAccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManagement;
        private libraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource depositoryBindingSource;
        private libraryDBDataSetTableAdapters.DepositoryTableAdapter depositoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UserIdRdb;
        private System.Windows.Forms.RadioButton bookIdRdb;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
    }
}