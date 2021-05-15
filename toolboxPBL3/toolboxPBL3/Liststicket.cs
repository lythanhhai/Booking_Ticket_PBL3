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
    public partial class Liststicket : UserControl
    {
        public Liststicket()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sticket sticket1 = new Sticket();
            flowLayoutPanel1.Controls.Add(sticket1);
        }
        public void GetListSticket(List<ViewSticket> s)
        {
            foreach (ViewSticket i in s)
            {
                Sticket sticket1 = new Sticket();
                sticket1.SetSticket(i);
                flowLayoutPanel1.Controls.Add(sticket1);
            }
        }
    }
   
}
