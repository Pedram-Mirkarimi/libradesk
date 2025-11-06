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
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
        }
        Database database = new Database();
        private void FrmBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDBDataSet.Book);
            tvBook.Nodes.Clear();
            DataTable dataTable = new DataTable();
            dataTable = database.Select("select Book.id, Book.name, Book.writer, Genre.genre from Book inner join Genre on Book.genre = Genre.id");
            dgvBook.DataSource = dataTable;
            dataTable = database.Select("select * from Genre");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                tvBook.Nodes.Add(dataTable.Rows[i].ItemArray[1].ToString());
            }
            //dataTable.Reset();
            //dataTable = database.Select("select * from Book");
            //int id = 0;
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    id = (int)dataTable.Rows[i].ItemArray[3];
            //    tvBook.Nodes[id].Nodes.Add(dataTable.Rows[i].ItemArray[1].ToString());
            //}
        }

        private void btnCategoryPlus_Click(object sender, EventArgs e)
        {
            FrmGenre frmGenre = new FrmGenre();
            frmGenre.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBookAction frmBookAction = new FrmBookAction();
            frmBookAction.Text = "اضافه کردن کتاب";
            frmBookAction.ShowDialog();
            FrmBook_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmBookAction frmBookAction = new FrmBookAction();
            frmBookAction.Text = "ویرایش کتاب";
            frmBookAction.txtBookName.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
            frmBookAction.txtWriterName.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            frmBookAction.txtCategory.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            frmBookAction.ShowDialog();
            FrmBook_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            int id;
            id = int.Parse(dgvBook.CurrentRow.Cells[0].Value.ToString());
            dataTable = database.Select("select * from Depository where bookId = " + id);
            if(dataTable.Rows.Count == 0)
            {
                if (database.SelectCommand("delete from Book where id = " + id) == true)
                {
                    FrmBook_Load(sender, e);
                    MessageBox.Show(".اطلاعات کتاب با موفقیت حذف شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("!کتاب موردنظر در امانت است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            String colName = "";
            if (rdbBook.Checked == true)
            {
                colName = "name";
            }
            else if (rdbWriter.Checked == true)
            {
                colName = "writer";
            }
            dataTable = database.Select("select Book.id, Book.name, Book.writer, Genre.genre from Book inner join Genre on Book.genre = Genre.id and " + colName + " like '%' + N'" + txtSearch.Text + "' +'%'");
            dgvBook.DataSource = dataTable;
        }
    }
}
