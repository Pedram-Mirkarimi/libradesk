using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FrmAccountManagement : Form
    {
        public FrmAccountManagement()
        {
            InitializeComponent();
        }
        Database database = new Database();

        private void FrmAccountManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Depository' table. You can move, or remove it, as needed.
            this.depositoryTableAdapter.Fill(this.libraryDBDataSet.Depository);
            DataTable dataTable = new DataTable();
            dataTable = database.Select("select Depository.id, Depository.bookId, Depository.borrowerId, Depository.date, Depository.maxDate, Book.name, Users.fName, Users.lName from Book inner join Depository on Depository.bookId = Book.id inner join Users on Users.id = Depository.borrowerId");
            dgvManagement.DataSource = dataTable;

        }

        private void dgvManagement_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = database.Select("select id from Depository");
            if(dataTable.Rows.Count == 0)
            {
                MessageBox.Show("!کاربری، بدهکار نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtId.Text = dgvManagement.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FrmDepository frmDepository = new FrmDepository();
            frmDepository.ShowDialog();
            FrmAccountManagement_Load(sender, e);
        }


        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                database.SelectCommand("delete from Depository where id = " + int.Parse(txtId.Text));
                FrmAccountManagement_Load(sender, e);
                txtId.Text = "";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DataTable dataTable = new DataTable();
                string str = "";
                if (bookIdRdb.Checked)
                    str = "Book.id";
                else if (UserIdRdb.Checked)
                    str = "Users.id";
                dataTable = database.Select("select Depository.id, Depository.bookId, Depository.borrowerId, Depository.date, Depository.maxDate, Book.name, Users.fName, Users.lName from Book inner join Depository on Depository.bookId = Book.id inner join Users on Users.id = Depository.borrowerId and " + str + "=" + txtSearch.Text);
                dgvManagement.DataSource = dataTable;
            }
            else
            {
                FrmAccountManagement_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAccountManagement_Load(sender, e);
        }
    }
}
