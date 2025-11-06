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
    public partial class FrmGenre : Form
    {
        public FrmGenre()
        {
            InitializeComponent();
        }
        Database database = new Database();
        private void FrmGenre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.libraryDBDataSet.Genre);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (database.SelectCommand("insert into Genre(genre) values(N'" + txtCategoryName.Text + "')") == true)
            {
                txtCategoryName.Text = "";
                FrmGenre_Load(sender, e);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(dgvGenre.CurrentRow.Cells[0].Value.ToString());
            if (database.SelectCommand("delete from Genre where id = " + id) == true)
            {
                txtCategoryName.Text = "";
                FrmGenre_Load(sender, e);
            }
        }

        private void dgvGenre_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = database.Select("select id from Genre");
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("!ژانری جهت انتخاب موجود نمی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtCategoryName.Text = dgvGenre.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
