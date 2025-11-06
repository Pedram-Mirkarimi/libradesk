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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        Database database = new Database();

        public void FrmMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Depository' table. You can move, or remove it, as needed.
            this.depositoryTableAdapter.Fill(this.libraryDBDataSet.Depository);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FrmBook frmBook = new FrmBook();
            frmBook.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            FrmDepository frmDepository = new FrmDepository();
            frmDepository.ShowDialog();
        }

        private void btnMangement_Click(object sender, EventArgs e)
        {
            FrmAccountManagement frmAccountManagement = new FrmAccountManagement();
            frmAccountManagement.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting frmSetting = new FrmSetting();
            frmSetting.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = database.Select("select * from Book");
            lblBookCount.Text = dt.Rows.Count.ToString();
            //dt.Reset();
            //dt = database.Select("select * from User");
            //lblUserCount.Text = dt.Rows.Count.ToString();
            PersianCalendar pc = new PersianCalendar();
            string nowDate = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
            lblDate.Text = nowDate;
            string nowTime = pc.GetHour(DateTime.Now).ToString() + ":" + pc.GetMinute(DateTime.Now).ToString() + ":" + pc.GetSecond(DateTime.Now).ToString();
            lblTime.Text = nowTime;
        }

        private void btnRefreshMenu_Click(object sender, EventArgs e)
        {
            FrmMenu_Load(sender, e);
        }
    }
}
