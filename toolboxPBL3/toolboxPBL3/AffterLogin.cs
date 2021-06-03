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
    public partial class AffterLogin : UserControl
    {
        public AffterLogin()
        {
            InitializeComponent();
        }

       

        private void btsearch_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Location = new Point(457, 0);
            label1.Location = new Point(177, 60);
        }
    }
}
