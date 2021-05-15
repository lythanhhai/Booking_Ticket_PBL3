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
    public partial class SearchTicket : UserControl
    {
        public SearchTicket()
        {
            InitializeComponent();
        }
        public void offtool()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            dateTimePicker1.Visible = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lbdiemden.Text != "Điểm đến" & lbdatdaudi.Text != "Bắt đầu"||(lbdiemden.Text != "Bắt đầu" & lbdatdaudi.Text != "Điểm đến"))
            {

                label27.Text = lbdiemden.Text;
                lbdiemden.Text = lbdatdaudi.Text;
                lbdatdaudi.Text = label27.Text;
            }
        }

        private void lbdatdaudi_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void lbdiemden_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            offtool();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            offtool();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Text != lbdiemden.Text)
                lbdatdaudi.Text = ((Label)sender).Text;
        }

        private void label23_Click(object sender, EventArgs e)
        {   
            if(((Label)sender).Text!=lbdatdaudi.Text)
            lbdiemden.Text= ((Label)sender).Text;
        }
    }
    
}
