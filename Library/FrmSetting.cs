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
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }
        Database database = new Database();

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            txtLastDateOfBackup.Text = Properties.Settings.Default.lastBackup;
        }

        private void btnSaveUserPass_Click(object sender, EventArgs e)
        {
            string prevPassword = Properties.Settings.Default.password;
            if(txtPrevPassword.Text == prevPassword)
            {
                Properties.Settings.Default.password = txtNewPassword.Text;
                Properties.Settings.Default.Save();
                txtPrevPassword.Text = txtNewPassword.Text = "";
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save";
            sfd.Filter = "Backup File (*.bak)|*.bak";
            sfd.OverwritePrompt = true;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                if(database.SelectCommand("backup database libraryDB to disk ='"+ sfd.FileName +"'") == true)
                {
                    MessageBox.Show(".پشتیبان گیری با موفقیت انجام شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.lastBackup = DateTime.Now.ToShortTimeString() + "    " + DateTime.Now.ToShortDateString();
                    Properties.Settings.Default.Save();
                    FrmSetting_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("!پشتیبان گیری با موفقیت انجام نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReturnBackup_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Browse";
            op.Filter = "Backup File (*.bak)|*.bak";
            if(op.ShowDialog() == DialogResult.OK)
            {
                if(database.SelectCommand("alter database libraryDB set single_user with rollback immediate use master restore database libraryDB from disk = '"+op.FileName+"' with replace") == true)
                {
                    MessageBox.Show(".بازگردانی فایل پشتیبان با موفقیت انجام شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("!بازگردانی فایل پشتیبان با موفقیت انجام نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
