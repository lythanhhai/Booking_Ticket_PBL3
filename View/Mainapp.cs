using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolboxPBL3;

namespace PBL3_DATVEXE.View
{
    public partial class Mainapp : Form
    {
        public Mainapp()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            gbtaikhoan.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gbtaikhoan.Visible = false;
            gbtimve.Visible = true;
            
        }
        
    }
}
