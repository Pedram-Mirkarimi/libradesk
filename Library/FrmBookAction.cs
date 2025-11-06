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
    public partial class FrmBookAction : Form
    {
        public FrmBookAction()
        {
            InitializeComponent();
        }
        Database database = new Database();
        private void FrmBookAction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.libraryDBDataSet.Genre);
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (this.Text == "اضافه کردن کتاب")
            {
                id = int.Parse(dgvGenre.CurrentRow.Cells[0].Value.ToString());
                if (database.SelectCommand("insert into Book(name, writer, genre) values(N'" + txtBookName.Text + "', N'" + txtWriterName.Text + "', '" + id + "')") == true)
                {
                    txtBookName.Text = "";
                    txtWriterName.Text = "";
                    txtCategory.Text = "";
                    MessageBox.Show(".اطلاعات کتاب با موفقیت ثبت شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                id = int.Parse(dgvGenre.CurrentRow.Cells[0].Value.ToString());
                if (database.SelectCommand("update Book set name= N'" + txtBookName.Text + "', writer = N'" + txtWriterName.Text + "', genre = '" + id + "' where id = '" + int.Parse(txtCategory.Text) + "'") == true)
                {
                    txtBookName.Text = "";
                    txtWriterName.Text = "";
                    txtCategory.Text = "";
                    MessageBox.Show(".اطلاعات کتاب با موفقیت ویرایش شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
