using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FrmDepository : Form
    {
        public FrmDepository()
        {
            InitializeComponent();
        }
        Database database = new Database();
        private void FrmDepository_Load(object sender, EventArgs e)
        {

        }

        private void txtBookId_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = database.Select("select id from Book where id = " + int.Parse(txtBookId.Text));
                if (dataTable.Rows.Count == 0)
                {
                    txtBookId.ForeColor = Color.Red;
                }
                else if (dataTable.Rows.Count == 1)
                {
                    txtBookId.ForeColor = Color.Green;
                }
            }
            catch
            {
                MessageBox.Show("!فیلد شناسه کتاب نمی تواند خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = database.Select("select id from Users where id = " + int.Parse(txtUserId.Text));
                if (dataTable.Rows.Count == 0)
                {
                    txtUserId.ForeColor = Color.Red;
                }
                else if (dataTable.Rows.Count == 1)
                {
                    txtUserId.ForeColor = Color.Green;
                }
            }
            catch
            {
                MessageBox.Show("!فیلد شناسه کاربر نمی تواند خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDateNow_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            txtDateNow.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString() + "-" + pc.GetHour(DateTime.Now).ToString() + ":" + pc.GetMinute(DateTime.Now).ToString() + ":" + pc.GetSecond(DateTime.Now).ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            int addMonth = DateTime.Now.Day - 10;
            if (addMonth > 0)
            {
                txtReturnDate.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now.AddMonths(1)).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now.AddDays(10)).ToString();
            }
            else
            {
                txtReturnDate.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now.AddDays(10)).ToString();
            }
        }
       
        private void btnSaveDepository_Click(object sender, EventArgs e)
        {
            if ((txtBookId.ForeColor == Color.Green && txtUserId.ForeColor == Color.Green) && (txtDateNow.Text != "" && txtReturnDate.Text != ""))
            {
                if (database.SelectCommand("insert into Depository(bookId, borrowerId, date, maxDate) values('" + int.Parse(txtBookId.Text) + "', '" + int.Parse(txtUserId.Text) + "', '" + txtDateNow.Text + "', '" + txtReturnDate.Text + "')") == true)
                {
                    txtBookId.Text = txtUserId.Text = txtDateNow.Text = txtReturnDate.Text = "";
                    MessageBox.Show(".اطلاعات امانت گیرنده کتاب با موفقیت ثبت شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
