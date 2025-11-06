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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            if (txtPassword.Text == Properties.Settings.Default.password)
            {
                frmMenu.ShowDialog();
                this.Hide();
            }
            else
            {
                txtPassword.Text = "";
                lblWrongUser.Visible = true;

            }
        }
    }
}
