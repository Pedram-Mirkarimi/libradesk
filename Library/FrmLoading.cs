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
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrmLogIn frmLogIn = new FrmLogIn();
            cp.Value += 10;
            if (cp.Value == 100)
            {
                timer1.Stop();
                frmLogIn.ShowDialog();
                this.Close();
            }
        }
    }
}
