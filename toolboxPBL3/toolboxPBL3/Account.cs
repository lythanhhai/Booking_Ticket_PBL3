using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toolboxPBL3
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }
        public void Setaccount(string Name,string SDT)
        {
            lbnameaccount.Text= Name;
            lbsdt.Text = SDT;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
