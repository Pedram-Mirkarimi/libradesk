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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }
        FrmUserAction frmUserAction = new FrmUserAction();
        Database database = new Database();
        private void FrmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this.libraryDBDataSet2.Users);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmUserAction.Text = "افزودن کاربر";
            frmUserAction.ShowDialog();
            FrmUser_Load(sender, e);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmUserAction.Text = "ویرایش کاربر";
            frmUserAction.txtCategory.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            frmUserAction.txtFName.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            frmUserAction.txtLName.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            frmUserAction.txtPhoneNumber.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            frmUserAction.ShowDialog();
            FrmUser_Load(sender, e);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvUser.CurrentRow.Cells[0].Value.ToString());
            DataTable dataTable = new DataTable();
            dataTable = database.Select("select * from Depository where borrowerId = " + id);
            if (dataTable.Rows.Count == 0)
            {
                if (database.SelectCommand("delete from Users where id=" + id) == true)
                {
                    FrmUser_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("!کاربر مورد نظر بدهکار است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string strName = "";
            if (rdbName.Checked)
            {
                strName = "fName";
            }
            else if (rdbFamily.Checked)
            {
                strName = "lName";
            }
            dataTable = database.Select("select id, fName, lName, phoneNumber from Users where " + strName + " like '%' + N'" + txtSearch.Text + "'+ '%'");
            dgvUser.DataSource = dataTable;
        }
    }
}
