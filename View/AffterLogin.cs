using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_DATVEXE.View
{
    public partial class AffterLogin : Form
    {
        public AffterLogin()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void AffterLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sss");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

       

        private void lbbatdaudi_Click(object sender, EventArgs e)
        {
                panel1.Visible = true;
                panel2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            dateTimePicker1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lbdiemden.Text != "Điểm đến" && lbdatdaudi.Text != "Bắt đầu")
            {
                lbhoandoi.Text = lbdiemden.Text;
                lbdiemden.Text = lbdatdaudi.Text;
                lbdatdaudi.Text = lbhoandoi.Text;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Text != lbdiemden.Text){
                lbdatdaudi.Text = ((Label)sender).Text; }
        }

        private void label26_Click(object sender, EventArgs e)
        {  if(((Label)sender).Text!=lbdatdaudi.Text)
            lbdiemden.Text = ((Label)sender).Text;
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbchonngay.Text = dateTimePicker1.Value.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
