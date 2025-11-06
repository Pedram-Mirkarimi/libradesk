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
    public partial class FrmUserAction : Form
    {
        public FrmUserAction()
        {
            InitializeComponent();
        }
        Database database = new Database();
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if(Text == "افزودن کاربر")
            {
                if (database.SelectCommand("insert into Users(fName, lName, phoneNumber) values(N'" + txtFName.Text + "', N'" + txtLName.Text + "', N'" + txtPhoneNumber.Text + "')") == true)
                {
                    txtCategory.Text = "";
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtPhoneNumber.Text = "";
                    MessageBox.Show(".اطلاعات کاربر با موفقیت ثبت شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if(Text == "ویرایش کاربر")
            {
                if (database.SelectCommand("update Users set fName = N'" + txtFName.Text + "', lName = N'" + txtLName.Text + "', phoneNumber = N'" + txtPhoneNumber.Text + "' where id = " + int.Parse(txtCategory.Text)) == true)
                {
                    txtCategory.Text = "";
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtPhoneNumber.Text = "";
                    MessageBox.Show(".اطلاعات کاربر با موفقیت ویرایش شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
